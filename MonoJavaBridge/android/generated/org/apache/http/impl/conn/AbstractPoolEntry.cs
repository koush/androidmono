namespace org.apache.http.impl.conn
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.impl.conn.AbstractPoolEntry_))]
	public abstract partial class AbstractPoolEntry : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractPoolEntry(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getState33005;
		public virtual global::java.lang.Object getState()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.AbstractPoolEntry.staticClass, global::org.apache.http.impl.conn.AbstractPoolEntry._getState33005)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setState33006;
		public virtual void setState(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractPoolEntry.staticClass, global::org.apache.http.impl.conn.AbstractPoolEntry._setState33006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _open33007;
		public virtual void open(org.apache.http.conn.routing.HttpRoute arg0, org.apache.http.protocol.HttpContext arg1, org.apache.http.@params.HttpParams arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractPoolEntry.staticClass, global::org.apache.http.impl.conn.AbstractPoolEntry._open33007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _tunnelTarget33008;
		public virtual void tunnelTarget(bool arg0, org.apache.http.@params.HttpParams arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractPoolEntry.staticClass, global::org.apache.http.impl.conn.AbstractPoolEntry._tunnelTarget33008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _tunnelProxy33009;
		public virtual void tunnelProxy(org.apache.http.HttpHost arg0, bool arg1, org.apache.http.@params.HttpParams arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractPoolEntry.staticClass, global::org.apache.http.impl.conn.AbstractPoolEntry._tunnelProxy33009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _layerProtocol33010;
		public virtual void layerProtocol(org.apache.http.protocol.HttpContext arg0, org.apache.http.@params.HttpParams arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractPoolEntry.staticClass, global::org.apache.http.impl.conn.AbstractPoolEntry._layerProtocol33010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _shutdownEntry33011;
		protected virtual void shutdownEntry()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractPoolEntry.staticClass, global::org.apache.http.impl.conn.AbstractPoolEntry._shutdownEntry33011);
		}
		internal static global::MonoJavaBridge.MethodId _AbstractPoolEntry33012;
		protected AbstractPoolEntry(org.apache.http.conn.ClientConnectionOperator arg0, org.apache.http.conn.routing.HttpRoute arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.AbstractPoolEntry.staticClass, global::org.apache.http.impl.conn.AbstractPoolEntry._AbstractPoolEntry33012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static AbstractPoolEntry()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.AbstractPoolEntry.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/AbstractPoolEntry"));
			global::org.apache.http.impl.conn.AbstractPoolEntry._getState33005 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPoolEntry.staticClass, "getState", "()Ljava/lang/Object;");
			global::org.apache.http.impl.conn.AbstractPoolEntry._setState33006 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPoolEntry.staticClass, "setState", "(Ljava/lang/Object;)V");
			global::org.apache.http.impl.conn.AbstractPoolEntry._open33007 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPoolEntry.staticClass, "open", "(Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractPoolEntry._tunnelTarget33008 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPoolEntry.staticClass, "tunnelTarget", "(ZLorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractPoolEntry._tunnelProxy33009 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPoolEntry.staticClass, "tunnelProxy", "(Lorg/apache/http/HttpHost;ZLorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractPoolEntry._layerProtocol33010 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPoolEntry.staticClass, "layerProtocol", "(Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractPoolEntry._shutdownEntry33011 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPoolEntry.staticClass, "shutdownEntry", "()V");
			global::org.apache.http.impl.conn.AbstractPoolEntry._AbstractPoolEntry33012 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractPoolEntry.staticClass, "<init>", "(Lorg/apache/http/conn/ClientConnectionOperator;Lorg/apache/http/conn/routing/HttpRoute;)V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.conn.AbstractPoolEntry))]
	internal sealed partial class AbstractPoolEntry_ : org.apache.http.impl.conn.AbstractPoolEntry
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractPoolEntry_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static AbstractPoolEntry_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.AbstractPoolEntry_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/AbstractPoolEntry"));
		}
		internal static void InitJNI()
		{
		}
	}
}
