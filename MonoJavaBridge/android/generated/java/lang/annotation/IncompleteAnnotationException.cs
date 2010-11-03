namespace java.lang.annotation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IncompleteAnnotationException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IncompleteAnnotationException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.Class annotationType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.annotation.IncompleteAnnotationException.staticClass, "annotationType", "()Ljava/lang/Class;", ref global::java.lang.annotation.IncompleteAnnotationException._m0) as java.lang.Class;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.String elementName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.annotation.IncompleteAnnotationException.staticClass, "elementName", "()Ljava/lang/String;", ref global::java.lang.annotation.IncompleteAnnotationException._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public IncompleteAnnotationException(java.lang.Class arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.annotation.IncompleteAnnotationException._m2.native == global::System.IntPtr.Zero)
				global::java.lang.annotation.IncompleteAnnotationException._m2 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.IncompleteAnnotationException.staticClass, "<init>", "(Ljava/lang/Class;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.annotation.IncompleteAnnotationException.staticClass, global::java.lang.annotation.IncompleteAnnotationException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static IncompleteAnnotationException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.annotation.IncompleteAnnotationException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/annotation/IncompleteAnnotationException"));
		}
	}
}
