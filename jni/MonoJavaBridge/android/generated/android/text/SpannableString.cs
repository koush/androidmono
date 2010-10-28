namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SpannableString : android.text.SpannableStringInternal, java.lang.CharSequence, GetChars, Spannable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SpannableString(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _subSequence12944;
		public virtual global::java.lang.CharSequence subSequence(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableString._subSequence12944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableString.staticClass, global::android.text.SpannableString._subSequence12944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf12945;
		public static global::android.text.SpannableString valueOf(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.SpannableString.staticClass, global::android.text.SpannableString._valueOf12945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.SpannableString;
		}
		public static android.text.SpannableString valueOf(string arg0)
		{
			return valueOf((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setSpan12946;
		public virtual void setSpan(java.lang.Object arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.SpannableString._setSpan12946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.SpannableString.staticClass, global::android.text.SpannableString._setSpan12946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _removeSpan12947;
		public virtual void removeSpan(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.SpannableString._removeSpan12947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.SpannableString.staticClass, global::android.text.SpannableString._removeSpan12947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SpannableString12948;
		public SpannableString(java.lang.CharSequence arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.SpannableString.staticClass, global::android.text.SpannableString._SpannableString12948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static SpannableString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.SpannableString.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/SpannableString"));
			global::android.text.SpannableString._subSequence12944 = @__env.GetMethodIDNoThrow(global::android.text.SpannableString.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
			global::android.text.SpannableString._valueOf12945 = @__env.GetStaticMethodIDNoThrow(global::android.text.SpannableString.staticClass, "valueOf", "(Ljava/lang/CharSequence;)Landroid/text/SpannableString;");
			global::android.text.SpannableString._setSpan12946 = @__env.GetMethodIDNoThrow(global::android.text.SpannableString.staticClass, "setSpan", "(Ljava/lang/Object;III)V");
			global::android.text.SpannableString._removeSpan12947 = @__env.GetMethodIDNoThrow(global::android.text.SpannableString.staticClass, "removeSpan", "(Ljava/lang/Object;)V");
			global::android.text.SpannableString._SpannableString12948 = @__env.GetMethodIDNoThrow(global::android.text.SpannableString.staticClass, "<init>", "(Ljava/lang/CharSequence;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
