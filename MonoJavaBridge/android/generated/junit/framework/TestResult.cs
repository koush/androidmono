namespace junit.framework
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TestResult : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TestResult(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _run31401;
		protected virtual void run(junit.framework.TestCase arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._run31401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _stop31402;
		public virtual void stop()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._stop31402);
		}
		internal static global::MonoJavaBridge.MethodId _errors31403;
		public virtual global::java.util.Enumeration errors()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._errors31403)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _addError31404;
		public virtual void addError(junit.framework.Test arg0, java.lang.Throwable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._addError31404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addFailure31405;
		public virtual void addFailure(junit.framework.Test arg0, junit.framework.AssertionFailedError arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._addFailure31405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addListener31406;
		public virtual void addListener(junit.framework.TestListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._addListener31406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeListener31407;
		public virtual void removeListener(junit.framework.TestListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._removeListener31407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _endTest31408;
		public virtual void endTest(junit.framework.Test arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._endTest31408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _errorCount31409;
		public virtual int errorCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._errorCount31409);
		}
		internal static global::MonoJavaBridge.MethodId _failureCount31410;
		public virtual int failureCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._failureCount31410);
		}
		internal static global::MonoJavaBridge.MethodId _failures31411;
		public virtual global::java.util.Enumeration failures()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._failures31411)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _runCount31412;
		public virtual int runCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._runCount31412);
		}
		internal static global::MonoJavaBridge.MethodId _runProtected31413;
		public virtual void runProtected(junit.framework.Test arg0, junit.framework.Protectable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._runProtected31413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _shouldStop31414;
		public virtual bool shouldStop()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._shouldStop31414);
		}
		internal static global::MonoJavaBridge.MethodId _startTest31415;
		public virtual void startTest(junit.framework.Test arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._startTest31415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _wasSuccessful31416;
		public virtual bool wasSuccessful()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._wasSuccessful31416);
		}
		internal static global::MonoJavaBridge.MethodId _TestResult31417;
		public TestResult() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.TestResult.staticClass, global::junit.framework.TestResult._TestResult31417);
			Init(@__env, handle);
		}
		static TestResult()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.framework.TestResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/framework/TestResult"));
			global::junit.framework.TestResult._run31401 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "run", "(Ljunit/framework/TestCase;)V");
			global::junit.framework.TestResult._stop31402 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "stop", "()V");
			global::junit.framework.TestResult._errors31403 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "errors", "()Ljava/util/Enumeration;");
			global::junit.framework.TestResult._addError31404 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "addError", "(Ljunit/framework/Test;Ljava/lang/Throwable;)V");
			global::junit.framework.TestResult._addFailure31405 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "addFailure", "(Ljunit/framework/Test;Ljunit/framework/AssertionFailedError;)V");
			global::junit.framework.TestResult._addListener31406 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "addListener", "(Ljunit/framework/TestListener;)V");
			global::junit.framework.TestResult._removeListener31407 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "removeListener", "(Ljunit/framework/TestListener;)V");
			global::junit.framework.TestResult._endTest31408 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "endTest", "(Ljunit/framework/Test;)V");
			global::junit.framework.TestResult._errorCount31409 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "errorCount", "()I");
			global::junit.framework.TestResult._failureCount31410 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "failureCount", "()I");
			global::junit.framework.TestResult._failures31411 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "failures", "()Ljava/util/Enumeration;");
			global::junit.framework.TestResult._runCount31412 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "runCount", "()I");
			global::junit.framework.TestResult._runProtected31413 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "runProtected", "(Ljunit/framework/Test;Ljunit/framework/Protectable;)V");
			global::junit.framework.TestResult._shouldStop31414 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "shouldStop", "()Z");
			global::junit.framework.TestResult._startTest31415 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "startTest", "(Ljunit/framework/Test;)V");
			global::junit.framework.TestResult._wasSuccessful31416 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "wasSuccessful", "()Z");
			global::junit.framework.TestResult._TestResult31417 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
