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
			internal static global::MonoJavaBridge.MethodId _values13722;
			public static global::java.net.Proxy.Type[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.net.Proxy.Type>(@__env.CallStaticObjectMethod(java.net.Proxy.Type.staticClass, global::java.net.Proxy.Type._values13722)) as java.net.Proxy.Type[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf13723;
			public static global::java.net.Proxy.Type valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.Proxy.Type.staticClass, global::java.net.Proxy.Type._valueOf13723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.Proxy.Type;
			}
			internal static global::MonoJavaBridge.FieldId _DIRECT13724;
			public static global::java.net.Proxy.Type DIRECT
			{
				get
				{
					return default(global::java.net.Proxy.Type);
				}
			}
			internal static global::MonoJavaBridge.FieldId _HTTP13725;
			public static global::java.net.Proxy.Type HTTP
			{
				get
				{
					return default(global::java.net.Proxy.Type);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SOCKS13726;
			public static global::java.net.Proxy.Type SOCKS
			{
				get
				{
					return default(global::java.net.Proxy.Type);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.net.Proxy.Type.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/Proxy$Type"));
				global::java.net.Proxy.Type._values13722 = @__env.GetStaticMethodIDNoThrow(global::java.net.Proxy.Type.staticClass, "values", "()[Ljava/net/Proxy/Type;");
				global::java.net.Proxy.Type._valueOf13723 = @__env.GetStaticMethodIDNoThrow(global::java.net.Proxy.Type.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/net/Proxy$Type;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _type13727;
		public virtual global::java.net.Proxy.Type type() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Proxy._type13727)) as java.net.Proxy.Type;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Proxy.staticClass, global::java.net.Proxy._type13727)) as java.net.Proxy.Type;
		}
		internal static global::MonoJavaBridge.MethodId _equals13728;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Proxy._equals13728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Proxy.staticClass, global::java.net.Proxy._equals13728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString13729;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Proxy._toString13729)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Proxy.staticClass, global::java.net.Proxy._toString13729)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode13730;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Proxy._hashCode13730);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Proxy.staticClass, global::java.net.Proxy._hashCode13730);
		}
		internal static global::MonoJavaBridge.MethodId _address13731;
		public virtual global::java.net.SocketAddress address() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Proxy._address13731)) as java.net.SocketAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Proxy.staticClass, global::java.net.Proxy._address13731)) as java.net.SocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _Proxy13732;
		public Proxy(java.net.Proxy.Type arg0, java.net.SocketAddress arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Proxy.staticClass, global::java.net.Proxy._Proxy13732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _NO_PROXY13733;
		public static global::java.net.Proxy NO_PROXY
		{
			get
			{
				return default(global::java.net.Proxy);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.Proxy.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/Proxy"));
			global::java.net.Proxy._type13727 = @__env.GetMethodIDNoThrow(global::java.net.Proxy.staticClass, "type", "()Ljava/net/Proxy$Type;");
			global::java.net.Proxy._equals13728 = @__env.GetMethodIDNoThrow(global::java.net.Proxy.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.net.Proxy._toString13729 = @__env.GetMethodIDNoThrow(global::java.net.Proxy.staticClass, "toString", "()Ljava/lang/String;");
			global::java.net.Proxy._hashCode13730 = @__env.GetMethodIDNoThrow(global::java.net.Proxy.staticClass, "hashCode", "()I");
			global::java.net.Proxy._address13731 = @__env.GetMethodIDNoThrow(global::java.net.Proxy.staticClass, "address", "()Ljava/net/SocketAddress;");
			global::java.net.Proxy._Proxy13732 = @__env.GetMethodIDNoThrow(global::java.net.Proxy.staticClass, "<init>", "(Ljava/net/Proxy$Type;Ljava/net/SocketAddress;)V");
		}
	}
}
