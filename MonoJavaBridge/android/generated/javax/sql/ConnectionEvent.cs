namespace javax.sql
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConnectionEvent : java.util.EventObject
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.sql.SQLException getSQLException()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.sql.ConnectionEvent.staticClass, "getSQLException", "()Ljava/sql/SQLException;", ref global::javax.sql.ConnectionEvent._m0) as java.sql.SQLException;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public ConnectionEvent(javax.sql.PooledConnection arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.sql.ConnectionEvent._m1.native == global::System.IntPtr.Zero)
				global::javax.sql.ConnectionEvent._m1 = @__env.GetMethodIDNoThrow(global::javax.sql.ConnectionEvent.staticClass, "<init>", "(Ljavax/sql/PooledConnection;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.sql.ConnectionEvent.staticClass, global::javax.sql.ConnectionEvent._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public ConnectionEvent(javax.sql.PooledConnection arg0, java.sql.SQLException arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.sql.ConnectionEvent._m2.native == global::System.IntPtr.Zero)
				global::javax.sql.ConnectionEvent._m2 = @__env.GetMethodIDNoThrow(global::javax.sql.ConnectionEvent.staticClass, "<init>", "(Ljavax/sql/PooledConnection;Ljava/sql/SQLException;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.sql.ConnectionEvent.staticClass, global::javax.sql.ConnectionEvent._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ConnectionEvent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.sql.ConnectionEvent.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/sql/ConnectionEvent"));
		}
		internal static void InitJNI()
		{
		}
	}
}
