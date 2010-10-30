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
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.io.InputStream getContent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.entity.BufferedHttpEntity.staticClass, "getContent", "()Ljava/io/InputStream;", ref global::org.apache.http.entity.BufferedHttpEntity._m0) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void writeTo(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.entity.BufferedHttpEntity.staticClass, "writeTo", "(Ljava/io/OutputStream;)V", ref global::org.apache.http.entity.BufferedHttpEntity._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long ContentLength
		{
			get
			{
				return getContentLength();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override long getContentLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.apache.http.entity.BufferedHttpEntity.staticClass, "getContentLength", "()J", ref global::org.apache.http.entity.BufferedHttpEntity._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool isRepeatable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.entity.BufferedHttpEntity.staticClass, "isRepeatable", "()Z", ref global::org.apache.http.entity.BufferedHttpEntity._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool isChunked()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.entity.BufferedHttpEntity.staticClass, "isChunked", "()Z", ref global::org.apache.http.entity.BufferedHttpEntity._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override bool isStreaming()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.entity.BufferedHttpEntity.staticClass, "isStreaming", "()Z", ref global::org.apache.http.entity.BufferedHttpEntity._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public BufferedHttpEntity(org.apache.http.HttpEntity arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.entity.BufferedHttpEntity._m6.native == global::System.IntPtr.Zero)
				global::org.apache.http.entity.BufferedHttpEntity._m6 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BufferedHttpEntity.staticClass, "<init>", "(Lorg/apache/http/HttpEntity;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.entity.BufferedHttpEntity.staticClass, global::org.apache.http.entity.BufferedHttpEntity._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
