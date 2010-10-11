namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SyncContext : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SyncContext()
		{
			InitJNI();
		}
		protected SyncContext(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onFinished1790;
		public virtual void onFinished(android.content.SyncResult arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.SyncContext._onFinished1790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.SyncContext.staticClass, global::android.content.SyncContext._onFinished1790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSyncContextBinder1791;
		public virtual global::android.os.IBinder getSyncContextBinder() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.SyncContext._getSyncContextBinder1791)) as android.os.IBinder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.SyncContext.staticClass, global::android.content.SyncContext._getSyncContextBinder1791)) as android.os.IBinder;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.SyncContext.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/SyncContext"));
			global::android.content.SyncContext._onFinished1790 = @__env.GetMethodIDNoThrow(global::android.content.SyncContext.staticClass, "onFinished", "(Landroid/content/SyncResult;)V");
			global::android.content.SyncContext._getSyncContextBinder1791 = @__env.GetMethodIDNoThrow(global::android.content.SyncContext.staticClass, "getSyncContextBinder", "()Landroid/os/IBinder;");
		}
	}
}
