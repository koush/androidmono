namespace android.test
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.test.ServiceTestCase_))]
	public abstract partial class ServiceTestCase : android.test.AndroidTestCase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ServiceTestCase()
		{
			InitJNI();
		}
		protected ServiceTestCase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getService7767;
		public virtual global::android.app.Service getService() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.ServiceTestCase._getService7767)) as android.app.Service;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.ServiceTestCase.staticClass, global::android.test.ServiceTestCase._getService7767)) as android.app.Service;
		}
		internal static global::MonoJavaBridge.MethodId _getApplication7768;
		public virtual global::android.app.Application getApplication() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.ServiceTestCase._getApplication7768)) as android.app.Application;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.ServiceTestCase.staticClass, global::android.test.ServiceTestCase._getApplication7768)) as android.app.Application;
		}
		internal static global::MonoJavaBridge.MethodId _startService7769;
		protected virtual void startService(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase._startService7769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase.staticClass, global::android.test.ServiceTestCase._startService7769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bindService7770;
		protected virtual global::android.os.IBinder bindService(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.ServiceTestCase._bindService7770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.IBinder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.ServiceTestCase.staticClass, global::android.test.ServiceTestCase._bindService7770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.IBinder;
		}
		internal static global::MonoJavaBridge.MethodId _setUp7771;
		protected override void setUp() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase._setUp7771);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase.staticClass, global::android.test.ServiceTestCase._setUp7771);
		}
		internal static global::MonoJavaBridge.MethodId _tearDown7772;
		protected override void tearDown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase._tearDown7772);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase.staticClass, global::android.test.ServiceTestCase._tearDown7772);
		}
		internal static global::MonoJavaBridge.MethodId _setApplication7773;
		public virtual void setApplication(android.app.Application arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase._setApplication7773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase.staticClass, global::android.test.ServiceTestCase._setApplication7773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSystemContext7774;
		public virtual global::android.content.Context getSystemContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.ServiceTestCase._getSystemContext7774)) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.ServiceTestCase.staticClass, global::android.test.ServiceTestCase._getSystemContext7774)) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _setupService7775;
		protected virtual void setupService() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase._setupService7775);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase.staticClass, global::android.test.ServiceTestCase._setupService7775);
		}
		internal static global::MonoJavaBridge.MethodId _shutdownService7776;
		protected virtual void shutdownService() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase._shutdownService7776);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase.staticClass, global::android.test.ServiceTestCase._shutdownService7776);
		}
		internal static global::MonoJavaBridge.MethodId _testServiceTestCaseSetUpProperly7777;
		public virtual void testServiceTestCaseSetUpProperly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase._testServiceTestCaseSetUpProperly7777);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase.staticClass, global::android.test.ServiceTestCase._testServiceTestCaseSetUpProperly7777);
		}
		internal static global::MonoJavaBridge.MethodId _ServiceTestCase7778;
		public ServiceTestCase(java.lang.Class arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.ServiceTestCase.staticClass, global::android.test.ServiceTestCase._ServiceTestCase7778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.ServiceTestCase.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/ServiceTestCase"));
			global::android.test.ServiceTestCase._getService7767 = @__env.GetMethodIDNoThrow(global::android.test.ServiceTestCase.staticClass, "getService", "()Landroid/app/Service;");
			global::android.test.ServiceTestCase._getApplication7768 = @__env.GetMethodIDNoThrow(global::android.test.ServiceTestCase.staticClass, "getApplication", "()Landroid/app/Application;");
			global::android.test.ServiceTestCase._startService7769 = @__env.GetMethodIDNoThrow(global::android.test.ServiceTestCase.staticClass, "startService", "(Landroid/content/Intent;)V");
			global::android.test.ServiceTestCase._bindService7770 = @__env.GetMethodIDNoThrow(global::android.test.ServiceTestCase.staticClass, "bindService", "(Landroid/content/Intent;)Landroid/os/IBinder;");
			global::android.test.ServiceTestCase._setUp7771 = @__env.GetMethodIDNoThrow(global::android.test.ServiceTestCase.staticClass, "setUp", "()V");
			global::android.test.ServiceTestCase._tearDown7772 = @__env.GetMethodIDNoThrow(global::android.test.ServiceTestCase.staticClass, "tearDown", "()V");
			global::android.test.ServiceTestCase._setApplication7773 = @__env.GetMethodIDNoThrow(global::android.test.ServiceTestCase.staticClass, "setApplication", "(Landroid/app/Application;)V");
			global::android.test.ServiceTestCase._getSystemContext7774 = @__env.GetMethodIDNoThrow(global::android.test.ServiceTestCase.staticClass, "getSystemContext", "()Landroid/content/Context;");
			global::android.test.ServiceTestCase._setupService7775 = @__env.GetMethodIDNoThrow(global::android.test.ServiceTestCase.staticClass, "setupService", "()V");
			global::android.test.ServiceTestCase._shutdownService7776 = @__env.GetMethodIDNoThrow(global::android.test.ServiceTestCase.staticClass, "shutdownService", "()V");
			global::android.test.ServiceTestCase._testServiceTestCaseSetUpProperly7777 = @__env.GetMethodIDNoThrow(global::android.test.ServiceTestCase.staticClass, "testServiceTestCaseSetUpProperly", "()V");
			global::android.test.ServiceTestCase._ServiceTestCase7778 = @__env.GetMethodIDNoThrow(global::android.test.ServiceTestCase.staticClass, "<init>", "(Ljava/lang/Class;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.test.ServiceTestCase))]
	public sealed partial class ServiceTestCase_ : android.test.ServiceTestCase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ServiceTestCase_()
		{
			InitJNI();
		}
		internal ServiceTestCase_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.ServiceTestCase_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/ServiceTestCase"));
		}
	}
}
