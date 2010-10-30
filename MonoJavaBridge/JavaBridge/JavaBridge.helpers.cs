using System;

namespace MonoJavaBridge
{
    public partial class JavaBridge
    {
        public static void CallVoidMethod(IJavaObject obj, JniGlobalHandle clazz, string name, string signature, ref MethodId methodId, params Value[] args)
        {
            var env = JNIEnv.ThreadEnv;
            if (methodId.native == IntPtr.Zero)
                methodId = env.GetMethodID(clazz, name, signature);
            if (!obj.IsClrObject)
                env.CallVoidMethod(obj.JvmHandle, methodId, args);
            else
                env.CallNonVirtualVoidMethod(obj.JvmHandle, clazz, methodId, args);
        }
        public static T CallIJavaObjectMethod<T>(IJavaObject obj, JniGlobalHandle clazz,  string name, string signature, ref MethodId methodId, params Value[] args) where T: class, IJavaObject
        {
            var env = JNIEnv.ThreadEnv;
            if (methodId.native == IntPtr.Zero)
                methodId = env.GetMethodID(clazz, name, signature);
            if (!obj.IsClrObject)
                return WrapIJavaObject<T>(env.CallObjectMethod(obj.JvmHandle, methodId, args));
            else
                return WrapIJavaObject<T>(env.CallNonVirtualObjectMethod(obj.JvmHandle, clazz, methodId, args));
        }
        public static T CallSealedClassObjectMethod<T>(IJavaObject obj, JniGlobalHandle clazz,  string name, string signature, ref MethodId methodId, params Value[] args) where T: class, IJavaObject
        {
            var env = JNIEnv.ThreadEnv;
            if (methodId.native == IntPtr.Zero)
                methodId = env.GetMethodID(clazz, name, signature);
            if (!obj.IsClrObject)
                return WrapJavaObjectSealedClass<T>(env.CallObjectMethod(obj.JvmHandle, methodId, args));
            else
                return WrapJavaObjectSealedClass<T>(env.CallNonVirtualObjectMethod(obj.JvmHandle, clazz, methodId, args));
        }
        public static T[] CallArrayObjectMethod<T>(IJavaObject obj, JniGlobalHandle clazz,  string name, string signature, ref MethodId methodId, params Value[] args)
        {
            var env = JNIEnv.ThreadEnv;
            if (methodId.native == IntPtr.Zero)
                methodId = env.GetMethodID(clazz, name, signature);
            if (!obj.IsClrObject)
                return WrapJavaArrayObject<T>(env.CallObjectMethod(obj.JvmHandle, methodId, args));
            else
                return WrapJavaArrayObject<T>(env.CallNonVirtualObjectMethod(obj.JvmHandle, clazz, methodId, args));
        }
        public static object CallObjectMethod(IJavaObject obj, JniGlobalHandle clazz,  string name, string signature, ref MethodId methodId, params Value[] args)
        {
            var env = JNIEnv.ThreadEnv;
            if (methodId.native == IntPtr.Zero)
                methodId = env.GetMethodID(clazz, name, signature);
            if (!obj.IsClrObject)
                return WrapJavaObject(env.CallObjectMethod(obj.JvmHandle, methodId, args));
            else
                return WrapJavaObject(env.CallNonVirtualObjectMethod(obj.JvmHandle, clazz, methodId, args));
        }
        public static bool CallBooleanMethod(IJavaObject obj, JniGlobalHandle clazz,  string name, string signature, ref MethodId methodId, params Value[] args)
        {
            var env = JNIEnv.ThreadEnv;
            if (methodId.native == IntPtr.Zero)
                methodId = env.GetMethodID(clazz, name, signature);
            if (!obj.IsClrObject)
                return env.CallBooleanMethod(obj.JvmHandle, methodId, args);
            else
                return env.CallNonVirtualBooleanMethod(obj.JvmHandle, clazz, methodId, args);
        }
        public static byte CallByteMethod(IJavaObject obj, JniGlobalHandle clazz,  string name, string signature, ref MethodId methodId, params Value[] args)
        {
            var env = JNIEnv.ThreadEnv;
            if (methodId.native == IntPtr.Zero)
                methodId = env.GetMethodID(clazz, name, signature);
            if (!obj.IsClrObject)
                return env.CallByteMethod(obj.JvmHandle, methodId, args);
            else
                return env.CallNonVirtualByteMethod(obj.JvmHandle, clazz, methodId, args);
        }
        public static char CallCharMethod(IJavaObject obj, JniGlobalHandle clazz,  string name, string signature, ref MethodId methodId, params Value[] args)
        {
            var env = JNIEnv.ThreadEnv;
            if (methodId.native == IntPtr.Zero)
                methodId = env.GetMethodID(clazz, name, signature);
            if (!obj.IsClrObject)
                return env.CallCharMethod(obj.JvmHandle, methodId, args);
            else
                return env.CallNonVirtualCharMethod(obj.JvmHandle, clazz, methodId, args);
        }
        public static short CallShortMethod(IJavaObject obj, JniGlobalHandle clazz,  string name, string signature, ref MethodId methodId, params Value[] args)
        {
            var env = JNIEnv.ThreadEnv;
            if (methodId.native == IntPtr.Zero)
                methodId = env.GetMethodID(clazz, name, signature);
            if (!obj.IsClrObject)
                return env.CallShortMethod(obj.JvmHandle, methodId, args);
            else
                return env.CallNonVirtualShortMethod(obj.JvmHandle, clazz, methodId, args);
        }
        public static double CallDoubleMethod(IJavaObject obj, JniGlobalHandle clazz,  string name, string signature, ref MethodId methodId, params Value[] args)
        {
            var env = JNIEnv.ThreadEnv;
            if (methodId.native == IntPtr.Zero)
                methodId = env.GetMethodID(clazz, name, signature);
            if (!obj.IsClrObject)
                return env.CallDoubleMethod(obj.JvmHandle, methodId, args);
            else
                return env.CallNonVirtualDoubleMethod(obj.JvmHandle, clazz, methodId, args);
        }
        public static float CallFloatMethod(IJavaObject obj, JniGlobalHandle clazz,  string name, string signature, ref MethodId methodId, params Value[] args)
        {
            var env = JNIEnv.ThreadEnv;
            if (methodId.native == IntPtr.Zero)
                methodId = env.GetMethodID(clazz, name, signature);
            if (!obj.IsClrObject)
                return env.CallFloatMethod(obj.JvmHandle, methodId, args);
            else
                return env.CallNonVirtualFloatMethod(obj.JvmHandle, clazz, methodId, args);
        }
        public static int CallIntMethod(IJavaObject obj, JniGlobalHandle clazz,  string name, string signature, ref MethodId methodId, params Value[] args)
        {
            var env = JNIEnv.ThreadEnv;
            if (methodId.native == IntPtr.Zero)
                methodId = env.GetMethodID(clazz, name, signature);
            if (!obj.IsClrObject)
                return env.CallIntMethod(obj.JvmHandle, methodId, args);
            else
                return env.CallNonVirtualIntMethod(obj.JvmHandle, clazz, methodId, args);
        }
        public static long CallLongMethod(IJavaObject obj, JniGlobalHandle clazz,  string name, string signature, ref MethodId methodId, params Value[] args)
        {
            var env = JNIEnv.ThreadEnv;
            if (methodId.native == IntPtr.Zero)
                methodId = env.GetMethodID(clazz, name, signature);
            if (!obj.IsClrObject)
                return env.CallLongMethod(obj.JvmHandle, methodId, args);
            else
                return env.CallNonVirtualLongMethod(obj.JvmHandle, clazz, methodId, args);
        }
    }
}

