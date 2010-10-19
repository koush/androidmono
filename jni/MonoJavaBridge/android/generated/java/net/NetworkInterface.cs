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
		internal static global::MonoJavaBridge.MethodId _equals15932;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface._equals15932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._equals15932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString15933;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.NetworkInterface._toString15933)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._toString15933)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode15934;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.NetworkInterface._hashCode15934);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._hashCode15934);
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName15935;
		public global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.NetworkInterface._getName15935)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getName15935)) as java.lang.String;
		}
		public new global::java.net.NetworkInterface Parent
		{
			get
			{
				return getParent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParent15936;
		public global::java.net.NetworkInterface getParent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.NetworkInterface._getParent15936)) as java.net.NetworkInterface;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getParent15936)) as java.net.NetworkInterface;
		}
		public new global::java.lang.String DisplayName
		{
			get
			{
				return getDisplayName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayName15937;
		public global::java.lang.String getDisplayName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.NetworkInterface._getDisplayName15937)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getDisplayName15937)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getByName15938;
		public static global::java.net.NetworkInterface getByName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getByName15938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.NetworkInterface;
		}
		public new global::java.util.Enumeration InetAddresses
		{
			get
			{
				return getInetAddresses();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInetAddresses15939;
		public global::java.util.Enumeration getInetAddresses() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.NetworkInterface._getInetAddresses15939)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getInetAddresses15939)) as java.util.Enumeration;
		}
		public new global::java.util.List InterfaceAddresses
		{
			get
			{
				return getInterfaceAddresses();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInterfaceAddresses15940;
		public global::java.util.List getInterfaceAddresses() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.NetworkInterface._getInterfaceAddresses15940)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getInterfaceAddresses15940)) as java.util.List;
		}
		public new global::java.util.Enumeration SubInterfaces
		{
			get
			{
				return getSubInterfaces();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSubInterfaces15941;
		public global::java.util.Enumeration getSubInterfaces() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.NetworkInterface._getSubInterfaces15941)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getSubInterfaces15941)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _getByInetAddress15942;
		public static global::java.net.NetworkInterface getByInetAddress(java.net.InetAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getByInetAddress15942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.NetworkInterface;
		}
		public static global::java.util.Enumeration NetworkInterfaces
		{
			get
			{
				return getNetworkInterfaces();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNetworkInterfaces15943;
		public static global::java.util.Enumeration getNetworkInterfaces() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallStaticObjectMethod(java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getNetworkInterfaces15943)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _isUp15944;
		public bool isUp() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface._isUp15944);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._isUp15944);
		}
		internal static global::MonoJavaBridge.MethodId _isLoopback15945;
		public bool isLoopback() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface._isLoopback15945);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._isLoopback15945);
		}
		internal static global::MonoJavaBridge.MethodId _isPointToPoint15946;
		public bool isPointToPoint() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface._isPointToPoint15946);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._isPointToPoint15946);
		}
		internal static global::MonoJavaBridge.MethodId _supportsMulticast15947;
		public bool supportsMulticast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface._supportsMulticast15947);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._supportsMulticast15947);
		}
		public new byte[] HardwareAddress
		{
			get
			{
				return getHardwareAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHardwareAddress15948;
		public byte[] getHardwareAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.NetworkInterface._getHardwareAddress15948)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getHardwareAddress15948)) as byte[];
		}
		public new int MTU
		{
			get
			{
				return getMTU();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMTU15949;
		public int getMTU() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.NetworkInterface._getMTU15949);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._getMTU15949);
		}
		internal static global::MonoJavaBridge.MethodId _isVirtual15950;
		public bool isVirtual() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface._isVirtual15950);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.NetworkInterface.staticClass, global::java.net.NetworkInterface._isVirtual15950);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.NetworkInterface.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/NetworkInterface"));
			global::java.net.NetworkInterface._equals15932 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.net.NetworkInterface._toString15933 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "toString", "()Ljava/lang/String;");
			global::java.net.NetworkInterface._hashCode15934 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "hashCode", "()I");
			global::java.net.NetworkInterface._getName15935 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getName", "()Ljava/lang/String;");
			global::java.net.NetworkInterface._getParent15936 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getParent", "()Ljava/net/NetworkInterface;");
			global::java.net.NetworkInterface._getDisplayName15937 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getDisplayName", "()Ljava/lang/String;");
			global::java.net.NetworkInterface._getByName15938 = @__env.GetStaticMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getByName", "(Ljava/lang/String;)Ljava/net/NetworkInterface;");
			global::java.net.NetworkInterface._getInetAddresses15939 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getInetAddresses", "()Ljava/util/Enumeration;");
			global::java.net.NetworkInterface._getInterfaceAddresses15940 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getInterfaceAddresses", "()Ljava/util/List;");
			global::java.net.NetworkInterface._getSubInterfaces15941 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getSubInterfaces", "()Ljava/util/Enumeration;");
			global::java.net.NetworkInterface._getByInetAddress15942 = @__env.GetStaticMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getByInetAddress", "(Ljava/net/InetAddress;)Ljava/net/NetworkInterface;");
			global::java.net.NetworkInterface._getNetworkInterfaces15943 = @__env.GetStaticMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getNetworkInterfaces", "()Ljava/util/Enumeration;");
			global::java.net.NetworkInterface._isUp15944 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "isUp", "()Z");
			global::java.net.NetworkInterface._isLoopback15945 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "isLoopback", "()Z");
			global::java.net.NetworkInterface._isPointToPoint15946 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "isPointToPoint", "()Z");
			global::java.net.NetworkInterface._supportsMulticast15947 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "supportsMulticast", "()Z");
			global::java.net.NetworkInterface._getHardwareAddress15948 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getHardwareAddress", "()[B");
			global::java.net.NetworkInterface._getMTU15949 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "getMTU", "()I");
			global::java.net.NetworkInterface._isVirtual15950 = @__env.GetMethodIDNoThrow(global::java.net.NetworkInterface.staticClass, "isVirtual", "()Z");
		}
	}
}
