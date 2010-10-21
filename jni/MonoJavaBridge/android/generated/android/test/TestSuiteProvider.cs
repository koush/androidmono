namespace android.test
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.test.TestSuiteProvider_))]
	public interface TestSuiteProvider  : global::MonoJavaBridge.IJavaObject 
	{
		global::junit.framework.TestSuite getTestSuite();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.test.TestSuiteProvider))]
	public sealed partial class TestSuiteProvider_ : java.lang.Object, TestSuiteProvider
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TestSuiteProvider_()
		{
			InitJNI();
		}
		internal TestSuiteProvider_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getTestSuite12266;
		 global::junit.framework.TestSuite android.test.TestSuiteProvider.getTestSuite() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.TestSuiteProvider_._getTestSuite12266)) as junit.framework.TestSuite;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.TestSuiteProvider_.staticClass, global::android.test.TestSuiteProvider_._getTestSuite12266)) as junit.framework.TestSuite;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.TestSuiteProvider_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/TestSuiteProvider"));
			global::android.test.TestSuiteProvider_._getTestSuite12266 = @__env.GetMethodIDNoThrow(global::android.test.TestSuiteProvider_.staticClass, "getTestSuite", "()Ljunit/framework/TestSuite;");
		}
	}
}
