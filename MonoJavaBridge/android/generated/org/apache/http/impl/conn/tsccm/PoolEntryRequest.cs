namespace org.apache.http.impl.conn.tsccm
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.impl.conn.tsccm.PoolEntryRequest_))]
	public partial interface PoolEntryRequest  : global::MonoJavaBridge.IJavaObject 
	{
		void abortRequest();
		global::org.apache.http.impl.conn.tsccm.BasicPoolEntry getPoolEntry(long arg0, java.util.concurrent.TimeUnit arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.conn.tsccm.PoolEntryRequest))]
	internal sealed partial class PoolEntryRequest_ : java.lang.Object, PoolEntryRequest
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal PoolEntryRequest_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _abortRequest33151;
		void org.apache.http.impl.conn.tsccm.PoolEntryRequest.abortRequest()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.PoolEntryRequest_.staticClass, "abortRequest", "()V", ref global::org.apache.http.impl.conn.tsccm.PoolEntryRequest_._abortRequest33151);
		}
		internal static global::MonoJavaBridge.MethodId _getPoolEntry33152;
		global::org.apache.http.impl.conn.tsccm.BasicPoolEntry org.apache.http.impl.conn.tsccm.PoolEntryRequest.getPoolEntry(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.tsccm.PoolEntryRequest_.staticClass, "getPoolEntry", "(JLjava/util/concurrent/TimeUnit;)Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;", ref global::org.apache.http.impl.conn.tsccm.PoolEntryRequest_._getPoolEntry33152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.impl.conn.tsccm.BasicPoolEntry;
		}
		static PoolEntryRequest_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.tsccm.PoolEntryRequest_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/tsccm/PoolEntryRequest"));
		}
		internal static void InitJNI()
		{
		}
	}
}
