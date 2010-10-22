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
		internal static global::MonoJavaBridge.MethodId _equals21443;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._equals21443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._equals21443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString21444;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.InetAddress._toString21444)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._toString21444)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode21445;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.InetAddress._hashCode21445);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._hashCode21445);
		}
		public new byte[] Address
		{
			get
			{
				return getAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAddress21446;
		public virtual byte[] getAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.InetAddress._getAddress21446)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._getAddress21446)) as byte[];
		}
		public new global::java.lang.String HostName
		{
			get
			{
				return getHostName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHostName21447;
		public virtual global::java.lang.String getHostName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.InetAddress._getHostName21447)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._getHostName21447)) as java.lang.String;
		}
		public new global::java.lang.String HostAddress
		{
			get
			{
				return getHostAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHostAddress21448;
		public virtual global::java.lang.String getHostAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.InetAddress._getHostAddress21448)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._getHostAddress21448)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getByName21449;
		public static global::java.net.InetAddress getByName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.InetAddress.staticClass, global::java.net.InetAddress._getByName21449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _isAnyLocalAddress21450;
		public virtual bool isAnyLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isAnyLocalAddress21450);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isAnyLocalAddress21450);
		}
		internal static global::MonoJavaBridge.MethodId _isMulticastAddress21451;
		public virtual bool isMulticastAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isMulticastAddress21451);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isMulticastAddress21451);
		}
		internal static global::MonoJavaBridge.MethodId _isLoopbackAddress21452;
		public virtual bool isLoopbackAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isLoopbackAddress21452);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isLoopbackAddress21452);
		}
		internal static global::MonoJavaBridge.MethodId _isLinkLocalAddress21453;
		public virtual bool isLinkLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isLinkLocalAddress21453);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isLinkLocalAddress21453);
		}
		internal static global::MonoJavaBridge.MethodId _isSiteLocalAddress21454;
		public virtual bool isSiteLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isSiteLocalAddress21454);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isSiteLocalAddress21454);
		}
		internal static global::MonoJavaBridge.MethodId _isMCGlobal21455;
		public virtual bool isMCGlobal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isMCGlobal21455);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isMCGlobal21455);
		}
		internal static global::MonoJavaBridge.MethodId _isMCNodeLocal21456;
		public virtual bool isMCNodeLocal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isMCNodeLocal21456);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isMCNodeLocal21456);
		}
		internal static global::MonoJavaBridge.MethodId _isMCLinkLocal21457;
		public virtual bool isMCLinkLocal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isMCLinkLocal21457);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isMCLinkLocal21457);
		}
		internal static global::MonoJavaBridge.MethodId _isMCSiteLocal21458;
		public virtual bool isMCSiteLocal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isMCSiteLocal21458);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isMCSiteLocal21458);
		}
		internal static global::MonoJavaBridge.MethodId _isMCOrgLocal21459;
		public virtual bool isMCOrgLocal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isMCOrgLocal21459);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isMCOrgLocal21459);
		}
		internal static global::MonoJavaBridge.MethodId _isReachable21460;
		public virtual bool isReachable(java.net.NetworkInterface arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isReachable21460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isReachable21460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isReachable21461;
		public virtual bool isReachable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isReachable21461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isReachable21461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String CanonicalHostName
		{
			get
			{
				return getCanonicalHostName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCanonicalHostName21462;
		public virtual global::java.lang.String getCanonicalHostName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.InetAddress._getCanonicalHostName21462)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._getCanonicalHostName21462)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getByAddress21463;
		public static global::java.net.InetAddress getByAddress(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.InetAddress.staticClass, global::java.net.InetAddress._getByAddress21463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getByAddress21464;
		public static global::java.net.InetAddress getByAddress(java.lang.String arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.InetAddress.staticClass, global::java.net.InetAddress._getByAddress21464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getAllByName21465;
		public static global::java.net.InetAddress[] getAllByName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.net.InetAddress>(@__env.CallStaticObjectMethod(java.net.InetAddress.staticClass, global::java.net.InetAddress._getAllByName21465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.InetAddress[];
		}
		public static global::java.net.InetAddress LocalHost
		{
			get
			{
				return getLocalHost();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalHost21466;
		public static global::java.net.InetAddress getLocalHost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.InetAddress.staticClass, global::java.net.InetAddress._getLocalHost21466)) as java.net.InetAddress;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.InetAddress.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/InetAddress"));
			global::java.net.InetAddress._equals21443 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.net.InetAddress._toString21444 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "toString", "()Ljava/lang/String;");
			global::java.net.InetAddress._hashCode21445 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "hashCode", "()I");
			global::java.net.InetAddress._getAddress21446 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getAddress", "()[B");
			global::java.net.InetAddress._getHostName21447 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getHostName", "()Ljava/lang/String;");
			global::java.net.InetAddress._getHostAddress21448 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getHostAddress", "()Ljava/lang/String;");
			global::java.net.InetAddress._getByName21449 = @__env.GetStaticMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getByName", "(Ljava/lang/String;)Ljava/net/InetAddress;");
			global::java.net.InetAddress._isAnyLocalAddress21450 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isAnyLocalAddress", "()Z");
			global::java.net.InetAddress._isMulticastAddress21451 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isMulticastAddress", "()Z");
			global::java.net.InetAddress._isLoopbackAddress21452 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isLoopbackAddress", "()Z");
			global::java.net.InetAddress._isLinkLocalAddress21453 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isLinkLocalAddress", "()Z");
			global::java.net.InetAddress._isSiteLocalAddress21454 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isSiteLocalAddress", "()Z");
			global::java.net.InetAddress._isMCGlobal21455 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isMCGlobal", "()Z");
			global::java.net.InetAddress._isMCNodeLocal21456 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isMCNodeLocal", "()Z");
			global::java.net.InetAddress._isMCLinkLocal21457 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isMCLinkLocal", "()Z");
			global::java.net.InetAddress._isMCSiteLocal21458 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isMCSiteLocal", "()Z");
			global::java.net.InetAddress._isMCOrgLocal21459 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isMCOrgLocal", "()Z");
			global::java.net.InetAddress._isReachable21460 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isReachable", "(Ljava/net/NetworkInterface;II)Z");
			global::java.net.InetAddress._isReachable21461 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isReachable", "(I)Z");
			global::java.net.InetAddress._getCanonicalHostName21462 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getCanonicalHostName", "()Ljava/lang/String;");
			global::java.net.InetAddress._getByAddress21463 = @__env.GetStaticMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getByAddress", "([B)Ljava/net/InetAddress;");
			global::java.net.InetAddress._getByAddress21464 = @__env.GetStaticMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getByAddress", "(Ljava/lang/String;[B)Ljava/net/InetAddress;");
			global::java.net.InetAddress._getAllByName21465 = @__env.GetStaticMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getAllByName", "(Ljava/lang/String;)[Ljava/net/InetAddress;");
			global::java.net.InetAddress._getLocalHost21466 = @__env.GetStaticMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getLocalHost", "()Ljava/net/InetAddress;");
		}
	}
}
