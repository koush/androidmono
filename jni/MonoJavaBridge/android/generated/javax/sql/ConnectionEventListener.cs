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
		static ConnectionEventListener_()
		{
			InitJNI();
		}
		internal ConnectionEventListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _connectionClosed30279;
		 void javax.sql.ConnectionEventListener.connectionClosed(javax.sql.ConnectionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.ConnectionEventListener_._connectionClosed30279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.ConnectionEventListener_.staticClass, global::javax.sql.ConnectionEventListener_._connectionClosed30279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _connectionErrorOccurred30280;
		 void javax.sql.ConnectionEventListener.connectionErrorOccurred(javax.sql.ConnectionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.ConnectionEventListener_._connectionErrorOccurred30280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.ConnectionEventListener_.staticClass, global::javax.sql.ConnectionEventListener_._connectionErrorOccurred30280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.sql.ConnectionEventListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/sql/ConnectionEventListener"));
			global::javax.sql.ConnectionEventListener_._connectionClosed30279 = @__env.GetMethodIDNoThrow(global::javax.sql.ConnectionEventListener_.staticClass, "connectionClosed", "(Ljavax/sql/ConnectionEvent;)V");
			global::javax.sql.ConnectionEventListener_._connectionErrorOccurred30280 = @__env.GetMethodIDNoThrow(global::javax.sql.ConnectionEventListener_.staticClass, "connectionErrorOccurred", "(Ljavax/sql/ConnectionEvent;)V");
		}
	}
}
