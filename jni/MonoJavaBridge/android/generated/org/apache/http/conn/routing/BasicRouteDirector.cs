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
		internal static global::MonoJavaBridge.MethodId _nextStep25505;
		public virtual int nextStep(org.apache.http.conn.routing.RouteInfo arg0, org.apache.http.conn.routing.RouteInfo arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.BasicRouteDirector._nextStep25505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, global::org.apache.http.conn.routing.BasicRouteDirector._nextStep25505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _firstStep25506;
		protected virtual int firstStep(org.apache.http.conn.routing.RouteInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.BasicRouteDirector._firstStep25506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, global::org.apache.http.conn.routing.BasicRouteDirector._firstStep25506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _directStep25507;
		protected virtual int directStep(org.apache.http.conn.routing.RouteInfo arg0, org.apache.http.conn.routing.RouteInfo arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.BasicRouteDirector._directStep25507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, global::org.apache.http.conn.routing.BasicRouteDirector._directStep25507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _proxiedStep25508;
		protected virtual int proxiedStep(org.apache.http.conn.routing.RouteInfo arg0, org.apache.http.conn.routing.RouteInfo arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.BasicRouteDirector._proxiedStep25508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, global::org.apache.http.conn.routing.BasicRouteDirector._proxiedStep25508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _BasicRouteDirector25509;
		public BasicRouteDirector()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.routing.BasicRouteDirector.staticClass, global::org.apache.http.conn.routing.BasicRouteDirector._BasicRouteDirector25509);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.routing.BasicRouteDirector.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/routing/BasicRouteDirector"));
			global::org.apache.http.conn.routing.BasicRouteDirector._nextStep25505 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, "nextStep", "(Lorg/apache/http/conn/routing/RouteInfo;Lorg/apache/http/conn/routing/RouteInfo;)I");
			global::org.apache.http.conn.routing.BasicRouteDirector._firstStep25506 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, "firstStep", "(Lorg/apache/http/conn/routing/RouteInfo;)I");
			global::org.apache.http.conn.routing.BasicRouteDirector._directStep25507 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, "directStep", "(Lorg/apache/http/conn/routing/RouteInfo;Lorg/apache/http/conn/routing/RouteInfo;)I");
			global::org.apache.http.conn.routing.BasicRouteDirector._proxiedStep25508 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, "proxiedStep", "(Lorg/apache/http/conn/routing/RouteInfo;Lorg/apache/http/conn/routing/RouteInfo;)I");
			global::org.apache.http.conn.routing.BasicRouteDirector._BasicRouteDirector25509 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, "<init>", "()V");
		}
	}
}
