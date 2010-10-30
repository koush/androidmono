namespace android.view
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.SurfaceHolder_))]
	public partial interface SurfaceHolder  : global::MonoJavaBridge.IJavaObject 
	{
		void setType(int arg0);
		void setFormat(int arg0);
		void setKeepScreenOn(bool arg0);
		void addCallback(android.view.SurfaceHolder_Callback arg0);
		void removeCallback(android.view.SurfaceHolder_Callback arg0);
		bool isCreating();
		void setFixedSize(int arg0, int arg1);
		void setSizeFromLayout();
		global::android.graphics.Canvas lockCanvas();
		global::android.graphics.Canvas lockCanvas(android.graphics.Rect arg0);
		void unlockCanvasAndPost(android.graphics.Canvas arg0);
		global::android.graphics.Rect getSurfaceFrame();
		global::android.view.Surface getSurface();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.SurfaceHolder))]
	internal sealed partial class SurfaceHolder_ : java.lang.Object, SurfaceHolder
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SurfaceHolder_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void android.view.SurfaceHolder.setType(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.SurfaceHolder_.staticClass, "setType", "(I)V", ref global::android.view.SurfaceHolder_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void android.view.SurfaceHolder.setFormat(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.SurfaceHolder_.staticClass, "setFormat", "(I)V", ref global::android.view.SurfaceHolder_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void android.view.SurfaceHolder.setKeepScreenOn(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.SurfaceHolder_.staticClass, "setKeepScreenOn", "(Z)V", ref global::android.view.SurfaceHolder_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void android.view.SurfaceHolder.addCallback(android.view.SurfaceHolder_Callback arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.SurfaceHolder_.staticClass, "addCallback", "(Landroid/view/SurfaceHolder$Callback;)V", ref global::android.view.SurfaceHolder_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void android.view.SurfaceHolder.removeCallback(android.view.SurfaceHolder_Callback arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.SurfaceHolder_.staticClass, "removeCallback", "(Landroid/view/SurfaceHolder$Callback;)V", ref global::android.view.SurfaceHolder_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		bool android.view.SurfaceHolder.isCreating()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.SurfaceHolder_.staticClass, "isCreating", "()Z", ref global::android.view.SurfaceHolder_._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		void android.view.SurfaceHolder.setFixedSize(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.SurfaceHolder_.staticClass, "setFixedSize", "(II)V", ref global::android.view.SurfaceHolder_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		void android.view.SurfaceHolder.setSizeFromLayout()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.SurfaceHolder_.staticClass, "setSizeFromLayout", "()V", ref global::android.view.SurfaceHolder_._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		global::android.graphics.Canvas android.view.SurfaceHolder.lockCanvas()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.SurfaceHolder_.staticClass, "lockCanvas", "()Landroid/graphics/Canvas;", ref global::android.view.SurfaceHolder_._m8) as android.graphics.Canvas;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		global::android.graphics.Canvas android.view.SurfaceHolder.lockCanvas(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.SurfaceHolder_.staticClass, "lockCanvas", "(Landroid/graphics/Rect;)Landroid/graphics/Canvas;", ref global::android.view.SurfaceHolder_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.Canvas;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		void android.view.SurfaceHolder.unlockCanvasAndPost(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.SurfaceHolder_.staticClass, "unlockCanvasAndPost", "(Landroid/graphics/Canvas;)V", ref global::android.view.SurfaceHolder_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		global::android.graphics.Rect android.view.SurfaceHolder.getSurfaceFrame()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.graphics.Rect>(this, global::android.view.SurfaceHolder_.staticClass, "getSurfaceFrame", "()Landroid/graphics/Rect;", ref global::android.view.SurfaceHolder_._m11) as android.graphics.Rect;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		global::android.view.Surface android.view.SurfaceHolder.getSurface()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.SurfaceHolder_.staticClass, "getSurface", "()Landroid/view/Surface;", ref global::android.view.SurfaceHolder_._m12) as android.view.Surface;
		}
		static SurfaceHolder_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.SurfaceHolder_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/SurfaceHolder"));
		}
		internal static void InitJNI()
		{
		}
	}
}
