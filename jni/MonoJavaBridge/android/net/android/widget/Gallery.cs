namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Gallery : android.widget.AbsSpinner, android.view.GestureDetector.OnGestureListener
	{ 
		internal new static global::java.lang.Class staticClass; 
		static Gallery() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.Gallery), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.Gallery(@__env); 
			} 
		} 
		protected Gallery(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public new class LayoutParams : android.view.ViewGroup.LayoutParams
		{ 
			internal new static global::java.lang.Class staticClass; 
			static LayoutParams() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.Gallery.LayoutParams), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.widget.Gallery.LayoutParams(@__env); 
				} 
			} 
			protected LayoutParams(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams9486; 
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.Gallery.LayoutParams.staticClass, _LayoutParams9486, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams9487; 
			public LayoutParams(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.Gallery.LayoutParams.staticClass, _LayoutParams9487, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams9488; 
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.Gallery.LayoutParams.staticClass, _LayoutParams9488, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.widget.Gallery.LayoutParams.staticClass = @__class; 
				global::android.widget.Gallery.LayoutParams._LayoutParams9486 = @__env.GetMethodID(global::android.widget.Gallery.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
				global::android.widget.Gallery.LayoutParams._LayoutParams9487 = @__env.GetMethodID(global::android.widget.Gallery.LayoutParams.staticClass, "<init>", "(II)V"); 
				global::android.widget.Gallery.LayoutParams._LayoutParams9488 = @__env.GetMethodID(global::android.widget.Gallery.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown9489; 
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Gallery)) 
				return @__env.CallBooleanMethod(this, _onKeyDown9489, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.Gallery.staticClass, _onKeyDown9489, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp9490; 
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Gallery)) 
				return @__env.CallBooleanMethod(this, _onKeyUp9490, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.Gallery.staticClass, _onKeyUp9490, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent9491; 
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Gallery)) 
				return @__env.CallBooleanMethod(this, _onTouchEvent9491, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.Gallery.staticClass, _onTouchEvent9491, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEvent9492; 
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Gallery)) 
				return @__env.CallBooleanMethod(this, _dispatchKeyEvent9492, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.Gallery.staticClass, _dispatchKeyEvent9492, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGravity9493; 
		public virtual void setGravity(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Gallery)) 
				@__env.CallVoidMethod(this, _setGravity9493, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Gallery.staticClass, _setGravity9493, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _showContextMenu9494; 
		public override bool showContextMenu() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Gallery)) 
				return @__env.CallBooleanMethod(this, _showContextMenu9494); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.Gallery.staticClass, _showContextMenu9494); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFocusChanged9495; 
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Gallery)) 
				@__env.CallVoidMethod(this, _onFocusChanged9495, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Gallery.staticClass, _onFocusChanged9495, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchSetPressed9496; 
		protected override void dispatchSetPressed(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Gallery)) 
				@__env.CallVoidMethod(this, _dispatchSetPressed9496, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Gallery.staticClass, _dispatchSetPressed9496, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContextMenuInfo9497; 
		protected override android.view.ContextMenu_ContextMenuInfo getContextMenuInfo() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Gallery)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu_ContextMenuInfo>(@__env, @__env.CallObjectMethodPtr(this, _getContextMenuInfo9497)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu_ContextMenuInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.Gallery.staticClass, _getContextMenuInfo9497)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeHorizontalScrollRange9498; 
		protected override int computeHorizontalScrollRange() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Gallery)) 
				return @__env.CallIntMethod(this, _computeHorizontalScrollRange9498); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.Gallery.staticClass, _computeHorizontalScrollRange9498); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeHorizontalScrollOffset9499; 
		protected override int computeHorizontalScrollOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Gallery)) 
				return @__env.CallIntMethod(this, _computeHorizontalScrollOffset9499); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.Gallery.staticClass, _computeHorizontalScrollOffset9499); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeHorizontalScrollExtent9500; 
		protected override int computeHorizontalScrollExtent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Gallery)) 
				return @__env.CallIntMethod(this, _computeHorizontalScrollExtent9500); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.Gallery.staticClass, _computeHorizontalScrollExtent9500); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLayout9501; 
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Gallery)) 
				@__env.CallVoidMethod(this, _onLayout9501, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Gallery.staticClass, _onLayout9501, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchSetSelected9502; 
		public override void dispatchSetSelected(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Gallery)) 
				@__env.CallVoidMethod(this, _dispatchSetSelected9502, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Gallery.staticClass, _dispatchSetSelected9502, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _showContextMenuForChild9503; 
		public override bool showContextMenuForChild(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Gallery)) 
				return @__env.CallBooleanMethod(this, _showContextMenuForChild9503, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.Gallery.staticClass, _showContextMenuForChild9503, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChildDrawingOrder9504; 
		protected override int getChildDrawingOrder(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Gallery)) 
				return @__env.CallIntMethod(this, _getChildDrawingOrder9504, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.Gallery.staticClass, _getChildDrawingOrder9504, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChildStaticTransformation9505; 
		protected override bool getChildStaticTransformation(android.view.View arg0, android.view.animation.Transformation arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Gallery)) 
				return @__env.CallBooleanMethod(this, _getChildStaticTransformation9505, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.Gallery.staticClass, _getChildStaticTransformation9505, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _checkLayoutParams9506; 
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Gallery)) 
				return @__env.CallBooleanMethod(this, _checkLayoutParams9506, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.Gallery.staticClass, _checkLayoutParams9506, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _generateLayoutParams9507; 
		public override android.view.ViewGroup.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Gallery)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, _generateLayoutParams9507, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.Gallery.staticClass, _generateLayoutParams9507, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _generateLayoutParams9508; 
		protected override android.view.ViewGroup.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Gallery)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, _generateLayoutParams9508, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.Gallery.staticClass, _generateLayoutParams9508, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _generateDefaultLayoutParams9509; 
		protected override android.view.ViewGroup.LayoutParams generateDefaultLayoutParams() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Gallery)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, _generateDefaultLayoutParams9509)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.Gallery.staticClass, _generateDefaultLayoutParams9509)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLongPress9510; 
		public virtual void onLongPress(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Gallery)) 
				@__env.CallVoidMethod(this, _onLongPress9510, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Gallery.staticClass, _onLongPress9510, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSingleTapUp9511; 
		public virtual bool onSingleTapUp(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Gallery)) 
				return @__env.CallBooleanMethod(this, _onSingleTapUp9511, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.Gallery.staticClass, _onSingleTapUp9511, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onScroll9512; 
		public virtual bool onScroll(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Gallery)) 
				return @__env.CallBooleanMethod(this, _onScroll9512, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.Gallery.staticClass, _onScroll9512, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFling9513; 
		public virtual bool onFling(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Gallery)) 
				return @__env.CallBooleanMethod(this, _onFling9513, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.Gallery.staticClass, _onFling9513, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onShowPress9514; 
		public virtual void onShowPress(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Gallery)) 
				@__env.CallVoidMethod(this, _onShowPress9514, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Gallery.staticClass, _onShowPress9514, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDown9515; 
		public virtual bool onDown(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Gallery)) 
				return @__env.CallBooleanMethod(this, _onDown9515, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.Gallery.staticClass, _onDown9515, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCallbackDuringFling9516; 
		public virtual void setCallbackDuringFling(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Gallery)) 
				@__env.CallVoidMethod(this, _setCallbackDuringFling9516, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Gallery.staticClass, _setCallbackDuringFling9516, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAnimationDuration9517; 
		public virtual void setAnimationDuration(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Gallery)) 
				@__env.CallVoidMethod(this, _setAnimationDuration9517, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Gallery.staticClass, _setAnimationDuration9517, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSpacing9518; 
		public virtual void setSpacing(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Gallery)) 
				@__env.CallVoidMethod(this, _setSpacing9518, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Gallery.staticClass, _setSpacing9518, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setUnselectedAlpha9519; 
		public virtual void setUnselectedAlpha(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Gallery)) 
				@__env.CallVoidMethod(this, _setUnselectedAlpha9519, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Gallery.staticClass, _setUnselectedAlpha9519, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Gallery9520; 
		public Gallery(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.Gallery.staticClass, _Gallery9520, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Gallery9521; 
		public Gallery(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.Gallery.staticClass, _Gallery9521, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Gallery9522; 
		public Gallery(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.Gallery.staticClass, _Gallery9522, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.Gallery.staticClass = @__class; 
			global::android.widget.Gallery._onKeyDown9489 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.widget.Gallery._onKeyUp9490 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.widget.Gallery._onTouchEvent9491 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.widget.Gallery._dispatchKeyEvent9492 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z"); 
			global::android.widget.Gallery._setGravity9493 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "setGravity", "(I)V"); 
			global::android.widget.Gallery._showContextMenu9494 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "showContextMenu", "()Z"); 
			global::android.widget.Gallery._onFocusChanged9495 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V"); 
			global::android.widget.Gallery._dispatchSetPressed9496 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "dispatchSetPressed", "(Z)V"); 
			global::android.widget.Gallery._getContextMenuInfo9497 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "getContextMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;"); 
			global::android.widget.Gallery._computeHorizontalScrollRange9498 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "computeHorizontalScrollRange", "()I"); 
			global::android.widget.Gallery._computeHorizontalScrollOffset9499 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "computeHorizontalScrollOffset", "()I"); 
			global::android.widget.Gallery._computeHorizontalScrollExtent9500 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "computeHorizontalScrollExtent", "()I"); 
			global::android.widget.Gallery._onLayout9501 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "onLayout", "(ZIIII)V"); 
			global::android.widget.Gallery._dispatchSetSelected9502 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "dispatchSetSelected", "(Z)V"); 
			global::android.widget.Gallery._showContextMenuForChild9503 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "showContextMenuForChild", "(Landroid/view/View;)Z"); 
			global::android.widget.Gallery._getChildDrawingOrder9504 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "getChildDrawingOrder", "(II)I"); 
			global::android.widget.Gallery._getChildStaticTransformation9505 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "getChildStaticTransformation", "(Landroid/view/View;Landroid/view/animation/Transformation;)Z"); 
			global::android.widget.Gallery._checkLayoutParams9506 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z"); 
			global::android.widget.Gallery._generateLayoutParams9507 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/view/ViewGroup$LayoutParams;"); 
			global::android.widget.Gallery._generateLayoutParams9508 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;"); 
			global::android.widget.Gallery._generateDefaultLayoutParams9509 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;"); 
			global::android.widget.Gallery._onLongPress9510 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "onLongPress", "(Landroid/view/MotionEvent;)V"); 
			global::android.widget.Gallery._onSingleTapUp9511 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "onSingleTapUp", "(Landroid/view/MotionEvent;)Z"); 
			global::android.widget.Gallery._onScroll9512 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z"); 
			global::android.widget.Gallery._onFling9513 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z"); 
			global::android.widget.Gallery._onShowPress9514 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "onShowPress", "(Landroid/view/MotionEvent;)V"); 
			global::android.widget.Gallery._onDown9515 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "onDown", "(Landroid/view/MotionEvent;)Z"); 
			global::android.widget.Gallery._setCallbackDuringFling9516 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "setCallbackDuringFling", "(Z)V"); 
			global::android.widget.Gallery._setAnimationDuration9517 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "setAnimationDuration", "(I)V"); 
			global::android.widget.Gallery._setSpacing9518 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "setSpacing", "(I)V"); 
			global::android.widget.Gallery._setUnselectedAlpha9519 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "setUnselectedAlpha", "(F)V"); 
			global::android.widget.Gallery._Gallery9520 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
			global::android.widget.Gallery._Gallery9521 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.Gallery._Gallery9522 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
		} 
	} 
} 
