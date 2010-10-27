namespace android.webkit
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.webkit.PluginStub_))]
	public partial interface PluginStub  : global::MonoJavaBridge.IJavaObject 
	{
		global::android.view.View getEmbeddedView(int arg0, android.content.Context arg1);
		global::android.view.View getFullScreenView(int arg0, android.content.Context arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.webkit.PluginStub))]
	internal sealed partial class PluginStub_ : java.lang.Object, PluginStub
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PluginStub_()
		{
			InitJNI();
		}
		internal PluginStub_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getEmbeddedView16090;
		global::android.view.View android.webkit.PluginStub.getEmbeddedView(int arg0, android.content.Context arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.PluginStub_._getEmbeddedView16090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.PluginStub_.staticClass, global::android.webkit.PluginStub_._getEmbeddedView16090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getFullScreenView16091;
		global::android.view.View android.webkit.PluginStub.getFullScreenView(int arg0, android.content.Context arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.PluginStub_._getFullScreenView16091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.PluginStub_.staticClass, global::android.webkit.PluginStub_._getFullScreenView16091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.PluginStub_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/PluginStub"));
			global::android.webkit.PluginStub_._getEmbeddedView16090 = @__env.GetMethodIDNoThrow(global::android.webkit.PluginStub_.staticClass, "getEmbeddedView", "(ILandroid/content/Context;)Landroid/view/View;");
			global::android.webkit.PluginStub_._getFullScreenView16091 = @__env.GetMethodIDNoThrow(global::android.webkit.PluginStub_.staticClass, "getFullScreenView", "(ILandroid/content/Context;)Landroid/view/View;");
		}
	}
}
