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
		internal static global::MonoJavaBridge.MethodId _equals13703;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface._equals13703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._equals13703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString13704;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.NetworkInterface._toString13704)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._toString13704)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode13705;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.NetworkInterface._hashCode13705);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._hashCode13705);
		}
		internal static global::MonoJavaBridge.MethodId _getName13706;
		public global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.NetworkInterface._getName13706)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getName13706)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getParent13707;
		public global::java.net.NetworkInterface getParent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.NetworkInterface._getParent13707)) as java.net.NetworkInterface;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getParent13707)) as java.net.NetworkInterface;
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayName13708;
		public global::java.lang.String getDisplayName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.NetworkInterface._getDisplayName13708)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getDisplayName13708)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getByName13709;
		public static global::java.net.NetworkInterface getByName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getByName13709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.NetworkInterface;
		}
		internal static global::MonoJavaBridge.MethodId _getInetAddresses13710;
		public global::java.util.Enumeration getInetAddresses() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.NetworkInterface._getInetAddresses13710)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getInetAddresses13710)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _getInterfaceAddresses13711;
		public global::java.util.List getInterfaceAddresses() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.NetworkInterface._getInterfaceAddresses13711)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getInterfaceAddresses13711)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getSubInterfaces13712;
		public global::java.util.Enumeration getSubInterfaces() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.NetworkInterface._getSubInterfaces13712)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getSubInterfaces13712)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _getByInetAddress13713;
		public static global::java.net.NetworkInterface getByInetAddress(java.net.InetAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getByInetAddress13713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.NetworkInterface;
		}
		internal static global::MonoJavaBridge.MethodId _getNetworkInterfaces13714;
		public static global::java.util.Enumeration getNetworkInterfaces() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallStaticObjectMethod(java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getNetworkInterfaces13714)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _isUp13715;
		public bool isUp() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface._isUp13715);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._isUp13715);
		}
		internal static global::MonoJavaBridge.MethodId _isLoopback13716;
		public bool isLoopback() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface._isLoopback13716);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._isLoopback13716);
		}
		internal static global::MonoJavaBridge.MethodId _isPointToPoint13717;
		public bool isPointToPoint() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface._isPointToPoint13717);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._isPointToPoint13717);
		}
		internal static global::MonoJavaBridge.MethodId _supportsMulticast13718;
		public bool supportsMulticast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface._supportsMulticast13718);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._supportsMulticast13718);
		}
		internal static global::MonoJavaBridge.MethodId _getHardwareAddress13719;
		public byte[] getHardwareAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.NetworkInterface._getHardwareAddress13719)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getHardwareAddress13719)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getMTU13720;
		public int getMTU() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.NetworkInterface._getMTU13720);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getMTU13720);
		}
		internal static global::MonoJavaBridge.MethodId _isVirtual13721;
		public bool isVirtual() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface._isVirtual13721);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._isVirtual13721);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.NetworkInterface.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/NetworkInterface"));
			global::java.net.NetworkInterface._equals13703 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.net.NetworkInterface._toString13704 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "toString", "()Ljava/lang/String;");
			global::java.net.NetworkInterface._hashCode13705 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "hashCode", "()I");
			global::java.net.NetworkInterface._getName13706 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getName", "()Ljava/lang/String;");
			global::java.net.NetworkInterface._getParent13707 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getParent", "()Ljava/net/NetworkInterface;");
			global::java.net.NetworkInterface._getDisplayName13708 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getDisplayName", "()Ljava/lang/String;");
			global::java.net.NetworkInterface._getByName13709 = @__env.GetStaticMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getByName", "(Ljava/lang/String;)Ljava/net/NetworkInterface;");
			global::java.net.NetworkInterface._getInetAddresses13710 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getInetAddresses", "()Ljava/util/Enumeration;");
			global::java.net.NetworkInterface._getInterfaceAddresses13711 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getInterfaceAddresses", "()Ljava/util/List;");
			global::java.net.NetworkInterface._getSubInterfaces13712 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getSubInterfaces", "()Ljava/util/Enumeration;");
			global::java.net.NetworkInterface._getByInetAddress13713 = @__env.GetStaticMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getByInetAddress", "(Ljava/net/InetAddress;)Ljava/net/NetworkInterface;");
			global::java.net.NetworkInterface._getNetworkInterfaces13714 = @__env.GetStaticMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getNetworkInterfaces", "()Ljava/util/Enumeration;");
			global::java.net.NetworkInterface._isUp13715 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "isUp", "()Z");
			global::java.net.NetworkInterface._isLoopback13716 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "isLoopback", "()Z");
			global::java.net.NetworkInterface._isPointToPoint13717 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "isPointToPoint", "()Z");
			global::java.net.NetworkInterface._supportsMulticast13718 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "supportsMulticast", "()Z");
			global::java.net.NetworkInterface._getHardwareAddress13719 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getHardwareAddress", "()[B");
			global::java.net.NetworkInterface._getMTU13720 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getMTU", "()I");
			global::java.net.NetworkInterface._isVirtual13721 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "isVirtual", "()Z");
		}
	}
}
