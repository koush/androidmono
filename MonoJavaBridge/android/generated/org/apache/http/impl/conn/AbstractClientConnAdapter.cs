namespace org.apache.http.impl.conn
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.impl.conn.AbstractClientConnAdapter_))]
	public abstract partial class AbstractClientConnAdapter : java.lang.Object, org.apache.http.conn.ManagedClientConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractClientConnAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract global::java.lang.Object getState();
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract void setState(java.lang.Object arg0);
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract void open(org.apache.http.conn.routing.HttpRoute arg0, org.apache.http.protocol.HttpContext arg1, org.apache.http.@params.HttpParams arg2);
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract global::org.apache.http.conn.routing.HttpRoute getRoute();
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract void tunnelTarget(bool arg0, org.apache.http.@params.HttpParams arg1);
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract void tunnelProxy(org.apache.http.HttpHost arg0, bool arg1, org.apache.http.@params.HttpParams arg2);
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract void layerProtocol(org.apache.http.protocol.HttpContext arg0, org.apache.http.@params.HttpParams arg1);
		private static global::MonoJavaBridge.MethodId _m7;
		public abstract void shutdown();
		private static global::MonoJavaBridge.MethodId _m8;
		public abstract void close();
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "flush", "()V", ref global::org.apache.http.impl.conn.AbstractClientConnAdapter._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool isOpen()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "isOpen", "()Z", ref global::org.apache.http.impl.conn.AbstractClientConnAdapter._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		protected virtual global::org.apache.http.conn.ClientConnectionManager getManager()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.conn.ClientConnectionManager>(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getManager", "()Lorg/apache/http/conn/ClientConnectionManager;", ref global::org.apache.http.impl.conn.AbstractClientConnAdapter._m11) as org.apache.http.conn.ClientConnectionManager;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual bool isSecure()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "isSecure", "()Z", ref global::org.apache.http.impl.conn.AbstractClientConnAdapter._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::java.net.InetAddress getLocalAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;", ref global::org.apache.http.impl.conn.AbstractClientConnAdapter._m13) as java.net.InetAddress;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual int getLocalPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getLocalPort", "()I", ref global::org.apache.http.impl.conn.AbstractClientConnAdapter._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void releaseConnection()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "releaseConnection", "()V", ref global::org.apache.http.impl.conn.AbstractClientConnAdapter._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual global::org.apache.http.HttpConnectionMetrics getMetrics()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpConnectionMetrics>(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;", ref global::org.apache.http.impl.conn.AbstractClientConnAdapter._m16) as org.apache.http.HttpConnectionMetrics;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual bool isResponseAvailable(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "isResponseAvailable", "(I)Z", ref global::org.apache.http.impl.conn.AbstractClientConnAdapter._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void sendRequestHeader(org.apache.http.HttpRequest arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "sendRequestHeader", "(Lorg/apache/http/HttpRequest;)V", ref global::org.apache.http.impl.conn.AbstractClientConnAdapter._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void sendRequestEntity(org.apache.http.HttpEntityEnclosingRequest arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "sendRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V", ref global::org.apache.http.impl.conn.AbstractClientConnAdapter._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual global::org.apache.http.HttpResponse receiveResponseHeader()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpResponse>(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "receiveResponseHeader", "()Lorg/apache/http/HttpResponse;", ref global::org.apache.http.impl.conn.AbstractClientConnAdapter._m20) as org.apache.http.HttpResponse;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void receiveResponseEntity(org.apache.http.HttpResponse arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "receiveResponseEntity", "(Lorg/apache/http/HttpResponse;)V", ref global::org.apache.http.impl.conn.AbstractClientConnAdapter._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual bool isStale()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "isStale", "()Z", ref global::org.apache.http.impl.conn.AbstractClientConnAdapter._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual void setSocketTimeout(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "setSocketTimeout", "(I)V", ref global::org.apache.http.impl.conn.AbstractClientConnAdapter._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual int getSocketTimeout()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getSocketTimeout", "()I", ref global::org.apache.http.impl.conn.AbstractClientConnAdapter._m24);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual global::java.net.InetAddress getRemoteAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getRemoteAddress", "()Ljava/net/InetAddress;", ref global::org.apache.http.impl.conn.AbstractClientConnAdapter._m25) as java.net.InetAddress;
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual int getRemotePort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getRemotePort", "()I", ref global::org.apache.http.impl.conn.AbstractClientConnAdapter._m26);
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual void abortConnection()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "abortConnection", "()V", ref global::org.apache.http.impl.conn.AbstractClientConnAdapter._m27);
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual global::javax.net.ssl.SSLSession getSSLSession()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.net.ssl.SSLSession>(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getSSLSession", "()Ljavax/net/ssl/SSLSession;", ref global::org.apache.http.impl.conn.AbstractClientConnAdapter._m28) as javax.net.ssl.SSLSession;
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual void markReusable()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "markReusable", "()V", ref global::org.apache.http.impl.conn.AbstractClientConnAdapter._m29);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual void unmarkReusable()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "unmarkReusable", "()V", ref global::org.apache.http.impl.conn.AbstractClientConnAdapter._m30);
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual bool isMarkedReusable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "isMarkedReusable", "()Z", ref global::org.apache.http.impl.conn.AbstractClientConnAdapter._m31);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual void setIdleDuration(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "setIdleDuration", "(JLjava/util/concurrent/TimeUnit;)V", ref global::org.apache.http.impl.conn.AbstractClientConnAdapter._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		protected virtual void detach()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "detach", "()V", ref global::org.apache.http.impl.conn.AbstractClientConnAdapter._m33);
		}
		private static global::MonoJavaBridge.MethodId _m34;
		protected virtual global::org.apache.http.conn.OperatedClientConnection getWrappedConnection()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.conn.OperatedClientConnection>(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getWrappedConnection", "()Lorg/apache/http/conn/OperatedClientConnection;", ref global::org.apache.http.impl.conn.AbstractClientConnAdapter._m34) as org.apache.http.conn.OperatedClientConnection;
		}
		private static global::MonoJavaBridge.MethodId _m35;
		protected virtual void assertNotAborted()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "assertNotAborted", "()V", ref global::org.apache.http.impl.conn.AbstractClientConnAdapter._m35);
		}
		private static global::MonoJavaBridge.MethodId _m36;
		protected virtual void assertValid(org.apache.http.conn.OperatedClientConnection arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "assertValid", "(Lorg/apache/http/conn/OperatedClientConnection;)V", ref global::org.apache.http.impl.conn.AbstractClientConnAdapter._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		protected AbstractClientConnAdapter(org.apache.http.conn.ClientConnectionManager arg0, org.apache.http.conn.OperatedClientConnection arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.conn.AbstractClientConnAdapter._m37.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.conn.AbstractClientConnAdapter._m37 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "<init>", "(Lorg/apache/http/conn/ClientConnectionManager;Lorg/apache/http/conn/OperatedClientConnection;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static AbstractClientConnAdapter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/AbstractClientConnAdapter"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.conn.AbstractClientConnAdapter))]
	internal sealed partial class AbstractClientConnAdapter_ : org.apache.http.impl.conn.AbstractClientConnAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractClientConnAdapter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.Object getState()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, "getState", "()Ljava/lang/Object;", ref global::org.apache.http.impl.conn.AbstractClientConnAdapter_._m0) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void setState(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, "setState", "(Ljava/lang/Object;)V", ref global::org.apache.http.impl.conn.AbstractClientConnAdapter_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void open(org.apache.http.conn.routing.HttpRoute arg0, org.apache.http.protocol.HttpContext arg1, org.apache.http.@params.HttpParams arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, "open", "(Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V", ref global::org.apache.http.impl.conn.AbstractClientConnAdapter_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::org.apache.http.conn.routing.HttpRoute getRoute()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.conn.routing.HttpRoute>(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, "getRoute", "()Lorg/apache/http/conn/routing/HttpRoute;", ref global::org.apache.http.impl.conn.AbstractClientConnAdapter_._m3) as org.apache.http.conn.routing.HttpRoute;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void tunnelTarget(bool arg0, org.apache.http.@params.HttpParams arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, "tunnelTarget", "(ZLorg/apache/http/params/HttpParams;)V", ref global::org.apache.http.impl.conn.AbstractClientConnAdapter_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override void tunnelProxy(org.apache.http.HttpHost arg0, bool arg1, org.apache.http.@params.HttpParams arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, "tunnelProxy", "(Lorg/apache/http/HttpHost;ZLorg/apache/http/params/HttpParams;)V", ref global::org.apache.http.impl.conn.AbstractClientConnAdapter_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override void layerProtocol(org.apache.http.protocol.HttpContext arg0, org.apache.http.@params.HttpParams arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, "layerProtocol", "(Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V", ref global::org.apache.http.impl.conn.AbstractClientConnAdapter_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override void shutdown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, "shutdown", "()V", ref global::org.apache.http.impl.conn.AbstractClientConnAdapter_._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, "close", "()V", ref global::org.apache.http.impl.conn.AbstractClientConnAdapter_._m8);
		}
		static AbstractClientConnAdapter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/AbstractClientConnAdapter"));
		}
		internal static void InitJNI()
		{
		}
	}
}
