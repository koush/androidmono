namespace android.text 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class SpannableStringInternal : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static SpannableStringInternal() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.SpannableStringInternal), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected SpannableStringInternal(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString6935; 
		public sealed override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.SpannableStringInternal._toString6935)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.SpannableStringInternal.staticClass, global::android.text.SpannableStringInternal._toString6935)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _length6936; 
		public virtual int length() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.text.SpannableStringInternal._length6936); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.text.SpannableStringInternal.staticClass, global::android.text.SpannableStringInternal._length6936); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _charAt6937; 
		public virtual char charAt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallCharMethod(this, global::android.text.SpannableStringInternal._charAt6937, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualCharMethod(this, global::android.text.SpannableStringInternal.staticClass, global::android.text.SpannableStringInternal._charAt6937, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChars6938; 
		public virtual void getChars(int arg0, int arg1, char[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.text.SpannableStringInternal._getChars6938, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.text.SpannableStringInternal.staticClass, global::android.text.SpannableStringInternal._getChars6938, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpans6939; 
		public virtual global::java.lang.Object[] getSpans(int arg0, int arg1, java.lang.Class arg2) 
		{ 
			if (!IsClrObject) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.text.SpannableStringInternal._getSpans6939, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.SpannableStringInternal.staticClass, global::android.text.SpannableStringInternal._getSpans6939, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpanStart6940; 
		public virtual int getSpanStart(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.text.SpannableStringInternal._getSpanStart6940, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.text.SpannableStringInternal.staticClass, global::android.text.SpannableStringInternal._getSpanStart6940, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpanEnd6941; 
		public virtual int getSpanEnd(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.text.SpannableStringInternal._getSpanEnd6941, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.text.SpannableStringInternal.staticClass, global::android.text.SpannableStringInternal._getSpanEnd6941, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpanFlags6942; 
		public virtual int getSpanFlags(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.text.SpannableStringInternal._getSpanFlags6942, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.text.SpannableStringInternal.staticClass, global::android.text.SpannableStringInternal._getSpanFlags6942, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _nextSpanTransition6943; 
		public virtual int nextSpanTransition(int arg0, int arg1, java.lang.Class arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.text.SpannableStringInternal._nextSpanTransition6943, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.text.SpannableStringInternal.staticClass, global::android.text.SpannableStringInternal._nextSpanTransition6943, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.SpannableStringInternal.staticClass = @__class; 
			global::android.text.SpannableStringInternal._toString6935 = @__env.GetMethodID(global::android.text.SpannableStringInternal.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.text.SpannableStringInternal._length6936 = @__env.GetMethodID(global::android.text.SpannableStringInternal.staticClass, "length", "()I"); 
			global::android.text.SpannableStringInternal._charAt6937 = @__env.GetMethodID(global::android.text.SpannableStringInternal.staticClass, "charAt", "(I)C"); 
			global::android.text.SpannableStringInternal._getChars6938 = @__env.GetMethodID(global::android.text.SpannableStringInternal.staticClass, "getChars", "(II[CI)V"); 
			global::android.text.SpannableStringInternal._getSpans6939 = @__env.GetMethodID(global::android.text.SpannableStringInternal.staticClass, "getSpans", "(IILjava/lang/Class;)[Ljava/lang/Object;"); 
			global::android.text.SpannableStringInternal._getSpanStart6940 = @__env.GetMethodID(global::android.text.SpannableStringInternal.staticClass, "getSpanStart", "(Ljava/lang/Object;)I"); 
			global::android.text.SpannableStringInternal._getSpanEnd6941 = @__env.GetMethodID(global::android.text.SpannableStringInternal.staticClass, "getSpanEnd", "(Ljava/lang/Object;)I"); 
			global::android.text.SpannableStringInternal._getSpanFlags6942 = @__env.GetMethodID(global::android.text.SpannableStringInternal.staticClass, "getSpanFlags", "(Ljava/lang/Object;)I"); 
			global::android.text.SpannableStringInternal._nextSpanTransition6943 = @__env.GetMethodID(global::android.text.SpannableStringInternal.staticClass, "nextSpanTransition", "(IILjava/lang/Class;)I"); 
		} 
	} 
} 
