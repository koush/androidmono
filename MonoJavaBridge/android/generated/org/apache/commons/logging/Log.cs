namespace org.apache.commons.logging
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.commons.logging.Log_))]
	public partial interface Log  : global::MonoJavaBridge.IJavaObject 
	{
		void debug(java.lang.Object arg0);
		void debug(java.lang.Object arg0, java.lang.Throwable arg1);
		void error(java.lang.Object arg0);
		void error(java.lang.Object arg0, java.lang.Throwable arg1);
		void info(java.lang.Object arg0);
		void info(java.lang.Object arg0, java.lang.Throwable arg1);
		void trace(java.lang.Object arg0);
		void trace(java.lang.Object arg0, java.lang.Throwable arg1);
		bool isDebugEnabled();
		bool isErrorEnabled();
		bool isFatalEnabled();
		bool isInfoEnabled();
		bool isTraceEnabled();
		bool isWarnEnabled();
		void warn(java.lang.Object arg0, java.lang.Throwable arg1);
		void warn(java.lang.Object arg0);
		void fatal(java.lang.Object arg0);
		void fatal(java.lang.Object arg0, java.lang.Throwable arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.commons.logging.Log))]
	internal sealed partial class Log_ : java.lang.Object, Log
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Log_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void org.apache.commons.logging.Log.debug(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.commons.logging.Log_.staticClass, "debug", "(Ljava/lang/Object;)V", ref global::org.apache.commons.logging.Log_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void org.apache.commons.logging.Log.debug(java.lang.Object arg0, java.lang.Throwable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.commons.logging.Log_.staticClass, "debug", "(Ljava/lang/Object;Ljava/lang/Throwable;)V", ref global::org.apache.commons.logging.Log_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void org.apache.commons.logging.Log.error(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.commons.logging.Log_.staticClass, "error", "(Ljava/lang/Object;)V", ref global::org.apache.commons.logging.Log_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void org.apache.commons.logging.Log.error(java.lang.Object arg0, java.lang.Throwable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.commons.logging.Log_.staticClass, "error", "(Ljava/lang/Object;Ljava/lang/Throwable;)V", ref global::org.apache.commons.logging.Log_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void org.apache.commons.logging.Log.info(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.commons.logging.Log_.staticClass, "info", "(Ljava/lang/Object;)V", ref global::org.apache.commons.logging.Log_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		void org.apache.commons.logging.Log.info(java.lang.Object arg0, java.lang.Throwable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.commons.logging.Log_.staticClass, "info", "(Ljava/lang/Object;Ljava/lang/Throwable;)V", ref global::org.apache.commons.logging.Log_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		void org.apache.commons.logging.Log.trace(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.commons.logging.Log_.staticClass, "trace", "(Ljava/lang/Object;)V", ref global::org.apache.commons.logging.Log_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		void org.apache.commons.logging.Log.trace(java.lang.Object arg0, java.lang.Throwable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.commons.logging.Log_.staticClass, "trace", "(Ljava/lang/Object;Ljava/lang/Throwable;)V", ref global::org.apache.commons.logging.Log_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		bool org.apache.commons.logging.Log.isDebugEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.commons.logging.Log_.staticClass, "isDebugEnabled", "()Z", ref global::org.apache.commons.logging.Log_._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		bool org.apache.commons.logging.Log.isErrorEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.commons.logging.Log_.staticClass, "isErrorEnabled", "()Z", ref global::org.apache.commons.logging.Log_._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		bool org.apache.commons.logging.Log.isFatalEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.commons.logging.Log_.staticClass, "isFatalEnabled", "()Z", ref global::org.apache.commons.logging.Log_._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		bool org.apache.commons.logging.Log.isInfoEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.commons.logging.Log_.staticClass, "isInfoEnabled", "()Z", ref global::org.apache.commons.logging.Log_._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		bool org.apache.commons.logging.Log.isTraceEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.commons.logging.Log_.staticClass, "isTraceEnabled", "()Z", ref global::org.apache.commons.logging.Log_._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		bool org.apache.commons.logging.Log.isWarnEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.commons.logging.Log_.staticClass, "isWarnEnabled", "()Z", ref global::org.apache.commons.logging.Log_._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		void org.apache.commons.logging.Log.warn(java.lang.Object arg0, java.lang.Throwable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.commons.logging.Log_.staticClass, "warn", "(Ljava/lang/Object;Ljava/lang/Throwable;)V", ref global::org.apache.commons.logging.Log_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		void org.apache.commons.logging.Log.warn(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.commons.logging.Log_.staticClass, "warn", "(Ljava/lang/Object;)V", ref global::org.apache.commons.logging.Log_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		void org.apache.commons.logging.Log.fatal(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.commons.logging.Log_.staticClass, "fatal", "(Ljava/lang/Object;)V", ref global::org.apache.commons.logging.Log_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		void org.apache.commons.logging.Log.fatal(java.lang.Object arg0, java.lang.Throwable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.commons.logging.Log_.staticClass, "fatal", "(Ljava/lang/Object;Ljava/lang/Throwable;)V", ref global::org.apache.commons.logging.Log_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static Log_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.commons.logging.Log_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/commons/logging/Log"));
		}
	}
}
