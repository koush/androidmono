namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class NetworkInterface : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NetworkInterface()
		{
			InitJNI();
		}
		internal NetworkInterface(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals21630;
		public sealed override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface._equals21630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._equals21630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString21631;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.NetworkInterface._toString21631)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._toString21631)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode21632;
		public sealed override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.NetworkInterface._hashCode21632);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._hashCode21632);
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName21633;
		public global::java.lang.String getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.NetworkInterface._getName21633)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getName21633)) as java.lang.String;
		}
		public new global::java.net.NetworkInterface Parent
		{
			get
			{
				return getParent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParent21634;
		public global::java.net.NetworkInterface getParent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.NetworkInterface>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.NetworkInterface._getParent21634)) as java.net.NetworkInterface;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.NetworkInterface>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getParent21634)) as java.net.NetworkInterface;
		}
		public new global::java.lang.String DisplayName
		{
			get
			{
				return getDisplayName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayName21635;
		public global::java.lang.String getDisplayName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.NetworkInterface._getDisplayName21635)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getDisplayName21635)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getByName21636;
		public static global::java.net.NetworkInterface getByName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.NetworkInterface>(@__env.CallStaticObjectMethod(java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getByName21636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.NetworkInterface;
		}
		public new global::java.util.Enumeration InetAddresses
		{
			get
			{
				return getInetAddresses();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInetAddresses21637;
		public global::java.util.Enumeration getInetAddresses()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.NetworkInterface._getInetAddresses21637)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getInetAddresses21637)) as java.util.Enumeration;
		}
		public new global::java.util.List InterfaceAddresses
		{
			get
			{
				return getInterfaceAddresses();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInterfaceAddresses21638;
		public global::java.util.List getInterfaceAddresses()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.NetworkInterface._getInterfaceAddresses21638)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getInterfaceAddresses21638)) as java.util.List;
		}
		public new global::java.util.Enumeration SubInterfaces
		{
			get
			{
				return getSubInterfaces();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSubInterfaces21639;
		public global::java.util.Enumeration getSubInterfaces()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.NetworkInterface._getSubInterfaces21639)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getSubInterfaces21639)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _getByInetAddress21640;
		public static global::java.net.NetworkInterface getByInetAddress(java.net.InetAddress arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.NetworkInterface>(@__env.CallStaticObjectMethod(java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getByInetAddress21640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.NetworkInterface;
		}
		public static global::java.util.Enumeration NetworkInterfaces
		{
			get
			{
				return getNetworkInterfaces();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNetworkInterfaces21641;
		public static global::java.util.Enumeration getNetworkInterfaces()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallStaticObjectMethod(java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getNetworkInterfaces21641)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _isUp21642;
		public bool isUp()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface._isUp21642);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._isUp21642);
		}
		internal static global::MonoJavaBridge.MethodId _isLoopback21643;
		public bool isLoopback()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface._isLoopback21643);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._isLoopback21643);
		}
		internal static global::MonoJavaBridge.MethodId _isPointToPoint21644;
		public bool isPointToPoint()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface._isPointToPoint21644);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._isPointToPoint21644);
		}
		internal static global::MonoJavaBridge.MethodId _supportsMulticast21645;
		public bool supportsMulticast()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface._supportsMulticast21645);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._supportsMulticast21645);
		}
		public new byte[] HardwareAddress
		{
			get
			{
				return getHardwareAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHardwareAddress21646;
		public byte[] getHardwareAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.NetworkInterface._getHardwareAddress21646)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getHardwareAddress21646)) as byte[];
		}
		public new int MTU
		{
			get
			{
				return getMTU();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMTU21647;
		public int getMTU()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.NetworkInterface._getMTU21647);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getMTU21647);
		}
		internal static global::MonoJavaBridge.MethodId _isVirtual21648;
		public bool isVirtual()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface._isVirtual21648);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._isVirtual21648);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.NetworkInterface.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/NetworkInterface"));
			global::java.net.NetworkInterface._equals21630 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.net.NetworkInterface._toString21631 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "toString", "()Ljava/lang/String;");
			global::java.net.NetworkInterface._hashCode21632 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "hashCode", "()I");
			global::java.net.NetworkInterface._getName21633 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getName", "()Ljava/lang/String;");
			global::java.net.NetworkInterface._getParent21634 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getParent", "()Ljava/net/NetworkInterface;");
			global::java.net.NetworkInterface._getDisplayName21635 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getDisplayName", "()Ljava/lang/String;");
			global::java.net.NetworkInterface._getByName21636 = @__env.GetStaticMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getByName", "(Ljava/lang/String;)Ljava/net/NetworkInterface;");
			global::java.net.NetworkInterface._getInetAddresses21637 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getInetAddresses", "()Ljava/util/Enumeration;");
			global::java.net.NetworkInterface._getInterfaceAddresses21638 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getInterfaceAddresses", "()Ljava/util/List;");
			global::java.net.NetworkInterface._getSubInterfaces21639 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getSubInterfaces", "()Ljava/util/Enumeration;");
			global::java.net.NetworkInterface._getByInetAddress21640 = @__env.GetStaticMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getByInetAddress", "(Ljava/net/InetAddress;)Ljava/net/NetworkInterface;");
			global::java.net.NetworkInterface._getNetworkInterfaces21641 = @__env.GetStaticMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getNetworkInterfaces", "()Ljava/util/Enumeration;");
			global::java.net.NetworkInterface._isUp21642 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "isUp", "()Z");
			global::java.net.NetworkInterface._isLoopback21643 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "isLoopback", "()Z");
			global::java.net.NetworkInterface._isPointToPoint21644 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "isPointToPoint", "()Z");
			global::java.net.NetworkInterface._supportsMulticast21645 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "supportsMulticast", "()Z");
			global::java.net.NetworkInterface._getHardwareAddress21646 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getHardwareAddress", "()[B");
			global::java.net.NetworkInterface._getMTU21647 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getMTU", "()I");
			global::java.net.NetworkInterface._isVirtual21648 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "isVirtual", "()Z");
		}
	}
}
