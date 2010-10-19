namespace android.text
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.Editable_))]
	public interface Editable : java.lang.CharSequence, GetChars, Spannable, java.lang.Appendable
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
	public sealed partial class Editable_ : java.lang.Object, Editable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Editable_()
		{
			InitJNI();
		}
		internal Editable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _append8200;
		 global::android.text.Editable android.text.Editable.append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._append8200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._append8200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _append8201;
		 global::android.text.Editable android.text.Editable.append(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._append8201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._append8201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _append8202;
		 global::android.text.Editable android.text.Editable.append(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._append8202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._append8202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _clear8203;
		 void android.text.Editable.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Editable_._clear8203);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._clear8203);
		}
		internal static global::MonoJavaBridge.MethodId _replace8204;
		 global::android.text.Editable android.text.Editable.replace(int arg0, int arg1, java.lang.CharSequence arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._replace8204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._replace8204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _replace8205;
		 global::android.text.Editable android.text.Editable.replace(int arg0, int arg1, java.lang.CharSequence arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._replace8205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._replace8205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _delete8206;
		 global::android.text.Editable android.text.Editable.delete(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._delete8206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._delete8206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _insert8207;
		 global::android.text.Editable android.text.Editable.insert(int arg0, java.lang.CharSequence arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._insert8207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._insert8207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _insert8208;
		 global::android.text.Editable android.text.Editable.insert(int arg0, java.lang.CharSequence arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._insert8208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._insert8208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _setFilters8209;
		 void android.text.Editable.setFilters(android.text.InputFilter[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Editable_._setFilters8209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._setFilters8209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFilters8210;
		 global::android.text.InputFilter[] android.text.Editable.getFilters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.InputFilter>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._getFilters8210)) as android.text.InputFilter[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.InputFilter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._getFilters8210)) as android.text.InputFilter[];
		}
		internal static global::MonoJavaBridge.MethodId _clearSpans8211;
		 void android.text.Editable.clearSpans() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Editable_._clearSpans8211);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._clearSpans8211);
		}
		internal static global::MonoJavaBridge.MethodId _toString8212;
		 global::java.lang.String java.lang.CharSequence.toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._toString8212)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._toString8212)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _length8213;
		 int java.lang.CharSequence.length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Editable_._length8213);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._length8213);
		}
		internal static global::MonoJavaBridge.MethodId _charAt8214;
		 char java.lang.CharSequence.charAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.text.Editable_._charAt8214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._charAt8214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _subSequence8215;
		 global::java.lang.CharSequence java.lang.CharSequence.subSequence(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._subSequence8215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._subSequence8215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getChars8216;
		 void android.text.GetChars.getChars(int arg0, int arg1, char[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Editable_._getChars8216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._getChars8216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setSpan8217;
		 void android.text.Spannable.setSpan(java.lang.Object arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Editable_._setSpan8217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._setSpan8217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _removeSpan8218;
		 void android.text.Spannable.removeSpan(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Editable_._removeSpan8218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._removeSpan8218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpans8219;
		 global::java.lang.Object[] android.text.Spanned.getSpans(int arg0, int arg1, java.lang.Class arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._getSpans8219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._getSpans8219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _getSpanStart8220;
		 int android.text.Spanned.getSpanStart(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Editable_._getSpanStart8220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._getSpanStart8220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpanEnd8221;
		 int android.text.Spanned.getSpanEnd(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Editable_._getSpanEnd8221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._getSpanEnd8221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpanFlags8222;
		 int android.text.Spanned.getSpanFlags(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Editable_._getSpanFlags8222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._getSpanFlags8222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextSpanTransition8223;
		 int android.text.Spanned.nextSpanTransition(int arg0, int arg1, java.lang.Class arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Editable_._nextSpanTransition8223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._nextSpanTransition8223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _append8224;
		 global::java.lang.Appendable java.lang.Appendable.append(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._append8224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._append8224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		internal static global::MonoJavaBridge.MethodId _append8225;
		 global::java.lang.Appendable java.lang.Appendable.append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._append8225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._append8225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
		}
		internal static global::MonoJavaBridge.MethodId _append8226;
		 global::java.lang.Appendable java.lang.Appendable.append(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._append8226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._append8226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.Editable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Editable"));
			global::android.text.Editable_._append8200 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "append", "(Ljava/lang/CharSequence;II)Landroid/text/Editable;");
			global::android.text.Editable_._append8201 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "append", "(Ljava/lang/CharSequence;)Landroid/text/Editable;");
			global::android.text.Editable_._append8202 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "append", "(C)Landroid/text/Editable;");
			global::android.text.Editable_._clear8203 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "clear", "()V");
			global::android.text.Editable_._replace8204 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "replace", "(IILjava/lang/CharSequence;II)Landroid/text/Editable;");
			global::android.text.Editable_._replace8205 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "replace", "(IILjava/lang/CharSequence;)Landroid/text/Editable;");
			global::android.text.Editable_._delete8206 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "delete", "(II)Landroid/text/Editable;");
			global::android.text.Editable_._insert8207 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "insert", "(ILjava/lang/CharSequence;)Landroid/text/Editable;");
			global::android.text.Editable_._insert8208 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "insert", "(ILjava/lang/CharSequence;II)Landroid/text/Editable;");
			global::android.text.Editable_._setFilters8209 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "setFilters", "([Landroid/text/InputFilter;)V");
			global::android.text.Editable_._getFilters8210 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "getFilters", "()[Landroid/text/InputFilter;");
			global::android.text.Editable_._clearSpans8211 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "clearSpans", "()V");
			global::android.text.Editable_._toString8212 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "toString", "()Ljava/lang/String;");
			global::android.text.Editable_._length8213 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "length", "()I");
			global::android.text.Editable_._charAt8214 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "charAt", "(I)C");
			global::android.text.Editable_._subSequence8215 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
			global::android.text.Editable_._getChars8216 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "getChars", "(II[CI)V");
			global::android.text.Editable_._setSpan8217 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "setSpan", "(Ljava/lang/Object;III)V");
			global::android.text.Editable_._removeSpan8218 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "removeSpan", "(Ljava/lang/Object;)V");
			global::android.text.Editable_._getSpans8219 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "getSpans", "(IILjava/lang/Class;)[Ljava/lang/Object;");
			global::android.text.Editable_._getSpanStart8220 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "getSpanStart", "(Ljava/lang/Object;)I");
			global::android.text.Editable_._getSpanEnd8221 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "getSpanEnd", "(Ljava/lang/Object;)I");
			global::android.text.Editable_._getSpanFlags8222 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "getSpanFlags", "(Ljava/lang/Object;)I");
			global::android.text.Editable_._nextSpanTransition8223 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "nextSpanTransition", "(IILjava/lang/Class;)I");
			global::android.text.Editable_._append8224 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;");
			global::android.text.Editable_._append8225 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;");
			global::android.text.Editable_._append8226 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "append", "(C)Ljava/lang/Appendable;");
		}
	}
}
