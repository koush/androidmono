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
			internal static global::MonoJavaBridge.MethodId _FixedViewInfo17232;
			public FixedViewInfo(android.widget.ListView arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ListView.FixedViewInfo.staticClass, global::android.widget.ListView.FixedViewInfo._FixedViewInfo17232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _view17233;
			public global::android.view.View view
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _view17233)) as android.view.View;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _data17234;
			public global::java.lang.Object data
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _data17234)) as java.lang.Object;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _isSelectable17235;
			public bool isSelectable
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _isSelectable17235);
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ListView.FixedViewInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ListView$FixedViewInfo"));
				global::android.widget.ListView.FixedViewInfo._FixedViewInfo17232 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.FixedViewInfo.staticClass, "<init>", "(Landroid/widget/ListView;)V");
				global::android.widget.ListView.FixedViewInfo._view17233 = @__env.GetFieldIDNoThrow(global::android.widget.ListView.FixedViewInfo.staticClass, "view", "Landroid/view/View;");
				global::android.widget.ListView.FixedViewInfo._data17234 = @__env.GetFieldIDNoThrow(global::android.widget.ListView.FixedViewInfo.staticClass, "data", "Ljava/lang/Object;");
				global::android.widget.ListView.FixedViewInfo._isSelectable17235 = @__env.GetFieldIDNoThrow(global::android.widget.ListView.FixedViewInfo.staticClass, "isSelectable", "Z");
			}
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState17236;
		public override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._onRestoreInstanceState17236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._onRestoreInstanceState17236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState17237;
		public override global::android.os.Parcelable onSaveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ListView._onSaveInstanceState17237)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._onSaveInstanceState17237)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown17238;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._onKeyDown17238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._onKeyDown17238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp17239;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._onKeyUp17239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._onKeyUp17239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyMultiple17240;
		public override bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._onKeyMultiple17240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._onKeyMultiple17240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent17241;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._onTouchEvent17241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._onTouchEvent17241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent17242;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._dispatchKeyEvent17242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._dispatchKeyEvent17242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchPopulateAccessibilityEvent17243;
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._dispatchPopulateAccessibilityEvent17243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._dispatchPopulateAccessibilityEvent17243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onFocusChanged17244;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._onFocusChanged17244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._onFocusChanged17244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged17245;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._onSizeChanged17245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._onSizeChanged17245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchDraw17246;
		protected override void dispatchDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._dispatchDraw17246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._dispatchDraw17246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onFinishInflate17247;
		protected override void onFinishInflate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._onFinishInflate17247);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._onFinishInflate17247);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure17248;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._onMeasure17248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._onMeasure17248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _requestChildRectangleOnScreen17249;
		public override bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._requestChildRectangleOnScreen17249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._requestChildRectangleOnScreen17249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _canAnimate17250;
		protected override bool canAnimate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._canAnimate17250);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._canAnimate17250);
		}
		internal static global::MonoJavaBridge.MethodId _setAdapter17251;
		public virtual void setAdapter(android.widget.ListAdapter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setAdapter17251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setAdapter17251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAdapter17252;
		public override void setAdapter(android.widget.Adapter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setAdapter17252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setAdapter17252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performItemClick17253;
		public override bool performItemClick(android.view.View arg0, int arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._performItemClick17253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._performItemClick17253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
		internal static global::MonoJavaBridge.MethodId _getAdapter17254;
		public override global::android.widget.Adapter getAdapter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.Adapter>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ListView._getAdapter17254)) as android.widget.Adapter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.Adapter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._getAdapter17254)) as android.widget.Adapter;
		}
		internal static global::MonoJavaBridge.MethodId _setSelection17255;
		public override void setSelection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setSelection17255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setSelection17255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MaxScrollAmount
		{
			get
			{
				return getMaxScrollAmount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaxScrollAmount17256;
		public virtual int getMaxScrollAmount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ListView._getMaxScrollAmount17256);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._getMaxScrollAmount17256);
		}
		internal static global::MonoJavaBridge.MethodId _addHeaderView17257;
		public virtual void addHeaderView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._addHeaderView17257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._addHeaderView17257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addHeaderView17258;
		public virtual void addHeaderView(android.view.View arg0, java.lang.Object arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._addHeaderView17258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._addHeaderView17258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new int HeaderViewsCount
		{
			get
			{
				return getHeaderViewsCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderViewsCount17259;
		public virtual int getHeaderViewsCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ListView._getHeaderViewsCount17259);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._getHeaderViewsCount17259);
		}
		internal static global::MonoJavaBridge.MethodId _removeHeaderView17260;
		public virtual bool removeHeaderView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._removeHeaderView17260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._removeHeaderView17260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addFooterView17261;
		public virtual void addFooterView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._addFooterView17261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._addFooterView17261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addFooterView17262;
		public virtual void addFooterView(android.view.View arg0, java.lang.Object arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._addFooterView17262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._addFooterView17262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new int FooterViewsCount
		{
			get
			{
				return getFooterViewsCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFooterViewsCount17263;
		public virtual int getFooterViewsCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ListView._getFooterViewsCount17263);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._getFooterViewsCount17263);
		}
		internal static global::MonoJavaBridge.MethodId _removeFooterView17264;
		public virtual bool removeFooterView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._removeFooterView17264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._removeFooterView17264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _layoutChildren17265;
		protected override void layoutChildren() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._layoutChildren17265);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._layoutChildren17265);
		}
		internal static global::MonoJavaBridge.MethodId _setSelectionFromTop17266;
		public virtual void setSelectionFromTop(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setSelectionFromTop17266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setSelectionFromTop17266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setSelectionAfterHeaderView17267;
		public virtual void setSelectionAfterHeaderView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setSelectionAfterHeaderView17267);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setSelectionAfterHeaderView17267);
		}
		internal static global::MonoJavaBridge.MethodId _setItemsCanFocus17268;
		public virtual void setItemsCanFocus(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setItemsCanFocus17268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setItemsCanFocus17268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getItemsCanFocus17269;
		public virtual bool getItemsCanFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._getItemsCanFocus17269);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._getItemsCanFocus17269);
		}
		internal static global::MonoJavaBridge.MethodId _setCacheColorHint17270;
		public override void setCacheColorHint(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setCacheColorHint17270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setCacheColorHint17270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDivider17271;
		public virtual global::android.graphics.drawable.Drawable getDivider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ListView._getDivider17271)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._getDivider17271)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _setDivider17272;
		public virtual void setDivider(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setDivider17272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setDivider17272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDividerHeight17273;
		public virtual int getDividerHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ListView._getDividerHeight17273);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._getDividerHeight17273);
		}
		internal static global::MonoJavaBridge.MethodId _setDividerHeight17274;
		public virtual void setDividerHeight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setDividerHeight17274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setDividerHeight17274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHeaderDividersEnabled17275;
		public virtual void setHeaderDividersEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setHeaderDividersEnabled17275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setHeaderDividersEnabled17275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFooterDividersEnabled17276;
		public virtual void setFooterDividersEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setFooterDividersEnabled17276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setFooterDividersEnabled17276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _findViewTraversal17277;
		protected virtual global::android.view.View findViewTraversal(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ListView._findViewTraversal17277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._findViewTraversal17277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _findViewWithTagTraversal17278;
		protected virtual global::android.view.View findViewWithTagTraversal(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ListView._findViewWithTagTraversal17278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._findViewWithTagTraversal17278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
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
		internal static global::MonoJavaBridge.MethodId _getChoiceMode17279;
		public virtual int getChoiceMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ListView._getChoiceMode17279);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._getChoiceMode17279);
		}
		internal static global::MonoJavaBridge.MethodId _setChoiceMode17280;
		public virtual void setChoiceMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setChoiceMode17280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setChoiceMode17280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setItemChecked17281;
		public virtual void setItemChecked(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setItemChecked17281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setItemChecked17281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isItemChecked17282;
		public virtual bool isItemChecked(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._isItemChecked17282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._isItemChecked17282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int CheckedItemPosition
		{
			get
			{
				return getCheckedItemPosition();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCheckedItemPosition17283;
		public virtual int getCheckedItemPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ListView._getCheckedItemPosition17283);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._getCheckedItemPosition17283);
		}
		public new global::android.util.SparseBooleanArray CheckedItemPositions
		{
			get
			{
				return getCheckedItemPositions();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCheckedItemPositions17284;
		public virtual global::android.util.SparseBooleanArray getCheckedItemPositions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ListView._getCheckedItemPositions17284)) as android.util.SparseBooleanArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._getCheckedItemPositions17284)) as android.util.SparseBooleanArray;
		}
		public new long[] CheckItemIds
		{
			get
			{
				return getCheckItemIds();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCheckItemIds17285;
		public virtual long[] getCheckItemIds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<long>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ListView._getCheckItemIds17285)) as long[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<long>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._getCheckItemIds17285)) as long[];
		}
		public new long[] CheckedItemIds
		{
			get
			{
				return getCheckedItemIds();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCheckedItemIds17286;
		public virtual long[] getCheckedItemIds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<long>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ListView._getCheckedItemIds17286)) as long[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<long>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._getCheckedItemIds17286)) as long[];
		}
		internal static global::MonoJavaBridge.MethodId _clearChoices17287;
		public virtual void clearChoices() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._clearChoices17287);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._clearChoices17287);
		}
		internal static global::MonoJavaBridge.MethodId _ListView17288;
		public ListView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ListView.staticClass, global::android.widget.ListView._ListView17288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ListView17289;
		public ListView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ListView.staticClass, global::android.widget.ListView._ListView17289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ListView17290;
		public ListView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ListView.staticClass, global::android.widget.ListView._ListView17290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
			global::android.widget.ListView._onRestoreInstanceState17236 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.widget.ListView._onSaveInstanceState17237 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.widget.ListView._onKeyDown17238 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.ListView._onKeyUp17239 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.ListView._onKeyMultiple17240 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z");
			global::android.widget.ListView._onTouchEvent17241 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.ListView._dispatchKeyEvent17242 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.widget.ListView._dispatchPopulateAccessibilityEvent17243 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.widget.ListView._onFocusChanged17244 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.widget.ListView._onSizeChanged17245 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "onSizeChanged", "(IIII)V");
			global::android.widget.ListView._dispatchDraw17246 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.ListView._onFinishInflate17247 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "onFinishInflate", "()V");
			global::android.widget.ListView._onMeasure17248 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "onMeasure", "(II)V");
			global::android.widget.ListView._requestChildRectangleOnScreen17249 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z");
			global::android.widget.ListView._canAnimate17250 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "canAnimate", "()Z");
			global::android.widget.ListView._setAdapter17251 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setAdapter", "(Landroid/widget/ListAdapter;)V");
			global::android.widget.ListView._setAdapter17252 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setAdapter", "(Landroid/widget/Adapter;)V");
			global::android.widget.ListView._performItemClick17253 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "performItemClick", "(Landroid/view/View;IJ)Z");
			global::android.widget.ListView._getAdapter17254 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "getAdapter", "()Landroid/widget/Adapter;");
			global::android.widget.ListView._setSelection17255 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setSelection", "(I)V");
			global::android.widget.ListView._getMaxScrollAmount17256 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "getMaxScrollAmount", "()I");
			global::android.widget.ListView._addHeaderView17257 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "addHeaderView", "(Landroid/view/View;)V");
			global::android.widget.ListView._addHeaderView17258 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "addHeaderView", "(Landroid/view/View;Ljava/lang/Object;Z)V");
			global::android.widget.ListView._getHeaderViewsCount17259 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "getHeaderViewsCount", "()I");
			global::android.widget.ListView._removeHeaderView17260 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "removeHeaderView", "(Landroid/view/View;)Z");
			global::android.widget.ListView._addFooterView17261 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "addFooterView", "(Landroid/view/View;)V");
			global::android.widget.ListView._addFooterView17262 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "addFooterView", "(Landroid/view/View;Ljava/lang/Object;Z)V");
			global::android.widget.ListView._getFooterViewsCount17263 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "getFooterViewsCount", "()I");
			global::android.widget.ListView._removeFooterView17264 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "removeFooterView", "(Landroid/view/View;)Z");
			global::android.widget.ListView._layoutChildren17265 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "layoutChildren", "()V");
			global::android.widget.ListView._setSelectionFromTop17266 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setSelectionFromTop", "(II)V");
			global::android.widget.ListView._setSelectionAfterHeaderView17267 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setSelectionAfterHeaderView", "()V");
			global::android.widget.ListView._setItemsCanFocus17268 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setItemsCanFocus", "(Z)V");
			global::android.widget.ListView._getItemsCanFocus17269 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "getItemsCanFocus", "()Z");
			global::android.widget.ListView._setCacheColorHint17270 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setCacheColorHint", "(I)V");
			global::android.widget.ListView._getDivider17271 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "getDivider", "()Landroid/graphics/drawable/Drawable;");
			global::android.widget.ListView._setDivider17272 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setDivider", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ListView._getDividerHeight17273 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "getDividerHeight", "()I");
			global::android.widget.ListView._setDividerHeight17274 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setDividerHeight", "(I)V");
			global::android.widget.ListView._setHeaderDividersEnabled17275 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setHeaderDividersEnabled", "(Z)V");
			global::android.widget.ListView._setFooterDividersEnabled17276 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setFooterDividersEnabled", "(Z)V");
			global::android.widget.ListView._findViewTraversal17277 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "findViewTraversal", "(I)Landroid/view/View;");
			global::android.widget.ListView._findViewWithTagTraversal17278 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "findViewWithTagTraversal", "(Ljava/lang/Object;)Landroid/view/View;");
			global::android.widget.ListView._getChoiceMode17279 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "getChoiceMode", "()I");
			global::android.widget.ListView._setChoiceMode17280 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setChoiceMode", "(I)V");
			global::android.widget.ListView._setItemChecked17281 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setItemChecked", "(IZ)V");
			global::android.widget.ListView._isItemChecked17282 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "isItemChecked", "(I)Z");
			global::android.widget.ListView._getCheckedItemPosition17283 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "getCheckedItemPosition", "()I");
			global::android.widget.ListView._getCheckedItemPositions17284 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "getCheckedItemPositions", "()Landroid/util/SparseBooleanArray;");
			global::android.widget.ListView._getCheckItemIds17285 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "getCheckItemIds", "()[J");
			global::android.widget.ListView._getCheckedItemIds17286 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "getCheckedItemIds", "()[J");
			global::android.widget.ListView._clearChoices17287 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "clearChoices", "()V");
			global::android.widget.ListView._ListView17288 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.ListView._ListView17289 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.ListView._ListView17290 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
