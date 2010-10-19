namespace java.util.logging
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MemoryHandler : java.util.logging.Handler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MemoryHandler()
		{
			InitJNI();
		}
		protected MemoryHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _push22107;
		public virtual void push() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.MemoryHandler._push22107);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.MemoryHandler.staticClass, global::java.util.logging.MemoryHandler._push22107);
		}
		internal static global::MonoJavaBridge.MethodId _flush22108;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.MemoryHandler._flush22108);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.MemoryHandler.staticClass, global::java.util.logging.MemoryHandler._flush22108);
		}
		internal static global::MonoJavaBridge.MethodId _close22109;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.MemoryHandler._close22109);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.MemoryHandler.staticClass, global::java.util.logging.MemoryHandler._close22109);
		}
		internal static global::MonoJavaBridge.MethodId _isLoggable22110;
		public override bool isLoggable(java.util.logging.LogRecord arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.logging.MemoryHandler._isLoggable22110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.logging.MemoryHandler.staticClass, global::java.util.logging.MemoryHandler._isLoggable22110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _publish22111;
		public override void publish(java.util.logging.LogRecord arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.MemoryHandler._publish22111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.MemoryHandler.staticClass, global::java.util.logging.MemoryHandler._publish22111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPushLevel22112;
		public virtual void setPushLevel(java.util.logging.Level arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.MemoryHandler._setPushLevel22112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.MemoryHandler.staticClass, global::java.util.logging.MemoryHandler._setPushLevel22112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.logging.Level PushLevel
		{
			get
			{
				return getPushLevel();
			}
			set
			{
				setPushLevel(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPushLevel22113;
		public virtual global::java.util.logging.Level getPushLevel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.MemoryHandler._getPushLevel22113)) as java.util.logging.Level;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.MemoryHandler.staticClass, global::java.util.logging.MemoryHandler._getPushLevel22113)) as java.util.logging.Level;
		}
		internal static global::MonoJavaBridge.MethodId _MemoryHandler22114;
		public MemoryHandler()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.MemoryHandler.staticClass, global::java.util.logging.MemoryHandler._MemoryHandler22114);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MemoryHandler22115;
		public MemoryHandler(java.util.logging.Handler arg0, int arg1, java.util.logging.Level arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.MemoryHandler.staticClass, global::java.util.logging.MemoryHandler._MemoryHandler22115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.MemoryHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/MemoryHandler"));
			global::java.util.logging.MemoryHandler._push22107 = @__env.GetMethodIDNoThrow(global::java.util.logging.MemoryHandler.staticClass, "push", "()V");
			global::java.util.logging.MemoryHandler._flush22108 = @__env.GetMethodIDNoThrow(global::java.util.logging.MemoryHandler.staticClass, "flush", "()V");
			global::java.util.logging.MemoryHandler._close22109 = @__env.GetMethodIDNoThrow(global::java.util.logging.MemoryHandler.staticClass, "close", "()V");
			global::java.util.logging.MemoryHandler._isLoggable22110 = @__env.GetMethodIDNoThrow(global::java.util.logging.MemoryHandler.staticClass, "isLoggable", "(Ljava/util/logging/LogRecord;)Z");
			global::java.util.logging.MemoryHandler._publish22111 = @__env.GetMethodIDNoThrow(global::java.util.logging.MemoryHandler.staticClass, "publish", "(Ljava/util/logging/LogRecord;)V");
			global::java.util.logging.MemoryHandler._setPushLevel22112 = @__env.GetMethodIDNoThrow(global::java.util.logging.MemoryHandler.staticClass, "setPushLevel", "(Ljava/util/logging/Level;)V");
			global::java.util.logging.MemoryHandler._getPushLevel22113 = @__env.GetMethodIDNoThrow(global::java.util.logging.MemoryHandler.staticClass, "getPushLevel", "()Ljava/util/logging/Level;");
			global::java.util.logging.MemoryHandler._MemoryHandler22114 = @__env.GetMethodIDNoThrow(global::java.util.logging.MemoryHandler.staticClass, "<init>", "()V");
			global::java.util.logging.MemoryHandler._MemoryHandler22115 = @__env.GetMethodIDNoThrow(global::java.util.logging.MemoryHandler.staticClass, "<init>", "(Ljava/util/logging/Handler;ILjava/util/logging/Level;)V");
		}
	}
}
