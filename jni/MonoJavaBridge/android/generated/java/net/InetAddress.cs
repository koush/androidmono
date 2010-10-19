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
		internal static global::MonoJavaBridge.MethodId _equals15863;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._equals15863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._equals15863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString15864;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.InetAddress._toString15864)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._toString15864)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode15865;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.InetAddress._hashCode15865);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._hashCode15865);
		}
		public new byte[] Address
		{
			get
			{
				return getAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAddress15866;
		public virtual byte[] getAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.InetAddress._getAddress15866)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._getAddress15866)) as byte[];
		}
		public new global::java.lang.String HostName
		{
			get
			{
				return getHostName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHostName15867;
		public virtual global::java.lang.String getHostName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.InetAddress._getHostName15867)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._getHostName15867)) as java.lang.String;
		}
		public new global::java.lang.String HostAddress
		{
			get
			{
				return getHostAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHostAddress15868;
		public virtual global::java.lang.String getHostAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.InetAddress._getHostAddress15868)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._getHostAddress15868)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getByName15869;
		public static global::java.net.InetAddress getByName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.InetAddress.staticClass, global::java.net.InetAddress._getByName15869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _isAnyLocalAddress15870;
		public virtual bool isAnyLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isAnyLocalAddress15870);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isAnyLocalAddress15870);
		}
		internal static global::MonoJavaBridge.MethodId _isMulticastAddress15871;
		public virtual bool isMulticastAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isMulticastAddress15871);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isMulticastAddress15871);
		}
		internal static global::MonoJavaBridge.MethodId _isLoopbackAddress15872;
		public virtual bool isLoopbackAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isLoopbackAddress15872);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isLoopbackAddress15872);
		}
		internal static global::MonoJavaBridge.MethodId _isLinkLocalAddress15873;
		public virtual bool isLinkLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isLinkLocalAddress15873);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isLinkLocalAddress15873);
		}
		internal static global::MonoJavaBridge.MethodId _isSiteLocalAddress15874;
		public virtual bool isSiteLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isSiteLocalAddress15874);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isSiteLocalAddress15874);
		}
		internal static global::MonoJavaBridge.MethodId _isMCGlobal15875;
		public virtual bool isMCGlobal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isMCGlobal15875);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isMCGlobal15875);
		}
		internal static global::MonoJavaBridge.MethodId _isMCNodeLocal15876;
		public virtual bool isMCNodeLocal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isMCNodeLocal15876);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isMCNodeLocal15876);
		}
		internal static global::MonoJavaBridge.MethodId _isMCLinkLocal15877;
		public virtual bool isMCLinkLocal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isMCLinkLocal15877);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isMCLinkLocal15877);
		}
		internal static global::MonoJavaBridge.MethodId _isMCSiteLocal15878;
		public virtual bool isMCSiteLocal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isMCSiteLocal15878);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isMCSiteLocal15878);
		}
		internal static global::MonoJavaBridge.MethodId _isMCOrgLocal15879;
		public virtual bool isMCOrgLocal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isMCOrgLocal15879);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isMCOrgLocal15879);
		}
		internal static global::MonoJavaBridge.MethodId _isReachable15880;
		public virtual bool isReachable(java.net.NetworkInterface arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isReachable15880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isReachable15880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isReachable15881;
		public virtual bool isReachable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.InetAddress._isReachable15881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isReachable15881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String CanonicalHostName
		{
			get
			{
				return getCanonicalHostName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCanonicalHostName15882;
		public virtual global::java.lang.String getCanonicalHostName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.InetAddress._getCanonicalHostName15882)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._getCanonicalHostName15882)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getByAddress15883;
		public static global::java.net.InetAddress getByAddress(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.InetAddress.staticClass, global::java.net.InetAddress._getByAddress15883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getByAddress15884;
		public static global::java.net.InetAddress getByAddress(java.lang.String arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.InetAddress.staticClass, global::java.net.InetAddress._getByAddress15884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getAllByName15885;
		public static global::java.net.InetAddress[] getAllByName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.net.InetAddress>(@__env.CallStaticObjectMethod(java.net.InetAddress.staticClass, global::java.net.InetAddress._getAllByName15885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.InetAddress[];
		}
		public static global::java.net.InetAddress LocalHost
		{
			get
			{
				return getLocalHost();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalHost15886;
		public static global::java.net.InetAddress getLocalHost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.InetAddress.staticClass, global::java.net.InetAddress._getLocalHost15886)) as java.net.InetAddress;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.InetAddress.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/InetAddress"));
			global::java.net.InetAddress._equals15863 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.net.InetAddress._toString15864 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "toString", "()Ljava/lang/String;");
			global::java.net.InetAddress._hashCode15865 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "hashCode", "()I");
			global::java.net.InetAddress._getAddress15866 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getAddress", "()[B");
			global::java.net.InetAddress._getHostName15867 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getHostName", "()Ljava/lang/String;");
			global::java.net.InetAddress._getHostAddress15868 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getHostAddress", "()Ljava/lang/String;");
			global::java.net.InetAddress._getByName15869 = @__env.GetStaticMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getByName", "(Ljava/lang/String;)Ljava/net/InetAddress;");
			global::java.net.InetAddress._isAnyLocalAddress15870 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isAnyLocalAddress", "()Z");
			global::java.net.InetAddress._isMulticastAddress15871 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isMulticastAddress", "()Z");
			global::java.net.InetAddress._isLoopbackAddress15872 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isLoopbackAddress", "()Z");
			global::java.net.InetAddress._isLinkLocalAddress15873 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isLinkLocalAddress", "()Z");
			global::java.net.InetAddress._isSiteLocalAddress15874 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isSiteLocalAddress", "()Z");
			global::java.net.InetAddress._isMCGlobal15875 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isMCGlobal", "()Z");
			global::java.net.InetAddress._isMCNodeLocal15876 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isMCNodeLocal", "()Z");
			global::java.net.InetAddress._isMCLinkLocal15877 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isMCLinkLocal", "()Z");
			global::java.net.InetAddress._isMCSiteLocal15878 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isMCSiteLocal", "()Z");
			global::java.net.InetAddress._isMCOrgLocal15879 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isMCOrgLocal", "()Z");
			global::java.net.InetAddress._isReachable15880 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isReachable", "(Ljava/net/NetworkInterface;II)Z");
			global::java.net.InetAddress._isReachable15881 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "isReachable", "(I)Z");
			global::java.net.InetAddress._getCanonicalHostName15882 = @__env.GetMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getCanonicalHostName", "()Ljava/lang/String;");
			global::java.net.InetAddress._getByAddress15883 = @__env.GetStaticMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getByAddress", "([B)Ljava/net/InetAddress;");
			global::java.net.InetAddress._getByAddress15884 = @__env.GetStaticMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getByAddress", "(Ljava/lang/String;[B)Ljava/net/InetAddress;");
			global::java.net.InetAddress._getAllByName15885 = @__env.GetStaticMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getAllByName", "(Ljava/lang/String;)[Ljava/net/InetAddress;");
			global::java.net.InetAddress._getLocalHost15886 = @__env.GetStaticMethodIDNoThrow(global::java.net.InetAddress.staticClass, "getLocalHost", "()Ljava/net/InetAddress;");
		}
	}
}
