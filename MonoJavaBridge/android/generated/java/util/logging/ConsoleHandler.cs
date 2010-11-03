namespace java.util.logging
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConsoleHandler : java.util.logging.StreamHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ConsoleHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.ConsoleHandler.staticClass, "close", "()V", ref global::java.util.logging.ConsoleHandler._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void publish(java.util.logging.LogRecord arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.ConsoleHandler.staticClass, "publish", "(Ljava/util/logging/LogRecord;)V", ref global::java.util.logging.ConsoleHandler._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public ConsoleHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.ConsoleHandler._m2.native == global::System.IntPtr.Zero)
				global::java.util.logging.ConsoleHandler._m2 = @__env.GetMethodIDNoThrow(global::java.util.logging.ConsoleHandler.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.ConsoleHandler.staticClass, global::java.util.logging.ConsoleHandler._m2);
			Init(@__env, handle);
		}
		static ConsoleHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.ConsoleHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/ConsoleHandler"));
		}
	}
}
