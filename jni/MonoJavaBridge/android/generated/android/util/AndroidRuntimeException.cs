namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AndroidRuntimeException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AndroidRuntimeException()
		{
			InitJNI();
		}
		protected AndroidRuntimeException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _AndroidRuntimeException13675;
		public AndroidRuntimeException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.AndroidRuntimeException.staticClass, global::android.util.AndroidRuntimeException._AndroidRuntimeException13675);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AndroidRuntimeException13676;
		public AndroidRuntimeException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.AndroidRuntimeException.staticClass, global::android.util.AndroidRuntimeException._AndroidRuntimeException13676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AndroidRuntimeException13677;
		public AndroidRuntimeException(java.lang.Exception arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.AndroidRuntimeException.staticClass, global::android.util.AndroidRuntimeException._AndroidRuntimeException13677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.AndroidRuntimeException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/AndroidRuntimeException"));
			global::android.util.AndroidRuntimeException._AndroidRuntimeException13675 = @__env.GetMethodIDNoThrow(global::android.util.AndroidRuntimeException.staticClass, "<init>", "()V");
			global::android.util.AndroidRuntimeException._AndroidRuntimeException13676 = @__env.GetMethodIDNoThrow(global::android.util.AndroidRuntimeException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.util.AndroidRuntimeException._AndroidRuntimeException13677 = @__env.GetMethodIDNoThrow(global::android.util.AndroidRuntimeException.staticClass, "<init>", "(Ljava/lang/Exception;)V");
		}
	}
}
