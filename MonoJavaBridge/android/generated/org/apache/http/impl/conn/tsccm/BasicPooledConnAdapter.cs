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
		internal static global::MonoJavaBridge.MethodId _getManager33128;
		protected override global::org.apache.http.conn.ClientConnectionManager getManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter._getManager33128.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter._getManager33128 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter.staticClass, "getManager", "()Lorg/apache/http/conn/ClientConnectionManager;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.conn.ClientConnectionManager>(this, global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter.staticClass, global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter._getManager33128) as org.apache.http.conn.ClientConnectionManager;
		}
		internal static global::MonoJavaBridge.MethodId _detach33129;
		protected override void detach()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter._detach33129.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter._detach33129 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter.staticClass, "detach", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter.staticClass, global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter._detach33129);
		}
		protected new global::org.apache.http.impl.conn.AbstractPoolEntry PoolEntry
		{
			get
			{
				return getPoolEntry();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPoolEntry33130;
		protected virtual global::org.apache.http.impl.conn.AbstractPoolEntry getPoolEntry()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter._getPoolEntry33130.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter._getPoolEntry33130 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter.staticClass, "getPoolEntry", "()Lorg/apache/http/impl/conn/AbstractPoolEntry;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter.staticClass, global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter._getPoolEntry33130) as org.apache.http.impl.conn.AbstractPoolEntry;
		}
		internal static global::MonoJavaBridge.MethodId _BasicPooledConnAdapter33131;
		protected BasicPooledConnAdapter(org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager arg0, org.apache.http.impl.conn.AbstractPoolEntry arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter._BasicPooledConnAdapter33131.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter._BasicPooledConnAdapter33131 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter.staticClass, "<init>", "(Lorg/apache/http/impl/conn/tsccm/ThreadSafeClientConnManager;Lorg/apache/http/impl/conn/AbstractPoolEntry;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter.staticClass, global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter._BasicPooledConnAdapter33131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static BasicPooledConnAdapter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/tsccm/BasicPooledConnAdapter"));
		}
		internal static void InitJNI()
		{
		}
	}
}
