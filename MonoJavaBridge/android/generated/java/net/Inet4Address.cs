namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Inet4Address : java.net.InetAddress
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Inet4Address(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals21529;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Inet4Address.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.net.Inet4Address._equals21529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode21530;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.Inet4Address.staticClass, "hashCode", "()I", ref global::java.net.Inet4Address._hashCode21530);
		}
		public new byte[] Address
		{
			get
			{
				return getAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAddress21531;
		public sealed override byte[] getAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.net.Inet4Address.staticClass, "getAddress", "()[B", ref global::java.net.Inet4Address._getAddress21531) as byte[];
		}
		public new global::java.lang.String HostAddress
		{
			get
			{
				return getHostAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHostAddress21532;
		public sealed override global::java.lang.String getHostAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.Inet4Address.staticClass, "getHostAddress", "()Ljava/lang/String;", ref global::java.net.Inet4Address._getHostAddress21532) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isAnyLocalAddress21533;
		public sealed override bool isAnyLocalAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Inet4Address.staticClass, "isAnyLocalAddress", "()Z", ref global::java.net.Inet4Address._isAnyLocalAddress21533);
		}
		internal static global::MonoJavaBridge.MethodId _isMulticastAddress21534;
		public sealed override bool isMulticastAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Inet4Address.staticClass, "isMulticastAddress", "()Z", ref global::java.net.Inet4Address._isMulticastAddress21534);
		}
		internal static global::MonoJavaBridge.MethodId _isLoopbackAddress21535;
		public sealed override bool isLoopbackAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Inet4Address.staticClass, "isLoopbackAddress", "()Z", ref global::java.net.Inet4Address._isLoopbackAddress21535);
		}
		internal static global::MonoJavaBridge.MethodId _isLinkLocalAddress21536;
		public sealed override bool isLinkLocalAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Inet4Address.staticClass, "isLinkLocalAddress", "()Z", ref global::java.net.Inet4Address._isLinkLocalAddress21536);
		}
		internal static global::MonoJavaBridge.MethodId _isSiteLocalAddress21537;
		public sealed override bool isSiteLocalAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Inet4Address.staticClass, "isSiteLocalAddress", "()Z", ref global::java.net.Inet4Address._isSiteLocalAddress21537);
		}
		internal static global::MonoJavaBridge.MethodId _isMCGlobal21538;
		public sealed override bool isMCGlobal()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Inet4Address.staticClass, "isMCGlobal", "()Z", ref global::java.net.Inet4Address._isMCGlobal21538);
		}
		internal static global::MonoJavaBridge.MethodId _isMCNodeLocal21539;
		public sealed override bool isMCNodeLocal()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Inet4Address.staticClass, "isMCNodeLocal", "()Z", ref global::java.net.Inet4Address._isMCNodeLocal21539);
		}
		internal static global::MonoJavaBridge.MethodId _isMCLinkLocal21540;
		public sealed override bool isMCLinkLocal()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Inet4Address.staticClass, "isMCLinkLocal", "()Z", ref global::java.net.Inet4Address._isMCLinkLocal21540);
		}
		internal static global::MonoJavaBridge.MethodId _isMCSiteLocal21541;
		public sealed override bool isMCSiteLocal()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Inet4Address.staticClass, "isMCSiteLocal", "()Z", ref global::java.net.Inet4Address._isMCSiteLocal21541);
		}
		internal static global::MonoJavaBridge.MethodId _isMCOrgLocal21542;
		public sealed override bool isMCOrgLocal()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Inet4Address.staticClass, "isMCOrgLocal", "()Z", ref global::java.net.Inet4Address._isMCOrgLocal21542);
		}
		static Inet4Address()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.Inet4Address.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/Inet4Address"));
		}
		internal static void InitJNI()
		{
		}
	}
}
