namespace org.apache.http.impl.entity
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EntityDeserializer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EntityDeserializer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected virtual global::org.apache.http.entity.BasicHttpEntity doDeserialize(org.apache.http.io.SessionInputBuffer arg0, org.apache.http.HttpMessage arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.entity.EntityDeserializer.staticClass, "doDeserialize", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/HttpMessage;)Lorg/apache/http/entity/BasicHttpEntity;", ref global::org.apache.http.impl.entity.EntityDeserializer._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.entity.BasicHttpEntity;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::org.apache.http.HttpEntity deserialize(org.apache.http.io.SessionInputBuffer arg0, org.apache.http.HttpMessage arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpEntity>(this, global::org.apache.http.impl.entity.EntityDeserializer.staticClass, "deserialize", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/HttpMessage;)Lorg/apache/http/HttpEntity;", ref global::org.apache.http.impl.entity.EntityDeserializer._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.HttpEntity;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public EntityDeserializer(org.apache.http.entity.ContentLengthStrategy arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.entity.EntityDeserializer._m2.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.entity.EntityDeserializer._m2 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.entity.EntityDeserializer.staticClass, "<init>", "(Lorg/apache/http/entity/ContentLengthStrategy;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.entity.EntityDeserializer.staticClass, global::org.apache.http.impl.entity.EntityDeserializer._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static EntityDeserializer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.entity.EntityDeserializer.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/entity/EntityDeserializer"));
		}
		internal static void InitJNI()
		{
		}
	}
}
