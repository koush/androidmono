namespace org.apache.http.conn.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ConnManagerParams : java.lang.Object, ConnManagerPNames
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ConnManagerParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static void setTimeout(org.apache.http.@params.HttpParams arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.@params.ConnManagerParams._m0.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.@params.ConnManagerParams._m0 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.@params.ConnManagerParams.staticClass, "setTimeout", "(Lorg/apache/http/params/HttpParams;J)V");
			@__env.CallStaticVoidMethod(org.apache.http.conn.@params.ConnManagerParams.staticClass, global::org.apache.http.conn.@params.ConnManagerParams._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static void setMaxTotalConnections(org.apache.http.@params.HttpParams arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.@params.ConnManagerParams._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.@params.ConnManagerParams._m1 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.@params.ConnManagerParams.staticClass, "setMaxTotalConnections", "(Lorg/apache/http/params/HttpParams;I)V");
			@__env.CallStaticVoidMethod(org.apache.http.conn.@params.ConnManagerParams.staticClass, global::org.apache.http.conn.@params.ConnManagerParams._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static long getTimeout(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.@params.ConnManagerParams._m2.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.@params.ConnManagerParams._m2 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.@params.ConnManagerParams.staticClass, "getTimeout", "(Lorg/apache/http/params/HttpParams;)J");
			return @__env.CallStaticLongMethod(org.apache.http.conn.@params.ConnManagerParams.staticClass, global::org.apache.http.conn.@params.ConnManagerParams._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static void setMaxConnectionsPerRoute(org.apache.http.@params.HttpParams arg0, org.apache.http.conn.@params.ConnPerRoute arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.@params.ConnManagerParams._m3.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.@params.ConnManagerParams._m3 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.@params.ConnManagerParams.staticClass, "setMaxConnectionsPerRoute", "(Lorg/apache/http/params/HttpParams;Lorg/apache/http/conn/params/ConnPerRoute;)V");
			@__env.CallStaticVoidMethod(org.apache.http.conn.@params.ConnManagerParams.staticClass, global::org.apache.http.conn.@params.ConnManagerParams._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static global::org.apache.http.conn.@params.ConnPerRoute getMaxConnectionsPerRoute(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.@params.ConnManagerParams._m4.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.@params.ConnManagerParams._m4 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.@params.ConnManagerParams.staticClass, "getMaxConnectionsPerRoute", "(Lorg/apache/http/params/HttpParams;)Lorg/apache/http/conn/params/ConnPerRoute;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.@params.ConnPerRoute>(@__env.CallStaticObjectMethod(org.apache.http.conn.@params.ConnManagerParams.staticClass, global::org.apache.http.conn.@params.ConnManagerParams._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.conn.@params.ConnPerRoute;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static int getMaxTotalConnections(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.@params.ConnManagerParams._m5.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.@params.ConnManagerParams._m5 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.@params.ConnManagerParams.staticClass, "getMaxTotalConnections", "(Lorg/apache/http/params/HttpParams;)I");
			return @__env.CallStaticIntMethod(org.apache.http.conn.@params.ConnManagerParams.staticClass, global::org.apache.http.conn.@params.ConnManagerParams._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public ConnManagerParams() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.@params.ConnManagerParams._m6.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.@params.ConnManagerParams._m6 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.@params.ConnManagerParams.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.@params.ConnManagerParams.staticClass, global::org.apache.http.conn.@params.ConnManagerParams._m6);
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
		}
	}
}
