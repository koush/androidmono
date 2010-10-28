namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.reflect.AnnotatedElement_))]
	public partial interface AnnotatedElement  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.annotation.Annotation getAnnotation(java.lang.Class arg0);
		bool isAnnotationPresent(java.lang.Class arg0);
		global::java.lang.annotation.Annotation[] getAnnotations();
		global::java.lang.annotation.Annotation[] getDeclaredAnnotations();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.reflect.AnnotatedElement))]
	internal sealed partial class AnnotatedElement_ : java.lang.Object, AnnotatedElement
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AnnotatedElement_()
		{
			InitJNI();
		}
		internal AnnotatedElement_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getAnnotation21007;
		global::java.lang.annotation.Annotation java.lang.reflect.AnnotatedElement.getAnnotation(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.annotation.Annotation>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.AnnotatedElement_._getAnnotation21007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.Annotation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.AnnotatedElement_.staticClass, global::java.lang.reflect.AnnotatedElement_._getAnnotation21007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.Annotation;
		}
		internal static global::MonoJavaBridge.MethodId _isAnnotationPresent21008;
		bool java.lang.reflect.AnnotatedElement.isAnnotationPresent(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.reflect.AnnotatedElement_._isAnnotationPresent21008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.AnnotatedElement_.staticClass, global::java.lang.reflect.AnnotatedElement_._isAnnotationPresent21008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAnnotations21009;
		global::java.lang.annotation.Annotation[] java.lang.reflect.AnnotatedElement.getAnnotations()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.AnnotatedElement_._getAnnotations21009)) as java.lang.annotation.Annotation[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.AnnotatedElement_.staticClass, global::java.lang.reflect.AnnotatedElement_._getAnnotations21009)) as java.lang.annotation.Annotation[];
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredAnnotations21010;
		global::java.lang.annotation.Annotation[] java.lang.reflect.AnnotatedElement.getDeclaredAnnotations()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.AnnotatedElement_._getDeclaredAnnotations21010)) as java.lang.annotation.Annotation[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.AnnotatedElement_.staticClass, global::java.lang.reflect.AnnotatedElement_._getDeclaredAnnotations21010)) as java.lang.annotation.Annotation[];
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.AnnotatedElement_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/AnnotatedElement"));
			global::java.lang.reflect.AnnotatedElement_._getAnnotation21007 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.AnnotatedElement_.staticClass, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;");
			global::java.lang.reflect.AnnotatedElement_._isAnnotationPresent21008 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.AnnotatedElement_.staticClass, "isAnnotationPresent", "(Ljava/lang/Class;)Z");
			global::java.lang.reflect.AnnotatedElement_._getAnnotations21009 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.AnnotatedElement_.staticClass, "getAnnotations", "()[Ljava/lang/annotation/Annotation;");
			global::java.lang.reflect.AnnotatedElement_._getDeclaredAnnotations21010 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.AnnotatedElement_.staticClass, "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;");
		}
	}
}
