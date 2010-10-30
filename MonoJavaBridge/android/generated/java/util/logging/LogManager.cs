namespace java.util.logging
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LogManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LogManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getProperty27997;
		public virtual global::java.lang.String getProperty(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.logging.LogManager.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/String;", ref global::java.util.logging.LogManager._getProperty27997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _checkAccess27998;
		public virtual void checkAccess()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.LogManager.staticClass, "checkAccess", "()V", ref global::java.util.logging.LogManager._checkAccess27998);
		}
		internal static global::MonoJavaBridge.MethodId _reset27999;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.LogManager.staticClass, "reset", "()V", ref global::java.util.logging.LogManager._reset27999);
		}
		internal static global::MonoJavaBridge.MethodId _getLogger28000;
		public virtual global::java.util.logging.Logger getLogger(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.logging.LogManager.staticClass, "getLogger", "(Ljava/lang/String;)Ljava/util/logging/Logger;", ref global::java.util.logging.LogManager._getLogger28000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.logging.Logger;
		}
		internal static global::MonoJavaBridge.MethodId _addPropertyChangeListener28001;
		public virtual void addPropertyChangeListener(java.beans.PropertyChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.LogManager.staticClass, "addPropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", ref global::java.util.logging.LogManager._addPropertyChangeListener28001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removePropertyChangeListener28002;
		public virtual void removePropertyChangeListener(java.beans.PropertyChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.LogManager.staticClass, "removePropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", ref global::java.util.logging.LogManager._removePropertyChangeListener28002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLogManager28003;
		public static global::java.util.logging.LogManager getLogManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.LogManager._getLogManager28003.native == global::System.IntPtr.Zero)
				global::java.util.logging.LogManager._getLogManager28003 = @__env.GetStaticMethodIDNoThrow(global::java.util.logging.LogManager.staticClass, "getLogManager", "()Ljava/util/logging/LogManager;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.logging.LogManager.staticClass, global::java.util.logging.LogManager._getLogManager28003)) as java.util.logging.LogManager;
		}
		internal static global::MonoJavaBridge.MethodId _addLogger28004;
		public virtual bool addLogger(java.util.logging.Logger arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.logging.LogManager.staticClass, "addLogger", "(Ljava/util/logging/Logger;)Z", ref global::java.util.logging.LogManager._addLogger28004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.Enumeration LoggerNames
		{
			get
			{
				return getLoggerNames();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLoggerNames28005;
		public virtual global::java.util.Enumeration getLoggerNames()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.util.logging.LogManager.staticClass, "getLoggerNames", "()Ljava/util/Enumeration;", ref global::java.util.logging.LogManager._getLoggerNames28005) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _readConfiguration28006;
		public virtual void readConfiguration(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.LogManager.staticClass, "readConfiguration", "(Ljava/io/InputStream;)V", ref global::java.util.logging.LogManager._readConfiguration28006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readConfiguration28007;
		public virtual void readConfiguration()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.LogManager.staticClass, "readConfiguration", "()V", ref global::java.util.logging.LogManager._readConfiguration28007);
		}
		public static global::java.util.logging.LoggingMXBean LoggingMXBean
		{
			get
			{
				return getLoggingMXBean();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLoggingMXBean28008;
		public static global::java.util.logging.LoggingMXBean getLoggingMXBean()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.LogManager._getLoggingMXBean28008.native == global::System.IntPtr.Zero)
				global::java.util.logging.LogManager._getLoggingMXBean28008 = @__env.GetStaticMethodIDNoThrow(global::java.util.logging.LogManager.staticClass, "getLoggingMXBean", "()Ljava/util/logging/LoggingMXBean;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.logging.LoggingMXBean>(@__env.CallStaticObjectMethod(java.util.logging.LogManager.staticClass, global::java.util.logging.LogManager._getLoggingMXBean28008)) as java.util.logging.LoggingMXBean;
		}
		internal static global::MonoJavaBridge.MethodId _LogManager28009;
		protected LogManager() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.LogManager._LogManager28009.native == global::System.IntPtr.Zero)
				global::java.util.logging.LogManager._LogManager28009 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogManager.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.LogManager.staticClass, global::java.util.logging.LogManager._LogManager28009);
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
		internal static void InitJNI()
		{
		}
	}
}
