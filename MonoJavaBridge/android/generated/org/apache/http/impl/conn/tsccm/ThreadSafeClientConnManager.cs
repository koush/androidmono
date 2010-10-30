namespace org.apache.http.impl.conn.tsccm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ThreadSafeClientConnManager : java.lang.Object, org.apache.http.conn.ClientConnectionManager
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ThreadSafeClientConnManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void shutdown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass, "shutdown", "()V", ref global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass, "finalize", "()V", ref global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._m1);
		}
		public new global::org.apache.http.conn.scheme.SchemeRegistry SchemeRegistry
		{
			get
			{
				return getSchemeRegistry();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::org.apache.http.conn.scheme.SchemeRegistry getSchemeRegistry()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.conn.scheme.SchemeRegistry>(this, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass, "getSchemeRegistry", "()Lorg/apache/http/conn/scheme/SchemeRegistry;", ref global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._m2) as org.apache.http.conn.scheme.SchemeRegistry;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::org.apache.http.conn.ClientConnectionRequest requestConnection(org.apache.http.conn.routing.HttpRoute arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.conn.ClientConnectionRequest>(this, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass, "requestConnection", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;)Lorg/apache/http/conn/ClientConnectionRequest;", ref global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.conn.ClientConnectionRequest;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void releaseConnection(org.apache.http.conn.ManagedClientConnection arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass, "releaseConnection", "(Lorg/apache/http/conn/ManagedClientConnection;JLjava/util/concurrent/TimeUnit;)V", ref global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void closeIdleConnections(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass, "closeIdleConnections", "(JLjava/util/concurrent/TimeUnit;)V", ref global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void closeExpiredConnections()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass, "closeExpiredConnections", "()V", ref global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected virtual global::org.apache.http.conn.ClientConnectionOperator createConnectionOperator(org.apache.http.conn.scheme.SchemeRegistry arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.conn.ClientConnectionOperator>(this, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass, "createConnectionOperator", "(Lorg/apache/http/conn/scheme/SchemeRegistry;)Lorg/apache/http/conn/ClientConnectionOperator;", ref global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.conn.ClientConnectionOperator;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected virtual global::org.apache.http.impl.conn.tsccm.AbstractConnPool createConnectionPool(org.apache.http.@params.HttpParams arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass, "createConnectionPool", "(Lorg/apache/http/params/HttpParams;)Lorg/apache/http/impl/conn/tsccm/AbstractConnPool;", ref global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.impl.conn.tsccm.AbstractConnPool;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual int getConnectionsInPool(org.apache.http.conn.routing.HttpRoute arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass, "getConnectionsInPool", "(Lorg/apache/http/conn/routing/HttpRoute;)I", ref global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ConnectionsInPool
		{
			get
			{
				return getConnectionsInPool();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual int getConnectionsInPool()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass, "getConnectionsInPool", "()I", ref global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public ThreadSafeClientConnManager(org.apache.http.@params.HttpParams arg0, org.apache.http.conn.scheme.SchemeRegistry arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._m11.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._m11 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass, "<init>", "(Lorg/apache/http/params/HttpParams;Lorg/apache/http/conn/scheme/SchemeRegistry;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ThreadSafeClientConnManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/tsccm/ThreadSafeClientConnManager"));
		}
		internal static void InitJNI()
		{
		}
	}
}
