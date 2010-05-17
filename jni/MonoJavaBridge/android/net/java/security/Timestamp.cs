namespace java.security 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class Timestamp : java.lang.Object, java.io.Serializable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Timestamp() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.security.Timestamp), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.security.Timestamp(@__env); 
			} 
		} 
		internal Timestamp(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode11596; 
		public sealed override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.Timestamp)) 
				return @__env.CallIntMethod(this, _hashCode11596); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.security.Timestamp.staticClass, _hashCode11596); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals11597; 
		public sealed override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.Timestamp)) 
				return @__env.CallBooleanMethod(this, _equals11597, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.security.Timestamp.staticClass, _equals11597, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString11598; 
		public sealed override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.Timestamp)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString11598)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.Timestamp.staticClass, _toString11598)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSignerCertPath11599; 
		public java.security.cert.CertPath getSignerCertPath() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.Timestamp)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.cert.CertPath>(@__env, @__env.CallObjectMethodPtr(this, _getSignerCertPath11599)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.cert.CertPath>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.Timestamp.staticClass, _getSignerCertPath11599)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTimestamp11600; 
		public java.util.Date getTimestamp() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.Timestamp)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Date>(@__env, @__env.CallObjectMethodPtr(this, _getTimestamp11600)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Date>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.Timestamp.staticClass, _getTimestamp11600)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Timestamp11601; 
		public Timestamp(java.util.Date arg0, java.security.cert.CertPath arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.security.Timestamp.staticClass, _Timestamp11601, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.security.Timestamp.staticClass = @__class; 
			global::java.security.Timestamp._hashCode11596 = @__env.GetMethodID(global::java.security.Timestamp.staticClass, "hashCode", "()I"); 
			global::java.security.Timestamp._equals11597 = @__env.GetMethodID(global::java.security.Timestamp.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.security.Timestamp._toString11598 = @__env.GetMethodID(global::java.security.Timestamp.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.security.Timestamp._getSignerCertPath11599 = @__env.GetMethodID(global::java.security.Timestamp.staticClass, "getSignerCertPath", "()Ljava/security/cert/CertPath;"); 
			global::java.security.Timestamp._getTimestamp11600 = @__env.GetMethodID(global::java.security.Timestamp.staticClass, "getTimestamp", "()Ljava/util/Date;"); 
			global::java.security.Timestamp._Timestamp11601 = @__env.GetMethodID(global::java.security.Timestamp.staticClass, "<init>", "(Ljava/util/Date;Ljava/security/cert/CertPath;)V"); 
		} 
	} 
} 
