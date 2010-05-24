namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class TabWidget : android.widget.LinearLayout, android.view.View.OnFocusChangeListener
	{ 
		internal new static global::java.lang.Class staticClass; 
		static TabWidget() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.TabWidget), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _setEnabled10942; 
		public override void setEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabWidget)) 
				@__env.CallVoidMethod(this, _setEnabled10942, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TabWidget.staticClass, _setEnabled10942, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView10943; 
		public override void addView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabWidget)) 
				@__env.CallVoidMethod(this, _addView10943, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TabWidget.staticClass, _addView10943, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSizeChanged10944; 
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabWidget)) 
				@__env.CallVoidMethod(this, _onSizeChanged10944, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TabWidget.staticClass, _onSizeChanged10944, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchDraw10945; 
		public virtual new void dispatchDraw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabWidget)) 
				@__env.CallVoidMethod(this, _dispatchDraw10945, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TabWidget.staticClass, _dispatchDraw10945, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChildDrawingOrder10946; 
		protected override int getChildDrawingOrder(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabWidget)) 
				return @__env.CallIntMethod(this, _getChildDrawingOrder10946, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.TabWidget.staticClass, _getChildDrawingOrder10946, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _childDrawableStateChanged10947; 
		public override void childDrawableStateChanged(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabWidget)) 
				@__env.CallVoidMethod(this, _childDrawableStateChanged10947, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TabWidget.staticClass, _childDrawableStateChanged10947, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCurrentTab10948; 
		public virtual void setCurrentTab(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabWidget)) 
				@__env.CallVoidMethod(this, _setCurrentTab10948, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TabWidget.staticClass, _setCurrentTab10948, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChildTabViewAt10949; 
		public virtual android.view.View getChildTabViewAt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabWidget)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getChildTabViewAt10949, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TabWidget.staticClass, _getChildTabViewAt10949, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTabCount10950; 
		public virtual int getTabCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabWidget)) 
				return @__env.CallIntMethod(this, _getTabCount10950); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.TabWidget.staticClass, _getTabCount10950); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDividerDrawable10951; 
		public virtual void setDividerDrawable(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabWidget)) 
				@__env.CallVoidMethod(this, _setDividerDrawable10951, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TabWidget.staticClass, _setDividerDrawable10951, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDividerDrawable10952; 
		public virtual void setDividerDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabWidget)) 
				@__env.CallVoidMethod(this, _setDividerDrawable10952, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TabWidget.staticClass, _setDividerDrawable10952, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _focusCurrentTab10953; 
		public virtual void focusCurrentTab(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabWidget)) 
				@__env.CallVoidMethod(this, _focusCurrentTab10953, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TabWidget.staticClass, _focusCurrentTab10953, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFocusChange10954; 
		public virtual void onFocusChange(android.view.View arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabWidget)) 
				@__env.CallVoidMethod(this, _onFocusChange10954, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TabWidget.staticClass, _onFocusChange10954, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TabWidget10955; 
		public TabWidget(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.TabWidget.staticClass, _TabWidget10955, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TabWidget10956; 
		public TabWidget(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.TabWidget.staticClass, _TabWidget10956, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TabWidget10957; 
		public TabWidget(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.TabWidget.staticClass, _TabWidget10957, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.TabWidget.staticClass = @__class; 
			global::android.widget.TabWidget._setEnabled10942 = @__env.GetMethodID(global::android.widget.TabWidget.staticClass, "setEnabled", "(Z)V"); 
			global::android.widget.TabWidget._addView10943 = @__env.GetMethodID(global::android.widget.TabWidget.staticClass, "addView", "(Landroid/view/View;)V"); 
			global::android.widget.TabWidget._onSizeChanged10944 = @__env.GetMethodID(global::android.widget.TabWidget.staticClass, "onSizeChanged", "(IIII)V"); 
			global::android.widget.TabWidget._dispatchDraw10945 = @__env.GetMethodID(global::android.widget.TabWidget.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V"); 
			global::android.widget.TabWidget._getChildDrawingOrder10946 = @__env.GetMethodID(global::android.widget.TabWidget.staticClass, "getChildDrawingOrder", "(II)I"); 
			global::android.widget.TabWidget._childDrawableStateChanged10947 = @__env.GetMethodID(global::android.widget.TabWidget.staticClass, "childDrawableStateChanged", "(Landroid/view/View;)V"); 
			global::android.widget.TabWidget._setCurrentTab10948 = @__env.GetMethodID(global::android.widget.TabWidget.staticClass, "setCurrentTab", "(I)V"); 
			global::android.widget.TabWidget._getChildTabViewAt10949 = @__env.GetMethodID(global::android.widget.TabWidget.staticClass, "getChildTabViewAt", "(I)Landroid/view/View;"); 
			global::android.widget.TabWidget._getTabCount10950 = @__env.GetMethodID(global::android.widget.TabWidget.staticClass, "getTabCount", "()I"); 
			global::android.widget.TabWidget._setDividerDrawable10951 = @__env.GetMethodID(global::android.widget.TabWidget.staticClass, "setDividerDrawable", "(I)V"); 
			global::android.widget.TabWidget._setDividerDrawable10952 = @__env.GetMethodID(global::android.widget.TabWidget.staticClass, "setDividerDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.widget.TabWidget._focusCurrentTab10953 = @__env.GetMethodID(global::android.widget.TabWidget.staticClass, "focusCurrentTab", "(I)V"); 
			global::android.widget.TabWidget._onFocusChange10954 = @__env.GetMethodID(global::android.widget.TabWidget.staticClass, "onFocusChange", "(Landroid/view/View;Z)V"); 
			global::android.widget.TabWidget._TabWidget10955 = @__env.GetMethodID(global::android.widget.TabWidget.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
			global::android.widget.TabWidget._TabWidget10956 = @__env.GetMethodID(global::android.widget.TabWidget.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.TabWidget._TabWidget10957 = @__env.GetMethodID(global::android.widget.TabWidget.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
