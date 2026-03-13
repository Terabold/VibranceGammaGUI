using System;
using System.Runtime.InteropServices;

namespace vibrance.GUI.common
{
    /// <summary>
    /// Uses magnification.dll (MagSetColorEffect) to apply color transformations.
    /// This sits above the standard gamma ramp and is almost never blocked by drivers.
    /// </summary>
    public static class MagnificationController
    {
        [DllImport("magnification.dll", SetLastError = true)]
        private static extern bool MagInitialize();

        [DllImport("magnification.dll", SetLastError = true)]
        private static extern bool MagUninitialize();

        [DllImport("magnification.dll", SetLastError = true)]
        private static extern bool MagSetColorEffect(IntPtr hwnd, ref MAGCOLOREFFECT pEffect);

        [StructLayout(LayoutKind.Sequential)]
        private struct MAGCOLOREFFECT
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
            public float[] transform;
        }

        private static bool _initialized = false;
        private static readonly float[] _identity = new float[] {
            1f, 0f, 0f, 0f, 0f,
            0f, 1f, 0f, 0f, 0f,
            0f, 0f, 1f, 0f, 0f,
            0f, 0f, 0f, 1f, 0f,
            0f, 0f, 0f, 0f, 1f
        };

        public static bool Init()
        {
            if (_initialized) return true;
            try {
                _initialized = MagInitialize();
                return _initialized;
            } catch { return false; }
        }

        /// <summary>
        /// Applies brightness and gamma via color matrix.
        /// </summary>
        public static bool Apply(float gamma, int shadowBoost)
        {
            if (!Init()) return false;

            // Simple mapping: 
            // Brightness (Shadow Boost 0-100) -> 1.0 to 1.5 multiplier on rgb diagonals
            float b = 1.0f + (shadowBoost / 200f); 
            
            // Gamma approximation in matrix (limited to linear scaling here for simplicity, 
            // but we can adjust contrast/offset).
            float g = gamma;

            float[] matrix = new float[] {
                b * g, 0f,    0f,    0f, 0f,
                0f,    b * g, 0f,    0f, 0f,
                0f,    0f,    b * g, 0f, 0f,
                0f,    0f,    0f,    1f, 0f,
                0f,    0f,    0f,    0f, 1f
            };

            var effect = new MAGCOLOREFFECT { transform = matrix };
            return MagSetColorEffect(IntPtr.Zero, ref effect);
        }

        public static bool Restore()
        {
            if (!Init()) return false;
            var effect = new MAGCOLOREFFECT { transform = _identity };
            return MagSetColorEffect(IntPtr.Zero, ref effect);
        }

        public static void Shutdown()
        {
            if (_initialized) {
                Restore();
                MagUninitialize();
                _initialized = false;
            }
        }
    }
}
