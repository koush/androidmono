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
		internal static global::MonoJavaBridge.MethodId _equals21424;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet6Address._equals21424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet6Address.staticClass, global::java.net.Inet6Address._equals21424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode21425;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Inet6Address._hashCode21425);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Inet6Address.staticClass, global::java.net.Inet6Address._hashCode21425);
		}
		public new byte[] Address
		{
			get
			{
				return getAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAddress21426;
		public sealed override byte[] getAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Inet6Address._getAddress21426)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Inet6Address.staticClass, global::java.net.Inet6Address._getAddress21426)) as byte[];
		}
		public new global::java.lang.String HostAddress
		{
			get
			{
				return getHostAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHostAddress21427;
		public sealed override global::java.lang.String getHostAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Inet6Address._getHostAddress21427)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Inet6Address.staticClass, global::java.net.Inet6Address._getHostAddress21427)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isAnyLocalAddress21428;
		public sealed override bool isAnyLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet6Address._isAnyLocalAddress21428);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet6Address.staticClass, global::java.net.Inet6Address._isAnyLocalAddress21428);
		}
		internal static global::MonoJavaBridge.MethodId _isMulticastAddress21429;
		public sealed override bool isMulticastAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet6Address._isMulticastAddress21429);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet6Address.staticClass, global::java.net.Inet6Address._isMulticastAddress21429);
		}
		internal static global::MonoJavaBridge.MethodId _isLoopbackAddress21430;
		public sealed override bool isLoopbackAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet6Address._isLoopbackAddress21430);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet6Address.staticClass, global::java.net.Inet6Address._isLoopbackAddress21430);
		}
		internal static global::MonoJavaBridge.MethodId _isLinkLocalAddress21431;
		public sealed override bool isLinkLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet6Address._isLinkLocalAddress21431);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet6Address.staticClass, global::java.net.Inet6Address._isLinkLocalAddress21431);
		}
		internal static global::MonoJavaBridge.MethodId _isSiteLocalAddress21432;
		public sealed override bool isSiteLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet6Address._isSiteLocalAddress21432);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet6Address.staticClass, global::java.net.Inet6Address._isSiteLocalAddress21432);
		}
		internal static global::MonoJavaBridge.MethodId _isMCGlobal21433;
		public sealed override bool isMCGlobal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet6Address._isMCGlobal21433);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet6Address.staticClass, global::java.net.Inet6Address._isMCGlobal21433);
		}
		internal static global::MonoJavaBridge.MethodId _isMCNodeLocal21434;
		public sealed override bool isMCNodeLocal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet6Address._isMCNodeLocal21434);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet6Address.staticClass, global::java.net.Inet6Address._isMCNodeLocal21434);
		}
		internal static global::MonoJavaBridge.MethodId _isMCLinkLocal21435;
		public sealed override bool isMCLinkLocal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet6Address._isMCLinkLocal21435);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet6Address.staticClass, global::java.net.Inet6Address._isMCLinkLocal21435);
		}
		internal static global::MonoJavaBridge.MethodId _isMCSiteLocal21436;
		public sealed override bool isMCSiteLocal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet6Address._isMCSiteLocal21436);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet6Address.staticClass, global::java.net.Inet6Address._isMCSiteLocal21436);
		}
		internal static global::MonoJavaBridge.MethodId _isMCOrgLocal21437;
		public sealed override bool isMCOrgLocal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet6Address._isMCOrgLocal21437);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet6Address.staticClass, global::java.net.Inet6Address._isMCOrgLocal21437);
		}
		internal static global::MonoJavaBridge.MethodId _getByAddress21438;
		public static global::java.net.Inet6Address getByAddress(java.lang.String arg0, byte[] arg1, java.net.NetworkInterface arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.Inet6Address.staticClass, global::java.net.Inet6Address._getByAddress21438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.net.Inet6Address;
		}
		internal static global::MonoJavaBridge.MethodId _getByAddress21439;
		public static global::java.net.Inet6Address getByAddress(java.lang.String arg0, byte[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.Inet6Address.staticClass, global::java.net.Inet6Address._getByAddress21439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.net.Inet6Address;
		}
		public new int ScopeId
		{
			get
			{
				return getScopeId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScopeId21440;
		public int getScopeId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Inet6Address._getScopeId21440);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Inet6Address.staticClass, global::java.net.Inet6Address._getScopeId21440);
		}
		public new global::java.net.NetworkInterface ScopedInterface
		{
			get
			{
				return getScopedInterface();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScopedInterface21441;
		public global::java.net.NetworkInterface getScopedInterface() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Inet6Address._getScopedInterface21441)) as java.net.NetworkInterface;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Inet6Address.staticClass, global::java.net.Inet6Address._getScopedInterface21441)) as java.net.NetworkInterface;
		}
		internal static global::MonoJavaBridge.MethodId _isIPv4CompatibleAddress21442;
		public bool isIPv4CompatibleAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet6Address._isIPv4CompatibleAddress21442);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet6Address.staticClass, global::java.net.Inet6Address._isIPv4CompatibleAddress21442);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.Inet6Address.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/Inet6Address"));
			global::java.net.Inet6Address._equals21424 = @__env.GetMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.net.Inet6Address._hashCode21425 = @__env.GetMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "hashCode", "()I");
			global::java.net.Inet6Address._getAddress21426 = @__env.GetMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "getAddress", "()[B");
			global::java.net.Inet6Address._getHostAddress21427 = @__env.GetMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "getHostAddress", "()Ljava/lang/String;");
			global::java.net.Inet6Address._isAnyLocalAddress21428 = @__env.GetMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "isAnyLocalAddress", "()Z");
			global::java.net.Inet6Address._isMulticastAddress21429 = @__env.GetMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "isMulticastAddress", "()Z");
			global::java.net.Inet6Address._isLoopbackAddress21430 = @__env.GetMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "isLoopbackAddress", "()Z");
			global::java.net.Inet6Address._isLinkLocalAddress21431 = @__env.GetMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "isLinkLocalAddress", "()Z");
			global::java.net.Inet6Address._isSiteLocalAddress21432 = @__env.GetMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "isSiteLocalAddress", "()Z");
			global::java.net.Inet6Address._isMCGlobal21433 = @__env.GetMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "isMCGlobal", "()Z");
			global::java.net.Inet6Address._isMCNodeLocal21434 = @__env.GetMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "isMCNodeLocal", "()Z");
			global::java.net.Inet6Address._isMCLinkLocal21435 = @__env.GetMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "isMCLinkLocal", "()Z");
			global::java.net.Inet6Address._isMCSiteLocal21436 = @__env.GetMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "isMCSiteLocal", "()Z");
			global::java.net.Inet6Address._isMCOrgLocal21437 = @__env.GetMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "isMCOrgLocal", "()Z");
			global::java.net.Inet6Address._getByAddress21438 = @__env.GetStaticMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "getByAddress", "(Ljava/lang/String;[BLjava/net/NetworkInterface;)Ljava/net/Inet6Address;");
			global::java.net.Inet6Address._getByAddress21439 = @__env.GetStaticMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "getByAddress", "(Ljava/lang/String;[BI)Ljava/net/Inet6Address;");
			global::java.net.Inet6Address._getScopeId21440 = @__env.GetMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "getScopeId", "()I");
			global::java.net.Inet6Address._getScopedInterface21441 = @__env.GetMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "getScopedInterface", "()Ljava/net/NetworkInterface;");
			global::java.net.Inet6Address._isIPv4CompatibleAddress21442 = @__env.GetMethodIDNoThrow(global::java.net.Inet6Address.staticClass, "isIPv4CompatibleAddress", "()Z");
		}
	}
}
