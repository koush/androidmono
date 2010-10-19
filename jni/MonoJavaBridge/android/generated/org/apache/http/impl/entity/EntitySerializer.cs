namespace org.apache.http.impl.entity
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EntitySerializer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EntitySerializer()
		{
			InitJNI();
		}
		protected EntitySerializer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _serialize26627;
		public virtual void serialize(org.apache.http.io.SessionOutputBuffer arg0, org.apache.http.HttpMessage arg1, org.apache.http.HttpEntity arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.entity.EntitySerializer._serialize26627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.entity.EntitySerializer.staticClass, global::org.apache.http.impl.entity.EntitySerializer._serialize26627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _doSerialize26628;
		protected virtual global::java.io.OutputStream doSerialize(org.apache.http.io.SessionOutputBuffer arg0, org.apache.http.HttpMessage arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.entity.EntitySerializer._doSerialize26628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.OutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.entity.EntitySerializer.staticClass, global::org.apache.http.impl.entity.EntitySerializer._doSerialize26628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.OutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _EntitySerializer26629;
		public EntitySerializer(org.apache.http.entity.ContentLengthStrategy arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.entity.EntitySerializer.staticClass, global::org.apache.http.impl.entity.EntitySerializer._EntitySerializer26629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.entity.EntitySerializer.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/entity/EntitySerializer"));
			global::org.apache.http.impl.entity.EntitySerializer._serialize26627 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.entity.EntitySerializer.staticClass, "serialize", "(Lorg/apache/http/io/SessionOutputBuffer;Lorg/apache/http/HttpMessage;Lorg/apache/http/HttpEntity;)V");
			global::org.apache.http.impl.entity.EntitySerializer._doSerialize26628 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.entity.EntitySerializer.staticClass, "doSerialize", "(Lorg/apache/http/io/SessionOutputBuffer;Lorg/apache/http/HttpMessage;)Ljava/io/OutputStream;");
			global::org.apache.http.impl.entity.EntitySerializer._EntitySerializer26629 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.entity.EntitySerializer.staticClass, "<init>", "(Lorg/apache/http/entity/ContentLengthStrategy;)V");
		}
	}
}
