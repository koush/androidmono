namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ListView : android.widget.AbsListView
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ListView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class FixedViewInfo : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected FixedViewInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public FixedViewInfo(android.widget.ListView arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.ListView.FixedViewInfo._m0.native == global::System.IntPtr.Zero)
					global::android.widget.ListView.FixedViewInfo._m0 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.FixedViewInfo.staticClass, "<init>", "(Landroid/widget/ListView;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ListView.FixedViewInfo.staticClass, global::android.widget.ListView.FixedViewInfo._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _view6075;
			public global::android.view.View view
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _view6075)) as android.view.View;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _data6076;
			public global::java.lang.Object data
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _data6076)) as java.lang.Object;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _isSelectable6077;
			public bool isSelectable
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _isSelectable6077);
				}
				set
				{
				}
			}
			static FixedViewInfo()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ListView.FixedViewInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ListView$FixedViewInfo"));
				global::android.widget.ListView.FixedViewInfo._view6075 = @__env.GetFieldIDNoThrow(global::android.widget.ListView.FixedViewInfo.staticClass, "view", "Landroid/view/View;");
				global::android.widget.ListView.FixedViewInfo._data6076 = @__env.GetFieldIDNoThrow(global::android.widget.ListView.FixedViewInfo.staticClass, "data", "Ljava/lang/Object;");
				global::android.widget.ListView.FixedViewInfo._isSelectable6077 = @__env.GetFieldIDNoThrow(global::android.widget.ListView.FixedViewInfo.staticClass, "isSelectable", "Z");
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void onRestoreInstanceState(android.os.Parcelable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ListView.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V", ref global::android.widget.ListView._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::android.os.Parcelable onSaveInstanceState()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.Parcelable>(this, global::android.widget.ListView.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;", ref global::android.widget.ListView._m1) as android.os.Parcelable;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ListView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z", ref global::android.widget.ListView._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ListView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z", ref global::android.widget.ListView._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ListView.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z", ref global::android.widget.ListView._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override bool onTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ListView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.widget.ListView._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ListView.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", ref global::android.widget.ListView._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ListView.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z", ref global::android.widget.ListView._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ListView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V", ref global::android.widget.ListView._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ListView.staticClass, "onSizeChanged", "(IIII)V", ref global::android.widget.ListView._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected override void dispatchDraw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ListView.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V", ref global::android.widget.ListView._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		protected override void onFinishInflate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ListView.staticClass, "onFinishInflate", "()V", ref global::android.widget.ListView._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ListView.staticClass, "onMeasure", "(II)V", ref global::android.widget.ListView._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ListView.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z", ref global::android.widget.ListView._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		protected override bool canAnimate()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ListView.staticClass, "canAnimate", "()Z", ref global::android.widget.ListView._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setAdapter(android.widget.ListAdapter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ListView.staticClass, "setAdapter", "(Landroid/widget/ListAdapter;)V", ref global::android.widget.ListView._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override void setAdapter(android.widget.Adapter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ListView.staticClass, "setAdapter", "(Landroid/widget/Adapter;)V", ref global::android.widget.ListView._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public override bool performItemClick(android.view.View arg0, int arg1, long arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ListView.staticClass, "performItemClick", "(Landroid/view/View;IJ)Z", ref global::android.widget.ListView._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
		private static global::MonoJavaBridge.MethodId _m18;
		public override global::android.widget.Adapter getAdapter()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.Adapter>(this, global::android.widget.ListView.staticClass, "getAdapter", "()Landroid/widget/Adapter;", ref global::android.widget.ListView._m18) as android.widget.Adapter;
		}
		public new int Selection
		{
			set
			{
				setSelection(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public override void setSelection(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ListView.staticClass, "setSelection", "(I)V", ref global::android.widget.ListView._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MaxScrollAmount
		{
			get
			{
				return getMaxScrollAmount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual int getMaxScrollAmount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ListView.staticClass, "getMaxScrollAmount", "()I", ref global::android.widget.ListView._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void addHeaderView(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ListView.staticClass, "addHeaderView", "(Landroid/view/View;)V", ref global::android.widget.ListView._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void addHeaderView(android.view.View arg0, java.lang.Object arg1, bool arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ListView.staticClass, "addHeaderView", "(Landroid/view/View;Ljava/lang/Object;Z)V", ref global::android.widget.ListView._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new int HeaderViewsCount
		{
			get
			{
				return getHeaderViewsCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual int getHeaderViewsCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ListView.staticClass, "getHeaderViewsCount", "()I", ref global::android.widget.ListView._m23);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual bool removeHeaderView(android.view.View arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ListView.staticClass, "removeHeaderView", "(Landroid/view/View;)Z", ref global::android.widget.ListView._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual void addFooterView(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ListView.staticClass, "addFooterView", "(Landroid/view/View;)V", ref global::android.widget.ListView._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual void addFooterView(android.view.View arg0, java.lang.Object arg1, bool arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ListView.staticClass, "addFooterView", "(Landroid/view/View;Ljava/lang/Object;Z)V", ref global::android.widget.ListView._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new int FooterViewsCount
		{
			get
			{
				return getFooterViewsCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual int getFooterViewsCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ListView.staticClass, "getFooterViewsCount", "()I", ref global::android.widget.ListView._m27);
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual bool removeFooterView(android.view.View arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ListView.staticClass, "removeFooterView", "(Landroid/view/View;)Z", ref global::android.widget.ListView._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		protected override void layoutChildren()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ListView.staticClass, "layoutChildren", "()V", ref global::android.widget.ListView._m29);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual void setSelectionFromTop(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ListView.staticClass, "setSelectionFromTop", "(II)V", ref global::android.widget.ListView._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual void setSelectionAfterHeaderView()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ListView.staticClass, "setSelectionAfterHeaderView", "()V", ref global::android.widget.ListView._m31);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual void setItemsCanFocus(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ListView.staticClass, "setItemsCanFocus", "(Z)V", ref global::android.widget.ListView._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual bool getItemsCanFocus()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ListView.staticClass, "getItemsCanFocus", "()Z", ref global::android.widget.ListView._m33);
		}
		public new int CacheColorHint
		{
			set
			{
				setCacheColorHint(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public override void setCacheColorHint(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ListView.staticClass, "setCacheColorHint", "(I)V", ref global::android.widget.ListView._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual global::android.graphics.drawable.Drawable getDivider()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ListView.staticClass, "getDivider", "()Landroid/graphics/drawable/Drawable;", ref global::android.widget.ListView._m35) as android.graphics.drawable.Drawable;
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual void setDivider(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ListView.staticClass, "setDivider", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.widget.ListView._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual int getDividerHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ListView.staticClass, "getDividerHeight", "()I", ref global::android.widget.ListView._m37);
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public virtual void setDividerHeight(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ListView.staticClass, "setDividerHeight", "(I)V", ref global::android.widget.ListView._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool HeaderDividersEnabled
		{
			set
			{
				setHeaderDividersEnabled(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public virtual void setHeaderDividersEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ListView.staticClass, "setHeaderDividersEnabled", "(Z)V", ref global::android.widget.ListView._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool FooterDividersEnabled
		{
			set
			{
				setFooterDividersEnabled(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public virtual void setFooterDividersEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ListView.staticClass, "setFooterDividersEnabled", "(Z)V", ref global::android.widget.ListView._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m41;
		protected virtual global::android.view.View findViewTraversal(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ListView.staticClass, "findViewTraversal", "(I)Landroid/view/View;", ref global::android.widget.ListView._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m42;
		protected virtual global::android.view.View findViewWithTagTraversal(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ListView.staticClass, "findViewWithTagTraversal", "(Ljava/lang/Object;)Landroid/view/View;", ref global::android.widget.ListView._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.View;
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
		private static global::MonoJavaBridge.MethodId _m43;
		public virtual int getChoiceMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ListView.staticClass, "getChoiceMode", "()I", ref global::android.widget.ListView._m43);
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public virtual void setChoiceMode(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ListView.staticClass, "setChoiceMode", "(I)V", ref global::android.widget.ListView._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public virtual void setItemChecked(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ListView.staticClass, "setItemChecked", "(IZ)V", ref global::android.widget.ListView._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public virtual bool isItemChecked(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ListView.staticClass, "isItemChecked", "(I)Z", ref global::android.widget.ListView._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int CheckedItemPosition
		{
			get
			{
				return getCheckedItemPosition();
			}
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public virtual int getCheckedItemPosition()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ListView.staticClass, "getCheckedItemPosition", "()I", ref global::android.widget.ListView._m47);
		}
		public new global::android.util.SparseBooleanArray CheckedItemPositions
		{
			get
			{
				return getCheckedItemPositions();
			}
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public virtual global::android.util.SparseBooleanArray getCheckedItemPositions()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ListView.staticClass, "getCheckedItemPositions", "()Landroid/util/SparseBooleanArray;", ref global::android.widget.ListView._m48) as android.util.SparseBooleanArray;
		}
		public new long[] CheckItemIds
		{
			get
			{
				return getCheckItemIds();
			}
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public virtual long[] getCheckItemIds()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<long>(this, global::android.widget.ListView.staticClass, "getCheckItemIds", "()[J", ref global::android.widget.ListView._m49) as long[];
		}
		public new long[] CheckedItemIds
		{
			get
			{
				return getCheckedItemIds();
			}
		}
		private static global::MonoJavaBridge.MethodId _m50;
		public virtual long[] getCheckedItemIds()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<long>(this, global::android.widget.ListView.staticClass, "getCheckedItemIds", "()[J", ref global::android.widget.ListView._m50) as long[];
		}
		private static global::MonoJavaBridge.MethodId _m51;
		public virtual void clearChoices()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ListView.staticClass, "clearChoices", "()V", ref global::android.widget.ListView._m51);
		}
		private static global::MonoJavaBridge.MethodId _m52;
		public ListView(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ListView._m52.native == global::System.IntPtr.Zero)
				global::android.widget.ListView._m52 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ListView.staticClass, global::android.widget.ListView._m52, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m53;
		public ListView(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ListView._m53.native == global::System.IntPtr.Zero)
				global::android.widget.ListView._m53 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ListView.staticClass, global::android.widget.ListView._m53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m54;
		public ListView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ListView._m54.native == global::System.IntPtr.Zero)
				global::android.widget.ListView._m54 = @__env.GetMethodIDNoThrow(global::android.widget.ListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ListView.staticClass, global::android.widget.ListView._m54, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
		static ListView()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ListView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ListView"));
		}
		internal static void InitJNI()
		{
		}
	}
}
