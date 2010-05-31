namespace android.webkit 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class WebSyncManager : java.lang.Object, java.lang.Runnable
	{ 
		internal static global::java.lang.Class staticClass; 
		static WebSyncManager() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.WebSyncManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected WebSyncManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _run9519; 
		public virtual void run() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.webkit.WebSyncManager._run9519); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSyncManager.staticClass, global::android.webkit.WebSyncManager._run9519); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sync9520; 
		public virtual void sync() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.webkit.WebSyncManager._sync9520); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSyncManager.staticClass, global::android.webkit.WebSyncManager._sync9520); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startSync9521; 
		public virtual void startSync() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.webkit.WebSyncManager._startSync9521); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSyncManager.staticClass, global::android.webkit.WebSyncManager._startSync9521); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resetSync9522; 
		public virtual void resetSync() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.webkit.WebSyncManager._resetSync9522); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSyncManager.staticClass, global::android.webkit.WebSyncManager._resetSync9522); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stopSync9523; 
		public virtual void stopSync() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.webkit.WebSyncManager._stopSync9523); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSyncManager.staticClass, global::android.webkit.WebSyncManager._stopSync9523); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSyncInit9524; 
		protected virtual void onSyncInit() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.webkit.WebSyncManager._onSyncInit9524); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSyncManager.staticClass, global::android.webkit.WebSyncManager._onSyncInit9524); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _WebSyncManager9525; 
		protected WebSyncManager(android.content.Context arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.webkit.WebSyncManager.staticClass, global::android.webkit.WebSyncManager._WebSyncManager9525, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.webkit.WebSyncManager.staticClass = @__class; 
			global::android.webkit.WebSyncManager._run9519 = @__env.GetMethodID(global::android.webkit.WebSyncManager.staticClass, "run", "()V"); 
			global::android.webkit.WebSyncManager._sync9520 = @__env.GetMethodID(global::android.webkit.WebSyncManager.staticClass, "sync", "()V"); 
			global::android.webkit.WebSyncManager._startSync9521 = @__env.GetMethodID(global::android.webkit.WebSyncManager.staticClass, "startSync", "()V"); 
			global::android.webkit.WebSyncManager._resetSync9522 = @__env.GetMethodID(global::android.webkit.WebSyncManager.staticClass, "resetSync", "()V"); 
			global::android.webkit.WebSyncManager._stopSync9523 = @__env.GetMethodID(global::android.webkit.WebSyncManager.staticClass, "stopSync", "()V"); 
			global::android.webkit.WebSyncManager._onSyncInit9524 = @__env.GetMethodID(global::android.webkit.WebSyncManager.staticClass, "onSyncInit", "()V"); 
			global::android.webkit.WebSyncManager._WebSyncManager9525 = @__env.GetMethodID(global::android.webkit.WebSyncManager.staticClass, "<init>", "(Landroid/content/Context;Ljava/lang/String;)V"); 
		} 
	} 
} 
