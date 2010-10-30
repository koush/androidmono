namespace org.apache.http.conn.routing
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class RouteInfo_LayerType : java.lang.Enum
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal RouteInfo_LayerType(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::org.apache.http.conn.routing.RouteInfo_LayerType[] values()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.RouteInfo_LayerType._m0.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.RouteInfo_LayerType._m0 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_LayerType.staticClass, "values", "()[Lorg/apache/http/conn/routing/RouteInfo$LayerType;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.conn.routing.RouteInfo_LayerType>(@__env.CallStaticObjectMethod(org.apache.http.conn.routing.RouteInfo_LayerType.staticClass, global::org.apache.http.conn.routing.RouteInfo_LayerType._m0)) as org.apache.http.conn.routing.RouteInfo_LayerType[];
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::org.apache.http.conn.routing.RouteInfo_LayerType valueOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.routing.RouteInfo_LayerType._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.routing.RouteInfo_LayerType._m1 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_LayerType.staticClass, "valueOf", "(Ljava/lang/String;)Lorg/apache/http/conn/routing/RouteInfo$LayerType;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.RouteInfo_LayerType>(@__env.CallStaticObjectMethod(org.apache.http.conn.routing.RouteInfo_LayerType.staticClass, global::org.apache.http.conn.routing.RouteInfo_LayerType._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.conn.routing.RouteInfo_LayerType;
		}
		internal static global::MonoJavaBridge.FieldId _LAYERED7470;
		public static global::org.apache.http.conn.routing.RouteInfo_LayerType LAYERED
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.RouteInfo_LayerType>(@__env.GetStaticObjectField(global::org.apache.http.conn.routing.RouteInfo_LayerType.staticClass, _LAYERED7470)) as org.apache.http.conn.routing.RouteInfo_LayerType;
			}
		}
		internal static global::MonoJavaBridge.FieldId _PLAIN7471;
		public static global::org.apache.http.conn.routing.RouteInfo_LayerType PLAIN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.RouteInfo_LayerType>(@__env.GetStaticObjectField(global::org.apache.http.conn.routing.RouteInfo_LayerType.staticClass, _PLAIN7471)) as org.apache.http.conn.routing.RouteInfo_LayerType;
			}
		}
		static RouteInfo_LayerType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.routing.RouteInfo_LayerType.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/routing/RouteInfo$LayerType"));
			global::org.apache.http.conn.routing.RouteInfo_LayerType._LAYERED7470 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_LayerType.staticClass, "LAYERED", "Lorg/apache/http/conn/routing/RouteInfo$LayerType;");
			global::org.apache.http.conn.routing.RouteInfo_LayerType._PLAIN7471 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_LayerType.staticClass, "PLAIN", "Lorg/apache/http/conn/routing/RouteInfo$LayerType;");
		}
		internal static void InitJNI()
		{
		}
	}
}
