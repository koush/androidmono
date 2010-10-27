namespace org.apache.http.conn.routing
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class RouteInfo_TunnelType : java.lang.Enum
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RouteInfo_TunnelType()
		{
			InitJNI();
		}
		internal RouteInfo_TunnelType(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _values32251;
		public static global::org.apache.http.conn.routing.RouteInfo_TunnelType[] values()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.conn.routing.RouteInfo_TunnelType>(@__env.CallStaticObjectMethod(org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass, global::org.apache.http.conn.routing.RouteInfo_TunnelType._values32251)) as org.apache.http.conn.routing.RouteInfo_TunnelType[];
		}
		internal static global::MonoJavaBridge.MethodId _valueOf32252;
		public static global::org.apache.http.conn.routing.RouteInfo_TunnelType valueOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.RouteInfo_TunnelType>(@__env.CallStaticObjectMethod(org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass, global::org.apache.http.conn.routing.RouteInfo_TunnelType._valueOf32252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.conn.routing.RouteInfo_TunnelType;
		}
		internal static global::MonoJavaBridge.FieldId _PLAIN32253;
		public static global::org.apache.http.conn.routing.RouteInfo_TunnelType PLAIN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.RouteInfo_TunnelType>(@__env.GetStaticObjectField(global::org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass, _PLAIN32253)) as org.apache.http.conn.routing.RouteInfo_TunnelType;
			}
		}
		internal static global::MonoJavaBridge.FieldId _TUNNELLED32254;
		public static global::org.apache.http.conn.routing.RouteInfo_TunnelType TUNNELLED
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.RouteInfo_TunnelType>(@__env.GetStaticObjectField(global::org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass, _TUNNELLED32254)) as org.apache.http.conn.routing.RouteInfo_TunnelType;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/routing/RouteInfo$TunnelType"));
			global::org.apache.http.conn.routing.RouteInfo_TunnelType._values32251 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass, "values", "()[Lorg/apache/http/conn/routing/RouteInfo$TunnelType;");
			global::org.apache.http.conn.routing.RouteInfo_TunnelType._valueOf32252 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass, "valueOf", "(Ljava/lang/String;)Lorg/apache/http/conn/routing/RouteInfo$TunnelType;");
			global::org.apache.http.conn.routing.RouteInfo_TunnelType._PLAIN32253 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass, "PLAIN", "Lorg/apache/http/conn/routing/RouteInfo$TunnelType;");
			global::org.apache.http.conn.routing.RouteInfo_TunnelType._TUNNELLED32254 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass, "TUNNELLED", "Lorg/apache/http/conn/routing/RouteInfo$TunnelType;");
		}
	}
}
