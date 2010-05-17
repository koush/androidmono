namespace java.security 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class CodeSource : java.lang.Object, java.io.Serializable
	{ 
		internal static global::java.lang.Class staticClass; 
		static CodeSource() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.security.CodeSource), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.security.CodeSource(@__env); 
			} 
		} 
		protected CodeSource(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode11563; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.CodeSource)) 
				return @__env.CallIntMethod(this, _hashCode11563); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.security.CodeSource.staticClass, _hashCode11563); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals11564; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.CodeSource)) 
				return @__env.CallBooleanMethod(this, _equals11564, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.security.CodeSource.staticClass, _equals11564, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString11565; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.CodeSource)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString11565)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.CodeSource.staticClass, _toString11565)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocation11566; 
		public virtual java.net.URL getLocation() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.CodeSource)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URL>(@__env, @__env.CallObjectMethodPtr(this, _getLocation11566)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URL>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.CodeSource.staticClass, _getLocation11566)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCertificates11567; 
		public virtual java.security.cert.Certificate[] getCertificates() 
		{ 
			if (GetType() == typeof(java.security.CodeSource)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getCertificates11567)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.CodeSource.staticClass, _getCertificates11567)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _implies11568; 
		public virtual bool implies(java.security.CodeSource arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.CodeSource)) 
				return @__env.CallBooleanMethod(this, _implies11568, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.security.CodeSource.staticClass, _implies11568, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCodeSigners11569; 
		public virtual java.security.CodeSigner[] getCodeSigners() 
		{ 
			if (GetType() == typeof(java.security.CodeSource)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getCodeSigners11569)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.CodeSource.staticClass, _getCodeSigners11569)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CodeSource11570; 
		public CodeSource(java.net.URL arg0, java.security.cert.Certificate[] arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.security.CodeSource.staticClass, _CodeSource11570, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CodeSource11571; 
		public CodeSource(java.net.URL arg0, java.security.CodeSigner[] arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.security.CodeSource.staticClass, _CodeSource11571, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.security.CodeSource.staticClass = @__class; 
			global::java.security.CodeSource._hashCode11563 = @__env.GetMethodID(global::java.security.CodeSource.staticClass, "hashCode", "()I"); 
			global::java.security.CodeSource._equals11564 = @__env.GetMethodID(global::java.security.CodeSource.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.security.CodeSource._toString11565 = @__env.GetMethodID(global::java.security.CodeSource.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.security.CodeSource._getLocation11566 = @__env.GetMethodID(global::java.security.CodeSource.staticClass, "getLocation", "()Ljava/net/URL;"); 
			global::java.security.CodeSource._getCertificates11567 = @__env.GetMethodID(global::java.security.CodeSource.staticClass, "getCertificates", "()[Ljava/security/cert/Certificate;"); 
			global::java.security.CodeSource._implies11568 = @__env.GetMethodID(global::java.security.CodeSource.staticClass, "implies", "(Ljava/security/CodeSource;)Z"); 
			global::java.security.CodeSource._getCodeSigners11569 = @__env.GetMethodID(global::java.security.CodeSource.staticClass, "getCodeSigners", "()[Ljava/security/CodeSigner;"); 
			global::java.security.CodeSource._CodeSource11570 = @__env.GetMethodID(global::java.security.CodeSource.staticClass, "<init>", "(Ljava/net/URL;[Ljava/security/cert/Certificate;)V"); 
			global::java.security.CodeSource._CodeSource11571 = @__env.GetMethodID(global::java.security.CodeSource.staticClass, "<init>", "(Ljava/net/URL;[Ljava/security/CodeSigner;)V"); 
		} 
	} 
} 
