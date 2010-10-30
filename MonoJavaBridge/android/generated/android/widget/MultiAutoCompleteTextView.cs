namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MultiAutoCompleteTextView : android.widget.AutoCompleteTextView
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MultiAutoCompleteTextView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class CommaTokenizer : java.lang.Object, Tokenizer
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected CommaTokenizer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _findTokenStart17423;
			public virtual int findTokenStart(java.lang.CharSequence arg0, int arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._findTokenStart17423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			public int findTokenStart(string arg0, int arg1)
			{
				return findTokenStart((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
			}
			internal static global::MonoJavaBridge.MethodId _findTokenEnd17424;
			public virtual int findTokenEnd(java.lang.CharSequence arg0, int arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._findTokenEnd17424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			public int findTokenEnd(string arg0, int arg1)
			{
				return findTokenEnd((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
			}
			internal static global::MonoJavaBridge.MethodId _terminateToken17425;
			public virtual global::java.lang.CharSequence terminateToken(java.lang.CharSequence arg0)
			{
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._terminateToken17425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			}
			public java.lang.CharSequence terminateToken(string arg0)
			{
				return terminateToken((global::java.lang.CharSequence)(global::java.lang.String)arg0);
			}
			internal static global::MonoJavaBridge.MethodId _CommaTokenizer17426;
			public CommaTokenizer() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._CommaTokenizer17426);
				Init(@__env, handle);
			}
			static CommaTokenizer()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/MultiAutoCompleteTextView$CommaTokenizer"));
				global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._findTokenStart17423 = @__env.GetMethodIDNoThrow(global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, "findTokenStart", "(Ljava/lang/CharSequence;I)I");
				global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._findTokenEnd17424 = @__env.GetMethodIDNoThrow(global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, "findTokenEnd", "(Ljava/lang/CharSequence;I)I");
				global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._terminateToken17425 = @__env.GetMethodIDNoThrow(global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, "terminateToken", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
				global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._CommaTokenizer17426 = @__env.GetMethodIDNoThrow(global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, "<init>", "()V");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.MultiAutoCompleteTextView.Tokenizer_))]
		public partial interface Tokenizer  : global::MonoJavaBridge.IJavaObject 
		{
			int findTokenStart(java.lang.CharSequence arg0, int arg1);
			int findTokenEnd(java.lang.CharSequence arg0, int arg1);
			global::java.lang.CharSequence terminateToken(java.lang.CharSequence arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.MultiAutoCompleteTextView.Tokenizer))]
		internal sealed partial class Tokenizer_ : java.lang.Object, Tokenizer
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Tokenizer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _findTokenStart17427;
			int android.widget.MultiAutoCompleteTextView.Tokenizer.findTokenStart(java.lang.CharSequence arg0, int arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.MultiAutoCompleteTextView.Tokenizer_._findTokenStart17427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _findTokenEnd17428;
			int android.widget.MultiAutoCompleteTextView.Tokenizer.findTokenEnd(java.lang.CharSequence arg0, int arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.MultiAutoCompleteTextView.Tokenizer_._findTokenEnd17428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _terminateToken17429;
			global::java.lang.CharSequence android.widget.MultiAutoCompleteTextView.Tokenizer.terminateToken(java.lang.CharSequence arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.MultiAutoCompleteTextView.Tokenizer_._terminateToken17429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			}
			static Tokenizer_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.MultiAutoCompleteTextView.Tokenizer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/MultiAutoCompleteTextView$Tokenizer"));
				global::android.widget.MultiAutoCompleteTextView.Tokenizer_._findTokenStart17427 = @__env.GetMethodIDNoThrow(global::android.widget.MultiAutoCompleteTextView.Tokenizer_.staticClass, "findTokenStart", "(Ljava/lang/CharSequence;I)I");
				global::android.widget.MultiAutoCompleteTextView.Tokenizer_._findTokenEnd17428 = @__env.GetMethodIDNoThrow(global::android.widget.MultiAutoCompleteTextView.Tokenizer_.staticClass, "findTokenEnd", "(Ljava/lang/CharSequence;I)I");
				global::android.widget.MultiAutoCompleteTextView.Tokenizer_._terminateToken17429 = @__env.GetMethodIDNoThrow(global::android.widget.MultiAutoCompleteTextView.Tokenizer_.staticClass, "terminateToken", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _setTokenizer17430;
		public virtual void setTokenizer(android.widget.MultiAutoCompleteTextView.Tokenizer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.MultiAutoCompleteTextView.staticClass, global::android.widget.MultiAutoCompleteTextView._setTokenizer17430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performFiltering17431;
		protected override void performFiltering(java.lang.CharSequence arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.MultiAutoCompleteTextView.staticClass, global::android.widget.MultiAutoCompleteTextView._performFiltering17431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		protected void performFiltering(string arg0, int arg1)
		{
			performFiltering((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _performFiltering17432;
		protected virtual void performFiltering(java.lang.CharSequence arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.MultiAutoCompleteTextView.staticClass, global::android.widget.MultiAutoCompleteTextView._performFiltering17432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		protected void performFiltering(string arg0, int arg1, int arg2, int arg3)
		{
			performFiltering((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _enoughToFilter17433;
		public override bool enoughToFilter()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.MultiAutoCompleteTextView.staticClass, global::android.widget.MultiAutoCompleteTextView._enoughToFilter17433);
		}
		internal static global::MonoJavaBridge.MethodId _performValidation17434;
		public override void performValidation()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.MultiAutoCompleteTextView.staticClass, global::android.widget.MultiAutoCompleteTextView._performValidation17434);
		}
		internal static global::MonoJavaBridge.MethodId _replaceText17435;
		protected override void replaceText(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.MultiAutoCompleteTextView.staticClass, global::android.widget.MultiAutoCompleteTextView._replaceText17435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		protected void replaceText(string arg0)
		{
			replaceText((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _MultiAutoCompleteTextView17436;
		public MultiAutoCompleteTextView(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.MultiAutoCompleteTextView.staticClass, global::android.widget.MultiAutoCompleteTextView._MultiAutoCompleteTextView17436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MultiAutoCompleteTextView17437;
		public MultiAutoCompleteTextView(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.MultiAutoCompleteTextView.staticClass, global::android.widget.MultiAutoCompleteTextView._MultiAutoCompleteTextView17437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MultiAutoCompleteTextView17438;
		public MultiAutoCompleteTextView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.MultiAutoCompleteTextView.staticClass, global::android.widget.MultiAutoCompleteTextView._MultiAutoCompleteTextView17438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static MultiAutoCompleteTextView()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.MultiAutoCompleteTextView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/MultiAutoCompleteTextView"));
			global::android.widget.MultiAutoCompleteTextView._setTokenizer17430 = @__env.GetMethodIDNoThrow(global::android.widget.MultiAutoCompleteTextView.staticClass, "setTokenizer", "(Landroid/widget/MultiAutoCompleteTextView$Tokenizer;)V");
			global::android.widget.MultiAutoCompleteTextView._performFiltering17431 = @__env.GetMethodIDNoThrow(global::android.widget.MultiAutoCompleteTextView.staticClass, "performFiltering", "(Ljava/lang/CharSequence;I)V");
			global::android.widget.MultiAutoCompleteTextView._performFiltering17432 = @__env.GetMethodIDNoThrow(global::android.widget.MultiAutoCompleteTextView.staticClass, "performFiltering", "(Ljava/lang/CharSequence;III)V");
			global::android.widget.MultiAutoCompleteTextView._enoughToFilter17433 = @__env.GetMethodIDNoThrow(global::android.widget.MultiAutoCompleteTextView.staticClass, "enoughToFilter", "()Z");
			global::android.widget.MultiAutoCompleteTextView._performValidation17434 = @__env.GetMethodIDNoThrow(global::android.widget.MultiAutoCompleteTextView.staticClass, "performValidation", "()V");
			global::android.widget.MultiAutoCompleteTextView._replaceText17435 = @__env.GetMethodIDNoThrow(global::android.widget.MultiAutoCompleteTextView.staticClass, "replaceText", "(Ljava/lang/CharSequence;)V");
			global::android.widget.MultiAutoCompleteTextView._MultiAutoCompleteTextView17436 = @__env.GetMethodIDNoThrow(global::android.widget.MultiAutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.MultiAutoCompleteTextView._MultiAutoCompleteTextView17437 = @__env.GetMethodIDNoThrow(global::android.widget.MultiAutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.MultiAutoCompleteTextView._MultiAutoCompleteTextView17438 = @__env.GetMethodIDNoThrow(global::android.widget.MultiAutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
