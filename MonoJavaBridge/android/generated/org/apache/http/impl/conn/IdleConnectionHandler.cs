namespace org.apache.http.impl.conn
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IdleConnectionHandler : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IdleConnectionHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void add(org.apache.http.HttpConnection arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.IdleConnectionHandler.staticClass, "add", "(Lorg/apache/http/HttpConnection;JLjava/util/concurrent/TimeUnit;)V", ref global::org.apache.http.impl.conn.IdleConnectionHandler._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual bool remove(org.apache.http.HttpConnection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.conn.IdleConnectionHandler.staticClass, "remove", "(Lorg/apache/http/HttpConnection;)Z", ref global::org.apache.http.impl.conn.IdleConnectionHandler._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void removeAll()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.IdleConnectionHandler.staticClass, "removeAll", "()V", ref global::org.apache.http.impl.conn.IdleConnectionHandler._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void closeIdleConnections(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.IdleConnectionHandler.staticClass, "closeIdleConnections", "(J)V", ref global::org.apache.http.impl.conn.IdleConnectionHandler._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void closeExpiredConnections()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.IdleConnectionHandler.staticClass, "closeExpiredConnections", "()V", ref global::org.apache.http.impl.conn.IdleConnectionHandler._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public IdleConnectionHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.conn.IdleConnectionHandler._m5.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.conn.IdleConnectionHandler._m5 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.IdleConnectionHandler.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.IdleConnectionHandler.staticClass, global::org.apache.http.impl.conn.IdleConnectionHandler._m5);
			Init(@__env, handle);
		}
		static IdleConnectionHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.IdleConnectionHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/IdleConnectionHandler"));
		}
	}
}
