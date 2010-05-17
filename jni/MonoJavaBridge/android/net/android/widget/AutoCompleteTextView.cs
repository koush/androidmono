namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class AutoCompleteTextView : android.widget.EditText, android.widget.Filter.FilterListener
	{ 
		internal new static global::java.lang.Class staticClass; 
		static AutoCompleteTextView() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.AutoCompleteTextView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.AutoCompleteTextView(@__env); 
			} 
		} 
		protected AutoCompleteTextView(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface Validator 
		{ 
			bool isValid(java.lang.CharSequence arg0); 
			java.lang.CharSequence fixText(java.lang.CharSequence arg0); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setThreshold9176; 
		public virtual void setThreshold(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				@__env.CallVoidMethod(this, _setThreshold9176, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AutoCompleteTextView.staticClass, _setThreshold9176, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown9177; 
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				return @__env.CallBooleanMethod(this, _onKeyDown9177, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.AutoCompleteTextView.staticClass, _onKeyDown9177, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp9178; 
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				return @__env.CallBooleanMethod(this, _onKeyUp9178, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.AutoCompleteTextView.staticClass, _onKeyUp9178, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onWindowFocusChanged9179; 
		public override void onWindowFocusChanged(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				@__env.CallVoidMethod(this, _onWindowFocusChanged9179, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AutoCompleteTextView.staticClass, _onWindowFocusChanged9179, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToWindow9180; 
		protected override void onAttachedToWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				@__env.CallVoidMethod(this, _onAttachedToWindow9180); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AutoCompleteTextView.staticClass, _onAttachedToWindow9180); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow9181; 
		protected override void onDetachedFromWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				@__env.CallVoidMethod(this, _onDetachedFromWindow9181); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AutoCompleteTextView.staticClass, _onDetachedFromWindow9181); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnClickListener9182; 
		public override void setOnClickListener(android.view.View.OnClickListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				@__env.CallVoidMethod(this, _setOnClickListener9182, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AutoCompleteTextView.staticClass, _setOnClickListener9182, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFocusChanged9183; 
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				@__env.CallVoidMethod(this, _onFocusChanged9183, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AutoCompleteTextView.staticClass, _onFocusChanged9183, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyPreIme9184; 
		public override bool onKeyPreIme(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				return @__env.CallBooleanMethod(this, _onKeyPreIme9184, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.AutoCompleteTextView.staticClass, _onKeyPreIme9184, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFilter9185; 
		protected virtual android.widget.Filter getFilter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Filter>(@__env, @__env.CallObjectMethodPtr(this, _getFilter9185)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Filter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.AutoCompleteTextView.staticClass, _getFilter9185)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAdapter9186; 
		public virtual void setAdapter(android.widget.ListAdapter arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				@__env.CallVoidMethod(this, _setAdapter9186, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AutoCompleteTextView.staticClass, _setAdapter9186, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnItemSelectedListener9187; 
		public virtual void setOnItemSelectedListener(android.widget.AdapterView.OnItemSelectedListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				@__env.CallVoidMethod(this, _setOnItemSelectedListener9187, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AutoCompleteTextView.staticClass, _setOnItemSelectedListener9187, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnItemClickListener9188; 
		public virtual void setOnItemClickListener(android.widget.AdapterView.OnItemClickListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				@__env.CallVoidMethod(this, _setOnItemClickListener9188, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AutoCompleteTextView.staticClass, _setOnItemClickListener9188, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOnItemClickListener9189; 
		public virtual android.widget.AdapterView.OnItemClickListener getOnItemClickListener() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemClickListener>(@__env, @__env.CallObjectMethodPtr(this, _getOnItemClickListener9189)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemClickListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.AutoCompleteTextView.staticClass, _getOnItemClickListener9189)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOnItemSelectedListener9190; 
		public virtual android.widget.AdapterView.OnItemSelectedListener getOnItemSelectedListener() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemSelectedListener>(@__env, @__env.CallObjectMethodPtr(this, _getOnItemSelectedListener9190)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemSelectedListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.AutoCompleteTextView.staticClass, _getOnItemSelectedListener9190)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAdapter9191; 
		public virtual android.widget.ListAdapter getAdapter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ListAdapter>(@__env, @__env.CallObjectMethodPtr(this, _getAdapter9191)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ListAdapter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.AutoCompleteTextView.staticClass, _getAdapter9191)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFrame9192; 
		protected override bool setFrame(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				return @__env.CallBooleanMethod(this, _setFrame9192, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.AutoCompleteTextView.staticClass, _setFrame9192, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCommitCompletion9193; 
		public override void onCommitCompletion(android.view.inputmethod.CompletionInfo arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				@__env.CallVoidMethod(this, _onCommitCompletion9193, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AutoCompleteTextView.staticClass, _onCommitCompletion9193, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFilterComplete9194; 
		public virtual void onFilterComplete(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				@__env.CallVoidMethod(this, _onFilterComplete9194, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AutoCompleteTextView.staticClass, _onFilterComplete9194, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performFiltering9195; 
		protected virtual void performFiltering(java.lang.CharSequence arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				@__env.CallVoidMethod(this, _performFiltering9195, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AutoCompleteTextView.staticClass, _performFiltering9195, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _enoughToFilter9196; 
		public virtual bool enoughToFilter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				return @__env.CallBooleanMethod(this, _enoughToFilter9196); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.AutoCompleteTextView.staticClass, _enoughToFilter9196); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performValidation9197; 
		public virtual void performValidation() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				@__env.CallVoidMethod(this, _performValidation9197); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AutoCompleteTextView.staticClass, _performValidation9197); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _replaceText9198; 
		protected virtual void replaceText(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				@__env.CallVoidMethod(this, _replaceText9198, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AutoCompleteTextView.staticClass, _replaceText9198, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCompletionHint9199; 
		public virtual void setCompletionHint(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				@__env.CallVoidMethod(this, _setCompletionHint9199, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AutoCompleteTextView.staticClass, _setCompletionHint9199, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDropDownWidth9200; 
		public virtual int getDropDownWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				return @__env.CallIntMethod(this, _getDropDownWidth9200); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.AutoCompleteTextView.staticClass, _getDropDownWidth9200); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDropDownWidth9201; 
		public virtual void setDropDownWidth(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				@__env.CallVoidMethod(this, _setDropDownWidth9201, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AutoCompleteTextView.staticClass, _setDropDownWidth9201, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDropDownHeight9202; 
		public virtual int getDropDownHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				return @__env.CallIntMethod(this, _getDropDownHeight9202); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.AutoCompleteTextView.staticClass, _getDropDownHeight9202); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDropDownHeight9203; 
		public virtual void setDropDownHeight(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				@__env.CallVoidMethod(this, _setDropDownHeight9203, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AutoCompleteTextView.staticClass, _setDropDownHeight9203, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDropDownAnchor9204; 
		public virtual int getDropDownAnchor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				return @__env.CallIntMethod(this, _getDropDownAnchor9204); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.AutoCompleteTextView.staticClass, _getDropDownAnchor9204); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDropDownAnchor9205; 
		public virtual void setDropDownAnchor(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				@__env.CallVoidMethod(this, _setDropDownAnchor9205, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AutoCompleteTextView.staticClass, _setDropDownAnchor9205, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDropDownBackground9206; 
		public virtual android.graphics.drawable.Drawable getDropDownBackground() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _getDropDownBackground9206)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.AutoCompleteTextView.staticClass, _getDropDownBackground9206)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDropDownBackgroundDrawable9207; 
		public virtual void setDropDownBackgroundDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				@__env.CallVoidMethod(this, _setDropDownBackgroundDrawable9207, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AutoCompleteTextView.staticClass, _setDropDownBackgroundDrawable9207, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDropDownBackgroundResource9208; 
		public virtual void setDropDownBackgroundResource(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				@__env.CallVoidMethod(this, _setDropDownBackgroundResource9208, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AutoCompleteTextView.staticClass, _setDropDownBackgroundResource9208, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDropDownVerticalOffset9209; 
		public virtual void setDropDownVerticalOffset(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				@__env.CallVoidMethod(this, _setDropDownVerticalOffset9209, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AutoCompleteTextView.staticClass, _setDropDownVerticalOffset9209, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDropDownVerticalOffset9210; 
		public virtual int getDropDownVerticalOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				return @__env.CallIntMethod(this, _getDropDownVerticalOffset9210); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.AutoCompleteTextView.staticClass, _getDropDownVerticalOffset9210); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDropDownHorizontalOffset9211; 
		public virtual void setDropDownHorizontalOffset(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				@__env.CallVoidMethod(this, _setDropDownHorizontalOffset9211, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AutoCompleteTextView.staticClass, _setDropDownHorizontalOffset9211, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDropDownHorizontalOffset9212; 
		public virtual int getDropDownHorizontalOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				return @__env.CallIntMethod(this, _getDropDownHorizontalOffset9212); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.AutoCompleteTextView.staticClass, _getDropDownHorizontalOffset9212); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getThreshold9213; 
		public virtual int getThreshold() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				return @__env.CallIntMethod(this, _getThreshold9213); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.AutoCompleteTextView.staticClass, _getThreshold9213); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItemClickListener9214; 
		public virtual android.widget.AdapterView.OnItemClickListener getItemClickListener() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemClickListener>(@__env, @__env.CallObjectMethodPtr(this, _getItemClickListener9214)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemClickListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.AutoCompleteTextView.staticClass, _getItemClickListener9214)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItemSelectedListener9215; 
		public virtual android.widget.AdapterView.OnItemSelectedListener getItemSelectedListener() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemSelectedListener>(@__env, @__env.CallObjectMethodPtr(this, _getItemSelectedListener9215)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemSelectedListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.AutoCompleteTextView.staticClass, _getItemSelectedListener9215)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isPopupShowing9216; 
		public virtual bool isPopupShowing() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				return @__env.CallBooleanMethod(this, _isPopupShowing9216); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.AutoCompleteTextView.staticClass, _isPopupShowing9216); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _convertSelectionToString9217; 
		protected virtual java.lang.CharSequence convertSelectionToString(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _convertSelectionToString9217, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.AutoCompleteTextView.staticClass, _convertSelectionToString9217, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearListSelection9218; 
		public virtual void clearListSelection() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				@__env.CallVoidMethod(this, _clearListSelection9218); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AutoCompleteTextView.staticClass, _clearListSelection9218); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setListSelection9219; 
		public virtual void setListSelection(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				@__env.CallVoidMethod(this, _setListSelection9219, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AutoCompleteTextView.staticClass, _setListSelection9219, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getListSelection9220; 
		public virtual int getListSelection() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				return @__env.CallIntMethod(this, _getListSelection9220); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.AutoCompleteTextView.staticClass, _getListSelection9220); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performCompletion9221; 
		public virtual void performCompletion() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				@__env.CallVoidMethod(this, _performCompletion9221); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AutoCompleteTextView.staticClass, _performCompletion9221); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isPerformingCompletion9222; 
		public virtual bool isPerformingCompletion() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				return @__env.CallBooleanMethod(this, _isPerformingCompletion9222); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.AutoCompleteTextView.staticClass, _isPerformingCompletion9222); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dismissDropDown9223; 
		public virtual void dismissDropDown() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				@__env.CallVoidMethod(this, _dismissDropDown9223); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AutoCompleteTextView.staticClass, _dismissDropDown9223); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _showDropDown9224; 
		public virtual void showDropDown() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				@__env.CallVoidMethod(this, _showDropDown9224); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AutoCompleteTextView.staticClass, _showDropDown9224); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setValidator9225; 
		public virtual void setValidator(android.widget.AutoCompleteTextView.Validator arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				@__env.CallVoidMethod(this, _setValidator9225, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AutoCompleteTextView.staticClass, _setValidator9225, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getValidator9226; 
		public virtual android.widget.AutoCompleteTextView.Validator getValidator() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AutoCompleteTextView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AutoCompleteTextView.Validator>(@__env, @__env.CallObjectMethodPtr(this, _getValidator9226)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AutoCompleteTextView.Validator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.AutoCompleteTextView.staticClass, _getValidator9226)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AutoCompleteTextView9227; 
		public AutoCompleteTextView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.AutoCompleteTextView.staticClass, _AutoCompleteTextView9227, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AutoCompleteTextView9228; 
		public AutoCompleteTextView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.AutoCompleteTextView.staticClass, _AutoCompleteTextView9228, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AutoCompleteTextView9229; 
		public AutoCompleteTextView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.AutoCompleteTextView.staticClass, _AutoCompleteTextView9229, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.AutoCompleteTextView.staticClass = @__class; 
			global::android.widget.AutoCompleteTextView._setThreshold9176 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setThreshold", "(I)V"); 
			global::android.widget.AutoCompleteTextView._onKeyDown9177 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.widget.AutoCompleteTextView._onKeyUp9178 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.widget.AutoCompleteTextView._onWindowFocusChanged9179 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "onWindowFocusChanged", "(Z)V"); 
			global::android.widget.AutoCompleteTextView._onAttachedToWindow9180 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "onAttachedToWindow", "()V"); 
			global::android.widget.AutoCompleteTextView._onDetachedFromWindow9181 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "onDetachedFromWindow", "()V"); 
			global::android.widget.AutoCompleteTextView._setOnClickListener9182 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setOnClickListener", "(Landroid/view/View$OnClickListener;)V"); 
			global::android.widget.AutoCompleteTextView._onFocusChanged9183 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V"); 
			global::android.widget.AutoCompleteTextView._onKeyPreIme9184 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "onKeyPreIme", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.widget.AutoCompleteTextView._getFilter9185 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getFilter", "()Landroid/widget/Filter;"); 
			global::android.widget.AutoCompleteTextView._setAdapter9186 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setAdapter", "(Landroid/widget/ListAdapter;)V"); 
			global::android.widget.AutoCompleteTextView._setOnItemSelectedListener9187 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setOnItemSelectedListener", "(Landroid/widget/AdapterView$OnItemSelectedListener;)V"); 
			global::android.widget.AutoCompleteTextView._setOnItemClickListener9188 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V"); 
			global::android.widget.AutoCompleteTextView._getOnItemClickListener9189 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getOnItemClickListener", "()Landroid/widget/AdapterView$OnItemClickListener;"); 
			global::android.widget.AutoCompleteTextView._getOnItemSelectedListener9190 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getOnItemSelectedListener", "()Landroid/widget/AdapterView$OnItemSelectedListener;"); 
			global::android.widget.AutoCompleteTextView._getAdapter9191 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getAdapter", "()Landroid/widget/ListAdapter;"); 
			global::android.widget.AutoCompleteTextView._setFrame9192 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setFrame", "(IIII)Z"); 
			global::android.widget.AutoCompleteTextView._onCommitCompletion9193 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "onCommitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)V"); 
			global::android.widget.AutoCompleteTextView._onFilterComplete9194 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "onFilterComplete", "(I)V"); 
			global::android.widget.AutoCompleteTextView._performFiltering9195 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "performFiltering", "(Ljava/lang/CharSequence;I)V"); 
			global::android.widget.AutoCompleteTextView._enoughToFilter9196 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "enoughToFilter", "()Z"); 
			global::android.widget.AutoCompleteTextView._performValidation9197 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "performValidation", "()V"); 
			global::android.widget.AutoCompleteTextView._replaceText9198 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "replaceText", "(Ljava/lang/CharSequence;)V"); 
			global::android.widget.AutoCompleteTextView._setCompletionHint9199 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setCompletionHint", "(Ljava/lang/CharSequence;)V"); 
			global::android.widget.AutoCompleteTextView._getDropDownWidth9200 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getDropDownWidth", "()I"); 
			global::android.widget.AutoCompleteTextView._setDropDownWidth9201 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setDropDownWidth", "(I)V"); 
			global::android.widget.AutoCompleteTextView._getDropDownHeight9202 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getDropDownHeight", "()I"); 
			global::android.widget.AutoCompleteTextView._setDropDownHeight9203 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setDropDownHeight", "(I)V"); 
			global::android.widget.AutoCompleteTextView._getDropDownAnchor9204 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getDropDownAnchor", "()I"); 
			global::android.widget.AutoCompleteTextView._setDropDownAnchor9205 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setDropDownAnchor", "(I)V"); 
			global::android.widget.AutoCompleteTextView._getDropDownBackground9206 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getDropDownBackground", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.widget.AutoCompleteTextView._setDropDownBackgroundDrawable9207 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setDropDownBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.widget.AutoCompleteTextView._setDropDownBackgroundResource9208 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setDropDownBackgroundResource", "(I)V"); 
			global::android.widget.AutoCompleteTextView._setDropDownVerticalOffset9209 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setDropDownVerticalOffset", "(I)V"); 
			global::android.widget.AutoCompleteTextView._getDropDownVerticalOffset9210 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getDropDownVerticalOffset", "()I"); 
			global::android.widget.AutoCompleteTextView._setDropDownHorizontalOffset9211 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setDropDownHorizontalOffset", "(I)V"); 
			global::android.widget.AutoCompleteTextView._getDropDownHorizontalOffset9212 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getDropDownHorizontalOffset", "()I"); 
			global::android.widget.AutoCompleteTextView._getThreshold9213 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getThreshold", "()I"); 
			global::android.widget.AutoCompleteTextView._getItemClickListener9214 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getItemClickListener", "()Landroid/widget/AdapterView$OnItemClickListener;"); 
			global::android.widget.AutoCompleteTextView._getItemSelectedListener9215 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getItemSelectedListener", "()Landroid/widget/AdapterView$OnItemSelectedListener;"); 
			global::android.widget.AutoCompleteTextView._isPopupShowing9216 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "isPopupShowing", "()Z"); 
			global::android.widget.AutoCompleteTextView._convertSelectionToString9217 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "convertSelectionToString", "(Ljava/lang/Object;)Ljava/lang/CharSequence;"); 
			global::android.widget.AutoCompleteTextView._clearListSelection9218 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "clearListSelection", "()V"); 
			global::android.widget.AutoCompleteTextView._setListSelection9219 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setListSelection", "(I)V"); 
			global::android.widget.AutoCompleteTextView._getListSelection9220 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getListSelection", "()I"); 
			global::android.widget.AutoCompleteTextView._performCompletion9221 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "performCompletion", "()V"); 
			global::android.widget.AutoCompleteTextView._isPerformingCompletion9222 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "isPerformingCompletion", "()Z"); 
			global::android.widget.AutoCompleteTextView._dismissDropDown9223 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "dismissDropDown", "()V"); 
			global::android.widget.AutoCompleteTextView._showDropDown9224 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "showDropDown", "()V"); 
			global::android.widget.AutoCompleteTextView._setValidator9225 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setValidator", "(Landroid/widget/AutoCompleteTextView$Validator;)V"); 
			global::android.widget.AutoCompleteTextView._getValidator9226 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getValidator", "()Landroid/widget/AutoCompleteTextView$Validator;"); 
			global::android.widget.AutoCompleteTextView._AutoCompleteTextView9227 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.AutoCompleteTextView._AutoCompleteTextView9228 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.AutoCompleteTextView._AutoCompleteTextView9229 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
