namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ParcelFormatException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ParcelFormatException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public ParcelFormatException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.ParcelFormatException._m0.native == global::System.IntPtr.Zero)
				global::android.os.ParcelFormatException._m0 = @__env.GetMethodIDNoThrow(global::android.os.ParcelFormatException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.ParcelFormatException.staticClass, global::android.os.ParcelFormatException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public ParcelFormatException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.ParcelFormatException._m1.native == global::System.IntPtr.Zero)
				global::android.os.ParcelFormatException._m1 = @__env.GetMethodIDNoThrow(global::android.os.ParcelFormatException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.ParcelFormatException.staticClass, global::android.os.ParcelFormatException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ParcelFormatException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.ParcelFormatException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/ParcelFormatException"));
		}
	}
}
