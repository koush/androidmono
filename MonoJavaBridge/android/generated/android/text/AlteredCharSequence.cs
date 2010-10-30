namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AlteredCharSequence : java.lang.Object, java.lang.CharSequence, GetChars
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AlteredCharSequence(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString12667;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.text.AlteredCharSequence.staticClass, "toString", "()Ljava/lang/String;", ref global::android.text.AlteredCharSequence._toString12667) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _length12668;
		public virtual int length()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.AlteredCharSequence.staticClass, "length", "()I", ref global::android.text.AlteredCharSequence._length12668);
		}
		internal static global::MonoJavaBridge.MethodId _charAt12669;
		public virtual char charAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::android.text.AlteredCharSequence.staticClass, "charAt", "(I)C", ref global::android.text.AlteredCharSequence._charAt12669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChars12670;
		public virtual void getChars(int arg0, int arg1, char[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.AlteredCharSequence.staticClass, "getChars", "(II[CI)V", ref global::android.text.AlteredCharSequence._getChars12670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _subSequence12671;
		public virtual global::java.lang.CharSequence subSequence(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.text.AlteredCharSequence.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;", ref global::android.text.AlteredCharSequence._subSequence12671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _make12672;
		public static global::android.text.AlteredCharSequence make(java.lang.CharSequence arg0, char[] arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.AlteredCharSequence._make12672.native == global::System.IntPtr.Zero)
				global::android.text.AlteredCharSequence._make12672 = @__env.GetStaticMethodIDNoThrow(global::android.text.AlteredCharSequence.staticClass, "make", "(Ljava/lang/CharSequence;[CII)Landroid/text/AlteredCharSequence;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.AlteredCharSequence.staticClass, global::android.text.AlteredCharSequence._make12672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.text.AlteredCharSequence;
		}
		public static android.text.AlteredCharSequence make(string arg0, char[] arg1, int arg2, int arg3)
		{
			return make((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		static AlteredCharSequence()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.AlteredCharSequence.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/AlteredCharSequence"));
		}
		internal static void InitJNI()
		{
		}
	}
}
