namespace org.apache.http.entity
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpEntityWrapper : java.lang.Object, HttpEntity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HttpEntityWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
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
		public virtual global::java.io.InputStream getContent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.entity.HttpEntityWrapper.staticClass, "getContent", "()Ljava/io/InputStream;", ref global::org.apache.http.entity.HttpEntityWrapper._m0) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void writeTo(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.entity.HttpEntityWrapper.staticClass, "writeTo", "(Ljava/io/OutputStream;)V", ref global::org.apache.http.entity.HttpEntityWrapper._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.Header ContentType
		{
			get
			{
				return getContentType();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::org.apache.http.Header getContentType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.entity.HttpEntityWrapper.staticClass, "getContentType", "()Lorg/apache/http/Header;", ref global::org.apache.http.entity.HttpEntityWrapper._m2) as org.apache.http.Header;
		}
		public new long ContentLength
		{
			get
			{
				return getContentLength();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual long getContentLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.apache.http.entity.HttpEntityWrapper.staticClass, "getContentLength", "()J", ref global::org.apache.http.entity.HttpEntityWrapper._m3);
		}
		public new global::org.apache.http.Header ContentEncoding
		{
			get
			{
				return getContentEncoding();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::org.apache.http.Header getContentEncoding()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.entity.HttpEntityWrapper.staticClass, "getContentEncoding", "()Lorg/apache/http/Header;", ref global::org.apache.http.entity.HttpEntityWrapper._m4) as org.apache.http.Header;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool isRepeatable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.entity.HttpEntityWrapper.staticClass, "isRepeatable", "()Z", ref global::org.apache.http.entity.HttpEntityWrapper._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual bool isChunked()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.entity.HttpEntityWrapper.staticClass, "isChunked", "()Z", ref global::org.apache.http.entity.HttpEntityWrapper._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool isStreaming()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.entity.HttpEntityWrapper.staticClass, "isStreaming", "()Z", ref global::org.apache.http.entity.HttpEntityWrapper._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void consumeContent()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.entity.HttpEntityWrapper.staticClass, "consumeContent", "()V", ref global::org.apache.http.entity.HttpEntityWrapper._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public HttpEntityWrapper(org.apache.http.HttpEntity arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.entity.HttpEntityWrapper._m9.native == global::System.IntPtr.Zero)
				global::org.apache.http.entity.HttpEntityWrapper._m9 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.HttpEntityWrapper.staticClass, "<init>", "(Lorg/apache/http/HttpEntity;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.entity.HttpEntityWrapper.staticClass, global::org.apache.http.entity.HttpEntityWrapper._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static HttpEntityWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.entity.HttpEntityWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/entity/HttpEntityWrapper"));
		}
	}
}
