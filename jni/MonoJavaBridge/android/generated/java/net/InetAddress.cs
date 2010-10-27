namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InetAddress : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InetAddress()
		{
			InitJNI();
		}
		protected InetAddress(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals21561;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._equals21561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._equals21561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString21562;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.InetAddress._toString21562)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._toString21562)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode21563;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.InetAddress._hashCode21563);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._hashCode21563);
		}
		public new byte[] Address
		{
			get
			{
				return getAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAddress21564;
		public virtual byte[] getAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.InetAddress._getAddress21564)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._getAddress21564)) as byte[];
		}
		public new global::java.lang.String HostName
		{
			get
			{
				return getHostName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHostName21565;
		public virtual global::java.lang.String getHostName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.InetAddress._getHostName21565)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._getHostName21565)) as java.lang.String;
		}
		public new global::java.lang.String HostAddress
		{
			get
			{
				return getHostAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHostAddress21566;
		public virtual global::java.lang.String getHostAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.InetAddress._getHostAddress21566)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._getHostAddress21566)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getByName21567;
		public static global::java.net.InetAddress getByName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.InetAddress.staticClass, global::java.net.InetAddress._getByName21567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _isAnyLocalAddress21568;
		public virtual bool isAnyLocalAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isAnyLocalAddress21568);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isAnyLocalAddress21568);
		}
		internal static global::MonoJavaBridge.MethodId _isMulticastAddress21569;
		public virtual bool isMulticastAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isMulticastAddress21569);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isMulticastAddress21569);
		}
		internal static global::MonoJavaBridge.MethodId _isLoopbackAddress21570;
		public virtual bool isLoopbackAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isLoopbackAddress21570);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isLoopbackAddress21570);
		}
		internal static global::MonoJavaBridge.MethodId _isLinkLocalAddress21571;
		public virtual bool isLinkLocalAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isLinkLocalAddress21571);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isLinkLocalAddress21571);
		}
		internal static global::MonoJavaBridge.MethodId _isSiteLocalAddress21572;
		public virtual bool isSiteLocalAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isSiteLocalAddress21572);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isSiteLocalAddress21572);
		}
		internal static global::MonoJavaBridge.MethodId _isMCGlobal21573;
		public virtual bool isMCGlobal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isMCGlobal21573);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isMCGlobal21573);
		}
		internal static global::MonoJavaBridge.MethodId _isMCNodeLocal21574;
		public virtual bool isMCNodeLocal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isMCNodeLocal21574);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isMCNodeLocal21574);
		}
		internal static global::MonoJavaBridge.MethodId _isMCLinkLocal21575;
		public virtual bool isMCLinkLocal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isMCLinkLocal21575);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isMCLinkLocal21575);
		}
		internal static global::MonoJavaBridge.MethodId _isMCSiteLocal21576;
		public virtual bool isMCSiteLocal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isMCSiteLocal21576);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isMCSiteLocal21576);
		}
		internal static global::MonoJavaBridge.MethodId _isMCOrgLocal21577;
		public virtual bool isMCOrgLocal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isMCOrgLocal21577);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isMCOrgLocal21577);
		}
		internal static global::MonoJavaBridge.MethodId _isReachable21578;
		public virtual bool isReachable(java.net.NetworkInterface arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isReachable21578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isReachable21578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isReachable21579;
		public virtual bool isReachable(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isReachable21579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isReachable21579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String CanonicalHostName
		{
			get
			{
				return getCanonicalHostName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCanonicalHostName21580;
		public virtual global::java.lang.String getCanonicalHostName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.InetAddress._getCanonicalHostName21580)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._getCanonicalHostName21580)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getByAddress21581;
		public static global::java.net.InetAddress getByAddress(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.InetAddress.staticClass, global::java.net.InetAddress._getByAddress21581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getByAddress21582;
		public static global::java.net.InetAddress getByAddress(java.lang.String arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.InetAddress.staticClass, global::java.net.InetAddress._getByAddress21582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getAllByName21583;
		public static global::java.net.InetAddress[] getAllByName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.net.InetAddress>(@__env.CallStaticObjectMethod(java.net.InetAddress.staticClass, global::java.net.InetAddress._getAllByName21583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.InetAddress[];
		}
		public static global::java.net.InetAddress LocalHost
		{
			get
			{
				return getLocalHost();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalHost21584;
		public static global::java.net.InetAddress getLocalHost()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.InetAddress.staticClass, global::java.net.InetAddress._getLocalHost21584)) as java.net.InetAddress;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.InetAddress.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/InetAddress"));
			global::java.net.InetAddress._equals21561 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.net.InetAddress._toString21562 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "toString", "()Ljava/lang/String;");
			global::java.net.InetAddress._hashCode21563 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "hashCode", "()I");
			global::java.net.InetAddress._getAddress21564 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getAddress", "()[B");
			global::java.net.InetAddress._getHostName21565 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getHostName", "()Ljava/lang/String;");
			global::java.net.InetAddress._getHostAddress21566 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getHostAddress", "()Ljava/lang/String;");
			global::java.net.InetAddress._getByName21567 = @__env.GetStaticMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getByName", "(Ljava/lang/String;)Ljava/net/InetAddress;");
			global::java.net.InetAddress._isAnyLocalAddress21568 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isAnyLocalAddress", "()Z");
			global::java.net.InetAddress._isMulticastAddress21569 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isMulticastAddress", "()Z");
			global::java.net.InetAddress._isLoopbackAddress21570 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isLoopbackAddress", "()Z");
			global::java.net.InetAddress._isLinkLocalAddress21571 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isLinkLocalAddress", "()Z");
			global::java.net.InetAddress._isSiteLocalAddress21572 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isSiteLocalAddress", "()Z");
			global::java.net.InetAddress._isMCGlobal21573 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isMCGlobal", "()Z");
			global::java.net.InetAddress._isMCNodeLocal21574 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isMCNodeLocal", "()Z");
			global::java.net.InetAddress._isMCLinkLocal21575 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isMCLinkLocal", "()Z");
			global::java.net.InetAddress._isMCSiteLocal21576 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isMCSiteLocal", "()Z");
			global::java.net.InetAddress._isMCOrgLocal21577 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isMCOrgLocal", "()Z");
			global::java.net.InetAddress._isReachable21578 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isReachable", "(Ljava/net/NetworkInterface;II)Z");
			global::java.net.InetAddress._isReachable21579 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isReachable", "(I)Z");
			global::java.net.InetAddress._getCanonicalHostName21580 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getCanonicalHostName", "()Ljava/lang/String;");
			global::java.net.InetAddress._getByAddress21581 = @__env.GetStaticMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getByAddress", "([B)Ljava/net/InetAddress;");
			global::java.net.InetAddress._getByAddress21582 = @__env.GetStaticMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getByAddress", "(Ljava/lang/String;[B)Ljava/net/InetAddress;");
			global::java.net.InetAddress._getAllByName21583 = @__env.GetStaticMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getAllByName", "(Ljava/lang/String;)[Ljava/net/InetAddress;");
			global::java.net.InetAddress._getLocalHost21584 = @__env.GetStaticMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getLocalHost", "()Ljava/net/InetAddress;");
		}
	}
}
