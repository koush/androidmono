namespace org.apache.http.entity
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ByteArrayEntity : org.apache.http.entity.AbstractHttpEntity, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ByteArrayEntity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.entity.ByteArrayEntity.staticClass, "clone", "()Ljava/lang/Object;", ref global::org.apache.http.entity.ByteArrayEntity._m0) as java.lang.Object;
		}
		public new global::java.io.InputStream Content
		{
			get
			{
				return getContent();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.io.InputStream getContent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.entity.ByteArrayEntity.staticClass, "getContent", "()Ljava/io/InputStream;", ref global::org.apache.http.entity.ByteArrayEntity._m1) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void writeTo(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.entity.ByteArrayEntity.staticClass, "writeTo", "(Ljava/io/OutputStream;)V", ref global::org.apache.http.entity.ByteArrayEntity._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long ContentLength
		{
			get
			{
				return getContentLength();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override long getContentLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.apache.http.entity.ByteArrayEntity.staticClass, "getContentLength", "()J", ref global::org.apache.http.entity.ByteArrayEntity._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool isRepeatable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.entity.ByteArrayEntity.staticClass, "isRepeatable", "()Z", ref global::org.apache.http.entity.ByteArrayEntity._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override bool isStreaming()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.entity.ByteArrayEntity.staticClass, "isStreaming", "()Z", ref global::org.apache.http.entity.ByteArrayEntity._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public ByteArrayEntity(byte[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.entity.ByteArrayEntity._m6.native == global::System.IntPtr.Zero)
				global::org.apache.http.entity.ByteArrayEntity._m6 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.ByteArrayEntity.staticClass, "<init>", "([B)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.entity.ByteArrayEntity.staticClass, global::org.apache.http.entity.ByteArrayEntity._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ByteArrayEntity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.entity.ByteArrayEntity.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/entity/ByteArrayEntity"));
		}
	}
}
