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
		internal static global::MonoJavaBridge.MethodId _InflateException8762;
		public InflateException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.InflateException.staticClass, global::android.view.InflateException._InflateException8762);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InflateException8763;
		public InflateException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.InflateException.staticClass, global::android.view.InflateException._InflateException8763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InflateException8764;
		public InflateException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.InflateException.staticClass, global::android.view.InflateException._InflateException8764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InflateException8765;
		public InflateException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.InflateException.staticClass, global::android.view.InflateException._InflateException8765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.InflateException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/InflateException"));
			global::android.view.InflateException._InflateException8762 = @__env.GetMethodIDNoThrow(global::android.view.InflateException.staticClass, "<init>", "()V");
			global::android.view.InflateException._InflateException8763 = @__env.GetMethodIDNoThrow(global::android.view.InflateException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::android.view.InflateException._InflateException8764 = @__env.GetMethodIDNoThrow(global::android.view.InflateException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.view.InflateException._InflateException8765 = @__env.GetMethodIDNoThrow(global::android.view.InflateException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
