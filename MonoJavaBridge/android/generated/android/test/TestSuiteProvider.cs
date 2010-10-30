namespace android.test
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.test.TestSuiteProvider_))]
	public partial interface TestSuiteProvider  : global::MonoJavaBridge.IJavaObject 
	{
		global::junit.framework.TestSuite getTestSuite();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.test.TestSuiteProvider))]
	internal sealed partial class TestSuiteProvider_ : java.lang.Object, TestSuiteProvider
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal TestSuiteProvider_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getTestSuite12323;
		global::junit.framework.TestSuite android.test.TestSuiteProvider.getTestSuite()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.TestSuiteProvider_._getTestSuite12323.native == global::System.IntPtr.Zero)
				global::android.test.TestSuiteProvider_._getTestSuite12323 = @__env.GetMethodIDNoThrow(global::android.test.TestSuiteProvider_.staticClass, "getTestSuite", "()Ljunit/framework/TestSuite;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.TestSuiteProvider_._getTestSuite12323)) as junit.framework.TestSuite;
		}
		static TestSuiteProvider_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.TestSuiteProvider_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/TestSuiteProvider"));
		}
		internal static void InitJNI()
		{
		}
	}

	public delegate junit.framework.TestSuite TestSuiteProviderDelegate();

	internal partial class TestSuiteProviderDelegateWrapper : java.lang.Object, TestSuiteProvider
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TestSuiteProviderDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _TestSuiteProviderDelegateWrapper12324;
		public TestSuiteProviderDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.TestSuiteProviderDelegateWrapper._TestSuiteProviderDelegateWrapper12324.native == global::System.IntPtr.Zero)
				global::android.test.TestSuiteProviderDelegateWrapper._TestSuiteProviderDelegateWrapper12324 = @__env.GetMethodIDNoThrow(global::android.test.TestSuiteProviderDelegateWrapper.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.TestSuiteProviderDelegateWrapper.staticClass, global::android.test.TestSuiteProviderDelegateWrapper._TestSuiteProviderDelegateWrapper12324);
			Init(@__env, handle);
		}
		static TestSuiteProviderDelegateWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.TestSuiteProviderDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/TestSuiteProviderDelegateWrapper"));
		}
		internal static void InitJNI()
		{
		}
	}
	internal partial class TestSuiteProviderDelegateWrapper
	{
		private TestSuiteProviderDelegate myDelegate;
		public junit.framework.TestSuite getTestSuite()
		{
			return myDelegate();
		}
		public static implicit operator TestSuiteProviderDelegateWrapper(TestSuiteProviderDelegate d)
		{
			global::android.test.TestSuiteProviderDelegateWrapper ret = new global::android.test.TestSuiteProviderDelegateWrapper();
			ret.myDelegate = d;
			global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
			return ret;
		}
	}
}
