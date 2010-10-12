namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InetAddress : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InetAddress()
		{
			InitJNI();
		}
		protected InetAddress(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals13679;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._equals13679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._equals13679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString13680;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.InetAddress._toString13680)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._toString13680)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode13681;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.InetAddress._hashCode13681);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._hashCode13681);
		}
		internal static global::MonoJavaBridge.MethodId _getAddress13682;
		public virtual byte[] getAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.InetAddress._getAddress13682)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._getAddress13682)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getHostName13683;
		public virtual global::java.lang.String getHostName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.InetAddress._getHostName13683)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._getHostName13683)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getHostAddress13684;
		public virtual global::java.lang.String getHostAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.InetAddress._getHostAddress13684)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._getHostAddress13684)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getByName13685;
		public static global::java.net.InetAddress getByName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.InetAddress.staticClass, global::java.net.InetAddress._getByName13685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _isAnyLocalAddress13686;
		public virtual bool isAnyLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isAnyLocalAddress13686);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isAnyLocalAddress13686);
		}
		internal static global::MonoJavaBridge.MethodId _isMulticastAddress13687;
		public virtual bool isMulticastAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isMulticastAddress13687);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isMulticastAddress13687);
		}
		internal static global::MonoJavaBridge.MethodId _isLoopbackAddress13688;
		public virtual bool isLoopbackAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isLoopbackAddress13688);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isLoopbackAddress13688);
		}
		internal static global::MonoJavaBridge.MethodId _isLinkLocalAddress13689;
		public virtual bool isLinkLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isLinkLocalAddress13689);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isLinkLocalAddress13689);
		}
		internal static global::MonoJavaBridge.MethodId _isSiteLocalAddress13690;
		public virtual bool isSiteLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isSiteLocalAddress13690);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isSiteLocalAddress13690);
		}
		internal static global::MonoJavaBridge.MethodId _isMCGlobal13691;
		public virtual bool isMCGlobal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isMCGlobal13691);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isMCGlobal13691);
		}
		internal static global::MonoJavaBridge.MethodId _isMCNodeLocal13692;
		public virtual bool isMCNodeLocal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isMCNodeLocal13692);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isMCNodeLocal13692);
		}
		internal static global::MonoJavaBridge.MethodId _isMCLinkLocal13693;
		public virtual bool isMCLinkLocal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isMCLinkLocal13693);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isMCLinkLocal13693);
		}
		internal static global::MonoJavaBridge.MethodId _isMCSiteLocal13694;
		public virtual bool isMCSiteLocal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isMCSiteLocal13694);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isMCSiteLocal13694);
		}
		internal static global::MonoJavaBridge.MethodId _isMCOrgLocal13695;
		public virtual bool isMCOrgLocal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isMCOrgLocal13695);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isMCOrgLocal13695);
		}
		internal static global::MonoJavaBridge.MethodId _isReachable13696;
		public virtual bool isReachable(java.net.NetworkInterface arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isReachable13696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isReachable13696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isReachable13697;
		public virtual bool isReachable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isReachable13697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isReachable13697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCanonicalHostName13698;
		public virtual global::java.lang.String getCanonicalHostName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.InetAddress._getCanonicalHostName13698)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._getCanonicalHostName13698)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getByAddress13699;
		public static global::java.net.InetAddress getByAddress(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.InetAddress.staticClass, global::java.net.InetAddress._getByAddress13699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getByAddress13700;
		public static global::java.net.InetAddress getByAddress(java.lang.String arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.InetAddress.staticClass, global::java.net.InetAddress._getByAddress13700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getAllByName13701;
		public static global::java.net.InetAddress[] getAllByName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.net.InetAddress>(@__env.CallStaticObjectMethod(java.net.InetAddress.staticClass, global::java.net.InetAddress._getAllByName13701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.InetAddress[];
		}
		internal static global::MonoJavaBridge.MethodId _getLocalHost13702;
		public static global::java.net.InetAddress getLocalHost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.InetAddress.staticClass, global::java.net.InetAddress._getLocalHost13702)) as java.net.InetAddress;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.InetAddress.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/InetAddress"));
			global::java.net.InetAddress._equals13679 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.net.InetAddress._toString13680 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "toString", "()Ljava/lang/String;");
			global::java.net.InetAddress._hashCode13681 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "hashCode", "()I");
			global::java.net.InetAddress._getAddress13682 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getAddress", "()[B");
			global::java.net.InetAddress._getHostName13683 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getHostName", "()Ljava/lang/String;");
			global::java.net.InetAddress._getHostAddress13684 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getHostAddress", "()Ljava/lang/String;");
			global::java.net.InetAddress._getByName13685 = @__env.GetStaticMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getByName", "(Ljava/lang/String;)Ljava/net/InetAddress;");
			global::java.net.InetAddress._isAnyLocalAddress13686 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isAnyLocalAddress", "()Z");
			global::java.net.InetAddress._isMulticastAddress13687 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isMulticastAddress", "()Z");
			global::java.net.InetAddress._isLoopbackAddress13688 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isLoopbackAddress", "()Z");
			global::java.net.InetAddress._isLinkLocalAddress13689 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isLinkLocalAddress", "()Z");
			global::java.net.InetAddress._isSiteLocalAddress13690 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isSiteLocalAddress", "()Z");
			global::java.net.InetAddress._isMCGlobal13691 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isMCGlobal", "()Z");
			global::java.net.InetAddress._isMCNodeLocal13692 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isMCNodeLocal", "()Z");
			global::java.net.InetAddress._isMCLinkLocal13693 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isMCLinkLocal", "()Z");
			global::java.net.InetAddress._isMCSiteLocal13694 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isMCSiteLocal", "()Z");
			global::java.net.InetAddress._isMCOrgLocal13695 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isMCOrgLocal", "()Z");
			global::java.net.InetAddress._isReachable13696 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isReachable", "(Ljava/net/NetworkInterface;II)Z");
			global::java.net.InetAddress._isReachable13697 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isReachable", "(I)Z");
			global::java.net.InetAddress._getCanonicalHostName13698 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getCanonicalHostName", "()Ljava/lang/String;");
			global::java.net.InetAddress._getByAddress13699 = @__env.GetStaticMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getByAddress", "([B)Ljava/net/InetAddress;");
			global::java.net.InetAddress._getByAddress13700 = @__env.GetStaticMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getByAddress", "(Ljava/lang/String;[B)Ljava/net/InetAddress;");
			global::java.net.InetAddress._getAllByName13701 = @__env.GetStaticMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getAllByName", "(Ljava/lang/String;)[Ljava/net/InetAddress;");
			global::java.net.InetAddress._getLocalHost13702 = @__env.GetStaticMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getLocalHost", "()Ljava/net/InetAddress;");
		}
	}
}
