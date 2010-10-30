namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class SpannedString : android.text.SpannableStringInternal, java.lang.CharSequence, GetChars, Spanned
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SpannedString(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _subSequence13014;
		public global::java.lang.CharSequence subSequence(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.text.SpannedString.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;", ref global::android.text.SpannedString._subSequence13014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf13015;
		public static global::android.text.SpannedString valueOf(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.SpannedString._valueOf13015.native == global::System.IntPtr.Zero)
				global::android.text.SpannedString._valueOf13015 = @__env.GetStaticMethodIDNoThrow(global::android.text.SpannedString.staticClass, "valueOf", "(Ljava/lang/CharSequence;)Landroid/text/SpannedString;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.SpannedString>(@__env.CallStaticObjectMethod(android.text.SpannedString.staticClass, global::android.text.SpannedString._valueOf13015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.SpannedString;
		}
		public static android.text.SpannedString valueOf(string arg0)
		{
			return valueOf((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _SpannedString13016;
		public SpannedString(java.lang.CharSequence arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.SpannedString._SpannedString13016.native == global::System.IntPtr.Zero)
				global::android.text.SpannedString._SpannedString13016 = @__env.GetMethodIDNoThrow(global::android.text.SpannedString.staticClass, "<init>", "(Ljava/lang/CharSequence;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.SpannedString.staticClass, global::android.text.SpannedString._SpannedString13016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static SpannedString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.SpannedString.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/SpannedString"));
		}
		internal static void InitJNI()
		{
		}
	}
}
