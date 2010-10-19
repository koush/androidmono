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
		internal static global::MonoJavaBridge.MethodId _equals25510;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute._equals25510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._equals25510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString25511;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute._toString25511)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._toString25511)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25512;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute._hashCode25512);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._hashCode25512);
		}
		internal static global::MonoJavaBridge.MethodId _clone25513;
		public global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute._clone25513)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._clone25513)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _isSecure25514;
		public bool isSecure() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute._isSecure25514);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._isSecure25514);
		}
		public new global::java.net.InetAddress LocalAddress
		{
			get
			{
				return getLocalAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalAddress25515;
		public global::java.net.InetAddress getLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute._getLocalAddress25515)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._getLocalAddress25515)) as java.net.InetAddress;
		}
		public new global::org.apache.http.HttpHost TargetHost
		{
			get
			{
				return getTargetHost();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTargetHost25516;
		public global::org.apache.http.HttpHost getTargetHost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute._getTargetHost25516)) as org.apache.http.HttpHost;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._getTargetHost25516)) as org.apache.http.HttpHost;
		}
		public new int HopCount
		{
			get
			{
				return getHopCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHopCount25517;
		public int getHopCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute._getHopCount25517);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._getHopCount25517);
		}
		internal static global::MonoJavaBridge.MethodId _getHopTarget25518;
		public global::org.apache.http.HttpHost getHopTarget(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute._getHopTarget25518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpHost;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._getHopTarget25518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpHost;
		}
		public new global::org.apache.http.HttpHost ProxyHost
		{
			get
			{
				return getProxyHost();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProxyHost25519;
		public global::org.apache.http.HttpHost getProxyHost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute._getProxyHost25519)) as org.apache.http.HttpHost;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._getProxyHost25519)) as org.apache.http.HttpHost;
		}
		public new global::org.apache.http.conn.routing.RouteInfo_TunnelType TunnelType
		{
			get
			{
				return getTunnelType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTunnelType25520;
		public global::org.apache.http.conn.routing.RouteInfo_TunnelType getTunnelType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute._getTunnelType25520)) as org.apache.http.conn.routing.RouteInfo_TunnelType;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._getTunnelType25520)) as org.apache.http.conn.routing.RouteInfo_TunnelType;
		}
		internal static global::MonoJavaBridge.MethodId _isTunnelled25521;
		public bool isTunnelled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute._isTunnelled25521);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._isTunnelled25521);
		}
		public new global::org.apache.http.conn.routing.RouteInfo_LayerType LayerType
		{
			get
			{
				return getLayerType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLayerType25522;
		public global::org.apache.http.conn.routing.RouteInfo_LayerType getLayerType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute._getLayerType25522)) as org.apache.http.conn.routing.RouteInfo_LayerType;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._getLayerType25522)) as org.apache.http.conn.routing.RouteInfo_LayerType;
		}
		internal static global::MonoJavaBridge.MethodId _isLayered25523;
		public bool isLayered() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute._isLayered25523);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._isLayered25523);
		}
		internal static global::MonoJavaBridge.MethodId _HttpRoute25524;
		public HttpRoute(org.apache.http.HttpHost arg0, java.net.InetAddress arg1, org.apache.http.HttpHost[] arg2, bool arg3, org.apache.http.conn.routing.RouteInfo_TunnelType arg4, org.apache.http.conn.routing.RouteInfo_LayerType arg5)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._HttpRoute25524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpRoute25525;
		public HttpRoute(org.apache.http.HttpHost arg0, java.net.InetAddress arg1, org.apache.http.HttpHost arg2, bool arg3, org.apache.http.conn.routing.RouteInfo_TunnelType arg4, org.apache.http.conn.routing.RouteInfo_LayerType arg5)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._HttpRoute25525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpRoute25526;
		public HttpRoute(org.apache.http.HttpHost arg0, java.net.InetAddress arg1, bool arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._HttpRoute25526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpRoute25527;
		public HttpRoute(org.apache.http.HttpHost arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._HttpRoute25527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpRoute25528;
		public HttpRoute(org.apache.http.HttpHost arg0, java.net.InetAddress arg1, org.apache.http.HttpHost arg2, bool arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._HttpRoute25528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.routing.HttpRoute.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/routing/HttpRoute"));
			global::org.apache.http.conn.routing.HttpRoute._equals25510 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::org.apache.http.conn.routing.HttpRoute._toString25511 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.conn.routing.HttpRoute._hashCode25512 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "hashCode", "()I");
			global::org.apache.http.conn.routing.HttpRoute._clone25513 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "clone", "()Ljava/lang/Object;");
			global::org.apache.http.conn.routing.HttpRoute._isSecure25514 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "isSecure", "()Z");
			global::org.apache.http.conn.routing.HttpRoute._getLocalAddress25515 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.conn.routing.HttpRoute._getTargetHost25516 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "getTargetHost", "()Lorg/apache/http/HttpHost;");
			global::org.apache.http.conn.routing.HttpRoute._getHopCount25517 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "getHopCount", "()I");
			global::org.apache.http.conn.routing.HttpRoute._getHopTarget25518 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "getHopTarget", "(I)Lorg/apache/http/HttpHost;");
			global::org.apache.http.conn.routing.HttpRoute._getProxyHost25519 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "getProxyHost", "()Lorg/apache/http/HttpHost;");
			global::org.apache.http.conn.routing.HttpRoute._getTunnelType25520 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "getTunnelType", "()Lorg/apache/http/conn/routing/RouteInfo$TunnelType;");
			global::org.apache.http.conn.routing.HttpRoute._isTunnelled25521 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "isTunnelled", "()Z");
			global::org.apache.http.conn.routing.HttpRoute._getLayerType25522 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "getLayerType", "()Lorg/apache/http/conn/routing/RouteInfo$LayerType;");
			global::org.apache.http.conn.routing.HttpRoute._isLayered25523 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "isLayered", "()Z");
			global::org.apache.http.conn.routing.HttpRoute._HttpRoute25524 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "<init>", "(Lorg/apache/http/HttpHost;Ljava/net/InetAddress;[Lorg/apache/http/HttpHost;ZLorg/apache/http/conn/routing/RouteInfo$TunnelType;Lorg/apache/http/conn/routing/RouteInfo$LayerType;)V");
			global::org.apache.http.conn.routing.HttpRoute._HttpRoute25525 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "<init>", "(Lorg/apache/http/HttpHost;Ljava/net/InetAddress;Lorg/apache/http/HttpHost;ZLorg/apache/http/conn/routing/RouteInfo$TunnelType;Lorg/apache/http/conn/routing/RouteInfo$LayerType;)V");
			global::org.apache.http.conn.routing.HttpRoute._HttpRoute25526 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "<init>", "(Lorg/apache/http/HttpHost;Ljava/net/InetAddress;Z)V");
			global::org.apache.http.conn.routing.HttpRoute._HttpRoute25527 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "<init>", "(Lorg/apache/http/HttpHost;)V");
			global::org.apache.http.conn.routing.HttpRoute._HttpRoute25528 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoute.staticClass, "<init>", "(Lorg/apache/http/HttpHost;Ljava/net/InetAddress;Lorg/apache/http/HttpHost;Z)V");
		}
	}
}
