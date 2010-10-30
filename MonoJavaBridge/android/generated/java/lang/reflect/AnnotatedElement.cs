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
		internal AnnotatedElement_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getAnnotation21007;
		global::java.lang.annotation.Annotation java.lang.reflect.AnnotatedElement.getAnnotation(java.lang.Class arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.annotation.Annotation>(this, global::java.lang.reflect.AnnotatedElement_.staticClass, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", ref global::java.lang.reflect.AnnotatedElement_._getAnnotation21007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.annotation.Annotation;
		}
		internal static global::MonoJavaBridge.MethodId _isAnnotationPresent21008;
		bool java.lang.reflect.AnnotatedElement.isAnnotationPresent(java.lang.Class arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.reflect.AnnotatedElement_.staticClass, "isAnnotationPresent", "(Ljava/lang/Class;)Z", ref global::java.lang.reflect.AnnotatedElement_._isAnnotationPresent21008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAnnotations21009;
		global::java.lang.annotation.Annotation[] java.lang.reflect.AnnotatedElement.getAnnotations()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.annotation.Annotation>(this, global::java.lang.reflect.AnnotatedElement_.staticClass, "getAnnotations", "()[Ljava/lang/annotation/Annotation;", ref global::java.lang.reflect.AnnotatedElement_._getAnnotations21009) as java.lang.annotation.Annotation[];
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredAnnotations21010;
		global::java.lang.annotation.Annotation[] java.lang.reflect.AnnotatedElement.getDeclaredAnnotations()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.annotation.Annotation>(this, global::java.lang.reflect.AnnotatedElement_.staticClass, "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;", ref global::java.lang.reflect.AnnotatedElement_._getDeclaredAnnotations21010) as java.lang.annotation.Annotation[];
		}
		static AnnotatedElement_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.AnnotatedElement_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/AnnotatedElement"));
		}
		internal static void InitJNI()
		{
		}
	}
}
