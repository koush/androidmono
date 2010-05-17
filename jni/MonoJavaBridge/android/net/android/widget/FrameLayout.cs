namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class FrameLayout : android.view.ViewGroup
	{ 
		internal new static global::java.lang.Class staticClass; 
		static FrameLayout() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.FrameLayout), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.FrameLayout(@__env); 
			} 
		} 
		protected FrameLayout(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public new class LayoutParams : android.view.ViewGroup.MarginLayoutParams
		{ 
			internal new static global::java.lang.Class staticClass; 
			static LayoutParams() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.FrameLayout.LayoutParams), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.widget.FrameLayout.LayoutParams(@__env); 
				} 
			} 
			protected LayoutParams(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams9461; 
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.FrameLayout.LayoutParams.staticClass, _LayoutParams9461, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams9462; 
			public LayoutParams(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.FrameLayout.LayoutParams.staticClass, _LayoutParams9462, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams9463; 
			public LayoutParams(int arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.FrameLayout.LayoutParams.staticClass, _LayoutParams9463, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams9464; 
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.FrameLayout.LayoutParams.staticClass, _LayoutParams9464, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams9465; 
			public LayoutParams(android.view.ViewGroup.MarginLayoutParams arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.FrameLayout.LayoutParams.staticClass, _LayoutParams9465, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _gravity9466; 
			public int gravity
			{ 
				get 
				{ 
					return default(int); 
				} 
				set 
				{ 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.widget.FrameLayout.LayoutParams.staticClass = @__class; 
				global::android.widget.FrameLayout.LayoutParams._LayoutParams9461 = @__env.GetMethodID(global::android.widget.FrameLayout.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
				global::android.widget.FrameLayout.LayoutParams._LayoutParams9462 = @__env.GetMethodID(global::android.widget.FrameLayout.LayoutParams.staticClass, "<init>", "(II)V"); 
				global::android.widget.FrameLayout.LayoutParams._LayoutParams9463 = @__env.GetMethodID(global::android.widget.FrameLayout.LayoutParams.staticClass, "<init>", "(III)V"); 
				global::android.widget.FrameLayout.LayoutParams._LayoutParams9464 = @__env.GetMethodID(global::android.widget.FrameLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V"); 
				global::android.widget.FrameLayout.LayoutParams._LayoutParams9465 = @__env.GetMethodID(global::android.widget.FrameLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setForeground9467; 
		public virtual void setForeground(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.FrameLayout)) 
				@__env.CallVoidMethod(this, _setForeground9467, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.FrameLayout.staticClass, _setForeground9467, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw9468; 
		public override void draw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.FrameLayout)) 
				@__env.CallVoidMethod(this, _draw9468, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.FrameLayout.staticClass, _draw9468, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSizeChanged9469; 
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.FrameLayout)) 
				@__env.CallVoidMethod(this, _onSizeChanged9469, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.FrameLayout.staticClass, _onSizeChanged9469, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLayout9470; 
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.FrameLayout)) 
				@__env.CallVoidMethod(this, _onLayout9470, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.FrameLayout.staticClass, _onLayout9470, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _verifyDrawable9471; 
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.FrameLayout)) 
				return @__env.CallBooleanMethod(this, _verifyDrawable9471, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.FrameLayout.staticClass, _verifyDrawable9471, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawableStateChanged9472; 
		protected override void drawableStateChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.FrameLayout)) 
				@__env.CallVoidMethod(this, _drawableStateChanged9472); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.FrameLayout.staticClass, _drawableStateChanged9472); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure9473; 
		protected override void onMeasure(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.FrameLayout)) 
				@__env.CallVoidMethod(this, _onMeasure9473, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.FrameLayout.staticClass, _onMeasure9473, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _checkLayoutParams9474; 
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.FrameLayout)) 
				return @__env.CallBooleanMethod(this, _checkLayoutParams9474, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.FrameLayout.staticClass, _checkLayoutParams9474, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _generateLayoutParams9475; 
		public virtual new android.widget.FrameLayout.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.FrameLayout)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.FrameLayout.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, _generateLayoutParams9475, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.FrameLayout.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.FrameLayout.staticClass, _generateLayoutParams9475, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _generateLayoutParams9476; 
		protected override android.view.ViewGroup.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.FrameLayout)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, _generateLayoutParams9476, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.FrameLayout.staticClass, _generateLayoutParams9476, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _generateDefaultLayoutParams9477; 
		protected virtual new android.widget.FrameLayout.LayoutParams generateDefaultLayoutParams() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.FrameLayout)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.FrameLayout.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, _generateDefaultLayoutParams9477)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.FrameLayout.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.FrameLayout.staticClass, _generateDefaultLayoutParams9477)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _gatherTransparentRegion9478; 
		public override bool gatherTransparentRegion(android.graphics.Region arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.FrameLayout)) 
				return @__env.CallBooleanMethod(this, _gatherTransparentRegion9478, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.FrameLayout.staticClass, _gatherTransparentRegion9478, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setForegroundGravity9479; 
		public virtual void setForegroundGravity(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.FrameLayout)) 
				@__env.CallVoidMethod(this, _setForegroundGravity9479, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.FrameLayout.staticClass, _setForegroundGravity9479, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getForeground9480; 
		public virtual android.graphics.drawable.Drawable getForeground() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.FrameLayout)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _getForeground9480)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.FrameLayout.staticClass, _getForeground9480)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMeasureAllChildren9481; 
		public virtual void setMeasureAllChildren(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.FrameLayout)) 
				@__env.CallVoidMethod(this, _setMeasureAllChildren9481, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.FrameLayout.staticClass, _setMeasureAllChildren9481, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getConsiderGoneChildrenWhenMeasuring9482; 
		public virtual bool getConsiderGoneChildrenWhenMeasuring() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.FrameLayout)) 
				return @__env.CallBooleanMethod(this, _getConsiderGoneChildrenWhenMeasuring9482); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.FrameLayout.staticClass, _getConsiderGoneChildrenWhenMeasuring9482); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _FrameLayout9483; 
		public FrameLayout(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.FrameLayout.staticClass, _FrameLayout9483, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _FrameLayout9484; 
		public FrameLayout(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.FrameLayout.staticClass, _FrameLayout9484, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _FrameLayout9485; 
		public FrameLayout(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.FrameLayout.staticClass, _FrameLayout9485, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.FrameLayout.staticClass = @__class; 
			global::android.widget.FrameLayout._setForeground9467 = @__env.GetMethodID(global::android.widget.FrameLayout.staticClass, "setForeground", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.widget.FrameLayout._draw9468 = @__env.GetMethodID(global::android.widget.FrameLayout.staticClass, "draw", "(Landroid/graphics/Canvas;)V"); 
			global::android.widget.FrameLayout._onSizeChanged9469 = @__env.GetMethodID(global::android.widget.FrameLayout.staticClass, "onSizeChanged", "(IIII)V"); 
			global::android.widget.FrameLayout._onLayout9470 = @__env.GetMethodID(global::android.widget.FrameLayout.staticClass, "onLayout", "(ZIIII)V"); 
			global::android.widget.FrameLayout._verifyDrawable9471 = @__env.GetMethodID(global::android.widget.FrameLayout.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z"); 
			global::android.widget.FrameLayout._drawableStateChanged9472 = @__env.GetMethodID(global::android.widget.FrameLayout.staticClass, "drawableStateChanged", "()V"); 
			global::android.widget.FrameLayout._onMeasure9473 = @__env.GetMethodID(global::android.widget.FrameLayout.staticClass, "onMeasure", "(II)V"); 
			global::android.widget.FrameLayout._checkLayoutParams9474 = @__env.GetMethodID(global::android.widget.FrameLayout.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z"); 
			global::android.widget.FrameLayout._generateLayoutParams9475 = @__env.GetMethodID(global::android.widget.FrameLayout.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/FrameLayout$LayoutParams;"); 
			global::android.widget.FrameLayout._generateLayoutParams9476 = @__env.GetMethodID(global::android.widget.FrameLayout.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;"); 
			global::android.widget.FrameLayout._generateDefaultLayoutParams9477 = @__env.GetMethodID(global::android.widget.FrameLayout.staticClass, "generateDefaultLayoutParams", "()Landroid/widget/FrameLayout$LayoutParams;"); 
			global::android.widget.FrameLayout._gatherTransparentRegion9478 = @__env.GetMethodID(global::android.widget.FrameLayout.staticClass, "gatherTransparentRegion", "(Landroid/graphics/Region;)Z"); 
			global::android.widget.FrameLayout._setForegroundGravity9479 = @__env.GetMethodID(global::android.widget.FrameLayout.staticClass, "setForegroundGravity", "(I)V"); 
			global::android.widget.FrameLayout._getForeground9480 = @__env.GetMethodID(global::android.widget.FrameLayout.staticClass, "getForeground", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.widget.FrameLayout._setMeasureAllChildren9481 = @__env.GetMethodID(global::android.widget.FrameLayout.staticClass, "setMeasureAllChildren", "(Z)V"); 
			global::android.widget.FrameLayout._getConsiderGoneChildrenWhenMeasuring9482 = @__env.GetMethodID(global::android.widget.FrameLayout.staticClass, "getConsiderGoneChildrenWhenMeasuring", "()Z"); 
			global::android.widget.FrameLayout._FrameLayout9483 = @__env.GetMethodID(global::android.widget.FrameLayout.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.FrameLayout._FrameLayout9484 = @__env.GetMethodID(global::android.widget.FrameLayout.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
			global::android.widget.FrameLayout._FrameLayout9485 = @__env.GetMethodID(global::android.widget.FrameLayout.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
