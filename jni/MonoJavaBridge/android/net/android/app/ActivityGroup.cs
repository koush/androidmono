namespace android.app 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ActivityGroup : android.app.Activity
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ActivityGroup() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.ActivityGroup), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _onCreate262; 
		protected override void onCreate(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ActivityGroup)) 
				@__env.CallVoidMethod(this, _onCreate262, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.ActivityGroup.staticClass, _onCreate262, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDestroy263; 
		protected override void onDestroy() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ActivityGroup)) 
				@__env.CallVoidMethod(this, _onDestroy263); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.ActivityGroup.staticClass, _onDestroy263); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onResume264; 
		protected override void onResume() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ActivityGroup)) 
				@__env.CallVoidMethod(this, _onResume264); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.ActivityGroup.staticClass, _onResume264); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState265; 
		protected override void onSaveInstanceState(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ActivityGroup)) 
				@__env.CallVoidMethod(this, _onSaveInstanceState265, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.ActivityGroup.staticClass, _onSaveInstanceState265, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPause266; 
		protected override void onPause() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ActivityGroup)) 
				@__env.CallVoidMethod(this, _onPause266); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.ActivityGroup.staticClass, _onPause266); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStop267; 
		protected override void onStop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ActivityGroup)) 
				@__env.CallVoidMethod(this, _onStop267); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.ActivityGroup.staticClass, _onStop267); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentActivity268; 
		public virtual android.app.Activity getCurrentActivity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ActivityGroup)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallObjectMethodPtr(this, _getCurrentActivity268)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.ActivityGroup.staticClass, _getCurrentActivity268)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocalActivityManager269; 
		public virtual android.app.LocalActivityManager getLocalActivityManager() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ActivityGroup)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.LocalActivityManager>(@__env, @__env.CallObjectMethodPtr(this, _getLocalActivityManager269)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.LocalActivityManager>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.ActivityGroup.staticClass, _getLocalActivityManager269)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ActivityGroup270; 
		public ActivityGroup(bool arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.ActivityGroup.staticClass, _ActivityGroup270, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ActivityGroup271; 
		public ActivityGroup()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.ActivityGroup.staticClass, _ActivityGroup271, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.app.ActivityGroup.staticClass = @__class; 
			global::android.app.ActivityGroup._onCreate262 = @__env.GetMethodID(global::android.app.ActivityGroup.staticClass, "onCreate", "(Landroid/os/Bundle;)V"); 
			global::android.app.ActivityGroup._onDestroy263 = @__env.GetMethodID(global::android.app.ActivityGroup.staticClass, "onDestroy", "()V"); 
			global::android.app.ActivityGroup._onResume264 = @__env.GetMethodID(global::android.app.ActivityGroup.staticClass, "onResume", "()V"); 
			global::android.app.ActivityGroup._onSaveInstanceState265 = @__env.GetMethodID(global::android.app.ActivityGroup.staticClass, "onSaveInstanceState", "(Landroid/os/Bundle;)V"); 
			global::android.app.ActivityGroup._onPause266 = @__env.GetMethodID(global::android.app.ActivityGroup.staticClass, "onPause", "()V"); 
			global::android.app.ActivityGroup._onStop267 = @__env.GetMethodID(global::android.app.ActivityGroup.staticClass, "onStop", "()V"); 
			global::android.app.ActivityGroup._getCurrentActivity268 = @__env.GetMethodID(global::android.app.ActivityGroup.staticClass, "getCurrentActivity", "()Landroid/app/Activity;"); 
			global::android.app.ActivityGroup._getLocalActivityManager269 = @__env.GetMethodID(global::android.app.ActivityGroup.staticClass, "getLocalActivityManager", "()Landroid/app/LocalActivityManager;"); 
			global::android.app.ActivityGroup._ActivityGroup270 = @__env.GetMethodID(global::android.app.ActivityGroup.staticClass, "<init>", "(Z)V"); 
			global::android.app.ActivityGroup._ActivityGroup271 = @__env.GetMethodID(global::android.app.ActivityGroup.staticClass, "<init>", "()V"); 
		} 
	} 
} 
