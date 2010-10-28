namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RoutedRequest : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RoutedRequest()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getRoute32953;
		public virtual global::org.apache.http.conn.routing.HttpRoute getRoute()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.HttpRoute>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.RoutedRequest._getRoute32953)) as org.apache.http.conn.routing.HttpRoute;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.HttpRoute>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.RoutedRequest.staticClass, global::org.apache.http.impl.client.RoutedRequest._getRoute32953)) as org.apache.http.conn.routing.HttpRoute;
		}
		public new global::org.apache.http.impl.client.RequestWrapper Request
		{
			get
			{
				return getRequest();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRequest32954;
		public virtual global::org.apache.http.impl.client.RequestWrapper getRequest()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.RoutedRequest._getRequest32954)) as org.apache.http.impl.client.RequestWrapper;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.RoutedRequest.staticClass, global::org.apache.http.impl.client.RoutedRequest._getRequest32954)) as org.apache.http.impl.client.RequestWrapper;
		}
		internal static global::MonoJavaBridge.MethodId _RoutedRequest32955;
		public RoutedRequest(org.apache.http.impl.client.RequestWrapper arg0, org.apache.http.conn.routing.HttpRoute arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.RoutedRequest.staticClass, global::org.apache.http.impl.client.RoutedRequest._RoutedRequest32955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.RoutedRequest.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/RoutedRequest"));
			global::org.apache.http.impl.client.RoutedRequest._getRoute32953 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RoutedRequest.staticClass, "getRoute", "()Lorg/apache/http/conn/routing/HttpRoute;");
			global::org.apache.http.impl.client.RoutedRequest._getRequest32954 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RoutedRequest.staticClass, "getRequest", "()Lorg/apache/http/impl/client/RequestWrapper;");
			global::org.apache.http.impl.client.RoutedRequest._RoutedRequest32955 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RoutedRequest.staticClass, "<init>", "(Lorg/apache/http/impl/client/RequestWrapper;Lorg/apache/http/conn/routing/HttpRoute;)V");
		}
	}
}
