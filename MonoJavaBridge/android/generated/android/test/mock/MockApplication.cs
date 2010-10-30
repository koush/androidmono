namespace android.test.mock
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MockApplication : android.app.Application
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MockApplication(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onCreate12379;
		public override void onCreate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockApplication.staticClass, "onCreate", "()V", ref global::android.test.mock.MockApplication._onCreate12379);
		}
		internal static global::MonoJavaBridge.MethodId _onConfigurationChanged12380;
		public override void onConfigurationChanged(android.content.res.Configuration arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockApplication.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V", ref global::android.test.mock.MockApplication._onConfigurationChanged12380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTerminate12381;
		public override void onTerminate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockApplication.staticClass, "onTerminate", "()V", ref global::android.test.mock.MockApplication._onTerminate12381);
		}
		internal static global::MonoJavaBridge.MethodId _MockApplication12382;
		public MockApplication() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockApplication._MockApplication12382.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockApplication._MockApplication12382 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockApplication.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.mock.MockApplication.staticClass, global::android.test.mock.MockApplication._MockApplication12382);
			Init(@__env, handle);
		}
		static MockApplication()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.mock.MockApplication.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/mock/MockApplication"));
		}
		internal static void InitJNI()
		{
		}
	}
}
