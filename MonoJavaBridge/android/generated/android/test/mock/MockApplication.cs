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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockApplication._onCreate12379);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockApplication.staticClass, global::android.test.mock.MockApplication._onCreate12379);
		}
		internal static global::MonoJavaBridge.MethodId _onConfigurationChanged12380;
		public override void onConfigurationChanged(android.content.res.Configuration arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockApplication._onConfigurationChanged12380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockApplication.staticClass, global::android.test.mock.MockApplication._onConfigurationChanged12380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTerminate12381;
		public override void onTerminate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockApplication._onTerminate12381);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockApplication.staticClass, global::android.test.mock.MockApplication._onTerminate12381);
		}
		internal static global::MonoJavaBridge.MethodId _MockApplication12382;
		public MockApplication() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.mock.MockApplication.staticClass, global::android.test.mock.MockApplication._MockApplication12382);
			Init(@__env, handle);
		}
		static MockApplication()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.mock.MockApplication.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/mock/MockApplication"));
			global::android.test.mock.MockApplication._onCreate12379 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockApplication.staticClass, "onCreate", "()V");
			global::android.test.mock.MockApplication._onConfigurationChanged12380 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockApplication.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			global::android.test.mock.MockApplication._onTerminate12381 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockApplication.staticClass, "onTerminate", "()V");
			global::android.test.mock.MockApplication._MockApplication12382 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockApplication.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
