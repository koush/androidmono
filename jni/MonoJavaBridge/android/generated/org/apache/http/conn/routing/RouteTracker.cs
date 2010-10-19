namespace org.apache.http.conn.routing
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class RouteTracker : java.lang.Object, RouteInfo, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RouteTracker()
		{
			InitJNI();
		}
		internal RouteTracker(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals25549;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._equals25549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._equals25549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString25550;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._toString25550)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._toString25550)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25551;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._hashCode25551);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._hashCode25551);
		}
		internal static global::MonoJavaBridge.MethodId _clone25552;
		public global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._clone25552)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._clone25552)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _isConnected25553;
		public bool isConnected() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._isConnected25553);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._isConnected25553);
		}
		internal static global::MonoJavaBridge.MethodId _isSecure25554;
		public bool isSecure() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._isSecure25554);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._isSecure25554);
		}
		public new global::java.net.InetAddress LocalAddress
		{
			get
			{
				return getLocalAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalAddress25555;
		public global::java.net.InetAddress getLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._getLocalAddress25555)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._getLocalAddress25555)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _tunnelTarget25556;
		public void tunnelTarget(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._tunnelTarget25556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._tunnelTarget25556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _tunnelProxy25557;
		public void tunnelProxy(org.apache.http.HttpHost arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._tunnelProxy25557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._tunnelProxy25557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _layerProtocol25558;
		public void layerProtocol(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._layerProtocol25558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._layerProtocol25558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.HttpHost TargetHost
		{
			get
			{
				return getTargetHost();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTargetHost25559;
		public global::org.apache.http.HttpHost getTargetHost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._getTargetHost25559)) as org.apache.http.HttpHost;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._getTargetHost25559)) as org.apache.http.HttpHost;
		}
		public new int HopCount
		{
			get
			{
				return getHopCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHopCount25560;
		public int getHopCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._getHopCount25560);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._getHopCount25560);
		}
		internal static global::MonoJavaBridge.MethodId _getHopTarget25561;
		public global::org.apache.http.HttpHost getHopTarget(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._getHopTarget25561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpHost;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._getHopTarget25561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpHost;
		}
		public new global::org.apache.http.HttpHost ProxyHost
		{
			get
			{
				return getProxyHost();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProxyHost25562;
		public global::org.apache.http.HttpHost getProxyHost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._getProxyHost25562)) as org.apache.http.HttpHost;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._getProxyHost25562)) as org.apache.http.HttpHost;
		}
		public new global::org.apache.http.conn.routing.RouteInfo_TunnelType TunnelType
		{
			get
			{
				return getTunnelType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTunnelType25563;
		public global::org.apache.http.conn.routing.RouteInfo_TunnelType getTunnelType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._getTunnelType25563)) as org.apache.http.conn.routing.RouteInfo_TunnelType;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._getTunnelType25563)) as org.apache.http.conn.routing.RouteInfo_TunnelType;
		}
		internal static global::MonoJavaBridge.MethodId _isTunnelled25564;
		public bool isTunnelled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._isTunnelled25564);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._isTunnelled25564);
		}
		public new global::org.apache.http.conn.routing.RouteInfo_LayerType LayerType
		{
			get
			{
				return getLayerType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLayerType25565;
		public global::org.apache.http.conn.routing.RouteInfo_LayerType getLayerType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._getLayerType25565)) as org.apache.http.conn.routing.RouteInfo_LayerType;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._getLayerType25565)) as org.apache.http.conn.routing.RouteInfo_LayerType;
		}
		internal static global::MonoJavaBridge.MethodId _isLayered25566;
		public bool isLayered() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._isLayered25566);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._isLayered25566);
		}
		internal static global::MonoJavaBridge.MethodId _connectTarget25567;
		public void connectTarget(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._connectTarget25567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._connectTarget25567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _connectProxy25568;
		public void connectProxy(org.apache.http.HttpHost arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._connectProxy25568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._connectProxy25568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _toRoute25569;
		public global::org.apache.http.conn.routing.HttpRoute toRoute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._toRoute25569)) as org.apache.http.conn.routing.HttpRoute;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._toRoute25569)) as org.apache.http.conn.routing.HttpRoute;
		}
		internal static global::MonoJavaBridge.MethodId _RouteTracker25570;
		public RouteTracker(org.apache.http.conn.routing.HttpRoute arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._RouteTracker25570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RouteTracker25571;
		public RouteTracker(org.apache.http.HttpHost arg0, java.net.InetAddress arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._RouteTracker25571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.routing.RouteTracker.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/routing/RouteTracker"));
			global::org.apache.http.conn.routing.RouteTracker._equals25549 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::org.apache.http.conn.routing.RouteTracker._toString25550 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.conn.routing.RouteTracker._hashCode25551 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "hashCode", "()I");
			global::org.apache.http.conn.routing.RouteTracker._clone25552 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "clone", "()Ljava/lang/Object;");
			global::org.apache.http.conn.routing.RouteTracker._isConnected25553 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "isConnected", "()Z");
			global::org.apache.http.conn.routing.RouteTracker._isSecure25554 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "isSecure", "()Z");
			global::org.apache.http.conn.routing.RouteTracker._getLocalAddress25555 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.conn.routing.RouteTracker._tunnelTarget25556 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "tunnelTarget", "(Z)V");
			global::org.apache.http.conn.routing.RouteTracker._tunnelProxy25557 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "tunnelProxy", "(Lorg/apache/http/HttpHost;Z)V");
			global::org.apache.http.conn.routing.RouteTracker._layerProtocol25558 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "layerProtocol", "(Z)V");
			global::org.apache.http.conn.routing.RouteTracker._getTargetHost25559 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "getTargetHost", "()Lorg/apache/http/HttpHost;");
			global::org.apache.http.conn.routing.RouteTracker._getHopCount25560 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "getHopCount", "()I");
			global::org.apache.http.conn.routing.RouteTracker._getHopTarget25561 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "getHopTarget", "(I)Lorg/apache/http/HttpHost;");
			global::org.apache.http.conn.routing.RouteTracker._getProxyHost25562 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "getProxyHost", "()Lorg/apache/http/HttpHost;");
			global::org.apache.http.conn.routing.RouteTracker._getTunnelType25563 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "getTunnelType", "()Lorg/apache/http/conn/routing/RouteInfo$TunnelType;");
			global::org.apache.http.conn.routing.RouteTracker._isTunnelled25564 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "isTunnelled", "()Z");
			global::org.apache.http.conn.routing.RouteTracker._getLayerType25565 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "getLayerType", "()Lorg/apache/http/conn/routing/RouteInfo$LayerType;");
			global::org.apache.http.conn.routing.RouteTracker._isLayered25566 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "isLayered", "()Z");
			global::org.apache.http.conn.routing.RouteTracker._connectTarget25567 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "connectTarget", "(Z)V");
			global::org.apache.http.conn.routing.RouteTracker._connectProxy25568 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "connectProxy", "(Lorg/apache/http/HttpHost;Z)V");
			global::org.apache.http.conn.routing.RouteTracker._toRoute25569 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "toRoute", "()Lorg/apache/http/conn/routing/HttpRoute;");
			global::org.apache.http.conn.routing.RouteTracker._RouteTracker25570 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "<init>", "(Lorg/apache/http/conn/routing/HttpRoute;)V");
			global::org.apache.http.conn.routing.RouteTracker._RouteTracker25571 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "<init>", "(Lorg/apache/http/HttpHost;Ljava/net/InetAddress;)V");
		}
	}
}
