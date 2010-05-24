namespace java.security.cert 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class Certificate : java.lang.Object, java.io.Serializable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Certificate() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.security.cert.Certificate), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected Certificate(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode12487; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.cert.Certificate)) 
				return @__env.CallIntMethod(this, _hashCode12487); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.security.cert.Certificate.staticClass, _hashCode12487); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals12488; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.cert.Certificate)) 
				return @__env.CallBooleanMethod(this, _equals12488, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.security.cert.Certificate.staticClass, _equals12488, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString12489; 
		public abstract new java.lang.String toString(); 
		internal static global::net.sf.jni4net.jni.MethodId _getType12490; 
		public virtual java.lang.String getType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.cert.Certificate)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getType12490)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.cert.Certificate.staticClass, _getType12490)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _verify12491; 
		public abstract void verify(java.security.PublicKey arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _verify12492; 
		public abstract void verify(java.security.PublicKey arg0, java.lang.String arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _getEncoded12493; 
		public abstract byte[] getEncoded(); 
		internal static global::net.sf.jni4net.jni.MethodId _getPublicKey12494; 
		public abstract java.security.PublicKey getPublicKey(); 
		internal static global::net.sf.jni4net.jni.MethodId _writeReplace12495; 
		protected virtual java.lang.Object writeReplace() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.cert.Certificate)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _writeReplace12495)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.cert.Certificate.staticClass, _writeReplace12495)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Certificate12496; 
		protected Certificate(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.security.cert.Certificate.staticClass, _Certificate12496, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.security.cert.Certificate.staticClass = @__class; 
			global::java.security.cert.Certificate._hashCode12487 = @__env.GetMethodID(global::java.security.cert.Certificate.staticClass, "hashCode", "()I"); 
			global::java.security.cert.Certificate._equals12488 = @__env.GetMethodID(global::java.security.cert.Certificate.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.security.cert.Certificate._toString12489 = @__env.GetMethodID(global::java.security.cert.Certificate.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.security.cert.Certificate._getType12490 = @__env.GetMethodID(global::java.security.cert.Certificate.staticClass, "getType", "()Ljava/lang/String;"); 
			global::java.security.cert.Certificate._verify12491 = @__env.GetMethodID(global::java.security.cert.Certificate.staticClass, "verify", "(Ljava/security/PublicKey;)V"); 
			global::java.security.cert.Certificate._verify12492 = @__env.GetMethodID(global::java.security.cert.Certificate.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V"); 
			global::java.security.cert.Certificate._getEncoded12493 = @__env.GetMethodID(global::java.security.cert.Certificate.staticClass, "getEncoded", "()[B"); 
			global::java.security.cert.Certificate._getPublicKey12494 = @__env.GetMethodID(global::java.security.cert.Certificate.staticClass, "getPublicKey", "()Ljava/security/PublicKey;"); 
			global::java.security.cert.Certificate._writeReplace12495 = @__env.GetMethodID(global::java.security.cert.Certificate.staticClass, "writeReplace", "()Ljava/lang/Object;"); 
			global::java.security.cert.Certificate._Certificate12496 = @__env.GetMethodID(global::java.security.cert.Certificate.staticClass, "<init>", "(Ljava/lang/String;)V"); 
		} 
	} 
} 
