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
		internal static global::MonoJavaBridge.MethodId _getSpans12989;
		global::java.lang.Object[] android.text.Spanned.getSpans(int arg0, int arg1, java.lang.Class arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::android.text.Spanned_.staticClass, "getSpans", "(IILjava/lang/Class;)[Ljava/lang/Object;", ref global::android.text.Spanned_._getSpans12989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _getSpanStart12990;
		int android.text.Spanned.getSpanStart(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Spanned_.staticClass, "getSpanStart", "(Ljava/lang/Object;)I", ref global::android.text.Spanned_._getSpanStart12990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpanEnd12991;
		int android.text.Spanned.getSpanEnd(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Spanned_.staticClass, "getSpanEnd", "(Ljava/lang/Object;)I", ref global::android.text.Spanned_._getSpanEnd12991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpanFlags12992;
		int android.text.Spanned.getSpanFlags(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Spanned_.staticClass, "getSpanFlags", "(Ljava/lang/Object;)I", ref global::android.text.Spanned_._getSpanFlags12992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextSpanTransition12993;
		int android.text.Spanned.nextSpanTransition(int arg0, int arg1, java.lang.Class arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Spanned_.staticClass, "nextSpanTransition", "(IILjava/lang/Class;)I", ref global::android.text.Spanned_._nextSpanTransition12993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _toString12994;
		global::java.lang.String java.lang.CharSequence.toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.text.Spanned_.staticClass, "toString", "()Ljava/lang/String;", ref global::android.text.Spanned_._toString12994) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _length12995;
		int java.lang.CharSequence.length()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Spanned_.staticClass, "length", "()I", ref global::android.text.Spanned_._length12995);
		}
		internal static global::MonoJavaBridge.MethodId _charAt12996;
		char java.lang.CharSequence.charAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::android.text.Spanned_.staticClass, "charAt", "(I)C", ref global::android.text.Spanned_._charAt12996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _subSequence12997;
		global::java.lang.CharSequence java.lang.CharSequence.subSequence(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.text.Spanned_.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;", ref global::android.text.Spanned_._subSequence12997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.CharSequence;
		}
		static Spanned_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.Spanned_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Spanned"));
		}
		internal static void InitJNI()
		{
		}
	}
}
