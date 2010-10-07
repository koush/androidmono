namespace org.apache.http.conn.routing
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class HttpRoute : java.lang.Object, RouteInfo, java.lang.Cloneable
	{
		internal static global::java.lang.Class staticClass;
		static HttpRoute()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.apache.http.conn.routing.HttpRoute), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.apache.http.conn.routing.HttpRoute(@__env);
			}
		}
		internal HttpRoute(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals14443;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.conn.routing.HttpRoute._equals14443, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._equals14443, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString14444;
		public sealed override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.routing.HttpRoute._toString14444));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._toString14444));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode14445;
		public sealed override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.apache.http.conn.routing.HttpRoute._hashCode14445);
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._hashCode14445);
		}
		internal static global::net.sf.jni4net.jni.MethodId _clone14446;
		public global::java.lang.Object clone() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.routing.HttpRoute._clone14446));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._clone14446));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isSecure14447;
		public bool isSecure() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.conn.routing.HttpRoute._isSecure14447);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._isSecure14447);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLocalAddress14448;
		public global::java.net.InetAddress getLocalAddress() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.routing.HttpRoute._getLocalAddress14448));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._getLocalAddress14448));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTargetHost14449;
		public global::org.apache.http.HttpHost getTargetHost() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.HttpHost>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.routing.HttpRoute._getTargetHost14449));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.HttpHost>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._getTargetHost14449));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHopCount14450;
		public int getHopCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.apache.http.conn.routing.HttpRoute._getHopCount14450);
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._getHopCount14450);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHopTarget14451;
		public global::org.apache.http.HttpHost getHopTarget(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.HttpHost>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.routing.HttpRoute._getHopTarget14451, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.HttpHost>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._getHopTarget14451, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getProxyHost14452;
		public global::org.apache.http.HttpHost getProxyHost() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.HttpHost>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.routing.HttpRoute._getProxyHost14452));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.HttpHost>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._getProxyHost14452));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTunnelType14453;
		public global::org.apache.http.conn.routing.RouteInfo_TunnelType getTunnelType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.conn.routing.RouteInfo_TunnelType>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.routing.HttpRoute._getTunnelType14453));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.conn.routing.RouteInfo_TunnelType>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._getTunnelType14453));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isTunnelled14454;
		public bool isTunnelled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.conn.routing.HttpRoute._isTunnelled14454);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._isTunnelled14454);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLayerType14455;
		public global::org.apache.http.conn.routing.RouteInfo_LayerType getLayerType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.conn.routing.RouteInfo_LayerType>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.routing.HttpRoute._getLayerType14455));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.conn.routing.RouteInfo_LayerType>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._getLayerType14455));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isLayered14456;
		public bool isLayered() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.conn.routing.HttpRoute._isLayered14456);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._isLayered14456);
		}
		internal static global::net.sf.jni4net.jni.MethodId _HttpRoute14457;
		public HttpRoute(org.apache.http.HttpHost arg0, java.net.InetAddress arg1, org.apache.http.HttpHost[] arg2, bool arg3, org.apache.http.conn.routing.RouteInfo_TunnelType arg4, org.apache.http.conn.routing.RouteInfo_LayerType arg5)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._HttpRoute14457, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _HttpRoute14458;
		public HttpRoute(org.apache.http.HttpHost arg0, java.net.InetAddress arg1, org.apache.http.HttpHost arg2, bool arg3, org.apache.http.conn.routing.RouteInfo_TunnelType arg4, org.apache.http.conn.routing.RouteInfo_LayerType arg5)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._HttpRoute14458, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _HttpRoute14459;
		public HttpRoute(org.apache.http.HttpHost arg0, java.net.InetAddress arg1, bool arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._HttpRoute14459, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _HttpRoute14460;
		public HttpRoute(org.apache.http.HttpHost arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._HttpRoute14460, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _HttpRoute14461;
		public HttpRoute(org.apache.http.HttpHost arg0, java.net.InetAddress arg1, org.apache.http.HttpHost arg2, bool arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(org.apache.http.conn.routing.HttpRoute.staticClass, global::org.apache.http.conn.routing.HttpRoute._HttpRoute14461, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.apache.http.conn.routing.HttpRoute.staticClass = @__class;
			global::org.apache.http.conn.routing.HttpRoute._equals14443 = @__env.GetMethodID(global::org.apache.http.conn.routing.HttpRoute.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::org.apache.http.conn.routing.HttpRoute._toString14444 = @__env.GetMethodID(global::org.apache.http.conn.routing.HttpRoute.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.conn.routing.HttpRoute._hashCode14445 = @__env.GetMethodID(global::org.apache.http.conn.routing.HttpRoute.staticClass, "hashCode", "()I");
			global::org.apache.http.conn.routing.HttpRoute._clone14446 = @__env.GetMethodID(global::org.apache.http.conn.routing.HttpRoute.staticClass, "clone", "()Ljava/lang/Object;");
			global::org.apache.http.conn.routing.HttpRoute._isSecure14447 = @__env.GetMethodID(global::org.apache.http.conn.routing.HttpRoute.staticClass, "isSecure", "()Z");
			global::org.apache.http.conn.routing.HttpRoute._getLocalAddress14448 = @__env.GetMethodID(global::org.apache.http.conn.routing.HttpRoute.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.conn.routing.HttpRoute._getTargetHost14449 = @__env.GetMethodID(global::org.apache.http.conn.routing.HttpRoute.staticClass, "getTargetHost", "()Lorg/apache/http/HttpHost;");
			global::org.apache.http.conn.routing.HttpRoute._getHopCount14450 = @__env.GetMethodID(global::org.apache.http.conn.routing.HttpRoute.staticClass, "getHopCount", "()I");
			global::org.apache.http.conn.routing.HttpRoute._getHopTarget14451 = @__env.GetMethodID(global::org.apache.http.conn.routing.HttpRoute.staticClass, "getHopTarget", "(I)Lorg/apache/http/HttpHost;");
			global::org.apache.http.conn.routing.HttpRoute._getProxyHost14452 = @__env.GetMethodID(global::org.apache.http.conn.routing.HttpRoute.staticClass, "getProxyHost", "()Lorg/apache/http/HttpHost;");
			global::org.apache.http.conn.routing.HttpRoute._getTunnelType14453 = @__env.GetMethodID(global::org.apache.http.conn.routing.HttpRoute.staticClass, "getTunnelType", "()Lorg/apache/http/conn/routing/RouteInfo$TunnelType;");
			global::org.apache.http.conn.routing.HttpRoute._isTunnelled14454 = @__env.GetMethodID(global::org.apache.http.conn.routing.HttpRoute.staticClass, "isTunnelled", "()Z");
			global::org.apache.http.conn.routing.HttpRoute._getLayerType14455 = @__env.GetMethodID(global::org.apache.http.conn.routing.HttpRoute.staticClass, "getLayerType", "()Lorg/apache/http/conn/routing/RouteInfo$LayerType;");
			global::org.apache.http.conn.routing.HttpRoute._isLayered14456 = @__env.GetMethodID(global::org.apache.http.conn.routing.HttpRoute.staticClass, "isLayered", "()Z");
			global::org.apache.http.conn.routing.HttpRoute._HttpRoute14457 = @__env.GetMethodID(global::org.apache.http.conn.routing.HttpRoute.staticClass, "<init>", "(Lorg/apache/http/HttpHost;Ljava/net/InetAddress;[Lorg/apache/http/HttpHost;ZLorg/apache/http/conn/routing/RouteInfo$TunnelType;Lorg/apache/http/conn/routing/RouteInfo$LayerType;)V");
			global::org.apache.http.conn.routing.HttpRoute._HttpRoute14458 = @__env.GetMethodID(global::org.apache.http.conn.routing.HttpRoute.staticClass, "<init>", "(Lorg/apache/http/HttpHost;Ljava/net/InetAddress;Lorg/apache/http/HttpHost;ZLorg/apache/http/conn/routing/RouteInfo$TunnelType;Lorg/apache/http/conn/routing/RouteInfo$LayerType;)V");
			global::org.apache.http.conn.routing.HttpRoute._HttpRoute14459 = @__env.GetMethodID(global::org.apache.http.conn.routing.HttpRoute.staticClass, "<init>", "(Lorg/apache/http/HttpHost;Ljava/net/InetAddress;Z)V");
			global::org.apache.http.conn.routing.HttpRoute._HttpRoute14460 = @__env.GetMethodID(global::org.apache.http.conn.routing.HttpRoute.staticClass, "<init>", "(Lorg/apache/http/HttpHost;)V");
			global::org.apache.http.conn.routing.HttpRoute._HttpRoute14461 = @__env.GetMethodID(global::org.apache.http.conn.routing.HttpRoute.staticClass, "<init>", "(Lorg/apache/http/HttpHost;Ljava/net/InetAddress;Lorg/apache/http/HttpHost;Z)V");
		}
	}
}
