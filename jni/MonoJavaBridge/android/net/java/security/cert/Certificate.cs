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
		internal static global::net.sf.jni4net.jni.MethodId _hashCode11612; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.cert.Certificate)) 
				return @__env.CallIntMethod(this, _hashCode11612); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.security.cert.Certificate.staticClass, _hashCode11612); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals11613; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.cert.Certificate)) 
				return @__env.CallBooleanMethod(this, _equals11613, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.security.cert.Certificate.staticClass, _equals11613, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString11614; 
		public abstract new java.lang.String toString(); 
		internal static global::net.sf.jni4net.jni.MethodId _getType11615; 
		public virtual java.lang.String getType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.cert.Certificate)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getType11615)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.cert.Certificate.staticClass, _getType11615)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _verify11616; 
		public abstract void verify(java.security.PublicKey arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _verify11617; 
		public abstract void verify(java.security.PublicKey arg0, java.lang.String arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _getEncoded11618; 
		public abstract byte[] getEncoded(); 
		internal static global::net.sf.jni4net.jni.MethodId _getPublicKey11619; 
		public abstract java.security.PublicKey getPublicKey(); 
		internal static global::net.sf.jni4net.jni.MethodId _writeReplace11620; 
		protected virtual java.lang.Object writeReplace() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.cert.Certificate)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _writeReplace11620)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.cert.Certificate.staticClass, _writeReplace11620)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Certificate11621; 
		protected Certificate(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.security.cert.Certificate.staticClass, _Certificate11621, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.security.cert.Certificate.staticClass = @__class; 
			global::java.security.cert.Certificate._hashCode11612 = @__env.GetMethodID(global::java.security.cert.Certificate.staticClass, "hashCode", "()I"); 
			global::java.security.cert.Certificate._equals11613 = @__env.GetMethodID(global::java.security.cert.Certificate.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.security.cert.Certificate._toString11614 = @__env.GetMethodID(global::java.security.cert.Certificate.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.security.cert.Certificate._getType11615 = @__env.GetMethodID(global::java.security.cert.Certificate.staticClass, "getType", "()Ljava/lang/String;"); 
			global::java.security.cert.Certificate._verify11616 = @__env.GetMethodID(global::java.security.cert.Certificate.staticClass, "verify", "(Ljava/security/PublicKey;)V"); 
			global::java.security.cert.Certificate._verify11617 = @__env.GetMethodID(global::java.security.cert.Certificate.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V"); 
			global::java.security.cert.Certificate._getEncoded11618 = @__env.GetMethodID(global::java.security.cert.Certificate.staticClass, "getEncoded", "()[B"); 
			global::java.security.cert.Certificate._getPublicKey11619 = @__env.GetMethodID(global::java.security.cert.Certificate.staticClass, "getPublicKey", "()Ljava/security/PublicKey;"); 
			global::java.security.cert.Certificate._writeReplace11620 = @__env.GetMethodID(global::java.security.cert.Certificate.staticClass, "writeReplace", "()Ljava/lang/Object;"); 
			global::java.security.cert.Certificate._Certificate11621 = @__env.GetMethodID(global::java.security.cert.Certificate.staticClass, "<init>", "(Ljava/lang/String;)V"); 
		} 
	} 
} 
