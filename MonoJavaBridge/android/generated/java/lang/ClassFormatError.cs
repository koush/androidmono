namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ClassFormatError : java.lang.LinkageError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ClassFormatError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public ClassFormatError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ClassFormatError._m0.native == global::System.IntPtr.Zero)
				global::java.lang.ClassFormatError._m0 = @__env.GetMethodIDNoThrow(global::java.lang.ClassFormatError.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ClassFormatError.staticClass, global::java.lang.ClassFormatError._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public ClassFormatError(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ClassFormatError._m1.native == global::System.IntPtr.Zero)
				global::java.lang.ClassFormatError._m1 = @__env.GetMethodIDNoThrow(global::java.lang.ClassFormatError.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ClassFormatError.staticClass, global::java.lang.ClassFormatError._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ClassFormatError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.ClassFormatError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ClassFormatError"));
		}
	}
}
