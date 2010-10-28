namespace org.apache.http.impl.conn
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.impl.conn.AbstractPooledConnAdapter_))]
	public abstract partial class AbstractPooledConnAdapter : org.apache.http.impl.conn.AbstractClientConnAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractPooledConnAdapter()
		{
			InitJNI();
		}
		protected AbstractPooledConnAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _shutdown33013;
		public override void shutdown()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._shutdown33013);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._shutdown33013);
		}
		internal static global::MonoJavaBridge.MethodId _getState33014;
		public override global::java.lang.Object getState()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._getState33014)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._getState33014)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _close33015;
		public override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._close33015);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._close33015);
		}
		internal static global::MonoJavaBridge.MethodId _setState33016;
		public override void setState(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._setState33016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._setState33016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _open33017;
		public override void open(org.apache.http.conn.routing.HttpRoute arg0, org.apache.http.protocol.HttpContext arg1, org.apache.http.@params.HttpParams arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._open33017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._open33017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getRoute33018;
		public override global::org.apache.http.conn.routing.HttpRoute getRoute()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.HttpRoute>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._getRoute33018)) as org.apache.http.conn.routing.HttpRoute;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.HttpRoute>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._getRoute33018)) as org.apache.http.conn.routing.HttpRoute;
		}
		internal static global::MonoJavaBridge.MethodId _tunnelTarget33019;
		public override void tunnelTarget(bool arg0, org.apache.http.@params.HttpParams arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._tunnelTarget33019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._tunnelTarget33019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _tunnelProxy33020;
		public override void tunnelProxy(org.apache.http.HttpHost arg0, bool arg1, org.apache.http.@params.HttpParams arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._tunnelProxy33020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._tunnelProxy33020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _layerProtocol33021;
		public override void layerProtocol(org.apache.http.protocol.HttpContext arg0, org.apache.http.@params.HttpParams arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._layerProtocol33021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._layerProtocol33021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _detach33022;
		protected override void detach()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._detach33022);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._detach33022);
		}
		internal static global::MonoJavaBridge.MethodId _assertAttached33023;
		protected virtual void assertAttached()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._assertAttached33023);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._assertAttached33023);
		}
		internal static global::MonoJavaBridge.MethodId _AbstractPooledConnAdapter33024;
		protected AbstractPooledConnAdapter(org.apache.http.conn.ClientConnectionManager arg0, org.apache.http.impl.conn.AbstractPoolEntry arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._AbstractPooledConnAdapter33024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/AbstractPooledConnAdapter"));
			global::org.apache.http.impl.conn.AbstractPooledConnAdapter._shutdown33013 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, "shutdown", "()V");
			global::org.apache.http.impl.conn.AbstractPooledConnAdapter._getState33014 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, "getState", "()Ljava/lang/Object;");
			global::org.apache.http.impl.conn.AbstractPooledConnAdapter._close33015 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, "close", "()V");
			global::org.apache.http.impl.conn.AbstractPooledConnAdapter._setState33016 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, "setState", "(Ljava/lang/Object;)V");
			global::org.apache.http.impl.conn.AbstractPooledConnAdapter._open33017 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, "open", "(Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractPooledConnAdapter._getRoute33018 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, "getRoute", "()Lorg/apache/http/conn/routing/HttpRoute;");
			global::org.apache.http.impl.conn.AbstractPooledConnAdapter._tunnelTarget33019 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, "tunnelTarget", "(ZLorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractPooledConnAdapter._tunnelProxy33020 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, "tunnelProxy", "(Lorg/apache/http/HttpHost;ZLorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractPooledConnAdapter._layerProtocol33021 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, "layerProtocol", "(Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractPooledConnAdapter._detach33022 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, "detach", "()V");
			global::org.apache.http.impl.conn.AbstractPooledConnAdapter._assertAttached33023 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, "assertAttached", "()V");
			global::org.apache.http.impl.conn.AbstractPooledConnAdapter._AbstractPooledConnAdapter33024 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, "<init>", "(Lorg/apache/http/conn/ClientConnectionManager;Lorg/apache/http/impl/conn/AbstractPoolEntry;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.conn.AbstractPooledConnAdapter))]
	internal sealed partial class AbstractPooledConnAdapter_ : org.apache.http.impl.conn.AbstractPooledConnAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractPooledConnAdapter_()
		{
			InitJNI();
		}
		internal AbstractPooledConnAdapter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.AbstractPooledConnAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/AbstractPooledConnAdapter"));
		}
	}
}
