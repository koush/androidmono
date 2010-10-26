namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Inet4Address : java.net.InetAddress
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Inet4Address()
		{
			InitJNI();
		}
		internal Inet4Address(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals21528;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet4Address._equals21528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._equals21528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode21529;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Inet4Address._hashCode21529);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._hashCode21529);
		}
		public new byte[] Address
		{
			get
			{
				return getAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAddress21530;
		public sealed override byte[] getAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Inet4Address._getAddress21530)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._getAddress21530)) as byte[];
		}
		public new global::java.lang.String HostAddress
		{
			get
			{
				return getHostAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHostAddress21531;
		public sealed override global::java.lang.String getHostAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Inet4Address._getHostAddress21531)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._getHostAddress21531)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isAnyLocalAddress21532;
		public sealed override bool isAnyLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet4Address._isAnyLocalAddress21532);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._isAnyLocalAddress21532);
		}
		internal static global::MonoJavaBridge.MethodId _isMulticastAddress21533;
		public sealed override bool isMulticastAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet4Address._isMulticastAddress21533);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._isMulticastAddress21533);
		}
		internal static global::MonoJavaBridge.MethodId _isLoopbackAddress21534;
		public sealed override bool isLoopbackAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet4Address._isLoopbackAddress21534);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._isLoopbackAddress21534);
		}
		internal static global::MonoJavaBridge.MethodId _isLinkLocalAddress21535;
		public sealed override bool isLinkLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet4Address._isLinkLocalAddress21535);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._isLinkLocalAddress21535);
		}
		internal static global::MonoJavaBridge.MethodId _isSiteLocalAddress21536;
		public sealed override bool isSiteLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet4Address._isSiteLocalAddress21536);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._isSiteLocalAddress21536);
		}
		internal static global::MonoJavaBridge.MethodId _isMCGlobal21537;
		public sealed override bool isMCGlobal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet4Address._isMCGlobal21537);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._isMCGlobal21537);
		}
		internal static global::MonoJavaBridge.MethodId _isMCNodeLocal21538;
		public sealed override bool isMCNodeLocal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet4Address._isMCNodeLocal21538);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._isMCNodeLocal21538);
		}
		internal static global::MonoJavaBridge.MethodId _isMCLinkLocal21539;
		public sealed override bool isMCLinkLocal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet4Address._isMCLinkLocal21539);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._isMCLinkLocal21539);
		}
		internal static global::MonoJavaBridge.MethodId _isMCSiteLocal21540;
		public sealed override bool isMCSiteLocal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet4Address._isMCSiteLocal21540);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._isMCSiteLocal21540);
		}
		internal static global::MonoJavaBridge.MethodId _isMCOrgLocal21541;
		public sealed override bool isMCOrgLocal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet4Address._isMCOrgLocal21541);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._isMCOrgLocal21541);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.Inet4Address.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/Inet4Address"));
			global::java.net.Inet4Address._equals21528 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.net.Inet4Address._hashCode21529 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "hashCode", "()I");
			global::java.net.Inet4Address._getAddress21530 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "getAddress", "()[B");
			global::java.net.Inet4Address._getHostAddress21531 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "getHostAddress", "()Ljava/lang/String;");
			global::java.net.Inet4Address._isAnyLocalAddress21532 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "isAnyLocalAddress", "()Z");
			global::java.net.Inet4Address._isMulticastAddress21533 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "isMulticastAddress", "()Z");
			global::java.net.Inet4Address._isLoopbackAddress21534 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "isLoopbackAddress", "()Z");
			global::java.net.Inet4Address._isLinkLocalAddress21535 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "isLinkLocalAddress", "()Z");
			global::java.net.Inet4Address._isSiteLocalAddress21536 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "isSiteLocalAddress", "()Z");
			global::java.net.Inet4Address._isMCGlobal21537 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "isMCGlobal", "()Z");
			global::java.net.Inet4Address._isMCNodeLocal21538 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "isMCNodeLocal", "()Z");
			global::java.net.Inet4Address._isMCLinkLocal21539 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "isMCLinkLocal", "()Z");
			global::java.net.Inet4Address._isMCSiteLocal21540 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "isMCSiteLocal", "()Z");
			global::java.net.Inet4Address._isMCOrgLocal21541 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "isMCOrgLocal", "()Z");
		}
	}
}
