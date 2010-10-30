namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ParcelFormatException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ParcelFormatException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ParcelFormatException10100;
		public ParcelFormatException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.ParcelFormatException._ParcelFormatException10100.native == global::System.IntPtr.Zero)
				global::android.os.ParcelFormatException._ParcelFormatException10100 = @__env.GetMethodIDNoThrow(global::android.os.ParcelFormatException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.ParcelFormatException.staticClass, global::android.os.ParcelFormatException._ParcelFormatException10100);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ParcelFormatException10101;
		public ParcelFormatException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.ParcelFormatException._ParcelFormatException10101.native == global::System.IntPtr.Zero)
				global::android.os.ParcelFormatException._ParcelFormatException10101 = @__env.GetMethodIDNoThrow(global::android.os.ParcelFormatException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.ParcelFormatException.staticClass, global::android.os.ParcelFormatException._ParcelFormatException10101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ParcelFormatException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.ParcelFormatException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/ParcelFormatException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
