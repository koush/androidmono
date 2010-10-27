namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Gallery : android.widget.AbsSpinner, android.view.GestureDetector.OnGestureListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Gallery()
		{
			InitJNI();
		}
		protected Gallery(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public new partial class LayoutParams : android.view.ViewGroup.LayoutParams
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static LayoutParams()
			{
				InitJNI();
			}
			protected LayoutParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17116;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Gallery.LayoutParams.staticClass, global::android.widget.Gallery.LayoutParams._LayoutParams17116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17117;
			public LayoutParams(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Gallery.LayoutParams.staticClass, global::android.widget.Gallery.LayoutParams._LayoutParams17117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17118;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Gallery.LayoutParams.staticClass, global::android.widget.Gallery.LayoutParams._LayoutParams17118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.Gallery.LayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Gallery$LayoutParams"));
				global::android.widget.Gallery.LayoutParams._LayoutParams17116 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::android.widget.Gallery.LayoutParams._LayoutParams17117 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.LayoutParams.staticClass, "<init>", "(II)V");
				global::android.widget.Gallery.LayoutParams._LayoutParams17118 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown17119;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.Gallery._onKeyDown17119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._onKeyDown17119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp17120;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.Gallery._onKeyUp17120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._onKeyUp17120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent17121;
		public override bool onTouchEvent(android.view.MotionEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.Gallery._onTouchEvent17121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._onTouchEvent17121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent17122;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.Gallery._dispatchKeyEvent17122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._dispatchKeyEvent17122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Gravity
		{
			set
			{
				setGravity(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setGravity17123;
		public virtual void setGravity(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Gallery._setGravity17123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._setGravity17123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _showContextMenu17124;
		public override bool showContextMenu()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.Gallery._showContextMenu17124);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._showContextMenu17124);
		}
		internal static global::MonoJavaBridge.MethodId _onFocusChanged17125;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Gallery._onFocusChanged17125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._onFocusChanged17125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSetPressed17126;
		protected override void dispatchSetPressed(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Gallery._dispatchSetPressed17126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._dispatchSetPressed17126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		protected new global::android.view.ContextMenu_ContextMenuInfo ContextMenuInfo
		{
			get
			{
				return getContextMenuInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContextMenuInfo17127;
		protected override global::android.view.ContextMenu_ContextMenuInfo getContextMenuInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu_ContextMenuInfo>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.Gallery._getContextMenuInfo17127)) as android.view.ContextMenu_ContextMenuInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu_ContextMenuInfo>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._getContextMenuInfo17127)) as android.view.ContextMenu_ContextMenuInfo;
		}
		internal static global::MonoJavaBridge.MethodId _computeHorizontalScrollRange17128;
		protected override int computeHorizontalScrollRange()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Gallery._computeHorizontalScrollRange17128);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._computeHorizontalScrollRange17128);
		}
		internal static global::MonoJavaBridge.MethodId _computeHorizontalScrollOffset17129;
		protected override int computeHorizontalScrollOffset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Gallery._computeHorizontalScrollOffset17129);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._computeHorizontalScrollOffset17129);
		}
		internal static global::MonoJavaBridge.MethodId _computeHorizontalScrollExtent17130;
		protected override int computeHorizontalScrollExtent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Gallery._computeHorizontalScrollExtent17130);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._computeHorizontalScrollExtent17130);
		}
		internal static global::MonoJavaBridge.MethodId _onLayout17131;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Gallery._onLayout17131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._onLayout17131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSetSelected17132;
		public override void dispatchSetSelected(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Gallery._dispatchSetSelected17132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._dispatchSetSelected17132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _showContextMenuForChild17133;
		public override bool showContextMenuForChild(android.view.View arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.Gallery._showContextMenuForChild17133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._showContextMenuForChild17133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChildDrawingOrder17134;
		protected override int getChildDrawingOrder(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Gallery._getChildDrawingOrder17134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._getChildDrawingOrder17134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getChildStaticTransformation17135;
		protected override bool getChildStaticTransformation(android.view.View arg0, android.view.animation.Transformation arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.Gallery._getChildStaticTransformation17135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._getChildStaticTransformation17135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkLayoutParams17136;
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.Gallery._checkLayoutParams17136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._checkLayoutParams17136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams17137;
		public override global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.util.AttributeSet arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.Gallery._generateLayoutParams17137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._generateLayoutParams17137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams17138;
		protected override global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.Gallery._generateLayoutParams17138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._generateLayoutParams17138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateDefaultLayoutParams17139;
		protected override global::android.view.ViewGroup.LayoutParams generateDefaultLayoutParams()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.Gallery._generateDefaultLayoutParams17139)) as android.view.ViewGroup.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._generateDefaultLayoutParams17139)) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _onLongPress17140;
		public virtual void onLongPress(android.view.MotionEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Gallery._onLongPress17140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._onLongPress17140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSingleTapUp17141;
		public virtual bool onSingleTapUp(android.view.MotionEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.Gallery._onSingleTapUp17141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._onSingleTapUp17141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onScroll17142;
		public virtual bool onScroll(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.Gallery._onScroll17142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._onScroll17142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onFling17143;
		public virtual bool onFling(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.Gallery._onFling17143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._onFling17143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onShowPress17144;
		public virtual void onShowPress(android.view.MotionEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Gallery._onShowPress17144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._onShowPress17144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDown17145;
		public virtual bool onDown(android.view.MotionEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.Gallery._onDown17145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._onDown17145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool CallbackDuringFling
		{
			set
			{
				setCallbackDuringFling(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setCallbackDuringFling17146;
		public virtual void setCallbackDuringFling(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Gallery._setCallbackDuringFling17146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._setCallbackDuringFling17146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int AnimationDuration
		{
			set
			{
				setAnimationDuration(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setAnimationDuration17147;
		public virtual void setAnimationDuration(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Gallery._setAnimationDuration17147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._setAnimationDuration17147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Spacing
		{
			set
			{
				setSpacing(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setSpacing17148;
		public virtual void setSpacing(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Gallery._setSpacing17148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._setSpacing17148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float UnselectedAlpha
		{
			set
			{
				setUnselectedAlpha(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setUnselectedAlpha17149;
		public virtual void setUnselectedAlpha(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Gallery._setUnselectedAlpha17149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._setUnselectedAlpha17149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Gallery17150;
		public Gallery(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Gallery.staticClass, global::android.widget.Gallery._Gallery17150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Gallery17151;
		public Gallery(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Gallery.staticClass, global::android.widget.Gallery._Gallery17151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Gallery17152;
		public Gallery(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Gallery.staticClass, global::android.widget.Gallery._Gallery17152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.Gallery.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Gallery"));
			global::android.widget.Gallery._onKeyDown17119 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.Gallery._onKeyUp17120 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.Gallery._onTouchEvent17121 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.Gallery._dispatchKeyEvent17122 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.widget.Gallery._setGravity17123 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "setGravity", "(I)V");
			global::android.widget.Gallery._showContextMenu17124 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "showContextMenu", "()Z");
			global::android.widget.Gallery._onFocusChanged17125 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.widget.Gallery._dispatchSetPressed17126 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "dispatchSetPressed", "(Z)V");
			global::android.widget.Gallery._getContextMenuInfo17127 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "getContextMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;");
			global::android.widget.Gallery._computeHorizontalScrollRange17128 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "computeHorizontalScrollRange", "()I");
			global::android.widget.Gallery._computeHorizontalScrollOffset17129 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "computeHorizontalScrollOffset", "()I");
			global::android.widget.Gallery._computeHorizontalScrollExtent17130 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "computeHorizontalScrollExtent", "()I");
			global::android.widget.Gallery._onLayout17131 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.Gallery._dispatchSetSelected17132 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "dispatchSetSelected", "(Z)V");
			global::android.widget.Gallery._showContextMenuForChild17133 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "showContextMenuForChild", "(Landroid/view/View;)Z");
			global::android.widget.Gallery._getChildDrawingOrder17134 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "getChildDrawingOrder", "(II)I");
			global::android.widget.Gallery._getChildStaticTransformation17135 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "getChildStaticTransformation", "(Landroid/view/View;Landroid/view/animation/Transformation;)Z");
			global::android.widget.Gallery._checkLayoutParams17136 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z");
			global::android.widget.Gallery._generateLayoutParams17137 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/view/ViewGroup$LayoutParams;");
			global::android.widget.Gallery._generateLayoutParams17138 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;");
			global::android.widget.Gallery._generateDefaultLayoutParams17139 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;");
			global::android.widget.Gallery._onLongPress17140 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "onLongPress", "(Landroid/view/MotionEvent;)V");
			global::android.widget.Gallery._onSingleTapUp17141 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "onSingleTapUp", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.Gallery._onScroll17142 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z");
			global::android.widget.Gallery._onFling17143 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z");
			global::android.widget.Gallery._onShowPress17144 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "onShowPress", "(Landroid/view/MotionEvent;)V");
			global::android.widget.Gallery._onDown17145 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "onDown", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.Gallery._setCallbackDuringFling17146 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "setCallbackDuringFling", "(Z)V");
			global::android.widget.Gallery._setAnimationDuration17147 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "setAnimationDuration", "(I)V");
			global::android.widget.Gallery._setSpacing17148 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "setSpacing", "(I)V");
			global::android.widget.Gallery._setUnselectedAlpha17149 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "setUnselectedAlpha", "(F)V");
			global::android.widget.Gallery._Gallery17150 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.Gallery._Gallery17151 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.Gallery._Gallery17152 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
