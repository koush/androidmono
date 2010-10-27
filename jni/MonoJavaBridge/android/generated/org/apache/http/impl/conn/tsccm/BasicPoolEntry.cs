namespace org.apache.http.impl.conn.tsccm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicPoolEntry : org.apache.http.impl.conn.AbstractPoolEntry
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BasicPoolEntry()
		{
			InitJNI();
		}
		protected BasicPoolEntry(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		protected new global::org.apache.http.conn.OperatedClientConnection Connection
		{
			get
			{
				return getConnection();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConnection33121;
		protected virtual global::org.apache.http.conn.OperatedClientConnection getConnection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.OperatedClientConnection>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.BasicPoolEntry._getConnection33121)) as org.apache.http.conn.OperatedClientConnection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.OperatedClientConnection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.BasicPoolEntry.staticClass, global::org.apache.http.impl.conn.tsccm.BasicPoolEntry._getConnection33121)) as org.apache.http.conn.OperatedClientConnection;
		}
		protected new global::org.apache.http.conn.routing.HttpRoute PlannedRoute
		{
			get
			{
				return getPlannedRoute();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPlannedRoute33122;
		protected virtual global::org.apache.http.conn.routing.HttpRoute getPlannedRoute()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.HttpRoute>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.BasicPoolEntry._getPlannedRoute33122)) as org.apache.http.conn.routing.HttpRoute;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.HttpRoute>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.BasicPoolEntry.staticClass, global::org.apache.http.impl.conn.tsccm.BasicPoolEntry._getPlannedRoute33122)) as org.apache.http.conn.routing.HttpRoute;
		}
		protected new global::org.apache.http.impl.conn.tsccm.BasicPoolEntryRef WeakRef
		{
			get
			{
				return getWeakRef();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWeakRef33123;
		protected virtual global::org.apache.http.impl.conn.tsccm.BasicPoolEntryRef getWeakRef()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.BasicPoolEntry._getWeakRef33123)) as org.apache.http.impl.conn.tsccm.BasicPoolEntryRef;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.BasicPoolEntry.staticClass, global::org.apache.http.impl.conn.tsccm.BasicPoolEntry._getWeakRef33123)) as org.apache.http.impl.conn.tsccm.BasicPoolEntryRef;
		}
		internal static global::MonoJavaBridge.MethodId _BasicPoolEntry33124;
		public BasicPoolEntry(org.apache.http.conn.ClientConnectionOperator arg0, org.apache.http.conn.routing.HttpRoute arg1, java.lang.@ref.ReferenceQueue arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.tsccm.BasicPoolEntry.staticClass, global::org.apache.http.impl.conn.tsccm.BasicPoolEntry._BasicPoolEntry33124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.tsccm.BasicPoolEntry.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/tsccm/BasicPoolEntry"));
			global::org.apache.http.impl.conn.tsccm.BasicPoolEntry._getConnection33121 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.BasicPoolEntry.staticClass, "getConnection", "()Lorg/apache/http/conn/OperatedClientConnection;");
			global::org.apache.http.impl.conn.tsccm.BasicPoolEntry._getPlannedRoute33122 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.BasicPoolEntry.staticClass, "getPlannedRoute", "()Lorg/apache/http/conn/routing/HttpRoute;");
			global::org.apache.http.impl.conn.tsccm.BasicPoolEntry._getWeakRef33123 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.BasicPoolEntry.staticClass, "getWeakRef", "()Lorg/apache/http/impl/conn/tsccm/BasicPoolEntryRef;");
			global::org.apache.http.impl.conn.tsccm.BasicPoolEntry._BasicPoolEntry33124 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.BasicPoolEntry.staticClass, "<init>", "(Lorg/apache/http/conn/ClientConnectionOperator;Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/ref/ReferenceQueue;)V");
		}
	}
}
