namespace org.apache.http.impl.conn.tsccm
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.impl.conn.tsccm.AbstractConnPool_))]
	public abstract partial class AbstractConnPool : java.lang.Object, RefQueueHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractConnPool(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void shutdown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "shutdown", "()V", ref global::org.apache.http.impl.conn.tsccm.AbstractConnPool._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::org.apache.http.impl.conn.tsccm.BasicPoolEntry getEntry(org.apache.http.conn.routing.HttpRoute arg0, java.lang.Object arg1, long arg2, java.util.concurrent.TimeUnit arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "getEntry", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;", ref global::org.apache.http.impl.conn.tsccm.AbstractConnPool._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as org.apache.http.impl.conn.tsccm.BasicPoolEntry;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract void freeEntry(org.apache.http.impl.conn.tsccm.BasicPoolEntry arg0, bool arg1, long arg2, java.util.concurrent.TimeUnit arg3);
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void closeIdleConnections(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "closeIdleConnections", "(JLjava/util/concurrent/TimeUnit;)V", ref global::org.apache.http.impl.conn.tsccm.AbstractConnPool._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void closeExpiredConnections()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "closeExpiredConnections", "()V", ref global::org.apache.http.impl.conn.tsccm.AbstractConnPool._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void enableConnectionGC()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "enableConnectionGC", "()V", ref global::org.apache.http.impl.conn.tsccm.AbstractConnPool._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract global::org.apache.http.impl.conn.tsccm.PoolEntryRequest requestPoolEntry(org.apache.http.conn.routing.HttpRoute arg0, java.lang.Object arg1);
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void handleReference(java.lang.@ref.Reference arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "handleReference", "(Ljava/lang/ref/Reference;)V", ref global::org.apache.http.impl.conn.tsccm.AbstractConnPool._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected abstract void handleLostEntry(org.apache.http.conn.routing.HttpRoute arg0);
		private static global::MonoJavaBridge.MethodId _m9;
		public abstract void deleteClosedConnections();
		private static global::MonoJavaBridge.MethodId _m10;
		protected virtual void closeConnection(org.apache.http.conn.OperatedClientConnection arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "closeConnection", "(Lorg/apache/http/conn/OperatedClientConnection;)V", ref global::org.apache.http.impl.conn.tsccm.AbstractConnPool._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		protected AbstractConnPool() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.conn.tsccm.AbstractConnPool._m11.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.conn.tsccm.AbstractConnPool._m11 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass, global::org.apache.http.impl.conn.tsccm.AbstractConnPool._m11);
			Init(@__env, handle);
		}
		static AbstractConnPool()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/tsccm/AbstractConnPool"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.conn.tsccm.AbstractConnPool))]
	internal sealed partial class AbstractConnPool_ : org.apache.http.impl.conn.tsccm.AbstractConnPool
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractConnPool_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void freeEntry(org.apache.http.impl.conn.tsccm.BasicPoolEntry arg0, bool arg1, long arg2, java.util.concurrent.TimeUnit arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.AbstractConnPool_.staticClass, "freeEntry", "(Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;ZJLjava/util/concurrent/TimeUnit;)V", ref global::org.apache.http.impl.conn.tsccm.AbstractConnPool_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::org.apache.http.impl.conn.tsccm.PoolEntryRequest requestPoolEntry(org.apache.http.conn.routing.HttpRoute arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.impl.conn.tsccm.PoolEntryRequest>(this, global::org.apache.http.impl.conn.tsccm.AbstractConnPool_.staticClass, "requestPoolEntry", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;)Lorg/apache/http/impl/conn/tsccm/PoolEntryRequest;", ref global::org.apache.http.impl.conn.tsccm.AbstractConnPool_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.impl.conn.tsccm.PoolEntryRequest;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override void handleLostEntry(org.apache.http.conn.routing.HttpRoute arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.AbstractConnPool_.staticClass, "handleLostEntry", "(Lorg/apache/http/conn/routing/HttpRoute;)V", ref global::org.apache.http.impl.conn.tsccm.AbstractConnPool_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void deleteClosedConnections()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.AbstractConnPool_.staticClass, "deleteClosedConnections", "()V", ref global::org.apache.http.impl.conn.tsccm.AbstractConnPool_._m3);
		}
		static AbstractConnPool_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.tsccm.AbstractConnPool_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/tsccm/AbstractConnPool"));
		}
	}
}
