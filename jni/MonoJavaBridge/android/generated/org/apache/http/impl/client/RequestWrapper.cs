namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RequestWrapper : org.apache.http.message.AbstractHttpMessage, org.apache.http.client.methods.HttpUriRequest
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RequestWrapper()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getMethod26196;
		public virtual global::java.lang.String getMethod() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper._getMethod26196)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper.staticClass, global::org.apache.http.impl.client.RequestWrapper._getMethod26196)) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getProtocolVersion26197;
		public override global::org.apache.http.ProtocolVersion getProtocolVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper._getProtocolVersion26197)) as org.apache.http.ProtocolVersion;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper.staticClass, global::org.apache.http.impl.client.RequestWrapper._getProtocolVersion26197)) as org.apache.http.ProtocolVersion;
		}
		internal static global::MonoJavaBridge.MethodId _setMethod26198;
		public virtual void setMethod(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper._setMethod26198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper.staticClass, global::org.apache.http.impl.client.RequestWrapper._setMethod26198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getURI26199;
		public virtual global::java.net.URI getURI() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper._getURI26199)) as java.net.URI;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper.staticClass, global::org.apache.http.impl.client.RequestWrapper._getURI26199)) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _isRepeatable26200;
		public virtual bool isRepeatable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper._isRepeatable26200);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper.staticClass, global::org.apache.http.impl.client.RequestWrapper._isRepeatable26200);
		}
		internal static global::MonoJavaBridge.MethodId _abort26201;
		public virtual void abort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper._abort26201);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper.staticClass, global::org.apache.http.impl.client.RequestWrapper._abort26201);
		}
		internal static global::MonoJavaBridge.MethodId _isAborted26202;
		public virtual bool isAborted() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper._isAborted26202);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper.staticClass, global::org.apache.http.impl.client.RequestWrapper._isAborted26202);
		}
		public new global::org.apache.http.RequestLine RequestLine
		{
			get
			{
				return getRequestLine();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRequestLine26203;
		public virtual global::org.apache.http.RequestLine getRequestLine() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.RequestLine>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper._getRequestLine26203)) as org.apache.http.RequestLine;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.RequestLine>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper.staticClass, global::org.apache.http.impl.client.RequestWrapper._getRequestLine26203)) as org.apache.http.RequestLine;
		}
		public new global::org.apache.http.HttpRequest Original
		{
			get
			{
				return getOriginal();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOriginal26204;
		public virtual global::org.apache.http.HttpRequest getOriginal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequest>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper._getOriginal26204)) as org.apache.http.HttpRequest;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequest>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper.staticClass, global::org.apache.http.impl.client.RequestWrapper._getOriginal26204)) as org.apache.http.HttpRequest;
		}
		internal static global::MonoJavaBridge.MethodId _setURI26205;
		public virtual void setURI(java.net.URI arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper._setURI26205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper.staticClass, global::org.apache.http.impl.client.RequestWrapper._setURI26205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _resetHeaders26206;
		public virtual void resetHeaders() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper._resetHeaders26206);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper.staticClass, global::org.apache.http.impl.client.RequestWrapper._resetHeaders26206);
		}
		internal static global::MonoJavaBridge.MethodId _setProtocolVersion26207;
		public virtual void setProtocolVersion(org.apache.http.ProtocolVersion arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper._setProtocolVersion26207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper.staticClass, global::org.apache.http.impl.client.RequestWrapper._setProtocolVersion26207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ExecCount
		{
			get
			{
				return getExecCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExecCount26208;
		public virtual int getExecCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper._getExecCount26208);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper.staticClass, global::org.apache.http.impl.client.RequestWrapper._getExecCount26208);
		}
		internal static global::MonoJavaBridge.MethodId _incrementExecCount26209;
		public virtual void incrementExecCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper._incrementExecCount26209);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper.staticClass, global::org.apache.http.impl.client.RequestWrapper._incrementExecCount26209);
		}
		internal static global::MonoJavaBridge.MethodId _RequestWrapper26210;
		public RequestWrapper(org.apache.http.HttpRequest arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.RequestWrapper.staticClass, global::org.apache.http.impl.client.RequestWrapper._RequestWrapper26210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.RequestWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/RequestWrapper"));
			global::org.apache.http.impl.client.RequestWrapper._getMethod26196 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RequestWrapper.staticClass, "getMethod", "()Ljava/lang/String;");
			global::org.apache.http.impl.client.RequestWrapper._getProtocolVersion26197 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RequestWrapper.staticClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;");
			global::org.apache.http.impl.client.RequestWrapper._setMethod26198 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RequestWrapper.staticClass, "setMethod", "(Ljava/lang/String;)V");
			global::org.apache.http.impl.client.RequestWrapper._getURI26199 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RequestWrapper.staticClass, "getURI", "()Ljava/net/URI;");
			global::org.apache.http.impl.client.RequestWrapper._isRepeatable26200 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RequestWrapper.staticClass, "isRepeatable", "()Z");
			global::org.apache.http.impl.client.RequestWrapper._abort26201 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RequestWrapper.staticClass, "abort", "()V");
			global::org.apache.http.impl.client.RequestWrapper._isAborted26202 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RequestWrapper.staticClass, "isAborted", "()Z");
			global::org.apache.http.impl.client.RequestWrapper._getRequestLine26203 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RequestWrapper.staticClass, "getRequestLine", "()Lorg/apache/http/RequestLine;");
			global::org.apache.http.impl.client.RequestWrapper._getOriginal26204 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RequestWrapper.staticClass, "getOriginal", "()Lorg/apache/http/HttpRequest;");
			global::org.apache.http.impl.client.RequestWrapper._setURI26205 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RequestWrapper.staticClass, "setURI", "(Ljava/net/URI;)V");
			global::org.apache.http.impl.client.RequestWrapper._resetHeaders26206 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RequestWrapper.staticClass, "resetHeaders", "()V");
			global::org.apache.http.impl.client.RequestWrapper._setProtocolVersion26207 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RequestWrapper.staticClass, "setProtocolVersion", "(Lorg/apache/http/ProtocolVersion;)V");
			global::org.apache.http.impl.client.RequestWrapper._getExecCount26208 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RequestWrapper.staticClass, "getExecCount", "()I");
			global::org.apache.http.impl.client.RequestWrapper._incrementExecCount26209 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RequestWrapper.staticClass, "incrementExecCount", "()V");
			global::org.apache.http.impl.client.RequestWrapper._RequestWrapper26210 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RequestWrapper.staticClass, "<init>", "(Lorg/apache/http/HttpRequest;)V");
		}
	}
}
