namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StackOverflowError : java.lang.VirtualMachineError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static StackOverflowError()
		{
			InitJNI();
		}
		protected StackOverflowError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _StackOverflowError20412;
		public StackOverflowError()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StackOverflowError.staticClass, global::java.lang.StackOverflowError._StackOverflowError20412);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StackOverflowError20413;
		public StackOverflowError(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StackOverflowError.staticClass, global::java.lang.StackOverflowError._StackOverflowError20413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.StackOverflowError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/StackOverflowError"));
			global::java.lang.StackOverflowError._StackOverflowError20412 = @__env.GetMethodIDNoThrow(global::java.lang.StackOverflowError.staticClass, "<init>", "()V");
			global::java.lang.StackOverflowError._StackOverflowError20413 = @__env.GetMethodIDNoThrow(global::java.lang.StackOverflowError.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
