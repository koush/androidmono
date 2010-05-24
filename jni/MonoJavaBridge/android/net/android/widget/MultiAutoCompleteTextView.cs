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
			internal static global::net.sf.jni4net.jni.MethodId _findTokenStart10519; 
			public virtual int findTokenStart(java.lang.CharSequence arg0, int arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.MultiAutoCompleteTextView.CommaTokenizer)) 
					return @__env.CallIntMethod(this, _findTokenStart10519, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, _findTokenStart10519, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _findTokenEnd10520; 
			public virtual int findTokenEnd(java.lang.CharSequence arg0, int arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.MultiAutoCompleteTextView.CommaTokenizer)) 
					return @__env.CallIntMethod(this, _findTokenEnd10520, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, _findTokenEnd10520, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _terminateToken10521; 
			public virtual java.lang.CharSequence terminateToken(java.lang.CharSequence arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.MultiAutoCompleteTextView.CommaTokenizer)) 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _terminateToken10521, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, _terminateToken10521, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _CommaTokenizer10522; 
			public CommaTokenizer()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, _CommaTokenizer10522, this); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass = @__class; 
				global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._findTokenStart10519 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, "findTokenStart", "(Ljava/lang/CharSequence;I)I"); 
				global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._findTokenEnd10520 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, "findTokenEnd", "(Ljava/lang/CharSequence;I)I"); 
				global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._terminateToken10521 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, "terminateToken", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;"); 
				global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._CommaTokenizer10522 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, "<init>", "()V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface Tokenizer 
		{ 
			int findTokenStart(java.lang.CharSequence arg0, int arg1); 
			int findTokenEnd(java.lang.CharSequence arg0, int arg1); 
			java.lang.CharSequence terminateToken(java.lang.CharSequence arg0); 
		} 

		public partial class Tokenizer_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __Tokenizer.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __Tokenizer : java.lang.Object, Tokenizer
		{ 
			internal static global::java.lang.Class staticClass; 
			static __Tokenizer() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.MultiAutoCompleteTextView.__Tokenizer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.widget.MultiAutoCompleteTextView.__Tokenizer(@__env); 
				} 
			} 
			internal __Tokenizer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _findTokenStart10523; 
			 int android.widget.MultiAutoCompleteTextView.Tokenizer.findTokenStart(java.lang.CharSequence arg0, int arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.MultiAutoCompleteTextView.__Tokenizer)) 
					return @__env.CallIntMethod(this, _findTokenStart10523, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.widget.MultiAutoCompleteTextView.__Tokenizer.staticClass, _findTokenStart10523, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _findTokenEnd10524; 
			 int android.widget.MultiAutoCompleteTextView.Tokenizer.findTokenEnd(java.lang.CharSequence arg0, int arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.MultiAutoCompleteTextView.__Tokenizer)) 
					return @__env.CallIntMethod(this, _findTokenEnd10524, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.widget.MultiAutoCompleteTextView.__Tokenizer.staticClass, _findTokenEnd10524, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _terminateToken10525; 
			 java.lang.CharSequence android.widget.MultiAutoCompleteTextView.Tokenizer.terminateToken(java.lang.CharSequence arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.MultiAutoCompleteTextView.__Tokenizer)) 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _terminateToken10525, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.MultiAutoCompleteTextView.__Tokenizer.staticClass, _terminateToken10525, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.widget.MultiAutoCompleteTextView.__Tokenizer.staticClass = @__class; 
				global::android.widget.MultiAutoCompleteTextView.__Tokenizer._findTokenStart10523 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.__Tokenizer.staticClass, "android.widget.MultiAutoCompleteTextView.Tokenizer.findTokenStart", "(Ljava/lang/CharSequence;I)I"); 
				global::android.widget.MultiAutoCompleteTextView.__Tokenizer._findTokenEnd10524 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.__Tokenizer.staticClass, "android.widget.MultiAutoCompleteTextView.Tokenizer.findTokenEnd", "(Ljava/lang/CharSequence;I)I"); 
				global::android.widget.MultiAutoCompleteTextView.__Tokenizer._terminateToken10525 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.__Tokenizer.staticClass, "android.widget.MultiAutoCompleteTextView.Tokenizer.terminateToken", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTokenizer10526; 
		public virtual void setTokenizer(android.widget.MultiAutoCompleteTextView.Tokenizer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.MultiAutoCompleteTextView)) 
				@__env.CallVoidMethod(this, _setTokenizer10526, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.MultiAutoCompleteTextView.staticClass, _setTokenizer10526, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performFiltering10527; 
		protected override void performFiltering(java.lang.CharSequence arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.MultiAutoCompleteTextView)) 
				@__env.CallVoidMethod(this, _performFiltering10527, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.MultiAutoCompleteTextView.staticClass, _performFiltering10527, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performFiltering10528; 
		protected virtual void performFiltering(java.lang.CharSequence arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.MultiAutoCompleteTextView)) 
				@__env.CallVoidMethod(this, _performFiltering10528, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.MultiAutoCompleteTextView.staticClass, _performFiltering10528, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _enoughToFilter10529; 
		public override bool enoughToFilter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.MultiAutoCompleteTextView)) 
				return @__env.CallBooleanMethod(this, _enoughToFilter10529); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.MultiAutoCompleteTextView.staticClass, _enoughToFilter10529); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performValidation10530; 
		public override void performValidation() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.MultiAutoCompleteTextView)) 
				@__env.CallVoidMethod(this, _performValidation10530); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.MultiAutoCompleteTextView.staticClass, _performValidation10530); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _replaceText10531; 
		protected override void replaceText(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.MultiAutoCompleteTextView)) 
				@__env.CallVoidMethod(this, _replaceText10531, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.MultiAutoCompleteTextView.staticClass, _replaceText10531, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _MultiAutoCompleteTextView10532; 
		public MultiAutoCompleteTextView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.MultiAutoCompleteTextView.staticClass, _MultiAutoCompleteTextView10532, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _MultiAutoCompleteTextView10533; 
		public MultiAutoCompleteTextView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.MultiAutoCompleteTextView.staticClass, _MultiAutoCompleteTextView10533, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _MultiAutoCompleteTextView10534; 
		public MultiAutoCompleteTextView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.MultiAutoCompleteTextView.staticClass, _MultiAutoCompleteTextView10534, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.MultiAutoCompleteTextView.staticClass = @__class; 
			global::android.widget.MultiAutoCompleteTextView._setTokenizer10526 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.staticClass, "setTokenizer", "(Landroid/widget/MultiAutoCompleteTextView$Tokenizer;)V"); 
			global::android.widget.MultiAutoCompleteTextView._performFiltering10527 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.staticClass, "performFiltering", "(Ljava/lang/CharSequence;I)V"); 
			global::android.widget.MultiAutoCompleteTextView._performFiltering10528 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.staticClass, "performFiltering", "(Ljava/lang/CharSequence;III)V"); 
			global::android.widget.MultiAutoCompleteTextView._enoughToFilter10529 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.staticClass, "enoughToFilter", "()Z"); 
			global::android.widget.MultiAutoCompleteTextView._performValidation10530 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.staticClass, "performValidation", "()V"); 
			global::android.widget.MultiAutoCompleteTextView._replaceText10531 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.staticClass, "replaceText", "(Ljava/lang/CharSequence;)V"); 
			global::android.widget.MultiAutoCompleteTextView._MultiAutoCompleteTextView10532 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.MultiAutoCompleteTextView._MultiAutoCompleteTextView10533 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.MultiAutoCompleteTextView._MultiAutoCompleteTextView10534 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
