namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ActivityGroup : android.app.Activity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ActivityGroup()
		{
			InitJNI();
		}
		protected ActivityGroup(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onCreate1541;
		protected override void onCreate(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityGroup._onCreate1541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._onCreate1541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDestroy1542;
		protected override void onDestroy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityGroup._onDestroy1542);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._onDestroy1542);
		}
		internal static global::MonoJavaBridge.MethodId _onResume1543;
		protected override void onResume() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityGroup._onResume1543);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._onResume1543);
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState1544;
		protected override void onSaveInstanceState(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityGroup._onSaveInstanceState1544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._onSaveInstanceState1544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onPause1545;
		protected override void onPause() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityGroup._onPause1545);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._onPause1545);
		}
		internal static global::MonoJavaBridge.MethodId _onStop1546;
		protected override void onStop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityGroup._onStop1546);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._onStop1546);
		}
		public new global::android.app.Activity CurrentActivity
		{
			get
			{
				return getCurrentActivity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentActivity1547;
		public virtual global::android.app.Activity getCurrentActivity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.ActivityGroup._getCurrentActivity1547)) as android.app.Activity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._getCurrentActivity1547)) as android.app.Activity;
		}
		public new global::android.app.LocalActivityManager LocalActivityManager
		{
			get
			{
				return getLocalActivityManager();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalActivityManager1548;
		public virtual global::android.app.LocalActivityManager getLocalActivityManager() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.ActivityGroup._getLocalActivityManager1548)) as android.app.LocalActivityManager;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._getLocalActivityManager1548)) as android.app.LocalActivityManager;
		}
		internal static global::MonoJavaBridge.MethodId _ActivityGroup1549;
		public ActivityGroup(bool arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._ActivityGroup1549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ActivityGroup1550;
		public ActivityGroup()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._ActivityGroup1550);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.ActivityGroup.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/ActivityGroup"));
			global::android.app.ActivityGroup._onCreate1541 = @__env.GetMethodIDNoThrow(global::android.app.ActivityGroup.staticClass, "onCreate", "(Landroid/os/Bundle;)V");
			global::android.app.ActivityGroup._onDestroy1542 = @__env.GetMethodIDNoThrow(global::android.app.ActivityGroup.staticClass, "onDestroy", "()V");
			global::android.app.ActivityGroup._onResume1543 = @__env.GetMethodIDNoThrow(global::android.app.ActivityGroup.staticClass, "onResume", "()V");
			global::android.app.ActivityGroup._onSaveInstanceState1544 = @__env.GetMethodIDNoThrow(global::android.app.ActivityGroup.staticClass, "onSaveInstanceState", "(Landroid/os/Bundle;)V");
			global::android.app.ActivityGroup._onPause1545 = @__env.GetMethodIDNoThrow(global::android.app.ActivityGroup.staticClass, "onPause", "()V");
			global::android.app.ActivityGroup._onStop1546 = @__env.GetMethodIDNoThrow(global::android.app.ActivityGroup.staticClass, "onStop", "()V");
			global::android.app.ActivityGroup._getCurrentActivity1547 = @__env.GetMethodIDNoThrow(global::android.app.ActivityGroup.staticClass, "getCurrentActivity", "()Landroid/app/Activity;");
			global::android.app.ActivityGroup._getLocalActivityManager1548 = @__env.GetMethodIDNoThrow(global::android.app.ActivityGroup.staticClass, "getLocalActivityManager", "()Landroid/app/LocalActivityManager;");
			global::android.app.ActivityGroup._ActivityGroup1549 = @__env.GetMethodIDNoThrow(global::android.app.ActivityGroup.staticClass, "<init>", "(Z)V");
			global::android.app.ActivityGroup._ActivityGroup1550 = @__env.GetMethodIDNoThrow(global::android.app.ActivityGroup.staticClass, "<init>", "()V");
		}
	}
}
