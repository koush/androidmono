#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU Lesser General Public License as 
published by the Free Software Foundation, either version 3 
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

#endregion

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace MonoJavaBridge
{
    unsafe partial class JNIEnv
    {
        public static JavaVM defaultVM;
        [ThreadStatic] public static JNIEnv threadJNIEnv;

        public readonly IntPtr envPtr;
        private JNINativeInterface functions;
        private JavaVM javaVM;

        public JNIEnv(IntPtr native)
        {
            this.envPtr = native;
            functions = *(*(JavaPtr*) native.ToPointer()).functions;
            InitMethods();
            if (defaultVM == null)
            {
                defaultVM = GetJavaVM();
            }
        }

        public static JNIEnv ThreadEnv
        {
            [SuppressUnmanagedCodeSecurity]
            get
            {
                if (threadJNIEnv == null)
                {
                    if (defaultVM == null)
                    {
                        throw new JNIException(
                            "AttachCurrentThreadAsDaemon failed: Java VM is not attached, call JNI.CreateJavaVM() first");
                    }
                    JNIResult result = defaultVM.AttachCurrentThreadAsDaemon(out threadJNIEnv, null);
                    if (result != JNIResult.JNI_OK)
                    {
                        throw new JNIException("AttachCurrentThreadAsDaemon failed: " + result);
                    }
                }
                return threadJNIEnv;
            }
        }

        [SuppressUnmanagedCodeSecurity]
        public static JNIEnv GetEnvForVm(JavaVM vm)
        {
            if (threadJNIEnv == null)
            {
                JNIResult result = vm.AttachCurrentThreadAsDaemon(out threadJNIEnv, null);
                if (result != JNIResult.JNI_OK)
                {
                    throw new JNIException("AttachCurrentThreadAsDaemon failed: " + result);
                }
            }
            return threadJNIEnv;
        }

        [global::System.Security.SuppressUnmanagedCodeSecurity]
        [global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
        public static JNIEnv GetEnvNoThrow(JavaVM vm)
        {
            if (threadJNIEnv == null)
            {
                JNIResult result = vm.AttachCurrentThreadAsDaemon(out threadJNIEnv, null);
                if (result != JNIResult.JNI_OK)
                {
                    return null;
                }
            }
            return threadJNIEnv;
        }

        [SuppressUnmanagedCodeSecurity]
        public static JNIEnv Wrap(IntPtr envi)
        {
            if (envi == IntPtr.Zero)
            {
                return null;
            }
            if (threadJNIEnv != null && envi == threadJNIEnv.envPtr)
            {
                return threadJNIEnv;
            }
            return new JNIEnv(envi);
        }

        #region Nested type: JavaPtr

        [StructLayout(LayoutKind.Sequential, Size = 4), NativeCppClass]
        private struct JavaPtr
        {
            public JNINativeInterface* functions;
        }

        #endregion
    }
}