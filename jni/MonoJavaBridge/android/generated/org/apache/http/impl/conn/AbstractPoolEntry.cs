namespace org.apache.http.impl.conn
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.impl.conn.AbstractPoolEntry_))]
	public abstract partial class AbstractPoolEntry : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractPoolEntry()
		{
			InitJNI();
		}
		protected AbstractPoolEntry(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getState26263;
		public virtual global::java.lang.Object getState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPoolEntry._getState26263)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPoolEntry.staticClass, global::org.apache.http.impl.conn.AbstractPoolEntry._getState26263)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setState26264;
		public virtual void setState(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPoolEntry._setState26264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPoolEntry.staticClass, global::org.apache.http.impl.conn.AbstractPoolEntry._setState26264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _open26265;
		public virtual void open(org.apache.http.conn.routing.HttpRoute arg0, org.apache.http.protocol.HttpContext arg1, org.apache.http.@params.HttpParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPoolEntry._open26265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPoolEntry.staticClass, global::org.apache.http.impl.conn.AbstractPoolEntry._open26265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _tunnelTarget26266;
		public virtual void tunnelTarget(bool arg0, org.apache.http.@params.HttpParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPoolEntry._tunnelTarget26266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPoolEntry.staticClass, global::org.apache.http.impl.conn.AbstractPoolEntry._tunnelTarget26266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _tunnelProxy26267;
		public virtual void tunnelProxy(org.apache.http.HttpHost arg0, bool arg1, org.apache.http.@params.HttpParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPoolEntry._tunnelProxy26267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPoolEntry.staticClass, global::org.apache.http.impl.conn.AbstractPoolEntry._tunnelProxy26267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _layerProtocol26268;
		public virtual void layerProtocol(org.apache.http.protocol.HttpContext arg0, org.apache.http.@params.HttpParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPoolEntry._layerProtocol26268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPoolEntry.staticClass, global::org.apache.http.impl.conn.AbstractPoolEntry._layerProtocol26268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _shutdownEntry26269;
		protected virtual void shutdownEntry() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPoolEntry._shutdownEntry26269);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractPoolEntry.staticClass, global::org.apache.http.impl.conn.AbstractPoolEntry._shutdownEntry26269);
		}
		internal static global::MonoJavaBridge.MethodId _AbstractPoolEntry26270;
		protected AbstractPoolEntry(org.apache.http.conn.ClientConnectionOperator arg0, org.apache.http.conn.routing.HttpRoute arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.AbstractPoolEntry.staticClass, global::org.apache.http.impl.conn.AbstractPoolEntry._AbstractPoolEntry26270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.AbstractPoolEntry.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/AbstractPoolEntry"));
			global::org.apache.http.impl.conn.AbstractPoolEntry._getState26263 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPoolEntry.staticClass, "getState", "()Ljava/lang/Object;");
			global::org.apache.http.impl.conn.AbstractPoolEntry._setState26264 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPoolEntry.staticClass, "setState", "(Ljava/lang/Object;)V");
			global::org.apache.http.impl.conn.AbstractPoolEntry._open26265 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPoolEntry.staticClass, "open", "(Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractPoolEntry._tunnelTarget26266 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPoolEntry.staticClass, "tunnelTarget", "(ZLorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractPoolEntry._tunnelProxy26267 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPoolEntry.staticClass, "tunnelProxy", "(Lorg/apache/http/HttpHost;ZLorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractPoolEntry._layerProtocol26268 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPoolEntry.staticClass, "layerProtocol", "(Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractPoolEntry._shutdownEntry26269 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPoolEntry.staticClass, "shutdownEntry", "()V");
			global::org.apache.http.impl.conn.AbstractPoolEntry._AbstractPoolEntry26270 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPoolEntry.staticClass, "<init>", "(Lorg/apache/http/conn/ClientConnectionOperator;Lorg/apache/http/conn/routing/HttpRoute;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.conn.AbstractPoolEntry))]
	public sealed partial class AbstractPoolEntry_ : org.apache.http.impl.conn.AbstractPoolEntry
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractPoolEntry_()
		{
			InitJNI();
		}
		internal AbstractPoolEntry_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.AbstractPoolEntry_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/AbstractPoolEntry"));
		}
	}
}
