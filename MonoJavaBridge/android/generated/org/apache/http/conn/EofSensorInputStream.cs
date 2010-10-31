namespace org.apache.http.conn
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EofSensorInputStream : java.io.InputStream, ConnectionReleaseTrigger
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EofSensorInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.EofSensorInputStream.staticClass, "close", "()V", ref global::org.apache.http.conn.EofSensorInputStream._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.EofSensorInputStream.staticClass, "read", "([BII)I", ref global::org.apache.http.conn.EofSensorInputStream._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int read(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.EofSensorInputStream.staticClass, "read", "([B)I", ref global::org.apache.http.conn.EofSensorInputStream._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.EofSensorInputStream.staticClass, "read", "()I", ref global::org.apache.http.conn.EofSensorInputStream._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int available()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.EofSensorInputStream.staticClass, "available", "()I", ref global::org.apache.http.conn.EofSensorInputStream._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void releaseConnection()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.EofSensorInputStream.staticClass, "releaseConnection", "()V", ref global::org.apache.http.conn.EofSensorInputStream._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void abortConnection()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.EofSensorInputStream.staticClass, "abortConnection", "()V", ref global::org.apache.http.conn.EofSensorInputStream._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected virtual bool isReadAllowed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.EofSensorInputStream.staticClass, "isReadAllowed", "()Z", ref global::org.apache.http.conn.EofSensorInputStream._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected virtual void checkEOF(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.EofSensorInputStream.staticClass, "checkEOF", "(I)V", ref global::org.apache.http.conn.EofSensorInputStream._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected virtual void checkClose()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.EofSensorInputStream.staticClass, "checkClose", "()V", ref global::org.apache.http.conn.EofSensorInputStream._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected virtual void checkAbort()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.EofSensorInputStream.staticClass, "checkAbort", "()V", ref global::org.apache.http.conn.EofSensorInputStream._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public EofSensorInputStream(java.io.InputStream arg0, org.apache.http.conn.EofSensorWatcher arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.EofSensorInputStream._m11.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.EofSensorInputStream._m11 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorInputStream.staticClass, "<init>", "(Ljava/io/InputStream;Lorg/apache/http/conn/EofSensorWatcher;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.EofSensorInputStream.staticClass, global::org.apache.http.conn.EofSensorInputStream._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static EofSensorInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.EofSensorInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/EofSensorInputStream"));
		}
	}
}
