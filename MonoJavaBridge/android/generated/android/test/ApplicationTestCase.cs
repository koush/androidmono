namespace android.test
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.test.ApplicationTestCase_))]
	public abstract partial class ApplicationTestCase : android.test.AndroidTestCase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ApplicationTestCase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getApplication12169;
		public virtual global::android.app.Application getApplication()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.ApplicationTestCase.staticClass, "getApplication", "()Landroid/app/Application;", ref global::android.test.ApplicationTestCase._getApplication12169) as android.app.Application;
		}
		internal static global::MonoJavaBridge.MethodId _setUp12170;
		protected override void setUp()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.ApplicationTestCase.staticClass, "setUp", "()V", ref global::android.test.ApplicationTestCase._setUp12170);
		}
		internal static global::MonoJavaBridge.MethodId _tearDown12171;
		protected override void tearDown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.ApplicationTestCase.staticClass, "tearDown", "()V", ref global::android.test.ApplicationTestCase._tearDown12171);
		}
		internal static global::MonoJavaBridge.MethodId _createApplication12172;
		protected virtual void createApplication()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.ApplicationTestCase.staticClass, "createApplication", "()V", ref global::android.test.ApplicationTestCase._createApplication12172);
		}
		internal static global::MonoJavaBridge.MethodId _terminateApplication12173;
		protected virtual void terminateApplication()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.ApplicationTestCase.staticClass, "terminateApplication", "()V", ref global::android.test.ApplicationTestCase._terminateApplication12173);
		}
		internal static global::MonoJavaBridge.MethodId _getSystemContext12174;
		public virtual global::android.content.Context getSystemContext()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.ApplicationTestCase.staticClass, "getSystemContext", "()Landroid/content/Context;", ref global::android.test.ApplicationTestCase._getSystemContext12174) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _testApplicationTestCaseSetUpProperly12175;
		public virtual void testApplicationTestCaseSetUpProperly()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.ApplicationTestCase.staticClass, "testApplicationTestCaseSetUpProperly", "()V", ref global::android.test.ApplicationTestCase._testApplicationTestCaseSetUpProperly12175);
		}
		internal static global::MonoJavaBridge.MethodId _ApplicationTestCase12176;
		public ApplicationTestCase(java.lang.Class arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.ApplicationTestCase._ApplicationTestCase12176.native == global::System.IntPtr.Zero)
				global::android.test.ApplicationTestCase._ApplicationTestCase12176 = @__env.GetMethodIDNoThrow(global::android.test.ApplicationTestCase.staticClass, "<init>", "(Ljava/lang/Class;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.ApplicationTestCase.staticClass, global::android.test.ApplicationTestCase._ApplicationTestCase12176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ApplicationTestCase()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.ApplicationTestCase.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/ApplicationTestCase"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.test.ApplicationTestCase))]
	internal sealed partial class ApplicationTestCase_ : android.test.ApplicationTestCase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ApplicationTestCase_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static ApplicationTestCase_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.ApplicationTestCase_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/ApplicationTestCase"));
		}
		internal static void InitJNI()
		{
		}
	}
}
