namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LocalActivityManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LocalActivityManager()
		{
			InitJNI();
		}
		protected LocalActivityManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _startActivity665;
		public virtual global::android.view.Window startActivity(java.lang.String arg0, android.content.Intent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.LocalActivityManager._startActivity665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.Window;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._startActivity665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.Window;
		}
		internal static global::MonoJavaBridge.MethodId _getActivity666;
		public virtual global::android.app.Activity getActivity(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.LocalActivityManager._getActivity666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.Activity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._getActivity666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.Activity;
		}
		public new global::android.app.Activity CurrentActivity
		{
			get
			{
				return getCurrentActivity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentActivity667;
		public virtual global::android.app.Activity getCurrentActivity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.LocalActivityManager._getCurrentActivity667)) as android.app.Activity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._getCurrentActivity667)) as android.app.Activity;
		}
		internal static global::MonoJavaBridge.MethodId _destroyActivity668;
		public virtual global::android.view.Window destroyActivity(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.LocalActivityManager._destroyActivity668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.Window;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._destroyActivity668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.Window;
		}
		public new global::java.lang.String CurrentId
		{
			get
			{
				return getCurrentId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentId669;
		public virtual global::java.lang.String getCurrentId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.LocalActivityManager._getCurrentId669)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._getCurrentId669)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _dispatchCreate670;
		public virtual void dispatchCreate(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.LocalActivityManager._dispatchCreate670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._dispatchCreate670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _saveInstanceState671;
		public virtual global::android.os.Bundle saveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.LocalActivityManager._saveInstanceState671)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._saveInstanceState671)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _dispatchResume672;
		public virtual void dispatchResume() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.LocalActivityManager._dispatchResume672);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._dispatchResume672);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchPause673;
		public virtual void dispatchPause(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.LocalActivityManager._dispatchPause673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._dispatchPause673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchStop674;
		public virtual void dispatchStop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.LocalActivityManager._dispatchStop674);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._dispatchStop674);
		}
		internal static global::MonoJavaBridge.MethodId _removeAllActivities675;
		public virtual void removeAllActivities() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.LocalActivityManager._removeAllActivities675);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._removeAllActivities675);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchDestroy676;
		public virtual void dispatchDestroy(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.LocalActivityManager._dispatchDestroy676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._dispatchDestroy676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _LocalActivityManager677;
		public LocalActivityManager(android.app.Activity arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._LocalActivityManager677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.LocalActivityManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/LocalActivityManager"));
			global::android.app.LocalActivityManager._startActivity665 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "startActivity", "(Ljava/lang/String;Landroid/content/Intent;)Landroid/view/Window;");
			global::android.app.LocalActivityManager._getActivity666 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "getActivity", "(Ljava/lang/String;)Landroid/app/Activity;");
			global::android.app.LocalActivityManager._getCurrentActivity667 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "getCurrentActivity", "()Landroid/app/Activity;");
			global::android.app.LocalActivityManager._destroyActivity668 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "destroyActivity", "(Ljava/lang/String;Z)Landroid/view/Window;");
			global::android.app.LocalActivityManager._getCurrentId669 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "getCurrentId", "()Ljava/lang/String;");
			global::android.app.LocalActivityManager._dispatchCreate670 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "dispatchCreate", "(Landroid/os/Bundle;)V");
			global::android.app.LocalActivityManager._saveInstanceState671 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "saveInstanceState", "()Landroid/os/Bundle;");
			global::android.app.LocalActivityManager._dispatchResume672 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "dispatchResume", "()V");
			global::android.app.LocalActivityManager._dispatchPause673 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "dispatchPause", "(Z)V");
			global::android.app.LocalActivityManager._dispatchStop674 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "dispatchStop", "()V");
			global::android.app.LocalActivityManager._removeAllActivities675 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "removeAllActivities", "()V");
			global::android.app.LocalActivityManager._dispatchDestroy676 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "dispatchDestroy", "(Z)V");
			global::android.app.LocalActivityManager._LocalActivityManager677 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "<init>", "(Landroid/app/Activity;Z)V");
		}
	}
}
