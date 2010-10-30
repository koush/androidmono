namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.webkit.WebSyncManager_))]
	public abstract partial class WebSyncManager : java.lang.Object, java.lang.Runnable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected WebSyncManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _run16296;
		public virtual void run()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSyncManager.staticClass, "run", "()V", ref global::android.webkit.WebSyncManager._run16296);
		}
		internal static global::MonoJavaBridge.MethodId _clone16297;
		protected override global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebSyncManager.staticClass, "clone", "()Ljava/lang/Object;", ref global::android.webkit.WebSyncManager._clone16297) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _sync16298;
		public virtual void sync()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSyncManager.staticClass, "sync", "()V", ref global::android.webkit.WebSyncManager._sync16298);
		}
		internal static global::MonoJavaBridge.MethodId _startSync16299;
		public virtual void startSync()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSyncManager.staticClass, "startSync", "()V", ref global::android.webkit.WebSyncManager._startSync16299);
		}
		internal static global::MonoJavaBridge.MethodId _resetSync16300;
		public virtual void resetSync()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSyncManager.staticClass, "resetSync", "()V", ref global::android.webkit.WebSyncManager._resetSync16300);
		}
		internal static global::MonoJavaBridge.MethodId _stopSync16301;
		public virtual void stopSync()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSyncManager.staticClass, "stopSync", "()V", ref global::android.webkit.WebSyncManager._stopSync16301);
		}
		internal static global::MonoJavaBridge.MethodId _onSyncInit16302;
		protected virtual void onSyncInit()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebSyncManager.staticClass, "onSyncInit", "()V", ref global::android.webkit.WebSyncManager._onSyncInit16302);
		}
		internal static global::MonoJavaBridge.MethodId _WebSyncManager16303;
		protected WebSyncManager(android.content.Context arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.WebSyncManager._WebSyncManager16303.native == global::System.IntPtr.Zero)
				global::android.webkit.WebSyncManager._WebSyncManager16303 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSyncManager.staticClass, "<init>", "(Landroid/content/Context;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebSyncManager.staticClass, global::android.webkit.WebSyncManager._WebSyncManager16303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static WebSyncManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.WebSyncManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebSyncManager"));
		}
		internal static void InitJNI()
		{
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
		internal static void InitJNI()
		{
		}
	}
}
