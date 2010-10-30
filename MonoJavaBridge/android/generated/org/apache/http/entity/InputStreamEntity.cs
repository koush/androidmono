namespace org.apache.http.entity
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InputStreamEntity : org.apache.http.entity.AbstractHttpEntity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InputStreamEntity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
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
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.entity.InputStreamEntity.staticClass, "getContent", "()Ljava/io/InputStream;", ref global::org.apache.http.entity.InputStreamEntity._m0) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void writeTo(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.entity.InputStreamEntity.staticClass, "writeTo", "(Ljava/io/OutputStream;)V", ref global::org.apache.http.entity.InputStreamEntity._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.apache.http.entity.InputStreamEntity.staticClass, "getContentLength", "()J", ref global::org.apache.http.entity.InputStreamEntity._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool isRepeatable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.entity.InputStreamEntity.staticClass, "isRepeatable", "()Z", ref global::org.apache.http.entity.InputStreamEntity._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool isStreaming()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.entity.InputStreamEntity.staticClass, "isStreaming", "()Z", ref global::org.apache.http.entity.InputStreamEntity._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override void consumeContent()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.entity.InputStreamEntity.staticClass, "consumeContent", "()V", ref global::org.apache.http.entity.InputStreamEntity._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public InputStreamEntity(java.io.InputStream arg0, long arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.entity.InputStreamEntity._m6.native == global::System.IntPtr.Zero)
				global::org.apache.http.entity.InputStreamEntity._m6 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.InputStreamEntity.staticClass, "<init>", "(Ljava/io/InputStream;J)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.entity.InputStreamEntity.staticClass, global::org.apache.http.entity.InputStreamEntity._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static InputStreamEntity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.entity.InputStreamEntity.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/entity/InputStreamEntity"));
		}
		internal static void InitJNI()
		{
		}
	}
}
