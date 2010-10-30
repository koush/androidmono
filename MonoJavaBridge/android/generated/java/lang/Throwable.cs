namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Throwable : global::MonoJavaBridge.JavaException, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Throwable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _printStackTrace20906;
		public virtual void printStackTrace(java.io.PrintStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Throwable.staticClass, global::java.lang.Throwable._printStackTrace20906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _printStackTrace20907;
		public virtual void printStackTrace()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Throwable.staticClass, global::java.lang.Throwable._printStackTrace20907);
		}
		internal static global::MonoJavaBridge.MethodId _printStackTrace20908;
		public virtual void printStackTrace(java.io.PrintWriter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Throwable.staticClass, global::java.lang.Throwable._printStackTrace20908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _fillInStackTrace20909;
		public virtual global::java.lang.Throwable fillInStackTrace()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Throwable.staticClass, global::java.lang.Throwable._fillInStackTrace20909)) as java.lang.Throwable;
		}
		public new global::java.lang.Throwable Cause
		{
			get
			{
				return getCause();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCause20910;
		public virtual global::java.lang.Throwable getCause()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Throwable.staticClass, global::java.lang.Throwable._getCause20910)) as java.lang.Throwable;
		}
		internal static global::MonoJavaBridge.MethodId _initCause20911;
		public virtual global::java.lang.Throwable initCause(java.lang.Throwable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Throwable.staticClass, global::java.lang.Throwable._initCause20911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Throwable;
		}
		internal static global::MonoJavaBridge.MethodId _toString20912;
		public virtual global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Throwable.staticClass, global::java.lang.Throwable._toString20912)) as java.lang.String;
		}
		public new global::java.lang.String Message
		{
			get
			{
				return getMessage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMessage20913;
		public virtual global::java.lang.String getMessage()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Throwable.staticClass, global::java.lang.Throwable._getMessage20913)) as java.lang.String;
		}
		public new global::java.lang.String LocalizedMessage
		{
			get
			{
				return getLocalizedMessage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalizedMessage20914;
		public virtual global::java.lang.String getLocalizedMessage()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Throwable.staticClass, global::java.lang.Throwable._getLocalizedMessage20914)) as java.lang.String;
		}
		public new global::java.lang.StackTraceElement[] StackTrace
		{
			get
			{
				return getStackTrace();
			}
			set
			{
				setStackTrace(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStackTrace20915;
		public virtual global::java.lang.StackTraceElement[] getStackTrace()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.StackTraceElement>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Throwable.staticClass, global::java.lang.Throwable._getStackTrace20915)) as java.lang.StackTraceElement[];
		}
		internal static global::MonoJavaBridge.MethodId _setStackTrace20916;
		public virtual void setStackTrace(java.lang.StackTraceElement[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Throwable.staticClass, global::java.lang.Throwable._setStackTrace20916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Throwable20917;
		public Throwable() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Throwable.staticClass, global::java.lang.Throwable._Throwable20917);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Throwable20918;
		public Throwable(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Throwable.staticClass, global::java.lang.Throwable._Throwable20918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Throwable20919;
		public Throwable(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Throwable.staticClass, global::java.lang.Throwable._Throwable20919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Throwable20920;
		public Throwable(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Throwable.staticClass, global::java.lang.Throwable._Throwable20920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Throwable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Throwable.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Throwable"));
			global::java.lang.Throwable._printStackTrace20906 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "printStackTrace", "(Ljava/io/PrintStream;)V");
			global::java.lang.Throwable._printStackTrace20907 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "printStackTrace", "()V");
			global::java.lang.Throwable._printStackTrace20908 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "printStackTrace", "(Ljava/io/PrintWriter;)V");
			global::java.lang.Throwable._fillInStackTrace20909 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "fillInStackTrace", "()Ljava/lang/Throwable;");
			global::java.lang.Throwable._getCause20910 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "getCause", "()Ljava/lang/Throwable;");
			global::java.lang.Throwable._initCause20911 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "initCause", "(Ljava/lang/Throwable;)Ljava/lang/Throwable;");
			global::java.lang.Throwable._toString20912 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Throwable._getMessage20913 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "getMessage", "()Ljava/lang/String;");
			global::java.lang.Throwable._getLocalizedMessage20914 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "getLocalizedMessage", "()Ljava/lang/String;");
			global::java.lang.Throwable._getStackTrace20915 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "getStackTrace", "()[Ljava/lang/StackTraceElement;");
			global::java.lang.Throwable._setStackTrace20916 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "setStackTrace", "([Ljava/lang/StackTraceElement;)V");
			global::java.lang.Throwable._Throwable20917 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "<init>", "()V");
			global::java.lang.Throwable._Throwable20918 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.Throwable._Throwable20919 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.lang.Throwable._Throwable20920 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
