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
		internal static global::MonoJavaBridge.MethodId _getContent31542;
		global::java.io.InputStream org.apache.http.HttpEntity.getContent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.HttpEntity_.staticClass, "getContent", "()Ljava/io/InputStream;", ref global::org.apache.http.HttpEntity_._getContent31542) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _writeTo31543;
		void org.apache.http.HttpEntity.writeTo(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpEntity_.staticClass, "writeTo", "(Ljava/io/OutputStream;)V", ref global::org.apache.http.HttpEntity_._writeTo31543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getContentType31544;
		global::org.apache.http.Header org.apache.http.HttpEntity.getContentType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.HttpEntity_.staticClass, "getContentType", "()Lorg/apache/http/Header;", ref global::org.apache.http.HttpEntity_._getContentType31544) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _getContentLength31545;
		long org.apache.http.HttpEntity.getContentLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.apache.http.HttpEntity_.staticClass, "getContentLength", "()J", ref global::org.apache.http.HttpEntity_._getContentLength31545);
		}
		internal static global::MonoJavaBridge.MethodId _getContentEncoding31546;
		global::org.apache.http.Header org.apache.http.HttpEntity.getContentEncoding()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.HttpEntity_.staticClass, "getContentEncoding", "()Lorg/apache/http/Header;", ref global::org.apache.http.HttpEntity_._getContentEncoding31546) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _isRepeatable31547;
		bool org.apache.http.HttpEntity.isRepeatable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.HttpEntity_.staticClass, "isRepeatable", "()Z", ref global::org.apache.http.HttpEntity_._isRepeatable31547);
		}
		internal static global::MonoJavaBridge.MethodId _isChunked31548;
		bool org.apache.http.HttpEntity.isChunked()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.HttpEntity_.staticClass, "isChunked", "()Z", ref global::org.apache.http.HttpEntity_._isChunked31548);
		}
		internal static global::MonoJavaBridge.MethodId _isStreaming31549;
		bool org.apache.http.HttpEntity.isStreaming()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.HttpEntity_.staticClass, "isStreaming", "()Z", ref global::org.apache.http.HttpEntity_._isStreaming31549);
		}
		internal static global::MonoJavaBridge.MethodId _consumeContent31550;
		void org.apache.http.HttpEntity.consumeContent()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpEntity_.staticClass, "consumeContent", "()V", ref global::org.apache.http.HttpEntity_._consumeContent31550);
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
