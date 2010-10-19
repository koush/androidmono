namespace org.apache.http.conn.routing
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.conn.routing.RouteInfo_))]
	public interface RouteInfo  : global::MonoJavaBridge.IJavaObject 
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
	public sealed partial class RouteInfo_ : java.lang.Object, RouteInfo
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RouteInfo_()
		{
			InitJNI();
		}
		internal RouteInfo_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isSecure25539;
		 bool org.apache.http.conn.routing.RouteInfo.isSecure() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_._isSecure25539);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_.staticClass, global::org.apache.http.conn.routing.RouteInfo_._isSecure25539);
		}
		internal static global::MonoJavaBridge.MethodId _getLocalAddress25540;
		 global::java.net.InetAddress org.apache.http.conn.routing.RouteInfo.getLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_._getLocalAddress25540)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_.staticClass, global::org.apache.http.conn.routing.RouteInfo_._getLocalAddress25540)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getTargetHost25541;
		 global::org.apache.http.HttpHost org.apache.http.conn.routing.RouteInfo.getTargetHost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_._getTargetHost25541)) as org.apache.http.HttpHost;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_.staticClass, global::org.apache.http.conn.routing.RouteInfo_._getTargetHost25541)) as org.apache.http.HttpHost;
		}
		internal static global::MonoJavaBridge.MethodId _getHopCount25542;
		 int org.apache.http.conn.routing.RouteInfo.getHopCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_._getHopCount25542);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_.staticClass, global::org.apache.http.conn.routing.RouteInfo_._getHopCount25542);
		}
		internal static global::MonoJavaBridge.MethodId _getHopTarget25543;
		 global::org.apache.http.HttpHost org.apache.http.conn.routing.RouteInfo.getHopTarget(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_._getHopTarget25543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpHost;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_.staticClass, global::org.apache.http.conn.routing.RouteInfo_._getHopTarget25543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpHost;
		}
		internal static global::MonoJavaBridge.MethodId _getProxyHost25544;
		 global::org.apache.http.HttpHost org.apache.http.conn.routing.RouteInfo.getProxyHost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_._getProxyHost25544)) as org.apache.http.HttpHost;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_.staticClass, global::org.apache.http.conn.routing.RouteInfo_._getProxyHost25544)) as org.apache.http.HttpHost;
		}
		internal static global::MonoJavaBridge.MethodId _getTunnelType25545;
		 global::org.apache.http.conn.routing.RouteInfo_TunnelType org.apache.http.conn.routing.RouteInfo.getTunnelType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_._getTunnelType25545)) as org.apache.http.conn.routing.RouteInfo_TunnelType;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_.staticClass, global::org.apache.http.conn.routing.RouteInfo_._getTunnelType25545)) as org.apache.http.conn.routing.RouteInfo_TunnelType;
		}
		internal static global::MonoJavaBridge.MethodId _isTunnelled25546;
		 bool org.apache.http.conn.routing.RouteInfo.isTunnelled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_._isTunnelled25546);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_.staticClass, global::org.apache.http.conn.routing.RouteInfo_._isTunnelled25546);
		}
		internal static global::MonoJavaBridge.MethodId _getLayerType25547;
		 global::org.apache.http.conn.routing.RouteInfo_LayerType org.apache.http.conn.routing.RouteInfo.getLayerType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_._getLayerType25547)) as org.apache.http.conn.routing.RouteInfo_LayerType;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_.staticClass, global::org.apache.http.conn.routing.RouteInfo_._getLayerType25547)) as org.apache.http.conn.routing.RouteInfo_LayerType;
		}
		internal static global::MonoJavaBridge.MethodId _isLayered25548;
		 bool org.apache.http.conn.routing.RouteInfo.isLayered() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_._isLayered25548);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_.staticClass, global::org.apache.http.conn.routing.RouteInfo_._isLayered25548);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.routing.RouteInfo_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/routing/RouteInfo"));
			global::org.apache.http.conn.routing.RouteInfo_._isSecure25539 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_.staticClass, "isSecure", "()Z");
			global::org.apache.http.conn.routing.RouteInfo_._getLocalAddress25540 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.conn.routing.RouteInfo_._getTargetHost25541 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_.staticClass, "getTargetHost", "()Lorg/apache/http/HttpHost;");
			global::org.apache.http.conn.routing.RouteInfo_._getHopCount25542 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_.staticClass, "getHopCount", "()I");
			global::org.apache.http.conn.routing.RouteInfo_._getHopTarget25543 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_.staticClass, "getHopTarget", "(I)Lorg/apache/http/HttpHost;");
			global::org.apache.http.conn.routing.RouteInfo_._getProxyHost25544 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_.staticClass, "getProxyHost", "()Lorg/apache/http/HttpHost;");
			global::org.apache.http.conn.routing.RouteInfo_._getTunnelType25545 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_.staticClass, "getTunnelType", "()Lorg/apache/http/conn/routing/RouteInfo$TunnelType;");
			global::org.apache.http.conn.routing.RouteInfo_._isTunnelled25546 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_.staticClass, "isTunnelled", "()Z");
			global::org.apache.http.conn.routing.RouteInfo_._getLayerType25547 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_.staticClass, "getLayerType", "()Lorg/apache/http/conn/routing/RouteInfo$LayerType;");
			global::org.apache.http.conn.routing.RouteInfo_._isLayered25548 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_.staticClass, "isLayered", "()Z");
		}
	}
}
