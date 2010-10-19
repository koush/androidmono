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
		internal static global::MonoJavaBridge.MethodId _shutdown25840;
		public abstract void shutdown();
		internal static global::MonoJavaBridge.MethodId _close25841;
		public abstract void close();
		internal static global::MonoJavaBridge.MethodId _isOpen25842;
		public abstract bool isOpen();
		internal static global::MonoJavaBridge.MethodId _setSocketTimeout25843;
		public abstract void setSocketTimeout(int arg0);
		internal static global::MonoJavaBridge.MethodId _getSocketTimeout25844;
		public abstract int getSocketTimeout();
		internal static global::MonoJavaBridge.MethodId _init25845;
		protected virtual void init(org.apache.http.io.SessionInputBuffer arg0, org.apache.http.io.SessionOutputBuffer arg1, org.apache.http.@params.HttpParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection._init25845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection._init25845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _flush25846;
		public virtual void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection._flush25846);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection._flush25846);
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics25847;
		public virtual global::org.apache.http.HttpConnectionMetrics getMetrics() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection._getMetrics25847)) as org.apache.http.HttpConnectionMetrics;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection._getMetrics25847)) as org.apache.http.HttpConnectionMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _isResponseAvailable25848;
		public virtual bool isResponseAvailable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection._isResponseAvailable25848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection._isResponseAvailable25848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendRequestHeader25849;
		public virtual void sendRequestHeader(org.apache.http.HttpRequest arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection._sendRequestHeader25849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection._sendRequestHeader25849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendRequestEntity25850;
		public virtual void sendRequestEntity(org.apache.http.HttpEntityEnclosingRequest arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection._sendRequestEntity25850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection._sendRequestEntity25850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _receiveResponseHeader25851;
		public virtual global::org.apache.http.HttpResponse receiveResponseHeader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection._receiveResponseHeader25851)) as org.apache.http.HttpResponse;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection._receiveResponseHeader25851)) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _receiveResponseEntity25852;
		public virtual void receiveResponseEntity(org.apache.http.HttpResponse arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection._receiveResponseEntity25852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection._receiveResponseEntity25852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isStale25853;
		public virtual bool isStale() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection._isStale25853);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection._isStale25853);
		}
		internal static global::MonoJavaBridge.MethodId _assertOpen25854;
		protected abstract void assertOpen();
		internal static global::MonoJavaBridge.MethodId _createEntityDeserializer25855;
		protected virtual global::org.apache.http.impl.entity.EntityDeserializer createEntityDeserializer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection._createEntityDeserializer25855)) as org.apache.http.impl.entity.EntityDeserializer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection._createEntityDeserializer25855)) as org.apache.http.impl.entity.EntityDeserializer;
		}
		internal static global::MonoJavaBridge.MethodId _createEntitySerializer25856;
		protected virtual global::org.apache.http.impl.entity.EntitySerializer createEntitySerializer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection._createEntitySerializer25856)) as org.apache.http.impl.entity.EntitySerializer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection._createEntitySerializer25856)) as org.apache.http.impl.entity.EntitySerializer;
		}
		internal static global::MonoJavaBridge.MethodId _createHttpResponseFactory25857;
		protected virtual global::org.apache.http.HttpResponseFactory createHttpResponseFactory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponseFactory>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection._createHttpResponseFactory25857)) as org.apache.http.HttpResponseFactory;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponseFactory>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection._createHttpResponseFactory25857)) as org.apache.http.HttpResponseFactory;
		}
		internal static global::MonoJavaBridge.MethodId _createResponseParser25858;
		protected virtual global::org.apache.http.io.HttpMessageParser createResponseParser(org.apache.http.io.SessionInputBuffer arg0, org.apache.http.HttpResponseFactory arg1, org.apache.http.@params.HttpParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpMessageParser>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection._createResponseParser25858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.HttpMessageParser;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpMessageParser>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection._createResponseParser25858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.HttpMessageParser;
		}
		internal static global::MonoJavaBridge.MethodId _createRequestWriter25859;
		protected virtual global::org.apache.http.io.HttpMessageWriter createRequestWriter(org.apache.http.io.SessionOutputBuffer arg0, org.apache.http.@params.HttpParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpMessageWriter>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection._createRequestWriter25859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.io.HttpMessageWriter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpMessageWriter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection._createRequestWriter25859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.io.HttpMessageWriter;
		}
		internal static global::MonoJavaBridge.MethodId _doFlush25860;
		protected virtual void doFlush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection._doFlush25860);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection._doFlush25860);
		}
		internal static global::MonoJavaBridge.MethodId _AbstractHttpClientConnection25861;
		public AbstractHttpClientConnection()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.AbstractHttpClientConnection.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection._AbstractHttpClientConnection25861);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.AbstractHttpClientConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/AbstractHttpClientConnection"));
			global::org.apache.http.impl.AbstractHttpClientConnection._shutdown25840 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "shutdown", "()V");
			global::org.apache.http.impl.AbstractHttpClientConnection._close25841 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "close", "()V");
			global::org.apache.http.impl.AbstractHttpClientConnection._isOpen25842 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "isOpen", "()Z");
			global::org.apache.http.impl.AbstractHttpClientConnection._setSocketTimeout25843 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "setSocketTimeout", "(I)V");
			global::org.apache.http.impl.AbstractHttpClientConnection._getSocketTimeout25844 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "getSocketTimeout", "()I");
			global::org.apache.http.impl.AbstractHttpClientConnection._init25845 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "init", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/io/SessionOutputBuffer;Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.impl.AbstractHttpClientConnection._flush25846 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "flush", "()V");
			global::org.apache.http.impl.AbstractHttpClientConnection._getMetrics25847 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;");
			global::org.apache.http.impl.AbstractHttpClientConnection._isResponseAvailable25848 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "isResponseAvailable", "(I)Z");
			global::org.apache.http.impl.AbstractHttpClientConnection._sendRequestHeader25849 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "sendRequestHeader", "(Lorg/apache/http/HttpRequest;)V");
			global::org.apache.http.impl.AbstractHttpClientConnection._sendRequestEntity25850 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "sendRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V");
			global::org.apache.http.impl.AbstractHttpClientConnection._receiveResponseHeader25851 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "receiveResponseHeader", "()Lorg/apache/http/HttpResponse;");
			global::org.apache.http.impl.AbstractHttpClientConnection._receiveResponseEntity25852 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "receiveResponseEntity", "(Lorg/apache/http/HttpResponse;)V");
			global::org.apache.http.impl.AbstractHttpClientConnection._isStale25853 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "isStale", "()Z");
			global::org.apache.http.impl.AbstractHttpClientConnection._assertOpen25854 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "assertOpen", "()V");
			global::org.apache.http.impl.AbstractHttpClientConnection._createEntityDeserializer25855 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "createEntityDeserializer", "()Lorg/apache/http/impl/entity/EntityDeserializer;");
			global::org.apache.http.impl.AbstractHttpClientConnection._createEntitySerializer25856 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "createEntitySerializer", "()Lorg/apache/http/impl/entity/EntitySerializer;");
			global::org.apache.http.impl.AbstractHttpClientConnection._createHttpResponseFactory25857 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "createHttpResponseFactory", "()Lorg/apache/http/HttpResponseFactory;");
			global::org.apache.http.impl.AbstractHttpClientConnection._createResponseParser25858 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "createResponseParser", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/HttpResponseFactory;Lorg/apache/http/@params/HttpParams;)Lorg/apache/http/io/HttpMessageParser;");
			global::org.apache.http.impl.AbstractHttpClientConnection._createRequestWriter25859 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "createRequestWriter", "(Lorg/apache/http/io/SessionOutputBuffer;Lorg/apache/http/@params/HttpParams;)Lorg/apache/http/io/HttpMessageWriter;");
			global::org.apache.http.impl.AbstractHttpClientConnection._doFlush25860 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "doFlush", "()V");
			global::org.apache.http.impl.AbstractHttpClientConnection._AbstractHttpClientConnection25861 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.AbstractHttpClientConnection))]
	public sealed partial class AbstractHttpClientConnection_ : org.apache.http.impl.AbstractHttpClientConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractHttpClientConnection_()
		{
			InitJNI();
		}
		internal AbstractHttpClientConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _shutdown25862;
		public override void shutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection_._shutdown25862);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection_.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection_._shutdown25862);
		}
		internal static global::MonoJavaBridge.MethodId _close25863;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection_._close25863);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection_.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection_._close25863);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen25864;
		public override bool isOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection_._isOpen25864);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection_.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection_._isOpen25864);
		}
		internal static global::MonoJavaBridge.MethodId _setSocketTimeout25865;
		public override void setSocketTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection_._setSocketTimeout25865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection_.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection_._setSocketTimeout25865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSocketTimeout25866;
		public override int getSocketTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection_._getSocketTimeout25866);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection_.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection_._getSocketTimeout25866);
		}
		internal static global::MonoJavaBridge.MethodId _assertOpen25867;
		protected override void assertOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection_._assertOpen25867);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.AbstractHttpClientConnection_.staticClass, global::org.apache.http.impl.AbstractHttpClientConnection_._assertOpen25867);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.AbstractHttpClientConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/AbstractHttpClientConnection"));
			global::org.apache.http.impl.AbstractHttpClientConnection_._shutdown25862 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection_.staticClass, "shutdown", "()V");
			global::org.apache.http.impl.AbstractHttpClientConnection_._close25863 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection_.staticClass, "close", "()V");
			global::org.apache.http.impl.AbstractHttpClientConnection_._isOpen25864 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection_.staticClass, "isOpen", "()Z");
			global::org.apache.http.impl.AbstractHttpClientConnection_._setSocketTimeout25865 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection_.staticClass, "setSocketTimeout", "(I)V");
			global::org.apache.http.impl.AbstractHttpClientConnection_._getSocketTimeout25866 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection_.staticClass, "getSocketTimeout", "()I");
			global::org.apache.http.impl.AbstractHttpClientConnection_._assertOpen25867 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpClientConnection_.staticClass, "assertOpen", "()V");
		}
	}
}
