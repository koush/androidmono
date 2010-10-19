namespace javax.sql
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConnectionEvent : java.util.EventObject
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ConnectionEvent()
		{
			InitJNI();
		}
		protected ConnectionEvent(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.sql.SQLException SQLException
		{
			get
			{
				return getSQLException();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSQLException23724;
		public virtual global::java.sql.SQLException getSQLException() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.ConnectionEvent._getSQLException23724)) as java.sql.SQLException;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.ConnectionEvent.staticClass, global::javax.sql.ConnectionEvent._getSQLException23724)) as java.sql.SQLException;
		}
		internal static global::MonoJavaBridge.MethodId _ConnectionEvent23725;
		public ConnectionEvent(javax.sql.PooledConnection arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.sql.ConnectionEvent.staticClass, global::javax.sql.ConnectionEvent._ConnectionEvent23725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ConnectionEvent23726;
		public ConnectionEvent(javax.sql.PooledConnection arg0, java.sql.SQLException arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.sql.ConnectionEvent.staticClass, global::javax.sql.ConnectionEvent._ConnectionEvent23726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.sql.ConnectionEvent.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/sql/ConnectionEvent"));
			global::javax.sql.ConnectionEvent._getSQLException23724 = @__env.GetMethodIDNoThrow(global::javax.sql.ConnectionEvent.staticClass, "getSQLException", "()Ljava/sql/SQLException;");
			global::javax.sql.ConnectionEvent._ConnectionEvent23725 = @__env.GetMethodIDNoThrow(global::javax.sql.ConnectionEvent.staticClass, "<init>", "(Ljavax/sql/PooledConnection;)V");
			global::javax.sql.ConnectionEvent._ConnectionEvent23726 = @__env.GetMethodIDNoThrow(global::javax.sql.ConnectionEvent.staticClass, "<init>", "(Ljavax/sql/PooledConnection;Ljava/sql/SQLException;)V");
		}
	}
}
