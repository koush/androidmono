namespace java.lang.annotation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IncompleteAnnotationException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IncompleteAnnotationException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _annotationType20962;
		public virtual global::java.lang.Class annotationType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.annotation.IncompleteAnnotationException._annotationType20962.native == global::System.IntPtr.Zero)
				global::java.lang.annotation.IncompleteAnnotationException._annotationType20962 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.IncompleteAnnotationException.staticClass, "annotationType", "()Ljava/lang/Class;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.annotation.IncompleteAnnotationException.staticClass, global::java.lang.annotation.IncompleteAnnotationException._annotationType20962) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _elementName20963;
		public virtual global::java.lang.String elementName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.annotation.IncompleteAnnotationException._elementName20963.native == global::System.IntPtr.Zero)
				global::java.lang.annotation.IncompleteAnnotationException._elementName20963 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.IncompleteAnnotationException.staticClass, "elementName", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.annotation.IncompleteAnnotationException.staticClass, global::java.lang.annotation.IncompleteAnnotationException._elementName20963) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _IncompleteAnnotationException20964;
		public IncompleteAnnotationException(java.lang.Class arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.annotation.IncompleteAnnotationException._IncompleteAnnotationException20964.native == global::System.IntPtr.Zero)
				global::java.lang.annotation.IncompleteAnnotationException._IncompleteAnnotationException20964 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.IncompleteAnnotationException.staticClass, "<init>", "(Ljava/lang/Class;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.annotation.IncompleteAnnotationException.staticClass, global::java.lang.annotation.IncompleteAnnotationException._IncompleteAnnotationException20964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static IncompleteAnnotationException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.annotation.IncompleteAnnotationException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/annotation/IncompleteAnnotationException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
