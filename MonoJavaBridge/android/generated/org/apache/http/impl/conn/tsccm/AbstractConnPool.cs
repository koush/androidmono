namespace org.apache.http.impl.conn.tsccm
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.impl.conn.tsccm.AbstractConnPool_))]
	public abstract partial class AbstractConnPool : java.lang.Object, RefQueueHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractConnPool(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _shutdown33106;
		public virtual void shutdown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "shutdown", "()V", ref global::org.apache.http.impl.conn.tsccm.AbstractConnPool._shutdown33106);
		}
		internal static global::MonoJavaBridge.MethodId _getEntry33107;
		public virtual global::org.apache.http.impl.conn.tsccm.BasicPoolEntry getEntry(org.apache.http.conn.routing.HttpRoute arg0, java.lang.Object arg1, long arg2, java.util.concurrent.TimeUnit arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "getEntry", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;", ref global::org.apache.http.impl.conn.tsccm.AbstractConnPool._getEntry33107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as org.apache.http.impl.conn.tsccm.BasicPoolEntry;
		}
		internal static global::MonoJavaBridge.MethodId _freeEntry33108;
		public abstract void freeEntry(org.apache.http.impl.conn.tsccm.BasicPoolEntry arg0, bool arg1, long arg2, java.util.concurrent.TimeUnit arg3);
		internal static global::MonoJavaBridge.MethodId _closeIdleConnections33109;
		public virtual void closeIdleConnections(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "closeIdleConnections", "(JLjava/util/concurrent/TimeUnit;)V", ref global::org.apache.http.impl.conn.tsccm.AbstractConnPool._closeIdleConnections33109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _closeExpiredConnections33110;
		public virtual void closeExpiredConnections()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "closeExpiredConnections", "()V", ref global::org.apache.http.impl.conn.tsccm.AbstractConnPool._closeExpiredConnections33110);
		}
		internal static global::MonoJavaBridge.MethodId _enableConnectionGC33111;
		public virtual void enableConnectionGC()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "enableConnectionGC", "()V", ref global::org.apache.http.impl.conn.tsccm.AbstractConnPool._enableConnectionGC33111);
		}
		internal static global::MonoJavaBridge.MethodId _requestPoolEntry33112;
		public abstract global::org.apache.http.impl.conn.tsccm.PoolEntryRequest requestPoolEntry(org.apache.http.conn.routing.HttpRoute arg0, java.lang.Object arg1);
		internal static global::MonoJavaBridge.MethodId _handleReference33113;
		public virtual void handleReference(java.lang.@ref.Reference arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "handleReference", "(Ljava/lang/ref/Reference;)V", ref global::org.apache.http.impl.conn.tsccm.AbstractConnPool._handleReference33113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _handleLostEntry33114;
		protected abstract void handleLostEntry(org.apache.http.conn.routing.HttpRoute arg0);
		internal static global::MonoJavaBridge.MethodId _deleteClosedConnections33115;
		public abstract void deleteClosedConnections();
		internal static global::MonoJavaBridge.MethodId _closeConnection33116;
		protected virtual void closeConnection(org.apache.http.conn.OperatedClientConnection arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "closeConnection", "(Lorg/apache/http/conn/OperatedClientConnection;)V", ref global::org.apache.http.impl.conn.tsccm.AbstractConnPool._closeConnection33116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AbstractConnPool33117;
		protected AbstractConnPool() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.conn.tsccm.AbstractConnPool._AbstractConnPool33117.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.conn.tsccm.AbstractConnPool._AbstractConnPool33117 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, global::org.apache.http.impl.conn.tsccm.AbstractConnPool._AbstractConnPool33117);
			Init(@__env, handle);
		}
		static AbstractConnPool()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/tsccm/AbstractConnPool"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.conn.tsccm.AbstractConnPool))]
	internal sealed partial class AbstractConnPool_ : org.apache.http.impl.conn.tsccm.AbstractConnPool
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractConnPool_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _freeEntry33118;
		public override void freeEntry(org.apache.http.impl.conn.tsccm.BasicPoolEntry arg0, bool arg1, long arg2, java.util.concurrent.TimeUnit arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.AbstractConnPool_.staticClass, "freeEntry", "(Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;ZJLjava/util/concurrent/TimeUnit;)V", ref global::org.apache.http.impl.conn.tsccm.AbstractConnPool_._freeEntry33118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _requestPoolEntry33119;
		public override global::org.apache.http.impl.conn.tsccm.PoolEntryRequest requestPoolEntry(org.apache.http.conn.routing.HttpRoute arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.impl.conn.tsccm.PoolEntryRequest>(this, global::org.apache.http.impl.conn.tsccm.AbstractConnPool_.staticClass, "requestPoolEntry", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;)Lorg/apache/http/impl/conn/tsccm/PoolEntryRequest;", ref global::org.apache.http.impl.conn.tsccm.AbstractConnPool_._requestPoolEntry33119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.impl.conn.tsccm.PoolEntryRequest;
		}
		internal static global::MonoJavaBridge.MethodId _handleLostEntry33120;
		protected override void handleLostEntry(org.apache.http.conn.routing.HttpRoute arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.AbstractConnPool_.staticClass, "handleLostEntry", "(Lorg/apache/http/conn/routing/HttpRoute;)V", ref global::org.apache.http.impl.conn.tsccm.AbstractConnPool_._handleLostEntry33120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deleteClosedConnections33121;
		public override void deleteClosedConnections()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.AbstractConnPool_.staticClass, "deleteClosedConnections", "()V", ref global::org.apache.http.impl.conn.tsccm.AbstractConnPool_._deleteClosedConnections33121);
		}
		static AbstractConnPool_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/tsccm/AbstractConnPool"));
		}
		internal static void InitJNI()
		{
		}
	}
}
