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
		internal static global::MonoJavaBridge.MethodId _flush27985;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.StreamHandler._flush27985);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.StreamHandler.staticClass, global::java.util.logging.StreamHandler._flush27985);
		}
		internal static global::MonoJavaBridge.MethodId _close27986;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.StreamHandler._close27986);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.StreamHandler.staticClass, global::java.util.logging.StreamHandler._close27986);
		}
		internal static global::MonoJavaBridge.MethodId _setEncoding27987;
		public override void setEncoding(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.StreamHandler._setEncoding27987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.StreamHandler.staticClass, global::java.util.logging.StreamHandler._setEncoding27987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLoggable27988;
		public override bool isLoggable(java.util.logging.LogRecord arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.logging.StreamHandler._isLoggable27988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.logging.StreamHandler.staticClass, global::java.util.logging.StreamHandler._isLoggable27988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _publish27989;
		public override void publish(java.util.logging.LogRecord arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.StreamHandler._publish27989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.StreamHandler.staticClass, global::java.util.logging.StreamHandler._publish27989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOutputStream27990;
		protected virtual void setOutputStream(java.io.OutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.StreamHandler._setOutputStream27990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.StreamHandler.staticClass, global::java.util.logging.StreamHandler._setOutputStream27990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _StreamHandler27991;
		public StreamHandler()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.StreamHandler.staticClass, global::java.util.logging.StreamHandler._StreamHandler27991);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StreamHandler27992;
		public StreamHandler(java.io.OutputStream arg0, java.util.logging.Formatter arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.StreamHandler.staticClass, global::java.util.logging.StreamHandler._StreamHandler27992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.StreamHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/StreamHandler"));
			global::java.util.logging.StreamHandler._flush27985 = @__env.GetMethodIDNoThrow(global::java.util.logging.StreamHandler.staticClass, "flush", "()V");
			global::java.util.logging.StreamHandler._close27986 = @__env.GetMethodIDNoThrow(global::java.util.logging.StreamHandler.staticClass, "close", "()V");
			global::java.util.logging.StreamHandler._setEncoding27987 = @__env.GetMethodIDNoThrow(global::java.util.logging.StreamHandler.staticClass, "setEncoding", "(Ljava/lang/String;)V");
			global::java.util.logging.StreamHandler._isLoggable27988 = @__env.GetMethodIDNoThrow(global::java.util.logging.StreamHandler.staticClass, "isLoggable", "(Ljava/util/logging/LogRecord;)Z");
			global::java.util.logging.StreamHandler._publish27989 = @__env.GetMethodIDNoThrow(global::java.util.logging.StreamHandler.staticClass, "publish", "(Ljava/util/logging/LogRecord;)V");
			global::java.util.logging.StreamHandler._setOutputStream27990 = @__env.GetMethodIDNoThrow(global::java.util.logging.StreamHandler.staticClass, "setOutputStream", "(Ljava/io/OutputStream;)V");
			global::java.util.logging.StreamHandler._StreamHandler27991 = @__env.GetMethodIDNoThrow(global::java.util.logging.StreamHandler.staticClass, "<init>", "()V");
			global::java.util.logging.StreamHandler._StreamHandler27992 = @__env.GetMethodIDNoThrow(global::java.util.logging.StreamHandler.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/util/logging/Formatter;)V");
		}
	}
}
