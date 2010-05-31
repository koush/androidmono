namespace android.content
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class AbstractThreadedSyncAdapter : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static AbstractThreadedSyncAdapter()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.AbstractThreadedSyncAdapter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected AbstractThreadedSyncAdapter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getContext909;
		public virtual global::android.content.Context getContext() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.AbstractThreadedSyncAdapter._getContext909));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.AbstractThreadedSyncAdapter.staticClass, global::android.content.AbstractThreadedSyncAdapter._getContext909));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSyncAdapterBinder910;
		public virtual global::android.os.IBinder getSyncAdapterBinder() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.AbstractThreadedSyncAdapter._getSyncAdapterBinder910));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.AbstractThreadedSyncAdapter.staticClass, global::android.content.AbstractThreadedSyncAdapter._getSyncAdapterBinder910));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onPerformSync911;
		public abstract void onPerformSync(android.accounts.Account arg0, android.os.Bundle arg1, java.lang.String arg2, android.content.ContentProviderClient arg3, android.content.SyncResult arg4);
		internal static global::net.sf.jni4net.jni.MethodId _AbstractThreadedSyncAdapter912;
		public AbstractThreadedSyncAdapter(android.content.Context arg0, bool arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.AbstractThreadedSyncAdapter.staticClass, global::android.content.AbstractThreadedSyncAdapter._AbstractThreadedSyncAdapter912, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
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
			global::android.content.AbstractThreadedSyncAdapter._getContext909 = @__env.GetMethodID(global::android.content.AbstractThreadedSyncAdapter.staticClass, "getContext", "()Landroid/content/Context;");
			global::android.content.AbstractThreadedSyncAdapter._getSyncAdapterBinder910 = @__env.GetMethodID(global::android.content.AbstractThreadedSyncAdapter.staticClass, "getSyncAdapterBinder", "()Landroid/os/IBinder;");
			global::android.content.AbstractThreadedSyncAdapter._onPerformSync911 = @__env.GetMethodID(global::android.content.AbstractThreadedSyncAdapter.staticClass, "onPerformSync", "(Landroid/accounts/Account;Landroid/os/Bundle;Ljava/lang/String;Landroid/content/ContentProviderClient;Landroid/content/SyncResult;)V");
			global::android.content.AbstractThreadedSyncAdapter._AbstractThreadedSyncAdapter912 = @__env.GetMethodID(global::android.content.AbstractThreadedSyncAdapter.staticClass, "<init>", "(Landroid/content/Context;Z)V");
		}
	}
}
