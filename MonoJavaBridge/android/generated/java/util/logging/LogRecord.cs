namespace java.util.logging
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LogRecord : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LogRecord(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Message
		{
			get
			{
				return getMessage();
			}
			set
			{
				setMessage(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.String getMessage()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.logging.LogRecord.staticClass, "getMessage", "()Ljava/lang/String;", ref global::java.util.logging.LogRecord._m0) as java.lang.String;
		}
		public new global::java.lang.Object[] Parameters
		{
			get
			{
				return getParameters();
			}
			set
			{
				setParameters(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Object[] getParameters()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.logging.LogRecord.staticClass, "getParameters", "()[Ljava/lang/Object;", ref global::java.util.logging.LogRecord._m1) as java.lang.Object[];
		}
		public new long Millis
		{
			get
			{
				return getMillis();
			}
			set
			{
				setMillis(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual long getMillis()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.logging.LogRecord.staticClass, "getMillis", "()J", ref global::java.util.logging.LogRecord._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setMillis(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.LogRecord.staticClass, "setMillis", "(J)V", ref global::java.util.logging.LogRecord._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setLevel(java.util.logging.Level arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.LogRecord.staticClass, "setLevel", "(Ljava/util/logging/Level;)V", ref global::java.util.logging.LogRecord._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.util.logging.Level getLevel()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.logging.LogRecord.staticClass, "getLevel", "()Ljava/util/logging/Level;", ref global::java.util.logging.LogRecord._m5) as java.util.logging.Level;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setMessage(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.LogRecord.staticClass, "setMessage", "(Ljava/lang/String;)V", ref global::java.util.logging.LogRecord._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setParameters(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.LogRecord.staticClass, "setParameters", "([Ljava/lang/Object;)V", ref global::java.util.logging.LogRecord._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.ResourceBundle ResourceBundle
		{
			get
			{
				return getResourceBundle();
			}
			set
			{
				setResourceBundle(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.util.ResourceBundle getResourceBundle()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.logging.LogRecord.staticClass, "getResourceBundle", "()Ljava/util/ResourceBundle;", ref global::java.util.logging.LogRecord._m8) as java.util.ResourceBundle;
		}
		public new global::java.lang.String ResourceBundleName
		{
			get
			{
				return getResourceBundleName();
			}
			set
			{
				setResourceBundleName(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::java.lang.String getResourceBundleName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.logging.LogRecord.staticClass, "getResourceBundleName", "()Ljava/lang/String;", ref global::java.util.logging.LogRecord._m9) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setLoggerName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.LogRecord.staticClass, "setLoggerName", "(Ljava/lang/String;)V", ref global::java.util.logging.LogRecord._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setResourceBundleName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.LogRecord.staticClass, "setResourceBundleName", "(Ljava/lang/String;)V", ref global::java.util.logging.LogRecord._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setResourceBundle(java.util.ResourceBundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.LogRecord.staticClass, "setResourceBundle", "(Ljava/util/ResourceBundle;)V", ref global::java.util.logging.LogRecord._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void setThrown(java.lang.Throwable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.LogRecord.staticClass, "setThrown", "(Ljava/lang/Throwable;)V", ref global::java.util.logging.LogRecord._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setSourceClassName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.LogRecord.staticClass, "setSourceClassName", "(Ljava/lang/String;)V", ref global::java.util.logging.LogRecord._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setSourceMethodName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.LogRecord.staticClass, "setSourceMethodName", "(Ljava/lang/String;)V", ref global::java.util.logging.LogRecord._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String LoggerName
		{
			get
			{
				return getLoggerName();
			}
			set
			{
				setLoggerName(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual global::java.lang.String getLoggerName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.logging.LogRecord.staticClass, "getLoggerName", "()Ljava/lang/String;", ref global::java.util.logging.LogRecord._m16) as java.lang.String;
		}
		public new long SequenceNumber
		{
			get
			{
				return getSequenceNumber();
			}
			set
			{
				setSequenceNumber(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual long getSequenceNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.logging.LogRecord.staticClass, "getSequenceNumber", "()J", ref global::java.util.logging.LogRecord._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void setSequenceNumber(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.LogRecord.staticClass, "setSequenceNumber", "(J)V", ref global::java.util.logging.LogRecord._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String SourceClassName
		{
			get
			{
				return getSourceClassName();
			}
			set
			{
				setSourceClassName(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual global::java.lang.String getSourceClassName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.logging.LogRecord.staticClass, "getSourceClassName", "()Ljava/lang/String;", ref global::java.util.logging.LogRecord._m19) as java.lang.String;
		}
		public new global::java.lang.String SourceMethodName
		{
			get
			{
				return getSourceMethodName();
			}
			set
			{
				setSourceMethodName(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual global::java.lang.String getSourceMethodName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.logging.LogRecord.staticClass, "getSourceMethodName", "()Ljava/lang/String;", ref global::java.util.logging.LogRecord._m20) as java.lang.String;
		}
		public new int ThreadID
		{
			get
			{
				return getThreadID();
			}
			set
			{
				setThreadID(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual int getThreadID()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.logging.LogRecord.staticClass, "getThreadID", "()I", ref global::java.util.logging.LogRecord._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void setThreadID(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.logging.LogRecord.staticClass, "setThreadID", "(I)V", ref global::java.util.logging.LogRecord._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.Throwable Thrown
		{
			get
			{
				return getThrown();
			}
			set
			{
				setThrown(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual global::java.lang.Throwable getThrown()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.logging.LogRecord.staticClass, "getThrown", "()Ljava/lang/Throwable;", ref global::java.util.logging.LogRecord._m23) as java.lang.Throwable;
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public LogRecord(java.util.logging.Level arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.LogRecord._m24.native == global::System.IntPtr.Zero)
				global::java.util.logging.LogRecord._m24 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogRecord.staticClass, "<init>", "(Ljava/util/logging/Level;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.LogRecord.staticClass, global::java.util.logging.LogRecord._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static LogRecord()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.LogRecord.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/LogRecord"));
		}
	}
}
