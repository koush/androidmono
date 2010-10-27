namespace org.apache.http.impl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.impl.AbstractHttpClientConnection_))]
	public abstract partial class AbstractHttpClientConnection : java.lang.Object, HttpClientConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractHttpClientConnection()
		{
			InitJNI();
		}
		protected AbstractHttpClientConnection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _shutdown32577;
		public abstract void shutdown();
		internal static global::MonoJavaBridge.MethodId _close32578;
		public abstract void close();
		internal static global::MonoJavaBridge.MethodId _isOpen32579;
		public abstract bool isOpen();
		internal static global::MonoJavaBridge.MethodId _setSocketTimeout32580;
		public abstract void setSocketTimeout(int arg0);
		internal static global::MonoJavaBridge.MethodId _getSocketTimeout32581;
		public abstract int getSocketTimeout();
		internal static global::MonoJavaBridge.MethodId _init32582;
		protected virtual void init(org.apache.http.io.SessionInputBuffer arg0, org.apache.http.io.SessionOutputBuffer arg1, org.apache.http.@params.HttpParams arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection._init32582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection._init32582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _flush32583;
		public virtual void flush()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection._flush32583);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection._flush32583);
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics32584;
		public virtual global::org.apache.http.HttpConnectionMetrics getMetrics()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection._getMetrics32584)) as org.apache.http.HttpConnectionMetrics;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection._getMetrics32584)) as org.apache.http.HttpConnectionMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _isResponseAvailable32585;
		public virtual bool isResponseAvailable(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection._isResponseAvailable32585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection._isResponseAvailable32585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendRequestHeader32586;
		public virtual void sendRequestHeader(org.apache.http.HttpRequest arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection._sendRequestHeader32586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection._sendRequestHeader32586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendRequestEntity32587;
		public virtual void sendRequestEntity(org.apache.http.HttpEntityEnclosingRequest arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection._sendRequestEntity32587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection._sendRequestEntity32587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _receiveResponseHeader32588;
		public virtual global::org.apache.http.HttpResponse receiveResponseHeader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection._receiveResponseHeader32588)) as org.apache.http.HttpResponse;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection._receiveResponseHeader32588)) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _receiveResponseEntity32589;
		public virtual void receiveResponseEntity(org.apache.http.HttpResponse arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection._receiveResponseEntity32589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection._receiveResponseEntity32589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isStale32590;
		public virtual bool isStale()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection._isStale32590);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection._isStale32590);
		}
		internal static global::MonoJavaBridge.MethodId _assertOpen32591;
		protected abstract void assertOpen();
		internal static global::MonoJavaBridge.MethodId _createEntityDeserializer32592;
		protected virtual global::org.apache.http.impl.entity.EntityDeserializer createEntityDeserializer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection._createEntityDeserializer32592)) as org.apache.http.impl.entity.EntityDeserializer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection._createEntityDeserializer32592)) as org.apache.http.impl.entity.EntityDeserializer;
		}
		internal static global::MonoJavaBridge.MethodId _createEntitySerializer32593;
		protected virtual global::org.apache.http.impl.entity.EntitySerializer createEntitySerializer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection._createEntitySerializer32593)) as org.apache.http.impl.entity.EntitySerializer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection._createEntitySerializer32593)) as org.apache.http.impl.entity.EntitySerializer;
		}
		internal static global::MonoJavaBridge.MethodId _createHttpResponseFactory32594;
		protected virtual global::org.apache.http.HttpResponseFactory createHttpResponseFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponseFactory>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection._createHttpResponseFactory32594)) as org.apache.http.HttpResponseFactory;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponseFactory>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection._createHttpResponseFactory32594)) as org.apache.http.HttpResponseFactory;
		}
		internal static global::MonoJavaBridge.MethodId _createResponseParser32595;
		protected virtual global::org.apache.http.io.HttpMessageParser createResponseParser(org.apache.http.io.SessionInputBuffer arg0, org.apache.http.HttpResponseFactory arg1, org.apache.http.@params.HttpParams arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpMessageParser>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection._createResponseParser32595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.HttpMessageParser;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpMessageParser>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection._createResponseParser32595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.HttpMessageParser;
		}
		internal static global::MonoJavaBridge.MethodId _createRequestWriter32596;
		protected virtual global::org.apache.http.io.HttpMessageWriter createRequestWriter(org.apache.http.io.SessionOutputBuffer arg0, org.apache.http.@params.HttpParams arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpMessageWriter>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection._createRequestWriter32596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.io.HttpMessageWriter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpMessageWriter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection._createRequestWriter32596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.io.HttpMessageWriter;
		}
		internal static global::MonoJavaBridge.MethodId _doFlush32597;
		protected virtual void doFlush()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection._doFlush32597);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection._doFlush32597);
		}
		internal static global::MonoJavaBridge.MethodId _AbstractHttpClientConnection32598;
		public AbstractHttpClientConnection() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.AbstractHttpClientConnection.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection._AbstractHttpClientConnection32598);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.AbstractHttpClientConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/AbstractHttpClientConnection"));
			global::org.apache.http.impl.AbstractHttpClientConnection._shutdown32577 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "shutdown", "()V");
			global::org.apache.http.impl.AbstractHttpClientConnection._close32578 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "close", "()V");
			global::org.apache.http.impl.AbstractHttpClientConnection._isOpen32579 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "isOpen", "()Z");
			global::org.apache.http.impl.AbstractHttpClientConnection._setSocketTimeout32580 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "setSocketTimeout", "(I)V");
			global::org.apache.http.impl.AbstractHttpClientConnection._getSocketTimeout32581 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "getSocketTimeout", "()I");
			global::org.apache.http.impl.AbstractHttpClientConnection._init32582 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "init", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/io/SessionOutputBuffer;Lorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.impl.AbstractHttpClientConnection._flush32583 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "flush", "()V");
			global::org.apache.http.impl.AbstractHttpClientConnection._getMetrics32584 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;");
			global::org.apache.http.impl.AbstractHttpClientConnection._isResponseAvailable32585 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "isResponseAvailable", "(I)Z");
			global::org.apache.http.impl.AbstractHttpClientConnection._sendRequestHeader32586 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "sendRequestHeader", "(Lorg/apache/http/HttpRequest;)V");
			global::org.apache.http.impl.AbstractHttpClientConnection._sendRequestEntity32587 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "sendRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V");
			global::org.apache.http.impl.AbstractHttpClientConnection._receiveResponseHeader32588 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "receiveResponseHeader", "()Lorg/apache/http/HttpResponse;");
			global::org.apache.http.impl.AbstractHttpClientConnection._receiveResponseEntity32589 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "receiveResponseEntity", "(Lorg/apache/http/HttpResponse;)V");
			global::org.apache.http.impl.AbstractHttpClientConnection._isStale32590 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "isStale", "()Z");
			global::org.apache.http.impl.AbstractHttpClientConnection._assertOpen32591 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "assertOpen", "()V");
			global::org.apache.http.impl.AbstractHttpClientConnection._createEntityDeserializer32592 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "createEntityDeserializer", "()Lorg/apache/http/impl/entity/EntityDeserializer;");
			global::org.apache.http.impl.AbstractHttpClientConnection._createEntitySerializer32593 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "createEntitySerializer", "()Lorg/apache/http/impl/entity/EntitySerializer;");
			global::org.apache.http.impl.AbstractHttpClientConnection._createHttpResponseFactory32594 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "createHttpResponseFactory", "()Lorg/apache/http/HttpResponseFactory;");
			global::org.apache.http.impl.AbstractHttpClientConnection._createResponseParser32595 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "createResponseParser", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/HttpResponseFactory;Lorg/apache/http/params/HttpParams;)Lorg/apache/http/io/HttpMessageParser;");
			global::org.apache.http.impl.AbstractHttpClientConnection._createRequestWriter32596 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "createRequestWriter", "(Lorg/apache/http/io/SessionOutputBuffer;Lorg/apache/http/params/HttpParams;)Lorg/apache/http/io/HttpMessageWriter;");
			global::org.apache.http.impl.AbstractHttpClientConnection._doFlush32597 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "doFlush", "()V");
			global::org.apache.http.impl.AbstractHttpClientConnection._AbstractHttpClientConnection32598 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.AbstractHttpClientConnection))]
	internal sealed partial class AbstractHttpClientConnection_ : org.apache.http.impl.AbstractHttpClientConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractHttpClientConnection_()
		{
			InitJNI();
		}
		internal AbstractHttpClientConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _shutdown32599;
		public override void shutdown()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection_._shutdown32599);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection_.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection_._shutdown32599);
		}
		internal static global::MonoJavaBridge.MethodId _close32600;
		public override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection_._close32600);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection_.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection_._close32600);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen32601;
		public override bool isOpen()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection_._isOpen32601);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection_.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection_._isOpen32601);
		}
		internal static global::MonoJavaBridge.MethodId _setSocketTimeout32602;
		public override void setSocketTimeout(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection_._setSocketTimeout32602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection_.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection_._setSocketTimeout32602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSocketTimeout32603;
		public override int getSocketTimeout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection_._getSocketTimeout32603);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection_.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection_._getSocketTimeout32603);
		}
		internal static global::MonoJavaBridge.MethodId _assertOpen32604;
		protected override void assertOpen()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection_._assertOpen32604);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection_.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection_._assertOpen32604);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.AbstractHttpClientConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/AbstractHttpClientConnection"));
			global::org.apache.http.impl.AbstractHttpClientConnection_._shutdown32599 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection_.staticClass, "shutdown", "()V");
			global::org.apache.http.impl.AbstractHttpClientConnection_._close32600 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection_.staticClass, "close", "()V");
			global::org.apache.http.impl.AbstractHttpClientConnection_._isOpen32601 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection_.staticClass, "isOpen", "()Z");
			global::org.apache.http.impl.AbstractHttpClientConnection_._setSocketTimeout32602 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection_.staticClass, "setSocketTimeout", "(I)V");
			global::org.apache.http.impl.AbstractHttpClientConnection_._getSocketTimeout32603 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection_.staticClass, "getSocketTimeout", "()I");
			global::org.apache.http.impl.AbstractHttpClientConnection_._assertOpen32604 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection_.staticClass, "assertOpen", "()V");
		}
	}
}
