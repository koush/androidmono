namespace android.test
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.test.ActivityUnitTestCase_))]
	public abstract partial class ActivityUnitTestCase : android.test.ActivityTestCase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ActivityUnitTestCase()
		{
			InitJNI();
		}
		protected ActivityUnitTestCase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _startActivity12071;
		protected virtual global::android.app.Activity startActivity(android.content.Intent arg0, android.os.Bundle arg1, java.lang.Object arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase._startActivity12071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.Activity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase.staticClass, global::android.test.ActivityUnitTestCase._startActivity12071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.Activity;
		}
		internal static global::MonoJavaBridge.MethodId _getRequestedOrientation12072;
		public virtual int getRequestedOrientation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase._getRequestedOrientation12072);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase.staticClass, global::android.test.ActivityUnitTestCase._getRequestedOrientation12072);
		}
		internal static global::MonoJavaBridge.MethodId _getActivity12073;
		public virtual global::android.app.Activity getActivity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase._getActivity12073)) as android.app.Activity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase.staticClass, global::android.test.ActivityUnitTestCase._getActivity12073)) as android.app.Activity;
		}
		internal static global::MonoJavaBridge.MethodId _setUp12074;
		protected override void setUp() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase._setUp12074);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase.staticClass, global::android.test.ActivityUnitTestCase._setUp12074);
		}
		internal static global::MonoJavaBridge.MethodId _tearDown12075;
		protected override void tearDown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase._tearDown12075);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase.staticClass, global::android.test.ActivityUnitTestCase._tearDown12075);
		}
		internal static global::MonoJavaBridge.MethodId _setApplication12076;
		public virtual void setApplication(android.app.Application arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase._setApplication12076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase.staticClass, global::android.test.ActivityUnitTestCase._setApplication12076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setActivityContext12077;
		public virtual void setActivityContext(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase._setActivityContext12077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase.staticClass, global::android.test.ActivityUnitTestCase._setActivityContext12077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getStartedActivityIntent12078;
		public virtual global::android.content.Intent getStartedActivityIntent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase._getStartedActivityIntent12078)) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase.staticClass, global::android.test.ActivityUnitTestCase._getStartedActivityIntent12078)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _getStartedActivityRequest12079;
		public virtual int getStartedActivityRequest() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase._getStartedActivityRequest12079);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase.staticClass, global::android.test.ActivityUnitTestCase._getStartedActivityRequest12079);
		}
		internal static global::MonoJavaBridge.MethodId _isFinishCalled12080;
		public virtual bool isFinishCalled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase._isFinishCalled12080);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase.staticClass, global::android.test.ActivityUnitTestCase._isFinishCalled12080);
		}
		internal static global::MonoJavaBridge.MethodId _getFinishedActivityRequest12081;
		public virtual int getFinishedActivityRequest() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase._getFinishedActivityRequest12081);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase.staticClass, global::android.test.ActivityUnitTestCase._getFinishedActivityRequest12081);
		}
		internal static global::MonoJavaBridge.MethodId _ActivityUnitTestCase12082;
		public ActivityUnitTestCase(java.lang.Class arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.ActivityUnitTestCase.staticClass, global::android.test.ActivityUnitTestCase._ActivityUnitTestCase12082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.ActivityUnitTestCase.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/ActivityUnitTestCase"));
			global::android.test.ActivityUnitTestCase._startActivity12071 = @__env.GetMethodIDNoThrow(global::android.test.ActivityUnitTestCase.staticClass, "startActivity", "(Landroid/content/Intent;Landroid/os/Bundle;Ljava/lang/Object;)Landroid/app/Activity;");
			global::android.test.ActivityUnitTestCase._getRequestedOrientation12072 = @__env.GetMethodIDNoThrow(global::android.test.ActivityUnitTestCase.staticClass, "getRequestedOrientation", "()I");
			global::android.test.ActivityUnitTestCase._getActivity12073 = @__env.GetMethodIDNoThrow(global::android.test.ActivityUnitTestCase.staticClass, "getActivity", "()Landroid/app/Activity;");
			global::android.test.ActivityUnitTestCase._setUp12074 = @__env.GetMethodIDNoThrow(global::android.test.ActivityUnitTestCase.staticClass, "setUp", "()V");
			global::android.test.ActivityUnitTestCase._tearDown12075 = @__env.GetMethodIDNoThrow(global::android.test.ActivityUnitTestCase.staticClass, "tearDown", "()V");
			global::android.test.ActivityUnitTestCase._setApplication12076 = @__env.GetMethodIDNoThrow(global::android.test.ActivityUnitTestCase.staticClass, "setApplication", "(Landroid/app/Application;)V");
			global::android.test.ActivityUnitTestCase._setActivityContext12077 = @__env.GetMethodIDNoThrow(global::android.test.ActivityUnitTestCase.staticClass, "setActivityContext", "(Landroid/content/Context;)V");
			global::android.test.ActivityUnitTestCase._getStartedActivityIntent12078 = @__env.GetMethodIDNoThrow(global::android.test.ActivityUnitTestCase.staticClass, "getStartedActivityIntent", "()Landroid/content/Intent;");
			global::android.test.ActivityUnitTestCase._getStartedActivityRequest12079 = @__env.GetMethodIDNoThrow(global::android.test.ActivityUnitTestCase.staticClass, "getStartedActivityRequest", "()I");
			global::android.test.ActivityUnitTestCase._isFinishCalled12080 = @__env.GetMethodIDNoThrow(global::android.test.ActivityUnitTestCase.staticClass, "isFinishCalled", "()Z");
			global::android.test.ActivityUnitTestCase._getFinishedActivityRequest12081 = @__env.GetMethodIDNoThrow(global::android.test.ActivityUnitTestCase.staticClass, "getFinishedActivityRequest", "()I");
			global::android.test.ActivityUnitTestCase._ActivityUnitTestCase12082 = @__env.GetMethodIDNoThrow(global::android.test.ActivityUnitTestCase.staticClass, "<init>", "(Ljava/lang/Class;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.test.ActivityUnitTestCase))]
	public sealed partial class ActivityUnitTestCase_ : android.test.ActivityUnitTestCase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ActivityUnitTestCase_()
		{
			InitJNI();
		}
		internal ActivityUnitTestCase_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.ActivityUnitTestCase_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/ActivityUnitTestCase"));
		}
	}
}
