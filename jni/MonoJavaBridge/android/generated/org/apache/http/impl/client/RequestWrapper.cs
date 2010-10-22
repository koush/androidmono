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
		internal static global::MonoJavaBridge.MethodId _getMethod32819;
		public virtual global::java.lang.String getMethod() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper._getMethod32819)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper.staticClass, global::org.apache.http.impl.client.RequestWrapper._getMethod32819)) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getProtocolVersion32820;
		public override global::org.apache.http.ProtocolVersion getProtocolVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper._getProtocolVersion32820)) as org.apache.http.ProtocolVersion;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper.staticClass, global::org.apache.http.impl.client.RequestWrapper._getProtocolVersion32820)) as org.apache.http.ProtocolVersion;
		}
		internal static global::MonoJavaBridge.MethodId _setMethod32821;
		public virtual void setMethod(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper._setMethod32821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper.staticClass, global::org.apache.http.impl.client.RequestWrapper._setMethod32821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getURI32822;
		public virtual global::java.net.URI getURI() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URI>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper._getURI32822)) as java.net.URI;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URI>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper.staticClass, global::org.apache.http.impl.client.RequestWrapper._getURI32822)) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _isRepeatable32823;
		public virtual bool isRepeatable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper._isRepeatable32823);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper.staticClass, global::org.apache.http.impl.client.RequestWrapper._isRepeatable32823);
		}
		internal static global::MonoJavaBridge.MethodId _abort32824;
		public virtual void abort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper._abort32824);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper.staticClass, global::org.apache.http.impl.client.RequestWrapper._abort32824);
		}
		internal static global::MonoJavaBridge.MethodId _isAborted32825;
		public virtual bool isAborted() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper._isAborted32825);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper.staticClass, global::org.apache.http.impl.client.RequestWrapper._isAborted32825);
		}
		public new global::org.apache.http.RequestLine RequestLine
		{
			get
			{
				return getRequestLine();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRequestLine32826;
		public virtual global::org.apache.http.RequestLine getRequestLine() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.RequestLine>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper._getRequestLine32826)) as org.apache.http.RequestLine;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.RequestLine>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper.staticClass, global::org.apache.http.impl.client.RequestWrapper._getRequestLine32826)) as org.apache.http.RequestLine;
		}
		public new global::org.apache.http.HttpRequest Original
		{
			get
			{
				return getOriginal();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOriginal32827;
		public virtual global::org.apache.http.HttpRequest getOriginal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequest>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper._getOriginal32827)) as org.apache.http.HttpRequest;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequest>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper.staticClass, global::org.apache.http.impl.client.RequestWrapper._getOriginal32827)) as org.apache.http.HttpRequest;
		}
		internal static global::MonoJavaBridge.MethodId _setURI32828;
		public virtual void setURI(java.net.URI arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper._setURI32828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper.staticClass, global::org.apache.http.impl.client.RequestWrapper._setURI32828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _resetHeaders32829;
		public virtual void resetHeaders() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper._resetHeaders32829);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper.staticClass, global::org.apache.http.impl.client.RequestWrapper._resetHeaders32829);
		}
		internal static global::MonoJavaBridge.MethodId _setProtocolVersion32830;
		public virtual void setProtocolVersion(org.apache.http.ProtocolVersion arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper._setProtocolVersion32830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper.staticClass, global::org.apache.http.impl.client.RequestWrapper._setProtocolVersion32830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ExecCount
		{
			get
			{
				return getExecCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExecCount32831;
		public virtual int getExecCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper._getExecCount32831);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper.staticClass, global::org.apache.http.impl.client.RequestWrapper._getExecCount32831);
		}
		internal static global::MonoJavaBridge.MethodId _incrementExecCount32832;
		public virtual void incrementExecCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper._incrementExecCount32832);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.RequestWrapper.staticClass, global::org.apache.http.impl.client.RequestWrapper._incrementExecCount32832);
		}
		internal static global::MonoJavaBridge.MethodId _RequestWrapper32833;
		public RequestWrapper(org.apache.http.HttpRequest arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.RequestWrapper.staticClass, global::org.apache.http.impl.client.RequestWrapper._RequestWrapper32833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.RequestWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/RequestWrapper"));
			global::org.apache.http.impl.client.RequestWrapper._getMethod32819 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RequestWrapper.staticClass, "getMethod", "()Ljava/lang/String;");
			global::org.apache.http.impl.client.RequestWrapper._getProtocolVersion32820 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RequestWrapper.staticClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;");
			global::org.apache.http.impl.client.RequestWrapper._setMethod32821 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RequestWrapper.staticClass, "setMethod", "(Ljava/lang/String;)V");
			global::org.apache.http.impl.client.RequestWrapper._getURI32822 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RequestWrapper.staticClass, "getURI", "()Ljava/net/URI;");
			global::org.apache.http.impl.client.RequestWrapper._isRepeatable32823 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RequestWrapper.staticClass, "isRepeatable", "()Z");
			global::org.apache.http.impl.client.RequestWrapper._abort32824 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RequestWrapper.staticClass, "abort", "()V");
			global::org.apache.http.impl.client.RequestWrapper._isAborted32825 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RequestWrapper.staticClass, "isAborted", "()Z");
			global::org.apache.http.impl.client.RequestWrapper._getRequestLine32826 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RequestWrapper.staticClass, "getRequestLine", "()Lorg/apache/http/RequestLine;");
			global::org.apache.http.impl.client.RequestWrapper._getOriginal32827 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RequestWrapper.staticClass, "getOriginal", "()Lorg/apache/http/HttpRequest;");
			global::org.apache.http.impl.client.RequestWrapper._setURI32828 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RequestWrapper.staticClass, "setURI", "(Ljava/net/URI;)V");
			global::org.apache.http.impl.client.RequestWrapper._resetHeaders32829 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RequestWrapper.staticClass, "resetHeaders", "()V");
			global::org.apache.http.impl.client.RequestWrapper._setProtocolVersion32830 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RequestWrapper.staticClass, "setProtocolVersion", "(Lorg/apache/http/ProtocolVersion;)V");
			global::org.apache.http.impl.client.RequestWrapper._getExecCount32831 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RequestWrapper.staticClass, "getExecCount", "()I");
			global::org.apache.http.impl.client.RequestWrapper._incrementExecCount32832 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RequestWrapper.staticClass, "incrementExecCount", "()V");
			global::org.apache.http.impl.client.RequestWrapper._RequestWrapper32833 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RequestWrapper.staticClass, "<init>", "(Lorg/apache/http/HttpRequest;)V");
		}
	}
}
