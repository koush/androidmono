namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TabWidget : android.widget.LinearLayout, android.view.View.OnFocusChangeListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TabWidget(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new bool Enabled
		{
			set
			{
				setEnabled(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void setEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TabWidget.staticClass, "setEnabled", "(Z)V", ref global::android.widget.TabWidget._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void addView(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TabWidget.staticClass, "addView", "(Landroid/view/View;)V", ref global::android.widget.TabWidget._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TabWidget.staticClass, "onSizeChanged", "(IIII)V", ref global::android.widget.TabWidget._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void dispatchDraw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TabWidget.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V", ref global::android.widget.TabWidget._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected override int getChildDrawingOrder(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TabWidget.staticClass, "getChildDrawingOrder", "(II)I", ref global::android.widget.TabWidget._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override void childDrawableStateChanged(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TabWidget.staticClass, "childDrawableStateChanged", "(Landroid/view/View;)V", ref global::android.widget.TabWidget._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int CurrentTab
		{
			set
			{
				setCurrentTab(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setCurrentTab(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TabWidget.staticClass, "setCurrentTab", "(I)V", ref global::android.widget.TabWidget._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::android.view.View getChildTabViewAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TabWidget.staticClass, "getChildTabViewAt", "(I)Landroid/view/View;", ref global::android.widget.TabWidget._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.View;
		}
		public new int TabCount
		{
			get
			{
				return getTabCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual int getTabCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TabWidget.staticClass, "getTabCount", "()I", ref global::android.widget.TabWidget._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setDividerDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TabWidget.staticClass, "setDividerDrawable", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.widget.TabWidget._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setDividerDrawable(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TabWidget.staticClass, "setDividerDrawable", "(I)V", ref global::android.widget.TabWidget._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setLeftStripDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TabWidget.staticClass, "setLeftStripDrawable", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.widget.TabWidget._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setLeftStripDrawable(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TabWidget.staticClass, "setLeftStripDrawable", "(I)V", ref global::android.widget.TabWidget._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void setRightStripDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TabWidget.staticClass, "setRightStripDrawable", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.widget.TabWidget._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setRightStripDrawable(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TabWidget.staticClass, "setRightStripDrawable", "(I)V", ref global::android.widget.TabWidget._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool StripEnabled
		{
			set
			{
				setStripEnabled(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setStripEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TabWidget.staticClass, "setStripEnabled", "(Z)V", ref global::android.widget.TabWidget._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual bool isStripEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TabWidget.staticClass, "isStripEnabled", "()Z", ref global::android.widget.TabWidget._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void focusCurrentTab(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TabWidget.staticClass, "focusCurrentTab", "(I)V", ref global::android.widget.TabWidget._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void onFocusChange(android.view.View arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TabWidget.staticClass, "onFocusChange", "(Landroid/view/View;Z)V", ref global::android.widget.TabWidget._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public TabWidget(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.TabWidget._m19.native == global::System.IntPtr.Zero)
				global::android.widget.TabWidget._m19 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TabWidget.staticClass, global::android.widget.TabWidget._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public TabWidget(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.TabWidget._m20.native == global::System.IntPtr.Zero)
				global::android.widget.TabWidget._m20 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TabWidget.staticClass, global::android.widget.TabWidget._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public TabWidget(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.TabWidget._m21.native == global::System.IntPtr.Zero)
				global::android.widget.TabWidget._m21 = @__env.GetMethodIDNoThrow(global::android.widget.TabWidget.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TabWidget.staticClass, global::android.widget.TabWidget._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static TabWidget()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.TabWidget.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TabWidget"));
		}
	}
}
