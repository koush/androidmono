namespace org.apache.http.conn.routing
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class RouteTracker : java.lang.Object, RouteInfo, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal RouteTracker(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.routing.RouteTracker.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::org.apache.http.conn.routing.RouteTracker._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.conn.routing.RouteTracker.staticClass, "toString", "()Ljava/lang/String;", ref global::org.apache.http.conn.routing.RouteTracker._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.routing.RouteTracker.staticClass, "hashCode", "()I", ref global::org.apache.http.conn.routing.RouteTracker._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.conn.routing.RouteTracker.staticClass, "clone", "()Ljava/lang/Object;", ref global::org.apache.http.conn.routing.RouteTracker._m3) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public bool isConnected()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.routing.RouteTracker.staticClass, "isConnected", "()Z", ref global::org.apache.http.conn.routing.RouteTracker._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public bool isSecure()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.routing.RouteTracker.staticClass, "isSecure", "()Z", ref global::org.apache.http.conn.routing.RouteTracker._m5);
		}
		public new global::java.net.InetAddress LocalAddress
		{
			get
			{
				return getLocalAddress();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public global::java.net.InetAddress getLocalAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.conn.routing.RouteTracker.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;", ref global::org.apache.http.conn.routing.RouteTracker._m6) as java.net.InetAddress;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public void tunnelTarget(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.routing.RouteTracker.staticClass, "tunnelTarget", "(Z)V", ref global::org.apache.http.conn.routing.RouteTracker._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public void tunnelProxy(org.apache.http.HttpHost arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.routing.RouteTracker.staticClass, "tunnelProxy", "(Lorg/apache/http/HttpHost;Z)V", ref global::org.apache.http.conn.routing.RouteTracker._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public void layerProtocol(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.routing.RouteTracker.staticClass, "layerProtocol", "(Z)V", ref global::org.apache.http.conn.routing.RouteTracker._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.HttpHost TargetHost
		{
			get
			{
				return getTargetHost();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public global::org.apache.http.HttpHost getTargetHost()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.HttpHost>(this, global::org.apache.http.conn.routing.RouteTracker.staticClass, "getTargetHost", "()Lorg/apache/http/HttpHost;", ref global::org.apache.http.conn.routing.RouteTracker._m10) as org.apache.http.HttpHost;
		}
		public new int HopCount
		{
			get
			{
				return getHopCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public int getHopCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.routing.RouteTracker.staticClass, "getHopCount", "()I", ref global::org.apache.http.conn.routing.RouteTracker._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public global::org.apache.http.HttpHost getHopTarget(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.HttpHost>(this, global::org.apache.http.conn.routing.RouteTracker.staticClass, "getHopTarget", "(I)Lorg/apache/http/HttpHost;", ref global::org.apache.http.conn.routing.RouteTracker._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.HttpHost;
		}
		public new global::org.apache.http.HttpHost ProxyHost
		{
			get
			{
				return getProxyHost();
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public global::org.apache.http.HttpHost getProxyHost()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.HttpHost>(this, global::org.apache.http.conn.routing.RouteTracker.staticClass, "getProxyHost", "()Lorg/apache/http/HttpHost;", ref global::org.apache.http.conn.routing.RouteTracker._m13) as org.apache.http.HttpHost;
		}
		public new global::org.apache.http.conn.routing.RouteInfo_TunnelType TunnelType
		{
			get
			{
				return getTunnelType();
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public global::org.apache.http.conn.routing.RouteInfo_TunnelType getTunnelType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.conn.routing.RouteInfo_TunnelType>(this, global::org.apache.http.conn.routing.RouteTracker.staticClass, "getTunnelType", "()Lorg/apache/http/conn/routing/RouteInfo$TunnelType;", ref global::org.apache.http.conn.routing.RouteTracker._m14) as org.apache.http.conn.routing.RouteInfo_TunnelType;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public bool isTunnelled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.routing.RouteTracker.staticClass, "isTunnelled", "()Z", ref global::org.apache.http.conn.routing.RouteTracker._m15);
		}
		public new global::org.apache.http.conn.routing.RouteInfo_LayerType LayerType
		{
			get
			{
				return getLayerType();
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public global::org.apache.http.conn.routing.RouteInfo_LayerType getLayerType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.conn.routing.RouteInfo_LayerType>(this, global::org.apache.http.conn.routing.RouteTracker.staticClass, "getLayerType", "()Lorg/apache/http/conn/routing/RouteInfo$LayerType;", ref global::org.apache.http.conn.routing.RouteTracker._m16) as org.apache.http.conn.routing.RouteInfo_LayerType;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public bool isLayered()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.routing.RouteTracker.staticClass, "isLayered", "()Z", ref global::org.apache.http.conn.routing.RouteTracker._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public void connectTarget(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.routing.RouteTracker.staticClass, "connectTarget", "(Z)V", ref global::org.apache.http.conn.routing.RouteTracker._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public void connectProxy(org.apache.http.HttpHost arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.routing.RouteTracker.staticClass, "connectProxy", "(Lorg/apache/http/HttpHost;Z)V", ref global::org.apache.http.conn.routing.RouteTracker._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public global::org.apache.http.conn.routing.HttpRoute toRoute()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.conn.routing.HttpRoute>(this, global::org.apache.http.conn.routing.RouteTracker.staticClass, "toRoute", "()Lorg/apache/http/conn/routing/HttpRoute;", ref global::org.apache.http.conn.routing.RouteTracker._m20) as org.apache.http.conn.routing.HttpRoute;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public RouteTracker(org.apache.http.conn.routing.HttpRoute arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.RouteTracker._m21.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.RouteTracker._m21 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "<init>", "(Lorg/apache/http/conn/routing/HttpRoute;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public RouteTracker(org.apache.http.HttpHost arg0, java.net.InetAddress arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.RouteTracker._m22.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.RouteTracker._m22 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.RouteTracker.staticClass, "<init>", "(Lorg/apache/http/HttpHost;Ljava/net/InetAddress;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.routing.RouteTracker.staticClass, global::org.apache.http.conn.routing.RouteTracker._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
