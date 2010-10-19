namespace org.apache.http.conn
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicManagedEntity : org.apache.http.entity.HttpEntityWrapper, ConnectionReleaseTrigger, EofSensorWatcher
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BasicManagedEntity()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getContent25364;
		public override global::java.io.InputStream getContent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity._getContent25364)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity.staticClass, global::org.apache.http.conn.BasicManagedEntity._getContent25364)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _writeTo25365;
		public override void writeTo(java.io.OutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity._writeTo25365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity.staticClass, global::org.apache.http.conn.BasicManagedEntity._writeTo25365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isRepeatable25366;
		public override bool isRepeatable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity._isRepeatable25366);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity.staticClass, global::org.apache.http.conn.BasicManagedEntity._isRepeatable25366);
		}
		internal static global::MonoJavaBridge.MethodId _releaseConnection25367;
		public virtual void releaseConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity._releaseConnection25367);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity.staticClass, global::org.apache.http.conn.BasicManagedEntity._releaseConnection25367);
		}
		internal static global::MonoJavaBridge.MethodId _consumeContent25368;
		public override void consumeContent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity._consumeContent25368);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity.staticClass, global::org.apache.http.conn.BasicManagedEntity._consumeContent25368);
		}
		internal static global::MonoJavaBridge.MethodId _abortConnection25369;
		public virtual void abortConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity._abortConnection25369);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity.staticClass, global::org.apache.http.conn.BasicManagedEntity._abortConnection25369);
		}
		internal static global::MonoJavaBridge.MethodId _eofDetected25370;
		public virtual bool eofDetected(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity._eofDetected25370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity.staticClass, global::org.apache.http.conn.BasicManagedEntity._eofDetected25370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _streamClosed25371;
		public virtual bool streamClosed(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity._streamClosed25371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity.staticClass, global::org.apache.http.conn.BasicManagedEntity._streamClosed25371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _streamAbort25372;
		public virtual bool streamAbort(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity._streamAbort25372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity.staticClass, global::org.apache.http.conn.BasicManagedEntity._streamAbort25372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _releaseManagedConnection25373;
		protected virtual void releaseManagedConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity._releaseManagedConnection25373);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity.staticClass, global::org.apache.http.conn.BasicManagedEntity._releaseManagedConnection25373);
		}
		internal static global::MonoJavaBridge.MethodId _BasicManagedEntity25374;
		public BasicManagedEntity(org.apache.http.HttpEntity arg0, org.apache.http.conn.ManagedClientConnection arg1, bool arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.BasicManagedEntity.staticClass, global::org.apache.http.conn.BasicManagedEntity._BasicManagedEntity25374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.BasicManagedEntity.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/BasicManagedEntity"));
			global::org.apache.http.conn.BasicManagedEntity._getContent25364 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.BasicManagedEntity.staticClass, "getContent", "()Ljava/io/InputStream;");
			global::org.apache.http.conn.BasicManagedEntity._writeTo25365 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.BasicManagedEntity.staticClass, "writeTo", "(Ljava/io/OutputStream;)V");
			global::org.apache.http.conn.BasicManagedEntity._isRepeatable25366 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.BasicManagedEntity.staticClass, "isRepeatable", "()Z");
			global::org.apache.http.conn.BasicManagedEntity._releaseConnection25367 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.BasicManagedEntity.staticClass, "releaseConnection", "()V");
			global::org.apache.http.conn.BasicManagedEntity._consumeContent25368 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.BasicManagedEntity.staticClass, "consumeContent", "()V");
			global::org.apache.http.conn.BasicManagedEntity._abortConnection25369 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.BasicManagedEntity.staticClass, "abortConnection", "()V");
			global::org.apache.http.conn.BasicManagedEntity._eofDetected25370 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.BasicManagedEntity.staticClass, "eofDetected", "(Ljava/io/InputStream;)Z");
			global::org.apache.http.conn.BasicManagedEntity._streamClosed25371 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.BasicManagedEntity.staticClass, "streamClosed", "(Ljava/io/InputStream;)Z");
			global::org.apache.http.conn.BasicManagedEntity._streamAbort25372 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.BasicManagedEntity.staticClass, "streamAbort", "(Ljava/io/InputStream;)Z");
			global::org.apache.http.conn.BasicManagedEntity._releaseManagedConnection25373 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.BasicManagedEntity.staticClass, "releaseManagedConnection", "()V");
			global::org.apache.http.conn.BasicManagedEntity._BasicManagedEntity25374 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.BasicManagedEntity.staticClass, "<init>", "(Lorg/apache/http/HttpEntity;Lorg/apache/http/conn/ManagedClientConnection;Z)V");
		}
	}
}
