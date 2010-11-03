namespace java.util.logging
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.logging.LoggingMXBean_))]
	public partial interface LoggingMXBean  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.util.List getLoggerNames();
		global::java.lang.String getLoggerLevel(java.lang.String arg0);
		void setLoggerLevel(java.lang.String arg0, java.lang.String arg1);
		global::java.lang.String getParentLoggerName(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.logging.LoggingMXBean))]
	internal sealed partial class LoggingMXBean_ : java.lang.Object, LoggingMXBean
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal LoggingMXBean_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.util.List java.util.logging.LoggingMXBean.getLoggerNames()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::java.util.logging.LoggingMXBean_.staticClass, "getLoggerNames", "()Ljava/util/List;", ref global::java.util.logging.LoggingMXBean_._m0) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.String java.util.logging.LoggingMXBean.getLoggerLevel(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.logging.LoggingMXBean_.staticClass, "getLoggerLevel", "(Ljava/lang/String;)Ljava/lang/String;", ref global::java.util.logging.LoggingMXBean_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void java.util.logging.LoggingMXBean.setLoggerLevel(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.LoggingMXBean_.staticClass, "setLoggerLevel", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::java.util.logging.LoggingMXBean_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.lang.String java.util.logging.LoggingMXBean.getParentLoggerName(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.logging.LoggingMXBean_.staticClass, "getParentLoggerName", "(Ljava/lang/String;)Ljava/lang/String;", ref global::java.util.logging.LoggingMXBean_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		static LoggingMXBean_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.LoggingMXBean_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/LoggingMXBean"));
		}
	}
}
