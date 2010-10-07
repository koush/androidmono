namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ListView : android.widget.AbsListView
	{
		internal new static global::java.lang.Class staticClass;
		static ListView()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.ListView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.ListView(@__env);
			}
		}
		protected ListView(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class FixedViewInfo : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static FixedViewInfo()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.ListView.FixedViewInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.ListView.FixedViewInfo(@__env);
				}
			}
			protected FixedViewInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _FixedViewInfo11145;
			public FixedViewInfo(android.widget.ListView arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.ListView.FixedViewInfo.staticClass, global::android.widget.ListView.FixedViewInfo._FixedViewInfo11145, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.FieldId _view11146;
			public global::android.view.View view
			{
				get
				{
					return default(global::android.view.View);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _data11147;
			public global::java.lang.Object data
			{
				get
				{
					return default(global::java.lang.Object);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _isSelectable11148;
			public bool isSelectable
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.ListView.FixedViewInfo.staticClass = @__class;
				global::android.widget.ListView.FixedViewInfo._FixedViewInfo11145 = @__env.GetMethodID(global::android.widget.ListView.FixedViewInfo.staticClass, "<init>", "(Landroid/widget/ListView;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState11149;
		public override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._onRestoreInstanceState11149, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._onRestoreInstanceState11149, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState11150;
		public override global::android.os.Parcelable onSaveInstanceState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ListView._onSaveInstanceState11150));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._onSaveInstanceState11150));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown11151;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ListView._onKeyDown11151, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._onKeyDown11151, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp11152;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ListView._onKeyUp11152, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._onKeyUp11152, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyMultiple11153;
		public override bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ListView._onKeyMultiple11153, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._onKeyMultiple11153, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent11154;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ListView._onTouchEvent11154, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._onTouchEvent11154, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEvent11155;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ListView._dispatchKeyEvent11155, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._dispatchKeyEvent11155, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchPopulateAccessibilityEvent11156;
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ListView._dispatchPopulateAccessibilityEvent11156, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._dispatchPopulateAccessibilityEvent11156, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onFocusChanged11157;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._onFocusChanged11157, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._onFocusChanged11157, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSizeChanged11158;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._onSizeChanged11158, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._onSizeChanged11158, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchDraw11159;
		protected override void dispatchDraw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._dispatchDraw11159, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._dispatchDraw11159, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onFinishInflate11160;
		protected override void onFinishInflate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._onFinishInflate11160);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._onFinishInflate11160);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure11161;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._onMeasure11161, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._onMeasure11161, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestChildRectangleOnScreen11162;
		public override bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ListView._requestChildRectangleOnScreen11162, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._requestChildRectangleOnScreen11162, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _canAnimate11163;
		protected override bool canAnimate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ListView._canAnimate11163);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._canAnimate11163);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAdapter11164;
		public virtual void setAdapter(android.widget.ListAdapter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._setAdapter11164, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._setAdapter11164, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAdapter11165;
		public override void setAdapter(android.widget.Adapter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._setAdapter11165, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._setAdapter11165, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _performItemClick11166;
		public override bool performItemClick(android.view.View arg0, int arg1, long arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ListView._performItemClick11166, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._performItemClick11166, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAdapter11167;
		public override global::android.widget.Adapter getAdapter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.Adapter>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ListView._getAdapter11167));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.Adapter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._getAdapter11167));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSelection11168;
		public override void setSelection(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._setSelection11168, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._setSelection11168, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMaxScrollAmount11169;
		public virtual int getMaxScrollAmount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.ListView._getMaxScrollAmount11169);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._getMaxScrollAmount11169);
		}
		internal static global::net.sf.jni4net.jni.MethodId _addHeaderView11170;
		public virtual void addHeaderView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._addHeaderView11170, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._addHeaderView11170, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addHeaderView11171;
		public virtual void addHeaderView(android.view.View arg0, java.lang.Object arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._addHeaderView11171, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._addHeaderView11171, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHeaderViewsCount11172;
		public virtual int getHeaderViewsCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.ListView._getHeaderViewsCount11172);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._getHeaderViewsCount11172);
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeHeaderView11173;
		public virtual bool removeHeaderView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ListView._removeHeaderView11173, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._removeHeaderView11173, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addFooterView11174;
		public virtual void addFooterView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._addFooterView11174, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._addFooterView11174, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addFooterView11175;
		public virtual void addFooterView(android.view.View arg0, java.lang.Object arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._addFooterView11175, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._addFooterView11175, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFooterViewsCount11176;
		public virtual int getFooterViewsCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.ListView._getFooterViewsCount11176);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._getFooterViewsCount11176);
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeFooterView11177;
		public virtual bool removeFooterView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ListView._removeFooterView11177, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._removeFooterView11177, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _layoutChildren11178;
		protected override void layoutChildren() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._layoutChildren11178);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._layoutChildren11178);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSelectionFromTop11179;
		public virtual void setSelectionFromTop(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._setSelectionFromTop11179, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._setSelectionFromTop11179, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSelectionAfterHeaderView11180;
		public virtual void setSelectionAfterHeaderView() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._setSelectionAfterHeaderView11180);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._setSelectionAfterHeaderView11180);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setItemsCanFocus11181;
		public virtual void setItemsCanFocus(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._setItemsCanFocus11181, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._setItemsCanFocus11181, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getItemsCanFocus11182;
		public virtual bool getItemsCanFocus() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ListView._getItemsCanFocus11182);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._getItemsCanFocus11182);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCacheColorHint11183;
		public override void setCacheColorHint(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._setCacheColorHint11183, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._setCacheColorHint11183, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDivider11184;
		public virtual global::android.graphics.drawable.Drawable getDivider() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ListView._getDivider11184));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._getDivider11184));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDivider11185;
		public virtual void setDivider(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._setDivider11185, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._setDivider11185, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDividerHeight11186;
		public virtual int getDividerHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.ListView._getDividerHeight11186);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._getDividerHeight11186);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDividerHeight11187;
		public virtual void setDividerHeight(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._setDividerHeight11187, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._setDividerHeight11187, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHeaderDividersEnabled11188;
		public virtual void setHeaderDividersEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._setHeaderDividersEnabled11188, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._setHeaderDividersEnabled11188, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFooterDividersEnabled11189;
		public virtual void setFooterDividersEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._setFooterDividersEnabled11189, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._setFooterDividersEnabled11189, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _findViewTraversal11190;
		protected virtual global::android.view.View findViewTraversal(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ListView._findViewTraversal11190, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._findViewTraversal11190, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _findViewWithTagTraversal11191;
		protected virtual global::android.view.View findViewWithTagTraversal(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ListView._findViewWithTagTraversal11191, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._findViewWithTagTraversal11191, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChoiceMode11192;
		public virtual int getChoiceMode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.ListView._getChoiceMode11192);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._getChoiceMode11192);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setChoiceMode11193;
		public virtual void setChoiceMode(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._setChoiceMode11193, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._setChoiceMode11193, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setItemChecked11194;
		public virtual void setItemChecked(int arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._setItemChecked11194, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._setItemChecked11194, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isItemChecked11195;
		public virtual bool isItemChecked(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ListView._isItemChecked11195, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._isItemChecked11195, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCheckedItemPosition11196;
		public virtual int getCheckedItemPosition() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.ListView._getCheckedItemPosition11196);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._getCheckedItemPosition11196);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCheckedItemPositions11197;
		public virtual global::android.util.SparseBooleanArray getCheckedItemPositions() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.SparseBooleanArray>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ListView._getCheckedItemPositions11197));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.SparseBooleanArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._getCheckedItemPositions11197));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCheckItemIds11198;
		public virtual long[] getCheckItemIds() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ListView._getCheckItemIds11198));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._getCheckItemIds11198));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCheckedItemIds11199;
		public virtual long[] getCheckedItemIds() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ListView._getCheckedItemIds11199));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._getCheckedItemIds11199));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearChoices11200;
		public virtual void clearChoices() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._clearChoices11200);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._clearChoices11200);
		}
		internal static global::net.sf.jni4net.jni.MethodId _ListView11201;
		public ListView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ListView.staticClass, global::android.widget.ListView._ListView11201, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ListView11202;
		public ListView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ListView.staticClass, global::android.widget.ListView._ListView11202, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ListView11203;
		public ListView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ListView.staticClass, global::android.widget.ListView._ListView11203, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		public static int CHOICE_MODE_NONE
		{
			get
			{
				return 0;
			}
		}
		public static int CHOICE_MODE_SINGLE
		{
			get
			{
				return 1;
			}
		}
		public static int CHOICE_MODE_MULTIPLE
		{
			get
			{
				return 2;
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.ListView.staticClass = @__class;
			global::android.widget.ListView._onRestoreInstanceState11149 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.widget.ListView._onSaveInstanceState11150 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.widget.ListView._onKeyDown11151 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.ListView._onKeyUp11152 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.ListView._onKeyMultiple11153 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z");
			global::android.widget.ListView._onTouchEvent11154 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.ListView._dispatchKeyEvent11155 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.widget.ListView._dispatchPopulateAccessibilityEvent11156 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.widget.ListView._onFocusChanged11157 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.widget.ListView._onSizeChanged11158 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "onSizeChanged", "(IIII)V");
			global::android.widget.ListView._dispatchDraw11159 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.ListView._onFinishInflate11160 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "onFinishInflate", "()V");
			global::android.widget.ListView._onMeasure11161 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "onMeasure", "(II)V");
			global::android.widget.ListView._requestChildRectangleOnScreen11162 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z");
			global::android.widget.ListView._canAnimate11163 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "canAnimate", "()Z");
			global::android.widget.ListView._setAdapter11164 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setAdapter", "(Landroid/widget/ListAdapter;)V");
			global::android.widget.ListView._setAdapter11165 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setAdapter", "(Landroid/widget/Adapter;)V");
			global::android.widget.ListView._performItemClick11166 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "performItemClick", "(Landroid/view/View;IJ)Z");
			global::android.widget.ListView._getAdapter11167 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "getAdapter", "()Landroid/widget/Adapter;");
			global::android.widget.ListView._setSelection11168 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setSelection", "(I)V");
			global::android.widget.ListView._getMaxScrollAmount11169 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "getMaxScrollAmount", "()I");
			global::android.widget.ListView._addHeaderView11170 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "addHeaderView", "(Landroid/view/View;)V");
			global::android.widget.ListView._addHeaderView11171 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "addHeaderView", "(Landroid/view/View;Ljava/lang/Object;Z)V");
			global::android.widget.ListView._getHeaderViewsCount11172 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "getHeaderViewsCount", "()I");
			global::android.widget.ListView._removeHeaderView11173 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "removeHeaderView", "(Landroid/view/View;)Z");
			global::android.widget.ListView._addFooterView11174 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "addFooterView", "(Landroid/view/View;)V");
			global::android.widget.ListView._addFooterView11175 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "addFooterView", "(Landroid/view/View;Ljava/lang/Object;Z)V");
			global::android.widget.ListView._getFooterViewsCount11176 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "getFooterViewsCount", "()I");
			global::android.widget.ListView._removeFooterView11177 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "removeFooterView", "(Landroid/view/View;)Z");
			global::android.widget.ListView._layoutChildren11178 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "layoutChildren", "()V");
			global::android.widget.ListView._setSelectionFromTop11179 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setSelectionFromTop", "(II)V");
			global::android.widget.ListView._setSelectionAfterHeaderView11180 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setSelectionAfterHeaderView", "()V");
			global::android.widget.ListView._setItemsCanFocus11181 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setItemsCanFocus", "(Z)V");
			global::android.widget.ListView._getItemsCanFocus11182 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "getItemsCanFocus", "()Z");
			global::android.widget.ListView._setCacheColorHint11183 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setCacheColorHint", "(I)V");
			global::android.widget.ListView._getDivider11184 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "getDivider", "()Landroid/graphics/drawable/Drawable;");
			global::android.widget.ListView._setDivider11185 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setDivider", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ListView._getDividerHeight11186 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "getDividerHeight", "()I");
			global::android.widget.ListView._setDividerHeight11187 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setDividerHeight", "(I)V");
			global::android.widget.ListView._setHeaderDividersEnabled11188 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setHeaderDividersEnabled", "(Z)V");
			global::android.widget.ListView._setFooterDividersEnabled11189 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setFooterDividersEnabled", "(Z)V");
			global::android.widget.ListView._findViewTraversal11190 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "findViewTraversal", "(I)Landroid/view/View;");
			global::android.widget.ListView._findViewWithTagTraversal11191 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "findViewWithTagTraversal", "(Ljava/lang/Object;)Landroid/view/View;");
			global::android.widget.ListView._getChoiceMode11192 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "getChoiceMode", "()I");
			global::android.widget.ListView._setChoiceMode11193 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setChoiceMode", "(I)V");
			global::android.widget.ListView._setItemChecked11194 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setItemChecked", "(IZ)V");
			global::android.widget.ListView._isItemChecked11195 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "isItemChecked", "(I)Z");
			global::android.widget.ListView._getCheckedItemPosition11196 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "getCheckedItemPosition", "()I");
			global::android.widget.ListView._getCheckedItemPositions11197 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "getCheckedItemPositions", "()Landroid/util/SparseBooleanArray;");
			global::android.widget.ListView._getCheckItemIds11198 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "getCheckItemIds", "()[J");
			global::android.widget.ListView._getCheckedItemIds11199 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "getCheckedItemIds", "()[J");
			global::android.widget.ListView._clearChoices11200 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "clearChoices", "()V");
			global::android.widget.ListView._ListView11201 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.ListView._ListView11202 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.ListView._ListView11203 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
