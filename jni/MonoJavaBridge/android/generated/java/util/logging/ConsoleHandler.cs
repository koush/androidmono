namespace java.util.logging
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConsoleHandler : java.util.logging.StreamHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ConsoleHandler()
		{
			InitJNI();
		}
		protected ConsoleHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close27933;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.ConsoleHandler._close27933);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.ConsoleHandler.staticClass, global::java.util.logging.ConsoleHandler._close27933);
		}
		internal static global::MonoJavaBridge.MethodId _publish27934;
		public override void publish(java.util.logging.LogRecord arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.ConsoleHandler._publish27934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.ConsoleHandler.staticClass, global::java.util.logging.ConsoleHandler._publish27934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ConsoleHandler27935;
		public ConsoleHandler()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.ConsoleHandler.staticClass, global::java.util.logging.ConsoleHandler._ConsoleHandler27935);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.ConsoleHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/ConsoleHandler"));
			global::java.util.logging.ConsoleHandler._close27933 = @__env.GetMethodIDNoThrow(global::java.util.logging.ConsoleHandler.staticClass, "close", "()V");
			global::java.util.logging.ConsoleHandler._publish27934 = @__env.GetMethodIDNoThrow(global::java.util.logging.ConsoleHandler.staticClass, "publish", "(Ljava/util/logging/LogRecord;)V");
			global::java.util.logging.ConsoleHandler._ConsoleHandler27935 = @__env.GetMethodIDNoThrow(global::java.util.logging.ConsoleHandler.staticClass, "<init>", "()V");
		}
	}
}
