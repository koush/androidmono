namespace junit.runner
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::junit.runner.TestSuiteLoader_))]
	public partial interface TestSuiteLoader  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Class load(java.lang.String arg0);
		global::java.lang.Class reload(java.lang.Class arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::junit.runner.TestSuiteLoader))]
	internal sealed partial class TestSuiteLoader_ : java.lang.Object, TestSuiteLoader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal TestSuiteLoader_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.Class junit.runner.TestSuiteLoader.load(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::junit.runner.TestSuiteLoader_.staticClass, "load", "(Ljava/lang/String;)Ljava/lang/Class;", ref global::junit.runner.TestSuiteLoader_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Class;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.Class junit.runner.TestSuiteLoader.reload(java.lang.Class arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::junit.runner.TestSuiteLoader_.staticClass, "reload", "(Ljava/lang/Class;)Ljava/lang/Class;", ref global::junit.runner.TestSuiteLoader_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Class;
		}
		static TestSuiteLoader_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.runner.TestSuiteLoader_.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/runner/TestSuiteLoader"));
		}
	}
}
