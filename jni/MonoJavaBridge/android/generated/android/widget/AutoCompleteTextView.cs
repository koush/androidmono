namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class AutoCompleteTextView : android.widget.EditText, android.widget.Filter.FilterListener
	{
		internal new static global::java.lang.Class staticClass;
		static AutoCompleteTextView()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.AutoCompleteTextView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
			global::java.lang.CharSequence fixText(java.lang.CharSequence arg0);
		}

		public partial class Validator_
		{
			public static global::java.lang.Class _class
			{
				get { return __Validator.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __Validator : java.lang.Object, Validator
		{
			internal static global::java.lang.Class staticClass;
			static __Validator()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.AutoCompleteTextView.__Validator), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.AutoCompleteTextView.__Validator(@__env);
				}
			}
			internal __Validator(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _isValid9887;
			 bool android.widget.AutoCompleteTextView.Validator.isValid(java.lang.CharSequence arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.widget.AutoCompleteTextView.__Validator._isValid9887, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AutoCompleteTextView.__Validator.staticClass, global::android.widget.AutoCompleteTextView.__Validator._isValid9887, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _fixText9888;
			 global::java.lang.CharSequence android.widget.AutoCompleteTextView.Validator.fixText(java.lang.CharSequence arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AutoCompleteTextView.__Validator._fixText9888, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AutoCompleteTextView.__Validator.staticClass, global::android.widget.AutoCompleteTextView.__Validator._fixText9888, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.AutoCompleteTextView.__Validator.staticClass = @__class;
				global::android.widget.AutoCompleteTextView.__Validator._isValid9887 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.__Validator.staticClass, "android.widget.AutoCompleteTextView.Validator.isValid", "(Ljava/lang/CharSequence;)Z");
				global::android.widget.AutoCompleteTextView.__Validator._fixText9888 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.__Validator.staticClass, "android.widget.AutoCompleteTextView.Validator.fixText", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _setThreshold9889;
		public virtual void setThreshold(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._setThreshold9889, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setThreshold9889, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown9890;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AutoCompleteTextView._onKeyDown9890, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onKeyDown9890, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp9891;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AutoCompleteTextView._onKeyUp9891, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onKeyUp9891, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onWindowFocusChanged9892;
		public override void onWindowFocusChanged(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._onWindowFocusChanged9892, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onWindowFocusChanged9892, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToWindow9893;
		protected override void onAttachedToWindow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._onAttachedToWindow9893);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onAttachedToWindow9893);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow9894;
		protected override void onDetachedFromWindow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._onDetachedFromWindow9894);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onDetachedFromWindow9894);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnClickListener9895;
		public override void setOnClickListener(android.view.View.OnClickListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._setOnClickListener9895, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setOnClickListener9895, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onFocusChanged9896;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._onFocusChanged9896, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onFocusChanged9896, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyPreIme9897;
		public override bool onKeyPreIme(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AutoCompleteTextView._onKeyPreIme9897, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onKeyPreIme9897, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFilter9898;
		protected virtual global::android.widget.Filter getFilter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Filter>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AutoCompleteTextView._getFilter9898));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Filter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getFilter9898));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAdapter9899;
		public virtual void setAdapter(android.widget.ListAdapter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._setAdapter9899, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setAdapter9899, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnItemSelectedListener9900;
		public virtual void setOnItemSelectedListener(android.widget.AdapterView.OnItemSelectedListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._setOnItemSelectedListener9900, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setOnItemSelectedListener9900, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnItemClickListener9901;
		public virtual void setOnItemClickListener(android.widget.AdapterView.OnItemClickListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._setOnItemClickListener9901, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setOnItemClickListener9901, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOnItemClickListener9902;
		public virtual global::android.widget.AdapterView.OnItemClickListener getOnItemClickListener() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemClickListener>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AutoCompleteTextView._getOnItemClickListener9902));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemClickListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getOnItemClickListener9902));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOnItemSelectedListener9903;
		public virtual global::android.widget.AdapterView.OnItemSelectedListener getOnItemSelectedListener() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemSelectedListener>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AutoCompleteTextView._getOnItemSelectedListener9903));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemSelectedListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getOnItemSelectedListener9903));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAdapter9904;
		public virtual global::android.widget.ListAdapter getAdapter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ListAdapter>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AutoCompleteTextView._getAdapter9904));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ListAdapter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getAdapter9904));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFrame9905;
		protected override bool setFrame(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AutoCompleteTextView._setFrame9905, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setFrame9905, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCommitCompletion9906;
		public override void onCommitCompletion(android.view.inputmethod.CompletionInfo arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._onCommitCompletion9906, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onCommitCompletion9906, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onFilterComplete9907;
		public virtual void onFilterComplete(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._onFilterComplete9907, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onFilterComplete9907, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _performFiltering9908;
		protected virtual void performFiltering(java.lang.CharSequence arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._performFiltering9908, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._performFiltering9908, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _enoughToFilter9909;
		public virtual bool enoughToFilter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AutoCompleteTextView._enoughToFilter9909);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._enoughToFilter9909);
		}
		internal static global::net.sf.jni4net.jni.MethodId _performValidation9910;
		public virtual void performValidation() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._performValidation9910);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._performValidation9910);
		}
		internal static global::net.sf.jni4net.jni.MethodId _replaceText9911;
		protected virtual void replaceText(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._replaceText9911, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._replaceText9911, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCompletionHint9912;
		public virtual void setCompletionHint(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._setCompletionHint9912, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setCompletionHint9912, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		public void setCompletionHint(string arg0)
		{
			setCompletionHint((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDropDownWidth9913;
		public virtual int getDropDownWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AutoCompleteTextView._getDropDownWidth9913);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getDropDownWidth9913);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDropDownWidth9914;
		public virtual void setDropDownWidth(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._setDropDownWidth9914, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setDropDownWidth9914, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDropDownHeight9915;
		public virtual int getDropDownHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AutoCompleteTextView._getDropDownHeight9915);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getDropDownHeight9915);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDropDownHeight9916;
		public virtual void setDropDownHeight(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._setDropDownHeight9916, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setDropDownHeight9916, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDropDownAnchor9917;
		public virtual int getDropDownAnchor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AutoCompleteTextView._getDropDownAnchor9917);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getDropDownAnchor9917);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDropDownAnchor9918;
		public virtual void setDropDownAnchor(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._setDropDownAnchor9918, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setDropDownAnchor9918, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDropDownBackground9919;
		public virtual global::android.graphics.drawable.Drawable getDropDownBackground() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AutoCompleteTextView._getDropDownBackground9919));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getDropDownBackground9919));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDropDownBackgroundDrawable9920;
		public virtual void setDropDownBackgroundDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._setDropDownBackgroundDrawable9920, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setDropDownBackgroundDrawable9920, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDropDownBackgroundResource9921;
		public virtual void setDropDownBackgroundResource(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._setDropDownBackgroundResource9921, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setDropDownBackgroundResource9921, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDropDownVerticalOffset9922;
		public virtual void setDropDownVerticalOffset(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._setDropDownVerticalOffset9922, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setDropDownVerticalOffset9922, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDropDownVerticalOffset9923;
		public virtual int getDropDownVerticalOffset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AutoCompleteTextView._getDropDownVerticalOffset9923);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getDropDownVerticalOffset9923);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDropDownHorizontalOffset9924;
		public virtual void setDropDownHorizontalOffset(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._setDropDownHorizontalOffset9924, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setDropDownHorizontalOffset9924, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDropDownHorizontalOffset9925;
		public virtual int getDropDownHorizontalOffset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AutoCompleteTextView._getDropDownHorizontalOffset9925);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getDropDownHorizontalOffset9925);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getThreshold9926;
		public virtual int getThreshold() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AutoCompleteTextView._getThreshold9926);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getThreshold9926);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getItemClickListener9927;
		public virtual global::android.widget.AdapterView.OnItemClickListener getItemClickListener() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemClickListener>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AutoCompleteTextView._getItemClickListener9927));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemClickListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getItemClickListener9927));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getItemSelectedListener9928;
		public virtual global::android.widget.AdapterView.OnItemSelectedListener getItemSelectedListener() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemSelectedListener>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AutoCompleteTextView._getItemSelectedListener9928));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemSelectedListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getItemSelectedListener9928));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isPopupShowing9929;
		public virtual bool isPopupShowing() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AutoCompleteTextView._isPopupShowing9929);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._isPopupShowing9929);
		}
		internal static global::net.sf.jni4net.jni.MethodId _convertSelectionToString9930;
		protected virtual global::java.lang.CharSequence convertSelectionToString(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AutoCompleteTextView._convertSelectionToString9930, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._convertSelectionToString9930, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearListSelection9931;
		public virtual void clearListSelection() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._clearListSelection9931);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._clearListSelection9931);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setListSelection9932;
		public virtual void setListSelection(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._setListSelection9932, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setListSelection9932, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getListSelection9933;
		public virtual int getListSelection() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AutoCompleteTextView._getListSelection9933);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getListSelection9933);
		}
		internal static global::net.sf.jni4net.jni.MethodId _performCompletion9934;
		public virtual void performCompletion() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._performCompletion9934);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._performCompletion9934);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isPerformingCompletion9935;
		public virtual bool isPerformingCompletion() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AutoCompleteTextView._isPerformingCompletion9935);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._isPerformingCompletion9935);
		}
		internal static global::net.sf.jni4net.jni.MethodId _dismissDropDown9936;
		public virtual void dismissDropDown() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._dismissDropDown9936);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._dismissDropDown9936);
		}
		internal static global::net.sf.jni4net.jni.MethodId _showDropDown9937;
		public virtual void showDropDown() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._showDropDown9937);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._showDropDown9937);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setValidator9938;
		public virtual void setValidator(android.widget.AutoCompleteTextView.Validator arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._setValidator9938, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setValidator9938, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getValidator9939;
		public virtual global::android.widget.AutoCompleteTextView.Validator getValidator() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AutoCompleteTextView.Validator>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AutoCompleteTextView._getValidator9939));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AutoCompleteTextView.Validator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getValidator9939));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AutoCompleteTextView9940;
		public AutoCompleteTextView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._AutoCompleteTextView9940, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AutoCompleteTextView9941;
		public AutoCompleteTextView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._AutoCompleteTextView9941, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AutoCompleteTextView9942;
		public AutoCompleteTextView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._AutoCompleteTextView9942, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.AutoCompleteTextView.staticClass = @__class;
			global::android.widget.AutoCompleteTextView._setThreshold9889 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setThreshold", "(I)V");
			global::android.widget.AutoCompleteTextView._onKeyDown9890 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.AutoCompleteTextView._onKeyUp9891 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.AutoCompleteTextView._onWindowFocusChanged9892 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "onWindowFocusChanged", "(Z)V");
			global::android.widget.AutoCompleteTextView._onAttachedToWindow9893 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "onAttachedToWindow", "()V");
			global::android.widget.AutoCompleteTextView._onDetachedFromWindow9894 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "onDetachedFromWindow", "()V");
			global::android.widget.AutoCompleteTextView._setOnClickListener9895 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setOnClickListener", "(Landroid/view/View$OnClickListener;)V");
			global::android.widget.AutoCompleteTextView._onFocusChanged9896 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.widget.AutoCompleteTextView._onKeyPreIme9897 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "onKeyPreIme", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.AutoCompleteTextView._getFilter9898 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getFilter", "()Landroid/widget/Filter;");
			global::android.widget.AutoCompleteTextView._setAdapter9899 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setAdapter", "(Landroid/widget/ListAdapter;)V");
			global::android.widget.AutoCompleteTextView._setOnItemSelectedListener9900 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setOnItemSelectedListener", "(Landroid/widget/AdapterView$OnItemSelectedListener;)V");
			global::android.widget.AutoCompleteTextView._setOnItemClickListener9901 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V");
			global::android.widget.AutoCompleteTextView._getOnItemClickListener9902 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getOnItemClickListener", "()Landroid/widget/AdapterView$OnItemClickListener;");
			global::android.widget.AutoCompleteTextView._getOnItemSelectedListener9903 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getOnItemSelectedListener", "()Landroid/widget/AdapterView$OnItemSelectedListener;");
			global::android.widget.AutoCompleteTextView._getAdapter9904 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getAdapter", "()Landroid/widget/ListAdapter;");
			global::android.widget.AutoCompleteTextView._setFrame9905 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setFrame", "(IIII)Z");
			global::android.widget.AutoCompleteTextView._onCommitCompletion9906 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "onCommitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)V");
			global::android.widget.AutoCompleteTextView._onFilterComplete9907 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "onFilterComplete", "(I)V");
			global::android.widget.AutoCompleteTextView._performFiltering9908 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "performFiltering", "(Ljava/lang/CharSequence;I)V");
			global::android.widget.AutoCompleteTextView._enoughToFilter9909 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "enoughToFilter", "()Z");
			global::android.widget.AutoCompleteTextView._performValidation9910 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "performValidation", "()V");
			global::android.widget.AutoCompleteTextView._replaceText9911 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "replaceText", "(Ljava/lang/CharSequence;)V");
			global::android.widget.AutoCompleteTextView._setCompletionHint9912 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setCompletionHint", "(Ljava/lang/CharSequence;)V");
			global::android.widget.AutoCompleteTextView._getDropDownWidth9913 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getDropDownWidth", "()I");
			global::android.widget.AutoCompleteTextView._setDropDownWidth9914 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setDropDownWidth", "(I)V");
			global::android.widget.AutoCompleteTextView._getDropDownHeight9915 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getDropDownHeight", "()I");
			global::android.widget.AutoCompleteTextView._setDropDownHeight9916 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setDropDownHeight", "(I)V");
			global::android.widget.AutoCompleteTextView._getDropDownAnchor9917 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getDropDownAnchor", "()I");
			global::android.widget.AutoCompleteTextView._setDropDownAnchor9918 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setDropDownAnchor", "(I)V");
			global::android.widget.AutoCompleteTextView._getDropDownBackground9919 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getDropDownBackground", "()Landroid/graphics/drawable/Drawable;");
			global::android.widget.AutoCompleteTextView._setDropDownBackgroundDrawable9920 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setDropDownBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.AutoCompleteTextView._setDropDownBackgroundResource9921 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setDropDownBackgroundResource", "(I)V");
			global::android.widget.AutoCompleteTextView._setDropDownVerticalOffset9922 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setDropDownVerticalOffset", "(I)V");
			global::android.widget.AutoCompleteTextView._getDropDownVerticalOffset9923 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getDropDownVerticalOffset", "()I");
			global::android.widget.AutoCompleteTextView._setDropDownHorizontalOffset9924 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setDropDownHorizontalOffset", "(I)V");
			global::android.widget.AutoCompleteTextView._getDropDownHorizontalOffset9925 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getDropDownHorizontalOffset", "()I");
			global::android.widget.AutoCompleteTextView._getThreshold9926 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getThreshold", "()I");
			global::android.widget.AutoCompleteTextView._getItemClickListener9927 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getItemClickListener", "()Landroid/widget/AdapterView$OnItemClickListener;");
			global::android.widget.AutoCompleteTextView._getItemSelectedListener9928 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getItemSelectedListener", "()Landroid/widget/AdapterView$OnItemSelectedListener;");
			global::android.widget.AutoCompleteTextView._isPopupShowing9929 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "isPopupShowing", "()Z");
			global::android.widget.AutoCompleteTextView._convertSelectionToString9930 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "convertSelectionToString", "(Ljava/lang/Object;)Ljava/lang/CharSequence;");
			global::android.widget.AutoCompleteTextView._clearListSelection9931 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "clearListSelection", "()V");
			global::android.widget.AutoCompleteTextView._setListSelection9932 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setListSelection", "(I)V");
			global::android.widget.AutoCompleteTextView._getListSelection9933 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getListSelection", "()I");
			global::android.widget.AutoCompleteTextView._performCompletion9934 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "performCompletion", "()V");
			global::android.widget.AutoCompleteTextView._isPerformingCompletion9935 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "isPerformingCompletion", "()Z");
			global::android.widget.AutoCompleteTextView._dismissDropDown9936 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "dismissDropDown", "()V");
			global::android.widget.AutoCompleteTextView._showDropDown9937 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "showDropDown", "()V");
			global::android.widget.AutoCompleteTextView._setValidator9938 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setValidator", "(Landroid/widget/AutoCompleteTextView$Validator;)V");
			global::android.widget.AutoCompleteTextView._getValidator9939 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getValidator", "()Landroid/widget/AutoCompleteTextView$Validator;");
			global::android.widget.AutoCompleteTextView._AutoCompleteTextView9940 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.AutoCompleteTextView._AutoCompleteTextView9941 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.AutoCompleteTextView._AutoCompleteTextView9942 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
