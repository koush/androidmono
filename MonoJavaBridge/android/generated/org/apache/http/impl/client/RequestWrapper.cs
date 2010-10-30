namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RequestWrapper : org.apache.http.message.AbstractHttpMessage, org.apache.http.client.methods.HttpUriRequest
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RequestWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Method
		{
			get
			{
				return getMethod();
			}
			set
			{
				setMethod(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.String getMethod()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.client.RequestWrapper.staticClass, "getMethod", "()Ljava/lang/String;", ref global::org.apache.http.impl.client.RequestWrapper._m0) as java.lang.String;
		}
		public new global::org.apache.http.ProtocolVersion ProtocolVersion
		{
			get
			{
				return getProtocolVersion();
			}
			set
			{
				setProtocolVersion(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::org.apache.http.ProtocolVersion getProtocolVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.client.RequestWrapper.staticClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", ref global::org.apache.http.impl.client.RequestWrapper._m1) as org.apache.http.ProtocolVersion;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void setMethod(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.RequestWrapper.staticClass, "setMethod", "(Ljava/lang/String;)V", ref global::org.apache.http.impl.client.RequestWrapper._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.net.URI URI
		{
			get
			{
				return getURI();
			}
			set
			{
				setURI(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.net.URI getURI()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.URI>(this, global::org.apache.http.impl.client.RequestWrapper.staticClass, "getURI", "()Ljava/net/URI;", ref global::org.apache.http.impl.client.RequestWrapper._m3) as java.net.URI;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool isRepeatable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.client.RequestWrapper.staticClass, "isRepeatable", "()Z", ref global::org.apache.http.impl.client.RequestWrapper._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void abort()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.RequestWrapper.staticClass, "abort", "()V", ref global::org.apache.http.impl.client.RequestWrapper._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual bool isAborted()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.client.RequestWrapper.staticClass, "isAborted", "()Z", ref global::org.apache.http.impl.client.RequestWrapper._m6);
		}
		public new global::org.apache.http.RequestLine RequestLine
		{
			get
			{
				return getRequestLine();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::org.apache.http.RequestLine getRequestLine()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.RequestLine>(this, global::org.apache.http.impl.client.RequestWrapper.staticClass, "getRequestLine", "()Lorg/apache/http/RequestLine;", ref global::org.apache.http.impl.client.RequestWrapper._m7) as org.apache.http.RequestLine;
		}
		public new global::org.apache.http.HttpRequest Original
		{
			get
			{
				return getOriginal();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::org.apache.http.HttpRequest getOriginal()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpRequest>(this, global::org.apache.http.impl.client.RequestWrapper.staticClass, "getOriginal", "()Lorg/apache/http/HttpRequest;", ref global::org.apache.http.impl.client.RequestWrapper._m8) as org.apache.http.HttpRequest;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setURI(java.net.URI arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.RequestWrapper.staticClass, "setURI", "(Ljava/net/URI;)V", ref global::org.apache.http.impl.client.RequestWrapper._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void resetHeaders()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.RequestWrapper.staticClass, "resetHeaders", "()V", ref global::org.apache.http.impl.client.RequestWrapper._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setProtocolVersion(org.apache.http.ProtocolVersion arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.RequestWrapper.staticClass, "setProtocolVersion", "(Lorg/apache/http/ProtocolVersion;)V", ref global::org.apache.http.impl.client.RequestWrapper._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ExecCount
		{
			get
			{
				return getExecCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual int getExecCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.client.RequestWrapper.staticClass, "getExecCount", "()I", ref global::org.apache.http.impl.client.RequestWrapper._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void incrementExecCount()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.RequestWrapper.staticClass, "incrementExecCount", "()V", ref global::org.apache.http.impl.client.RequestWrapper._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public RequestWrapper(org.apache.http.HttpRequest arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.RequestWrapper._m14.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.RequestWrapper._m14 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RequestWrapper.staticClass, "<init>", "(Lorg/apache/http/HttpRequest;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.RequestWrapper.staticClass, global::org.apache.http.impl.client.RequestWrapper._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static RequestWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.RequestWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/RequestWrapper"));
		}
		internal static void InitJNI()
		{
		}
	}
}
