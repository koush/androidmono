namespace android.text
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.Editable_))]
	public partial interface Editable : java.lang.CharSequence, GetChars, Spannable, java.lang.Appendable
	{
		global::android.text.Editable append(java.lang.CharSequence arg0, int arg1, int arg2);
		global::android.text.Editable append(java.lang.CharSequence arg0);
		global::android.text.Editable append(char arg0);
		void clear();
		global::android.text.Editable replace(int arg0, int arg1, java.lang.CharSequence arg2, int arg3, int arg4);
		global::android.text.Editable replace(int arg0, int arg1, java.lang.CharSequence arg2);
		global::android.text.Editable delete(int arg0, int arg1);
		global::android.text.Editable insert(int arg0, java.lang.CharSequence arg1);
		global::android.text.Editable insert(int arg0, java.lang.CharSequence arg1, int arg2, int arg3);
		void setFilters(android.text.InputFilter[] arg0);
		global::android.text.InputFilter[] getFilters();
		void clearSpans();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.Editable))]
	internal sealed partial class Editable_ : java.lang.Object, Editable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Editable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::android.text.Editable android.text.Editable.append(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.Editable>(this, global::android.text.Editable_.staticClass, "append", "(Ljava/lang/CharSequence;II)Landroid/text/Editable;", ref global::android.text.Editable_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.text.Editable;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::android.text.Editable android.text.Editable.append(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.Editable>(this, global::android.text.Editable_.staticClass, "append", "(Ljava/lang/CharSequence;)Landroid/text/Editable;", ref global::android.text.Editable_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.text.Editable;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::android.text.Editable android.text.Editable.append(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.Editable>(this, global::android.text.Editable_.staticClass, "append", "(C)Landroid/text/Editable;", ref global::android.text.Editable_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.text.Editable;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void android.text.Editable.clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.Editable_.staticClass, "clear", "()V", ref global::android.text.Editable_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::android.text.Editable android.text.Editable.replace(int arg0, int arg1, java.lang.CharSequence arg2, int arg3, int arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.Editable>(this, global::android.text.Editable_.staticClass, "replace", "(IILjava/lang/CharSequence;II)Landroid/text/Editable;", ref global::android.text.Editable_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4)) as android.text.Editable;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		global::android.text.Editable android.text.Editable.replace(int arg0, int arg1, java.lang.CharSequence arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.Editable>(this, global::android.text.Editable_.staticClass, "replace", "(IILjava/lang/CharSequence;)Landroid/text/Editable;", ref global::android.text.Editable_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.text.Editable;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		global::android.text.Editable android.text.Editable.delete(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.Editable>(this, global::android.text.Editable_.staticClass, "delete", "(II)Landroid/text/Editable;", ref global::android.text.Editable_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.text.Editable;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		global::android.text.Editable android.text.Editable.insert(int arg0, java.lang.CharSequence arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.Editable>(this, global::android.text.Editable_.staticClass, "insert", "(ILjava/lang/CharSequence;)Landroid/text/Editable;", ref global::android.text.Editable_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.text.Editable;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		global::android.text.Editable android.text.Editable.insert(int arg0, java.lang.CharSequence arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.Editable>(this, global::android.text.Editable_.staticClass, "insert", "(ILjava/lang/CharSequence;II)Landroid/text/Editable;", ref global::android.text.Editable_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.text.Editable;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		void android.text.Editable.setFilters(android.text.InputFilter[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.Editable_.staticClass, "setFilters", "([Landroid/text/InputFilter;)V", ref global::android.text.Editable_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		global::android.text.InputFilter[] android.text.Editable.getFilters()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<android.text.InputFilter>(this, global::android.text.Editable_.staticClass, "getFilters", "()[Landroid/text/InputFilter;", ref global::android.text.Editable_._m10) as android.text.InputFilter[];
		}
		private static global::MonoJavaBridge.MethodId _m11;
		void android.text.Editable.clearSpans()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.Editable_.staticClass, "clearSpans", "()V", ref global::android.text.Editable_._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		global::java.lang.String java.lang.CharSequence.toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.text.Editable_.staticClass, "toString", "()Ljava/lang/String;", ref global::android.text.Editable_._m12) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		int java.lang.CharSequence.length()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Editable_.staticClass, "length", "()I", ref global::android.text.Editable_._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		char java.lang.CharSequence.charAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::android.text.Editable_.staticClass, "charAt", "(I)C", ref global::android.text.Editable_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		global::java.lang.CharSequence java.lang.CharSequence.subSequence(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.text.Editable_.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;", ref global::android.text.Editable_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		void android.text.GetChars.getChars(int arg0, int arg1, char[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.Editable_.staticClass, "getChars", "(II[CI)V", ref global::android.text.Editable_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		void android.text.Spannable.setSpan(java.lang.Object arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.Editable_.staticClass, "setSpan", "(Ljava/lang/Object;III)V", ref global::android.text.Editable_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		void android.text.Spannable.removeSpan(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.Editable_.staticClass, "removeSpan", "(Ljava/lang/Object;)V", ref global::android.text.Editable_._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		global::java.lang.Object[] android.text.Spanned.getSpans(int arg0, int arg1, java.lang.Class arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::android.text.Editable_.staticClass, "getSpans", "(IILjava/lang/Class;)[Ljava/lang/Object;", ref global::android.text.Editable_._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m20;
		int android.text.Spanned.getSpanStart(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Editable_.staticClass, "getSpanStart", "(Ljava/lang/Object;)I", ref global::android.text.Editable_._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		int android.text.Spanned.getSpanEnd(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Editable_.staticClass, "getSpanEnd", "(Ljava/lang/Object;)I", ref global::android.text.Editable_._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		int android.text.Spanned.getSpanFlags(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Editable_.staticClass, "getSpanFlags", "(Ljava/lang/Object;)I", ref global::android.text.Editable_._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		int android.text.Spanned.nextSpanTransition(int arg0, int arg1, java.lang.Class arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Editable_.staticClass, "nextSpanTransition", "(IILjava/lang/Class;)I", ref global::android.text.Editable_._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		global::java.lang.Appendable java.lang.Appendable.append(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.Appendable>(this, global::android.text.Editable_.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;", ref global::android.text.Editable_._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Appendable;
		}
		private static global::MonoJavaBridge.MethodId _m25;
		global::java.lang.Appendable java.lang.Appendable.append(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.Appendable>(this, global::android.text.Editable_.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;", ref global::android.text.Editable_._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Appendable;
		}
		private static global::MonoJavaBridge.MethodId _m26;
		global::java.lang.Appendable java.lang.Appendable.append(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.Appendable>(this, global::android.text.Editable_.staticClass, "append", "(C)Ljava/lang/Appendable;", ref global::android.text.Editable_._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Appendable;
		}
		static Editable_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.Editable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Editable"));
		}
	}
}
