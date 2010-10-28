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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceHolder_._setType14570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceHolder_.staticClass, global::android.view.SurfaceHolder_._setType14570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFormat14571;
		void android.view.SurfaceHolder.setFormat(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceHolder_._setFormat14571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceHolder_.staticClass, global::android.view.SurfaceHolder_._setFormat14571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setKeepScreenOn14572;
		void android.view.SurfaceHolder.setKeepScreenOn(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceHolder_._setKeepScreenOn14572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceHolder_.staticClass, global::android.view.SurfaceHolder_._setKeepScreenOn14572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addCallback14573;
		void android.view.SurfaceHolder.addCallback(android.view.SurfaceHolder_Callback arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceHolder_._addCallback14573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceHolder_.staticClass, global::android.view.SurfaceHolder_._addCallback14573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeCallback14574;
		void android.view.SurfaceHolder.removeCallback(android.view.SurfaceHolder_Callback arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceHolder_._removeCallback14574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceHolder_.staticClass, global::android.view.SurfaceHolder_._removeCallback14574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCreating14575;
		bool android.view.SurfaceHolder.isCreating()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.SurfaceHolder_._isCreating14575);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.SurfaceHolder_.staticClass, global::android.view.SurfaceHolder_._isCreating14575);
		}
		internal static global::MonoJavaBridge.MethodId _setFixedSize14576;
		void android.view.SurfaceHolder.setFixedSize(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceHolder_._setFixedSize14576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceHolder_.staticClass, global::android.view.SurfaceHolder_._setFixedSize14576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setSizeFromLayout14577;
		void android.view.SurfaceHolder.setSizeFromLayout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceHolder_._setSizeFromLayout14577);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceHolder_.staticClass, global::android.view.SurfaceHolder_._setSizeFromLayout14577);
		}
		internal static global::MonoJavaBridge.MethodId _lockCanvas14578;
		global::android.graphics.Canvas android.view.SurfaceHolder.lockCanvas()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SurfaceHolder_._lockCanvas14578)) as android.graphics.Canvas;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SurfaceHolder_.staticClass, global::android.view.SurfaceHolder_._lockCanvas14578)) as android.graphics.Canvas;
		}
		internal static global::MonoJavaBridge.MethodId _lockCanvas14579;
		global::android.graphics.Canvas android.view.SurfaceHolder.lockCanvas(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SurfaceHolder_._lockCanvas14579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Canvas;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SurfaceHolder_.staticClass, global::android.view.SurfaceHolder_._lockCanvas14579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Canvas;
		}
		internal static global::MonoJavaBridge.MethodId _unlockCanvasAndPost14580;
		void android.view.SurfaceHolder.unlockCanvasAndPost(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceHolder_._unlockCanvasAndPost14580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceHolder_.staticClass, global::android.view.SurfaceHolder_._unlockCanvasAndPost14580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSurfaceFrame14581;
		global::android.graphics.Rect android.view.SurfaceHolder.getSurfaceFrame()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Rect>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SurfaceHolder_._getSurfaceFrame14581)) as android.graphics.Rect;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Rect>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SurfaceHolder_.staticClass, global::android.view.SurfaceHolder_._getSurfaceFrame14581)) as android.graphics.Rect;
		}
		internal static global::MonoJavaBridge.MethodId _getSurface14582;
		global::android.view.Surface android.view.SurfaceHolder.getSurface()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SurfaceHolder_._getSurface14582)) as android.view.Surface;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SurfaceHolder_.staticClass, global::android.view.SurfaceHolder_._getSurface14582)) as android.view.Surface;
		}
		static SurfaceHolder_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.SurfaceHolder_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/SurfaceHolder"));
			global::android.view.SurfaceHolder_._setType14570 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceHolder_.staticClass, "setType", "(I)V");
			global::android.view.SurfaceHolder_._setFormat14571 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceHolder_.staticClass, "setFormat", "(I)V");
			global::android.view.SurfaceHolder_._setKeepScreenOn14572 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceHolder_.staticClass, "setKeepScreenOn", "(Z)V");
			global::android.view.SurfaceHolder_._addCallback14573 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceHolder_.staticClass, "addCallback", "(Landroid/view/SurfaceHolder$Callback;)V");
			global::android.view.SurfaceHolder_._removeCallback14574 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceHolder_.staticClass, "removeCallback", "(Landroid/view/SurfaceHolder$Callback;)V");
			global::android.view.SurfaceHolder_._isCreating14575 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceHolder_.staticClass, "isCreating", "()Z");
			global::android.view.SurfaceHolder_._setFixedSize14576 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceHolder_.staticClass, "setFixedSize", "(II)V");
			global::android.view.SurfaceHolder_._setSizeFromLayout14577 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceHolder_.staticClass, "setSizeFromLayout", "()V");
			global::android.view.SurfaceHolder_._lockCanvas14578 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceHolder_.staticClass, "lockCanvas", "()Landroid/graphics/Canvas;");
			global::android.view.SurfaceHolder_._lockCanvas14579 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceHolder_.staticClass, "lockCanvas", "(Landroid/graphics/Rect;)Landroid/graphics/Canvas;");
			global::android.view.SurfaceHolder_._unlockCanvasAndPost14580 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceHolder_.staticClass, "unlockCanvasAndPost", "(Landroid/graphics/Canvas;)V");
			global::android.view.SurfaceHolder_._getSurfaceFrame14581 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceHolder_.staticClass, "getSurfaceFrame", "()Landroid/graphics/Rect;");
			global::android.view.SurfaceHolder_._getSurface14582 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceHolder_.staticClass, "getSurface", "()Landroid/view/Surface;");
		}
		internal static void InitJNI()
		{
		}
	}
}
