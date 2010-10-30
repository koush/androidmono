namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SpannableString : android.text.SpannableStringInternal, java.lang.CharSequence, GetChars, Spannable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SpannableString(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.CharSequence subSequence(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.text.SpannableString.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;", ref global::android.text.SpannableString._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::android.text.SpannableString valueOf(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.SpannableString._m1.native == global::System.IntPtr.Zero)
				global::android.text.SpannableString._m1 = @__env.GetStaticMethodIDNoThrow(global::android.text.SpannableString.staticClass, "valueOf", "(Ljava/lang/CharSequence;)Landroid/text/SpannableString;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.SpannableString.staticClass, global::android.text.SpannableString._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.SpannableString;
		}
		public static android.text.SpannableString valueOf(string arg0)
		{
			return valueOf((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void setSpan(java.lang.Object arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.SpannableString.staticClass, "setSpan", "(Ljava/lang/Object;III)V", ref global::android.text.SpannableString._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void removeSpan(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.SpannableString.staticClass, "removeSpan", "(Ljava/lang/Object;)V", ref global::android.text.SpannableString._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public SpannableString(java.lang.CharSequence arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.SpannableString._m4.native == global::System.IntPtr.Zero)
				global::android.text.SpannableString._m4 = @__env.GetMethodIDNoThrow(global::android.text.SpannableString.staticClass, "<init>", "(Ljava/lang/CharSequence;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.SpannableString.staticClass, global::android.text.SpannableString._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static SpannableString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.SpannableString.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/SpannableString"));
		}
		internal static void InitJNI()
		{
		}
	}
}
