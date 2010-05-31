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
			internal static global::net.sf.jni4net.jni.MethodId _FixedViewInfo10437;
			public FixedViewInfo(android.widget.ListView arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.ListView.FixedViewInfo.staticClass, global::android.widget.ListView.FixedViewInfo._FixedViewInfo10437, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.FieldId _view10438;
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
			internal static global::net.sf.jni4net.jni.FieldId _data10439;
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
			internal static global::net.sf.jni4net.jni.FieldId _isSelectable10440;
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
				global::android.widget.ListView.FixedViewInfo._FixedViewInfo10437 = @__env.GetMethodID(global::android.widget.ListView.FixedViewInfo.staticClass, "<init>", "(Landroid/widget/ListView;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState10441;
		public override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._onRestoreInstanceState10441, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._onRestoreInstanceState10441, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState10442;
		public override global::android.os.Parcelable onSaveInstanceState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ListView._onSaveInstanceState10442));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._onSaveInstanceState10442));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown10443;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ListView._onKeyDown10443, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._onKeyDown10443, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp10444;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ListView._onKeyUp10444, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._onKeyUp10444, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyMultiple10445;
		public override bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ListView._onKeyMultiple10445, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._onKeyMultiple10445, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent10446;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ListView._onTouchEvent10446, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._onTouchEvent10446, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEvent10447;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ListView._dispatchKeyEvent10447, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._dispatchKeyEvent10447, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchPopulateAccessibilityEvent10448;
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ListView._dispatchPopulateAccessibilityEvent10448, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._dispatchPopulateAccessibilityEvent10448, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onFocusChanged10449;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._onFocusChanged10449, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._onFocusChanged10449, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchDraw10450;
		protected override void dispatchDraw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._dispatchDraw10450, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._dispatchDraw10450, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onFinishInflate10451;
		protected override void onFinishInflate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._onFinishInflate10451);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._onFinishInflate10451);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure10452;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._onMeasure10452, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._onMeasure10452, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestChildRectangleOnScreen10453;
		public override bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ListView._requestChildRectangleOnScreen10453, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._requestChildRectangleOnScreen10453, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _canAnimate10454;
		protected override bool canAnimate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ListView._canAnimate10454);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._canAnimate10454);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAdapter10455;
		public virtual void setAdapter(android.widget.ListAdapter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._setAdapter10455, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._setAdapter10455, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAdapter10456;
		public override void setAdapter(android.widget.Adapter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._setAdapter10456, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._setAdapter10456, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _performItemClick10457;
		public override bool performItemClick(android.view.View arg0, int arg1, long arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ListView._performItemClick10457, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._performItemClick10457, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAdapter10458;
		public override global::android.widget.Adapter getAdapter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.Adapter>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ListView._getAdapter10458));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.Adapter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._getAdapter10458));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSelection10459;
		public override void setSelection(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._setSelection10459, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._setSelection10459, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMaxScrollAmount10460;
		public virtual int getMaxScrollAmount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.ListView._getMaxScrollAmount10460);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._getMaxScrollAmount10460);
		}
		internal static global::net.sf.jni4net.jni.MethodId _addHeaderView10461;
		public virtual void addHeaderView(android.view.View arg0, java.lang.Object arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._addHeaderView10461, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._addHeaderView10461, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addHeaderView10462;
		public virtual void addHeaderView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._addHeaderView10462, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._addHeaderView10462, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHeaderViewsCount10463;
		public virtual int getHeaderViewsCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.ListView._getHeaderViewsCount10463);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._getHeaderViewsCount10463);
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeHeaderView10464;
		public virtual bool removeHeaderView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ListView._removeHeaderView10464, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._removeHeaderView10464, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addFooterView10465;
		public virtual void addFooterView(android.view.View arg0, java.lang.Object arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._addFooterView10465, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._addFooterView10465, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addFooterView10466;
		public virtual void addFooterView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._addFooterView10466, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._addFooterView10466, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFooterViewsCount10467;
		public virtual int getFooterViewsCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.ListView._getFooterViewsCount10467);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._getFooterViewsCount10467);
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeFooterView10468;
		public virtual bool removeFooterView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ListView._removeFooterView10468, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._removeFooterView10468, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _layoutChildren10469;
		protected override void layoutChildren() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._layoutChildren10469);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._layoutChildren10469);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSelectionFromTop10470;
		public virtual void setSelectionFromTop(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._setSelectionFromTop10470, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._setSelectionFromTop10470, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSelectionAfterHeaderView10471;
		public virtual void setSelectionAfterHeaderView() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._setSelectionAfterHeaderView10471);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._setSelectionAfterHeaderView10471);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setItemsCanFocus10472;
		public virtual void setItemsCanFocus(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._setItemsCanFocus10472, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._setItemsCanFocus10472, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getItemsCanFocus10473;
		public virtual bool getItemsCanFocus() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ListView._getItemsCanFocus10473);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._getItemsCanFocus10473);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCacheColorHint10474;
		public override void setCacheColorHint(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._setCacheColorHint10474, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._setCacheColorHint10474, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDivider10475;
		public virtual global::android.graphics.drawable.Drawable getDivider() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ListView._getDivider10475));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._getDivider10475));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDivider10476;
		public virtual void setDivider(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._setDivider10476, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._setDivider10476, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDividerHeight10477;
		public virtual int getDividerHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.ListView._getDividerHeight10477);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._getDividerHeight10477);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDividerHeight10478;
		public virtual void setDividerHeight(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._setDividerHeight10478, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._setDividerHeight10478, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHeaderDividersEnabled10479;
		public virtual void setHeaderDividersEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._setHeaderDividersEnabled10479, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._setHeaderDividersEnabled10479, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFooterDividersEnabled10480;
		public virtual void setFooterDividersEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._setFooterDividersEnabled10480, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._setFooterDividersEnabled10480, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _findViewTraversal10481;
		protected virtual global::android.view.View findViewTraversal(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ListView._findViewTraversal10481, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._findViewTraversal10481, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _findViewWithTagTraversal10482;
		protected virtual global::android.view.View findViewWithTagTraversal(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ListView._findViewWithTagTraversal10482, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._findViewWithTagTraversal10482, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChoiceMode10483;
		public virtual int getChoiceMode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.ListView._getChoiceMode10483);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._getChoiceMode10483);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setChoiceMode10484;
		public virtual void setChoiceMode(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._setChoiceMode10484, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._setChoiceMode10484, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setItemChecked10485;
		public virtual void setItemChecked(int arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._setItemChecked10485, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._setItemChecked10485, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isItemChecked10486;
		public virtual bool isItemChecked(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ListView._isItemChecked10486, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._isItemChecked10486, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCheckedItemPosition10487;
		public virtual int getCheckedItemPosition() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.ListView._getCheckedItemPosition10487);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._getCheckedItemPosition10487);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCheckedItemPositions10488;
		public virtual global::android.util.SparseBooleanArray getCheckedItemPositions() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.SparseBooleanArray>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ListView._getCheckedItemPositions10488));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.SparseBooleanArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._getCheckedItemPositions10488));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCheckItemIds10489;
		public virtual long[] getCheckItemIds() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ListView._getCheckItemIds10489));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._getCheckItemIds10489));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearChoices10490;
		public virtual void clearChoices() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ListView._clearChoices10490);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ListView.staticClass, global::android.widget.ListView._clearChoices10490);
		}
		internal static global::net.sf.jni4net.jni.MethodId _ListView10491;
		public ListView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ListView.staticClass, global::android.widget.ListView._ListView10491, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ListView10492;
		public ListView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ListView.staticClass, global::android.widget.ListView._ListView10492, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ListView10493;
		public ListView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ListView.staticClass, global::android.widget.ListView._ListView10493, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
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
			global::android.widget.ListView._onRestoreInstanceState10441 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.widget.ListView._onSaveInstanceState10442 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.widget.ListView._onKeyDown10443 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.ListView._onKeyUp10444 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.ListView._onKeyMultiple10445 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z");
			global::android.widget.ListView._onTouchEvent10446 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.ListView._dispatchKeyEvent10447 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.widget.ListView._dispatchPopulateAccessibilityEvent10448 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.widget.ListView._onFocusChanged10449 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.widget.ListView._dispatchDraw10450 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.ListView._onFinishInflate10451 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "onFinishInflate", "()V");
			global::android.widget.ListView._onMeasure10452 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "onMeasure", "(II)V");
			global::android.widget.ListView._requestChildRectangleOnScreen10453 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z");
			global::android.widget.ListView._canAnimate10454 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "canAnimate", "()Z");
			global::android.widget.ListView._setAdapter10455 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setAdapter", "(Landroid/widget/ListAdapter;)V");
			global::android.widget.ListView._setAdapter10456 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setAdapter", "(Landroid/widget/Adapter;)V");
			global::android.widget.ListView._performItemClick10457 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "performItemClick", "(Landroid/view/View;IJ)Z");
			global::android.widget.ListView._getAdapter10458 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "getAdapter", "()Landroid/widget/Adapter;");
			global::android.widget.ListView._setSelection10459 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setSelection", "(I)V");
			global::android.widget.ListView._getMaxScrollAmount10460 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "getMaxScrollAmount", "()I");
			global::android.widget.ListView._addHeaderView10461 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "addHeaderView", "(Landroid/view/View;Ljava/lang/Object;Z)V");
			global::android.widget.ListView._addHeaderView10462 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "addHeaderView", "(Landroid/view/View;)V");
			global::android.widget.ListView._getHeaderViewsCount10463 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "getHeaderViewsCount", "()I");
			global::android.widget.ListView._removeHeaderView10464 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "removeHeaderView", "(Landroid/view/View;)Z");
			global::android.widget.ListView._addFooterView10465 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "addFooterView", "(Landroid/view/View;Ljava/lang/Object;Z)V");
			global::android.widget.ListView._addFooterView10466 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "addFooterView", "(Landroid/view/View;)V");
			global::android.widget.ListView._getFooterViewsCount10467 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "getFooterViewsCount", "()I");
			global::android.widget.ListView._removeFooterView10468 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "removeFooterView", "(Landroid/view/View;)Z");
			global::android.widget.ListView._layoutChildren10469 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "layoutChildren", "()V");
			global::android.widget.ListView._setSelectionFromTop10470 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setSelectionFromTop", "(II)V");
			global::android.widget.ListView._setSelectionAfterHeaderView10471 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setSelectionAfterHeaderView", "()V");
			global::android.widget.ListView._setItemsCanFocus10472 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setItemsCanFocus", "(Z)V");
			global::android.widget.ListView._getItemsCanFocus10473 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "getItemsCanFocus", "()Z");
			global::android.widget.ListView._setCacheColorHint10474 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setCacheColorHint", "(I)V");
			global::android.widget.ListView._getDivider10475 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "getDivider", "()Landroid/graphics/drawable/Drawable;");
			global::android.widget.ListView._setDivider10476 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setDivider", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ListView._getDividerHeight10477 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "getDividerHeight", "()I");
			global::android.widget.ListView._setDividerHeight10478 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setDividerHeight", "(I)V");
			global::android.widget.ListView._setHeaderDividersEnabled10479 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setHeaderDividersEnabled", "(Z)V");
			global::android.widget.ListView._setFooterDividersEnabled10480 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setFooterDividersEnabled", "(Z)V");
			global::android.widget.ListView._findViewTraversal10481 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "findViewTraversal", "(I)Landroid/view/View;");
			global::android.widget.ListView._findViewWithTagTraversal10482 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "findViewWithTagTraversal", "(Ljava/lang/Object;)Landroid/view/View;");
			global::android.widget.ListView._getChoiceMode10483 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "getChoiceMode", "()I");
			global::android.widget.ListView._setChoiceMode10484 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setChoiceMode", "(I)V");
			global::android.widget.ListView._setItemChecked10485 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "setItemChecked", "(IZ)V");
			global::android.widget.ListView._isItemChecked10486 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "isItemChecked", "(I)Z");
			global::android.widget.ListView._getCheckedItemPosition10487 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "getCheckedItemPosition", "()I");
			global::android.widget.ListView._getCheckedItemPositions10488 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "getCheckedItemPositions", "()Landroid/util/SparseBooleanArray;");
			global::android.widget.ListView._getCheckItemIds10489 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "getCheckItemIds", "()[J");
			global::android.widget.ListView._clearChoices10490 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "clearChoices", "()V");
			global::android.widget.ListView._ListView10491 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.ListView._ListView10492 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.ListView._ListView10493 = @__env.GetMethodID(global::android.widget.ListView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
