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
		internal static global::net.sf.jni4net.jni.MethodId _getContext1039;
		public virtual global::android.content.Context getContext() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.AbstractThreadedSyncAdapter._getContext1039));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.AbstractThreadedSyncAdapter.staticClass, global::android.content.AbstractThreadedSyncAdapter._getContext1039));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSyncAdapterBinder1040;
		public virtual global::android.os.IBinder getSyncAdapterBinder() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.AbstractThreadedSyncAdapter._getSyncAdapterBinder1040));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.AbstractThreadedSyncAdapter.staticClass, global::android.content.AbstractThreadedSyncAdapter._getSyncAdapterBinder1040));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onPerformSync1041;
		public abstract void onPerformSync(android.accounts.Account arg0, android.os.Bundle arg1, java.lang.String arg2, android.content.ContentProviderClient arg3, android.content.SyncResult arg4);
		internal static global::net.sf.jni4net.jni.MethodId _onSyncCanceled1042;
		public virtual void onSyncCanceled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.AbstractThreadedSyncAdapter._onSyncCanceled1042);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.AbstractThreadedSyncAdapter.staticClass, global::android.content.AbstractThreadedSyncAdapter._onSyncCanceled1042);
		}
		internal static global::net.sf.jni4net.jni.MethodId _AbstractThreadedSyncAdapter1043;
		public AbstractThreadedSyncAdapter(android.content.Context arg0, bool arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.AbstractThreadedSyncAdapter.staticClass, global::android.content.AbstractThreadedSyncAdapter._AbstractThreadedSyncAdapter1043, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
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
			global::android.content.AbstractThreadedSyncAdapter._getContext1039 = @__env.GetMethodID(global::android.content.AbstractThreadedSyncAdapter.staticClass, "getContext", "()Landroid/content/Context;");
			global::android.content.AbstractThreadedSyncAdapter._getSyncAdapterBinder1040 = @__env.GetMethodID(global::android.content.AbstractThreadedSyncAdapter.staticClass, "getSyncAdapterBinder", "()Landroid/os/IBinder;");
			global::android.content.AbstractThreadedSyncAdapter._onPerformSync1041 = @__env.GetMethodID(global::android.content.AbstractThreadedSyncAdapter.staticClass, "onPerformSync", "(Landroid/accounts/Account;Landroid/os/Bundle;Ljava/lang/String;Landroid/content/ContentProviderClient;Landroid/content/SyncResult;)V");
			global::android.content.AbstractThreadedSyncAdapter._onSyncCanceled1042 = @__env.GetMethodID(global::android.content.AbstractThreadedSyncAdapter.staticClass, "onSyncCanceled", "()V");
			global::android.content.AbstractThreadedSyncAdapter._AbstractThreadedSyncAdapter1043 = @__env.GetMethodID(global::android.content.AbstractThreadedSyncAdapter.staticClass, "<init>", "(Landroid/content/Context;Z)V");
		}
	}
}
