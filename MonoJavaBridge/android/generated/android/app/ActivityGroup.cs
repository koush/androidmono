namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ActivityGroup : android.app.Activity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ActivityGroup(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onCreate1543;
		protected override void onCreate(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ActivityGroup.staticClass, "onCreate", "(Landroid/os/Bundle;)V", ref global::android.app.ActivityGroup._onCreate1543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDestroy1544;
		protected override void onDestroy()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ActivityGroup.staticClass, "onDestroy", "()V", ref global::android.app.ActivityGroup._onDestroy1544);
		}
		internal static global::MonoJavaBridge.MethodId _onResume1545;
		protected override void onResume()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ActivityGroup.staticClass, "onResume", "()V", ref global::android.app.ActivityGroup._onResume1545);
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState1546;
		protected override void onSaveInstanceState(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ActivityGroup.staticClass, "onSaveInstanceState", "(Landroid/os/Bundle;)V", ref global::android.app.ActivityGroup._onSaveInstanceState1546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onPause1547;
		protected override void onPause()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ActivityGroup.staticClass, "onPause", "()V", ref global::android.app.ActivityGroup._onPause1547);
		}
		internal static global::MonoJavaBridge.MethodId _onStop1548;
		protected override void onStop()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ActivityGroup.staticClass, "onStop", "()V", ref global::android.app.ActivityGroup._onStop1548);
		}
		public new global::android.app.Activity CurrentActivity
		{
			get
			{
				return getCurrentActivity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentActivity1549;
		public virtual global::android.app.Activity getCurrentActivity()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.ActivityGroup.staticClass, "getCurrentActivity", "()Landroid/app/Activity;", ref global::android.app.ActivityGroup._getCurrentActivity1549) as android.app.Activity;
		}
		public new global::android.app.LocalActivityManager LocalActivityManager
		{
			get
			{
				return getLocalActivityManager();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalActivityManager1550;
		public virtual global::android.app.LocalActivityManager getLocalActivityManager()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.ActivityGroup.staticClass, "getLocalActivityManager", "()Landroid/app/LocalActivityManager;", ref global::android.app.ActivityGroup._getLocalActivityManager1550) as android.app.LocalActivityManager;
		}
		internal static global::MonoJavaBridge.MethodId _ActivityGroup1551;
		public ActivityGroup(bool arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.ActivityGroup._ActivityGroup1551.native == global::System.IntPtr.Zero)
				global::android.app.ActivityGroup._ActivityGroup1551 = @__env.GetMethodIDNoThrow(global::android.app.ActivityGroup.staticClass, "<init>", "(Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._ActivityGroup1551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ActivityGroup1552;
		public ActivityGroup() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.ActivityGroup._ActivityGroup1552.native == global::System.IntPtr.Zero)
				global::android.app.ActivityGroup._ActivityGroup1552 = @__env.GetMethodIDNoThrow(global::android.app.ActivityGroup.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._ActivityGroup1552);
			Init(@__env, handle);
		}
		static ActivityGroup()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.ActivityGroup.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/ActivityGroup"));
		}
		internal static void InitJNI()
		{
		}
	}
}
