namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Throwable : global::MonoJavaBridge.JavaException, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Throwable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void printStackTrace(java.io.PrintStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Throwable.staticClass, "printStackTrace", "(Ljava/io/PrintStream;)V", ref global::java.lang.Throwable._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void printStackTrace()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Throwable.staticClass, "printStackTrace", "()V", ref global::java.lang.Throwable._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void printStackTrace(java.io.PrintWriter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Throwable.staticClass, "printStackTrace", "(Ljava/io/PrintWriter;)V", ref global::java.lang.Throwable._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.Throwable fillInStackTrace()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Throwable.staticClass, "fillInStackTrace", "()Ljava/lang/Throwable;", ref global::java.lang.Throwable._m3) as java.lang.Throwable;
		}
		public new global::java.lang.Throwable Cause
		{
			get
			{
				return getCause();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.Throwable getCause()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Throwable.staticClass, "getCause", "()Ljava/lang/Throwable;", ref global::java.lang.Throwable._m4) as java.lang.Throwable;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.Throwable initCause(java.lang.Throwable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Throwable.staticClass, "initCause", "(Ljava/lang/Throwable;)Ljava/lang/Throwable;", ref global::java.lang.Throwable._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Throwable;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.Throwable.staticClass, "toString", "()Ljava/lang/String;", ref global::java.lang.Throwable._m6) as java.lang.String;
		}
		public new global::java.lang.String Message
		{
			get
			{
				return getMessage();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.lang.String getMessage()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.Throwable.staticClass, "getMessage", "()Ljava/lang/String;", ref global::java.lang.Throwable._m7) as java.lang.String;
		}
		public new global::java.lang.String LocalizedMessage
		{
			get
			{
				return getLocalizedMessage();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.lang.String getLocalizedMessage()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.Throwable.staticClass, "getLocalizedMessage", "()Ljava/lang/String;", ref global::java.lang.Throwable._m8) as java.lang.String;
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
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::java.lang.StackTraceElement[] getStackTrace()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.StackTraceElement>(this, global::java.lang.Throwable.staticClass, "getStackTrace", "()[Ljava/lang/StackTraceElement;", ref global::java.lang.Throwable._m9) as java.lang.StackTraceElement[];
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setStackTrace(java.lang.StackTraceElement[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Throwable.staticClass, "setStackTrace", "([Ljava/lang/StackTraceElement;)V", ref global::java.lang.Throwable._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public Throwable() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Throwable._m11.native == global::System.IntPtr.Zero)
				global::java.lang.Throwable._m11 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Throwable.staticClass, global::java.lang.Throwable._m11);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public Throwable(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Throwable._m12.native == global::System.IntPtr.Zero)
				global::java.lang.Throwable._m12 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Throwable.staticClass, global::java.lang.Throwable._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public Throwable(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Throwable._m13.native == global::System.IntPtr.Zero)
				global::java.lang.Throwable._m13 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Throwable.staticClass, global::java.lang.Throwable._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public Throwable(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Throwable._m14.native == global::System.IntPtr.Zero)
				global::java.lang.Throwable._m14 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Throwable.staticClass, global::java.lang.Throwable._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Throwable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Throwable.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Throwable"));
		}
	}
}
