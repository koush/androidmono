namespace java.util.logging
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Logger : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Logger(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _log28036;
		public virtual void log(java.util.logging.Level arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "log", "(Ljava/util/logging/Level;Ljava/lang/String;)V", ref global::java.util.logging.Logger._log28036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _log28037;
		public virtual void log(java.util.logging.Level arg0, java.lang.String arg1, java.lang.Throwable arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "log", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/Throwable;)V", ref global::java.util.logging.Logger._log28037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _log28038;
		public virtual void log(java.util.logging.Level arg0, java.lang.String arg1, java.lang.Object[] arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "log", "(Ljava/util/logging/Level;Ljava/lang/String;[Ljava/lang/Object;)V", ref global::java.util.logging.Logger._log28038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _log28039;
		public virtual void log(java.util.logging.LogRecord arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "log", "(Ljava/util/logging/LogRecord;)V", ref global::java.util.logging.Logger._log28039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _log28040;
		public virtual void log(java.util.logging.Level arg0, java.lang.String arg1, java.lang.Object arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "log", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/Object;)V", ref global::java.util.logging.Logger._log28040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName28041;
		public virtual global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.logging.Logger.staticClass, "getName", "()Ljava/lang/String;", ref global::java.util.logging.Logger._getName28041) as java.lang.String;
		}
		public new global::java.util.logging.Logger Parent
		{
			get
			{
				return getParent();
			}
			set
			{
				setParent(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParent28042;
		public virtual global::java.util.logging.Logger getParent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.logging.Logger.staticClass, "getParent", "()Ljava/util/logging/Logger;", ref global::java.util.logging.Logger._getParent28042) as java.util.logging.Logger;
		}
		internal static global::MonoJavaBridge.MethodId _setParent28043;
		public virtual void setParent(java.util.logging.Logger arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "setParent", "(Ljava/util/logging/Logger;)V", ref global::java.util.logging.Logger._setParent28043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLogger28044;
		public static global::java.util.logging.Logger getLogger(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.Logger._getLogger28044.native == global::System.IntPtr.Zero)
				global::java.util.logging.Logger._getLogger28044 = @__env.GetStaticMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "getLogger", "(Ljava/lang/String;)Ljava/util/logging/Logger;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.logging.Logger.staticClass, global::java.util.logging.Logger._getLogger28044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.logging.Logger;
		}
		internal static global::MonoJavaBridge.MethodId _getLogger28045;
		public static global::java.util.logging.Logger getLogger(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.Logger._getLogger28045.native == global::System.IntPtr.Zero)
				global::java.util.logging.Logger._getLogger28045 = @__env.GetStaticMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "getLogger", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/logging/Logger;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.logging.Logger.staticClass, global::java.util.logging.Logger._getLogger28045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.logging.Logger;
		}
		internal static global::MonoJavaBridge.MethodId _warning28046;
		public virtual void warning(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "warning", "(Ljava/lang/String;)V", ref global::java.util.logging.Logger._warning28046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _info28047;
		public virtual void info(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "info", "(Ljava/lang/String;)V", ref global::java.util.logging.Logger._info28047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _config28048;
		public virtual void config(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "config", "(Ljava/lang/String;)V", ref global::java.util.logging.Logger._config28048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLevel28049;
		public virtual void setLevel(java.util.logging.Level arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "setLevel", "(Ljava/util/logging/Level;)V", ref global::java.util.logging.Logger._setLevel28049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.logging.Level Level
		{
			get
			{
				return getLevel();
			}
			set
			{
				setLevel(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLevel28050;
		public virtual global::java.util.logging.Level getLevel()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.logging.Logger.staticClass, "getLevel", "()Ljava/util/logging/Level;", ref global::java.util.logging.Logger._getLevel28050) as java.util.logging.Level;
		}
		public new global::java.util.logging.Filter Filter
		{
			get
			{
				return getFilter();
			}
			set
			{
				setFilter(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFilter28051;
		public virtual global::java.util.logging.Filter getFilter()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.logging.Filter>(this, global::java.util.logging.Logger.staticClass, "getFilter", "()Ljava/util/logging/Filter;", ref global::java.util.logging.Logger._getFilter28051) as java.util.logging.Filter;
		}
		internal static global::MonoJavaBridge.MethodId _setFilter28052;
		public virtual void setFilter(java.util.logging.Filter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "setFilter", "(Ljava/util/logging/Filter;)V", ref global::java.util.logging.Logger._setFilter28052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _entering28053;
		public virtual void entering(java.lang.String arg0, java.lang.String arg1, java.lang.Object arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "entering", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V", ref global::java.util.logging.Logger._entering28053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _entering28054;
		public virtual void entering(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "entering", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::java.util.logging.Logger._entering28054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _entering28055;
		public virtual void entering(java.lang.String arg0, java.lang.String arg1, java.lang.Object[] arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "entering", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", ref global::java.util.logging.Logger._entering28055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isLoggable28056;
		public virtual bool isLoggable(java.util.logging.Level arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.logging.Logger.staticClass, "isLoggable", "(Ljava/util/logging/Level;)Z", ref global::java.util.logging.Logger._isLoggable28056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _fine28057;
		public virtual void fine(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "fine", "(Ljava/lang/String;)V", ref global::java.util.logging.Logger._fine28057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _finest28058;
		public virtual void finest(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "finest", "(Ljava/lang/String;)V", ref global::java.util.logging.Logger._finest28058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _finer28059;
		public virtual void finer(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "finer", "(Ljava/lang/String;)V", ref global::java.util.logging.Logger._finer28059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.util.logging.Logger AnonymousLogger
		{
			get
			{
				return getAnonymousLogger();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAnonymousLogger28060;
		public static global::java.util.logging.Logger getAnonymousLogger()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.Logger._getAnonymousLogger28060.native == global::System.IntPtr.Zero)
				global::java.util.logging.Logger._getAnonymousLogger28060 = @__env.GetStaticMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "getAnonymousLogger", "()Ljava/util/logging/Logger;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.logging.Logger.staticClass, global::java.util.logging.Logger._getAnonymousLogger28060)) as java.util.logging.Logger;
		}
		internal static global::MonoJavaBridge.MethodId _getAnonymousLogger28061;
		public static global::java.util.logging.Logger getAnonymousLogger(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.Logger._getAnonymousLogger28061.native == global::System.IntPtr.Zero)
				global::java.util.logging.Logger._getAnonymousLogger28061 = @__env.GetStaticMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "getAnonymousLogger", "(Ljava/lang/String;)Ljava/util/logging/Logger;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.logging.Logger.staticClass, global::java.util.logging.Logger._getAnonymousLogger28061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.logging.Logger;
		}
		public new global::java.util.ResourceBundle ResourceBundle
		{
			get
			{
				return getResourceBundle();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getResourceBundle28062;
		public virtual global::java.util.ResourceBundle getResourceBundle()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.logging.Logger.staticClass, "getResourceBundle", "()Ljava/util/ResourceBundle;", ref global::java.util.logging.Logger._getResourceBundle28062) as java.util.ResourceBundle;
		}
		public new global::java.lang.String ResourceBundleName
		{
			get
			{
				return getResourceBundleName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getResourceBundleName28063;
		public virtual global::java.lang.String getResourceBundleName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.logging.Logger.staticClass, "getResourceBundleName", "()Ljava/lang/String;", ref global::java.util.logging.Logger._getResourceBundleName28063) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _logp28064;
		public virtual void logp(java.util.logging.Level arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.Object arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "logp", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V", ref global::java.util.logging.Logger._logp28064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _logp28065;
		public virtual void logp(java.util.logging.Level arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "logp", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ref global::java.util.logging.Logger._logp28065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _logp28066;
		public virtual void logp(java.util.logging.Level arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.Object[] arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "logp", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", ref global::java.util.logging.Logger._logp28066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _logp28067;
		public virtual void logp(java.util.logging.Level arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.Throwable arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "logp", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", ref global::java.util.logging.Logger._logp28067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _logrb28068;
		public virtual void logrb(java.util.logging.Level arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "logrb", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ref global::java.util.logging.Logger._logrb28068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _logrb28069;
		public virtual void logrb(java.util.logging.Level arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4, java.lang.Object[] arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "logrb", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", ref global::java.util.logging.Logger._logrb28069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _logrb28070;
		public virtual void logrb(java.util.logging.Level arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4, java.lang.Throwable arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "logrb", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", ref global::java.util.logging.Logger._logrb28070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _logrb28071;
		public virtual void logrb(java.util.logging.Level arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4, java.lang.Object arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "logrb", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V", ref global::java.util.logging.Logger._logrb28071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _exiting28072;
		public virtual void exiting(java.lang.String arg0, java.lang.String arg1, java.lang.Object arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "exiting", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V", ref global::java.util.logging.Logger._exiting28072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _exiting28073;
		public virtual void exiting(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "exiting", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::java.util.logging.Logger._exiting28073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _throwing28074;
		public virtual void throwing(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "throwing", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", ref global::java.util.logging.Logger._throwing28074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _severe28075;
		public virtual void severe(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "severe", "(Ljava/lang/String;)V", ref global::java.util.logging.Logger._severe28075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addHandler28076;
		public virtual void addHandler(java.util.logging.Handler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "addHandler", "(Ljava/util/logging/Handler;)V", ref global::java.util.logging.Logger._addHandler28076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeHandler28077;
		public virtual void removeHandler(java.util.logging.Handler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "removeHandler", "(Ljava/util/logging/Handler;)V", ref global::java.util.logging.Logger._removeHandler28077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.logging.Handler[] Handlers
		{
			get
			{
				return getHandlers();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHandlers28078;
		public virtual global::java.util.logging.Handler[] getHandlers()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.util.logging.Handler>(this, global::java.util.logging.Logger.staticClass, "getHandlers", "()[Ljava/util/logging/Handler;", ref global::java.util.logging.Logger._getHandlers28078) as java.util.logging.Handler[];
		}
		internal static global::MonoJavaBridge.MethodId _setUseParentHandlers28079;
		public virtual void setUseParentHandlers(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "setUseParentHandlers", "(Z)V", ref global::java.util.logging.Logger._setUseParentHandlers28079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool UseParentHandlers
		{
			get
			{
				return getUseParentHandlers();
			}
			set
			{
				setUseParentHandlers(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUseParentHandlers28080;
		public virtual bool getUseParentHandlers()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.logging.Logger.staticClass, "getUseParentHandlers", "()Z", ref global::java.util.logging.Logger._getUseParentHandlers28080);
		}
		internal static global::MonoJavaBridge.MethodId _Logger28081;
		protected Logger(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.Logger._Logger28081.native == global::System.IntPtr.Zero)
				global::java.util.logging.Logger._Logger28081 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.Logger.staticClass, global::java.util.logging.Logger._Logger28081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static global::java.lang.String GLOBAL_LOGGER_NAME
		{
			get
			{
				return "global";
			}
		}
		internal static global::MonoJavaBridge.FieldId _global28083;
		public static global::java.util.logging.Logger global
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Logger.staticClass, _global28083)) as java.util.logging.Logger;
			}
		}
		static Logger()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.Logger.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/Logger"));
			global::java.util.logging.Logger._global28083 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Logger.staticClass, "global", "Ljava/util/logging/Logger;");
		}
		internal static void InitJNI()
		{
		}
	}
}
