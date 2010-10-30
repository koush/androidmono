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
		internal static global::MonoJavaBridge.MethodId _getCause21158;
		public override global::java.lang.Throwable getCause()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.reflect.UndeclaredThrowableException.staticClass, global::java.lang.reflect.UndeclaredThrowableException._getCause21158)) as java.lang.Throwable;
		}
		public new global::java.lang.Throwable UndeclaredThrowable
		{
			get
			{
				return getUndeclaredThrowable();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUndeclaredThrowable21159;
		public virtual global::java.lang.Throwable getUndeclaredThrowable()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.reflect.UndeclaredThrowableException.staticClass, global::java.lang.reflect.UndeclaredThrowableException._getUndeclaredThrowable21159)) as java.lang.Throwable;
		}
		internal static global::MonoJavaBridge.MethodId _UndeclaredThrowableException21160;
		public UndeclaredThrowableException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.reflect.UndeclaredThrowableException.staticClass, global::java.lang.reflect.UndeclaredThrowableException._UndeclaredThrowableException21160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _UndeclaredThrowableException21161;
		public UndeclaredThrowableException(java.lang.Throwable arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.reflect.UndeclaredThrowableException.staticClass, global::java.lang.reflect.UndeclaredThrowableException._UndeclaredThrowableException21161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static UndeclaredThrowableException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.UndeclaredThrowableException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/UndeclaredThrowableException"));
			global::java.lang.reflect.UndeclaredThrowableException._getCause21158 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.UndeclaredThrowableException.staticClass, "getCause", "()Ljava/lang/Throwable;");
			global::java.lang.reflect.UndeclaredThrowableException._getUndeclaredThrowable21159 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.UndeclaredThrowableException.staticClass, "getUndeclaredThrowable", "()Ljava/lang/Throwable;");
			global::java.lang.reflect.UndeclaredThrowableException._UndeclaredThrowableException21160 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.UndeclaredThrowableException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::java.lang.reflect.UndeclaredThrowableException._UndeclaredThrowableException21161 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.UndeclaredThrowableException.staticClass, "<init>", "(Ljava/lang/Throwable;Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
