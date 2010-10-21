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
		internal static global::MonoJavaBridge.MethodId _values32133;
		public static global::org.apache.http.conn.routing.RouteInfo_TunnelType[] values() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.conn.routing.RouteInfo_TunnelType>(@__env.CallStaticObjectMethod(org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass, global::org.apache.http.conn.routing.RouteInfo_TunnelType._values32133)) as org.apache.http.conn.routing.RouteInfo_TunnelType[];
		}
		internal static global::MonoJavaBridge.MethodId _valueOf32134;
		public static global::org.apache.http.conn.routing.RouteInfo_TunnelType valueOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass, global::org.apache.http.conn.routing.RouteInfo_TunnelType._valueOf32134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.conn.routing.RouteInfo_TunnelType;
		}
		internal static global::MonoJavaBridge.FieldId _PLAIN32135;
		public static global::org.apache.http.conn.routing.RouteInfo_TunnelType PLAIN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass, _PLAIN32135)) as org.apache.http.conn.routing.RouteInfo_TunnelType;
			}
		}
		internal static global::MonoJavaBridge.FieldId _TUNNELLED32136;
		public static global::org.apache.http.conn.routing.RouteInfo_TunnelType TUNNELLED
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass, _TUNNELLED32136)) as org.apache.http.conn.routing.RouteInfo_TunnelType;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/routing/RouteInfo_TunnelType"));
			global::org.apache.http.conn.routing.RouteInfo_TunnelType._values32133 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass, "values", "()[Lorg/apache/http/conn/routing/RouteInfo$TunnelType;");
			global::org.apache.http.conn.routing.RouteInfo_TunnelType._valueOf32134 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass, "valueOf", "(Ljava/lang/String;)Lorg/apache/http/conn/routing/RouteInfo$TunnelType;");
			global::org.apache.http.conn.routing.RouteInfo_TunnelType._PLAIN32135 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass, "PLAIN", "Lorg/apache/http/conn/routing/RouteInfo$TunnelType;");
			global::org.apache.http.conn.routing.RouteInfo_TunnelType._TUNNELLED32136 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass, "TUNNELLED", "Lorg/apache/http/conn/routing/RouteInfo$TunnelType;");
		}
	}
}
