namespace org.apache.http.conn.routing
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class HttpRoute : java.lang.Object, RouteInfo, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpRoute(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals32220;
		public sealed override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.HttpRoute._equals32220.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.HttpRoute._equals32220 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._equals32220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString32221;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.HttpRoute._toString32221.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.HttpRoute._toString32221 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._toString32221)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode32222;
		public sealed override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.HttpRoute._hashCode32222.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.HttpRoute._hashCode32222 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "hashCode", "()I");
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._hashCode32222);
		}
		internal static global::MonoJavaBridge.MethodId _clone32223;
		public global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.HttpRoute._clone32223.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.HttpRoute._clone32223 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "clone", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._clone32223)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _isSecure32224;
		public bool isSecure()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.HttpRoute._isSecure32224.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.HttpRoute._isSecure32224 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "isSecure", "()Z");
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._isSecure32224);
		}
		public new global::java.net.InetAddress LocalAddress
		{
			get
			{
				return getLocalAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalAddress32225;
		public global::java.net.InetAddress getLocalAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.HttpRoute._getLocalAddress32225.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.HttpRoute._getLocalAddress32225 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._getLocalAddress32225)) as java.net.InetAddress;
		}
		public new global::org.apache.http.HttpHost TargetHost
		{
			get
			{
				return getTargetHost();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTargetHost32226;
		public global::org.apache.http.HttpHost getTargetHost()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.HttpRoute._getTargetHost32226.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.HttpRoute._getTargetHost32226 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "getTargetHost", "()Lorg/apache/http/HttpHost;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpHost>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._getTargetHost32226)) as org.apache.http.HttpHost;
		}
		public new int HopCount
		{
			get
			{
				return getHopCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHopCount32227;
		public int getHopCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.HttpRoute._getHopCount32227.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.HttpRoute._getHopCount32227 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "getHopCount", "()I");
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._getHopCount32227);
		}
		internal static global::MonoJavaBridge.MethodId _getHopTarget32228;
		public global::org.apache.http.HttpHost getHopTarget(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.HttpRoute._getHopTarget32228.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.HttpRoute._getHopTarget32228 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "getHopTarget", "(I)Lorg/apache/http/HttpHost;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpHost>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._getHopTarget32228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpHost;
		}
		public new global::org.apache.http.HttpHost ProxyHost
		{
			get
			{
				return getProxyHost();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProxyHost32229;
		public global::org.apache.http.HttpHost getProxyHost()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.HttpRoute._getProxyHost32229.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.HttpRoute._getProxyHost32229 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "getProxyHost", "()Lorg/apache/http/HttpHost;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpHost>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._getProxyHost32229)) as org.apache.http.HttpHost;
		}
		public new global::org.apache.http.conn.routing.RouteInfo_TunnelType TunnelType
		{
			get
			{
				return getTunnelType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTunnelType32230;
		public global::org.apache.http.conn.routing.RouteInfo_TunnelType getTunnelType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.HttpRoute._getTunnelType32230.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.HttpRoute._getTunnelType32230 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "getTunnelType", "()Lorg/apache/http/conn/routing/RouteInfo$TunnelType;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.RouteInfo_TunnelType>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._getTunnelType32230)) as org.apache.http.conn.routing.RouteInfo_TunnelType;
		}
		internal static global::MonoJavaBridge.MethodId _isTunnelled32231;
		public bool isTunnelled()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.HttpRoute._isTunnelled32231.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.HttpRoute._isTunnelled32231 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "isTunnelled", "()Z");
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._isTunnelled32231);
		}
		public new global::org.apache.http.conn.routing.RouteInfo_LayerType LayerType
		{
			get
			{
				return getLayerType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLayerType32232;
		public global::org.apache.http.conn.routing.RouteInfo_LayerType getLayerType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.HttpRoute._getLayerType32232.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.HttpRoute._getLayerType32232 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "getLayerType", "()Lorg/apache/http/conn/routing/RouteInfo$LayerType;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.RouteInfo_LayerType>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._getLayerType32232)) as org.apache.http.conn.routing.RouteInfo_LayerType;
		}
		internal static global::MonoJavaBridge.MethodId _isLayered32233;
		public bool isLayered()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.HttpRoute._isLayered32233.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.HttpRoute._isLayered32233 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "isLayered", "()Z");
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._isLayered32233);
		}
		internal static global::MonoJavaBridge.MethodId _HttpRoute32234;
		public HttpRoute(org.apache.http.HttpHost arg0, java.net.InetAddress arg1, org.apache.http.HttpHost[] arg2, bool arg3, org.apache.http.conn.routing.RouteInfo_TunnelType arg4, org.apache.http.conn.routing.RouteInfo_LayerType arg5) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.HttpRoute._HttpRoute32234.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.HttpRoute._HttpRoute32234 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "<init>", "(Lorg/apache/http/HttpHost;Ljava/net/InetAddress;[Lorg/apache/http/HttpHost;ZLorg/apache/http/conn/routing/RouteInfo$TunnelType;Lorg/apache/http/conn/routing/RouteInfo$LayerType;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._HttpRoute32234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpRoute32235;
		public HttpRoute(org.apache.http.HttpHost arg0, java.net.InetAddress arg1, org.apache.http.HttpHost arg2, bool arg3, org.apache.http.conn.routing.RouteInfo_TunnelType arg4, org.apache.http.conn.routing.RouteInfo_LayerType arg5) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.HttpRoute._HttpRoute32235.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.HttpRoute._HttpRoute32235 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "<init>", "(Lorg/apache/http/HttpHost;Ljava/net/InetAddress;Lorg/apache/http/HttpHost;ZLorg/apache/http/conn/routing/RouteInfo$TunnelType;Lorg/apache/http/conn/routing/RouteInfo$LayerType;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._HttpRoute32235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpRoute32236;
		public HttpRoute(org.apache.http.HttpHost arg0, java.net.InetAddress arg1, bool arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.HttpRoute._HttpRoute32236.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.HttpRoute._HttpRoute32236 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "<init>", "(Lorg/apache/http/HttpHost;Ljava/net/InetAddress;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._HttpRoute32236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpRoute32237;
		public HttpRoute(org.apache.http.HttpHost arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.HttpRoute._HttpRoute32237.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.HttpRoute._HttpRoute32237 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "<init>", "(Lorg/apache/http/HttpHost;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._HttpRoute32237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpRoute32238;
		public HttpRoute(org.apache.http.HttpHost arg0, java.net.InetAddress arg1, org.apache.http.HttpHost arg2, bool arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.HttpRoute._HttpRoute32238.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.HttpRoute._HttpRoute32238 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "<init>", "(Lorg/apache/http/HttpHost;Ljava/net/InetAddress;Lorg/apache/http/HttpHost;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._HttpRoute32238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static HttpRoute()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.routing.HttpRoute.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/routing/HttpRoute"));
		}
		internal static void InitJNI()
		{
		}
	}
}
