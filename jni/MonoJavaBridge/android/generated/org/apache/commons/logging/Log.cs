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
		internal static global::MonoJavaBridge.MethodId _debug24864;
		 void org.apache.commons.logging.Log.debug(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._debug24864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._debug24864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _debug24865;
		 void org.apache.commons.logging.Log.debug(java.lang.Object arg0, java.lang.Throwable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._debug24865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._debug24865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _error24866;
		 void org.apache.commons.logging.Log.error(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._error24866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._error24866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _error24867;
		 void org.apache.commons.logging.Log.error(java.lang.Object arg0, java.lang.Throwable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._error24867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._error24867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _info24868;
		 void org.apache.commons.logging.Log.info(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._info24868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._info24868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _info24869;
		 void org.apache.commons.logging.Log.info(java.lang.Object arg0, java.lang.Throwable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._info24869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._info24869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _trace24870;
		 void org.apache.commons.logging.Log.trace(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._trace24870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._trace24870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _trace24871;
		 void org.apache.commons.logging.Log.trace(java.lang.Object arg0, java.lang.Throwable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._trace24871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._trace24871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isDebugEnabled24872;
		 bool org.apache.commons.logging.Log.isDebugEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._isDebugEnabled24872);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._isDebugEnabled24872);
		}
		internal static global::MonoJavaBridge.MethodId _isErrorEnabled24873;
		 bool org.apache.commons.logging.Log.isErrorEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._isErrorEnabled24873);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._isErrorEnabled24873);
		}
		internal static global::MonoJavaBridge.MethodId _isFatalEnabled24874;
		 bool org.apache.commons.logging.Log.isFatalEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._isFatalEnabled24874);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._isFatalEnabled24874);
		}
		internal static global::MonoJavaBridge.MethodId _isInfoEnabled24875;
		 bool org.apache.commons.logging.Log.isInfoEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._isInfoEnabled24875);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._isInfoEnabled24875);
		}
		internal static global::MonoJavaBridge.MethodId _isTraceEnabled24876;
		 bool org.apache.commons.logging.Log.isTraceEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._isTraceEnabled24876);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._isTraceEnabled24876);
		}
		internal static global::MonoJavaBridge.MethodId _isWarnEnabled24877;
		 bool org.apache.commons.logging.Log.isWarnEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._isWarnEnabled24877);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._isWarnEnabled24877);
		}
		internal static global::MonoJavaBridge.MethodId _warn24878;
		 void org.apache.commons.logging.Log.warn(java.lang.Object arg0, java.lang.Throwable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._warn24878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._warn24878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _warn24879;
		 void org.apache.commons.logging.Log.warn(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._warn24879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._warn24879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _fatal24880;
		 void org.apache.commons.logging.Log.fatal(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._fatal24880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._fatal24880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _fatal24881;
		 void org.apache.commons.logging.Log.fatal(java.lang.Object arg0, java.lang.Throwable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._fatal24881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._fatal24881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.commons.logging.Log_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/commons/logging/Log"));
			global::org.apache.commons.logging.Log_._debug24864 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "debug", "(Ljava/lang/Object;)V");
			global::org.apache.commons.logging.Log_._debug24865 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "debug", "(Ljava/lang/Object;Ljava/lang/Throwable;)V");
			global::org.apache.commons.logging.Log_._error24866 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "error", "(Ljava/lang/Object;)V");
			global::org.apache.commons.logging.Log_._error24867 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "error", "(Ljava/lang/Object;Ljava/lang/Throwable;)V");
			global::org.apache.commons.logging.Log_._info24868 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "info", "(Ljava/lang/Object;)V");
			global::org.apache.commons.logging.Log_._info24869 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "info", "(Ljava/lang/Object;Ljava/lang/Throwable;)V");
			global::org.apache.commons.logging.Log_._trace24870 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "trace", "(Ljava/lang/Object;)V");
			global::org.apache.commons.logging.Log_._trace24871 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "trace", "(Ljava/lang/Object;Ljava/lang/Throwable;)V");
			global::org.apache.commons.logging.Log_._isDebugEnabled24872 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "isDebugEnabled", "()Z");
			global::org.apache.commons.logging.Log_._isErrorEnabled24873 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "isErrorEnabled", "()Z");
			global::org.apache.commons.logging.Log_._isFatalEnabled24874 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "isFatalEnabled", "()Z");
			global::org.apache.commons.logging.Log_._isInfoEnabled24875 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "isInfoEnabled", "()Z");
			global::org.apache.commons.logging.Log_._isTraceEnabled24876 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "isTraceEnabled", "()Z");
			global::org.apache.commons.logging.Log_._isWarnEnabled24877 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "isWarnEnabled", "()Z");
			global::org.apache.commons.logging.Log_._warn24878 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "warn", "(Ljava/lang/Object;Ljava/lang/Throwable;)V");
			global::org.apache.commons.logging.Log_._warn24879 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "warn", "(Ljava/lang/Object;)V");
			global::org.apache.commons.logging.Log_._fatal24880 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "fatal", "(Ljava/lang/Object;)V");
			global::org.apache.commons.logging.Log_._fatal24881 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "fatal", "(Ljava/lang/Object;Ljava/lang/Throwable;)V");
		}
	}
}
