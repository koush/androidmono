namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SpannableStringBuilder : java.lang.Object, java.lang.CharSequence, GetChars, Spannable, Editable, java.lang.Appendable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SpannableStringBuilder()
		{
			InitJNI();
		}
		protected SpannableStringBuilder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString12949;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._toString12949)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._toString12949)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _append12950;
		 global::java.lang.Appendable java.lang.Appendable.append(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._append12950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._append12950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		internal static global::MonoJavaBridge.MethodId _append12951;
		public virtual global::android.text.Editable append(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._append12951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._append12951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _append12952;
		public virtual global::android.text.Editable append(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._append12952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._append12952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Editable;
		}
		public android.text.Editable append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _append12953;
		 global::java.lang.Appendable java.lang.Appendable.append(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._append12953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._append12953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		internal static global::MonoJavaBridge.MethodId _append12954;
		public virtual global::android.text.Editable append(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._append12954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._append12954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.text.Editable;
		}
		public android.text.Editable append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _append12955;
		 global::java.lang.Appendable java.lang.Appendable.append(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._append12955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._append12955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
		}
		internal static global::MonoJavaBridge.MethodId _clear12956;
		public virtual void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._clear12956);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._clear12956);
		}
		internal static global::MonoJavaBridge.MethodId _length12957;
		public virtual int length()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._length12957);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._length12957);
		}
		internal static global::MonoJavaBridge.MethodId _charAt12958;
		public virtual char charAt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._charAt12958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._charAt12958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChars12959;
		public virtual void getChars(int arg0, int arg1, char[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._getChars12959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._getChars12959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _subSequence12960;
		public virtual global::java.lang.CharSequence subSequence(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._subSequence12960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._subSequence12960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _replace12961;
		public virtual global::android.text.Editable replace(int arg0, int arg1, java.lang.CharSequence arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._replace12961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._replace12961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.text.Editable;
		}
		public android.text.Editable replace(int arg0, int arg1, string arg2)
		{
			return replace(arg0, arg1, (global::java.lang.CharSequence)(global::java.lang.String)arg2);
		}
		internal static global::MonoJavaBridge.MethodId _replace12962;
		public virtual global::android.text.Editable replace(int arg0, int arg1, java.lang.CharSequence arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._replace12962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._replace12962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.text.Editable;
		}
		public android.text.Editable replace(int arg0, int arg1, string arg2, int arg3, int arg4)
		{
			return replace(arg0, arg1, (global::java.lang.CharSequence)(global::java.lang.String)arg2, arg3, arg4);
		}
		internal static global::MonoJavaBridge.MethodId _valueOf12963;
		public static global::android.text.SpannableStringBuilder valueOf(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._valueOf12963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.SpannableStringBuilder;
		}
		public static android.text.SpannableStringBuilder valueOf(string arg0)
		{
			return valueOf((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _delete12964;
		public virtual global::android.text.Editable delete(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._delete12964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._delete12964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _insert12965;
		public virtual global::android.text.Editable insert(int arg0, java.lang.CharSequence arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._insert12965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._insert12965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.text.Editable;
		}
		public android.text.Editable insert(int arg0, string arg1, int arg2, int arg3)
		{
			return insert(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _insert12966;
		public virtual global::android.text.Editable insert(int arg0, java.lang.CharSequence arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._insert12966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._insert12966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.text.Editable;
		}
		public android.text.Editable insert(int arg0, string arg1)
		{
			return insert(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _setFilters12967;
		public virtual void setFilters(android.text.InputFilter[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._setFilters12967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._setFilters12967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.text.InputFilter[] Filters
		{
			get
			{
				return getFilters();
			}
			set
			{
				setFilters(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFilters12968;
		public virtual global::android.text.InputFilter[] getFilters()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.InputFilter>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._getFilters12968)) as android.text.InputFilter[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.InputFilter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._getFilters12968)) as android.text.InputFilter[];
		}
		internal static global::MonoJavaBridge.MethodId _clearSpans12969;
		public virtual void clearSpans()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._clearSpans12969);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._clearSpans12969);
		}
		internal static global::MonoJavaBridge.MethodId _setSpan12970;
		public virtual void setSpan(java.lang.Object arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._setSpan12970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._setSpan12970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _removeSpan12971;
		public virtual void removeSpan(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._removeSpan12971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._removeSpan12971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpans12972;
		public virtual global::java.lang.Object[] getSpans(int arg0, int arg1, java.lang.Class arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._getSpans12972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._getSpans12972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _getSpanStart12973;
		public virtual int getSpanStart(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._getSpanStart12973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._getSpanStart12973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpanEnd12974;
		public virtual int getSpanEnd(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._getSpanEnd12974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._getSpanEnd12974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpanFlags12975;
		public virtual int getSpanFlags(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._getSpanFlags12975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._getSpanFlags12975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextSpanTransition12976;
		public virtual int nextSpanTransition(int arg0, int arg1, java.lang.Class arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._nextSpanTransition12976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._nextSpanTransition12976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _SpannableStringBuilder12977;
		public SpannableStringBuilder(java.lang.CharSequence arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._SpannableStringBuilder12977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SpannableStringBuilder12978;
		public SpannableStringBuilder(java.lang.CharSequence arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._SpannableStringBuilder12978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SpannableStringBuilder12979;
		public SpannableStringBuilder() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._SpannableStringBuilder12979);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.SpannableStringBuilder.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/SpannableStringBuilder"));
			global::android.text.SpannableStringBuilder._toString12949 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "toString", "()Ljava/lang/String;");
			global::android.text.SpannableStringBuilder._append12950 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "append", "(C)Ljava/lang/Appendable;");
			global::android.text.SpannableStringBuilder._append12951 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "append", "(C)Landroid/text/Editable;");
			global::android.text.SpannableStringBuilder._append12952 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;)Landroid/text/Editable;");
			global::android.text.SpannableStringBuilder._append12953 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;");
			global::android.text.SpannableStringBuilder._append12954 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;II)Landroid/text/Editable;");
			global::android.text.SpannableStringBuilder._append12955 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;");
			global::android.text.SpannableStringBuilder._clear12956 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "clear", "()V");
			global::android.text.SpannableStringBuilder._length12957 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "length", "()I");
			global::android.text.SpannableStringBuilder._charAt12958 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "charAt", "(I)C");
			global::android.text.SpannableStringBuilder._getChars12959 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "getChars", "(II[CI)V");
			global::android.text.SpannableStringBuilder._subSequence12960 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
			global::android.text.SpannableStringBuilder._replace12961 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "replace", "(IILjava/lang/CharSequence;)Landroid/text/Editable;");
			global::android.text.SpannableStringBuilder._replace12962 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "replace", "(IILjava/lang/CharSequence;II)Landroid/text/Editable;");
			global::android.text.SpannableStringBuilder._valueOf12963 = @__env.GetStaticMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "valueOf", "(Ljava/lang/CharSequence;)Landroid/text/SpannableStringBuilder;");
			global::android.text.SpannableStringBuilder._delete12964 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "delete", "(II)Landroid/text/Editable;");
			global::android.text.SpannableStringBuilder._insert12965 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "insert", "(ILjava/lang/CharSequence;II)Landroid/text/Editable;");
			global::android.text.SpannableStringBuilder._insert12966 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "insert", "(ILjava/lang/CharSequence;)Landroid/text/Editable;");
			global::android.text.SpannableStringBuilder._setFilters12967 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "setFilters", "([Landroid/text/InputFilter;)V");
			global::android.text.SpannableStringBuilder._getFilters12968 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "getFilters", "()[Landroid/text/InputFilter;");
			global::android.text.SpannableStringBuilder._clearSpans12969 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "clearSpans", "()V");
			global::android.text.SpannableStringBuilder._setSpan12970 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "setSpan", "(Ljava/lang/Object;III)V");
			global::android.text.SpannableStringBuilder._removeSpan12971 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "removeSpan", "(Ljava/lang/Object;)V");
			global::android.text.SpannableStringBuilder._getSpans12972 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "getSpans", "(IILjava/lang/Class;)[Ljava/lang/Object;");
			global::android.text.SpannableStringBuilder._getSpanStart12973 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "getSpanStart", "(Ljava/lang/Object;)I");
			global::android.text.SpannableStringBuilder._getSpanEnd12974 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "getSpanEnd", "(Ljava/lang/Object;)I");
			global::android.text.SpannableStringBuilder._getSpanFlags12975 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "getSpanFlags", "(Ljava/lang/Object;)I");
			global::android.text.SpannableStringBuilder._nextSpanTransition12976 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "nextSpanTransition", "(IILjava/lang/Class;)I");
			global::android.text.SpannableStringBuilder._SpannableStringBuilder12977 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "<init>", "(Ljava/lang/CharSequence;)V");
			global::android.text.SpannableStringBuilder._SpannableStringBuilder12978 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "<init>", "(Ljava/lang/CharSequence;II)V");
			global::android.text.SpannableStringBuilder._SpannableStringBuilder12979 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "<init>", "()V");
		}
	}
}
