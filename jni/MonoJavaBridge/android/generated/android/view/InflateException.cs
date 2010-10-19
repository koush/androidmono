namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InflateException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InflateException()
		{
			InitJNI();
		}
		protected InflateException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _InflateException9308;
		public InflateException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.InflateException.staticClass, global::android.view.InflateException._InflateException9308);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InflateException9309;
		public InflateException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.InflateException.staticClass, global::android.view.InflateException._InflateException9309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InflateException9310;
		public InflateException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.InflateException.staticClass, global::android.view.InflateException._InflateException9310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InflateException9311;
		public InflateException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.InflateException.staticClass, global::android.view.InflateException._InflateException9311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.InflateException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/InflateException"));
			global::android.view.InflateException._InflateException9308 = @__env.GetMethodIDNoThrow(global::android.view.InflateException.staticClass, "<init>", "()V");
			global::android.view.InflateException._InflateException9309 = @__env.GetMethodIDNoThrow(global::android.view.InflateException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::android.view.InflateException._InflateException9310 = @__env.GetMethodIDNoThrow(global::android.view.InflateException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.view.InflateException._InflateException9311 = @__env.GetMethodIDNoThrow(global::android.view.InflateException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
