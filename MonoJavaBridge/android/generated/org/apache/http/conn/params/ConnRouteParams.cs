namespace org.apache.http.conn.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConnRouteParams : java.lang.Object, ConnRoutePNames
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ConnRouteParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.net.InetAddress getLocalAddress(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.@params.ConnRouteParams._m0.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.@params.ConnRouteParams._m0 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.@params.ConnRouteParams.staticClass, "getLocalAddress", "(Lorg/apache/http/params/HttpParams;)Ljava/net/InetAddress;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.conn.@params.ConnRouteParams.staticClass, global::org.apache.http.conn.@params.ConnRouteParams._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.InetAddress;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static void setDefaultProxy(org.apache.http.@params.HttpParams arg0, org.apache.http.HttpHost arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.@params.ConnRouteParams._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.@params.ConnRouteParams._m1 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.@params.ConnRouteParams.staticClass, "setDefaultProxy", "(Lorg/apache/http/params/HttpParams;Lorg/apache/http/HttpHost;)V");
			@__env.CallStaticVoidMethod(org.apache.http.conn.@params.ConnRouteParams.staticClass, global::org.apache.http.conn.@params.ConnRouteParams._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static void setLocalAddress(org.apache.http.@params.HttpParams arg0, java.net.InetAddress arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.@params.ConnRouteParams._m2.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.@params.ConnRouteParams._m2 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.@params.ConnRouteParams.staticClass, "setLocalAddress", "(Lorg/apache/http/params/HttpParams;Ljava/net/InetAddress;)V");
			@__env.CallStaticVoidMethod(org.apache.http.conn.@params.ConnRouteParams.staticClass, global::org.apache.http.conn.@params.ConnRouteParams._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static void setForcedRoute(org.apache.http.@params.HttpParams arg0, org.apache.http.conn.routing.HttpRoute arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.@params.ConnRouteParams._m3.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.@params.ConnRouteParams._m3 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.@params.ConnRouteParams.staticClass, "setForcedRoute", "(Lorg/apache/http/params/HttpParams;Lorg/apache/http/conn/routing/HttpRoute;)V");
			@__env.CallStaticVoidMethod(org.apache.http.conn.@params.ConnRouteParams.staticClass, global::org.apache.http.conn.@params.ConnRouteParams._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static global::org.apache.http.HttpHost getDefaultProxy(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.@params.ConnRouteParams._m4.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.@params.ConnRouteParams._m4 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.@params.ConnRouteParams.staticClass, "getDefaultProxy", "(Lorg/apache/http/params/HttpParams;)Lorg/apache/http/HttpHost;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpHost>(@__env.CallStaticObjectMethod(org.apache.http.conn.@params.ConnRouteParams.staticClass, global::org.apache.http.conn.@params.ConnRouteParams._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpHost;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::org.apache.http.conn.routing.HttpRoute getForcedRoute(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.@params.ConnRouteParams._m5.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.@params.ConnRouteParams._m5 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.@params.ConnRouteParams.staticClass, "getForcedRoute", "(Lorg/apache/http/params/HttpParams;)Lorg/apache/http/conn/routing/HttpRoute;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.HttpRoute>(@__env.CallStaticObjectMethod(org.apache.http.conn.@params.ConnRouteParams.staticClass, global::org.apache.http.conn.@params.ConnRouteParams._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.conn.routing.HttpRoute;
		}
		internal static global::MonoJavaBridge.FieldId _NO_HOST7461;
		public static global::org.apache.http.HttpHost NO_HOST
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpHost>(@__env.GetStaticObjectField(global::org.apache.http.conn.@params.ConnRouteParams.staticClass, _NO_HOST7461)) as org.apache.http.HttpHost;
			}
		}
		internal static global::MonoJavaBridge.FieldId _NO_ROUTE7462;
		public static global::org.apache.http.conn.routing.HttpRoute NO_ROUTE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.HttpRoute>(@__env.GetStaticObjectField(global::org.apache.http.conn.@params.ConnRouteParams.staticClass, _NO_ROUTE7462)) as org.apache.http.conn.routing.HttpRoute;
			}
		}
		static ConnRouteParams()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.@params.ConnRouteParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/params/ConnRouteParams"));
			global::org.apache.http.conn.@params.ConnRouteParams._NO_HOST7461 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.conn.@params.ConnRouteParams.staticClass, "NO_HOST", "Lorg/apache/http/HttpHost;");
			global::org.apache.http.conn.@params.ConnRouteParams._NO_ROUTE7462 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.conn.@params.ConnRouteParams.staticClass, "NO_ROUTE", "Lorg/apache/http/conn/routing/HttpRoute;");
		}
		internal static void InitJNI()
		{
		}
	}
}
