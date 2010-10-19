namespace javax.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.sql.PooledConnection_))]
	public interface PooledConnection  : global::MonoJavaBridge.IJavaObject 
	{
		void close();
		global::java.sql.Connection getConnection();
		void addConnectionEventListener(javax.sql.ConnectionEventListener arg0);
		void removeConnectionEventListener(javax.sql.ConnectionEventListener arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.sql.PooledConnection))]
	public sealed partial class PooledConnection_ : java.lang.Object, PooledConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PooledConnection_()
		{
			InitJNI();
		}
		internal PooledConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close23733;
		 void javax.sql.PooledConnection.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.PooledConnection_._close23733);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.PooledConnection_.staticClass, global::javax.sql.PooledConnection_._close23733);
		}
		internal static global::MonoJavaBridge.MethodId _getConnection23734;
		 global::java.sql.Connection javax.sql.PooledConnection.getConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.PooledConnection_._getConnection23734)) as java.sql.Connection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.PooledConnection_.staticClass, global::javax.sql.PooledConnection_._getConnection23734)) as java.sql.Connection;
		}
		internal static global::MonoJavaBridge.MethodId _addConnectionEventListener23735;
		 void javax.sql.PooledConnection.addConnectionEventListener(javax.sql.ConnectionEventListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.PooledConnection_._addConnectionEventListener23735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.PooledConnection_.staticClass, global::javax.sql.PooledConnection_._addConnectionEventListener23735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeConnectionEventListener23736;
		 void javax.sql.PooledConnection.removeConnectionEventListener(javax.sql.ConnectionEventListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.PooledConnection_._removeConnectionEventListener23736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.PooledConnection_.staticClass, global::javax.sql.PooledConnection_._removeConnectionEventListener23736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.sql.PooledConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/sql/PooledConnection"));
			global::javax.sql.PooledConnection_._close23733 = @__env.GetMethodIDNoThrow(global::javax.sql.PooledConnection_.staticClass, "close", "()V");
			global::javax.sql.PooledConnection_._getConnection23734 = @__env.GetMethodIDNoThrow(global::javax.sql.PooledConnection_.staticClass, "getConnection", "()Ljava/sql/Connection;");
			global::javax.sql.PooledConnection_._addConnectionEventListener23735 = @__env.GetMethodIDNoThrow(global::javax.sql.PooledConnection_.staticClass, "addConnectionEventListener", "(Ljavax/sql/ConnectionEventListener;)V");
			global::javax.sql.PooledConnection_._removeConnectionEventListener23736 = @__env.GetMethodIDNoThrow(global::javax.sql.PooledConnection_.staticClass, "removeConnectionEventListener", "(Ljavax/sql/ConnectionEventListener;)V");
		}
	}
}
