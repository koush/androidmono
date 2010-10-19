namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ListView : android.widget.AbsListView
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ListView()
		{
			InitJNI();
		}
		protected ListView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class FixedViewInfo : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static FixedViewInfo()
			{
				InitJNI();
			}
			protected FixedViewInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _FixedViewInfo12070;
			public FixedViewInfo(android.widget.ListView arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ListView.FixedViewInfo.staticClass, global::android.widget.ListView.FixedViewInfo._FixedViewInfo12070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _view12071;
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
			internal static global::MonoJavaBridge.FieldId _data12072;
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
			internal static global::MonoJavaBridge.FieldId _isSelectable12073;
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
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ListView.FixedViewInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ListView$FixedViewInfo"));
				global::android.widget.ListView.FixedViewInfo._FixedViewInfo12070 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.FixedViewInfo.staticClass, "<init>", "(Landroid/widget/ListView;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState12074;
		public override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._onRestoreInstanceState12074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._onRestoreInstanceState12074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState12075;
		public override global::android.os.Parcelable onSaveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ListView._onSaveInstanceState12075)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._onSaveInstanceState12075)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown12076;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._onKeyDown12076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._onKeyDown12076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp12077;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._onKeyUp12077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._onKeyUp12077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyMultiple12078;
		public override bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._onKeyMultiple12078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._onKeyMultiple12078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent12079;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._onTouchEvent12079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._onTouchEvent12079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent12080;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._dispatchKeyEvent12080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._dispatchKeyEvent12080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchPopulateAccessibilityEvent12081;
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._dispatchPopulateAccessibilityEvent12081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._dispatchPopulateAccessibilityEvent12081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onFocusChanged12082;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._onFocusChanged12082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._onFocusChanged12082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged12083;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._onSizeChanged12083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._onSizeChanged12083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchDraw12084;
		protected override void dispatchDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._dispatchDraw12084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._dispatchDraw12084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onFinishInflate12085;
		protected override void onFinishInflate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._onFinishInflate12085);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._onFinishInflate12085);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure12086;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._onMeasure12086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._onMeasure12086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _requestChildRectangleOnScreen12087;
		public override bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._requestChildRectangleOnScreen12087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._requestChildRectangleOnScreen12087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _canAnimate12088;
		protected override bool canAnimate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._canAnimate12088);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._canAnimate12088);
		}
		internal static global::MonoJavaBridge.MethodId _setAdapter12089;
		public virtual void setAdapter(android.widget.ListAdapter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setAdapter12089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setAdapter12089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAdapter12090;
		public override void setAdapter(android.widget.Adapter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setAdapter12090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setAdapter12090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performItemClick12091;
		public override bool performItemClick(android.view.View arg0, int arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._performItemClick12091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._performItemClick12091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::android.widget.Adapter Adapter
		{
			get
			{
				return getAdapter();
			}
			set
			{
				setAdapter(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAdapter12092;
		public override global::android.widget.Adapter getAdapter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.Adapter>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ListView._getAdapter12092)) as android.widget.Adapter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.Adapter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._getAdapter12092)) as android.widget.Adapter;
		}
		internal static global::MonoJavaBridge.MethodId _setSelection12093;
		public override void setSelection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setSelection12093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setSelection12093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MaxScrollAmount
		{
			get
			{
				return getMaxScrollAmount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaxScrollAmount12094;
		public virtual int getMaxScrollAmount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ListView._getMaxScrollAmount12094);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._getMaxScrollAmount12094);
		}
		internal static global::MonoJavaBridge.MethodId _addHeaderView12095;
		public virtual void addHeaderView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._addHeaderView12095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._addHeaderView12095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addHeaderView12096;
		public virtual void addHeaderView(android.view.View arg0, java.lang.Object arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._addHeaderView12096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._addHeaderView12096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new int HeaderViewsCount
		{
			get
			{
				return getHeaderViewsCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderViewsCount12097;
		public virtual int getHeaderViewsCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ListView._getHeaderViewsCount12097);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._getHeaderViewsCount12097);
		}
		internal static global::MonoJavaBridge.MethodId _removeHeaderView12098;
		public virtual bool removeHeaderView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._removeHeaderView12098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._removeHeaderView12098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addFooterView12099;
		public virtual void addFooterView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._addFooterView12099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._addFooterView12099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addFooterView12100;
		public virtual void addFooterView(android.view.View arg0, java.lang.Object arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._addFooterView12100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._addFooterView12100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new int FooterViewsCount
		{
			get
			{
				return getFooterViewsCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFooterViewsCount12101;
		public virtual int getFooterViewsCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ListView._getFooterViewsCount12101);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._getFooterViewsCount12101);
		}
		internal static global::MonoJavaBridge.MethodId _removeFooterView12102;
		public virtual bool removeFooterView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._removeFooterView12102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._removeFooterView12102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _layoutChildren12103;
		protected override void layoutChildren() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._layoutChildren12103);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._layoutChildren12103);
		}
		internal static global::MonoJavaBridge.MethodId _setSelectionFromTop12104;
		public virtual void setSelectionFromTop(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setSelectionFromTop12104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setSelectionFromTop12104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setSelectionAfterHeaderView12105;
		public virtual void setSelectionAfterHeaderView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setSelectionAfterHeaderView12105);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setSelectionAfterHeaderView12105);
		}
		internal static global::MonoJavaBridge.MethodId _setItemsCanFocus12106;
		public virtual void setItemsCanFocus(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setItemsCanFocus12106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setItemsCanFocus12106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool ItemsCanFocus
		{
			get
			{
				return getItemsCanFocus();
			}
			set
			{
				setItemsCanFocus(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getItemsCanFocus12107;
		public virtual bool getItemsCanFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._getItemsCanFocus12107);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._getItemsCanFocus12107);
		}
		internal static global::MonoJavaBridge.MethodId _setCacheColorHint12108;
		public override void setCacheColorHint(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setCacheColorHint12108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setCacheColorHint12108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.drawable.Drawable Divider
		{
			get
			{
				return getDivider();
			}
			set
			{
				setDivider(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDivider12109;
		public virtual global::android.graphics.drawable.Drawable getDivider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ListView._getDivider12109)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._getDivider12109)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _setDivider12110;
		public virtual void setDivider(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setDivider12110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setDivider12110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int DividerHeight
		{
			get
			{
				return getDividerHeight();
			}
			set
			{
				setDividerHeight(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDividerHeight12111;
		public virtual int getDividerHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ListView._getDividerHeight12111);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._getDividerHeight12111);
		}
		internal static global::MonoJavaBridge.MethodId _setDividerHeight12112;
		public virtual void setDividerHeight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setDividerHeight12112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setDividerHeight12112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHeaderDividersEnabled12113;
		public virtual void setHeaderDividersEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setHeaderDividersEnabled12113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setHeaderDividersEnabled12113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFooterDividersEnabled12114;
		public virtual void setFooterDividersEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setFooterDividersEnabled12114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setFooterDividersEnabled12114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _findViewTraversal12115;
		protected virtual global::android.view.View findViewTraversal(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ListView._findViewTraversal12115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._findViewTraversal12115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _findViewWithTagTraversal12116;
		protected virtual global::android.view.View findViewWithTagTraversal(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ListView._findViewWithTagTraversal12116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._findViewWithTagTraversal12116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
		}
		public new int ChoiceMode
		{
			get
			{
				return getChoiceMode();
			}
			set
			{
				setChoiceMode(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChoiceMode12117;
		public virtual int getChoiceMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ListView._getChoiceMode12117);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._getChoiceMode12117);
		}
		internal static global::MonoJavaBridge.MethodId _setChoiceMode12118;
		public virtual void setChoiceMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setChoiceMode12118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setChoiceMode12118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setItemChecked12119;
		public virtual void setItemChecked(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setItemChecked12119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setItemChecked12119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isItemChecked12120;
		public virtual bool isItemChecked(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._isItemChecked12120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._isItemChecked12120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int CheckedItemPosition
		{
			get
			{
				return getCheckedItemPosition();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCheckedItemPosition12121;
		public virtual int getCheckedItemPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ListView._getCheckedItemPosition12121);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._getCheckedItemPosition12121);
		}
		public new global::android.util.SparseBooleanArray CheckedItemPositions
		{
			get
			{
				return getCheckedItemPositions();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCheckedItemPositions12122;
		public virtual global::android.util.SparseBooleanArray getCheckedItemPositions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ListView._getCheckedItemPositions12122)) as android.util.SparseBooleanArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._getCheckedItemPositions12122)) as android.util.SparseBooleanArray;
		}
		public new long[] CheckItemIds
		{
			get
			{
				return getCheckItemIds();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCheckItemIds12123;
		public virtual long[] getCheckItemIds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<long>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ListView._getCheckItemIds12123)) as long[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<long>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._getCheckItemIds12123)) as long[];
		}
		public new long[] CheckedItemIds
		{
			get
			{
				return getCheckedItemIds();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCheckedItemIds12124;
		public virtual long[] getCheckedItemIds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<long>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ListView._getCheckedItemIds12124)) as long[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<long>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._getCheckedItemIds12124)) as long[];
		}
		internal static global::MonoJavaBridge.MethodId _clearChoices12125;
		public virtual void clearChoices() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._clearChoices12125);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._clearChoices12125);
		}
		internal static global::MonoJavaBridge.MethodId _ListView12126;
		public ListView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ListView.staticClass, global::android.widget.ListView._ListView12126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ListView12127;
		public ListView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ListView.staticClass, global::android.widget.ListView._ListView12127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ListView12128;
		public ListView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ListView.staticClass, global::android.widget.ListView._ListView12128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ListView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ListView"));
			global::android.widget.ListView._onRestoreInstanceState12074 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.widget.ListView._onSaveInstanceState12075 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.widget.ListView._onKeyDown12076 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.ListView._onKeyUp12077 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.ListView._onKeyMultiple12078 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z");
			global::android.widget.ListView._onTouchEvent12079 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.ListView._dispatchKeyEvent12080 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.widget.ListView._dispatchPopulateAccessibilityEvent12081 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.widget.ListView._onFocusChanged12082 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.widget.ListView._onSizeChanged12083 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "onSizeChanged", "(IIII)V");
			global::android.widget.ListView._dispatchDraw12084 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.ListView._onFinishInflate12085 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "onFinishInflate", "()V");
			global::android.widget.ListView._onMeasure12086 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "onMeasure", "(II)V");
			global::android.widget.ListView._requestChildRectangleOnScreen12087 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z");
			global::android.widget.ListView._canAnimate12088 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "canAnimate", "()Z");
			global::android.widget.ListView._setAdapter12089 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setAdapter", "(Landroid/widget/ListAdapter;)V");
			global::android.widget.ListView._setAdapter12090 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setAdapter", "(Landroid/widget/Adapter;)V");
			global::android.widget.ListView._performItemClick12091 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "performItemClick", "(Landroid/view/View;IJ)Z");
			global::android.widget.ListView._getAdapter12092 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "getAdapter", "()Landroid/widget/Adapter;");
			global::android.widget.ListView._setSelection12093 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setSelection", "(I)V");
			global::android.widget.ListView._getMaxScrollAmount12094 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "getMaxScrollAmount", "()I");
			global::android.widget.ListView._addHeaderView12095 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "addHeaderView", "(Landroid/view/View;)V");
			global::android.widget.ListView._addHeaderView12096 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "addHeaderView", "(Landroid/view/View;Ljava/lang/Object;Z)V");
			global::android.widget.ListView._getHeaderViewsCount12097 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "getHeaderViewsCount", "()I");
			global::android.widget.ListView._removeHeaderView12098 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "removeHeaderView", "(Landroid/view/View;)Z");
			global::android.widget.ListView._addFooterView12099 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "addFooterView", "(Landroid/view/View;)V");
			global::android.widget.ListView._addFooterView12100 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "addFooterView", "(Landroid/view/View;Ljava/lang/Object;Z)V");
			global::android.widget.ListView._getFooterViewsCount12101 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "getFooterViewsCount", "()I");
			global::android.widget.ListView._removeFooterView12102 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "removeFooterView", "(Landroid/view/View;)Z");
			global::android.widget.ListView._layoutChildren12103 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "layoutChildren", "()V");
			global::android.widget.ListView._setSelectionFromTop12104 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setSelectionFromTop", "(II)V");
			global::android.widget.ListView._setSelectionAfterHeaderView12105 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setSelectionAfterHeaderView", "()V");
			global::android.widget.ListView._setItemsCanFocus12106 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setItemsCanFocus", "(Z)V");
			global::android.widget.ListView._getItemsCanFocus12107 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "getItemsCanFocus", "()Z");
			global::android.widget.ListView._setCacheColorHint12108 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setCacheColorHint", "(I)V");
			global::android.widget.ListView._getDivider12109 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "getDivider", "()Landroid/graphics/drawable/Drawable;");
			global::android.widget.ListView._setDivider12110 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setDivider", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ListView._getDividerHeight12111 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "getDividerHeight", "()I");
			global::android.widget.ListView._setDividerHeight12112 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setDividerHeight", "(I)V");
			global::android.widget.ListView._setHeaderDividersEnabled12113 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setHeaderDividersEnabled", "(Z)V");
			global::android.widget.ListView._setFooterDividersEnabled12114 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setFooterDividersEnabled", "(Z)V");
			global::android.widget.ListView._findViewTraversal12115 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "findViewTraversal", "(I)Landroid/view/View;");
			global::android.widget.ListView._findViewWithTagTraversal12116 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "findViewWithTagTraversal", "(Ljava/lang/Object;)Landroid/view/View;");
			global::android.widget.ListView._getChoiceMode12117 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "getChoiceMode", "()I");
			global::android.widget.ListView._setChoiceMode12118 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setChoiceMode", "(I)V");
			global::android.widget.ListView._setItemChecked12119 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setItemChecked", "(IZ)V");
			global::android.widget.ListView._isItemChecked12120 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "isItemChecked", "(I)Z");
			global::android.widget.ListView._getCheckedItemPosition12121 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "getCheckedItemPosition", "()I");
			global::android.widget.ListView._getCheckedItemPositions12122 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "getCheckedItemPositions", "()Landroid/util/SparseBooleanArray;");
			global::android.widget.ListView._getCheckItemIds12123 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "getCheckItemIds", "()[J");
			global::android.widget.ListView._getCheckedItemIds12124 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "getCheckedItemIds", "()[J");
			global::android.widget.ListView._clearChoices12125 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "clearChoices", "()V");
			global::android.widget.ListView._ListView12126 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.ListView._ListView12127 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.ListView._ListView12128 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
