namespace android.view
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.SurfaceHolder_))]
	public interface SurfaceHolder  : global::MonoJavaBridge.IJavaObject 
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
	public sealed partial class SurfaceHolder_ : java.lang.Object, SurfaceHolder
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SurfaceHolder_()
		{
			InitJNI();
		}
		internal SurfaceHolder_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setType9607;
		 void android.view.SurfaceHolder.setType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceHolder_._setType9607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceHolder_.staticClass, global::android.view.SurfaceHolder_._setType9607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFormat9608;
		 void android.view.SurfaceHolder.setFormat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceHolder_._setFormat9608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceHolder_.staticClass, global::android.view.SurfaceHolder_._setFormat9608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setKeepScreenOn9609;
		 void android.view.SurfaceHolder.setKeepScreenOn(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceHolder_._setKeepScreenOn9609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceHolder_.staticClass, global::android.view.SurfaceHolder_._setKeepScreenOn9609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addCallback9610;
		 void android.view.SurfaceHolder.addCallback(android.view.SurfaceHolder_Callback arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceHolder_._addCallback9610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceHolder_.staticClass, global::android.view.SurfaceHolder_._addCallback9610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeCallback9611;
		 void android.view.SurfaceHolder.removeCallback(android.view.SurfaceHolder_Callback arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceHolder_._removeCallback9611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceHolder_.staticClass, global::android.view.SurfaceHolder_._removeCallback9611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCreating9612;
		 bool android.view.SurfaceHolder.isCreating() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.SurfaceHolder_._isCreating9612);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.SurfaceHolder_.staticClass, global::android.view.SurfaceHolder_._isCreating9612);
		}
		internal static global::MonoJavaBridge.MethodId _setFixedSize9613;
		 void android.view.SurfaceHolder.setFixedSize(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceHolder_._setFixedSize9613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceHolder_.staticClass, global::android.view.SurfaceHolder_._setFixedSize9613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setSizeFromLayout9614;
		 void android.view.SurfaceHolder.setSizeFromLayout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceHolder_._setSizeFromLayout9614);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceHolder_.staticClass, global::android.view.SurfaceHolder_._setSizeFromLayout9614);
		}
		internal static global::MonoJavaBridge.MethodId _lockCanvas9615;
		 global::android.graphics.Canvas android.view.SurfaceHolder.lockCanvas() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SurfaceHolder_._lockCanvas9615)) as android.graphics.Canvas;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SurfaceHolder_.staticClass, global::android.view.SurfaceHolder_._lockCanvas9615)) as android.graphics.Canvas;
		}
		internal static global::MonoJavaBridge.MethodId _lockCanvas9616;
		 global::android.graphics.Canvas android.view.SurfaceHolder.lockCanvas(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SurfaceHolder_._lockCanvas9616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Canvas;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SurfaceHolder_.staticClass, global::android.view.SurfaceHolder_._lockCanvas9616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Canvas;
		}
		internal static global::MonoJavaBridge.MethodId _unlockCanvasAndPost9617;
		 void android.view.SurfaceHolder.unlockCanvasAndPost(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceHolder_._unlockCanvasAndPost9617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceHolder_.staticClass, global::android.view.SurfaceHolder_._unlockCanvasAndPost9617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSurfaceFrame9618;
		 global::android.graphics.Rect android.view.SurfaceHolder.getSurfaceFrame() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SurfaceHolder_._getSurfaceFrame9618)) as android.graphics.Rect;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SurfaceHolder_.staticClass, global::android.view.SurfaceHolder_._getSurfaceFrame9618)) as android.graphics.Rect;
		}
		internal static global::MonoJavaBridge.MethodId _getSurface9619;
		 global::android.view.Surface android.view.SurfaceHolder.getSurface() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SurfaceHolder_._getSurface9619)) as android.view.Surface;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SurfaceHolder_.staticClass, global::android.view.SurfaceHolder_._getSurface9619)) as android.view.Surface;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.SurfaceHolder_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/SurfaceHolder"));
			global::android.view.SurfaceHolder_._setType9607 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceHolder_.staticClass, "setType", "(I)V");
			global::android.view.SurfaceHolder_._setFormat9608 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceHolder_.staticClass, "setFormat", "(I)V");
			global::android.view.SurfaceHolder_._setKeepScreenOn9609 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceHolder_.staticClass, "setKeepScreenOn", "(Z)V");
			global::android.view.SurfaceHolder_._addCallback9610 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceHolder_.staticClass, "addCallback", "(Landroid/view/SurfaceHolder$Callback;)V");
			global::android.view.SurfaceHolder_._removeCallback9611 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceHolder_.staticClass, "removeCallback", "(Landroid/view/SurfaceHolder$Callback;)V");
			global::android.view.SurfaceHolder_._isCreating9612 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceHolder_.staticClass, "isCreating", "()Z");
			global::android.view.SurfaceHolder_._setFixedSize9613 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceHolder_.staticClass, "setFixedSize", "(II)V");
			global::android.view.SurfaceHolder_._setSizeFromLayout9614 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceHolder_.staticClass, "setSizeFromLayout", "()V");
			global::android.view.SurfaceHolder_._lockCanvas9615 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceHolder_.staticClass, "lockCanvas", "()Landroid/graphics/Canvas;");
			global::android.view.SurfaceHolder_._lockCanvas9616 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceHolder_.staticClass, "lockCanvas", "(Landroid/graphics/Rect;)Landroid/graphics/Canvas;");
			global::android.view.SurfaceHolder_._unlockCanvasAndPost9617 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceHolder_.staticClass, "unlockCanvasAndPost", "(Landroid/graphics/Canvas;)V");
			global::android.view.SurfaceHolder_._getSurfaceFrame9618 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceHolder_.staticClass, "getSurfaceFrame", "()Landroid/graphics/Rect;");
			global::android.view.SurfaceHolder_._getSurface9619 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceHolder_.staticClass, "getSurface", "()Landroid/view/Surface;");
		}
	}
}
