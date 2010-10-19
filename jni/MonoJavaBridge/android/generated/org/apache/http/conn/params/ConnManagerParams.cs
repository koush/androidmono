namespace org.apache.http.conn.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ConnManagerParams : java.lang.Object, ConnManagerPNames
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ConnManagerParams()
		{
			InitJNI();
		}
		internal ConnManagerParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setTimeout25478;
		public static void setTimeout(org.apache.http.@params.HttpParams arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.conn.@params.ConnManagerParams.staticClass, global::org.apache.http.conn.@params.ConnManagerParams._setTimeout25478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setMaxTotalConnections25479;
		public static void setMaxTotalConnections(org.apache.http.@params.HttpParams arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.conn.@params.ConnManagerParams.staticClass, global::org.apache.http.conn.@params.ConnManagerParams._setMaxTotalConnections25479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getTimeout25480;
		public static long getTimeout(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(org.apache.http.conn.@params.ConnManagerParams.staticClass, global::org.apache.http.conn.@params.ConnManagerParams._getTimeout25480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMaxConnectionsPerRoute25481;
		public static void setMaxConnectionsPerRoute(org.apache.http.@params.HttpParams arg0, org.apache.http.conn.@params.ConnPerRoute arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.conn.@params.ConnManagerParams.staticClass, global::org.apache.http.conn.@params.ConnManagerParams._setMaxConnectionsPerRoute25481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMaxConnectionsPerRoute25482;
		public static global::org.apache.http.conn.@params.ConnPerRoute getMaxConnectionsPerRoute(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.@params.ConnPerRoute>(@__env.CallStaticObjectMethod(org.apache.http.conn.@params.ConnManagerParams.staticClass, global::org.apache.http.conn.@params.ConnManagerParams._getMaxConnectionsPerRoute25482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.conn.@params.ConnPerRoute;
		}
		internal static global::MonoJavaBridge.MethodId _getMaxTotalConnections25483;
		public static int getMaxTotalConnections(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(org.apache.http.conn.@params.ConnManagerParams.staticClass, global::org.apache.http.conn.@params.ConnManagerParams._getMaxTotalConnections25483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ConnManagerParams25484;
		public ConnManagerParams()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.@params.ConnManagerParams.staticClass, global::org.apache.http.conn.@params.ConnManagerParams._ConnManagerParams25484);
			Init(@__env, handle);
		}
		public static int DEFAULT_MAX_TOTAL_CONNECTIONS
		{
			get
			{
				return 20;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.@params.ConnManagerParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/@params/ConnManagerParams"));
			global::org.apache.http.conn.@params.ConnManagerParams._setTimeout25478 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.@params.ConnManagerParams.staticClass, "setTimeout", "(Lorg/apache/http/@params/HttpParams;J)V");
			global::org.apache.http.conn.@params.ConnManagerParams._setMaxTotalConnections25479 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.@params.ConnManagerParams.staticClass, "setMaxTotalConnections", "(Lorg/apache/http/@params/HttpParams;I)V");
			global::org.apache.http.conn.@params.ConnManagerParams._getTimeout25480 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.@params.ConnManagerParams.staticClass, "getTimeout", "(Lorg/apache/http/@params/HttpParams;)J");
			global::org.apache.http.conn.@params.ConnManagerParams._setMaxConnectionsPerRoute25481 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.@params.ConnManagerParams.staticClass, "setMaxConnectionsPerRoute", "(Lorg/apache/http/@params/HttpParams;Lorg/apache/http/conn/@params/ConnPerRoute;)V");
			global::org.apache.http.conn.@params.ConnManagerParams._getMaxConnectionsPerRoute25482 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.@params.ConnManagerParams.staticClass, "getMaxConnectionsPerRoute", "(Lorg/apache/http/@params/HttpParams;)Lorg/apache/http/conn/@params/ConnPerRoute;");
			global::org.apache.http.conn.@params.ConnManagerParams._getMaxTotalConnections25483 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.@params.ConnManagerParams.staticClass, "getMaxTotalConnections", "(Lorg/apache/http/@params/HttpParams;)I");
			global::org.apache.http.conn.@params.ConnManagerParams._ConnManagerParams25484 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.@params.ConnManagerParams.staticClass, "<init>", "()V");
		}
	}
}
