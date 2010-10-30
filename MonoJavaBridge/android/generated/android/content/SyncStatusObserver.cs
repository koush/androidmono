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
		internal SyncStatusObserver_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onStatusChanged3588;
		void android.content.SyncStatusObserver.onStatusChanged(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.SyncStatusObserver_.staticClass, "onStatusChanged", "(I)V", ref global::android.content.SyncStatusObserver_._onStatusChanged3588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static SyncStatusObserver_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.SyncStatusObserver_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/SyncStatusObserver"));
		}
		internal static void InitJNI()
		{
		}
	}

	public delegate void SyncStatusObserverDelegate(int arg0);

	internal partial class SyncStatusObserverDelegateWrapper : java.lang.Object, SyncStatusObserver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SyncStatusObserverDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SyncStatusObserverDelegateWrapper3589;
		public SyncStatusObserverDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.SyncStatusObserverDelegateWrapper._SyncStatusObserverDelegateWrapper3589.native == global::System.IntPtr.Zero)
				global::android.content.SyncStatusObserverDelegateWrapper._SyncStatusObserverDelegateWrapper3589 = @__env.GetMethodIDNoThrow(global::android.content.SyncStatusObserverDelegateWrapper.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.SyncStatusObserverDelegateWrapper.staticClass, global::android.content.SyncStatusObserverDelegateWrapper._SyncStatusObserverDelegateWrapper3589);
			Init(@__env, handle);
		}
		static SyncStatusObserverDelegateWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.SyncStatusObserverDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/SyncStatusObserverDelegateWrapper"));
		}
		internal static void InitJNI()
		{
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
