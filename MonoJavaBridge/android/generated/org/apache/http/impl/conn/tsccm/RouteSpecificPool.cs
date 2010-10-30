namespace org.apache.http.impl.conn.tsccm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RouteSpecificPool : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RouteSpecificPool(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _freeEntry33158;
		public virtual void freeEntry(org.apache.http.impl.conn.tsccm.BasicPoolEntry arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._freeEntry33158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deleteEntry33159;
		public virtual bool deleteEntry(org.apache.http.impl.conn.tsccm.BasicPoolEntry arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._deleteEntry33159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.conn.routing.HttpRoute Route
		{
			get
			{
				return getRoute();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRoute33160;
		public virtual global::org.apache.http.conn.routing.HttpRoute getRoute()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.HttpRoute>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._getRoute33160)) as org.apache.http.conn.routing.HttpRoute;
		}
		public new int MaxEntries
		{
			get
			{
				return getMaxEntries();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaxEntries33161;
		public virtual int getMaxEntries()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._getMaxEntries33161);
		}
		internal static global::MonoJavaBridge.MethodId _isUnused33162;
		public virtual bool isUnused()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._isUnused33162);
		}
		public new int Capacity
		{
			get
			{
				return getCapacity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCapacity33163;
		public virtual int getCapacity()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._getCapacity33163);
		}
		public new int EntryCount
		{
			get
			{
				return getEntryCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEntryCount33164;
		public virtual int getEntryCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._getEntryCount33164);
		}
		internal static global::MonoJavaBridge.MethodId _allocEntry33165;
		public virtual global::org.apache.http.impl.conn.tsccm.BasicPoolEntry allocEntry(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._allocEntry33165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.impl.conn.tsccm.BasicPoolEntry;
		}
		internal static global::MonoJavaBridge.MethodId _createdEntry33166;
		public virtual void createdEntry(org.apache.http.impl.conn.tsccm.BasicPoolEntry arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._createdEntry33166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dropEntry33167;
		public virtual void dropEntry()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._dropEntry33167);
		}
		internal static global::MonoJavaBridge.MethodId _queueThread33168;
		public virtual void queueThread(org.apache.http.impl.conn.tsccm.WaitingThread arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._queueThread33168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasThread33169;
		public virtual bool hasThread()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._hasThread33169);
		}
		internal static global::MonoJavaBridge.MethodId _nextThread33170;
		public virtual global::org.apache.http.impl.conn.tsccm.WaitingThread nextThread()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._nextThread33170)) as org.apache.http.impl.conn.tsccm.WaitingThread;
		}
		internal static global::MonoJavaBridge.MethodId _removeThread33171;
		public virtual void removeThread(org.apache.http.impl.conn.tsccm.WaitingThread arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._removeThread33171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _RouteSpecificPool33172;
		public RouteSpecificPool(org.apache.http.conn.routing.HttpRoute arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._RouteSpecificPool33172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static RouteSpecificPool()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/tsccm/RouteSpecificPool"));
			global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._freeEntry33158 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, "freeEntry", "(Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;)V");
			global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._deleteEntry33159 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, "deleteEntry", "(Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;)Z");
			global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._getRoute33160 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, "getRoute", "()Lorg/apache/http/conn/routing/HttpRoute;");
			global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._getMaxEntries33161 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, "getMaxEntries", "()I");
			global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._isUnused33162 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, "isUnused", "()Z");
			global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._getCapacity33163 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, "getCapacity", "()I");
			global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._getEntryCount33164 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, "getEntryCount", "()I");
			global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._allocEntry33165 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, "allocEntry", "(Ljava/lang/Object;)Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;");
			global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._createdEntry33166 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, "createdEntry", "(Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;)V");
			global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._dropEntry33167 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, "dropEntry", "()V");
			global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._queueThread33168 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, "queueThread", "(Lorg/apache/http/impl/conn/tsccm/WaitingThread;)V");
			global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._hasThread33169 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, "hasThread", "()Z");
			global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._nextThread33170 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, "nextThread", "()Lorg/apache/http/impl/conn/tsccm/WaitingThread;");
			global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._removeThread33171 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, "removeThread", "(Lorg/apache/http/impl/conn/tsccm/WaitingThread;)V");
			global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._RouteSpecificPool33172 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, "<init>", "(Lorg/apache/http/conn/routing/HttpRoute;I)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
