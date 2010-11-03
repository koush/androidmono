namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UndeclaredThrowableException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected UndeclaredThrowableException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
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
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.reflect.UndeclaredThrowableException.staticClass, "getCause", "()Ljava/lang/Throwable;", ref global::java.lang.reflect.UndeclaredThrowableException._m0) as java.lang.Throwable;
		}
		public new global::java.lang.Throwable UndeclaredThrowable
		{
			get
			{
				return getUndeclaredThrowable();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Throwable getUndeclaredThrowable()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.reflect.UndeclaredThrowableException.staticClass, "getUndeclaredThrowable", "()Ljava/lang/Throwable;", ref global::java.lang.reflect.UndeclaredThrowableException._m1) as java.lang.Throwable;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public UndeclaredThrowableException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.UndeclaredThrowableException._m2.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.UndeclaredThrowableException._m2 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.UndeclaredThrowableException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.reflect.UndeclaredThrowableException.staticClass, global::java.lang.reflect.UndeclaredThrowableException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public UndeclaredThrowableException(java.lang.Throwable arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.UndeclaredThrowableException._m3.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.UndeclaredThrowableException._m3 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.UndeclaredThrowableException.staticClass, "<init>", "(Ljava/lang/Throwable;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.reflect.UndeclaredThrowableException.staticClass, global::java.lang.reflect.UndeclaredThrowableException._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static UndeclaredThrowableException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.UndeclaredThrowableException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/UndeclaredThrowableException"));
		}
	}
}
