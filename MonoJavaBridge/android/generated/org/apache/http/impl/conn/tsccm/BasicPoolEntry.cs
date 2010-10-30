namespace org.apache.http.impl.conn.tsccm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicPoolEntry : org.apache.http.impl.conn.AbstractPoolEntry
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
		internal static global::MonoJavaBridge.MethodId _getConnection33122;
		protected virtual global::org.apache.http.conn.OperatedClientConnection getConnection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.conn.tsccm.BasicPoolEntry._getConnection33122.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.conn.tsccm.BasicPoolEntry._getConnection33122 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.BasicPoolEntry.staticClass, "getConnection", "()Lorg/apache/http/conn/OperatedClientConnection;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.conn.OperatedClientConnection>(this, global::org.apache.http.impl.conn.tsccm.BasicPoolEntry.staticClass, global::org.apache.http.impl.conn.tsccm.BasicPoolEntry._getConnection33122) as org.apache.http.conn.OperatedClientConnection;
		}
		protected new global::org.apache.http.conn.routing.HttpRoute PlannedRoute
		{
			get
			{
				return getPlannedRoute();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPlannedRoute33123;
		protected virtual global::org.apache.http.conn.routing.HttpRoute getPlannedRoute()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.conn.tsccm.BasicPoolEntry._getPlannedRoute33123.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.conn.tsccm.BasicPoolEntry._getPlannedRoute33123 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.BasicPoolEntry.staticClass, "getPlannedRoute", "()Lorg/apache/http/conn/routing/HttpRoute;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.conn.routing.HttpRoute>(this, global::org.apache.http.impl.conn.tsccm.BasicPoolEntry.staticClass, global::org.apache.http.impl.conn.tsccm.BasicPoolEntry._getPlannedRoute33123) as org.apache.http.conn.routing.HttpRoute;
		}
		protected new global::org.apache.http.impl.conn.tsccm.BasicPoolEntryRef WeakRef
		{
			get
			{
				return getWeakRef();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWeakRef33124;
		protected virtual global::org.apache.http.impl.conn.tsccm.BasicPoolEntryRef getWeakRef()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.conn.tsccm.BasicPoolEntry._getWeakRef33124.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.conn.tsccm.BasicPoolEntry._getWeakRef33124 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.BasicPoolEntry.staticClass, "getWeakRef", "()Lorg/apache/http/impl/conn/tsccm/BasicPoolEntryRef;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.tsccm.BasicPoolEntry.staticClass, global::org.apache.http.impl.conn.tsccm.BasicPoolEntry._getWeakRef33124) as org.apache.http.impl.conn.tsccm.BasicPoolEntryRef;
		}
		internal static global::MonoJavaBridge.MethodId _BasicPoolEntry33125;
		public BasicPoolEntry(org.apache.http.conn.ClientConnectionOperator arg0, org.apache.http.conn.routing.HttpRoute arg1, java.lang.@ref.ReferenceQueue arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.conn.tsccm.BasicPoolEntry._BasicPoolEntry33125.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.conn.tsccm.BasicPoolEntry._BasicPoolEntry33125 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.BasicPoolEntry.staticClass, "<init>", "(Lorg/apache/http/conn/ClientConnectionOperator;Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/ref/ReferenceQueue;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.tsccm.BasicPoolEntry.staticClass, global::org.apache.http.impl.conn.tsccm.BasicPoolEntry._BasicPoolEntry33125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static BasicPoolEntry()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.tsccm.BasicPoolEntry.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/tsccm/BasicPoolEntry"));
		}
		internal static void InitJNI()
		{
		}
	}
}
