namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StackOverflowError : java.lang.VirtualMachineError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected StackOverflowError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _StackOverflowError20531;
		public StackOverflowError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StackOverflowError.staticClass, global::java.lang.StackOverflowError._StackOverflowError20531);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StackOverflowError20532;
		public StackOverflowError(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StackOverflowError.staticClass, global::java.lang.StackOverflowError._StackOverflowError20532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static StackOverflowError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.StackOverflowError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/StackOverflowError"));
			global::java.lang.StackOverflowError._StackOverflowError20531 = @__env.GetMethodIDNoThrow(global::java.lang.StackOverflowError.staticClass, "<init>", "()V");
			global::java.lang.StackOverflowError._StackOverflowError20532 = @__env.GetMethodIDNoThrow(global::java.lang.StackOverflowError.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
