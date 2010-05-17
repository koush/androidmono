namespace android.webkit 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class WebSyncManager : java.lang.Object, java.lang.Runnable
	{ 
		internal static global::java.lang.Class staticClass; 
		static WebSyncManager() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.webkit.WebSyncManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected WebSyncManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _run8826; 
		public virtual void run() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSyncManager)) 
				@__env.CallVoidMethod(this, _run8826); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSyncManager.staticClass, _run8826); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sync8827; 
		public virtual void sync() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSyncManager)) 
				@__env.CallVoidMethod(this, _sync8827); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSyncManager.staticClass, _sync8827); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startSync8828; 
		public virtual void startSync() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSyncManager)) 
				@__env.CallVoidMethod(this, _startSync8828); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSyncManager.staticClass, _startSync8828); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resetSync8829; 
		public virtual void resetSync() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSyncManager)) 
				@__env.CallVoidMethod(this, _resetSync8829); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSyncManager.staticClass, _resetSync8829); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stopSync8830; 
		public virtual void stopSync() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSyncManager)) 
				@__env.CallVoidMethod(this, _stopSync8830); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSyncManager.staticClass, _stopSync8830); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSyncInit8831; 
		protected virtual void onSyncInit() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebSyncManager)) 
				@__env.CallVoidMethod(this, _onSyncInit8831); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebSyncManager.staticClass, _onSyncInit8831); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _WebSyncManager8832; 
		protected WebSyncManager(android.content.Context arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.webkit.WebSyncManager.staticClass, _WebSyncManager8832, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.webkit.WebSyncManager.staticClass = @__class; 
			global::android.webkit.WebSyncManager._run8826 = @__env.GetMethodID(global::android.webkit.WebSyncManager.staticClass, "run", "()V"); 
			global::android.webkit.WebSyncManager._sync8827 = @__env.GetMethodID(global::android.webkit.WebSyncManager.staticClass, "sync", "()V"); 
			global::android.webkit.WebSyncManager._startSync8828 = @__env.GetMethodID(global::android.webkit.WebSyncManager.staticClass, "startSync", "()V"); 
			global::android.webkit.WebSyncManager._resetSync8829 = @__env.GetMethodID(global::android.webkit.WebSyncManager.staticClass, "resetSync", "()V"); 
			global::android.webkit.WebSyncManager._stopSync8830 = @__env.GetMethodID(global::android.webkit.WebSyncManager.staticClass, "stopSync", "()V"); 
			global::android.webkit.WebSyncManager._onSyncInit8831 = @__env.GetMethodID(global::android.webkit.WebSyncManager.staticClass, "onSyncInit", "()V"); 
			global::android.webkit.WebSyncManager._WebSyncManager8832 = @__env.GetMethodID(global::android.webkit.WebSyncManager.staticClass, "<init>", "(Landroid/content/Context;Ljava/lang/String;)V"); 
		} 
	} 
} 
