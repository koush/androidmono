namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SurfaceView : android.view.View
	{ 
		internal new static global::java.lang.Class staticClass; 
		static SurfaceView() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.SurfaceView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _draw8070; 
		public override void draw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.SurfaceView._draw8070, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._draw8070, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToWindow8071; 
		protected override void onAttachedToWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.SurfaceView._onAttachedToWindow8071); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._onAttachedToWindow8071); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow8072; 
		protected override void onDetachedFromWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.SurfaceView._onDetachedFromWindow8072); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._onDetachedFromWindow8072); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVisibility8073; 
		public override void setVisibility(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.SurfaceView._setVisibility8073, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._setVisibility8073, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onWindowVisibilityChanged8074; 
		protected override void onWindowVisibilityChanged(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.SurfaceView._onWindowVisibilityChanged8074, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._onWindowVisibilityChanged8074, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onScrollChanged8075; 
		protected override void onScrollChanged(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.SurfaceView._onScrollChanged8075, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._onScrollChanged8075, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSizeChanged8076; 
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.SurfaceView._onSizeChanged8076, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._onSizeChanged8076, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchDraw8077; 
		protected override void dispatchDraw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.SurfaceView._dispatchDraw8077, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._dispatchDraw8077, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure8078; 
		protected override void onMeasure(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.SurfaceView._onMeasure8078, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._onMeasure8078, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _gatherTransparentRegion8079; 
		public virtual bool gatherTransparentRegion(android.graphics.Region arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.SurfaceView._gatherTransparentRegion8079, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._gatherTransparentRegion8079, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHolder8080; 
		public virtual global::android.view.SurfaceHolder getHolder() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SurfaceHolder>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.SurfaceView._getHolder8080)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SurfaceHolder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._getHolder8080)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setZOrderMediaOverlay8081; 
		public virtual void setZOrderMediaOverlay(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.SurfaceView._setZOrderMediaOverlay8081, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._setZOrderMediaOverlay8081, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setZOrderOnTop8082; 
		public virtual void setZOrderOnTop(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.SurfaceView._setZOrderOnTop8082, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.SurfaceView.staticClass, global::android.view.SurfaceView._setZOrderOnTop8082, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SurfaceView8083; 
		public SurfaceView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.SurfaceView.staticClass, global::android.view.SurfaceView._SurfaceView8083, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SurfaceView8084; 
		public SurfaceView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.SurfaceView.staticClass, global::android.view.SurfaceView._SurfaceView8084, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SurfaceView8085; 
		public SurfaceView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.SurfaceView.staticClass, global::android.view.SurfaceView._SurfaceView8085, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.SurfaceView.staticClass = @__class; 
			global::android.view.SurfaceView._draw8070 = @__env.GetMethodID(global::android.view.SurfaceView.staticClass, "draw", "(Landroid/graphics/Canvas;)V"); 
			global::android.view.SurfaceView._onAttachedToWindow8071 = @__env.GetMethodID(global::android.view.SurfaceView.staticClass, "onAttachedToWindow", "()V"); 
			global::android.view.SurfaceView._onDetachedFromWindow8072 = @__env.GetMethodID(global::android.view.SurfaceView.staticClass, "onDetachedFromWindow", "()V"); 
			global::android.view.SurfaceView._setVisibility8073 = @__env.GetMethodID(global::android.view.SurfaceView.staticClass, "setVisibility", "(I)V"); 
			global::android.view.SurfaceView._onWindowVisibilityChanged8074 = @__env.GetMethodID(global::android.view.SurfaceView.staticClass, "onWindowVisibilityChanged", "(I)V"); 
			global::android.view.SurfaceView._onScrollChanged8075 = @__env.GetMethodID(global::android.view.SurfaceView.staticClass, "onScrollChanged", "(IIII)V"); 
			global::android.view.SurfaceView._onSizeChanged8076 = @__env.GetMethodID(global::android.view.SurfaceView.staticClass, "onSizeChanged", "(IIII)V"); 
			global::android.view.SurfaceView._dispatchDraw8077 = @__env.GetMethodID(global::android.view.SurfaceView.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V"); 
			global::android.view.SurfaceView._onMeasure8078 = @__env.GetMethodID(global::android.view.SurfaceView.staticClass, "onMeasure", "(II)V"); 
			global::android.view.SurfaceView._gatherTransparentRegion8079 = @__env.GetMethodID(global::android.view.SurfaceView.staticClass, "gatherTransparentRegion", "(Landroid/graphics/Region;)Z"); 
			global::android.view.SurfaceView._getHolder8080 = @__env.GetMethodID(global::android.view.SurfaceView.staticClass, "getHolder", "()Landroid/view/SurfaceHolder;"); 
			global::android.view.SurfaceView._setZOrderMediaOverlay8081 = @__env.GetMethodID(global::android.view.SurfaceView.staticClass, "setZOrderMediaOverlay", "(Z)V"); 
			global::android.view.SurfaceView._setZOrderOnTop8082 = @__env.GetMethodID(global::android.view.SurfaceView.staticClass, "setZOrderOnTop", "(Z)V"); 
			global::android.view.SurfaceView._SurfaceView8083 = @__env.GetMethodID(global::android.view.SurfaceView.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.view.SurfaceView._SurfaceView8084 = @__env.GetMethodID(global::android.view.SurfaceView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.view.SurfaceView._SurfaceView8085 = @__env.GetMethodID(global::android.view.SurfaceView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
