namespace org.apache.http.impl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.impl.AbstractHttpServerConnection_))]
	public abstract partial class AbstractHttpServerConnection : java.lang.Object, HttpServerConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractHttpServerConnection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _shutdown32606;
		public abstract void shutdown();
		internal static global::MonoJavaBridge.MethodId _close32607;
		public abstract void close();
		internal static global::MonoJavaBridge.MethodId _isOpen32608;
		public abstract bool isOpen();
		internal static global::MonoJavaBridge.MethodId _setSocketTimeout32609;
		public abstract void setSocketTimeout(int arg0);
		internal static global::MonoJavaBridge.MethodId _getSocketTimeout32610;
		public abstract int getSocketTimeout();
		internal static global::MonoJavaBridge.MethodId _init32611;
		protected virtual void init(org.apache.http.io.SessionInputBuffer arg0, org.apache.http.io.SessionOutputBuffer arg1, org.apache.http.@params.HttpParams arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "init", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/io/SessionOutputBuffer;Lorg/apache/http/params/HttpParams;)V", ref global::org.apache.http.impl.AbstractHttpServerConnection._init32611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _flush32612;
		public virtual void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "flush", "()V", ref global::org.apache.http.impl.AbstractHttpServerConnection._flush32612);
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics32613;
		public virtual global::org.apache.http.HttpConnectionMetrics getMetrics()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpConnectionMetrics>(this, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;", ref global::org.apache.http.impl.AbstractHttpServerConnection._getMetrics32613) as org.apache.http.HttpConnectionMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _isStale32614;
		public virtual bool isStale()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "isStale", "()Z", ref global::org.apache.http.impl.AbstractHttpServerConnection._isStale32614);
		}
		internal static global::MonoJavaBridge.MethodId _receiveRequestHeader32615;
		public virtual global::org.apache.http.HttpRequest receiveRequestHeader()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpRequest>(this, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "receiveRequestHeader", "()Lorg/apache/http/HttpRequest;", ref global::org.apache.http.impl.AbstractHttpServerConnection._receiveRequestHeader32615) as org.apache.http.HttpRequest;
		}
		internal static global::MonoJavaBridge.MethodId _receiveRequestEntity32616;
		public virtual void receiveRequestEntity(org.apache.http.HttpEntityEnclosingRequest arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "receiveRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V", ref global::org.apache.http.impl.AbstractHttpServerConnection._receiveRequestEntity32616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendResponseHeader32617;
		public virtual void sendResponseHeader(org.apache.http.HttpResponse arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "sendResponseHeader", "(Lorg/apache/http/HttpResponse;)V", ref global::org.apache.http.impl.AbstractHttpServerConnection._sendResponseHeader32617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendResponseEntity32618;
		public virtual void sendResponseEntity(org.apache.http.HttpResponse arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "sendResponseEntity", "(Lorg/apache/http/HttpResponse;)V", ref global::org.apache.http.impl.AbstractHttpServerConnection._sendResponseEntity32618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _assertOpen32619;
		protected abstract void assertOpen();
		internal static global::MonoJavaBridge.MethodId _createEntityDeserializer32620;
		protected virtual global::org.apache.http.impl.entity.EntityDeserializer createEntityDeserializer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "createEntityDeserializer", "()Lorg/apache/http/impl/entity/EntityDeserializer;", ref global::org.apache.http.impl.AbstractHttpServerConnection._createEntityDeserializer32620) as org.apache.http.impl.entity.EntityDeserializer;
		}
		internal static global::MonoJavaBridge.MethodId _createEntitySerializer32621;
		protected virtual global::org.apache.http.impl.entity.EntitySerializer createEntitySerializer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "createEntitySerializer", "()Lorg/apache/http/impl/entity/EntitySerializer;", ref global::org.apache.http.impl.AbstractHttpServerConnection._createEntitySerializer32621) as org.apache.http.impl.entity.EntitySerializer;
		}
		internal static global::MonoJavaBridge.MethodId _doFlush32622;
		protected virtual void doFlush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "doFlush", "()V", ref global::org.apache.http.impl.AbstractHttpServerConnection._doFlush32622);
		}
		internal static global::MonoJavaBridge.MethodId _createHttpRequestFactory32623;
		protected virtual global::org.apache.http.HttpRequestFactory createHttpRequestFactory()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpRequestFactory>(this, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "createHttpRequestFactory", "()Lorg/apache/http/HttpRequestFactory;", ref global::org.apache.http.impl.AbstractHttpServerConnection._createHttpRequestFactory32623) as org.apache.http.HttpRequestFactory;
		}
		internal static global::MonoJavaBridge.MethodId _createRequestParser32624;
		protected virtual global::org.apache.http.io.HttpMessageParser createRequestParser(org.apache.http.io.SessionInputBuffer arg0, org.apache.http.HttpRequestFactory arg1, org.apache.http.@params.HttpParams arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.io.HttpMessageParser>(this, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "createRequestParser", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/HttpRequestFactory;Lorg/apache/http/params/HttpParams;)Lorg/apache/http/io/HttpMessageParser;", ref global::org.apache.http.impl.AbstractHttpServerConnection._createRequestParser32624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.apache.http.io.HttpMessageParser;
		}
		internal static global::MonoJavaBridge.MethodId _createResponseWriter32625;
		protected virtual global::org.apache.http.io.HttpMessageWriter createResponseWriter(org.apache.http.io.SessionOutputBuffer arg0, org.apache.http.@params.HttpParams arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.io.HttpMessageWriter>(this, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "createResponseWriter", "(Lorg/apache/http/io/SessionOutputBuffer;Lorg/apache/http/params/HttpParams;)Lorg/apache/http/io/HttpMessageWriter;", ref global::org.apache.http.impl.AbstractHttpServerConnection._createResponseWriter32625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.io.HttpMessageWriter;
		}
		internal static global::MonoJavaBridge.MethodId _AbstractHttpServerConnection32626;
		public AbstractHttpServerConnection() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.AbstractHttpServerConnection._AbstractHttpServerConnection32626.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.AbstractHttpServerConnection._AbstractHttpServerConnection32626 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.AbstractHttpServerConnection.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection._AbstractHttpServerConnection32626);
			Init(@__env, handle);
		}
		static AbstractHttpServerConnection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.AbstractHttpServerConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/AbstractHttpServerConnection"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.AbstractHttpServerConnection))]
	internal sealed partial class AbstractHttpServerConnection_ : org.apache.http.impl.AbstractHttpServerConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractHttpServerConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _shutdown32627;
		public override void shutdown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass, "shutdown", "()V", ref global::org.apache.http.impl.AbstractHttpServerConnection_._shutdown32627);
		}
		internal static global::MonoJavaBridge.MethodId _close32628;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass, "close", "()V", ref global::org.apache.http.impl.AbstractHttpServerConnection_._close32628);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen32629;
		public override bool isOpen()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass, "isOpen", "()Z", ref global::org.apache.http.impl.AbstractHttpServerConnection_._isOpen32629);
		}
		internal static global::MonoJavaBridge.MethodId _setSocketTimeout32630;
		public override void setSocketTimeout(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass, "setSocketTimeout", "(I)V", ref global::org.apache.http.impl.AbstractHttpServerConnection_._setSocketTimeout32630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSocketTimeout32631;
		public override int getSocketTimeout()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass, "getSocketTimeout", "()I", ref global::org.apache.http.impl.AbstractHttpServerConnection_._getSocketTimeout32631);
		}
		internal static global::MonoJavaBridge.MethodId _assertOpen32632;
		protected override void assertOpen()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass, "assertOpen", "()V", ref global::org.apache.http.impl.AbstractHttpServerConnection_._assertOpen32632);
		}
		static AbstractHttpServerConnection_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/AbstractHttpServerConnection"));
		}
		internal static void InitJNI()
		{
		}
	}
}
