namespace java.util.logging
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StreamHandler : java.util.logging.Handler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static StreamHandler()
		{
			InitJNI();
		}
		protected StreamHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _flush28103;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.StreamHandler._flush28103);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.StreamHandler.staticClass, global::java.util.logging.StreamHandler._flush28103);
		}
		internal static global::MonoJavaBridge.MethodId _close28104;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.StreamHandler._close28104);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.StreamHandler.staticClass, global::java.util.logging.StreamHandler._close28104);
		}
		internal static global::MonoJavaBridge.MethodId _setEncoding28105;
		public override void setEncoding(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.StreamHandler._setEncoding28105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.StreamHandler.staticClass, global::java.util.logging.StreamHandler._setEncoding28105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLoggable28106;
		public override bool isLoggable(java.util.logging.LogRecord arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.logging.StreamHandler._isLoggable28106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.logging.StreamHandler.staticClass, global::java.util.logging.StreamHandler._isLoggable28106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _publish28107;
		public override void publish(java.util.logging.LogRecord arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.StreamHandler._publish28107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.StreamHandler.staticClass, global::java.util.logging.StreamHandler._publish28107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOutputStream28108;
		protected virtual void setOutputStream(java.io.OutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.StreamHandler._setOutputStream28108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.StreamHandler.staticClass, global::java.util.logging.StreamHandler._setOutputStream28108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _StreamHandler28109;
		public StreamHandler()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.StreamHandler.staticClass, global::java.util.logging.StreamHandler._StreamHandler28109);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StreamHandler28110;
		public StreamHandler(java.io.OutputStream arg0, java.util.logging.Formatter arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.StreamHandler.staticClass, global::java.util.logging.StreamHandler._StreamHandler28110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.StreamHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/StreamHandler"));
			global::java.util.logging.StreamHandler._flush28103 = @__env.GetMethodIDNoThrow(global::java.util.logging.StreamHandler.staticClass, "flush", "()V");
			global::java.util.logging.StreamHandler._close28104 = @__env.GetMethodIDNoThrow(global::java.util.logging.StreamHandler.staticClass, "close", "()V");
			global::java.util.logging.StreamHandler._setEncoding28105 = @__env.GetMethodIDNoThrow(global::java.util.logging.StreamHandler.staticClass, "setEncoding", "(Ljava/lang/String;)V");
			global::java.util.logging.StreamHandler._isLoggable28106 = @__env.GetMethodIDNoThrow(global::java.util.logging.StreamHandler.staticClass, "isLoggable", "(Ljava/util/logging/LogRecord;)Z");
			global::java.util.logging.StreamHandler._publish28107 = @__env.GetMethodIDNoThrow(global::java.util.logging.StreamHandler.staticClass, "publish", "(Ljava/util/logging/LogRecord;)V");
			global::java.util.logging.StreamHandler._setOutputStream28108 = @__env.GetMethodIDNoThrow(global::java.util.logging.StreamHandler.staticClass, "setOutputStream", "(Ljava/io/OutputStream;)V");
			global::java.util.logging.StreamHandler._StreamHandler28109 = @__env.GetMethodIDNoThrow(global::java.util.logging.StreamHandler.staticClass, "<init>", "()V");
			global::java.util.logging.StreamHandler._StreamHandler28110 = @__env.GetMethodIDNoThrow(global::java.util.logging.StreamHandler.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/util/logging/Formatter;)V");
		}
	}
}
