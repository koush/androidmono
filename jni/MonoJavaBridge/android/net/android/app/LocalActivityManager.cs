namespace android.app 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class LocalActivityManager : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static LocalActivityManager() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.LocalActivityManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.app.LocalActivityManager(@__env); 
			} 
		} 
		protected LocalActivityManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startActivity636; 
		public virtual android.view.Window startActivity(java.lang.String arg0, android.content.Intent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.LocalActivityManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.Window>(@__env, @__env.CallObjectMethodPtr(this, _startActivity636, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.Window>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.LocalActivityManager.staticClass, _startActivity636, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getActivity637; 
		public virtual android.app.Activity getActivity(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.LocalActivityManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallObjectMethodPtr(this, _getActivity637, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.LocalActivityManager.staticClass, _getActivity637, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentActivity638; 
		public virtual android.app.Activity getCurrentActivity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.LocalActivityManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallObjectMethodPtr(this, _getCurrentActivity638)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.LocalActivityManager.staticClass, _getCurrentActivity638)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _destroyActivity639; 
		public virtual android.view.Window destroyActivity(java.lang.String arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.LocalActivityManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.Window>(@__env, @__env.CallObjectMethodPtr(this, _destroyActivity639, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.Window>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.LocalActivityManager.staticClass, _destroyActivity639, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentId640; 
		public virtual java.lang.String getCurrentId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.LocalActivityManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getCurrentId640)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.LocalActivityManager.staticClass, _getCurrentId640)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchCreate641; 
		public virtual void dispatchCreate(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.LocalActivityManager)) 
				@__env.CallVoidMethod(this, _dispatchCreate641, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.LocalActivityManager.staticClass, _dispatchCreate641, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _saveInstanceState642; 
		public virtual android.os.Bundle saveInstanceState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.LocalActivityManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, _saveInstanceState642)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.LocalActivityManager.staticClass, _saveInstanceState642)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchResume643; 
		public virtual void dispatchResume() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.LocalActivityManager)) 
				@__env.CallVoidMethod(this, _dispatchResume643); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.LocalActivityManager.staticClass, _dispatchResume643); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchPause644; 
		public virtual void dispatchPause(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.LocalActivityManager)) 
				@__env.CallVoidMethod(this, _dispatchPause644, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.LocalActivityManager.staticClass, _dispatchPause644, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchStop645; 
		public virtual void dispatchStop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.LocalActivityManager)) 
				@__env.CallVoidMethod(this, _dispatchStop645); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.LocalActivityManager.staticClass, _dispatchStop645); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeAllActivities646; 
		public virtual void removeAllActivities() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.LocalActivityManager)) 
				@__env.CallVoidMethod(this, _removeAllActivities646); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.LocalActivityManager.staticClass, _removeAllActivities646); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchDestroy647; 
		public virtual void dispatchDestroy(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.LocalActivityManager)) 
				@__env.CallVoidMethod(this, _dispatchDestroy647, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.LocalActivityManager.staticClass, _dispatchDestroy647, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LocalActivityManager648; 
		public LocalActivityManager(android.app.Activity arg0, bool arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.LocalActivityManager.staticClass, _LocalActivityManager648, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.app.LocalActivityManager.staticClass = @__class; 
			global::android.app.LocalActivityManager._startActivity636 = @__env.GetMethodID(global::android.app.LocalActivityManager.staticClass, "startActivity", "(Ljava/lang/String;Landroid/content/Intent;)Landroid/view/Window;"); 
			global::android.app.LocalActivityManager._getActivity637 = @__env.GetMethodID(global::android.app.LocalActivityManager.staticClass, "getActivity", "(Ljava/lang/String;)Landroid/app/Activity;"); 
			global::android.app.LocalActivityManager._getCurrentActivity638 = @__env.GetMethodID(global::android.app.LocalActivityManager.staticClass, "getCurrentActivity", "()Landroid/app/Activity;"); 
			global::android.app.LocalActivityManager._destroyActivity639 = @__env.GetMethodID(global::android.app.LocalActivityManager.staticClass, "destroyActivity", "(Ljava/lang/String;Z)Landroid/view/Window;"); 
			global::android.app.LocalActivityManager._getCurrentId640 = @__env.GetMethodID(global::android.app.LocalActivityManager.staticClass, "getCurrentId", "()Ljava/lang/String;"); 
			global::android.app.LocalActivityManager._dispatchCreate641 = @__env.GetMethodID(global::android.app.LocalActivityManager.staticClass, "dispatchCreate", "(Landroid/os/Bundle;)V"); 
			global::android.app.LocalActivityManager._saveInstanceState642 = @__env.GetMethodID(global::android.app.LocalActivityManager.staticClass, "saveInstanceState", "()Landroid/os/Bundle;"); 
			global::android.app.LocalActivityManager._dispatchResume643 = @__env.GetMethodID(global::android.app.LocalActivityManager.staticClass, "dispatchResume", "()V"); 
			global::android.app.LocalActivityManager._dispatchPause644 = @__env.GetMethodID(global::android.app.LocalActivityManager.staticClass, "dispatchPause", "(Z)V"); 
			global::android.app.LocalActivityManager._dispatchStop645 = @__env.GetMethodID(global::android.app.LocalActivityManager.staticClass, "dispatchStop", "()V"); 
			global::android.app.LocalActivityManager._removeAllActivities646 = @__env.GetMethodID(global::android.app.LocalActivityManager.staticClass, "removeAllActivities", "()V"); 
			global::android.app.LocalActivityManager._dispatchDestroy647 = @__env.GetMethodID(global::android.app.LocalActivityManager.staticClass, "dispatchDestroy", "(Z)V"); 
			global::android.app.LocalActivityManager._LocalActivityManager648 = @__env.GetMethodID(global::android.app.LocalActivityManager.staticClass, "<init>", "(Landroid/app/Activity;Z)V"); 
		} 
	} 
} 
