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
		internal static global::MonoJavaBridge.MethodId _setEnabled17888;
		public override void setEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._setEnabled17888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._setEnabled17888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addView17889;
		public override void addView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._addView17889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._addView17889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged17890;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._onSizeChanged17890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._onSizeChanged17890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchDraw17891;
		public virtual void dispatchDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._dispatchDraw17891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._dispatchDraw17891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChildDrawingOrder17892;
		protected override int getChildDrawingOrder(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TabWidget._getChildDrawingOrder17892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._getChildDrawingOrder17892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _childDrawableStateChanged17893;
		public override void childDrawableStateChanged(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._childDrawableStateChanged17893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._childDrawableStateChanged17893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCurrentTab17894;
		public virtual void setCurrentTab(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._setCurrentTab17894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._setCurrentTab17894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChildTabViewAt17895;
		public virtual global::android.view.View getChildTabViewAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TabWidget._getChildTabViewAt17895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._getChildTabViewAt17895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
		}
		public new int TabCount
		{
			get
			{
				return getTabCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTabCount17896;
		public virtual int getTabCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TabWidget._getTabCount17896);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._getTabCount17896);
		}
		internal static global::MonoJavaBridge.MethodId _setDividerDrawable17897;
		public virtual void setDividerDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._setDividerDrawable17897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._setDividerDrawable17897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDividerDrawable17898;
		public virtual void setDividerDrawable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._setDividerDrawable17898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._setDividerDrawable17898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLeftStripDrawable17899;
		public virtual void setLeftStripDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._setLeftStripDrawable17899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._setLeftStripDrawable17899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLeftStripDrawable17900;
		public virtual void setLeftStripDrawable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._setLeftStripDrawable17900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._setLeftStripDrawable17900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRightStripDrawable17901;
		public virtual void setRightStripDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._setRightStripDrawable17901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._setRightStripDrawable17901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRightStripDrawable17902;
		public virtual void setRightStripDrawable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._setRightStripDrawable17902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._setRightStripDrawable17902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setStripEnabled17903;
		public virtual void setStripEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._setStripEnabled17903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._setStripEnabled17903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isStripEnabled17904;
		public virtual bool isStripEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TabWidget._isStripEnabled17904);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._isStripEnabled17904);
		}
		internal static global::MonoJavaBridge.MethodId _focusCurrentTab17905;
		public virtual void focusCurrentTab(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._focusCurrentTab17905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._focusCurrentTab17905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onFocusChange17906;
		public virtual void onFocusChange(android.view.View arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabWidget._onFocusChange17906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._onFocusChange17906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _TabWidget17907;
		public TabWidget(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TabWidget.staticClass, global::android.widget.TabWidget._TabWidget17907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TabWidget17908;
		public TabWidget(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TabWidget.staticClass, global::android.widget.TabWidget._TabWidget17908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TabWidget17909;
		public TabWidget(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TabWidget.staticClass, global::android.widget.TabWidget._TabWidget17909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.TabWidget.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TabWidget"));
			global::android.widget.TabWidget._setEnabled17888 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "setEnabled", "(Z)V");
			global::android.widget.TabWidget._addView17889 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "addView", "(Landroid/view/View;)V");
			global::android.widget.TabWidget._onSizeChanged17890 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "onSizeChanged", "(IIII)V");
			global::android.widget.TabWidget._dispatchDraw17891 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.TabWidget._getChildDrawingOrder17892 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "getChildDrawingOrder", "(II)I");
			global::android.widget.TabWidget._childDrawableStateChanged17893 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "childDrawableStateChanged", "(Landroid/view/View;)V");
			global::android.widget.TabWidget._setCurrentTab17894 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "setCurrentTab", "(I)V");
			global::android.widget.TabWidget._getChildTabViewAt17895 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "getChildTabViewAt", "(I)Landroid/view/View;");
			global::android.widget.TabWidget._getTabCount17896 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "getTabCount", "()I");
			global::android.widget.TabWidget._setDividerDrawable17897 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "setDividerDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.TabWidget._setDividerDrawable17898 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "setDividerDrawable", "(I)V");
			global::android.widget.TabWidget._setLeftStripDrawable17899 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "setLeftStripDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.TabWidget._setLeftStripDrawable17900 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "setLeftStripDrawable", "(I)V");
			global::android.widget.TabWidget._setRightStripDrawable17901 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "setRightStripDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.TabWidget._setRightStripDrawable17902 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "setRightStripDrawable", "(I)V");
			global::android.widget.TabWidget._setStripEnabled17903 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "setStripEnabled", "(Z)V");
			global::android.widget.TabWidget._isStripEnabled17904 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "isStripEnabled", "()Z");
			global::android.widget.TabWidget._focusCurrentTab17905 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "focusCurrentTab", "(I)V");
			global::android.widget.TabWidget._onFocusChange17906 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "onFocusChange", "(Landroid/view/View;Z)V");
			global::android.widget.TabWidget._TabWidget17907 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.TabWidget._TabWidget17908 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.TabWidget._TabWidget17909 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
