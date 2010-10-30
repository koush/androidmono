using System;

namespace MonoJavaBridge
{
    public partial class JavaBridge
    {
        public static void CallVoidMethod(IJavaObject obj, JniGlobalHandle clazz, MethodId methodId, params Value[] args)
        {
            var env = JNIEnv.ThreadEnv;
            if (!obj.IsClrObject)
                env.CallVoidMethod(obj.JvmHandle, methodId, args);
            else
                env.CallNonVirtualVoidMethod(obj.JvmHandle, clazz, methodId, args);
        }
        public static JniLocalHandle CallObjectMethod(IJavaObject obj, JniGlobalHandle clazz, MethodId methodId, params Value[] args)
        {
            var env = JNIEnv.ThreadEnv;
            if (!obj.IsClrObject)
                return env.CallObjectMethod(obj.JvmHandle, methodId, args);
            else
                return env.CallNonVirtualObjectMethod(obj.JvmHandle, clazz, methodId, args);
        }
        public static bool CallBooleanMethod(IJavaObject obj, JniGlobalHandle clazz, MethodId methodId, params Value[] args)
        {
            var env = JNIEnv.ThreadEnv;
            if (!obj.IsClrObject)
                return env.CallBooleanMethod(obj.JvmHandle, methodId, args);
            else
                return env.CallNonVirtualBooleanMethod(obj.JvmHandle, clazz, methodId, args);
        }
        public static byte CallByteMethod(IJavaObject obj, JniGlobalHandle clazz, MethodId methodId, params Value[] args)
        {
            var env = JNIEnv.ThreadEnv;
            if (!obj.IsClrObject)
                return env.CallByteMethod(obj.JvmHandle, methodId, args);
            else
                return env.CallNonVirtualByteMethod(obj.JvmHandle, clazz, methodId, args);
        }
        public static char CallCharMethod(IJavaObject obj, JniGlobalHandle clazz, MethodId methodId, params Value[] args)
        {
            var env = JNIEnv.ThreadEnv;
            if (!obj.IsClrObject)
                return env.CallCharMethod(obj.JvmHandle, methodId, args);
            else
                return env.CallNonVirtualCharMethod(obj.JvmHandle, clazz, methodId, args);
        }
        public static short CallShortMethod(IJavaObject obj, JniGlobalHandle clazz, MethodId methodId, params Value[] args)
        {
            var env = JNIEnv.ThreadEnv;
            if (!obj.IsClrObject)
                return env.CallShortMethod(obj.JvmHandle, methodId, args);
            else
                return env.CallNonVirtualShortMethod(obj.JvmHandle, clazz, methodId, args);
        }
        public static double CallDoubleMethod(IJavaObject obj, JniGlobalHandle clazz, MethodId methodId, params Value[] args)
        {
            var env = JNIEnv.ThreadEnv;
            if (!obj.IsClrObject)
                return env.CallDoubleMethod(obj.JvmHandle, methodId, args);
            else
                return env.CallNonVirtualDoubleMethod(obj.JvmHandle, clazz, methodId, args);
        }
        public static float CallFloatMethod(IJavaObject obj, JniGlobalHandle clazz, MethodId methodId, params Value[] args)
        {
            var env = JNIEnv.ThreadEnv;
            if (!obj.IsClrObject)
                return env.CallFloatMethod(obj.JvmHandle, methodId, args);
            else
                return env.CallNonVirtualFloatMethod(obj.JvmHandle, clazz, methodId, args);
        }
        public static int CallIntMethod(IJavaObject obj, JniGlobalHandle clazz, MethodId methodId, params Value[] args)
        {
            var env = JNIEnv.ThreadEnv;
            if (!obj.IsClrObject)
                return env.CallIntMethod(obj.JvmHandle, methodId, args);
            else
                return env.CallNonVirtualIntMethod(obj.JvmHandle, clazz, methodId, args);
        }
        public static long CallLongMethod(IJavaObject obj, JniGlobalHandle clazz, MethodId methodId, params Value[] args)
        {
            var env = JNIEnv.ThreadEnv;
            if (!obj.IsClrObject)
                return env.CallLongMethod(obj.JvmHandle, methodId, args);
            else
                return env.CallNonVirtualLongMethod(obj.JvmHandle, clazz, methodId, args);
        }
    }
}

