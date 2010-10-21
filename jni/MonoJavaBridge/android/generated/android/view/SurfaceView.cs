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
		internal static global::MonoJavaBridge.MethodId _draw14519;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceView._draw14519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._draw14519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow14520;
		protected override void onAttachedToWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceView._onAttachedToWindow14520);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._onAttachedToWindow14520);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow14521;
		protected override void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceView._onDetachedFromWindow14521);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._onDetachedFromWindow14521);
		}
		internal static global::MonoJavaBridge.MethodId _setVisibility14522;
		public override void setVisibility(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceView._setVisibility14522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._setVisibility14522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onWindowVisibilityChanged14523;
		protected override void onWindowVisibilityChanged(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceView._onWindowVisibilityChanged14523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._onWindowVisibilityChanged14523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged14524;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceView._onSizeChanged14524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._onSizeChanged14524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchDraw14525;
		protected override void dispatchDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceView._dispatchDraw14525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._dispatchDraw14525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure14526;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceView._onMeasure14526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._onMeasure14526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _gatherTransparentRegion14527;
		public virtual bool gatherTransparentRegion(android.graphics.Region arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.SurfaceView._gatherTransparentRegion14527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._gatherTransparentRegion14527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.view.SurfaceHolder Holder
		{
			get
			{
				return getHolder();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHolder14528;
		public virtual global::android.view.SurfaceHolder getHolder() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SurfaceHolder>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SurfaceView._getHolder14528)) as android.view.SurfaceHolder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SurfaceHolder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._getHolder14528)) as android.view.SurfaceHolder;
		}
		internal static global::MonoJavaBridge.MethodId _setZOrderMediaOverlay14529;
		public virtual void setZOrderMediaOverlay(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceView._setZOrderMediaOverlay14529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._setZOrderMediaOverlay14529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setZOrderOnTop14530;
		public virtual void setZOrderOnTop(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SurfaceView._setZOrderOnTop14530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._setZOrderOnTop14530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SurfaceView14531;
		public SurfaceView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.SurfaceView.staticClass, global::android.view.SurfaceView._SurfaceView14531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SurfaceView14532;
		public SurfaceView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.SurfaceView.staticClass, global::android.view.SurfaceView._SurfaceView14532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SurfaceView14533;
		public SurfaceView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.SurfaceView.staticClass, global::android.view.SurfaceView._SurfaceView14533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.SurfaceView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/SurfaceView"));
			global::android.view.SurfaceView._draw14519 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.view.SurfaceView._onAttachedToWindow14520 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "onAttachedToWindow", "()V");
			global::android.view.SurfaceView._onDetachedFromWindow14521 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "onDetachedFromWindow", "()V");
			global::android.view.SurfaceView._setVisibility14522 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "setVisibility", "(I)V");
			global::android.view.SurfaceView._onWindowVisibilityChanged14523 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "onWindowVisibilityChanged", "(I)V");
			global::android.view.SurfaceView._onSizeChanged14524 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "onSizeChanged", "(IIII)V");
			global::android.view.SurfaceView._dispatchDraw14525 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V");
			global::android.view.SurfaceView._onMeasure14526 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "onMeasure", "(II)V");
			global::android.view.SurfaceView._gatherTransparentRegion14527 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "gatherTransparentRegion", "(Landroid/graphics/Region;)Z");
			global::android.view.SurfaceView._getHolder14528 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "getHolder", "()Landroid/view/SurfaceHolder;");
			global::android.view.SurfaceView._setZOrderMediaOverlay14529 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "setZOrderMediaOverlay", "(Z)V");
			global::android.view.SurfaceView._setZOrderOnTop14530 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "setZOrderOnTop", "(Z)V");
			global::android.view.SurfaceView._SurfaceView14531 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.view.SurfaceView._SurfaceView14532 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.view.SurfaceView._SurfaceView14533 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
