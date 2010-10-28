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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.PoolEntryRequest_._abortRequest33151);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.PoolEntryRequest_.staticClass, global::org.apache.http.impl.conn.tsccm.PoolEntryRequest_._abortRequest33151);
		}
		internal static global::MonoJavaBridge.MethodId _getPoolEntry33152;
		global::org.apache.http.impl.conn.tsccm.BasicPoolEntry org.apache.http.impl.conn.tsccm.PoolEntryRequest.getPoolEntry(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.PoolEntryRequest_._getPoolEntry33152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.impl.conn.tsccm.BasicPoolEntry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.PoolEntryRequest_.staticClass, global::org.apache.http.impl.conn.tsccm.PoolEntryRequest_._getPoolEntry33152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.impl.conn.tsccm.BasicPoolEntry;
		}
		static PoolEntryRequest_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.tsccm.PoolEntryRequest_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/tsccm/PoolEntryRequest"));
			global::org.apache.http.impl.conn.tsccm.PoolEntryRequest_._abortRequest33151 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.PoolEntryRequest_.staticClass, "abortRequest", "()V");
			global::org.apache.http.impl.conn.tsccm.PoolEntryRequest_._getPoolEntry33152 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.PoolEntryRequest_.staticClass, "getPoolEntry", "(JLjava/util/concurrent/TimeUnit;)Lorg/apache/http/impl/conn/tsccm/BasicPoolEntry;");
		}
		internal static void InitJNI()
		{
		}
	}
}
