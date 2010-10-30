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
		internal static global::MonoJavaBridge.MethodId _getMethod32938;
		public virtual global::java.lang.String getMethod()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.client.RequestWrapper.staticClass, "getMethod", "()Ljava/lang/String;", ref global::org.apache.http.impl.client.RequestWrapper._getMethod32938) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getProtocolVersion32939;
		public override global::org.apache.http.ProtocolVersion getProtocolVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.client.RequestWrapper.staticClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", ref global::org.apache.http.impl.client.RequestWrapper._getProtocolVersion32939) as org.apache.http.ProtocolVersion;
		}
		internal static global::MonoJavaBridge.MethodId _setMethod32940;
		public virtual void setMethod(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.RequestWrapper.staticClass, "setMethod", "(Ljava/lang/String;)V", ref global::org.apache.http.impl.client.RequestWrapper._setMethod32940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getURI32941;
		public virtual global::java.net.URI getURI()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.URI>(this, global::org.apache.http.impl.client.RequestWrapper.staticClass, "getURI", "()Ljava/net/URI;", ref global::org.apache.http.impl.client.RequestWrapper._getURI32941) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _isRepeatable32942;
		public virtual bool isRepeatable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.client.RequestWrapper.staticClass, "isRepeatable", "()Z", ref global::org.apache.http.impl.client.RequestWrapper._isRepeatable32942);
		}
		internal static global::MonoJavaBridge.MethodId _abort32943;
		public virtual void abort()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.RequestWrapper.staticClass, "abort", "()V", ref global::org.apache.http.impl.client.RequestWrapper._abort32943);
		}
		internal static global::MonoJavaBridge.MethodId _isAborted32944;
		public virtual bool isAborted()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.client.RequestWrapper.staticClass, "isAborted", "()Z", ref global::org.apache.http.impl.client.RequestWrapper._isAborted32944);
		}
		public new global::org.apache.http.RequestLine RequestLine
		{
			get
			{
				return getRequestLine();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRequestLine32945;
		public virtual global::org.apache.http.RequestLine getRequestLine()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.RequestLine>(this, global::org.apache.http.impl.client.RequestWrapper.staticClass, "getRequestLine", "()Lorg/apache/http/RequestLine;", ref global::org.apache.http.impl.client.RequestWrapper._getRequestLine32945) as org.apache.http.RequestLine;
		}
		public new global::org.apache.http.HttpRequest Original
		{
			get
			{
				return getOriginal();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOriginal32946;
		public virtual global::org.apache.http.HttpRequest getOriginal()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpRequest>(this, global::org.apache.http.impl.client.RequestWrapper.staticClass, "getOriginal", "()Lorg/apache/http/HttpRequest;", ref global::org.apache.http.impl.client.RequestWrapper._getOriginal32946) as org.apache.http.HttpRequest;
		}
		internal static global::MonoJavaBridge.MethodId _setURI32947;
		public virtual void setURI(java.net.URI arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.RequestWrapper.staticClass, "setURI", "(Ljava/net/URI;)V", ref global::org.apache.http.impl.client.RequestWrapper._setURI32947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _resetHeaders32948;
		public virtual void resetHeaders()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.RequestWrapper.staticClass, "resetHeaders", "()V", ref global::org.apache.http.impl.client.RequestWrapper._resetHeaders32948);
		}
		internal static global::MonoJavaBridge.MethodId _setProtocolVersion32949;
		public virtual void setProtocolVersion(org.apache.http.ProtocolVersion arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.RequestWrapper.staticClass, "setProtocolVersion", "(Lorg/apache/http/ProtocolVersion;)V", ref global::org.apache.http.impl.client.RequestWrapper._setProtocolVersion32949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ExecCount
		{
			get
			{
				return getExecCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExecCount32950;
		public virtual int getExecCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.client.RequestWrapper.staticClass, "getExecCount", "()I", ref global::org.apache.http.impl.client.RequestWrapper._getExecCount32950);
		}
		internal static global::MonoJavaBridge.MethodId _incrementExecCount32951;
		public virtual void incrementExecCount()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.RequestWrapper.staticClass, "incrementExecCount", "()V", ref global::org.apache.http.impl.client.RequestWrapper._incrementExecCount32951);
		}
		internal static global::MonoJavaBridge.MethodId _RequestWrapper32952;
		public RequestWrapper(org.apache.http.HttpRequest arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.RequestWrapper._RequestWrapper32952.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.RequestWrapper._RequestWrapper32952 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RequestWrapper.staticClass, "<init>", "(Lorg/apache/http/HttpRequest;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.RequestWrapper.staticClass, global::org.apache.http.impl.client.RequestWrapper._RequestWrapper32952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
