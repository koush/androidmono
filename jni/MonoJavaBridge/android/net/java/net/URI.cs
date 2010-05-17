namespace java.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class URI : java.lang.Object, java.lang.Comparable, java.io.Serializable
	{ 
		internal static global::java.lang.Class staticClass; 
		static URI() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.net.URI), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _hashCode11066; 
		public sealed override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return @__env.CallIntMethod(this, _hashCode11066); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.URI.staticClass, _hashCode11066); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals11067; 
		public sealed override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return @__env.CallBooleanMethod(this, _equals11067, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.URI.staticClass, _equals11067, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo11068; 
		public int compareTo(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return @__env.CallIntMethod(this, _compareTo11068, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.URI.staticClass, _compareTo11068, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo11069; 
		public int compareTo(java.net.URI arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return @__env.CallIntMethod(this, _compareTo11069, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.URI.staticClass, _compareTo11069, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString11070; 
		public sealed override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString11070)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URI.staticClass, _toString11070)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAbsolute11071; 
		public bool isAbsolute() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return @__env.CallBooleanMethod(this, _isAbsolute11071); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.URI.staticClass, _isAbsolute11071); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPath11072; 
		public java.lang.String getPath() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getPath11072)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URI.staticClass, _getPath11072)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toURL11073; 
		public java.net.URL toURL() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URL>(@__env, @__env.CallObjectMethodPtr(this, _toURL11073)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URL>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URI.staticClass, _toURL11073)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resolve11074; 
		public java.net.URI resolve(java.net.URI arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URI>(@__env, @__env.CallObjectMethodPtr(this, _resolve11074, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URI>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URI.staticClass, _resolve11074, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resolve11075; 
		public java.net.URI resolve(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URI>(@__env, @__env.CallObjectMethodPtr(this, _resolve11075, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URI>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URI.staticClass, _resolve11075, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _normalize11076; 
		public java.net.URI normalize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URI>(@__env, @__env.CallObjectMethodPtr(this, _normalize11076)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URI>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URI.staticClass, _normalize11076)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isOpaque11077; 
		public bool isOpaque() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return @__env.CallBooleanMethod(this, _isOpaque11077); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.URI.staticClass, _isOpaque11077); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScheme11078; 
		public java.lang.String getScheme() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getScheme11078)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URI.staticClass, _getScheme11078)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAuthority11079; 
		public java.lang.String getAuthority() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getAuthority11079)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URI.staticClass, _getAuthority11079)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFragment11080; 
		public java.lang.String getFragment() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getFragment11080)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URI.staticClass, _getFragment11080)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getQuery11081; 
		public java.lang.String getQuery() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getQuery11081)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URI.staticClass, _getQuery11081)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUserInfo11082; 
		public java.lang.String getUserInfo() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getUserInfo11082)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URI.staticClass, _getUserInfo11082)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPort11083; 
		public int getPort() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return @__env.CallIntMethod(this, _getPort11083); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.URI.staticClass, _getPort11083); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHost11084; 
		public java.lang.String getHost() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getHost11084)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URI.staticClass, _getHost11084)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _create11085; 
		public static java.net.URI create(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URI>(@__env, @__env.CallStaticObjectMethodPtr(java.net.URI.staticClass, _create11085, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSchemeSpecificPart11086; 
		public java.lang.String getSchemeSpecificPart() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getSchemeSpecificPart11086)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URI.staticClass, _getSchemeSpecificPart11086)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _parseServerAuthority11087; 
		public java.net.URI parseServerAuthority() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URI>(@__env, @__env.CallObjectMethodPtr(this, _parseServerAuthority11087)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URI>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URI.staticClass, _parseServerAuthority11087)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _relativize11088; 
		public java.net.URI relativize(java.net.URI arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URI>(@__env, @__env.CallObjectMethodPtr(this, _relativize11088, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URI>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URI.staticClass, _relativize11088, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRawSchemeSpecificPart11089; 
		public java.lang.String getRawSchemeSpecificPart() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getRawSchemeSpecificPart11089)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URI.staticClass, _getRawSchemeSpecificPart11089)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRawAuthority11090; 
		public java.lang.String getRawAuthority() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getRawAuthority11090)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URI.staticClass, _getRawAuthority11090)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRawUserInfo11091; 
		public java.lang.String getRawUserInfo() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getRawUserInfo11091)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URI.staticClass, _getRawUserInfo11091)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRawPath11092; 
		public java.lang.String getRawPath() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getRawPath11092)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URI.staticClass, _getRawPath11092)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRawQuery11093; 
		public java.lang.String getRawQuery() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getRawQuery11093)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URI.staticClass, _getRawQuery11093)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRawFragment11094; 
		public java.lang.String getRawFragment() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getRawFragment11094)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URI.staticClass, _getRawFragment11094)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toASCIIString11095; 
		public java.lang.String toASCIIString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URI)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toASCIIString11095)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URI.staticClass, _toASCIIString11095)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _URI11096; 
		public URI(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, int arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String arg6)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.URI.staticClass, _URI11096, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _URI11097; 
		public URI(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.URI.staticClass, _URI11097, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _URI11098; 
		public URI(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.URI.staticClass, _URI11098, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _URI11099; 
		public URI(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.URI.staticClass, _URI11099, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _URI11100; 
		public URI(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.URI.staticClass, _URI11100, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.net.URI.staticClass = @__class; 
			global::java.net.URI._hashCode11066 = @__env.GetMethodID(global::java.net.URI.staticClass, "hashCode", "()I"); 
			global::java.net.URI._equals11067 = @__env.GetMethodID(global::java.net.URI.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.net.URI._compareTo11068 = @__env.GetMethodID(global::java.net.URI.staticClass, "compareTo", "(Ljava/lang/Object;)I"); 
			global::java.net.URI._compareTo11069 = @__env.GetMethodID(global::java.net.URI.staticClass, "compareTo", "(Ljava/net/URI;)I"); 
			global::java.net.URI._toString11070 = @__env.GetMethodID(global::java.net.URI.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.net.URI._isAbsolute11071 = @__env.GetMethodID(global::java.net.URI.staticClass, "isAbsolute", "()Z"); 
			global::java.net.URI._getPath11072 = @__env.GetMethodID(global::java.net.URI.staticClass, "getPath", "()Ljava/lang/String;"); 
			global::java.net.URI._toURL11073 = @__env.GetMethodID(global::java.net.URI.staticClass, "toURL", "()Ljava/net/URL;"); 
			global::java.net.URI._resolve11074 = @__env.GetMethodID(global::java.net.URI.staticClass, "resolve", "(Ljava/net/URI;)Ljava/net/URI;"); 
			global::java.net.URI._resolve11075 = @__env.GetMethodID(global::java.net.URI.staticClass, "resolve", "(Ljava/lang/String;)Ljava/net/URI;"); 
			global::java.net.URI._normalize11076 = @__env.GetMethodID(global::java.net.URI.staticClass, "normalize", "()Ljava/net/URI;"); 
			global::java.net.URI._isOpaque11077 = @__env.GetMethodID(global::java.net.URI.staticClass, "isOpaque", "()Z"); 
			global::java.net.URI._getScheme11078 = @__env.GetMethodID(global::java.net.URI.staticClass, "getScheme", "()Ljava/lang/String;"); 
			global::java.net.URI._getAuthority11079 = @__env.GetMethodID(global::java.net.URI.staticClass, "getAuthority", "()Ljava/lang/String;"); 
			global::java.net.URI._getFragment11080 = @__env.GetMethodID(global::java.net.URI.staticClass, "getFragment", "()Ljava/lang/String;"); 
			global::java.net.URI._getQuery11081 = @__env.GetMethodID(global::java.net.URI.staticClass, "getQuery", "()Ljava/lang/String;"); 
			global::java.net.URI._getUserInfo11082 = @__env.GetMethodID(global::java.net.URI.staticClass, "getUserInfo", "()Ljava/lang/String;"); 
			global::java.net.URI._getPort11083 = @__env.GetMethodID(global::java.net.URI.staticClass, "getPort", "()I"); 
			global::java.net.URI._getHost11084 = @__env.GetMethodID(global::java.net.URI.staticClass, "getHost", "()Ljava/lang/String;"); 
			global::java.net.URI._create11085 = @__env.GetStaticMethodID(global::java.net.URI.staticClass, "create", "(Ljava/lang/String;)Ljava/net/URI;"); 
			global::java.net.URI._getSchemeSpecificPart11086 = @__env.GetMethodID(global::java.net.URI.staticClass, "getSchemeSpecificPart", "()Ljava/lang/String;"); 
			global::java.net.URI._parseServerAuthority11087 = @__env.GetMethodID(global::java.net.URI.staticClass, "parseServerAuthority", "()Ljava/net/URI;"); 
			global::java.net.URI._relativize11088 = @__env.GetMethodID(global::java.net.URI.staticClass, "relativize", "(Ljava/net/URI;)Ljava/net/URI;"); 
			global::java.net.URI._getRawSchemeSpecificPart11089 = @__env.GetMethodID(global::java.net.URI.staticClass, "getRawSchemeSpecificPart", "()Ljava/lang/String;"); 
			global::java.net.URI._getRawAuthority11090 = @__env.GetMethodID(global::java.net.URI.staticClass, "getRawAuthority", "()Ljava/lang/String;"); 
			global::java.net.URI._getRawUserInfo11091 = @__env.GetMethodID(global::java.net.URI.staticClass, "getRawUserInfo", "()Ljava/lang/String;"); 
			global::java.net.URI._getRawPath11092 = @__env.GetMethodID(global::java.net.URI.staticClass, "getRawPath", "()Ljava/lang/String;"); 
			global::java.net.URI._getRawQuery11093 = @__env.GetMethodID(global::java.net.URI.staticClass, "getRawQuery", "()Ljava/lang/String;"); 
			global::java.net.URI._getRawFragment11094 = @__env.GetMethodID(global::java.net.URI.staticClass, "getRawFragment", "()Ljava/lang/String;"); 
			global::java.net.URI._toASCIIString11095 = @__env.GetMethodID(global::java.net.URI.staticClass, "toASCIIString", "()Ljava/lang/String;"); 
			global::java.net.URI._URI11096 = @__env.GetMethodID(global::java.net.URI.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"); 
			global::java.net.URI._URI11097 = @__env.GetMethodID(global::java.net.URI.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"); 
			global::java.net.URI._URI11098 = @__env.GetMethodID(global::java.net.URI.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"); 
			global::java.net.URI._URI11099 = @__env.GetMethodID(global::java.net.URI.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"); 
			global::java.net.URI._URI11100 = @__env.GetMethodID(global::java.net.URI.staticClass, "<init>", "(Ljava/lang/String;)V"); 
		} 
	} 
} 
