namespace org.apache.http.conn.routing
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class RouteInfo_TunnelType : java.lang.Enum
	{
		internal new static global::java.lang.Class staticClass;
		static RouteInfo_TunnelType()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.apache.http.conn.routing.RouteInfo_TunnelType), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.apache.http.conn.routing.RouteInfo_TunnelType(@__env);
			}
		}
		internal RouteInfo_TunnelType(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _values14466;
		public static global::org.apache.http.conn.routing.RouteInfo_TunnelType[] values() 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass, global::org.apache.http.conn.routing.RouteInfo_TunnelType._values14466));
		}
		internal static global::net.sf.jni4net.jni.MethodId _valueOf14467;
		public static global::org.apache.http.conn.routing.RouteInfo_TunnelType valueOf(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.conn.routing.RouteInfo_TunnelType>(@__env, @__env.CallStaticObjectMethodPtr(org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass, global::org.apache.http.conn.routing.RouteInfo_TunnelType._valueOf14467, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.FieldId _PLAIN14468;
		public static global::org.apache.http.conn.routing.RouteInfo_TunnelType PLAIN
		{
			get
			{
				return default(global::org.apache.http.conn.routing.RouteInfo_TunnelType);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _TUNNELLED14469;
		public static global::org.apache.http.conn.routing.RouteInfo_TunnelType TUNNELLED
		{
			get
			{
				return default(global::org.apache.http.conn.routing.RouteInfo_TunnelType);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass = @__class;
			global::org.apache.http.conn.routing.RouteInfo_TunnelType._values14466 = @__env.GetStaticMethodID(global::org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass, "values", "()[Lorg/apache/http/conn/routing/RouteInfo$TunnelType;");
			global::org.apache.http.conn.routing.RouteInfo_TunnelType._valueOf14467 = @__env.GetStaticMethodID(global::org.apache.http.conn.routing.RouteInfo_TunnelType.staticClass, "valueOf", "(Ljava/lang/String;)Lorg/apache/http/conn/routing/RouteInfo$TunnelType;");
		}
	}
}
