namespace org.apache.http.conn.routing
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class RouteInfo_TunnelType : java.lang.Enum
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal RouteInfo_TunnelType(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::org.apache.http.conn.routing.RouteInfo_TunnelType[] values()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.RouteInfo_TunnelType._m0.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.RouteInfo_TunnelType._m0 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass, "values", "()[Lorg/apache/http/conn/routing/RouteInfo$TunnelType;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.conn.routing.RouteInfo_TunnelType>(@__env.CallStaticObjectMethod(org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass, global::org.apache.http.conn.routing.RouteInfo_TunnelType._m0)) as org.apache.http.conn.routing.RouteInfo_TunnelType[];
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::org.apache.http.conn.routing.RouteInfo_TunnelType valueOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.RouteInfo_TunnelType._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.RouteInfo_TunnelType._m1 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass, "valueOf", "(Ljava/lang/String;)Lorg/apache/http/conn/routing/RouteInfo$TunnelType;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.RouteInfo_TunnelType>(@__env.CallStaticObjectMethod(org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass, global::org.apache.http.conn.routing.RouteInfo_TunnelType._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.conn.routing.RouteInfo_TunnelType;
		}
		internal static global::MonoJavaBridge.FieldId _PLAIN7238;
		public static global::org.apache.http.conn.routing.RouteInfo_TunnelType PLAIN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.RouteInfo_TunnelType>(@__env.GetStaticObjectField(global::org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass, _PLAIN7238)) as org.apache.http.conn.routing.RouteInfo_TunnelType;
			}
		}
		internal static global::MonoJavaBridge.FieldId _TUNNELLED7239;
		public static global::org.apache.http.conn.routing.RouteInfo_TunnelType TUNNELLED
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.RouteInfo_TunnelType>(@__env.GetStaticObjectField(global::org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass, _TUNNELLED7239)) as org.apache.http.conn.routing.RouteInfo_TunnelType;
			}
		}
		static RouteInfo_TunnelType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/routing/RouteInfo$TunnelType"));
			global::org.apache.http.conn.routing.RouteInfo_TunnelType._PLAIN7238 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass, "PLAIN", "Lorg/apache/http/conn/routing/RouteInfo$TunnelType;");
			global::org.apache.http.conn.routing.RouteInfo_TunnelType._TUNNELLED7239 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass, "TUNNELLED", "Lorg/apache/http/conn/routing/RouteInfo$TunnelType;");
		}
	}
}
