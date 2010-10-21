namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InternalError : java.lang.VirtualMachineError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InternalError()
		{
			InitJNI();
		}
		protected InternalError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _InternalError20118;
		public InternalError()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.InternalError.staticClass, global::java.lang.InternalError._InternalError20118);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InternalError20119;
		public InternalError(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.InternalError.staticClass, global::java.lang.InternalError._InternalError20119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.InternalError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/InternalError"));
			global::java.lang.InternalError._InternalError20118 = @__env.GetMethodIDNoThrow(global::java.lang.InternalError.staticClass, "<init>", "()V");
			global::java.lang.InternalError._InternalError20119 = @__env.GetMethodIDNoThrow(global::java.lang.InternalError.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
