namespace org.apache.http.conn.routing
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface RouteInfo 
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

	public partial class RouteInfo_
	{
		public static global::java.lang.Class _class
		{
			get { return __RouteInfo.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __RouteInfo : java.lang.Object, RouteInfo
	{
		internal static global::java.lang.Class staticClass;
		static __RouteInfo()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.apache.http.conn.routing.__RouteInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.apache.http.conn.routing.__RouteInfo(@__env);
			}
		}
		internal __RouteInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _isSecure14470;
		 bool org.apache.http.conn.routing.RouteInfo.isSecure() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.conn.routing.__RouteInfo._isSecure14470);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.conn.routing.__RouteInfo.staticClass, global::org.apache.http.conn.routing.__RouteInfo._isSecure14470);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLocalAddress14471;
		 global::java.net.InetAddress org.apache.http.conn.routing.RouteInfo.getLocalAddress() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.routing.__RouteInfo._getLocalAddress14471));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.routing.__RouteInfo.staticClass, global::org.apache.http.conn.routing.__RouteInfo._getLocalAddress14471));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTargetHost14472;
		 global::org.apache.http.HttpHost org.apache.http.conn.routing.RouteInfo.getTargetHost() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.HttpHost>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.routing.__RouteInfo._getTargetHost14472));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.HttpHost>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.routing.__RouteInfo.staticClass, global::org.apache.http.conn.routing.__RouteInfo._getTargetHost14472));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHopCount14473;
		 int org.apache.http.conn.routing.RouteInfo.getHopCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.apache.http.conn.routing.__RouteInfo._getHopCount14473);
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.apache.http.conn.routing.__RouteInfo.staticClass, global::org.apache.http.conn.routing.__RouteInfo._getHopCount14473);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHopTarget14474;
		 global::org.apache.http.HttpHost org.apache.http.conn.routing.RouteInfo.getHopTarget(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.HttpHost>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.routing.__RouteInfo._getHopTarget14474, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.HttpHost>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.routing.__RouteInfo.staticClass, global::org.apache.http.conn.routing.__RouteInfo._getHopTarget14474, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getProxyHost14475;
		 global::org.apache.http.HttpHost org.apache.http.conn.routing.RouteInfo.getProxyHost() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.HttpHost>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.routing.__RouteInfo._getProxyHost14475));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.HttpHost>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.routing.__RouteInfo.staticClass, global::org.apache.http.conn.routing.__RouteInfo._getProxyHost14475));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTunnelType14476;
		 global::org.apache.http.conn.routing.RouteInfo_TunnelType org.apache.http.conn.routing.RouteInfo.getTunnelType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.conn.routing.RouteInfo_TunnelType>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.routing.__RouteInfo._getTunnelType14476));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.conn.routing.RouteInfo_TunnelType>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.routing.__RouteInfo.staticClass, global::org.apache.http.conn.routing.__RouteInfo._getTunnelType14476));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isTunnelled14477;
		 bool org.apache.http.conn.routing.RouteInfo.isTunnelled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.conn.routing.__RouteInfo._isTunnelled14477);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.conn.routing.__RouteInfo.staticClass, global::org.apache.http.conn.routing.__RouteInfo._isTunnelled14477);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLayerType14478;
		 global::org.apache.http.conn.routing.RouteInfo_LayerType org.apache.http.conn.routing.RouteInfo.getLayerType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.conn.routing.RouteInfo_LayerType>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.routing.__RouteInfo._getLayerType14478));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.conn.routing.RouteInfo_LayerType>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.routing.__RouteInfo.staticClass, global::org.apache.http.conn.routing.__RouteInfo._getLayerType14478));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isLayered14479;
		 bool org.apache.http.conn.routing.RouteInfo.isLayered() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.conn.routing.__RouteInfo._isLayered14479);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.conn.routing.__RouteInfo.staticClass, global::org.apache.http.conn.routing.__RouteInfo._isLayered14479);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.apache.http.conn.routing.__RouteInfo.staticClass = @__class;
			global::org.apache.http.conn.routing.__RouteInfo._isSecure14470 = @__env.GetMethodID(global::org.apache.http.conn.routing.__RouteInfo.staticClass, "org.apache.http.conn.routing.RouteInfo.isSecure", "()Z");
			global::org.apache.http.conn.routing.__RouteInfo._getLocalAddress14471 = @__env.GetMethodID(global::org.apache.http.conn.routing.__RouteInfo.staticClass, "org.apache.http.conn.routing.RouteInfo.getLocalAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.conn.routing.__RouteInfo._getTargetHost14472 = @__env.GetMethodID(global::org.apache.http.conn.routing.__RouteInfo.staticClass, "org.apache.http.conn.routing.RouteInfo.getTargetHost", "()Lorg/apache/http/HttpHost;");
			global::org.apache.http.conn.routing.__RouteInfo._getHopCount14473 = @__env.GetMethodID(global::org.apache.http.conn.routing.__RouteInfo.staticClass, "org.apache.http.conn.routing.RouteInfo.getHopCount", "()I");
			global::org.apache.http.conn.routing.__RouteInfo._getHopTarget14474 = @__env.GetMethodID(global::org.apache.http.conn.routing.__RouteInfo.staticClass, "org.apache.http.conn.routing.RouteInfo.getHopTarget", "(I)Lorg/apache/http/HttpHost;");
			global::org.apache.http.conn.routing.__RouteInfo._getProxyHost14475 = @__env.GetMethodID(global::org.apache.http.conn.routing.__RouteInfo.staticClass, "org.apache.http.conn.routing.RouteInfo.getProxyHost", "()Lorg/apache/http/HttpHost;");
			global::org.apache.http.conn.routing.__RouteInfo._getTunnelType14476 = @__env.GetMethodID(global::org.apache.http.conn.routing.__RouteInfo.staticClass, "org.apache.http.conn.routing.RouteInfo.getTunnelType", "()Lorg/apache/http/conn/routing/RouteInfo$TunnelType;");
			global::org.apache.http.conn.routing.__RouteInfo._isTunnelled14477 = @__env.GetMethodID(global::org.apache.http.conn.routing.__RouteInfo.staticClass, "org.apache.http.conn.routing.RouteInfo.isTunnelled", "()Z");
			global::org.apache.http.conn.routing.__RouteInfo._getLayerType14478 = @__env.GetMethodID(global::org.apache.http.conn.routing.__RouteInfo.staticClass, "org.apache.http.conn.routing.RouteInfo.getLayerType", "()Lorg/apache/http/conn/routing/RouteInfo$LayerType;");
			global::org.apache.http.conn.routing.__RouteInfo._isLayered14479 = @__env.GetMethodID(global::org.apache.http.conn.routing.__RouteInfo.staticClass, "org.apache.http.conn.routing.RouteInfo.isLayered", "()Z");
		}
	}
}
