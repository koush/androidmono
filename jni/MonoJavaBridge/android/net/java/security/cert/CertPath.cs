namespace java.security.cert 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class CertPath : java.lang.Object, java.io.Serializable
	{ 
		internal static global::java.lang.Class staticClass; 
		static CertPath() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.security.cert.CertPath), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected CertPath(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode11602; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.cert.CertPath)) 
				return @__env.CallIntMethod(this, _hashCode11602); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.security.cert.CertPath.staticClass, _hashCode11602); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals11603; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.cert.CertPath)) 
				return @__env.CallBooleanMethod(this, _equals11603, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.security.cert.CertPath.staticClass, _equals11603, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString11604; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.cert.CertPath)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString11604)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.cert.CertPath.staticClass, _toString11604)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCertificates11605; 
		public abstract java.util.List getCertificates(); 
		internal static global::net.sf.jni4net.jni.MethodId _getType11606; 
		public virtual java.lang.String getType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.cert.CertPath)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getType11606)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.cert.CertPath.staticClass, _getType11606)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEncoded11607; 
		public abstract byte[] getEncoded(); 
		internal static global::net.sf.jni4net.jni.MethodId _getEncoded11608; 
		public abstract byte[] getEncoded(java.lang.String arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _writeReplace11609; 
		protected virtual java.lang.Object writeReplace() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.cert.CertPath)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _writeReplace11609)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.cert.CertPath.staticClass, _writeReplace11609)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEncodings11610; 
		public abstract java.util.Iterator getEncodings(); 
		internal static global::net.sf.jni4net.jni.MethodId _CertPath11611; 
		protected CertPath(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.security.cert.CertPath.staticClass, _CertPath11611, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.security.cert.CertPath.staticClass = @__class; 
			global::java.security.cert.CertPath._hashCode11602 = @__env.GetMethodID(global::java.security.cert.CertPath.staticClass, "hashCode", "()I"); 
			global::java.security.cert.CertPath._equals11603 = @__env.GetMethodID(global::java.security.cert.CertPath.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.security.cert.CertPath._toString11604 = @__env.GetMethodID(global::java.security.cert.CertPath.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.security.cert.CertPath._getCertificates11605 = @__env.GetMethodID(global::java.security.cert.CertPath.staticClass, "getCertificates", "()Ljava/util/List;"); 
			global::java.security.cert.CertPath._getType11606 = @__env.GetMethodID(global::java.security.cert.CertPath.staticClass, "getType", "()Ljava/lang/String;"); 
			global::java.security.cert.CertPath._getEncoded11607 = @__env.GetMethodID(global::java.security.cert.CertPath.staticClass, "getEncoded", "()[B"); 
			global::java.security.cert.CertPath._getEncoded11608 = @__env.GetMethodID(global::java.security.cert.CertPath.staticClass, "getEncoded", "(Ljava/lang/String;)[B"); 
			global::java.security.cert.CertPath._writeReplace11609 = @__env.GetMethodID(global::java.security.cert.CertPath.staticClass, "writeReplace", "()Ljava/lang/Object;"); 
			global::java.security.cert.CertPath._getEncodings11610 = @__env.GetMethodID(global::java.security.cert.CertPath.staticClass, "getEncodings", "()Ljava/util/Iterator;"); 
			global::java.security.cert.CertPath._CertPath11611 = @__env.GetMethodID(global::java.security.cert.CertPath.staticClass, "<init>", "(Ljava/lang/String;)V"); 
		} 
	} 
} 
