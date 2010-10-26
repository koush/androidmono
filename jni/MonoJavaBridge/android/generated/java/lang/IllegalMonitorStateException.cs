namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IllegalMonitorStateException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static IllegalMonitorStateException()
		{
			InitJNI();
		}
		protected IllegalMonitorStateException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _IllegalMonitorStateException20177;
		public IllegalMonitorStateException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IllegalMonitorStateException.staticClass, global::java.lang.IllegalMonitorStateException._IllegalMonitorStateException20177);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IllegalMonitorStateException20178;
		public IllegalMonitorStateException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IllegalMonitorStateException.staticClass, global::java.lang.IllegalMonitorStateException._IllegalMonitorStateException20178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.IllegalMonitorStateException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/IllegalMonitorStateException"));
			global::java.lang.IllegalMonitorStateException._IllegalMonitorStateException20177 = @__env.GetMethodIDNoThrow(global::java.lang.IllegalMonitorStateException.staticClass, "<init>", "()V");
			global::java.lang.IllegalMonitorStateException._IllegalMonitorStateException20178 = @__env.GetMethodIDNoThrow(global::java.lang.IllegalMonitorStateException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
