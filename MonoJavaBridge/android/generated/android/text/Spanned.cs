namespace android.text
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.Spanned_))]
	public partial interface Spanned : java.lang.CharSequence
	{
		global::java.lang.Object[] getSpans(int arg0, int arg1, java.lang.Class arg2);
		int getSpanStart(java.lang.Object arg0);
		int getSpanEnd(java.lang.Object arg0);
		int getSpanFlags(java.lang.Object arg0);
		int nextSpanTransition(int arg0, int arg1, java.lang.Class arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.Spanned))]
	internal sealed partial class Spanned_ : java.lang.Object, Spanned
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Spanned_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.Object[] android.text.Spanned.getSpans(int arg0, int arg1, java.lang.Class arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::android.text.Spanned_.staticClass, "getSpans", "(IILjava/lang/Class;)[Ljava/lang/Object;", ref global::android.text.Spanned_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m1;
		int android.text.Spanned.getSpanStart(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Spanned_.staticClass, "getSpanStart", "(Ljava/lang/Object;)I", ref global::android.text.Spanned_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		int android.text.Spanned.getSpanEnd(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Spanned_.staticClass, "getSpanEnd", "(Ljava/lang/Object;)I", ref global::android.text.Spanned_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		int android.text.Spanned.getSpanFlags(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Spanned_.staticClass, "getSpanFlags", "(Ljava/lang/Object;)I", ref global::android.text.Spanned_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		int android.text.Spanned.nextSpanTransition(int arg0, int arg1, java.lang.Class arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Spanned_.staticClass, "nextSpanTransition", "(IILjava/lang/Class;)I", ref global::android.text.Spanned_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		global::java.lang.String java.lang.CharSequence.toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.text.Spanned_.staticClass, "toString", "()Ljava/lang/String;", ref global::android.text.Spanned_._m5) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		int java.lang.CharSequence.length()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Spanned_.staticClass, "length", "()I", ref global::android.text.Spanned_._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		char java.lang.CharSequence.charAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::android.text.Spanned_.staticClass, "charAt", "(I)C", ref global::android.text.Spanned_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		global::java.lang.CharSequence java.lang.CharSequence.subSequence(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.text.Spanned_.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;", ref global::android.text.Spanned_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.CharSequence;
		}
		static Spanned_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.Spanned_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Spanned"));
		}
	}
}
