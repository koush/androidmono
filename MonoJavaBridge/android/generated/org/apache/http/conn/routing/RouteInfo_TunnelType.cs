namespace org.apache.http.conn.routing
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class RouteInfo_TunnelType : java.lang.Enum
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal RouteInfo_TunnelType(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _values32252;
		public static global::org.apache.http.conn.routing.RouteInfo_TunnelType[] values()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.RouteInfo_TunnelType._values32252.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.RouteInfo_TunnelType._values32252 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass, "values", "()[Lorg/apache/http/conn/routing/RouteInfo$TunnelType;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.conn.routing.RouteInfo_TunnelType>(@__env.CallStaticObjectMethod(org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass, global::org.apache.http.conn.routing.RouteInfo_TunnelType._values32252)) as org.apache.http.conn.routing.RouteInfo_TunnelType[];
		}
		internal static global::MonoJavaBridge.MethodId _valueOf32253;
		public static global::org.apache.http.conn.routing.RouteInfo_TunnelType valueOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.RouteInfo_TunnelType._valueOf32253.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.RouteInfo_TunnelType._valueOf32253 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass, "valueOf", "(Ljava/lang/String;)Lorg/apache/http/conn/routing/RouteInfo$TunnelType;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.RouteInfo_TunnelType>(@__env.CallStaticObjectMethod(org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass, global::org.apache.http.conn.routing.RouteInfo_TunnelType._valueOf32253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.conn.routing.RouteInfo_TunnelType;
		}
		internal static global::MonoJavaBridge.FieldId _PLAIN32254;
		public static global::org.apache.http.conn.routing.RouteInfo_TunnelType PLAIN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.RouteInfo_TunnelType>(@__env.GetStaticObjectField(global::org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass, _PLAIN32254)) as org.apache.http.conn.routing.RouteInfo_TunnelType;
			}
		}
		internal static global::MonoJavaBridge.FieldId _TUNNELLED32255;
		public static global::org.apache.http.conn.routing.RouteInfo_TunnelType TUNNELLED
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.RouteInfo_TunnelType>(@__env.GetStaticObjectField(global::org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass, _TUNNELLED32255)) as org.apache.http.conn.routing.RouteInfo_TunnelType;
			}
		}
		static RouteInfo_TunnelType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/routing/RouteInfo$TunnelType"));
			global::org.apache.http.conn.routing.RouteInfo_TunnelType._PLAIN32254 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass, "PLAIN", "Lorg/apache/http/conn/routing/RouteInfo$TunnelType;");
			global::org.apache.http.conn.routing.RouteInfo_TunnelType._TUNNELLED32255 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass, "TUNNELLED", "Lorg/apache/http/conn/routing/RouteInfo$TunnelType;");
		}
		internal static void InitJNI()
		{
		}
	}
}
