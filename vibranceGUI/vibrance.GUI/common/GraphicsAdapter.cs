using System;
using System.IO;
using System.Runtime.InteropServices;
using vibrance.GUI.NVIDIA;

namespace vibrance.GUI.common
{
    public enum GraphicsAdapter
    {
        Unknown = 0,
        Nvidia = 1
    }

    public class GraphicsAdapterHelper
    {

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr LoadLibrary(string dllToLoad);

        private const string _nvidiaDllName = "nvapi.dll";

        public static GraphicsAdapter GetAdapter()
        {
            if (IsAdapterAvailable(_nvidiaDllName))
            {
                return GraphicsAdapter.Nvidia;
            }
            return GraphicsAdapter.Unknown;
        }

        private static bool IsAdapterAvailable(string dllName)
        {
            try
            {
                return LoadLibrary(dllName) != IntPtr.Zero;
            }
            catch (Exception)
            {
                return false;
            }    
        }
    }
}
