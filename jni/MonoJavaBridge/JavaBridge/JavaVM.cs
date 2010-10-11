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
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace MonoJavaBridge
{
    [SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.Execution | SecurityPermissionFlag.UnmanagedCode | SecurityPermissionFlag.SkipVerification)]
    [ReflectionPermission(SecurityAction.Assert, Unrestricted = true)]
    public unsafe partial class JavaVM
    {
        private readonly IntPtr native;
        private JNIInvokeInterface functions;

        public struct Delegates
        {
            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            internal delegate JNIResult AttachCurrentThread(IntPtr thiz, out IntPtr penv, JavaVMInitArgs* args);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            internal delegate JNIResult AttachCurrentThreadAsDaemon(IntPtr thiz, out IntPtr penv, JavaVMInitArgs* args);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            internal delegate JNIResult DestroyJavaVM(IntPtr thiz);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            internal delegate JNIResult DetachCurrentThread(IntPtr thiz);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            internal delegate JNIResult GetEnv(IntPtr thiz, out IntPtr penv, int version);
        }

        [StructLayout(LayoutKind.Sequential, Size = 4), NativeCppClass]
        private struct JavaPtr
        {
            public JNIInvokeInterface* functions;
        }

        private Delegates.AttachCurrentThread attachCurrentThread;
        private Delegates.AttachCurrentThreadAsDaemon attachCurrentThreadAsDaemon;
        private Delegates.DestroyJavaVM destroyJavaVM;
        private Delegates.DetachCurrentThread detachCurrentThread;
        private Delegates.GetEnv getEnv;

        public JavaVM(IntPtr native)
        {
            this.native = native;
            functions = *(*(JavaPtr*) native.ToPointer()).functions;

            Helper.GetDelegateForFunctionPointer(functions.AttachCurrentThreadAsDaemon, ref attachCurrentThreadAsDaemon);
            Helper.GetDelegateForFunctionPointer(functions.AttachCurrentThread, ref attachCurrentThread);
            Helper.GetDelegateForFunctionPointer(functions.DestroyJavaVM, ref destroyJavaVM);
            Helper.GetDelegateForFunctionPointer(functions.DetachCurrentThread, ref detachCurrentThread);
            Helper.GetDelegateForFunctionPointer(functions.GetEnv, ref getEnv);
        }

        public JNIResult AttachCurrentThread(out JNIEnv penv, JavaVMInitArgs? args)
        {
            IntPtr env;
            JNIResult result;
            if (args.HasValue)
            {
                JavaVMInitArgs initArgs = args.Value;
                result = attachCurrentThread.Invoke(native, out env, &initArgs);
            }
            else
            {
                result = attachCurrentThread.Invoke(native, out env, null);
            }
            penv = new JNIEnv(env);
            return result;
        }

        [SuppressUnmanagedCodeSecurity]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        public JNIResult AttachCurrentThreadAsDaemon(out JNIEnv penv, JavaVMInitArgs? args)
        {
            IntPtr env;
            JNIResult result;
            if (args.HasValue)
            {
                JavaVMInitArgs value = args.Value;
                result = attachCurrentThreadAsDaemon.Invoke(native, out env, &value);
            }
            else
            {
                result = attachCurrentThreadAsDaemon.Invoke(native, out env, null);
            }
            if (result == JNIResult.JNI_OK)
            {
                penv = new JNIEnv(env);
            }
            else
            {
                penv = null;
            }
            return result;
        }

        public JNIResult DestroyJavaVM()
        {
            return destroyJavaVM.Invoke(native);
        }

        public JNIResult DetachCurrentThread()
        {
            return detachCurrentThread.Invoke(native);
        }

        public JNIResult GetEnv(out JNIEnv penv, int version)
        {
            IntPtr env;
            JNIResult result = getEnv.Invoke(native, out env, version);
            penv = new JNIEnv(env);
            return result;
        }

        [StructLayout(LayoutKind.Sequential), NativeCppClass]
        public struct JNIInvokeInterface
        {
            public IntPtr reserved0;
            public IntPtr reserved1;
            public IntPtr reserved2;

            public IntPtr DestroyJavaVM;
            public IntPtr AttachCurrentThread;
            public IntPtr DetachCurrentThread;
            public IntPtr GetEnv;
            public IntPtr AttachCurrentThreadAsDaemon;
        }
    }
}