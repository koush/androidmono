namespace org.apache.http.entity
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BufferedHttpEntity : org.apache.http.entity.HttpEntityWrapper
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BufferedHttpEntity()
		{
			InitJNI();
		}
		protected BufferedHttpEntity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.io.InputStream Content
		{
			get
			{
				return getContent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContent32514;
		public override global::java.io.InputStream getContent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.entity.BufferedHttpEntity._getContent32514)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.entity.BufferedHttpEntity.staticClass, global::org.apache.http.entity.BufferedHttpEntity._getContent32514)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _writeTo32515;
		public override void writeTo(java.io.OutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.BufferedHttpEntity._writeTo32515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.BufferedHttpEntity.staticClass, global::org.apache.http.entity.BufferedHttpEntity._writeTo32515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long ContentLength
		{
			get
			{
				return getContentLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentLength32516;
		public override long getContentLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.entity.BufferedHttpEntity._getContentLength32516);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.entity.BufferedHttpEntity.staticClass, global::org.apache.http.entity.BufferedHttpEntity._getContentLength32516);
		}
		internal static global::MonoJavaBridge.MethodId _isRepeatable32517;
		public override bool isRepeatable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.entity.BufferedHttpEntity._isRepeatable32517);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.entity.BufferedHttpEntity.staticClass, global::org.apache.http.entity.BufferedHttpEntity._isRepeatable32517);
		}
		internal static global::MonoJavaBridge.MethodId _isChunked32518;
		public override bool isChunked() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.entity.BufferedHttpEntity._isChunked32518);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.entity.BufferedHttpEntity.staticClass, global::org.apache.http.entity.BufferedHttpEntity._isChunked32518);
		}
		internal static global::MonoJavaBridge.MethodId _isStreaming32519;
		public override bool isStreaming() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.entity.BufferedHttpEntity._isStreaming32519);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.entity.BufferedHttpEntity.staticClass, global::org.apache.http.entity.BufferedHttpEntity._isStreaming32519);
		}
		internal static global::MonoJavaBridge.MethodId _BufferedHttpEntity32520;
		public BufferedHttpEntity(org.apache.http.HttpEntity arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.entity.BufferedHttpEntity.staticClass, global::org.apache.http.entity.BufferedHttpEntity._BufferedHttpEntity32520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.entity.BufferedHttpEntity.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/entity/BufferedHttpEntity"));
			global::org.apache.http.entity.BufferedHttpEntity._getContent32514 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BufferedHttpEntity.staticClass, "getContent", "()Ljava/io/InputStream;");
			global::org.apache.http.entity.BufferedHttpEntity._writeTo32515 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BufferedHttpEntity.staticClass, "writeTo", "(Ljava/io/OutputStream;)V");
			global::org.apache.http.entity.BufferedHttpEntity._getContentLength32516 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BufferedHttpEntity.staticClass, "getContentLength", "()J");
			global::org.apache.http.entity.BufferedHttpEntity._isRepeatable32517 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BufferedHttpEntity.staticClass, "isRepeatable", "()Z");
			global::org.apache.http.entity.BufferedHttpEntity._isChunked32518 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BufferedHttpEntity.staticClass, "isChunked", "()Z");
			global::org.apache.http.entity.BufferedHttpEntity._isStreaming32519 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BufferedHttpEntity.staticClass, "isStreaming", "()Z");
			global::org.apache.http.entity.BufferedHttpEntity._BufferedHttpEntity32520 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BufferedHttpEntity.staticClass, "<init>", "(Lorg/apache/http/HttpEntity;)V");
		}
	}
}
