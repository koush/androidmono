namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnknownError : java.lang.VirtualMachineError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static UnknownError()
		{
			InitJNI();
		}
		protected UnknownError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _UnknownError20922;
		public UnknownError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.UnknownError.staticClass, global::java.lang.UnknownError._UnknownError20922);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _UnknownError20923;
		public UnknownError(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.UnknownError.staticClass, global::java.lang.UnknownError._UnknownError20923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.UnknownError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/UnknownError"));
			global::java.lang.UnknownError._UnknownError20922 = @__env.GetMethodIDNoThrow(global::java.lang.UnknownError.staticClass, "<init>", "()V");
			global::java.lang.UnknownError._UnknownError20923 = @__env.GetMethodIDNoThrow(global::java.lang.UnknownError.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
