namespace org.apache.http.impl.entity
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EntitySerializer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EntitySerializer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void serialize(org.apache.http.io.SessionOutputBuffer arg0, org.apache.http.HttpMessage arg1, org.apache.http.HttpEntity arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.entity.EntitySerializer.staticClass, "serialize", "(Lorg/apache/http/io/SessionOutputBuffer;Lorg/apache/http/HttpMessage;Lorg/apache/http/HttpEntity;)V", ref global::org.apache.http.impl.entity.EntitySerializer._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected virtual global::java.io.OutputStream doSerialize(org.apache.http.io.SessionOutputBuffer arg0, org.apache.http.HttpMessage arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.entity.EntitySerializer.staticClass, "doSerialize", "(Lorg/apache/http/io/SessionOutputBuffer;Lorg/apache/http/HttpMessage;)Ljava/io/OutputStream;", ref global::org.apache.http.impl.entity.EntitySerializer._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.io.OutputStream;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public EntitySerializer(org.apache.http.entity.ContentLengthStrategy arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.entity.EntitySerializer._m2.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.entity.EntitySerializer._m2 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.entity.EntitySerializer.staticClass, "<init>", "(Lorg/apache/http/entity/ContentLengthStrategy;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.entity.EntitySerializer.staticClass, global::org.apache.http.impl.entity.EntitySerializer._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static EntitySerializer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.entity.EntitySerializer.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/entity/EntitySerializer"));
		}
		internal static void InitJNI()
		{
		}
	}
}
