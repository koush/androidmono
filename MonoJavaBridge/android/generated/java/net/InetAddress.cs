namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InetAddress : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InetAddress(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.InetAddress.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.net.InetAddress._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.InetAddress.staticClass, "toString", "()Ljava/lang/String;", ref global::java.net.InetAddress._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.InetAddress.staticClass, "hashCode", "()I", ref global::java.net.InetAddress._m2);
		}
		public new byte[] Address
		{
			get
			{
				return getAddress();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual byte[] getAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.net.InetAddress.staticClass, "getAddress", "()[B", ref global::java.net.InetAddress._m3) as byte[];
		}
		public new global::java.lang.String HostName
		{
			get
			{
				return getHostName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.String getHostName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.InetAddress.staticClass, "getHostName", "()Ljava/lang/String;", ref global::java.net.InetAddress._m4) as java.lang.String;
		}
		public new global::java.lang.String HostAddress
		{
			get
			{
				return getHostAddress();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.String getHostAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.InetAddress.staticClass, "getHostAddress", "()Ljava/lang/String;", ref global::java.net.InetAddress._m5) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::java.net.InetAddress getByName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.InetAddress._m6.native == global::System.IntPtr.Zero)
				global::java.net.InetAddress._m6 = @__env.GetStaticMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getByName", "(Ljava/lang/String;)Ljava/net/InetAddress;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.InetAddress.staticClass, global::java.net.InetAddress._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.InetAddress;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool isAnyLocalAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.InetAddress.staticClass, "isAnyLocalAddress", "()Z", ref global::java.net.InetAddress._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual bool isMulticastAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.InetAddress.staticClass, "isMulticastAddress", "()Z", ref global::java.net.InetAddress._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual bool isLoopbackAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.InetAddress.staticClass, "isLoopbackAddress", "()Z", ref global::java.net.InetAddress._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool isLinkLocalAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.InetAddress.staticClass, "isLinkLocalAddress", "()Z", ref global::java.net.InetAddress._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual bool isSiteLocalAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.InetAddress.staticClass, "isSiteLocalAddress", "()Z", ref global::java.net.InetAddress._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual bool isMCGlobal()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.InetAddress.staticClass, "isMCGlobal", "()Z", ref global::java.net.InetAddress._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual bool isMCNodeLocal()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.InetAddress.staticClass, "isMCNodeLocal", "()Z", ref global::java.net.InetAddress._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual bool isMCLinkLocal()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.InetAddress.staticClass, "isMCLinkLocal", "()Z", ref global::java.net.InetAddress._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual bool isMCSiteLocal()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.InetAddress.staticClass, "isMCSiteLocal", "()Z", ref global::java.net.InetAddress._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual bool isMCOrgLocal()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.InetAddress.staticClass, "isMCOrgLocal", "()Z", ref global::java.net.InetAddress._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual bool isReachable(java.net.NetworkInterface arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.InetAddress.staticClass, "isReachable", "(Ljava/net/NetworkInterface;II)Z", ref global::java.net.InetAddress._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual bool isReachable(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.InetAddress.staticClass, "isReachable", "(I)Z", ref global::java.net.InetAddress._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String CanonicalHostName
		{
			get
			{
				return getCanonicalHostName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual global::java.lang.String getCanonicalHostName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.InetAddress.staticClass, "getCanonicalHostName", "()Ljava/lang/String;", ref global::java.net.InetAddress._m19) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public static global::java.net.InetAddress getByAddress(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.InetAddress._m20.native == global::System.IntPtr.Zero)
				global::java.net.InetAddress._m20 = @__env.GetStaticMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getByAddress", "([B)Ljava/net/InetAddress;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.InetAddress.staticClass, global::java.net.InetAddress._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.InetAddress;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public static global::java.net.InetAddress getByAddress(java.lang.String arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.InetAddress._m21.native == global::System.IntPtr.Zero)
				global::java.net.InetAddress._m21 = @__env.GetStaticMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getByAddress", "(Ljava/lang/String;[B)Ljava/net/InetAddress;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.InetAddress.staticClass, global::java.net.InetAddress._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.InetAddress;
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public static global::java.net.InetAddress[] getAllByName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.InetAddress._m22.native == global::System.IntPtr.Zero)
				global::java.net.InetAddress._m22 = @__env.GetStaticMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getAllByName", "(Ljava/lang/String;)[Ljava/net/InetAddress;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.net.InetAddress>(@__env.CallStaticObjectMethod(java.net.InetAddress.staticClass, global::java.net.InetAddress._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.InetAddress[];
		}
		public static global::java.net.InetAddress LocalHost
		{
			get
			{
				return getLocalHost();
			}
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public static global::java.net.InetAddress getLocalHost()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.InetAddress._m23.native == global::System.IntPtr.Zero)
				global::java.net.InetAddress._m23 = @__env.GetStaticMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getLocalHost", "()Ljava/net/InetAddress;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.InetAddress.staticClass, global::java.net.InetAddress._m23)) as java.net.InetAddress;
		}
		static InetAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.InetAddress.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/InetAddress"));
		}
	}
}
