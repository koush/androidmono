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
		internal static global::MonoJavaBridge.MethodId _equals21410;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet4Address._equals21410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._equals21410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode21411;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Inet4Address._hashCode21411);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._hashCode21411);
		}
		public new byte[] Address
		{
			get
			{
				return getAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAddress21412;
		public sealed override byte[] getAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Inet4Address._getAddress21412)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._getAddress21412)) as byte[];
		}
		public new global::java.lang.String HostAddress
		{
			get
			{
				return getHostAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHostAddress21413;
		public sealed override global::java.lang.String getHostAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Inet4Address._getHostAddress21413)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._getHostAddress21413)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isAnyLocalAddress21414;
		public sealed override bool isAnyLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet4Address._isAnyLocalAddress21414);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._isAnyLocalAddress21414);
		}
		internal static global::MonoJavaBridge.MethodId _isMulticastAddress21415;
		public sealed override bool isMulticastAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet4Address._isMulticastAddress21415);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._isMulticastAddress21415);
		}
		internal static global::MonoJavaBridge.MethodId _isLoopbackAddress21416;
		public sealed override bool isLoopbackAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet4Address._isLoopbackAddress21416);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._isLoopbackAddress21416);
		}
		internal static global::MonoJavaBridge.MethodId _isLinkLocalAddress21417;
		public sealed override bool isLinkLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet4Address._isLinkLocalAddress21417);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._isLinkLocalAddress21417);
		}
		internal static global::MonoJavaBridge.MethodId _isSiteLocalAddress21418;
		public sealed override bool isSiteLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet4Address._isSiteLocalAddress21418);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._isSiteLocalAddress21418);
		}
		internal static global::MonoJavaBridge.MethodId _isMCGlobal21419;
		public sealed override bool isMCGlobal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet4Address._isMCGlobal21419);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._isMCGlobal21419);
		}
		internal static global::MonoJavaBridge.MethodId _isMCNodeLocal21420;
		public sealed override bool isMCNodeLocal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet4Address._isMCNodeLocal21420);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._isMCNodeLocal21420);
		}
		internal static global::MonoJavaBridge.MethodId _isMCLinkLocal21421;
		public sealed override bool isMCLinkLocal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet4Address._isMCLinkLocal21421);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._isMCLinkLocal21421);
		}
		internal static global::MonoJavaBridge.MethodId _isMCSiteLocal21422;
		public sealed override bool isMCSiteLocal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet4Address._isMCSiteLocal21422);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._isMCSiteLocal21422);
		}
		internal static global::MonoJavaBridge.MethodId _isMCOrgLocal21423;
		public sealed override bool isMCOrgLocal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet4Address._isMCOrgLocal21423);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._isMCOrgLocal21423);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.Inet4Address.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/Inet4Address"));
			global::java.net.Inet4Address._equals21410 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.net.Inet4Address._hashCode21411 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "hashCode", "()I");
			global::java.net.Inet4Address._getAddress21412 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "getAddress", "()[B");
			global::java.net.Inet4Address._getHostAddress21413 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "getHostAddress", "()Ljava/lang/String;");
			global::java.net.Inet4Address._isAnyLocalAddress21414 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "isAnyLocalAddress", "()Z");
			global::java.net.Inet4Address._isMulticastAddress21415 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "isMulticastAddress", "()Z");
			global::java.net.Inet4Address._isLoopbackAddress21416 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "isLoopbackAddress", "()Z");
			global::java.net.Inet4Address._isLinkLocalAddress21417 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "isLinkLocalAddress", "()Z");
			global::java.net.Inet4Address._isSiteLocalAddress21418 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "isSiteLocalAddress", "()Z");
			global::java.net.Inet4Address._isMCGlobal21419 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "isMCGlobal", "()Z");
			global::java.net.Inet4Address._isMCNodeLocal21420 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "isMCNodeLocal", "()Z");
			global::java.net.Inet4Address._isMCLinkLocal21421 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "isMCLinkLocal", "()Z");
			global::java.net.Inet4Address._isMCSiteLocal21422 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "isMCSiteLocal", "()Z");
			global::java.net.Inet4Address._isMCOrgLocal21423 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "isMCOrgLocal", "()Z");
		}
	}
}
