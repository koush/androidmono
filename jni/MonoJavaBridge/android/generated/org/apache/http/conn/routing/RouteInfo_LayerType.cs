namespace org.apache.http.conn.routing
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class RouteInfo_LayerType : java.lang.Enum
	{
		internal new static global::java.lang.Class staticClass;
		static RouteInfo_LayerType()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.apache.http.conn.routing.RouteInfo_LayerType), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.apache.http.conn.routing.RouteInfo_LayerType(@__env);
			}
		}
		internal RouteInfo_LayerType(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _values14462;
		public static global::org.apache.http.conn.routing.RouteInfo_LayerType[] values() 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(org.apache.http.conn.routing.RouteInfo_LayerType.staticClass, global::org.apache.http.conn.routing.RouteInfo_LayerType._values14462));
		}
		internal static global::net.sf.jni4net.jni.MethodId _valueOf14463;
		public static global::org.apache.http.conn.routing.RouteInfo_LayerType valueOf(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.conn.routing.RouteInfo_LayerType>(@__env, @__env.CallStaticObjectMethodPtr(org.apache.http.conn.routing.RouteInfo_LayerType.staticClass, global::org.apache.http.conn.routing.RouteInfo_LayerType._valueOf14463, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.FieldId _LAYERED14464;
		public static global::org.apache.http.conn.routing.RouteInfo_LayerType LAYERED
		{
			get
			{
				return default(global::org.apache.http.conn.routing.RouteInfo_LayerType);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _PLAIN14465;
		public static global::org.apache.http.conn.routing.RouteInfo_LayerType PLAIN
		{
			get
			{
				return default(global::org.apache.http.conn.routing.RouteInfo_LayerType);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.apache.http.conn.routing.RouteInfo_LayerType.staticClass = @__class;
			global::org.apache.http.conn.routing.RouteInfo_LayerType._values14462 = @__env.GetStaticMethodID(global::org.apache.http.conn.routing.RouteInfo_LayerType.staticClass, "values", "()[Lorg/apache/http/conn/routing/RouteInfo$LayerType;");
			global::org.apache.http.conn.routing.RouteInfo_LayerType._valueOf14463 = @__env.GetStaticMethodID(global::org.apache.http.conn.routing.RouteInfo_LayerType.staticClass, "valueOf", "(Ljava/lang/String;)Lorg/apache/http/conn/routing/RouteInfo$LayerType;");
		}
	}
}
