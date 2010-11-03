namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InvocationTargetException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InvocationTargetException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
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
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.reflect.InvocationTargetException.staticClass, "getCause", "()Ljava/lang/Throwable;", ref global::java.lang.reflect.InvocationTargetException._m0) as java.lang.Throwable;
		}
		public new global::java.lang.Throwable TargetException
		{
			get
			{
				return getTargetException();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Throwable getTargetException()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.reflect.InvocationTargetException.staticClass, "getTargetException", "()Ljava/lang/Throwable;", ref global::java.lang.reflect.InvocationTargetException._m1) as java.lang.Throwable;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected InvocationTargetException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.InvocationTargetException._m2.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.InvocationTargetException._m2 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.InvocationTargetException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.reflect.InvocationTargetException.staticClass, global::java.lang.reflect.InvocationTargetException._m2);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public InvocationTargetException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.InvocationTargetException._m3.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.InvocationTargetException._m3 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.InvocationTargetException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.reflect.InvocationTargetException.staticClass, global::java.lang.reflect.InvocationTargetException._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public InvocationTargetException(java.lang.Throwable arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.InvocationTargetException._m4.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.InvocationTargetException._m4 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.InvocationTargetException.staticClass, "<init>", "(Ljava/lang/Throwable;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.reflect.InvocationTargetException.staticClass, global::java.lang.reflect.InvocationTargetException._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static InvocationTargetException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.InvocationTargetException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/InvocationTargetException"));
		}
	}
}
