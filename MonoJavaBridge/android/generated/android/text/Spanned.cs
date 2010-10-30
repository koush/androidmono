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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Spanned_._getSpans12989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _getSpanStart12990;
		int android.text.Spanned.getSpanStart(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::android.text.Spanned_._getSpanStart12990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpanEnd12991;
		int android.text.Spanned.getSpanEnd(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::android.text.Spanned_._getSpanEnd12991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpanFlags12992;
		int android.text.Spanned.getSpanFlags(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::android.text.Spanned_._getSpanFlags12992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextSpanTransition12993;
		int android.text.Spanned.nextSpanTransition(int arg0, int arg1, java.lang.Class arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::android.text.Spanned_._nextSpanTransition12993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _toString12994;
		global::java.lang.String java.lang.CharSequence.toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Spanned_._toString12994)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _length12995;
		int java.lang.CharSequence.length()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::android.text.Spanned_._length12995);
		}
		internal static global::MonoJavaBridge.MethodId _charAt12996;
		char java.lang.CharSequence.charAt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallCharMethod(this.JvmHandle, global::android.text.Spanned_._charAt12996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _subSequence12997;
		global::java.lang.CharSequence java.lang.CharSequence.subSequence(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Spanned_._subSequence12997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		static Spanned_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.Spanned_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Spanned"));
			global::android.text.Spanned_._getSpans12989 = @__env.GetMethodIDNoThrow(global::android.text.Spanned_.staticClass, "getSpans", "(IILjava/lang/Class;)[Ljava/lang/Object;");
			global::android.text.Spanned_._getSpanStart12990 = @__env.GetMethodIDNoThrow(global::android.text.Spanned_.staticClass, "getSpanStart", "(Ljava/lang/Object;)I");
			global::android.text.Spanned_._getSpanEnd12991 = @__env.GetMethodIDNoThrow(global::android.text.Spanned_.staticClass, "getSpanEnd", "(Ljava/lang/Object;)I");
			global::android.text.Spanned_._getSpanFlags12992 = @__env.GetMethodIDNoThrow(global::android.text.Spanned_.staticClass, "getSpanFlags", "(Ljava/lang/Object;)I");
			global::android.text.Spanned_._nextSpanTransition12993 = @__env.GetMethodIDNoThrow(global::android.text.Spanned_.staticClass, "nextSpanTransition", "(IILjava/lang/Class;)I");
			global::android.text.Spanned_._toString12994 = @__env.GetMethodIDNoThrow(global::android.text.Spanned_.staticClass, "toString", "()Ljava/lang/String;");
			global::android.text.Spanned_._length12995 = @__env.GetMethodIDNoThrow(global::android.text.Spanned_.staticClass, "length", "()I");
			global::android.text.Spanned_._charAt12996 = @__env.GetMethodIDNoThrow(global::android.text.Spanned_.staticClass, "charAt", "(I)C");
			global::android.text.Spanned_._subSequence12997 = @__env.GetMethodIDNoThrow(global::android.text.Spanned_.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
		}
		internal static void InitJNI()
		{
		}
	}
}
