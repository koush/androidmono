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
		private static global::MonoJavaBridge.MethodId _m0;
		bool org.apache.http.conn.routing.RouteInfo.isSecure()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.routing.RouteInfo_.staticClass, "isSecure", "()Z", ref global::org.apache.http.conn.routing.RouteInfo_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.net.InetAddress org.apache.http.conn.routing.RouteInfo.getLocalAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.conn.routing.RouteInfo_.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;", ref global::org.apache.http.conn.routing.RouteInfo_._m1) as java.net.InetAddress;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::org.apache.http.HttpHost org.apache.http.conn.routing.RouteInfo.getTargetHost()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.HttpHost>(this, global::org.apache.http.conn.routing.RouteInfo_.staticClass, "getTargetHost", "()Lorg/apache/http/HttpHost;", ref global::org.apache.http.conn.routing.RouteInfo_._m2) as org.apache.http.HttpHost;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		int org.apache.http.conn.routing.RouteInfo.getHopCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.routing.RouteInfo_.staticClass, "getHopCount", "()I", ref global::org.apache.http.conn.routing.RouteInfo_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::org.apache.http.HttpHost org.apache.http.conn.routing.RouteInfo.getHopTarget(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.HttpHost>(this, global::org.apache.http.conn.routing.RouteInfo_.staticClass, "getHopTarget", "(I)Lorg/apache/http/HttpHost;", ref global::org.apache.http.conn.routing.RouteInfo_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.HttpHost;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		global::org.apache.http.HttpHost org.apache.http.conn.routing.RouteInfo.getProxyHost()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.HttpHost>(this, global::org.apache.http.conn.routing.RouteInfo_.staticClass, "getProxyHost", "()Lorg/apache/http/HttpHost;", ref global::org.apache.http.conn.routing.RouteInfo_._m5) as org.apache.http.HttpHost;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		global::org.apache.http.conn.routing.RouteInfo_TunnelType org.apache.http.conn.routing.RouteInfo.getTunnelType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.conn.routing.RouteInfo_TunnelType>(this, global::org.apache.http.conn.routing.RouteInfo_.staticClass, "getTunnelType", "()Lorg/apache/http/conn/routing/RouteInfo$TunnelType;", ref global::org.apache.http.conn.routing.RouteInfo_._m6) as org.apache.http.conn.routing.RouteInfo_TunnelType;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		bool org.apache.http.conn.routing.RouteInfo.isTunnelled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.routing.RouteInfo_.staticClass, "isTunnelled", "()Z", ref global::org.apache.http.conn.routing.RouteInfo_._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		global::org.apache.http.conn.routing.RouteInfo_LayerType org.apache.http.conn.routing.RouteInfo.getLayerType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.conn.routing.RouteInfo_LayerType>(this, global::org.apache.http.conn.routing.RouteInfo_.staticClass, "getLayerType", "()Lorg/apache/http/conn/routing/RouteInfo$LayerType;", ref global::org.apache.http.conn.routing.RouteInfo_._m8) as org.apache.http.conn.routing.RouteInfo_LayerType;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		bool org.apache.http.conn.routing.RouteInfo.isLayered()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.routing.RouteInfo_.staticClass, "isLayered", "()Z", ref global::org.apache.http.conn.routing.RouteInfo_._m9);
		}
		static RouteInfo_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.routing.RouteInfo_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/routing/RouteInfo"));
		}
	}
}
