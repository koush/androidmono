namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SurfaceView : android.view.View
	{ 
		internal new static global::java.lang.Class staticClass; 
		static SurfaceView() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.SurfaceView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.SurfaceView(@__env); 
			} 
		} 
		protected SurfaceView(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw7518; 
		public override void draw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.SurfaceView)) 
				@__env.CallVoidMethod(this, _draw7518, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.SurfaceView.staticClass, _draw7518, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToWindow7519; 
		protected override void onAttachedToWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.SurfaceView)) 
				@__env.CallVoidMethod(this, _onAttachedToWindow7519); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.SurfaceView.staticClass, _onAttachedToWindow7519); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow7520; 
		protected override void onDetachedFromWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.SurfaceView)) 
				@__env.CallVoidMethod(this, _onDetachedFromWindow7520); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.SurfaceView.staticClass, _onDetachedFromWindow7520); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVisibility7521; 
		public override void setVisibility(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.SurfaceView)) 
				@__env.CallVoidMethod(this, _setVisibility7521, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.SurfaceView.staticClass, _setVisibility7521, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onWindowVisibilityChanged7522; 
		protected override void onWindowVisibilityChanged(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.SurfaceView)) 
				@__env.CallVoidMethod(this, _onWindowVisibilityChanged7522, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.SurfaceView.staticClass, _onWindowVisibilityChanged7522, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onScrollChanged7523; 
		protected override void onScrollChanged(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.SurfaceView)) 
				@__env.CallVoidMethod(this, _onScrollChanged7523, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.SurfaceView.staticClass, _onScrollChanged7523, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSizeChanged7524; 
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.SurfaceView)) 
				@__env.CallVoidMethod(this, _onSizeChanged7524, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.SurfaceView.staticClass, _onSizeChanged7524, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchDraw7525; 
		protected override void dispatchDraw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.SurfaceView)) 
				@__env.CallVoidMethod(this, _dispatchDraw7525, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.SurfaceView.staticClass, _dispatchDraw7525, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure7526; 
		protected override void onMeasure(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.SurfaceView)) 
				@__env.CallVoidMethod(this, _onMeasure7526, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.SurfaceView.staticClass, _onMeasure7526, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _gatherTransparentRegion7527; 
		public virtual bool gatherTransparentRegion(android.graphics.Region arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.SurfaceView)) 
				return @__env.CallBooleanMethod(this, _gatherTransparentRegion7527, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.SurfaceView.staticClass, _gatherTransparentRegion7527, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHolder7528; 
		public virtual android.view.SurfaceHolder getHolder() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.SurfaceView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SurfaceHolder>(@__env, @__env.CallObjectMethodPtr(this, _getHolder7528)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SurfaceHolder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.SurfaceView.staticClass, _getHolder7528)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setZOrderMediaOverlay7529; 
		public virtual void setZOrderMediaOverlay(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.SurfaceView)) 
				@__env.CallVoidMethod(this, _setZOrderMediaOverlay7529, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.SurfaceView.staticClass, _setZOrderMediaOverlay7529, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setZOrderOnTop7530; 
		public virtual void setZOrderOnTop(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.SurfaceView)) 
				@__env.CallVoidMethod(this, _setZOrderOnTop7530, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.SurfaceView.staticClass, _setZOrderOnTop7530, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SurfaceView7531; 
		public SurfaceView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.SurfaceView.staticClass, _SurfaceView7531, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SurfaceView7532; 
		public SurfaceView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.SurfaceView.staticClass, _SurfaceView7532, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SurfaceView7533; 
		public SurfaceView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.SurfaceView.staticClass, _SurfaceView7533, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.SurfaceView.staticClass = @__class; 
			global::android.view.SurfaceView._draw7518 = @__env.GetMethodID(global::android.view.SurfaceView.staticClass, "draw", "(Landroid/graphics/Canvas;)V"); 
			global::android.view.SurfaceView._onAttachedToWindow7519 = @__env.GetMethodID(global::android.view.SurfaceView.staticClass, "onAttachedToWindow", "()V"); 
			global::android.view.SurfaceView._onDetachedFromWindow7520 = @__env.GetMethodID(global::android.view.SurfaceView.staticClass, "onDetachedFromWindow", "()V"); 
			global::android.view.SurfaceView._setVisibility7521 = @__env.GetMethodID(global::android.view.SurfaceView.staticClass, "setVisibility", "(I)V"); 
			global::android.view.SurfaceView._onWindowVisibilityChanged7522 = @__env.GetMethodID(global::android.view.SurfaceView.staticClass, "onWindowVisibilityChanged", "(I)V"); 
			global::android.view.SurfaceView._onScrollChanged7523 = @__env.GetMethodID(global::android.view.SurfaceView.staticClass, "onScrollChanged", "(IIII)V"); 
			global::android.view.SurfaceView._onSizeChanged7524 = @__env.GetMethodID(global::android.view.SurfaceView.staticClass, "onSizeChanged", "(IIII)V"); 
			global::android.view.SurfaceView._dispatchDraw7525 = @__env.GetMethodID(global::android.view.SurfaceView.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V"); 
			global::android.view.SurfaceView._onMeasure7526 = @__env.GetMethodID(global::android.view.SurfaceView.staticClass, "onMeasure", "(II)V"); 
			global::android.view.SurfaceView._gatherTransparentRegion7527 = @__env.GetMethodID(global::android.view.SurfaceView.staticClass, "gatherTransparentRegion", "(Landroid/graphics/Region;)Z"); 
			global::android.view.SurfaceView._getHolder7528 = @__env.GetMethodID(global::android.view.SurfaceView.staticClass, "getHolder", "()Landroid/view/SurfaceHolder;"); 
			global::android.view.SurfaceView._setZOrderMediaOverlay7529 = @__env.GetMethodID(global::android.view.SurfaceView.staticClass, "setZOrderMediaOverlay", "(Z)V"); 
			global::android.view.SurfaceView._setZOrderOnTop7530 = @__env.GetMethodID(global::android.view.SurfaceView.staticClass, "setZOrderOnTop", "(Z)V"); 
			global::android.view.SurfaceView._SurfaceView7531 = @__env.GetMethodID(global::android.view.SurfaceView.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.view.SurfaceView._SurfaceView7532 = @__env.GetMethodID(global::android.view.SurfaceView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.view.SurfaceView._SurfaceView7533 = @__env.GetMethodID(global::android.view.SurfaceView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
