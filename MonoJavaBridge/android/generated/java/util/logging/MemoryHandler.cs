namespace java.util.logging
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MemoryHandler : java.util.logging.Handler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MemoryHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void push()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.MemoryHandler.staticClass, "push", "()V", ref global::java.util.logging.MemoryHandler._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.MemoryHandler.staticClass, "flush", "()V", ref global::java.util.logging.MemoryHandler._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.MemoryHandler.staticClass, "close", "()V", ref global::java.util.logging.MemoryHandler._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool isLoggable(java.util.logging.LogRecord arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.logging.MemoryHandler.staticClass, "isLoggable", "(Ljava/util/logging/LogRecord;)Z", ref global::java.util.logging.MemoryHandler._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void publish(java.util.logging.LogRecord arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.MemoryHandler.staticClass, "publish", "(Ljava/util/logging/LogRecord;)V", ref global::java.util.logging.MemoryHandler._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setPushLevel(java.util.logging.Level arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.MemoryHandler.staticClass, "setPushLevel", "(Ljava/util/logging/Level;)V", ref global::java.util.logging.MemoryHandler._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.util.logging.Level getPushLevel()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.logging.MemoryHandler.staticClass, "getPushLevel", "()Ljava/util/logging/Level;", ref global::java.util.logging.MemoryHandler._m6) as java.util.logging.Level;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public MemoryHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.MemoryHandler._m7.native == global::System.IntPtr.Zero)
				global::java.util.logging.MemoryHandler._m7 = @__env.GetMethodIDNoThrow(global::java.util.logging.MemoryHandler.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.MemoryHandler.staticClass, global::java.util.logging.MemoryHandler._m7);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public MemoryHandler(java.util.logging.Handler arg0, int arg1, java.util.logging.Level arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.MemoryHandler._m8.native == global::System.IntPtr.Zero)
				global::java.util.logging.MemoryHandler._m8 = @__env.GetMethodIDNoThrow(global::java.util.logging.MemoryHandler.staticClass, "<init>", "(Ljava/util/logging/Handler;ILjava/util/logging/Level;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.MemoryHandler.staticClass, global::java.util.logging.MemoryHandler._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static MemoryHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.MemoryHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/MemoryHandler"));
		}
	}
}
