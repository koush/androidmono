namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AutoCompleteTextView : android.widget.EditText, android.widget.Filter.FilterListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AutoCompleteTextView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.AutoCompleteTextView.Validator_))]
		public partial interface Validator  : global::MonoJavaBridge.IJavaObject 
		{
			bool isValid(java.lang.CharSequence arg0);
			global::java.lang.CharSequence fixText(java.lang.CharSequence arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.AutoCompleteTextView.Validator))]
		internal sealed partial class Validator_ : java.lang.Object, Validator
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Validator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			bool android.widget.AutoCompleteTextView.Validator.isValid(java.lang.CharSequence arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AutoCompleteTextView.Validator_.staticClass, "isValid", "(Ljava/lang/CharSequence;)Z", ref global::android.widget.AutoCompleteTextView.Validator_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			global::java.lang.CharSequence android.widget.AutoCompleteTextView.Validator.fixText(java.lang.CharSequence arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.widget.AutoCompleteTextView.Validator_.staticClass, "fixText", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", ref global::android.widget.AutoCompleteTextView.Validator_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
			}
			static Validator_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.AutoCompleteTextView.Validator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AutoCompleteTextView$Validator"));
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void setThreshold(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "setThreshold", "(I)V", ref global::android.widget.AutoCompleteTextView._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z", ref global::android.widget.AutoCompleteTextView._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z", ref global::android.widget.AutoCompleteTextView._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void onWindowFocusChanged(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "onWindowFocusChanged", "(Z)V", ref global::android.widget.AutoCompleteTextView._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected override void onAttachedToWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "onAttachedToWindow", "()V", ref global::android.widget.AutoCompleteTextView._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override void onDetachedFromWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "onDetachedFromWindow", "()V", ref global::android.widget.AutoCompleteTextView._m5);
		}
		public new global::android.view.View.OnClickListener OnClickListener
		{
			set
			{
				setOnClickListener(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override void setOnClickListener(android.view.View.OnClickListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "setOnClickListener", "(Landroid/view/View$OnClickListener;)V", ref global::android.widget.AutoCompleteTextView._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnClickListener(global::android.view.View.OnClickListenerDelegate arg0)
		{
			setOnClickListener((global::android.view.View.OnClickListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V", ref global::android.widget.AutoCompleteTextView._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected override void onDisplayHint(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "onDisplayHint", "(I)V", ref global::android.widget.AutoCompleteTextView._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override bool onKeyPreIme(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "onKeyPreIme", "(ILandroid/view/KeyEvent;)Z", ref global::android.widget.AutoCompleteTextView._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		protected new global::android.widget.Filter Filter
		{
			get
			{
				return getFilter();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected virtual global::android.widget.Filter getFilter()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "getFilter", "()Landroid/widget/Filter;", ref global::android.widget.AutoCompleteTextView._m10) as android.widget.Filter;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setAdapter(android.widget.ListAdapter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "setAdapter", "(Landroid/widget/ListAdapter;)V", ref global::android.widget.AutoCompleteTextView._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setOnItemSelectedListener(android.widget.AdapterView.OnItemSelectedListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "setOnItemSelectedListener", "(Landroid/widget/AdapterView$OnItemSelectedListener;)V", ref global::android.widget.AutoCompleteTextView._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void setOnItemClickListener(android.widget.AdapterView.OnItemClickListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V", ref global::android.widget.AutoCompleteTextView._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnItemClickListener(global::android.widget.AdapterView.OnItemClickListenerDelegate arg0)
		{
			setOnItemClickListener((global::android.widget.AdapterView.OnItemClickListenerDelegateWrapper)arg0);
		}
		public new global::android.widget.AdapterView.OnItemClickListenerDelegate OnItemClickListener
		{
			get
			{
				return new global::android.widget.AdapterView.OnItemClickListenerDelegate(getOnItemClickListener().onItemClick);
			}
			set
			{
				setOnItemClickListener(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::android.widget.AdapterView.OnItemClickListener getOnItemClickListener()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.AdapterView.OnItemClickListener>(this, global::android.widget.AutoCompleteTextView.staticClass, "getOnItemClickListener", "()Landroid/widget/AdapterView$OnItemClickListener;", ref global::android.widget.AutoCompleteTextView._m14) as android.widget.AdapterView.OnItemClickListener;
		}
		public new global::android.widget.AdapterView.OnItemSelectedListener OnItemSelectedListener
		{
			get
			{
				return getOnItemSelectedListener();
			}
			set
			{
				setOnItemSelectedListener(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual global::android.widget.AdapterView.OnItemSelectedListener getOnItemSelectedListener()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.AdapterView.OnItemSelectedListener>(this, global::android.widget.AutoCompleteTextView.staticClass, "getOnItemSelectedListener", "()Landroid/widget/AdapterView$OnItemSelectedListener;", ref global::android.widget.AutoCompleteTextView._m15) as android.widget.AdapterView.OnItemSelectedListener;
		}
		public new global::android.widget.ListAdapter Adapter
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
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual global::android.widget.ListAdapter getAdapter()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.ListAdapter>(this, global::android.widget.AutoCompleteTextView.staticClass, "getAdapter", "()Landroid/widget/ListAdapter;", ref global::android.widget.AutoCompleteTextView._m16) as android.widget.ListAdapter;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		protected override bool setFrame(int arg0, int arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "setFrame", "(IIII)Z", ref global::android.widget.AutoCompleteTextView._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public override void onCommitCompletion(android.view.inputmethod.CompletionInfo arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "onCommitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)V", ref global::android.widget.AutoCompleteTextView._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void onFilterComplete(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "onFilterComplete", "(I)V", ref global::android.widget.AutoCompleteTextView._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		protected virtual void performFiltering(java.lang.CharSequence arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "performFiltering", "(Ljava/lang/CharSequence;I)V", ref global::android.widget.AutoCompleteTextView._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		protected void performFiltering(string arg0, int arg1)
		{
			performFiltering((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual bool enoughToFilter()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "enoughToFilter", "()Z", ref global::android.widget.AutoCompleteTextView._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void performValidation()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "performValidation", "()V", ref global::android.widget.AutoCompleteTextView._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		protected virtual void replaceText(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "replaceText", "(Ljava/lang/CharSequence;)V", ref global::android.widget.AutoCompleteTextView._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		protected void replaceText(string arg0)
		{
			replaceText((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		public new global::java.lang.CharSequence CompletionHint
		{
			set
			{
				setCompletionHint(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual void setCompletionHint(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "setCompletionHint", "(Ljava/lang/CharSequence;)V", ref global::android.widget.AutoCompleteTextView._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setCompletionHint(string arg0)
		{
			setCompletionHint((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		public new int DropDownWidth
		{
			get
			{
				return getDropDownWidth();
			}
			set
			{
				setDropDownWidth(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual int getDropDownWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "getDropDownWidth", "()I", ref global::android.widget.AutoCompleteTextView._m25);
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual void setDropDownWidth(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "setDropDownWidth", "(I)V", ref global::android.widget.AutoCompleteTextView._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int DropDownHeight
		{
			get
			{
				return getDropDownHeight();
			}
			set
			{
				setDropDownHeight(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual int getDropDownHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "getDropDownHeight", "()I", ref global::android.widget.AutoCompleteTextView._m27);
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual void setDropDownHeight(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "setDropDownHeight", "(I)V", ref global::android.widget.AutoCompleteTextView._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int DropDownAnchor
		{
			get
			{
				return getDropDownAnchor();
			}
			set
			{
				setDropDownAnchor(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual int getDropDownAnchor()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "getDropDownAnchor", "()I", ref global::android.widget.AutoCompleteTextView._m29);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual void setDropDownAnchor(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "setDropDownAnchor", "(I)V", ref global::android.widget.AutoCompleteTextView._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.drawable.Drawable DropDownBackground
		{
			get
			{
				return getDropDownBackground();
			}
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual global::android.graphics.drawable.Drawable getDropDownBackground()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "getDropDownBackground", "()Landroid/graphics/drawable/Drawable;", ref global::android.widget.AutoCompleteTextView._m31) as android.graphics.drawable.Drawable;
		}
		public new global::android.graphics.drawable.Drawable DropDownBackgroundDrawable
		{
			set
			{
				setDropDownBackgroundDrawable(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual void setDropDownBackgroundDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "setDropDownBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.widget.AutoCompleteTextView._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int DropDownBackgroundResource
		{
			set
			{
				setDropDownBackgroundResource(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual void setDropDownBackgroundResource(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "setDropDownBackgroundResource", "(I)V", ref global::android.widget.AutoCompleteTextView._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual void setDropDownVerticalOffset(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "setDropDownVerticalOffset", "(I)V", ref global::android.widget.AutoCompleteTextView._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int DropDownVerticalOffset
		{
			get
			{
				return getDropDownVerticalOffset();
			}
			set
			{
				setDropDownVerticalOffset(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual int getDropDownVerticalOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "getDropDownVerticalOffset", "()I", ref global::android.widget.AutoCompleteTextView._m35);
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual void setDropDownHorizontalOffset(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "setDropDownHorizontalOffset", "(I)V", ref global::android.widget.AutoCompleteTextView._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int DropDownHorizontalOffset
		{
			get
			{
				return getDropDownHorizontalOffset();
			}
			set
			{
				setDropDownHorizontalOffset(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual int getDropDownHorizontalOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "getDropDownHorizontalOffset", "()I", ref global::android.widget.AutoCompleteTextView._m37);
		}
		public new int Threshold
		{
			get
			{
				return getThreshold();
			}
			set
			{
				setThreshold(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public virtual int getThreshold()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "getThreshold", "()I", ref global::android.widget.AutoCompleteTextView._m38);
		}
		public new global::android.widget.AdapterView.OnItemClickListenerDelegate ItemClickListener
		{
			get
			{
				return new global::android.widget.AdapterView.OnItemClickListenerDelegate(getItemClickListener().onItemClick);
			}
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public virtual global::android.widget.AdapterView.OnItemClickListener getItemClickListener()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.AdapterView.OnItemClickListener>(this, global::android.widget.AutoCompleteTextView.staticClass, "getItemClickListener", "()Landroid/widget/AdapterView$OnItemClickListener;", ref global::android.widget.AutoCompleteTextView._m39) as android.widget.AdapterView.OnItemClickListener;
		}
		public new global::android.widget.AdapterView.OnItemSelectedListener ItemSelectedListener
		{
			get
			{
				return getItemSelectedListener();
			}
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public virtual global::android.widget.AdapterView.OnItemSelectedListener getItemSelectedListener()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.AdapterView.OnItemSelectedListener>(this, global::android.widget.AutoCompleteTextView.staticClass, "getItemSelectedListener", "()Landroid/widget/AdapterView$OnItemSelectedListener;", ref global::android.widget.AutoCompleteTextView._m40) as android.widget.AdapterView.OnItemSelectedListener;
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public virtual bool isPopupShowing()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "isPopupShowing", "()Z", ref global::android.widget.AutoCompleteTextView._m41);
		}
		private static global::MonoJavaBridge.MethodId _m42;
		protected virtual global::java.lang.CharSequence convertSelectionToString(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.widget.AutoCompleteTextView.staticClass, "convertSelectionToString", "(Ljava/lang/Object;)Ljava/lang/CharSequence;", ref global::android.widget.AutoCompleteTextView._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public virtual void clearListSelection()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "clearListSelection", "()V", ref global::android.widget.AutoCompleteTextView._m43);
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public virtual void setListSelection(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "setListSelection", "(I)V", ref global::android.widget.AutoCompleteTextView._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ListSelection
		{
			get
			{
				return getListSelection();
			}
			set
			{
				setListSelection(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public virtual int getListSelection()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "getListSelection", "()I", ref global::android.widget.AutoCompleteTextView._m45);
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public virtual void performCompletion()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "performCompletion", "()V", ref global::android.widget.AutoCompleteTextView._m46);
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public virtual bool isPerformingCompletion()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "isPerformingCompletion", "()Z", ref global::android.widget.AutoCompleteTextView._m47);
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public virtual void dismissDropDown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "dismissDropDown", "()V", ref global::android.widget.AutoCompleteTextView._m48);
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public virtual void showDropDown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "showDropDown", "()V", ref global::android.widget.AutoCompleteTextView._m49);
		}
		private static global::MonoJavaBridge.MethodId _m50;
		public virtual void setValidator(android.widget.AutoCompleteTextView.Validator arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "setValidator", "(Landroid/widget/AutoCompleteTextView$Validator;)V", ref global::android.widget.AutoCompleteTextView._m50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m51;
		public virtual global::android.widget.AutoCompleteTextView.Validator getValidator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.AutoCompleteTextView.Validator>(this, global::android.widget.AutoCompleteTextView.staticClass, "getValidator", "()Landroid/widget/AutoCompleteTextView$Validator;", ref global::android.widget.AutoCompleteTextView._m51) as android.widget.AutoCompleteTextView.Validator;
		}
		private static global::MonoJavaBridge.MethodId _m52;
		public AutoCompleteTextView(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AutoCompleteTextView._m52.native == global::System.IntPtr.Zero)
				global::android.widget.AutoCompleteTextView._m52 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._m52, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m53;
		public AutoCompleteTextView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AutoCompleteTextView._m53.native == global::System.IntPtr.Zero)
				global::android.widget.AutoCompleteTextView._m53 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._m53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m54;
		public AutoCompleteTextView(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AutoCompleteTextView._m54.native == global::System.IntPtr.Zero)
				global::android.widget.AutoCompleteTextView._m54 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._m54, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static AutoCompleteTextView()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.AutoCompleteTextView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AutoCompleteTextView"));
		}
	}
}
