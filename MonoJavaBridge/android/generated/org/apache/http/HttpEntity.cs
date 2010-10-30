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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpEntity_._getContent31542.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpEntity_._getContent31542 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntity_.staticClass, "getContent", "()Ljava/io/InputStream;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpEntity_._getContent31542)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _writeTo31543;
		void org.apache.http.HttpEntity.writeTo(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpEntity_._writeTo31543.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpEntity_._writeTo31543 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntity_.staticClass, "writeTo", "(Ljava/io/OutputStream;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpEntity_._writeTo31543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getContentType31544;
		global::org.apache.http.Header org.apache.http.HttpEntity.getContentType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpEntity_._getContentType31544.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpEntity_._getContentType31544 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntity_.staticClass, "getContentType", "()Lorg/apache/http/Header;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpEntity_._getContentType31544)) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _getContentLength31545;
		long org.apache.http.HttpEntity.getContentLength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpEntity_._getContentLength31545.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpEntity_._getContentLength31545 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntity_.staticClass, "getContentLength", "()J");
			return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.HttpEntity_._getContentLength31545);
		}
		internal static global::MonoJavaBridge.MethodId _getContentEncoding31546;
		global::org.apache.http.Header org.apache.http.HttpEntity.getContentEncoding()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpEntity_._getContentEncoding31546.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpEntity_._getContentEncoding31546 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntity_.staticClass, "getContentEncoding", "()Lorg/apache/http/Header;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpEntity_._getContentEncoding31546)) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _isRepeatable31547;
		bool org.apache.http.HttpEntity.isRepeatable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpEntity_._isRepeatable31547.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpEntity_._isRepeatable31547 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntity_.staticClass, "isRepeatable", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.HttpEntity_._isRepeatable31547);
		}
		internal static global::MonoJavaBridge.MethodId _isChunked31548;
		bool org.apache.http.HttpEntity.isChunked()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpEntity_._isChunked31548.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpEntity_._isChunked31548 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntity_.staticClass, "isChunked", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.HttpEntity_._isChunked31548);
		}
		internal static global::MonoJavaBridge.MethodId _isStreaming31549;
		bool org.apache.http.HttpEntity.isStreaming()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpEntity_._isStreaming31549.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpEntity_._isStreaming31549 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntity_.staticClass, "isStreaming", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.HttpEntity_._isStreaming31549);
		}
		internal static global::MonoJavaBridge.MethodId _consumeContent31550;
		void org.apache.http.HttpEntity.consumeContent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpEntity_._consumeContent31550.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpEntity_._consumeContent31550 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntity_.staticClass, "consumeContent", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpEntity_._consumeContent31550);
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
