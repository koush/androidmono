namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnsupportedClassVersionError : java.lang.ClassFormatError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static UnsupportedClassVersionError()
		{
			InitJNI();
		}
		protected UnsupportedClassVersionError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _UnsupportedClassVersionError20926;
		public UnsupportedClassVersionError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.UnsupportedClassVersionError.staticClass, global::java.lang.UnsupportedClassVersionError._UnsupportedClassVersionError20926);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _UnsupportedClassVersionError20927;
		public UnsupportedClassVersionError(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.UnsupportedClassVersionError.staticClass, global::java.lang.UnsupportedClassVersionError._UnsupportedClassVersionError20927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.UnsupportedClassVersionError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/UnsupportedClassVersionError"));
			global::java.lang.UnsupportedClassVersionError._UnsupportedClassVersionError20926 = @__env.GetMethodIDNoThrow(global::java.lang.UnsupportedClassVersionError.staticClass, "<init>", "()V");
			global::java.lang.UnsupportedClassVersionError._UnsupportedClassVersionError20927 = @__env.GetMethodIDNoThrow(global::java.lang.UnsupportedClassVersionError.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
