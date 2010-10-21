namespace org.apache.http.impl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.impl.AbstractHttpServerConnection_))]
	public abstract partial class AbstractHttpServerConnection : java.lang.Object, HttpServerConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractHttpServerConnection()
		{
			InitJNI();
		}
		protected AbstractHttpServerConnection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _shutdown32487;
		public abstract void shutdown();
		internal static global::MonoJavaBridge.MethodId _close32488;
		public abstract void close();
		internal static global::MonoJavaBridge.MethodId _isOpen32489;
		public abstract bool isOpen();
		internal static global::MonoJavaBridge.MethodId _setSocketTimeout32490;
		public abstract void setSocketTimeout(int arg0);
		internal static global::MonoJavaBridge.MethodId _getSocketTimeout32491;
		public abstract int getSocketTimeout();
		internal static global::MonoJavaBridge.MethodId _init32492;
		protected virtual void init(org.apache.http.io.SessionInputBuffer arg0, org.apache.http.io.SessionOutputBuffer arg1, org.apache.http.@params.HttpParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection._init32492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection._init32492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _flush32493;
		public virtual void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection._flush32493);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection._flush32493);
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics32494;
		public virtual global::org.apache.http.HttpConnectionMetrics getMetrics() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection._getMetrics32494)) as org.apache.http.HttpConnectionMetrics;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection._getMetrics32494)) as org.apache.http.HttpConnectionMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _isStale32495;
		public virtual bool isStale() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection._isStale32495);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection._isStale32495);
		}
		internal static global::MonoJavaBridge.MethodId _receiveRequestHeader32496;
		public virtual global::org.apache.http.HttpRequest receiveRequestHeader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequest>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection._receiveRequestHeader32496)) as org.apache.http.HttpRequest;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequest>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection._receiveRequestHeader32496)) as org.apache.http.HttpRequest;
		}
		internal static global::MonoJavaBridge.MethodId _receiveRequestEntity32497;
		public virtual void receiveRequestEntity(org.apache.http.HttpEntityEnclosingRequest arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection._receiveRequestEntity32497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection._receiveRequestEntity32497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendResponseHeader32498;
		public virtual void sendResponseHeader(org.apache.http.HttpResponse arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection._sendResponseHeader32498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection._sendResponseHeader32498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendResponseEntity32499;
		public virtual void sendResponseEntity(org.apache.http.HttpResponse arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection._sendResponseEntity32499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection._sendResponseEntity32499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _assertOpen32500;
		protected abstract void assertOpen();
		internal static global::MonoJavaBridge.MethodId _createEntityDeserializer32501;
		protected virtual global::org.apache.http.impl.entity.EntityDeserializer createEntityDeserializer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection._createEntityDeserializer32501)) as org.apache.http.impl.entity.EntityDeserializer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection._createEntityDeserializer32501)) as org.apache.http.impl.entity.EntityDeserializer;
		}
		internal static global::MonoJavaBridge.MethodId _createEntitySerializer32502;
		protected virtual global::org.apache.http.impl.entity.EntitySerializer createEntitySerializer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection._createEntitySerializer32502)) as org.apache.http.impl.entity.EntitySerializer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection._createEntitySerializer32502)) as org.apache.http.impl.entity.EntitySerializer;
		}
		internal static global::MonoJavaBridge.MethodId _doFlush32503;
		protected virtual void doFlush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection._doFlush32503);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection._doFlush32503);
		}
		internal static global::MonoJavaBridge.MethodId _createHttpRequestFactory32504;
		protected virtual global::org.apache.http.HttpRequestFactory createHttpRequestFactory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequestFactory>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection._createHttpRequestFactory32504)) as org.apache.http.HttpRequestFactory;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequestFactory>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection._createHttpRequestFactory32504)) as org.apache.http.HttpRequestFactory;
		}
		internal static global::MonoJavaBridge.MethodId _createRequestParser32505;
		protected virtual global::org.apache.http.io.HttpMessageParser createRequestParser(org.apache.http.io.SessionInputBuffer arg0, org.apache.http.HttpRequestFactory arg1, org.apache.http.@params.HttpParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpMessageParser>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection._createRequestParser32505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.HttpMessageParser;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpMessageParser>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection._createRequestParser32505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.HttpMessageParser;
		}
		internal static global::MonoJavaBridge.MethodId _createResponseWriter32506;
		protected virtual global::org.apache.http.io.HttpMessageWriter createResponseWriter(org.apache.http.io.SessionOutputBuffer arg0, org.apache.http.@params.HttpParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpMessageWriter>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection._createResponseWriter32506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.io.HttpMessageWriter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpMessageWriter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection._createResponseWriter32506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.io.HttpMessageWriter;
		}
		internal static global::MonoJavaBridge.MethodId _AbstractHttpServerConnection32507;
		public AbstractHttpServerConnection()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.AbstractHttpServerConnection.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection._AbstractHttpServerConnection32507);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.AbstractHttpServerConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/AbstractHttpServerConnection"));
			global::org.apache.http.impl.AbstractHttpServerConnection._shutdown32487 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "shutdown", "()V");
			global::org.apache.http.impl.AbstractHttpServerConnection._close32488 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "close", "()V");
			global::org.apache.http.impl.AbstractHttpServerConnection._isOpen32489 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "isOpen", "()Z");
			global::org.apache.http.impl.AbstractHttpServerConnection._setSocketTimeout32490 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "setSocketTimeout", "(I)V");
			global::org.apache.http.impl.AbstractHttpServerConnection._getSocketTimeout32491 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "getSocketTimeout", "()I");
			global::org.apache.http.impl.AbstractHttpServerConnection._init32492 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "init", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/io/SessionOutputBuffer;Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.impl.AbstractHttpServerConnection._flush32493 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "flush", "()V");
			global::org.apache.http.impl.AbstractHttpServerConnection._getMetrics32494 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;");
			global::org.apache.http.impl.AbstractHttpServerConnection._isStale32495 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "isStale", "()Z");
			global::org.apache.http.impl.AbstractHttpServerConnection._receiveRequestHeader32496 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "receiveRequestHeader", "()Lorg/apache/http/HttpRequest;");
			global::org.apache.http.impl.AbstractHttpServerConnection._receiveRequestEntity32497 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "receiveRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V");
			global::org.apache.http.impl.AbstractHttpServerConnection._sendResponseHeader32498 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "sendResponseHeader", "(Lorg/apache/http/HttpResponse;)V");
			global::org.apache.http.impl.AbstractHttpServerConnection._sendResponseEntity32499 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "sendResponseEntity", "(Lorg/apache/http/HttpResponse;)V");
			global::org.apache.http.impl.AbstractHttpServerConnection._assertOpen32500 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "assertOpen", "()V");
			global::org.apache.http.impl.AbstractHttpServerConnection._createEntityDeserializer32501 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "createEntityDeserializer", "()Lorg/apache/http/impl/entity/EntityDeserializer;");
			global::org.apache.http.impl.AbstractHttpServerConnection._createEntitySerializer32502 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "createEntitySerializer", "()Lorg/apache/http/impl/entity/EntitySerializer;");
			global::org.apache.http.impl.AbstractHttpServerConnection._doFlush32503 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "doFlush", "()V");
			global::org.apache.http.impl.AbstractHttpServerConnection._createHttpRequestFactory32504 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "createHttpRequestFactory", "()Lorg/apache/http/HttpRequestFactory;");
			global::org.apache.http.impl.AbstractHttpServerConnection._createRequestParser32505 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "createRequestParser", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/HttpRequestFactory;Lorg/apache/http/@params/HttpParams;)Lorg/apache/http/io/HttpMessageParser;");
			global::org.apache.http.impl.AbstractHttpServerConnection._createResponseWriter32506 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "createResponseWriter", "(Lorg/apache/http/io/SessionOutputBuffer;Lorg/apache/http/@params/HttpParams;)Lorg/apache/http/io/HttpMessageWriter;");
			global::org.apache.http.impl.AbstractHttpServerConnection._AbstractHttpServerConnection32507 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.AbstractHttpServerConnection))]
	public sealed partial class AbstractHttpServerConnection_ : org.apache.http.impl.AbstractHttpServerConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractHttpServerConnection_()
		{
			InitJNI();
		}
		internal AbstractHttpServerConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _shutdown32508;
		public override void shutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection_._shutdown32508);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection_._shutdown32508);
		}
		internal static global::MonoJavaBridge.MethodId _close32509;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection_._close32509);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection_._close32509);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen32510;
		public override bool isOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection_._isOpen32510);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection_._isOpen32510);
		}
		internal static global::MonoJavaBridge.MethodId _setSocketTimeout32511;
		public override void setSocketTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection_._setSocketTimeout32511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection_._setSocketTimeout32511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSocketTimeout32512;
		public override int getSocketTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection_._getSocketTimeout32512);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection_._getSocketTimeout32512);
		}
		internal static global::MonoJavaBridge.MethodId _assertOpen32513;
		protected override void assertOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection_._assertOpen32513);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection_._assertOpen32513);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/AbstractHttpServerConnection"));
			global::org.apache.http.impl.AbstractHttpServerConnection_._shutdown32508 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass, "shutdown", "()V");
			global::org.apache.http.impl.AbstractHttpServerConnection_._close32509 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass, "close", "()V");
			global::org.apache.http.impl.AbstractHttpServerConnection_._isOpen32510 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass, "isOpen", "()Z");
			global::org.apache.http.impl.AbstractHttpServerConnection_._setSocketTimeout32511 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass, "setSocketTimeout", "(I)V");
			global::org.apache.http.impl.AbstractHttpServerConnection_._getSocketTimeout32512 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass, "getSocketTimeout", "()I");
			global::org.apache.http.impl.AbstractHttpServerConnection_._assertOpen32513 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass, "assertOpen", "()V");
		}
	}
}
