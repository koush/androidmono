namespace android.webkit
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.webkit.DownloadListener_))]
	public partial interface DownloadListener  : global::MonoJavaBridge.IJavaObject 
	{
		void onDownloadStart(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, long arg4);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.webkit.DownloadListener))]
	internal sealed partial class DownloadListener_ : java.lang.Object, DownloadListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DownloadListener_()
		{
			InitJNI();
		}
		internal DownloadListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onDownloadStart16040;
		void android.webkit.DownloadListener.onDownloadStart(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, long arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.DownloadListener_._onDownloadStart16040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.DownloadListener_.staticClass, global::android.webkit.DownloadListener_._onDownloadStart16040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.DownloadListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/DownloadListener"));
			global::android.webkit.DownloadListener_._onDownloadStart16040 = @__env.GetMethodIDNoThrow(global::android.webkit.DownloadListener_.staticClass, "onDownloadStart", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;J)V");
		}
	}

	public delegate void DownloadListenerDelegate(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, long arg4);

	internal partial class DownloadListenerDelegateWrapper : java.lang.Object, DownloadListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DownloadListenerDelegateWrapper()
		{
			InitJNI();
		}
		protected DownloadListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _DownloadListenerDelegateWrapper16041;
		public DownloadListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.DownloadListenerDelegateWrapper.staticClass, global::android.webkit.DownloadListenerDelegateWrapper._DownloadListenerDelegateWrapper16041);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.DownloadListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/DownloadListenerDelegateWrapper"));
			global::android.webkit.DownloadListenerDelegateWrapper._DownloadListenerDelegateWrapper16041 = @__env.GetMethodIDNoThrow(global::android.webkit.DownloadListenerDelegateWrapper.staticClass, "<init>", "()V");
		}
	}
	internal partial class DownloadListenerDelegateWrapper
	{
		private DownloadListenerDelegate myDelegate;
		public void onDownloadStart(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, long arg4)
		{
			myDelegate(arg0, arg1, arg2, arg3, arg4);
		}
		public static implicit operator DownloadListenerDelegateWrapper(DownloadListenerDelegate d)
		{
			global::android.webkit.DownloadListenerDelegateWrapper ret = new global::android.webkit.DownloadListenerDelegateWrapper();
			ret.myDelegate = d;
			global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
			return ret;
		}
	}
}
