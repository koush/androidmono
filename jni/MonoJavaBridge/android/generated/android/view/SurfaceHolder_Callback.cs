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
		static SurfaceHolder_Callback_()
		{
			InitJNI();
		}
		internal SurfaceHolder_Callback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _surfaceCreated14567;
		 void android.view.SurfaceHolder_Callback.surfaceCreated(android.view.SurfaceHolder arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceHolder_Callback_._surfaceCreated14567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceHolder_Callback_.staticClass, global::android.view.SurfaceHolder_Callback_._surfaceCreated14567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _surfaceDestroyed14568;
		 void android.view.SurfaceHolder_Callback.surfaceDestroyed(android.view.SurfaceHolder arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceHolder_Callback_._surfaceDestroyed14568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceHolder_Callback_.staticClass, global::android.view.SurfaceHolder_Callback_._surfaceDestroyed14568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _surfaceChanged14569;
		 void android.view.SurfaceHolder_Callback.surfaceChanged(android.view.SurfaceHolder arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceHolder_Callback_._surfaceChanged14569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceHolder_Callback_.staticClass, global::android.view.SurfaceHolder_Callback_._surfaceChanged14569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.SurfaceHolder_Callback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/SurfaceHolder$Callback"));
			global::android.view.SurfaceHolder_Callback_._surfaceCreated14567 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceHolder_Callback_.staticClass, "surfaceCreated", "(Landroid/view/SurfaceHolder;)V");
			global::android.view.SurfaceHolder_Callback_._surfaceDestroyed14568 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceHolder_Callback_.staticClass, "surfaceDestroyed", "(Landroid/view/SurfaceHolder;)V");
			global::android.view.SurfaceHolder_Callback_._surfaceChanged14569 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceHolder_Callback_.staticClass, "surfaceChanged", "(Landroid/view/SurfaceHolder;III)V");
		}
	}
}
