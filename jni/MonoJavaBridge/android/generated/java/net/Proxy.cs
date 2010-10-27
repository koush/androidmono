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
			internal static global::MonoJavaBridge.MethodId _values21658;
			public static global::java.net.Proxy.Type[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.net.Proxy.Type>(@__env.CallStaticObjectMethod(java.net.Proxy.Type.staticClass, global::java.net.Proxy.Type._values21658)) as java.net.Proxy.Type[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf21659;
			public static global::java.net.Proxy.Type valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.Proxy.Type>(@__env.CallStaticObjectMethod(java.net.Proxy.Type.staticClass, global::java.net.Proxy.Type._valueOf21659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.Proxy.Type;
			}
			internal static global::MonoJavaBridge.FieldId _DIRECT21660;
			public static global::java.net.Proxy.Type DIRECT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.Proxy.Type>(@__env.GetStaticObjectField(global::java.net.Proxy.Type.staticClass, _DIRECT21660)) as java.net.Proxy.Type;
				}
			}
			internal static global::MonoJavaBridge.FieldId _HTTP21661;
			public static global::java.net.Proxy.Type HTTP
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.Proxy.Type>(@__env.GetStaticObjectField(global::java.net.Proxy.Type.staticClass, _HTTP21661)) as java.net.Proxy.Type;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SOCKS21662;
			public static global::java.net.Proxy.Type SOCKS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.Proxy.Type>(@__env.GetStaticObjectField(global::java.net.Proxy.Type.staticClass, _SOCKS21662)) as java.net.Proxy.Type;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.net.Proxy.Type.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/Proxy$Type"));
				global::java.net.Proxy.Type._values21658 = @__env.GetStaticMethodIDNoThrow(global::java.net.Proxy.Type.staticClass, "values", "()[Ljava/net/Proxy/Type;");
				global::java.net.Proxy.Type._valueOf21659 = @__env.GetStaticMethodIDNoThrow(global::java.net.Proxy.Type.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/net/Proxy$Type;");
				global::java.net.Proxy.Type._DIRECT21660 = @__env.GetStaticFieldIDNoThrow(global::java.net.Proxy.Type.staticClass, "DIRECT", "Ljava/net/Proxy$Type;");
				global::java.net.Proxy.Type._HTTP21661 = @__env.GetStaticFieldIDNoThrow(global::java.net.Proxy.Type.staticClass, "HTTP", "Ljava/net/Proxy$Type;");
				global::java.net.Proxy.Type._SOCKS21662 = @__env.GetStaticFieldIDNoThrow(global::java.net.Proxy.Type.staticClass, "SOCKS", "Ljava/net/Proxy$Type;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _type21663;
		public virtual global::java.net.Proxy.Type type()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.Proxy.Type>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Proxy._type21663)) as java.net.Proxy.Type;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.Proxy.Type>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Proxy.staticClass, global::java.net.Proxy._type21663)) as java.net.Proxy.Type;
		}
		internal static global::MonoJavaBridge.MethodId _equals21664;
		public sealed override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Proxy._equals21664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Proxy.staticClass, global::java.net.Proxy._equals21664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString21665;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Proxy._toString21665)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Proxy.staticClass, global::java.net.Proxy._toString21665)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode21666;
		public sealed override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Proxy._hashCode21666);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Proxy.staticClass, global::java.net.Proxy._hashCode21666);
		}
		internal static global::MonoJavaBridge.MethodId _address21667;
		public virtual global::java.net.SocketAddress address()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Proxy._address21667)) as java.net.SocketAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Proxy.staticClass, global::java.net.Proxy._address21667)) as java.net.SocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _Proxy21668;
		public Proxy(java.net.Proxy.Type arg0, java.net.SocketAddress arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Proxy.staticClass, global::java.net.Proxy._Proxy21668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _NO_PROXY21669;
		public static global::java.net.Proxy NO_PROXY
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.net.Proxy.staticClass, _NO_PROXY21669)) as java.net.Proxy;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.Proxy.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/Proxy"));
			global::java.net.Proxy._type21663 = @__env.GetMethodIDNoThrow(global::java.net.Proxy.staticClass, "type", "()Ljava/net/Proxy$Type;");
			global::java.net.Proxy._equals21664 = @__env.GetMethodIDNoThrow(global::java.net.Proxy.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.net.Proxy._toString21665 = @__env.GetMethodIDNoThrow(global::java.net.Proxy.staticClass, "toString", "()Ljava/lang/String;");
			global::java.net.Proxy._hashCode21666 = @__env.GetMethodIDNoThrow(global::java.net.Proxy.staticClass, "hashCode", "()I");
			global::java.net.Proxy._address21667 = @__env.GetMethodIDNoThrow(global::java.net.Proxy.staticClass, "address", "()Ljava/net/SocketAddress;");
			global::java.net.Proxy._Proxy21668 = @__env.GetMethodIDNoThrow(global::java.net.Proxy.staticClass, "<init>", "(Ljava/net/Proxy$Type;Ljava/net/SocketAddress;)V");
			global::java.net.Proxy._NO_PROXY21669 = @__env.GetStaticFieldIDNoThrow(global::java.net.Proxy.staticClass, "NO_PROXY", "Ljava/net/Proxy;");
		}
	}
}
