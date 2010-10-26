namespace org.apache.http.conn.routing
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class RouteInfo_LayerType : java.lang.Enum
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RouteInfo_LayerType()
		{
			InitJNI();
		}
		internal RouteInfo_LayerType(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _values32247;
		public static global::org.apache.http.conn.routing.RouteInfo_LayerType[] values() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.conn.routing.RouteInfo_LayerType>(@__env.CallStaticObjectMethod(org.apache.http.conn.routing.RouteInfo_LayerType.staticClass, global::org.apache.http.conn.routing.RouteInfo_LayerType._values32247)) as org.apache.http.conn.routing.RouteInfo_LayerType[];
		}
		internal static global::MonoJavaBridge.MethodId _valueOf32248;
		public static global::org.apache.http.conn.routing.RouteInfo_LayerType valueOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.RouteInfo_LayerType>(@__env.CallStaticObjectMethod(org.apache.http.conn.routing.RouteInfo_LayerType.staticClass, global::org.apache.http.conn.routing.RouteInfo_LayerType._valueOf32248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.conn.routing.RouteInfo_LayerType;
		}
		internal static global::MonoJavaBridge.FieldId _LAYERED32249;
		public static global::org.apache.http.conn.routing.RouteInfo_LayerType LAYERED
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.RouteInfo_LayerType>(@__env.GetStaticObjectField(global::org.apache.http.conn.routing.RouteInfo_LayerType.staticClass, _LAYERED32249)) as org.apache.http.conn.routing.RouteInfo_LayerType;
			}
		}
		internal static global::MonoJavaBridge.FieldId _PLAIN32250;
		public static global::org.apache.http.conn.routing.RouteInfo_LayerType PLAIN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.RouteInfo_LayerType>(@__env.GetStaticObjectField(global::org.apache.http.conn.routing.RouteInfo_LayerType.staticClass, _PLAIN32250)) as org.apache.http.conn.routing.RouteInfo_LayerType;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.routing.RouteInfo_LayerType.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/routing/RouteInfo$LayerType"));
			global::org.apache.http.conn.routing.RouteInfo_LayerType._values32247 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_LayerType.staticClass, "values", "()[Lorg/apache/http/conn/routing/RouteInfo$LayerType;");
			global::org.apache.http.conn.routing.RouteInfo_LayerType._valueOf32248 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_LayerType.staticClass, "valueOf", "(Ljava/lang/String;)Lorg/apache/http/conn/routing/RouteInfo$LayerType;");
			global::org.apache.http.conn.routing.RouteInfo_LayerType._LAYERED32249 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_LayerType.staticClass, "LAYERED", "Lorg/apache/http/conn/routing/RouteInfo$LayerType;");
			global::org.apache.http.conn.routing.RouteInfo_LayerType._PLAIN32250 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.conn.routing.RouteInfo_LayerType.staticClass, "PLAIN", "Lorg/apache/http/conn/routing/RouteInfo$LayerType;");
		}
	}
}
