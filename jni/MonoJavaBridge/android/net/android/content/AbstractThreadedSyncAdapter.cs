namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class AbstractThreadedSyncAdapter : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static AbstractThreadedSyncAdapter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.AbstractThreadedSyncAdapter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected AbstractThreadedSyncAdapter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContext896; 
		public virtual android.content.Context getContext() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.AbstractThreadedSyncAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, _getContext896)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.AbstractThreadedSyncAdapter.staticClass, _getContext896)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSyncAdapterBinder897; 
		public virtual android.os.IBinder getSyncAdapterBinder() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.AbstractThreadedSyncAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallObjectMethodPtr(this, _getSyncAdapterBinder897)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.AbstractThreadedSyncAdapter.staticClass, _getSyncAdapterBinder897)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPerformSync898; 
		public abstract void onPerformSync(android.accounts.Account arg0, android.os.Bundle arg1, java.lang.String arg2, android.content.ContentProviderClient arg3, android.content.SyncResult arg4); 
		internal static global::net.sf.jni4net.jni.MethodId _AbstractThreadedSyncAdapter899; 
		public AbstractThreadedSyncAdapter(android.content.Context arg0, bool arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.AbstractThreadedSyncAdapter.staticClass, _AbstractThreadedSyncAdapter899, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		public static int LOG_SYNC_DETAILS
		{ 
			get 
			{ 
				return 2743; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.AbstractThreadedSyncAdapter.staticClass = @__class; 
			global::android.content.AbstractThreadedSyncAdapter._getContext896 = @__env.GetMethodID(global::android.content.AbstractThreadedSyncAdapter.staticClass, "getContext", "()Landroid/content/Context;"); 
			global::android.content.AbstractThreadedSyncAdapter._getSyncAdapterBinder897 = @__env.GetMethodID(global::android.content.AbstractThreadedSyncAdapter.staticClass, "getSyncAdapterBinder", "()Landroid/os/IBinder;"); 
			global::android.content.AbstractThreadedSyncAdapter._onPerformSync898 = @__env.GetMethodID(global::android.content.AbstractThreadedSyncAdapter.staticClass, "onPerformSync", "(Landroid/accounts/Account;Landroid/os/Bundle;Ljava/lang/String;Landroid/content/ContentProviderClient;Landroid/content/SyncResult;)V"); 
			global::android.content.AbstractThreadedSyncAdapter._AbstractThreadedSyncAdapter899 = @__env.GetMethodID(global::android.content.AbstractThreadedSyncAdapter.staticClass, "<init>", "(Landroid/content/Context;Z)V"); 
		} 
	} 
} 
