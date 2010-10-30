namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NotificationManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NotificationManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _notify2004;
		public virtual void notify(int arg0, android.app.Notification arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.NotificationManager.staticClass, "notify", "(ILandroid/app/Notification;)V", ref global::android.app.NotificationManager._notify2004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _notify2005;
		public virtual void notify(java.lang.String arg0, int arg1, android.app.Notification arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.NotificationManager.staticClass, "notify", "(Ljava/lang/String;ILandroid/app/Notification;)V", ref global::android.app.NotificationManager._notify2005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _cancel2006;
		public virtual void cancel(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.NotificationManager.staticClass, "cancel", "(I)V", ref global::android.app.NotificationManager._cancel2006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cancel2007;
		public virtual void cancel(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.NotificationManager.staticClass, "cancel", "(Ljava/lang/String;I)V", ref global::android.app.NotificationManager._cancel2007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _cancelAll2008;
		public virtual void cancelAll()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.NotificationManager.staticClass, "cancelAll", "()V", ref global::android.app.NotificationManager._cancelAll2008);
		}
		static NotificationManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.NotificationManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/NotificationManager"));
		}
		internal static void InitJNI()
		{
		}
	}
}
