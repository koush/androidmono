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
		internal static global::MonoJavaBridge.MethodId _shutdown26363;
		public virtual void shutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool._shutdown26363);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, global::org.apache.http.impl.conn.tsccm.AbstractConnPool._shutdown26363);
		}
		internal static global::MonoJavaBridge.MethodId _getEntry26364;
		public virtual global::org.apache.http.impl.conn.tsccm.BasicPoolEntry getEntry(org.apache.http.conn.routing.HttpRoute arg0, java.lang.Object arg1, long arg2, java.util.concurrent.TimeUnit arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool._getEntry26364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as org.apache.http.impl.conn.tsccm.BasicPoolEntry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, global::org.apache.http.impl.conn.tsccm.AbstractConnPool._getEntry26364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as org.apache.http.impl.conn.tsccm.BasicPoolEntry;
		}
		internal static global::MonoJavaBridge.MethodId _freeEntry26365;
		public abstract void freeEntry(org.apache.http.impl.conn.tsccm.BasicPoolEntry arg0, bool arg1, long arg2, java.util.concurrent.TimeUnit arg3);
		internal static global::MonoJavaBridge.MethodId _closeIdleConnections26366;
		public virtual void closeIdleConnections(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool._closeIdleConnections26366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, global::org.apache.http.impl.conn.tsccm.AbstractConnPool._closeIdleConnections26366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _closeExpiredConnections26367;
		public virtual void closeExpiredConnections() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool._closeExpiredConnections26367);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, global::org.apache.http.impl.conn.tsccm.AbstractConnPool._closeExpiredConnections26367);
		}
		internal static global::MonoJavaBridge.MethodId _enableConnectionGC26368;
		public virtual void enableConnectionGC() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool._enableConnectionGC26368);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, global::org.apache.http.impl.conn.tsccm.AbstractConnPool._enableConnectionGC26368);
		}
		internal static global::MonoJavaBridge.MethodId _requestPoolEntry26369;
		public abstract global::org.apache.http.impl.conn.tsccm.PoolEntryRequest requestPoolEntry(org.apache.http.conn.routing.HttpRoute arg0, java.lang.Object arg1);
		internal static global::MonoJavaBridge.MethodId _handleReference26370;
		public virtual void handleReference(java.lang.@ref.Reference arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool._handleReference26370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, global::org.apache.http.impl.conn.tsccm.AbstractConnPool._handleReference26370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _handleLostEntry26371;
		protected abstract void handleLostEntry(org.apache.http.conn.routing.HttpRoute arg0);
		internal static global::MonoJavaBridge.MethodId _deleteClosedConnections26372;
		public abstract void deleteClosedConnections();
		internal static global::MonoJavaBridge.MethodId _closeConnection26373;
		protected virtual void closeConnection(org.apache.http.conn.OperatedClientConnection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool._closeConnection26373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, global::org.apache.http.impl.conn.tsccm.AbstractConnPool._closeConnection26373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AbstractConnPool26374;
		protected AbstractConnPool()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, global::org.apache.http.impl.conn.tsccm.AbstractConnPool._AbstractConnPool26374);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/tsccm/AbstractConnPool"));
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool._shutdown26363 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "shutdown", "()V");
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool._getEntry26364 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "getEntry", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;");
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool._freeEntry26365 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "freeEntry", "(Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;ZJLjava/util/concurrent/TimeUnit;)V");
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool._closeIdleConnections26366 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "closeIdleConnections", "(JLjava/util/concurrent/TimeUnit;)V");
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool._closeExpiredConnections26367 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "closeExpiredConnections", "()V");
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool._enableConnectionGC26368 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "enableConnectionGC", "()V");
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool._requestPoolEntry26369 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "requestPoolEntry", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;)Lorg/apache/http/impl/conn/tsccm/PoolEntryRequest;");
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool._handleReference26370 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "handleReference", "(Ljava/lang/@ref/Reference;)V");
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool._handleLostEntry26371 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "handleLostEntry", "(Lorg/apache/http/conn/routing/HttpRoute;)V");
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool._deleteClosedConnections26372 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "deleteClosedConnections", "()V");
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool._closeConnection26373 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "closeConnection", "(Lorg/apache/http/conn/OperatedClientConnection;)V");
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool._AbstractConnPool26374 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.conn.tsccm.AbstractConnPool))]
	public sealed partial class AbstractConnPool_ : org.apache.http.impl.conn.tsccm.AbstractConnPool
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractConnPool_()
		{
			InitJNI();
		}
		internal AbstractConnPool_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _freeEntry26375;
		public override void freeEntry(org.apache.http.impl.conn.tsccm.BasicPoolEntry arg0, bool arg1, long arg2, java.util.concurrent.TimeUnit arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool_._freeEntry26375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool_.staticClass, global::org.apache.http.impl.conn.tsccm.AbstractConnPool_._freeEntry26375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _requestPoolEntry26376;
		public override global::org.apache.http.impl.conn.tsccm.PoolEntryRequest requestPoolEntry(org.apache.http.conn.routing.HttpRoute arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.impl.conn.tsccm.PoolEntryRequest>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool_._requestPoolEntry26376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.impl.conn.tsccm.PoolEntryRequest;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.impl.conn.tsccm.PoolEntryRequest>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool_.staticClass, global::org.apache.http.impl.conn.tsccm.AbstractConnPool_._requestPoolEntry26376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.impl.conn.tsccm.PoolEntryRequest;
		}
		internal static global::MonoJavaBridge.MethodId _handleLostEntry26377;
		protected override void handleLostEntry(org.apache.http.conn.routing.HttpRoute arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool_._handleLostEntry26377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool_.staticClass, global::org.apache.http.impl.conn.tsccm.AbstractConnPool_._handleLostEntry26377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deleteClosedConnections26378;
		public override void deleteClosedConnections() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool_._deleteClosedConnections26378);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.AbstractConnPool_.staticClass, global::org.apache.http.impl.conn.tsccm.AbstractConnPool_._deleteClosedConnections26378);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/tsccm/AbstractConnPool"));
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool_._freeEntry26375 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.AbstractConnPool_.staticClass, "freeEntry", "(Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;ZJLjava/util/concurrent/TimeUnit;)V");
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool_._requestPoolEntry26376 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.AbstractConnPool_.staticClass, "requestPoolEntry", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;)Lorg/apache/http/impl/conn/tsccm/PoolEntryRequest;");
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool_._handleLostEntry26377 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.AbstractConnPool_.staticClass, "handleLostEntry", "(Lorg/apache/http/conn/routing/HttpRoute;)V");
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool_._deleteClosedConnections26378 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.AbstractConnPool_.staticClass, "deleteClosedConnections", "()V");
		}
	}
}
