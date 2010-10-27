namespace org.apache.http.conn
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicEofSensorWatcher : java.lang.Object, EofSensorWatcher
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BasicEofSensorWatcher()
		{
			InitJNI();
		}
		protected BasicEofSensorWatcher(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _eofDetected32060;
		public virtual bool eofDetected(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.BasicEofSensorWatcher._eofDetected32060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.BasicEofSensorWatcher.staticClass, global::org.apache.http.conn.BasicEofSensorWatcher._eofDetected32060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _streamClosed32061;
		public virtual bool streamClosed(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.BasicEofSensorWatcher._streamClosed32061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.BasicEofSensorWatcher.staticClass, global::org.apache.http.conn.BasicEofSensorWatcher._streamClosed32061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _streamAbort32062;
		public virtual bool streamAbort(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.BasicEofSensorWatcher._streamAbort32062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.BasicEofSensorWatcher.staticClass, global::org.apache.http.conn.BasicEofSensorWatcher._streamAbort32062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _BasicEofSensorWatcher32063;
		public BasicEofSensorWatcher(org.apache.http.conn.ManagedClientConnection arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.BasicEofSensorWatcher.staticClass, global::org.apache.http.conn.BasicEofSensorWatcher._BasicEofSensorWatcher32063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.BasicEofSensorWatcher.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/BasicEofSensorWatcher"));
			global::org.apache.http.conn.BasicEofSensorWatcher._eofDetected32060 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.BasicEofSensorWatcher.staticClass, "eofDetected", "(Ljava/io/InputStream;)Z");
			global::org.apache.http.conn.BasicEofSensorWatcher._streamClosed32061 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.BasicEofSensorWatcher.staticClass, "streamClosed", "(Ljava/io/InputStream;)Z");
			global::org.apache.http.conn.BasicEofSensorWatcher._streamAbort32062 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.BasicEofSensorWatcher.staticClass, "streamAbort", "(Ljava/io/InputStream;)Z");
			global::org.apache.http.conn.BasicEofSensorWatcher._BasicEofSensorWatcher32063 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.BasicEofSensorWatcher.staticClass, "<init>", "(Lorg/apache/http/conn/ManagedClientConnection;Z)V");
		}
	}
}
