namespace android.test
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.test.ActivityInstrumentationTestCase_))]
	public abstract partial class ActivityInstrumentationTestCase : android.test.ActivityTestCase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ActivityInstrumentationTestCase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getActivity12110;
		public virtual global::android.app.Activity getActivity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.ActivityInstrumentationTestCase._getActivity12110.native == global::System.IntPtr.Zero)
				global::android.test.ActivityInstrumentationTestCase._getActivity12110 = @__env.GetMethodIDNoThrow(global::android.test.ActivityInstrumentationTestCase.staticClass, "getActivity", "()Landroid/app/Activity;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.ActivityInstrumentationTestCase.staticClass, global::android.test.ActivityInstrumentationTestCase._getActivity12110) as android.app.Activity;
		}
		internal static global::MonoJavaBridge.MethodId _setUp12111;
		protected override void setUp()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.ActivityInstrumentationTestCase._setUp12111.native == global::System.IntPtr.Zero)
				global::android.test.ActivityInstrumentationTestCase._setUp12111 = @__env.GetMethodIDNoThrow(global::android.test.ActivityInstrumentationTestCase.staticClass, "setUp", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.ActivityInstrumentationTestCase.staticClass, global::android.test.ActivityInstrumentationTestCase._setUp12111);
		}
		internal static global::MonoJavaBridge.MethodId _tearDown12112;
		protected override void tearDown()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.ActivityInstrumentationTestCase._tearDown12112.native == global::System.IntPtr.Zero)
				global::android.test.ActivityInstrumentationTestCase._tearDown12112 = @__env.GetMethodIDNoThrow(global::android.test.ActivityInstrumentationTestCase.staticClass, "tearDown", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.ActivityInstrumentationTestCase.staticClass, global::android.test.ActivityInstrumentationTestCase._tearDown12112);
		}
		internal static global::MonoJavaBridge.MethodId _testActivityTestCaseSetUpProperly12113;
		public virtual void testActivityTestCaseSetUpProperly()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.ActivityInstrumentationTestCase._testActivityTestCaseSetUpProperly12113.native == global::System.IntPtr.Zero)
				global::android.test.ActivityInstrumentationTestCase._testActivityTestCaseSetUpProperly12113 = @__env.GetMethodIDNoThrow(global::android.test.ActivityInstrumentationTestCase.staticClass, "testActivityTestCaseSetUpProperly", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.ActivityInstrumentationTestCase.staticClass, global::android.test.ActivityInstrumentationTestCase._testActivityTestCaseSetUpProperly12113);
		}
		internal static global::MonoJavaBridge.MethodId _ActivityInstrumentationTestCase12114;
		public ActivityInstrumentationTestCase(java.lang.String arg0, java.lang.Class arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.ActivityInstrumentationTestCase._ActivityInstrumentationTestCase12114.native == global::System.IntPtr.Zero)
				global::android.test.ActivityInstrumentationTestCase._ActivityInstrumentationTestCase12114 = @__env.GetMethodIDNoThrow(global::android.test.ActivityInstrumentationTestCase.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Class;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.ActivityInstrumentationTestCase.staticClass, global::android.test.ActivityInstrumentationTestCase._ActivityInstrumentationTestCase12114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ActivityInstrumentationTestCase12115;
		public ActivityInstrumentationTestCase(java.lang.String arg0, java.lang.Class arg1, bool arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.ActivityInstrumentationTestCase._ActivityInstrumentationTestCase12115.native == global::System.IntPtr.Zero)
				global::android.test.ActivityInstrumentationTestCase._ActivityInstrumentationTestCase12115 = @__env.GetMethodIDNoThrow(global::android.test.ActivityInstrumentationTestCase.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Class;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.ActivityInstrumentationTestCase.staticClass, global::android.test.ActivityInstrumentationTestCase._ActivityInstrumentationTestCase12115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static ActivityInstrumentationTestCase()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.ActivityInstrumentationTestCase.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/ActivityInstrumentationTestCase"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.test.ActivityInstrumentationTestCase))]
	internal sealed partial class ActivityInstrumentationTestCase_ : android.test.ActivityInstrumentationTestCase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ActivityInstrumentationTestCase_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static ActivityInstrumentationTestCase_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.ActivityInstrumentationTestCase_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/ActivityInstrumentationTestCase"));
		}
		internal static void InitJNI()
		{
		}
	}
}
