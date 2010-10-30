namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InetAddress : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InetAddress(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals21562;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.InetAddress._equals21562.native == global::System.IntPtr.Zero)
				global::java.net.InetAddress._equals21562 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._equals21562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString21563;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.InetAddress._toString21563.native == global::System.IntPtr.Zero)
				global::java.net.InetAddress._toString21563 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._toString21563) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode21564;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.InetAddress._hashCode21564.native == global::System.IntPtr.Zero)
				global::java.net.InetAddress._hashCode21564 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "hashCode", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._hashCode21564);
		}
		public new byte[] Address
		{
			get
			{
				return getAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAddress21565;
		public virtual byte[] getAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.InetAddress._getAddress21565.native == global::System.IntPtr.Zero)
				global::java.net.InetAddress._getAddress21565 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getAddress", "()[B");
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._getAddress21565) as byte[];
		}
		public new global::java.lang.String HostName
		{
			get
			{
				return getHostName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHostName21566;
		public virtual global::java.lang.String getHostName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.InetAddress._getHostName21566.native == global::System.IntPtr.Zero)
				global::java.net.InetAddress._getHostName21566 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getHostName", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._getHostName21566) as java.lang.String;
		}
		public new global::java.lang.String HostAddress
		{
			get
			{
				return getHostAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHostAddress21567;
		public virtual global::java.lang.String getHostAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.InetAddress._getHostAddress21567.native == global::System.IntPtr.Zero)
				global::java.net.InetAddress._getHostAddress21567 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getHostAddress", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._getHostAddress21567) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getByName21568;
		public static global::java.net.InetAddress getByName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.InetAddress._getByName21568.native == global::System.IntPtr.Zero)
				global::java.net.InetAddress._getByName21568 = @__env.GetStaticMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getByName", "(Ljava/lang/String;)Ljava/net/InetAddress;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.InetAddress.staticClass, global::java.net.InetAddress._getByName21568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _isAnyLocalAddress21569;
		public virtual bool isAnyLocalAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.InetAddress._isAnyLocalAddress21569.native == global::System.IntPtr.Zero)
				global::java.net.InetAddress._isAnyLocalAddress21569 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isAnyLocalAddress", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isAnyLocalAddress21569);
		}
		internal static global::MonoJavaBridge.MethodId _isMulticastAddress21570;
		public virtual bool isMulticastAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.InetAddress._isMulticastAddress21570.native == global::System.IntPtr.Zero)
				global::java.net.InetAddress._isMulticastAddress21570 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isMulticastAddress", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isMulticastAddress21570);
		}
		internal static global::MonoJavaBridge.MethodId _isLoopbackAddress21571;
		public virtual bool isLoopbackAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.InetAddress._isLoopbackAddress21571.native == global::System.IntPtr.Zero)
				global::java.net.InetAddress._isLoopbackAddress21571 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isLoopbackAddress", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isLoopbackAddress21571);
		}
		internal static global::MonoJavaBridge.MethodId _isLinkLocalAddress21572;
		public virtual bool isLinkLocalAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.InetAddress._isLinkLocalAddress21572.native == global::System.IntPtr.Zero)
				global::java.net.InetAddress._isLinkLocalAddress21572 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isLinkLocalAddress", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isLinkLocalAddress21572);
		}
		internal static global::MonoJavaBridge.MethodId _isSiteLocalAddress21573;
		public virtual bool isSiteLocalAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.InetAddress._isSiteLocalAddress21573.native == global::System.IntPtr.Zero)
				global::java.net.InetAddress._isSiteLocalAddress21573 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isSiteLocalAddress", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isSiteLocalAddress21573);
		}
		internal static global::MonoJavaBridge.MethodId _isMCGlobal21574;
		public virtual bool isMCGlobal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.InetAddress._isMCGlobal21574.native == global::System.IntPtr.Zero)
				global::java.net.InetAddress._isMCGlobal21574 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isMCGlobal", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isMCGlobal21574);
		}
		internal static global::MonoJavaBridge.MethodId _isMCNodeLocal21575;
		public virtual bool isMCNodeLocal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.InetAddress._isMCNodeLocal21575.native == global::System.IntPtr.Zero)
				global::java.net.InetAddress._isMCNodeLocal21575 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isMCNodeLocal", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isMCNodeLocal21575);
		}
		internal static global::MonoJavaBridge.MethodId _isMCLinkLocal21576;
		public virtual bool isMCLinkLocal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.InetAddress._isMCLinkLocal21576.native == global::System.IntPtr.Zero)
				global::java.net.InetAddress._isMCLinkLocal21576 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isMCLinkLocal", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isMCLinkLocal21576);
		}
		internal static global::MonoJavaBridge.MethodId _isMCSiteLocal21577;
		public virtual bool isMCSiteLocal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.InetAddress._isMCSiteLocal21577.native == global::System.IntPtr.Zero)
				global::java.net.InetAddress._isMCSiteLocal21577 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isMCSiteLocal", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isMCSiteLocal21577);
		}
		internal static global::MonoJavaBridge.MethodId _isMCOrgLocal21578;
		public virtual bool isMCOrgLocal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.InetAddress._isMCOrgLocal21578.native == global::System.IntPtr.Zero)
				global::java.net.InetAddress._isMCOrgLocal21578 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isMCOrgLocal", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isMCOrgLocal21578);
		}
		internal static global::MonoJavaBridge.MethodId _isReachable21579;
		public virtual bool isReachable(java.net.NetworkInterface arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.InetAddress._isReachable21579.native == global::System.IntPtr.Zero)
				global::java.net.InetAddress._isReachable21579 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isReachable", "(Ljava/net/NetworkInterface;II)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isReachable21579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isReachable21580;
		public virtual bool isReachable(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.InetAddress._isReachable21580.native == global::System.IntPtr.Zero)
				global::java.net.InetAddress._isReachable21580 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isReachable", "(I)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isReachable21580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String CanonicalHostName
		{
			get
			{
				return getCanonicalHostName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCanonicalHostName21581;
		public virtual global::java.lang.String getCanonicalHostName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.InetAddress._getCanonicalHostName21581.native == global::System.IntPtr.Zero)
				global::java.net.InetAddress._getCanonicalHostName21581 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getCanonicalHostName", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._getCanonicalHostName21581) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getByAddress21582;
		public static global::java.net.InetAddress getByAddress(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.InetAddress._getByAddress21582.native == global::System.IntPtr.Zero)
				global::java.net.InetAddress._getByAddress21582 = @__env.GetStaticMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getByAddress", "([B)Ljava/net/InetAddress;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.InetAddress.staticClass, global::java.net.InetAddress._getByAddress21582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getByAddress21583;
		public static global::java.net.InetAddress getByAddress(java.lang.String arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.InetAddress._getByAddress21583.native == global::System.IntPtr.Zero)
				global::java.net.InetAddress._getByAddress21583 = @__env.GetStaticMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getByAddress", "(Ljava/lang/String;[B)Ljava/net/InetAddress;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.InetAddress.staticClass, global::java.net.InetAddress._getByAddress21583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getAllByName21584;
		public static global::java.net.InetAddress[] getAllByName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.InetAddress._getAllByName21584.native == global::System.IntPtr.Zero)
				global::java.net.InetAddress._getAllByName21584 = @__env.GetStaticMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getAllByName", "(Ljava/lang/String;)[Ljava/net/InetAddress;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.net.InetAddress>(@__env.CallStaticObjectMethod(java.net.InetAddress.staticClass, global::java.net.InetAddress._getAllByName21584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.InetAddress[];
		}
		public static global::java.net.InetAddress LocalHost
		{
			get
			{
				return getLocalHost();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalHost21585;
		public static global::java.net.InetAddress getLocalHost()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.InetAddress._getLocalHost21585.native == global::System.IntPtr.Zero)
				global::java.net.InetAddress._getLocalHost21585 = @__env.GetStaticMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getLocalHost", "()Ljava/net/InetAddress;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.InetAddress.staticClass, global::java.net.InetAddress._getLocalHost21585)) as java.net.InetAddress;
		}
		static InetAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.InetAddress.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/InetAddress"));
		}
		internal static void InitJNI()
		{
		}
	}
}
