namespace org.apache.http.conn.routing
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicRouteDirector : java.lang.Object, HttpRouteDirector
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicRouteDirector(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual int nextStep(org.apache.http.conn.routing.RouteInfo arg0, org.apache.http.conn.routing.RouteInfo arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, "nextStep", "(Lorg/apache/http/conn/routing/RouteInfo;Lorg/apache/http/conn/routing/RouteInfo;)I", ref global::org.apache.http.conn.routing.BasicRouteDirector._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected virtual int firstStep(org.apache.http.conn.routing.RouteInfo arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, "firstStep", "(Lorg/apache/http/conn/routing/RouteInfo;)I", ref global::org.apache.http.conn.routing.BasicRouteDirector._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected virtual int directStep(org.apache.http.conn.routing.RouteInfo arg0, org.apache.http.conn.routing.RouteInfo arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, "directStep", "(Lorg/apache/http/conn/routing/RouteInfo;Lorg/apache/http/conn/routing/RouteInfo;)I", ref global::org.apache.http.conn.routing.BasicRouteDirector._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected virtual int proxiedStep(org.apache.http.conn.routing.RouteInfo arg0, org.apache.http.conn.routing.RouteInfo arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, "proxiedStep", "(Lorg/apache/http/conn/routing/RouteInfo;Lorg/apache/http/conn/routing/RouteInfo;)I", ref global::org.apache.http.conn.routing.BasicRouteDirector._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public BasicRouteDirector() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.BasicRouteDirector._m4.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.BasicRouteDirector._m4 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.routing.BasicRouteDirector.staticClass, global::org.apache.http.conn.routing.BasicRouteDirector._m4);
			Init(@__env, handle);
		}
		static BasicRouteDirector()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.routing.BasicRouteDirector.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/routing/BasicRouteDirector"));
		}
	}
}
