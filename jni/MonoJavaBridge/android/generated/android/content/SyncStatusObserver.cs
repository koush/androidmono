namespace android.content
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.content.SyncStatusObserver_))]
	public partial interface SyncStatusObserver  : global::MonoJavaBridge.IJavaObject 
	{
		void onStatusChanged(int arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.SyncStatusObserver))]
	internal sealed partial class SyncStatusObserver_ : java.lang.Object, SyncStatusObserver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SyncStatusObserver_()
		{
			InitJNI();
		}
		internal SyncStatusObserver_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onStatusChanged3588;
		void android.content.SyncStatusObserver.onStatusChanged(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.SyncStatusObserver_._onStatusChanged3588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.SyncStatusObserver_.staticClass, global::android.content.SyncStatusObserver_._onStatusChanged3588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.SyncStatusObserver_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/SyncStatusObserver"));
			global::android.content.SyncStatusObserver_._onStatusChanged3588 = @__env.GetMethodIDNoThrow(global::android.content.SyncStatusObserver_.staticClass, "onStatusChanged", "(I)V");
		}
	}

	public delegate void SyncStatusObserverDelegate(int arg0);

	internal partial class SyncStatusObserverDelegateWrapper : java.lang.Object, SyncStatusObserver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SyncStatusObserverDelegateWrapper()
		{
			InitJNI();
		}
		protected SyncStatusObserverDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SyncStatusObserverDelegateWrapper3589;
		public SyncStatusObserverDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.SyncStatusObserverDelegateWrapper.staticClass, global::android.content.SyncStatusObserverDelegateWrapper._SyncStatusObserverDelegateWrapper3589);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.SyncStatusObserverDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/SyncStatusObserverDelegateWrapper"));
			global::android.content.SyncStatusObserverDelegateWrapper._SyncStatusObserverDelegateWrapper3589 = @__env.GetMethodIDNoThrow(global::android.content.SyncStatusObserverDelegateWrapper.staticClass, "<init>", "()V");
		}
	}
	internal partial class SyncStatusObserverDelegateWrapper
	{
		private SyncStatusObserverDelegate myDelegate;
		public void onStatusChanged(int arg0)
		{
			myDelegate(arg0);
		}
		public static implicit operator SyncStatusObserverDelegateWrapper(SyncStatusObserverDelegate d)
		{
			global::android.content.SyncStatusObserverDelegateWrapper ret = new global::android.content.SyncStatusObserverDelegateWrapper();
			ret.myDelegate = d;
			global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
			return ret;
		}
	}
}
