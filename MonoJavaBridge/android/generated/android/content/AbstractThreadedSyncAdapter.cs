namespace android.content
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.content.AbstractThreadedSyncAdapter_))]
	public abstract partial class AbstractThreadedSyncAdapter : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractThreadedSyncAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getContext2558;
		public virtual global::android.content.Context getContext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.AbstractThreadedSyncAdapter._getContext2558.native == global::System.IntPtr.Zero)
				global::android.content.AbstractThreadedSyncAdapter._getContext2558 = @__env.GetMethodIDNoThrow(global::android.content.AbstractThreadedSyncAdapter.staticClass, "getContext", "()Landroid/content/Context;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.AbstractThreadedSyncAdapter.staticClass, global::android.content.AbstractThreadedSyncAdapter._getContext2558) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _getSyncAdapterBinder2559;
		public virtual global::android.os.IBinder getSyncAdapterBinder()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.AbstractThreadedSyncAdapter._getSyncAdapterBinder2559.native == global::System.IntPtr.Zero)
				global::android.content.AbstractThreadedSyncAdapter._getSyncAdapterBinder2559 = @__env.GetMethodIDNoThrow(global::android.content.AbstractThreadedSyncAdapter.staticClass, "getSyncAdapterBinder", "()Landroid/os/IBinder;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.IBinder>(this, global::android.content.AbstractThreadedSyncAdapter.staticClass, global::android.content.AbstractThreadedSyncAdapter._getSyncAdapterBinder2559) as android.os.IBinder;
		}
		internal static global::MonoJavaBridge.MethodId _onPerformSync2560;
		public abstract void onPerformSync(android.accounts.Account arg0, android.os.Bundle arg1, java.lang.String arg2, android.content.ContentProviderClient arg3, android.content.SyncResult arg4);
		internal static global::MonoJavaBridge.MethodId _onSyncCanceled2561;
		public virtual void onSyncCanceled()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.AbstractThreadedSyncAdapter._onSyncCanceled2561.native == global::System.IntPtr.Zero)
				global::android.content.AbstractThreadedSyncAdapter._onSyncCanceled2561 = @__env.GetMethodIDNoThrow(global::android.content.AbstractThreadedSyncAdapter.staticClass, "onSyncCanceled", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.AbstractThreadedSyncAdapter.staticClass, global::android.content.AbstractThreadedSyncAdapter._onSyncCanceled2561);
		}
		internal static global::MonoJavaBridge.MethodId _AbstractThreadedSyncAdapter2562;
		public AbstractThreadedSyncAdapter(android.content.Context arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.AbstractThreadedSyncAdapter._AbstractThreadedSyncAdapter2562.native == global::System.IntPtr.Zero)
				global::android.content.AbstractThreadedSyncAdapter._AbstractThreadedSyncAdapter2562 = @__env.GetMethodIDNoThrow(global::android.content.AbstractThreadedSyncAdapter.staticClass, "<init>", "(Landroid/content/Context;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.AbstractThreadedSyncAdapter.staticClass, global::android.content.AbstractThreadedSyncAdapter._AbstractThreadedSyncAdapter2562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static int LOG_SYNC_DETAILS
		{
			get
			{
				return 2743;
			}
		}
		static AbstractThreadedSyncAdapter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.AbstractThreadedSyncAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/AbstractThreadedSyncAdapter"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.AbstractThreadedSyncAdapter))]
	internal sealed partial class AbstractThreadedSyncAdapter_ : android.content.AbstractThreadedSyncAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractThreadedSyncAdapter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onPerformSync2564;
		public override void onPerformSync(android.accounts.Account arg0, android.os.Bundle arg1, java.lang.String arg2, android.content.ContentProviderClient arg3, android.content.SyncResult arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.AbstractThreadedSyncAdapter_._onPerformSync2564.native == global::System.IntPtr.Zero)
				global::android.content.AbstractThreadedSyncAdapter_._onPerformSync2564 = @__env.GetMethodIDNoThrow(global::android.content.AbstractThreadedSyncAdapter_.staticClass, "onPerformSync", "(Landroid/accounts/Account;Landroid/os/Bundle;Ljava/lang/String;Landroid/content/ContentProviderClient;Landroid/content/SyncResult;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.content.AbstractThreadedSyncAdapter_._onPerformSync2564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		static AbstractThreadedSyncAdapter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.AbstractThreadedSyncAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/AbstractThreadedSyncAdapter"));
		}
		internal static void InitJNI()
		{
		}
	}
}
