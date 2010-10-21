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
		internal static global::MonoJavaBridge.MethodId _startActivity1951;
		public virtual global::android.view.Window startActivity(java.lang.String arg0, android.content.Intent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.LocalActivityManager._startActivity1951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.Window;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._startActivity1951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.Window;
		}
		internal static global::MonoJavaBridge.MethodId _getActivity1952;
		public virtual global::android.app.Activity getActivity(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.LocalActivityManager._getActivity1952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.Activity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._getActivity1952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.Activity;
		}
		public new global::android.app.Activity CurrentActivity
		{
			get
			{
				return getCurrentActivity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentActivity1953;
		public virtual global::android.app.Activity getCurrentActivity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.LocalActivityManager._getCurrentActivity1953)) as android.app.Activity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._getCurrentActivity1953)) as android.app.Activity;
		}
		internal static global::MonoJavaBridge.MethodId _destroyActivity1954;
		public virtual global::android.view.Window destroyActivity(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.LocalActivityManager._destroyActivity1954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.Window;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._destroyActivity1954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.Window;
		}
		public new global::java.lang.String CurrentId
		{
			get
			{
				return getCurrentId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentId1955;
		public virtual global::java.lang.String getCurrentId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.LocalActivityManager._getCurrentId1955)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._getCurrentId1955)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _dispatchCreate1956;
		public virtual void dispatchCreate(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.LocalActivityManager._dispatchCreate1956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._dispatchCreate1956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _saveInstanceState1957;
		public virtual global::android.os.Bundle saveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.LocalActivityManager._saveInstanceState1957)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._saveInstanceState1957)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _dispatchResume1958;
		public virtual void dispatchResume() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.LocalActivityManager._dispatchResume1958);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._dispatchResume1958);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchPause1959;
		public virtual void dispatchPause(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.LocalActivityManager._dispatchPause1959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._dispatchPause1959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchStop1960;
		public virtual void dispatchStop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.LocalActivityManager._dispatchStop1960);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._dispatchStop1960);
		}
		internal static global::MonoJavaBridge.MethodId _removeAllActivities1961;
		public virtual void removeAllActivities() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.LocalActivityManager._removeAllActivities1961);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._removeAllActivities1961);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchDestroy1962;
		public virtual void dispatchDestroy(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.LocalActivityManager._dispatchDestroy1962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._dispatchDestroy1962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _LocalActivityManager1963;
		public LocalActivityManager(android.app.Activity arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.LocalActivityManager.staticClass, global::android.app.LocalActivityManager._LocalActivityManager1963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.LocalActivityManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/LocalActivityManager"));
			global::android.app.LocalActivityManager._startActivity1951 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "startActivity", "(Ljava/lang/String;Landroid/content/Intent;)Landroid/view/Window;");
			global::android.app.LocalActivityManager._getActivity1952 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "getActivity", "(Ljava/lang/String;)Landroid/app/Activity;");
			global::android.app.LocalActivityManager._getCurrentActivity1953 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "getCurrentActivity", "()Landroid/app/Activity;");
			global::android.app.LocalActivityManager._destroyActivity1954 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "destroyActivity", "(Ljava/lang/String;Z)Landroid/view/Window;");
			global::android.app.LocalActivityManager._getCurrentId1955 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "getCurrentId", "()Ljava/lang/String;");
			global::android.app.LocalActivityManager._dispatchCreate1956 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "dispatchCreate", "(Landroid/os/Bundle;)V");
			global::android.app.LocalActivityManager._saveInstanceState1957 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "saveInstanceState", "()Landroid/os/Bundle;");
			global::android.app.LocalActivityManager._dispatchResume1958 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "dispatchResume", "()V");
			global::android.app.LocalActivityManager._dispatchPause1959 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "dispatchPause", "(Z)V");
			global::android.app.LocalActivityManager._dispatchStop1960 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "dispatchStop", "()V");
			global::android.app.LocalActivityManager._removeAllActivities1961 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "removeAllActivities", "()V");
			global::android.app.LocalActivityManager._dispatchDestroy1962 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "dispatchDestroy", "(Z)V");
			global::android.app.LocalActivityManager._LocalActivityManager1963 = @__env.GetMethodIDNoThrow(global::android.app.LocalActivityManager.staticClass, "<init>", "(Landroid/app/Activity;Z)V");
		}
	}
}
