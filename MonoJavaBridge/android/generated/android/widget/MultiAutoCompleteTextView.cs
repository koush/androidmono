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
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual int findTokenStart(java.lang.CharSequence arg0, int arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, "findTokenStart", "(Ljava/lang/CharSequence;I)I", ref global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			public int findTokenStart(string arg0, int arg1)
			{
				return findTokenStart((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public virtual int findTokenEnd(java.lang.CharSequence arg0, int arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, "findTokenEnd", "(Ljava/lang/CharSequence;I)I", ref global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			public int findTokenEnd(string arg0, int arg1)
			{
				return findTokenEnd((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public virtual global::java.lang.CharSequence terminateToken(java.lang.CharSequence arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, "terminateToken", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", ref global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
			}
			public java.lang.CharSequence terminateToken(string arg0)
			{
				return terminateToken((global::java.lang.CharSequence)(global::java.lang.String)arg0);
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public CommaTokenizer() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._m3.native == global::System.IntPtr.Zero)
					global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._m3 = @__env.GetMethodIDNoThrow(global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._m3);
				Init(@__env, handle);
			}
			static CommaTokenizer()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/MultiAutoCompleteTextView$CommaTokenizer"));
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
			private static global::MonoJavaBridge.MethodId _m0;
			int android.widget.MultiAutoCompleteTextView.Tokenizer.findTokenStart(java.lang.CharSequence arg0, int arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.MultiAutoCompleteTextView.Tokenizer_.staticClass, "findTokenStart", "(Ljava/lang/CharSequence;I)I", ref global::android.widget.MultiAutoCompleteTextView.Tokenizer_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			int android.widget.MultiAutoCompleteTextView.Tokenizer.findTokenEnd(java.lang.CharSequence arg0, int arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.MultiAutoCompleteTextView.Tokenizer_.staticClass, "findTokenEnd", "(Ljava/lang/CharSequence;I)I", ref global::android.widget.MultiAutoCompleteTextView.Tokenizer_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			global::java.lang.CharSequence android.widget.MultiAutoCompleteTextView.Tokenizer.terminateToken(java.lang.CharSequence arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.widget.MultiAutoCompleteTextView.Tokenizer_.staticClass, "terminateToken", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", ref global::android.widget.MultiAutoCompleteTextView.Tokenizer_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
			}
			static Tokenizer_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.MultiAutoCompleteTextView.Tokenizer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/MultiAutoCompleteTextView$Tokenizer"));
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void setTokenizer(android.widget.MultiAutoCompleteTextView.Tokenizer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.MultiAutoCompleteTextView.staticClass, "setTokenizer", "(Landroid/widget/MultiAutoCompleteTextView$Tokenizer;)V", ref global::android.widget.MultiAutoCompleteTextView._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void performFiltering(java.lang.CharSequence arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.MultiAutoCompleteTextView.staticClass, "performFiltering", "(Ljava/lang/CharSequence;I)V", ref global::android.widget.MultiAutoCompleteTextView._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		protected void performFiltering(string arg0, int arg1)
		{
			performFiltering((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected virtual void performFiltering(java.lang.CharSequence arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.MultiAutoCompleteTextView.staticClass, "performFiltering", "(Ljava/lang/CharSequence;III)V", ref global::android.widget.MultiAutoCompleteTextView._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		protected void performFiltering(string arg0, int arg1, int arg2, int arg3)
		{
			performFiltering((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool enoughToFilter()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.MultiAutoCompleteTextView.staticClass, "enoughToFilter", "()Z", ref global::android.widget.MultiAutoCompleteTextView._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void performValidation()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.MultiAutoCompleteTextView.staticClass, "performValidation", "()V", ref global::android.widget.MultiAutoCompleteTextView._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override void replaceText(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.MultiAutoCompleteTextView.staticClass, "replaceText", "(Ljava/lang/CharSequence;)V", ref global::android.widget.MultiAutoCompleteTextView._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		protected void replaceText(string arg0)
		{
			replaceText((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public MultiAutoCompleteTextView(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.MultiAutoCompleteTextView._m6.native == global::System.IntPtr.Zero)
				global::android.widget.MultiAutoCompleteTextView._m6 = @__env.GetMethodIDNoThrow(global::android.widget.MultiAutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.MultiAutoCompleteTextView.staticClass, global::android.widget.MultiAutoCompleteTextView._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public MultiAutoCompleteTextView(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.MultiAutoCompleteTextView._m7.native == global::System.IntPtr.Zero)
				global::android.widget.MultiAutoCompleteTextView._m7 = @__env.GetMethodIDNoThrow(global::android.widget.MultiAutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.MultiAutoCompleteTextView.staticClass, global::android.widget.MultiAutoCompleteTextView._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public MultiAutoCompleteTextView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.MultiAutoCompleteTextView._m8.native == global::System.IntPtr.Zero)
				global::android.widget.MultiAutoCompleteTextView._m8 = @__env.GetMethodIDNoThrow(global::android.widget.MultiAutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.MultiAutoCompleteTextView.staticClass, global::android.widget.MultiAutoCompleteTextView._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static MultiAutoCompleteTextView()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.MultiAutoCompleteTextView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/MultiAutoCompleteTextView"));
		}
		internal static void InitJNI()
		{
		}
	}
}
