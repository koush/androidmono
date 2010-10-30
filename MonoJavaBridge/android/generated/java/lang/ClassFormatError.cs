namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ClassFormatError : java.lang.LinkageError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ClassFormatError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ClassFormatError20038;
		public ClassFormatError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ClassFormatError._ClassFormatError20038.native == global::System.IntPtr.Zero)
				global::java.lang.ClassFormatError._ClassFormatError20038 = @__env.GetMethodIDNoThrow(global::java.lang.ClassFormatError.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ClassFormatError.staticClass, global::java.lang.ClassFormatError._ClassFormatError20038);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ClassFormatError20039;
		public ClassFormatError(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ClassFormatError._ClassFormatError20039.native == global::System.IntPtr.Zero)
				global::java.lang.ClassFormatError._ClassFormatError20039 = @__env.GetMethodIDNoThrow(global::java.lang.ClassFormatError.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ClassFormatError.staticClass, global::java.lang.ClassFormatError._ClassFormatError20039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ClassFormatError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.ClassFormatError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ClassFormatError"));
		}
		internal static void InitJNI()
		{
		}
	}
}
