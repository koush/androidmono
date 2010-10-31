namespace android.view
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.SurfaceHolder_Callback_))]
	public partial interface SurfaceHolder_Callback  : global::MonoJavaBridge.IJavaObject 
	{
		void surfaceCreated(android.view.SurfaceHolder arg0);
		void surfaceDestroyed(android.view.SurfaceHolder arg0);
		void surfaceChanged(android.view.SurfaceHolder arg0, int arg1, int arg2, int arg3);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.SurfaceHolder_Callback))]
	internal sealed partial class SurfaceHolder_Callback_ : java.lang.Object, SurfaceHolder_Callback
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SurfaceHolder_Callback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void android.view.SurfaceHolder_Callback.surfaceCreated(android.view.SurfaceHolder arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.SurfaceHolder_Callback_.staticClass, "surfaceCreated", "(Landroid/view/SurfaceHolder;)V", ref global::android.view.SurfaceHolder_Callback_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void android.view.SurfaceHolder_Callback.surfaceDestroyed(android.view.SurfaceHolder arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.SurfaceHolder_Callback_.staticClass, "surfaceDestroyed", "(Landroid/view/SurfaceHolder;)V", ref global::android.view.SurfaceHolder_Callback_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void android.view.SurfaceHolder_Callback.surfaceChanged(android.view.SurfaceHolder arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.SurfaceHolder_Callback_.staticClass, "surfaceChanged", "(Landroid/view/SurfaceHolder;III)V", ref global::android.view.SurfaceHolder_Callback_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		static SurfaceHolder_Callback_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.SurfaceHolder_Callback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/SurfaceHolder$Callback"));
		}
	}
}
