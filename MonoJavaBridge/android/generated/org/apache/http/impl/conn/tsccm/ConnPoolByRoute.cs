namespace org.apache.http.impl.conn.tsccm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConnPoolByRoute : org.apache.http.impl.conn.tsccm.AbstractConnPool
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ConnPoolByRoute(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _shutdown33132;
		public override void shutdown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._shutdown33132);
		}
		internal static global::MonoJavaBridge.MethodId _createEntry33133;
		protected virtual global::org.apache.http.impl.conn.tsccm.BasicPoolEntry createEntry(org.apache.http.impl.conn.tsccm.RouteSpecificPool arg0, org.apache.http.conn.ClientConnectionOperator arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._createEntry33133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.impl.conn.tsccm.BasicPoolEntry;
		}
		internal static global::MonoJavaBridge.MethodId _freeEntry33134;
		public override void freeEntry(org.apache.http.impl.conn.tsccm.BasicPoolEntry arg0, bool arg1, long arg2, java.util.concurrent.TimeUnit arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._freeEntry33134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _deleteEntry33135;
		protected virtual void deleteEntry(org.apache.http.impl.conn.tsccm.BasicPoolEntry arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._deleteEntry33135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestPoolEntry33136;
		public override global::org.apache.http.impl.conn.tsccm.PoolEntryRequest requestPoolEntry(org.apache.http.conn.routing.HttpRoute arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.impl.conn.tsccm.PoolEntryRequest>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._requestPoolEntry33136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.impl.conn.tsccm.PoolEntryRequest;
		}
		internal static global::MonoJavaBridge.MethodId _handleLostEntry33137;
		protected override void handleLostEntry(org.apache.http.conn.routing.HttpRoute arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._handleLostEntry33137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deleteClosedConnections33138;
		public override void deleteClosedConnections()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._deleteClosedConnections33138);
		}
		internal static global::MonoJavaBridge.MethodId _getConnectionsInPool33139;
		public virtual int getConnectionsInPool(org.apache.http.conn.routing.HttpRoute arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._getConnectionsInPool33139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createFreeConnQueue33140;
		protected virtual global::java.util.Queue createFreeConnQueue()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Queue>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._createFreeConnQueue33140)) as java.util.Queue;
		}
		internal static global::MonoJavaBridge.MethodId _createWaitingThreadQueue33141;
		protected virtual global::java.util.Queue createWaitingThreadQueue()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Queue>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._createWaitingThreadQueue33141)) as java.util.Queue;
		}
		internal static global::MonoJavaBridge.MethodId _createRouteToPoolMap33142;
		protected virtual global::java.util.Map createRouteToPoolMap()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._createRouteToPoolMap33142)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _newRouteSpecificPool33143;
		protected virtual global::org.apache.http.impl.conn.tsccm.RouteSpecificPool newRouteSpecificPool(org.apache.http.conn.routing.HttpRoute arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._newRouteSpecificPool33143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.impl.conn.tsccm.RouteSpecificPool;
		}
		internal static global::MonoJavaBridge.MethodId _newWaitingThread33144;
		protected virtual global::org.apache.http.impl.conn.tsccm.WaitingThread newWaitingThread(java.util.concurrent.locks.Condition arg0, org.apache.http.impl.conn.tsccm.RouteSpecificPool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._newWaitingThread33144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.impl.conn.tsccm.WaitingThread;
		}
		internal static global::MonoJavaBridge.MethodId _getRoutePool33145;
		protected virtual global::org.apache.http.impl.conn.tsccm.RouteSpecificPool getRoutePool(org.apache.http.conn.routing.HttpRoute arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._getRoutePool33145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.impl.conn.tsccm.RouteSpecificPool;
		}
		internal static global::MonoJavaBridge.MethodId _getEntryBlocking33146;
		protected virtual global::org.apache.http.impl.conn.tsccm.BasicPoolEntry getEntryBlocking(org.apache.http.conn.routing.HttpRoute arg0, java.lang.Object arg1, long arg2, java.util.concurrent.TimeUnit arg3, org.apache.http.impl.conn.tsccm.WaitingThreadAborter arg4)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._getEntryBlocking33146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as org.apache.http.impl.conn.tsccm.BasicPoolEntry;
		}
		internal static global::MonoJavaBridge.MethodId _getFreeEntry33147;
		protected virtual global::org.apache.http.impl.conn.tsccm.BasicPoolEntry getFreeEntry(org.apache.http.impl.conn.tsccm.RouteSpecificPool arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._getFreeEntry33147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.impl.conn.tsccm.BasicPoolEntry;
		}
		internal static global::MonoJavaBridge.MethodId _deleteLeastUsedEntry33148;
		protected virtual void deleteLeastUsedEntry()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._deleteLeastUsedEntry33148);
		}
		internal static global::MonoJavaBridge.MethodId _notifyWaitingThread33149;
		protected virtual void notifyWaitingThread(org.apache.http.impl.conn.tsccm.RouteSpecificPool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._notifyWaitingThread33149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ConnPoolByRoute33150;
		public ConnPoolByRoute(org.apache.http.conn.ClientConnectionOperator arg0, org.apache.http.@params.HttpParams arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._ConnPoolByRoute33150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ConnPoolByRoute()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/tsccm/ConnPoolByRoute"));
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._shutdown33132 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "shutdown", "()V");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._createEntry33133 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "createEntry", "(Lorg/apache/http/impl/conn/tsccm/RouteSpecificPool;Lorg/apache/http/conn/ClientConnectionOperator;)Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._freeEntry33134 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "freeEntry", "(Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;ZJLjava/util/concurrent/TimeUnit;)V");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._deleteEntry33135 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "deleteEntry", "(Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;)V");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._requestPoolEntry33136 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "requestPoolEntry", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;)Lorg/apache/http/impl/conn/tsccm/PoolEntryRequest;");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._handleLostEntry33137 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "handleLostEntry", "(Lorg/apache/http/conn/routing/HttpRoute;)V");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._deleteClosedConnections33138 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "deleteClosedConnections", "()V");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._getConnectionsInPool33139 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "getConnectionsInPool", "(Lorg/apache/http/conn/routing/HttpRoute;)I");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._createFreeConnQueue33140 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "createFreeConnQueue", "()Ljava/util/Queue;");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._createWaitingThreadQueue33141 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "createWaitingThreadQueue", "()Ljava/util/Queue;");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._createRouteToPoolMap33142 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "createRouteToPoolMap", "()Ljava/util/Map;");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._newRouteSpecificPool33143 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "newRouteSpecificPool", "(Lorg/apache/http/conn/routing/HttpRoute;)Lorg/apache/http/impl/conn/tsccm/RouteSpecificPool;");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._newWaitingThread33144 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "newWaitingThread", "(Ljava/util/concurrent/locks/Condition;Lorg/apache/http/impl/conn/tsccm/RouteSpecificPool;)Lorg/apache/http/impl/conn/tsccm/WaitingThread;");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._getRoutePool33145 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "getRoutePool", "(Lorg/apache/http/conn/routing/HttpRoute;Z)Lorg/apache/http/impl/conn/tsccm/RouteSpecificPool;");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._getEntryBlocking33146 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "getEntryBlocking", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;Lorg/apache/http/impl/conn/tsccm/WaitingThreadAborter;)Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._getFreeEntry33147 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "getFreeEntry", "(Lorg/apache/http/impl/conn/tsccm/RouteSpecificPool;Ljava/lang/Object;)Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._deleteLeastUsedEntry33148 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "deleteLeastUsedEntry", "()V");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._notifyWaitingThread33149 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "notifyWaitingThread", "(Lorg/apache/http/impl/conn/tsccm/RouteSpecificPool;)V");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._ConnPoolByRoute33150 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "<init>", "(Lorg/apache/http/conn/ClientConnectionOperator;Lorg/apache/http/params/HttpParams;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
