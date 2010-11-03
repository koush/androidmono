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
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.Throwable getCause()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.ExceptionInInitializerError.staticClass, "getCause", "()Ljava/lang/Throwable;", ref global::java.lang.ExceptionInInitializerError._m0) as java.lang.Throwable;
		}
		public new global::java.lang.Throwable Exception
		{
			get
			{
				return getException();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Throwable getException()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.ExceptionInInitializerError.staticClass, "getException", "()Ljava/lang/Throwable;", ref global::java.lang.ExceptionInInitializerError._m1) as java.lang.Throwable;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public ExceptionInInitializerError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ExceptionInInitializerError._m2.native == global::System.IntPtr.Zero)
				global::java.lang.ExceptionInInitializerError._m2 = @__env.GetMethodIDNoThrow(global::java.lang.ExceptionInInitializerError.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ExceptionInInitializerError.staticClass, global::java.lang.ExceptionInInitializerError._m2);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public ExceptionInInitializerError(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ExceptionInInitializerError._m3.native == global::System.IntPtr.Zero)
				global::java.lang.ExceptionInInitializerError._m3 = @__env.GetMethodIDNoThrow(global::java.lang.ExceptionInInitializerError.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ExceptionInInitializerError.staticClass, global::java.lang.ExceptionInInitializerError._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public ExceptionInInitializerError(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ExceptionInInitializerError._m4.native == global::System.IntPtr.Zero)
				global::java.lang.ExceptionInInitializerError._m4 = @__env.GetMethodIDNoThrow(global::java.lang.ExceptionInInitializerError.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ExceptionInInitializerError.staticClass, global::java.lang.ExceptionInInitializerError._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ExceptionInInitializerError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.ExceptionInInitializerError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ExceptionInInitializerError"));
		}
	}
}
