namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LocalActivityManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LocalActivityManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _startActivity1955;
		public virtual global::android.view.Window startActivity(java.lang.String arg0, android.content.Intent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._startActivity1955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.Window;
		}
		internal static global::MonoJavaBridge.MethodId _getActivity1956;
		public virtual global::android.app.Activity getActivity(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._getActivity1956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.Activity;
		}
		public new global::android.app.Activity CurrentActivity
		{
			get
			{
				return getCurrentActivity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentActivity1957;
		public virtual global::android.app.Activity getCurrentActivity()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._getCurrentActivity1957)) as android.app.Activity;
		}
		internal static global::MonoJavaBridge.MethodId _destroyActivity1958;
		public virtual global::android.view.Window destroyActivity(java.lang.String arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._destroyActivity1958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.Window;
		}
		public new global::java.lang.String CurrentId
		{
			get
			{
				return getCurrentId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentId1959;
		public virtual global::java.lang.String getCurrentId()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._getCurrentId1959)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _dispatchCreate1960;
		public virtual void dispatchCreate(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._dispatchCreate1960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _saveInstanceState1961;
		public virtual global::android.os.Bundle saveInstanceState()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._saveInstanceState1961)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _dispatchResume1962;
		public virtual void dispatchResume()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._dispatchResume1962);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchPause1963;
		public virtual void dispatchPause(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._dispatchPause1963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchStop1964;
		public virtual void dispatchStop()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._dispatchStop1964);
		}
		internal static global::MonoJavaBridge.MethodId _removeAllActivities1965;
		public virtual void removeAllActivities()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._removeAllActivities1965);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchDestroy1966;
		public virtual void dispatchDestroy(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._dispatchDestroy1966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _LocalActivityManager1967;
		public LocalActivityManager(android.app.Activity arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._LocalActivityManager1967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static LocalActivityManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.LocalActivityManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/LocalActivityManager"));
			global::android.app.LocalActivityManager._startActivity1955 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "startActivity", "(Ljava/lang/String;Landroid/content/Intent;)Landroid/view/Window;");
			global::android.app.LocalActivityManager._getActivity1956 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "getActivity", "(Ljava/lang/String;)Landroid/app/Activity;");
			global::android.app.LocalActivityManager._getCurrentActivity1957 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "getCurrentActivity", "()Landroid/app/Activity;");
			global::android.app.LocalActivityManager._destroyActivity1958 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "destroyActivity", "(Ljava/lang/String;Z)Landroid/view/Window;");
			global::android.app.LocalActivityManager._getCurrentId1959 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "getCurrentId", "()Ljava/lang/String;");
			global::android.app.LocalActivityManager._dispatchCreate1960 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "dispatchCreate", "(Landroid/os/Bundle;)V");
			global::android.app.LocalActivityManager._saveInstanceState1961 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "saveInstanceState", "()Landroid/os/Bundle;");
			global::android.app.LocalActivityManager._dispatchResume1962 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "dispatchResume", "()V");
			global::android.app.LocalActivityManager._dispatchPause1963 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "dispatchPause", "(Z)V");
			global::android.app.LocalActivityManager._dispatchStop1964 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "dispatchStop", "()V");
			global::android.app.LocalActivityManager._removeAllActivities1965 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "removeAllActivities", "()V");
			global::android.app.LocalActivityManager._dispatchDestroy1966 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "dispatchDestroy", "(Z)V");
			global::android.app.LocalActivityManager._LocalActivityManager1967 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "<init>", "(Landroid/app/Activity;Z)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
