namespace org.apache.http.entity
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ByteArrayEntity : org.apache.http.entity.AbstractHttpEntity, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ByteArrayEntity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone32522;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.entity.ByteArrayEntity.staticClass, global::org.apache.http.entity.ByteArrayEntity._clone32522)) as java.lang.Object;
		}
		public new global::java.io.InputStream Content
		{
			get
			{
				return getContent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContent32523;
		public override global::java.io.InputStream getContent()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.entity.ByteArrayEntity.staticClass, global::org.apache.http.entity.ByteArrayEntity._getContent32523)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _writeTo32524;
		public override void writeTo(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.entity.ByteArrayEntity.staticClass, global::org.apache.http.entity.ByteArrayEntity._writeTo32524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long ContentLength
		{
			get
			{
				return getContentLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentLength32525;
		public override long getContentLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.apache.http.entity.ByteArrayEntity.staticClass, global::org.apache.http.entity.ByteArrayEntity._getContentLength32525);
		}
		internal static global::MonoJavaBridge.MethodId _isRepeatable32526;
		public override bool isRepeatable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.entity.ByteArrayEntity.staticClass, global::org.apache.http.entity.ByteArrayEntity._isRepeatable32526);
		}
		internal static global::MonoJavaBridge.MethodId _isStreaming32527;
		public override bool isStreaming()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.entity.ByteArrayEntity.staticClass, global::org.apache.http.entity.ByteArrayEntity._isStreaming32527);
		}
		internal static global::MonoJavaBridge.MethodId _ByteArrayEntity32528;
		public ByteArrayEntity(byte[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.entity.ByteArrayEntity.staticClass, global::org.apache.http.entity.ByteArrayEntity._ByteArrayEntity32528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ByteArrayEntity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.entity.ByteArrayEntity.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/entity/ByteArrayEntity"));
			global::org.apache.http.entity.ByteArrayEntity._clone32522 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.ByteArrayEntity.staticClass, "clone", "()Ljava/lang/Object;");
			global::org.apache.http.entity.ByteArrayEntity._getContent32523 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.ByteArrayEntity.staticClass, "getContent", "()Ljava/io/InputStream;");
			global::org.apache.http.entity.ByteArrayEntity._writeTo32524 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.ByteArrayEntity.staticClass, "writeTo", "(Ljava/io/OutputStream;)V");
			global::org.apache.http.entity.ByteArrayEntity._getContentLength32525 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.ByteArrayEntity.staticClass, "getContentLength", "()J");
			global::org.apache.http.entity.ByteArrayEntity._isRepeatable32526 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.ByteArrayEntity.staticClass, "isRepeatable", "()Z");
			global::org.apache.http.entity.ByteArrayEntity._isStreaming32527 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.ByteArrayEntity.staticClass, "isStreaming", "()Z");
			global::org.apache.http.entity.ByteArrayEntity._ByteArrayEntity32528 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.ByteArrayEntity.staticClass, "<init>", "([B)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
