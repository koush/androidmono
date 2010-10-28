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
		static ConnectionReleaseTrigger_()
		{
			InitJNI();
		}
		internal ConnectionReleaseTrigger_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _releaseConnection32093;
		void org.apache.http.conn.ConnectionReleaseTrigger.releaseConnection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ConnectionReleaseTrigger_._releaseConnection32093);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ConnectionReleaseTrigger_.staticClass, global::org.apache.http.conn.ConnectionReleaseTrigger_._releaseConnection32093);
		}
		internal static global::MonoJavaBridge.MethodId _abortConnection32094;
		void org.apache.http.conn.ConnectionReleaseTrigger.abortConnection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ConnectionReleaseTrigger_._abortConnection32094);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ConnectionReleaseTrigger_.staticClass, global::org.apache.http.conn.ConnectionReleaseTrigger_._abortConnection32094);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.ConnectionReleaseTrigger_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/ConnectionReleaseTrigger"));
			global::org.apache.http.conn.ConnectionReleaseTrigger_._releaseConnection32093 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ConnectionReleaseTrigger_.staticClass, "releaseConnection", "()V");
			global::org.apache.http.conn.ConnectionReleaseTrigger_._abortConnection32094 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ConnectionReleaseTrigger_.staticClass, "abortConnection", "()V");
		}
	}
}
