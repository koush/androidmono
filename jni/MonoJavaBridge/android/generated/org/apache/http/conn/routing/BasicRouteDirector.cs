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
		internal static global::MonoJavaBridge.MethodId _nextStep32096;
		public virtual int nextStep(org.apache.http.conn.routing.RouteInfo arg0, org.apache.http.conn.routing.RouteInfo arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.BasicRouteDirector._nextStep32096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, global::org.apache.http.conn.routing.BasicRouteDirector._nextStep32096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _firstStep32097;
		protected virtual int firstStep(org.apache.http.conn.routing.RouteInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.BasicRouteDirector._firstStep32097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, global::org.apache.http.conn.routing.BasicRouteDirector._firstStep32097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _directStep32098;
		protected virtual int directStep(org.apache.http.conn.routing.RouteInfo arg0, org.apache.http.conn.routing.RouteInfo arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.BasicRouteDirector._directStep32098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, global::org.apache.http.conn.routing.BasicRouteDirector._directStep32098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _proxiedStep32099;
		protected virtual int proxiedStep(org.apache.http.conn.routing.RouteInfo arg0, org.apache.http.conn.routing.RouteInfo arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.BasicRouteDirector._proxiedStep32099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, global::org.apache.http.conn.routing.BasicRouteDirector._proxiedStep32099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _BasicRouteDirector32100;
		public BasicRouteDirector()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.routing.BasicRouteDirector.staticClass, global::org.apache.http.conn.routing.BasicRouteDirector._BasicRouteDirector32100);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.routing.BasicRouteDirector.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/routing/BasicRouteDirector"));
			global::org.apache.http.conn.routing.BasicRouteDirector._nextStep32096 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, "nextStep", "(Lorg/apache/http/conn/routing/RouteInfo;Lorg/apache/http/conn/routing/RouteInfo;)I");
			global::org.apache.http.conn.routing.BasicRouteDirector._firstStep32097 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, "firstStep", "(Lorg/apache/http/conn/routing/RouteInfo;)I");
			global::org.apache.http.conn.routing.BasicRouteDirector._directStep32098 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, "directStep", "(Lorg/apache/http/conn/routing/RouteInfo;Lorg/apache/http/conn/routing/RouteInfo;)I");
			global::org.apache.http.conn.routing.BasicRouteDirector._proxiedStep32099 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, "proxiedStep", "(Lorg/apache/http/conn/routing/RouteInfo;Lorg/apache/http/conn/routing/RouteInfo;)I");
			global::org.apache.http.conn.routing.BasicRouteDirector._BasicRouteDirector32100 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.BasicRouteDirector.staticClass, "<init>", "()V");
		}
	}
}
