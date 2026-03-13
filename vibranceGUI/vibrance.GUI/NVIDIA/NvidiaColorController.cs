using System;
using System.Runtime.InteropServices;
using vibrance.GUI.common;

namespace vibrance.GUI.NVIDIA
{
    /// <summary>
    /// Authentic NVAPI bridge.
    /// v1.0.7 (Authentic Probe) - Exhaustive Hardware ID Search.
    /// </summary>
    internal static class NvidiaColorController
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
        private static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr QueryInterface_t(uint id);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int EnumDisplay_t(uint index, ref IntPtr hDisp);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int SetGammaRamp_t(IntPtr hDisp, ref GammaRamp_t ramp);

        [StructLayout(LayoutKind.Sequential)]
        public struct GammaRamp_t
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public ushort[] Red;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public ushort[] Green;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public ushort[] Blue;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct NV_COLOR_CONTROL_V1
        {
            public uint version;      // struct size | (1u << 16)
            public int brightness;    // -100 to 100
            public int contrast;      // -100 to 100
            public int hue;           // 0 to 359
            public int saturation;    // 0 to 200 (100 = default)
            public int gamma;         // 50 to 500 (100 = 1.0)
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int ColorControl_t(IntPtr hDisp, ref NV_COLOR_CONTROL_V1 info);

        // Exhaustive probe list for ANY active slider interface
        private static readonly uint[] CandidateGetColor = {
            0x9A1B9365, 0x351221D2, 0x94D28D05, 0x7B6FD8D5, 0x61B9235C, 0xA48D1485, 0x09246688
        };
        private static readonly uint[] CandidateSetColor = {
            0x1E0FD897, 0x2D77C9B1, 0x20875A66, 0x3F6F8D0, 0x6BEF0C63, 0xE4FBFB9C, 0x4A82D9A8, 0x53B0A33D
        };

        private static bool _initDone  = false;
        private static bool _available = false;
        private static IntPtr _hDisp   = IntPtr.Zero;
        private static ColorControl_t _getColor;
        private static ColorControl_t _setColor;
        private static SetGammaRamp_t _setRamp;
        private static NV_COLOR_CONTROL_V1 _original;
        private static bool _hasOriginal;

        public static bool IsAvailable => _available;

        public static bool TryInit()
        {
            VibranceGUI.Log("v1.0.7 Authentic Probe STARTING...");
            if (_initDone) return _available;
            _initDone = true;

            try
            {
                IntPtr hNvapi = GetModuleHandle("nvapi.dll");
                if (hNvapi == IntPtr.Zero) hNvapi = LoadLibrary("nvapi.dll");
                VibranceGUI.Log($"[NVAPI] hMod=0x{hNvapi.ToInt64():X}");
                if (hNvapi == IntPtr.Zero) return false;

                IntPtr qiPtr = GetProcAddress(hNvapi, "nvapi_QueryInterface");
                VibranceGUI.Log($"[NVAPI] QI=0x{qiPtr.ToInt64():X}");
                if (qiPtr == IntPtr.Zero) return false;

                var qi = Marshal.GetDelegateForFunctionPointer<QueryInterface_t>(qiPtr);

                // Get display handle
                IntPtr pEnum = qi(0x9ABDD40D);
                if (pEnum == IntPtr.Zero) return false;

                var enumFn = Marshal.GetDelegateForFunctionPointer<EnumDisplay_t>(pEnum);
                IntPtr h = IntPtr.Zero;
                if (enumFn(0, ref h) != 0 || h == IntPtr.Zero) return false;
                _hDisp = h;

                // Probe candidates
                IntPtr pGet = IntPtr.Zero;
                uint foundGetId = 0;
                foreach (uint id in CandidateGetColor)
                {
                    IntPtr p = qi(id);
                    VibranceGUI.Log($"[NVAPI] Probe GetColor 0x{id:X8} => 0x{p.ToInt64():X}");
                    if (p != IntPtr.Zero && pGet == IntPtr.Zero) { pGet = p; foundGetId = id; }
                }

                IntPtr pSet = IntPtr.Zero;
                uint foundSetId = 0;
                foreach (uint id in CandidateSetColor)
                {
                    IntPtr p = qi(id);
                    VibranceGUI.Log($"[NVAPI] Probe SetColor 0x{id:X8} => 0x{p.ToInt64():X}");
                    if (p != IntPtr.Zero && pSet == IntPtr.Zero) { pSet = p; foundSetId = id; }
                }

                if (pGet != IntPtr.Zero && pSet != IntPtr.Zero)
                {
                    _getColor = Marshal.GetDelegateForFunctionPointer<ColorControl_t>(pGet);
                    _setColor = Marshal.GetDelegateForFunctionPointer<ColorControl_t>(pSet);
                    VibranceGUI.Log($"[NVAPI] AUTHENTIC: Get=0x{foundGetId:X8} Set=0x{foundSetId:X8}");
                    
                    var orig = MakeInfo();
                    if (_getColor(_hDisp, ref orig) == 0) { _original = orig; _hasOriginal = true; }
                    _available = true;
                }
                else
                {
                    VibranceGUI.Log($"[NVAPI] FAILED to find authentic IDs. GetFound={foundGetId:X} SetFound={foundSetId:X}");
                }

                return _available;
            }
            catch (Exception ex)
            {
                VibranceGUI.Log($"[NVAPI] TryInit Error: {ex.Message}");
                return false;
            }
        }

        public static bool SetGammaAndBrightness(float gammaScalar, int shadowBoost)
        {
            if (!_available) return false;
            try
            {
                var info = MakeInfo();
                _getColor(_hDisp, ref info);
                info.gamma = (int)Math.Max(50, Math.Min(480, (int)Math.Round(gammaScalar * 100)));
                info.brightness = (int)Math.Max(-100, Math.Min(100, shadowBoost));
                info.contrast = 0;
                int r = _setColor(_hDisp, ref info);
                VibranceGUI.Log($"[NVAPI] SetAuthentic result={r} Gamma={info.gamma} Bright={info.brightness}");
                return r == 0;
            }
            catch { return false; }
        }

        public static bool SetDirectRamp(ushort[] red, ushort[] green, ushort[] blue)
        {
            if (!_available || _setRamp == null) return false;
            try
            {
                GammaRamp_t ramp = new GammaRamp_t { Red = red, Green = green, Blue = blue };
                return _setRamp(_hDisp, ref ramp) == 0;
            }
            catch { return false; }
        }

        public static bool RestoreOriginal()
        {
            if (!_available || !_hasOriginal) return false;
            try
            {
                var info = _original;
                return _setColor(_hDisp, ref info) == 0;
            }
            catch { return false; }
        }

        private static NV_COLOR_CONTROL_V1 MakeInfo()
        {
            var i = new NV_COLOR_CONTROL_V1();
            i.version = (uint)Marshal.SizeOf(i) | (1u << 16);
            return i;
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr LoadLibrary(string lpFileName);
    }
}
