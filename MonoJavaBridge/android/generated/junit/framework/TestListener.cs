namespace junit.framework
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::junit.framework.TestListener_))]
	public partial interface TestListener  : global::MonoJavaBridge.IJavaObject 
	{
		void addError(junit.framework.Test arg0, java.lang.Throwable arg1);
		void addFailure(junit.framework.Test arg0, junit.framework.AssertionFailedError arg1);
		void endTest(junit.framework.Test arg0);
		void startTest(junit.framework.Test arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::junit.framework.TestListener))]
	internal sealed partial class TestListener_ : java.lang.Object, TestListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal TestListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void junit.framework.TestListener.addError(junit.framework.Test arg0, java.lang.Throwable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestListener_.staticClass, "addError", "(Ljunit/framework/Test;Ljava/lang/Throwable;)V", ref global::junit.framework.TestListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void junit.framework.TestListener.addFailure(junit.framework.Test arg0, junit.framework.AssertionFailedError arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestListener_.staticClass, "addFailure", "(Ljunit/framework/Test;Ljunit/framework/AssertionFailedError;)V", ref global::junit.framework.TestListener_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void junit.framework.TestListener.endTest(junit.framework.Test arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestListener_.staticClass, "endTest", "(Ljunit/framework/Test;)V", ref global::junit.framework.TestListener_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void junit.framework.TestListener.startTest(junit.framework.Test arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestListener_.staticClass, "startTest", "(Ljunit/framework/Test;)V", ref global::junit.framework.TestListener_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static TestListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.framework.TestListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/framework/TestListener"));
		}
		internal static void InitJNI()
		{
		}
	}
}
