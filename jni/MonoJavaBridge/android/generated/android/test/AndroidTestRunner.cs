namespace android.test
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AndroidTestRunner : junit.runner.BaseTestRunner
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AndroidTestRunner()
		{
			InitJNI();
		}
		protected AndroidTestRunner(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _runTest7625;
		public virtual void runTest() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.AndroidTestRunner._runTest7625);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.AndroidTestRunner.staticClass, global::android.test.AndroidTestRunner._runTest7625);
		}
		internal static global::MonoJavaBridge.MethodId _runTest7626;
		public virtual void runTest(junit.framework.TestResult arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.AndroidTestRunner._runTest7626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.AndroidTestRunner.staticClass, global::android.test.AndroidTestRunner._runTest7626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setContext7627;
		public virtual void setContext(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.AndroidTestRunner._setContext7627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.AndroidTestRunner.staticClass, global::android.test.AndroidTestRunner._setContext7627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTestClassName7628;
		public virtual void setTestClassName(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.AndroidTestRunner._setTestClassName7628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.AndroidTestRunner.staticClass, global::android.test.AndroidTestRunner._setTestClassName7628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTest7629;
		public virtual void setTest(junit.framework.Test arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.AndroidTestRunner._setTest7629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.AndroidTestRunner.staticClass, global::android.test.AndroidTestRunner._setTest7629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearTestListeners7630;
		public virtual void clearTestListeners() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.AndroidTestRunner._clearTestListeners7630);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.AndroidTestRunner.staticClass, global::android.test.AndroidTestRunner._clearTestListeners7630);
		}
		internal static global::MonoJavaBridge.MethodId _addTestListener7631;
		public virtual void addTestListener(junit.framework.TestListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.AndroidTestRunner._addTestListener7631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.AndroidTestRunner.staticClass, global::android.test.AndroidTestRunner._addTestListener7631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createTestResult7632;
		protected virtual global::junit.framework.TestResult createTestResult() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.AndroidTestRunner._createTestResult7632)) as junit.framework.TestResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.AndroidTestRunner.staticClass, global::android.test.AndroidTestRunner._createTestResult7632)) as junit.framework.TestResult;
		}
		public new global::java.util.List TestCases
		{
			get
			{
				return getTestCases();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTestCases7633;
		public virtual global::java.util.List getTestCases() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.AndroidTestRunner._getTestCases7633)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.AndroidTestRunner.staticClass, global::android.test.AndroidTestRunner._getTestCases7633)) as java.util.List;
		}
		public new global::java.lang.String TestClassName
		{
			get
			{
				return getTestClassName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTestClassName7634;
		public virtual global::java.lang.String getTestClassName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.AndroidTestRunner._getTestClassName7634)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.AndroidTestRunner.staticClass, global::android.test.AndroidTestRunner._getTestClassName7634)) as java.lang.String;
		}
		public new global::junit.framework.TestResult TestResult
		{
			get
			{
				return getTestResult();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTestResult7635;
		public virtual global::junit.framework.TestResult getTestResult() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.AndroidTestRunner._getTestResult7635)) as junit.framework.TestResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.AndroidTestRunner.staticClass, global::android.test.AndroidTestRunner._getTestResult7635)) as junit.framework.TestResult;
		}
		internal static global::MonoJavaBridge.MethodId _setInstrumentation7636;
		public virtual void setInstrumentation(android.app.Instrumentation arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.AndroidTestRunner._setInstrumentation7636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.AndroidTestRunner.staticClass, global::android.test.AndroidTestRunner._setInstrumentation7636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInstrumentaiton7637;
		public virtual void setInstrumentaiton(android.app.Instrumentation arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.AndroidTestRunner._setInstrumentaiton7637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.AndroidTestRunner.staticClass, global::android.test.AndroidTestRunner._setInstrumentaiton7637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _loadSuiteClass7638;
		protected override global::java.lang.Class loadSuiteClass(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.AndroidTestRunner._loadSuiteClass7638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.AndroidTestRunner.staticClass, global::android.test.AndroidTestRunner._loadSuiteClass7638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _testStarted7639;
		public override void testStarted(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.AndroidTestRunner._testStarted7639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.AndroidTestRunner.staticClass, global::android.test.AndroidTestRunner._testStarted7639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _testEnded7640;
		public override void testEnded(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.AndroidTestRunner._testEnded7640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.AndroidTestRunner.staticClass, global::android.test.AndroidTestRunner._testEnded7640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _testFailed7641;
		public override void testFailed(int arg0, junit.framework.Test arg1, java.lang.Throwable arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.AndroidTestRunner._testFailed7641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.AndroidTestRunner.staticClass, global::android.test.AndroidTestRunner._testFailed7641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _runFailed7642;
		protected override void runFailed(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.AndroidTestRunner._runFailed7642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.AndroidTestRunner.staticClass, global::android.test.AndroidTestRunner._runFailed7642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AndroidTestRunner7643;
		public AndroidTestRunner()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.AndroidTestRunner.staticClass, global::android.test.AndroidTestRunner._AndroidTestRunner7643);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.AndroidTestRunner.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/AndroidTestRunner"));
			global::android.test.AndroidTestRunner._runTest7625 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestRunner.staticClass, "runTest", "()V");
			global::android.test.AndroidTestRunner._runTest7626 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestRunner.staticClass, "runTest", "(Ljunit/framework/TestResult;)V");
			global::android.test.AndroidTestRunner._setContext7627 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestRunner.staticClass, "setContext", "(Landroid/content/Context;)V");
			global::android.test.AndroidTestRunner._setTestClassName7628 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestRunner.staticClass, "setTestClassName", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.test.AndroidTestRunner._setTest7629 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestRunner.staticClass, "setTest", "(Ljunit/framework/Test;)V");
			global::android.test.AndroidTestRunner._clearTestListeners7630 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestRunner.staticClass, "clearTestListeners", "()V");
			global::android.test.AndroidTestRunner._addTestListener7631 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestRunner.staticClass, "addTestListener", "(Ljunit/framework/TestListener;)V");
			global::android.test.AndroidTestRunner._createTestResult7632 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestRunner.staticClass, "createTestResult", "()Ljunit/framework/TestResult;");
			global::android.test.AndroidTestRunner._getTestCases7633 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestRunner.staticClass, "getTestCases", "()Ljava/util/List;");
			global::android.test.AndroidTestRunner._getTestClassName7634 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestRunner.staticClass, "getTestClassName", "()Ljava/lang/String;");
			global::android.test.AndroidTestRunner._getTestResult7635 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestRunner.staticClass, "getTestResult", "()Ljunit/framework/TestResult;");
			global::android.test.AndroidTestRunner._setInstrumentation7636 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestRunner.staticClass, "setInstrumentation", "(Landroid/app/Instrumentation;)V");
			global::android.test.AndroidTestRunner._setInstrumentaiton7637 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestRunner.staticClass, "setInstrumentaiton", "(Landroid/app/Instrumentation;)V");
			global::android.test.AndroidTestRunner._loadSuiteClass7638 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestRunner.staticClass, "loadSuiteClass", "(Ljava/lang/String;)Ljava/lang/Class;");
			global::android.test.AndroidTestRunner._testStarted7639 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestRunner.staticClass, "testStarted", "(Ljava/lang/String;)V");
			global::android.test.AndroidTestRunner._testEnded7640 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestRunner.staticClass, "testEnded", "(Ljava/lang/String;)V");
			global::android.test.AndroidTestRunner._testFailed7641 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestRunner.staticClass, "testFailed", "(ILjunit/framework/Test;Ljava/lang/Throwable;)V");
			global::android.test.AndroidTestRunner._runFailed7642 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestRunner.staticClass, "runFailed", "(Ljava/lang/String;)V");
			global::android.test.AndroidTestRunner._AndroidTestRunner7643 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestRunner.staticClass, "<init>", "()V");
		}
	}
}
