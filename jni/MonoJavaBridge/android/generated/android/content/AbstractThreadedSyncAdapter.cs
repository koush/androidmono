namespace android.content
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.content.AbstractThreadedSyncAdapter_))]
	public abstract partial class AbstractThreadedSyncAdapter : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractThreadedSyncAdapter()
		{
			InitJNI();
		}
		protected AbstractThreadedSyncAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getContext1054;
		public virtual global::android.content.Context getContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.AbstractThreadedSyncAdapter._getContext1054)) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.AbstractThreadedSyncAdapter.staticClass, global::android.content.AbstractThreadedSyncAdapter._getContext1054)) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _getSyncAdapterBinder1055;
		public virtual global::android.os.IBinder getSyncAdapterBinder() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.AbstractThreadedSyncAdapter._getSyncAdapterBinder1055)) as android.os.IBinder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.AbstractThreadedSyncAdapter.staticClass, global::android.content.AbstractThreadedSyncAdapter._getSyncAdapterBinder1055)) as android.os.IBinder;
		}
		internal static global::MonoJavaBridge.MethodId _onPerformSync1056;
		public abstract void onPerformSync(android.accounts.Account arg0, android.os.Bundle arg1, java.lang.String arg2, android.content.ContentProviderClient arg3, android.content.SyncResult arg4);
		internal static global::MonoJavaBridge.MethodId _onSyncCanceled1057;
		public virtual void onSyncCanceled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.AbstractThreadedSyncAdapter._onSyncCanceled1057);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.AbstractThreadedSyncAdapter.staticClass, global::android.content.AbstractThreadedSyncAdapter._onSyncCanceled1057);
		}
		internal static global::MonoJavaBridge.MethodId _AbstractThreadedSyncAdapter1058;
		public AbstractThreadedSyncAdapter(android.content.Context arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.AbstractThreadedSyncAdapter.staticClass, global::android.content.AbstractThreadedSyncAdapter._AbstractThreadedSyncAdapter1058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static int LOG_SYNC_DETAILS
		{
			get
			{
				return 2743;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.AbstractThreadedSyncAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/AbstractThreadedSyncAdapter"));
			global::android.content.AbstractThreadedSyncAdapter._getContext1054 = @__env.GetMethodIDNoThrow(global::android.content.AbstractThreadedSyncAdapter.staticClass, "getContext", "()Landroid/content/Context;");
			global::android.content.AbstractThreadedSyncAdapter._getSyncAdapterBinder1055 = @__env.GetMethodIDNoThrow(global::android.content.AbstractThreadedSyncAdapter.staticClass, "getSyncAdapterBinder", "()Landroid/os/IBinder;");
			global::android.content.AbstractThreadedSyncAdapter._onPerformSync1056 = @__env.GetMethodIDNoThrow(global::android.content.AbstractThreadedSyncAdapter.staticClass, "onPerformSync", "(Landroid/accounts/Account;Landroid/os/Bundle;Ljava/lang/String;Landroid/content/ContentProviderClient;Landroid/content/SyncResult;)V");
			global::android.content.AbstractThreadedSyncAdapter._onSyncCanceled1057 = @__env.GetMethodIDNoThrow(global::android.content.AbstractThreadedSyncAdapter.staticClass, "onSyncCanceled", "()V");
			global::android.content.AbstractThreadedSyncAdapter._AbstractThreadedSyncAdapter1058 = @__env.GetMethodIDNoThrow(global::android.content.AbstractThreadedSyncAdapter.staticClass, "<init>", "(Landroid/content/Context;Z)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.AbstractThreadedSyncAdapter))]
	public sealed partial class AbstractThreadedSyncAdapter_ : android.content.AbstractThreadedSyncAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractThreadedSyncAdapter_()
		{
			InitJNI();
		}
		internal AbstractThreadedSyncAdapter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onPerformSync1059;
		public override void onPerformSync(android.accounts.Account arg0, android.os.Bundle arg1, java.lang.String arg2, android.content.ContentProviderClient arg3, android.content.SyncResult arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.AbstractThreadedSyncAdapter_._onPerformSync1059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.AbstractThreadedSyncAdapter_.staticClass, global::android.content.AbstractThreadedSyncAdapter_._onPerformSync1059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.AbstractThreadedSyncAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/AbstractThreadedSyncAdapter"));
			global::android.content.AbstractThreadedSyncAdapter_._onPerformSync1059 = @__env.GetMethodIDNoThrow(global::android.content.AbstractThreadedSyncAdapter_.staticClass, "onPerformSync", "(Landroid/accounts/Account;Landroid/os/Bundle;Ljava/lang/String;Landroid/content/ContentProviderClient;Landroid/content/SyncResult;)V");
		}
	}
}
