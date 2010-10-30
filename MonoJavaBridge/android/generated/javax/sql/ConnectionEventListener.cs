namespace javax.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.sql.ConnectionEventListener_))]
	public partial interface ConnectionEventListener : java.util.EventListener
	{
		void connectionClosed(javax.sql.ConnectionEvent arg0);
		void connectionErrorOccurred(javax.sql.ConnectionEvent arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.sql.ConnectionEventListener))]
	internal sealed partial class ConnectionEventListener_ : java.lang.Object, ConnectionEventListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ConnectionEventListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void javax.sql.ConnectionEventListener.connectionClosed(javax.sql.ConnectionEvent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.ConnectionEventListener_.staticClass, "connectionClosed", "(Ljavax/sql/ConnectionEvent;)V", ref global::javax.sql.ConnectionEventListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void javax.sql.ConnectionEventListener.connectionErrorOccurred(javax.sql.ConnectionEvent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.ConnectionEventListener_.staticClass, "connectionErrorOccurred", "(Ljavax/sql/ConnectionEvent;)V", ref global::javax.sql.ConnectionEventListener_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static ConnectionEventListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.sql.ConnectionEventListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/sql/ConnectionEventListener"));
		}
		internal static void InitJNI()
		{
		}
	}
}
