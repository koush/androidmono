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
		internal static global::MonoJavaBridge.MethodId _equals15830;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet4Address._equals15830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._equals15830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode15831;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Inet4Address._hashCode15831);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._hashCode15831);
		}
		public new byte[] Address
		{
			get
			{
				return getAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAddress15832;
		public sealed override byte[] getAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Inet4Address._getAddress15832)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._getAddress15832)) as byte[];
		}
		public new global::java.lang.String HostAddress
		{
			get
			{
				return getHostAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHostAddress15833;
		public sealed override global::java.lang.String getHostAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Inet4Address._getHostAddress15833)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._getHostAddress15833)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isAnyLocalAddress15834;
		public sealed override bool isAnyLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet4Address._isAnyLocalAddress15834);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._isAnyLocalAddress15834);
		}
		internal static global::MonoJavaBridge.MethodId _isMulticastAddress15835;
		public sealed override bool isMulticastAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet4Address._isMulticastAddress15835);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._isMulticastAddress15835);
		}
		internal static global::MonoJavaBridge.MethodId _isLoopbackAddress15836;
		public sealed override bool isLoopbackAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet4Address._isLoopbackAddress15836);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._isLoopbackAddress15836);
		}
		internal static global::MonoJavaBridge.MethodId _isLinkLocalAddress15837;
		public sealed override bool isLinkLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet4Address._isLinkLocalAddress15837);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._isLinkLocalAddress15837);
		}
		internal static global::MonoJavaBridge.MethodId _isSiteLocalAddress15838;
		public sealed override bool isSiteLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet4Address._isSiteLocalAddress15838);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._isSiteLocalAddress15838);
		}
		internal static global::MonoJavaBridge.MethodId _isMCGlobal15839;
		public sealed override bool isMCGlobal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet4Address._isMCGlobal15839);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._isMCGlobal15839);
		}
		internal static global::MonoJavaBridge.MethodId _isMCNodeLocal15840;
		public sealed override bool isMCNodeLocal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet4Address._isMCNodeLocal15840);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._isMCNodeLocal15840);
		}
		internal static global::MonoJavaBridge.MethodId _isMCLinkLocal15841;
		public sealed override bool isMCLinkLocal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet4Address._isMCLinkLocal15841);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._isMCLinkLocal15841);
		}
		internal static global::MonoJavaBridge.MethodId _isMCSiteLocal15842;
		public sealed override bool isMCSiteLocal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet4Address._isMCSiteLocal15842);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._isMCSiteLocal15842);
		}
		internal static global::MonoJavaBridge.MethodId _isMCOrgLocal15843;
		public sealed override bool isMCOrgLocal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Inet4Address._isMCOrgLocal15843);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Inet4Address.staticClass, global::java.net.Inet4Address._isMCOrgLocal15843);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.Inet4Address.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/Inet4Address"));
			global::java.net.Inet4Address._equals15830 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.net.Inet4Address._hashCode15831 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "hashCode", "()I");
			global::java.net.Inet4Address._getAddress15832 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "getAddress", "()[B");
			global::java.net.Inet4Address._getHostAddress15833 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "getHostAddress", "()Ljava/lang/String;");
			global::java.net.Inet4Address._isAnyLocalAddress15834 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "isAnyLocalAddress", "()Z");
			global::java.net.Inet4Address._isMulticastAddress15835 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "isMulticastAddress", "()Z");
			global::java.net.Inet4Address._isLoopbackAddress15836 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "isLoopbackAddress", "()Z");
			global::java.net.Inet4Address._isLinkLocalAddress15837 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "isLinkLocalAddress", "()Z");
			global::java.net.Inet4Address._isSiteLocalAddress15838 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "isSiteLocalAddress", "()Z");
			global::java.net.Inet4Address._isMCGlobal15839 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "isMCGlobal", "()Z");
			global::java.net.Inet4Address._isMCNodeLocal15840 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "isMCNodeLocal", "()Z");
			global::java.net.Inet4Address._isMCLinkLocal15841 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "isMCLinkLocal", "()Z");
			global::java.net.Inet4Address._isMCSiteLocal15842 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "isMCSiteLocal", "()Z");
			global::java.net.Inet4Address._isMCOrgLocal15843 = @__env.GetMethodIDNoThrow(global::java.net.Inet4Address.staticClass, "isMCOrgLocal", "()Z");
		}
	}
}
