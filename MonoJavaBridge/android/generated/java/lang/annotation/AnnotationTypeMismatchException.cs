namespace java.lang.annotation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AnnotationTypeMismatchException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AnnotationTypeMismatchException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _element20945;
		public virtual global::java.lang.reflect.Method element()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.annotation.AnnotationTypeMismatchException._element20945.native == global::System.IntPtr.Zero)
				global::java.lang.annotation.AnnotationTypeMismatchException._element20945 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.AnnotationTypeMismatchException.staticClass, "element", "()Ljava/lang/reflect/Method;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.reflect.Method>(this, global::java.lang.annotation.AnnotationTypeMismatchException.staticClass, global::java.lang.annotation.AnnotationTypeMismatchException._element20945) as java.lang.reflect.Method;
		}
		internal static global::MonoJavaBridge.MethodId _foundType20946;
		public virtual global::java.lang.String foundType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.annotation.AnnotationTypeMismatchException._foundType20946.native == global::System.IntPtr.Zero)
				global::java.lang.annotation.AnnotationTypeMismatchException._foundType20946 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.AnnotationTypeMismatchException.staticClass, "foundType", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.annotation.AnnotationTypeMismatchException.staticClass, global::java.lang.annotation.AnnotationTypeMismatchException._foundType20946) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _AnnotationTypeMismatchException20947;
		public AnnotationTypeMismatchException(java.lang.reflect.Method arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.annotation.AnnotationTypeMismatchException._AnnotationTypeMismatchException20947.native == global::System.IntPtr.Zero)
				global::java.lang.annotation.AnnotationTypeMismatchException._AnnotationTypeMismatchException20947 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.AnnotationTypeMismatchException.staticClass, "<init>", "(Ljava/lang/reflect/Method;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.annotation.AnnotationTypeMismatchException.staticClass, global::java.lang.annotation.AnnotationTypeMismatchException._AnnotationTypeMismatchException20947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static AnnotationTypeMismatchException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.annotation.AnnotationTypeMismatchException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/annotation/AnnotationTypeMismatchException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
