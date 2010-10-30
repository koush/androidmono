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
		private static global::MonoJavaBridge.MethodId _m0;
		protected virtual global::org.apache.http.conn.OperatedClientConnection getConnection()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.conn.OperatedClientConnection>(this, global::org.apache.http.impl.conn.tsccm.BasicPoolEntry.staticClass, "getConnection", "()Lorg/apache/http/conn/OperatedClientConnection;", ref global::org.apache.http.impl.conn.tsccm.BasicPoolEntry._m0) as org.apache.http.conn.OperatedClientConnection;
		}
		protected new global::org.apache.http.conn.routing.HttpRoute PlannedRoute
		{
			get
			{
				return getPlannedRoute();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected virtual global::org.apache.http.conn.routing.HttpRoute getPlannedRoute()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.conn.routing.HttpRoute>(this, global::org.apache.http.impl.conn.tsccm.BasicPoolEntry.staticClass, "getPlannedRoute", "()Lorg/apache/http/conn/routing/HttpRoute;", ref global::org.apache.http.impl.conn.tsccm.BasicPoolEntry._m1) as org.apache.http.conn.routing.HttpRoute;
		}
		protected new global::org.apache.http.impl.conn.tsccm.BasicPoolEntryRef WeakRef
		{
			get
			{
				return getWeakRef();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected virtual global::org.apache.http.impl.conn.tsccm.BasicPoolEntryRef getWeakRef()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.tsccm.BasicPoolEntry.staticClass, "getWeakRef", "()Lorg/apache/http/impl/conn/tsccm/BasicPoolEntryRef;", ref global::org.apache.http.impl.conn.tsccm.BasicPoolEntry._m2) as org.apache.http.impl.conn.tsccm.BasicPoolEntryRef;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public BasicPoolEntry(org.apache.http.conn.ClientConnectionOperator arg0, org.apache.http.conn.routing.HttpRoute arg1, java.lang.@ref.ReferenceQueue arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.conn.tsccm.BasicPoolEntry._m3.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.conn.tsccm.BasicPoolEntry._m3 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.BasicPoolEntry.staticClass, "<init>", "(Lorg/apache/http/conn/ClientConnectionOperator;Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/ref/ReferenceQueue;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.tsccm.BasicPoolEntry.staticClass, global::org.apache.http.impl.conn.tsccm.BasicPoolEntry._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
