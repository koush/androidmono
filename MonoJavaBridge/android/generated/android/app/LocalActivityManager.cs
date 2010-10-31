namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LocalActivityManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LocalActivityManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::android.view.Window startActivity(java.lang.String arg0, android.content.Intent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.LocalActivityManager.staticClass, "startActivity", "(Ljava/lang/String;Landroid/content/Intent;)Landroid/view/Window;", ref global::android.app.LocalActivityManager._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.view.Window;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::android.app.Activity getActivity(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.LocalActivityManager.staticClass, "getActivity", "(Ljava/lang/String;)Landroid/app/Activity;", ref global::android.app.LocalActivityManager._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.app.Activity;
		}
		public new global::android.app.Activity CurrentActivity
		{
			get
			{
				return getCurrentActivity();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::android.app.Activity getCurrentActivity()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.LocalActivityManager.staticClass, "getCurrentActivity", "()Landroid/app/Activity;", ref global::android.app.LocalActivityManager._m2) as android.app.Activity;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::android.view.Window destroyActivity(java.lang.String arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.LocalActivityManager.staticClass, "destroyActivity", "(Ljava/lang/String;Z)Landroid/view/Window;", ref global::android.app.LocalActivityManager._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.view.Window;
		}
		public new global::java.lang.String CurrentId
		{
			get
			{
				return getCurrentId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.String getCurrentId()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.app.LocalActivityManager.staticClass, "getCurrentId", "()Ljava/lang/String;", ref global::android.app.LocalActivityManager._m4) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void dispatchCreate(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.LocalActivityManager.staticClass, "dispatchCreate", "(Landroid/os/Bundle;)V", ref global::android.app.LocalActivityManager._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::android.os.Bundle saveInstanceState()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.app.LocalActivityManager.staticClass, "saveInstanceState", "()Landroid/os/Bundle;", ref global::android.app.LocalActivityManager._m6) as android.os.Bundle;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void dispatchResume()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.LocalActivityManager.staticClass, "dispatchResume", "()V", ref global::android.app.LocalActivityManager._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void dispatchPause(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.LocalActivityManager.staticClass, "dispatchPause", "(Z)V", ref global::android.app.LocalActivityManager._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void dispatchStop()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.LocalActivityManager.staticClass, "dispatchStop", "()V", ref global::android.app.LocalActivityManager._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void removeAllActivities()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.LocalActivityManager.staticClass, "removeAllActivities", "()V", ref global::android.app.LocalActivityManager._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void dispatchDestroy(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.LocalActivityManager.staticClass, "dispatchDestroy", "(Z)V", ref global::android.app.LocalActivityManager._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public LocalActivityManager(android.app.Activity arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.LocalActivityManager._m12.native == global::System.IntPtr.Zero)
				global::android.app.LocalActivityManager._m12 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "<init>", "(Landroid/app/Activity;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static LocalActivityManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.LocalActivityManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/LocalActivityManager"));
		}
	}
}
