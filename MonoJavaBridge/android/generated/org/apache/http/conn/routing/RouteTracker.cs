namespace org.apache.http.conn.routing
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class RouteTracker : java.lang.Object, RouteInfo, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal RouteTracker(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals32266;
		public sealed override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.RouteTracker._equals32266.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.RouteTracker._equals32266 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._equals32266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString32267;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.RouteTracker._toString32267.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.RouteTracker._toString32267 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._toString32267)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode32268;
		public sealed override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.RouteTracker._hashCode32268.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.RouteTracker._hashCode32268 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "hashCode", "()I");
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._hashCode32268);
		}
		internal static global::MonoJavaBridge.MethodId _clone32269;
		public global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.RouteTracker._clone32269.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.RouteTracker._clone32269 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "clone", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._clone32269)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _isConnected32270;
		public bool isConnected()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.RouteTracker._isConnected32270.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.RouteTracker._isConnected32270 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "isConnected", "()Z");
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._isConnected32270);
		}
		internal static global::MonoJavaBridge.MethodId _isSecure32271;
		public bool isSecure()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.RouteTracker._isSecure32271.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.RouteTracker._isSecure32271 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "isSecure", "()Z");
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._isSecure32271);
		}
		public new global::java.net.InetAddress LocalAddress
		{
			get
			{
				return getLocalAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalAddress32272;
		public global::java.net.InetAddress getLocalAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.RouteTracker._getLocalAddress32272.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.RouteTracker._getLocalAddress32272 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._getLocalAddress32272)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _tunnelTarget32273;
		public void tunnelTarget(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.RouteTracker._tunnelTarget32273.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.RouteTracker._tunnelTarget32273 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "tunnelTarget", "(Z)V");
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._tunnelTarget32273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _tunnelProxy32274;
		public void tunnelProxy(org.apache.http.HttpHost arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.RouteTracker._tunnelProxy32274.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.RouteTracker._tunnelProxy32274 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "tunnelProxy", "(Lorg/apache/http/HttpHost;Z)V");
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._tunnelProxy32274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _layerProtocol32275;
		public void layerProtocol(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.RouteTracker._layerProtocol32275.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.RouteTracker._layerProtocol32275 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "layerProtocol", "(Z)V");
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._layerProtocol32275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.HttpHost TargetHost
		{
			get
			{
				return getTargetHost();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTargetHost32276;
		public global::org.apache.http.HttpHost getTargetHost()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.RouteTracker._getTargetHost32276.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.RouteTracker._getTargetHost32276 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "getTargetHost", "()Lorg/apache/http/HttpHost;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpHost>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._getTargetHost32276)) as org.apache.http.HttpHost;
		}
		public new int HopCount
		{
			get
			{
				return getHopCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHopCount32277;
		public int getHopCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.RouteTracker._getHopCount32277.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.RouteTracker._getHopCount32277 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "getHopCount", "()I");
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._getHopCount32277);
		}
		internal static global::MonoJavaBridge.MethodId _getHopTarget32278;
		public global::org.apache.http.HttpHost getHopTarget(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.RouteTracker._getHopTarget32278.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.RouteTracker._getHopTarget32278 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "getHopTarget", "(I)Lorg/apache/http/HttpHost;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpHost>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._getHopTarget32278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpHost;
		}
		public new global::org.apache.http.HttpHost ProxyHost
		{
			get
			{
				return getProxyHost();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProxyHost32279;
		public global::org.apache.http.HttpHost getProxyHost()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.RouteTracker._getProxyHost32279.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.RouteTracker._getProxyHost32279 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "getProxyHost", "()Lorg/apache/http/HttpHost;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpHost>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._getProxyHost32279)) as org.apache.http.HttpHost;
		}
		public new global::org.apache.http.conn.routing.RouteInfo_TunnelType TunnelType
		{
			get
			{
				return getTunnelType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTunnelType32280;
		public global::org.apache.http.conn.routing.RouteInfo_TunnelType getTunnelType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.RouteTracker._getTunnelType32280.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.RouteTracker._getTunnelType32280 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "getTunnelType", "()Lorg/apache/http/conn/routing/RouteInfo$TunnelType;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.RouteInfo_TunnelType>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._getTunnelType32280)) as org.apache.http.conn.routing.RouteInfo_TunnelType;
		}
		internal static global::MonoJavaBridge.MethodId _isTunnelled32281;
		public bool isTunnelled()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.RouteTracker._isTunnelled32281.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.RouteTracker._isTunnelled32281 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "isTunnelled", "()Z");
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._isTunnelled32281);
		}
		public new global::org.apache.http.conn.routing.RouteInfo_LayerType LayerType
		{
			get
			{
				return getLayerType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLayerType32282;
		public global::org.apache.http.conn.routing.RouteInfo_LayerType getLayerType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.RouteTracker._getLayerType32282.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.RouteTracker._getLayerType32282 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "getLayerType", "()Lorg/apache/http/conn/routing/RouteInfo$LayerType;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.RouteInfo_LayerType>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._getLayerType32282)) as org.apache.http.conn.routing.RouteInfo_LayerType;
		}
		internal static global::MonoJavaBridge.MethodId _isLayered32283;
		public bool isLayered()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.RouteTracker._isLayered32283.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.RouteTracker._isLayered32283 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "isLayered", "()Z");
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._isLayered32283);
		}
		internal static global::MonoJavaBridge.MethodId _connectTarget32284;
		public void connectTarget(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.RouteTracker._connectTarget32284.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.RouteTracker._connectTarget32284 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "connectTarget", "(Z)V");
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._connectTarget32284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _connectProxy32285;
		public void connectProxy(org.apache.http.HttpHost arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.RouteTracker._connectProxy32285.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.RouteTracker._connectProxy32285 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "connectProxy", "(Lorg/apache/http/HttpHost;Z)V");
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._connectProxy32285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _toRoute32286;
		public global::org.apache.http.conn.routing.HttpRoute toRoute()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.RouteTracker._toRoute32286.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.RouteTracker._toRoute32286 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "toRoute", "()Lorg/apache/http/conn/routing/HttpRoute;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.HttpRoute>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._toRoute32286)) as org.apache.http.conn.routing.HttpRoute;
		}
		internal static global::MonoJavaBridge.MethodId _RouteTracker32287;
		public RouteTracker(org.apache.http.conn.routing.HttpRoute arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.RouteTracker._RouteTracker32287.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.RouteTracker._RouteTracker32287 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "<init>", "(Lorg/apache/http/conn/routing/HttpRoute;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._RouteTracker32287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RouteTracker32288;
		public RouteTracker(org.apache.http.HttpHost arg0, java.net.InetAddress arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.RouteTracker._RouteTracker32288.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.RouteTracker._RouteTracker32288 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "<init>", "(Lorg/apache/http/HttpHost;Ljava/net/InetAddress;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._RouteTracker32288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static RouteTracker()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.routing.RouteTracker.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/routing/RouteTracker"));
		}
		internal static void InitJNI()
		{
		}
	}
}
