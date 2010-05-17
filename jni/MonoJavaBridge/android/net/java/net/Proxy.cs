namespace java.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Proxy : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Proxy() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.net.Proxy), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.net.Proxy(@__env); 
			} 
		} 
		protected Proxy(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Type : java.lang.Enum
		{ 
			internal new static global::java.lang.Class staticClass; 
			static Type() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.net.Proxy.Type), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::java.net.Proxy.Type(@__env); 
				} 
			} 
			internal Type(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _valueOf10954; 
			public static java.net.Proxy.Type valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Proxy.Type>(@__env, @__env.CallStaticObjectMethodPtr(java.net.Proxy.Type.staticClass, _valueOf10954, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values10955; 
			public static java.net.Proxy.Type[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(java.net.Proxy.Type.staticClass, _values10955)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _DIRECT10956; 
			public static java.net.Proxy.Type DIRECT
			{ 
				get 
				{ 
					return default(java.net.Proxy.Type); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _HTTP10957; 
			public static java.net.Proxy.Type HTTP
			{ 
				get 
				{ 
					return default(java.net.Proxy.Type); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _SOCKS10958; 
			public static java.net.Proxy.Type SOCKS
			{ 
				get 
				{ 
					return default(java.net.Proxy.Type); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::java.net.Proxy.Type.staticClass = @__class; 
				global::java.net.Proxy.Type._valueOf10954 = @__env.GetStaticMethodID(global::java.net.Proxy.Type.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/net/Proxy$Type;"); 
				global::java.net.Proxy.Type._values10955 = @__env.GetStaticMethodID(global::java.net.Proxy.Type.staticClass, "values", "()[Ljava/net/Proxy/Type;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _type10959; 
		public virtual java.net.Proxy.Type type() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Proxy)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Proxy.Type>(@__env, @__env.CallObjectMethodPtr(this, _type10959)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Proxy.Type>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.Proxy.staticClass, _type10959)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode10960; 
		public sealed override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Proxy)) 
				return @__env.CallIntMethod(this, _hashCode10960); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.Proxy.staticClass, _hashCode10960); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals10961; 
		public sealed override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Proxy)) 
				return @__env.CallBooleanMethod(this, _equals10961, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.Proxy.staticClass, _equals10961, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString10962; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Proxy)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString10962)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.Proxy.staticClass, _toString10962)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _address10963; 
		public virtual java.net.SocketAddress address() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Proxy)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.SocketAddress>(@__env, @__env.CallObjectMethodPtr(this, _address10963)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.SocketAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.Proxy.staticClass, _address10963)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Proxy10964; 
		public Proxy(java.net.Proxy.Type arg0, java.net.SocketAddress arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.Proxy.staticClass, _Proxy10964, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _NO_PROXY10965; 
		public static java.net.Proxy NO_PROXY
		{ 
			get 
			{ 
				return default(java.net.Proxy); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.net.Proxy.staticClass = @__class; 
			global::java.net.Proxy._type10959 = @__env.GetMethodID(global::java.net.Proxy.staticClass, "type", "()Ljava/net/Proxy$Type;"); 
			global::java.net.Proxy._hashCode10960 = @__env.GetMethodID(global::java.net.Proxy.staticClass, "hashCode", "()I"); 
			global::java.net.Proxy._equals10961 = @__env.GetMethodID(global::java.net.Proxy.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.net.Proxy._toString10962 = @__env.GetMethodID(global::java.net.Proxy.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.net.Proxy._address10963 = @__env.GetMethodID(global::java.net.Proxy.staticClass, "address", "()Ljava/net/SocketAddress;"); 
			global::java.net.Proxy._Proxy10964 = @__env.GetMethodID(global::java.net.Proxy.staticClass, "<init>", "(Ljava/net/Proxy$Type;Ljava/net/SocketAddress;)V"); 
		} 
	} 
} 
