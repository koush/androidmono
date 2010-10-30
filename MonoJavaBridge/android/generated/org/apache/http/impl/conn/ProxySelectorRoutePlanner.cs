namespace org.apache.http.impl.conn
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ProxySelectorRoutePlanner : java.lang.Object, org.apache.http.conn.routing.HttpRoutePlanner
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ProxySelectorRoutePlanner(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected virtual global::java.lang.String getHost(java.net.InetSocketAddress arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass, "getHost", "(Ljava/net/InetSocketAddress;)Ljava/lang/String;", ref global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::org.apache.http.conn.routing.HttpRoute determineRoute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.protocol.HttpContext arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.conn.routing.HttpRoute>(this, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass, "determineRoute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/conn/routing/HttpRoute;", ref global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.apache.http.conn.routing.HttpRoute;
		}
		public new global::java.net.ProxySelector ProxySelector
		{
			get
			{
				return getProxySelector();
			}
			set
			{
				setProxySelector(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.net.ProxySelector getProxySelector()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass, "getProxySelector", "()Ljava/net/ProxySelector;", ref global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._m2) as java.net.ProxySelector;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setProxySelector(java.net.ProxySelector arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass, "setProxySelector", "(Ljava/net/ProxySelector;)V", ref global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected virtual global::org.apache.http.HttpHost determineProxy(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.protocol.HttpContext arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.HttpHost>(this, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass, "determineProxy", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/HttpHost;", ref global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.apache.http.HttpHost;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected virtual global::java.net.Proxy chooseProxy(java.util.List arg0, org.apache.http.HttpHost arg1, org.apache.http.HttpRequest arg2, org.apache.http.protocol.HttpContext arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass, "chooseProxy", "(Ljava/util/List;Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)Ljava/net/Proxy;", ref global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.net.Proxy;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public ProxySelectorRoutePlanner(org.apache.http.conn.scheme.SchemeRegistry arg0, java.net.ProxySelector arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._m6.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._m6 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass, "<init>", "(Lorg/apache/http/conn/scheme/SchemeRegistry;Ljava/net/ProxySelector;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ProxySelectorRoutePlanner()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/ProxySelectorRoutePlanner"));
		}
		internal static void InitJNI()
		{
		}
	}
}
