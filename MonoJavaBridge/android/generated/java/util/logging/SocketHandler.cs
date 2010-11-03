namespace java.util.logging
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SocketHandler : java.util.logging.StreamHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SocketHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.SocketHandler.staticClass, "close", "()V", ref global::java.util.logging.SocketHandler._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void publish(java.util.logging.LogRecord arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.SocketHandler.staticClass, "publish", "(Ljava/util/logging/LogRecord;)V", ref global::java.util.logging.SocketHandler._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public SocketHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.SocketHandler._m2.native == global::System.IntPtr.Zero)
				global::java.util.logging.SocketHandler._m2 = @__env.GetMethodIDNoThrow(global::java.util.logging.SocketHandler.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.SocketHandler.staticClass, global::java.util.logging.SocketHandler._m2);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public SocketHandler(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.SocketHandler._m3.native == global::System.IntPtr.Zero)
				global::java.util.logging.SocketHandler._m3 = @__env.GetMethodIDNoThrow(global::java.util.logging.SocketHandler.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.SocketHandler.staticClass, global::java.util.logging.SocketHandler._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static SocketHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.SocketHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/SocketHandler"));
		}
	}
}
