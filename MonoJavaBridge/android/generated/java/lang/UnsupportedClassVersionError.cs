namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnsupportedClassVersionError : java.lang.ClassFormatError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected UnsupportedClassVersionError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _UnsupportedClassVersionError20927;
		public UnsupportedClassVersionError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.UnsupportedClassVersionError._UnsupportedClassVersionError20927.native == global::System.IntPtr.Zero)
				global::java.lang.UnsupportedClassVersionError._UnsupportedClassVersionError20927 = @__env.GetMethodIDNoThrow(global::java.lang.UnsupportedClassVersionError.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.UnsupportedClassVersionError.staticClass, global::java.lang.UnsupportedClassVersionError._UnsupportedClassVersionError20927);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _UnsupportedClassVersionError20928;
		public UnsupportedClassVersionError(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.UnsupportedClassVersionError._UnsupportedClassVersionError20928.native == global::System.IntPtr.Zero)
				global::java.lang.UnsupportedClassVersionError._UnsupportedClassVersionError20928 = @__env.GetMethodIDNoThrow(global::java.lang.UnsupportedClassVersionError.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.UnsupportedClassVersionError.staticClass, global::java.lang.UnsupportedClassVersionError._UnsupportedClassVersionError20928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static UnsupportedClassVersionError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.UnsupportedClassVersionError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/UnsupportedClassVersionError"));
		}
		internal static void InitJNI()
		{
		}
	}
}
