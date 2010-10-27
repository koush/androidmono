namespace org.apache.http.impl.conn.tsccm
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.impl.conn.tsccm.AbstractConnPool_))]
	public abstract partial class AbstractConnPool : java.lang.Object, RefQueueHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractConnPool()
		{
			InitJNI();
		}
		protected AbstractConnPool(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _shutdown33105;
		public virtual void shutdown()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool._shutdown33105);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, global::org.apache.http.impl.conn.tsccm.AbstractConnPool._shutdown33105);
		}
		internal static global::MonoJavaBridge.MethodId _getEntry33106;
		public virtual global::org.apache.http.impl.conn.tsccm.BasicPoolEntry getEntry(org.apache.http.conn.routing.HttpRoute arg0, java.lang.Object arg1, long arg2, java.util.concurrent.TimeUnit arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool._getEntry33106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as org.apache.http.impl.conn.tsccm.BasicPoolEntry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, global::org.apache.http.impl.conn.tsccm.AbstractConnPool._getEntry33106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as org.apache.http.impl.conn.tsccm.BasicPoolEntry;
		}
		internal static global::MonoJavaBridge.MethodId _freeEntry33107;
		public abstract void freeEntry(org.apache.http.impl.conn.tsccm.BasicPoolEntry arg0, bool arg1, long arg2, java.util.concurrent.TimeUnit arg3);
		internal static global::MonoJavaBridge.MethodId _closeIdleConnections33108;
		public virtual void closeIdleConnections(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool._closeIdleConnections33108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, global::org.apache.http.impl.conn.tsccm.AbstractConnPool._closeIdleConnections33108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _closeExpiredConnections33109;
		public virtual void closeExpiredConnections()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool._closeExpiredConnections33109);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, global::org.apache.http.impl.conn.tsccm.AbstractConnPool._closeExpiredConnections33109);
		}
		internal static global::MonoJavaBridge.MethodId _enableConnectionGC33110;
		public virtual void enableConnectionGC()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool._enableConnectionGC33110);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, global::org.apache.http.impl.conn.tsccm.AbstractConnPool._enableConnectionGC33110);
		}
		internal static global::MonoJavaBridge.MethodId _requestPoolEntry33111;
		public abstract global::org.apache.http.impl.conn.tsccm.PoolEntryRequest requestPoolEntry(org.apache.http.conn.routing.HttpRoute arg0, java.lang.Object arg1);
		internal static global::MonoJavaBridge.MethodId _handleReference33112;
		public virtual void handleReference(java.lang.@ref.Reference arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool._handleReference33112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, global::org.apache.http.impl.conn.tsccm.AbstractConnPool._handleReference33112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _handleLostEntry33113;
		protected abstract void handleLostEntry(org.apache.http.conn.routing.HttpRoute arg0);
		internal static global::MonoJavaBridge.MethodId _deleteClosedConnections33114;
		public abstract void deleteClosedConnections();
		internal static global::MonoJavaBridge.MethodId _closeConnection33115;
		protected virtual void closeConnection(org.apache.http.conn.OperatedClientConnection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool._closeConnection33115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, global::org.apache.http.impl.conn.tsccm.AbstractConnPool._closeConnection33115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AbstractConnPool33116;
		protected AbstractConnPool() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, global::org.apache.http.impl.conn.tsccm.AbstractConnPool._AbstractConnPool33116);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/tsccm/AbstractConnPool"));
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool._shutdown33105 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "shutdown", "()V");
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool._getEntry33106 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "getEntry", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;");
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool._freeEntry33107 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "freeEntry", "(Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;ZJLjava/util/concurrent/TimeUnit;)V");
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool._closeIdleConnections33108 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "closeIdleConnections", "(JLjava/util/concurrent/TimeUnit;)V");
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool._closeExpiredConnections33109 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "closeExpiredConnections", "()V");
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool._enableConnectionGC33110 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "enableConnectionGC", "()V");
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool._requestPoolEntry33111 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "requestPoolEntry", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;)Lorg/apache/http/impl/conn/tsccm/PoolEntryRequest;");
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool._handleReference33112 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "handleReference", "(Ljava/lang/ref/Reference;)V");
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool._handleLostEntry33113 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "handleLostEntry", "(Lorg/apache/http/conn/routing/HttpRoute;)V");
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool._deleteClosedConnections33114 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "deleteClosedConnections", "()V");
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool._closeConnection33115 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "closeConnection", "(Lorg/apache/http/conn/OperatedClientConnection;)V");
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool._AbstractConnPool33116 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.conn.tsccm.AbstractConnPool))]
	internal sealed partial class AbstractConnPool_ : org.apache.http.impl.conn.tsccm.AbstractConnPool
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractConnPool_()
		{
			InitJNI();
		}
		internal AbstractConnPool_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _freeEntry33117;
		public override void freeEntry(org.apache.http.impl.conn.tsccm.BasicPoolEntry arg0, bool arg1, long arg2, java.util.concurrent.TimeUnit arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool_._freeEntry33117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool_.staticClass, global::org.apache.http.impl.conn.tsccm.AbstractConnPool_._freeEntry33117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _requestPoolEntry33118;
		public override global::org.apache.http.impl.conn.tsccm.PoolEntryRequest requestPoolEntry(org.apache.http.conn.routing.HttpRoute arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.impl.conn.tsccm.PoolEntryRequest>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool_._requestPoolEntry33118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.impl.conn.tsccm.PoolEntryRequest;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.impl.conn.tsccm.PoolEntryRequest>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool_.staticClass, global::org.apache.http.impl.conn.tsccm.AbstractConnPool_._requestPoolEntry33118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.impl.conn.tsccm.PoolEntryRequest;
		}
		internal static global::MonoJavaBridge.MethodId _handleLostEntry33119;
		protected override void handleLostEntry(org.apache.http.conn.routing.HttpRoute arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool_._handleLostEntry33119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool_.staticClass, global::org.apache.http.impl.conn.tsccm.AbstractConnPool_._handleLostEntry33119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deleteClosedConnections33120;
		public override void deleteClosedConnections()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool_._deleteClosedConnections33120);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool_.staticClass, global::org.apache.http.impl.conn.tsccm.AbstractConnPool_._deleteClosedConnections33120);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/tsccm/AbstractConnPool"));
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool_._freeEntry33117 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.AbstractConnPool_.staticClass, "freeEntry", "(Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;ZJLjava/util/concurrent/TimeUnit;)V");
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool_._requestPoolEntry33118 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.AbstractConnPool_.staticClass, "requestPoolEntry", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;)Lorg/apache/http/impl/conn/tsccm/PoolEntryRequest;");
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool_._handleLostEntry33119 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.AbstractConnPool_.staticClass, "handleLostEntry", "(Lorg/apache/http/conn/routing/HttpRoute;)V");
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool_._deleteClosedConnections33120 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.AbstractConnPool_.staticClass, "deleteClosedConnections", "()V");
		}
	}
}
