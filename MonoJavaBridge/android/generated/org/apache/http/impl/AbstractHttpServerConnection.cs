namespace org.apache.http.impl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.impl.AbstractHttpServerConnection_))]
	public abstract partial class AbstractHttpServerConnection : java.lang.Object, HttpServerConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractHttpServerConnection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract void shutdown();
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract void close();
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract bool isOpen();
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract void setSocketTimeout(int arg0);
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract int getSocketTimeout();
		private static global::MonoJavaBridge.MethodId _m5;
		protected virtual void init(org.apache.http.io.SessionInputBuffer arg0, org.apache.http.io.SessionOutputBuffer arg1, org.apache.http.@params.HttpParams arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "init", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/io/SessionOutputBuffer;Lorg/apache/http/params/HttpParams;)V", ref global::org.apache.http.impl.AbstractHttpServerConnection._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "flush", "()V", ref global::org.apache.http.impl.AbstractHttpServerConnection._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::org.apache.http.HttpConnectionMetrics getMetrics()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpConnectionMetrics>(this, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;", ref global::org.apache.http.impl.AbstractHttpServerConnection._m7) as org.apache.http.HttpConnectionMetrics;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual bool isStale()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "isStale", "()Z", ref global::org.apache.http.impl.AbstractHttpServerConnection._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::org.apache.http.HttpRequest receiveRequestHeader()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpRequest>(this, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "receiveRequestHeader", "()Lorg/apache/http/HttpRequest;", ref global::org.apache.http.impl.AbstractHttpServerConnection._m9) as org.apache.http.HttpRequest;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void receiveRequestEntity(org.apache.http.HttpEntityEnclosingRequest arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "receiveRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V", ref global::org.apache.http.impl.AbstractHttpServerConnection._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void sendResponseHeader(org.apache.http.HttpResponse arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "sendResponseHeader", "(Lorg/apache/http/HttpResponse;)V", ref global::org.apache.http.impl.AbstractHttpServerConnection._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void sendResponseEntity(org.apache.http.HttpResponse arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "sendResponseEntity", "(Lorg/apache/http/HttpResponse;)V", ref global::org.apache.http.impl.AbstractHttpServerConnection._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		protected abstract void assertOpen();
		private static global::MonoJavaBridge.MethodId _m14;
		protected virtual global::org.apache.http.impl.entity.EntityDeserializer createEntityDeserializer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "createEntityDeserializer", "()Lorg/apache/http/impl/entity/EntityDeserializer;", ref global::org.apache.http.impl.AbstractHttpServerConnection._m14) as org.apache.http.impl.entity.EntityDeserializer;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		protected virtual global::org.apache.http.impl.entity.EntitySerializer createEntitySerializer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "createEntitySerializer", "()Lorg/apache/http/impl/entity/EntitySerializer;", ref global::org.apache.http.impl.AbstractHttpServerConnection._m15) as org.apache.http.impl.entity.EntitySerializer;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		protected virtual void doFlush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "doFlush", "()V", ref global::org.apache.http.impl.AbstractHttpServerConnection._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		protected virtual global::org.apache.http.HttpRequestFactory createHttpRequestFactory()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpRequestFactory>(this, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "createHttpRequestFactory", "()Lorg/apache/http/HttpRequestFactory;", ref global::org.apache.http.impl.AbstractHttpServerConnection._m17) as org.apache.http.HttpRequestFactory;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		protected virtual global::org.apache.http.io.HttpMessageParser createRequestParser(org.apache.http.io.SessionInputBuffer arg0, org.apache.http.HttpRequestFactory arg1, org.apache.http.@params.HttpParams arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.io.HttpMessageParser>(this, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "createRequestParser", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/HttpRequestFactory;Lorg/apache/http/params/HttpParams;)Lorg/apache/http/io/HttpMessageParser;", ref global::org.apache.http.impl.AbstractHttpServerConnection._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.apache.http.io.HttpMessageParser;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		protected virtual global::org.apache.http.io.HttpMessageWriter createResponseWriter(org.apache.http.io.SessionOutputBuffer arg0, org.apache.http.@params.HttpParams arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.io.HttpMessageWriter>(this, global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "createResponseWriter", "(Lorg/apache/http/io/SessionOutputBuffer;Lorg/apache/http/params/HttpParams;)Lorg/apache/http/io/HttpMessageWriter;", ref global::org.apache.http.impl.AbstractHttpServerConnection._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.io.HttpMessageWriter;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public AbstractHttpServerConnection() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.AbstractHttpServerConnection._m20.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.AbstractHttpServerConnection._m20 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.AbstractHttpServerConnection.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.AbstractHttpServerConnection.staticClass, global::org.apache.http.impl.AbstractHttpServerConnection._m20);
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
		private static global::MonoJavaBridge.MethodId _m0;
		public override void shutdown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass, "shutdown", "()V", ref global::org.apache.http.impl.AbstractHttpServerConnection_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass, "close", "()V", ref global::org.apache.http.impl.AbstractHttpServerConnection_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool isOpen()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass, "isOpen", "()Z", ref global::org.apache.http.impl.AbstractHttpServerConnection_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void setSocketTimeout(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass, "setSocketTimeout", "(I)V", ref global::org.apache.http.impl.AbstractHttpServerConnection_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int getSocketTimeout()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass, "getSocketTimeout", "()I", ref global::org.apache.http.impl.AbstractHttpServerConnection_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override void assertOpen()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.AbstractHttpServerConnection_.staticClass, "assertOpen", "()V", ref global::org.apache.http.impl.AbstractHttpServerConnection_._m5);
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
