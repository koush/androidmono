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
		internal static global::MonoJavaBridge.MethodId _close32094;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream._close32094);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream.staticClass, global::org.apache.http.conn.EofSensorInputStream._close32094);
		}
		internal static global::MonoJavaBridge.MethodId _read32095;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream._read32095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream.staticClass, global::org.apache.http.conn.EofSensorInputStream._read32095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read32096;
		public override int read(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream._read32096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream.staticClass, global::org.apache.http.conn.EofSensorInputStream._read32096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read32097;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream._read32097);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream.staticClass, global::org.apache.http.conn.EofSensorInputStream._read32097);
		}
		internal static global::MonoJavaBridge.MethodId _available32098;
		public override int available() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream._available32098);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream.staticClass, global::org.apache.http.conn.EofSensorInputStream._available32098);
		}
		internal static global::MonoJavaBridge.MethodId _releaseConnection32099;
		public virtual void releaseConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream._releaseConnection32099);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream.staticClass, global::org.apache.http.conn.EofSensorInputStream._releaseConnection32099);
		}
		internal static global::MonoJavaBridge.MethodId _abortConnection32100;
		public virtual void abortConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream._abortConnection32100);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream.staticClass, global::org.apache.http.conn.EofSensorInputStream._abortConnection32100);
		}
		internal static global::MonoJavaBridge.MethodId _isReadAllowed32101;
		protected virtual bool isReadAllowed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream._isReadAllowed32101);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream.staticClass, global::org.apache.http.conn.EofSensorInputStream._isReadAllowed32101);
		}
		internal static global::MonoJavaBridge.MethodId _checkEOF32102;
		protected virtual void checkEOF(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream._checkEOF32102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream.staticClass, global::org.apache.http.conn.EofSensorInputStream._checkEOF32102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkClose32103;
		protected virtual void checkClose() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream._checkClose32103);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream.staticClass, global::org.apache.http.conn.EofSensorInputStream._checkClose32103);
		}
		internal static global::MonoJavaBridge.MethodId _checkAbort32104;
		protected virtual void checkAbort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream._checkAbort32104);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorInputStream.staticClass, global::org.apache.http.conn.EofSensorInputStream._checkAbort32104);
		}
		internal static global::MonoJavaBridge.MethodId _EofSensorInputStream32105;
		public EofSensorInputStream(java.io.InputStream arg0, org.apache.http.conn.EofSensorWatcher arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.EofSensorInputStream.staticClass, global::org.apache.http.conn.EofSensorInputStream._EofSensorInputStream32105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.EofSensorInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/EofSensorInputStream"));
			global::org.apache.http.conn.EofSensorInputStream._close32094 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorInputStream.staticClass, "close", "()V");
			global::org.apache.http.conn.EofSensorInputStream._read32095 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorInputStream.staticClass, "read", "([BII)I");
			global::org.apache.http.conn.EofSensorInputStream._read32096 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorInputStream.staticClass, "read", "([B)I");
			global::org.apache.http.conn.EofSensorInputStream._read32097 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorInputStream.staticClass, "read", "()I");
			global::org.apache.http.conn.EofSensorInputStream._available32098 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorInputStream.staticClass, "available", "()I");
			global::org.apache.http.conn.EofSensorInputStream._releaseConnection32099 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorInputStream.staticClass, "releaseConnection", "()V");
			global::org.apache.http.conn.EofSensorInputStream._abortConnection32100 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorInputStream.staticClass, "abortConnection", "()V");
			global::org.apache.http.conn.EofSensorInputStream._isReadAllowed32101 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorInputStream.staticClass, "isReadAllowed", "()Z");
			global::org.apache.http.conn.EofSensorInputStream._checkEOF32102 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorInputStream.staticClass, "checkEOF", "(I)V");
			global::org.apache.http.conn.EofSensorInputStream._checkClose32103 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorInputStream.staticClass, "checkClose", "()V");
			global::org.apache.http.conn.EofSensorInputStream._checkAbort32104 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorInputStream.staticClass, "checkAbort", "()V");
			global::org.apache.http.conn.EofSensorInputStream._EofSensorInputStream32105 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorInputStream.staticClass, "<init>", "(Ljava/io/InputStream;Lorg/apache/http/conn/EofSensorWatcher;)V");
		}
	}
}
