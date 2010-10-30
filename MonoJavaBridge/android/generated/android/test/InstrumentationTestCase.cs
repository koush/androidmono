namespace android.test
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InstrumentationTestCase : junit.framework.TestCase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InstrumentationTestCase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _launchActivity12186;
		public virtual global::android.app.Activity launchActivity(java.lang.String arg0, java.lang.Class arg1, android.os.Bundle arg2)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.InstrumentationTestCase.staticClass, global::android.test.InstrumentationTestCase._launchActivity12186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.Activity;
		}
		internal static global::MonoJavaBridge.MethodId _tearDown12187;
		protected override void tearDown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.InstrumentationTestCase.staticClass, global::android.test.InstrumentationTestCase._tearDown12187);
		}
		internal static global::MonoJavaBridge.MethodId _injectInstrumentation12188;
		public virtual void injectInstrumentation(android.app.Instrumentation arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.InstrumentationTestCase.staticClass, global::android.test.InstrumentationTestCase._injectInstrumentation12188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _injectInsrumentation12189;
		public virtual void injectInsrumentation(android.app.Instrumentation arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.InstrumentationTestCase.staticClass, global::android.test.InstrumentationTestCase._injectInsrumentation12189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.app.Instrumentation Instrumentation
		{
			get
			{
				return getInstrumentation();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInstrumentation12190;
		public virtual global::android.app.Instrumentation getInstrumentation()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.InstrumentationTestCase.staticClass, global::android.test.InstrumentationTestCase._getInstrumentation12190)) as android.app.Instrumentation;
		}
		internal static global::MonoJavaBridge.MethodId _launchActivityWithIntent12191;
		public virtual global::android.app.Activity launchActivityWithIntent(java.lang.String arg0, java.lang.Class arg1, android.content.Intent arg2)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.InstrumentationTestCase.staticClass, global::android.test.InstrumentationTestCase._launchActivityWithIntent12191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.Activity;
		}
		internal static global::MonoJavaBridge.MethodId _runTestOnUiThread12192;
		public virtual void runTestOnUiThread(java.lang.Runnable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.InstrumentationTestCase.staticClass, global::android.test.InstrumentationTestCase._runTestOnUiThread12192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void runTestOnUiThread(global::java.lang.RunnableDelegate arg0)
		{
			runTestOnUiThread((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _runTest12193;
		protected override void runTest()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.InstrumentationTestCase.staticClass, global::android.test.InstrumentationTestCase._runTest12193);
		}
		internal static global::MonoJavaBridge.MethodId _sendKeys12194;
		public virtual void sendKeys(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.InstrumentationTestCase.staticClass, global::android.test.InstrumentationTestCase._sendKeys12194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendKeys12195;
		public virtual void sendKeys(int[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.InstrumentationTestCase.staticClass, global::android.test.InstrumentationTestCase._sendKeys12195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendRepeatedKeys12196;
		public virtual void sendRepeatedKeys(int[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.InstrumentationTestCase.staticClass, global::android.test.InstrumentationTestCase._sendRepeatedKeys12196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _InstrumentationTestCase12197;
		public InstrumentationTestCase() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.InstrumentationTestCase.staticClass, global::android.test.InstrumentationTestCase._InstrumentationTestCase12197);
			Init(@__env, handle);
		}
		static InstrumentationTestCase()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.InstrumentationTestCase.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/InstrumentationTestCase"));
			global::android.test.InstrumentationTestCase._launchActivity12186 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestCase.staticClass, "launchActivity", "(Ljava/lang/String;Ljava/lang/Class;Landroid/os/Bundle;)Landroid/app/Activity;");
			global::android.test.InstrumentationTestCase._tearDown12187 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestCase.staticClass, "tearDown", "()V");
			global::android.test.InstrumentationTestCase._injectInstrumentation12188 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestCase.staticClass, "injectInstrumentation", "(Landroid/app/Instrumentation;)V");
			global::android.test.InstrumentationTestCase._injectInsrumentation12189 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestCase.staticClass, "injectInsrumentation", "(Landroid/app/Instrumentation;)V");
			global::android.test.InstrumentationTestCase._getInstrumentation12190 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestCase.staticClass, "getInstrumentation", "()Landroid/app/Instrumentation;");
			global::android.test.InstrumentationTestCase._launchActivityWithIntent12191 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestCase.staticClass, "launchActivityWithIntent", "(Ljava/lang/String;Ljava/lang/Class;Landroid/content/Intent;)Landroid/app/Activity;");
			global::android.test.InstrumentationTestCase._runTestOnUiThread12192 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestCase.staticClass, "runTestOnUiThread", "(Ljava/lang/Runnable;)V");
			global::android.test.InstrumentationTestCase._runTest12193 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestCase.staticClass, "runTest", "()V");
			global::android.test.InstrumentationTestCase._sendKeys12194 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestCase.staticClass, "sendKeys", "(Ljava/lang/String;)V");
			global::android.test.InstrumentationTestCase._sendKeys12195 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestCase.staticClass, "sendKeys", "([I)V");
			global::android.test.InstrumentationTestCase._sendRepeatedKeys12196 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestCase.staticClass, "sendRepeatedKeys", "([I)V");
			global::android.test.InstrumentationTestCase._InstrumentationTestCase12197 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestCase.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
