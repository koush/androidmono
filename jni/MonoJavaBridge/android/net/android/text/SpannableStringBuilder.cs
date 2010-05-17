namespace android.text 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SpannableStringBuilder : java.lang.Object, java.lang.CharSequence, GetChars, Spannable, Editable, java.lang.Appendable
	{ 
		internal static global::java.lang.Class staticClass; 
		static SpannableStringBuilder() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.SpannableStringBuilder), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.SpannableStringBuilder(@__env); 
			} 
		} 
		protected SpannableStringBuilder(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear6564; 
		public virtual void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.SpannableStringBuilder)) 
				@__env.CallVoidMethod(this, _clear6564); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.SpannableStringBuilder.staticClass, _clear6564); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString6565; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.SpannableStringBuilder)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString6565)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.SpannableStringBuilder.staticClass, _toString6565)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _append6566; 
		 java.lang.Appendable java.lang.Appendable.append(char arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.SpannableStringBuilder)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallObjectMethodPtr(this, _append6566, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.SpannableStringBuilder.staticClass, _append6566, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _append6567; 
		public virtual android.text.Editable append(char arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.SpannableStringBuilder)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallObjectMethodPtr(this, _append6567, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.SpannableStringBuilder.staticClass, _append6567, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _append6568; 
		public virtual android.text.Editable append(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.SpannableStringBuilder)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallObjectMethodPtr(this, _append6568, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.SpannableStringBuilder.staticClass, _append6568, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _append6569; 
		 java.lang.Appendable java.lang.Appendable.append(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.SpannableStringBuilder)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallObjectMethodPtr(this, _append6569, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.SpannableStringBuilder.staticClass, _append6569, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _append6570; 
		public virtual android.text.Editable append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.SpannableStringBuilder)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallObjectMethodPtr(this, _append6570, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.SpannableStringBuilder.staticClass, _append6570, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _append6571; 
		 java.lang.Appendable java.lang.Appendable.append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.SpannableStringBuilder)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallObjectMethodPtr(this, _append6571, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.SpannableStringBuilder.staticClass, _append6571, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _length6572; 
		public virtual int length() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.SpannableStringBuilder)) 
				return @__env.CallIntMethod(this, _length6572); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.SpannableStringBuilder.staticClass, _length6572); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _charAt6573; 
		public virtual char charAt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.SpannableStringBuilder)) 
				return @__env.CallCharMethod(this, _charAt6573, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualCharMethod(this, android.text.SpannableStringBuilder.staticClass, _charAt6573, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChars6574; 
		public virtual void getChars(int arg0, int arg1, char[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.SpannableStringBuilder)) 
				@__env.CallVoidMethod(this, _getChars6574, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.SpannableStringBuilder.staticClass, _getChars6574, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _subSequence6575; 
		public virtual java.lang.CharSequence subSequence(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.SpannableStringBuilder)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _subSequence6575, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.SpannableStringBuilder.staticClass, _subSequence6575, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _replace6576; 
		public virtual android.text.Editable replace(int arg0, int arg1, java.lang.CharSequence arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.SpannableStringBuilder)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallObjectMethodPtr(this, _replace6576, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.SpannableStringBuilder.staticClass, _replace6576, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _replace6577; 
		public virtual android.text.Editable replace(int arg0, int arg1, java.lang.CharSequence arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.SpannableStringBuilder)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallObjectMethodPtr(this, _replace6577, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.SpannableStringBuilder.staticClass, _replace6577, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _valueOf6578; 
		public static android.text.SpannableStringBuilder valueOf(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.SpannableStringBuilder>(@__env, @__env.CallStaticObjectMethodPtr(android.text.SpannableStringBuilder.staticClass, _valueOf6578, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _delete6579; 
		public virtual android.text.Editable delete(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.SpannableStringBuilder)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallObjectMethodPtr(this, _delete6579, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.SpannableStringBuilder.staticClass, _delete6579, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _insert6580; 
		public virtual android.text.Editable insert(int arg0, java.lang.CharSequence arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.SpannableStringBuilder)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallObjectMethodPtr(this, _insert6580, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.SpannableStringBuilder.staticClass, _insert6580, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _insert6581; 
		public virtual android.text.Editable insert(int arg0, java.lang.CharSequence arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.SpannableStringBuilder)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallObjectMethodPtr(this, _insert6581, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.SpannableStringBuilder.staticClass, _insert6581, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFilters6582; 
		public virtual void setFilters(android.text.InputFilter[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.SpannableStringBuilder)) 
				@__env.CallVoidMethod(this, _setFilters6582, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.text.InputFilter[], android.text.InputFilter>(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.SpannableStringBuilder.staticClass, _setFilters6582, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.text.InputFilter[], android.text.InputFilter>(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFilters6583; 
		public virtual android.text.InputFilter[] getFilters() 
		{ 
			if (GetType() == typeof(android.text.SpannableStringBuilder)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getFilters6583)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.SpannableStringBuilder.staticClass, _getFilters6583)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearSpans6584; 
		public virtual void clearSpans() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.SpannableStringBuilder)) 
				@__env.CallVoidMethod(this, _clearSpans6584); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.SpannableStringBuilder.staticClass, _clearSpans6584); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSpan6585; 
		public virtual void setSpan(java.lang.Object arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.SpannableStringBuilder)) 
				@__env.CallVoidMethod(this, _setSpan6585, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.SpannableStringBuilder.staticClass, _setSpan6585, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeSpan6586; 
		public virtual void removeSpan(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.SpannableStringBuilder)) 
				@__env.CallVoidMethod(this, _removeSpan6586, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.SpannableStringBuilder.staticClass, _removeSpan6586, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpans6587; 
		public virtual java.lang.Object[] getSpans(int arg0, int arg1, java.lang.Class arg2) 
		{ 
			if (GetType() == typeof(android.text.SpannableStringBuilder)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getSpans6587, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.SpannableStringBuilder.staticClass, _getSpans6587, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpanStart6588; 
		public virtual int getSpanStart(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.SpannableStringBuilder)) 
				return @__env.CallIntMethod(this, _getSpanStart6588, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.SpannableStringBuilder.staticClass, _getSpanStart6588, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpanEnd6589; 
		public virtual int getSpanEnd(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.SpannableStringBuilder)) 
				return @__env.CallIntMethod(this, _getSpanEnd6589, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.SpannableStringBuilder.staticClass, _getSpanEnd6589, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpanFlags6590; 
		public virtual int getSpanFlags(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.SpannableStringBuilder)) 
				return @__env.CallIntMethod(this, _getSpanFlags6590, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.SpannableStringBuilder.staticClass, _getSpanFlags6590, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _nextSpanTransition6591; 
		public virtual int nextSpanTransition(int arg0, int arg1, java.lang.Class arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.SpannableStringBuilder)) 
				return @__env.CallIntMethod(this, _nextSpanTransition6591, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.SpannableStringBuilder.staticClass, _nextSpanTransition6591, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SpannableStringBuilder6592; 
		public SpannableStringBuilder(java.lang.CharSequence arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.SpannableStringBuilder.staticClass, _SpannableStringBuilder6592, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SpannableStringBuilder6593; 
		public SpannableStringBuilder(java.lang.CharSequence arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.SpannableStringBuilder.staticClass, _SpannableStringBuilder6593, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SpannableStringBuilder6594; 
		public SpannableStringBuilder()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.SpannableStringBuilder.staticClass, _SpannableStringBuilder6594, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.SpannableStringBuilder.staticClass = @__class; 
			global::android.text.SpannableStringBuilder._clear6564 = @__env.GetMethodID(global::android.text.SpannableStringBuilder.staticClass, "clear", "()V"); 
			global::android.text.SpannableStringBuilder._toString6565 = @__env.GetMethodID(global::android.text.SpannableStringBuilder.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.text.SpannableStringBuilder._append6566 = @__env.GetMethodID(global::android.text.SpannableStringBuilder.staticClass, "java.lang.Appendable.append", "(C)Ljava/lang/Appendable;"); 
			global::android.text.SpannableStringBuilder._append6567 = @__env.GetMethodID(global::android.text.SpannableStringBuilder.staticClass, "append", "(C)Landroid/text/Editable;"); 
			global::android.text.SpannableStringBuilder._append6568 = @__env.GetMethodID(global::android.text.SpannableStringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;)Landroid/text/Editable;"); 
			global::android.text.SpannableStringBuilder._append6569 = @__env.GetMethodID(global::android.text.SpannableStringBuilder.staticClass, "java.lang.Appendable.append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;"); 
			global::android.text.SpannableStringBuilder._append6570 = @__env.GetMethodID(global::android.text.SpannableStringBuilder.staticClass, "append", "(Ljava/lang/CharSequence;II)Landroid/text/Editable;"); 
			global::android.text.SpannableStringBuilder._append6571 = @__env.GetMethodID(global::android.text.SpannableStringBuilder.staticClass, "java.lang.Appendable.append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;"); 
			global::android.text.SpannableStringBuilder._length6572 = @__env.GetMethodID(global::android.text.SpannableStringBuilder.staticClass, "length", "()I"); 
			global::android.text.SpannableStringBuilder._charAt6573 = @__env.GetMethodID(global::android.text.SpannableStringBuilder.staticClass, "charAt", "(I)C"); 
			global::android.text.SpannableStringBuilder._getChars6574 = @__env.GetMethodID(global::android.text.SpannableStringBuilder.staticClass, "getChars", "(II[CI)V"); 
			global::android.text.SpannableStringBuilder._subSequence6575 = @__env.GetMethodID(global::android.text.SpannableStringBuilder.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;"); 
			global::android.text.SpannableStringBuilder._replace6576 = @__env.GetMethodID(global::android.text.SpannableStringBuilder.staticClass, "replace", "(IILjava/lang/CharSequence;)Landroid/text/Editable;"); 
			global::android.text.SpannableStringBuilder._replace6577 = @__env.GetMethodID(global::android.text.SpannableStringBuilder.staticClass, "replace", "(IILjava/lang/CharSequence;II)Landroid/text/Editable;"); 
			global::android.text.SpannableStringBuilder._valueOf6578 = @__env.GetStaticMethodID(global::android.text.SpannableStringBuilder.staticClass, "valueOf", "(Ljava/lang/CharSequence;)Landroid/text/SpannableStringBuilder;"); 
			global::android.text.SpannableStringBuilder._delete6579 = @__env.GetMethodID(global::android.text.SpannableStringBuilder.staticClass, "delete", "(II)Landroid/text/Editable;"); 
			global::android.text.SpannableStringBuilder._insert6580 = @__env.GetMethodID(global::android.text.SpannableStringBuilder.staticClass, "insert", "(ILjava/lang/CharSequence;II)Landroid/text/Editable;"); 
			global::android.text.SpannableStringBuilder._insert6581 = @__env.GetMethodID(global::android.text.SpannableStringBuilder.staticClass, "insert", "(ILjava/lang/CharSequence;)Landroid/text/Editable;"); 
			global::android.text.SpannableStringBuilder._setFilters6582 = @__env.GetMethodID(global::android.text.SpannableStringBuilder.staticClass, "setFilters", "([Landroid/text/InputFilter;)V"); 
			global::android.text.SpannableStringBuilder._getFilters6583 = @__env.GetMethodID(global::android.text.SpannableStringBuilder.staticClass, "getFilters", "()[Landroid/text/InputFilter;"); 
			global::android.text.SpannableStringBuilder._clearSpans6584 = @__env.GetMethodID(global::android.text.SpannableStringBuilder.staticClass, "clearSpans", "()V"); 
			global::android.text.SpannableStringBuilder._setSpan6585 = @__env.GetMethodID(global::android.text.SpannableStringBuilder.staticClass, "setSpan", "(Ljava/lang/Object;III)V"); 
			global::android.text.SpannableStringBuilder._removeSpan6586 = @__env.GetMethodID(global::android.text.SpannableStringBuilder.staticClass, "removeSpan", "(Ljava/lang/Object;)V"); 
			global::android.text.SpannableStringBuilder._getSpans6587 = @__env.GetMethodID(global::android.text.SpannableStringBuilder.staticClass, "getSpans", "(IILjava/lang/Class;)[Ljava/lang/Object;"); 
			global::android.text.SpannableStringBuilder._getSpanStart6588 = @__env.GetMethodID(global::android.text.SpannableStringBuilder.staticClass, "getSpanStart", "(Ljava/lang/Object;)I"); 
			global::android.text.SpannableStringBuilder._getSpanEnd6589 = @__env.GetMethodID(global::android.text.SpannableStringBuilder.staticClass, "getSpanEnd", "(Ljava/lang/Object;)I"); 
			global::android.text.SpannableStringBuilder._getSpanFlags6590 = @__env.GetMethodID(global::android.text.SpannableStringBuilder.staticClass, "getSpanFlags", "(Ljava/lang/Object;)I"); 
			global::android.text.SpannableStringBuilder._nextSpanTransition6591 = @__env.GetMethodID(global::android.text.SpannableStringBuilder.staticClass, "nextSpanTransition", "(IILjava/lang/Class;)I"); 
			global::android.text.SpannableStringBuilder._SpannableStringBuilder6592 = @__env.GetMethodID(global::android.text.SpannableStringBuilder.staticClass, "<init>", "(Ljava/lang/CharSequence;)V"); 
			global::android.text.SpannableStringBuilder._SpannableStringBuilder6593 = @__env.GetMethodID(global::android.text.SpannableStringBuilder.staticClass, "<init>", "(Ljava/lang/CharSequence;II)V"); 
			global::android.text.SpannableStringBuilder._SpannableStringBuilder6594 = @__env.GetMethodID(global::android.text.SpannableStringBuilder.staticClass, "<init>", "()V"); 
		} 
	} 
} 
