namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class NetworkInterface : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal NetworkInterface(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals21631;
		public sealed override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface._equals21631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._equals21631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString21632;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.NetworkInterface._toString21632)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._toString21632)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode21633;
		public sealed override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.NetworkInterface._hashCode21633);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._hashCode21633);
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName21634;
		public global::java.lang.String getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.NetworkInterface._getName21634)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getName21634)) as java.lang.String;
		}
		public new global::java.net.NetworkInterface Parent
		{
			get
			{
				return getParent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParent21635;
		public global::java.net.NetworkInterface getParent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.NetworkInterface>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.NetworkInterface._getParent21635)) as java.net.NetworkInterface;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.NetworkInterface>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getParent21635)) as java.net.NetworkInterface;
		}
		public new global::java.lang.String DisplayName
		{
			get
			{
				return getDisplayName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayName21636;
		public global::java.lang.String getDisplayName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.NetworkInterface._getDisplayName21636)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getDisplayName21636)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getByName21637;
		public static global::java.net.NetworkInterface getByName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.NetworkInterface>(@__env.CallStaticObjectMethod(java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getByName21637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.NetworkInterface;
		}
		public new global::java.util.Enumeration InetAddresses
		{
			get
			{
				return getInetAddresses();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInetAddresses21638;
		public global::java.util.Enumeration getInetAddresses()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.NetworkInterface._getInetAddresses21638)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getInetAddresses21638)) as java.util.Enumeration;
		}
		public new global::java.util.List InterfaceAddresses
		{
			get
			{
				return getInterfaceAddresses();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInterfaceAddresses21639;
		public global::java.util.List getInterfaceAddresses()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.NetworkInterface._getInterfaceAddresses21639)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getInterfaceAddresses21639)) as java.util.List;
		}
		public new global::java.util.Enumeration SubInterfaces
		{
			get
			{
				return getSubInterfaces();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSubInterfaces21640;
		public global::java.util.Enumeration getSubInterfaces()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.NetworkInterface._getSubInterfaces21640)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getSubInterfaces21640)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _getByInetAddress21641;
		public static global::java.net.NetworkInterface getByInetAddress(java.net.InetAddress arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.NetworkInterface>(@__env.CallStaticObjectMethod(java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getByInetAddress21641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.NetworkInterface;
		}
		public static global::java.util.Enumeration NetworkInterfaces
		{
			get
			{
				return getNetworkInterfaces();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNetworkInterfaces21642;
		public static global::java.util.Enumeration getNetworkInterfaces()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallStaticObjectMethod(java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getNetworkInterfaces21642)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _isUp21643;
		public bool isUp()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface._isUp21643);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._isUp21643);
		}
		internal static global::MonoJavaBridge.MethodId _isLoopback21644;
		public bool isLoopback()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface._isLoopback21644);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._isLoopback21644);
		}
		internal static global::MonoJavaBridge.MethodId _isPointToPoint21645;
		public bool isPointToPoint()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface._isPointToPoint21645);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._isPointToPoint21645);
		}
		internal static global::MonoJavaBridge.MethodId _supportsMulticast21646;
		public bool supportsMulticast()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface._supportsMulticast21646);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._supportsMulticast21646);
		}
		public new byte[] HardwareAddress
		{
			get
			{
				return getHardwareAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHardwareAddress21647;
		public byte[] getHardwareAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.NetworkInterface._getHardwareAddress21647)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getHardwareAddress21647)) as byte[];
		}
		public new int MTU
		{
			get
			{
				return getMTU();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMTU21648;
		public int getMTU()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.NetworkInterface._getMTU21648);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getMTU21648);
		}
		internal static global::MonoJavaBridge.MethodId _isVirtual21649;
		public bool isVirtual()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface._isVirtual21649);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._isVirtual21649);
		}
		static NetworkInterface()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.NetworkInterface.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/NetworkInterface"));
			global::java.net.NetworkInterface._equals21631 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.net.NetworkInterface._toString21632 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "toString", "()Ljava/lang/String;");
			global::java.net.NetworkInterface._hashCode21633 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "hashCode", "()I");
			global::java.net.NetworkInterface._getName21634 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getName", "()Ljava/lang/String;");
			global::java.net.NetworkInterface._getParent21635 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getParent", "()Ljava/net/NetworkInterface;");
			global::java.net.NetworkInterface._getDisplayName21636 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getDisplayName", "()Ljava/lang/String;");
			global::java.net.NetworkInterface._getByName21637 = @__env.GetStaticMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getByName", "(Ljava/lang/String;)Ljava/net/NetworkInterface;");
			global::java.net.NetworkInterface._getInetAddresses21638 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getInetAddresses", "()Ljava/util/Enumeration;");
			global::java.net.NetworkInterface._getInterfaceAddresses21639 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getInterfaceAddresses", "()Ljava/util/List;");
			global::java.net.NetworkInterface._getSubInterfaces21640 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getSubInterfaces", "()Ljava/util/Enumeration;");
			global::java.net.NetworkInterface._getByInetAddress21641 = @__env.GetStaticMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getByInetAddress", "(Ljava/net/InetAddress;)Ljava/net/NetworkInterface;");
			global::java.net.NetworkInterface._getNetworkInterfaces21642 = @__env.GetStaticMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getNetworkInterfaces", "()Ljava/util/Enumeration;");
			global::java.net.NetworkInterface._isUp21643 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "isUp", "()Z");
			global::java.net.NetworkInterface._isLoopback21644 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "isLoopback", "()Z");
			global::java.net.NetworkInterface._isPointToPoint21645 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "isPointToPoint", "()Z");
			global::java.net.NetworkInterface._supportsMulticast21646 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "supportsMulticast", "()Z");
			global::java.net.NetworkInterface._getHardwareAddress21647 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getHardwareAddress", "()[B");
			global::java.net.NetworkInterface._getMTU21648 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getMTU", "()I");
			global::java.net.NetworkInterface._isVirtual21649 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "isVirtual", "()Z");
		}
		internal static void InitJNI()
		{
		}
	}
}
