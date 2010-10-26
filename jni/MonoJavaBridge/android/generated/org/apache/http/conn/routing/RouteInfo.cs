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
		static RouteInfo_()
		{
			InitJNI();
		}
		internal RouteInfo_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isSecure32255;
		 bool org.apache.http.conn.routing.RouteInfo.isSecure() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_._isSecure32255);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_.staticClass, global::org.apache.http.conn.routing.RouteInfo_._isSecure32255);
		}
		internal static global::MonoJavaBridge.MethodId _getLocalAddress32256;
		 global::java.net.InetAddress org.apache.http.conn.routing.RouteInfo.getLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_._getLocalAddress32256)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_.staticClass, global::org.apache.http.conn.routing.RouteInfo_._getLocalAddress32256)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getTargetHost32257;
		 global::org.apache.http.HttpHost org.apache.http.conn.routing.RouteInfo.getTargetHost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpHost>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_._getTargetHost32257)) as org.apache.http.HttpHost;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpHost>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_.staticClass, global::org.apache.http.conn.routing.RouteInfo_._getTargetHost32257)) as org.apache.http.HttpHost;
		}
		internal static global::MonoJavaBridge.MethodId _getHopCount32258;
		 int org.apache.http.conn.routing.RouteInfo.getHopCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_._getHopCount32258);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_.staticClass, global::org.apache.http.conn.routing.RouteInfo_._getHopCount32258);
		}
		internal static global::MonoJavaBridge.MethodId _getHopTarget32259;
		 global::org.apache.http.HttpHost org.apache.http.conn.routing.RouteInfo.getHopTarget(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpHost>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_._getHopTarget32259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpHost;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpHost>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_.staticClass, global::org.apache.http.conn.routing.RouteInfo_._getHopTarget32259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpHost;
		}
		internal static global::MonoJavaBridge.MethodId _getProxyHost32260;
		 global::org.apache.http.HttpHost org.apache.http.conn.routing.RouteInfo.getProxyHost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpHost>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_._getProxyHost32260)) as org.apache.http.HttpHost;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpHost>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_.staticClass, global::org.apache.http.conn.routing.RouteInfo_._getProxyHost32260)) as org.apache.http.HttpHost;
		}
		internal static global::MonoJavaBridge.MethodId _getTunnelType32261;
		 global::org.apache.http.conn.routing.RouteInfo_TunnelType org.apache.http.conn.routing.RouteInfo.getTunnelType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.RouteInfo_TunnelType>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_._getTunnelType32261)) as org.apache.http.conn.routing.RouteInfo_TunnelType;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.RouteInfo_TunnelType>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_.staticClass, global::org.apache.http.conn.routing.RouteInfo_._getTunnelType32261)) as org.apache.http.conn.routing.RouteInfo_TunnelType;
		}
		internal static global::MonoJavaBridge.MethodId _isTunnelled32262;
		 bool org.apache.http.conn.routing.RouteInfo.isTunnelled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_._isTunnelled32262);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_.staticClass, global::org.apache.http.conn.routing.RouteInfo_._isTunnelled32262);
		}
		internal static global::MonoJavaBridge.MethodId _getLayerType32263;
		 global::org.apache.http.conn.routing.RouteInfo_LayerType org.apache.http.conn.routing.RouteInfo.getLayerType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.RouteInfo_LayerType>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_._getLayerType32263)) as org.apache.http.conn.routing.RouteInfo_LayerType;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.RouteInfo_LayerType>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_.staticClass, global::org.apache.http.conn.routing.RouteInfo_._getLayerType32263)) as org.apache.http.conn.routing.RouteInfo_LayerType;
		}
		internal static global::MonoJavaBridge.MethodId _isLayered32264;
		 bool org.apache.http.conn.routing.RouteInfo.isLayered() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_._isLayered32264);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteInfo_.staticClass, global::org.apache.http.conn.routing.RouteInfo_._isLayered32264);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.routing.RouteInfo_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/routing/RouteInfo"));
			global::org.apache.http.conn.routing.RouteInfo_._isSecure32255 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_.staticClass, "isSecure", "()Z");
			global::org.apache.http.conn.routing.RouteInfo_._getLocalAddress32256 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.conn.routing.RouteInfo_._getTargetHost32257 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_.staticClass, "getTargetHost", "()Lorg/apache/http/HttpHost;");
			global::org.apache.http.conn.routing.RouteInfo_._getHopCount32258 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_.staticClass, "getHopCount", "()I");
			global::org.apache.http.conn.routing.RouteInfo_._getHopTarget32259 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_.staticClass, "getHopTarget", "(I)Lorg/apache/http/HttpHost;");
			global::org.apache.http.conn.routing.RouteInfo_._getProxyHost32260 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_.staticClass, "getProxyHost", "()Lorg/apache/http/HttpHost;");
			global::org.apache.http.conn.routing.RouteInfo_._getTunnelType32261 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_.staticClass, "getTunnelType", "()Lorg/apache/http/conn/routing/RouteInfo$TunnelType;");
			global::org.apache.http.conn.routing.RouteInfo_._isTunnelled32262 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_.staticClass, "isTunnelled", "()Z");
			global::org.apache.http.conn.routing.RouteInfo_._getLayerType32263 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_.staticClass, "getLayerType", "()Lorg/apache/http/conn/routing/RouteInfo$LayerType;");
			global::org.apache.http.conn.routing.RouteInfo_._isLayered32264 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_.staticClass, "isLayered", "()Z");
		}
	}
}
