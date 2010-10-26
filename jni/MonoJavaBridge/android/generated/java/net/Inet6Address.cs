namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Inet6Address : java.net.InetAddress
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Inet6Address()
		{
			InitJNI();
		}
		internal Inet6Address(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals21542;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet6Address._equals21542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet6Address.staticClass, global::java.net.Inet6Address._equals21542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode21543;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Inet6Address._hashCode21543);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Inet6Address.staticClass, global::java.net.Inet6Address._hashCode21543);
		}
		public new byte[] Address
		{
			get
			{
				return getAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAddress21544;
		public sealed override byte[] getAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Inet6Address._getAddress21544)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Inet6Address.staticClass, global::java.net.Inet6Address._getAddress21544)) as byte[];
		}
		public new global::java.lang.String HostAddress
		{
			get
			{
				return getHostAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHostAddress21545;
		public sealed override global::java.lang.String getHostAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Inet6Address._getHostAddress21545)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Inet6Address.staticClass, global::java.net.Inet6Address._getHostAddress21545)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isAnyLocalAddress21546;
		public sealed override bool isAnyLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet6Address._isAnyLocalAddress21546);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet6Address.staticClass, global::java.net.Inet6Address._isAnyLocalAddress21546);
		}
		internal static global::MonoJavaBridge.MethodId _isMulticastAddress21547;
		public sealed override bool isMulticastAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet6Address._isMulticastAddress21547);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet6Address.staticClass, global::java.net.Inet6Address._isMulticastAddress21547);
		}
		internal static global::MonoJavaBridge.MethodId _isLoopbackAddress21548;
		public sealed override bool isLoopbackAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet6Address._isLoopbackAddress21548);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet6Address.staticClass, global::java.net.Inet6Address._isLoopbackAddress21548);
		}
		internal static global::MonoJavaBridge.MethodId _isLinkLocalAddress21549;
		public sealed override bool isLinkLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet6Address._isLinkLocalAddress21549);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet6Address.staticClass, global::java.net.Inet6Address._isLinkLocalAddress21549);
		}
		internal static global::MonoJavaBridge.MethodId _isSiteLocalAddress21550;
		public sealed override bool isSiteLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet6Address._isSiteLocalAddress21550);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet6Address.staticClass, global::java.net.Inet6Address._isSiteLocalAddress21550);
		}
		internal static global::MonoJavaBridge.MethodId _isMCGlobal21551;
		public sealed override bool isMCGlobal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet6Address._isMCGlobal21551);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet6Address.staticClass, global::java.net.Inet6Address._isMCGlobal21551);
		}
		internal static global::MonoJavaBridge.MethodId _isMCNodeLocal21552;
		public sealed override bool isMCNodeLocal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet6Address._isMCNodeLocal21552);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet6Address.staticClass, global::java.net.Inet6Address._isMCNodeLocal21552);
		}
		internal static global::MonoJavaBridge.MethodId _isMCLinkLocal21553;
		public sealed override bool isMCLinkLocal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet6Address._isMCLinkLocal21553);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet6Address.staticClass, global::java.net.Inet6Address._isMCLinkLocal21553);
		}
		internal static global::MonoJavaBridge.MethodId _isMCSiteLocal21554;
		public sealed override bool isMCSiteLocal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet6Address._isMCSiteLocal21554);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet6Address.staticClass, global::java.net.Inet6Address._isMCSiteLocal21554);
		}
		internal static global::MonoJavaBridge.MethodId _isMCOrgLocal21555;
		public sealed override bool isMCOrgLocal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet6Address._isMCOrgLocal21555);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet6Address.staticClass, global::java.net.Inet6Address._isMCOrgLocal21555);
		}
		internal static global::MonoJavaBridge.MethodId _getByAddress21556;
		public static global::java.net.Inet6Address getByAddress(java.lang.String arg0, byte[] arg1, java.net.NetworkInterface arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.Inet6Address>(@__env.CallStaticObjectMethod(java.net.Inet6Address.staticClass, global::java.net.Inet6Address._getByAddress21556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.net.Inet6Address;
		}
		internal static global::MonoJavaBridge.MethodId _getByAddress21557;
		public static global::java.net.Inet6Address getByAddress(java.lang.String arg0, byte[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.Inet6Address>(@__env.CallStaticObjectMethod(java.net.Inet6Address.staticClass, global::java.net.Inet6Address._getByAddress21557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.net.Inet6Address;
		}
		public new int ScopeId
		{
			get
			{
				return getScopeId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScopeId21558;
		public int getScopeId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Inet6Address._getScopeId21558);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Inet6Address.staticClass, global::java.net.Inet6Address._getScopeId21558);
		}
		public new global::java.net.NetworkInterface ScopedInterface
		{
			get
			{
				return getScopedInterface();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScopedInterface21559;
		public global::java.net.NetworkInterface getScopedInterface() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.NetworkInterface>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Inet6Address._getScopedInterface21559)) as java.net.NetworkInterface;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.NetworkInterface>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Inet6Address.staticClass, global::java.net.Inet6Address._getScopedInterface21559)) as java.net.NetworkInterface;
		}
		internal static global::MonoJavaBridge.MethodId _isIPv4CompatibleAddress21560;
		public bool isIPv4CompatibleAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet6Address._isIPv4CompatibleAddress21560);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet6Address.staticClass, global::java.net.Inet6Address._isIPv4CompatibleAddress21560);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.Inet6Address.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/Inet6Address"));
			global::java.net.Inet6Address._equals21542 = @__env.GetMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.net.Inet6Address._hashCode21543 = @__env.GetMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "hashCode", "()I");
			global::java.net.Inet6Address._getAddress21544 = @__env.GetMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "getAddress", "()[B");
			global::java.net.Inet6Address._getHostAddress21545 = @__env.GetMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "getHostAddress", "()Ljava/lang/String;");
			global::java.net.Inet6Address._isAnyLocalAddress21546 = @__env.GetMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "isAnyLocalAddress", "()Z");
			global::java.net.Inet6Address._isMulticastAddress21547 = @__env.GetMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "isMulticastAddress", "()Z");
			global::java.net.Inet6Address._isLoopbackAddress21548 = @__env.GetMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "isLoopbackAddress", "()Z");
			global::java.net.Inet6Address._isLinkLocalAddress21549 = @__env.GetMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "isLinkLocalAddress", "()Z");
			global::java.net.Inet6Address._isSiteLocalAddress21550 = @__env.GetMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "isSiteLocalAddress", "()Z");
			global::java.net.Inet6Address._isMCGlobal21551 = @__env.GetMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "isMCGlobal", "()Z");
			global::java.net.Inet6Address._isMCNodeLocal21552 = @__env.GetMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "isMCNodeLocal", "()Z");
			global::java.net.Inet6Address._isMCLinkLocal21553 = @__env.GetMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "isMCLinkLocal", "()Z");
			global::java.net.Inet6Address._isMCSiteLocal21554 = @__env.GetMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "isMCSiteLocal", "()Z");
			global::java.net.Inet6Address._isMCOrgLocal21555 = @__env.GetMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "isMCOrgLocal", "()Z");
			global::java.net.Inet6Address._getByAddress21556 = @__env.GetStaticMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "getByAddress", "(Ljava/lang/String;[BLjava/net/NetworkInterface;)Ljava/net/Inet6Address;");
			global::java.net.Inet6Address._getByAddress21557 = @__env.GetStaticMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "getByAddress", "(Ljava/lang/String;[BI)Ljava/net/Inet6Address;");
			global::java.net.Inet6Address._getScopeId21558 = @__env.GetMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "getScopeId", "()I");
			global::java.net.Inet6Address._getScopedInterface21559 = @__env.GetMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "getScopedInterface", "()Ljava/net/NetworkInterface;");
			global::java.net.Inet6Address._isIPv4CompatibleAddress21560 = @__env.GetMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "isIPv4CompatibleAddress", "()Z");
		}
	}
}
