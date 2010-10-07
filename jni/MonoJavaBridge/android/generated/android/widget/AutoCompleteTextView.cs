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
			internal static global::net.sf.jni4net.jni.MethodId _isValid10584;
			 bool android.widget.AutoCompleteTextView.Validator.isValid(java.lang.CharSequence arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.widget.AutoCompleteTextView.__Validator._isValid10584, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AutoCompleteTextView.__Validator.staticClass, global::android.widget.AutoCompleteTextView.__Validator._isValid10584, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _fixText10585;
			 global::java.lang.CharSequence android.widget.AutoCompleteTextView.Validator.fixText(java.lang.CharSequence arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AutoCompleteTextView.__Validator._fixText10585, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AutoCompleteTextView.__Validator.staticClass, global::android.widget.AutoCompleteTextView.__Validator._fixText10585, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.AutoCompleteTextView.__Validator.staticClass = @__class;
				global::android.widget.AutoCompleteTextView.__Validator._isValid10584 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.__Validator.staticClass, "android.widget.AutoCompleteTextView.Validator.isValid", "(Ljava/lang/CharSequence;)Z");
				global::android.widget.AutoCompleteTextView.__Validator._fixText10585 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.__Validator.staticClass, "android.widget.AutoCompleteTextView.Validator.fixText", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _setThreshold10586;
		public virtual void setThreshold(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._setThreshold10586, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setThreshold10586, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown10587;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AutoCompleteTextView._onKeyDown10587, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onKeyDown10587, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp10588;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AutoCompleteTextView._onKeyUp10588, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onKeyUp10588, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onWindowFocusChanged10589;
		public override void onWindowFocusChanged(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._onWindowFocusChanged10589, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onWindowFocusChanged10589, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToWindow10590;
		protected override void onAttachedToWindow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._onAttachedToWindow10590);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onAttachedToWindow10590);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow10591;
		protected override void onDetachedFromWindow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._onDetachedFromWindow10591);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onDetachedFromWindow10591);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnClickListener10592;
		public override void setOnClickListener(android.view.View.OnClickListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._setOnClickListener10592, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setOnClickListener10592, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onFocusChanged10593;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._onFocusChanged10593, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onFocusChanged10593, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDisplayHint10594;
		protected override void onDisplayHint(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._onDisplayHint10594, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onDisplayHint10594, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyPreIme10595;
		public override bool onKeyPreIme(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AutoCompleteTextView._onKeyPreIme10595, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onKeyPreIme10595, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFilter10596;
		protected virtual global::android.widget.Filter getFilter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Filter>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AutoCompleteTextView._getFilter10596));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Filter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getFilter10596));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAdapter10597;
		public virtual void setAdapter(android.widget.ListAdapter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._setAdapter10597, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setAdapter10597, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnItemSelectedListener10598;
		public virtual void setOnItemSelectedListener(android.widget.AdapterView.OnItemSelectedListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._setOnItemSelectedListener10598, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setOnItemSelectedListener10598, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnItemClickListener10599;
		public virtual void setOnItemClickListener(android.widget.AdapterView.OnItemClickListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._setOnItemClickListener10599, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setOnItemClickListener10599, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOnItemClickListener10600;
		public virtual global::android.widget.AdapterView.OnItemClickListener getOnItemClickListener() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemClickListener>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AutoCompleteTextView._getOnItemClickListener10600));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemClickListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getOnItemClickListener10600));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOnItemSelectedListener10601;
		public virtual global::android.widget.AdapterView.OnItemSelectedListener getOnItemSelectedListener() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemSelectedListener>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AutoCompleteTextView._getOnItemSelectedListener10601));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemSelectedListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getOnItemSelectedListener10601));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAdapter10602;
		public virtual global::android.widget.ListAdapter getAdapter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ListAdapter>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AutoCompleteTextView._getAdapter10602));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ListAdapter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getAdapter10602));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFrame10603;
		protected override bool setFrame(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AutoCompleteTextView._setFrame10603, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setFrame10603, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCommitCompletion10604;
		public override void onCommitCompletion(android.view.inputmethod.CompletionInfo arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._onCommitCompletion10604, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onCommitCompletion10604, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onFilterComplete10605;
		public virtual void onFilterComplete(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._onFilterComplete10605, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._onFilterComplete10605, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _performFiltering10606;
		protected virtual void performFiltering(java.lang.CharSequence arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._performFiltering10606, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._performFiltering10606, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _enoughToFilter10607;
		public virtual bool enoughToFilter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AutoCompleteTextView._enoughToFilter10607);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._enoughToFilter10607);
		}
		internal static global::net.sf.jni4net.jni.MethodId _performValidation10608;
		public virtual void performValidation() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._performValidation10608);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._performValidation10608);
		}
		internal static global::net.sf.jni4net.jni.MethodId _replaceText10609;
		protected virtual void replaceText(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._replaceText10609, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._replaceText10609, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCompletionHint10610;
		public virtual void setCompletionHint(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._setCompletionHint10610, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setCompletionHint10610, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		public void setCompletionHint(string arg0)
		{
			setCompletionHint((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDropDownWidth10611;
		public virtual int getDropDownWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AutoCompleteTextView._getDropDownWidth10611);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getDropDownWidth10611);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDropDownWidth10612;
		public virtual void setDropDownWidth(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._setDropDownWidth10612, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setDropDownWidth10612, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDropDownHeight10613;
		public virtual int getDropDownHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AutoCompleteTextView._getDropDownHeight10613);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getDropDownHeight10613);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDropDownHeight10614;
		public virtual void setDropDownHeight(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._setDropDownHeight10614, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setDropDownHeight10614, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDropDownAnchor10615;
		public virtual int getDropDownAnchor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AutoCompleteTextView._getDropDownAnchor10615);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getDropDownAnchor10615);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDropDownAnchor10616;
		public virtual void setDropDownAnchor(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._setDropDownAnchor10616, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setDropDownAnchor10616, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDropDownBackground10617;
		public virtual global::android.graphics.drawable.Drawable getDropDownBackground() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AutoCompleteTextView._getDropDownBackground10617));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getDropDownBackground10617));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDropDownBackgroundDrawable10618;
		public virtual void setDropDownBackgroundDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._setDropDownBackgroundDrawable10618, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setDropDownBackgroundDrawable10618, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDropDownBackgroundResource10619;
		public virtual void setDropDownBackgroundResource(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._setDropDownBackgroundResource10619, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setDropDownBackgroundResource10619, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDropDownVerticalOffset10620;
		public virtual void setDropDownVerticalOffset(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._setDropDownVerticalOffset10620, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setDropDownVerticalOffset10620, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDropDownVerticalOffset10621;
		public virtual int getDropDownVerticalOffset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AutoCompleteTextView._getDropDownVerticalOffset10621);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getDropDownVerticalOffset10621);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDropDownHorizontalOffset10622;
		public virtual void setDropDownHorizontalOffset(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._setDropDownHorizontalOffset10622, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setDropDownHorizontalOffset10622, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDropDownHorizontalOffset10623;
		public virtual int getDropDownHorizontalOffset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AutoCompleteTextView._getDropDownHorizontalOffset10623);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getDropDownHorizontalOffset10623);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getThreshold10624;
		public virtual int getThreshold() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AutoCompleteTextView._getThreshold10624);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getThreshold10624);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getItemClickListener10625;
		public virtual global::android.widget.AdapterView.OnItemClickListener getItemClickListener() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemClickListener>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AutoCompleteTextView._getItemClickListener10625));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemClickListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getItemClickListener10625));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getItemSelectedListener10626;
		public virtual global::android.widget.AdapterView.OnItemSelectedListener getItemSelectedListener() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemSelectedListener>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AutoCompleteTextView._getItemSelectedListener10626));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemSelectedListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getItemSelectedListener10626));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isPopupShowing10627;
		public virtual bool isPopupShowing() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AutoCompleteTextView._isPopupShowing10627);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._isPopupShowing10627);
		}
		internal static global::net.sf.jni4net.jni.MethodId _convertSelectionToString10628;
		protected virtual global::java.lang.CharSequence convertSelectionToString(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AutoCompleteTextView._convertSelectionToString10628, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._convertSelectionToString10628, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearListSelection10629;
		public virtual void clearListSelection() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._clearListSelection10629);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._clearListSelection10629);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setListSelection10630;
		public virtual void setListSelection(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._setListSelection10630, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setListSelection10630, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getListSelection10631;
		public virtual int getListSelection() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AutoCompleteTextView._getListSelection10631);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getListSelection10631);
		}
		internal static global::net.sf.jni4net.jni.MethodId _performCompletion10632;
		public virtual void performCompletion() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._performCompletion10632);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._performCompletion10632);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isPerformingCompletion10633;
		public virtual bool isPerformingCompletion() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AutoCompleteTextView._isPerformingCompletion10633);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._isPerformingCompletion10633);
		}
		internal static global::net.sf.jni4net.jni.MethodId _dismissDropDown10634;
		public virtual void dismissDropDown() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._dismissDropDown10634);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._dismissDropDown10634);
		}
		internal static global::net.sf.jni4net.jni.MethodId _showDropDown10635;
		public virtual void showDropDown() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._showDropDown10635);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._showDropDown10635);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setValidator10636;
		public virtual void setValidator(android.widget.AutoCompleteTextView.Validator arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AutoCompleteTextView._setValidator10636, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._setValidator10636, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getValidator10637;
		public virtual global::android.widget.AutoCompleteTextView.Validator getValidator() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AutoCompleteTextView.Validator>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AutoCompleteTextView._getValidator10637));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AutoCompleteTextView.Validator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._getValidator10637));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AutoCompleteTextView10638;
		public AutoCompleteTextView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._AutoCompleteTextView10638, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AutoCompleteTextView10639;
		public AutoCompleteTextView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._AutoCompleteTextView10639, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AutoCompleteTextView10640;
		public AutoCompleteTextView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.AutoCompleteTextView.staticClass, global::android.widget.AutoCompleteTextView._AutoCompleteTextView10640, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.AutoCompleteTextView.staticClass = @__class;
			global::android.widget.AutoCompleteTextView._setThreshold10586 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setThreshold", "(I)V");
			global::android.widget.AutoCompleteTextView._onKeyDown10587 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.AutoCompleteTextView._onKeyUp10588 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.AutoCompleteTextView._onWindowFocusChanged10589 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "onWindowFocusChanged", "(Z)V");
			global::android.widget.AutoCompleteTextView._onAttachedToWindow10590 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "onAttachedToWindow", "()V");
			global::android.widget.AutoCompleteTextView._onDetachedFromWindow10591 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "onDetachedFromWindow", "()V");
			global::android.widget.AutoCompleteTextView._setOnClickListener10592 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setOnClickListener", "(Landroid/view/View$OnClickListener;)V");
			global::android.widget.AutoCompleteTextView._onFocusChanged10593 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.widget.AutoCompleteTextView._onDisplayHint10594 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "onDisplayHint", "(I)V");
			global::android.widget.AutoCompleteTextView._onKeyPreIme10595 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "onKeyPreIme", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.AutoCompleteTextView._getFilter10596 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getFilter", "()Landroid/widget/Filter;");
			global::android.widget.AutoCompleteTextView._setAdapter10597 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setAdapter", "(Landroid/widget/ListAdapter;)V");
			global::android.widget.AutoCompleteTextView._setOnItemSelectedListener10598 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setOnItemSelectedListener", "(Landroid/widget/AdapterView$OnItemSelectedListener;)V");
			global::android.widget.AutoCompleteTextView._setOnItemClickListener10599 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V");
			global::android.widget.AutoCompleteTextView._getOnItemClickListener10600 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getOnItemClickListener", "()Landroid/widget/AdapterView$OnItemClickListener;");
			global::android.widget.AutoCompleteTextView._getOnItemSelectedListener10601 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getOnItemSelectedListener", "()Landroid/widget/AdapterView$OnItemSelectedListener;");
			global::android.widget.AutoCompleteTextView._getAdapter10602 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getAdapter", "()Landroid/widget/ListAdapter;");
			global::android.widget.AutoCompleteTextView._setFrame10603 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setFrame", "(IIII)Z");
			global::android.widget.AutoCompleteTextView._onCommitCompletion10604 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "onCommitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)V");
			global::android.widget.AutoCompleteTextView._onFilterComplete10605 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "onFilterComplete", "(I)V");
			global::android.widget.AutoCompleteTextView._performFiltering10606 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "performFiltering", "(Ljava/lang/CharSequence;I)V");
			global::android.widget.AutoCompleteTextView._enoughToFilter10607 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "enoughToFilter", "()Z");
			global::android.widget.AutoCompleteTextView._performValidation10608 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "performValidation", "()V");
			global::android.widget.AutoCompleteTextView._replaceText10609 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "replaceText", "(Ljava/lang/CharSequence;)V");
			global::android.widget.AutoCompleteTextView._setCompletionHint10610 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setCompletionHint", "(Ljava/lang/CharSequence;)V");
			global::android.widget.AutoCompleteTextView._getDropDownWidth10611 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getDropDownWidth", "()I");
			global::android.widget.AutoCompleteTextView._setDropDownWidth10612 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setDropDownWidth", "(I)V");
			global::android.widget.AutoCompleteTextView._getDropDownHeight10613 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getDropDownHeight", "()I");
			global::android.widget.AutoCompleteTextView._setDropDownHeight10614 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setDropDownHeight", "(I)V");
			global::android.widget.AutoCompleteTextView._getDropDownAnchor10615 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getDropDownAnchor", "()I");
			global::android.widget.AutoCompleteTextView._setDropDownAnchor10616 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setDropDownAnchor", "(I)V");
			global::android.widget.AutoCompleteTextView._getDropDownBackground10617 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getDropDownBackground", "()Landroid/graphics/drawable/Drawable;");
			global::android.widget.AutoCompleteTextView._setDropDownBackgroundDrawable10618 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setDropDownBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.AutoCompleteTextView._setDropDownBackgroundResource10619 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setDropDownBackgroundResource", "(I)V");
			global::android.widget.AutoCompleteTextView._setDropDownVerticalOffset10620 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setDropDownVerticalOffset", "(I)V");
			global::android.widget.AutoCompleteTextView._getDropDownVerticalOffset10621 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getDropDownVerticalOffset", "()I");
			global::android.widget.AutoCompleteTextView._setDropDownHorizontalOffset10622 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setDropDownHorizontalOffset", "(I)V");
			global::android.widget.AutoCompleteTextView._getDropDownHorizontalOffset10623 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getDropDownHorizontalOffset", "()I");
			global::android.widget.AutoCompleteTextView._getThreshold10624 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getThreshold", "()I");
			global::android.widget.AutoCompleteTextView._getItemClickListener10625 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getItemClickListener", "()Landroid/widget/AdapterView$OnItemClickListener;");
			global::android.widget.AutoCompleteTextView._getItemSelectedListener10626 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getItemSelectedListener", "()Landroid/widget/AdapterView$OnItemSelectedListener;");
			global::android.widget.AutoCompleteTextView._isPopupShowing10627 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "isPopupShowing", "()Z");
			global::android.widget.AutoCompleteTextView._convertSelectionToString10628 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "convertSelectionToString", "(Ljava/lang/Object;)Ljava/lang/CharSequence;");
			global::android.widget.AutoCompleteTextView._clearListSelection10629 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "clearListSelection", "()V");
			global::android.widget.AutoCompleteTextView._setListSelection10630 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setListSelection", "(I)V");
			global::android.widget.AutoCompleteTextView._getListSelection10631 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getListSelection", "()I");
			global::android.widget.AutoCompleteTextView._performCompletion10632 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "performCompletion", "()V");
			global::android.widget.AutoCompleteTextView._isPerformingCompletion10633 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "isPerformingCompletion", "()Z");
			global::android.widget.AutoCompleteTextView._dismissDropDown10634 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "dismissDropDown", "()V");
			global::android.widget.AutoCompleteTextView._showDropDown10635 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "showDropDown", "()V");
			global::android.widget.AutoCompleteTextView._setValidator10636 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "setValidator", "(Landroid/widget/AutoCompleteTextView$Validator;)V");
			global::android.widget.AutoCompleteTextView._getValidator10637 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "getValidator", "()Landroid/widget/AutoCompleteTextView$Validator;");
			global::android.widget.AutoCompleteTextView._AutoCompleteTextView10638 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.AutoCompleteTextView._AutoCompleteTextView10639 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.AutoCompleteTextView._AutoCompleteTextView10640 = @__env.GetMethodID(global::android.widget.AutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
