namespace org.apache.http.conn.routing
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class HttpRoute : java.lang.Object, RouteInfo, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpRoute()
		{
			InitJNI();
		}
		internal HttpRoute(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals32101;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute._equals32101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._equals32101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString32102;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute._toString32102)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._toString32102)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode32103;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute._hashCode32103);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._hashCode32103);
		}
		internal static global::MonoJavaBridge.MethodId _clone32104;
		public global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute._clone32104)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._clone32104)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _isSecure32105;
		public bool isSecure() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute._isSecure32105);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._isSecure32105);
		}
		public new global::java.net.InetAddress LocalAddress
		{
			get
			{
				return getLocalAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalAddress32106;
		public global::java.net.InetAddress getLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute._getLocalAddress32106)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._getLocalAddress32106)) as java.net.InetAddress;
		}
		public new global::org.apache.http.HttpHost TargetHost
		{
			get
			{
				return getTargetHost();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTargetHost32107;
		public global::org.apache.http.HttpHost getTargetHost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpHost>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute._getTargetHost32107)) as org.apache.http.HttpHost;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpHost>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._getTargetHost32107)) as org.apache.http.HttpHost;
		}
		public new int HopCount
		{
			get
			{
				return getHopCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHopCount32108;
		public int getHopCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute._getHopCount32108);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._getHopCount32108);
		}
		internal static global::MonoJavaBridge.MethodId _getHopTarget32109;
		public global::org.apache.http.HttpHost getHopTarget(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpHost>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute._getHopTarget32109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpHost;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpHost>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._getHopTarget32109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpHost;
		}
		public new global::org.apache.http.HttpHost ProxyHost
		{
			get
			{
				return getProxyHost();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProxyHost32110;
		public global::org.apache.http.HttpHost getProxyHost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpHost>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute._getProxyHost32110)) as org.apache.http.HttpHost;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpHost>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._getProxyHost32110)) as org.apache.http.HttpHost;
		}
		public new global::org.apache.http.conn.routing.RouteInfo_TunnelType TunnelType
		{
			get
			{
				return getTunnelType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTunnelType32111;
		public global::org.apache.http.conn.routing.RouteInfo_TunnelType getTunnelType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.RouteInfo_TunnelType>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute._getTunnelType32111)) as org.apache.http.conn.routing.RouteInfo_TunnelType;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.RouteInfo_TunnelType>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._getTunnelType32111)) as org.apache.http.conn.routing.RouteInfo_TunnelType;
		}
		internal static global::MonoJavaBridge.MethodId _isTunnelled32112;
		public bool isTunnelled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute._isTunnelled32112);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._isTunnelled32112);
		}
		public new global::org.apache.http.conn.routing.RouteInfo_LayerType LayerType
		{
			get
			{
				return getLayerType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLayerType32113;
		public global::org.apache.http.conn.routing.RouteInfo_LayerType getLayerType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.RouteInfo_LayerType>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute._getLayerType32113)) as org.apache.http.conn.routing.RouteInfo_LayerType;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.RouteInfo_LayerType>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._getLayerType32113)) as org.apache.http.conn.routing.RouteInfo_LayerType;
		}
		internal static global::MonoJavaBridge.MethodId _isLayered32114;
		public bool isLayered() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute._isLayered32114);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._isLayered32114);
		}
		internal static global::MonoJavaBridge.MethodId _HttpRoute32115;
		public HttpRoute(org.apache.http.HttpHost arg0, java.net.InetAddress arg1, org.apache.http.HttpHost[] arg2, bool arg3, org.apache.http.conn.routing.RouteInfo_TunnelType arg4, org.apache.http.conn.routing.RouteInfo_LayerType arg5)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._HttpRoute32115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpRoute32116;
		public HttpRoute(org.apache.http.HttpHost arg0, java.net.InetAddress arg1, org.apache.http.HttpHost arg2, bool arg3, org.apache.http.conn.routing.RouteInfo_TunnelType arg4, org.apache.http.conn.routing.RouteInfo_LayerType arg5)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._HttpRoute32116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpRoute32117;
		public HttpRoute(org.apache.http.HttpHost arg0, java.net.InetAddress arg1, bool arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._HttpRoute32117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpRoute32118;
		public HttpRoute(org.apache.http.HttpHost arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._HttpRoute32118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpRoute32119;
		public HttpRoute(org.apache.http.HttpHost arg0, java.net.InetAddress arg1, org.apache.http.HttpHost arg2, bool arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._HttpRoute32119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.routing.HttpRoute.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/routing/HttpRoute"));
			global::org.apache.http.conn.routing.HttpRoute._equals32101 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::org.apache.http.conn.routing.HttpRoute._toString32102 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.conn.routing.HttpRoute._hashCode32103 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "hashCode", "()I");
			global::org.apache.http.conn.routing.HttpRoute._clone32104 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "clone", "()Ljava/lang/Object;");
			global::org.apache.http.conn.routing.HttpRoute._isSecure32105 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "isSecure", "()Z");
			global::org.apache.http.conn.routing.HttpRoute._getLocalAddress32106 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.conn.routing.HttpRoute._getTargetHost32107 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "getTargetHost", "()Lorg/apache/http/HttpHost;");
			global::org.apache.http.conn.routing.HttpRoute._getHopCount32108 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "getHopCount", "()I");
			global::org.apache.http.conn.routing.HttpRoute._getHopTarget32109 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "getHopTarget", "(I)Lorg/apache/http/HttpHost;");
			global::org.apache.http.conn.routing.HttpRoute._getProxyHost32110 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "getProxyHost", "()Lorg/apache/http/HttpHost;");
			global::org.apache.http.conn.routing.HttpRoute._getTunnelType32111 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "getTunnelType", "()Lorg/apache/http/conn/routing/RouteInfo$TunnelType;");
			global::org.apache.http.conn.routing.HttpRoute._isTunnelled32112 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "isTunnelled", "()Z");
			global::org.apache.http.conn.routing.HttpRoute._getLayerType32113 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "getLayerType", "()Lorg/apache/http/conn/routing/RouteInfo$LayerType;");
			global::org.apache.http.conn.routing.HttpRoute._isLayered32114 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "isLayered", "()Z");
			global::org.apache.http.conn.routing.HttpRoute._HttpRoute32115 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "<init>", "(Lorg/apache/http/HttpHost;Ljava/net/InetAddress;[Lorg/apache/http/HttpHost;ZLorg/apache/http/conn/routing/RouteInfo$TunnelType;Lorg/apache/http/conn/routing/RouteInfo$LayerType;)V");
			global::org.apache.http.conn.routing.HttpRoute._HttpRoute32116 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "<init>", "(Lorg/apache/http/HttpHost;Ljava/net/InetAddress;Lorg/apache/http/HttpHost;ZLorg/apache/http/conn/routing/RouteInfo$TunnelType;Lorg/apache/http/conn/routing/RouteInfo$LayerType;)V");
			global::org.apache.http.conn.routing.HttpRoute._HttpRoute32117 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "<init>", "(Lorg/apache/http/HttpHost;Ljava/net/InetAddress;Z)V");
			global::org.apache.http.conn.routing.HttpRoute._HttpRoute32118 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "<init>", "(Lorg/apache/http/HttpHost;)V");
			global::org.apache.http.conn.routing.HttpRoute._HttpRoute32119 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "<init>", "(Lorg/apache/http/HttpHost;Ljava/net/InetAddress;Lorg/apache/http/HttpHost;Z)V");
		}
	}
}
