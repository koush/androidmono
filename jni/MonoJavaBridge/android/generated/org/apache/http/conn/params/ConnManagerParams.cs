namespace org.apache.http.conn.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ConnManagerParams : java.lang.Object, ConnManagerPNames
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ConnManagerParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setTimeout32183;
		public static void setTimeout(org.apache.http.@params.HttpParams arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.conn.@params.ConnManagerParams.staticClass, global::org.apache.http.conn.@params.ConnManagerParams._setTimeout32183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setMaxTotalConnections32184;
		public static void setMaxTotalConnections(org.apache.http.@params.HttpParams arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.conn.@params.ConnManagerParams.staticClass, global::org.apache.http.conn.@params.ConnManagerParams._setMaxTotalConnections32184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getTimeout32185;
		public static long getTimeout(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(org.apache.http.conn.@params.ConnManagerParams.staticClass, global::org.apache.http.conn.@params.ConnManagerParams._getTimeout32185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMaxConnectionsPerRoute32186;
		public static void setMaxConnectionsPerRoute(org.apache.http.@params.HttpParams arg0, org.apache.http.conn.@params.ConnPerRoute arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.conn.@params.ConnManagerParams.staticClass, global::org.apache.http.conn.@params.ConnManagerParams._setMaxConnectionsPerRoute32186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMaxConnectionsPerRoute32187;
		public static global::org.apache.http.conn.@params.ConnPerRoute getMaxConnectionsPerRoute(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.@params.ConnPerRoute>(@__env.CallStaticObjectMethod(org.apache.http.conn.@params.ConnManagerParams.staticClass, global::org.apache.http.conn.@params.ConnManagerParams._getMaxConnectionsPerRoute32187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.conn.@params.ConnPerRoute;
		}
		internal static global::MonoJavaBridge.MethodId _getMaxTotalConnections32188;
		public static int getMaxTotalConnections(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(org.apache.http.conn.@params.ConnManagerParams.staticClass, global::org.apache.http.conn.@params.ConnManagerParams._getMaxTotalConnections32188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ConnManagerParams32189;
		public ConnManagerParams() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.@params.ConnManagerParams.staticClass, global::org.apache.http.conn.@params.ConnManagerParams._ConnManagerParams32189);
			Init(@__env, handle);
		}
		public static int DEFAULT_MAX_TOTAL_CONNECTIONS
		{
			get
			{
				return 20;
			}
		}
		static ConnManagerParams()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.@params.ConnManagerParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/params/ConnManagerParams"));
			global::org.apache.http.conn.@params.ConnManagerParams._setTimeout32183 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.@params.ConnManagerParams.staticClass, "setTimeout", "(Lorg/apache/http/params/HttpParams;J)V");
			global::org.apache.http.conn.@params.ConnManagerParams._setMaxTotalConnections32184 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.@params.ConnManagerParams.staticClass, "setMaxTotalConnections", "(Lorg/apache/http/params/HttpParams;I)V");
			global::org.apache.http.conn.@params.ConnManagerParams._getTimeout32185 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.@params.ConnManagerParams.staticClass, "getTimeout", "(Lorg/apache/http/params/HttpParams;)J");
			global::org.apache.http.conn.@params.ConnManagerParams._setMaxConnectionsPerRoute32186 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.@params.ConnManagerParams.staticClass, "setMaxConnectionsPerRoute", "(Lorg/apache/http/params/HttpParams;Lorg/apache/http/conn/params/ConnPerRoute;)V");
			global::org.apache.http.conn.@params.ConnManagerParams._getMaxConnectionsPerRoute32187 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.@params.ConnManagerParams.staticClass, "getMaxConnectionsPerRoute", "(Lorg/apache/http/params/HttpParams;)Lorg/apache/http/conn/params/ConnPerRoute;");
			global::org.apache.http.conn.@params.ConnManagerParams._getMaxTotalConnections32188 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.@params.ConnManagerParams.staticClass, "getMaxTotalConnections", "(Lorg/apache/http/params/HttpParams;)I");
			global::org.apache.http.conn.@params.ConnManagerParams._ConnManagerParams32189 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.@params.ConnManagerParams.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
