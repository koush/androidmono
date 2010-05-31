namespace java.security 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class CodeSigner : java.lang.Object, java.io.Serializable
	{ 
		internal static global::java.lang.Class staticClass; 
		static CodeSigner() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.security.CodeSigner), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _hashCode12421; 
		public sealed override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.security.CodeSigner._hashCode12421); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.security.CodeSigner.staticClass, global::java.security.CodeSigner._hashCode12421); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals12422; 
		public sealed override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::java.security.CodeSigner._equals12422, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.security.CodeSigner.staticClass, global::java.security.CodeSigner._equals12422, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString12423; 
		public sealed override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.CodeSigner._toString12423)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.CodeSigner.staticClass, global::java.security.CodeSigner._toString12423)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSignerCertPath12424; 
		public global::java.security.cert.CertPath getSignerCertPath() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.cert.CertPath>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.CodeSigner._getSignerCertPath12424)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.cert.CertPath>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.CodeSigner.staticClass, global::java.security.CodeSigner._getSignerCertPath12424)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTimestamp12425; 
		public global::java.security.Timestamp getTimestamp() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.Timestamp>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.CodeSigner._getTimestamp12425)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.Timestamp>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.CodeSigner.staticClass, global::java.security.CodeSigner._getTimestamp12425)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CodeSigner12426; 
		public CodeSigner(java.security.cert.CertPath arg0, java.security.Timestamp arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.security.CodeSigner.staticClass, global::java.security.CodeSigner._CodeSigner12426, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.security.CodeSigner.staticClass = @__class; 
			global::java.security.CodeSigner._hashCode12421 = @__env.GetMethodID(global::java.security.CodeSigner.staticClass, "hashCode", "()I"); 
			global::java.security.CodeSigner._equals12422 = @__env.GetMethodID(global::java.security.CodeSigner.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.security.CodeSigner._toString12423 = @__env.GetMethodID(global::java.security.CodeSigner.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.security.CodeSigner._getSignerCertPath12424 = @__env.GetMethodID(global::java.security.CodeSigner.staticClass, "getSignerCertPath", "()Ljava/security/cert/CertPath;"); 
			global::java.security.CodeSigner._getTimestamp12425 = @__env.GetMethodID(global::java.security.CodeSigner.staticClass, "getTimestamp", "()Ljava/security/Timestamp;"); 
			global::java.security.CodeSigner._CodeSigner12426 = @__env.GetMethodID(global::java.security.CodeSigner.staticClass, "<init>", "(Ljava/security/cert/CertPath;Ljava/security/Timestamp;)V"); 
		} 
	} 
} 
