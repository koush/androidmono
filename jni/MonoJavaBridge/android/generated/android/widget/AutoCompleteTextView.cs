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
			internal static global::MonoJavaBridge.MethodId _isValid11486;
			 bool android.widget.AutoCompleteTextView.Validator.isValid(java.lang.CharSequence arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.Validator_._isValid11486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.Validator_.staticClass, global::android.widget.AutoCompleteTextView.Validator_._isValid11486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _fixText11487;
			 global::java.lang.CharSequence android.widget.AutoCompleteTextView.Validator.fixText(java.lang.CharSequence arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.Validator_._fixText11487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.Validator_.staticClass, global::android.widget.AutoCompleteTextView.Validator_._fixText11487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.AutoCompleteTextView.Validator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AutoCompleteTextView$Validator"));
				global::android.widget.AutoCompleteTextView.Validator_._isValid11486 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.Validator_.staticClass, "isValid", "(Ljava/lang/CharSequence;)Z");
				global::android.widget.AutoCompleteTextView.Validator_._fixText11487 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.Validator_.staticClass, "fixText", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _setThreshold11488;
		public virtual void setThreshold(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._setThreshold11488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setThreshold11488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown11489;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._onKeyDown11489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onKeyDown11489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp11490;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._onKeyUp11490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onKeyUp11490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onWindowFocusChanged11491;
		public override void onWindowFocusChanged(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._onWindowFocusChanged11491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onWindowFocusChanged11491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow11492;
		protected override void onAttachedToWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._onAttachedToWindow11492);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onAttachedToWindow11492);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow11493;
		protected override void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._onDetachedFromWindow11493);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onDetachedFromWindow11493);
		}
		internal static global::MonoJavaBridge.MethodId _setOnClickListener11494;
		public override void setOnClickListener(android.view.View.OnClickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._setOnClickListener11494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setOnClickListener11494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onFocusChanged11495;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._onFocusChanged11495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onFocusChanged11495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onDisplayHint11496;
		protected override void onDisplayHint(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._onDisplayHint11496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onDisplayHint11496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyPreIme11497;
		public override bool onKeyPreIme(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._onKeyPreIme11497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onKeyPreIme11497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		protected new global::android.widget.Filter Filter
		{
			get
			{
				return getFilter();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFilter11498;
		protected virtual global::android.widget.Filter getFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._getFilter11498)) as android.widget.Filter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getFilter11498)) as android.widget.Filter;
		}
		internal static global::MonoJavaBridge.MethodId _setAdapter11499;
		public virtual void setAdapter(android.widget.ListAdapter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._setAdapter11499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setAdapter11499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnItemSelectedListener11500;
		public virtual void setOnItemSelectedListener(android.widget.AdapterView.OnItemSelectedListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._setOnItemSelectedListener11500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setOnItemSelectedListener11500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnItemClickListener11501;
		public virtual void setOnItemClickListener(android.widget.AdapterView.OnItemClickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._setOnItemClickListener11501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setOnItemClickListener11501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getOnItemClickListener11502;
		public virtual global::android.widget.AdapterView.OnItemClickListener getOnItemClickListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.AdapterView.OnItemClickListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._getOnItemClickListener11502)) as android.widget.AdapterView.OnItemClickListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.AdapterView.OnItemClickListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getOnItemClickListener11502)) as android.widget.AdapterView.OnItemClickListener;
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
		internal static global::MonoJavaBridge.MethodId _getOnItemSelectedListener11503;
		public virtual global::android.widget.AdapterView.OnItemSelectedListener getOnItemSelectedListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.AdapterView.OnItemSelectedListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._getOnItemSelectedListener11503)) as android.widget.AdapterView.OnItemSelectedListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.AdapterView.OnItemSelectedListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getOnItemSelectedListener11503)) as android.widget.AdapterView.OnItemSelectedListener;
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
		internal static global::MonoJavaBridge.MethodId _getAdapter11504;
		public virtual global::android.widget.ListAdapter getAdapter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.ListAdapter>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._getAdapter11504)) as android.widget.ListAdapter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.ListAdapter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getAdapter11504)) as android.widget.ListAdapter;
		}
		internal static global::MonoJavaBridge.MethodId _setFrame11505;
		protected override bool setFrame(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._setFrame11505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setFrame11505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onCommitCompletion11506;
		public override void onCommitCompletion(android.view.inputmethod.CompletionInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._onCommitCompletion11506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onCommitCompletion11506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onFilterComplete11507;
		public virtual void onFilterComplete(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._onFilterComplete11507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onFilterComplete11507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performFiltering11508;
		protected virtual void performFiltering(java.lang.CharSequence arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._performFiltering11508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._performFiltering11508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _enoughToFilter11509;
		public virtual bool enoughToFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._enoughToFilter11509);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._enoughToFilter11509);
		}
		internal static global::MonoJavaBridge.MethodId _performValidation11510;
		public virtual void performValidation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._performValidation11510);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._performValidation11510);
		}
		internal static global::MonoJavaBridge.MethodId _replaceText11511;
		protected virtual void replaceText(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._replaceText11511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._replaceText11511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCompletionHint11512;
		public virtual void setCompletionHint(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._setCompletionHint11512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setCompletionHint11512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDropDownWidth11513;
		public virtual int getDropDownWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._getDropDownWidth11513);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getDropDownWidth11513);
		}
		internal static global::MonoJavaBridge.MethodId _setDropDownWidth11514;
		public virtual void setDropDownWidth(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._setDropDownWidth11514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setDropDownWidth11514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDropDownHeight11515;
		public virtual int getDropDownHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._getDropDownHeight11515);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getDropDownHeight11515);
		}
		internal static global::MonoJavaBridge.MethodId _setDropDownHeight11516;
		public virtual void setDropDownHeight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._setDropDownHeight11516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setDropDownHeight11516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDropDownAnchor11517;
		public virtual int getDropDownAnchor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._getDropDownAnchor11517);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getDropDownAnchor11517);
		}
		internal static global::MonoJavaBridge.MethodId _setDropDownAnchor11518;
		public virtual void setDropDownAnchor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._setDropDownAnchor11518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setDropDownAnchor11518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.drawable.Drawable DropDownBackground
		{
			get
			{
				return getDropDownBackground();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDropDownBackground11519;
		public virtual global::android.graphics.drawable.Drawable getDropDownBackground() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._getDropDownBackground11519)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getDropDownBackground11519)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _setDropDownBackgroundDrawable11520;
		public virtual void setDropDownBackgroundDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._setDropDownBackgroundDrawable11520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setDropDownBackgroundDrawable11520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDropDownBackgroundResource11521;
		public virtual void setDropDownBackgroundResource(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._setDropDownBackgroundResource11521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setDropDownBackgroundResource11521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDropDownVerticalOffset11522;
		public virtual void setDropDownVerticalOffset(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._setDropDownVerticalOffset11522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setDropDownVerticalOffset11522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDropDownVerticalOffset11523;
		public virtual int getDropDownVerticalOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._getDropDownVerticalOffset11523);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getDropDownVerticalOffset11523);
		}
		internal static global::MonoJavaBridge.MethodId _setDropDownHorizontalOffset11524;
		public virtual void setDropDownHorizontalOffset(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._setDropDownHorizontalOffset11524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setDropDownHorizontalOffset11524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDropDownHorizontalOffset11525;
		public virtual int getDropDownHorizontalOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._getDropDownHorizontalOffset11525);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getDropDownHorizontalOffset11525);
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
		internal static global::MonoJavaBridge.MethodId _getThreshold11526;
		public virtual int getThreshold() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._getThreshold11526);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getThreshold11526);
		}
		public new global::android.widget.AdapterView.OnItemClickListener ItemClickListener
		{
			get
			{
				return getItemClickListener();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getItemClickListener11527;
		public virtual global::android.widget.AdapterView.OnItemClickListener getItemClickListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.AdapterView.OnItemClickListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._getItemClickListener11527)) as android.widget.AdapterView.OnItemClickListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.AdapterView.OnItemClickListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getItemClickListener11527)) as android.widget.AdapterView.OnItemClickListener;
		}
		public new global::android.widget.AdapterView.OnItemSelectedListener ItemSelectedListener
		{
			get
			{
				return getItemSelectedListener();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getItemSelectedListener11528;
		public virtual global::android.widget.AdapterView.OnItemSelectedListener getItemSelectedListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.AdapterView.OnItemSelectedListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._getItemSelectedListener11528)) as android.widget.AdapterView.OnItemSelectedListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.AdapterView.OnItemSelectedListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getItemSelectedListener11528)) as android.widget.AdapterView.OnItemSelectedListener;
		}
		internal static global::MonoJavaBridge.MethodId _isPopupShowing11529;
		public virtual bool isPopupShowing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._isPopupShowing11529);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._isPopupShowing11529);
		}
		internal static global::MonoJavaBridge.MethodId _convertSelectionToString11530;
		protected virtual global::java.lang.CharSequence convertSelectionToString(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._convertSelectionToString11530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._convertSelectionToString11530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _clearListSelection11531;
		public virtual void clearListSelection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._clearListSelection11531);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._clearListSelection11531);
		}
		internal static global::MonoJavaBridge.MethodId _setListSelection11532;
		public virtual void setListSelection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._setListSelection11532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setListSelection11532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getListSelection11533;
		public virtual int getListSelection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._getListSelection11533);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getListSelection11533);
		}
		internal static global::MonoJavaBridge.MethodId _performCompletion11534;
		public virtual void performCompletion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._performCompletion11534);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._performCompletion11534);
		}
		internal static global::MonoJavaBridge.MethodId _isPerformingCompletion11535;
		public virtual bool isPerformingCompletion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._isPerformingCompletion11535);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._isPerformingCompletion11535);
		}
		internal static global::MonoJavaBridge.MethodId _dismissDropDown11536;
		public virtual void dismissDropDown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._dismissDropDown11536);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._dismissDropDown11536);
		}
		internal static global::MonoJavaBridge.MethodId _showDropDown11537;
		public virtual void showDropDown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._showDropDown11537);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._showDropDown11537);
		}
		internal static global::MonoJavaBridge.MethodId _setValidator11538;
		public virtual void setValidator(android.widget.AutoCompleteTextView.Validator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._setValidator11538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setValidator11538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getValidator11539;
		public virtual global::android.widget.AutoCompleteTextView.Validator getValidator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.AutoCompleteTextView.Validator>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView._getValidator11539)) as android.widget.AutoCompleteTextView.Validator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.AutoCompleteTextView.Validator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getValidator11539)) as android.widget.AutoCompleteTextView.Validator;
		}
		internal static global::MonoJavaBridge.MethodId _AutoCompleteTextView11540;
		public AutoCompleteTextView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._AutoCompleteTextView11540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AutoCompleteTextView11541;
		public AutoCompleteTextView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._AutoCompleteTextView11541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AutoCompleteTextView11542;
		public AutoCompleteTextView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._AutoCompleteTextView11542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.AutoCompleteTextView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AutoCompleteTextView"));
			global::android.widget.AutoCompleteTextView._setThreshold11488 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "setThreshold", "(I)V");
			global::android.widget.AutoCompleteTextView._onKeyDown11489 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.AutoCompleteTextView._onKeyUp11490 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.AutoCompleteTextView._onWindowFocusChanged11491 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "onWindowFocusChanged", "(Z)V");
			global::android.widget.AutoCompleteTextView._onAttachedToWindow11492 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "onAttachedToWindow", "()V");
			global::android.widget.AutoCompleteTextView._onDetachedFromWindow11493 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "onDetachedFromWindow", "()V");
			global::android.widget.AutoCompleteTextView._setOnClickListener11494 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "setOnClickListener", "(Landroid/view/View$OnClickListener;)V");
			global::android.widget.AutoCompleteTextView._onFocusChanged11495 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.widget.AutoCompleteTextView._onDisplayHint11496 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "onDisplayHint", "(I)V");
			global::android.widget.AutoCompleteTextView._onKeyPreIme11497 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "onKeyPreIme", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.AutoCompleteTextView._getFilter11498 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "getFilter", "()Landroid/widget/Filter;");
			global::android.widget.AutoCompleteTextView._setAdapter11499 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "setAdapter", "(Landroid/widget/ListAdapter;)V");
			global::android.widget.AutoCompleteTextView._setOnItemSelectedListener11500 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "setOnItemSelectedListener", "(Landroid/widget/AdapterView$OnItemSelectedListener;)V");
			global::android.widget.AutoCompleteTextView._setOnItemClickListener11501 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V");
			global::android.widget.AutoCompleteTextView._getOnItemClickListener11502 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "getOnItemClickListener", "()Landroid/widget/AdapterView$OnItemClickListener;");
			global::android.widget.AutoCompleteTextView._getOnItemSelectedListener11503 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "getOnItemSelectedListener", "()Landroid/widget/AdapterView$OnItemSelectedListener;");
			global::android.widget.AutoCompleteTextView._getAdapter11504 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "getAdapter", "()Landroid/widget/ListAdapter;");
			global::android.widget.AutoCompleteTextView._setFrame11505 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "setFrame", "(IIII)Z");
			global::android.widget.AutoCompleteTextView._onCommitCompletion11506 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "onCommitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)V");
			global::android.widget.AutoCompleteTextView._onFilterComplete11507 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "onFilterComplete", "(I)V");
			global::android.widget.AutoCompleteTextView._performFiltering11508 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "performFiltering", "(Ljava/lang/CharSequence;I)V");
			global::android.widget.AutoCompleteTextView._enoughToFilter11509 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "enoughToFilter", "()Z");
			global::android.widget.AutoCompleteTextView._performValidation11510 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "performValidation", "()V");
			global::android.widget.AutoCompleteTextView._replaceText11511 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "replaceText", "(Ljava/lang/CharSequence;)V");
			global::android.widget.AutoCompleteTextView._setCompletionHint11512 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "setCompletionHint", "(Ljava/lang/CharSequence;)V");
			global::android.widget.AutoCompleteTextView._getDropDownWidth11513 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "getDropDownWidth", "()I");
			global::android.widget.AutoCompleteTextView._setDropDownWidth11514 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "setDropDownWidth", "(I)V");
			global::android.widget.AutoCompleteTextView._getDropDownHeight11515 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "getDropDownHeight", "()I");
			global::android.widget.AutoCompleteTextView._setDropDownHeight11516 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "setDropDownHeight", "(I)V");
			global::android.widget.AutoCompleteTextView._getDropDownAnchor11517 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "getDropDownAnchor", "()I");
			global::android.widget.AutoCompleteTextView._setDropDownAnchor11518 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "setDropDownAnchor", "(I)V");
			global::android.widget.AutoCompleteTextView._getDropDownBackground11519 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "getDropDownBackground", "()Landroid/graphics/drawable/Drawable;");
			global::android.widget.AutoCompleteTextView._setDropDownBackgroundDrawable11520 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "setDropDownBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.AutoCompleteTextView._setDropDownBackgroundResource11521 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "setDropDownBackgroundResource", "(I)V");
			global::android.widget.AutoCompleteTextView._setDropDownVerticalOffset11522 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "setDropDownVerticalOffset", "(I)V");
			global::android.widget.AutoCompleteTextView._getDropDownVerticalOffset11523 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "getDropDownVerticalOffset", "()I");
			global::android.widget.AutoCompleteTextView._setDropDownHorizontalOffset11524 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "setDropDownHorizontalOffset", "(I)V");
			global::android.widget.AutoCompleteTextView._getDropDownHorizontalOffset11525 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "getDropDownHorizontalOffset", "()I");
			global::android.widget.AutoCompleteTextView._getThreshold11526 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "getThreshold", "()I");
			global::android.widget.AutoCompleteTextView._getItemClickListener11527 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "getItemClickListener", "()Landroid/widget/AdapterView$OnItemClickListener;");
			global::android.widget.AutoCompleteTextView._getItemSelectedListener11528 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "getItemSelectedListener", "()Landroid/widget/AdapterView$OnItemSelectedListener;");
			global::android.widget.AutoCompleteTextView._isPopupShowing11529 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "isPopupShowing", "()Z");
			global::android.widget.AutoCompleteTextView._convertSelectionToString11530 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "convertSelectionToString", "(Ljava/lang/Object;)Ljava/lang/CharSequence;");
			global::android.widget.AutoCompleteTextView._clearListSelection11531 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "clearListSelection", "()V");
			global::android.widget.AutoCompleteTextView._setListSelection11532 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "setListSelection", "(I)V");
			global::android.widget.AutoCompleteTextView._getListSelection11533 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "getListSelection", "()I");
			global::android.widget.AutoCompleteTextView._performCompletion11534 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "performCompletion", "()V");
			global::android.widget.AutoCompleteTextView._isPerformingCompletion11535 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "isPerformingCompletion", "()Z");
			global::android.widget.AutoCompleteTextView._dismissDropDown11536 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "dismissDropDown", "()V");
			global::android.widget.AutoCompleteTextView._showDropDown11537 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "showDropDown", "()V");
			global::android.widget.AutoCompleteTextView._setValidator11538 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "setValidator", "(Landroid/widget/AutoCompleteTextView$Validator;)V");
			global::android.widget.AutoCompleteTextView._getValidator11539 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "getValidator", "()Landroid/widget/AutoCompleteTextView$Validator;");
			global::android.widget.AutoCompleteTextView._AutoCompleteTextView11540 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.AutoCompleteTextView._AutoCompleteTextView11541 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.AutoCompleteTextView._AutoCompleteTextView11542 = @__env.GetMethodIDNoThrow(global::android.widget.AutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
