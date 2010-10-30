namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class NetworkInterface : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal NetworkInterface(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.NetworkInterface.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.net.NetworkInterface._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.NetworkInterface.staticClass, "toString", "()Ljava/lang/String;", ref global::java.net.NetworkInterface._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.NetworkInterface.staticClass, "hashCode", "()I", ref global::java.net.NetworkInterface._m2);
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.NetworkInterface.staticClass, "getName", "()Ljava/lang/String;", ref global::java.net.NetworkInterface._m3) as java.lang.String;
		}
		public new global::java.net.NetworkInterface Parent
		{
			get
			{
				return getParent();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public global::java.net.NetworkInterface getParent()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.NetworkInterface>(this, global::java.net.NetworkInterface.staticClass, "getParent", "()Ljava/net/NetworkInterface;", ref global::java.net.NetworkInterface._m4) as java.net.NetworkInterface;
		}
		public new global::java.lang.String DisplayName
		{
			get
			{
				return getDisplayName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public global::java.lang.String getDisplayName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.NetworkInterface.staticClass, "getDisplayName", "()Ljava/lang/String;", ref global::java.net.NetworkInterface._m5) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::java.net.NetworkInterface getByName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.NetworkInterface._m6.native == global::System.IntPtr.Zero)
				global::java.net.NetworkInterface._m6 = @__env.GetStaticMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getByName", "(Ljava/lang/String;)Ljava/net/NetworkInterface;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.NetworkInterface>(@__env.CallStaticObjectMethod(java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.NetworkInterface;
		}
		public new global::java.util.Enumeration InetAddresses
		{
			get
			{
				return getInetAddresses();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public global::java.util.Enumeration getInetAddresses()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.net.NetworkInterface.staticClass, "getInetAddresses", "()Ljava/util/Enumeration;", ref global::java.net.NetworkInterface._m7) as java.util.Enumeration;
		}
		public new global::java.util.List InterfaceAddresses
		{
			get
			{
				return getInterfaceAddresses();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public global::java.util.List getInterfaceAddresses()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::java.net.NetworkInterface.staticClass, "getInterfaceAddresses", "()Ljava/util/List;", ref global::java.net.NetworkInterface._m8) as java.util.List;
		}
		public new global::java.util.Enumeration SubInterfaces
		{
			get
			{
				return getSubInterfaces();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public global::java.util.Enumeration getSubInterfaces()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.net.NetworkInterface.staticClass, "getSubInterfaces", "()Ljava/util/Enumeration;", ref global::java.net.NetworkInterface._m9) as java.util.Enumeration;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static global::java.net.NetworkInterface getByInetAddress(java.net.InetAddress arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.NetworkInterface._m10.native == global::System.IntPtr.Zero)
				global::java.net.NetworkInterface._m10 = @__env.GetStaticMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getByInetAddress", "(Ljava/net/InetAddress;)Ljava/net/NetworkInterface;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.NetworkInterface>(@__env.CallStaticObjectMethod(java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.NetworkInterface;
		}
		public static global::java.util.Enumeration NetworkInterfaces
		{
			get
			{
				return getNetworkInterfaces();
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static global::java.util.Enumeration getNetworkInterfaces()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.NetworkInterface._m11.native == global::System.IntPtr.Zero)
				global::java.net.NetworkInterface._m11 = @__env.GetStaticMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getNetworkInterfaces", "()Ljava/util/Enumeration;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallStaticObjectMethod(java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._m11)) as java.util.Enumeration;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public bool isUp()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.NetworkInterface.staticClass, "isUp", "()Z", ref global::java.net.NetworkInterface._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public bool isLoopback()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.NetworkInterface.staticClass, "isLoopback", "()Z", ref global::java.net.NetworkInterface._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public bool isPointToPoint()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.NetworkInterface.staticClass, "isPointToPoint", "()Z", ref global::java.net.NetworkInterface._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public bool supportsMulticast()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.NetworkInterface.staticClass, "supportsMulticast", "()Z", ref global::java.net.NetworkInterface._m15);
		}
		public new byte[] HardwareAddress
		{
			get
			{
				return getHardwareAddress();
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public byte[] getHardwareAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.net.NetworkInterface.staticClass, "getHardwareAddress", "()[B", ref global::java.net.NetworkInterface._m16) as byte[];
		}
		public new int MTU
		{
			get
			{
				return getMTU();
			}
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public int getMTU()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.NetworkInterface.staticClass, "getMTU", "()I", ref global::java.net.NetworkInterface._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public bool isVirtual()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.NetworkInterface.staticClass, "isVirtual", "()Z", ref global::java.net.NetworkInterface._m18);
		}
		static NetworkInterface()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.NetworkInterface.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/NetworkInterface"));
		}
		internal static void InitJNI()
		{
		}
	}
}
