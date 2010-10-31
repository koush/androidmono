namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ActivityGroup : android.app.Activity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ActivityGroup(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void onCreate(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ActivityGroup.staticClass, "onCreate", "(Landroid/os/Bundle;)V", ref global::android.app.ActivityGroup._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void onDestroy()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ActivityGroup.staticClass, "onDestroy", "()V", ref global::android.app.ActivityGroup._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override void onResume()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ActivityGroup.staticClass, "onResume", "()V", ref global::android.app.ActivityGroup._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override void onSaveInstanceState(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ActivityGroup.staticClass, "onSaveInstanceState", "(Landroid/os/Bundle;)V", ref global::android.app.ActivityGroup._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected override void onPause()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ActivityGroup.staticClass, "onPause", "()V", ref global::android.app.ActivityGroup._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override void onStop()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ActivityGroup.staticClass, "onStop", "()V", ref global::android.app.ActivityGroup._m5);
		}
		public new global::android.app.Activity CurrentActivity
		{
			get
			{
				return getCurrentActivity();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::android.app.Activity getCurrentActivity()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.ActivityGroup.staticClass, "getCurrentActivity", "()Landroid/app/Activity;", ref global::android.app.ActivityGroup._m6) as android.app.Activity;
		}
		public new global::android.app.LocalActivityManager LocalActivityManager
		{
			get
			{
				return getLocalActivityManager();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::android.app.LocalActivityManager getLocalActivityManager()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.ActivityGroup.staticClass, "getLocalActivityManager", "()Landroid/app/LocalActivityManager;", ref global::android.app.ActivityGroup._m7) as android.app.LocalActivityManager;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public ActivityGroup(bool arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.ActivityGroup._m8.native == global::System.IntPtr.Zero)
				global::android.app.ActivityGroup._m8 = @__env.GetMethodIDNoThrow(global::android.app.ActivityGroup.staticClass, "<init>", "(Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public ActivityGroup() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.ActivityGroup._m9.native == global::System.IntPtr.Zero)
				global::android.app.ActivityGroup._m9 = @__env.GetMethodIDNoThrow(global::android.app.ActivityGroup.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._m9);
			Init(@__env, handle);
		}
		static ActivityGroup()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.ActivityGroup.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/ActivityGroup"));
		}
	}
}
