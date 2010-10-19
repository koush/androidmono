namespace android.test
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InstrumentationTestSuite : junit.framework.TestSuite
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InstrumentationTestSuite()
		{
			InitJNI();
		}
		protected InstrumentationTestSuite(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _runTest7680;
		public override void runTest(junit.framework.Test arg0, junit.framework.TestResult arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.InstrumentationTestSuite._runTest7680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.InstrumentationTestSuite.staticClass, global::android.test.InstrumentationTestSuite._runTest7680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addTestSuite7681;
		public override void addTestSuite(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.InstrumentationTestSuite._addTestSuite7681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.InstrumentationTestSuite.staticClass, global::android.test.InstrumentationTestSuite._addTestSuite7681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _InstrumentationTestSuite7682;
		public InstrumentationTestSuite(android.app.Instrumentation arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.InstrumentationTestSuite.staticClass, global::android.test.InstrumentationTestSuite._InstrumentationTestSuite7682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InstrumentationTestSuite7683;
		public InstrumentationTestSuite(java.lang.String arg0, android.app.Instrumentation arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.InstrumentationTestSuite.staticClass, global::android.test.InstrumentationTestSuite._InstrumentationTestSuite7683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InstrumentationTestSuite7684;
		public InstrumentationTestSuite(java.lang.Class arg0, android.app.Instrumentation arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.InstrumentationTestSuite.staticClass, global::android.test.InstrumentationTestSuite._InstrumentationTestSuite7684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.InstrumentationTestSuite.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/InstrumentationTestSuite"));
			global::android.test.InstrumentationTestSuite._runTest7680 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestSuite.staticClass, "runTest", "(Ljunit/framework/Test;Ljunit/framework/TestResult;)V");
			global::android.test.InstrumentationTestSuite._addTestSuite7681 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestSuite.staticClass, "addTestSuite", "(Ljava/lang/Class;)V");
			global::android.test.InstrumentationTestSuite._InstrumentationTestSuite7682 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestSuite.staticClass, "<init>", "(Landroid/app/Instrumentation;)V");
			global::android.test.InstrumentationTestSuite._InstrumentationTestSuite7683 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestSuite.staticClass, "<init>", "(Ljava/lang/String;Landroid/app/Instrumentation;)V");
			global::android.test.InstrumentationTestSuite._InstrumentationTestSuite7684 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestSuite.staticClass, "<init>", "(Ljava/lang/Class;Landroid/app/Instrumentation;)V");
		}
	}
}
