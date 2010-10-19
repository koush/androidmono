namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class VerifyError : java.lang.LinkageError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static VerifyError()
		{
			InitJNI();
		}
		protected VerifyError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _VerifyError15292;
		public VerifyError()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.VerifyError.staticClass, global::java.lang.VerifyError._VerifyError15292);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _VerifyError15293;
		public VerifyError(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.VerifyError.staticClass, global::java.lang.VerifyError._VerifyError15293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.VerifyError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/VerifyError"));
			global::java.lang.VerifyError._VerifyError15292 = @__env.GetMethodIDNoThrow(global::java.lang.VerifyError.staticClass, "<init>", "()V");
			global::java.lang.VerifyError._VerifyError15293 = @__env.GetMethodIDNoThrow(global::java.lang.VerifyError.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
