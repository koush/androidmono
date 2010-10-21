namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AutoCompleteTextView : android.widget.EditText, android.widget.Filter.FilterListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AutoCompleteTextView()
		{
			InitJNI();
		}
		protected AutoCompleteTextView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.AutoCompleteTextView.Validator_))]
		public interface Validator  : global::MonoJavaBridge.IJavaObject 
		{
			bool isValid(java.lang.CharSequence arg0);
			global::java.lang.CharSequence fixText(java.lang.CharSequence arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.AutoCompleteTextView.Validator))]
		public sealed partial class Validator_ : java.lang.Object, Validator
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Validator_()
			{
				InitJNI();
			}
			internal Validator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _isValid16631;
			 bool android.widget.AutoCompleteTextView.Validator.isValid(java.lang.CharSequence arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.Validator_._isValid16631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.Validator_.staticClass, global::android.widget.AutoCompleteTextView.Validator_._isValid16631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _fixText16632;
			 global::java.lang.CharSequence android.widget.AutoCompleteTextView.Validator.fixText(java.lang.CharSequence arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.Validator_._fixText16632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.Validator_.staticClass, global::android.widget.AutoCompleteTextView.Validator_._fixText16632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.AutoCompleteTextView.Validator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AutoCompleteTextView$Validator"));
				global::android.widget.AutoCompleteTextView.Validator_._isValid16631 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.Validator_.staticClass, "isValid", "(Ljava/lang/CharSequence;)Z");
				global::android.widget.AutoCompleteTextView.Validator_._fixText16632 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.Validator_.staticClass, "fixText", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _setThreshold16633;
		public virtual void setThreshold(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._setThreshold16633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setThreshold16633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown16634;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._onKeyDown16634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onKeyDown16634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp16635;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._onKeyUp16635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onKeyUp16635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onWindowFocusChanged16636;
		public override void onWindowFocusChanged(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._onWindowFocusChanged16636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onWindowFocusChanged16636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow16637;
		protected override void onAttachedToWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._onAttachedToWindow16637);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onAttachedToWindow16637);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow16638;
		protected override void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._onDetachedFromWindow16638);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onDetachedFromWindow16638);
		}
		internal static global::MonoJavaBridge.MethodId _setOnClickListener16639;
		public override void setOnClickListener(android.view.View.OnClickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._setOnClickListener16639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setOnClickListener16639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onFocusChanged16640;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._onFocusChanged16640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onFocusChanged16640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onDisplayHint16641;
		protected override void onDisplayHint(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._onDisplayHint16641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onDisplayHint16641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyPreIme16642;
		public override bool onKeyPreIme(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._onKeyPreIme16642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onKeyPreIme16642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		protected new global::android.widget.Filter Filter
		{
			get
			{
				return getFilter();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFilter16643;
		protected virtual global::android.widget.Filter getFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._getFilter16643)) as android.widget.Filter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getFilter16643)) as android.widget.Filter;
		}
		internal static global::MonoJavaBridge.MethodId _setAdapter16644;
		public virtual void setAdapter(android.widget.ListAdapter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._setAdapter16644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setAdapter16644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnItemSelectedListener16645;
		public virtual void setOnItemSelectedListener(android.widget.AdapterView.OnItemSelectedListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._setOnItemSelectedListener16645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setOnItemSelectedListener16645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnItemClickListener16646;
		public virtual void setOnItemClickListener(android.widget.AdapterView.OnItemClickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._setOnItemClickListener16646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setOnItemClickListener16646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.widget.AdapterView.OnItemClickListener OnItemClickListener
		{
			get
			{
				return getOnItemClickListener();
			}
			set
			{
				setOnItemClickListener(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOnItemClickListener16647;
		public virtual global::android.widget.AdapterView.OnItemClickListener getOnItemClickListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.AdapterView.OnItemClickListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._getOnItemClickListener16647)) as android.widget.AdapterView.OnItemClickListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.AdapterView.OnItemClickListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getOnItemClickListener16647)) as android.widget.AdapterView.OnItemClickListener;
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
		internal static global::MonoJavaBridge.MethodId _getOnItemSelectedListener16648;
		public virtual global::android.widget.AdapterView.OnItemSelectedListener getOnItemSelectedListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.AdapterView.OnItemSelectedListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._getOnItemSelectedListener16648)) as android.widget.AdapterView.OnItemSelectedListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.AdapterView.OnItemSelectedListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getOnItemSelectedListener16648)) as android.widget.AdapterView.OnItemSelectedListener;
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
		internal static global::MonoJavaBridge.MethodId _getAdapter16649;
		public virtual global::android.widget.ListAdapter getAdapter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.ListAdapter>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._getAdapter16649)) as android.widget.ListAdapter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.ListAdapter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getAdapter16649)) as android.widget.ListAdapter;
		}
		internal static global::MonoJavaBridge.MethodId _setFrame16650;
		protected override bool setFrame(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._setFrame16650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setFrame16650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onCommitCompletion16651;
		public override void onCommitCompletion(android.view.inputmethod.CompletionInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._onCommitCompletion16651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onCommitCompletion16651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onFilterComplete16652;
		public virtual void onFilterComplete(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._onFilterComplete16652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onFilterComplete16652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performFiltering16653;
		protected virtual void performFiltering(java.lang.CharSequence arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._performFiltering16653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._performFiltering16653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _enoughToFilter16654;
		public virtual bool enoughToFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._enoughToFilter16654);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._enoughToFilter16654);
		}
		internal static global::MonoJavaBridge.MethodId _performValidation16655;
		public virtual void performValidation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._performValidation16655);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._performValidation16655);
		}
		internal static global::MonoJavaBridge.MethodId _replaceText16656;
		protected virtual void replaceText(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._replaceText16656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._replaceText16656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCompletionHint16657;
		public virtual void setCompletionHint(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._setCompletionHint16657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setCompletionHint16657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDropDownWidth16658;
		public virtual int getDropDownWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._getDropDownWidth16658);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getDropDownWidth16658);
		}
		internal static global::MonoJavaBridge.MethodId _setDropDownWidth16659;
		public virtual void setDropDownWidth(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._setDropDownWidth16659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setDropDownWidth16659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDropDownHeight16660;
		public virtual int getDropDownHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._getDropDownHeight16660);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getDropDownHeight16660);
		}
		internal static global::MonoJavaBridge.MethodId _setDropDownHeight16661;
		public virtual void setDropDownHeight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._setDropDownHeight16661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setDropDownHeight16661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDropDownAnchor16662;
		public virtual int getDropDownAnchor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._getDropDownAnchor16662);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getDropDownAnchor16662);
		}
		internal static global::MonoJavaBridge.MethodId _setDropDownAnchor16663;
		public virtual void setDropDownAnchor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._setDropDownAnchor16663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setDropDownAnchor16663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.drawable.Drawable DropDownBackground
		{
			get
			{
				return getDropDownBackground();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDropDownBackground16664;
		public virtual global::android.graphics.drawable.Drawable getDropDownBackground() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._getDropDownBackground16664)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getDropDownBackground16664)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _setDropDownBackgroundDrawable16665;
		public virtual void setDropDownBackgroundDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._setDropDownBackgroundDrawable16665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setDropDownBackgroundDrawable16665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDropDownBackgroundResource16666;
		public virtual void setDropDownBackgroundResource(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._setDropDownBackgroundResource16666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setDropDownBackgroundResource16666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDropDownVerticalOffset16667;
		public virtual void setDropDownVerticalOffset(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._setDropDownVerticalOffset16667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setDropDownVerticalOffset16667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDropDownVerticalOffset16668;
		public virtual int getDropDownVerticalOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._getDropDownVerticalOffset16668);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getDropDownVerticalOffset16668);
		}
		internal static global::MonoJavaBridge.MethodId _setDropDownHorizontalOffset16669;
		public virtual void setDropDownHorizontalOffset(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._setDropDownHorizontalOffset16669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setDropDownHorizontalOffset16669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDropDownHorizontalOffset16670;
		public virtual int getDropDownHorizontalOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._getDropDownHorizontalOffset16670);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getDropDownHorizontalOffset16670);
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
		internal static global::MonoJavaBridge.MethodId _getThreshold16671;
		public virtual int getThreshold() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._getThreshold16671);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getThreshold16671);
		}
		public new global::android.widget.AdapterView.OnItemClickListener ItemClickListener
		{
			get
			{
				return getItemClickListener();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getItemClickListener16672;
		public virtual global::android.widget.AdapterView.OnItemClickListener getItemClickListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.AdapterView.OnItemClickListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._getItemClickListener16672)) as android.widget.AdapterView.OnItemClickListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.AdapterView.OnItemClickListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getItemClickListener16672)) as android.widget.AdapterView.OnItemClickListener;
		}
		public new global::android.widget.AdapterView.OnItemSelectedListener ItemSelectedListener
		{
			get
			{
				return getItemSelectedListener();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getItemSelectedListener16673;
		public virtual global::android.widget.AdapterView.OnItemSelectedListener getItemSelectedListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.AdapterView.OnItemSelectedListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._getItemSelectedListener16673)) as android.widget.AdapterView.OnItemSelectedListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.AdapterView.OnItemSelectedListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getItemSelectedListener16673)) as android.widget.AdapterView.OnItemSelectedListener;
		}
		internal static global::MonoJavaBridge.MethodId _isPopupShowing16674;
		public virtual bool isPopupShowing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._isPopupShowing16674);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._isPopupShowing16674);
		}
		internal static global::MonoJavaBridge.MethodId _convertSelectionToString16675;
		protected virtual global::java.lang.CharSequence convertSelectionToString(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._convertSelectionToString16675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._convertSelectionToString16675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _clearListSelection16676;
		public virtual void clearListSelection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._clearListSelection16676);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._clearListSelection16676);
		}
		internal static global::MonoJavaBridge.MethodId _setListSelection16677;
		public virtual void setListSelection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._setListSelection16677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setListSelection16677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getListSelection16678;
		public virtual int getListSelection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._getListSelection16678);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getListSelection16678);
		}
		internal static global::MonoJavaBridge.MethodId _performCompletion16679;
		public virtual void performCompletion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._performCompletion16679);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._performCompletion16679);
		}
		internal static global::MonoJavaBridge.MethodId _isPerformingCompletion16680;
		public virtual bool isPerformingCompletion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._isPerformingCompletion16680);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._isPerformingCompletion16680);
		}
		internal static global::MonoJavaBridge.MethodId _dismissDropDown16681;
		public virtual void dismissDropDown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._dismissDropDown16681);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._dismissDropDown16681);
		}
		internal static global::MonoJavaBridge.MethodId _showDropDown16682;
		public virtual void showDropDown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._showDropDown16682);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._showDropDown16682);
		}
		internal static global::MonoJavaBridge.MethodId _setValidator16683;
		public virtual void setValidator(android.widget.AutoCompleteTextView.Validator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._setValidator16683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setValidator16683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getValidator16684;
		public virtual global::android.widget.AutoCompleteTextView.Validator getValidator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.AutoCompleteTextView.Validator>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._getValidator16684)) as android.widget.AutoCompleteTextView.Validator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.AutoCompleteTextView.Validator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getValidator16684)) as android.widget.AutoCompleteTextView.Validator;
		}
		internal static global::MonoJavaBridge.MethodId _AutoCompleteTextView16685;
		public AutoCompleteTextView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._AutoCompleteTextView16685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AutoCompleteTextView16686;
		public AutoCompleteTextView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._AutoCompleteTextView16686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AutoCompleteTextView16687;
		public AutoCompleteTextView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._AutoCompleteTextView16687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.AutoCompleteTextView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AutoCompleteTextView"));
			global::android.widget.AutoCompleteTextView._setThreshold16633 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "setThreshold", "(I)V");
			global::android.widget.AutoCompleteTextView._onKeyDown16634 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.AutoCompleteTextView._onKeyUp16635 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.AutoCompleteTextView._onWindowFocusChanged16636 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "onWindowFocusChanged", "(Z)V");
			global::android.widget.AutoCompleteTextView._onAttachedToWindow16637 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "onAttachedToWindow", "()V");
			global::android.widget.AutoCompleteTextView._onDetachedFromWindow16638 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "onDetachedFromWindow", "()V");
			global::android.widget.AutoCompleteTextView._setOnClickListener16639 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "setOnClickListener", "(Landroid/view/View$OnClickListener;)V");
			global::android.widget.AutoCompleteTextView._onFocusChanged16640 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.widget.AutoCompleteTextView._onDisplayHint16641 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "onDisplayHint", "(I)V");
			global::android.widget.AutoCompleteTextView._onKeyPreIme16642 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "onKeyPreIme", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.AutoCompleteTextView._getFilter16643 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "getFilter", "()Landroid/widget/Filter;");
			global::android.widget.AutoCompleteTextView._setAdapter16644 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "setAdapter", "(Landroid/widget/ListAdapter;)V");
			global::android.widget.AutoCompleteTextView._setOnItemSelectedListener16645 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "setOnItemSelectedListener", "(Landroid/widget/AdapterView$OnItemSelectedListener;)V");
			global::android.widget.AutoCompleteTextView._setOnItemClickListener16646 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V");
			global::android.widget.AutoCompleteTextView._getOnItemClickListener16647 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "getOnItemClickListener", "()Landroid/widget/AdapterView$OnItemClickListener;");
			global::android.widget.AutoCompleteTextView._getOnItemSelectedListener16648 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "getOnItemSelectedListener", "()Landroid/widget/AdapterView$OnItemSelectedListener;");
			global::android.widget.AutoCompleteTextView._getAdapter16649 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "getAdapter", "()Landroid/widget/ListAdapter;");
			global::android.widget.AutoCompleteTextView._setFrame16650 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "setFrame", "(IIII)Z");
			global::android.widget.AutoCompleteTextView._onCommitCompletion16651 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "onCommitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)V");
			global::android.widget.AutoCompleteTextView._onFilterComplete16652 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "onFilterComplete", "(I)V");
			global::android.widget.AutoCompleteTextView._performFiltering16653 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "performFiltering", "(Ljava/lang/CharSequence;I)V");
			global::android.widget.AutoCompleteTextView._enoughToFilter16654 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "enoughToFilter", "()Z");
			global::android.widget.AutoCompleteTextView._performValidation16655 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "performValidation", "()V");
			global::android.widget.AutoCompleteTextView._replaceText16656 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "replaceText", "(Ljava/lang/CharSequence;)V");
			global::android.widget.AutoCompleteTextView._setCompletionHint16657 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "setCompletionHint", "(Ljava/lang/CharSequence;)V");
			global::android.widget.AutoCompleteTextView._getDropDownWidth16658 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "getDropDownWidth", "()I");
			global::android.widget.AutoCompleteTextView._setDropDownWidth16659 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "setDropDownWidth", "(I)V");
			global::android.widget.AutoCompleteTextView._getDropDownHeight16660 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "getDropDownHeight", "()I");
			global::android.widget.AutoCompleteTextView._setDropDownHeight16661 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "setDropDownHeight", "(I)V");
			global::android.widget.AutoCompleteTextView._getDropDownAnchor16662 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "getDropDownAnchor", "()I");
			global::android.widget.AutoCompleteTextView._setDropDownAnchor16663 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "setDropDownAnchor", "(I)V");
			global::android.widget.AutoCompleteTextView._getDropDownBackground16664 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "getDropDownBackground", "()Landroid/graphics/drawable/Drawable;");
			global::android.widget.AutoCompleteTextView._setDropDownBackgroundDrawable16665 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "setDropDownBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.AutoCompleteTextView._setDropDownBackgroundResource16666 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "setDropDownBackgroundResource", "(I)V");
			global::android.widget.AutoCompleteTextView._setDropDownVerticalOffset16667 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "setDropDownVerticalOffset", "(I)V");
			global::android.widget.AutoCompleteTextView._getDropDownVerticalOffset16668 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "getDropDownVerticalOffset", "()I");
			global::android.widget.AutoCompleteTextView._setDropDownHorizontalOffset16669 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "setDropDownHorizontalOffset", "(I)V");
			global::android.widget.AutoCompleteTextView._getDropDownHorizontalOffset16670 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "getDropDownHorizontalOffset", "()I");
			global::android.widget.AutoCompleteTextView._getThreshold16671 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "getThreshold", "()I");
			global::android.widget.AutoCompleteTextView._getItemClickListener16672 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "getItemClickListener", "()Landroid/widget/AdapterView$OnItemClickListener;");
			global::android.widget.AutoCompleteTextView._getItemSelectedListener16673 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "getItemSelectedListener", "()Landroid/widget/AdapterView$OnItemSelectedListener;");
			global::android.widget.AutoCompleteTextView._isPopupShowing16674 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "isPopupShowing", "()Z");
			global::android.widget.AutoCompleteTextView._convertSelectionToString16675 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "convertSelectionToString", "(Ljava/lang/Object;)Ljava/lang/CharSequence;");
			global::android.widget.AutoCompleteTextView._clearListSelection16676 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "clearListSelection", "()V");
			global::android.widget.AutoCompleteTextView._setListSelection16677 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "setListSelection", "(I)V");
			global::android.widget.AutoCompleteTextView._getListSelection16678 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "getListSelection", "()I");
			global::android.widget.AutoCompleteTextView._performCompletion16679 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "performCompletion", "()V");
			global::android.widget.AutoCompleteTextView._isPerformingCompletion16680 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "isPerformingCompletion", "()Z");
			global::android.widget.AutoCompleteTextView._dismissDropDown16681 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "dismissDropDown", "()V");
			global::android.widget.AutoCompleteTextView._showDropDown16682 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "showDropDown", "()V");
			global::android.widget.AutoCompleteTextView._setValidator16683 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "setValidator", "(Landroid/widget/AutoCompleteTextView$Validator;)V");
			global::android.widget.AutoCompleteTextView._getValidator16684 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "getValidator", "()Landroid/widget/AutoCompleteTextView$Validator;");
			global::android.widget.AutoCompleteTextView._AutoCompleteTextView16685 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.AutoCompleteTextView._AutoCompleteTextView16686 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.AutoCompleteTextView._AutoCompleteTextView16687 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
