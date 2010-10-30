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
			internal static global::MonoJavaBridge.MethodId _ConnAdapter33077;
			protected ConnAdapter(org.apache.http.impl.conn.SingleClientConnManager arg0, org.apache.http.impl.conn.SingleClientConnManager.PoolEntry arg1, org.apache.http.conn.routing.HttpRoute arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::org.apache.http.impl.conn.SingleClientConnManager.ConnAdapter._ConnAdapter33077.native == global::System.IntPtr.Zero)
					global::org.apache.http.impl.conn.SingleClientConnManager.ConnAdapter._ConnAdapter33077 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.SingleClientConnManager.ConnAdapter.staticClass, "<init>", "(Lorg/apache/http/impl/conn/SingleClientConnManager;Lorg/apache/http/impl/conn/SingleClientConnManager$PoolEntry;Lorg/apache/http/conn/routing/HttpRoute;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.SingleClientConnManager.ConnAdapter.staticClass, global::org.apache.http.impl.conn.SingleClientConnManager.ConnAdapter._ConnAdapter33077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			static ConnAdapter()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::org.apache.http.impl.conn.SingleClientConnManager.ConnAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/SingleClientConnManager$ConnAdapter"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		protected partial class PoolEntry : org.apache.http.impl.conn.AbstractPoolEntry
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected PoolEntry(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _shutdown33078;
			protected virtual void shutdown()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry.staticClass, "shutdown", "()V", ref global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry._shutdown33078);
			}
			internal static global::MonoJavaBridge.MethodId _close33079;
			protected virtual void close()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry.staticClass, "close", "()V", ref global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry._close33079);
			}
			internal static global::MonoJavaBridge.MethodId _PoolEntry33080;
			protected PoolEntry(org.apache.http.impl.conn.SingleClientConnManager arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry._PoolEntry33080.native == global::System.IntPtr.Zero)
					global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry._PoolEntry33080 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry.staticClass, "<init>", "(Lorg/apache/http/impl/conn/SingleClientConnManager;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.SingleClientConnManager.PoolEntry.staticClass, global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry._PoolEntry33080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static PoolEntry()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/SingleClientConnManager$PoolEntry"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _shutdown33081;
		public virtual void shutdown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "shutdown", "()V", ref global::org.apache.http.impl.conn.SingleClientConnManager._shutdown33081);
		}
		internal static global::MonoJavaBridge.MethodId _finalize33082;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "finalize", "()V", ref global::org.apache.http.impl.conn.SingleClientConnManager._finalize33082);
		}
		internal static global::MonoJavaBridge.MethodId _getConnection33083;
		public virtual global::org.apache.http.conn.ManagedClientConnection getConnection(org.apache.http.conn.routing.HttpRoute arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.conn.ManagedClientConnection>(this, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "getConnection", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;)Lorg/apache/http/conn/ManagedClientConnection;", ref global::org.apache.http.impl.conn.SingleClientConnManager._getConnection33083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.conn.ManagedClientConnection;
		}
		public new global::org.apache.http.conn.scheme.SchemeRegistry SchemeRegistry
		{
			get
			{
				return getSchemeRegistry();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSchemeRegistry33084;
		public virtual global::org.apache.http.conn.scheme.SchemeRegistry getSchemeRegistry()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.conn.scheme.SchemeRegistry>(this, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "getSchemeRegistry", "()Lorg/apache/http/conn/scheme/SchemeRegistry;", ref global::org.apache.http.impl.conn.SingleClientConnManager._getSchemeRegistry33084) as org.apache.http.conn.scheme.SchemeRegistry;
		}
		internal static global::MonoJavaBridge.MethodId _requestConnection33085;
		public virtual global::org.apache.http.conn.ClientConnectionRequest requestConnection(org.apache.http.conn.routing.HttpRoute arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.conn.ClientConnectionRequest>(this, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "requestConnection", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;)Lorg/apache/http/conn/ClientConnectionRequest;", ref global::org.apache.http.impl.conn.SingleClientConnManager._requestConnection33085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.conn.ClientConnectionRequest;
		}
		internal static global::MonoJavaBridge.MethodId _releaseConnection33086;
		public virtual void releaseConnection(org.apache.http.conn.ManagedClientConnection arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "releaseConnection", "(Lorg/apache/http/conn/ManagedClientConnection;JLjava/util/concurrent/TimeUnit;)V", ref global::org.apache.http.impl.conn.SingleClientConnManager._releaseConnection33086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _closeIdleConnections33087;
		public virtual void closeIdleConnections(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "closeIdleConnections", "(JLjava/util/concurrent/TimeUnit;)V", ref global::org.apache.http.impl.conn.SingleClientConnManager._closeIdleConnections33087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _closeExpiredConnections33088;
		public virtual void closeExpiredConnections()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "closeExpiredConnections", "()V", ref global::org.apache.http.impl.conn.SingleClientConnManager._closeExpiredConnections33088);
		}
		internal static global::MonoJavaBridge.MethodId _createConnectionOperator33089;
		protected virtual global::org.apache.http.conn.ClientConnectionOperator createConnectionOperator(org.apache.http.conn.scheme.SchemeRegistry arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.conn.ClientConnectionOperator>(this, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "createConnectionOperator", "(Lorg/apache/http/conn/scheme/SchemeRegistry;)Lorg/apache/http/conn/ClientConnectionOperator;", ref global::org.apache.http.impl.conn.SingleClientConnManager._createConnectionOperator33089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.conn.ClientConnectionOperator;
		}
		internal static global::MonoJavaBridge.MethodId _assertStillUp33090;
		protected virtual void assertStillUp()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "assertStillUp", "()V", ref global::org.apache.http.impl.conn.SingleClientConnManager._assertStillUp33090);
		}
		internal static global::MonoJavaBridge.MethodId _revokeConnection33091;
		protected virtual void revokeConnection()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "revokeConnection", "()V", ref global::org.apache.http.impl.conn.SingleClientConnManager._revokeConnection33091);
		}
		internal static global::MonoJavaBridge.MethodId _SingleClientConnManager33092;
		public SingleClientConnManager(org.apache.http.@params.HttpParams arg0, org.apache.http.conn.scheme.SchemeRegistry arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.conn.SingleClientConnManager._SingleClientConnManager33092.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.conn.SingleClientConnManager._SingleClientConnManager33092 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "<init>", "(Lorg/apache/http/params/HttpParams;Lorg/apache/http/conn/scheme/SchemeRegistry;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.SingleClientConnManager.staticClass, global::org.apache.http.impl.conn.SingleClientConnManager._SingleClientConnManager33092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		internal static void InitJNI()
		{
		}
	}
}
