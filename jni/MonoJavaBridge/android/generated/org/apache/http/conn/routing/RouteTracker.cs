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
		internal static global::MonoJavaBridge.MethodId _equals32147;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._equals32147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._equals32147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString32148;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._toString32148)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._toString32148)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode32149;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._hashCode32149);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._hashCode32149);
		}
		internal static global::MonoJavaBridge.MethodId _clone32150;
		public global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._clone32150)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._clone32150)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _isConnected32151;
		public bool isConnected() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._isConnected32151);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._isConnected32151);
		}
		internal static global::MonoJavaBridge.MethodId _isSecure32152;
		public bool isSecure() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._isSecure32152);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._isSecure32152);
		}
		public new global::java.net.InetAddress LocalAddress
		{
			get
			{
				return getLocalAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalAddress32153;
		public global::java.net.InetAddress getLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._getLocalAddress32153)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._getLocalAddress32153)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _tunnelTarget32154;
		public void tunnelTarget(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._tunnelTarget32154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._tunnelTarget32154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _tunnelProxy32155;
		public void tunnelProxy(org.apache.http.HttpHost arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._tunnelProxy32155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._tunnelProxy32155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _layerProtocol32156;
		public void layerProtocol(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._layerProtocol32156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._layerProtocol32156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.HttpHost TargetHost
		{
			get
			{
				return getTargetHost();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTargetHost32157;
		public global::org.apache.http.HttpHost getTargetHost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpHost>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._getTargetHost32157)) as org.apache.http.HttpHost;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpHost>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._getTargetHost32157)) as org.apache.http.HttpHost;
		}
		public new int HopCount
		{
			get
			{
				return getHopCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHopCount32158;
		public int getHopCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._getHopCount32158);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._getHopCount32158);
		}
		internal static global::MonoJavaBridge.MethodId _getHopTarget32159;
		public global::org.apache.http.HttpHost getHopTarget(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpHost>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._getHopTarget32159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpHost;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpHost>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._getHopTarget32159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpHost;
		}
		public new global::org.apache.http.HttpHost ProxyHost
		{
			get
			{
				return getProxyHost();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProxyHost32160;
		public global::org.apache.http.HttpHost getProxyHost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpHost>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._getProxyHost32160)) as org.apache.http.HttpHost;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpHost>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._getProxyHost32160)) as org.apache.http.HttpHost;
		}
		public new global::org.apache.http.conn.routing.RouteInfo_TunnelType TunnelType
		{
			get
			{
				return getTunnelType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTunnelType32161;
		public global::org.apache.http.conn.routing.RouteInfo_TunnelType getTunnelType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.RouteInfo_TunnelType>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._getTunnelType32161)) as org.apache.http.conn.routing.RouteInfo_TunnelType;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.RouteInfo_TunnelType>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._getTunnelType32161)) as org.apache.http.conn.routing.RouteInfo_TunnelType;
		}
		internal static global::MonoJavaBridge.MethodId _isTunnelled32162;
		public bool isTunnelled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._isTunnelled32162);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._isTunnelled32162);
		}
		public new global::org.apache.http.conn.routing.RouteInfo_LayerType LayerType
		{
			get
			{
				return getLayerType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLayerType32163;
		public global::org.apache.http.conn.routing.RouteInfo_LayerType getLayerType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.RouteInfo_LayerType>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._getLayerType32163)) as org.apache.http.conn.routing.RouteInfo_LayerType;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.RouteInfo_LayerType>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._getLayerType32163)) as org.apache.http.conn.routing.RouteInfo_LayerType;
		}
		internal static global::MonoJavaBridge.MethodId _isLayered32164;
		public bool isLayered() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._isLayered32164);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._isLayered32164);
		}
		internal static global::MonoJavaBridge.MethodId _connectTarget32165;
		public void connectTarget(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._connectTarget32165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._connectTarget32165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _connectProxy32166;
		public void connectProxy(org.apache.http.HttpHost arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._connectProxy32166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._connectProxy32166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _toRoute32167;
		public global::org.apache.http.conn.routing.HttpRoute toRoute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.HttpRoute>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker._toRoute32167)) as org.apache.http.conn.routing.HttpRoute;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.HttpRoute>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._toRoute32167)) as org.apache.http.conn.routing.HttpRoute;
		}
		internal static global::MonoJavaBridge.MethodId _RouteTracker32168;
		public RouteTracker(org.apache.http.conn.routing.HttpRoute arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._RouteTracker32168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RouteTracker32169;
		public RouteTracker(org.apache.http.HttpHost arg0, java.net.InetAddress arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._RouteTracker32169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.routing.RouteTracker.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/routing/RouteTracker"));
			global::org.apache.http.conn.routing.RouteTracker._equals32147 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::org.apache.http.conn.routing.RouteTracker._toString32148 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.conn.routing.RouteTracker._hashCode32149 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "hashCode", "()I");
			global::org.apache.http.conn.routing.RouteTracker._clone32150 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "clone", "()Ljava/lang/Object;");
			global::org.apache.http.conn.routing.RouteTracker._isConnected32151 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "isConnected", "()Z");
			global::org.apache.http.conn.routing.RouteTracker._isSecure32152 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "isSecure", "()Z");
			global::org.apache.http.conn.routing.RouteTracker._getLocalAddress32153 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.conn.routing.RouteTracker._tunnelTarget32154 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "tunnelTarget", "(Z)V");
			global::org.apache.http.conn.routing.RouteTracker._tunnelProxy32155 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "tunnelProxy", "(Lorg/apache/http/HttpHost;Z)V");
			global::org.apache.http.conn.routing.RouteTracker._layerProtocol32156 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "layerProtocol", "(Z)V");
			global::org.apache.http.conn.routing.RouteTracker._getTargetHost32157 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "getTargetHost", "()Lorg/apache/http/HttpHost;");
			global::org.apache.http.conn.routing.RouteTracker._getHopCount32158 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "getHopCount", "()I");
			global::org.apache.http.conn.routing.RouteTracker._getHopTarget32159 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "getHopTarget", "(I)Lorg/apache/http/HttpHost;");
			global::org.apache.http.conn.routing.RouteTracker._getProxyHost32160 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "getProxyHost", "()Lorg/apache/http/HttpHost;");
			global::org.apache.http.conn.routing.RouteTracker._getTunnelType32161 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "getTunnelType", "()Lorg/apache/http/conn/routing/RouteInfo$TunnelType;");
			global::org.apache.http.conn.routing.RouteTracker._isTunnelled32162 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "isTunnelled", "()Z");
			global::org.apache.http.conn.routing.RouteTracker._getLayerType32163 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "getLayerType", "()Lorg/apache/http/conn/routing/RouteInfo$LayerType;");
			global::org.apache.http.conn.routing.RouteTracker._isLayered32164 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "isLayered", "()Z");
			global::org.apache.http.conn.routing.RouteTracker._connectTarget32165 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "connectTarget", "(Z)V");
			global::org.apache.http.conn.routing.RouteTracker._connectProxy32166 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "connectProxy", "(Lorg/apache/http/HttpHost;Z)V");
			global::org.apache.http.conn.routing.RouteTracker._toRoute32167 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "toRoute", "()Lorg/apache/http/conn/routing/HttpRoute;");
			global::org.apache.http.conn.routing.RouteTracker._RouteTracker32168 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "<init>", "(Lorg/apache/http/conn/routing/HttpRoute;)V");
			global::org.apache.http.conn.routing.RouteTracker._RouteTracker32169 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "<init>", "(Lorg/apache/http/HttpHost;Ljava/net/InetAddress;)V");
		}
	}
}
