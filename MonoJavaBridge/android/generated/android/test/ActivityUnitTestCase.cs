namespace android.test
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.test.ActivityUnitTestCase_))]
	public abstract partial class ActivityUnitTestCase : android.test.ActivityTestCase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ActivityUnitTestCase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _startActivity12128;
		protected virtual global::android.app.Activity startActivity(android.content.Intent arg0, android.os.Bundle arg1, java.lang.Object arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.ActivityUnitTestCase.staticClass, "startActivity", "(Landroid/content/Intent;Landroid/os/Bundle;Ljava/lang/Object;)Landroid/app/Activity;", ref global::android.test.ActivityUnitTestCase._startActivity12128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.app.Activity;
		}
		internal static global::MonoJavaBridge.MethodId _getRequestedOrientation12129;
		public virtual int getRequestedOrientation()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.test.ActivityUnitTestCase.staticClass, "getRequestedOrientation", "()I", ref global::android.test.ActivityUnitTestCase._getRequestedOrientation12129);
		}
		internal static global::MonoJavaBridge.MethodId _getActivity12130;
		public virtual global::android.app.Activity getActivity()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.ActivityUnitTestCase.staticClass, "getActivity", "()Landroid/app/Activity;", ref global::android.test.ActivityUnitTestCase._getActivity12130) as android.app.Activity;
		}
		internal static global::MonoJavaBridge.MethodId _setUp12131;
		protected override void setUp()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.ActivityUnitTestCase.staticClass, "setUp", "()V", ref global::android.test.ActivityUnitTestCase._setUp12131);
		}
		internal static global::MonoJavaBridge.MethodId _tearDown12132;
		protected override void tearDown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.ActivityUnitTestCase.staticClass, "tearDown", "()V", ref global::android.test.ActivityUnitTestCase._tearDown12132);
		}
		internal static global::MonoJavaBridge.MethodId _setApplication12133;
		public virtual void setApplication(android.app.Application arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.ActivityUnitTestCase.staticClass, "setApplication", "(Landroid/app/Application;)V", ref global::android.test.ActivityUnitTestCase._setApplication12133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setActivityContext12134;
		public virtual void setActivityContext(android.content.Context arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.ActivityUnitTestCase.staticClass, "setActivityContext", "(Landroid/content/Context;)V", ref global::android.test.ActivityUnitTestCase._setActivityContext12134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getStartedActivityIntent12135;
		public virtual global::android.content.Intent getStartedActivityIntent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.ActivityUnitTestCase.staticClass, "getStartedActivityIntent", "()Landroid/content/Intent;", ref global::android.test.ActivityUnitTestCase._getStartedActivityIntent12135) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _getStartedActivityRequest12136;
		public virtual int getStartedActivityRequest()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.test.ActivityUnitTestCase.staticClass, "getStartedActivityRequest", "()I", ref global::android.test.ActivityUnitTestCase._getStartedActivityRequest12136);
		}
		internal static global::MonoJavaBridge.MethodId _isFinishCalled12137;
		public virtual bool isFinishCalled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.test.ActivityUnitTestCase.staticClass, "isFinishCalled", "()Z", ref global::android.test.ActivityUnitTestCase._isFinishCalled12137);
		}
		internal static global::MonoJavaBridge.MethodId _getFinishedActivityRequest12138;
		public virtual int getFinishedActivityRequest()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.test.ActivityUnitTestCase.staticClass, "getFinishedActivityRequest", "()I", ref global::android.test.ActivityUnitTestCase._getFinishedActivityRequest12138);
		}
		internal static global::MonoJavaBridge.MethodId _ActivityUnitTestCase12139;
		public ActivityUnitTestCase(java.lang.Class arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.ActivityUnitTestCase._ActivityUnitTestCase12139.native == global::System.IntPtr.Zero)
				global::android.test.ActivityUnitTestCase._ActivityUnitTestCase12139 = @__env.GetMethodIDNoThrow(global::android.test.ActivityUnitTestCase.staticClass, "<init>", "(Ljava/lang/Class;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.ActivityUnitTestCase.staticClass, global::android.test.ActivityUnitTestCase._ActivityUnitTestCase12139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ActivityUnitTestCase()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.ActivityUnitTestCase.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/ActivityUnitTestCase"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.test.ActivityUnitTestCase))]
	internal sealed partial class ActivityUnitTestCase_ : android.test.ActivityUnitTestCase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ActivityUnitTestCase_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static ActivityUnitTestCase_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.ActivityUnitTestCase_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/ActivityUnitTestCase"));
		}
		internal static void InitJNI()
		{
		}
	}
}
