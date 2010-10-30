namespace android.test
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InstrumentationTestSuite : junit.framework.TestSuite
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InstrumentationTestSuite(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _runTest12215;
		public override void runTest(junit.framework.Test arg0, junit.framework.TestResult arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.InstrumentationTestSuite.staticClass, "runTest", "(Ljunit/framework/Test;Ljunit/framework/TestResult;)V", ref global::android.test.InstrumentationTestSuite._runTest12215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addTestSuite12216;
		public override void addTestSuite(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.InstrumentationTestSuite.staticClass, "addTestSuite", "(Ljava/lang/Class;)V", ref global::android.test.InstrumentationTestSuite._addTestSuite12216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _InstrumentationTestSuite12217;
		public InstrumentationTestSuite(android.app.Instrumentation arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.InstrumentationTestSuite._InstrumentationTestSuite12217.native == global::System.IntPtr.Zero)
				global::android.test.InstrumentationTestSuite._InstrumentationTestSuite12217 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestSuite.staticClass, "<init>", "(Landroid/app/Instrumentation;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.InstrumentationTestSuite.staticClass, global::android.test.InstrumentationTestSuite._InstrumentationTestSuite12217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InstrumentationTestSuite12218;
		public InstrumentationTestSuite(java.lang.String arg0, android.app.Instrumentation arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.InstrumentationTestSuite._InstrumentationTestSuite12218.native == global::System.IntPtr.Zero)
				global::android.test.InstrumentationTestSuite._InstrumentationTestSuite12218 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestSuite.staticClass, "<init>", "(Ljava/lang/String;Landroid/app/Instrumentation;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.InstrumentationTestSuite.staticClass, global::android.test.InstrumentationTestSuite._InstrumentationTestSuite12218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InstrumentationTestSuite12219;
		public InstrumentationTestSuite(java.lang.Class arg0, android.app.Instrumentation arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.InstrumentationTestSuite._InstrumentationTestSuite12219.native == global::System.IntPtr.Zero)
				global::android.test.InstrumentationTestSuite._InstrumentationTestSuite12219 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestSuite.staticClass, "<init>", "(Ljava/lang/Class;Landroid/app/Instrumentation;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.InstrumentationTestSuite.staticClass, global::android.test.InstrumentationTestSuite._InstrumentationTestSuite12219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static InstrumentationTestSuite()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.InstrumentationTestSuite.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/InstrumentationTestSuite"));
		}
		internal static void InitJNI()
		{
		}
	}
}
