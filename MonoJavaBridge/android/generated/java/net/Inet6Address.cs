namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Inet6Address : java.net.InetAddress
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Inet6Address(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Inet6Address.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.net.Inet6Address._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.Inet6Address.staticClass, "hashCode", "()I", ref global::java.net.Inet6Address._m1);
		}
		public new byte[] Address
		{
			get
			{
				return getAddress();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override byte[] getAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.net.Inet6Address.staticClass, "getAddress", "()[B", ref global::java.net.Inet6Address._m2) as byte[];
		}
		public new global::java.lang.String HostAddress
		{
			get
			{
				return getHostAddress();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public sealed override global::java.lang.String getHostAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.Inet6Address.staticClass, "getHostAddress", "()Ljava/lang/String;", ref global::java.net.Inet6Address._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public sealed override bool isAnyLocalAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Inet6Address.staticClass, "isAnyLocalAddress", "()Z", ref global::java.net.Inet6Address._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public sealed override bool isMulticastAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Inet6Address.staticClass, "isMulticastAddress", "()Z", ref global::java.net.Inet6Address._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public sealed override bool isLoopbackAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Inet6Address.staticClass, "isLoopbackAddress", "()Z", ref global::java.net.Inet6Address._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public sealed override bool isLinkLocalAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Inet6Address.staticClass, "isLinkLocalAddress", "()Z", ref global::java.net.Inet6Address._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public sealed override bool isSiteLocalAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Inet6Address.staticClass, "isSiteLocalAddress", "()Z", ref global::java.net.Inet6Address._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public sealed override bool isMCGlobal()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Inet6Address.staticClass, "isMCGlobal", "()Z", ref global::java.net.Inet6Address._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public sealed override bool isMCNodeLocal()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Inet6Address.staticClass, "isMCNodeLocal", "()Z", ref global::java.net.Inet6Address._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public sealed override bool isMCLinkLocal()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Inet6Address.staticClass, "isMCLinkLocal", "()Z", ref global::java.net.Inet6Address._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public sealed override bool isMCSiteLocal()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Inet6Address.staticClass, "isMCSiteLocal", "()Z", ref global::java.net.Inet6Address._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public sealed override bool isMCOrgLocal()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Inet6Address.staticClass, "isMCOrgLocal", "()Z", ref global::java.net.Inet6Address._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static global::java.net.Inet6Address getByAddress(java.lang.String arg0, byte[] arg1, java.net.NetworkInterface arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.Inet6Address._m14.native == global::System.IntPtr.Zero)
				global::java.net.Inet6Address._m14 = @__env.GetStaticMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "getByAddress", "(Ljava/lang/String;[BLjava/net/NetworkInterface;)Ljava/net/Inet6Address;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.Inet6Address>(@__env.CallStaticObjectMethod(java.net.Inet6Address.staticClass, global::java.net.Inet6Address._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.net.Inet6Address;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static global::java.net.Inet6Address getByAddress(java.lang.String arg0, byte[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.Inet6Address._m15.native == global::System.IntPtr.Zero)
				global::java.net.Inet6Address._m15 = @__env.GetStaticMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "getByAddress", "(Ljava/lang/String;[BI)Ljava/net/Inet6Address;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.Inet6Address>(@__env.CallStaticObjectMethod(java.net.Inet6Address.staticClass, global::java.net.Inet6Address._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.net.Inet6Address;
		}
		public new int ScopeId
		{
			get
			{
				return getScopeId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public int getScopeId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.Inet6Address.staticClass, "getScopeId", "()I", ref global::java.net.Inet6Address._m16);
		}
		public new global::java.net.NetworkInterface ScopedInterface
		{
			get
			{
				return getScopedInterface();
			}
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public global::java.net.NetworkInterface getScopedInterface()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.NetworkInterface>(this, global::java.net.Inet6Address.staticClass, "getScopedInterface", "()Ljava/net/NetworkInterface;", ref global::java.net.Inet6Address._m17) as java.net.NetworkInterface;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public bool isIPv4CompatibleAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Inet6Address.staticClass, "isIPv4CompatibleAddress", "()Z", ref global::java.net.Inet6Address._m18);
		}
		static Inet6Address()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.Inet6Address.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/Inet6Address"));
		}
	}
}
