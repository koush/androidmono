namespace android.webkit
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.webkit.DownloadListener_))]
	public interface DownloadListener  : global::MonoJavaBridge.IJavaObject 
	{
		void onDownloadStart(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, long arg4);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.webkit.DownloadListener))]
	public sealed partial class DownloadListener_ : java.lang.Object, DownloadListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DownloadListener_()
		{
			InitJNI();
		}
		internal DownloadListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onDownloadStart10311;
		 void android.webkit.DownloadListener.onDownloadStart(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, long arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.DownloadListener_._onDownloadStart10311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.DownloadListener_.staticClass, global::android.webkit.DownloadListener_._onDownloadStart10311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.DownloadListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/DownloadListener"));
			global::android.webkit.DownloadListener_._onDownloadStart10311 = @__env.GetMethodIDNoThrow(global::android.webkit.DownloadListener_.staticClass, "onDownloadStart", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;J)V");
		}
	}
}
