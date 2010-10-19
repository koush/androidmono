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
			internal static global::MonoJavaBridge.MethodId _LayoutParams11857;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Gallery.LayoutParams.staticClass, global::android.widget.Gallery.LayoutParams._LayoutParams11857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams11858;
			public LayoutParams(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Gallery.LayoutParams.staticClass, global::android.widget.Gallery.LayoutParams._LayoutParams11858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams11859;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Gallery.LayoutParams.staticClass, global::android.widget.Gallery.LayoutParams._LayoutParams11859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.Gallery.LayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Gallery$LayoutParams"));
				global::android.widget.Gallery.LayoutParams._LayoutParams11857 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::android.widget.Gallery.LayoutParams._LayoutParams11858 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.LayoutParams.staticClass, "<init>", "(II)V");
				global::android.widget.Gallery.LayoutParams._LayoutParams11859 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown11860;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.Gallery._onKeyDown11860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._onKeyDown11860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp11861;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.Gallery._onKeyUp11861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._onKeyUp11861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent11862;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.Gallery._onTouchEvent11862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._onTouchEvent11862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent11863;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.Gallery._dispatchKeyEvent11863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._dispatchKeyEvent11863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setGravity11864;
		public virtual void setGravity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Gallery._setGravity11864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._setGravity11864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _showContextMenu11865;
		public override bool showContextMenu() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.Gallery._showContextMenu11865);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._showContextMenu11865);
		}
		internal static global::MonoJavaBridge.MethodId _onFocusChanged11866;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Gallery._onFocusChanged11866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._onFocusChanged11866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSetPressed11867;
		protected override void dispatchSetPressed(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Gallery._dispatchSetPressed11867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._dispatchSetPressed11867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		protected new global::android.view.ContextMenu_ContextMenuInfo ContextMenuInfo
		{
			get
			{
				return getContextMenuInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContextMenuInfo11868;
		protected override global::android.view.ContextMenu_ContextMenuInfo getContextMenuInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu_ContextMenuInfo>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.Gallery._getContextMenuInfo11868)) as android.view.ContextMenu_ContextMenuInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu_ContextMenuInfo>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._getContextMenuInfo11868)) as android.view.ContextMenu_ContextMenuInfo;
		}
		internal static global::MonoJavaBridge.MethodId _computeHorizontalScrollRange11869;
		protected override int computeHorizontalScrollRange() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Gallery._computeHorizontalScrollRange11869);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._computeHorizontalScrollRange11869);
		}
		internal static global::MonoJavaBridge.MethodId _computeHorizontalScrollOffset11870;
		protected override int computeHorizontalScrollOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Gallery._computeHorizontalScrollOffset11870);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._computeHorizontalScrollOffset11870);
		}
		internal static global::MonoJavaBridge.MethodId _computeHorizontalScrollExtent11871;
		protected override int computeHorizontalScrollExtent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Gallery._computeHorizontalScrollExtent11871);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._computeHorizontalScrollExtent11871);
		}
		internal static global::MonoJavaBridge.MethodId _onLayout11872;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Gallery._onLayout11872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._onLayout11872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSetSelected11873;
		public override void dispatchSetSelected(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Gallery._dispatchSetSelected11873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._dispatchSetSelected11873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _showContextMenuForChild11874;
		public override bool showContextMenuForChild(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.Gallery._showContextMenuForChild11874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._showContextMenuForChild11874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChildDrawingOrder11875;
		protected override int getChildDrawingOrder(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Gallery._getChildDrawingOrder11875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._getChildDrawingOrder11875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getChildStaticTransformation11876;
		protected override bool getChildStaticTransformation(android.view.View arg0, android.view.animation.Transformation arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.Gallery._getChildStaticTransformation11876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._getChildStaticTransformation11876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkLayoutParams11877;
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.Gallery._checkLayoutParams11877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._checkLayoutParams11877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams11878;
		public override global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.Gallery._generateLayoutParams11878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._generateLayoutParams11878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams11879;
		protected override global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.Gallery._generateLayoutParams11879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._generateLayoutParams11879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateDefaultLayoutParams11880;
		protected override global::android.view.ViewGroup.LayoutParams generateDefaultLayoutParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.Gallery._generateDefaultLayoutParams11880)) as android.view.ViewGroup.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._generateDefaultLayoutParams11880)) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _onLongPress11881;
		public virtual void onLongPress(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Gallery._onLongPress11881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._onLongPress11881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSingleTapUp11882;
		public virtual bool onSingleTapUp(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.Gallery._onSingleTapUp11882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._onSingleTapUp11882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onScroll11883;
		public virtual bool onScroll(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.Gallery._onScroll11883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._onScroll11883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onFling11884;
		public virtual bool onFling(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.Gallery._onFling11884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._onFling11884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onShowPress11885;
		public virtual void onShowPress(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Gallery._onShowPress11885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._onShowPress11885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDown11886;
		public virtual bool onDown(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.Gallery._onDown11886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._onDown11886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCallbackDuringFling11887;
		public virtual void setCallbackDuringFling(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Gallery._setCallbackDuringFling11887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._setCallbackDuringFling11887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAnimationDuration11888;
		public virtual void setAnimationDuration(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Gallery._setAnimationDuration11888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._setAnimationDuration11888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSpacing11889;
		public virtual void setSpacing(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Gallery._setSpacing11889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._setSpacing11889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setUnselectedAlpha11890;
		public virtual void setUnselectedAlpha(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Gallery._setUnselectedAlpha11890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Gallery.staticClass, global::android.widget.Gallery._setUnselectedAlpha11890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Gallery11891;
		public Gallery(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Gallery.staticClass, global::android.widget.Gallery._Gallery11891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Gallery11892;
		public Gallery(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Gallery.staticClass, global::android.widget.Gallery._Gallery11892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Gallery11893;
		public Gallery(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Gallery.staticClass, global::android.widget.Gallery._Gallery11893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.Gallery.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Gallery"));
			global::android.widget.Gallery._onKeyDown11860 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.Gallery._onKeyUp11861 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.Gallery._onTouchEvent11862 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.Gallery._dispatchKeyEvent11863 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.widget.Gallery._setGravity11864 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "setGravity", "(I)V");
			global::android.widget.Gallery._showContextMenu11865 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "showContextMenu", "()Z");
			global::android.widget.Gallery._onFocusChanged11866 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.widget.Gallery._dispatchSetPressed11867 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "dispatchSetPressed", "(Z)V");
			global::android.widget.Gallery._getContextMenuInfo11868 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "getContextMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;");
			global::android.widget.Gallery._computeHorizontalScrollRange11869 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "computeHorizontalScrollRange", "()I");
			global::android.widget.Gallery._computeHorizontalScrollOffset11870 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "computeHorizontalScrollOffset", "()I");
			global::android.widget.Gallery._computeHorizontalScrollExtent11871 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "computeHorizontalScrollExtent", "()I");
			global::android.widget.Gallery._onLayout11872 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.Gallery._dispatchSetSelected11873 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "dispatchSetSelected", "(Z)V");
			global::android.widget.Gallery._showContextMenuForChild11874 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "showContextMenuForChild", "(Landroid/view/View;)Z");
			global::android.widget.Gallery._getChildDrawingOrder11875 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "getChildDrawingOrder", "(II)I");
			global::android.widget.Gallery._getChildStaticTransformation11876 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "getChildStaticTransformation", "(Landroid/view/View;Landroid/view/animation/Transformation;)Z");
			global::android.widget.Gallery._checkLayoutParams11877 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z");
			global::android.widget.Gallery._generateLayoutParams11878 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/view/ViewGroup$LayoutParams;");
			global::android.widget.Gallery._generateLayoutParams11879 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;");
			global::android.widget.Gallery._generateDefaultLayoutParams11880 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;");
			global::android.widget.Gallery._onLongPress11881 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "onLongPress", "(Landroid/view/MotionEvent;)V");
			global::android.widget.Gallery._onSingleTapUp11882 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "onSingleTapUp", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.Gallery._onScroll11883 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z");
			global::android.widget.Gallery._onFling11884 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z");
			global::android.widget.Gallery._onShowPress11885 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "onShowPress", "(Landroid/view/MotionEvent;)V");
			global::android.widget.Gallery._onDown11886 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "onDown", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.Gallery._setCallbackDuringFling11887 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "setCallbackDuringFling", "(Z)V");
			global::android.widget.Gallery._setAnimationDuration11888 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "setAnimationDuration", "(I)V");
			global::android.widget.Gallery._setSpacing11889 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "setSpacing", "(I)V");
			global::android.widget.Gallery._setUnselectedAlpha11890 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "setUnselectedAlpha", "(F)V");
			global::android.widget.Gallery._Gallery11891 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.Gallery._Gallery11892 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.Gallery._Gallery11893 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
