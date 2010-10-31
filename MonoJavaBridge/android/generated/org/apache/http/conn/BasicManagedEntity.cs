namespace org.apache.http.conn
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicManagedEntity : org.apache.http.entity.HttpEntityWrapper, ConnectionReleaseTrigger, EofSensorWatcher
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicManagedEntity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.io.InputStream Content
		{
			get
			{
				return getContent();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.io.InputStream getContent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.conn.BasicManagedEntity.staticClass, "getContent", "()Ljava/io/InputStream;", ref global::org.apache.http.conn.BasicManagedEntity._m0) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void writeTo(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.BasicManagedEntity.staticClass, "writeTo", "(Ljava/io/OutputStream;)V", ref global::org.apache.http.conn.BasicManagedEntity._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool isRepeatable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.BasicManagedEntity.staticClass, "isRepeatable", "()Z", ref global::org.apache.http.conn.BasicManagedEntity._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void releaseConnection()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.BasicManagedEntity.staticClass, "releaseConnection", "()V", ref global::org.apache.http.conn.BasicManagedEntity._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void consumeContent()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.BasicManagedEntity.staticClass, "consumeContent", "()V", ref global::org.apache.http.conn.BasicManagedEntity._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void abortConnection()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.BasicManagedEntity.staticClass, "abortConnection", "()V", ref global::org.apache.http.conn.BasicManagedEntity._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual bool eofDetected(java.io.InputStream arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.BasicManagedEntity.staticClass, "eofDetected", "(Ljava/io/InputStream;)Z", ref global::org.apache.http.conn.BasicManagedEntity._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool streamClosed(java.io.InputStream arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.BasicManagedEntity.staticClass, "streamClosed", "(Ljava/io/InputStream;)Z", ref global::org.apache.http.conn.BasicManagedEntity._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual bool streamAbort(java.io.InputStream arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.BasicManagedEntity.staticClass, "streamAbort", "(Ljava/io/InputStream;)Z", ref global::org.apache.http.conn.BasicManagedEntity._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected virtual void releaseManagedConnection()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.BasicManagedEntity.staticClass, "releaseManagedConnection", "()V", ref global::org.apache.http.conn.BasicManagedEntity._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public BasicManagedEntity(org.apache.http.HttpEntity arg0, org.apache.http.conn.ManagedClientConnection arg1, bool arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.BasicManagedEntity._m10.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.BasicManagedEntity._m10 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.BasicManagedEntity.staticClass, "<init>", "(Lorg/apache/http/HttpEntity;Lorg/apache/http/conn/ManagedClientConnection;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.BasicManagedEntity.staticClass, global::org.apache.http.conn.BasicManagedEntity._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static BasicManagedEntity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.BasicManagedEntity.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/BasicManagedEntity"));
		}
	}
}
