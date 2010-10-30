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
			internal static global::MonoJavaBridge.MethodId _isValid16725;
			bool android.widget.AutoCompleteTextView.Validator.isValid(java.lang.CharSequence arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AutoCompleteTextView.Validator_.staticClass, "isValid", "(Ljava/lang/CharSequence;)Z", ref global::android.widget.AutoCompleteTextView.Validator_._isValid16725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _fixText16726;
			global::java.lang.CharSequence android.widget.AutoCompleteTextView.Validator.fixText(java.lang.CharSequence arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.widget.AutoCompleteTextView.Validator_.staticClass, "fixText", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", ref global::android.widget.AutoCompleteTextView.Validator_._fixText16726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
			}
			static Validator_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.AutoCompleteTextView.Validator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AutoCompleteTextView$Validator"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _setThreshold16727;
		public virtual void setThreshold(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "setThreshold", "(I)V", ref global::android.widget.AutoCompleteTextView._setThreshold16727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown16728;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z", ref global::android.widget.AutoCompleteTextView._onKeyDown16728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp16729;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z", ref global::android.widget.AutoCompleteTextView._onKeyUp16729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onWindowFocusChanged16730;
		public override void onWindowFocusChanged(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "onWindowFocusChanged", "(Z)V", ref global::android.widget.AutoCompleteTextView._onWindowFocusChanged16730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow16731;
		protected override void onAttachedToWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "onAttachedToWindow", "()V", ref global::android.widget.AutoCompleteTextView._onAttachedToWindow16731);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow16732;
		protected override void onDetachedFromWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "onDetachedFromWindow", "()V", ref global::android.widget.AutoCompleteTextView._onDetachedFromWindow16732);
		}
		public new global::android.view.View.OnClickListener OnClickListener
		{
			set
			{
				setOnClickListener(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setOnClickListener16733;
		public override void setOnClickListener(android.view.View.OnClickListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "setOnClickListener", "(Landroid/view/View$OnClickListener;)V", ref global::android.widget.AutoCompleteTextView._setOnClickListener16733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnClickListener(global::android.view.View.OnClickListenerDelegate arg0)
		{
			setOnClickListener((global::android.view.View.OnClickListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _onFocusChanged16734;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V", ref global::android.widget.AutoCompleteTextView._onFocusChanged16734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onDisplayHint16735;
		protected override void onDisplayHint(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "onDisplayHint", "(I)V", ref global::android.widget.AutoCompleteTextView._onDisplayHint16735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyPreIme16736;
		public override bool onKeyPreIme(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "onKeyPreIme", "(ILandroid/view/KeyEvent;)Z", ref global::android.widget.AutoCompleteTextView._onKeyPreIme16736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		protected new global::android.widget.Filter Filter
		{
			get
			{
				return getFilter();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFilter16737;
		protected virtual global::android.widget.Filter getFilter()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "getFilter", "()Landroid/widget/Filter;", ref global::android.widget.AutoCompleteTextView._getFilter16737) as android.widget.Filter;
		}
		internal static global::MonoJavaBridge.MethodId _setAdapter16738;
		public virtual void setAdapter(android.widget.ListAdapter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "setAdapter", "(Landroid/widget/ListAdapter;)V", ref global::android.widget.AutoCompleteTextView._setAdapter16738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnItemSelectedListener16739;
		public virtual void setOnItemSelectedListener(android.widget.AdapterView.OnItemSelectedListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "setOnItemSelectedListener", "(Landroid/widget/AdapterView$OnItemSelectedListener;)V", ref global::android.widget.AutoCompleteTextView._setOnItemSelectedListener16739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnItemClickListener16740;
		public virtual void setOnItemClickListener(android.widget.AdapterView.OnItemClickListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V", ref global::android.widget.AutoCompleteTextView._setOnItemClickListener16740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getOnItemClickListener16741;
		public virtual global::android.widget.AdapterView.OnItemClickListener getOnItemClickListener()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.AdapterView.OnItemClickListener>(this, global::android.widget.AutoCompleteTextView.staticClass, "getOnItemClickListener", "()Landroid/widget/AdapterView$OnItemClickListener;", ref global::android.widget.AutoCompleteTextView._getOnItemClickListener16741) as android.widget.AdapterView.OnItemClickListener;
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
		internal static global::MonoJavaBridge.MethodId _getOnItemSelectedListener16742;
		public virtual global::android.widget.AdapterView.OnItemSelectedListener getOnItemSelectedListener()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.AdapterView.OnItemSelectedListener>(this, global::android.widget.AutoCompleteTextView.staticClass, "getOnItemSelectedListener", "()Landroid/widget/AdapterView$OnItemSelectedListener;", ref global::android.widget.AutoCompleteTextView._getOnItemSelectedListener16742) as android.widget.AdapterView.OnItemSelectedListener;
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
		internal static global::MonoJavaBridge.MethodId _getAdapter16743;
		public virtual global::android.widget.ListAdapter getAdapter()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.ListAdapter>(this, global::android.widget.AutoCompleteTextView.staticClass, "getAdapter", "()Landroid/widget/ListAdapter;", ref global::android.widget.AutoCompleteTextView._getAdapter16743) as android.widget.ListAdapter;
		}
		internal static global::MonoJavaBridge.MethodId _setFrame16744;
		protected override bool setFrame(int arg0, int arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "setFrame", "(IIII)Z", ref global::android.widget.AutoCompleteTextView._setFrame16744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onCommitCompletion16745;
		public override void onCommitCompletion(android.view.inputmethod.CompletionInfo arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "onCommitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)V", ref global::android.widget.AutoCompleteTextView._onCommitCompletion16745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onFilterComplete16746;
		public virtual void onFilterComplete(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "onFilterComplete", "(I)V", ref global::android.widget.AutoCompleteTextView._onFilterComplete16746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performFiltering16747;
		protected virtual void performFiltering(java.lang.CharSequence arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "performFiltering", "(Ljava/lang/CharSequence;I)V", ref global::android.widget.AutoCompleteTextView._performFiltering16747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		protected void performFiltering(string arg0, int arg1)
		{
			performFiltering((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _enoughToFilter16748;
		public virtual bool enoughToFilter()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "enoughToFilter", "()Z", ref global::android.widget.AutoCompleteTextView._enoughToFilter16748);
		}
		internal static global::MonoJavaBridge.MethodId _performValidation16749;
		public virtual void performValidation()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "performValidation", "()V", ref global::android.widget.AutoCompleteTextView._performValidation16749);
		}
		internal static global::MonoJavaBridge.MethodId _replaceText16750;
		protected virtual void replaceText(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "replaceText", "(Ljava/lang/CharSequence;)V", ref global::android.widget.AutoCompleteTextView._replaceText16750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _setCompletionHint16751;
		public virtual void setCompletionHint(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "setCompletionHint", "(Ljava/lang/CharSequence;)V", ref global::android.widget.AutoCompleteTextView._setCompletionHint16751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDropDownWidth16752;
		public virtual int getDropDownWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "getDropDownWidth", "()I", ref global::android.widget.AutoCompleteTextView._getDropDownWidth16752);
		}
		internal static global::MonoJavaBridge.MethodId _setDropDownWidth16753;
		public virtual void setDropDownWidth(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "setDropDownWidth", "(I)V", ref global::android.widget.AutoCompleteTextView._setDropDownWidth16753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDropDownHeight16754;
		public virtual int getDropDownHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "getDropDownHeight", "()I", ref global::android.widget.AutoCompleteTextView._getDropDownHeight16754);
		}
		internal static global::MonoJavaBridge.MethodId _setDropDownHeight16755;
		public virtual void setDropDownHeight(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "setDropDownHeight", "(I)V", ref global::android.widget.AutoCompleteTextView._setDropDownHeight16755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDropDownAnchor16756;
		public virtual int getDropDownAnchor()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "getDropDownAnchor", "()I", ref global::android.widget.AutoCompleteTextView._getDropDownAnchor16756);
		}
		internal static global::MonoJavaBridge.MethodId _setDropDownAnchor16757;
		public virtual void setDropDownAnchor(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "setDropDownAnchor", "(I)V", ref global::android.widget.AutoCompleteTextView._setDropDownAnchor16757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.drawable.Drawable DropDownBackground
		{
			get
			{
				return getDropDownBackground();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDropDownBackground16758;
		public virtual global::android.graphics.drawable.Drawable getDropDownBackground()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "getDropDownBackground", "()Landroid/graphics/drawable/Drawable;", ref global::android.widget.AutoCompleteTextView._getDropDownBackground16758) as android.graphics.drawable.Drawable;
		}
		public new global::android.graphics.drawable.Drawable DropDownBackgroundDrawable
		{
			set
			{
				setDropDownBackgroundDrawable(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDropDownBackgroundDrawable16759;
		public virtual void setDropDownBackgroundDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "setDropDownBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.widget.AutoCompleteTextView._setDropDownBackgroundDrawable16759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int DropDownBackgroundResource
		{
			set
			{
				setDropDownBackgroundResource(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDropDownBackgroundResource16760;
		public virtual void setDropDownBackgroundResource(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "setDropDownBackgroundResource", "(I)V", ref global::android.widget.AutoCompleteTextView._setDropDownBackgroundResource16760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDropDownVerticalOffset16761;
		public virtual void setDropDownVerticalOffset(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "setDropDownVerticalOffset", "(I)V", ref global::android.widget.AutoCompleteTextView._setDropDownVerticalOffset16761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDropDownVerticalOffset16762;
		public virtual int getDropDownVerticalOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "getDropDownVerticalOffset", "()I", ref global::android.widget.AutoCompleteTextView._getDropDownVerticalOffset16762);
		}
		internal static global::MonoJavaBridge.MethodId _setDropDownHorizontalOffset16763;
		public virtual void setDropDownHorizontalOffset(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "setDropDownHorizontalOffset", "(I)V", ref global::android.widget.AutoCompleteTextView._setDropDownHorizontalOffset16763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDropDownHorizontalOffset16764;
		public virtual int getDropDownHorizontalOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "getDropDownHorizontalOffset", "()I", ref global::android.widget.AutoCompleteTextView._getDropDownHorizontalOffset16764);
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
		internal static global::MonoJavaBridge.MethodId _getThreshold16765;
		public virtual int getThreshold()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "getThreshold", "()I", ref global::android.widget.AutoCompleteTextView._getThreshold16765);
		}
		public new global::android.widget.AdapterView.OnItemClickListenerDelegate ItemClickListener
		{
			get
			{
				return new global::android.widget.AdapterView.OnItemClickListenerDelegate(getItemClickListener().onItemClick);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getItemClickListener16766;
		public virtual global::android.widget.AdapterView.OnItemClickListener getItemClickListener()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.AdapterView.OnItemClickListener>(this, global::android.widget.AutoCompleteTextView.staticClass, "getItemClickListener", "()Landroid/widget/AdapterView$OnItemClickListener;", ref global::android.widget.AutoCompleteTextView._getItemClickListener16766) as android.widget.AdapterView.OnItemClickListener;
		}
		public new global::android.widget.AdapterView.OnItemSelectedListener ItemSelectedListener
		{
			get
			{
				return getItemSelectedListener();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getItemSelectedListener16767;
		public virtual global::android.widget.AdapterView.OnItemSelectedListener getItemSelectedListener()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.AdapterView.OnItemSelectedListener>(this, global::android.widget.AutoCompleteTextView.staticClass, "getItemSelectedListener", "()Landroid/widget/AdapterView$OnItemSelectedListener;", ref global::android.widget.AutoCompleteTextView._getItemSelectedListener16767) as android.widget.AdapterView.OnItemSelectedListener;
		}
		internal static global::MonoJavaBridge.MethodId _isPopupShowing16768;
		public virtual bool isPopupShowing()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "isPopupShowing", "()Z", ref global::android.widget.AutoCompleteTextView._isPopupShowing16768);
		}
		internal static global::MonoJavaBridge.MethodId _convertSelectionToString16769;
		protected virtual global::java.lang.CharSequence convertSelectionToString(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.widget.AutoCompleteTextView.staticClass, "convertSelectionToString", "(Ljava/lang/Object;)Ljava/lang/CharSequence;", ref global::android.widget.AutoCompleteTextView._convertSelectionToString16769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _clearListSelection16770;
		public virtual void clearListSelection()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "clearListSelection", "()V", ref global::android.widget.AutoCompleteTextView._clearListSelection16770);
		}
		internal static global::MonoJavaBridge.MethodId _setListSelection16771;
		public virtual void setListSelection(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "setListSelection", "(I)V", ref global::android.widget.AutoCompleteTextView._setListSelection16771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getListSelection16772;
		public virtual int getListSelection()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "getListSelection", "()I", ref global::android.widget.AutoCompleteTextView._getListSelection16772);
		}
		internal static global::MonoJavaBridge.MethodId _performCompletion16773;
		public virtual void performCompletion()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "performCompletion", "()V", ref global::android.widget.AutoCompleteTextView._performCompletion16773);
		}
		internal static global::MonoJavaBridge.MethodId _isPerformingCompletion16774;
		public virtual bool isPerformingCompletion()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "isPerformingCompletion", "()Z", ref global::android.widget.AutoCompleteTextView._isPerformingCompletion16774);
		}
		internal static global::MonoJavaBridge.MethodId _dismissDropDown16775;
		public virtual void dismissDropDown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "dismissDropDown", "()V", ref global::android.widget.AutoCompleteTextView._dismissDropDown16775);
		}
		internal static global::MonoJavaBridge.MethodId _showDropDown16776;
		public virtual void showDropDown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "showDropDown", "()V", ref global::android.widget.AutoCompleteTextView._showDropDown16776);
		}
		internal static global::MonoJavaBridge.MethodId _setValidator16777;
		public virtual void setValidator(android.widget.AutoCompleteTextView.Validator arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, "setValidator", "(Landroid/widget/AutoCompleteTextView$Validator;)V", ref global::android.widget.AutoCompleteTextView._setValidator16777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getValidator16778;
		public virtual global::android.widget.AutoCompleteTextView.Validator getValidator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.AutoCompleteTextView.Validator>(this, global::android.widget.AutoCompleteTextView.staticClass, "getValidator", "()Landroid/widget/AutoCompleteTextView$Validator;", ref global::android.widget.AutoCompleteTextView._getValidator16778) as android.widget.AutoCompleteTextView.Validator;
		}
		internal static global::MonoJavaBridge.MethodId _AutoCompleteTextView16779;
		public AutoCompleteTextView(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AutoCompleteTextView._AutoCompleteTextView16779.native == global::System.IntPtr.Zero)
				global::android.widget.AutoCompleteTextView._AutoCompleteTextView16779 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._AutoCompleteTextView16779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AutoCompleteTextView16780;
		public AutoCompleteTextView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AutoCompleteTextView._AutoCompleteTextView16780.native == global::System.IntPtr.Zero)
				global::android.widget.AutoCompleteTextView._AutoCompleteTextView16780 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._AutoCompleteTextView16780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AutoCompleteTextView16781;
		public AutoCompleteTextView(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AutoCompleteTextView._AutoCompleteTextView16781.native == global::System.IntPtr.Zero)
				global::android.widget.AutoCompleteTextView._AutoCompleteTextView16781 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._AutoCompleteTextView16781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static AutoCompleteTextView()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.AutoCompleteTextView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AutoCompleteTextView"));
		}
		internal static void InitJNI()
		{
		}
	}
}
