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
		internal static global::MonoJavaBridge.MethodId _setEnabled12586;
		public override void setEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._setEnabled12586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._setEnabled12586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addView12587;
		public override void addView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._addView12587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._addView12587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged12588;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._onSizeChanged12588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._onSizeChanged12588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchDraw12589;
		public virtual void dispatchDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._dispatchDraw12589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._dispatchDraw12589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChildDrawingOrder12590;
		protected override int getChildDrawingOrder(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TabWidget._getChildDrawingOrder12590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._getChildDrawingOrder12590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _childDrawableStateChanged12591;
		public override void childDrawableStateChanged(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._childDrawableStateChanged12591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._childDrawableStateChanged12591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCurrentTab12592;
		public virtual void setCurrentTab(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._setCurrentTab12592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._setCurrentTab12592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChildTabViewAt12593;
		public virtual global::android.view.View getChildTabViewAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TabWidget._getChildTabViewAt12593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._getChildTabViewAt12593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
		}
		public new int TabCount
		{
			get
			{
				return getTabCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTabCount12594;
		public virtual int getTabCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TabWidget._getTabCount12594);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._getTabCount12594);
		}
		internal static global::MonoJavaBridge.MethodId _setDividerDrawable12595;
		public virtual void setDividerDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._setDividerDrawable12595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._setDividerDrawable12595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDividerDrawable12596;
		public virtual void setDividerDrawable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._setDividerDrawable12596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._setDividerDrawable12596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLeftStripDrawable12597;
		public virtual void setLeftStripDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._setLeftStripDrawable12597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._setLeftStripDrawable12597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLeftStripDrawable12598;
		public virtual void setLeftStripDrawable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._setLeftStripDrawable12598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._setLeftStripDrawable12598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRightStripDrawable12599;
		public virtual void setRightStripDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._setRightStripDrawable12599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._setRightStripDrawable12599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRightStripDrawable12600;
		public virtual void setRightStripDrawable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._setRightStripDrawable12600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._setRightStripDrawable12600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setStripEnabled12601;
		public virtual void setStripEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._setStripEnabled12601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._setStripEnabled12601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isStripEnabled12602;
		public virtual bool isStripEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TabWidget._isStripEnabled12602);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._isStripEnabled12602);
		}
		internal static global::MonoJavaBridge.MethodId _focusCurrentTab12603;
		public virtual void focusCurrentTab(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._focusCurrentTab12603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._focusCurrentTab12603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onFocusChange12604;
		public virtual void onFocusChange(android.view.View arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._onFocusChange12604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._onFocusChange12604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _TabWidget12605;
		public TabWidget(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TabWidget.staticClass, global::android.widget.TabWidget._TabWidget12605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TabWidget12606;
		public TabWidget(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TabWidget.staticClass, global::android.widget.TabWidget._TabWidget12606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TabWidget12607;
		public TabWidget(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TabWidget.staticClass, global::android.widget.TabWidget._TabWidget12607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.TabWidget.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TabWidget"));
			global::android.widget.TabWidget._setEnabled12586 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "setEnabled", "(Z)V");
			global::android.widget.TabWidget._addView12587 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "addView", "(Landroid/view/View;)V");
			global::android.widget.TabWidget._onSizeChanged12588 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "onSizeChanged", "(IIII)V");
			global::android.widget.TabWidget._dispatchDraw12589 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.TabWidget._getChildDrawingOrder12590 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "getChildDrawingOrder", "(II)I");
			global::android.widget.TabWidget._childDrawableStateChanged12591 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "childDrawableStateChanged", "(Landroid/view/View;)V");
			global::android.widget.TabWidget._setCurrentTab12592 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "setCurrentTab", "(I)V");
			global::android.widget.TabWidget._getChildTabViewAt12593 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "getChildTabViewAt", "(I)Landroid/view/View;");
			global::android.widget.TabWidget._getTabCount12594 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "getTabCount", "()I");
			global::android.widget.TabWidget._setDividerDrawable12595 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "setDividerDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.TabWidget._setDividerDrawable12596 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "setDividerDrawable", "(I)V");
			global::android.widget.TabWidget._setLeftStripDrawable12597 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "setLeftStripDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.TabWidget._setLeftStripDrawable12598 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "setLeftStripDrawable", "(I)V");
			global::android.widget.TabWidget._setRightStripDrawable12599 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "setRightStripDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.TabWidget._setRightStripDrawable12600 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "setRightStripDrawable", "(I)V");
			global::android.widget.TabWidget._setStripEnabled12601 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "setStripEnabled", "(Z)V");
			global::android.widget.TabWidget._isStripEnabled12602 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "isStripEnabled", "()Z");
			global::android.widget.TabWidget._focusCurrentTab12603 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "focusCurrentTab", "(I)V");
			global::android.widget.TabWidget._onFocusChange12604 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "onFocusChange", "(Landroid/view/View;Z)V");
			global::android.widget.TabWidget._TabWidget12605 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.TabWidget._TabWidget12606 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.TabWidget._TabWidget12607 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
