namespace android.test
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AssertionFailedError : java.lang.Error
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AssertionFailedError()
		{
			InitJNI();
		}
		protected AssertionFailedError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _AssertionFailedError12177;
		public AssertionFailedError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.AssertionFailedError.staticClass, global::android.test.AssertionFailedError._AssertionFailedError12177);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AssertionFailedError12178;
		public AssertionFailedError(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.AssertionFailedError.staticClass, global::android.test.AssertionFailedError._AssertionFailedError12178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.AssertionFailedError.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/AssertionFailedError"));
			global::android.test.AssertionFailedError._AssertionFailedError12177 = @__env.GetMethodIDNoThrow(global::android.test.AssertionFailedError.staticClass, "<init>", "()V");
			global::android.test.AssertionFailedError._AssertionFailedError12178 = @__env.GetMethodIDNoThrow(global::android.test.AssertionFailedError.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
