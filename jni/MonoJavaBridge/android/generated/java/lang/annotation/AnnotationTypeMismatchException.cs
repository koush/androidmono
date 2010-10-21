namespace java.lang.annotation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AnnotationTypeMismatchException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AnnotationTypeMismatchException()
		{
			InitJNI();
		}
		protected AnnotationTypeMismatchException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _element20826;
		public virtual global::java.lang.reflect.Method element() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.annotation.AnnotationTypeMismatchException._element20826)) as java.lang.reflect.Method;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.annotation.AnnotationTypeMismatchException.staticClass, global::java.lang.annotation.AnnotationTypeMismatchException._element20826)) as java.lang.reflect.Method;
		}
		internal static global::MonoJavaBridge.MethodId _foundType20827;
		public virtual global::java.lang.String foundType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.annotation.AnnotationTypeMismatchException._foundType20827)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.annotation.AnnotationTypeMismatchException.staticClass, global::java.lang.annotation.AnnotationTypeMismatchException._foundType20827)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _AnnotationTypeMismatchException20828;
		public AnnotationTypeMismatchException(java.lang.reflect.Method arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.annotation.AnnotationTypeMismatchException.staticClass, global::java.lang.annotation.AnnotationTypeMismatchException._AnnotationTypeMismatchException20828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.annotation.AnnotationTypeMismatchException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/annotation/AnnotationTypeMismatchException"));
			global::java.lang.annotation.AnnotationTypeMismatchException._element20826 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.AnnotationTypeMismatchException.staticClass, "element", "()Ljava/lang/reflect/Method;");
			global::java.lang.annotation.AnnotationTypeMismatchException._foundType20827 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.AnnotationTypeMismatchException.staticClass, "foundType", "()Ljava/lang/String;");
			global::java.lang.annotation.AnnotationTypeMismatchException._AnnotationTypeMismatchException20828 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.AnnotationTypeMismatchException.staticClass, "<init>", "(Ljava/lang/reflect/Method;Ljava/lang/String;)V");
		}
	}
}
