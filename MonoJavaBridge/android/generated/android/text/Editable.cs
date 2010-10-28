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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._append12742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._append12742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _append12743;
		global::android.text.Editable android.text.Editable.append(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._append12743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._append12743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _append12744;
		global::android.text.Editable android.text.Editable.append(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._append12744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._append12744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _clear12745;
		void android.text.Editable.clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Editable_._clear12745);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._clear12745);
		}
		internal static global::MonoJavaBridge.MethodId _replace12746;
		global::android.text.Editable android.text.Editable.replace(int arg0, int arg1, java.lang.CharSequence arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._replace12746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._replace12746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _replace12747;
		global::android.text.Editable android.text.Editable.replace(int arg0, int arg1, java.lang.CharSequence arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._replace12747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._replace12747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _delete12748;
		global::android.text.Editable android.text.Editable.delete(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._delete12748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._delete12748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _insert12749;
		global::android.text.Editable android.text.Editable.insert(int arg0, java.lang.CharSequence arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._insert12749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._insert12749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _insert12750;
		global::android.text.Editable android.text.Editable.insert(int arg0, java.lang.CharSequence arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._insert12750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._insert12750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _setFilters12751;
		void android.text.Editable.setFilters(android.text.InputFilter[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Editable_._setFilters12751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._setFilters12751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFilters12752;
		global::android.text.InputFilter[] android.text.Editable.getFilters()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.InputFilter>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._getFilters12752)) as android.text.InputFilter[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.InputFilter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._getFilters12752)) as android.text.InputFilter[];
		}
		internal static global::MonoJavaBridge.MethodId _clearSpans12753;
		void android.text.Editable.clearSpans()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Editable_._clearSpans12753);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._clearSpans12753);
		}
		internal static global::MonoJavaBridge.MethodId _toString12754;
		global::java.lang.String java.lang.CharSequence.toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._toString12754)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._toString12754)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _length12755;
		int java.lang.CharSequence.length()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Editable_._length12755);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._length12755);
		}
		internal static global::MonoJavaBridge.MethodId _charAt12756;
		char java.lang.CharSequence.charAt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.text.Editable_._charAt12756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._charAt12756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _subSequence12757;
		global::java.lang.CharSequence java.lang.CharSequence.subSequence(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._subSequence12757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._subSequence12757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getChars12758;
		void android.text.GetChars.getChars(int arg0, int arg1, char[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Editable_._getChars12758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._getChars12758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setSpan12759;
		void android.text.Spannable.setSpan(java.lang.Object arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Editable_._setSpan12759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._setSpan12759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _removeSpan12760;
		void android.text.Spannable.removeSpan(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Editable_._removeSpan12760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._removeSpan12760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpans12761;
		global::java.lang.Object[] android.text.Spanned.getSpans(int arg0, int arg1, java.lang.Class arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._getSpans12761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._getSpans12761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _getSpanStart12762;
		int android.text.Spanned.getSpanStart(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Editable_._getSpanStart12762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._getSpanStart12762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpanEnd12763;
		int android.text.Spanned.getSpanEnd(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Editable_._getSpanEnd12763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._getSpanEnd12763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpanFlags12764;
		int android.text.Spanned.getSpanFlags(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Editable_._getSpanFlags12764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._getSpanFlags12764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextSpanTransition12765;
		int android.text.Spanned.nextSpanTransition(int arg0, int arg1, java.lang.Class arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Editable_._nextSpanTransition12765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._nextSpanTransition12765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _append12766;
		global::java.lang.Appendable java.lang.Appendable.append(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._append12766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._append12766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		internal static global::MonoJavaBridge.MethodId _append12767;
		global::java.lang.Appendable java.lang.Appendable.append(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._append12767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._append12767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
		}
		internal static global::MonoJavaBridge.MethodId _append12768;
		global::java.lang.Appendable java.lang.Appendable.append(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._append12768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._append12768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		static Editable_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.Editable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Editable"));
			global::android.text.Editable_._append12742 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "append", "(Ljava/lang/CharSequence;II)Landroid/text/Editable;");
			global::android.text.Editable_._append12743 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "append", "(Ljava/lang/CharSequence;)Landroid/text/Editable;");
			global::android.text.Editable_._append12744 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "append", "(C)Landroid/text/Editable;");
			global::android.text.Editable_._clear12745 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "clear", "()V");
			global::android.text.Editable_._replace12746 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "replace", "(IILjava/lang/CharSequence;II)Landroid/text/Editable;");
			global::android.text.Editable_._replace12747 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "replace", "(IILjava/lang/CharSequence;)Landroid/text/Editable;");
			global::android.text.Editable_._delete12748 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "delete", "(II)Landroid/text/Editable;");
			global::android.text.Editable_._insert12749 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "insert", "(ILjava/lang/CharSequence;)Landroid/text/Editable;");
			global::android.text.Editable_._insert12750 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "insert", "(ILjava/lang/CharSequence;II)Landroid/text/Editable;");
			global::android.text.Editable_._setFilters12751 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "setFilters", "([Landroid/text/InputFilter;)V");
			global::android.text.Editable_._getFilters12752 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "getFilters", "()[Landroid/text/InputFilter;");
			global::android.text.Editable_._clearSpans12753 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "clearSpans", "()V");
			global::android.text.Editable_._toString12754 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "toString", "()Ljava/lang/String;");
			global::android.text.Editable_._length12755 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "length", "()I");
			global::android.text.Editable_._charAt12756 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "charAt", "(I)C");
			global::android.text.Editable_._subSequence12757 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
			global::android.text.Editable_._getChars12758 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "getChars", "(II[CI)V");
			global::android.text.Editable_._setSpan12759 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "setSpan", "(Ljava/lang/Object;III)V");
			global::android.text.Editable_._removeSpan12760 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "removeSpan", "(Ljava/lang/Object;)V");
			global::android.text.Editable_._getSpans12761 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "getSpans", "(IILjava/lang/Class;)[Ljava/lang/Object;");
			global::android.text.Editable_._getSpanStart12762 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "getSpanStart", "(Ljava/lang/Object;)I");
			global::android.text.Editable_._getSpanEnd12763 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "getSpanEnd", "(Ljava/lang/Object;)I");
			global::android.text.Editable_._getSpanFlags12764 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "getSpanFlags", "(Ljava/lang/Object;)I");
			global::android.text.Editable_._nextSpanTransition12765 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "nextSpanTransition", "(IILjava/lang/Class;)I");
			global::android.text.Editable_._append12766 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;");
			global::android.text.Editable_._append12767 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;");
			global::android.text.Editable_._append12768 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "append", "(C)Ljava/lang/Appendable;");
		}
		internal static void InitJNI()
		{
		}
	}
}
