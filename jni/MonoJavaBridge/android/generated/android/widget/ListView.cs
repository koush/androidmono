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
			internal static global::MonoJavaBridge.MethodId _FixedViewInfo17336;
			public FixedViewInfo(android.widget.ListView arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ListView.FixedViewInfo.staticClass, global::android.widget.ListView.FixedViewInfo._FixedViewInfo17336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _view17337;
			public global::android.view.View view
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _view17337)) as android.view.View;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _data17338;
			public global::java.lang.Object data
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _data17338)) as java.lang.Object;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _isSelectable17339;
			public bool isSelectable
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _isSelectable17339);
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ListView.FixedViewInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ListView$FixedViewInfo"));
				global::android.widget.ListView.FixedViewInfo._FixedViewInfo17336 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.FixedViewInfo.staticClass, "<init>", "(Landroid/widget/ListView;)V");
				global::android.widget.ListView.FixedViewInfo._view17337 = @__env.GetFieldIDNoThrow(global::android.widget.ListView.FixedViewInfo.staticClass, "view", "Landroid/view/View;");
				global::android.widget.ListView.FixedViewInfo._data17338 = @__env.GetFieldIDNoThrow(global::android.widget.ListView.FixedViewInfo.staticClass, "data", "Ljava/lang/Object;");
				global::android.widget.ListView.FixedViewInfo._isSelectable17339 = @__env.GetFieldIDNoThrow(global::android.widget.ListView.FixedViewInfo.staticClass, "isSelectable", "Z");
			}
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState17340;
		public override void onRestoreInstanceState(android.os.Parcelable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._onRestoreInstanceState17340, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._onRestoreInstanceState17340, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState17341;
		public override global::android.os.Parcelable onSaveInstanceState()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ListView._onSaveInstanceState17341)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._onSaveInstanceState17341)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown17342;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._onKeyDown17342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._onKeyDown17342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp17343;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._onKeyUp17343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._onKeyUp17343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyMultiple17344;
		public override bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._onKeyMultiple17344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._onKeyMultiple17344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent17345;
		public override bool onTouchEvent(android.view.MotionEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._onTouchEvent17345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._onTouchEvent17345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent17346;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._dispatchKeyEvent17346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._dispatchKeyEvent17346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchPopulateAccessibilityEvent17347;
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._dispatchPopulateAccessibilityEvent17347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._dispatchPopulateAccessibilityEvent17347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onFocusChanged17348;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._onFocusChanged17348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._onFocusChanged17348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged17349;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._onSizeChanged17349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._onSizeChanged17349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchDraw17350;
		protected override void dispatchDraw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._dispatchDraw17350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._dispatchDraw17350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onFinishInflate17351;
		protected override void onFinishInflate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._onFinishInflate17351);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._onFinishInflate17351);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure17352;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._onMeasure17352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._onMeasure17352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _requestChildRectangleOnScreen17353;
		public override bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._requestChildRectangleOnScreen17353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._requestChildRectangleOnScreen17353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _canAnimate17354;
		protected override bool canAnimate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._canAnimate17354);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._canAnimate17354);
		}
		internal static global::MonoJavaBridge.MethodId _setAdapter17355;
		public virtual void setAdapter(android.widget.ListAdapter arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setAdapter17355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setAdapter17355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAdapter17356;
		public override void setAdapter(android.widget.Adapter arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setAdapter17356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setAdapter17356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performItemClick17357;
		public override bool performItemClick(android.view.View arg0, int arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._performItemClick17357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._performItemClick17357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
		internal static global::MonoJavaBridge.MethodId _getAdapter17358;
		public override global::android.widget.Adapter getAdapter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.Adapter>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ListView._getAdapter17358)) as android.widget.Adapter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.Adapter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._getAdapter17358)) as android.widget.Adapter;
		}
		public new int Selection
		{
			set
			{
				setSelection(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setSelection17359;
		public override void setSelection(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setSelection17359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setSelection17359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MaxScrollAmount
		{
			get
			{
				return getMaxScrollAmount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaxScrollAmount17360;
		public virtual int getMaxScrollAmount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ListView._getMaxScrollAmount17360);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._getMaxScrollAmount17360);
		}
		internal static global::MonoJavaBridge.MethodId _addHeaderView17361;
		public virtual void addHeaderView(android.view.View arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._addHeaderView17361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._addHeaderView17361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addHeaderView17362;
		public virtual void addHeaderView(android.view.View arg0, java.lang.Object arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._addHeaderView17362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._addHeaderView17362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new int HeaderViewsCount
		{
			get
			{
				return getHeaderViewsCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderViewsCount17363;
		public virtual int getHeaderViewsCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ListView._getHeaderViewsCount17363);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._getHeaderViewsCount17363);
		}
		internal static global::MonoJavaBridge.MethodId _removeHeaderView17364;
		public virtual bool removeHeaderView(android.view.View arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._removeHeaderView17364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._removeHeaderView17364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addFooterView17365;
		public virtual void addFooterView(android.view.View arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._addFooterView17365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._addFooterView17365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addFooterView17366;
		public virtual void addFooterView(android.view.View arg0, java.lang.Object arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._addFooterView17366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._addFooterView17366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new int FooterViewsCount
		{
			get
			{
				return getFooterViewsCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFooterViewsCount17367;
		public virtual int getFooterViewsCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ListView._getFooterViewsCount17367);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._getFooterViewsCount17367);
		}
		internal static global::MonoJavaBridge.MethodId _removeFooterView17368;
		public virtual bool removeFooterView(android.view.View arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._removeFooterView17368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._removeFooterView17368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _layoutChildren17369;
		protected override void layoutChildren()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._layoutChildren17369);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._layoutChildren17369);
		}
		internal static global::MonoJavaBridge.MethodId _setSelectionFromTop17370;
		public virtual void setSelectionFromTop(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setSelectionFromTop17370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setSelectionFromTop17370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setSelectionAfterHeaderView17371;
		public virtual void setSelectionAfterHeaderView()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setSelectionAfterHeaderView17371);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setSelectionAfterHeaderView17371);
		}
		internal static global::MonoJavaBridge.MethodId _setItemsCanFocus17372;
		public virtual void setItemsCanFocus(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setItemsCanFocus17372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setItemsCanFocus17372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getItemsCanFocus17373;
		public virtual bool getItemsCanFocus()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._getItemsCanFocus17373);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._getItemsCanFocus17373);
		}
		public new int CacheColorHint
		{
			set
			{
				setCacheColorHint(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setCacheColorHint17374;
		public override void setCacheColorHint(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setCacheColorHint17374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setCacheColorHint17374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDivider17375;
		public virtual global::android.graphics.drawable.Drawable getDivider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ListView._getDivider17375)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._getDivider17375)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _setDivider17376;
		public virtual void setDivider(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setDivider17376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setDivider17376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDividerHeight17377;
		public virtual int getDividerHeight()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ListView._getDividerHeight17377);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._getDividerHeight17377);
		}
		internal static global::MonoJavaBridge.MethodId _setDividerHeight17378;
		public virtual void setDividerHeight(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setDividerHeight17378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setDividerHeight17378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool HeaderDividersEnabled
		{
			set
			{
				setHeaderDividersEnabled(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setHeaderDividersEnabled17379;
		public virtual void setHeaderDividersEnabled(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setHeaderDividersEnabled17379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setHeaderDividersEnabled17379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool FooterDividersEnabled
		{
			set
			{
				setFooterDividersEnabled(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setFooterDividersEnabled17380;
		public virtual void setFooterDividersEnabled(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setFooterDividersEnabled17380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setFooterDividersEnabled17380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _findViewTraversal17381;
		protected virtual global::android.view.View findViewTraversal(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ListView._findViewTraversal17381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._findViewTraversal17381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _findViewWithTagTraversal17382;
		protected virtual global::android.view.View findViewWithTagTraversal(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ListView._findViewWithTagTraversal17382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._findViewWithTagTraversal17382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
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
		internal static global::MonoJavaBridge.MethodId _getChoiceMode17383;
		public virtual int getChoiceMode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ListView._getChoiceMode17383);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._getChoiceMode17383);
		}
		internal static global::MonoJavaBridge.MethodId _setChoiceMode17384;
		public virtual void setChoiceMode(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setChoiceMode17384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setChoiceMode17384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setItemChecked17385;
		public virtual void setItemChecked(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._setItemChecked17385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._setItemChecked17385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isItemChecked17386;
		public virtual bool isItemChecked(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListView._isItemChecked17386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._isItemChecked17386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int CheckedItemPosition
		{
			get
			{
				return getCheckedItemPosition();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCheckedItemPosition17387;
		public virtual int getCheckedItemPosition()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ListView._getCheckedItemPosition17387);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._getCheckedItemPosition17387);
		}
		public new global::android.util.SparseBooleanArray CheckedItemPositions
		{
			get
			{
				return getCheckedItemPositions();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCheckedItemPositions17388;
		public virtual global::android.util.SparseBooleanArray getCheckedItemPositions()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ListView._getCheckedItemPositions17388)) as android.util.SparseBooleanArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._getCheckedItemPositions17388)) as android.util.SparseBooleanArray;
		}
		public new long[] CheckItemIds
		{
			get
			{
				return getCheckItemIds();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCheckItemIds17389;
		public virtual long[] getCheckItemIds()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<long>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ListView._getCheckItemIds17389)) as long[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<long>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._getCheckItemIds17389)) as long[];
		}
		public new long[] CheckedItemIds
		{
			get
			{
				return getCheckedItemIds();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCheckedItemIds17390;
		public virtual long[] getCheckedItemIds()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<long>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ListView._getCheckedItemIds17390)) as long[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<long>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._getCheckedItemIds17390)) as long[];
		}
		internal static global::MonoJavaBridge.MethodId _clearChoices17391;
		public virtual void clearChoices()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListView._clearChoices17391);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListView.staticClass, global::android.widget.ListView._clearChoices17391);
		}
		internal static global::MonoJavaBridge.MethodId _ListView17392;
		public ListView(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ListView.staticClass, global::android.widget.ListView._ListView17392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ListView17393;
		public ListView(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ListView.staticClass, global::android.widget.ListView._ListView17393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ListView17394;
		public ListView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ListView.staticClass, global::android.widget.ListView._ListView17394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
			global::android.widget.ListView._onRestoreInstanceState17340 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.widget.ListView._onSaveInstanceState17341 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.widget.ListView._onKeyDown17342 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.ListView._onKeyUp17343 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.ListView._onKeyMultiple17344 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z");
			global::android.widget.ListView._onTouchEvent17345 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.ListView._dispatchKeyEvent17346 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.widget.ListView._dispatchPopulateAccessibilityEvent17347 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.widget.ListView._onFocusChanged17348 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.widget.ListView._onSizeChanged17349 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "onSizeChanged", "(IIII)V");
			global::android.widget.ListView._dispatchDraw17350 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.ListView._onFinishInflate17351 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "onFinishInflate", "()V");
			global::android.widget.ListView._onMeasure17352 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "onMeasure", "(II)V");
			global::android.widget.ListView._requestChildRectangleOnScreen17353 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z");
			global::android.widget.ListView._canAnimate17354 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "canAnimate", "()Z");
			global::android.widget.ListView._setAdapter17355 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setAdapter", "(Landroid/widget/ListAdapter;)V");
			global::android.widget.ListView._setAdapter17356 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setAdapter", "(Landroid/widget/Adapter;)V");
			global::android.widget.ListView._performItemClick17357 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "performItemClick", "(Landroid/view/View;IJ)Z");
			global::android.widget.ListView._getAdapter17358 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "getAdapter", "()Landroid/widget/Adapter;");
			global::android.widget.ListView._setSelection17359 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setSelection", "(I)V");
			global::android.widget.ListView._getMaxScrollAmount17360 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "getMaxScrollAmount", "()I");
			global::android.widget.ListView._addHeaderView17361 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "addHeaderView", "(Landroid/view/View;)V");
			global::android.widget.ListView._addHeaderView17362 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "addHeaderView", "(Landroid/view/View;Ljava/lang/Object;Z)V");
			global::android.widget.ListView._getHeaderViewsCount17363 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "getHeaderViewsCount", "()I");
			global::android.widget.ListView._removeHeaderView17364 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "removeHeaderView", "(Landroid/view/View;)Z");
			global::android.widget.ListView._addFooterView17365 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "addFooterView", "(Landroid/view/View;)V");
			global::android.widget.ListView._addFooterView17366 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "addFooterView", "(Landroid/view/View;Ljava/lang/Object;Z)V");
			global::android.widget.ListView._getFooterViewsCount17367 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "getFooterViewsCount", "()I");
			global::android.widget.ListView._removeFooterView17368 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "removeFooterView", "(Landroid/view/View;)Z");
			global::android.widget.ListView._layoutChildren17369 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "layoutChildren", "()V");
			global::android.widget.ListView._setSelectionFromTop17370 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setSelectionFromTop", "(II)V");
			global::android.widget.ListView._setSelectionAfterHeaderView17371 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setSelectionAfterHeaderView", "()V");
			global::android.widget.ListView._setItemsCanFocus17372 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setItemsCanFocus", "(Z)V");
			global::android.widget.ListView._getItemsCanFocus17373 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "getItemsCanFocus", "()Z");
			global::android.widget.ListView._setCacheColorHint17374 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setCacheColorHint", "(I)V");
			global::android.widget.ListView._getDivider17375 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "getDivider", "()Landroid/graphics/drawable/Drawable;");
			global::android.widget.ListView._setDivider17376 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setDivider", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ListView._getDividerHeight17377 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "getDividerHeight", "()I");
			global::android.widget.ListView._setDividerHeight17378 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setDividerHeight", "(I)V");
			global::android.widget.ListView._setHeaderDividersEnabled17379 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setHeaderDividersEnabled", "(Z)V");
			global::android.widget.ListView._setFooterDividersEnabled17380 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setFooterDividersEnabled", "(Z)V");
			global::android.widget.ListView._findViewTraversal17381 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "findViewTraversal", "(I)Landroid/view/View;");
			global::android.widget.ListView._findViewWithTagTraversal17382 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "findViewWithTagTraversal", "(Ljava/lang/Object;)Landroid/view/View;");
			global::android.widget.ListView._getChoiceMode17383 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "getChoiceMode", "()I");
			global::android.widget.ListView._setChoiceMode17384 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setChoiceMode", "(I)V");
			global::android.widget.ListView._setItemChecked17385 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "setItemChecked", "(IZ)V");
			global::android.widget.ListView._isItemChecked17386 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "isItemChecked", "(I)Z");
			global::android.widget.ListView._getCheckedItemPosition17387 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "getCheckedItemPosition", "()I");
			global::android.widget.ListView._getCheckedItemPositions17388 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "getCheckedItemPositions", "()Landroid/util/SparseBooleanArray;");
			global::android.widget.ListView._getCheckItemIds17389 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "getCheckItemIds", "()[J");
			global::android.widget.ListView._getCheckedItemIds17390 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "getCheckedItemIds", "()[J");
			global::android.widget.ListView._clearChoices17391 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "clearChoices", "()V");
			global::android.widget.ListView._ListView17392 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.ListView._ListView17393 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.ListView._ListView17394 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
