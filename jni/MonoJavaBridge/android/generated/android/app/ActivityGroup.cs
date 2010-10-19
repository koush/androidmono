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
		internal static global::MonoJavaBridge.MethodId _onCreate282;
		protected override void onCreate(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityGroup._onCreate282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._onCreate282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDestroy283;
		protected override void onDestroy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityGroup._onDestroy283);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._onDestroy283);
		}
		internal static global::MonoJavaBridge.MethodId _onResume284;
		protected override void onResume() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityGroup._onResume284);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._onResume284);
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState285;
		protected override void onSaveInstanceState(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityGroup._onSaveInstanceState285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._onSaveInstanceState285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onPause286;
		protected override void onPause() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityGroup._onPause286);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._onPause286);
		}
		internal static global::MonoJavaBridge.MethodId _onStop287;
		protected override void onStop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityGroup._onStop287);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._onStop287);
		}
		public new global::android.app.Activity CurrentActivity
		{
			get
			{
				return getCurrentActivity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentActivity288;
		public virtual global::android.app.Activity getCurrentActivity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.ActivityGroup._getCurrentActivity288)) as android.app.Activity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._getCurrentActivity288)) as android.app.Activity;
		}
		public new global::android.app.LocalActivityManager LocalActivityManager
		{
			get
			{
				return getLocalActivityManager();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalActivityManager289;
		public virtual global::android.app.LocalActivityManager getLocalActivityManager() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.ActivityGroup._getLocalActivityManager289)) as android.app.LocalActivityManager;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._getLocalActivityManager289)) as android.app.LocalActivityManager;
		}
		internal static global::MonoJavaBridge.MethodId _ActivityGroup290;
		public ActivityGroup(bool arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._ActivityGroup290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ActivityGroup291;
		public ActivityGroup()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._ActivityGroup291);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.ActivityGroup.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/ActivityGroup"));
			global::android.app.ActivityGroup._onCreate282 = @__env.GetMethodIDNoThrow(global::android.app.ActivityGroup.staticClass, "onCreate", "(Landroid/os/Bundle;)V");
			global::android.app.ActivityGroup._onDestroy283 = @__env.GetMethodIDNoThrow(global::android.app.ActivityGroup.staticClass, "onDestroy", "()V");
			global::android.app.ActivityGroup._onResume284 = @__env.GetMethodIDNoThrow(global::android.app.ActivityGroup.staticClass, "onResume", "()V");
			global::android.app.ActivityGroup._onSaveInstanceState285 = @__env.GetMethodIDNoThrow(global::android.app.ActivityGroup.staticClass, "onSaveInstanceState", "(Landroid/os/Bundle;)V");
			global::android.app.ActivityGroup._onPause286 = @__env.GetMethodIDNoThrow(global::android.app.ActivityGroup.staticClass, "onPause", "()V");
			global::android.app.ActivityGroup._onStop287 = @__env.GetMethodIDNoThrow(global::android.app.ActivityGroup.staticClass, "onStop", "()V");
			global::android.app.ActivityGroup._getCurrentActivity288 = @__env.GetMethodIDNoThrow(global::android.app.ActivityGroup.staticClass, "getCurrentActivity", "()Landroid/app/Activity;");
			global::android.app.ActivityGroup._getLocalActivityManager289 = @__env.GetMethodIDNoThrow(global::android.app.ActivityGroup.staticClass, "getLocalActivityManager", "()Landroid/app/LocalActivityManager;");
			global::android.app.ActivityGroup._ActivityGroup290 = @__env.GetMethodIDNoThrow(global::android.app.ActivityGroup.staticClass, "<init>", "(Z)V");
			global::android.app.ActivityGroup._ActivityGroup291 = @__env.GetMethodIDNoThrow(global::android.app.ActivityGroup.staticClass, "<init>", "()V");
		}
	}
}
