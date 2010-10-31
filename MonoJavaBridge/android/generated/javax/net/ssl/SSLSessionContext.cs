namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.net.ssl.SSLSessionContext_))]
	public partial interface SSLSessionContext  : global::MonoJavaBridge.IJavaObject 
	{
		global::javax.net.ssl.SSLSession getSession(byte[] arg0);
		global::java.util.Enumeration getIds();
		void setSessionTimeout(int arg0);
		int getSessionTimeout();
		void setSessionCacheSize(int arg0);
		int getSessionCacheSize();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.SSLSessionContext))]
	internal sealed partial class SSLSessionContext_ : java.lang.Object, SSLSessionContext
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SSLSessionContext_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::javax.net.ssl.SSLSession javax.net.ssl.SSLSessionContext.getSession(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.net.ssl.SSLSession>(this, global::javax.net.ssl.SSLSessionContext_.staticClass, "getSession", "([B)Ljavax/net/ssl/SSLSession;", ref global::javax.net.ssl.SSLSessionContext_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.net.ssl.SSLSession;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.util.Enumeration javax.net.ssl.SSLSessionContext.getIds()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::javax.net.ssl.SSLSessionContext_.staticClass, "getIds", "()Ljava/util/Enumeration;", ref global::javax.net.ssl.SSLSessionContext_._m1) as java.util.Enumeration;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void javax.net.ssl.SSLSessionContext.setSessionTimeout(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLSessionContext_.staticClass, "setSessionTimeout", "(I)V", ref global::javax.net.ssl.SSLSessionContext_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		int javax.net.ssl.SSLSessionContext.getSessionTimeout()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.net.ssl.SSLSessionContext_.staticClass, "getSessionTimeout", "()I", ref global::javax.net.ssl.SSLSessionContext_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void javax.net.ssl.SSLSessionContext.setSessionCacheSize(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLSessionContext_.staticClass, "setSessionCacheSize", "(I)V", ref global::javax.net.ssl.SSLSessionContext_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		int javax.net.ssl.SSLSessionContext.getSessionCacheSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.net.ssl.SSLSessionContext_.staticClass, "getSessionCacheSize", "()I", ref global::javax.net.ssl.SSLSessionContext_._m5);
		}
		static SSLSessionContext_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLSessionContext_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLSessionContext"));
		}
	}
}
