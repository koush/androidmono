namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class MultiAutoCompleteTextView : android.widget.AutoCompleteTextView
	{ 
		internal new static global::java.lang.Class staticClass; 
		static MultiAutoCompleteTextView() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.MultiAutoCompleteTextView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.MultiAutoCompleteTextView(@__env); 
			} 
		} 
		protected MultiAutoCompleteTextView(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class CommaTokenizer : java.lang.Object, Tokenizer
		{ 
			internal static global::java.lang.Class staticClass; 
			static CommaTokenizer() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.MultiAutoCompleteTextView.CommaTokenizer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.widget.MultiAutoCompleteTextView.CommaTokenizer(@__env); 
				} 
			} 
			protected CommaTokenizer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _findTokenStart9753; 
			public virtual int findTokenStart(java.lang.CharSequence arg0, int arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.MultiAutoCompleteTextView.CommaTokenizer)) 
					return @__env.CallIntMethod(this, _findTokenStart9753, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, _findTokenStart9753, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _findTokenEnd9754; 
			public virtual int findTokenEnd(java.lang.CharSequence arg0, int arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.MultiAutoCompleteTextView.CommaTokenizer)) 
					return @__env.CallIntMethod(this, _findTokenEnd9754, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, _findTokenEnd9754, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _terminateToken9755; 
			public virtual java.lang.CharSequence terminateToken(java.lang.CharSequence arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.MultiAutoCompleteTextView.CommaTokenizer)) 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _terminateToken9755, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, _terminateToken9755, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _CommaTokenizer9756; 
			public CommaTokenizer()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, _CommaTokenizer9756, this); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass = @__class; 
				global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._findTokenStart9753 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, "findTokenStart", "(Ljava/lang/CharSequence;I)I"); 
				global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._findTokenEnd9754 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, "findTokenEnd", "(Ljava/lang/CharSequence;I)I"); 
				global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._terminateToken9755 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, "terminateToken", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;"); 
				global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._CommaTokenizer9756 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, "<init>", "()V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface Tokenizer 
		{ 
			int findTokenStart(java.lang.CharSequence arg0, int arg1); 
			int findTokenEnd(java.lang.CharSequence arg0, int arg1); 
			java.lang.CharSequence terminateToken(java.lang.CharSequence arg0); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTokenizer9757; 
		public virtual void setTokenizer(android.widget.MultiAutoCompleteTextView.Tokenizer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.MultiAutoCompleteTextView)) 
				@__env.CallVoidMethod(this, _setTokenizer9757, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.MultiAutoCompleteTextView.staticClass, _setTokenizer9757, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performFiltering9758; 
		protected override void performFiltering(java.lang.CharSequence arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.MultiAutoCompleteTextView)) 
				@__env.CallVoidMethod(this, _performFiltering9758, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.MultiAutoCompleteTextView.staticClass, _performFiltering9758, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performFiltering9759; 
		protected virtual void performFiltering(java.lang.CharSequence arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.MultiAutoCompleteTextView)) 
				@__env.CallVoidMethod(this, _performFiltering9759, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.MultiAutoCompleteTextView.staticClass, _performFiltering9759, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _enoughToFilter9760; 
		public override bool enoughToFilter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.MultiAutoCompleteTextView)) 
				return @__env.CallBooleanMethod(this, _enoughToFilter9760); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.MultiAutoCompleteTextView.staticClass, _enoughToFilter9760); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performValidation9761; 
		public override void performValidation() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.MultiAutoCompleteTextView)) 
				@__env.CallVoidMethod(this, _performValidation9761); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.MultiAutoCompleteTextView.staticClass, _performValidation9761); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _replaceText9762; 
		protected override void replaceText(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.MultiAutoCompleteTextView)) 
				@__env.CallVoidMethod(this, _replaceText9762, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.MultiAutoCompleteTextView.staticClass, _replaceText9762, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _MultiAutoCompleteTextView9763; 
		public MultiAutoCompleteTextView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.MultiAutoCompleteTextView.staticClass, _MultiAutoCompleteTextView9763, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _MultiAutoCompleteTextView9764; 
		public MultiAutoCompleteTextView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.MultiAutoCompleteTextView.staticClass, _MultiAutoCompleteTextView9764, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _MultiAutoCompleteTextView9765; 
		public MultiAutoCompleteTextView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.MultiAutoCompleteTextView.staticClass, _MultiAutoCompleteTextView9765, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.MultiAutoCompleteTextView.staticClass = @__class; 
			global::android.widget.MultiAutoCompleteTextView._setTokenizer9757 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.staticClass, "setTokenizer", "(Landroid/widget/MultiAutoCompleteTextView$Tokenizer;)V"); 
			global::android.widget.MultiAutoCompleteTextView._performFiltering9758 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.staticClass, "performFiltering", "(Ljava/lang/CharSequence;I)V"); 
			global::android.widget.MultiAutoCompleteTextView._performFiltering9759 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.staticClass, "performFiltering", "(Ljava/lang/CharSequence;III)V"); 
			global::android.widget.MultiAutoCompleteTextView._enoughToFilter9760 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.staticClass, "enoughToFilter", "()Z"); 
			global::android.widget.MultiAutoCompleteTextView._performValidation9761 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.staticClass, "performValidation", "()V"); 
			global::android.widget.MultiAutoCompleteTextView._replaceText9762 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.staticClass, "replaceText", "(Ljava/lang/CharSequence;)V"); 
			global::android.widget.MultiAutoCompleteTextView._MultiAutoCompleteTextView9763 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.MultiAutoCompleteTextView._MultiAutoCompleteTextView9764 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.MultiAutoCompleteTextView._MultiAutoCompleteTextView9765 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
