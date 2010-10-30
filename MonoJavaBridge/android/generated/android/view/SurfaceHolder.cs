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
		internal static global::MonoJavaBridge.MethodId _setType14570;
		void android.view.SurfaceHolder.setType(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.SurfaceHolder_.staticClass, "setType", "(I)V", ref global::android.view.SurfaceHolder_._setType14570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFormat14571;
		void android.view.SurfaceHolder.setFormat(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.SurfaceHolder_.staticClass, "setFormat", "(I)V", ref global::android.view.SurfaceHolder_._setFormat14571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setKeepScreenOn14572;
		void android.view.SurfaceHolder.setKeepScreenOn(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.SurfaceHolder_.staticClass, "setKeepScreenOn", "(Z)V", ref global::android.view.SurfaceHolder_._setKeepScreenOn14572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addCallback14573;
		void android.view.SurfaceHolder.addCallback(android.view.SurfaceHolder_Callback arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.SurfaceHolder_.staticClass, "addCallback", "(Landroid/view/SurfaceHolder$Callback;)V", ref global::android.view.SurfaceHolder_._addCallback14573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeCallback14574;
		void android.view.SurfaceHolder.removeCallback(android.view.SurfaceHolder_Callback arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.SurfaceHolder_.staticClass, "removeCallback", "(Landroid/view/SurfaceHolder$Callback;)V", ref global::android.view.SurfaceHolder_._removeCallback14574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCreating14575;
		bool android.view.SurfaceHolder.isCreating()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.SurfaceHolder_.staticClass, "isCreating", "()Z", ref global::android.view.SurfaceHolder_._isCreating14575);
		}
		internal static global::MonoJavaBridge.MethodId _setFixedSize14576;
		void android.view.SurfaceHolder.setFixedSize(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.SurfaceHolder_.staticClass, "setFixedSize", "(II)V", ref global::android.view.SurfaceHolder_._setFixedSize14576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setSizeFromLayout14577;
		void android.view.SurfaceHolder.setSizeFromLayout()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.SurfaceHolder_.staticClass, "setSizeFromLayout", "()V", ref global::android.view.SurfaceHolder_._setSizeFromLayout14577);
		}
		internal static global::MonoJavaBridge.MethodId _lockCanvas14578;
		global::android.graphics.Canvas android.view.SurfaceHolder.lockCanvas()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.SurfaceHolder_.staticClass, "lockCanvas", "()Landroid/graphics/Canvas;", ref global::android.view.SurfaceHolder_._lockCanvas14578) as android.graphics.Canvas;
		}
		internal static global::MonoJavaBridge.MethodId _lockCanvas14579;
		global::android.graphics.Canvas android.view.SurfaceHolder.lockCanvas(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.SurfaceHolder_.staticClass, "lockCanvas", "(Landroid/graphics/Rect;)Landroid/graphics/Canvas;", ref global::android.view.SurfaceHolder_._lockCanvas14579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.Canvas;
		}
		internal static global::MonoJavaBridge.MethodId _unlockCanvasAndPost14580;
		void android.view.SurfaceHolder.unlockCanvasAndPost(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.SurfaceHolder_.staticClass, "unlockCanvasAndPost", "(Landroid/graphics/Canvas;)V", ref global::android.view.SurfaceHolder_._unlockCanvasAndPost14580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSurfaceFrame14581;
		global::android.graphics.Rect android.view.SurfaceHolder.getSurfaceFrame()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.graphics.Rect>(this, global::android.view.SurfaceHolder_.staticClass, "getSurfaceFrame", "()Landroid/graphics/Rect;", ref global::android.view.SurfaceHolder_._getSurfaceFrame14581) as android.graphics.Rect;
		}
		internal static global::MonoJavaBridge.MethodId _getSurface14582;
		global::android.view.Surface android.view.SurfaceHolder.getSurface()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.SurfaceHolder_.staticClass, "getSurface", "()Landroid/view/Surface;", ref global::android.view.SurfaceHolder_._getSurface14582) as android.view.Surface;
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
