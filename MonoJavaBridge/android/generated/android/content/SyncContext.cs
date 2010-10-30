namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SyncContext : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SyncContext(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onFinished3546;
		public virtual void onFinished(android.content.SyncResult arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.SyncContext.staticClass, global::android.content.SyncContext._onFinished3546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.os.IBinder SyncContextBinder
		{
			get
			{
				return getSyncContextBinder();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSyncContextBinder3547;
		public virtual global::android.os.IBinder getSyncContextBinder()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.SyncContext.staticClass, global::android.content.SyncContext._getSyncContextBinder3547)) as android.os.IBinder;
		}
		static SyncContext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.SyncContext.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/SyncContext"));
			global::android.content.SyncContext._onFinished3546 = @__env.GetMethodIDNoThrow(global::android.content.SyncContext.staticClass, "onFinished", "(Landroid/content/SyncResult;)V");
			global::android.content.SyncContext._getSyncContextBinder3547 = @__env.GetMethodIDNoThrow(global::android.content.SyncContext.staticClass, "getSyncContextBinder", "()Landroid/os/IBinder;");
		}
		internal static void InitJNI()
		{
		}
	}
}
