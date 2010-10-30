namespace org.apache.http.conn.routing
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicRouteDirector : java.lang.Object, HttpRouteDirector
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicRouteDirector(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _nextStep32215;
		public virtual int nextStep(org.apache.http.conn.routing.RouteInfo arg0, org.apache.http.conn.routing.RouteInfo arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.BasicRouteDirector._nextStep32215.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.BasicRouteDirector._nextStep32215 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, "nextStep", "(Lorg/apache/http/conn/routing/RouteInfo;Lorg/apache/http/conn/routing/RouteInfo;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, global::org.apache.http.conn.routing.BasicRouteDirector._nextStep32215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _firstStep32216;
		protected virtual int firstStep(org.apache.http.conn.routing.RouteInfo arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.BasicRouteDirector._firstStep32216.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.BasicRouteDirector._firstStep32216 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, "firstStep", "(Lorg/apache/http/conn/routing/RouteInfo;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, global::org.apache.http.conn.routing.BasicRouteDirector._firstStep32216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _directStep32217;
		protected virtual int directStep(org.apache.http.conn.routing.RouteInfo arg0, org.apache.http.conn.routing.RouteInfo arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.BasicRouteDirector._directStep32217.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.BasicRouteDirector._directStep32217 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, "directStep", "(Lorg/apache/http/conn/routing/RouteInfo;Lorg/apache/http/conn/routing/RouteInfo;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, global::org.apache.http.conn.routing.BasicRouteDirector._directStep32217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _proxiedStep32218;
		protected virtual int proxiedStep(org.apache.http.conn.routing.RouteInfo arg0, org.apache.http.conn.routing.RouteInfo arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.BasicRouteDirector._proxiedStep32218.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.BasicRouteDirector._proxiedStep32218 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, "proxiedStep", "(Lorg/apache/http/conn/routing/RouteInfo;Lorg/apache/http/conn/routing/RouteInfo;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, global::org.apache.http.conn.routing.BasicRouteDirector._proxiedStep32218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _BasicRouteDirector32219;
		public BasicRouteDirector() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.BasicRouteDirector._BasicRouteDirector32219.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.BasicRouteDirector._BasicRouteDirector32219 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.routing.BasicRouteDirector.staticClass, global::org.apache.http.conn.routing.BasicRouteDirector._BasicRouteDirector32219);
			Init(@__env, handle);
		}
		static BasicRouteDirector()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.routing.BasicRouteDirector.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/routing/BasicRouteDirector"));
		}
		internal static void InitJNI()
		{
		}
	}
}
