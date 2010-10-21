namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IllegalStateException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static IllegalStateException()
		{
			InitJNI();
		}
		protected IllegalStateException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _IllegalStateException20061;
		public IllegalStateException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IllegalStateException.staticClass, global::java.lang.IllegalStateException._IllegalStateException20061);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IllegalStateException20062;
		public IllegalStateException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IllegalStateException.staticClass, global::java.lang.IllegalStateException._IllegalStateException20062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IllegalStateException20063;
		public IllegalStateException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IllegalStateException.staticClass, global::java.lang.IllegalStateException._IllegalStateException20063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IllegalStateException20064;
		public IllegalStateException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IllegalStateException.staticClass, global::java.lang.IllegalStateException._IllegalStateException20064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.IllegalStateException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/IllegalStateException"));
			global::java.lang.IllegalStateException._IllegalStateException20061 = @__env.GetMethodIDNoThrow(global::java.lang.IllegalStateException.staticClass, "<init>", "()V");
			global::java.lang.IllegalStateException._IllegalStateException20062 = @__env.GetMethodIDNoThrow(global::java.lang.IllegalStateException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.IllegalStateException._IllegalStateException20063 = @__env.GetMethodIDNoThrow(global::java.lang.IllegalStateException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.lang.IllegalStateException._IllegalStateException20064 = @__env.GetMethodIDNoThrow(global::java.lang.IllegalStateException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
