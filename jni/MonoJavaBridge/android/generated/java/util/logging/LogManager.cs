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
		internal static global::MonoJavaBridge.MethodId _getProperty27878;
		public virtual global::java.lang.String getProperty(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.LogManager._getProperty27878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.LogManager.staticClass, global::java.util.logging.LogManager._getProperty27878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _checkAccess27879;
		public virtual void checkAccess() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.LogManager._checkAccess27879);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.LogManager.staticClass, global::java.util.logging.LogManager._checkAccess27879);
		}
		internal static global::MonoJavaBridge.MethodId _reset27880;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.LogManager._reset27880);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.LogManager.staticClass, global::java.util.logging.LogManager._reset27880);
		}
		internal static global::MonoJavaBridge.MethodId _getLogger27881;
		public virtual global::java.util.logging.Logger getLogger(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.LogManager._getLogger27881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.logging.Logger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.LogManager.staticClass, global::java.util.logging.LogManager._getLogger27881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.logging.Logger;
		}
		internal static global::MonoJavaBridge.MethodId _addPropertyChangeListener27882;
		public virtual void addPropertyChangeListener(java.beans.PropertyChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.LogManager._addPropertyChangeListener27882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.LogManager.staticClass, global::java.util.logging.LogManager._addPropertyChangeListener27882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removePropertyChangeListener27883;
		public virtual void removePropertyChangeListener(java.beans.PropertyChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.LogManager._removePropertyChangeListener27883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.LogManager.staticClass, global::java.util.logging.LogManager._removePropertyChangeListener27883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLogManager27884;
		public static global::java.util.logging.LogManager getLogManager() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.logging.LogManager.staticClass, global::java.util.logging.LogManager._getLogManager27884)) as java.util.logging.LogManager;
		}
		internal static global::MonoJavaBridge.MethodId _addLogger27885;
		public virtual bool addLogger(java.util.logging.Logger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.logging.LogManager._addLogger27885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.logging.LogManager.staticClass, global::java.util.logging.LogManager._addLogger27885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.Enumeration LoggerNames
		{
			get
			{
				return getLoggerNames();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLoggerNames27886;
		public virtual global::java.util.Enumeration getLoggerNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.LogManager._getLoggerNames27886)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.LogManager.staticClass, global::java.util.logging.LogManager._getLoggerNames27886)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _readConfiguration27887;
		public virtual void readConfiguration(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.LogManager._readConfiguration27887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.LogManager.staticClass, global::java.util.logging.LogManager._readConfiguration27887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readConfiguration27888;
		public virtual void readConfiguration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.LogManager._readConfiguration27888);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.LogManager.staticClass, global::java.util.logging.LogManager._readConfiguration27888);
		}
		public static global::java.util.logging.LoggingMXBean LoggingMXBean
		{
			get
			{
				return getLoggingMXBean();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLoggingMXBean27889;
		public static global::java.util.logging.LoggingMXBean getLoggingMXBean() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.logging.LoggingMXBean>(@__env.CallStaticObjectMethod(java.util.logging.LogManager.staticClass, global::java.util.logging.LogManager._getLoggingMXBean27889)) as java.util.logging.LoggingMXBean;
		}
		internal static global::MonoJavaBridge.MethodId _LogManager27890;
		protected LogManager()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.LogManager.staticClass, global::java.util.logging.LogManager._LogManager27890);
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
			global::java.util.logging.LogManager._getProperty27878 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogManager.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.logging.LogManager._checkAccess27879 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogManager.staticClass, "checkAccess", "()V");
			global::java.util.logging.LogManager._reset27880 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogManager.staticClass, "reset", "()V");
			global::java.util.logging.LogManager._getLogger27881 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogManager.staticClass, "getLogger", "(Ljava/lang/String;)Ljava/util/logging/Logger;");
			global::java.util.logging.LogManager._addPropertyChangeListener27882 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogManager.staticClass, "addPropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V");
			global::java.util.logging.LogManager._removePropertyChangeListener27883 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogManager.staticClass, "removePropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V");
			global::java.util.logging.LogManager._getLogManager27884 = @__env.GetStaticMethodIDNoThrow(global::java.util.logging.LogManager.staticClass, "getLogManager", "()Ljava/util/logging/LogManager;");
			global::java.util.logging.LogManager._addLogger27885 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogManager.staticClass, "addLogger", "(Ljava/util/logging/Logger;)Z");
			global::java.util.logging.LogManager._getLoggerNames27886 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogManager.staticClass, "getLoggerNames", "()Ljava/util/Enumeration;");
			global::java.util.logging.LogManager._readConfiguration27887 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogManager.staticClass, "readConfiguration", "(Ljava/io/InputStream;)V");
			global::java.util.logging.LogManager._readConfiguration27888 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogManager.staticClass, "readConfiguration", "()V");
			global::java.util.logging.LogManager._getLoggingMXBean27889 = @__env.GetStaticMethodIDNoThrow(global::java.util.logging.LogManager.staticClass, "getLoggingMXBean", "()Ljava/util/logging/LoggingMXBean;");
			global::java.util.logging.LogManager._LogManager27890 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogManager.staticClass, "<init>", "()V");
		}
	}
}
