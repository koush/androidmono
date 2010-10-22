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
		internal static global::MonoJavaBridge.MethodId _toString12888;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._toString12888)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._toString12888)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _append12889;
		 global::java.lang.Appendable java.lang.Appendable.append(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._append12889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._append12889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		internal static global::MonoJavaBridge.MethodId _append12890;
		public virtual global::android.text.Editable append(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._append12890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._append12890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _append12891;
		public virtual global::android.text.Editable append(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._append12891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._append12891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Editable;
		}
		public android.text.Editable append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _append12892;
		 global::java.lang.Appendable java.lang.Appendable.append(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._append12892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._append12892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		internal static global::MonoJavaBridge.MethodId _append12893;
		public virtual global::android.text.Editable append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._append12893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._append12893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.text.Editable;
		}
		public android.text.Editable append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _append12894;
		 global::java.lang.Appendable java.lang.Appendable.append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._append12894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._append12894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
		}
		internal static global::MonoJavaBridge.MethodId _clear12895;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._clear12895);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._clear12895);
		}
		internal static global::MonoJavaBridge.MethodId _length12896;
		public virtual int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._length12896);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._length12896);
		}
		internal static global::MonoJavaBridge.MethodId _charAt12897;
		public virtual char charAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._charAt12897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._charAt12897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChars12898;
		public virtual void getChars(int arg0, int arg1, char[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._getChars12898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._getChars12898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _subSequence12899;
		public virtual global::java.lang.CharSequence subSequence(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._subSequence12899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._subSequence12899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _replace12900;
		public virtual global::android.text.Editable replace(int arg0, int arg1, java.lang.CharSequence arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._replace12900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._replace12900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.text.Editable;
		}
		public android.text.Editable replace(int arg0, int arg1, string arg2)
		{
			return replace(arg0, arg1, (global::java.lang.CharSequence)(global::java.lang.String)arg2);
		}
		internal static global::MonoJavaBridge.MethodId _replace12901;
		public virtual global::android.text.Editable replace(int arg0, int arg1, java.lang.CharSequence arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._replace12901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._replace12901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.text.Editable;
		}
		public android.text.Editable replace(int arg0, int arg1, string arg2, int arg3, int arg4)
		{
			return replace(arg0, arg1, (global::java.lang.CharSequence)(global::java.lang.String)arg2, arg3, arg4);
		}
		internal static global::MonoJavaBridge.MethodId _valueOf12902;
		public static global::android.text.SpannableStringBuilder valueOf(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._valueOf12902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.SpannableStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _delete12903;
		public virtual global::android.text.Editable delete(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._delete12903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._delete12903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _insert12904;
		public virtual global::android.text.Editable insert(int arg0, java.lang.CharSequence arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._insert12904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._insert12904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.text.Editable;
		}
		public android.text.Editable insert(int arg0, string arg1, int arg2, int arg3)
		{
			return insert(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _insert12905;
		public virtual global::android.text.Editable insert(int arg0, java.lang.CharSequence arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._insert12905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._insert12905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.text.Editable;
		}
		public android.text.Editable insert(int arg0, string arg1)
		{
			return insert(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _setFilters12906;
		public virtual void setFilters(android.text.InputFilter[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._setFilters12906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._setFilters12906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getFilters12907;
		public virtual global::android.text.InputFilter[] getFilters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.InputFilter>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._getFilters12907)) as android.text.InputFilter[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.InputFilter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._getFilters12907)) as android.text.InputFilter[];
		}
		internal static global::MonoJavaBridge.MethodId _clearSpans12908;
		public virtual void clearSpans() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._clearSpans12908);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._clearSpans12908);
		}
		internal static global::MonoJavaBridge.MethodId _setSpan12909;
		public virtual void setSpan(java.lang.Object arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._setSpan12909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._setSpan12909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _removeSpan12910;
		public virtual void removeSpan(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._removeSpan12910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._removeSpan12910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpans12911;
		public virtual global::java.lang.Object[] getSpans(int arg0, int arg1, java.lang.Class arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._getSpans12911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._getSpans12911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _getSpanStart12912;
		public virtual int getSpanStart(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._getSpanStart12912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._getSpanStart12912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpanEnd12913;
		public virtual int getSpanEnd(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._getSpanEnd12913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._getSpanEnd12913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpanFlags12914;
		public virtual int getSpanFlags(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._getSpanFlags12914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._getSpanFlags12914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextSpanTransition12915;
		public virtual int nextSpanTransition(int arg0, int arg1, java.lang.Class arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._nextSpanTransition12915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._nextSpanTransition12915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _SpannableStringBuilder12916;
		public SpannableStringBuilder(java.lang.CharSequence arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._SpannableStringBuilder12916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SpannableStringBuilder12917;
		public SpannableStringBuilder(java.lang.CharSequence arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._SpannableStringBuilder12917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SpannableStringBuilder12918;
		public SpannableStringBuilder()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._SpannableStringBuilder12918);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.SpannableStringBuilder.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/SpannableStringBuilder"));
			global::android.text.SpannableStringBuilder._toString12888 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "toString", "()Ljava/lang/String;");
			global::android.text.SpannableStringBuilder._append12889 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "append", "(C)Ljava/lang/Appendable;");
			global::android.text.SpannableStringBuilder._append12890 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "append", "(C)Landroid/text/Editable;");
			global::android.text.SpannableStringBuilder._append12891 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;)Landroid/text/Editable;");
			global::android.text.SpannableStringBuilder._append12892 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;");
			global::android.text.SpannableStringBuilder._append12893 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;II)Landroid/text/Editable;");
			global::android.text.SpannableStringBuilder._append12894 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;");
			global::android.text.SpannableStringBuilder._clear12895 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "clear", "()V");
			global::android.text.SpannableStringBuilder._length12896 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "length", "()I");
			global::android.text.SpannableStringBuilder._charAt12897 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "charAt", "(I)C");
			global::android.text.SpannableStringBuilder._getChars12898 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "getChars", "(II[CI)V");
			global::android.text.SpannableStringBuilder._subSequence12899 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
			global::android.text.SpannableStringBuilder._replace12900 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "replace", "(IILjava/lang/CharSequence;)Landroid/text/Editable;");
			global::android.text.SpannableStringBuilder._replace12901 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "replace", "(IILjava/lang/CharSequence;II)Landroid/text/Editable;");
			global::android.text.SpannableStringBuilder._valueOf12902 = @__env.GetStaticMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "valueOf", "(Ljava/lang/CharSequence;)Landroid/text/SpannableStringBuilder;");
			global::android.text.SpannableStringBuilder._delete12903 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "delete", "(II)Landroid/text/Editable;");
			global::android.text.SpannableStringBuilder._insert12904 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "insert", "(ILjava/lang/CharSequence;II)Landroid/text/Editable;");
			global::android.text.SpannableStringBuilder._insert12905 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "insert", "(ILjava/lang/CharSequence;)Landroid/text/Editable;");
			global::android.text.SpannableStringBuilder._setFilters12906 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "setFilters", "([Landroid/text/InputFilter;)V");
			global::android.text.SpannableStringBuilder._getFilters12907 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "getFilters", "()[Landroid/text/InputFilter;");
			global::android.text.SpannableStringBuilder._clearSpans12908 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "clearSpans", "()V");
			global::android.text.SpannableStringBuilder._setSpan12909 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "setSpan", "(Ljava/lang/Object;III)V");
			global::android.text.SpannableStringBuilder._removeSpan12910 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "removeSpan", "(Ljava/lang/Object;)V");
			global::android.text.SpannableStringBuilder._getSpans12911 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "getSpans", "(IILjava/lang/Class;)[Ljava/lang/Object;");
			global::android.text.SpannableStringBuilder._getSpanStart12912 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "getSpanStart", "(Ljava/lang/Object;)I");
			global::android.text.SpannableStringBuilder._getSpanEnd12913 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "getSpanEnd", "(Ljava/lang/Object;)I");
			global::android.text.SpannableStringBuilder._getSpanFlags12914 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "getSpanFlags", "(Ljava/lang/Object;)I");
			global::android.text.SpannableStringBuilder._nextSpanTransition12915 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "nextSpanTransition", "(IILjava/lang/Class;)I");
			global::android.text.SpannableStringBuilder._SpannableStringBuilder12916 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "<init>", "(Ljava/lang/CharSequence;)V");
			global::android.text.SpannableStringBuilder._SpannableStringBuilder12917 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "<init>", "(Ljava/lang/CharSequence;II)V");
			global::android.text.SpannableStringBuilder._SpannableStringBuilder12918 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "<init>", "()V");
		}
	}
}
