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
		internal static global::net.sf.jni4net.jni.MethodId _onCreate269;
		protected override void onCreate(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ActivityGroup._onCreate269, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._onCreate269, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDestroy270;
		protected override void onDestroy() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ActivityGroup._onDestroy270);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._onDestroy270);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onResume271;
		protected override void onResume() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ActivityGroup._onResume271);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._onResume271);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState272;
		protected override void onSaveInstanceState(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ActivityGroup._onSaveInstanceState272, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._onSaveInstanceState272, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onPause273;
		protected override void onPause() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ActivityGroup._onPause273);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._onPause273);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onStop274;
		protected override void onStop() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ActivityGroup._onStop274);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._onStop274);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentActivity275;
		public virtual global::android.app.Activity getCurrentActivity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.ActivityGroup._getCurrentActivity275));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._getCurrentActivity275));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLocalActivityManager276;
		public virtual global::android.app.LocalActivityManager getLocalActivityManager() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.LocalActivityManager>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.ActivityGroup._getLocalActivityManager276));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.LocalActivityManager>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._getLocalActivityManager276));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ActivityGroup277;
		public ActivityGroup(bool arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._ActivityGroup277, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ActivityGroup278;
		public ActivityGroup()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.app.ActivityGroup.staticClass, global::android.app.ActivityGroup._ActivityGroup278, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.app.ActivityGroup.staticClass = @__class;
			global::android.app.ActivityGroup._onCreate269 = @__env.GetMethodID(global::android.app.ActivityGroup.staticClass, "onCreate", "(Landroid/os/Bundle;)V");
			global::android.app.ActivityGroup._onDestroy270 = @__env.GetMethodID(global::android.app.ActivityGroup.staticClass, "onDestroy", "()V");
			global::android.app.ActivityGroup._onResume271 = @__env.GetMethodID(global::android.app.ActivityGroup.staticClass, "onResume", "()V");
			global::android.app.ActivityGroup._onSaveInstanceState272 = @__env.GetMethodID(global::android.app.ActivityGroup.staticClass, "onSaveInstanceState", "(Landroid/os/Bundle;)V");
			global::android.app.ActivityGroup._onPause273 = @__env.GetMethodID(global::android.app.ActivityGroup.staticClass, "onPause", "()V");
			global::android.app.ActivityGroup._onStop274 = @__env.GetMethodID(global::android.app.ActivityGroup.staticClass, "onStop", "()V");
			global::android.app.ActivityGroup._getCurrentActivity275 = @__env.GetMethodID(global::android.app.ActivityGroup.staticClass, "getCurrentActivity", "()Landroid/app/Activity;");
			global::android.app.ActivityGroup._getLocalActivityManager276 = @__env.GetMethodID(global::android.app.ActivityGroup.staticClass, "getLocalActivityManager", "()Landroid/app/LocalActivityManager;");
			global::android.app.ActivityGroup._ActivityGroup277 = @__env.GetMethodID(global::android.app.ActivityGroup.staticClass, "<init>", "(Z)V");
			global::android.app.ActivityGroup._ActivityGroup278 = @__env.GetMethodID(global::android.app.ActivityGroup.staticClass, "<init>", "()V");
		}
	}
}
