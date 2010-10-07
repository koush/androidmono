namespace android.app
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ActivityGroup : android.app.Activity
	{
		internal new static global::java.lang.Class staticClass;
		static ActivityGroup()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.ActivityGroup), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.app.ActivityGroup(@__env);
			}
		}
		protected ActivityGroup(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreate273;
		protected override void onCreate(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ActivityGroup._onCreate273, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._onCreate273, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDestroy274;
		protected override void onDestroy() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ActivityGroup._onDestroy274);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._onDestroy274);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onResume275;
		protected override void onResume() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ActivityGroup._onResume275);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._onResume275);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState276;
		protected override void onSaveInstanceState(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ActivityGroup._onSaveInstanceState276, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._onSaveInstanceState276, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onPause277;
		protected override void onPause() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ActivityGroup._onPause277);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._onPause277);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onStop278;
		protected override void onStop() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ActivityGroup._onStop278);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._onStop278);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentActivity279;
		public virtual global::android.app.Activity getCurrentActivity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.ActivityGroup._getCurrentActivity279));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._getCurrentActivity279));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLocalActivityManager280;
		public virtual global::android.app.LocalActivityManager getLocalActivityManager() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.LocalActivityManager>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.ActivityGroup._getLocalActivityManager280));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.LocalActivityManager>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._getLocalActivityManager280));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ActivityGroup281;
		public ActivityGroup(bool arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._ActivityGroup281, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ActivityGroup282;
		public ActivityGroup()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._ActivityGroup282, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.app.ActivityGroup.staticClass = @__class;
			global::android.app.ActivityGroup._onCreate273 = @__env.GetMethodID(global::android.app.ActivityGroup.staticClass, "onCreate", "(Landroid/os/Bundle;)V");
			global::android.app.ActivityGroup._onDestroy274 = @__env.GetMethodID(global::android.app.ActivityGroup.staticClass, "onDestroy", "()V");
			global::android.app.ActivityGroup._onResume275 = @__env.GetMethodID(global::android.app.ActivityGroup.staticClass, "onResume", "()V");
			global::android.app.ActivityGroup._onSaveInstanceState276 = @__env.GetMethodID(global::android.app.ActivityGroup.staticClass, "onSaveInstanceState", "(Landroid/os/Bundle;)V");
			global::android.app.ActivityGroup._onPause277 = @__env.GetMethodID(global::android.app.ActivityGroup.staticClass, "onPause", "()V");
			global::android.app.ActivityGroup._onStop278 = @__env.GetMethodID(global::android.app.ActivityGroup.staticClass, "onStop", "()V");
			global::android.app.ActivityGroup._getCurrentActivity279 = @__env.GetMethodID(global::android.app.ActivityGroup.staticClass, "getCurrentActivity", "()Landroid/app/Activity;");
			global::android.app.ActivityGroup._getLocalActivityManager280 = @__env.GetMethodID(global::android.app.ActivityGroup.staticClass, "getLocalActivityManager", "()Landroid/app/LocalActivityManager;");
			global::android.app.ActivityGroup._ActivityGroup281 = @__env.GetMethodID(global::android.app.ActivityGroup.staticClass, "<init>", "(Z)V");
			global::android.app.ActivityGroup._ActivityGroup282 = @__env.GetMethodID(global::android.app.ActivityGroup.staticClass, "<init>", "()V");
		}
	}
}
