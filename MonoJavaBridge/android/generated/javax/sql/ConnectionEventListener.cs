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
		internal static global::MonoJavaBridge.MethodId _connectionClosed30280;
		void javax.sql.ConnectionEventListener.connectionClosed(javax.sql.ConnectionEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.sql.ConnectionEventListener_._connectionClosed30280.native == global::System.IntPtr.Zero)
				global::javax.sql.ConnectionEventListener_._connectionClosed30280 = @__env.GetMethodIDNoThrow(global::javax.sql.ConnectionEventListener_.staticClass, "connectionClosed", "(Ljavax/sql/ConnectionEvent;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.ConnectionEventListener_._connectionClosed30280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _connectionErrorOccurred30281;
		void javax.sql.ConnectionEventListener.connectionErrorOccurred(javax.sql.ConnectionEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.sql.ConnectionEventListener_._connectionErrorOccurred30281.native == global::System.IntPtr.Zero)
				global::javax.sql.ConnectionEventListener_._connectionErrorOccurred30281 = @__env.GetMethodIDNoThrow(global::javax.sql.ConnectionEventListener_.staticClass, "connectionErrorOccurred", "(Ljavax/sql/ConnectionEvent;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.ConnectionEventListener_._connectionErrorOccurred30281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
