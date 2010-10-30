namespace org.apache.http.conn
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConnectionPoolTimeoutException : org.apache.http.conn.ConnectTimeoutException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ConnectionPoolTimeoutException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public ConnectionPoolTimeoutException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.ConnectionPoolTimeoutException._m0.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.ConnectionPoolTimeoutException._m0 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ConnectionPoolTimeoutException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.ConnectionPoolTimeoutException.staticClass, global::org.apache.http.conn.ConnectionPoolTimeoutException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public ConnectionPoolTimeoutException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.ConnectionPoolTimeoutException._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.ConnectionPoolTimeoutException._m1 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ConnectionPoolTimeoutException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.ConnectionPoolTimeoutException.staticClass, global::org.apache.http.conn.ConnectionPoolTimeoutException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ConnectionPoolTimeoutException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.ConnectionPoolTimeoutException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/ConnectionPoolTimeoutException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
