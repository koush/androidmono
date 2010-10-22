namespace java.util.logging
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Logger : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Logger()
		{
			InitJNI();
		}
		protected Logger(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _log27917;
		public virtual void log(java.util.logging.Level arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Logger._log27917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._log27917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _log27918;
		public virtual void log(java.util.logging.Level arg0, java.lang.String arg1, java.lang.Throwable arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Logger._log27918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._log27918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _log27919;
		public virtual void log(java.util.logging.Level arg0, java.lang.String arg1, java.lang.Object[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Logger._log27919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._log27919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _log27920;
		public virtual void log(java.util.logging.LogRecord arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Logger._log27920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._log27920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _log27921;
		public virtual void log(java.util.logging.Level arg0, java.lang.String arg1, java.lang.Object arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Logger._log27921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._log27921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName27922;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.Logger._getName27922)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._getName27922)) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getParent27923;
		public virtual global::java.util.logging.Logger getParent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.Logger._getParent27923)) as java.util.logging.Logger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._getParent27923)) as java.util.logging.Logger;
		}
		internal static global::MonoJavaBridge.MethodId _setParent27924;
		public virtual void setParent(java.util.logging.Logger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Logger._setParent27924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._setParent27924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLogger27925;
		public static global::java.util.logging.Logger getLogger(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.logging.Logger.staticClass, global::java.util.logging.Logger._getLogger27925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.logging.Logger;
		}
		internal static global::MonoJavaBridge.MethodId _getLogger27926;
		public static global::java.util.logging.Logger getLogger(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.logging.Logger.staticClass, global::java.util.logging.Logger._getLogger27926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.logging.Logger;
		}
		internal static global::MonoJavaBridge.MethodId _warning27927;
		public virtual void warning(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Logger._warning27927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._warning27927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _info27928;
		public virtual void info(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Logger._info27928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._info27928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _config27929;
		public virtual void config(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Logger._config27929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._config27929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLevel27930;
		public virtual void setLevel(java.util.logging.Level arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Logger._setLevel27930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._setLevel27930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getLevel27931;
		public virtual global::java.util.logging.Level getLevel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.Logger._getLevel27931)) as java.util.logging.Level;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._getLevel27931)) as java.util.logging.Level;
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
		internal static global::MonoJavaBridge.MethodId _getFilter27932;
		public virtual global::java.util.logging.Filter getFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.logging.Filter>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.Logger._getFilter27932)) as java.util.logging.Filter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.logging.Filter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._getFilter27932)) as java.util.logging.Filter;
		}
		internal static global::MonoJavaBridge.MethodId _setFilter27933;
		public virtual void setFilter(java.util.logging.Filter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Logger._setFilter27933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._setFilter27933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _entering27934;
		public virtual void entering(java.lang.String arg0, java.lang.String arg1, java.lang.Object arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Logger._entering27934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._entering27934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _entering27935;
		public virtual void entering(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Logger._entering27935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._entering27935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _entering27936;
		public virtual void entering(java.lang.String arg0, java.lang.String arg1, java.lang.Object[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Logger._entering27936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._entering27936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isLoggable27937;
		public virtual bool isLoggable(java.util.logging.Level arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.logging.Logger._isLoggable27937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._isLoggable27937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _fine27938;
		public virtual void fine(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Logger._fine27938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._fine27938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _finest27939;
		public virtual void finest(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Logger._finest27939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._finest27939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _finer27940;
		public virtual void finer(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Logger._finer27940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._finer27940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.util.logging.Logger AnonymousLogger
		{
			get
			{
				return getAnonymousLogger();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAnonymousLogger27941;
		public static global::java.util.logging.Logger getAnonymousLogger() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.logging.Logger.staticClass, global::java.util.logging.Logger._getAnonymousLogger27941)) as java.util.logging.Logger;
		}
		internal static global::MonoJavaBridge.MethodId _getAnonymousLogger27942;
		public static global::java.util.logging.Logger getAnonymousLogger(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.logging.Logger.staticClass, global::java.util.logging.Logger._getAnonymousLogger27942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.logging.Logger;
		}
		public new global::java.util.ResourceBundle ResourceBundle
		{
			get
			{
				return getResourceBundle();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getResourceBundle27943;
		public virtual global::java.util.ResourceBundle getResourceBundle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.Logger._getResourceBundle27943)) as java.util.ResourceBundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._getResourceBundle27943)) as java.util.ResourceBundle;
		}
		public new global::java.lang.String ResourceBundleName
		{
			get
			{
				return getResourceBundleName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getResourceBundleName27944;
		public virtual global::java.lang.String getResourceBundleName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.Logger._getResourceBundleName27944)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._getResourceBundleName27944)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _logp27945;
		public virtual void logp(java.util.logging.Level arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.Object arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Logger._logp27945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._logp27945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _logp27946;
		public virtual void logp(java.util.logging.Level arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Logger._logp27946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._logp27946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _logp27947;
		public virtual void logp(java.util.logging.Level arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.Object[] arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Logger._logp27947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._logp27947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _logp27948;
		public virtual void logp(java.util.logging.Level arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.Throwable arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Logger._logp27948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._logp27948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _logrb27949;
		public virtual void logrb(java.util.logging.Level arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Logger._logrb27949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._logrb27949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _logrb27950;
		public virtual void logrb(java.util.logging.Level arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4, java.lang.Object[] arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Logger._logrb27950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._logrb27950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _logrb27951;
		public virtual void logrb(java.util.logging.Level arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4, java.lang.Throwable arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Logger._logrb27951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._logrb27951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _logrb27952;
		public virtual void logrb(java.util.logging.Level arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4, java.lang.Object arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Logger._logrb27952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._logrb27952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _exiting27953;
		public virtual void exiting(java.lang.String arg0, java.lang.String arg1, java.lang.Object arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Logger._exiting27953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._exiting27953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _exiting27954;
		public virtual void exiting(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Logger._exiting27954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._exiting27954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _throwing27955;
		public virtual void throwing(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Logger._throwing27955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._throwing27955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _severe27956;
		public virtual void severe(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Logger._severe27956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._severe27956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addHandler27957;
		public virtual void addHandler(java.util.logging.Handler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Logger._addHandler27957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._addHandler27957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeHandler27958;
		public virtual void removeHandler(java.util.logging.Handler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Logger._removeHandler27958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._removeHandler27958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.logging.Handler[] Handlers
		{
			get
			{
				return getHandlers();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHandlers27959;
		public virtual global::java.util.logging.Handler[] getHandlers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.logging.Handler>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.Logger._getHandlers27959)) as java.util.logging.Handler[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.logging.Handler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._getHandlers27959)) as java.util.logging.Handler[];
		}
		internal static global::MonoJavaBridge.MethodId _setUseParentHandlers27960;
		public virtual void setUseParentHandlers(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Logger._setUseParentHandlers27960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._setUseParentHandlers27960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getUseParentHandlers27961;
		public virtual bool getUseParentHandlers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.logging.Logger._getUseParentHandlers27961);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.logging.Logger.staticClass, global::java.util.logging.Logger._getUseParentHandlers27961);
		}
		internal static global::MonoJavaBridge.MethodId _Logger27962;
		protected Logger(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.Logger.staticClass, global::java.util.logging.Logger._Logger27962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static global::java.lang.String GLOBAL_LOGGER_NAME
		{
			get
			{
				return "global";
			}
		}
		internal static global::MonoJavaBridge.FieldId _global27964;
		public static global::java.util.logging.Logger global
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Logger.staticClass, _global27964)) as java.util.logging.Logger;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.Logger.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/Logger"));
			global::java.util.logging.Logger._log27917 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "log", "(Ljava/util/logging/Level;Ljava/lang/String;)V");
			global::java.util.logging.Logger._log27918 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "log", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.util.logging.Logger._log27919 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "log", "(Ljava/util/logging/Level;Ljava/lang/String;[Ljava/lang/Object;)V");
			global::java.util.logging.Logger._log27920 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "log", "(Ljava/util/logging/LogRecord;)V");
			global::java.util.logging.Logger._log27921 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "log", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/Object;)V");
			global::java.util.logging.Logger._getName27922 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "getName", "()Ljava/lang/String;");
			global::java.util.logging.Logger._getParent27923 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "getParent", "()Ljava/util/logging/Logger;");
			global::java.util.logging.Logger._setParent27924 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "setParent", "(Ljava/util/logging/Logger;)V");
			global::java.util.logging.Logger._getLogger27925 = @__env.GetStaticMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "getLogger", "(Ljava/lang/String;)Ljava/util/logging/Logger;");
			global::java.util.logging.Logger._getLogger27926 = @__env.GetStaticMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "getLogger", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/logging/Logger;");
			global::java.util.logging.Logger._warning27927 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "warning", "(Ljava/lang/String;)V");
			global::java.util.logging.Logger._info27928 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "info", "(Ljava/lang/String;)V");
			global::java.util.logging.Logger._config27929 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "config", "(Ljava/lang/String;)V");
			global::java.util.logging.Logger._setLevel27930 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "setLevel", "(Ljava/util/logging/Level;)V");
			global::java.util.logging.Logger._getLevel27931 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "getLevel", "()Ljava/util/logging/Level;");
			global::java.util.logging.Logger._getFilter27932 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "getFilter", "()Ljava/util/logging/Filter;");
			global::java.util.logging.Logger._setFilter27933 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "setFilter", "(Ljava/util/logging/Filter;)V");
			global::java.util.logging.Logger._entering27934 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "entering", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V");
			global::java.util.logging.Logger._entering27935 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "entering", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.logging.Logger._entering27936 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "entering", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V");
			global::java.util.logging.Logger._isLoggable27937 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "isLoggable", "(Ljava/util/logging/Level;)Z");
			global::java.util.logging.Logger._fine27938 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "fine", "(Ljava/lang/String;)V");
			global::java.util.logging.Logger._finest27939 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "finest", "(Ljava/lang/String;)V");
			global::java.util.logging.Logger._finer27940 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "finer", "(Ljava/lang/String;)V");
			global::java.util.logging.Logger._getAnonymousLogger27941 = @__env.GetStaticMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "getAnonymousLogger", "()Ljava/util/logging/Logger;");
			global::java.util.logging.Logger._getAnonymousLogger27942 = @__env.GetStaticMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "getAnonymousLogger", "(Ljava/lang/String;)Ljava/util/logging/Logger;");
			global::java.util.logging.Logger._getResourceBundle27943 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "getResourceBundle", "()Ljava/util/ResourceBundle;");
			global::java.util.logging.Logger._getResourceBundleName27944 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "getResourceBundleName", "()Ljava/lang/String;");
			global::java.util.logging.Logger._logp27945 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "logp", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V");
			global::java.util.logging.Logger._logp27946 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "logp", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.logging.Logger._logp27947 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "logp", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V");
			global::java.util.logging.Logger._logp27948 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "logp", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.util.logging.Logger._logrb27949 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "logrb", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.logging.Logger._logrb27950 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "logrb", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V");
			global::java.util.logging.Logger._logrb27951 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "logrb", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.util.logging.Logger._logrb27952 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "logrb", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V");
			global::java.util.logging.Logger._exiting27953 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "exiting", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V");
			global::java.util.logging.Logger._exiting27954 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "exiting", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.logging.Logger._throwing27955 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "throwing", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.util.logging.Logger._severe27956 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "severe", "(Ljava/lang/String;)V");
			global::java.util.logging.Logger._addHandler27957 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "addHandler", "(Ljava/util/logging/Handler;)V");
			global::java.util.logging.Logger._removeHandler27958 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "removeHandler", "(Ljava/util/logging/Handler;)V");
			global::java.util.logging.Logger._getHandlers27959 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "getHandlers", "()[Ljava/util/logging/Handler;");
			global::java.util.logging.Logger._setUseParentHandlers27960 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "setUseParentHandlers", "(Z)V");
			global::java.util.logging.Logger._getUseParentHandlers27961 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "getUseParentHandlers", "()Z");
			global::java.util.logging.Logger._Logger27962 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.logging.Logger._global27964 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Logger.staticClass, "global", "Ljava/util/logging/Logger;");
		}
	}
}
