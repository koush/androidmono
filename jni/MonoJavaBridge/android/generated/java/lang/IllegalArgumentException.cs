namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IllegalArgumentException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static IllegalArgumentException()
		{
			InitJNI();
		}
		protected IllegalArgumentException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _IllegalArgumentException20055;
		public IllegalArgumentException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IllegalArgumentException.staticClass, global::java.lang.IllegalArgumentException._IllegalArgumentException20055);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IllegalArgumentException20056;
		public IllegalArgumentException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IllegalArgumentException.staticClass, global::java.lang.IllegalArgumentException._IllegalArgumentException20056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IllegalArgumentException20057;
		public IllegalArgumentException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IllegalArgumentException.staticClass, global::java.lang.IllegalArgumentException._IllegalArgumentException20057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IllegalArgumentException20058;
		public IllegalArgumentException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IllegalArgumentException.staticClass, global::java.lang.IllegalArgumentException._IllegalArgumentException20058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.IllegalArgumentException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/IllegalArgumentException"));
			global::java.lang.IllegalArgumentException._IllegalArgumentException20055 = @__env.GetMethodIDNoThrow(global::java.lang.IllegalArgumentException.staticClass, "<init>", "()V");
			global::java.lang.IllegalArgumentException._IllegalArgumentException20056 = @__env.GetMethodIDNoThrow(global::java.lang.IllegalArgumentException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.IllegalArgumentException._IllegalArgumentException20057 = @__env.GetMethodIDNoThrow(global::java.lang.IllegalArgumentException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.lang.IllegalArgumentException._IllegalArgumentException20058 = @__env.GetMethodIDNoThrow(global::java.lang.IllegalArgumentException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
