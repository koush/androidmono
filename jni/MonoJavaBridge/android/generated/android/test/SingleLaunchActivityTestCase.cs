namespace android.test
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.test.SingleLaunchActivityTestCase_))]
	public abstract partial class SingleLaunchActivityTestCase : android.test.InstrumentationTestCase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SingleLaunchActivityTestCase()
		{
			InitJNI();
		}
		protected SingleLaunchActivityTestCase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getActivity7779;
		public virtual global::android.app.Activity getActivity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.SingleLaunchActivityTestCase._getActivity7779)) as android.app.Activity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.SingleLaunchActivityTestCase.staticClass, global::android.test.SingleLaunchActivityTestCase._getActivity7779)) as android.app.Activity;
		}
		internal static global::MonoJavaBridge.MethodId _setUp7780;
		protected override void setUp() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.SingleLaunchActivityTestCase._setUp7780);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.SingleLaunchActivityTestCase.staticClass, global::android.test.SingleLaunchActivityTestCase._setUp7780);
		}
		internal static global::MonoJavaBridge.MethodId _tearDown7781;
		protected override void tearDown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.SingleLaunchActivityTestCase._tearDown7781);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.SingleLaunchActivityTestCase.staticClass, global::android.test.SingleLaunchActivityTestCase._tearDown7781);
		}
		internal static global::MonoJavaBridge.MethodId _testActivityTestCaseSetUpProperly7782;
		public virtual void testActivityTestCaseSetUpProperly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.SingleLaunchActivityTestCase._testActivityTestCaseSetUpProperly7782);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.SingleLaunchActivityTestCase.staticClass, global::android.test.SingleLaunchActivityTestCase._testActivityTestCaseSetUpProperly7782);
		}
		internal static global::MonoJavaBridge.MethodId _SingleLaunchActivityTestCase7783;
		public SingleLaunchActivityTestCase(java.lang.String arg0, java.lang.Class arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.SingleLaunchActivityTestCase.staticClass, global::android.test.SingleLaunchActivityTestCase._SingleLaunchActivityTestCase7783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.SingleLaunchActivityTestCase.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/SingleLaunchActivityTestCase"));
			global::android.test.SingleLaunchActivityTestCase._getActivity7779 = @__env.GetMethodIDNoThrow(global::android.test.SingleLaunchActivityTestCase.staticClass, "getActivity", "()Landroid/app/Activity;");
			global::android.test.SingleLaunchActivityTestCase._setUp7780 = @__env.GetMethodIDNoThrow(global::android.test.SingleLaunchActivityTestCase.staticClass, "setUp", "()V");
			global::android.test.SingleLaunchActivityTestCase._tearDown7781 = @__env.GetMethodIDNoThrow(global::android.test.SingleLaunchActivityTestCase.staticClass, "tearDown", "()V");
			global::android.test.SingleLaunchActivityTestCase._testActivityTestCaseSetUpProperly7782 = @__env.GetMethodIDNoThrow(global::android.test.SingleLaunchActivityTestCase.staticClass, "testActivityTestCaseSetUpProperly", "()V");
			global::android.test.SingleLaunchActivityTestCase._SingleLaunchActivityTestCase7783 = @__env.GetMethodIDNoThrow(global::android.test.SingleLaunchActivityTestCase.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Class;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.test.SingleLaunchActivityTestCase))]
	public sealed partial class SingleLaunchActivityTestCase_ : android.test.SingleLaunchActivityTestCase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SingleLaunchActivityTestCase_()
		{
			InitJNI();
		}
		internal SingleLaunchActivityTestCase_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.SingleLaunchActivityTestCase_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/SingleLaunchActivityTestCase"));
		}
	}
}
