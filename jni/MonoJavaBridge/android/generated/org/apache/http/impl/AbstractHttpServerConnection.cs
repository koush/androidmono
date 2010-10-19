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
		internal static global::MonoJavaBridge.MethodId _shutdown25868;
		public abstract void shutdown();
		internal static global::MonoJavaBridge.MethodId _close25869;
		public abstract void close();
		internal static global::MonoJavaBridge.MethodId _isOpen25870;
		public abstract bool isOpen();
		internal static global::MonoJavaBridge.MethodId _setSocketTimeout25871;
		public abstract void setSocketTimeout(int arg0);
		internal static global::MonoJavaBridge.MethodId _getSocketTimeout25872;
		public abstract int getSocketTimeout();
		internal static global::MonoJavaBridge.MethodId _init25873;
		protected virtual void init(org.apache.http.io.SessionInputBuffer arg0, org.apache.http.io.SessionOutputBuffer arg1, org.apache.http.@params.HttpParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection._init25873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection._init25873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _flush25874;
		public virtual void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection._flush25874);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection._flush25874);
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics25875;
		public virtual global::org.apache.http.HttpConnectionMetrics getMetrics() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection._getMetrics25875)) as org.apache.http.HttpConnectionMetrics;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection._getMetrics25875)) as org.apache.http.HttpConnectionMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _isStale25876;
		public virtual bool isStale() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection._isStale25876);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection._isStale25876);
		}
		internal static global::MonoJavaBridge.MethodId _receiveRequestHeader25877;
		public virtual global::org.apache.http.HttpRequest receiveRequestHeader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequest>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection._receiveRequestHeader25877)) as org.apache.http.HttpRequest;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequest>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection._receiveRequestHeader25877)) as org.apache.http.HttpRequest;
		}
		internal static global::MonoJavaBridge.MethodId _receiveRequestEntity25878;
		public virtual void receiveRequestEntity(org.apache.http.HttpEntityEnclosingRequest arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection._receiveRequestEntity25878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection._receiveRequestEntity25878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendResponseHeader25879;
		public virtual void sendResponseHeader(org.apache.http.HttpResponse arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection._sendResponseHeader25879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection._sendResponseHeader25879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendResponseEntity25880;
		public virtual void sendResponseEntity(org.apache.http.HttpResponse arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection._sendResponseEntity25880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection._sendResponseEntity25880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _assertOpen25881;
		protected abstract void assertOpen();
		internal static global::MonoJavaBridge.MethodId _createEntityDeserializer25882;
		protected virtual global::org.apache.http.impl.entity.EntityDeserializer createEntityDeserializer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection._createEntityDeserializer25882)) as org.apache.http.impl.entity.EntityDeserializer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection._createEntityDeserializer25882)) as org.apache.http.impl.entity.EntityDeserializer;
		}
		internal static global::MonoJavaBridge.MethodId _createEntitySerializer25883;
		protected virtual global::org.apache.http.impl.entity.EntitySerializer createEntitySerializer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection._createEntitySerializer25883)) as org.apache.http.impl.entity.EntitySerializer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection._createEntitySerializer25883)) as org.apache.http.impl.entity.EntitySerializer;
		}
		internal static global::MonoJavaBridge.MethodId _doFlush25884;
		protected virtual void doFlush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection._doFlush25884);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection._doFlush25884);
		}
		internal static global::MonoJavaBridge.MethodId _createHttpRequestFactory25885;
		protected virtual global::org.apache.http.HttpRequestFactory createHttpRequestFactory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequestFactory>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection._createHttpRequestFactory25885)) as org.apache.http.HttpRequestFactory;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequestFactory>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection._createHttpRequestFactory25885)) as org.apache.http.HttpRequestFactory;
		}
		internal static global::MonoJavaBridge.MethodId _createRequestParser25886;
		protected virtual global::org.apache.http.io.HttpMessageParser createRequestParser(org.apache.http.io.SessionInputBuffer arg0, org.apache.http.HttpRequestFactory arg1, org.apache.http.@params.HttpParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpMessageParser>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection._createRequestParser25886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.HttpMessageParser;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpMessageParser>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection._createRequestParser25886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.HttpMessageParser;
		}
		internal static global::MonoJavaBridge.MethodId _createResponseWriter25887;
		protected virtual global::org.apache.http.io.HttpMessageWriter createResponseWriter(org.apache.http.io.SessionOutputBuffer arg0, org.apache.http.@params.HttpParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpMessageWriter>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection._createResponseWriter25887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.io.HttpMessageWriter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpMessageWriter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection._createResponseWriter25887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.io.HttpMessageWriter;
		}
		internal static global::MonoJavaBridge.MethodId _AbstractHttpServerConnection25888;
		public AbstractHttpServerConnection()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.AbstractHttpServerConnection.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection._AbstractHttpServerConnection25888);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.AbstractHttpServerConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/AbstractHttpServerConnection"));
			global::org.apache.http.impl.AbstractHttpServerConnection._shutdown25868 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "shutdown", "()V");
			global::org.apache.http.impl.AbstractHttpServerConnection._close25869 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "close", "()V");
			global::org.apache.http.impl.AbstractHttpServerConnection._isOpen25870 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "isOpen", "()Z");
			global::org.apache.http.impl.AbstractHttpServerConnection._setSocketTimeout25871 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "setSocketTimeout", "(I)V");
			global::org.apache.http.impl.AbstractHttpServerConnection._getSocketTimeout25872 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "getSocketTimeout", "()I");
			global::org.apache.http.impl.AbstractHttpServerConnection._init25873 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "init", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/io/SessionOutputBuffer;Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.impl.AbstractHttpServerConnection._flush25874 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "flush", "()V");
			global::org.apache.http.impl.AbstractHttpServerConnection._getMetrics25875 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;");
			global::org.apache.http.impl.AbstractHttpServerConnection._isStale25876 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "isStale", "()Z");
			global::org.apache.http.impl.AbstractHttpServerConnection._receiveRequestHeader25877 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "receiveRequestHeader", "()Lorg/apache/http/HttpRequest;");
			global::org.apache.http.impl.AbstractHttpServerConnection._receiveRequestEntity25878 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "receiveRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V");
			global::org.apache.http.impl.AbstractHttpServerConnection._sendResponseHeader25879 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "sendResponseHeader", "(Lorg/apache/http/HttpResponse;)V");
			global::org.apache.http.impl.AbstractHttpServerConnection._sendResponseEntity25880 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "sendResponseEntity", "(Lorg/apache/http/HttpResponse;)V");
			global::org.apache.http.impl.AbstractHttpServerConnection._assertOpen25881 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "assertOpen", "()V");
			global::org.apache.http.impl.AbstractHttpServerConnection._createEntityDeserializer25882 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "createEntityDeserializer", "()Lorg/apache/http/impl/entity/EntityDeserializer;");
			global::org.apache.http.impl.AbstractHttpServerConnection._createEntitySerializer25883 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "createEntitySerializer", "()Lorg/apache/http/impl/entity/EntitySerializer;");
			global::org.apache.http.impl.AbstractHttpServerConnection._doFlush25884 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "doFlush", "()V");
			global::org.apache.http.impl.AbstractHttpServerConnection._createHttpRequestFactory25885 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "createHttpRequestFactory", "()Lorg/apache/http/HttpRequestFactory;");
			global::org.apache.http.impl.AbstractHttpServerConnection._createRequestParser25886 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "createRequestParser", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/HttpRequestFactory;Lorg/apache/http/@params/HttpParams;)Lorg/apache/http/io/HttpMessageParser;");
			global::org.apache.http.impl.AbstractHttpServerConnection._createResponseWriter25887 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "createResponseWriter", "(Lorg/apache/http/io/SessionOutputBuffer;Lorg/apache/http/@params/HttpParams;)Lorg/apache/http/io/HttpMessageWriter;");
			global::org.apache.http.impl.AbstractHttpServerConnection._AbstractHttpServerConnection25888 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _shutdown25889;
		public override void shutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection_._shutdown25889);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection_._shutdown25889);
		}
		internal static global::MonoJavaBridge.MethodId _close25890;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection_._close25890);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection_._close25890);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen25891;
		public override bool isOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection_._isOpen25891);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection_._isOpen25891);
		}
		internal static global::MonoJavaBridge.MethodId _setSocketTimeout25892;
		public override void setSocketTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection_._setSocketTimeout25892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection_._setSocketTimeout25892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSocketTimeout25893;
		public override int getSocketTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection_._getSocketTimeout25893);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection_._getSocketTimeout25893);
		}
		internal static global::MonoJavaBridge.MethodId _assertOpen25894;
		protected override void assertOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection_._assertOpen25894);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection_._assertOpen25894);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/AbstractHttpServerConnection"));
			global::org.apache.http.impl.AbstractHttpServerConnection_._shutdown25889 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass, "shutdown", "()V");
			global::org.apache.http.impl.AbstractHttpServerConnection_._close25890 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass, "close", "()V");
			global::org.apache.http.impl.AbstractHttpServerConnection_._isOpen25891 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass, "isOpen", "()Z");
			global::org.apache.http.impl.AbstractHttpServerConnection_._setSocketTimeout25892 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass, "setSocketTimeout", "(I)V");
			global::org.apache.http.impl.AbstractHttpServerConnection_._getSocketTimeout25893 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass, "getSocketTimeout", "()I");
			global::org.apache.http.impl.AbstractHttpServerConnection_._assertOpen25894 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass, "assertOpen", "()V");
		}
	}
}
