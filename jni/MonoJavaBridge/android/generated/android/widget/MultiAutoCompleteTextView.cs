namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class MultiAutoCompleteTextView : android.widget.AutoCompleteTextView
	{
		internal new static global::java.lang.Class staticClass;
		static MultiAutoCompleteTextView()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.MultiAutoCompleteTextView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.MultiAutoCompleteTextView.CommaTokenizer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
			internal static global::net.sf.jni4net.jni.MethodId _findTokenStart11229;
			public virtual int findTokenStart(java.lang.CharSequence arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._findTokenStart11229, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._findTokenStart11229, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			public int findTokenStart(string arg0, int arg1)
			{
				return findTokenStart((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
			}
			internal static global::net.sf.jni4net.jni.MethodId _findTokenEnd11230;
			public virtual int findTokenEnd(java.lang.CharSequence arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._findTokenEnd11230, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._findTokenEnd11230, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			public int findTokenEnd(string arg0, int arg1)
			{
				return findTokenEnd((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
			}
			internal static global::net.sf.jni4net.jni.MethodId _terminateToken11231;
			public virtual global::java.lang.CharSequence terminateToken(java.lang.CharSequence arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._terminateToken11231, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._terminateToken11231, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			}
			public java.lang.CharSequence terminateToken(string arg0)
			{
				return terminateToken((global::java.lang.CharSequence)(global::java.lang.String)arg0);
			}
			internal static global::net.sf.jni4net.jni.MethodId _CommaTokenizer11232;
			public CommaTokenizer()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._CommaTokenizer11232, this);
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass = @__class;
				global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._findTokenStart11229 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, "findTokenStart", "(Ljava/lang/CharSequence;I)I");
				global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._findTokenEnd11230 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, "findTokenEnd", "(Ljava/lang/CharSequence;I)I");
				global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._terminateToken11231 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, "terminateToken", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
				global::android.widget.MultiAutoCompleteTextView.CommaTokenizer._CommaTokenizer11232 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.CommaTokenizer.staticClass, "<init>", "()V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface Tokenizer 
		{
			int findTokenStart(java.lang.CharSequence arg0, int arg1);
			int findTokenEnd(java.lang.CharSequence arg0, int arg1);
			global::java.lang.CharSequence terminateToken(java.lang.CharSequence arg0);
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.MultiAutoCompleteTextView.__Tokenizer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
			internal static global::net.sf.jni4net.jni.MethodId _findTokenStart11233;
			 int android.widget.MultiAutoCompleteTextView.Tokenizer.findTokenStart(java.lang.CharSequence arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.widget.MultiAutoCompleteTextView.__Tokenizer._findTokenStart11233, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.widget.MultiAutoCompleteTextView.__Tokenizer.staticClass, global::android.widget.MultiAutoCompleteTextView.__Tokenizer._findTokenStart11233, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _findTokenEnd11234;
			 int android.widget.MultiAutoCompleteTextView.Tokenizer.findTokenEnd(java.lang.CharSequence arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.widget.MultiAutoCompleteTextView.__Tokenizer._findTokenEnd11234, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.widget.MultiAutoCompleteTextView.__Tokenizer.staticClass, global::android.widget.MultiAutoCompleteTextView.__Tokenizer._findTokenEnd11234, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _terminateToken11235;
			 global::java.lang.CharSequence android.widget.MultiAutoCompleteTextView.Tokenizer.terminateToken(java.lang.CharSequence arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.MultiAutoCompleteTextView.__Tokenizer._terminateToken11235, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.MultiAutoCompleteTextView.__Tokenizer.staticClass, global::android.widget.MultiAutoCompleteTextView.__Tokenizer._terminateToken11235, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.MultiAutoCompleteTextView.__Tokenizer.staticClass = @__class;
				global::android.widget.MultiAutoCompleteTextView.__Tokenizer._findTokenStart11233 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.__Tokenizer.staticClass, "android.widget.MultiAutoCompleteTextView.Tokenizer.findTokenStart", "(Ljava/lang/CharSequence;I)I");
				global::android.widget.MultiAutoCompleteTextView.__Tokenizer._findTokenEnd11234 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.__Tokenizer.staticClass, "android.widget.MultiAutoCompleteTextView.Tokenizer.findTokenEnd", "(Ljava/lang/CharSequence;I)I");
				global::android.widget.MultiAutoCompleteTextView.__Tokenizer._terminateToken11235 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.__Tokenizer.staticClass, "android.widget.MultiAutoCompleteTextView.Tokenizer.terminateToken", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTokenizer11236;
		public virtual void setTokenizer(android.widget.MultiAutoCompleteTextView.Tokenizer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.MultiAutoCompleteTextView._setTokenizer11236, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.MultiAutoCompleteTextView.staticClass, global::android.widget.MultiAutoCompleteTextView._setTokenizer11236, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _performFiltering11237;
		protected override void performFiltering(java.lang.CharSequence arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.MultiAutoCompleteTextView._performFiltering11237, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.MultiAutoCompleteTextView.staticClass, global::android.widget.MultiAutoCompleteTextView._performFiltering11237, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _performFiltering11238;
		protected virtual void performFiltering(java.lang.CharSequence arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.MultiAutoCompleteTextView._performFiltering11238, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.MultiAutoCompleteTextView.staticClass, global::android.widget.MultiAutoCompleteTextView._performFiltering11238, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _enoughToFilter11239;
		public override bool enoughToFilter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.MultiAutoCompleteTextView._enoughToFilter11239);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.MultiAutoCompleteTextView.staticClass, global::android.widget.MultiAutoCompleteTextView._enoughToFilter11239);
		}
		internal static global::net.sf.jni4net.jni.MethodId _performValidation11240;
		public override void performValidation() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.MultiAutoCompleteTextView._performValidation11240);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.MultiAutoCompleteTextView.staticClass, global::android.widget.MultiAutoCompleteTextView._performValidation11240);
		}
		internal static global::net.sf.jni4net.jni.MethodId _replaceText11241;
		protected override void replaceText(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.MultiAutoCompleteTextView._replaceText11241, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.MultiAutoCompleteTextView.staticClass, global::android.widget.MultiAutoCompleteTextView._replaceText11241, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _MultiAutoCompleteTextView11242;
		public MultiAutoCompleteTextView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.MultiAutoCompleteTextView.staticClass, global::android.widget.MultiAutoCompleteTextView._MultiAutoCompleteTextView11242, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _MultiAutoCompleteTextView11243;
		public MultiAutoCompleteTextView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.MultiAutoCompleteTextView.staticClass, global::android.widget.MultiAutoCompleteTextView._MultiAutoCompleteTextView11243, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _MultiAutoCompleteTextView11244;
		public MultiAutoCompleteTextView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.MultiAutoCompleteTextView.staticClass, global::android.widget.MultiAutoCompleteTextView._MultiAutoCompleteTextView11244, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.MultiAutoCompleteTextView.staticClass = @__class;
			global::android.widget.MultiAutoCompleteTextView._setTokenizer11236 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.staticClass, "setTokenizer", "(Landroid/widget/MultiAutoCompleteTextView$Tokenizer;)V");
			global::android.widget.MultiAutoCompleteTextView._performFiltering11237 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.staticClass, "performFiltering", "(Ljava/lang/CharSequence;I)V");
			global::android.widget.MultiAutoCompleteTextView._performFiltering11238 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.staticClass, "performFiltering", "(Ljava/lang/CharSequence;III)V");
			global::android.widget.MultiAutoCompleteTextView._enoughToFilter11239 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.staticClass, "enoughToFilter", "()Z");
			global::android.widget.MultiAutoCompleteTextView._performValidation11240 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.staticClass, "performValidation", "()V");
			global::android.widget.MultiAutoCompleteTextView._replaceText11241 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.staticClass, "replaceText", "(Ljava/lang/CharSequence;)V");
			global::android.widget.MultiAutoCompleteTextView._MultiAutoCompleteTextView11242 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.MultiAutoCompleteTextView._MultiAutoCompleteTextView11243 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.MultiAutoCompleteTextView._MultiAutoCompleteTextView11244 = @__env.GetMethodID(global::android.widget.MultiAutoCompleteTextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
