namespace org.apache.http.conn.routing
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicRouteDirector : java.lang.Object, HttpRouteDirector
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BasicRouteDirector()
		{
			InitJNI();
		}
		protected BasicRouteDirector(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _nextStep32214;
		public virtual int nextStep(org.apache.http.conn.routing.RouteInfo arg0, org.apache.http.conn.routing.RouteInfo arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.BasicRouteDirector._nextStep32214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, global::org.apache.http.conn.routing.BasicRouteDirector._nextStep32214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _firstStep32215;
		protected virtual int firstStep(org.apache.http.conn.routing.RouteInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.BasicRouteDirector._firstStep32215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, global::org.apache.http.conn.routing.BasicRouteDirector._firstStep32215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _directStep32216;
		protected virtual int directStep(org.apache.http.conn.routing.RouteInfo arg0, org.apache.http.conn.routing.RouteInfo arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.BasicRouteDirector._directStep32216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, global::org.apache.http.conn.routing.BasicRouteDirector._directStep32216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _proxiedStep32217;
		protected virtual int proxiedStep(org.apache.http.conn.routing.RouteInfo arg0, org.apache.http.conn.routing.RouteInfo arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.BasicRouteDirector._proxiedStep32217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, global::org.apache.http.conn.routing.BasicRouteDirector._proxiedStep32217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _BasicRouteDirector32218;
		public BasicRouteDirector()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.routing.BasicRouteDirector.staticClass, global::org.apache.http.conn.routing.BasicRouteDirector._BasicRouteDirector32218);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.routing.BasicRouteDirector.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/routing/BasicRouteDirector"));
			global::org.apache.http.conn.routing.BasicRouteDirector._nextStep32214 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, "nextStep", "(Lorg/apache/http/conn/routing/RouteInfo;Lorg/apache/http/conn/routing/RouteInfo;)I");
			global::org.apache.http.conn.routing.BasicRouteDirector._firstStep32215 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, "firstStep", "(Lorg/apache/http/conn/routing/RouteInfo;)I");
			global::org.apache.http.conn.routing.BasicRouteDirector._directStep32216 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, "directStep", "(Lorg/apache/http/conn/routing/RouteInfo;Lorg/apache/http/conn/routing/RouteInfo;)I");
			global::org.apache.http.conn.routing.BasicRouteDirector._proxiedStep32217 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, "proxiedStep", "(Lorg/apache/http/conn/routing/RouteInfo;Lorg/apache/http/conn/routing/RouteInfo;)I");
			global::org.apache.http.conn.routing.BasicRouteDirector._BasicRouteDirector32218 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, "<init>", "()V");
		}
	}
}
