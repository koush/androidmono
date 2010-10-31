namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RoutedRequest : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RoutedRequest(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::org.apache.http.conn.routing.HttpRoute Route
		{
			get
			{
				return getRoute();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::org.apache.http.conn.routing.HttpRoute getRoute()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.conn.routing.HttpRoute>(this, global::org.apache.http.impl.client.RoutedRequest.staticClass, "getRoute", "()Lorg/apache/http/conn/routing/HttpRoute;", ref global::org.apache.http.impl.client.RoutedRequest._m0) as org.apache.http.conn.routing.HttpRoute;
		}
		public new global::org.apache.http.impl.client.RequestWrapper Request
		{
			get
			{
				return getRequest();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::org.apache.http.impl.client.RequestWrapper getRequest()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.client.RoutedRequest.staticClass, "getRequest", "()Lorg/apache/http/impl/client/RequestWrapper;", ref global::org.apache.http.impl.client.RoutedRequest._m1) as org.apache.http.impl.client.RequestWrapper;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public RoutedRequest(org.apache.http.impl.client.RequestWrapper arg0, org.apache.http.conn.routing.HttpRoute arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.RoutedRequest._m2.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.RoutedRequest._m2 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RoutedRequest.staticClass, "<init>", "(Lorg/apache/http/impl/client/RequestWrapper;Lorg/apache/http/conn/routing/HttpRoute;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.RoutedRequest.staticClass, global::org.apache.http.impl.client.RoutedRequest._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static RoutedRequest()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.RoutedRequest.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/RoutedRequest"));
		}
	}
}
