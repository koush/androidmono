namespace org.apache.http.impl.conn
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IdleConnectionHandler : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IdleConnectionHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add33048;
		public virtual void add(org.apache.http.HttpConnection arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.IdleConnectionHandler.staticClass, "add", "(Lorg/apache/http/HttpConnection;JLjava/util/concurrent/TimeUnit;)V", ref global::org.apache.http.impl.conn.IdleConnectionHandler._add33048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _remove33049;
		public virtual bool remove(org.apache.http.HttpConnection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.conn.IdleConnectionHandler.staticClass, "remove", "(Lorg/apache/http/HttpConnection;)Z", ref global::org.apache.http.impl.conn.IdleConnectionHandler._remove33049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll33050;
		public virtual void removeAll()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.IdleConnectionHandler.staticClass, "removeAll", "()V", ref global::org.apache.http.impl.conn.IdleConnectionHandler._removeAll33050);
		}
		internal static global::MonoJavaBridge.MethodId _closeIdleConnections33051;
		public virtual void closeIdleConnections(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.IdleConnectionHandler.staticClass, "closeIdleConnections", "(J)V", ref global::org.apache.http.impl.conn.IdleConnectionHandler._closeIdleConnections33051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _closeExpiredConnections33052;
		public virtual void closeExpiredConnections()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.IdleConnectionHandler.staticClass, "closeExpiredConnections", "()V", ref global::org.apache.http.impl.conn.IdleConnectionHandler._closeExpiredConnections33052);
		}
		internal static global::MonoJavaBridge.MethodId _IdleConnectionHandler33053;
		public IdleConnectionHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.conn.IdleConnectionHandler._IdleConnectionHandler33053.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.conn.IdleConnectionHandler._IdleConnectionHandler33053 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.IdleConnectionHandler.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.IdleConnectionHandler.staticClass, global::org.apache.http.impl.conn.IdleConnectionHandler._IdleConnectionHandler33053);
			Init(@__env, handle);
		}
		static IdleConnectionHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.IdleConnectionHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/IdleConnectionHandler"));
		}
		internal static void InitJNI()
		{
		}
	}
}
