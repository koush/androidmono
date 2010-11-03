namespace java.util.logging
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LogManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LogManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.String getProperty(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.logging.LogManager.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/String;", ref global::java.util.logging.LogManager._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void checkAccess()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.LogManager.staticClass, "checkAccess", "()V", ref global::java.util.logging.LogManager._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.LogManager.staticClass, "reset", "()V", ref global::java.util.logging.LogManager._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.util.logging.Logger getLogger(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.logging.LogManager.staticClass, "getLogger", "(Ljava/lang/String;)Ljava/util/logging/Logger;", ref global::java.util.logging.LogManager._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.logging.Logger;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void addPropertyChangeListener(java.beans.PropertyChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.LogManager.staticClass, "addPropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", ref global::java.util.logging.LogManager._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void removePropertyChangeListener(java.beans.PropertyChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.LogManager.staticClass, "removePropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", ref global::java.util.logging.LogManager._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::java.util.logging.LogManager getLogManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.LogManager._m6.native == global::System.IntPtr.Zero)
				global::java.util.logging.LogManager._m6 = @__env.GetStaticMethodIDNoThrow(global::java.util.logging.LogManager.staticClass, "getLogManager", "()Ljava/util/logging/LogManager;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.logging.LogManager.staticClass, global::java.util.logging.LogManager._m6)) as java.util.logging.LogManager;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool addLogger(java.util.logging.Logger arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.logging.LogManager.staticClass, "addLogger", "(Ljava/util/logging/Logger;)Z", ref global::java.util.logging.LogManager._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.Enumeration LoggerNames
		{
			get
			{
				return getLoggerNames();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.util.Enumeration getLoggerNames()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.util.logging.LogManager.staticClass, "getLoggerNames", "()Ljava/util/Enumeration;", ref global::java.util.logging.LogManager._m8) as java.util.Enumeration;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void readConfiguration(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.LogManager.staticClass, "readConfiguration", "(Ljava/io/InputStream;)V", ref global::java.util.logging.LogManager._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void readConfiguration()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.LogManager.staticClass, "readConfiguration", "()V", ref global::java.util.logging.LogManager._m10);
		}
		public static global::java.util.logging.LoggingMXBean LoggingMXBean
		{
			get
			{
				return getLoggingMXBean();
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static global::java.util.logging.LoggingMXBean getLoggingMXBean()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.LogManager._m11.native == global::System.IntPtr.Zero)
				global::java.util.logging.LogManager._m11 = @__env.GetStaticMethodIDNoThrow(global::java.util.logging.LogManager.staticClass, "getLoggingMXBean", "()Ljava/util/logging/LoggingMXBean;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.logging.LoggingMXBean>(@__env.CallStaticObjectMethod(java.util.logging.LogManager.staticClass, global::java.util.logging.LogManager._m11)) as java.util.logging.LoggingMXBean;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		protected LogManager() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.LogManager._m12.native == global::System.IntPtr.Zero)
				global::java.util.logging.LogManager._m12 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogManager.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.LogManager.staticClass, global::java.util.logging.LogManager._m12);
			Init(@__env, handle);
		}
		public static global::java.lang.String LOGGING_MXBEAN_NAME
		{
			get
			{
				return "java.util.logging:type=Logging";
			}
		}
		static LogManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.LogManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/LogManager"));
		}
	}
}
