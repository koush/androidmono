namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SyncContext : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SyncContext(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void onFinished(android.content.SyncResult arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.SyncContext.staticClass, "onFinished", "(Landroid/content/SyncResult;)V", ref global::android.content.SyncContext._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.os.IBinder SyncContextBinder
		{
			get
			{
				return getSyncContextBinder();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::android.os.IBinder getSyncContextBinder()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.IBinder>(this, global::android.content.SyncContext.staticClass, "getSyncContextBinder", "()Landroid/os/IBinder;", ref global::android.content.SyncContext._m1) as android.os.IBinder;
		}
		static SyncContext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.SyncContext.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/SyncContext"));
		}
		internal static void InitJNI()
		{
		}
	}
}
