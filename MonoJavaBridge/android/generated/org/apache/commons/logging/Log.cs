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
		internal static global::MonoJavaBridge.MethodId _debug31472;
		void org.apache.commons.logging.Log.debug(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.commons.logging.Log_.staticClass, "debug", "(Ljava/lang/Object;)V", ref global::org.apache.commons.logging.Log_._debug31472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _debug31473;
		void org.apache.commons.logging.Log.debug(java.lang.Object arg0, java.lang.Throwable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.commons.logging.Log_.staticClass, "debug", "(Ljava/lang/Object;Ljava/lang/Throwable;)V", ref global::org.apache.commons.logging.Log_._debug31473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _error31474;
		void org.apache.commons.logging.Log.error(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.commons.logging.Log_.staticClass, "error", "(Ljava/lang/Object;)V", ref global::org.apache.commons.logging.Log_._error31474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _error31475;
		void org.apache.commons.logging.Log.error(java.lang.Object arg0, java.lang.Throwable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.commons.logging.Log_.staticClass, "error", "(Ljava/lang/Object;Ljava/lang/Throwable;)V", ref global::org.apache.commons.logging.Log_._error31475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _info31476;
		void org.apache.commons.logging.Log.info(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.commons.logging.Log_.staticClass, "info", "(Ljava/lang/Object;)V", ref global::org.apache.commons.logging.Log_._info31476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _info31477;
		void org.apache.commons.logging.Log.info(java.lang.Object arg0, java.lang.Throwable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.commons.logging.Log_.staticClass, "info", "(Ljava/lang/Object;Ljava/lang/Throwable;)V", ref global::org.apache.commons.logging.Log_._info31477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _trace31478;
		void org.apache.commons.logging.Log.trace(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.commons.logging.Log_.staticClass, "trace", "(Ljava/lang/Object;)V", ref global::org.apache.commons.logging.Log_._trace31478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _trace31479;
		void org.apache.commons.logging.Log.trace(java.lang.Object arg0, java.lang.Throwable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.commons.logging.Log_.staticClass, "trace", "(Ljava/lang/Object;Ljava/lang/Throwable;)V", ref global::org.apache.commons.logging.Log_._trace31479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isDebugEnabled31480;
		bool org.apache.commons.logging.Log.isDebugEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.commons.logging.Log_.staticClass, "isDebugEnabled", "()Z", ref global::org.apache.commons.logging.Log_._isDebugEnabled31480);
		}
		internal static global::MonoJavaBridge.MethodId _isErrorEnabled31481;
		bool org.apache.commons.logging.Log.isErrorEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.commons.logging.Log_.staticClass, "isErrorEnabled", "()Z", ref global::org.apache.commons.logging.Log_._isErrorEnabled31481);
		}
		internal static global::MonoJavaBridge.MethodId _isFatalEnabled31482;
		bool org.apache.commons.logging.Log.isFatalEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.commons.logging.Log_.staticClass, "isFatalEnabled", "()Z", ref global::org.apache.commons.logging.Log_._isFatalEnabled31482);
		}
		internal static global::MonoJavaBridge.MethodId _isInfoEnabled31483;
		bool org.apache.commons.logging.Log.isInfoEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.commons.logging.Log_.staticClass, "isInfoEnabled", "()Z", ref global::org.apache.commons.logging.Log_._isInfoEnabled31483);
		}
		internal static global::MonoJavaBridge.MethodId _isTraceEnabled31484;
		bool org.apache.commons.logging.Log.isTraceEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.commons.logging.Log_.staticClass, "isTraceEnabled", "()Z", ref global::org.apache.commons.logging.Log_._isTraceEnabled31484);
		}
		internal static global::MonoJavaBridge.MethodId _isWarnEnabled31485;
		bool org.apache.commons.logging.Log.isWarnEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.commons.logging.Log_.staticClass, "isWarnEnabled", "()Z", ref global::org.apache.commons.logging.Log_._isWarnEnabled31485);
		}
		internal static global::MonoJavaBridge.MethodId _warn31486;
		void org.apache.commons.logging.Log.warn(java.lang.Object arg0, java.lang.Throwable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.commons.logging.Log_.staticClass, "warn", "(Ljava/lang/Object;Ljava/lang/Throwable;)V", ref global::org.apache.commons.logging.Log_._warn31486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _warn31487;
		void org.apache.commons.logging.Log.warn(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.commons.logging.Log_.staticClass, "warn", "(Ljava/lang/Object;)V", ref global::org.apache.commons.logging.Log_._warn31487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _fatal31488;
		void org.apache.commons.logging.Log.fatal(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.commons.logging.Log_.staticClass, "fatal", "(Ljava/lang/Object;)V", ref global::org.apache.commons.logging.Log_._fatal31488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _fatal31489;
		void org.apache.commons.logging.Log.fatal(java.lang.Object arg0, java.lang.Throwable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.commons.logging.Log_.staticClass, "fatal", "(Ljava/lang/Object;Ljava/lang/Throwable;)V", ref global::org.apache.commons.logging.Log_._fatal31489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static Log_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.commons.logging.Log_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/commons/logging/Log"));
		}
		internal static void InitJNI()
		{
		}
	}
}
