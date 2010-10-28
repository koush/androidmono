namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RuntimeException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RuntimeException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _RuntimeException20454;
		public RuntimeException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.RuntimeException.staticClass, global::java.lang.RuntimeException._RuntimeException20454);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RuntimeException20455;
		public RuntimeException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.RuntimeException.staticClass, global::java.lang.RuntimeException._RuntimeException20455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RuntimeException20456;
		public RuntimeException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.RuntimeException.staticClass, global::java.lang.RuntimeException._RuntimeException20456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RuntimeException20457;
		public RuntimeException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.RuntimeException.staticClass, global::java.lang.RuntimeException._RuntimeException20457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static RuntimeException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.RuntimeException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/RuntimeException"));
			global::java.lang.RuntimeException._RuntimeException20454 = @__env.GetMethodIDNoThrow(global::java.lang.RuntimeException.staticClass, "<init>", "()V");
			global::java.lang.RuntimeException._RuntimeException20455 = @__env.GetMethodIDNoThrow(global::java.lang.RuntimeException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.RuntimeException._RuntimeException20456 = @__env.GetMethodIDNoThrow(global::java.lang.RuntimeException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.lang.RuntimeException._RuntimeException20457 = @__env.GetMethodIDNoThrow(global::java.lang.RuntimeException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
