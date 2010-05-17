namespace javax.security.auth.x500 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class X500Principal : java.lang.Object, java.security.Principal, java.io.Serializable
	{ 
		internal static global::java.lang.Class staticClass; 
		static X500Principal() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(javax.security.auth.x500.X500Principal), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::javax.security.auth.x500.X500Principal(@__env); 
			} 
		} 
		internal X500Principal(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode12166; 
		public sealed override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(javax.security.auth.x500.X500Principal)) 
				return @__env.CallIntMethod(this, _hashCode12166); 
			else 
				return @__env.CallNonVirtualIntMethod(this, javax.security.auth.x500.X500Principal.staticClass, _hashCode12166); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals12167; 
		public sealed override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(javax.security.auth.x500.X500Principal)) 
				return @__env.CallBooleanMethod(this, _equals12167, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, javax.security.auth.x500.X500Principal.staticClass, _equals12167, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString12168; 
		public sealed override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(javax.security.auth.x500.X500Principal)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString12168)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, javax.security.auth.x500.X500Principal.staticClass, _toString12168)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getName12169; 
		public java.lang.String getName(java.lang.String arg0, java.util.Map arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(javax.security.auth.x500.X500Principal)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getName12169, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, javax.security.auth.x500.X500Principal.staticClass, _getName12169, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getName12170; 
		public java.lang.String getName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(javax.security.auth.x500.X500Principal)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getName12170)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, javax.security.auth.x500.X500Principal.staticClass, _getName12170)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getName12171; 
		public java.lang.String getName(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(javax.security.auth.x500.X500Principal)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getName12171, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, javax.security.auth.x500.X500Principal.staticClass, _getName12171, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEncoded12172; 
		public byte[] getEncoded() 
		{ 
			if (GetType() == typeof(javax.security.auth.x500.X500Principal)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getEncoded12172)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, javax.security.auth.x500.X500Principal.staticClass, _getEncoded12172)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _X500Principal12173; 
		public X500Principal(java.io.InputStream arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(javax.security.auth.x500.X500Principal.staticClass, _X500Principal12173, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _X500Principal12174; 
		public X500Principal(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(javax.security.auth.x500.X500Principal.staticClass, _X500Principal12174, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _X500Principal12175; 
		public X500Principal(java.lang.String arg0, java.util.Map arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(javax.security.auth.x500.X500Principal.staticClass, _X500Principal12175, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _X500Principal12176; 
		public X500Principal(byte[] arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(javax.security.auth.x500.X500Principal.staticClass, _X500Principal12176, this, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		public static java.lang.String RFC1779
		{ 
			get 
			{ 
				return "RFC1779"; 
			} 
		} 
		public static java.lang.String RFC2253
		{ 
			get 
			{ 
				return "RFC2253"; 
			} 
		} 
		public static java.lang.String CANONICAL
		{ 
			get 
			{ 
				return "CANONICAL"; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::javax.security.auth.x500.X500Principal.staticClass = @__class; 
			global::javax.security.auth.x500.X500Principal._hashCode12166 = @__env.GetMethodID(global::javax.security.auth.x500.X500Principal.staticClass, "hashCode", "()I"); 
			global::javax.security.auth.x500.X500Principal._equals12167 = @__env.GetMethodID(global::javax.security.auth.x500.X500Principal.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::javax.security.auth.x500.X500Principal._toString12168 = @__env.GetMethodID(global::javax.security.auth.x500.X500Principal.staticClass, "toString", "()Ljava/lang/String;"); 
			global::javax.security.auth.x500.X500Principal._getName12169 = @__env.GetMethodID(global::javax.security.auth.x500.X500Principal.staticClass, "getName", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;"); 
			global::javax.security.auth.x500.X500Principal._getName12170 = @__env.GetMethodID(global::javax.security.auth.x500.X500Principal.staticClass, "getName", "()Ljava/lang/String;"); 
			global::javax.security.auth.x500.X500Principal._getName12171 = @__env.GetMethodID(global::javax.security.auth.x500.X500Principal.staticClass, "getName", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::javax.security.auth.x500.X500Principal._getEncoded12172 = @__env.GetMethodID(global::javax.security.auth.x500.X500Principal.staticClass, "getEncoded", "()[B"); 
			global::javax.security.auth.x500.X500Principal._X500Principal12173 = @__env.GetMethodID(global::javax.security.auth.x500.X500Principal.staticClass, "<init>", "(Ljava/io/InputStream;)V"); 
			global::javax.security.auth.x500.X500Principal._X500Principal12174 = @__env.GetMethodID(global::javax.security.auth.x500.X500Principal.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			global::javax.security.auth.x500.X500Principal._X500Principal12175 = @__env.GetMethodID(global::javax.security.auth.x500.X500Principal.staticClass, "<init>", "(Ljava/lang/String;Ljava/util/Map;)V"); 
			global::javax.security.auth.x500.X500Principal._X500Principal12176 = @__env.GetMethodID(global::javax.security.auth.x500.X500Principal.staticClass, "<init>", "([B)V"); 
		} 
	} 
} 
