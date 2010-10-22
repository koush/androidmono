namespace org.apache.http.impl.conn
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ProxySelectorRoutePlanner : java.lang.Object, org.apache.http.conn.routing.HttpRoutePlanner
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ProxySelectorRoutePlanner()
		{
			InitJNI();
		}
		protected ProxySelectorRoutePlanner(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getHost32951;
		protected virtual global::java.lang.String getHost(java.net.InetSocketAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._getHost32951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._getHost32951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _determineRoute32952;
		public virtual global::org.apache.http.conn.routing.HttpRoute determineRoute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.protocol.HttpContext arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.HttpRoute>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._determineRoute32952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.conn.routing.HttpRoute;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.HttpRoute>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._determineRoute32952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.conn.routing.HttpRoute;
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
		internal static global::MonoJavaBridge.MethodId _getProxySelector32953;
		public virtual global::java.net.ProxySelector getProxySelector() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._getProxySelector32953)) as java.net.ProxySelector;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._getProxySelector32953)) as java.net.ProxySelector;
		}
		internal static global::MonoJavaBridge.MethodId _setProxySelector32954;
		public virtual void setProxySelector(java.net.ProxySelector arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._setProxySelector32954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._setProxySelector32954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _determineProxy32955;
		protected virtual global::org.apache.http.HttpHost determineProxy(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.protocol.HttpContext arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpHost>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._determineProxy32955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.HttpHost;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpHost>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._determineProxy32955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.HttpHost;
		}
		internal static global::MonoJavaBridge.MethodId _chooseProxy32956;
		protected virtual global::java.net.Proxy chooseProxy(java.util.List arg0, org.apache.http.HttpHost arg1, org.apache.http.HttpRequest arg2, org.apache.http.protocol.HttpContext arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._chooseProxy32956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.net.Proxy;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._chooseProxy32956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.net.Proxy;
		}
		internal static global::MonoJavaBridge.MethodId _ProxySelectorRoutePlanner32957;
		public ProxySelectorRoutePlanner(org.apache.http.conn.scheme.SchemeRegistry arg0, java.net.ProxySelector arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._ProxySelectorRoutePlanner32957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/ProxySelectorRoutePlanner"));
			global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._getHost32951 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass, "getHost", "(Ljava/net/InetSocketAddress;)Ljava/lang/String;");
			global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._determineRoute32952 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass, "determineRoute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/conn/routing/HttpRoute;");
			global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._getProxySelector32953 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass, "getProxySelector", "()Ljava/net/ProxySelector;");
			global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._setProxySelector32954 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass, "setProxySelector", "(Ljava/net/ProxySelector;)V");
			global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._determineProxy32955 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass, "determineProxy", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/HttpHost;");
			global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._chooseProxy32956 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass, "chooseProxy", "(Ljava/util/List;Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)Ljava/net/Proxy;");
			global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._ProxySelectorRoutePlanner32957 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass, "<init>", "(Lorg/apache/http/conn/scheme/SchemeRegistry;Ljava/net/ProxySelector;)V");
		}
	}
}
