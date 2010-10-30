namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.HttpEntity_))]
	public partial interface HttpEntity  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.io.InputStream getContent();
		void writeTo(java.io.OutputStream arg0);
		global::org.apache.http.Header getContentType();
		long getContentLength();
		global::org.apache.http.Header getContentEncoding();
		bool isRepeatable();
		bool isChunked();
		bool isStreaming();
		void consumeContent();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.HttpEntity))]
	internal sealed partial class HttpEntity_ : java.lang.Object, HttpEntity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpEntity_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.io.InputStream org.apache.http.HttpEntity.getContent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.HttpEntity_.staticClass, "getContent", "()Ljava/io/InputStream;", ref global::org.apache.http.HttpEntity_._m0) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void org.apache.http.HttpEntity.writeTo(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpEntity_.staticClass, "writeTo", "(Ljava/io/OutputStream;)V", ref global::org.apache.http.HttpEntity_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::org.apache.http.Header org.apache.http.HttpEntity.getContentType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.HttpEntity_.staticClass, "getContentType", "()Lorg/apache/http/Header;", ref global::org.apache.http.HttpEntity_._m2) as org.apache.http.Header;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		long org.apache.http.HttpEntity.getContentLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.apache.http.HttpEntity_.staticClass, "getContentLength", "()J", ref global::org.apache.http.HttpEntity_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::org.apache.http.Header org.apache.http.HttpEntity.getContentEncoding()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.HttpEntity_.staticClass, "getContentEncoding", "()Lorg/apache/http/Header;", ref global::org.apache.http.HttpEntity_._m4) as org.apache.http.Header;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		bool org.apache.http.HttpEntity.isRepeatable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.HttpEntity_.staticClass, "isRepeatable", "()Z", ref global::org.apache.http.HttpEntity_._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		bool org.apache.http.HttpEntity.isChunked()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.HttpEntity_.staticClass, "isChunked", "()Z", ref global::org.apache.http.HttpEntity_._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		bool org.apache.http.HttpEntity.isStreaming()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.HttpEntity_.staticClass, "isStreaming", "()Z", ref global::org.apache.http.HttpEntity_._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		void org.apache.http.HttpEntity.consumeContent()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpEntity_.staticClass, "consumeContent", "()V", ref global::org.apache.http.HttpEntity_._m8);
		}
		static HttpEntity_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpEntity_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpEntity"));
		}
		internal static void InitJNI()
		{
		}
	}
}
