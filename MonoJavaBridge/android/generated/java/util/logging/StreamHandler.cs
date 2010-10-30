namespace java.util.logging
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StreamHandler : java.util.logging.Handler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected StreamHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _flush28104;
		public override void flush()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.StreamHandler._flush28104.native == global::System.IntPtr.Zero)
				global::java.util.logging.StreamHandler._flush28104 = @__env.GetMethodIDNoThrow(global::java.util.logging.StreamHandler.staticClass, "flush", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.StreamHandler.staticClass, global::java.util.logging.StreamHandler._flush28104);
		}
		internal static global::MonoJavaBridge.MethodId _close28105;
		public override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.StreamHandler._close28105.native == global::System.IntPtr.Zero)
				global::java.util.logging.StreamHandler._close28105 = @__env.GetMethodIDNoThrow(global::java.util.logging.StreamHandler.staticClass, "close", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.StreamHandler.staticClass, global::java.util.logging.StreamHandler._close28105);
		}
		public new global::java.lang.String Encoding
		{
			set
			{
				setEncoding(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setEncoding28106;
		public override void setEncoding(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.StreamHandler._setEncoding28106.native == global::System.IntPtr.Zero)
				global::java.util.logging.StreamHandler._setEncoding28106 = @__env.GetMethodIDNoThrow(global::java.util.logging.StreamHandler.staticClass, "setEncoding", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.StreamHandler.staticClass, global::java.util.logging.StreamHandler._setEncoding28106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLoggable28107;
		public override bool isLoggable(java.util.logging.LogRecord arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.StreamHandler._isLoggable28107.native == global::System.IntPtr.Zero)
				global::java.util.logging.StreamHandler._isLoggable28107 = @__env.GetMethodIDNoThrow(global::java.util.logging.StreamHandler.staticClass, "isLoggable", "(Ljava/util/logging/LogRecord;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.logging.StreamHandler.staticClass, global::java.util.logging.StreamHandler._isLoggable28107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _publish28108;
		public override void publish(java.util.logging.LogRecord arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.StreamHandler._publish28108.native == global::System.IntPtr.Zero)
				global::java.util.logging.StreamHandler._publish28108 = @__env.GetMethodIDNoThrow(global::java.util.logging.StreamHandler.staticClass, "publish", "(Ljava/util/logging/LogRecord;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.StreamHandler.staticClass, global::java.util.logging.StreamHandler._publish28108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		protected new global::java.io.OutputStream OutputStream
		{
			set
			{
				setOutputStream(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setOutputStream28109;
		protected virtual void setOutputStream(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.StreamHandler._setOutputStream28109.native == global::System.IntPtr.Zero)
				global::java.util.logging.StreamHandler._setOutputStream28109 = @__env.GetMethodIDNoThrow(global::java.util.logging.StreamHandler.staticClass, "setOutputStream", "(Ljava/io/OutputStream;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.StreamHandler.staticClass, global::java.util.logging.StreamHandler._setOutputStream28109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _StreamHandler28110;
		public StreamHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.StreamHandler._StreamHandler28110.native == global::System.IntPtr.Zero)
				global::java.util.logging.StreamHandler._StreamHandler28110 = @__env.GetMethodIDNoThrow(global::java.util.logging.StreamHandler.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.StreamHandler.staticClass, global::java.util.logging.StreamHandler._StreamHandler28110);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StreamHandler28111;
		public StreamHandler(java.io.OutputStream arg0, java.util.logging.Formatter arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.StreamHandler._StreamHandler28111.native == global::System.IntPtr.Zero)
				global::java.util.logging.StreamHandler._StreamHandler28111 = @__env.GetMethodIDNoThrow(global::java.util.logging.StreamHandler.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/util/logging/Formatter;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.StreamHandler.staticClass, global::java.util.logging.StreamHandler._StreamHandler28111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static StreamHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.StreamHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/StreamHandler"));
		}
		internal static void InitJNI()
		{
		}
	}
}
