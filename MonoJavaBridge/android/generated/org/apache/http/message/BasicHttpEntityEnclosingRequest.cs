namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicHttpEntityEnclosingRequest : org.apache.http.message.BasicHttpRequest, HttpEntityEnclosingRequest
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicHttpEntityEnclosingRequest(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::org.apache.http.HttpEntity Entity
		{
			get
			{
				return getEntity();
			}
			set
			{
				setEntity(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::org.apache.http.HttpEntity getEntity()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpEntity>(this, global::org.apache.http.message.BasicHttpEntityEnclosingRequest.staticClass, "getEntity", "()Lorg/apache/http/HttpEntity;", ref global::org.apache.http.message.BasicHttpEntityEnclosingRequest._m0) as org.apache.http.HttpEntity;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void setEntity(org.apache.http.HttpEntity arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.BasicHttpEntityEnclosingRequest.staticClass, "setEntity", "(Lorg/apache/http/HttpEntity;)V", ref global::org.apache.http.message.BasicHttpEntityEnclosingRequest._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual bool expectContinue()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.message.BasicHttpEntityEnclosingRequest.staticClass, "expectContinue", "()Z", ref global::org.apache.http.message.BasicHttpEntityEnclosingRequest._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public BasicHttpEntityEnclosingRequest(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHttpEntityEnclosingRequest._m3.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHttpEntityEnclosingRequest._m3 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHttpEntityEnclosingRequest.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHttpEntityEnclosingRequest.staticClass, global::org.apache.http.message.BasicHttpEntityEnclosingRequest._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public BasicHttpEntityEnclosingRequest(java.lang.String arg0, java.lang.String arg1, org.apache.http.ProtocolVersion arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHttpEntityEnclosingRequest._m4.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHttpEntityEnclosingRequest._m4 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHttpEntityEnclosingRequest.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Lorg/apache/http/ProtocolVersion;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHttpEntityEnclosingRequest.staticClass, global::org.apache.http.message.BasicHttpEntityEnclosingRequest._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public BasicHttpEntityEnclosingRequest(org.apache.http.RequestLine arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHttpEntityEnclosingRequest._m5.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHttpEntityEnclosingRequest._m5 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHttpEntityEnclosingRequest.staticClass, "<init>", "(Lorg/apache/http/RequestLine;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHttpEntityEnclosingRequest.staticClass, global::org.apache.http.message.BasicHttpEntityEnclosingRequest._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static BasicHttpEntityEnclosingRequest()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicHttpEntityEnclosingRequest.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicHttpEntityEnclosingRequest"));
		}
		internal static void InitJNI()
		{
		}
	}
}
