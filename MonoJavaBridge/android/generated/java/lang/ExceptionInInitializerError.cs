namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ExceptionInInitializerError : java.lang.LinkageError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ExceptionInInitializerError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.Throwable Cause
		{
			get
			{
				return getCause();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCause20137;
		public override global::java.lang.Throwable getCause()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.ExceptionInInitializerError.staticClass, "getCause", "()Ljava/lang/Throwable;", ref global::java.lang.ExceptionInInitializerError._getCause20137) as java.lang.Throwable;
		}
		public new global::java.lang.Throwable Exception
		{
			get
			{
				return getException();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getException20138;
		public virtual global::java.lang.Throwable getException()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.ExceptionInInitializerError.staticClass, "getException", "()Ljava/lang/Throwable;", ref global::java.lang.ExceptionInInitializerError._getException20138) as java.lang.Throwable;
		}
		internal static global::MonoJavaBridge.MethodId _ExceptionInInitializerError20139;
		public ExceptionInInitializerError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ExceptionInInitializerError._ExceptionInInitializerError20139.native == global::System.IntPtr.Zero)
				global::java.lang.ExceptionInInitializerError._ExceptionInInitializerError20139 = @__env.GetMethodIDNoThrow(global::java.lang.ExceptionInInitializerError.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ExceptionInInitializerError.staticClass, global::java.lang.ExceptionInInitializerError._ExceptionInInitializerError20139);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ExceptionInInitializerError20140;
		public ExceptionInInitializerError(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ExceptionInInitializerError._ExceptionInInitializerError20140.native == global::System.IntPtr.Zero)
				global::java.lang.ExceptionInInitializerError._ExceptionInInitializerError20140 = @__env.GetMethodIDNoThrow(global::java.lang.ExceptionInInitializerError.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ExceptionInInitializerError.staticClass, global::java.lang.ExceptionInInitializerError._ExceptionInInitializerError20140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ExceptionInInitializerError20141;
		public ExceptionInInitializerError(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ExceptionInInitializerError._ExceptionInInitializerError20141.native == global::System.IntPtr.Zero)
				global::java.lang.ExceptionInInitializerError._ExceptionInInitializerError20141 = @__env.GetMethodIDNoThrow(global::java.lang.ExceptionInInitializerError.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ExceptionInInitializerError.staticClass, global::java.lang.ExceptionInInitializerError._ExceptionInInitializerError20141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ExceptionInInitializerError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.ExceptionInInitializerError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ExceptionInInitializerError"));
		}
		internal static void InitJNI()
		{
		}
	}
}
