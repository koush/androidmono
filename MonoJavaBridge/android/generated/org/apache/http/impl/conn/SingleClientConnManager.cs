namespace org.apache.http.impl.conn
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SingleClientConnManager : java.lang.Object, org.apache.http.conn.ClientConnectionManager
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SingleClientConnManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		protected partial class ConnAdapter : org.apache.http.impl.conn.AbstractPooledConnAdapter
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected ConnAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			protected ConnAdapter(org.apache.http.impl.conn.SingleClientConnManager arg0, org.apache.http.impl.conn.SingleClientConnManager.PoolEntry arg1, org.apache.http.conn.routing.HttpRoute arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::org.apache.http.impl.conn.SingleClientConnManager.ConnAdapter._m0.native == global::System.IntPtr.Zero)
					global::org.apache.http.impl.conn.SingleClientConnManager.ConnAdapter._m0 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.SingleClientConnManager.ConnAdapter.staticClass, "<init>", "(Lorg/apache/http/impl/conn/SingleClientConnManager;Lorg/apache/http/impl/conn/SingleClientConnManager$PoolEntry;Lorg/apache/http/conn/routing/HttpRoute;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.SingleClientConnManager.ConnAdapter.staticClass, global::org.apache.http.impl.conn.SingleClientConnManager.ConnAdapter._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			static ConnAdapter()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::org.apache.http.impl.conn.SingleClientConnManager.ConnAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/SingleClientConnManager$ConnAdapter"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		protected partial class PoolEntry : org.apache.http.impl.conn.AbstractPoolEntry
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected PoolEntry(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			protected virtual void shutdown()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry.staticClass, "shutdown", "()V", ref global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry._m0);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			protected virtual void close()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry.staticClass, "close", "()V", ref global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry._m1);
			}
			private static global::MonoJavaBridge.MethodId _m2;
			protected PoolEntry(org.apache.http.impl.conn.SingleClientConnManager arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry._m2.native == global::System.IntPtr.Zero)
					global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry._m2 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry.staticClass, "<init>", "(Lorg/apache/http/impl/conn/SingleClientConnManager;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.SingleClientConnManager.PoolEntry.staticClass, global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static PoolEntry()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/SingleClientConnManager$PoolEntry"));
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void shutdown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "shutdown", "()V", ref global::org.apache.http.impl.conn.SingleClientConnManager._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "finalize", "()V", ref global::org.apache.http.impl.conn.SingleClientConnManager._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::org.apache.http.conn.ManagedClientConnection getConnection(org.apache.http.conn.routing.HttpRoute arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.conn.ManagedClientConnection>(this, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "getConnection", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;)Lorg/apache/http/conn/ManagedClientConnection;", ref global::org.apache.http.impl.conn.SingleClientConnManager._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.conn.ManagedClientConnection;
		}
		public new global::org.apache.http.conn.scheme.SchemeRegistry SchemeRegistry
		{
			get
			{
				return getSchemeRegistry();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::org.apache.http.conn.scheme.SchemeRegistry getSchemeRegistry()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.conn.scheme.SchemeRegistry>(this, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "getSchemeRegistry", "()Lorg/apache/http/conn/scheme/SchemeRegistry;", ref global::org.apache.http.impl.conn.SingleClientConnManager._m3) as org.apache.http.conn.scheme.SchemeRegistry;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::org.apache.http.conn.ClientConnectionRequest requestConnection(org.apache.http.conn.routing.HttpRoute arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.conn.ClientConnectionRequest>(this, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "requestConnection", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;)Lorg/apache/http/conn/ClientConnectionRequest;", ref global::org.apache.http.impl.conn.SingleClientConnManager._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.conn.ClientConnectionRequest;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void releaseConnection(org.apache.http.conn.ManagedClientConnection arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "releaseConnection", "(Lorg/apache/http/conn/ManagedClientConnection;JLjava/util/concurrent/TimeUnit;)V", ref global::org.apache.http.impl.conn.SingleClientConnManager._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void closeIdleConnections(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "closeIdleConnections", "(JLjava/util/concurrent/TimeUnit;)V", ref global::org.apache.http.impl.conn.SingleClientConnManager._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void closeExpiredConnections()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "closeExpiredConnections", "()V", ref global::org.apache.http.impl.conn.SingleClientConnManager._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected virtual global::org.apache.http.conn.ClientConnectionOperator createConnectionOperator(org.apache.http.conn.scheme.SchemeRegistry arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.conn.ClientConnectionOperator>(this, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "createConnectionOperator", "(Lorg/apache/http/conn/scheme/SchemeRegistry;)Lorg/apache/http/conn/ClientConnectionOperator;", ref global::org.apache.http.impl.conn.SingleClientConnManager._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.conn.ClientConnectionOperator;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected virtual void assertStillUp()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "assertStillUp", "()V", ref global::org.apache.http.impl.conn.SingleClientConnManager._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected virtual void revokeConnection()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "revokeConnection", "()V", ref global::org.apache.http.impl.conn.SingleClientConnManager._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public SingleClientConnManager(org.apache.http.@params.HttpParams arg0, org.apache.http.conn.scheme.SchemeRegistry arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.conn.SingleClientConnManager._m11.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.conn.SingleClientConnManager._m11 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "<init>", "(Lorg/apache/http/params/HttpParams;Lorg/apache/http/conn/scheme/SchemeRegistry;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.SingleClientConnManager.staticClass, global::org.apache.http.impl.conn.SingleClientConnManager._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static global::java.lang.String MISUSE_MESSAGE
		{
			get
			{
				return "Invalid use of SingleClientConnManager: connection still allocated.\nMake sure to release the connection before allocating another one.";
			}
		}
		static SingleClientConnManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.SingleClientConnManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/SingleClientConnManager"));
		}
	}
}
