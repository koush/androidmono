namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Gallery : android.widget.AbsSpinner, android.view.GestureDetector.OnGestureListener
	{
		internal new static global::java.lang.Class staticClass;
		static Gallery()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.Gallery), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.Gallery.LayoutParams), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams10230;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.Gallery.LayoutParams.staticClass, global::android.widget.Gallery.LayoutParams._LayoutParams10230, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams10231;
			public LayoutParams(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.Gallery.LayoutParams.staticClass, global::android.widget.Gallery.LayoutParams._LayoutParams10231, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams10232;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.Gallery.LayoutParams.staticClass, global::android.widget.Gallery.LayoutParams._LayoutParams10232, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.Gallery.LayoutParams.staticClass = @__class;
				global::android.widget.Gallery.LayoutParams._LayoutParams10230 = @__env.GetMethodID(global::android.widget.Gallery.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::android.widget.Gallery.LayoutParams._LayoutParams10231 = @__env.GetMethodID(global::android.widget.Gallery.LayoutParams.staticClass, "<init>", "(II)V");
				global::android.widget.Gallery.LayoutParams._LayoutParams10232 = @__env.GetMethodID(global::android.widget.Gallery.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown10233;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.Gallery._onKeyDown10233, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._onKeyDown10233, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp10234;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.Gallery._onKeyUp10234, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._onKeyUp10234, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent10235;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.Gallery._onTouchEvent10235, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._onTouchEvent10235, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEvent10236;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.Gallery._dispatchKeyEvent10236, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._dispatchKeyEvent10236, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setGravity10237;
		public virtual void setGravity(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.Gallery._setGravity10237, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._setGravity10237, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _showContextMenu10238;
		public override bool showContextMenu() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.Gallery._showContextMenu10238);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._showContextMenu10238);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onFocusChanged10239;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.Gallery._onFocusChanged10239, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._onFocusChanged10239, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchSetPressed10240;
		protected override void dispatchSetPressed(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.Gallery._dispatchSetPressed10240, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._dispatchSetPressed10240, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getContextMenuInfo10241;
		protected override global::android.view.ContextMenu_ContextMenuInfo getContextMenuInfo() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu_ContextMenuInfo>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.Gallery._getContextMenuInfo10241));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu_ContextMenuInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._getContextMenuInfo10241));
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeHorizontalScrollRange10242;
		protected override int computeHorizontalScrollRange() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.Gallery._computeHorizontalScrollRange10242);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._computeHorizontalScrollRange10242);
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeHorizontalScrollOffset10243;
		protected override int computeHorizontalScrollOffset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.Gallery._computeHorizontalScrollOffset10243);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._computeHorizontalScrollOffset10243);
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeHorizontalScrollExtent10244;
		protected override int computeHorizontalScrollExtent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.Gallery._computeHorizontalScrollExtent10244);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._computeHorizontalScrollExtent10244);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onLayout10245;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.Gallery._onLayout10245, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._onLayout10245, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchSetSelected10246;
		public override void dispatchSetSelected(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.Gallery._dispatchSetSelected10246, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._dispatchSetSelected10246, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _showContextMenuForChild10247;
		public override bool showContextMenuForChild(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.Gallery._showContextMenuForChild10247, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._showContextMenuForChild10247, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChildDrawingOrder10248;
		protected override int getChildDrawingOrder(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.Gallery._getChildDrawingOrder10248, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._getChildDrawingOrder10248, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChildStaticTransformation10249;
		protected override bool getChildStaticTransformation(android.view.View arg0, android.view.animation.Transformation arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.Gallery._getChildStaticTransformation10249, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._getChildStaticTransformation10249, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _checkLayoutParams10250;
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.Gallery._checkLayoutParams10250, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._checkLayoutParams10250, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _generateLayoutParams10251;
		public override global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.Gallery._generateLayoutParams10251, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._generateLayoutParams10251, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _generateLayoutParams10252;
		protected override global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.Gallery._generateLayoutParams10252, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._generateLayoutParams10252, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _generateDefaultLayoutParams10253;
		protected override global::android.view.ViewGroup.LayoutParams generateDefaultLayoutParams() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.Gallery._generateDefaultLayoutParams10253));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._generateDefaultLayoutParams10253));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onLongPress10254;
		public virtual void onLongPress(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.Gallery._onLongPress10254, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._onLongPress10254, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSingleTapUp10255;
		public virtual bool onSingleTapUp(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.Gallery._onSingleTapUp10255, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._onSingleTapUp10255, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onScroll10256;
		public virtual bool onScroll(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.Gallery._onScroll10256, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._onScroll10256, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onFling10257;
		public virtual bool onFling(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.Gallery._onFling10257, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._onFling10257, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onShowPress10258;
		public virtual void onShowPress(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.Gallery._onShowPress10258, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._onShowPress10258, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDown10259;
		public virtual bool onDown(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.Gallery._onDown10259, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._onDown10259, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCallbackDuringFling10260;
		public virtual void setCallbackDuringFling(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.Gallery._setCallbackDuringFling10260, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._setCallbackDuringFling10260, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAnimationDuration10261;
		public virtual void setAnimationDuration(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.Gallery._setAnimationDuration10261, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._setAnimationDuration10261, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSpacing10262;
		public virtual void setSpacing(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.Gallery._setSpacing10262, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._setSpacing10262, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setUnselectedAlpha10263;
		public virtual void setUnselectedAlpha(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.Gallery._setUnselectedAlpha10263, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._setUnselectedAlpha10263, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Gallery10264;
		public Gallery(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.Gallery.staticClass, global::android.widget.Gallery._Gallery10264, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Gallery10265;
		public Gallery(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.Gallery.staticClass, global::android.widget.Gallery._Gallery10265, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Gallery10266;
		public Gallery(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.Gallery.staticClass, global::android.widget.Gallery._Gallery10266, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.Gallery.staticClass = @__class;
			global::android.widget.Gallery._onKeyDown10233 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.Gallery._onKeyUp10234 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.Gallery._onTouchEvent10235 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.Gallery._dispatchKeyEvent10236 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.widget.Gallery._setGravity10237 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "setGravity", "(I)V");
			global::android.widget.Gallery._showContextMenu10238 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "showContextMenu", "()Z");
			global::android.widget.Gallery._onFocusChanged10239 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.widget.Gallery._dispatchSetPressed10240 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "dispatchSetPressed", "(Z)V");
			global::android.widget.Gallery._getContextMenuInfo10241 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "getContextMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;");
			global::android.widget.Gallery._computeHorizontalScrollRange10242 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "computeHorizontalScrollRange", "()I");
			global::android.widget.Gallery._computeHorizontalScrollOffset10243 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "computeHorizontalScrollOffset", "()I");
			global::android.widget.Gallery._computeHorizontalScrollExtent10244 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "computeHorizontalScrollExtent", "()I");
			global::android.widget.Gallery._onLayout10245 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.Gallery._dispatchSetSelected10246 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "dispatchSetSelected", "(Z)V");
			global::android.widget.Gallery._showContextMenuForChild10247 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "showContextMenuForChild", "(Landroid/view/View;)Z");
			global::android.widget.Gallery._getChildDrawingOrder10248 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "getChildDrawingOrder", "(II)I");
			global::android.widget.Gallery._getChildStaticTransformation10249 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "getChildStaticTransformation", "(Landroid/view/View;Landroid/view/animation/Transformation;)Z");
			global::android.widget.Gallery._checkLayoutParams10250 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z");
			global::android.widget.Gallery._generateLayoutParams10251 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/view/ViewGroup$LayoutParams;");
			global::android.widget.Gallery._generateLayoutParams10252 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;");
			global::android.widget.Gallery._generateDefaultLayoutParams10253 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;");
			global::android.widget.Gallery._onLongPress10254 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "onLongPress", "(Landroid/view/MotionEvent;)V");
			global::android.widget.Gallery._onSingleTapUp10255 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "onSingleTapUp", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.Gallery._onScroll10256 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z");
			global::android.widget.Gallery._onFling10257 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z");
			global::android.widget.Gallery._onShowPress10258 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "onShowPress", "(Landroid/view/MotionEvent;)V");
			global::android.widget.Gallery._onDown10259 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "onDown", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.Gallery._setCallbackDuringFling10260 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "setCallbackDuringFling", "(Z)V");
			global::android.widget.Gallery._setAnimationDuration10261 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "setAnimationDuration", "(I)V");
			global::android.widget.Gallery._setSpacing10262 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "setSpacing", "(I)V");
			global::android.widget.Gallery._setUnselectedAlpha10263 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "setUnselectedAlpha", "(F)V");
			global::android.widget.Gallery._Gallery10264 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.Gallery._Gallery10265 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.Gallery._Gallery10266 = @__env.GetMethodID(global::android.widget.Gallery.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
