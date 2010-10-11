namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BadParcelableException : android.util.AndroidRuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BadParcelableException()
		{
			InitJNI();
		}
		protected BadParcelableException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _BadParcelableException6144;
		public BadParcelableException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.BadParcelableException.staticClass, global::android.os.BadParcelableException._BadParcelableException6144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BadParcelableException6145;
		public BadParcelableException(java.lang.Exception arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.BadParcelableException.staticClass, global::android.os.BadParcelableException._BadParcelableException6145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.BadParcelableException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/BadParcelableException"));
			global::android.os.BadParcelableException._BadParcelableException6144 = @__env.GetMethodIDNoThrow(global::android.os.BadParcelableException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.os.BadParcelableException._BadParcelableException6145 = @__env.GetMethodIDNoThrow(global::android.os.BadParcelableException.staticClass, "<init>", "(Ljava/lang/Exception;)V");
		}
	}
}
