namespace java.lang.annotation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AnnotationFormatError : java.lang.Error
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AnnotationFormatError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public AnnotationFormatError(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.annotation.AnnotationFormatError._m0.native == global::System.IntPtr.Zero)
				global::java.lang.annotation.AnnotationFormatError._m0 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.AnnotationFormatError.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.annotation.AnnotationFormatError.staticClass, global::java.lang.annotation.AnnotationFormatError._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public AnnotationFormatError(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.annotation.AnnotationFormatError._m1.native == global::System.IntPtr.Zero)
				global::java.lang.annotation.AnnotationFormatError._m1 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.AnnotationFormatError.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.annotation.AnnotationFormatError.staticClass, global::java.lang.annotation.AnnotationFormatError._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public AnnotationFormatError(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.annotation.AnnotationFormatError._m2.native == global::System.IntPtr.Zero)
				global::java.lang.annotation.AnnotationFormatError._m2 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.AnnotationFormatError.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.annotation.AnnotationFormatError.staticClass, global::java.lang.annotation.AnnotationFormatError._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static AnnotationFormatError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.annotation.AnnotationFormatError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/annotation/AnnotationFormatError"));
		}
	}
}
