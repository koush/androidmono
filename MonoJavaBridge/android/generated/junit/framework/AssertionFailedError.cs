namespace junit.framework
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AssertionFailedError : java.lang.Error
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AssertionFailedError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public AssertionFailedError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.AssertionFailedError._m0.native == global::System.IntPtr.Zero)
				global::junit.framework.AssertionFailedError._m0 = @__env.GetMethodIDNoThrow(global::junit.framework.AssertionFailedError.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.AssertionFailedError.staticClass, global::junit.framework.AssertionFailedError._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public AssertionFailedError(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.AssertionFailedError._m1.native == global::System.IntPtr.Zero)
				global::junit.framework.AssertionFailedError._m1 = @__env.GetMethodIDNoThrow(global::junit.framework.AssertionFailedError.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.AssertionFailedError.staticClass, global::junit.framework.AssertionFailedError._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static AssertionFailedError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.framework.AssertionFailedError.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/framework/AssertionFailedError"));
		}
		internal static void InitJNI()
		{
		}
	}
}
