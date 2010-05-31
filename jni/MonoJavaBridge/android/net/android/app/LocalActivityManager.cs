namespace android.app 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class LocalActivityManager : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static LocalActivityManager() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.LocalActivityManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _startActivity645; 
		public virtual global::android.view.Window startActivity(java.lang.String arg0, android.content.Intent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.Window>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.LocalActivityManager._startActivity645, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.Window>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._startActivity645, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getActivity646; 
		public virtual global::android.app.Activity getActivity(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.LocalActivityManager._getActivity646, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._getActivity646, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentActivity647; 
		public virtual global::android.app.Activity getCurrentActivity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.LocalActivityManager._getCurrentActivity647)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._getCurrentActivity647)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _destroyActivity648; 
		public virtual global::android.view.Window destroyActivity(java.lang.String arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.Window>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.LocalActivityManager._destroyActivity648, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.Window>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._destroyActivity648, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentId649; 
		public virtual global::java.lang.String getCurrentId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.LocalActivityManager._getCurrentId649)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._getCurrentId649)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchCreate650; 
		public virtual void dispatchCreate(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.LocalActivityManager._dispatchCreate650, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._dispatchCreate650, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _saveInstanceState651; 
		public virtual global::android.os.Bundle saveInstanceState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.LocalActivityManager._saveInstanceState651)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._saveInstanceState651)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchResume652; 
		public virtual void dispatchResume() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.LocalActivityManager._dispatchResume652); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._dispatchResume652); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchPause653; 
		public virtual void dispatchPause(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.LocalActivityManager._dispatchPause653, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._dispatchPause653, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchStop654; 
		public virtual void dispatchStop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.LocalActivityManager._dispatchStop654); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._dispatchStop654); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeAllActivities655; 
		public virtual void removeAllActivities() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.LocalActivityManager._removeAllActivities655); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._removeAllActivities655); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchDestroy656; 
		public virtual void dispatchDestroy(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.LocalActivityManager._dispatchDestroy656, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._dispatchDestroy656, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LocalActivityManager657; 
		public LocalActivityManager(android.app.Activity arg0, bool arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._LocalActivityManager657, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.app.LocalActivityManager.staticClass = @__class; 
			global::android.app.LocalActivityManager._startActivity645 = @__env.GetMethodID(global::android.app.LocalActivityManager.staticClass, "startActivity", "(Ljava/lang/String;Landroid/content/Intent;)Landroid/view/Window;"); 
			global::android.app.LocalActivityManager._getActivity646 = @__env.GetMethodID(global::android.app.LocalActivityManager.staticClass, "getActivity", "(Ljava/lang/String;)Landroid/app/Activity;"); 
			global::android.app.LocalActivityManager._getCurrentActivity647 = @__env.GetMethodID(global::android.app.LocalActivityManager.staticClass, "getCurrentActivity", "()Landroid/app/Activity;"); 
			global::android.app.LocalActivityManager._destroyActivity648 = @__env.GetMethodID(global::android.app.LocalActivityManager.staticClass, "destroyActivity", "(Ljava/lang/String;Z)Landroid/view/Window;"); 
			global::android.app.LocalActivityManager._getCurrentId649 = @__env.GetMethodID(global::android.app.LocalActivityManager.staticClass, "getCurrentId", "()Ljava/lang/String;"); 
			global::android.app.LocalActivityManager._dispatchCreate650 = @__env.GetMethodID(global::android.app.LocalActivityManager.staticClass, "dispatchCreate", "(Landroid/os/Bundle;)V"); 
			global::android.app.LocalActivityManager._saveInstanceState651 = @__env.GetMethodID(global::android.app.LocalActivityManager.staticClass, "saveInstanceState", "()Landroid/os/Bundle;"); 
			global::android.app.LocalActivityManager._dispatchResume652 = @__env.GetMethodID(global::android.app.LocalActivityManager.staticClass, "dispatchResume", "()V"); 
			global::android.app.LocalActivityManager._dispatchPause653 = @__env.GetMethodID(global::android.app.LocalActivityManager.staticClass, "dispatchPause", "(Z)V"); 
			global::android.app.LocalActivityManager._dispatchStop654 = @__env.GetMethodID(global::android.app.LocalActivityManager.staticClass, "dispatchStop", "()V"); 
			global::android.app.LocalActivityManager._removeAllActivities655 = @__env.GetMethodID(global::android.app.LocalActivityManager.staticClass, "removeAllActivities", "()V"); 
			global::android.app.LocalActivityManager._dispatchDestroy656 = @__env.GetMethodID(global::android.app.LocalActivityManager.staticClass, "dispatchDestroy", "(Z)V"); 
			global::android.app.LocalActivityManager._LocalActivityManager657 = @__env.GetMethodID(global::android.app.LocalActivityManager.staticClass, "<init>", "(Landroid/app/Activity;Z)V"); 
		} 
	} 
} 
