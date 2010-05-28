namespace android.text 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class AlteredCharSequence : java.lang.Object, java.lang.CharSequence, GetChars
	{ 
		internal static global::java.lang.Class staticClass; 
		static AlteredCharSequence() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.AlteredCharSequence), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.AlteredCharSequence(@__env); 
			} 
		} 
		protected AlteredCharSequence(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString6681; 
		public override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.AlteredCharSequence)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.AlteredCharSequence._toString6681)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.AlteredCharSequence.staticClass, global::android.text.AlteredCharSequence._toString6681)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _length6682; 
		public virtual int length() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.AlteredCharSequence)) 
				return @__env.CallIntMethod(this, global::android.text.AlteredCharSequence._length6682); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.text.AlteredCharSequence.staticClass, global::android.text.AlteredCharSequence._length6682); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _charAt6683; 
		public virtual char charAt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.AlteredCharSequence)) 
				return @__env.CallCharMethod(this, global::android.text.AlteredCharSequence._charAt6683, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualCharMethod(this, global::android.text.AlteredCharSequence.staticClass, global::android.text.AlteredCharSequence._charAt6683, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChars6684; 
		public virtual void getChars(int arg0, int arg1, char[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.AlteredCharSequence)) 
				@__env.CallVoidMethod(this, global::android.text.AlteredCharSequence._getChars6684, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.text.AlteredCharSequence.staticClass, global::android.text.AlteredCharSequence._getChars6684, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _subSequence6685; 
		public virtual global::java.lang.CharSequence subSequence(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.AlteredCharSequence)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.AlteredCharSequence._subSequence6685, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.AlteredCharSequence.staticClass, global::android.text.AlteredCharSequence._subSequence6685, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _make6686; 
		public static global::android.text.AlteredCharSequence make(java.lang.CharSequence arg0, char[] arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.AlteredCharSequence>(@__env, @__env.CallStaticObjectMethodPtr(android.text.AlteredCharSequence.staticClass, global::android.text.AlteredCharSequence._make6686, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.AlteredCharSequence.staticClass = @__class; 
			global::android.text.AlteredCharSequence._toString6681 = @__env.GetMethodID(global::android.text.AlteredCharSequence.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.text.AlteredCharSequence._length6682 = @__env.GetMethodID(global::android.text.AlteredCharSequence.staticClass, "length", "()I"); 
			global::android.text.AlteredCharSequence._charAt6683 = @__env.GetMethodID(global::android.text.AlteredCharSequence.staticClass, "charAt", "(I)C"); 
			global::android.text.AlteredCharSequence._getChars6684 = @__env.GetMethodID(global::android.text.AlteredCharSequence.staticClass, "getChars", "(II[CI)V"); 
			global::android.text.AlteredCharSequence._subSequence6685 = @__env.GetMethodID(global::android.text.AlteredCharSequence.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;"); 
			global::android.text.AlteredCharSequence._make6686 = @__env.GetStaticMethodID(global::android.text.AlteredCharSequence.staticClass, "make", "(Ljava/lang/CharSequence;[CII)Landroid/text/AlteredCharSequence;"); 
		} 
	} 
} 
