namespace org.apache.http.conn
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EofSensorInputStream : java.io.InputStream, ConnectionReleaseTrigger
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EofSensorInputStream()
		{
			InitJNI();
		}
		protected EofSensorInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close25394;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream._close25394);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream.staticClass, global::org.apache.http.conn.EofSensorInputStream._close25394);
		}
		internal static global::MonoJavaBridge.MethodId _read25395;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream._read25395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream.staticClass, global::org.apache.http.conn.EofSensorInputStream._read25395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read25396;
		public override int read(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream._read25396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream.staticClass, global::org.apache.http.conn.EofSensorInputStream._read25396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read25397;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream._read25397);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream.staticClass, global::org.apache.http.conn.EofSensorInputStream._read25397);
		}
		internal static global::MonoJavaBridge.MethodId _available25398;
		public override int available() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream._available25398);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream.staticClass, global::org.apache.http.conn.EofSensorInputStream._available25398);
		}
		internal static global::MonoJavaBridge.MethodId _releaseConnection25399;
		public virtual void releaseConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream._releaseConnection25399);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream.staticClass, global::org.apache.http.conn.EofSensorInputStream._releaseConnection25399);
		}
		internal static global::MonoJavaBridge.MethodId _abortConnection25400;
		public virtual void abortConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream._abortConnection25400);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream.staticClass, global::org.apache.http.conn.EofSensorInputStream._abortConnection25400);
		}
		internal static global::MonoJavaBridge.MethodId _isReadAllowed25401;
		protected virtual bool isReadAllowed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream._isReadAllowed25401);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream.staticClass, global::org.apache.http.conn.EofSensorInputStream._isReadAllowed25401);
		}
		internal static global::MonoJavaBridge.MethodId _checkEOF25402;
		protected virtual void checkEOF(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream._checkEOF25402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream.staticClass, global::org.apache.http.conn.EofSensorInputStream._checkEOF25402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkClose25403;
		protected virtual void checkClose() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream._checkClose25403);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream.staticClass, global::org.apache.http.conn.EofSensorInputStream._checkClose25403);
		}
		internal static global::MonoJavaBridge.MethodId _checkAbort25404;
		protected virtual void checkAbort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream._checkAbort25404);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream.staticClass, global::org.apache.http.conn.EofSensorInputStream._checkAbort25404);
		}
		internal static global::MonoJavaBridge.MethodId _EofSensorInputStream25405;
		public EofSensorInputStream(java.io.InputStream arg0, org.apache.http.conn.EofSensorWatcher arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.EofSensorInputStream.staticClass, global::org.apache.http.conn.EofSensorInputStream._EofSensorInputStream25405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.EofSensorInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/EofSensorInputStream"));
			global::org.apache.http.conn.EofSensorInputStream._close25394 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorInputStream.staticClass, "close", "()V");
			global::org.apache.http.conn.EofSensorInputStream._read25395 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorInputStream.staticClass, "read", "([BII)I");
			global::org.apache.http.conn.EofSensorInputStream._read25396 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorInputStream.staticClass, "read", "([B)I");
			global::org.apache.http.conn.EofSensorInputStream._read25397 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorInputStream.staticClass, "read", "()I");
			global::org.apache.http.conn.EofSensorInputStream._available25398 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorInputStream.staticClass, "available", "()I");
			global::org.apache.http.conn.EofSensorInputStream._releaseConnection25399 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorInputStream.staticClass, "releaseConnection", "()V");
			global::org.apache.http.conn.EofSensorInputStream._abortConnection25400 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorInputStream.staticClass, "abortConnection", "()V");
			global::org.apache.http.conn.EofSensorInputStream._isReadAllowed25401 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorInputStream.staticClass, "isReadAllowed", "()Z");
			global::org.apache.http.conn.EofSensorInputStream._checkEOF25402 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorInputStream.staticClass, "checkEOF", "(I)V");
			global::org.apache.http.conn.EofSensorInputStream._checkClose25403 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorInputStream.staticClass, "checkClose", "()V");
			global::org.apache.http.conn.EofSensorInputStream._checkAbort25404 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorInputStream.staticClass, "checkAbort", "()V");
			global::org.apache.http.conn.EofSensorInputStream._EofSensorInputStream25405 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorInputStream.staticClass, "<init>", "(Ljava/io/InputStream;Lorg/apache/http/conn/EofSensorWatcher;)V");
		}
	}
}
