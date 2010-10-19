namespace org.apache.http.impl.conn.tsccm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConnPoolByRoute : org.apache.http.impl.conn.tsccm.AbstractConnPool
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ConnPoolByRoute()
		{
			InitJNI();
		}
		protected ConnPoolByRoute(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _shutdown26389;
		public override void shutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._shutdown26389);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._shutdown26389);
		}
		internal static global::MonoJavaBridge.MethodId _createEntry26390;
		protected virtual global::org.apache.http.impl.conn.tsccm.BasicPoolEntry createEntry(org.apache.http.impl.conn.tsccm.RouteSpecificPool arg0, org.apache.http.conn.ClientConnectionOperator arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._createEntry26390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.impl.conn.tsccm.BasicPoolEntry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._createEntry26390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.impl.conn.tsccm.BasicPoolEntry;
		}
		internal static global::MonoJavaBridge.MethodId _freeEntry26391;
		public override void freeEntry(org.apache.http.impl.conn.tsccm.BasicPoolEntry arg0, bool arg1, long arg2, java.util.concurrent.TimeUnit arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._freeEntry26391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._freeEntry26391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _deleteEntry26392;
		protected virtual void deleteEntry(org.apache.http.impl.conn.tsccm.BasicPoolEntry arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._deleteEntry26392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._deleteEntry26392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestPoolEntry26393;
		public override global::org.apache.http.impl.conn.tsccm.PoolEntryRequest requestPoolEntry(org.apache.http.conn.routing.HttpRoute arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.impl.conn.tsccm.PoolEntryRequest>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._requestPoolEntry26393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.impl.conn.tsccm.PoolEntryRequest;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.impl.conn.tsccm.PoolEntryRequest>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._requestPoolEntry26393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.impl.conn.tsccm.PoolEntryRequest;
		}
		internal static global::MonoJavaBridge.MethodId _handleLostEntry26394;
		protected override void handleLostEntry(org.apache.http.conn.routing.HttpRoute arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._handleLostEntry26394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._handleLostEntry26394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deleteClosedConnections26395;
		public override void deleteClosedConnections() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._deleteClosedConnections26395);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._deleteClosedConnections26395);
		}
		internal static global::MonoJavaBridge.MethodId _getConnectionsInPool26396;
		public virtual int getConnectionsInPool(org.apache.http.conn.routing.HttpRoute arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._getConnectionsInPool26396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._getConnectionsInPool26396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createFreeConnQueue26397;
		protected virtual global::java.util.Queue createFreeConnQueue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Queue>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._createFreeConnQueue26397)) as java.util.Queue;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Queue>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._createFreeConnQueue26397)) as java.util.Queue;
		}
		internal static global::MonoJavaBridge.MethodId _createWaitingThreadQueue26398;
		protected virtual global::java.util.Queue createWaitingThreadQueue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Queue>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._createWaitingThreadQueue26398)) as java.util.Queue;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Queue>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._createWaitingThreadQueue26398)) as java.util.Queue;
		}
		internal static global::MonoJavaBridge.MethodId _createRouteToPoolMap26399;
		protected virtual global::java.util.Map createRouteToPoolMap() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._createRouteToPoolMap26399)) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._createRouteToPoolMap26399)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _newRouteSpecificPool26400;
		protected virtual global::org.apache.http.impl.conn.tsccm.RouteSpecificPool newRouteSpecificPool(org.apache.http.conn.routing.HttpRoute arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._newRouteSpecificPool26400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.impl.conn.tsccm.RouteSpecificPool;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._newRouteSpecificPool26400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.impl.conn.tsccm.RouteSpecificPool;
		}
		internal static global::MonoJavaBridge.MethodId _newWaitingThread26401;
		protected virtual global::org.apache.http.impl.conn.tsccm.WaitingThread newWaitingThread(java.util.concurrent.locks.Condition arg0, org.apache.http.impl.conn.tsccm.RouteSpecificPool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._newWaitingThread26401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.impl.conn.tsccm.WaitingThread;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._newWaitingThread26401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.impl.conn.tsccm.WaitingThread;
		}
		internal static global::MonoJavaBridge.MethodId _getRoutePool26402;
		protected virtual global::org.apache.http.impl.conn.tsccm.RouteSpecificPool getRoutePool(org.apache.http.conn.routing.HttpRoute arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._getRoutePool26402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.impl.conn.tsccm.RouteSpecificPool;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._getRoutePool26402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.impl.conn.tsccm.RouteSpecificPool;
		}
		internal static global::MonoJavaBridge.MethodId _getEntryBlocking26403;
		protected virtual global::org.apache.http.impl.conn.tsccm.BasicPoolEntry getEntryBlocking(org.apache.http.conn.routing.HttpRoute arg0, java.lang.Object arg1, long arg2, java.util.concurrent.TimeUnit arg3, org.apache.http.impl.conn.tsccm.WaitingThreadAborter arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._getEntryBlocking26403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as org.apache.http.impl.conn.tsccm.BasicPoolEntry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._getEntryBlocking26403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as org.apache.http.impl.conn.tsccm.BasicPoolEntry;
		}
		internal static global::MonoJavaBridge.MethodId _getFreeEntry26404;
		protected virtual global::org.apache.http.impl.conn.tsccm.BasicPoolEntry getFreeEntry(org.apache.http.impl.conn.tsccm.RouteSpecificPool arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._getFreeEntry26404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.impl.conn.tsccm.BasicPoolEntry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._getFreeEntry26404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.impl.conn.tsccm.BasicPoolEntry;
		}
		internal static global::MonoJavaBridge.MethodId _deleteLeastUsedEntry26405;
		protected virtual void deleteLeastUsedEntry() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._deleteLeastUsedEntry26405);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._deleteLeastUsedEntry26405);
		}
		internal static global::MonoJavaBridge.MethodId _notifyWaitingThread26406;
		protected virtual void notifyWaitingThread(org.apache.http.impl.conn.tsccm.RouteSpecificPool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._notifyWaitingThread26406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._notifyWaitingThread26406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ConnPoolByRoute26407;
		public ConnPoolByRoute(org.apache.http.conn.ClientConnectionOperator arg0, org.apache.http.@params.HttpParams arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._ConnPoolByRoute26407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/tsccm/ConnPoolByRoute"));
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._shutdown26389 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "shutdown", "()V");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._createEntry26390 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "createEntry", "(Lorg/apache/http/impl/conn/tsccm/RouteSpecificPool;Lorg/apache/http/conn/ClientConnectionOperator;)Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._freeEntry26391 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "freeEntry", "(Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;ZJLjava/util/concurrent/TimeUnit;)V");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._deleteEntry26392 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "deleteEntry", "(Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;)V");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._requestPoolEntry26393 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "requestPoolEntry", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;)Lorg/apache/http/impl/conn/tsccm/PoolEntryRequest;");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._handleLostEntry26394 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "handleLostEntry", "(Lorg/apache/http/conn/routing/HttpRoute;)V");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._deleteClosedConnections26395 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "deleteClosedConnections", "()V");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._getConnectionsInPool26396 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "getConnectionsInPool", "(Lorg/apache/http/conn/routing/HttpRoute;)I");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._createFreeConnQueue26397 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "createFreeConnQueue", "()Ljava/util/Queue;");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._createWaitingThreadQueue26398 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "createWaitingThreadQueue", "()Ljava/util/Queue;");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._createRouteToPoolMap26399 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "createRouteToPoolMap", "()Ljava/util/Map;");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._newRouteSpecificPool26400 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "newRouteSpecificPool", "(Lorg/apache/http/conn/routing/HttpRoute;)Lorg/apache/http/impl/conn/tsccm/RouteSpecificPool;");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._newWaitingThread26401 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "newWaitingThread", "(Ljava/util/concurrent/locks/Condition;Lorg/apache/http/impl/conn/tsccm/RouteSpecificPool;)Lorg/apache/http/impl/conn/tsccm/WaitingThread;");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._getRoutePool26402 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "getRoutePool", "(Lorg/apache/http/conn/routing/HttpRoute;Z)Lorg/apache/http/impl/conn/tsccm/RouteSpecificPool;");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._getEntryBlocking26403 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "getEntryBlocking", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;Lorg/apache/http/impl/conn/tsccm/WaitingThreadAborter;)Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._getFreeEntry26404 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "getFreeEntry", "(Lorg/apache/http/impl/conn/tsccm/RouteSpecificPool;Ljava/lang/Object;)Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._deleteLeastUsedEntry26405 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "deleteLeastUsedEntry", "()V");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._notifyWaitingThread26406 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "notifyWaitingThread", "(Lorg/apache/http/impl/conn/tsccm/RouteSpecificPool;)V");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._ConnPoolByRoute26407 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "<init>", "(Lorg/apache/http/conn/ClientConnectionOperator;Lorg/apache/http/@params/HttpParams;)V");
		}
	}
}
