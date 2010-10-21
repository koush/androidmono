namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UndeclaredThrowableException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static UndeclaredThrowableException()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getCause21039;
		public override global::java.lang.Throwable getCause() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.UndeclaredThrowableException._getCause21039)) as java.lang.Throwable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.UndeclaredThrowableException.staticClass, global::java.lang.reflect.UndeclaredThrowableException._getCause21039)) as java.lang.Throwable;
		}
		public new global::java.lang.Throwable UndeclaredThrowable
		{
			get
			{
				return getUndeclaredThrowable();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUndeclaredThrowable21040;
		public virtual global::java.lang.Throwable getUndeclaredThrowable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.UndeclaredThrowableException._getUndeclaredThrowable21040)) as java.lang.Throwable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.UndeclaredThrowableException.staticClass, global::java.lang.reflect.UndeclaredThrowableException._getUndeclaredThrowable21040)) as java.lang.Throwable;
		}
		internal static global::MonoJavaBridge.MethodId _UndeclaredThrowableException21041;
		public UndeclaredThrowableException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.reflect.UndeclaredThrowableException.staticClass, global::java.lang.reflect.UndeclaredThrowableException._UndeclaredThrowableException21041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _UndeclaredThrowableException21042;
		public UndeclaredThrowableException(java.lang.Throwable arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.reflect.UndeclaredThrowableException.staticClass, global::java.lang.reflect.UndeclaredThrowableException._UndeclaredThrowableException21042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.UndeclaredThrowableException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/UndeclaredThrowableException"));
			global::java.lang.reflect.UndeclaredThrowableException._getCause21039 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.UndeclaredThrowableException.staticClass, "getCause", "()Ljava/lang/Throwable;");
			global::java.lang.reflect.UndeclaredThrowableException._getUndeclaredThrowable21040 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.UndeclaredThrowableException.staticClass, "getUndeclaredThrowable", "()Ljava/lang/Throwable;");
			global::java.lang.reflect.UndeclaredThrowableException._UndeclaredThrowableException21041 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.UndeclaredThrowableException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::java.lang.reflect.UndeclaredThrowableException._UndeclaredThrowableException21042 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.UndeclaredThrowableException.staticClass, "<init>", "(Ljava/lang/Throwable;Ljava/lang/String;)V");
		}
	}
}
