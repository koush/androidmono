namespace org.apache.http.impl.conn.tsccm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConnPoolByRoute : org.apache.http.impl.conn.tsccm.AbstractConnPool
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ConnPoolByRoute(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void shutdown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "shutdown", "()V", ref global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected virtual global::org.apache.http.impl.conn.tsccm.BasicPoolEntry createEntry(org.apache.http.impl.conn.tsccm.RouteSpecificPool arg0, org.apache.http.conn.ClientConnectionOperator arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "createEntry", "(Lorg/apache/http/impl/conn/tsccm/RouteSpecificPool;Lorg/apache/http/conn/ClientConnectionOperator;)Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;", ref global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.impl.conn.tsccm.BasicPoolEntry;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void freeEntry(org.apache.http.impl.conn.tsccm.BasicPoolEntry arg0, bool arg1, long arg2, java.util.concurrent.TimeUnit arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "freeEntry", "(Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;ZJLjava/util/concurrent/TimeUnit;)V", ref global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected virtual void deleteEntry(org.apache.http.impl.conn.tsccm.BasicPoolEntry arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "deleteEntry", "(Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;)V", ref global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::org.apache.http.impl.conn.tsccm.PoolEntryRequest requestPoolEntry(org.apache.http.conn.routing.HttpRoute arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.impl.conn.tsccm.PoolEntryRequest>(this, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "requestPoolEntry", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;)Lorg/apache/http/impl/conn/tsccm/PoolEntryRequest;", ref global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.impl.conn.tsccm.PoolEntryRequest;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override void handleLostEntry(org.apache.http.conn.routing.HttpRoute arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "handleLostEntry", "(Lorg/apache/http/conn/routing/HttpRoute;)V", ref global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override void deleteClosedConnections()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "deleteClosedConnections", "()V", ref global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual int getConnectionsInPool(org.apache.http.conn.routing.HttpRoute arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "getConnectionsInPool", "(Lorg/apache/http/conn/routing/HttpRoute;)I", ref global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected virtual global::java.util.Queue createFreeConnQueue()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Queue>(this, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "createFreeConnQueue", "()Ljava/util/Queue;", ref global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._m8) as java.util.Queue;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected virtual global::java.util.Queue createWaitingThreadQueue()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Queue>(this, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "createWaitingThreadQueue", "()Ljava/util/Queue;", ref global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._m9) as java.util.Queue;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected virtual global::java.util.Map createRouteToPoolMap()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map>(this, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "createRouteToPoolMap", "()Ljava/util/Map;", ref global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._m10) as java.util.Map;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		protected virtual global::org.apache.http.impl.conn.tsccm.RouteSpecificPool newRouteSpecificPool(org.apache.http.conn.routing.HttpRoute arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "newRouteSpecificPool", "(Lorg/apache/http/conn/routing/HttpRoute;)Lorg/apache/http/impl/conn/tsccm/RouteSpecificPool;", ref global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.impl.conn.tsccm.RouteSpecificPool;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		protected virtual global::org.apache.http.impl.conn.tsccm.WaitingThread newWaitingThread(java.util.concurrent.locks.Condition arg0, org.apache.http.impl.conn.tsccm.RouteSpecificPool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "newWaitingThread", "(Ljava/util/concurrent/locks/Condition;Lorg/apache/http/impl/conn/tsccm/RouteSpecificPool;)Lorg/apache/http/impl/conn/tsccm/WaitingThread;", ref global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.impl.conn.tsccm.WaitingThread;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		protected virtual global::org.apache.http.impl.conn.tsccm.RouteSpecificPool getRoutePool(org.apache.http.conn.routing.HttpRoute arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "getRoutePool", "(Lorg/apache/http/conn/routing/HttpRoute;Z)Lorg/apache/http/impl/conn/tsccm/RouteSpecificPool;", ref global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.impl.conn.tsccm.RouteSpecificPool;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		protected virtual global::org.apache.http.impl.conn.tsccm.BasicPoolEntry getEntryBlocking(org.apache.http.conn.routing.HttpRoute arg0, java.lang.Object arg1, long arg2, java.util.concurrent.TimeUnit arg3, org.apache.http.impl.conn.tsccm.WaitingThreadAborter arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "getEntryBlocking", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;Lorg/apache/http/impl/conn/tsccm/WaitingThreadAborter;)Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;", ref global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4)) as org.apache.http.impl.conn.tsccm.BasicPoolEntry;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		protected virtual global::org.apache.http.impl.conn.tsccm.BasicPoolEntry getFreeEntry(org.apache.http.impl.conn.tsccm.RouteSpecificPool arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "getFreeEntry", "(Lorg/apache/http/impl/conn/tsccm/RouteSpecificPool;Ljava/lang/Object;)Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;", ref global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.impl.conn.tsccm.BasicPoolEntry;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		protected virtual void deleteLeastUsedEntry()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "deleteLeastUsedEntry", "()V", ref global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		protected virtual void notifyWaitingThread(org.apache.http.impl.conn.tsccm.RouteSpecificPool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "notifyWaitingThread", "(Lorg/apache/http/impl/conn/tsccm/RouteSpecificPool;)V", ref global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public ConnPoolByRoute(org.apache.http.conn.ClientConnectionOperator arg0, org.apache.http.@params.HttpParams arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._m18.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._m18 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "<init>", "(Lorg/apache/http/conn/ClientConnectionOperator;Lorg/apache/http/params/HttpParams;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ConnPoolByRoute()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/tsccm/ConnPoolByRoute"));
		}
		internal static void InitJNI()
		{
		}
	}
}
