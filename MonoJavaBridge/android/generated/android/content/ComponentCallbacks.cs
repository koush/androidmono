namespace android.content
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.content.ComponentCallbacks_))]
	public partial interface ComponentCallbacks  : global::MonoJavaBridge.IJavaObject 
	{
		void onConfigurationChanged(android.content.res.Configuration arg0);
		void onLowMemory();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.ComponentCallbacks))]
	internal sealed partial class ComponentCallbacks_ : java.lang.Object, ComponentCallbacks
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ComponentCallbacks_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onConfigurationChanged2609;
		void android.content.ComponentCallbacks.onConfigurationChanged(android.content.res.Configuration arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ComponentCallbacks_._onConfigurationChanged2609.native == global::System.IntPtr.Zero)
				global::android.content.ComponentCallbacks_._onConfigurationChanged2609 = @__env.GetMethodIDNoThrow(global::android.content.ComponentCallbacks_.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.content.ComponentCallbacks_._onConfigurationChanged2609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLowMemory2610;
		void android.content.ComponentCallbacks.onLowMemory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ComponentCallbacks_._onLowMemory2610.native == global::System.IntPtr.Zero)
				global::android.content.ComponentCallbacks_._onLowMemory2610 = @__env.GetMethodIDNoThrow(global::android.content.ComponentCallbacks_.staticClass, "onLowMemory", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.content.ComponentCallbacks_._onLowMemory2610);
		}
		static ComponentCallbacks_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ComponentCallbacks_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ComponentCallbacks"));
		}
		internal static void InitJNI()
		{
		}
	}
}
