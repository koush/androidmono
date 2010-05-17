namespace android.text 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class SpannableStringInternal : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static SpannableStringInternal() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.SpannableStringInternal), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected SpannableStringInternal(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString6595; 
		public sealed override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.SpannableStringInternal)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString6595)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.SpannableStringInternal.staticClass, _toString6595)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _length6596; 
		public virtual int length() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.SpannableStringInternal)) 
				return @__env.CallIntMethod(this, _length6596); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.SpannableStringInternal.staticClass, _length6596); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _charAt6597; 
		public virtual char charAt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.SpannableStringInternal)) 
				return @__env.CallCharMethod(this, _charAt6597, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualCharMethod(this, android.text.SpannableStringInternal.staticClass, _charAt6597, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChars6598; 
		public virtual void getChars(int arg0, int arg1, char[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.SpannableStringInternal)) 
				@__env.CallVoidMethod(this, _getChars6598, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.SpannableStringInternal.staticClass, _getChars6598, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpans6599; 
		public virtual java.lang.Object[] getSpans(int arg0, int arg1, java.lang.Class arg2) 
		{ 
			if (GetType() == typeof(android.text.SpannableStringInternal)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getSpans6599, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.SpannableStringInternal.staticClass, _getSpans6599, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpanStart6600; 
		public virtual int getSpanStart(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.SpannableStringInternal)) 
				return @__env.CallIntMethod(this, _getSpanStart6600, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.SpannableStringInternal.staticClass, _getSpanStart6600, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpanEnd6601; 
		public virtual int getSpanEnd(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.SpannableStringInternal)) 
				return @__env.CallIntMethod(this, _getSpanEnd6601, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.SpannableStringInternal.staticClass, _getSpanEnd6601, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpanFlags6602; 
		public virtual int getSpanFlags(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.SpannableStringInternal)) 
				return @__env.CallIntMethod(this, _getSpanFlags6602, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.SpannableStringInternal.staticClass, _getSpanFlags6602, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _nextSpanTransition6603; 
		public virtual int nextSpanTransition(int arg0, int arg1, java.lang.Class arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.SpannableStringInternal)) 
				return @__env.CallIntMethod(this, _nextSpanTransition6603, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.SpannableStringInternal.staticClass, _nextSpanTransition6603, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.SpannableStringInternal.staticClass = @__class; 
			global::android.text.SpannableStringInternal._toString6595 = @__env.GetMethodID(global::android.text.SpannableStringInternal.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.text.SpannableStringInternal._length6596 = @__env.GetMethodID(global::android.text.SpannableStringInternal.staticClass, "length", "()I"); 
			global::android.text.SpannableStringInternal._charAt6597 = @__env.GetMethodID(global::android.text.SpannableStringInternal.staticClass, "charAt", "(I)C"); 
			global::android.text.SpannableStringInternal._getChars6598 = @__env.GetMethodID(global::android.text.SpannableStringInternal.staticClass, "getChars", "(II[CI)V"); 
			global::android.text.SpannableStringInternal._getSpans6599 = @__env.GetMethodID(global::android.text.SpannableStringInternal.staticClass, "getSpans", "(IILjava/lang/Class;)[Ljava/lang/Object;"); 
			global::android.text.SpannableStringInternal._getSpanStart6600 = @__env.GetMethodID(global::android.text.SpannableStringInternal.staticClass, "getSpanStart", "(Ljava/lang/Object;)I"); 
			global::android.text.SpannableStringInternal._getSpanEnd6601 = @__env.GetMethodID(global::android.text.SpannableStringInternal.staticClass, "getSpanEnd", "(Ljava/lang/Object;)I"); 
			global::android.text.SpannableStringInternal._getSpanFlags6602 = @__env.GetMethodID(global::android.text.SpannableStringInternal.staticClass, "getSpanFlags", "(Ljava/lang/Object;)I"); 
			global::android.text.SpannableStringInternal._nextSpanTransition6603 = @__env.GetMethodID(global::android.text.SpannableStringInternal.staticClass, "nextSpanTransition", "(IILjava/lang/Class;)I"); 
		} 
	} 
} 
