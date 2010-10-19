namespace android.test
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.test.ApplicationTestCase_))]
	public abstract partial class ApplicationTestCase : android.test.AndroidTestCase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ApplicationTestCase()
		{
			InitJNI();
		}
		protected ApplicationTestCase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getApplication7644;
		public virtual global::android.app.Application getApplication() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.ApplicationTestCase._getApplication7644)) as android.app.Application;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.ApplicationTestCase.staticClass, global::android.test.ApplicationTestCase._getApplication7644)) as android.app.Application;
		}
		internal static global::MonoJavaBridge.MethodId _setUp7645;
		protected override void setUp() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ApplicationTestCase._setUp7645);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ApplicationTestCase.staticClass, global::android.test.ApplicationTestCase._setUp7645);
		}
		internal static global::MonoJavaBridge.MethodId _tearDown7646;
		protected override void tearDown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ApplicationTestCase._tearDown7646);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ApplicationTestCase.staticClass, global::android.test.ApplicationTestCase._tearDown7646);
		}
		internal static global::MonoJavaBridge.MethodId _createApplication7647;
		protected virtual void createApplication() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ApplicationTestCase._createApplication7647);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ApplicationTestCase.staticClass, global::android.test.ApplicationTestCase._createApplication7647);
		}
		internal static global::MonoJavaBridge.MethodId _terminateApplication7648;
		protected virtual void terminateApplication() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ApplicationTestCase._terminateApplication7648);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ApplicationTestCase.staticClass, global::android.test.ApplicationTestCase._terminateApplication7648);
		}
		internal static global::MonoJavaBridge.MethodId _getSystemContext7649;
		public virtual global::android.content.Context getSystemContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.ApplicationTestCase._getSystemContext7649)) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.ApplicationTestCase.staticClass, global::android.test.ApplicationTestCase._getSystemContext7649)) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _testApplicationTestCaseSetUpProperly7650;
		public virtual void testApplicationTestCaseSetUpProperly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ApplicationTestCase._testApplicationTestCaseSetUpProperly7650);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ApplicationTestCase.staticClass, global::android.test.ApplicationTestCase._testApplicationTestCaseSetUpProperly7650);
		}
		internal static global::MonoJavaBridge.MethodId _ApplicationTestCase7651;
		public ApplicationTestCase(java.lang.Class arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.ApplicationTestCase.staticClass, global::android.test.ApplicationTestCase._ApplicationTestCase7651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.ApplicationTestCase.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/ApplicationTestCase"));
			global::android.test.ApplicationTestCase._getApplication7644 = @__env.GetMethodIDNoThrow(global::android.test.ApplicationTestCase.staticClass, "getApplication", "()Landroid/app/Application;");
			global::android.test.ApplicationTestCase._setUp7645 = @__env.GetMethodIDNoThrow(global::android.test.ApplicationTestCase.staticClass, "setUp", "()V");
			global::android.test.ApplicationTestCase._tearDown7646 = @__env.GetMethodIDNoThrow(global::android.test.ApplicationTestCase.staticClass, "tearDown", "()V");
			global::android.test.ApplicationTestCase._createApplication7647 = @__env.GetMethodIDNoThrow(global::android.test.ApplicationTestCase.staticClass, "createApplication", "()V");
			global::android.test.ApplicationTestCase._terminateApplication7648 = @__env.GetMethodIDNoThrow(global::android.test.ApplicationTestCase.staticClass, "terminateApplication", "()V");
			global::android.test.ApplicationTestCase._getSystemContext7649 = @__env.GetMethodIDNoThrow(global::android.test.ApplicationTestCase.staticClass, "getSystemContext", "()Landroid/content/Context;");
			global::android.test.ApplicationTestCase._testApplicationTestCaseSetUpProperly7650 = @__env.GetMethodIDNoThrow(global::android.test.ApplicationTestCase.staticClass, "testApplicationTestCaseSetUpProperly", "()V");
			global::android.test.ApplicationTestCase._ApplicationTestCase7651 = @__env.GetMethodIDNoThrow(global::android.test.ApplicationTestCase.staticClass, "<init>", "(Ljava/lang/Class;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.test.ApplicationTestCase))]
	public sealed partial class ApplicationTestCase_ : android.test.ApplicationTestCase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ApplicationTestCase_()
		{
			InitJNI();
		}
		internal ApplicationTestCase_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.ApplicationTestCase_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/ApplicationTestCase"));
		}
	}
}
