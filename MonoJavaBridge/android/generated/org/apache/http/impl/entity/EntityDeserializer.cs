namespace org.apache.http.impl.entity
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EntityDeserializer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EntityDeserializer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _doDeserialize33370;
		protected virtual global::org.apache.http.entity.BasicHttpEntity doDeserialize(org.apache.http.io.SessionInputBuffer arg0, org.apache.http.HttpMessage arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.entity.EntityDeserializer.staticClass, global::org.apache.http.impl.entity.EntityDeserializer._doDeserialize33370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.entity.BasicHttpEntity;
		}
		internal static global::MonoJavaBridge.MethodId _deserialize33371;
		public virtual global::org.apache.http.HttpEntity deserialize(org.apache.http.io.SessionInputBuffer arg0, org.apache.http.HttpMessage arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpEntity>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.entity.EntityDeserializer.staticClass, global::org.apache.http.impl.entity.EntityDeserializer._deserialize33371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HttpEntity;
		}
		internal static global::MonoJavaBridge.MethodId _EntityDeserializer33372;
		public EntityDeserializer(org.apache.http.entity.ContentLengthStrategy arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.entity.EntityDeserializer.staticClass, global::org.apache.http.impl.entity.EntityDeserializer._EntityDeserializer33372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static EntityDeserializer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.entity.EntityDeserializer.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/entity/EntityDeserializer"));
			global::org.apache.http.impl.entity.EntityDeserializer._doDeserialize33370 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.entity.EntityDeserializer.staticClass, "doDeserialize", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/HttpMessage;)Lorg/apache/http/entity/BasicHttpEntity;");
			global::org.apache.http.impl.entity.EntityDeserializer._deserialize33371 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.entity.EntityDeserializer.staticClass, "deserialize", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/HttpMessage;)Lorg/apache/http/HttpEntity;");
			global::org.apache.http.impl.entity.EntityDeserializer._EntityDeserializer33372 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.entity.EntityDeserializer.staticClass, "<init>", "(Lorg/apache/http/entity/ContentLengthStrategy;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
