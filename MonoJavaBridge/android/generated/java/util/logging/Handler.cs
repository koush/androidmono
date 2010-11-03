namespace java.util.logging
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.logging.Handler_))]
	public abstract partial class Handler : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Handler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract void flush();
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract void close();
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.String getEncoding()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.logging.Handler.staticClass, "getEncoding", "()Ljava/lang/String;", ref global::java.util.logging.Handler._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setEncoding(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Handler.staticClass, "setEncoding", "(Ljava/lang/String;)V", ref global::java.util.logging.Handler._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setLevel(java.util.logging.Level arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Handler.staticClass, "setLevel", "(Ljava/util/logging/Level;)V", ref global::java.util.logging.Handler._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.util.logging.Level getLevel()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.logging.Handler.staticClass, "getLevel", "()Ljava/util/logging/Level;", ref global::java.util.logging.Handler._m5) as java.util.logging.Level;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.util.logging.Filter getFilter()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.logging.Filter>(this, global::java.util.logging.Handler.staticClass, "getFilter", "()Ljava/util/logging/Filter;", ref global::java.util.logging.Handler._m6) as java.util.logging.Filter;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setFilter(java.util.logging.Filter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Handler.staticClass, "setFilter", "(Ljava/util/logging/Filter;)V", ref global::java.util.logging.Handler._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual bool isLoggable(java.util.logging.LogRecord arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.logging.Handler.staticClass, "isLoggable", "(Ljava/util/logging/LogRecord;)Z", ref global::java.util.logging.Handler._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public abstract void publish(java.util.logging.LogRecord arg0);
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setFormatter(java.util.logging.Formatter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Handler.staticClass, "setFormatter", "(Ljava/util/logging/Formatter;)V", ref global::java.util.logging.Handler._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::java.util.logging.Formatter getFormatter()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.logging.Handler.staticClass, "getFormatter", "()Ljava/util/logging/Formatter;", ref global::java.util.logging.Handler._m11) as java.util.logging.Formatter;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setErrorManager(java.util.logging.ErrorManager arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Handler.staticClass, "setErrorManager", "(Ljava/util/logging/ErrorManager;)V", ref global::java.util.logging.Handler._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::java.util.logging.ErrorManager getErrorManager()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.logging.Handler.staticClass, "getErrorManager", "()Ljava/util/logging/ErrorManager;", ref global::java.util.logging.Handler._m13) as java.util.logging.ErrorManager;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		protected virtual void reportError(java.lang.String arg0, java.lang.Exception arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Handler.staticClass, "reportError", "(Ljava/lang/String;Ljava/lang/Exception;I)V", ref global::java.util.logging.Handler._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		protected Handler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.Handler._m15.native == global::System.IntPtr.Zero)
				global::java.util.logging.Handler._m15 = @__env.GetMethodIDNoThrow(global::java.util.logging.Handler.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.Handler.staticClass, global::java.util.logging.Handler._m15);
			Init(@__env, handle);
		}
		static Handler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.Handler.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/Handler"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.logging.Handler))]
	internal sealed partial class Handler_ : java.util.logging.Handler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Handler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Handler_.staticClass, "flush", "()V", ref global::java.util.logging.Handler_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Handler_.staticClass, "close", "()V", ref global::java.util.logging.Handler_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void publish(java.util.logging.LogRecord arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Handler_.staticClass, "publish", "(Ljava/util/logging/LogRecord;)V", ref global::java.util.logging.Handler_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Handler_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.Handler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/Handler"));
		}
	}
}
