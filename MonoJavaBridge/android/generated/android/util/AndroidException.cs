namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AndroidException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AndroidException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public AndroidException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.AndroidException._m0.native == global::System.IntPtr.Zero)
				global::android.util.AndroidException._m0 = @__env.GetMethodIDNoThrow(global::android.util.AndroidException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.AndroidException.staticClass, global::android.util.AndroidException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public AndroidException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.AndroidException._m1.native == global::System.IntPtr.Zero)
				global::android.util.AndroidException._m1 = @__env.GetMethodIDNoThrow(global::android.util.AndroidException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.AndroidException.staticClass, global::android.util.AndroidException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public AndroidException(java.lang.Exception arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.AndroidException._m2.native == global::System.IntPtr.Zero)
				global::android.util.AndroidException._m2 = @__env.GetMethodIDNoThrow(global::android.util.AndroidException.staticClass, "<init>", "(Ljava/lang/Exception;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.AndroidException.staticClass, global::android.util.AndroidException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static AndroidException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.AndroidException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/AndroidException"));
		}
	}
}
