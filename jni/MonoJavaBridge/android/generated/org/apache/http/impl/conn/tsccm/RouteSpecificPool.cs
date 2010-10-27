namespace org.apache.http.impl.conn.tsccm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RouteSpecificPool : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RouteSpecificPool()
		{
			InitJNI();
		}
		protected RouteSpecificPool(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _freeEntry33157;
		public virtual void freeEntry(org.apache.http.impl.conn.tsccm.BasicPoolEntry arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._freeEntry33157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._freeEntry33157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deleteEntry33158;
		public virtual bool deleteEntry(org.apache.http.impl.conn.tsccm.BasicPoolEntry arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._deleteEntry33158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._deleteEntry33158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.conn.routing.HttpRoute Route
		{
			get
			{
				return getRoute();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRoute33159;
		public virtual global::org.apache.http.conn.routing.HttpRoute getRoute()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.HttpRoute>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._getRoute33159)) as org.apache.http.conn.routing.HttpRoute;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.HttpRoute>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._getRoute33159)) as org.apache.http.conn.routing.HttpRoute;
		}
		public new int MaxEntries
		{
			get
			{
				return getMaxEntries();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaxEntries33160;
		public virtual int getMaxEntries()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._getMaxEntries33160);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._getMaxEntries33160);
		}
		internal static global::MonoJavaBridge.MethodId _isUnused33161;
		public virtual bool isUnused()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._isUnused33161);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._isUnused33161);
		}
		public new int Capacity
		{
			get
			{
				return getCapacity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCapacity33162;
		public virtual int getCapacity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._getCapacity33162);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._getCapacity33162);
		}
		public new int EntryCount
		{
			get
			{
				return getEntryCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEntryCount33163;
		public virtual int getEntryCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._getEntryCount33163);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._getEntryCount33163);
		}
		internal static global::MonoJavaBridge.MethodId _allocEntry33164;
		public virtual global::org.apache.http.impl.conn.tsccm.BasicPoolEntry allocEntry(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._allocEntry33164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.impl.conn.tsccm.BasicPoolEntry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._allocEntry33164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.impl.conn.tsccm.BasicPoolEntry;
		}
		internal static global::MonoJavaBridge.MethodId _createdEntry33165;
		public virtual void createdEntry(org.apache.http.impl.conn.tsccm.BasicPoolEntry arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._createdEntry33165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._createdEntry33165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dropEntry33166;
		public virtual void dropEntry()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._dropEntry33166);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._dropEntry33166);
		}
		internal static global::MonoJavaBridge.MethodId _queueThread33167;
		public virtual void queueThread(org.apache.http.impl.conn.tsccm.WaitingThread arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._queueThread33167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._queueThread33167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasThread33168;
		public virtual bool hasThread()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._hasThread33168);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._hasThread33168);
		}
		internal static global::MonoJavaBridge.MethodId _nextThread33169;
		public virtual global::org.apache.http.impl.conn.tsccm.WaitingThread nextThread()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._nextThread33169)) as org.apache.http.impl.conn.tsccm.WaitingThread;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._nextThread33169)) as org.apache.http.impl.conn.tsccm.WaitingThread;
		}
		internal static global::MonoJavaBridge.MethodId _removeThread33170;
		public virtual void removeThread(org.apache.http.impl.conn.tsccm.WaitingThread arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._removeThread33170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._removeThread33170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _RouteSpecificPool33171;
		public RouteSpecificPool(org.apache.http.conn.routing.HttpRoute arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._RouteSpecificPool33171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/tsccm/RouteSpecificPool"));
			global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._freeEntry33157 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, "freeEntry", "(Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;)V");
			global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._deleteEntry33158 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, "deleteEntry", "(Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;)Z");
			global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._getRoute33159 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, "getRoute", "()Lorg/apache/http/conn/routing/HttpRoute;");
			global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._getMaxEntries33160 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, "getMaxEntries", "()I");
			global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._isUnused33161 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, "isUnused", "()Z");
			global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._getCapacity33162 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, "getCapacity", "()I");
			global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._getEntryCount33163 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, "getEntryCount", "()I");
			global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._allocEntry33164 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, "allocEntry", "(Ljava/lang/Object;)Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;");
			global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._createdEntry33165 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, "createdEntry", "(Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;)V");
			global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._dropEntry33166 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, "dropEntry", "()V");
			global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._queueThread33167 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, "queueThread", "(Lorg/apache/http/impl/conn/tsccm/WaitingThread;)V");
			global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._hasThread33168 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, "hasThread", "()Z");
			global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._nextThread33169 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, "nextThread", "()Lorg/apache/http/impl/conn/tsccm/WaitingThread;");
			global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._removeThread33170 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, "removeThread", "(Lorg/apache/http/impl/conn/tsccm/WaitingThread;)V");
			global::org.apache.http.impl.conn.tsccm.RouteSpecificPool._RouteSpecificPool33171 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.RouteSpecificPool.staticClass, "<init>", "(Lorg/apache/http/conn/routing/HttpRoute;I)V");
		}
	}
}
