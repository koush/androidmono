namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MultiAutoCompleteTextView : android.widget.AutoCompleteTextView
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MultiAutoCompleteTextView()
		{
			InitJNI();
		}
		protected MultiAutoCompleteTextView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class CommaTokenizer : java.lang.Object, Tokenizer
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static CommaTokenizer()
			{
				InitJNI();
			}
			protected CommaTokenizer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _findTokenStart17319;
			public virtual int findTokenStart(java.lang.CharSequence arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._findTokenStart17319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._findTokenStart17319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			public int findTokenStart(string arg0, int arg1)
			{
				return findTokenStart((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
			}
			internal static global::MonoJavaBridge.MethodId _findTokenEnd17320;
			public virtual int findTokenEnd(java.lang.CharSequence arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._findTokenEnd17320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._findTokenEnd17320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			public int findTokenEnd(string arg0, int arg1)
			{
				return findTokenEnd((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
			}
			internal static global::MonoJavaBridge.MethodId _terminateToken17321;
			public virtual global::java.lang.CharSequence terminateToken(java.lang.CharSequence arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._terminateToken17321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._terminateToken17321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			}
			public java.lang.CharSequence terminateToken(string arg0)
			{
				return terminateToken((global::java.lang.CharSequence)(global::java.lang.String)arg0);
			}
			internal static global::MonoJavaBridge.MethodId _CommaTokenizer17322;
			public CommaTokenizer()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._CommaTokenizer17322);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/MultiAutoCompleteTextView$CommaTokenizer"));
				global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._findTokenStart17319 = @__env.GetMethodIDNoThrow(global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, "findTokenStart", "(Ljava/lang/CharSequence;I)I");
				global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._findTokenEnd17320 = @__env.GetMethodIDNoThrow(global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, "findTokenEnd", "(Ljava/lang/CharSequence;I)I");
				global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._terminateToken17321 = @__env.GetMethodIDNoThrow(global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, "terminateToken", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
				global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._CommaTokenizer17322 = @__env.GetMethodIDNoThrow(global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, "<init>", "()V");
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
		public sealed partial class Tokenizer_ : java.lang.Object, Tokenizer
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Tokenizer_()
			{
				InitJNI();
			}
			internal Tokenizer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _findTokenStart17323;
			 int android.widget.MultiAutoCompleteTextView.Tokenizer.findTokenStart(java.lang.CharSequence arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.widget.MultiAutoCompleteTextView.Tokenizer_._findTokenStart17323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.MultiAutoCompleteTextView.Tokenizer_.staticClass, global::android.widget.MultiAutoCompleteTextView.Tokenizer_._findTokenStart17323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _findTokenEnd17324;
			 int android.widget.MultiAutoCompleteTextView.Tokenizer.findTokenEnd(java.lang.CharSequence arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.widget.MultiAutoCompleteTextView.Tokenizer_._findTokenEnd17324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.MultiAutoCompleteTextView.Tokenizer_.staticClass, global::android.widget.MultiAutoCompleteTextView.Tokenizer_._findTokenEnd17324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _terminateToken17325;
			 global::java.lang.CharSequence android.widget.MultiAutoCompleteTextView.Tokenizer.terminateToken(java.lang.CharSequence arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.MultiAutoCompleteTextView.Tokenizer_._terminateToken17325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.MultiAutoCompleteTextView.Tokenizer_.staticClass, global::android.widget.MultiAutoCompleteTextView.Tokenizer_._terminateToken17325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.MultiAutoCompleteTextView.Tokenizer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/MultiAutoCompleteTextView$Tokenizer"));
				global::android.widget.MultiAutoCompleteTextView.Tokenizer_._findTokenStart17323 = @__env.GetMethodIDNoThrow(global::android.widget.MultiAutoCompleteTextView.Tokenizer_.staticClass, "findTokenStart", "(Ljava/lang/CharSequence;I)I");
				global::android.widget.MultiAutoCompleteTextView.Tokenizer_._findTokenEnd17324 = @__env.GetMethodIDNoThrow(global::android.widget.MultiAutoCompleteTextView.Tokenizer_.staticClass, "findTokenEnd", "(Ljava/lang/CharSequence;I)I");
				global::android.widget.MultiAutoCompleteTextView.Tokenizer_._terminateToken17325 = @__env.GetMethodIDNoThrow(global::android.widget.MultiAutoCompleteTextView.Tokenizer_.staticClass, "terminateToken", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _setTokenizer17326;
		public virtual void setTokenizer(android.widget.MultiAutoCompleteTextView.Tokenizer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.MultiAutoCompleteTextView._setTokenizer17326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.MultiAutoCompleteTextView.staticClass, global::android.widget.MultiAutoCompleteTextView._setTokenizer17326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performFiltering17327;
		protected override void performFiltering(java.lang.CharSequence arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.MultiAutoCompleteTextView._performFiltering17327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.MultiAutoCompleteTextView.staticClass, global::android.widget.MultiAutoCompleteTextView._performFiltering17327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _performFiltering17328;
		protected virtual void performFiltering(java.lang.CharSequence arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.MultiAutoCompleteTextView._performFiltering17328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.MultiAutoCompleteTextView.staticClass, global::android.widget.MultiAutoCompleteTextView._performFiltering17328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _enoughToFilter17329;
		public override bool enoughToFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.MultiAutoCompleteTextView._enoughToFilter17329);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.MultiAutoCompleteTextView.staticClass, global::android.widget.MultiAutoCompleteTextView._enoughToFilter17329);
		}
		internal static global::MonoJavaBridge.MethodId _performValidation17330;
		public override void performValidation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.MultiAutoCompleteTextView._performValidation17330);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.MultiAutoCompleteTextView.staticClass, global::android.widget.MultiAutoCompleteTextView._performValidation17330);
		}
		internal static global::MonoJavaBridge.MethodId _replaceText17331;
		protected override void replaceText(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.MultiAutoCompleteTextView._replaceText17331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.MultiAutoCompleteTextView.staticClass, global::android.widget.MultiAutoCompleteTextView._replaceText17331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _MultiAutoCompleteTextView17332;
		public MultiAutoCompleteTextView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.MultiAutoCompleteTextView.staticClass, global::android.widget.MultiAutoCompleteTextView._MultiAutoCompleteTextView17332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MultiAutoCompleteTextView17333;
		public MultiAutoCompleteTextView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.MultiAutoCompleteTextView.staticClass, global::android.widget.MultiAutoCompleteTextView._MultiAutoCompleteTextView17333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MultiAutoCompleteTextView17334;
		public MultiAutoCompleteTextView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.MultiAutoCompleteTextView.staticClass, global::android.widget.MultiAutoCompleteTextView._MultiAutoCompleteTextView17334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.MultiAutoCompleteTextView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/MultiAutoCompleteTextView"));
			global::android.widget.MultiAutoCompleteTextView._setTokenizer17326 = @__env.GetMethodIDNoThrow(global::android.widget.MultiAutoCompleteTextView.staticClass, "setTokenizer", "(Landroid/widget/MultiAutoCompleteTextView$Tokenizer;)V");
			global::android.widget.MultiAutoCompleteTextView._performFiltering17327 = @__env.GetMethodIDNoThrow(global::android.widget.MultiAutoCompleteTextView.staticClass, "performFiltering", "(Ljava/lang/CharSequence;I)V");
			global::android.widget.MultiAutoCompleteTextView._performFiltering17328 = @__env.GetMethodIDNoThrow(global::android.widget.MultiAutoCompleteTextView.staticClass, "performFiltering", "(Ljava/lang/CharSequence;III)V");
			global::android.widget.MultiAutoCompleteTextView._enoughToFilter17329 = @__env.GetMethodIDNoThrow(global::android.widget.MultiAutoCompleteTextView.staticClass, "enoughToFilter", "()Z");
			global::android.widget.MultiAutoCompleteTextView._performValidation17330 = @__env.GetMethodIDNoThrow(global::android.widget.MultiAutoCompleteTextView.staticClass, "performValidation", "()V");
			global::android.widget.MultiAutoCompleteTextView._replaceText17331 = @__env.GetMethodIDNoThrow(global::android.widget.MultiAutoCompleteTextView.staticClass, "replaceText", "(Ljava/lang/CharSequence;)V");
			global::android.widget.MultiAutoCompleteTextView._MultiAutoCompleteTextView17332 = @__env.GetMethodIDNoThrow(global::android.widget.MultiAutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.MultiAutoCompleteTextView._MultiAutoCompleteTextView17333 = @__env.GetMethodIDNoThrow(global::android.widget.MultiAutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.MultiAutoCompleteTextView._MultiAutoCompleteTextView17334 = @__env.GetMethodIDNoThrow(global::android.widget.MultiAutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
