namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.webkit.WebSyncManager_))]
	public abstract partial class WebSyncManager : java.lang.Object, java.lang.Runnable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static WebSyncManager()
		{
			InitJNI();
		}
		protected WebSyncManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _run10555;
		public virtual void run() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSyncManager._run10555);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSyncManager.staticClass, global::android.webkit.WebSyncManager._run10555);
		}
		internal static global::MonoJavaBridge.MethodId _clone10556;
		protected override global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebSyncManager._clone10556)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebSyncManager.staticClass, global::android.webkit.WebSyncManager._clone10556)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _sync10557;
		public virtual void sync() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSyncManager._sync10557);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSyncManager.staticClass, global::android.webkit.WebSyncManager._sync10557);
		}
		internal static global::MonoJavaBridge.MethodId _startSync10558;
		public virtual void startSync() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSyncManager._startSync10558);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSyncManager.staticClass, global::android.webkit.WebSyncManager._startSync10558);
		}
		internal static global::MonoJavaBridge.MethodId _resetSync10559;
		public virtual void resetSync() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSyncManager._resetSync10559);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSyncManager.staticClass, global::android.webkit.WebSyncManager._resetSync10559);
		}
		internal static global::MonoJavaBridge.MethodId _stopSync10560;
		public virtual void stopSync() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSyncManager._stopSync10560);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSyncManager.staticClass, global::android.webkit.WebSyncManager._stopSync10560);
		}
		internal static global::MonoJavaBridge.MethodId _onSyncInit10561;
		protected virtual void onSyncInit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebSyncManager._onSyncInit10561);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebSyncManager.staticClass, global::android.webkit.WebSyncManager._onSyncInit10561);
		}
		internal static global::MonoJavaBridge.MethodId _WebSyncManager10562;
		protected WebSyncManager(android.content.Context arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebSyncManager.staticClass, global::android.webkit.WebSyncManager._WebSyncManager10562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.WebSyncManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebSyncManager"));
			global::android.webkit.WebSyncManager._run10555 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSyncManager.staticClass, "run", "()V");
			global::android.webkit.WebSyncManager._clone10556 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSyncManager.staticClass, "clone", "()Ljava/lang/Object;");
			global::android.webkit.WebSyncManager._sync10557 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSyncManager.staticClass, "sync", "()V");
			global::android.webkit.WebSyncManager._startSync10558 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSyncManager.staticClass, "startSync", "()V");
			global::android.webkit.WebSyncManager._resetSync10559 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSyncManager.staticClass, "resetSync", "()V");
			global::android.webkit.WebSyncManager._stopSync10560 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSyncManager.staticClass, "stopSync", "()V");
			global::android.webkit.WebSyncManager._onSyncInit10561 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSyncManager.staticClass, "onSyncInit", "()V");
			global::android.webkit.WebSyncManager._WebSyncManager10562 = @__env.GetMethodIDNoThrow(global::android.webkit.WebSyncManager.staticClass, "<init>", "(Landroid/content/Context;Ljava/lang/String;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.webkit.WebSyncManager))]
	public sealed partial class WebSyncManager_ : android.webkit.WebSyncManager
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static WebSyncManager_()
		{
			InitJNI();
		}
		internal WebSyncManager_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.WebSyncManager_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebSyncManager"));
		}
	}
}
