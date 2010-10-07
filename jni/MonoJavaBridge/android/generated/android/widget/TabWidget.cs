namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class TabWidget : android.widget.LinearLayout, android.view.View.OnFocusChangeListener
	{
		internal new static global::java.lang.Class staticClass;
		static TabWidget()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.TabWidget), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.TabWidget(@__env);
			}
		}
		protected TabWidget(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _setEnabled11653;
		public override void setEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TabWidget._setEnabled11653, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._setEnabled11653, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addView11654;
		public override void addView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TabWidget._addView11654, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._addView11654, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSizeChanged11655;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TabWidget._onSizeChanged11655, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._onSizeChanged11655, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchDraw11656;
		public virtual new void dispatchDraw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TabWidget._dispatchDraw11656, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._dispatchDraw11656, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChildDrawingOrder11657;
		protected override int getChildDrawingOrder(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.TabWidget._getChildDrawingOrder11657, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._getChildDrawingOrder11657, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _childDrawableStateChanged11658;
		public override void childDrawableStateChanged(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TabWidget._childDrawableStateChanged11658, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._childDrawableStateChanged11658, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCurrentTab11659;
		public virtual void setCurrentTab(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TabWidget._setCurrentTab11659, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._setCurrentTab11659, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChildTabViewAt11660;
		public virtual global::android.view.View getChildTabViewAt(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TabWidget._getChildTabViewAt11660, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._getChildTabViewAt11660, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTabCount11661;
		public virtual int getTabCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.TabWidget._getTabCount11661);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._getTabCount11661);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDividerDrawable11662;
		public virtual void setDividerDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TabWidget._setDividerDrawable11662, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._setDividerDrawable11662, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDividerDrawable11663;
		public virtual void setDividerDrawable(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TabWidget._setDividerDrawable11663, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._setDividerDrawable11663, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLeftStripDrawable11664;
		public virtual void setLeftStripDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TabWidget._setLeftStripDrawable11664, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._setLeftStripDrawable11664, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLeftStripDrawable11665;
		public virtual void setLeftStripDrawable(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TabWidget._setLeftStripDrawable11665, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._setLeftStripDrawable11665, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setRightStripDrawable11666;
		public virtual void setRightStripDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TabWidget._setRightStripDrawable11666, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._setRightStripDrawable11666, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setRightStripDrawable11667;
		public virtual void setRightStripDrawable(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TabWidget._setRightStripDrawable11667, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._setRightStripDrawable11667, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStripEnabled11668;
		public virtual void setStripEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TabWidget._setStripEnabled11668, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._setStripEnabled11668, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isStripEnabled11669;
		public virtual bool isStripEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.TabWidget._isStripEnabled11669);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._isStripEnabled11669);
		}
		internal static global::net.sf.jni4net.jni.MethodId _focusCurrentTab11670;
		public virtual void focusCurrentTab(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TabWidget._focusCurrentTab11670, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._focusCurrentTab11670, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onFocusChange11671;
		public virtual void onFocusChange(android.view.View arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TabWidget._onFocusChange11671, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TabWidget.staticClass, global::android.widget.TabWidget._onFocusChange11671, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _TabWidget11672;
		public TabWidget(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.TabWidget.staticClass, global::android.widget.TabWidget._TabWidget11672, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _TabWidget11673;
		public TabWidget(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.TabWidget.staticClass, global::android.widget.TabWidget._TabWidget11673, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _TabWidget11674;
		public TabWidget(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.TabWidget.staticClass, global::android.widget.TabWidget._TabWidget11674, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.TabWidget.staticClass = @__class;
			global::android.widget.TabWidget._setEnabled11653 = @__env.GetMethodID(global::android.widget.TabWidget.staticClass, "setEnabled", "(Z)V");
			global::android.widget.TabWidget._addView11654 = @__env.GetMethodID(global::android.widget.TabWidget.staticClass, "addView", "(Landroid/view/View;)V");
			global::android.widget.TabWidget._onSizeChanged11655 = @__env.GetMethodID(global::android.widget.TabWidget.staticClass, "onSizeChanged", "(IIII)V");
			global::android.widget.TabWidget._dispatchDraw11656 = @__env.GetMethodID(global::android.widget.TabWidget.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.TabWidget._getChildDrawingOrder11657 = @__env.GetMethodID(global::android.widget.TabWidget.staticClass, "getChildDrawingOrder", "(II)I");
			global::android.widget.TabWidget._childDrawableStateChanged11658 = @__env.GetMethodID(global::android.widget.TabWidget.staticClass, "childDrawableStateChanged", "(Landroid/view/View;)V");
			global::android.widget.TabWidget._setCurrentTab11659 = @__env.GetMethodID(global::android.widget.TabWidget.staticClass, "setCurrentTab", "(I)V");
			global::android.widget.TabWidget._getChildTabViewAt11660 = @__env.GetMethodID(global::android.widget.TabWidget.staticClass, "getChildTabViewAt", "(I)Landroid/view/View;");
			global::android.widget.TabWidget._getTabCount11661 = @__env.GetMethodID(global::android.widget.TabWidget.staticClass, "getTabCount", "()I");
			global::android.widget.TabWidget._setDividerDrawable11662 = @__env.GetMethodID(global::android.widget.TabWidget.staticClass, "setDividerDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.TabWidget._setDividerDrawable11663 = @__env.GetMethodID(global::android.widget.TabWidget.staticClass, "setDividerDrawable", "(I)V");
			global::android.widget.TabWidget._setLeftStripDrawable11664 = @__env.GetMethodID(global::android.widget.TabWidget.staticClass, "setLeftStripDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.TabWidget._setLeftStripDrawable11665 = @__env.GetMethodID(global::android.widget.TabWidget.staticClass, "setLeftStripDrawable", "(I)V");
			global::android.widget.TabWidget._setRightStripDrawable11666 = @__env.GetMethodID(global::android.widget.TabWidget.staticClass, "setRightStripDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.TabWidget._setRightStripDrawable11667 = @__env.GetMethodID(global::android.widget.TabWidget.staticClass, "setRightStripDrawable", "(I)V");
			global::android.widget.TabWidget._setStripEnabled11668 = @__env.GetMethodID(global::android.widget.TabWidget.staticClass, "setStripEnabled", "(Z)V");
			global::android.widget.TabWidget._isStripEnabled11669 = @__env.GetMethodID(global::android.widget.TabWidget.staticClass, "isStripEnabled", "()Z");
			global::android.widget.TabWidget._focusCurrentTab11670 = @__env.GetMethodID(global::android.widget.TabWidget.staticClass, "focusCurrentTab", "(I)V");
			global::android.widget.TabWidget._onFocusChange11671 = @__env.GetMethodID(global::android.widget.TabWidget.staticClass, "onFocusChange", "(Landroid/view/View;Z)V");
			global::android.widget.TabWidget._TabWidget11672 = @__env.GetMethodID(global::android.widget.TabWidget.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.TabWidget._TabWidget11673 = @__env.GetMethodID(global::android.widget.TabWidget.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.TabWidget._TabWidget11674 = @__env.GetMethodID(global::android.widget.TabWidget.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
