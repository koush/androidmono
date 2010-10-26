namespace java.util.logging
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LogManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LogManager()
		{
			InitJNI();
		}
		protected LogManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getProperty27996;
		public virtual global::java.lang.String getProperty(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.LogManager._getProperty27996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.LogManager.staticClass, global::java.util.logging.LogManager._getProperty27996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _checkAccess27997;
		public virtual void checkAccess() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.LogManager._checkAccess27997);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.LogManager.staticClass, global::java.util.logging.LogManager._checkAccess27997);
		}
		internal static global::MonoJavaBridge.MethodId _reset27998;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.LogManager._reset27998);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.LogManager.staticClass, global::java.util.logging.LogManager._reset27998);
		}
		internal static global::MonoJavaBridge.MethodId _getLogger27999;
		public virtual global::java.util.logging.Logger getLogger(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.LogManager._getLogger27999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.logging.Logger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.LogManager.staticClass, global::java.util.logging.LogManager._getLogger27999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.logging.Logger;
		}
		internal static global::MonoJavaBridge.MethodId _addPropertyChangeListener28000;
		public virtual void addPropertyChangeListener(java.beans.PropertyChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.LogManager._addPropertyChangeListener28000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.LogManager.staticClass, global::java.util.logging.LogManager._addPropertyChangeListener28000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removePropertyChangeListener28001;
		public virtual void removePropertyChangeListener(java.beans.PropertyChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.LogManager._removePropertyChangeListener28001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.LogManager.staticClass, global::java.util.logging.LogManager._removePropertyChangeListener28001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLogManager28002;
		public static global::java.util.logging.LogManager getLogManager() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.logging.LogManager.staticClass, global::java.util.logging.LogManager._getLogManager28002)) as java.util.logging.LogManager;
		}
		internal static global::MonoJavaBridge.MethodId _addLogger28003;
		public virtual bool addLogger(java.util.logging.Logger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.logging.LogManager._addLogger28003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.logging.LogManager.staticClass, global::java.util.logging.LogManager._addLogger28003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.Enumeration LoggerNames
		{
			get
			{
				return getLoggerNames();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLoggerNames28004;
		public virtual global::java.util.Enumeration getLoggerNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.LogManager._getLoggerNames28004)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.LogManager.staticClass, global::java.util.logging.LogManager._getLoggerNames28004)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _readConfiguration28005;
		public virtual void readConfiguration(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.LogManager._readConfiguration28005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.LogManager.staticClass, global::java.util.logging.LogManager._readConfiguration28005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readConfiguration28006;
		public virtual void readConfiguration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.LogManager._readConfiguration28006);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.LogManager.staticClass, global::java.util.logging.LogManager._readConfiguration28006);
		}
		public static global::java.util.logging.LoggingMXBean LoggingMXBean
		{
			get
			{
				return getLoggingMXBean();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLoggingMXBean28007;
		public static global::java.util.logging.LoggingMXBean getLoggingMXBean() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.logging.LoggingMXBean>(@__env.CallStaticObjectMethod(java.util.logging.LogManager.staticClass, global::java.util.logging.LogManager._getLoggingMXBean28007)) as java.util.logging.LoggingMXBean;
		}
		internal static global::MonoJavaBridge.MethodId _LogManager28008;
		protected LogManager()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.LogManager.staticClass, global::java.util.logging.LogManager._LogManager28008);
			Init(@__env, handle);
		}
		public static global::java.lang.String LOGGING_MXBEAN_NAME
		{
			get
			{
				return "java.util.logging:type=Logging";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.LogManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/LogManager"));
			global::java.util.logging.LogManager._getProperty27996 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogManager.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.logging.LogManager._checkAccess27997 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogManager.staticClass, "checkAccess", "()V");
			global::java.util.logging.LogManager._reset27998 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogManager.staticClass, "reset", "()V");
			global::java.util.logging.LogManager._getLogger27999 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogManager.staticClass, "getLogger", "(Ljava/lang/String;)Ljava/util/logging/Logger;");
			global::java.util.logging.LogManager._addPropertyChangeListener28000 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogManager.staticClass, "addPropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V");
			global::java.util.logging.LogManager._removePropertyChangeListener28001 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogManager.staticClass, "removePropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V");
			global::java.util.logging.LogManager._getLogManager28002 = @__env.GetStaticMethodIDNoThrow(global::java.util.logging.LogManager.staticClass, "getLogManager", "()Ljava/util/logging/LogManager;");
			global::java.util.logging.LogManager._addLogger28003 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogManager.staticClass, "addLogger", "(Ljava/util/logging/Logger;)Z");
			global::java.util.logging.LogManager._getLoggerNames28004 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogManager.staticClass, "getLoggerNames", "()Ljava/util/Enumeration;");
			global::java.util.logging.LogManager._readConfiguration28005 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogManager.staticClass, "readConfiguration", "(Ljava/io/InputStream;)V");
			global::java.util.logging.LogManager._readConfiguration28006 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogManager.staticClass, "readConfiguration", "()V");
			global::java.util.logging.LogManager._getLoggingMXBean28007 = @__env.GetStaticMethodIDNoThrow(global::java.util.logging.LogManager.staticClass, "getLoggingMXBean", "()Ljava/util/logging/LoggingMXBean;");
			global::java.util.logging.LogManager._LogManager28008 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogManager.staticClass, "<init>", "()V");
		}
	}
}
