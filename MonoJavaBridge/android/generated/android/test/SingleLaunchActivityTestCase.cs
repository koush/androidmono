namespace android.test
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.test.SingleLaunchActivityTestCase_))]
	public abstract partial class SingleLaunchActivityTestCase : android.test.InstrumentationTestCase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SingleLaunchActivityTestCase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getActivity12314;
		public virtual global::android.app.Activity getActivity()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.SingleLaunchActivityTestCase.staticClass, global::android.test.SingleLaunchActivityTestCase._getActivity12314)) as android.app.Activity;
		}
		internal static global::MonoJavaBridge.MethodId _setUp12315;
		protected override void setUp()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.SingleLaunchActivityTestCase.staticClass, global::android.test.SingleLaunchActivityTestCase._setUp12315);
		}
		internal static global::MonoJavaBridge.MethodId _tearDown12316;
		protected override void tearDown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.SingleLaunchActivityTestCase.staticClass, global::android.test.SingleLaunchActivityTestCase._tearDown12316);
		}
		internal static global::MonoJavaBridge.MethodId _testActivityTestCaseSetUpProperly12317;
		public virtual void testActivityTestCaseSetUpProperly()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.SingleLaunchActivityTestCase.staticClass, global::android.test.SingleLaunchActivityTestCase._testActivityTestCaseSetUpProperly12317);
		}
		internal static global::MonoJavaBridge.MethodId _SingleLaunchActivityTestCase12318;
		public SingleLaunchActivityTestCase(java.lang.String arg0, java.lang.Class arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.SingleLaunchActivityTestCase.staticClass, global::android.test.SingleLaunchActivityTestCase._SingleLaunchActivityTestCase12318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static SingleLaunchActivityTestCase()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.SingleLaunchActivityTestCase.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/SingleLaunchActivityTestCase"));
			global::android.test.SingleLaunchActivityTestCase._getActivity12314 = @__env.GetMethodIDNoThrow(global::android.test.SingleLaunchActivityTestCase.staticClass, "getActivity", "()Landroid/app/Activity;");
			global::android.test.SingleLaunchActivityTestCase._setUp12315 = @__env.GetMethodIDNoThrow(global::android.test.SingleLaunchActivityTestCase.staticClass, "setUp", "()V");
			global::android.test.SingleLaunchActivityTestCase._tearDown12316 = @__env.GetMethodIDNoThrow(global::android.test.SingleLaunchActivityTestCase.staticClass, "tearDown", "()V");
			global::android.test.SingleLaunchActivityTestCase._testActivityTestCaseSetUpProperly12317 = @__env.GetMethodIDNoThrow(global::android.test.SingleLaunchActivityTestCase.staticClass, "testActivityTestCaseSetUpProperly", "()V");
			global::android.test.SingleLaunchActivityTestCase._SingleLaunchActivityTestCase12318 = @__env.GetMethodIDNoThrow(global::android.test.SingleLaunchActivityTestCase.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Class;)V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.test.SingleLaunchActivityTestCase))]
	internal sealed partial class SingleLaunchActivityTestCase_ : android.test.SingleLaunchActivityTestCase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SingleLaunchActivityTestCase_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static SingleLaunchActivityTestCase_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.SingleLaunchActivityTestCase_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/SingleLaunchActivityTestCase"));
		}
		internal static void InitJNI()
		{
		}
	}
}
