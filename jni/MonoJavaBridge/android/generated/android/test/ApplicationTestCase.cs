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
		internal static global::MonoJavaBridge.MethodId _getApplication12169;
		public virtual global::android.app.Application getApplication()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.ApplicationTestCase._getApplication12169)) as android.app.Application;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.ApplicationTestCase.staticClass, global::android.test.ApplicationTestCase._getApplication12169)) as android.app.Application;
		}
		internal static global::MonoJavaBridge.MethodId _setUp12170;
		protected override void setUp()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ApplicationTestCase._setUp12170);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ApplicationTestCase.staticClass, global::android.test.ApplicationTestCase._setUp12170);
		}
		internal static global::MonoJavaBridge.MethodId _tearDown12171;
		protected override void tearDown()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ApplicationTestCase._tearDown12171);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ApplicationTestCase.staticClass, global::android.test.ApplicationTestCase._tearDown12171);
		}
		internal static global::MonoJavaBridge.MethodId _createApplication12172;
		protected virtual void createApplication()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ApplicationTestCase._createApplication12172);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ApplicationTestCase.staticClass, global::android.test.ApplicationTestCase._createApplication12172);
		}
		internal static global::MonoJavaBridge.MethodId _terminateApplication12173;
		protected virtual void terminateApplication()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ApplicationTestCase._terminateApplication12173);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ApplicationTestCase.staticClass, global::android.test.ApplicationTestCase._terminateApplication12173);
		}
		internal static global::MonoJavaBridge.MethodId _getSystemContext12174;
		public virtual global::android.content.Context getSystemContext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.ApplicationTestCase._getSystemContext12174)) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.ApplicationTestCase.staticClass, global::android.test.ApplicationTestCase._getSystemContext12174)) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _testApplicationTestCaseSetUpProperly12175;
		public virtual void testApplicationTestCaseSetUpProperly()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ApplicationTestCase._testApplicationTestCaseSetUpProperly12175);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ApplicationTestCase.staticClass, global::android.test.ApplicationTestCase._testApplicationTestCaseSetUpProperly12175);
		}
		internal static global::MonoJavaBridge.MethodId _ApplicationTestCase12176;
		public ApplicationTestCase(java.lang.Class arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.ApplicationTestCase.staticClass, global::android.test.ApplicationTestCase._ApplicationTestCase12176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.ApplicationTestCase.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/ApplicationTestCase"));
			global::android.test.ApplicationTestCase._getApplication12169 = @__env.GetMethodIDNoThrow(global::android.test.ApplicationTestCase.staticClass, "getApplication", "()Landroid/app/Application;");
			global::android.test.ApplicationTestCase._setUp12170 = @__env.GetMethodIDNoThrow(global::android.test.ApplicationTestCase.staticClass, "setUp", "()V");
			global::android.test.ApplicationTestCase._tearDown12171 = @__env.GetMethodIDNoThrow(global::android.test.ApplicationTestCase.staticClass, "tearDown", "()V");
			global::android.test.ApplicationTestCase._createApplication12172 = @__env.GetMethodIDNoThrow(global::android.test.ApplicationTestCase.staticClass, "createApplication", "()V");
			global::android.test.ApplicationTestCase._terminateApplication12173 = @__env.GetMethodIDNoThrow(global::android.test.ApplicationTestCase.staticClass, "terminateApplication", "()V");
			global::android.test.ApplicationTestCase._getSystemContext12174 = @__env.GetMethodIDNoThrow(global::android.test.ApplicationTestCase.staticClass, "getSystemContext", "()Landroid/content/Context;");
			global::android.test.ApplicationTestCase._testApplicationTestCaseSetUpProperly12175 = @__env.GetMethodIDNoThrow(global::android.test.ApplicationTestCase.staticClass, "testApplicationTestCaseSetUpProperly", "()V");
			global::android.test.ApplicationTestCase._ApplicationTestCase12176 = @__env.GetMethodIDNoThrow(global::android.test.ApplicationTestCase.staticClass, "<init>", "(Ljava/lang/Class;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.test.ApplicationTestCase))]
	internal sealed partial class ApplicationTestCase_ : android.test.ApplicationTestCase
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
