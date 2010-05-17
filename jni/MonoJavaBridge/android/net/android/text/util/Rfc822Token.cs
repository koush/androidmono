namespace android.text.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Rfc822Token : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Rfc822Token() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.util.Rfc822Token), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.util.Rfc822Token(@__env); 
			} 
		} 
		protected Rfc822Token(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode7105; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.util.Rfc822Token)) 
				return @__env.CallIntMethod(this, _hashCode7105); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.util.Rfc822Token.staticClass, _hashCode7105); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals7106; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.util.Rfc822Token)) 
				return @__env.CallBooleanMethod(this, _equals7106, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.util.Rfc822Token.staticClass, _equals7106, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAddress7107; 
		public virtual java.lang.String getAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.util.Rfc822Token)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getAddress7107)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.util.Rfc822Token.staticClass, _getAddress7107)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString7108; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.util.Rfc822Token)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString7108)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.util.Rfc822Token.staticClass, _toString7108)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getName7109; 
		public virtual java.lang.String getName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.util.Rfc822Token)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getName7109)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.util.Rfc822Token.staticClass, _getName7109)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setName7110; 
		public virtual void setName(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.util.Rfc822Token)) 
				@__env.CallVoidMethod(this, _setName7110, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.util.Rfc822Token.staticClass, _setName7110, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setComment7111; 
		public virtual void setComment(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.util.Rfc822Token)) 
				@__env.CallVoidMethod(this, _setComment7111, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.util.Rfc822Token.staticClass, _setComment7111, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getComment7112; 
		public virtual java.lang.String getComment() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.util.Rfc822Token)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getComment7112)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.util.Rfc822Token.staticClass, _getComment7112)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAddress7113; 
		public virtual void setAddress(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.util.Rfc822Token)) 
				@__env.CallVoidMethod(this, _setAddress7113, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.util.Rfc822Token.staticClass, _setAddress7113, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _quoteNameIfNecessary7114; 
		public static java.lang.String quoteNameIfNecessary(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.text.util.Rfc822Token.staticClass, _quoteNameIfNecessary7114, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _quoteName7115; 
		public static java.lang.String quoteName(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.text.util.Rfc822Token.staticClass, _quoteName7115, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _quoteComment7116; 
		public static java.lang.String quoteComment(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.text.util.Rfc822Token.staticClass, _quoteComment7116, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Rfc822Token7117; 
		public Rfc822Token(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.util.Rfc822Token.staticClass, _Rfc822Token7117, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.util.Rfc822Token.staticClass = @__class; 
			global::android.text.util.Rfc822Token._hashCode7105 = @__env.GetMethodID(global::android.text.util.Rfc822Token.staticClass, "hashCode", "()I"); 
			global::android.text.util.Rfc822Token._equals7106 = @__env.GetMethodID(global::android.text.util.Rfc822Token.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::android.text.util.Rfc822Token._getAddress7107 = @__env.GetMethodID(global::android.text.util.Rfc822Token.staticClass, "getAddress", "()Ljava/lang/String;"); 
			global::android.text.util.Rfc822Token._toString7108 = @__env.GetMethodID(global::android.text.util.Rfc822Token.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.text.util.Rfc822Token._getName7109 = @__env.GetMethodID(global::android.text.util.Rfc822Token.staticClass, "getName", "()Ljava/lang/String;"); 
			global::android.text.util.Rfc822Token._setName7110 = @__env.GetMethodID(global::android.text.util.Rfc822Token.staticClass, "setName", "(Ljava/lang/String;)V"); 
			global::android.text.util.Rfc822Token._setComment7111 = @__env.GetMethodID(global::android.text.util.Rfc822Token.staticClass, "setComment", "(Ljava/lang/String;)V"); 
			global::android.text.util.Rfc822Token._getComment7112 = @__env.GetMethodID(global::android.text.util.Rfc822Token.staticClass, "getComment", "()Ljava/lang/String;"); 
			global::android.text.util.Rfc822Token._setAddress7113 = @__env.GetMethodID(global::android.text.util.Rfc822Token.staticClass, "setAddress", "(Ljava/lang/String;)V"); 
			global::android.text.util.Rfc822Token._quoteNameIfNecessary7114 = @__env.GetStaticMethodID(global::android.text.util.Rfc822Token.staticClass, "quoteNameIfNecessary", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.text.util.Rfc822Token._quoteName7115 = @__env.GetStaticMethodID(global::android.text.util.Rfc822Token.staticClass, "quoteName", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.text.util.Rfc822Token._quoteComment7116 = @__env.GetStaticMethodID(global::android.text.util.Rfc822Token.staticClass, "quoteComment", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.text.util.Rfc822Token._Rfc822Token7117 = @__env.GetMethodID(global::android.text.util.Rfc822Token.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"); 
		} 
	} 
} 
