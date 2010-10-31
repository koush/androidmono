namespace org.apache.http.impl.conn.tsccm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicPooledConnAdapter : org.apache.http.impl.conn.AbstractPooledConnAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicPooledConnAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		protected new global::org.apache.http.conn.ClientConnectionManager Manager
		{
			get
			{
				return getManager();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override global::org.apache.http.conn.ClientConnectionManager getManager()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.conn.ClientConnectionManager>(this, global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter.staticClass, "getManager", "()Lorg/apache/http/conn/ClientConnectionManager;", ref global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter._m0) as org.apache.http.conn.ClientConnectionManager;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void detach()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter.staticClass, "detach", "()V", ref global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter._m1);
		}
		protected new global::org.apache.http.impl.conn.AbstractPoolEntry PoolEntry
		{
			get
			{
				return getPoolEntry();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected virtual global::org.apache.http.impl.conn.AbstractPoolEntry getPoolEntry()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter.staticClass, "getPoolEntry", "()Lorg/apache/http/impl/conn/AbstractPoolEntry;", ref global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter._m2) as org.apache.http.impl.conn.AbstractPoolEntry;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected BasicPooledConnAdapter(org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager arg0, org.apache.http.impl.conn.AbstractPoolEntry arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter._m3.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter._m3 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter.staticClass, "<init>", "(Lorg/apache/http/impl/conn/tsccm/ThreadSafeClientConnManager;Lorg/apache/http/impl/conn/AbstractPoolEntry;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter.staticClass, global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static BasicPooledConnAdapter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/tsccm/BasicPooledConnAdapter"));
		}
	}
}
