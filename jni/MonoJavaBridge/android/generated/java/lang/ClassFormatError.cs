namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ClassFormatError : java.lang.LinkageError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ClassFormatError()
		{
			InitJNI();
		}
		protected ClassFormatError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ClassFormatError14414;
		public ClassFormatError()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ClassFormatError.staticClass, global::java.lang.ClassFormatError._ClassFormatError14414);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ClassFormatError14415;
		public ClassFormatError(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ClassFormatError.staticClass, global::java.lang.ClassFormatError._ClassFormatError14415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.ClassFormatError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ClassFormatError"));
			global::java.lang.ClassFormatError._ClassFormatError14414 = @__env.GetMethodIDNoThrow(global::java.lang.ClassFormatError.staticClass, "<init>", "()V");
			global::java.lang.ClassFormatError._ClassFormatError14415 = @__env.GetMethodIDNoThrow(global::java.lang.ClassFormatError.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
