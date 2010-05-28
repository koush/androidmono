namespace android.net.http 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SslCertificate : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static SslCertificate() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.net.http.SslCertificate), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.net.http.SslCertificate.DName), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _getDName4835; 
			public virtual global::java.lang.String getDName() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.http.SslCertificate.DName)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.http.SslCertificate.DName._getDName4835)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.http.SslCertificate.DName.staticClass, global::android.net.http.SslCertificate.DName._getDName4835)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getCName4836; 
			public virtual global::java.lang.String getCName() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.http.SslCertificate.DName)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.http.SslCertificate.DName._getCName4836)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.http.SslCertificate.DName.staticClass, global::android.net.http.SslCertificate.DName._getCName4836)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getOName4837; 
			public virtual global::java.lang.String getOName() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.http.SslCertificate.DName)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.http.SslCertificate.DName._getOName4837)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.http.SslCertificate.DName.staticClass, global::android.net.http.SslCertificate.DName._getOName4837)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getUName4838; 
			public virtual global::java.lang.String getUName() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.http.SslCertificate.DName)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.http.SslCertificate.DName._getUName4838)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.http.SslCertificate.DName.staticClass, global::android.net.http.SslCertificate.DName._getUName4838)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _DName4839; 
			public DName(android.net.http.SslCertificate arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.net.http.SslCertificate.DName.staticClass, global::android.net.http.SslCertificate.DName._DName4839, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.net.http.SslCertificate.DName.staticClass = @__class; 
				global::android.net.http.SslCertificate.DName._getDName4835 = @__env.GetMethodID(global::android.net.http.SslCertificate.DName.staticClass, "getDName", "()Ljava/lang/String;"); 
				global::android.net.http.SslCertificate.DName._getCName4836 = @__env.GetMethodID(global::android.net.http.SslCertificate.DName.staticClass, "getCName", "()Ljava/lang/String;"); 
				global::android.net.http.SslCertificate.DName._getOName4837 = @__env.GetMethodID(global::android.net.http.SslCertificate.DName.staticClass, "getOName", "()Ljava/lang/String;"); 
				global::android.net.http.SslCertificate.DName._getUName4838 = @__env.GetMethodID(global::android.net.http.SslCertificate.DName.staticClass, "getUName", "()Ljava/lang/String;"); 
				global::android.net.http.SslCertificate.DName._DName4839 = @__env.GetMethodID(global::android.net.http.SslCertificate.DName.staticClass, "<init>", "(Landroid/net/http/SslCertificate;Ljava/lang/String;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString4840; 
		public override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.http.SslCertificate)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.http.SslCertificate._toString4840)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._toString4840)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _saveState4841; 
		public static global::android.os.Bundle saveState(android.net.http.SslCertificate arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallStaticObjectMethodPtr(android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._saveState4841, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _restoreState4842; 
		public static global::android.net.http.SslCertificate restoreState(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.http.SslCertificate>(@__env, @__env.CallStaticObjectMethodPtr(android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._restoreState4842, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getValidNotBefore4843; 
		public virtual global::java.lang.String getValidNotBefore() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.http.SslCertificate)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.http.SslCertificate._getValidNotBefore4843)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._getValidNotBefore4843)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getValidNotAfter4844; 
		public virtual global::java.lang.String getValidNotAfter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.http.SslCertificate)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.http.SslCertificate._getValidNotAfter4844)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._getValidNotAfter4844)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIssuedTo4845; 
		public virtual global::android.net.http.SslCertificate.DName getIssuedTo() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.http.SslCertificate)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.http.SslCertificate.DName>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.http.SslCertificate._getIssuedTo4845)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.http.SslCertificate.DName>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._getIssuedTo4845)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIssuedBy4846; 
		public virtual global::android.net.http.SslCertificate.DName getIssuedBy() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.http.SslCertificate)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.http.SslCertificate.DName>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.http.SslCertificate._getIssuedBy4846)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.http.SslCertificate.DName>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._getIssuedBy4846)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SslCertificate4847; 
		public SslCertificate(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._SslCertificate4847, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SslCertificate4848; 
		public SslCertificate(java.security.cert.X509Certificate arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.net.http.SslCertificate.staticClass, global::android.net.http.SslCertificate._SslCertificate4848, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.net.http.SslCertificate.staticClass = @__class; 
			global::android.net.http.SslCertificate._toString4840 = @__env.GetMethodID(global::android.net.http.SslCertificate.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.net.http.SslCertificate._saveState4841 = @__env.GetStaticMethodID(global::android.net.http.SslCertificate.staticClass, "saveState", "(Landroid/net/http/SslCertificate;)Landroid/os/Bundle;"); 
			global::android.net.http.SslCertificate._restoreState4842 = @__env.GetStaticMethodID(global::android.net.http.SslCertificate.staticClass, "restoreState", "(Landroid/os/Bundle;)Landroid/net/http/SslCertificate;"); 
			global::android.net.http.SslCertificate._getValidNotBefore4843 = @__env.GetMethodID(global::android.net.http.SslCertificate.staticClass, "getValidNotBefore", "()Ljava/lang/String;"); 
			global::android.net.http.SslCertificate._getValidNotAfter4844 = @__env.GetMethodID(global::android.net.http.SslCertificate.staticClass, "getValidNotAfter", "()Ljava/lang/String;"); 
			global::android.net.http.SslCertificate._getIssuedTo4845 = @__env.GetMethodID(global::android.net.http.SslCertificate.staticClass, "getIssuedTo", "()Landroid/net/http/SslCertificate$DName;"); 
			global::android.net.http.SslCertificate._getIssuedBy4846 = @__env.GetMethodID(global::android.net.http.SslCertificate.staticClass, "getIssuedBy", "()Landroid/net/http/SslCertificate$DName;"); 
			global::android.net.http.SslCertificate._SslCertificate4847 = @__env.GetMethodID(global::android.net.http.SslCertificate.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.net.http.SslCertificate._SslCertificate4848 = @__env.GetMethodID(global::android.net.http.SslCertificate.staticClass, "<init>", "(Ljava/security/cert/X509Certificate;)V"); 
		} 
	} 
} 
