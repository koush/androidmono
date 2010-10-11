namespace android.content
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.content.SyncStatusObserver_))]
	public interface SyncStatusObserver  : global::MonoJavaBridge.IJavaObject 
	{
		void onStatusChanged(int arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.SyncStatusObserver))]
	public sealed partial class SyncStatusObserver_ : java.lang.Object, SyncStatusObserver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SyncStatusObserver_()
		{
			InitJNI();
		}
		internal SyncStatusObserver_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onStatusChanged1832;
		 void android.content.SyncStatusObserver.onStatusChanged(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.SyncStatusObserver_._onStatusChanged1832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.SyncStatusObserver_.staticClass, global::android.content.SyncStatusObserver_._onStatusChanged1832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.SyncStatusObserver_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/SyncStatusObserver"));
			global::android.content.SyncStatusObserver_._onStatusChanged1832 = @__env.GetMethodIDNoThrow(global::android.content.SyncStatusObserver_.staticClass, "onStatusChanged", "(I)V");
		}
	}
}
