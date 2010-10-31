namespace android.text.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Rfc822Tokenizer : java.lang.Object, android.widget.MultiAutoCompleteTextView.Tokenizer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Rfc822Tokenizer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static void tokenize(java.lang.CharSequence arg0, java.util.Collection arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.util.Rfc822Tokenizer._m0.native == global::System.IntPtr.Zero)
				global::android.text.util.Rfc822Tokenizer._m0 = @__env.GetStaticMethodIDNoThrow(global::android.text.util.Rfc822Tokenizer.staticClass, "tokenize", "(Ljava/lang/CharSequence;Ljava/util/Collection;)V");
			@__env.CallStaticVoidMethod(android.text.util.Rfc822Tokenizer.staticClass, global::android.text.util.Rfc822Tokenizer._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public static void tokenize(string arg0, java.util.Collection arg1)
		{
			tokenize((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::android.text.util.Rfc822Token[] tokenize(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.util.Rfc822Tokenizer._m1.native == global::System.IntPtr.Zero)
				global::android.text.util.Rfc822Tokenizer._m1 = @__env.GetStaticMethodIDNoThrow(global::android.text.util.Rfc822Tokenizer.staticClass, "tokenize", "(Ljava/lang/CharSequence;)[Landroid/text/util/Rfc822Token;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.util.Rfc822Token>(@__env.CallStaticObjectMethod(android.text.util.Rfc822Tokenizer.staticClass, global::android.text.util.Rfc822Tokenizer._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.util.Rfc822Token[];
		}
		public static android.text.util.Rfc822Token[] tokenize(string arg0)
		{
			return tokenize((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int findTokenStart(java.lang.CharSequence arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.util.Rfc822Tokenizer.staticClass, "findTokenStart", "(Ljava/lang/CharSequence;I)I", ref global::android.text.util.Rfc822Tokenizer._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public int findTokenStart(string arg0, int arg1)
		{
			return findTokenStart((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int findTokenEnd(java.lang.CharSequence arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.util.Rfc822Tokenizer.staticClass, "findTokenEnd", "(Ljava/lang/CharSequence;I)I", ref global::android.text.util.Rfc822Tokenizer._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public int findTokenEnd(string arg0, int arg1)
		{
			return findTokenEnd((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.CharSequence terminateToken(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.text.util.Rfc822Tokenizer.staticClass, "terminateToken", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", ref global::android.text.util.Rfc822Tokenizer._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
		}
		public java.lang.CharSequence terminateToken(string arg0)
		{
			return terminateToken((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public Rfc822Tokenizer() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.util.Rfc822Tokenizer._m5.native == global::System.IntPtr.Zero)
				global::android.text.util.Rfc822Tokenizer._m5 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Tokenizer.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.util.Rfc822Tokenizer.staticClass, global::android.text.util.Rfc822Tokenizer._m5);
			Init(@__env, handle);
		}
		static Rfc822Tokenizer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.util.Rfc822Tokenizer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/util/Rfc822Tokenizer"));
		}
	}
}
