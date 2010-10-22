namespace org.apache.http.impl.conn
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SingleClientConnManager : java.lang.Object, org.apache.http.conn.ClientConnectionManager
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SingleClientConnManager()
		{
			InitJNI();
		}
		protected SingleClientConnManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		protected partial class ConnAdapter : org.apache.http.impl.conn.AbstractPooledConnAdapter
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static ConnAdapter()
			{
				InitJNI();
			}
			protected ConnAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _ConnAdapter32958;
			protected ConnAdapter(org.apache.http.impl.conn.SingleClientConnManager arg0, org.apache.http.impl.conn.SingleClientConnManager.PoolEntry arg1, org.apache.http.conn.routing.HttpRoute arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.SingleClientConnManager.ConnAdapter.staticClass, global::org.apache.http.impl.conn.SingleClientConnManager.ConnAdapter._ConnAdapter32958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::org.apache.http.impl.conn.SingleClientConnManager.ConnAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/SingleClientConnManager$ConnAdapter"));
				global::org.apache.http.impl.conn.SingleClientConnManager.ConnAdapter._ConnAdapter32958 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.SingleClientConnManager.ConnAdapter.staticClass, "<init>", "(Lorg/apache/http/impl/conn/SingleClientConnManager;Lorg/apache/http/impl/conn/SingleClientConnManager$PoolEntry;Lorg/apache/http/conn/routing/HttpRoute;)V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		protected partial class PoolEntry : org.apache.http.impl.conn.AbstractPoolEntry
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static PoolEntry()
			{
				InitJNI();
			}
			protected PoolEntry(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _shutdown32959;
			protected virtual void shutdown() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry._shutdown32959);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry.staticClass, global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry._shutdown32959);
			}
			internal static global::MonoJavaBridge.MethodId _close32960;
			protected virtual void close() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry._close32960);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry.staticClass, global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry._close32960);
			}
			internal static global::MonoJavaBridge.MethodId _PoolEntry32961;
			protected PoolEntry(org.apache.http.impl.conn.SingleClientConnManager arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.SingleClientConnManager.PoolEntry.staticClass, global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry._PoolEntry32961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/SingleClientConnManager$PoolEntry"));
				global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry._shutdown32959 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry.staticClass, "shutdown", "()V");
				global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry._close32960 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry.staticClass, "close", "()V");
				global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry._PoolEntry32961 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry.staticClass, "<init>", "(Lorg/apache/http/impl/conn/SingleClientConnManager;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _shutdown32962;
		public virtual void shutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager._shutdown32962);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, global::org.apache.http.impl.conn.SingleClientConnManager._shutdown32962);
		}
		internal static global::MonoJavaBridge.MethodId _finalize32963;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager._finalize32963);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, global::org.apache.http.impl.conn.SingleClientConnManager._finalize32963);
		}
		internal static global::MonoJavaBridge.MethodId _getConnection32964;
		public virtual global::org.apache.http.conn.ManagedClientConnection getConnection(org.apache.http.conn.routing.HttpRoute arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ManagedClientConnection>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager._getConnection32964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.conn.ManagedClientConnection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ManagedClientConnection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, global::org.apache.http.impl.conn.SingleClientConnManager._getConnection32964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.conn.ManagedClientConnection;
		}
		public new global::org.apache.http.conn.scheme.SchemeRegistry SchemeRegistry
		{
			get
			{
				return getSchemeRegistry();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSchemeRegistry32965;
		public virtual global::org.apache.http.conn.scheme.SchemeRegistry getSchemeRegistry() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.scheme.SchemeRegistry>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager._getSchemeRegistry32965)) as org.apache.http.conn.scheme.SchemeRegistry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.scheme.SchemeRegistry>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, global::org.apache.http.impl.conn.SingleClientConnManager._getSchemeRegistry32965)) as org.apache.http.conn.scheme.SchemeRegistry;
		}
		internal static global::MonoJavaBridge.MethodId _requestConnection32966;
		public virtual global::org.apache.http.conn.ClientConnectionRequest requestConnection(org.apache.http.conn.routing.HttpRoute arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionRequest>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager._requestConnection32966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.conn.ClientConnectionRequest;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionRequest>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, global::org.apache.http.impl.conn.SingleClientConnManager._requestConnection32966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.conn.ClientConnectionRequest;
		}
		internal static global::MonoJavaBridge.MethodId _releaseConnection32967;
		public virtual void releaseConnection(org.apache.http.conn.ManagedClientConnection arg0, long arg1, java.util.concurrent.TimeUnit arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager._releaseConnection32967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, global::org.apache.http.impl.conn.SingleClientConnManager._releaseConnection32967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _closeIdleConnections32968;
		public virtual void closeIdleConnections(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager._closeIdleConnections32968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, global::org.apache.http.impl.conn.SingleClientConnManager._closeIdleConnections32968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _closeExpiredConnections32969;
		public virtual void closeExpiredConnections() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager._closeExpiredConnections32969);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, global::org.apache.http.impl.conn.SingleClientConnManager._closeExpiredConnections32969);
		}
		internal static global::MonoJavaBridge.MethodId _createConnectionOperator32970;
		protected virtual global::org.apache.http.conn.ClientConnectionOperator createConnectionOperator(org.apache.http.conn.scheme.SchemeRegistry arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionOperator>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager._createConnectionOperator32970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.conn.ClientConnectionOperator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionOperator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, global::org.apache.http.impl.conn.SingleClientConnManager._createConnectionOperator32970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.conn.ClientConnectionOperator;
		}
		internal static global::MonoJavaBridge.MethodId _assertStillUp32971;
		protected virtual void assertStillUp() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager._assertStillUp32971);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, global::org.apache.http.impl.conn.SingleClientConnManager._assertStillUp32971);
		}
		internal static global::MonoJavaBridge.MethodId _revokeConnection32972;
		protected virtual void revokeConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager._revokeConnection32972);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, global::org.apache.http.impl.conn.SingleClientConnManager._revokeConnection32972);
		}
		internal static global::MonoJavaBridge.MethodId _SingleClientConnManager32973;
		public SingleClientConnManager(org.apache.http.@params.HttpParams arg0, org.apache.http.conn.scheme.SchemeRegistry arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.SingleClientConnManager.staticClass, global::org.apache.http.impl.conn.SingleClientConnManager._SingleClientConnManager32973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static global::java.lang.String MISUSE_MESSAGE
		{
			get
			{
				return "Invalid use of SingleClientConnManager: connection still allocated.\nMake sure to release the connection before allocating another one.";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.SingleClientConnManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/SingleClientConnManager"));
			global::org.apache.http.impl.conn.SingleClientConnManager._shutdown32962 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "shutdown", "()V");
			global::org.apache.http.impl.conn.SingleClientConnManager._finalize32963 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "finalize", "()V");
			global::org.apache.http.impl.conn.SingleClientConnManager._getConnection32964 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "getConnection", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;)Lorg/apache/http/conn/ManagedClientConnection;");
			global::org.apache.http.impl.conn.SingleClientConnManager._getSchemeRegistry32965 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "getSchemeRegistry", "()Lorg/apache/http/conn/scheme/SchemeRegistry;");
			global::org.apache.http.impl.conn.SingleClientConnManager._requestConnection32966 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "requestConnection", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;)Lorg/apache/http/conn/ClientConnectionRequest;");
			global::org.apache.http.impl.conn.SingleClientConnManager._releaseConnection32967 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "releaseConnection", "(Lorg/apache/http/conn/ManagedClientConnection;JLjava/util/concurrent/TimeUnit;)V");
			global::org.apache.http.impl.conn.SingleClientConnManager._closeIdleConnections32968 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "closeIdleConnections", "(JLjava/util/concurrent/TimeUnit;)V");
			global::org.apache.http.impl.conn.SingleClientConnManager._closeExpiredConnections32969 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "closeExpiredConnections", "()V");
			global::org.apache.http.impl.conn.SingleClientConnManager._createConnectionOperator32970 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "createConnectionOperator", "(Lorg/apache/http/conn/scheme/SchemeRegistry;)Lorg/apache/http/conn/ClientConnectionOperator;");
			global::org.apache.http.impl.conn.SingleClientConnManager._assertStillUp32971 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "assertStillUp", "()V");
			global::org.apache.http.impl.conn.SingleClientConnManager._revokeConnection32972 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "revokeConnection", "()V");
			global::org.apache.http.impl.conn.SingleClientConnManager._SingleClientConnManager32973 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "<init>", "(Lorg/apache/http/@params/HttpParams;Lorg/apache/http/conn/scheme/SchemeRegistry;)V");
		}
	}
}
