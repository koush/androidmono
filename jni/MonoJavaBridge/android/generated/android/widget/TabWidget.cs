namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TabWidget : android.widget.LinearLayout, android.view.View.OnFocusChangeListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TabWidget()
		{
			InitJNI();
		}
		protected TabWidget(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setEnabled17773;
		public override void setEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._setEnabled17773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._setEnabled17773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addView17774;
		public override void addView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._addView17774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._addView17774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged17775;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._onSizeChanged17775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._onSizeChanged17775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchDraw17776;
		public virtual void dispatchDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._dispatchDraw17776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._dispatchDraw17776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChildDrawingOrder17777;
		protected override int getChildDrawingOrder(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TabWidget._getChildDrawingOrder17777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._getChildDrawingOrder17777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _childDrawableStateChanged17778;
		public override void childDrawableStateChanged(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._childDrawableStateChanged17778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._childDrawableStateChanged17778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCurrentTab17779;
		public virtual void setCurrentTab(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._setCurrentTab17779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._setCurrentTab17779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChildTabViewAt17780;
		public virtual global::android.view.View getChildTabViewAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TabWidget._getChildTabViewAt17780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._getChildTabViewAt17780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
		}
		public new int TabCount
		{
			get
			{
				return getTabCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTabCount17781;
		public virtual int getTabCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TabWidget._getTabCount17781);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._getTabCount17781);
		}
		internal static global::MonoJavaBridge.MethodId _setDividerDrawable17782;
		public virtual void setDividerDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._setDividerDrawable17782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._setDividerDrawable17782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDividerDrawable17783;
		public virtual void setDividerDrawable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._setDividerDrawable17783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._setDividerDrawable17783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLeftStripDrawable17784;
		public virtual void setLeftStripDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._setLeftStripDrawable17784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._setLeftStripDrawable17784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLeftStripDrawable17785;
		public virtual void setLeftStripDrawable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._setLeftStripDrawable17785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._setLeftStripDrawable17785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRightStripDrawable17786;
		public virtual void setRightStripDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._setRightStripDrawable17786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._setRightStripDrawable17786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRightStripDrawable17787;
		public virtual void setRightStripDrawable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._setRightStripDrawable17787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._setRightStripDrawable17787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setStripEnabled17788;
		public virtual void setStripEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._setStripEnabled17788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._setStripEnabled17788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isStripEnabled17789;
		public virtual bool isStripEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TabWidget._isStripEnabled17789);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._isStripEnabled17789);
		}
		internal static global::MonoJavaBridge.MethodId _focusCurrentTab17790;
		public virtual void focusCurrentTab(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._focusCurrentTab17790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._focusCurrentTab17790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onFocusChange17791;
		public virtual void onFocusChange(android.view.View arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._onFocusChange17791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._onFocusChange17791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _TabWidget17792;
		public TabWidget(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TabWidget.staticClass, global::android.widget.TabWidget._TabWidget17792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TabWidget17793;
		public TabWidget(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TabWidget.staticClass, global::android.widget.TabWidget._TabWidget17793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TabWidget17794;
		public TabWidget(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TabWidget.staticClass, global::android.widget.TabWidget._TabWidget17794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.TabWidget.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TabWidget"));
			global::android.widget.TabWidget._setEnabled17773 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "setEnabled", "(Z)V");
			global::android.widget.TabWidget._addView17774 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "addView", "(Landroid/view/View;)V");
			global::android.widget.TabWidget._onSizeChanged17775 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "onSizeChanged", "(IIII)V");
			global::android.widget.TabWidget._dispatchDraw17776 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.TabWidget._getChildDrawingOrder17777 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "getChildDrawingOrder", "(II)I");
			global::android.widget.TabWidget._childDrawableStateChanged17778 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "childDrawableStateChanged", "(Landroid/view/View;)V");
			global::android.widget.TabWidget._setCurrentTab17779 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "setCurrentTab", "(I)V");
			global::android.widget.TabWidget._getChildTabViewAt17780 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "getChildTabViewAt", "(I)Landroid/view/View;");
			global::android.widget.TabWidget._getTabCount17781 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "getTabCount", "()I");
			global::android.widget.TabWidget._setDividerDrawable17782 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "setDividerDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.TabWidget._setDividerDrawable17783 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "setDividerDrawable", "(I)V");
			global::android.widget.TabWidget._setLeftStripDrawable17784 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "setLeftStripDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.TabWidget._setLeftStripDrawable17785 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "setLeftStripDrawable", "(I)V");
			global::android.widget.TabWidget._setRightStripDrawable17786 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "setRightStripDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.TabWidget._setRightStripDrawable17787 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "setRightStripDrawable", "(I)V");
			global::android.widget.TabWidget._setStripEnabled17788 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "setStripEnabled", "(Z)V");
			global::android.widget.TabWidget._isStripEnabled17789 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "isStripEnabled", "()Z");
			global::android.widget.TabWidget._focusCurrentTab17790 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "focusCurrentTab", "(I)V");
			global::android.widget.TabWidget._onFocusChange17791 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "onFocusChange", "(Landroid/view/View;Z)V");
			global::android.widget.TabWidget._TabWidget17792 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.TabWidget._TabWidget17793 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.TabWidget._TabWidget17794 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
