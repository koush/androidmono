namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Proxy : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Proxy()
		{
			InitJNI();
		}
		protected Proxy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Type : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Type()
			{
				InitJNI();
			}
			internal Type(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values21540;
			public static global::java.net.Proxy.Type[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.net.Proxy.Type>(@__env.CallStaticObjectMethod(java.net.Proxy.Type.staticClass, global::java.net.Proxy.Type._values21540)) as java.net.Proxy.Type[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf21541;
			public static global::java.net.Proxy.Type valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.Proxy.Type>(@__env.CallStaticObjectMethod(java.net.Proxy.Type.staticClass, global::java.net.Proxy.Type._valueOf21541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.Proxy.Type;
			}
			internal static global::MonoJavaBridge.FieldId _DIRECT21542;
			public static global::java.net.Proxy.Type DIRECT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.Proxy.Type>(@__env.GetStaticObjectField(global::java.net.Proxy.Type.staticClass, _DIRECT21542)) as java.net.Proxy.Type;
				}
			}
			internal static global::MonoJavaBridge.FieldId _HTTP21543;
			public static global::java.net.Proxy.Type HTTP
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.Proxy.Type>(@__env.GetStaticObjectField(global::java.net.Proxy.Type.staticClass, _HTTP21543)) as java.net.Proxy.Type;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SOCKS21544;
			public static global::java.net.Proxy.Type SOCKS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.Proxy.Type>(@__env.GetStaticObjectField(global::java.net.Proxy.Type.staticClass, _SOCKS21544)) as java.net.Proxy.Type;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.net.Proxy.Type.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/Proxy$Type"));
				global::java.net.Proxy.Type._values21540 = @__env.GetStaticMethodIDNoThrow(global::java.net.Proxy.Type.staticClass, "values", "()[Ljava/net/Proxy/Type;");
				global::java.net.Proxy.Type._valueOf21541 = @__env.GetStaticMethodIDNoThrow(global::java.net.Proxy.Type.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/net/Proxy$Type;");
				global::java.net.Proxy.Type._DIRECT21542 = @__env.GetStaticFieldIDNoThrow(global::java.net.Proxy.Type.staticClass, "DIRECT", "Ljava/net/Proxy$Type;");
				global::java.net.Proxy.Type._HTTP21543 = @__env.GetStaticFieldIDNoThrow(global::java.net.Proxy.Type.staticClass, "HTTP", "Ljava/net/Proxy$Type;");
				global::java.net.Proxy.Type._SOCKS21544 = @__env.GetStaticFieldIDNoThrow(global::java.net.Proxy.Type.staticClass, "SOCKS", "Ljava/net/Proxy$Type;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _type21545;
		public virtual global::java.net.Proxy.Type type() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.Proxy.Type>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Proxy._type21545)) as java.net.Proxy.Type;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.Proxy.Type>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Proxy.staticClass, global::java.net.Proxy._type21545)) as java.net.Proxy.Type;
		}
		internal static global::MonoJavaBridge.MethodId _equals21546;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Proxy._equals21546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Proxy.staticClass, global::java.net.Proxy._equals21546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString21547;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Proxy._toString21547)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Proxy.staticClass, global::java.net.Proxy._toString21547)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode21548;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Proxy._hashCode21548);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Proxy.staticClass, global::java.net.Proxy._hashCode21548);
		}
		internal static global::MonoJavaBridge.MethodId _address21549;
		public virtual global::java.net.SocketAddress address() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Proxy._address21549)) as java.net.SocketAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Proxy.staticClass, global::java.net.Proxy._address21549)) as java.net.SocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _Proxy21550;
		public Proxy(java.net.Proxy.Type arg0, java.net.SocketAddress arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Proxy.staticClass, global::java.net.Proxy._Proxy21550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _NO_PROXY21551;
		public static global::java.net.Proxy NO_PROXY
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.net.Proxy.staticClass, _NO_PROXY21551)) as java.net.Proxy;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.Proxy.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/Proxy"));
			global::java.net.Proxy._type21545 = @__env.GetMethodIDNoThrow(global::java.net.Proxy.staticClass, "type", "()Ljava/net/Proxy$Type;");
			global::java.net.Proxy._equals21546 = @__env.GetMethodIDNoThrow(global::java.net.Proxy.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.net.Proxy._toString21547 = @__env.GetMethodIDNoThrow(global::java.net.Proxy.staticClass, "toString", "()Ljava/lang/String;");
			global::java.net.Proxy._hashCode21548 = @__env.GetMethodIDNoThrow(global::java.net.Proxy.staticClass, "hashCode", "()I");
			global::java.net.Proxy._address21549 = @__env.GetMethodIDNoThrow(global::java.net.Proxy.staticClass, "address", "()Ljava/net/SocketAddress;");
			global::java.net.Proxy._Proxy21550 = @__env.GetMethodIDNoThrow(global::java.net.Proxy.staticClass, "<init>", "(Ljava/net/Proxy$Type;Ljava/net/SocketAddress;)V");
			global::java.net.Proxy._NO_PROXY21551 = @__env.GetStaticFieldIDNoThrow(global::java.net.Proxy.staticClass, "NO_PROXY", "Ljava/net/Proxy;");
		}
	}
}
