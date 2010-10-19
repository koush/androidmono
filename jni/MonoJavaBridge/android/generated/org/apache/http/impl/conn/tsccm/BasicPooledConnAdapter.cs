namespace org.apache.http.impl.conn.tsccm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicPooledConnAdapter : org.apache.http.impl.conn.AbstractPooledConnAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BasicPooledConnAdapter()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getManager26385;
		protected override global::org.apache.http.conn.ClientConnectionManager getManager() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionManager>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter._getManager26385)) as org.apache.http.conn.ClientConnectionManager;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionManager>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter.staticClass, global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter._getManager26385)) as org.apache.http.conn.ClientConnectionManager;
		}
		internal static global::MonoJavaBridge.MethodId _detach26386;
		protected override void detach() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter._detach26386);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter.staticClass, global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter._detach26386);
		}
		protected new global::org.apache.http.impl.conn.AbstractPoolEntry PoolEntry
		{
			get
			{
				return getPoolEntry();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPoolEntry26387;
		protected virtual global::org.apache.http.impl.conn.AbstractPoolEntry getPoolEntry() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter._getPoolEntry26387)) as org.apache.http.impl.conn.AbstractPoolEntry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter.staticClass, global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter._getPoolEntry26387)) as org.apache.http.impl.conn.AbstractPoolEntry;
		}
		internal static global::MonoJavaBridge.MethodId _BasicPooledConnAdapter26388;
		protected BasicPooledConnAdapter(org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager arg0, org.apache.http.impl.conn.AbstractPoolEntry arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter.staticClass, global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter._BasicPooledConnAdapter26388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/tsccm/BasicPooledConnAdapter"));
			global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter._getManager26385 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter.staticClass, "getManager", "()Lorg/apache/http/conn/ClientConnectionManager;");
			global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter._detach26386 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter.staticClass, "detach", "()V");
			global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter._getPoolEntry26387 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter.staticClass, "getPoolEntry", "()Lorg/apache/http/impl/conn/AbstractPoolEntry;");
			global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter._BasicPooledConnAdapter26388 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.BasicPooledConnAdapter.staticClass, "<init>", "(Lorg/apache/http/impl/conn/tsccm/ThreadSafeClientConnManager;Lorg/apache/http/impl/conn/AbstractPoolEntry;)V");
		}
	}
}
