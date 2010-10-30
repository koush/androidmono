namespace org.apache.http.conn.routing
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.conn.routing.RouteInfo_))]
	public partial interface RouteInfo  : global::MonoJavaBridge.IJavaObject 
	{
		bool isSecure();
		global::java.net.InetAddress getLocalAddress();
		global::org.apache.http.HttpHost getTargetHost();
		int getHopCount();
		global::org.apache.http.HttpHost getHopTarget(int arg0);
		global::org.apache.http.HttpHost getProxyHost();
		global::org.apache.http.conn.routing.RouteInfo_TunnelType getTunnelType();
		bool isTunnelled();
		global::org.apache.http.conn.routing.RouteInfo_LayerType getLayerType();
		bool isLayered();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.conn.routing.RouteInfo))]
	internal sealed partial class RouteInfo_ : java.lang.Object, RouteInfo
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal RouteInfo_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isSecure32256;
		bool org.apache.http.conn.routing.RouteInfo.isSecure()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.routing.RouteInfo_.staticClass, "isSecure", "()Z", ref global::org.apache.http.conn.routing.RouteInfo_._isSecure32256);
		}
		internal static global::MonoJavaBridge.MethodId _getLocalAddress32257;
		global::java.net.InetAddress org.apache.http.conn.routing.RouteInfo.getLocalAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.conn.routing.RouteInfo_.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;", ref global::org.apache.http.conn.routing.RouteInfo_._getLocalAddress32257) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getTargetHost32258;
		global::org.apache.http.HttpHost org.apache.http.conn.routing.RouteInfo.getTargetHost()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.HttpHost>(this, global::org.apache.http.conn.routing.RouteInfo_.staticClass, "getTargetHost", "()Lorg/apache/http/HttpHost;", ref global::org.apache.http.conn.routing.RouteInfo_._getTargetHost32258) as org.apache.http.HttpHost;
		}
		internal static global::MonoJavaBridge.MethodId _getHopCount32259;
		int org.apache.http.conn.routing.RouteInfo.getHopCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.routing.RouteInfo_.staticClass, "getHopCount", "()I", ref global::org.apache.http.conn.routing.RouteInfo_._getHopCount32259);
		}
		internal static global::MonoJavaBridge.MethodId _getHopTarget32260;
		global::org.apache.http.HttpHost org.apache.http.conn.routing.RouteInfo.getHopTarget(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.HttpHost>(this, global::org.apache.http.conn.routing.RouteInfo_.staticClass, "getHopTarget", "(I)Lorg/apache/http/HttpHost;", ref global::org.apache.http.conn.routing.RouteInfo_._getHopTarget32260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.HttpHost;
		}
		internal static global::MonoJavaBridge.MethodId _getProxyHost32261;
		global::org.apache.http.HttpHost org.apache.http.conn.routing.RouteInfo.getProxyHost()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.HttpHost>(this, global::org.apache.http.conn.routing.RouteInfo_.staticClass, "getProxyHost", "()Lorg/apache/http/HttpHost;", ref global::org.apache.http.conn.routing.RouteInfo_._getProxyHost32261) as org.apache.http.HttpHost;
		}
		internal static global::MonoJavaBridge.MethodId _getTunnelType32262;
		global::org.apache.http.conn.routing.RouteInfo_TunnelType org.apache.http.conn.routing.RouteInfo.getTunnelType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.conn.routing.RouteInfo_TunnelType>(this, global::org.apache.http.conn.routing.RouteInfo_.staticClass, "getTunnelType", "()Lorg/apache/http/conn/routing/RouteInfo$TunnelType;", ref global::org.apache.http.conn.routing.RouteInfo_._getTunnelType32262) as org.apache.http.conn.routing.RouteInfo_TunnelType;
		}
		internal static global::MonoJavaBridge.MethodId _isTunnelled32263;
		bool org.apache.http.conn.routing.RouteInfo.isTunnelled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.routing.RouteInfo_.staticClass, "isTunnelled", "()Z", ref global::org.apache.http.conn.routing.RouteInfo_._isTunnelled32263);
		}
		internal static global::MonoJavaBridge.MethodId _getLayerType32264;
		global::org.apache.http.conn.routing.RouteInfo_LayerType org.apache.http.conn.routing.RouteInfo.getLayerType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.conn.routing.RouteInfo_LayerType>(this, global::org.apache.http.conn.routing.RouteInfo_.staticClass, "getLayerType", "()Lorg/apache/http/conn/routing/RouteInfo$LayerType;", ref global::org.apache.http.conn.routing.RouteInfo_._getLayerType32264) as org.apache.http.conn.routing.RouteInfo_LayerType;
		}
		internal static global::MonoJavaBridge.MethodId _isLayered32265;
		bool org.apache.http.conn.routing.RouteInfo.isLayered()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.routing.RouteInfo_.staticClass, "isLayered", "()Z", ref global::org.apache.http.conn.routing.RouteInfo_._isLayered32265);
		}
		static RouteInfo_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.routing.RouteInfo_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/routing/RouteInfo"));
		}
		internal static void InitJNI()
		{
		}
	}
}
