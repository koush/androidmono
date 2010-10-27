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
		internal static global::MonoJavaBridge.MethodId _startActivity12128;
		protected virtual global::android.app.Activity startActivity(android.content.Intent arg0, android.os.Bundle arg1, java.lang.Object arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase._startActivity12128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.Activity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase.staticClass, global::android.test.ActivityUnitTestCase._startActivity12128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.Activity;
		}
		internal static global::MonoJavaBridge.MethodId _getRequestedOrientation12129;
		public virtual int getRequestedOrientation()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase._getRequestedOrientation12129);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase.staticClass, global::android.test.ActivityUnitTestCase._getRequestedOrientation12129);
		}
		internal static global::MonoJavaBridge.MethodId _getActivity12130;
		public virtual global::android.app.Activity getActivity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase._getActivity12130)) as android.app.Activity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase.staticClass, global::android.test.ActivityUnitTestCase._getActivity12130)) as android.app.Activity;
		}
		internal static global::MonoJavaBridge.MethodId _setUp12131;
		protected override void setUp()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase._setUp12131);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase.staticClass, global::android.test.ActivityUnitTestCase._setUp12131);
		}
		internal static global::MonoJavaBridge.MethodId _tearDown12132;
		protected override void tearDown()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase._tearDown12132);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase.staticClass, global::android.test.ActivityUnitTestCase._tearDown12132);
		}
		internal static global::MonoJavaBridge.MethodId _setApplication12133;
		public virtual void setApplication(android.app.Application arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase._setApplication12133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase.staticClass, global::android.test.ActivityUnitTestCase._setApplication12133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setActivityContext12134;
		public virtual void setActivityContext(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase._setActivityContext12134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase.staticClass, global::android.test.ActivityUnitTestCase._setActivityContext12134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getStartedActivityIntent12135;
		public virtual global::android.content.Intent getStartedActivityIntent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase._getStartedActivityIntent12135)) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase.staticClass, global::android.test.ActivityUnitTestCase._getStartedActivityIntent12135)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _getStartedActivityRequest12136;
		public virtual int getStartedActivityRequest()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase._getStartedActivityRequest12136);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase.staticClass, global::android.test.ActivityUnitTestCase._getStartedActivityRequest12136);
		}
		internal static global::MonoJavaBridge.MethodId _isFinishCalled12137;
		public virtual bool isFinishCalled()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase._isFinishCalled12137);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase.staticClass, global::android.test.ActivityUnitTestCase._isFinishCalled12137);
		}
		internal static global::MonoJavaBridge.MethodId _getFinishedActivityRequest12138;
		public virtual int getFinishedActivityRequest()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase._getFinishedActivityRequest12138);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.ActivityUnitTestCase.staticClass, global::android.test.ActivityUnitTestCase._getFinishedActivityRequest12138);
		}
		internal static global::MonoJavaBridge.MethodId _ActivityUnitTestCase12139;
		public ActivityUnitTestCase(java.lang.Class arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.ActivityUnitTestCase.staticClass, global::android.test.ActivityUnitTestCase._ActivityUnitTestCase12139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.ActivityUnitTestCase.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/ActivityUnitTestCase"));
			global::android.test.ActivityUnitTestCase._startActivity12128 = @__env.GetMethodIDNoThrow(global::android.test.ActivityUnitTestCase.staticClass, "startActivity", "(Landroid/content/Intent;Landroid/os/Bundle;Ljava/lang/Object;)Landroid/app/Activity;");
			global::android.test.ActivityUnitTestCase._getRequestedOrientation12129 = @__env.GetMethodIDNoThrow(global::android.test.ActivityUnitTestCase.staticClass, "getRequestedOrientation", "()I");
			global::android.test.ActivityUnitTestCase._getActivity12130 = @__env.GetMethodIDNoThrow(global::android.test.ActivityUnitTestCase.staticClass, "getActivity", "()Landroid/app/Activity;");
			global::android.test.ActivityUnitTestCase._setUp12131 = @__env.GetMethodIDNoThrow(global::android.test.ActivityUnitTestCase.staticClass, "setUp", "()V");
			global::android.test.ActivityUnitTestCase._tearDown12132 = @__env.GetMethodIDNoThrow(global::android.test.ActivityUnitTestCase.staticClass, "tearDown", "()V");
			global::android.test.ActivityUnitTestCase._setApplication12133 = @__env.GetMethodIDNoThrow(global::android.test.ActivityUnitTestCase.staticClass, "setApplication", "(Landroid/app/Application;)V");
			global::android.test.ActivityUnitTestCase._setActivityContext12134 = @__env.GetMethodIDNoThrow(global::android.test.ActivityUnitTestCase.staticClass, "setActivityContext", "(Landroid/content/Context;)V");
			global::android.test.ActivityUnitTestCase._getStartedActivityIntent12135 = @__env.GetMethodIDNoThrow(global::android.test.ActivityUnitTestCase.staticClass, "getStartedActivityIntent", "()Landroid/content/Intent;");
			global::android.test.ActivityUnitTestCase._getStartedActivityRequest12136 = @__env.GetMethodIDNoThrow(global::android.test.ActivityUnitTestCase.staticClass, "getStartedActivityRequest", "()I");
			global::android.test.ActivityUnitTestCase._isFinishCalled12137 = @__env.GetMethodIDNoThrow(global::android.test.ActivityUnitTestCase.staticClass, "isFinishCalled", "()Z");
			global::android.test.ActivityUnitTestCase._getFinishedActivityRequest12138 = @__env.GetMethodIDNoThrow(global::android.test.ActivityUnitTestCase.staticClass, "getFinishedActivityRequest", "()I");
			global::android.test.ActivityUnitTestCase._ActivityUnitTestCase12139 = @__env.GetMethodIDNoThrow(global::android.test.ActivityUnitTestCase.staticClass, "<init>", "(Ljava/lang/Class;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.test.ActivityUnitTestCase))]
	internal sealed partial class ActivityUnitTestCase_ : android.test.ActivityUnitTestCase
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
