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
		internal static global::MonoJavaBridge.MethodId _append12742;
		global::android.text.Editable android.text.Editable.append(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.Editable>(this, global::android.text.Editable_.staticClass, "append", "(Ljava/lang/CharSequence;II)Landroid/text/Editable;", ref global::android.text.Editable_._append12742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _append12743;
		global::android.text.Editable android.text.Editable.append(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.Editable>(this, global::android.text.Editable_.staticClass, "append", "(Ljava/lang/CharSequence;)Landroid/text/Editable;", ref global::android.text.Editable_._append12743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _append12744;
		global::android.text.Editable android.text.Editable.append(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.Editable>(this, global::android.text.Editable_.staticClass, "append", "(C)Landroid/text/Editable;", ref global::android.text.Editable_._append12744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _clear12745;
		void android.text.Editable.clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.Editable_.staticClass, "clear", "()V", ref global::android.text.Editable_._clear12745);
		}
		internal static global::MonoJavaBridge.MethodId _replace12746;
		global::android.text.Editable android.text.Editable.replace(int arg0, int arg1, java.lang.CharSequence arg2, int arg3, int arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.Editable>(this, global::android.text.Editable_.staticClass, "replace", "(IILjava/lang/CharSequence;II)Landroid/text/Editable;", ref global::android.text.Editable_._replace12746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4)) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _replace12747;
		global::android.text.Editable android.text.Editable.replace(int arg0, int arg1, java.lang.CharSequence arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.Editable>(this, global::android.text.Editable_.staticClass, "replace", "(IILjava/lang/CharSequence;)Landroid/text/Editable;", ref global::android.text.Editable_._replace12747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _delete12748;
		global::android.text.Editable android.text.Editable.delete(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.Editable>(this, global::android.text.Editable_.staticClass, "delete", "(II)Landroid/text/Editable;", ref global::android.text.Editable_._delete12748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _insert12749;
		global::android.text.Editable android.text.Editable.insert(int arg0, java.lang.CharSequence arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.Editable>(this, global::android.text.Editable_.staticClass, "insert", "(ILjava/lang/CharSequence;)Landroid/text/Editable;", ref global::android.text.Editable_._insert12749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _insert12750;
		global::android.text.Editable android.text.Editable.insert(int arg0, java.lang.CharSequence arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.Editable>(this, global::android.text.Editable_.staticClass, "insert", "(ILjava/lang/CharSequence;II)Landroid/text/Editable;", ref global::android.text.Editable_._insert12750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _setFilters12751;
		void android.text.Editable.setFilters(android.text.InputFilter[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.Editable_.staticClass, "setFilters", "([Landroid/text/InputFilter;)V", ref global::android.text.Editable_._setFilters12751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFilters12752;
		global::android.text.InputFilter[] android.text.Editable.getFilters()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<android.text.InputFilter>(this, global::android.text.Editable_.staticClass, "getFilters", "()[Landroid/text/InputFilter;", ref global::android.text.Editable_._getFilters12752) as android.text.InputFilter[];
		}
		internal static global::MonoJavaBridge.MethodId _clearSpans12753;
		void android.text.Editable.clearSpans()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.Editable_.staticClass, "clearSpans", "()V", ref global::android.text.Editable_._clearSpans12753);
		}
		internal static global::MonoJavaBridge.MethodId _toString12754;
		global::java.lang.String java.lang.CharSequence.toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.text.Editable_.staticClass, "toString", "()Ljava/lang/String;", ref global::android.text.Editable_._toString12754) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _length12755;
		int java.lang.CharSequence.length()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Editable_.staticClass, "length", "()I", ref global::android.text.Editable_._length12755);
		}
		internal static global::MonoJavaBridge.MethodId _charAt12756;
		char java.lang.CharSequence.charAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::android.text.Editable_.staticClass, "charAt", "(I)C", ref global::android.text.Editable_._charAt12756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _subSequence12757;
		global::java.lang.CharSequence java.lang.CharSequence.subSequence(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.text.Editable_.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;", ref global::android.text.Editable_._subSequence12757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getChars12758;
		void android.text.GetChars.getChars(int arg0, int arg1, char[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.Editable_.staticClass, "getChars", "(II[CI)V", ref global::android.text.Editable_._getChars12758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setSpan12759;
		void android.text.Spannable.setSpan(java.lang.Object arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.Editable_.staticClass, "setSpan", "(Ljava/lang/Object;III)V", ref global::android.text.Editable_._setSpan12759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _removeSpan12760;
		void android.text.Spannable.removeSpan(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.Editable_.staticClass, "removeSpan", "(Ljava/lang/Object;)V", ref global::android.text.Editable_._removeSpan12760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpans12761;
		global::java.lang.Object[] android.text.Spanned.getSpans(int arg0, int arg1, java.lang.Class arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::android.text.Editable_.staticClass, "getSpans", "(IILjava/lang/Class;)[Ljava/lang/Object;", ref global::android.text.Editable_._getSpans12761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _getSpanStart12762;
		int android.text.Spanned.getSpanStart(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Editable_.staticClass, "getSpanStart", "(Ljava/lang/Object;)I", ref global::android.text.Editable_._getSpanStart12762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpanEnd12763;
		int android.text.Spanned.getSpanEnd(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Editable_.staticClass, "getSpanEnd", "(Ljava/lang/Object;)I", ref global::android.text.Editable_._getSpanEnd12763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpanFlags12764;
		int android.text.Spanned.getSpanFlags(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Editable_.staticClass, "getSpanFlags", "(Ljava/lang/Object;)I", ref global::android.text.Editable_._getSpanFlags12764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextSpanTransition12765;
		int android.text.Spanned.nextSpanTransition(int arg0, int arg1, java.lang.Class arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Editable_.staticClass, "nextSpanTransition", "(IILjava/lang/Class;)I", ref global::android.text.Editable_._nextSpanTransition12765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _append12766;
		global::java.lang.Appendable java.lang.Appendable.append(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.Appendable>(this, global::android.text.Editable_.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;", ref global::android.text.Editable_._append12766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Appendable;
		}
		internal static global::MonoJavaBridge.MethodId _append12767;
		global::java.lang.Appendable java.lang.Appendable.append(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.Appendable>(this, global::android.text.Editable_.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;", ref global::android.text.Editable_._append12767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Appendable;
		}
		internal static global::MonoJavaBridge.MethodId _append12768;
		global::java.lang.Appendable java.lang.Appendable.append(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.Appendable>(this, global::android.text.Editable_.staticClass, "append", "(C)Ljava/lang/Appendable;", ref global::android.text.Editable_._append12768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Appendable;
		}
		static Editable_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.Editable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Editable"));
		}
		internal static void InitJNI()
		{
		}
	}
}
