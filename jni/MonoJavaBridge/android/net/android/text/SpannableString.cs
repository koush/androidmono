namespace android.text 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SpannableString : android.text.SpannableStringInternal, java.lang.CharSequence, GetChars, Spannable
	{ 
		internal new static global::java.lang.Class staticClass; 
		static SpannableString() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.SpannableString), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.SpannableString(@__env); 
			} 
		} 
		protected SpannableString(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _subSequence6559; 
		public virtual java.lang.CharSequence subSequence(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.SpannableString)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _subSequence6559, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.SpannableString.staticClass, _subSequence6559, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _valueOf6560; 
		public static android.text.SpannableString valueOf(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.SpannableString>(@__env, @__env.CallStaticObjectMethodPtr(android.text.SpannableString.staticClass, _valueOf6560, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSpan6561; 
		public virtual void setSpan(java.lang.Object arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.SpannableString)) 
				@__env.CallVoidMethod(this, _setSpan6561, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.SpannableString.staticClass, _setSpan6561, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeSpan6562; 
		public virtual void removeSpan(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.SpannableString)) 
				@__env.CallVoidMethod(this, _removeSpan6562, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.SpannableString.staticClass, _removeSpan6562, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SpannableString6563; 
		public SpannableString(java.lang.CharSequence arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.SpannableString.staticClass, _SpannableString6563, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.SpannableString.staticClass = @__class; 
			global::android.text.SpannableString._subSequence6559 = @__env.GetMethodID(global::android.text.SpannableString.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;"); 
			global::android.text.SpannableString._valueOf6560 = @__env.GetStaticMethodID(global::android.text.SpannableString.staticClass, "valueOf", "(Ljava/lang/CharSequence;)Landroid/text/SpannableString;"); 
			global::android.text.SpannableString._setSpan6561 = @__env.GetMethodID(global::android.text.SpannableString.staticClass, "setSpan", "(Ljava/lang/Object;III)V"); 
			global::android.text.SpannableString._removeSpan6562 = @__env.GetMethodID(global::android.text.SpannableString.staticClass, "removeSpan", "(Ljava/lang/Object;)V"); 
			global::android.text.SpannableString._SpannableString6563 = @__env.GetMethodID(global::android.text.SpannableString.staticClass, "<init>", "(Ljava/lang/CharSequence;)V"); 
		} 
	} 
} 
