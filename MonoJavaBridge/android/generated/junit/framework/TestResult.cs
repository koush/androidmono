namespace junit.framework
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TestResult : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TestResult(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected virtual void run(junit.framework.TestCase arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestResult.staticClass, "run", "(Ljunit/framework/TestCase;)V", ref global::junit.framework.TestResult._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void stop()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestResult.staticClass, "stop", "()V", ref global::junit.framework.TestResult._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.util.Enumeration errors()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::junit.framework.TestResult.staticClass, "errors", "()Ljava/util/Enumeration;", ref global::junit.framework.TestResult._m2) as java.util.Enumeration;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void addError(junit.framework.Test arg0, java.lang.Throwable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestResult.staticClass, "addError", "(Ljunit/framework/Test;Ljava/lang/Throwable;)V", ref global::junit.framework.TestResult._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void addFailure(junit.framework.Test arg0, junit.framework.AssertionFailedError arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestResult.staticClass, "addFailure", "(Ljunit/framework/Test;Ljunit/framework/AssertionFailedError;)V", ref global::junit.framework.TestResult._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void addListener(junit.framework.TestListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestResult.staticClass, "addListener", "(Ljunit/framework/TestListener;)V", ref global::junit.framework.TestResult._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void removeListener(junit.framework.TestListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestResult.staticClass, "removeListener", "(Ljunit/framework/TestListener;)V", ref global::junit.framework.TestResult._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void endTest(junit.framework.Test arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestResult.staticClass, "endTest", "(Ljunit/framework/Test;)V", ref global::junit.framework.TestResult._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual int errorCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::junit.framework.TestResult.staticClass, "errorCount", "()I", ref global::junit.framework.TestResult._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual int failureCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::junit.framework.TestResult.staticClass, "failureCount", "()I", ref global::junit.framework.TestResult._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::java.util.Enumeration failures()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::junit.framework.TestResult.staticClass, "failures", "()Ljava/util/Enumeration;", ref global::junit.framework.TestResult._m10) as java.util.Enumeration;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual int runCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::junit.framework.TestResult.staticClass, "runCount", "()I", ref global::junit.framework.TestResult._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void runProtected(junit.framework.Test arg0, junit.framework.Protectable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestResult.staticClass, "runProtected", "(Ljunit/framework/Test;Ljunit/framework/Protectable;)V", ref global::junit.framework.TestResult._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual bool shouldStop()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::junit.framework.TestResult.staticClass, "shouldStop", "()Z", ref global::junit.framework.TestResult._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void startTest(junit.framework.Test arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestResult.staticClass, "startTest", "(Ljunit/framework/Test;)V", ref global::junit.framework.TestResult._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual bool wasSuccessful()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::junit.framework.TestResult.staticClass, "wasSuccessful", "()Z", ref global::junit.framework.TestResult._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public TestResult() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestResult._m16.native == global::System.IntPtr.Zero)
				global::junit.framework.TestResult._m16 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.TestResult.staticClass, global::junit.framework.TestResult._m16);
			Init(@__env, handle);
		}
		static TestResult()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.framework.TestResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/framework/TestResult"));
		}
	}
}
