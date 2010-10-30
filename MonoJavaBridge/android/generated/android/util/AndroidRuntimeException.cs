namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AndroidRuntimeException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AndroidRuntimeException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public AndroidRuntimeException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.AndroidRuntimeException._m0.native == global::System.IntPtr.Zero)
				global::android.util.AndroidRuntimeException._m0 = @__env.GetMethodIDNoThrow(global::android.util.AndroidRuntimeException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.AndroidRuntimeException.staticClass, global::android.util.AndroidRuntimeException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public AndroidRuntimeException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.AndroidRuntimeException._m1.native == global::System.IntPtr.Zero)
				global::android.util.AndroidRuntimeException._m1 = @__env.GetMethodIDNoThrow(global::android.util.AndroidRuntimeException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.AndroidRuntimeException.staticClass, global::android.util.AndroidRuntimeException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public AndroidRuntimeException(java.lang.Exception arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.AndroidRuntimeException._m2.native == global::System.IntPtr.Zero)
				global::android.util.AndroidRuntimeException._m2 = @__env.GetMethodIDNoThrow(global::android.util.AndroidRuntimeException.staticClass, "<init>", "(Ljava/lang/Exception;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.AndroidRuntimeException.staticClass, global::android.util.AndroidRuntimeException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static AndroidRuntimeException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.AndroidRuntimeException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/AndroidRuntimeException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
