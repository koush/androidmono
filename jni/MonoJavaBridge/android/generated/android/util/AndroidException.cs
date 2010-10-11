namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AndroidException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AndroidException()
		{
			InitJNI();
		}
		protected AndroidException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _AndroidException8437;
		public AndroidException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.AndroidException.staticClass, global::android.util.AndroidException._AndroidException8437);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AndroidException8438;
		public AndroidException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.AndroidException.staticClass, global::android.util.AndroidException._AndroidException8438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AndroidException8439;
		public AndroidException(java.lang.Exception arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.AndroidException.staticClass, global::android.util.AndroidException._AndroidException8439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.AndroidException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/AndroidException"));
			global::android.util.AndroidException._AndroidException8437 = @__env.GetMethodIDNoThrow(global::android.util.AndroidException.staticClass, "<init>", "()V");
			global::android.util.AndroidException._AndroidException8438 = @__env.GetMethodIDNoThrow(global::android.util.AndroidException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.util.AndroidException._AndroidException8439 = @__env.GetMethodIDNoThrow(global::android.util.AndroidException.staticClass, "<init>", "(Ljava/lang/Exception;)V");
		}
	}
}
