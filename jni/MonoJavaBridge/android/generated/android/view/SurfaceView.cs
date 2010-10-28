namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SurfaceView : android.view.View
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SurfaceView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _draw14587;
		public override void draw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceView._draw14587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._draw14587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow14588;
		protected override void onAttachedToWindow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceView._onAttachedToWindow14588);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._onAttachedToWindow14588);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow14589;
		protected override void onDetachedFromWindow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceView._onDetachedFromWindow14589);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._onDetachedFromWindow14589);
		}
		public new int Visibility
		{
			set
			{
				setVisibility(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setVisibility14590;
		public override void setVisibility(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceView._setVisibility14590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._setVisibility14590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onWindowVisibilityChanged14591;
		protected override void onWindowVisibilityChanged(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceView._onWindowVisibilityChanged14591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._onWindowVisibilityChanged14591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged14592;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceView._onSizeChanged14592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._onSizeChanged14592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchDraw14593;
		protected override void dispatchDraw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceView._dispatchDraw14593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._dispatchDraw14593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure14594;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceView._onMeasure14594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._onMeasure14594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _gatherTransparentRegion14595;
		public virtual bool gatherTransparentRegion(android.graphics.Region arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.SurfaceView._gatherTransparentRegion14595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._gatherTransparentRegion14595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.view.SurfaceHolder Holder
		{
			get
			{
				return getHolder();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHolder14596;
		public virtual global::android.view.SurfaceHolder getHolder()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SurfaceHolder>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SurfaceView._getHolder14596)) as android.view.SurfaceHolder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SurfaceHolder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._getHolder14596)) as android.view.SurfaceHolder;
		}
		public new bool ZOrderMediaOverlay
		{
			set
			{
				setZOrderMediaOverlay(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setZOrderMediaOverlay14597;
		public virtual void setZOrderMediaOverlay(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceView._setZOrderMediaOverlay14597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._setZOrderMediaOverlay14597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool ZOrderOnTop
		{
			set
			{
				setZOrderOnTop(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setZOrderOnTop14598;
		public virtual void setZOrderOnTop(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceView._setZOrderOnTop14598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._setZOrderOnTop14598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SurfaceView14599;
		public SurfaceView(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.SurfaceView.staticClass, global::android.view.SurfaceView._SurfaceView14599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SurfaceView14600;
		public SurfaceView(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.SurfaceView.staticClass, global::android.view.SurfaceView._SurfaceView14600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SurfaceView14601;
		public SurfaceView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.SurfaceView.staticClass, global::android.view.SurfaceView._SurfaceView14601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static SurfaceView()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.SurfaceView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/SurfaceView"));
			global::android.view.SurfaceView._draw14587 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.view.SurfaceView._onAttachedToWindow14588 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "onAttachedToWindow", "()V");
			global::android.view.SurfaceView._onDetachedFromWindow14589 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "onDetachedFromWindow", "()V");
			global::android.view.SurfaceView._setVisibility14590 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "setVisibility", "(I)V");
			global::android.view.SurfaceView._onWindowVisibilityChanged14591 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "onWindowVisibilityChanged", "(I)V");
			global::android.view.SurfaceView._onSizeChanged14592 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "onSizeChanged", "(IIII)V");
			global::android.view.SurfaceView._dispatchDraw14593 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V");
			global::android.view.SurfaceView._onMeasure14594 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "onMeasure", "(II)V");
			global::android.view.SurfaceView._gatherTransparentRegion14595 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "gatherTransparentRegion", "(Landroid/graphics/Region;)Z");
			global::android.view.SurfaceView._getHolder14596 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "getHolder", "()Landroid/view/SurfaceHolder;");
			global::android.view.SurfaceView._setZOrderMediaOverlay14597 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "setZOrderMediaOverlay", "(Z)V");
			global::android.view.SurfaceView._setZOrderOnTop14598 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "setZOrderOnTop", "(Z)V");
			global::android.view.SurfaceView._SurfaceView14599 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.view.SurfaceView._SurfaceView14600 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.view.SurfaceView._SurfaceView14601 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
