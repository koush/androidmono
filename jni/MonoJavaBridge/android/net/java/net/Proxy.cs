namespace java.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Proxy : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Proxy() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.net.Proxy), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.net.Proxy.Type), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _valueOf11782; 
			public static global::java.net.Proxy.Type valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Proxy.Type>(@__env, @__env.CallStaticObjectMethodPtr(java.net.Proxy.Type.staticClass, global::java.net.Proxy.Type._valueOf11782, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values11783; 
			public static global::java.net.Proxy.Type[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(java.net.Proxy.Type.staticClass, global::java.net.Proxy.Type._values11783)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _DIRECT11784; 
			public static global::java.net.Proxy.Type DIRECT
			{ 
				get 
				{ 
					return default(global::java.net.Proxy.Type); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _HTTP11785; 
			public static global::java.net.Proxy.Type HTTP
			{ 
				get 
				{ 
					return default(global::java.net.Proxy.Type); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _SOCKS11786; 
			public static global::java.net.Proxy.Type SOCKS
			{ 
				get 
				{ 
					return default(global::java.net.Proxy.Type); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::java.net.Proxy.Type.staticClass = @__class; 
				global::java.net.Proxy.Type._valueOf11782 = @__env.GetStaticMethodID(global::java.net.Proxy.Type.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/net/Proxy$Type;"); 
				global::java.net.Proxy.Type._values11783 = @__env.GetStaticMethodID(global::java.net.Proxy.Type.staticClass, "values", "()[Ljava/net/Proxy/Type;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _type11787; 
		public virtual global::java.net.Proxy.Type type() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Proxy.Type>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.Proxy._type11787)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Proxy.Type>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.Proxy.staticClass, global::java.net.Proxy._type11787)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode11788; 
		public sealed override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.net.Proxy._hashCode11788); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.net.Proxy.staticClass, global::java.net.Proxy._hashCode11788); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals11789; 
		public sealed override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::java.net.Proxy._equals11789, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.net.Proxy.staticClass, global::java.net.Proxy._equals11789, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString11790; 
		public override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.Proxy._toString11790)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.Proxy.staticClass, global::java.net.Proxy._toString11790)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _address11791; 
		public virtual global::java.net.SocketAddress address() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.SocketAddress>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.Proxy._address11791)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.SocketAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.Proxy.staticClass, global::java.net.Proxy._address11791)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Proxy11792; 
		public Proxy(java.net.Proxy.Type arg0, java.net.SocketAddress arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.Proxy.staticClass, global::java.net.Proxy._Proxy11792, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _NO_PROXY11793; 
		public static global::java.net.Proxy NO_PROXY
		{ 
			get 
			{ 
				return default(global::java.net.Proxy); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.net.Proxy.staticClass = @__class; 
			global::java.net.Proxy._type11787 = @__env.GetMethodID(global::java.net.Proxy.staticClass, "type", "()Ljava/net/Proxy$Type;"); 
			global::java.net.Proxy._hashCode11788 = @__env.GetMethodID(global::java.net.Proxy.staticClass, "hashCode", "()I"); 
			global::java.net.Proxy._equals11789 = @__env.GetMethodID(global::java.net.Proxy.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.net.Proxy._toString11790 = @__env.GetMethodID(global::java.net.Proxy.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.net.Proxy._address11791 = @__env.GetMethodID(global::java.net.Proxy.staticClass, "address", "()Ljava/net/SocketAddress;"); 
			global::java.net.Proxy._Proxy11792 = @__env.GetMethodID(global::java.net.Proxy.staticClass, "<init>", "(Ljava/net/Proxy$Type;Ljava/net/SocketAddress;)V"); 
		} 
	} 
} 
