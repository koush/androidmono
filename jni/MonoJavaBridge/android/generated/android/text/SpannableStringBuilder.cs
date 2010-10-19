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
		internal static global::MonoJavaBridge.MethodId _toString8368;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._toString8368)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._toString8368)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _append8369;
		 global::java.lang.Appendable java.lang.Appendable.append(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._append8369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._append8369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		internal static global::MonoJavaBridge.MethodId _append8370;
		public virtual global::android.text.Editable append(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._append8370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._append8370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _append8371;
		public virtual global::android.text.Editable append(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._append8371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._append8371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Editable;
		}
		public android.text.Editable append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _append8372;
		 global::java.lang.Appendable java.lang.Appendable.append(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._append8372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._append8372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		internal static global::MonoJavaBridge.MethodId _append8373;
		public virtual global::android.text.Editable append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._append8373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._append8373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.text.Editable;
		}
		public android.text.Editable append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _append8374;
		 global::java.lang.Appendable java.lang.Appendable.append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._append8374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._append8374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
		}
		internal static global::MonoJavaBridge.MethodId _clear8375;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._clear8375);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._clear8375);
		}
		internal static global::MonoJavaBridge.MethodId _length8376;
		public virtual int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._length8376);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._length8376);
		}
		internal static global::MonoJavaBridge.MethodId _charAt8377;
		public virtual char charAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._charAt8377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._charAt8377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChars8378;
		public virtual void getChars(int arg0, int arg1, char[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._getChars8378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._getChars8378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _subSequence8379;
		public virtual global::java.lang.CharSequence subSequence(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._subSequence8379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._subSequence8379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _replace8380;
		public virtual global::android.text.Editable replace(int arg0, int arg1, java.lang.CharSequence arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._replace8380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._replace8380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.text.Editable;
		}
		public android.text.Editable replace(int arg0, int arg1, string arg2)
		{
			return replace(arg0, arg1, (global::java.lang.CharSequence)(global::java.lang.String)arg2);
		}
		internal static global::MonoJavaBridge.MethodId _replace8381;
		public virtual global::android.text.Editable replace(int arg0, int arg1, java.lang.CharSequence arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._replace8381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._replace8381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.text.Editable;
		}
		public android.text.Editable replace(int arg0, int arg1, string arg2, int arg3, int arg4)
		{
			return replace(arg0, arg1, (global::java.lang.CharSequence)(global::java.lang.String)arg2, arg3, arg4);
		}
		internal static global::MonoJavaBridge.MethodId _valueOf8382;
		public static global::android.text.SpannableStringBuilder valueOf(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._valueOf8382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.SpannableStringBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _delete8383;
		public virtual global::android.text.Editable delete(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._delete8383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._delete8383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _insert8384;
		public virtual global::android.text.Editable insert(int arg0, java.lang.CharSequence arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._insert8384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._insert8384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.text.Editable;
		}
		public android.text.Editable insert(int arg0, string arg1, int arg2, int arg3)
		{
			return insert(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _insert8385;
		public virtual global::android.text.Editable insert(int arg0, java.lang.CharSequence arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._insert8385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._insert8385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.text.Editable;
		}
		public android.text.Editable insert(int arg0, string arg1)
		{
			return insert(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _setFilters8386;
		public virtual void setFilters(android.text.InputFilter[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._setFilters8386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._setFilters8386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getFilters8387;
		public virtual global::android.text.InputFilter[] getFilters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.InputFilter>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._getFilters8387)) as android.text.InputFilter[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.InputFilter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._getFilters8387)) as android.text.InputFilter[];
		}
		internal static global::MonoJavaBridge.MethodId _clearSpans8388;
		public virtual void clearSpans() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._clearSpans8388);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._clearSpans8388);
		}
		internal static global::MonoJavaBridge.MethodId _setSpan8389;
		public virtual void setSpan(java.lang.Object arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._setSpan8389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._setSpan8389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _removeSpan8390;
		public virtual void removeSpan(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._removeSpan8390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._removeSpan8390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpans8391;
		public virtual global::java.lang.Object[] getSpans(int arg0, int arg1, java.lang.Class arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._getSpans8391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._getSpans8391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _getSpanStart8392;
		public virtual int getSpanStart(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._getSpanStart8392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._getSpanStart8392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpanEnd8393;
		public virtual int getSpanEnd(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._getSpanEnd8393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._getSpanEnd8393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpanFlags8394;
		public virtual int getSpanFlags(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._getSpanFlags8394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._getSpanFlags8394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextSpanTransition8395;
		public virtual int nextSpanTransition(int arg0, int arg1, java.lang.Class arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.SpannableStringBuilder._nextSpanTransition8395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._nextSpanTransition8395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _SpannableStringBuilder8396;
		public SpannableStringBuilder(java.lang.CharSequence arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._SpannableStringBuilder8396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SpannableStringBuilder8397;
		public SpannableStringBuilder(java.lang.CharSequence arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._SpannableStringBuilder8397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SpannableStringBuilder8398;
		public SpannableStringBuilder()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.SpannableStringBuilder.staticClass, global::android.text.SpannableStringBuilder._SpannableStringBuilder8398);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.SpannableStringBuilder.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/SpannableStringBuilder"));
			global::android.text.SpannableStringBuilder._toString8368 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "toString", "()Ljava/lang/String;");
			global::android.text.SpannableStringBuilder._append8369 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "append", "(C)Ljava/lang/Appendable;");
			global::android.text.SpannableStringBuilder._append8370 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "append", "(C)Landroid/text/Editable;");
			global::android.text.SpannableStringBuilder._append8371 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;)Landroid/text/Editable;");
			global::android.text.SpannableStringBuilder._append8372 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;");
			global::android.text.SpannableStringBuilder._append8373 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;II)Landroid/text/Editable;");
			global::android.text.SpannableStringBuilder._append8374 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;");
			global::android.text.SpannableStringBuilder._clear8375 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "clear", "()V");
			global::android.text.SpannableStringBuilder._length8376 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "length", "()I");
			global::android.text.SpannableStringBuilder._charAt8377 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "charAt", "(I)C");
			global::android.text.SpannableStringBuilder._getChars8378 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "getChars", "(II[CI)V");
			global::android.text.SpannableStringBuilder._subSequence8379 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
			global::android.text.SpannableStringBuilder._replace8380 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "replace", "(IILjava/lang/CharSequence;)Landroid/text/Editable;");
			global::android.text.SpannableStringBuilder._replace8381 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "replace", "(IILjava/lang/CharSequence;II)Landroid/text/Editable;");
			global::android.text.SpannableStringBuilder._valueOf8382 = @__env.GetStaticMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "valueOf", "(Ljava/lang/CharSequence;)Landroid/text/SpannableStringBuilder;");
			global::android.text.SpannableStringBuilder._delete8383 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "delete", "(II)Landroid/text/Editable;");
			global::android.text.SpannableStringBuilder._insert8384 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "insert", "(ILjava/lang/CharSequence;II)Landroid/text/Editable;");
			global::android.text.SpannableStringBuilder._insert8385 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "insert", "(ILjava/lang/CharSequence;)Landroid/text/Editable;");
			global::android.text.SpannableStringBuilder._setFilters8386 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "setFilters", "([Landroid/text/InputFilter;)V");
			global::android.text.SpannableStringBuilder._getFilters8387 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "getFilters", "()[Landroid/text/InputFilter;");
			global::android.text.SpannableStringBuilder._clearSpans8388 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "clearSpans", "()V");
			global::android.text.SpannableStringBuilder._setSpan8389 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "setSpan", "(Ljava/lang/Object;III)V");
			global::android.text.SpannableStringBuilder._removeSpan8390 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "removeSpan", "(Ljava/lang/Object;)V");
			global::android.text.SpannableStringBuilder._getSpans8391 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "getSpans", "(IILjava/lang/Class;)[Ljava/lang/Object;");
			global::android.text.SpannableStringBuilder._getSpanStart8392 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "getSpanStart", "(Ljava/lang/Object;)I");
			global::android.text.SpannableStringBuilder._getSpanEnd8393 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "getSpanEnd", "(Ljava/lang/Object;)I");
			global::android.text.SpannableStringBuilder._getSpanFlags8394 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "getSpanFlags", "(Ljava/lang/Object;)I");
			global::android.text.SpannableStringBuilder._nextSpanTransition8395 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "nextSpanTransition", "(IILjava/lang/Class;)I");
			global::android.text.SpannableStringBuilder._SpannableStringBuilder8396 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "<init>", "(Ljava/lang/CharSequence;)V");
			global::android.text.SpannableStringBuilder._SpannableStringBuilder8397 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "<init>", "(Ljava/lang/CharSequence;II)V");
			global::android.text.SpannableStringBuilder._SpannableStringBuilder8398 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringBuilder.staticClass, "<init>", "()V");
		}
	}
}
