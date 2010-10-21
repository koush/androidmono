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
		internal static global::MonoJavaBridge.MethodId _getService12245;
		public virtual global::android.app.Service getService() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.ServiceTestCase._getService12245)) as android.app.Service;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.ServiceTestCase.staticClass, global::android.test.ServiceTestCase._getService12245)) as android.app.Service;
		}
		internal static global::MonoJavaBridge.MethodId _getApplication12246;
		public virtual global::android.app.Application getApplication() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.ServiceTestCase._getApplication12246)) as android.app.Application;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.ServiceTestCase.staticClass, global::android.test.ServiceTestCase._getApplication12246)) as android.app.Application;
		}
		internal static global::MonoJavaBridge.MethodId _startService12247;
		protected virtual void startService(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase._startService12247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase.staticClass, global::android.test.ServiceTestCase._startService12247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bindService12248;
		protected virtual global::android.os.IBinder bindService(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.ServiceTestCase._bindService12248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.IBinder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.ServiceTestCase.staticClass, global::android.test.ServiceTestCase._bindService12248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.IBinder;
		}
		internal static global::MonoJavaBridge.MethodId _setUp12249;
		protected override void setUp() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase._setUp12249);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase.staticClass, global::android.test.ServiceTestCase._setUp12249);
		}
		internal static global::MonoJavaBridge.MethodId _tearDown12250;
		protected override void tearDown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase._tearDown12250);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase.staticClass, global::android.test.ServiceTestCase._tearDown12250);
		}
		internal static global::MonoJavaBridge.MethodId _setApplication12251;
		public virtual void setApplication(android.app.Application arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase._setApplication12251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase.staticClass, global::android.test.ServiceTestCase._setApplication12251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSystemContext12252;
		public virtual global::android.content.Context getSystemContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.ServiceTestCase._getSystemContext12252)) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.ServiceTestCase.staticClass, global::android.test.ServiceTestCase._getSystemContext12252)) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _setupService12253;
		protected virtual void setupService() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase._setupService12253);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase.staticClass, global::android.test.ServiceTestCase._setupService12253);
		}
		internal static global::MonoJavaBridge.MethodId _shutdownService12254;
		protected virtual void shutdownService() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase._shutdownService12254);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase.staticClass, global::android.test.ServiceTestCase._shutdownService12254);
		}
		internal static global::MonoJavaBridge.MethodId _testServiceTestCaseSetUpProperly12255;
		public virtual void testServiceTestCaseSetUpProperly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase._testServiceTestCaseSetUpProperly12255);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ServiceTestCase.staticClass, global::android.test.ServiceTestCase._testServiceTestCaseSetUpProperly12255);
		}
		internal static global::MonoJavaBridge.MethodId _ServiceTestCase12256;
		public ServiceTestCase(java.lang.Class arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.ServiceTestCase.staticClass, global::android.test.ServiceTestCase._ServiceTestCase12256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.ServiceTestCase.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/ServiceTestCase"));
			global::android.test.ServiceTestCase._getService12245 = @__env.GetMethodIDNoThrow(global::android.test.ServiceTestCase.staticClass, "getService", "()Landroid/app/Service;");
			global::android.test.ServiceTestCase._getApplication12246 = @__env.GetMethodIDNoThrow(global::android.test.ServiceTestCase.staticClass, "getApplication", "()Landroid/app/Application;");
			global::android.test.ServiceTestCase._startService12247 = @__env.GetMethodIDNoThrow(global::android.test.ServiceTestCase.staticClass, "startService", "(Landroid/content/Intent;)V");
			global::android.test.ServiceTestCase._bindService12248 = @__env.GetMethodIDNoThrow(global::android.test.ServiceTestCase.staticClass, "bindService", "(Landroid/content/Intent;)Landroid/os/IBinder;");
			global::android.test.ServiceTestCase._setUp12249 = @__env.GetMethodIDNoThrow(global::android.test.ServiceTestCase.staticClass, "setUp", "()V");
			global::android.test.ServiceTestCase._tearDown12250 = @__env.GetMethodIDNoThrow(global::android.test.ServiceTestCase.staticClass, "tearDown", "()V");
			global::android.test.ServiceTestCase._setApplication12251 = @__env.GetMethodIDNoThrow(global::android.test.ServiceTestCase.staticClass, "setApplication", "(Landroid/app/Application;)V");
			global::android.test.ServiceTestCase._getSystemContext12252 = @__env.GetMethodIDNoThrow(global::android.test.ServiceTestCase.staticClass, "getSystemContext", "()Landroid/content/Context;");
			global::android.test.ServiceTestCase._setupService12253 = @__env.GetMethodIDNoThrow(global::android.test.ServiceTestCase.staticClass, "setupService", "()V");
			global::android.test.ServiceTestCase._shutdownService12254 = @__env.GetMethodIDNoThrow(global::android.test.ServiceTestCase.staticClass, "shutdownService", "()V");
			global::android.test.ServiceTestCase._testServiceTestCaseSetUpProperly12255 = @__env.GetMethodIDNoThrow(global::android.test.ServiceTestCase.staticClass, "testServiceTestCaseSetUpProperly", "()V");
			global::android.test.ServiceTestCase._ServiceTestCase12256 = @__env.GetMethodIDNoThrow(global::android.test.ServiceTestCase.staticClass, "<init>", "(Ljava/lang/Class;)V");
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
