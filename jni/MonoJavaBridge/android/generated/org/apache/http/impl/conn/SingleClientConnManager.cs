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
			internal static global::MonoJavaBridge.MethodId _ConnAdapter26335;
			protected ConnAdapter(org.apache.http.impl.conn.SingleClientConnManager arg0, org.apache.http.impl.conn.SingleClientConnManager.PoolEntry arg1, org.apache.http.conn.routing.HttpRoute arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.SingleClientConnManager.ConnAdapter.staticClass, global::org.apache.http.impl.conn.SingleClientConnManager.ConnAdapter._ConnAdapter26335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::org.apache.http.impl.conn.SingleClientConnManager.ConnAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/SingleClientConnManager$ConnAdapter"));
				global::org.apache.http.impl.conn.SingleClientConnManager.ConnAdapter._ConnAdapter26335 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.SingleClientConnManager.ConnAdapter.staticClass, "<init>", "(Lorg/apache/http/impl/conn/SingleClientConnManager;Lorg/apache/http/impl/conn/SingleClientConnManager$PoolEntry;Lorg/apache/http/conn/routing/HttpRoute;)V");
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
			internal static global::MonoJavaBridge.MethodId _shutdown26336;
			protected virtual void shutdown() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry._shutdown26336);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry.staticClass, global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry._shutdown26336);
			}
			internal static global::MonoJavaBridge.MethodId _close26337;
			protected virtual void close() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry._close26337);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry.staticClass, global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry._close26337);
			}
			internal static global::MonoJavaBridge.MethodId _PoolEntry26338;
			protected PoolEntry(org.apache.http.impl.conn.SingleClientConnManager arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.SingleClientConnManager.PoolEntry.staticClass, global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry._PoolEntry26338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/SingleClientConnManager$PoolEntry"));
				global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry._shutdown26336 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry.staticClass, "shutdown", "()V");
				global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry._close26337 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry.staticClass, "close", "()V");
				global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry._PoolEntry26338 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.SingleClientConnManager.PoolEntry.staticClass, "<init>", "(Lorg/apache/http/impl/conn/SingleClientConnManager;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _shutdown26339;
		public virtual void shutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager._shutdown26339);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, global::org.apache.http.impl.conn.SingleClientConnManager._shutdown26339);
		}
		internal static global::MonoJavaBridge.MethodId _finalize26340;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager._finalize26340);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, global::org.apache.http.impl.conn.SingleClientConnManager._finalize26340);
		}
		internal static global::MonoJavaBridge.MethodId _getConnection26341;
		public virtual global::org.apache.http.conn.ManagedClientConnection getConnection(org.apache.http.conn.routing.HttpRoute arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ManagedClientConnection>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager._getConnection26341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.conn.ManagedClientConnection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ManagedClientConnection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, global::org.apache.http.impl.conn.SingleClientConnManager._getConnection26341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.conn.ManagedClientConnection;
		}
		public new global::org.apache.http.conn.scheme.SchemeRegistry SchemeRegistry
		{
			get
			{
				return getSchemeRegistry();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSchemeRegistry26342;
		public virtual global::org.apache.http.conn.scheme.SchemeRegistry getSchemeRegistry() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager._getSchemeRegistry26342)) as org.apache.http.conn.scheme.SchemeRegistry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, global::org.apache.http.impl.conn.SingleClientConnManager._getSchemeRegistry26342)) as org.apache.http.conn.scheme.SchemeRegistry;
		}
		internal static global::MonoJavaBridge.MethodId _requestConnection26343;
		public virtual global::org.apache.http.conn.ClientConnectionRequest requestConnection(org.apache.http.conn.routing.HttpRoute arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionRequest>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager._requestConnection26343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.conn.ClientConnectionRequest;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionRequest>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, global::org.apache.http.impl.conn.SingleClientConnManager._requestConnection26343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.conn.ClientConnectionRequest;
		}
		internal static global::MonoJavaBridge.MethodId _releaseConnection26344;
		public virtual void releaseConnection(org.apache.http.conn.ManagedClientConnection arg0, long arg1, java.util.concurrent.TimeUnit arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager._releaseConnection26344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, global::org.apache.http.impl.conn.SingleClientConnManager._releaseConnection26344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _closeIdleConnections26345;
		public virtual void closeIdleConnections(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager._closeIdleConnections26345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, global::org.apache.http.impl.conn.SingleClientConnManager._closeIdleConnections26345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _closeExpiredConnections26346;
		public virtual void closeExpiredConnections() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager._closeExpiredConnections26346);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, global::org.apache.http.impl.conn.SingleClientConnManager._closeExpiredConnections26346);
		}
		internal static global::MonoJavaBridge.MethodId _createConnectionOperator26347;
		protected virtual global::org.apache.http.conn.ClientConnectionOperator createConnectionOperator(org.apache.http.conn.scheme.SchemeRegistry arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionOperator>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager._createConnectionOperator26347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.conn.ClientConnectionOperator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionOperator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, global::org.apache.http.impl.conn.SingleClientConnManager._createConnectionOperator26347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.conn.ClientConnectionOperator;
		}
		internal static global::MonoJavaBridge.MethodId _assertStillUp26348;
		protected virtual void assertStillUp() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager._assertStillUp26348);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, global::org.apache.http.impl.conn.SingleClientConnManager._assertStillUp26348);
		}
		internal static global::MonoJavaBridge.MethodId _revokeConnection26349;
		protected virtual void revokeConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager._revokeConnection26349);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, global::org.apache.http.impl.conn.SingleClientConnManager._revokeConnection26349);
		}
		internal static global::MonoJavaBridge.MethodId _SingleClientConnManager26350;
		public SingleClientConnManager(org.apache.http.@params.HttpParams arg0, org.apache.http.conn.scheme.SchemeRegistry arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.SingleClientConnManager.staticClass, global::org.apache.http.impl.conn.SingleClientConnManager._SingleClientConnManager26350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
			global::org.apache.http.impl.conn.SingleClientConnManager._shutdown26339 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "shutdown", "()V");
			global::org.apache.http.impl.conn.SingleClientConnManager._finalize26340 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "finalize", "()V");
			global::org.apache.http.impl.conn.SingleClientConnManager._getConnection26341 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "getConnection", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;)Lorg/apache/http/conn/ManagedClientConnection;");
			global::org.apache.http.impl.conn.SingleClientConnManager._getSchemeRegistry26342 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "getSchemeRegistry", "()Lorg/apache/http/conn/scheme/SchemeRegistry;");
			global::org.apache.http.impl.conn.SingleClientConnManager._requestConnection26343 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "requestConnection", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;)Lorg/apache/http/conn/ClientConnectionRequest;");
			global::org.apache.http.impl.conn.SingleClientConnManager._releaseConnection26344 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "releaseConnection", "(Lorg/apache/http/conn/ManagedClientConnection;JLjava/util/concurrent/TimeUnit;)V");
			global::org.apache.http.impl.conn.SingleClientConnManager._closeIdleConnections26345 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "closeIdleConnections", "(JLjava/util/concurrent/TimeUnit;)V");
			global::org.apache.http.impl.conn.SingleClientConnManager._closeExpiredConnections26346 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "closeExpiredConnections", "()V");
			global::org.apache.http.impl.conn.SingleClientConnManager._createConnectionOperator26347 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "createConnectionOperator", "(Lorg/apache/http/conn/scheme/SchemeRegistry;)Lorg/apache/http/conn/ClientConnectionOperator;");
			global::org.apache.http.impl.conn.SingleClientConnManager._assertStillUp26348 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "assertStillUp", "()V");
			global::org.apache.http.impl.conn.SingleClientConnManager._revokeConnection26349 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "revokeConnection", "()V");
			global::org.apache.http.impl.conn.SingleClientConnManager._SingleClientConnManager26350 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.SingleClientConnManager.staticClass, "<init>", "(Lorg/apache/http/@params/HttpParams;Lorg/apache/http/conn/scheme/SchemeRegistry;)V");
		}
	}
}
