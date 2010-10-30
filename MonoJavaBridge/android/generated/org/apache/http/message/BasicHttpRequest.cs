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
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::org.apache.http.ProtocolVersion getProtocolVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.BasicHttpRequest.staticClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", ref global::org.apache.http.message.BasicHttpRequest._m0) as org.apache.http.ProtocolVersion;
		}
		public new global::org.apache.http.RequestLine RequestLine
		{
			get
			{
				return getRequestLine();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::org.apache.http.RequestLine getRequestLine()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.RequestLine>(this, global::org.apache.http.message.BasicHttpRequest.staticClass, "getRequestLine", "()Lorg/apache/http/RequestLine;", ref global::org.apache.http.message.BasicHttpRequest._m1) as org.apache.http.RequestLine;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public BasicHttpRequest(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHttpRequest._m2.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHttpRequest._m2 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHttpRequest.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHttpRequest.staticClass, global::org.apache.http.message.BasicHttpRequest._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public BasicHttpRequest(java.lang.String arg0, java.lang.String arg1, org.apache.http.ProtocolVersion arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHttpRequest._m3.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHttpRequest._m3 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHttpRequest.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Lorg/apache/http/ProtocolVersion;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHttpRequest.staticClass, global::org.apache.http.message.BasicHttpRequest._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public BasicHttpRequest(org.apache.http.RequestLine arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHttpRequest._m4.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHttpRequest._m4 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHttpRequest.staticClass, "<init>", "(Lorg/apache/http/RequestLine;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHttpRequest.staticClass, global::org.apache.http.message.BasicHttpRequest._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
