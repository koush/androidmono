namespace android.text
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.GetChars_))]
	public partial interface GetChars : java.lang.CharSequence
	{
		void getChars(int arg0, int arg1, char[] arg2, int arg3);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.GetChars))]
	internal sealed partial class GetChars_ : java.lang.Object, GetChars
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal GetChars_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void android.text.GetChars.getChars(int arg0, int arg1, char[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.GetChars_.staticClass, "getChars", "(II[CI)V", ref global::android.text.GetChars_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.String java.lang.CharSequence.toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.text.GetChars_.staticClass, "toString", "()Ljava/lang/String;", ref global::android.text.GetChars_._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		int java.lang.CharSequence.length()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.GetChars_.staticClass, "length", "()I", ref global::android.text.GetChars_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		char java.lang.CharSequence.charAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::android.text.GetChars_.staticClass, "charAt", "(I)C", ref global::android.text.GetChars_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::java.lang.CharSequence java.lang.CharSequence.subSequence(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.text.GetChars_.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;", ref global::android.text.GetChars_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.CharSequence;
		}
		static GetChars_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.GetChars_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/GetChars"));
		}
	}
}
