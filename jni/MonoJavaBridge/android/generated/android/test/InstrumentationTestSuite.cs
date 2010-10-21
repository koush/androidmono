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
		internal static global::MonoJavaBridge.MethodId _runTest12158;
		public override void runTest(junit.framework.Test arg0, junit.framework.TestResult arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.InstrumentationTestSuite._runTest12158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.InstrumentationTestSuite.staticClass, global::android.test.InstrumentationTestSuite._runTest12158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addTestSuite12159;
		public override void addTestSuite(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.InstrumentationTestSuite._addTestSuite12159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.InstrumentationTestSuite.staticClass, global::android.test.InstrumentationTestSuite._addTestSuite12159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _InstrumentationTestSuite12160;
		public InstrumentationTestSuite(android.app.Instrumentation arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.InstrumentationTestSuite.staticClass, global::android.test.InstrumentationTestSuite._InstrumentationTestSuite12160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InstrumentationTestSuite12161;
		public InstrumentationTestSuite(java.lang.String arg0, android.app.Instrumentation arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.InstrumentationTestSuite.staticClass, global::android.test.InstrumentationTestSuite._InstrumentationTestSuite12161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InstrumentationTestSuite12162;
		public InstrumentationTestSuite(java.lang.Class arg0, android.app.Instrumentation arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.InstrumentationTestSuite.staticClass, global::android.test.InstrumentationTestSuite._InstrumentationTestSuite12162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.InstrumentationTestSuite.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/InstrumentationTestSuite"));
			global::android.test.InstrumentationTestSuite._runTest12158 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestSuite.staticClass, "runTest", "(Ljunit/framework/Test;Ljunit/framework/TestResult;)V");
			global::android.test.InstrumentationTestSuite._addTestSuite12159 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestSuite.staticClass, "addTestSuite", "(Ljava/lang/Class;)V");
			global::android.test.InstrumentationTestSuite._InstrumentationTestSuite12160 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestSuite.staticClass, "<init>", "(Landroid/app/Instrumentation;)V");
			global::android.test.InstrumentationTestSuite._InstrumentationTestSuite12161 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestSuite.staticClass, "<init>", "(Ljava/lang/String;Landroid/app/Instrumentation;)V");
			global::android.test.InstrumentationTestSuite._InstrumentationTestSuite12162 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestSuite.staticClass, "<init>", "(Ljava/lang/Class;Landroid/app/Instrumentation;)V");
		}
	}
}
