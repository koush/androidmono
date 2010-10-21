namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InvocationTargetException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InvocationTargetException()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getCause20966;
		public override global::java.lang.Throwable getCause() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.InvocationTargetException._getCause20966)) as java.lang.Throwable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.InvocationTargetException.staticClass, global::java.lang.reflect.InvocationTargetException._getCause20966)) as java.lang.Throwable;
		}
		public new global::java.lang.Throwable TargetException
		{
			get
			{
				return getTargetException();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTargetException20967;
		public virtual global::java.lang.Throwable getTargetException() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.InvocationTargetException._getTargetException20967)) as java.lang.Throwable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.InvocationTargetException.staticClass, global::java.lang.reflect.InvocationTargetException._getTargetException20967)) as java.lang.Throwable;
		}
		internal static global::MonoJavaBridge.MethodId _InvocationTargetException20968;
		protected InvocationTargetException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.reflect.InvocationTargetException.staticClass, global::java.lang.reflect.InvocationTargetException._InvocationTargetException20968);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InvocationTargetException20969;
		public InvocationTargetException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.reflect.InvocationTargetException.staticClass, global::java.lang.reflect.InvocationTargetException._InvocationTargetException20969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InvocationTargetException20970;
		public InvocationTargetException(java.lang.Throwable arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.reflect.InvocationTargetException.staticClass, global::java.lang.reflect.InvocationTargetException._InvocationTargetException20970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.InvocationTargetException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/InvocationTargetException"));
			global::java.lang.reflect.InvocationTargetException._getCause20966 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.InvocationTargetException.staticClass, "getCause", "()Ljava/lang/Throwable;");
			global::java.lang.reflect.InvocationTargetException._getTargetException20967 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.InvocationTargetException.staticClass, "getTargetException", "()Ljava/lang/Throwable;");
			global::java.lang.reflect.InvocationTargetException._InvocationTargetException20968 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.InvocationTargetException.staticClass, "<init>", "()V");
			global::java.lang.reflect.InvocationTargetException._InvocationTargetException20969 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.InvocationTargetException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::java.lang.reflect.InvocationTargetException._InvocationTargetException20970 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.InvocationTargetException.staticClass, "<init>", "(Ljava/lang/Throwable;Ljava/lang/String;)V");
		}
	}
}
