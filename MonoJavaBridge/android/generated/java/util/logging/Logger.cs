namespace java.util.logging
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Logger : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Logger(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void log(java.util.logging.Level arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "log", "(Ljava/util/logging/Level;Ljava/lang/String;)V", ref global::java.util.logging.Logger._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void log(java.util.logging.Level arg0, java.lang.String arg1, java.lang.Throwable arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "log", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/Throwable;)V", ref global::java.util.logging.Logger._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void log(java.util.logging.Level arg0, java.lang.String arg1, java.lang.Object[] arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "log", "(Ljava/util/logging/Level;Ljava/lang/String;[Ljava/lang/Object;)V", ref global::java.util.logging.Logger._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void log(java.util.logging.LogRecord arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "log", "(Ljava/util/logging/LogRecord;)V", ref global::java.util.logging.Logger._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void log(java.util.logging.Level arg0, java.lang.String arg1, java.lang.Object arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "log", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/Object;)V", ref global::java.util.logging.Logger._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.logging.Logger.staticClass, "getName", "()Ljava/lang/String;", ref global::java.util.logging.Logger._m5) as java.lang.String;
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
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.util.logging.Logger getParent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.logging.Logger.staticClass, "getParent", "()Ljava/util/logging/Logger;", ref global::java.util.logging.Logger._m6) as java.util.logging.Logger;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setParent(java.util.logging.Logger arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "setParent", "(Ljava/util/logging/Logger;)V", ref global::java.util.logging.Logger._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static global::java.util.logging.Logger getLogger(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.Logger._m8.native == global::System.IntPtr.Zero)
				global::java.util.logging.Logger._m8 = @__env.GetStaticMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "getLogger", "(Ljava/lang/String;)Ljava/util/logging/Logger;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.logging.Logger.staticClass, global::java.util.logging.Logger._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.logging.Logger;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static global::java.util.logging.Logger getLogger(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.Logger._m9.native == global::System.IntPtr.Zero)
				global::java.util.logging.Logger._m9 = @__env.GetStaticMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "getLogger", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/logging/Logger;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.logging.Logger.staticClass, global::java.util.logging.Logger._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.logging.Logger;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void warning(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "warning", "(Ljava/lang/String;)V", ref global::java.util.logging.Logger._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void info(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "info", "(Ljava/lang/String;)V", ref global::java.util.logging.Logger._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void config(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "config", "(Ljava/lang/String;)V", ref global::java.util.logging.Logger._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void setLevel(java.util.logging.Level arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "setLevel", "(Ljava/util/logging/Level;)V", ref global::java.util.logging.Logger._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::java.util.logging.Level getLevel()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.logging.Logger.staticClass, "getLevel", "()Ljava/util/logging/Level;", ref global::java.util.logging.Logger._m14) as java.util.logging.Level;
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
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual global::java.util.logging.Filter getFilter()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.logging.Filter>(this, global::java.util.logging.Logger.staticClass, "getFilter", "()Ljava/util/logging/Filter;", ref global::java.util.logging.Logger._m15) as java.util.logging.Filter;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void setFilter(java.util.logging.Filter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "setFilter", "(Ljava/util/logging/Filter;)V", ref global::java.util.logging.Logger._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void entering(java.lang.String arg0, java.lang.String arg1, java.lang.Object arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "entering", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V", ref global::java.util.logging.Logger._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void entering(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "entering", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::java.util.logging.Logger._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void entering(java.lang.String arg0, java.lang.String arg1, java.lang.Object[] arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "entering", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", ref global::java.util.logging.Logger._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual bool isLoggable(java.util.logging.Level arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.logging.Logger.staticClass, "isLoggable", "(Ljava/util/logging/Level;)Z", ref global::java.util.logging.Logger._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void fine(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "fine", "(Ljava/lang/String;)V", ref global::java.util.logging.Logger._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void finest(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "finest", "(Ljava/lang/String;)V", ref global::java.util.logging.Logger._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual void finer(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "finer", "(Ljava/lang/String;)V", ref global::java.util.logging.Logger._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.util.logging.Logger AnonymousLogger
		{
			get
			{
				return getAnonymousLogger();
			}
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public static global::java.util.logging.Logger getAnonymousLogger()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.Logger._m24.native == global::System.IntPtr.Zero)
				global::java.util.logging.Logger._m24 = @__env.GetStaticMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "getAnonymousLogger", "()Ljava/util/logging/Logger;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.logging.Logger.staticClass, global::java.util.logging.Logger._m24)) as java.util.logging.Logger;
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public static global::java.util.logging.Logger getAnonymousLogger(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.Logger._m25.native == global::System.IntPtr.Zero)
				global::java.util.logging.Logger._m25 = @__env.GetStaticMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "getAnonymousLogger", "(Ljava/lang/String;)Ljava/util/logging/Logger;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.logging.Logger.staticClass, global::java.util.logging.Logger._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.logging.Logger;
		}
		public new global::java.util.ResourceBundle ResourceBundle
		{
			get
			{
				return getResourceBundle();
			}
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual global::java.util.ResourceBundle getResourceBundle()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.logging.Logger.staticClass, "getResourceBundle", "()Ljava/util/ResourceBundle;", ref global::java.util.logging.Logger._m26) as java.util.ResourceBundle;
		}
		public new global::java.lang.String ResourceBundleName
		{
			get
			{
				return getResourceBundleName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual global::java.lang.String getResourceBundleName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.logging.Logger.staticClass, "getResourceBundleName", "()Ljava/lang/String;", ref global::java.util.logging.Logger._m27) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual void logp(java.util.logging.Level arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.Object arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "logp", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V", ref global::java.util.logging.Logger._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual void logp(java.util.logging.Level arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "logp", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ref global::java.util.logging.Logger._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual void logp(java.util.logging.Level arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.Object[] arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "logp", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", ref global::java.util.logging.Logger._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual void logp(java.util.logging.Level arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.Throwable arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "logp", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", ref global::java.util.logging.Logger._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual void logrb(java.util.logging.Level arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "logrb", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ref global::java.util.logging.Logger._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual void logrb(java.util.logging.Level arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4, java.lang.Object[] arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "logrb", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", ref global::java.util.logging.Logger._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual void logrb(java.util.logging.Level arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4, java.lang.Throwable arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "logrb", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", ref global::java.util.logging.Logger._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual void logrb(java.util.logging.Level arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4, java.lang.Object arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "logrb", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V", ref global::java.util.logging.Logger._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual void exiting(java.lang.String arg0, java.lang.String arg1, java.lang.Object arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "exiting", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V", ref global::java.util.logging.Logger._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual void exiting(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "exiting", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::java.util.logging.Logger._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public virtual void throwing(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "throwing", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", ref global::java.util.logging.Logger._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public virtual void severe(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "severe", "(Ljava/lang/String;)V", ref global::java.util.logging.Logger._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public virtual void addHandler(java.util.logging.Handler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "addHandler", "(Ljava/util/logging/Handler;)V", ref global::java.util.logging.Logger._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public virtual void removeHandler(java.util.logging.Handler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "removeHandler", "(Ljava/util/logging/Handler;)V", ref global::java.util.logging.Logger._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.logging.Handler[] Handlers
		{
			get
			{
				return getHandlers();
			}
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public virtual global::java.util.logging.Handler[] getHandlers()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.util.logging.Handler>(this, global::java.util.logging.Logger.staticClass, "getHandlers", "()[Ljava/util/logging/Handler;", ref global::java.util.logging.Logger._m42) as java.util.logging.Handler[];
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public virtual void setUseParentHandlers(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.Logger.staticClass, "setUseParentHandlers", "(Z)V", ref global::java.util.logging.Logger._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m44;
		public virtual bool getUseParentHandlers()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.logging.Logger.staticClass, "getUseParentHandlers", "()Z", ref global::java.util.logging.Logger._m44);
		}
		private static global::MonoJavaBridge.MethodId _m45;
		protected Logger(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.Logger._m45.native == global::System.IntPtr.Zero)
				global::java.util.logging.Logger._m45 = @__env.GetMethodIDNoThrow(global::java.util.logging.Logger.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.Logger.staticClass, global::java.util.logging.Logger._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static global::java.lang.String GLOBAL_LOGGER_NAME
		{
			get
			{
				return "global";
			}
		}
		internal static global::MonoJavaBridge.FieldId _global6896;
		public static global::java.util.logging.Logger global
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Logger.staticClass, _global6896)) as java.util.logging.Logger;
			}
		}
		static Logger()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.Logger.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/Logger"));
			global::java.util.logging.Logger._global6896 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Logger.staticClass, "global", "Ljava/util/logging/Logger;");
		}
	}
}
