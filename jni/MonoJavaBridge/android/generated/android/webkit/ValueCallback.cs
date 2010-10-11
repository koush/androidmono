namespace android.webkit
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.webkit.ValueCallback_))]
	public interface ValueCallback  : global::MonoJavaBridge.IJavaObject 
	{
		void onReceiveValue(java.lang.Object arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.webkit.ValueCallback))]
	public sealed partial class ValueCallback_ : java.lang.Object, ValueCallback
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ValueCallback_()
		{
			InitJNI();
		}
		internal ValueCallback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onReceiveValue10389;
		 void android.webkit.ValueCallback.onReceiveValue(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.ValueCallback_._onReceiveValue10389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.ValueCallback_.staticClass, global::android.webkit.ValueCallback_._onReceiveValue10389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.ValueCallback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/ValueCallback"));
			global::android.webkit.ValueCallback_._onReceiveValue10389 = @__env.GetMethodIDNoThrow(global::android.webkit.ValueCallback_.staticClass, "onReceiveValue", "(Ljava/lang/Object;)V");
		}
	}
}
