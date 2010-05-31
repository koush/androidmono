namespace android.text
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class SpannedString : android.text.SpannableStringInternal, java.lang.CharSequence, GetChars, Spanned
	{
		internal new static global::java.lang.Class staticClass;
		static SpannedString()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.SpannedString), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.SpannedString(@__env);
			}
		}
		internal SpannedString(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _subSequence6953;
		public global::java.lang.CharSequence subSequence(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.SpannedString._subSequence6953, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.SpannedString.staticClass, global::android.text.SpannedString._subSequence6953, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _valueOf6954;
		public static global::android.text.SpannedString valueOf(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.SpannedString>(@__env, @__env.CallStaticObjectMethodPtr(android.text.SpannedString.staticClass, global::android.text.SpannedString._valueOf6954, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SpannedString6955;
		public SpannedString(java.lang.CharSequence arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.SpannedString.staticClass, global::android.text.SpannedString._SpannedString6955, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.SpannedString.staticClass = @__class;
			global::android.text.SpannedString._subSequence6953 = @__env.GetMethodID(global::android.text.SpannedString.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
			global::android.text.SpannedString._valueOf6954 = @__env.GetStaticMethodID(global::android.text.SpannedString.staticClass, "valueOf", "(Ljava/lang/CharSequence;)Landroid/text/SpannedString;");
			global::android.text.SpannedString._SpannedString6955 = @__env.GetMethodID(global::android.text.SpannedString.staticClass, "<init>", "(Ljava/lang/CharSequence;)V");
		}
	}
}
