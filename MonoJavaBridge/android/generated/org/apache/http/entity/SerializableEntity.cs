namespace org.apache.http.entity
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SerializableEntity : org.apache.http.entity.AbstractHttpEntity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SerializableEntity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
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
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.entity.SerializableEntity.staticClass, "getContent", "()Ljava/io/InputStream;", ref global::org.apache.http.entity.SerializableEntity._m0) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void writeTo(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.entity.SerializableEntity.staticClass, "writeTo", "(Ljava/io/OutputStream;)V", ref global::org.apache.http.entity.SerializableEntity._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.apache.http.entity.SerializableEntity.staticClass, "getContentLength", "()J", ref global::org.apache.http.entity.SerializableEntity._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool isRepeatable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.entity.SerializableEntity.staticClass, "isRepeatable", "()Z", ref global::org.apache.http.entity.SerializableEntity._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool isStreaming()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.entity.SerializableEntity.staticClass, "isStreaming", "()Z", ref global::org.apache.http.entity.SerializableEntity._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public SerializableEntity(java.io.Serializable arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.entity.SerializableEntity._m5.native == global::System.IntPtr.Zero)
				global::org.apache.http.entity.SerializableEntity._m5 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.SerializableEntity.staticClass, "<init>", "(Ljava/io/Serializable;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.entity.SerializableEntity.staticClass, global::org.apache.http.entity.SerializableEntity._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static SerializableEntity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.entity.SerializableEntity.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/entity/SerializableEntity"));
		}
		internal static void InitJNI()
		{
		}
	}
}
