namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnknownError : java.lang.VirtualMachineError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected UnknownError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _UnknownError20923;
		public UnknownError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.UnknownError.staticClass, global::java.lang.UnknownError._UnknownError20923);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _UnknownError20924;
		public UnknownError(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.UnknownError.staticClass, global::java.lang.UnknownError._UnknownError20924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static UnknownError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.UnknownError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/UnknownError"));
			global::java.lang.UnknownError._UnknownError20923 = @__env.GetMethodIDNoThrow(global::java.lang.UnknownError.staticClass, "<init>", "()V");
			global::java.lang.UnknownError._UnknownError20924 = @__env.GetMethodIDNoThrow(global::java.lang.UnknownError.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
