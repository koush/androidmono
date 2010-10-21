namespace org.apache.commons.logging
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.commons.logging.Log_))]
	public interface Log  : global::MonoJavaBridge.IJavaObject 
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
	public sealed partial class Log_ : java.lang.Object, Log
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Log_()
		{
			InitJNI();
		}
		internal Log_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _debug31353;
		 void org.apache.commons.logging.Log.debug(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._debug31353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._debug31353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _debug31354;
		 void org.apache.commons.logging.Log.debug(java.lang.Object arg0, java.lang.Throwable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._debug31354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._debug31354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _error31355;
		 void org.apache.commons.logging.Log.error(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._error31355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._error31355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _error31356;
		 void org.apache.commons.logging.Log.error(java.lang.Object arg0, java.lang.Throwable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._error31356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._error31356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _info31357;
		 void org.apache.commons.logging.Log.info(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._info31357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._info31357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _info31358;
		 void org.apache.commons.logging.Log.info(java.lang.Object arg0, java.lang.Throwable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._info31358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._info31358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _trace31359;
		 void org.apache.commons.logging.Log.trace(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._trace31359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._trace31359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _trace31360;
		 void org.apache.commons.logging.Log.trace(java.lang.Object arg0, java.lang.Throwable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._trace31360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._trace31360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isDebugEnabled31361;
		 bool org.apache.commons.logging.Log.isDebugEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._isDebugEnabled31361);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._isDebugEnabled31361);
		}
		internal static global::MonoJavaBridge.MethodId _isErrorEnabled31362;
		 bool org.apache.commons.logging.Log.isErrorEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._isErrorEnabled31362);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._isErrorEnabled31362);
		}
		internal static global::MonoJavaBridge.MethodId _isFatalEnabled31363;
		 bool org.apache.commons.logging.Log.isFatalEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._isFatalEnabled31363);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._isFatalEnabled31363);
		}
		internal static global::MonoJavaBridge.MethodId _isInfoEnabled31364;
		 bool org.apache.commons.logging.Log.isInfoEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._isInfoEnabled31364);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._isInfoEnabled31364);
		}
		internal static global::MonoJavaBridge.MethodId _isTraceEnabled31365;
		 bool org.apache.commons.logging.Log.isTraceEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._isTraceEnabled31365);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._isTraceEnabled31365);
		}
		internal static global::MonoJavaBridge.MethodId _isWarnEnabled31366;
		 bool org.apache.commons.logging.Log.isWarnEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._isWarnEnabled31366);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._isWarnEnabled31366);
		}
		internal static global::MonoJavaBridge.MethodId _warn31367;
		 void org.apache.commons.logging.Log.warn(java.lang.Object arg0, java.lang.Throwable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._warn31367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._warn31367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _warn31368;
		 void org.apache.commons.logging.Log.warn(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._warn31368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._warn31368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _fatal31369;
		 void org.apache.commons.logging.Log.fatal(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._fatal31369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._fatal31369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _fatal31370;
		 void org.apache.commons.logging.Log.fatal(java.lang.Object arg0, java.lang.Throwable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._fatal31370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._fatal31370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.commons.logging.Log_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/commons/logging/Log"));
			global::org.apache.commons.logging.Log_._debug31353 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "debug", "(Ljava/lang/Object;)V");
			global::org.apache.commons.logging.Log_._debug31354 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "debug", "(Ljava/lang/Object;Ljava/lang/Throwable;)V");
			global::org.apache.commons.logging.Log_._error31355 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "error", "(Ljava/lang/Object;)V");
			global::org.apache.commons.logging.Log_._error31356 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "error", "(Ljava/lang/Object;Ljava/lang/Throwable;)V");
			global::org.apache.commons.logging.Log_._info31357 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "info", "(Ljava/lang/Object;)V");
			global::org.apache.commons.logging.Log_._info31358 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "info", "(Ljava/lang/Object;Ljava/lang/Throwable;)V");
			global::org.apache.commons.logging.Log_._trace31359 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "trace", "(Ljava/lang/Object;)V");
			global::org.apache.commons.logging.Log_._trace31360 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "trace", "(Ljava/lang/Object;Ljava/lang/Throwable;)V");
			global::org.apache.commons.logging.Log_._isDebugEnabled31361 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "isDebugEnabled", "()Z");
			global::org.apache.commons.logging.Log_._isErrorEnabled31362 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "isErrorEnabled", "()Z");
			global::org.apache.commons.logging.Log_._isFatalEnabled31363 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "isFatalEnabled", "()Z");
			global::org.apache.commons.logging.Log_._isInfoEnabled31364 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "isInfoEnabled", "()Z");
			global::org.apache.commons.logging.Log_._isTraceEnabled31365 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "isTraceEnabled", "()Z");
			global::org.apache.commons.logging.Log_._isWarnEnabled31366 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "isWarnEnabled", "()Z");
			global::org.apache.commons.logging.Log_._warn31367 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "warn", "(Ljava/lang/Object;Ljava/lang/Throwable;)V");
			global::org.apache.commons.logging.Log_._warn31368 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "warn", "(Ljava/lang/Object;)V");
			global::org.apache.commons.logging.Log_._fatal31369 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "fatal", "(Ljava/lang/Object;)V");
			global::org.apache.commons.logging.Log_._fatal31370 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "fatal", "(Ljava/lang/Object;Ljava/lang/Throwable;)V");
		}
	}
}
