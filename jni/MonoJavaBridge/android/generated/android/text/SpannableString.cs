namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SpannableString : android.text.SpannableStringInternal, java.lang.CharSequence, GetChars, Spannable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SpannableString()
		{
			InitJNI();
		}
		protected SpannableString(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _subSequence12883;
		public virtual global::java.lang.CharSequence subSequence(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableString._subSequence12883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableString.staticClass, global::android.text.SpannableString._subSequence12883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf12884;
		public static global::android.text.SpannableString valueOf(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.SpannableString.staticClass, global::android.text.SpannableString._valueOf12884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.SpannableString;
		}
		internal static global::MonoJavaBridge.MethodId _setSpan12885;
		public virtual void setSpan(java.lang.Object arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.SpannableString._setSpan12885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.SpannableString.staticClass, global::android.text.SpannableString._setSpan12885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _removeSpan12886;
		public virtual void removeSpan(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.SpannableString._removeSpan12886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.SpannableString.staticClass, global::android.text.SpannableString._removeSpan12886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SpannableString12887;
		public SpannableString(java.lang.CharSequence arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.SpannableString.staticClass, global::android.text.SpannableString._SpannableString12887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.SpannableString.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/SpannableString"));
			global::android.text.SpannableString._subSequence12883 = @__env.GetMethodIDNoThrow(global::android.text.SpannableString.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
			global::android.text.SpannableString._valueOf12884 = @__env.GetStaticMethodIDNoThrow(global::android.text.SpannableString.staticClass, "valueOf", "(Ljava/lang/CharSequence;)Landroid/text/SpannableString;");
			global::android.text.SpannableString._setSpan12885 = @__env.GetMethodIDNoThrow(global::android.text.SpannableString.staticClass, "setSpan", "(Ljava/lang/Object;III)V");
			global::android.text.SpannableString._removeSpan12886 = @__env.GetMethodIDNoThrow(global::android.text.SpannableString.staticClass, "removeSpan", "(Ljava/lang/Object;)V");
			global::android.text.SpannableString._SpannableString12887 = @__env.GetMethodIDNoThrow(global::android.text.SpannableString.staticClass, "<init>", "(Ljava/lang/CharSequence;)V");
		}
	}
}
