namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.webkit.WebSyncManager_))]
	public abstract partial class WebSyncManager : java.lang.Object, java.lang.Runnable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected WebSyncManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void run()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSyncManager.staticClass, "run", "()V", ref global::android.webkit.WebSyncManager._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebSyncManager.staticClass, "clone", "()Ljava/lang/Object;", ref global::android.webkit.WebSyncManager._m1) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void sync()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSyncManager.staticClass, "sync", "()V", ref global::android.webkit.WebSyncManager._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void startSync()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSyncManager.staticClass, "startSync", "()V", ref global::android.webkit.WebSyncManager._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void resetSync()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSyncManager.staticClass, "resetSync", "()V", ref global::android.webkit.WebSyncManager._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void stopSync()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSyncManager.staticClass, "stopSync", "()V", ref global::android.webkit.WebSyncManager._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected virtual void onSyncInit()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSyncManager.staticClass, "onSyncInit", "()V", ref global::android.webkit.WebSyncManager._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected WebSyncManager(android.content.Context arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.WebSyncManager._m7.native == global::System.IntPtr.Zero)
				global::android.webkit.WebSyncManager._m7 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSyncManager.staticClass, "<init>", "(Landroid/content/Context;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebSyncManager.staticClass, global::android.webkit.WebSyncManager._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static WebSyncManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.WebSyncManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebSyncManager"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.webkit.WebSyncManager))]
	internal sealed partial class WebSyncManager_ : android.webkit.WebSyncManager
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal WebSyncManager_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static WebSyncManager_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.WebSyncManager_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebSyncManager"));
		}
	}
}
