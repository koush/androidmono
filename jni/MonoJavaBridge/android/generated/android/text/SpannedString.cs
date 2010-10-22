namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class SpannedString : android.text.SpannableStringInternal, java.lang.CharSequence, GetChars, Spanned
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SpannedString()
		{
			InitJNI();
		}
		internal SpannedString(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _subSequence12953;
		public global::java.lang.CharSequence subSequence(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannedString._subSequence12953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannedString.staticClass, global::android.text.SpannedString._subSequence12953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf12954;
		public static global::android.text.SpannedString valueOf(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.SpannedString>(@__env.CallStaticObjectMethod(android.text.SpannedString.staticClass, global::android.text.SpannedString._valueOf12954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.SpannedString;
		}
		internal static global::MonoJavaBridge.MethodId _SpannedString12955;
		public SpannedString(java.lang.CharSequence arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.SpannedString.staticClass, global::android.text.SpannedString._SpannedString12955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.SpannedString.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/SpannedString"));
			global::android.text.SpannedString._subSequence12953 = @__env.GetMethodIDNoThrow(global::android.text.SpannedString.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
			global::android.text.SpannedString._valueOf12954 = @__env.GetStaticMethodIDNoThrow(global::android.text.SpannedString.staticClass, "valueOf", "(Ljava/lang/CharSequence;)Landroid/text/SpannedString;");
			global::android.text.SpannedString._SpannedString12955 = @__env.GetMethodIDNoThrow(global::android.text.SpannedString.staticClass, "<init>", "(Ljava/lang/CharSequence;)V");
		}
	}
}
