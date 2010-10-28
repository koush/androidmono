using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Reflection;


namespace MonoJavaBridge
{
    static class Helper
    {
        public static void GetDelegateForFunctionPointer<T>(IntPtr ptr, ref T res)
        {
            res = (T)(object)Marshal.GetDelegateForFunctionPointer(ptr, typeof(T));
        }
    }
}
