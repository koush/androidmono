namespace android.text.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Rfc822Tokenizer : java.lang.Object, android.widget.MultiAutoCompleteTextView.Tokenizer
	{ 
		internal static global::java.lang.Class staticClass; 
		static Rfc822Tokenizer() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.util.Rfc822Tokenizer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.util.Rfc822Tokenizer(@__env); 
			} 
		} 
		protected Rfc822Tokenizer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _tokenize7498; 
		public static global::android.text.util.Rfc822Token[] tokenize(java.lang.CharSequence arg0) 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.text.util.Rfc822Tokenizer.staticClass, global::android.text.util.Rfc822Tokenizer._tokenize7498, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _findTokenStart7499; 
		public virtual int findTokenStart(java.lang.CharSequence arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.util.Rfc822Tokenizer)) 
				return @__env.CallIntMethod(this, global::android.text.util.Rfc822Tokenizer._findTokenStart7499, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.text.util.Rfc822Tokenizer.staticClass, global::android.text.util.Rfc822Tokenizer._findTokenStart7499, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _findTokenEnd7500; 
		public virtual int findTokenEnd(java.lang.CharSequence arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.util.Rfc822Tokenizer)) 
				return @__env.CallIntMethod(this, global::android.text.util.Rfc822Tokenizer._findTokenEnd7500, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.text.util.Rfc822Tokenizer.staticClass, global::android.text.util.Rfc822Tokenizer._findTokenEnd7500, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _terminateToken7501; 
		public virtual global::java.lang.CharSequence terminateToken(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.util.Rfc822Tokenizer)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.util.Rfc822Tokenizer._terminateToken7501, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.util.Rfc822Tokenizer.staticClass, global::android.text.util.Rfc822Tokenizer._terminateToken7501, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Rfc822Tokenizer7502; 
		public Rfc822Tokenizer()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.util.Rfc822Tokenizer.staticClass, global::android.text.util.Rfc822Tokenizer._Rfc822Tokenizer7502, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.util.Rfc822Tokenizer.staticClass = @__class; 
			global::android.text.util.Rfc822Tokenizer._tokenize7498 = @__env.GetStaticMethodID(global::android.text.util.Rfc822Tokenizer.staticClass, "tokenize", "(Ljava/lang/CharSequence;)[Landroid/text/util/Rfc822Token;"); 
			global::android.text.util.Rfc822Tokenizer._findTokenStart7499 = @__env.GetMethodID(global::android.text.util.Rfc822Tokenizer.staticClass, "findTokenStart", "(Ljava/lang/CharSequence;I)I"); 
			global::android.text.util.Rfc822Tokenizer._findTokenEnd7500 = @__env.GetMethodID(global::android.text.util.Rfc822Tokenizer.staticClass, "findTokenEnd", "(Ljava/lang/CharSequence;I)I"); 
			global::android.text.util.Rfc822Tokenizer._terminateToken7501 = @__env.GetMethodID(global::android.text.util.Rfc822Tokenizer.staticClass, "terminateToken", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;"); 
			global::android.text.util.Rfc822Tokenizer._Rfc822Tokenizer7502 = @__env.GetMethodID(global::android.text.util.Rfc822Tokenizer.staticClass, "<init>", "()V"); 
		} 
	} 
} 
