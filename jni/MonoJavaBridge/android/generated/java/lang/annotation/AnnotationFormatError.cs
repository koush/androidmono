namespace java.lang.annotation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AnnotationFormatError : java.lang.Error
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AnnotationFormatError()
		{
			InitJNI();
		}
		protected AnnotationFormatError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _AnnotationFormatError20942;
		public AnnotationFormatError(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.annotation.AnnotationFormatError.staticClass, global::java.lang.annotation.AnnotationFormatError._AnnotationFormatError20942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AnnotationFormatError20943;
		public AnnotationFormatError(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.annotation.AnnotationFormatError.staticClass, global::java.lang.annotation.AnnotationFormatError._AnnotationFormatError20943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AnnotationFormatError20944;
		public AnnotationFormatError(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.annotation.AnnotationFormatError.staticClass, global::java.lang.annotation.AnnotationFormatError._AnnotationFormatError20944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.annotation.AnnotationFormatError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/annotation/AnnotationFormatError"));
			global::java.lang.annotation.AnnotationFormatError._AnnotationFormatError20942 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.AnnotationFormatError.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.annotation.AnnotationFormatError._AnnotationFormatError20943 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.AnnotationFormatError.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.lang.annotation.AnnotationFormatError._AnnotationFormatError20944 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.AnnotationFormatError.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
