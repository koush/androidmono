namespace org.apache.http.entity
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BufferedHttpEntity : org.apache.http.entity.HttpEntityWrapper
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
		internal static global::MonoJavaBridge.MethodId _getContent32515;
		public override global::java.io.InputStream getContent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.entity.BufferedHttpEntity.staticClass, "getContent", "()Ljava/io/InputStream;", ref global::org.apache.http.entity.BufferedHttpEntity._getContent32515) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _writeTo32516;
		public override void writeTo(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.entity.BufferedHttpEntity.staticClass, "writeTo", "(Ljava/io/OutputStream;)V", ref global::org.apache.http.entity.BufferedHttpEntity._writeTo32516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long ContentLength
		{
			get
			{
				return getContentLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentLength32517;
		public override long getContentLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.apache.http.entity.BufferedHttpEntity.staticClass, "getContentLength", "()J", ref global::org.apache.http.entity.BufferedHttpEntity._getContentLength32517);
		}
		internal static global::MonoJavaBridge.MethodId _isRepeatable32518;
		public override bool isRepeatable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.entity.BufferedHttpEntity.staticClass, "isRepeatable", "()Z", ref global::org.apache.http.entity.BufferedHttpEntity._isRepeatable32518);
		}
		internal static global::MonoJavaBridge.MethodId _isChunked32519;
		public override bool isChunked()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.entity.BufferedHttpEntity.staticClass, "isChunked", "()Z", ref global::org.apache.http.entity.BufferedHttpEntity._isChunked32519);
		}
		internal static global::MonoJavaBridge.MethodId _isStreaming32520;
		public override bool isStreaming()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.entity.BufferedHttpEntity.staticClass, "isStreaming", "()Z", ref global::org.apache.http.entity.BufferedHttpEntity._isStreaming32520);
		}
		internal static global::MonoJavaBridge.MethodId _BufferedHttpEntity32521;
		public BufferedHttpEntity(org.apache.http.HttpEntity arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.entity.BufferedHttpEntity._BufferedHttpEntity32521.native == global::System.IntPtr.Zero)
				global::org.apache.http.entity.BufferedHttpEntity._BufferedHttpEntity32521 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BufferedHttpEntity.staticClass, "<init>", "(Lorg/apache/http/HttpEntity;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.entity.BufferedHttpEntity.staticClass, global::org.apache.http.entity.BufferedHttpEntity._BufferedHttpEntity32521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static BufferedHttpEntity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.entity.BufferedHttpEntity.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/entity/BufferedHttpEntity"));
		}
		internal static void InitJNI()
		{
		}
	}
}
