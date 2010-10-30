namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BadParcelableException : android.util.AndroidRuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BadParcelableException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _BadParcelableException9513;
		public BadParcelableException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.BadParcelableException._BadParcelableException9513.native == global::System.IntPtr.Zero)
				global::android.os.BadParcelableException._BadParcelableException9513 = @__env.GetMethodIDNoThrow(global::android.os.BadParcelableException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.BadParcelableException.staticClass, global::android.os.BadParcelableException._BadParcelableException9513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BadParcelableException9514;
		public BadParcelableException(java.lang.Exception arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.BadParcelableException._BadParcelableException9514.native == global::System.IntPtr.Zero)
				global::android.os.BadParcelableException._BadParcelableException9514 = @__env.GetMethodIDNoThrow(global::android.os.BadParcelableException.staticClass, "<init>", "(Ljava/lang/Exception;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.BadParcelableException.staticClass, global::android.os.BadParcelableException._BadParcelableException9514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static BadParcelableException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.BadParcelableException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/BadParcelableException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
