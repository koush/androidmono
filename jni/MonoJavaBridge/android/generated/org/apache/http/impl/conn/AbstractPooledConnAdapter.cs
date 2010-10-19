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
		internal static global::MonoJavaBridge.MethodId _shutdown26271;
		public override void shutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._shutdown26271);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._shutdown26271);
		}
		internal static global::MonoJavaBridge.MethodId _getState26272;
		public override global::java.lang.Object getState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._getState26272)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._getState26272)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _close26273;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._close26273);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._close26273);
		}
		internal static global::MonoJavaBridge.MethodId _setState26274;
		public override void setState(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._setState26274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._setState26274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _open26275;
		public override void open(org.apache.http.conn.routing.HttpRoute arg0, org.apache.http.protocol.HttpContext arg1, org.apache.http.@params.HttpParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._open26275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._open26275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getRoute26276;
		public override global::org.apache.http.conn.routing.HttpRoute getRoute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._getRoute26276)) as org.apache.http.conn.routing.HttpRoute;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._getRoute26276)) as org.apache.http.conn.routing.HttpRoute;
		}
		internal static global::MonoJavaBridge.MethodId _tunnelTarget26277;
		public override void tunnelTarget(bool arg0, org.apache.http.@params.HttpParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._tunnelTarget26277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._tunnelTarget26277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _tunnelProxy26278;
		public override void tunnelProxy(org.apache.http.HttpHost arg0, bool arg1, org.apache.http.@params.HttpParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._tunnelProxy26278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._tunnelProxy26278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _layerProtocol26279;
		public override void layerProtocol(org.apache.http.protocol.HttpContext arg0, org.apache.http.@params.HttpParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._layerProtocol26279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._layerProtocol26279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _detach26280;
		protected override void detach() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._detach26280);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._detach26280);
		}
		internal static global::MonoJavaBridge.MethodId _assertAttached26281;
		protected virtual void assertAttached() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._assertAttached26281);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._assertAttached26281);
		}
		internal static global::MonoJavaBridge.MethodId _AbstractPooledConnAdapter26282;
		protected AbstractPooledConnAdapter(org.apache.http.conn.ClientConnectionManager arg0, org.apache.http.impl.conn.AbstractPoolEntry arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractPooledConnAdapter._AbstractPooledConnAdapter26282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/AbstractPooledConnAdapter"));
			global::org.apache.http.impl.conn.AbstractPooledConnAdapter._shutdown26271 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, "shutdown", "()V");
			global::org.apache.http.impl.conn.AbstractPooledConnAdapter._getState26272 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, "getState", "()Ljava/lang/Object;");
			global::org.apache.http.impl.conn.AbstractPooledConnAdapter._close26273 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, "close", "()V");
			global::org.apache.http.impl.conn.AbstractPooledConnAdapter._setState26274 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, "setState", "(Ljava/lang/Object;)V");
			global::org.apache.http.impl.conn.AbstractPooledConnAdapter._open26275 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, "open", "(Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractPooledConnAdapter._getRoute26276 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, "getRoute", "()Lorg/apache/http/conn/routing/HttpRoute;");
			global::org.apache.http.impl.conn.AbstractPooledConnAdapter._tunnelTarget26277 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, "tunnelTarget", "(ZLorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractPooledConnAdapter._tunnelProxy26278 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, "tunnelProxy", "(Lorg/apache/http/HttpHost;ZLorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractPooledConnAdapter._layerProtocol26279 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, "layerProtocol", "(Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractPooledConnAdapter._detach26280 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, "detach", "()V");
			global::org.apache.http.impl.conn.AbstractPooledConnAdapter._assertAttached26281 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, "assertAttached", "()V");
			global::org.apache.http.impl.conn.AbstractPooledConnAdapter._AbstractPooledConnAdapter26282 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPooledConnAdapter.staticClass, "<init>", "(Lorg/apache/http/conn/ClientConnectionManager;Lorg/apache/http/impl/conn/AbstractPoolEntry;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.conn.AbstractPooledConnAdapter))]
	public sealed partial class AbstractPooledConnAdapter_ : org.apache.http.impl.conn.AbstractPooledConnAdapter
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
