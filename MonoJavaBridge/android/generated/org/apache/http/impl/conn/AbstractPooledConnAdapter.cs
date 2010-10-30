namespace org.apache.http.impl.conn
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.impl.conn.AbstractPooledConnAdapter_))]
	public abstract partial class AbstractPooledConnAdapter : org.apache.http.impl.conn.AbstractClientConnAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractPooledConnAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _shutdown33013;
		public override void shutdown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, "shutdown", "()V", ref global::org.apache.http.impl.conn.AbstractPooledConnAdapter._shutdown33013);
		}
		internal static global::MonoJavaBridge.MethodId _getState33014;
		public override global::java.lang.Object getState()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, "getState", "()Ljava/lang/Object;", ref global::org.apache.http.impl.conn.AbstractPooledConnAdapter._getState33014) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _close33015;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, "close", "()V", ref global::org.apache.http.impl.conn.AbstractPooledConnAdapter._close33015);
		}
		internal static global::MonoJavaBridge.MethodId _setState33016;
		public override void setState(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, "setState", "(Ljava/lang/Object;)V", ref global::org.apache.http.impl.conn.AbstractPooledConnAdapter._setState33016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _open33017;
		public override void open(org.apache.http.conn.routing.HttpRoute arg0, org.apache.http.protocol.HttpContext arg1, org.apache.http.@params.HttpParams arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, "open", "(Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V", ref global::org.apache.http.impl.conn.AbstractPooledConnAdapter._open33017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getRoute33018;
		public override global::org.apache.http.conn.routing.HttpRoute getRoute()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.conn.routing.HttpRoute>(this, global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, "getRoute", "()Lorg/apache/http/conn/routing/HttpRoute;", ref global::org.apache.http.impl.conn.AbstractPooledConnAdapter._getRoute33018) as org.apache.http.conn.routing.HttpRoute;
		}
		internal static global::MonoJavaBridge.MethodId _tunnelTarget33019;
		public override void tunnelTarget(bool arg0, org.apache.http.@params.HttpParams arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, "tunnelTarget", "(ZLorg/apache/http/params/HttpParams;)V", ref global::org.apache.http.impl.conn.AbstractPooledConnAdapter._tunnelTarget33019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _tunnelProxy33020;
		public override void tunnelProxy(org.apache.http.HttpHost arg0, bool arg1, org.apache.http.@params.HttpParams arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, "tunnelProxy", "(Lorg/apache/http/HttpHost;ZLorg/apache/http/params/HttpParams;)V", ref global::org.apache.http.impl.conn.AbstractPooledConnAdapter._tunnelProxy33020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _layerProtocol33021;
		public override void layerProtocol(org.apache.http.protocol.HttpContext arg0, org.apache.http.@params.HttpParams arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, "layerProtocol", "(Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V", ref global::org.apache.http.impl.conn.AbstractPooledConnAdapter._layerProtocol33021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _detach33022;
		protected override void detach()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, "detach", "()V", ref global::org.apache.http.impl.conn.AbstractPooledConnAdapter._detach33022);
		}
		internal static global::MonoJavaBridge.MethodId _assertAttached33023;
		protected virtual void assertAttached()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, "assertAttached", "()V", ref global::org.apache.http.impl.conn.AbstractPooledConnAdapter._assertAttached33023);
		}
		internal static global::MonoJavaBridge.MethodId _AbstractPooledConnAdapter33024;
		protected AbstractPooledConnAdapter(org.apache.http.conn.ClientConnectionManager arg0, org.apache.http.impl.conn.AbstractPoolEntry arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.conn.AbstractPooledConnAdapter._AbstractPooledConnAdapter33024.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.conn.AbstractPooledConnAdapter._AbstractPooledConnAdapter33024 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, "<init>", "(Lorg/apache/http/conn/ClientConnectionManager;Lorg/apache/http/impl/conn/AbstractPoolEntry;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._AbstractPooledConnAdapter33024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static AbstractPooledConnAdapter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/AbstractPooledConnAdapter"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.conn.AbstractPooledConnAdapter))]
	internal sealed partial class AbstractPooledConnAdapter_ : org.apache.http.impl.conn.AbstractPooledConnAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractPooledConnAdapter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static AbstractPooledConnAdapter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.AbstractPooledConnAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/AbstractPooledConnAdapter"));
		}
		internal static void InitJNI()
		{
		}
	}
}
