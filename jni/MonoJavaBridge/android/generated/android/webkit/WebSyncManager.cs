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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSyncManager._run16296);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSyncManager.staticClass, global::android.webkit.WebSyncManager._run16296);
		}
		internal static global::MonoJavaBridge.MethodId _clone16297;
		protected override global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSyncManager._clone16297)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSyncManager.staticClass, global::android.webkit.WebSyncManager._clone16297)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _sync16298;
		public virtual void sync()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSyncManager._sync16298);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSyncManager.staticClass, global::android.webkit.WebSyncManager._sync16298);
		}
		internal static global::MonoJavaBridge.MethodId _startSync16299;
		public virtual void startSync()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSyncManager._startSync16299);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSyncManager.staticClass, global::android.webkit.WebSyncManager._startSync16299);
		}
		internal static global::MonoJavaBridge.MethodId _resetSync16300;
		public virtual void resetSync()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSyncManager._resetSync16300);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSyncManager.staticClass, global::android.webkit.WebSyncManager._resetSync16300);
		}
		internal static global::MonoJavaBridge.MethodId _stopSync16301;
		public virtual void stopSync()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSyncManager._stopSync16301);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSyncManager.staticClass, global::android.webkit.WebSyncManager._stopSync16301);
		}
		internal static global::MonoJavaBridge.MethodId _onSyncInit16302;
		protected virtual void onSyncInit()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSyncManager._onSyncInit16302);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSyncManager.staticClass, global::android.webkit.WebSyncManager._onSyncInit16302);
		}
		internal static global::MonoJavaBridge.MethodId _WebSyncManager16303;
		protected WebSyncManager(android.content.Context arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebSyncManager.staticClass, global::android.webkit.WebSyncManager._WebSyncManager16303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static WebSyncManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.WebSyncManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebSyncManager"));
			global::android.webkit.WebSyncManager._run16296 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSyncManager.staticClass, "run", "()V");
			global::android.webkit.WebSyncManager._clone16297 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSyncManager.staticClass, "clone", "()Ljava/lang/Object;");
			global::android.webkit.WebSyncManager._sync16298 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSyncManager.staticClass, "sync", "()V");
			global::android.webkit.WebSyncManager._startSync16299 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSyncManager.staticClass, "startSync", "()V");
			global::android.webkit.WebSyncManager._resetSync16300 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSyncManager.staticClass, "resetSync", "()V");
			global::android.webkit.WebSyncManager._stopSync16301 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSyncManager.staticClass, "stopSync", "()V");
			global::android.webkit.WebSyncManager._onSyncInit16302 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSyncManager.staticClass, "onSyncInit", "()V");
			global::android.webkit.WebSyncManager._WebSyncManager16303 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSyncManager.staticClass, "<init>", "(Landroid/content/Context;Ljava/lang/String;)V");
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
