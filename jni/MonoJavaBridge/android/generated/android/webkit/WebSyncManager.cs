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
		internal static global::net.sf.jni4net.jni.MethodId _run10208;
		public virtual void run() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSyncManager._run10208);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSyncManager.staticClass, global::android.webkit.WebSyncManager._run10208);
		}
		internal static global::net.sf.jni4net.jni.MethodId _sync10209;
		public virtual void sync() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSyncManager._sync10209);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSyncManager.staticClass, global::android.webkit.WebSyncManager._sync10209);
		}
		internal static global::net.sf.jni4net.jni.MethodId _startSync10210;
		public virtual void startSync() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSyncManager._startSync10210);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSyncManager.staticClass, global::android.webkit.WebSyncManager._startSync10210);
		}
		internal static global::net.sf.jni4net.jni.MethodId _resetSync10211;
		public virtual void resetSync() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSyncManager._resetSync10211);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSyncManager.staticClass, global::android.webkit.WebSyncManager._resetSync10211);
		}
		internal static global::net.sf.jni4net.jni.MethodId _stopSync10212;
		public virtual void stopSync() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSyncManager._stopSync10212);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSyncManager.staticClass, global::android.webkit.WebSyncManager._stopSync10212);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSyncInit10213;
		protected virtual void onSyncInit() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebSyncManager._onSyncInit10213);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebSyncManager.staticClass, global::android.webkit.WebSyncManager._onSyncInit10213);
		}
		internal static global::net.sf.jni4net.jni.MethodId _WebSyncManager10214;
		protected WebSyncManager(android.content.Context arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.webkit.WebSyncManager.staticClass, global::android.webkit.WebSyncManager._WebSyncManager10214, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.webkit.WebSyncManager.staticClass = @__class;
			global::android.webkit.WebSyncManager._run10208 = @__env.GetMethodID(global::android.webkit.WebSyncManager.staticClass, "run", "()V");
			global::android.webkit.WebSyncManager._sync10209 = @__env.GetMethodID(global::android.webkit.WebSyncManager.staticClass, "sync", "()V");
			global::android.webkit.WebSyncManager._startSync10210 = @__env.GetMethodID(global::android.webkit.WebSyncManager.staticClass, "startSync", "()V");
			global::android.webkit.WebSyncManager._resetSync10211 = @__env.GetMethodID(global::android.webkit.WebSyncManager.staticClass, "resetSync", "()V");
			global::android.webkit.WebSyncManager._stopSync10212 = @__env.GetMethodID(global::android.webkit.WebSyncManager.staticClass, "stopSync", "()V");
			global::android.webkit.WebSyncManager._onSyncInit10213 = @__env.GetMethodID(global::android.webkit.WebSyncManager.staticClass, "onSyncInit", "()V");
			global::android.webkit.WebSyncManager._WebSyncManager10214 = @__env.GetMethodID(global::android.webkit.WebSyncManager.staticClass, "<init>", "(Landroid/content/Context;Ljava/lang/String;)V");
		}
	}
}
