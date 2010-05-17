namespace java.security 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class CodeSigner : java.lang.Object, java.io.Serializable
	{ 
		internal static global::java.lang.Class staticClass; 
		static CodeSigner() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.security.CodeSigner), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.security.CodeSigner(@__env); 
			} 
		} 
		internal CodeSigner(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode11557; 
		public sealed override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.CodeSigner)) 
				return @__env.CallIntMethod(this, _hashCode11557); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.security.CodeSigner.staticClass, _hashCode11557); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals11558; 
		public sealed override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.CodeSigner)) 
				return @__env.CallBooleanMethod(this, _equals11558, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.security.CodeSigner.staticClass, _equals11558, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString11559; 
		public sealed override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.CodeSigner)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString11559)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.CodeSigner.staticClass, _toString11559)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSignerCertPath11560; 
		public java.security.cert.CertPath getSignerCertPath() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.CodeSigner)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.cert.CertPath>(@__env, @__env.CallObjectMethodPtr(this, _getSignerCertPath11560)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.cert.CertPath>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.CodeSigner.staticClass, _getSignerCertPath11560)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTimestamp11561; 
		public java.security.Timestamp getTimestamp() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.CodeSigner)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.Timestamp>(@__env, @__env.CallObjectMethodPtr(this, _getTimestamp11561)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.Timestamp>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.CodeSigner.staticClass, _getTimestamp11561)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CodeSigner11562; 
		public CodeSigner(java.security.cert.CertPath arg0, java.security.Timestamp arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.security.CodeSigner.staticClass, _CodeSigner11562, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.security.CodeSigner.staticClass = @__class; 
			global::java.security.CodeSigner._hashCode11557 = @__env.GetMethodID(global::java.security.CodeSigner.staticClass, "hashCode", "()I"); 
			global::java.security.CodeSigner._equals11558 = @__env.GetMethodID(global::java.security.CodeSigner.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.security.CodeSigner._toString11559 = @__env.GetMethodID(global::java.security.CodeSigner.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.security.CodeSigner._getSignerCertPath11560 = @__env.GetMethodID(global::java.security.CodeSigner.staticClass, "getSignerCertPath", "()Ljava/security/cert/CertPath;"); 
			global::java.security.CodeSigner._getTimestamp11561 = @__env.GetMethodID(global::java.security.CodeSigner.staticClass, "getTimestamp", "()Ljava/security/Timestamp;"); 
			global::java.security.CodeSigner._CodeSigner11562 = @__env.GetMethodID(global::java.security.CodeSigner.staticClass, "<init>", "(Ljava/security/cert/CertPath;Ljava/security/Timestamp;)V"); 
		} 
	} 
} 
