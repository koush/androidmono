namespace org.apache.http.entity
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EntityTemplate : org.apache.http.entity.AbstractHttpEntity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EntityTemplate(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.io.InputStream Content
		{
			get
			{
				return getContent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContent32533;
		public override global::java.io.InputStream getContent()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.entity.EntityTemplate.staticClass, global::org.apache.http.entity.EntityTemplate._getContent32533)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _writeTo32534;
		public override void writeTo(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.entity.EntityTemplate.staticClass, global::org.apache.http.entity.EntityTemplate._writeTo32534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long ContentLength
		{
			get
			{
				return getContentLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentLength32535;
		public override long getContentLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.apache.http.entity.EntityTemplate.staticClass, global::org.apache.http.entity.EntityTemplate._getContentLength32535);
		}
		internal static global::MonoJavaBridge.MethodId _isRepeatable32536;
		public override bool isRepeatable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.entity.EntityTemplate.staticClass, global::org.apache.http.entity.EntityTemplate._isRepeatable32536);
		}
		internal static global::MonoJavaBridge.MethodId _isStreaming32537;
		public override bool isStreaming()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.entity.EntityTemplate.staticClass, global::org.apache.http.entity.EntityTemplate._isStreaming32537);
		}
		internal static global::MonoJavaBridge.MethodId _consumeContent32538;
		public override void consumeContent()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.entity.EntityTemplate.staticClass, global::org.apache.http.entity.EntityTemplate._consumeContent32538);
		}
		internal static global::MonoJavaBridge.MethodId _EntityTemplate32539;
		public EntityTemplate(org.apache.http.entity.ContentProducer arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.entity.EntityTemplate.staticClass, global::org.apache.http.entity.EntityTemplate._EntityTemplate32539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static EntityTemplate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.entity.EntityTemplate.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/entity/EntityTemplate"));
			global::org.apache.http.entity.EntityTemplate._getContent32533 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.EntityTemplate.staticClass, "getContent", "()Ljava/io/InputStream;");
			global::org.apache.http.entity.EntityTemplate._writeTo32534 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.EntityTemplate.staticClass, "writeTo", "(Ljava/io/OutputStream;)V");
			global::org.apache.http.entity.EntityTemplate._getContentLength32535 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.EntityTemplate.staticClass, "getContentLength", "()J");
			global::org.apache.http.entity.EntityTemplate._isRepeatable32536 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.EntityTemplate.staticClass, "isRepeatable", "()Z");
			global::org.apache.http.entity.EntityTemplate._isStreaming32537 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.EntityTemplate.staticClass, "isStreaming", "()Z");
			global::org.apache.http.entity.EntityTemplate._consumeContent32538 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.EntityTemplate.staticClass, "consumeContent", "()V");
			global::org.apache.http.entity.EntityTemplate._EntityTemplate32539 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.EntityTemplate.staticClass, "<init>", "(Lorg/apache/http/entity/ContentProducer;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
