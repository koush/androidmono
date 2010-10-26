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
		internal static global::MonoJavaBridge.MethodId _shutdown33131;
		public override void shutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._shutdown33131);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._shutdown33131);
		}
		internal static global::MonoJavaBridge.MethodId _createEntry33132;
		protected virtual global::org.apache.http.impl.conn.tsccm.BasicPoolEntry createEntry(org.apache.http.impl.conn.tsccm.RouteSpecificPool arg0, org.apache.http.conn.ClientConnectionOperator arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._createEntry33132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.impl.conn.tsccm.BasicPoolEntry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._createEntry33132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.impl.conn.tsccm.BasicPoolEntry;
		}
		internal static global::MonoJavaBridge.MethodId _freeEntry33133;
		public override void freeEntry(org.apache.http.impl.conn.tsccm.BasicPoolEntry arg0, bool arg1, long arg2, java.util.concurrent.TimeUnit arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._freeEntry33133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._freeEntry33133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _deleteEntry33134;
		protected virtual void deleteEntry(org.apache.http.impl.conn.tsccm.BasicPoolEntry arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._deleteEntry33134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._deleteEntry33134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestPoolEntry33135;
		public override global::org.apache.http.impl.conn.tsccm.PoolEntryRequest requestPoolEntry(org.apache.http.conn.routing.HttpRoute arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.impl.conn.tsccm.PoolEntryRequest>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._requestPoolEntry33135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.impl.conn.tsccm.PoolEntryRequest;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.impl.conn.tsccm.PoolEntryRequest>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._requestPoolEntry33135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.impl.conn.tsccm.PoolEntryRequest;
		}
		internal static global::MonoJavaBridge.MethodId _handleLostEntry33136;
		protected override void handleLostEntry(org.apache.http.conn.routing.HttpRoute arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._handleLostEntry33136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._handleLostEntry33136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deleteClosedConnections33137;
		public override void deleteClosedConnections() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._deleteClosedConnections33137);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._deleteClosedConnections33137);
		}
		internal static global::MonoJavaBridge.MethodId _getConnectionsInPool33138;
		public virtual int getConnectionsInPool(org.apache.http.conn.routing.HttpRoute arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._getConnectionsInPool33138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._getConnectionsInPool33138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createFreeConnQueue33139;
		protected virtual global::java.util.Queue createFreeConnQueue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Queue>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._createFreeConnQueue33139)) as java.util.Queue;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Queue>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._createFreeConnQueue33139)) as java.util.Queue;
		}
		internal static global::MonoJavaBridge.MethodId _createWaitingThreadQueue33140;
		protected virtual global::java.util.Queue createWaitingThreadQueue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Queue>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._createWaitingThreadQueue33140)) as java.util.Queue;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Queue>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._createWaitingThreadQueue33140)) as java.util.Queue;
		}
		internal static global::MonoJavaBridge.MethodId _createRouteToPoolMap33141;
		protected virtual global::java.util.Map createRouteToPoolMap() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._createRouteToPoolMap33141)) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._createRouteToPoolMap33141)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _newRouteSpecificPool33142;
		protected virtual global::org.apache.http.impl.conn.tsccm.RouteSpecificPool newRouteSpecificPool(org.apache.http.conn.routing.HttpRoute arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._newRouteSpecificPool33142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.impl.conn.tsccm.RouteSpecificPool;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._newRouteSpecificPool33142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.impl.conn.tsccm.RouteSpecificPool;
		}
		internal static global::MonoJavaBridge.MethodId _newWaitingThread33143;
		protected virtual global::org.apache.http.impl.conn.tsccm.WaitingThread newWaitingThread(java.util.concurrent.locks.Condition arg0, org.apache.http.impl.conn.tsccm.RouteSpecificPool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._newWaitingThread33143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.impl.conn.tsccm.WaitingThread;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._newWaitingThread33143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.impl.conn.tsccm.WaitingThread;
		}
		internal static global::MonoJavaBridge.MethodId _getRoutePool33144;
		protected virtual global::org.apache.http.impl.conn.tsccm.RouteSpecificPool getRoutePool(org.apache.http.conn.routing.HttpRoute arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._getRoutePool33144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.impl.conn.tsccm.RouteSpecificPool;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._getRoutePool33144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.impl.conn.tsccm.RouteSpecificPool;
		}
		internal static global::MonoJavaBridge.MethodId _getEntryBlocking33145;
		protected virtual global::org.apache.http.impl.conn.tsccm.BasicPoolEntry getEntryBlocking(org.apache.http.conn.routing.HttpRoute arg0, java.lang.Object arg1, long arg2, java.util.concurrent.TimeUnit arg3, org.apache.http.impl.conn.tsccm.WaitingThreadAborter arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._getEntryBlocking33145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as org.apache.http.impl.conn.tsccm.BasicPoolEntry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._getEntryBlocking33145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as org.apache.http.impl.conn.tsccm.BasicPoolEntry;
		}
		internal static global::MonoJavaBridge.MethodId _getFreeEntry33146;
		protected virtual global::org.apache.http.impl.conn.tsccm.BasicPoolEntry getFreeEntry(org.apache.http.impl.conn.tsccm.RouteSpecificPool arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._getFreeEntry33146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.impl.conn.tsccm.BasicPoolEntry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._getFreeEntry33146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.impl.conn.tsccm.BasicPoolEntry;
		}
		internal static global::MonoJavaBridge.MethodId _deleteLeastUsedEntry33147;
		protected virtual void deleteLeastUsedEntry() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._deleteLeastUsedEntry33147);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._deleteLeastUsedEntry33147);
		}
		internal static global::MonoJavaBridge.MethodId _notifyWaitingThread33148;
		protected virtual void notifyWaitingThread(org.apache.http.impl.conn.tsccm.RouteSpecificPool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._notifyWaitingThread33148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._notifyWaitingThread33148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ConnPoolByRoute33149;
		public ConnPoolByRoute(org.apache.http.conn.ClientConnectionOperator arg0, org.apache.http.@params.HttpParams arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._ConnPoolByRoute33149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/tsccm/ConnPoolByRoute"));
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._shutdown33131 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "shutdown", "()V");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._createEntry33132 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "createEntry", "(Lorg/apache/http/impl/conn/tsccm/RouteSpecificPool;Lorg/apache/http/conn/ClientConnectionOperator;)Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._freeEntry33133 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "freeEntry", "(Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;ZJLjava/util/concurrent/TimeUnit;)V");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._deleteEntry33134 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "deleteEntry", "(Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;)V");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._requestPoolEntry33135 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "requestPoolEntry", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;)Lorg/apache/http/impl/conn/tsccm/PoolEntryRequest;");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._handleLostEntry33136 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "handleLostEntry", "(Lorg/apache/http/conn/routing/HttpRoute;)V");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._deleteClosedConnections33137 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "deleteClosedConnections", "()V");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._getConnectionsInPool33138 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "getConnectionsInPool", "(Lorg/apache/http/conn/routing/HttpRoute;)I");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._createFreeConnQueue33139 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "createFreeConnQueue", "()Ljava/util/Queue;");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._createWaitingThreadQueue33140 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "createWaitingThreadQueue", "()Ljava/util/Queue;");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._createRouteToPoolMap33141 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "createRouteToPoolMap", "()Ljava/util/Map;");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._newRouteSpecificPool33142 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "newRouteSpecificPool", "(Lorg/apache/http/conn/routing/HttpRoute;)Lorg/apache/http/impl/conn/tsccm/RouteSpecificPool;");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._newWaitingThread33143 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "newWaitingThread", "(Ljava/util/concurrent/locks/Condition;Lorg/apache/http/impl/conn/tsccm/RouteSpecificPool;)Lorg/apache/http/impl/conn/tsccm/WaitingThread;");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._getRoutePool33144 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "getRoutePool", "(Lorg/apache/http/conn/routing/HttpRoute;Z)Lorg/apache/http/impl/conn/tsccm/RouteSpecificPool;");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._getEntryBlocking33145 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "getEntryBlocking", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;Lorg/apache/http/impl/conn/tsccm/WaitingThreadAborter;)Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._getFreeEntry33146 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "getFreeEntry", "(Lorg/apache/http/impl/conn/tsccm/RouteSpecificPool;Ljava/lang/Object;)Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._deleteLeastUsedEntry33147 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "deleteLeastUsedEntry", "()V");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._notifyWaitingThread33148 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "notifyWaitingThread", "(Lorg/apache/http/impl/conn/tsccm/RouteSpecificPool;)V");
			global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute._ConnPoolByRoute33149 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ConnPoolByRoute.staticClass, "<init>", "(Lorg/apache/http/conn/ClientConnectionOperator;Lorg/apache/http/params/HttpParams;)V");
		}
	}
}
