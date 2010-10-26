namespace org.apache.http.impl.conn
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IdleConnectionHandler : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static IdleConnectionHandler()
		{
			InitJNI();
		}
		protected IdleConnectionHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add33047;
		public virtual void add(org.apache.http.HttpConnection arg0, long arg1, java.util.concurrent.TimeUnit arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.IdleConnectionHandler._add33047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.IdleConnectionHandler.staticClass, global::org.apache.http.impl.conn.IdleConnectionHandler._add33047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _remove33048;
		public virtual bool remove(org.apache.http.HttpConnection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.IdleConnectionHandler._remove33048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.IdleConnectionHandler.staticClass, global::org.apache.http.impl.conn.IdleConnectionHandler._remove33048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll33049;
		public virtual void removeAll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.IdleConnectionHandler._removeAll33049);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.IdleConnectionHandler.staticClass, global::org.apache.http.impl.conn.IdleConnectionHandler._removeAll33049);
		}
		internal static global::MonoJavaBridge.MethodId _closeIdleConnections33050;
		public virtual void closeIdleConnections(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.IdleConnectionHandler._closeIdleConnections33050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.IdleConnectionHandler.staticClass, global::org.apache.http.impl.conn.IdleConnectionHandler._closeIdleConnections33050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _closeExpiredConnections33051;
		public virtual void closeExpiredConnections() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.IdleConnectionHandler._closeExpiredConnections33051);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.IdleConnectionHandler.staticClass, global::org.apache.http.impl.conn.IdleConnectionHandler._closeExpiredConnections33051);
		}
		internal static global::MonoJavaBridge.MethodId _IdleConnectionHandler33052;
		public IdleConnectionHandler()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.IdleConnectionHandler.staticClass, global::org.apache.http.impl.conn.IdleConnectionHandler._IdleConnectionHandler33052);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.IdleConnectionHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/IdleConnectionHandler"));
			global::org.apache.http.impl.conn.IdleConnectionHandler._add33047 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.IdleConnectionHandler.staticClass, "add", "(Lorg/apache/http/HttpConnection;JLjava/util/concurrent/TimeUnit;)V");
			global::org.apache.http.impl.conn.IdleConnectionHandler._remove33048 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.IdleConnectionHandler.staticClass, "remove", "(Lorg/apache/http/HttpConnection;)Z");
			global::org.apache.http.impl.conn.IdleConnectionHandler._removeAll33049 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.IdleConnectionHandler.staticClass, "removeAll", "()V");
			global::org.apache.http.impl.conn.IdleConnectionHandler._closeIdleConnections33050 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.IdleConnectionHandler.staticClass, "closeIdleConnections", "(J)V");
			global::org.apache.http.impl.conn.IdleConnectionHandler._closeExpiredConnections33051 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.IdleConnectionHandler.staticClass, "closeExpiredConnections", "()V");
			global::org.apache.http.impl.conn.IdleConnectionHandler._IdleConnectionHandler33052 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.IdleConnectionHandler.staticClass, "<init>", "()V");
		}
	}
}
