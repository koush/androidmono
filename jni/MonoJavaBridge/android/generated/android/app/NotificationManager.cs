namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NotificationManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NotificationManager()
		{
			InitJNI();
		}
		protected NotificationManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _notify702;
		public virtual void notify(int arg0, android.app.Notification arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.NotificationManager._notify702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.NotificationManager.staticClass, global::android.app.NotificationManager._notify702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _notify703;
		public virtual void notify(java.lang.String arg0, int arg1, android.app.Notification arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.NotificationManager._notify703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.NotificationManager.staticClass, global::android.app.NotificationManager._notify703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _cancel704;
		public virtual void cancel(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.NotificationManager._cancel704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.NotificationManager.staticClass, global::android.app.NotificationManager._cancel704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cancel705;
		public virtual void cancel(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.NotificationManager._cancel705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.NotificationManager.staticClass, global::android.app.NotificationManager._cancel705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _cancelAll706;
		public virtual void cancelAll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.NotificationManager._cancelAll706);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.NotificationManager.staticClass, global::android.app.NotificationManager._cancelAll706);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.NotificationManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/NotificationManager"));
			global::android.app.NotificationManager._notify702 = @__env.GetMethodIDNoThrow(global::android.app.NotificationManager.staticClass, "notify", "(ILandroid/app/Notification;)V");
			global::android.app.NotificationManager._notify703 = @__env.GetMethodIDNoThrow(global::android.app.NotificationManager.staticClass, "notify", "(Ljava/lang/String;ILandroid/app/Notification;)V");
			global::android.app.NotificationManager._cancel704 = @__env.GetMethodIDNoThrow(global::android.app.NotificationManager.staticClass, "cancel", "(I)V");
			global::android.app.NotificationManager._cancel705 = @__env.GetMethodIDNoThrow(global::android.app.NotificationManager.staticClass, "cancel", "(Ljava/lang/String;I)V");
			global::android.app.NotificationManager._cancelAll706 = @__env.GetMethodIDNoThrow(global::android.app.NotificationManager.staticClass, "cancelAll", "()V");
		}
	}
}
