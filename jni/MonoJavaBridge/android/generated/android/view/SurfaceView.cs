namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SurfaceView : android.view.View
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SurfaceView()
		{
			InitJNI();
		}
		protected SurfaceView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _draw9620;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceView._draw9620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._draw9620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow9621;
		protected override void onAttachedToWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceView._onAttachedToWindow9621);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._onAttachedToWindow9621);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow9622;
		protected override void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceView._onDetachedFromWindow9622);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._onDetachedFromWindow9622);
		}
		internal static global::MonoJavaBridge.MethodId _setVisibility9623;
		public override void setVisibility(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceView._setVisibility9623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._setVisibility9623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onWindowVisibilityChanged9624;
		protected override void onWindowVisibilityChanged(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceView._onWindowVisibilityChanged9624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._onWindowVisibilityChanged9624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged9625;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceView._onSizeChanged9625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._onSizeChanged9625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchDraw9626;
		protected override void dispatchDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceView._dispatchDraw9626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._dispatchDraw9626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure9627;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceView._onMeasure9627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._onMeasure9627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _gatherTransparentRegion9628;
		public virtual bool gatherTransparentRegion(android.graphics.Region arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.SurfaceView._gatherTransparentRegion9628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._gatherTransparentRegion9628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.view.SurfaceHolder Holder
		{
			get
			{
				return getHolder();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHolder9629;
		public virtual global::android.view.SurfaceHolder getHolder() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SurfaceHolder>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SurfaceView._getHolder9629)) as android.view.SurfaceHolder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SurfaceHolder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._getHolder9629)) as android.view.SurfaceHolder;
		}
		internal static global::MonoJavaBridge.MethodId _setZOrderMediaOverlay9630;
		public virtual void setZOrderMediaOverlay(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceView._setZOrderMediaOverlay9630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._setZOrderMediaOverlay9630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setZOrderOnTop9631;
		public virtual void setZOrderOnTop(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceView._setZOrderOnTop9631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._setZOrderOnTop9631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SurfaceView9632;
		public SurfaceView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.SurfaceView.staticClass, global::android.view.SurfaceView._SurfaceView9632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SurfaceView9633;
		public SurfaceView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.SurfaceView.staticClass, global::android.view.SurfaceView._SurfaceView9633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SurfaceView9634;
		public SurfaceView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.SurfaceView.staticClass, global::android.view.SurfaceView._SurfaceView9634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.SurfaceView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/SurfaceView"));
			global::android.view.SurfaceView._draw9620 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.view.SurfaceView._onAttachedToWindow9621 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "onAttachedToWindow", "()V");
			global::android.view.SurfaceView._onDetachedFromWindow9622 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "onDetachedFromWindow", "()V");
			global::android.view.SurfaceView._setVisibility9623 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "setVisibility", "(I)V");
			global::android.view.SurfaceView._onWindowVisibilityChanged9624 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "onWindowVisibilityChanged", "(I)V");
			global::android.view.SurfaceView._onSizeChanged9625 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "onSizeChanged", "(IIII)V");
			global::android.view.SurfaceView._dispatchDraw9626 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V");
			global::android.view.SurfaceView._onMeasure9627 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "onMeasure", "(II)V");
			global::android.view.SurfaceView._gatherTransparentRegion9628 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "gatherTransparentRegion", "(Landroid/graphics/Region;)Z");
			global::android.view.SurfaceView._getHolder9629 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "getHolder", "()Landroid/view/SurfaceHolder;");
			global::android.view.SurfaceView._setZOrderMediaOverlay9630 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "setZOrderMediaOverlay", "(Z)V");
			global::android.view.SurfaceView._setZOrderOnTop9631 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "setZOrderOnTop", "(Z)V");
			global::android.view.SurfaceView._SurfaceView9632 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.view.SurfaceView._SurfaceView9633 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.view.SurfaceView._SurfaceView9634 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
