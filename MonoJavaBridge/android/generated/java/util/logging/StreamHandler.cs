namespace java.util.logging
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StreamHandler : java.util.logging.Handler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected StreamHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.StreamHandler.staticClass, "flush", "()V", ref global::java.util.logging.StreamHandler._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.StreamHandler.staticClass, "close", "()V", ref global::java.util.logging.StreamHandler._m1);
		}
		public new global::java.lang.String Encoding
		{
			set
			{
				setEncoding(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void setEncoding(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.StreamHandler.staticClass, "setEncoding", "(Ljava/lang/String;)V", ref global::java.util.logging.StreamHandler._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool isLoggable(java.util.logging.LogRecord arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.logging.StreamHandler.staticClass, "isLoggable", "(Ljava/util/logging/LogRecord;)Z", ref global::java.util.logging.StreamHandler._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void publish(java.util.logging.LogRecord arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.StreamHandler.staticClass, "publish", "(Ljava/util/logging/LogRecord;)V", ref global::java.util.logging.StreamHandler._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		protected new global::java.io.OutputStream OutputStream
		{
			set
			{
				setOutputStream(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected virtual void setOutputStream(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.StreamHandler.staticClass, "setOutputStream", "(Ljava/io/OutputStream;)V", ref global::java.util.logging.StreamHandler._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public StreamHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.StreamHandler._m6.native == global::System.IntPtr.Zero)
				global::java.util.logging.StreamHandler._m6 = @__env.GetMethodIDNoThrow(global::java.util.logging.StreamHandler.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.StreamHandler.staticClass, global::java.util.logging.StreamHandler._m6);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public StreamHandler(java.io.OutputStream arg0, java.util.logging.Formatter arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.StreamHandler._m7.native == global::System.IntPtr.Zero)
				global::java.util.logging.StreamHandler._m7 = @__env.GetMethodIDNoThrow(global::java.util.logging.StreamHandler.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/util/logging/Formatter;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.StreamHandler.staticClass, global::java.util.logging.StreamHandler._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static StreamHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.StreamHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/StreamHandler"));
		}
	}
}
