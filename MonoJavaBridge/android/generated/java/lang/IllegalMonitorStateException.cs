namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IllegalMonitorStateException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IllegalMonitorStateException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public IllegalMonitorStateException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.IllegalMonitorStateException._m0.native == global::System.IntPtr.Zero)
				global::java.lang.IllegalMonitorStateException._m0 = @__env.GetMethodIDNoThrow(global::java.lang.IllegalMonitorStateException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IllegalMonitorStateException.staticClass, global::java.lang.IllegalMonitorStateException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public IllegalMonitorStateException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.IllegalMonitorStateException._m1.native == global::System.IntPtr.Zero)
				global::java.lang.IllegalMonitorStateException._m1 = @__env.GetMethodIDNoThrow(global::java.lang.IllegalMonitorStateException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IllegalMonitorStateException.staticClass, global::java.lang.IllegalMonitorStateException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static IllegalMonitorStateException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.IllegalMonitorStateException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/IllegalMonitorStateException"));
		}
	}
}
