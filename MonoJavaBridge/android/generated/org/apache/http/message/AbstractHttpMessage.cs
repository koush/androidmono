namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.message.AbstractHttpMessage_))]
	public abstract partial class AbstractHttpMessage : java.lang.Object, HttpMessage
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractHttpMessage(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getProtocolVersion33485;
		public abstract global::org.apache.http.ProtocolVersion getProtocolVersion();
		internal static global::MonoJavaBridge.MethodId _getParams33486;
		public virtual global::org.apache.http.@params.HttpParams getParams()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.AbstractHttpMessage.staticClass, global::org.apache.http.message.AbstractHttpMessage._getParams33486)) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _setParams33487;
		public virtual void setParams(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.AbstractHttpMessage.staticClass, global::org.apache.http.message.AbstractHttpMessage._setParams33487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHeaders33488;
		public virtual global::org.apache.http.Header[] getHeaders(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.AbstractHttpMessage.staticClass, global::org.apache.http.message.AbstractHttpMessage._getHeaders33488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header[];
		}
		internal static global::MonoJavaBridge.MethodId _containsHeader33489;
		public virtual bool containsHeader(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.message.AbstractHttpMessage.staticClass, global::org.apache.http.message.AbstractHttpMessage._containsHeader33489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFirstHeader33490;
		public virtual global::org.apache.http.Header getFirstHeader(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.AbstractHttpMessage.staticClass, global::org.apache.http.message.AbstractHttpMessage._getFirstHeader33490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _getLastHeader33491;
		public virtual global::org.apache.http.Header getLastHeader(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.AbstractHttpMessage.staticClass, global::org.apache.http.message.AbstractHttpMessage._getLastHeader33491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _getAllHeaders33492;
		public virtual global::org.apache.http.Header[] getAllHeaders()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.AbstractHttpMessage.staticClass, global::org.apache.http.message.AbstractHttpMessage._getAllHeaders33492)) as org.apache.http.Header[];
		}
		internal static global::MonoJavaBridge.MethodId _addHeader33493;
		public virtual void addHeader(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.AbstractHttpMessage.staticClass, global::org.apache.http.message.AbstractHttpMessage._addHeader33493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addHeader33494;
		public virtual void addHeader(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.AbstractHttpMessage.staticClass, global::org.apache.http.message.AbstractHttpMessage._addHeader33494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setHeader33495;
		public virtual void setHeader(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.AbstractHttpMessage.staticClass, global::org.apache.http.message.AbstractHttpMessage._setHeader33495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setHeader33496;
		public virtual void setHeader(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.AbstractHttpMessage.staticClass, global::org.apache.http.message.AbstractHttpMessage._setHeader33496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHeaders33497;
		public virtual void setHeaders(org.apache.http.Header[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.AbstractHttpMessage.staticClass, global::org.apache.http.message.AbstractHttpMessage._setHeaders33497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeHeader33498;
		public virtual void removeHeader(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.AbstractHttpMessage.staticClass, global::org.apache.http.message.AbstractHttpMessage._removeHeader33498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeHeaders33499;
		public virtual void removeHeaders(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.AbstractHttpMessage.staticClass, global::org.apache.http.message.AbstractHttpMessage._removeHeaders33499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _headerIterator33500;
		public virtual global::org.apache.http.HeaderIterator headerIterator()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.AbstractHttpMessage.staticClass, global::org.apache.http.message.AbstractHttpMessage._headerIterator33500)) as org.apache.http.HeaderIterator;
		}
		internal static global::MonoJavaBridge.MethodId _headerIterator33501;
		public virtual global::org.apache.http.HeaderIterator headerIterator(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.AbstractHttpMessage.staticClass, global::org.apache.http.message.AbstractHttpMessage._headerIterator33501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HeaderIterator;
		}
		internal static global::MonoJavaBridge.MethodId _AbstractHttpMessage33502;
		protected AbstractHttpMessage() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.AbstractHttpMessage.staticClass, global::org.apache.http.message.AbstractHttpMessage._AbstractHttpMessage33502);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AbstractHttpMessage33503;
		protected AbstractHttpMessage(org.apache.http.@params.HttpParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.AbstractHttpMessage.staticClass, global::org.apache.http.message.AbstractHttpMessage._AbstractHttpMessage33503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static AbstractHttpMessage()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.AbstractHttpMessage.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/AbstractHttpMessage"));
			global::org.apache.http.message.AbstractHttpMessage._getProtocolVersion33485 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;");
			global::org.apache.http.message.AbstractHttpMessage._getParams33486 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "getParams", "()Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.message.AbstractHttpMessage._setParams33487 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "setParams", "(Lorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.message.AbstractHttpMessage._getHeaders33488 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;");
			global::org.apache.http.message.AbstractHttpMessage._containsHeader33489 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "containsHeader", "(Ljava/lang/String;)Z");
			global::org.apache.http.message.AbstractHttpMessage._getFirstHeader33490 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;");
			global::org.apache.http.message.AbstractHttpMessage._getLastHeader33491 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;");
			global::org.apache.http.message.AbstractHttpMessage._getAllHeaders33492 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "getAllHeaders", "()[Lorg/apache/http/Header;");
			global::org.apache.http.message.AbstractHttpMessage._addHeader33493 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "addHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.message.AbstractHttpMessage._addHeader33494 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.message.AbstractHttpMessage._setHeader33495 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "setHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.message.AbstractHttpMessage._setHeader33496 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "setHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.message.AbstractHttpMessage._setHeaders33497 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "setHeaders", "([Lorg/apache/http/Header;)V");
			global::org.apache.http.message.AbstractHttpMessage._removeHeader33498 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "removeHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.message.AbstractHttpMessage._removeHeaders33499 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "removeHeaders", "(Ljava/lang/String;)V");
			global::org.apache.http.message.AbstractHttpMessage._headerIterator33500 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "headerIterator", "()Lorg/apache/http/HeaderIterator;");
			global::org.apache.http.message.AbstractHttpMessage._headerIterator33501 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "headerIterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;");
			global::org.apache.http.message.AbstractHttpMessage._AbstractHttpMessage33502 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "<init>", "()V");
			global::org.apache.http.message.AbstractHttpMessage._AbstractHttpMessage33503 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "<init>", "(Lorg/apache/http/params/HttpParams;)V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.message.AbstractHttpMessage))]
	internal sealed partial class AbstractHttpMessage_ : org.apache.http.message.AbstractHttpMessage
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractHttpMessage_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getProtocolVersion33504;
		public override global::org.apache.http.ProtocolVersion getProtocolVersion()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.AbstractHttpMessage_._getProtocolVersion33504)) as org.apache.http.ProtocolVersion;
		}
		static AbstractHttpMessage_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.AbstractHttpMessage_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/AbstractHttpMessage"));
			global::org.apache.http.message.AbstractHttpMessage_._getProtocolVersion33504 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage_.staticClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;");
		}
		internal static void InitJNI()
		{
		}
	}
}
