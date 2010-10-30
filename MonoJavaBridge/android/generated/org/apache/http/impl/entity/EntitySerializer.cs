namespace org.apache.http.impl.entity
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EntitySerializer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EntitySerializer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _serialize33373;
		public virtual void serialize(org.apache.http.io.SessionOutputBuffer arg0, org.apache.http.HttpMessage arg1, org.apache.http.HttpEntity arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.entity.EntitySerializer._serialize33373.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.entity.EntitySerializer._serialize33373 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.entity.EntitySerializer.staticClass, "serialize", "(Lorg/apache/http/io/SessionOutputBuffer;Lorg/apache/http/HttpMessage;Lorg/apache/http/HttpEntity;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.entity.EntitySerializer.staticClass, global::org.apache.http.impl.entity.EntitySerializer._serialize33373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _doSerialize33374;
		protected virtual global::java.io.OutputStream doSerialize(org.apache.http.io.SessionOutputBuffer arg0, org.apache.http.HttpMessage arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.entity.EntitySerializer._doSerialize33374.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.entity.EntitySerializer._doSerialize33374 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.entity.EntitySerializer.staticClass, "doSerialize", "(Lorg/apache/http/io/SessionOutputBuffer;Lorg/apache/http/HttpMessage;)Ljava/io/OutputStream;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.entity.EntitySerializer.staticClass, global::org.apache.http.impl.entity.EntitySerializer._doSerialize33374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.io.OutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _EntitySerializer33375;
		public EntitySerializer(org.apache.http.entity.ContentLengthStrategy arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.entity.EntitySerializer._EntitySerializer33375.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.entity.EntitySerializer._EntitySerializer33375 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.entity.EntitySerializer.staticClass, "<init>", "(Lorg/apache/http/entity/ContentLengthStrategy;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.entity.EntitySerializer.staticClass, global::org.apache.http.impl.entity.EntitySerializer._EntitySerializer33375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
