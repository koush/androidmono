namespace android.test
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.test.ServiceTestCase_))]
	public abstract partial class ServiceTestCase : android.test.AndroidTestCase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ServiceTestCase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getService12302;
		public virtual global::android.app.Service getService()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.ServiceTestCase._getService12302)) as android.app.Service;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.ServiceTestCase.staticClass, global::android.test.ServiceTestCase._getService12302)) as android.app.Service;
		}
		internal static global::MonoJavaBridge.MethodId _getApplication12303;
		public virtual global::android.app.Application getApplication()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.ServiceTestCase._getApplication12303)) as android.app.Application;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.ServiceTestCase.staticClass, global::android.test.ServiceTestCase._getApplication12303)) as android.app.Application;
		}
		internal static global::MonoJavaBridge.MethodId _startService12304;
		protected virtual void startService(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase._startService12304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase.staticClass, global::android.test.ServiceTestCase._startService12304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bindService12305;
		protected virtual global::android.os.IBinder bindService(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.ServiceTestCase._bindService12305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.IBinder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.ServiceTestCase.staticClass, global::android.test.ServiceTestCase._bindService12305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.IBinder;
		}
		internal static global::MonoJavaBridge.MethodId _setUp12306;
		protected override void setUp()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase._setUp12306);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase.staticClass, global::android.test.ServiceTestCase._setUp12306);
		}
		internal static global::MonoJavaBridge.MethodId _tearDown12307;
		protected override void tearDown()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase._tearDown12307);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase.staticClass, global::android.test.ServiceTestCase._tearDown12307);
		}
		internal static global::MonoJavaBridge.MethodId _setApplication12308;
		public virtual void setApplication(android.app.Application arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase._setApplication12308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase.staticClass, global::android.test.ServiceTestCase._setApplication12308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSystemContext12309;
		public virtual global::android.content.Context getSystemContext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.ServiceTestCase._getSystemContext12309)) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.ServiceTestCase.staticClass, global::android.test.ServiceTestCase._getSystemContext12309)) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _setupService12310;
		protected virtual void setupService()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase._setupService12310);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase.staticClass, global::android.test.ServiceTestCase._setupService12310);
		}
		internal static global::MonoJavaBridge.MethodId _shutdownService12311;
		protected virtual void shutdownService()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase._shutdownService12311);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase.staticClass, global::android.test.ServiceTestCase._shutdownService12311);
		}
		internal static global::MonoJavaBridge.MethodId _testServiceTestCaseSetUpProperly12312;
		public virtual void testServiceTestCaseSetUpProperly()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase._testServiceTestCaseSetUpProperly12312);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase.staticClass, global::android.test.ServiceTestCase._testServiceTestCaseSetUpProperly12312);
		}
		internal static global::MonoJavaBridge.MethodId _ServiceTestCase12313;
		public ServiceTestCase(java.lang.Class arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.ServiceTestCase.staticClass, global::android.test.ServiceTestCase._ServiceTestCase12313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ServiceTestCase()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.ServiceTestCase.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/ServiceTestCase"));
			global::android.test.ServiceTestCase._getService12302 = @__env.GetMethodIDNoThrow(global::android.test.ServiceTestCase.staticClass, "getService", "()Landroid/app/Service;");
			global::android.test.ServiceTestCase._getApplication12303 = @__env.GetMethodIDNoThrow(global::android.test.ServiceTestCase.staticClass, "getApplication", "()Landroid/app/Application;");
			global::android.test.ServiceTestCase._startService12304 = @__env.GetMethodIDNoThrow(global::android.test.ServiceTestCase.staticClass, "startService", "(Landroid/content/Intent;)V");
			global::android.test.ServiceTestCase._bindService12305 = @__env.GetMethodIDNoThrow(global::android.test.ServiceTestCase.staticClass, "bindService", "(Landroid/content/Intent;)Landroid/os/IBinder;");
			global::android.test.ServiceTestCase._setUp12306 = @__env.GetMethodIDNoThrow(global::android.test.ServiceTestCase.staticClass, "setUp", "()V");
			global::android.test.ServiceTestCase._tearDown12307 = @__env.GetMethodIDNoThrow(global::android.test.ServiceTestCase.staticClass, "tearDown", "()V");
			global::android.test.ServiceTestCase._setApplication12308 = @__env.GetMethodIDNoThrow(global::android.test.ServiceTestCase.staticClass, "setApplication", "(Landroid/app/Application;)V");
			global::android.test.ServiceTestCase._getSystemContext12309 = @__env.GetMethodIDNoThrow(global::android.test.ServiceTestCase.staticClass, "getSystemContext", "()Landroid/content/Context;");
			global::android.test.ServiceTestCase._setupService12310 = @__env.GetMethodIDNoThrow(global::android.test.ServiceTestCase.staticClass, "setupService", "()V");
			global::android.test.ServiceTestCase._shutdownService12311 = @__env.GetMethodIDNoThrow(global::android.test.ServiceTestCase.staticClass, "shutdownService", "()V");
			global::android.test.ServiceTestCase._testServiceTestCaseSetUpProperly12312 = @__env.GetMethodIDNoThrow(global::android.test.ServiceTestCase.staticClass, "testServiceTestCaseSetUpProperly", "()V");
			global::android.test.ServiceTestCase._ServiceTestCase12313 = @__env.GetMethodIDNoThrow(global::android.test.ServiceTestCase.staticClass, "<init>", "(Ljava/lang/Class;)V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.test.ServiceTestCase))]
	internal sealed partial class ServiceTestCase_ : android.test.ServiceTestCase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ServiceTestCase_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static ServiceTestCase_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.ServiceTestCase_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/ServiceTestCase"));
		}
		internal static void InitJNI()
		{
		}
	}
}
