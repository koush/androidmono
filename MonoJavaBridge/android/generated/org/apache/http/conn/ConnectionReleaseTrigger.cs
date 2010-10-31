namespace org.apache.http.conn
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.conn.ConnectionReleaseTrigger_))]
	public partial interface ConnectionReleaseTrigger  : global::MonoJavaBridge.IJavaObject 
	{
		void releaseConnection();
		void abortConnection();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.conn.ConnectionReleaseTrigger))]
	internal sealed partial class ConnectionReleaseTrigger_ : java.lang.Object, ConnectionReleaseTrigger
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ConnectionReleaseTrigger_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void org.apache.http.conn.ConnectionReleaseTrigger.releaseConnection()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ConnectionReleaseTrigger_.staticClass, "releaseConnection", "()V", ref global::org.apache.http.conn.ConnectionReleaseTrigger_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void org.apache.http.conn.ConnectionReleaseTrigger.abortConnection()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ConnectionReleaseTrigger_.staticClass, "abortConnection", "()V", ref global::org.apache.http.conn.ConnectionReleaseTrigger_._m1);
		}
		static ConnectionReleaseTrigger_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.ConnectionReleaseTrigger_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/ConnectionReleaseTrigger"));
		}
	}
}
