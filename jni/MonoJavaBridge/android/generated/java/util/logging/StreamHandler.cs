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
		internal static global::MonoJavaBridge.MethodId _flush22122;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.StreamHandler._flush22122);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.StreamHandler.staticClass, global::java.util.logging.StreamHandler._flush22122);
		}
		internal static global::MonoJavaBridge.MethodId _close22123;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.StreamHandler._close22123);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.StreamHandler.staticClass, global::java.util.logging.StreamHandler._close22123);
		}
		internal static global::MonoJavaBridge.MethodId _setEncoding22124;
		public override void setEncoding(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.StreamHandler._setEncoding22124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.StreamHandler.staticClass, global::java.util.logging.StreamHandler._setEncoding22124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLoggable22125;
		public override bool isLoggable(java.util.logging.LogRecord arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.logging.StreamHandler._isLoggable22125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.logging.StreamHandler.staticClass, global::java.util.logging.StreamHandler._isLoggable22125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _publish22126;
		public override void publish(java.util.logging.LogRecord arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.StreamHandler._publish22126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.StreamHandler.staticClass, global::java.util.logging.StreamHandler._publish22126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOutputStream22127;
		protected virtual void setOutputStream(java.io.OutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.StreamHandler._setOutputStream22127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.StreamHandler.staticClass, global::java.util.logging.StreamHandler._setOutputStream22127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _StreamHandler22128;
		public StreamHandler()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.StreamHandler.staticClass, global::java.util.logging.StreamHandler._StreamHandler22128);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StreamHandler22129;
		public StreamHandler(java.io.OutputStream arg0, java.util.logging.Formatter arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.StreamHandler.staticClass, global::java.util.logging.StreamHandler._StreamHandler22129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.StreamHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/StreamHandler"));
			global::java.util.logging.StreamHandler._flush22122 = @__env.GetMethodIDNoThrow(global::java.util.logging.StreamHandler.staticClass, "flush", "()V");
			global::java.util.logging.StreamHandler._close22123 = @__env.GetMethodIDNoThrow(global::java.util.logging.StreamHandler.staticClass, "close", "()V");
			global::java.util.logging.StreamHandler._setEncoding22124 = @__env.GetMethodIDNoThrow(global::java.util.logging.StreamHandler.staticClass, "setEncoding", "(Ljava/lang/String;)V");
			global::java.util.logging.StreamHandler._isLoggable22125 = @__env.GetMethodIDNoThrow(global::java.util.logging.StreamHandler.staticClass, "isLoggable", "(Ljava/util/logging/LogRecord;)Z");
			global::java.util.logging.StreamHandler._publish22126 = @__env.GetMethodIDNoThrow(global::java.util.logging.StreamHandler.staticClass, "publish", "(Ljava/util/logging/LogRecord;)V");
			global::java.util.logging.StreamHandler._setOutputStream22127 = @__env.GetMethodIDNoThrow(global::java.util.logging.StreamHandler.staticClass, "setOutputStream", "(Ljava/io/OutputStream;)V");
			global::java.util.logging.StreamHandler._StreamHandler22128 = @__env.GetMethodIDNoThrow(global::java.util.logging.StreamHandler.staticClass, "<init>", "()V");
			global::java.util.logging.StreamHandler._StreamHandler22129 = @__env.GetMethodIDNoThrow(global::java.util.logging.StreamHandler.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/util/logging/Formatter;)V");
		}
	}
}
