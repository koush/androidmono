namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ExceptionInInitializerError : java.lang.LinkageError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ExceptionInInitializerError()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getCause20019;
		public override global::java.lang.Throwable getCause() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ExceptionInInitializerError._getCause20019)) as java.lang.Throwable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ExceptionInInitializerError.staticClass, global::java.lang.ExceptionInInitializerError._getCause20019)) as java.lang.Throwable;
		}
		public new global::java.lang.Throwable Exception
		{
			get
			{
				return getException();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getException20020;
		public virtual global::java.lang.Throwable getException() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ExceptionInInitializerError._getException20020)) as java.lang.Throwable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ExceptionInInitializerError.staticClass, global::java.lang.ExceptionInInitializerError._getException20020)) as java.lang.Throwable;
		}
		internal static global::MonoJavaBridge.MethodId _ExceptionInInitializerError20021;
		public ExceptionInInitializerError()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ExceptionInInitializerError.staticClass, global::java.lang.ExceptionInInitializerError._ExceptionInInitializerError20021);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ExceptionInInitializerError20022;
		public ExceptionInInitializerError(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ExceptionInInitializerError.staticClass, global::java.lang.ExceptionInInitializerError._ExceptionInInitializerError20022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ExceptionInInitializerError20023;
		public ExceptionInInitializerError(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ExceptionInInitializerError.staticClass, global::java.lang.ExceptionInInitializerError._ExceptionInInitializerError20023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.ExceptionInInitializerError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ExceptionInInitializerError"));
			global::java.lang.ExceptionInInitializerError._getCause20019 = @__env.GetMethodIDNoThrow(global::java.lang.ExceptionInInitializerError.staticClass, "getCause", "()Ljava/lang/Throwable;");
			global::java.lang.ExceptionInInitializerError._getException20020 = @__env.GetMethodIDNoThrow(global::java.lang.ExceptionInInitializerError.staticClass, "getException", "()Ljava/lang/Throwable;");
			global::java.lang.ExceptionInInitializerError._ExceptionInInitializerError20021 = @__env.GetMethodIDNoThrow(global::java.lang.ExceptionInInitializerError.staticClass, "<init>", "()V");
			global::java.lang.ExceptionInInitializerError._ExceptionInInitializerError20022 = @__env.GetMethodIDNoThrow(global::java.lang.ExceptionInInitializerError.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::java.lang.ExceptionInInitializerError._ExceptionInInitializerError20023 = @__env.GetMethodIDNoThrow(global::java.lang.ExceptionInInitializerError.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
