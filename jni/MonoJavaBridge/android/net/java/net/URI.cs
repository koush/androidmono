namespace java.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class URI : java.lang.Object, java.lang.Comparable, java.io.Serializable
	{ 
		internal static global::java.lang.Class staticClass; 
		static URI() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.net.URI), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.net.URI(@__env); 
			} 
		} 
		internal URI(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode11897; 
		public sealed override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return @__env.CallIntMethod(this, global::java.net.URI._hashCode11897); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.net.URI.staticClass, global::java.net.URI._hashCode11897); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals11898; 
		public sealed override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return @__env.CallBooleanMethod(this, global::java.net.URI._equals11898, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.net.URI.staticClass, global::java.net.URI._equals11898, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo11899; 
		public int compareTo(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return @__env.CallIntMethod(this, global::java.net.URI._compareTo11899, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.net.URI.staticClass, global::java.net.URI._compareTo11899, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo11900; 
		public int compareTo(java.net.URI arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return @__env.CallIntMethod(this, global::java.net.URI._compareTo11900, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.net.URI.staticClass, global::java.net.URI._compareTo11900, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString11901; 
		public sealed override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URI._toString11901)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.URI.staticClass, global::java.net.URI._toString11901)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAbsolute11902; 
		public bool isAbsolute() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return @__env.CallBooleanMethod(this, global::java.net.URI._isAbsolute11902); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.net.URI.staticClass, global::java.net.URI._isAbsolute11902); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPath11903; 
		public global::java.lang.String getPath() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URI._getPath11903)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.URI.staticClass, global::java.net.URI._getPath11903)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toURL11904; 
		public global::java.net.URL toURL() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URL>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URI._toURL11904)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URL>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.URI.staticClass, global::java.net.URI._toURL11904)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resolve11905; 
		public global::java.net.URI resolve(java.net.URI arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URI>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URI._resolve11905, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URI>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.URI.staticClass, global::java.net.URI._resolve11905, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resolve11906; 
		public global::java.net.URI resolve(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URI>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URI._resolve11906, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URI>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.URI.staticClass, global::java.net.URI._resolve11906, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _normalize11907; 
		public global::java.net.URI normalize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URI>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URI._normalize11907)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URI>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.URI.staticClass, global::java.net.URI._normalize11907)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isOpaque11908; 
		public bool isOpaque() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return @__env.CallBooleanMethod(this, global::java.net.URI._isOpaque11908); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.net.URI.staticClass, global::java.net.URI._isOpaque11908); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScheme11909; 
		public global::java.lang.String getScheme() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URI._getScheme11909)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.URI.staticClass, global::java.net.URI._getScheme11909)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAuthority11910; 
		public global::java.lang.String getAuthority() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URI._getAuthority11910)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.URI.staticClass, global::java.net.URI._getAuthority11910)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFragment11911; 
		public global::java.lang.String getFragment() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URI._getFragment11911)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.URI.staticClass, global::java.net.URI._getFragment11911)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getQuery11912; 
		public global::java.lang.String getQuery() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URI._getQuery11912)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.URI.staticClass, global::java.net.URI._getQuery11912)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUserInfo11913; 
		public global::java.lang.String getUserInfo() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URI._getUserInfo11913)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.URI.staticClass, global::java.net.URI._getUserInfo11913)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPort11914; 
		public int getPort() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return @__env.CallIntMethod(this, global::java.net.URI._getPort11914); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.net.URI.staticClass, global::java.net.URI._getPort11914); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHost11915; 
		public global::java.lang.String getHost() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URI._getHost11915)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.URI.staticClass, global::java.net.URI._getHost11915)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _create11916; 
		public static global::java.net.URI create(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URI>(@__env, @__env.CallStaticObjectMethodPtr(java.net.URI.staticClass, global::java.net.URI._create11916, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSchemeSpecificPart11917; 
		public global::java.lang.String getSchemeSpecificPart() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URI._getSchemeSpecificPart11917)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.URI.staticClass, global::java.net.URI._getSchemeSpecificPart11917)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _parseServerAuthority11918; 
		public global::java.net.URI parseServerAuthority() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URI>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URI._parseServerAuthority11918)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URI>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.URI.staticClass, global::java.net.URI._parseServerAuthority11918)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _relativize11919; 
		public global::java.net.URI relativize(java.net.URI arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URI>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URI._relativize11919, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URI>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.URI.staticClass, global::java.net.URI._relativize11919, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRawSchemeSpecificPart11920; 
		public global::java.lang.String getRawSchemeSpecificPart() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URI._getRawSchemeSpecificPart11920)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.URI.staticClass, global::java.net.URI._getRawSchemeSpecificPart11920)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRawAuthority11921; 
		public global::java.lang.String getRawAuthority() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URI._getRawAuthority11921)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.URI.staticClass, global::java.net.URI._getRawAuthority11921)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRawUserInfo11922; 
		public global::java.lang.String getRawUserInfo() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URI._getRawUserInfo11922)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.URI.staticClass, global::java.net.URI._getRawUserInfo11922)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRawPath11923; 
		public global::java.lang.String getRawPath() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URI._getRawPath11923)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.URI.staticClass, global::java.net.URI._getRawPath11923)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRawQuery11924; 
		public global::java.lang.String getRawQuery() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URI._getRawQuery11924)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.URI.staticClass, global::java.net.URI._getRawQuery11924)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRawFragment11925; 
		public global::java.lang.String getRawFragment() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URI._getRawFragment11925)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.URI.staticClass, global::java.net.URI._getRawFragment11925)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toASCIIString11926; 
		public global::java.lang.String toASCIIString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URI._toASCIIString11926)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.URI.staticClass, global::java.net.URI._toASCIIString11926)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _URI11927; 
		public URI(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, int arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String arg6)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.URI.staticClass, global::java.net.URI._URI11927, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _URI11928; 
		public URI(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.URI.staticClass, global::java.net.URI._URI11928, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _URI11929; 
		public URI(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.URI.staticClass, global::java.net.URI._URI11929, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _URI11930; 
		public URI(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.URI.staticClass, global::java.net.URI._URI11930, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _URI11931; 
		public URI(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.URI.staticClass, global::java.net.URI._URI11931, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.net.URI.staticClass = @__class; 
			global::java.net.URI._hashCode11897 = @__env.GetMethodID(global::java.net.URI.staticClass, "hashCode", "()I"); 
			global::java.net.URI._equals11898 = @__env.GetMethodID(global::java.net.URI.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.net.URI._compareTo11899 = @__env.GetMethodID(global::java.net.URI.staticClass, "compareTo", "(Ljava/lang/Object;)I"); 
			global::java.net.URI._compareTo11900 = @__env.GetMethodID(global::java.net.URI.staticClass, "compareTo", "(Ljava/net/URI;)I"); 
			global::java.net.URI._toString11901 = @__env.GetMethodID(global::java.net.URI.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.net.URI._isAbsolute11902 = @__env.GetMethodID(global::java.net.URI.staticClass, "isAbsolute", "()Z"); 
			global::java.net.URI._getPath11903 = @__env.GetMethodID(global::java.net.URI.staticClass, "getPath", "()Ljava/lang/String;"); 
			global::java.net.URI._toURL11904 = @__env.GetMethodID(global::java.net.URI.staticClass, "toURL", "()Ljava/net/URL;"); 
			global::java.net.URI._resolve11905 = @__env.GetMethodID(global::java.net.URI.staticClass, "resolve", "(Ljava/net/URI;)Ljava/net/URI;"); 
			global::java.net.URI._resolve11906 = @__env.GetMethodID(global::java.net.URI.staticClass, "resolve", "(Ljava/lang/String;)Ljava/net/URI;"); 
			global::java.net.URI._normalize11907 = @__env.GetMethodID(global::java.net.URI.staticClass, "normalize", "()Ljava/net/URI;"); 
			global::java.net.URI._isOpaque11908 = @__env.GetMethodID(global::java.net.URI.staticClass, "isOpaque", "()Z"); 
			global::java.net.URI._getScheme11909 = @__env.GetMethodID(global::java.net.URI.staticClass, "getScheme", "()Ljava/lang/String;"); 
			global::java.net.URI._getAuthority11910 = @__env.GetMethodID(global::java.net.URI.staticClass, "getAuthority", "()Ljava/lang/String;"); 
			global::java.net.URI._getFragment11911 = @__env.GetMethodID(global::java.net.URI.staticClass, "getFragment", "()Ljava/lang/String;"); 
			global::java.net.URI._getQuery11912 = @__env.GetMethodID(global::java.net.URI.staticClass, "getQuery", "()Ljava/lang/String;"); 
			global::java.net.URI._getUserInfo11913 = @__env.GetMethodID(global::java.net.URI.staticClass, "getUserInfo", "()Ljava/lang/String;"); 
			global::java.net.URI._getPort11914 = @__env.GetMethodID(global::java.net.URI.staticClass, "getPort", "()I"); 
			global::java.net.URI._getHost11915 = @__env.GetMethodID(global::java.net.URI.staticClass, "getHost", "()Ljava/lang/String;"); 
			global::java.net.URI._create11916 = @__env.GetStaticMethodID(global::java.net.URI.staticClass, "create", "(Ljava/lang/String;)Ljava/net/URI;"); 
			global::java.net.URI._getSchemeSpecificPart11917 = @__env.GetMethodID(global::java.net.URI.staticClass, "getSchemeSpecificPart", "()Ljava/lang/String;"); 
			global::java.net.URI._parseServerAuthority11918 = @__env.GetMethodID(global::java.net.URI.staticClass, "parseServerAuthority", "()Ljava/net/URI;"); 
			global::java.net.URI._relativize11919 = @__env.GetMethodID(global::java.net.URI.staticClass, "relativize", "(Ljava/net/URI;)Ljava/net/URI;"); 
			global::java.net.URI._getRawSchemeSpecificPart11920 = @__env.GetMethodID(global::java.net.URI.staticClass, "getRawSchemeSpecificPart", "()Ljava/lang/String;"); 
			global::java.net.URI._getRawAuthority11921 = @__env.GetMethodID(global::java.net.URI.staticClass, "getRawAuthority", "()Ljava/lang/String;"); 
			global::java.net.URI._getRawUserInfo11922 = @__env.GetMethodID(global::java.net.URI.staticClass, "getRawUserInfo", "()Ljava/lang/String;"); 
			global::java.net.URI._getRawPath11923 = @__env.GetMethodID(global::java.net.URI.staticClass, "getRawPath", "()Ljava/lang/String;"); 
			global::java.net.URI._getRawQuery11924 = @__env.GetMethodID(global::java.net.URI.staticClass, "getRawQuery", "()Ljava/lang/String;"); 
			global::java.net.URI._getRawFragment11925 = @__env.GetMethodID(global::java.net.URI.staticClass, "getRawFragment", "()Ljava/lang/String;"); 
			global::java.net.URI._toASCIIString11926 = @__env.GetMethodID(global::java.net.URI.staticClass, "toASCIIString", "()Ljava/lang/String;"); 
			global::java.net.URI._URI11927 = @__env.GetMethodID(global::java.net.URI.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"); 
			global::java.net.URI._URI11928 = @__env.GetMethodID(global::java.net.URI.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"); 
			global::java.net.URI._URI11929 = @__env.GetMethodID(global::java.net.URI.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"); 
			global::java.net.URI._URI11930 = @__env.GetMethodID(global::java.net.URI.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"); 
			global::java.net.URI._URI11931 = @__env.GetMethodID(global::java.net.URI.staticClass, "<init>", "(Ljava/lang/String;)V"); 
		} 
	} 
} 
