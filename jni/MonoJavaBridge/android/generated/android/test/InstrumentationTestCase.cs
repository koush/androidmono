namespace android.test
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InstrumentationTestCase : junit.framework.TestCase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InstrumentationTestCase()
		{
			InitJNI();
		}
		protected InstrumentationTestCase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _launchActivity12129;
		public virtual global::android.app.Activity launchActivity(java.lang.String arg0, java.lang.Class arg1, android.os.Bundle arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.InstrumentationTestCase._launchActivity12129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.Activity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.InstrumentationTestCase.staticClass, global::android.test.InstrumentationTestCase._launchActivity12129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.Activity;
		}
		internal static global::MonoJavaBridge.MethodId _tearDown12130;
		protected override void tearDown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.InstrumentationTestCase._tearDown12130);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.InstrumentationTestCase.staticClass, global::android.test.InstrumentationTestCase._tearDown12130);
		}
		internal static global::MonoJavaBridge.MethodId _injectInstrumentation12131;
		public virtual void injectInstrumentation(android.app.Instrumentation arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.InstrumentationTestCase._injectInstrumentation12131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.InstrumentationTestCase.staticClass, global::android.test.InstrumentationTestCase._injectInstrumentation12131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _injectInsrumentation12132;
		public virtual void injectInsrumentation(android.app.Instrumentation arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.InstrumentationTestCase._injectInsrumentation12132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.InstrumentationTestCase.staticClass, global::android.test.InstrumentationTestCase._injectInsrumentation12132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.app.Instrumentation Instrumentation
		{
			get
			{
				return getInstrumentation();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInstrumentation12133;
		public virtual global::android.app.Instrumentation getInstrumentation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.InstrumentationTestCase._getInstrumentation12133)) as android.app.Instrumentation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.InstrumentationTestCase.staticClass, global::android.test.InstrumentationTestCase._getInstrumentation12133)) as android.app.Instrumentation;
		}
		internal static global::MonoJavaBridge.MethodId _launchActivityWithIntent12134;
		public virtual global::android.app.Activity launchActivityWithIntent(java.lang.String arg0, java.lang.Class arg1, android.content.Intent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.InstrumentationTestCase._launchActivityWithIntent12134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.Activity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.InstrumentationTestCase.staticClass, global::android.test.InstrumentationTestCase._launchActivityWithIntent12134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.Activity;
		}
		internal static global::MonoJavaBridge.MethodId _runTestOnUiThread12135;
		public virtual void runTestOnUiThread(java.lang.Runnable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.InstrumentationTestCase._runTestOnUiThread12135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.InstrumentationTestCase.staticClass, global::android.test.InstrumentationTestCase._runTestOnUiThread12135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _runTest12136;
		protected override void runTest() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.InstrumentationTestCase._runTest12136);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.InstrumentationTestCase.staticClass, global::android.test.InstrumentationTestCase._runTest12136);
		}
		internal static global::MonoJavaBridge.MethodId _sendKeys12137;
		public virtual void sendKeys(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.InstrumentationTestCase._sendKeys12137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.InstrumentationTestCase.staticClass, global::android.test.InstrumentationTestCase._sendKeys12137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendKeys12138;
		public virtual void sendKeys(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.InstrumentationTestCase._sendKeys12138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.InstrumentationTestCase.staticClass, global::android.test.InstrumentationTestCase._sendKeys12138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendRepeatedKeys12139;
		public virtual void sendRepeatedKeys(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.InstrumentationTestCase._sendRepeatedKeys12139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.InstrumentationTestCase.staticClass, global::android.test.InstrumentationTestCase._sendRepeatedKeys12139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _InstrumentationTestCase12140;
		public InstrumentationTestCase()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.InstrumentationTestCase.staticClass, global::android.test.InstrumentationTestCase._InstrumentationTestCase12140);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.InstrumentationTestCase.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/InstrumentationTestCase"));
			global::android.test.InstrumentationTestCase._launchActivity12129 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestCase.staticClass, "launchActivity", "(Ljava/lang/String;Ljava/lang/Class;Landroid/os/Bundle;)Landroid/app/Activity;");
			global::android.test.InstrumentationTestCase._tearDown12130 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestCase.staticClass, "tearDown", "()V");
			global::android.test.InstrumentationTestCase._injectInstrumentation12131 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestCase.staticClass, "injectInstrumentation", "(Landroid/app/Instrumentation;)V");
			global::android.test.InstrumentationTestCase._injectInsrumentation12132 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestCase.staticClass, "injectInsrumentation", "(Landroid/app/Instrumentation;)V");
			global::android.test.InstrumentationTestCase._getInstrumentation12133 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestCase.staticClass, "getInstrumentation", "()Landroid/app/Instrumentation;");
			global::android.test.InstrumentationTestCase._launchActivityWithIntent12134 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestCase.staticClass, "launchActivityWithIntent", "(Ljava/lang/String;Ljava/lang/Class;Landroid/content/Intent;)Landroid/app/Activity;");
			global::android.test.InstrumentationTestCase._runTestOnUiThread12135 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestCase.staticClass, "runTestOnUiThread", "(Ljava/lang/Runnable;)V");
			global::android.test.InstrumentationTestCase._runTest12136 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestCase.staticClass, "runTest", "()V");
			global::android.test.InstrumentationTestCase._sendKeys12137 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestCase.staticClass, "sendKeys", "(Ljava/lang/String;)V");
			global::android.test.InstrumentationTestCase._sendKeys12138 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestCase.staticClass, "sendKeys", "([I)V");
			global::android.test.InstrumentationTestCase._sendRepeatedKeys12139 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestCase.staticClass, "sendRepeatedKeys", "([I)V");
			global::android.test.InstrumentationTestCase._InstrumentationTestCase12140 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestCase.staticClass, "<init>", "()V");
		}
	}
}
