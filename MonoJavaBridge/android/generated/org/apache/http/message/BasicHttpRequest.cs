namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicHttpRequest : org.apache.http.message.AbstractHttpMessage, HttpRequest
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicHttpRequest(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::org.apache.http.ProtocolVersion ProtocolVersion
		{
			get
			{
				return getProtocolVersion();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProtocolVersion33574;
		public override global::org.apache.http.ProtocolVersion getProtocolVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.BasicHttpRequest.staticClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", ref global::org.apache.http.message.BasicHttpRequest._getProtocolVersion33574) as org.apache.http.ProtocolVersion;
		}
		public new global::org.apache.http.RequestLine RequestLine
		{
			get
			{
				return getRequestLine();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRequestLine33575;
		public virtual global::org.apache.http.RequestLine getRequestLine()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.RequestLine>(this, global::org.apache.http.message.BasicHttpRequest.staticClass, "getRequestLine", "()Lorg/apache/http/RequestLine;", ref global::org.apache.http.message.BasicHttpRequest._getRequestLine33575) as org.apache.http.RequestLine;
		}
		internal static global::MonoJavaBridge.MethodId _BasicHttpRequest33576;
		public BasicHttpRequest(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHttpRequest._BasicHttpRequest33576.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHttpRequest._BasicHttpRequest33576 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHttpRequest.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHttpRequest.staticClass, global::org.apache.http.message.BasicHttpRequest._BasicHttpRequest33576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BasicHttpRequest33577;
		public BasicHttpRequest(java.lang.String arg0, java.lang.String arg1, org.apache.http.ProtocolVersion arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHttpRequest._BasicHttpRequest33577.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHttpRequest._BasicHttpRequest33577 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHttpRequest.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Lorg/apache/http/ProtocolVersion;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHttpRequest.staticClass, global::org.apache.http.message.BasicHttpRequest._BasicHttpRequest33577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BasicHttpRequest33578;
		public BasicHttpRequest(org.apache.http.RequestLine arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHttpRequest._BasicHttpRequest33578.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHttpRequest._BasicHttpRequest33578 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHttpRequest.staticClass, "<init>", "(Lorg/apache/http/RequestLine;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHttpRequest.staticClass, global::org.apache.http.message.BasicHttpRequest._BasicHttpRequest33578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static BasicHttpRequest()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicHttpRequest.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicHttpRequest"));
		}
		internal static void InitJNI()
		{
		}
	}
}
