namespace android.text.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Rfc822Tokenizer : java.lang.Object, android.widget.MultiAutoCompleteTextView.Tokenizer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Rfc822Tokenizer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _tokenize13666;
		public static void tokenize(java.lang.CharSequence arg0, java.util.Collection arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.util.Rfc822Tokenizer.staticClass, global::android.text.util.Rfc822Tokenizer._tokenize13666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public static void tokenize(string arg0, java.util.Collection arg1)
		{
			tokenize((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _tokenize13667;
		public static global::android.text.util.Rfc822Token[] tokenize(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.util.Rfc822Token>(@__env.CallStaticObjectMethod(android.text.util.Rfc822Tokenizer.staticClass, global::android.text.util.Rfc822Tokenizer._tokenize13667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.util.Rfc822Token[];
		}
		public static android.text.util.Rfc822Token[] tokenize(string arg0)
		{
			return tokenize((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _findTokenStart13668;
		public virtual int findTokenStart(java.lang.CharSequence arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.util.Rfc822Tokenizer.staticClass, global::android.text.util.Rfc822Tokenizer._findTokenStart13668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public int findTokenStart(string arg0, int arg1)
		{
			return findTokenStart((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _findTokenEnd13669;
		public virtual int findTokenEnd(java.lang.CharSequence arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.util.Rfc822Tokenizer.staticClass, global::android.text.util.Rfc822Tokenizer._findTokenEnd13669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public int findTokenEnd(string arg0, int arg1)
		{
			return findTokenEnd((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _terminateToken13670;
		public virtual global::java.lang.CharSequence terminateToken(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.text.util.Rfc822Tokenizer.staticClass, global::android.text.util.Rfc822Tokenizer._terminateToken13670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		public java.lang.CharSequence terminateToken(string arg0)
		{
			return terminateToken((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _Rfc822Tokenizer13671;
		public Rfc822Tokenizer() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.util.Rfc822Tokenizer.staticClass, global::android.text.util.Rfc822Tokenizer._Rfc822Tokenizer13671);
			Init(@__env, handle);
		}
		static Rfc822Tokenizer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.util.Rfc822Tokenizer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/util/Rfc822Tokenizer"));
			global::android.text.util.Rfc822Tokenizer._tokenize13666 = @__env.GetStaticMethodIDNoThrow(global::android.text.util.Rfc822Tokenizer.staticClass, "tokenize", "(Ljava/lang/CharSequence;Ljava/util/Collection;)V");
			global::android.text.util.Rfc822Tokenizer._tokenize13667 = @__env.GetStaticMethodIDNoThrow(global::android.text.util.Rfc822Tokenizer.staticClass, "tokenize", "(Ljava/lang/CharSequence;)[Landroid/text/util/Rfc822Token;");
			global::android.text.util.Rfc822Tokenizer._findTokenStart13668 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Tokenizer.staticClass, "findTokenStart", "(Ljava/lang/CharSequence;I)I");
			global::android.text.util.Rfc822Tokenizer._findTokenEnd13669 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Tokenizer.staticClass, "findTokenEnd", "(Ljava/lang/CharSequence;I)I");
			global::android.text.util.Rfc822Tokenizer._terminateToken13670 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Tokenizer.staticClass, "terminateToken", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
			global::android.text.util.Rfc822Tokenizer._Rfc822Tokenizer13671 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Tokenizer.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
