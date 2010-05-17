namespace android.net.http 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SslCertificate : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static SslCertificate() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.net.http.SslCertificate), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.net.http.SslCertificate(@__env); 
			} 
		} 
		protected SslCertificate(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class DName : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static DName() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.net.http.SslCertificate.DName), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.net.http.SslCertificate.DName(@__env); 
				} 
			} 
			protected DName(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getDName4586; 
			public virtual java.lang.String getDName() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.http.SslCertificate.DName)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getDName4586)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.http.SslCertificate.DName.staticClass, _getDName4586)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getCName4587; 
			public virtual java.lang.String getCName() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.http.SslCertificate.DName)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getCName4587)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.http.SslCertificate.DName.staticClass, _getCName4587)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getOName4588; 
			public virtual java.lang.String getOName() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.http.SslCertificate.DName)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getOName4588)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.http.SslCertificate.DName.staticClass, _getOName4588)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getUName4589; 
			public virtual java.lang.String getUName() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.http.SslCertificate.DName)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getUName4589)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.http.SslCertificate.DName.staticClass, _getUName4589)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _DName4590; 
			public DName(android.net.http.SslCertificate arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.net.http.SslCertificate.DName.staticClass, _DName4590, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.net.http.SslCertificate.DName.staticClass = @__class; 
				global::android.net.http.SslCertificate.DName._getDName4586 = @__env.GetMethodID(global::android.net.http.SslCertificate.DName.staticClass, "getDName", "()Ljava/lang/String;"); 
				global::android.net.http.SslCertificate.DName._getCName4587 = @__env.GetMethodID(global::android.net.http.SslCertificate.DName.staticClass, "getCName", "()Ljava/lang/String;"); 
				global::android.net.http.SslCertificate.DName._getOName4588 = @__env.GetMethodID(global::android.net.http.SslCertificate.DName.staticClass, "getOName", "()Ljava/lang/String;"); 
				global::android.net.http.SslCertificate.DName._getUName4589 = @__env.GetMethodID(global::android.net.http.SslCertificate.DName.staticClass, "getUName", "()Ljava/lang/String;"); 
				global::android.net.http.SslCertificate.DName._DName4590 = @__env.GetMethodID(global::android.net.http.SslCertificate.DName.staticClass, "<init>", "(Landroid/net/http/SslCertificate;Ljava/lang/String;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString4591; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.http.SslCertificate)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString4591)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.http.SslCertificate.staticClass, _toString4591)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _saveState4592; 
		public static android.os.Bundle saveState(android.net.http.SslCertificate arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallStaticObjectMethodPtr(android.net.http.SslCertificate.staticClass, _saveState4592, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _restoreState4593; 
		public static android.net.http.SslCertificate restoreState(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.http.SslCertificate>(@__env, @__env.CallStaticObjectMethodPtr(android.net.http.SslCertificate.staticClass, _restoreState4593, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getValidNotBefore4594; 
		public virtual java.lang.String getValidNotBefore() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.http.SslCertificate)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getValidNotBefore4594)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.http.SslCertificate.staticClass, _getValidNotBefore4594)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getValidNotAfter4595; 
		public virtual java.lang.String getValidNotAfter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.http.SslCertificate)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getValidNotAfter4595)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.http.SslCertificate.staticClass, _getValidNotAfter4595)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIssuedTo4596; 
		public virtual android.net.http.SslCertificate.DName getIssuedTo() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.http.SslCertificate)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.http.SslCertificate.DName>(@__env, @__env.CallObjectMethodPtr(this, _getIssuedTo4596)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.http.SslCertificate.DName>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.http.SslCertificate.staticClass, _getIssuedTo4596)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIssuedBy4597; 
		public virtual android.net.http.SslCertificate.DName getIssuedBy() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.http.SslCertificate)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.http.SslCertificate.DName>(@__env, @__env.CallObjectMethodPtr(this, _getIssuedBy4597)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.http.SslCertificate.DName>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.http.SslCertificate.staticClass, _getIssuedBy4597)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SslCertificate4598; 
		public SslCertificate(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.net.http.SslCertificate.staticClass, _SslCertificate4598, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SslCertificate4599; 
		public SslCertificate(java.security.cert.X509Certificate arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.net.http.SslCertificate.staticClass, _SslCertificate4599, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.net.http.SslCertificate.staticClass = @__class; 
			global::android.net.http.SslCertificate._toString4591 = @__env.GetMethodID(global::android.net.http.SslCertificate.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.net.http.SslCertificate._saveState4592 = @__env.GetStaticMethodID(global::android.net.http.SslCertificate.staticClass, "saveState", "(Landroid/net/http/SslCertificate;)Landroid/os/Bundle;"); 
			global::android.net.http.SslCertificate._restoreState4593 = @__env.GetStaticMethodID(global::android.net.http.SslCertificate.staticClass, "restoreState", "(Landroid/os/Bundle;)Landroid/net/http/SslCertificate;"); 
			global::android.net.http.SslCertificate._getValidNotBefore4594 = @__env.GetMethodID(global::android.net.http.SslCertificate.staticClass, "getValidNotBefore", "()Ljava/lang/String;"); 
			global::android.net.http.SslCertificate._getValidNotAfter4595 = @__env.GetMethodID(global::android.net.http.SslCertificate.staticClass, "getValidNotAfter", "()Ljava/lang/String;"); 
			global::android.net.http.SslCertificate._getIssuedTo4596 = @__env.GetMethodID(global::android.net.http.SslCertificate.staticClass, "getIssuedTo", "()Landroid/net/http/SslCertificate$DName;"); 
			global::android.net.http.SslCertificate._getIssuedBy4597 = @__env.GetMethodID(global::android.net.http.SslCertificate.staticClass, "getIssuedBy", "()Landroid/net/http/SslCertificate$DName;"); 
			global::android.net.http.SslCertificate._SslCertificate4598 = @__env.GetMethodID(global::android.net.http.SslCertificate.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.net.http.SslCertificate._SslCertificate4599 = @__env.GetMethodID(global::android.net.http.SslCertificate.staticClass, "<init>", "(Ljava/security/cert/X509Certificate;)V"); 
		} 
	} 
} 
