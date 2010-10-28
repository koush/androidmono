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
		internal static global::MonoJavaBridge.MethodId _getSession30063;
		global::javax.net.ssl.SSLSession javax.net.ssl.SSLSessionContext.getSession(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionContext_._getSession30063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.net.ssl.SSLSession;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionContext_.staticClass, global::javax.net.ssl.SSLSessionContext_._getSession30063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.net.ssl.SSLSession;
		}
		internal static global::MonoJavaBridge.MethodId _getIds30064;
		global::java.util.Enumeration javax.net.ssl.SSLSessionContext.getIds()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionContext_._getIds30064)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionContext_.staticClass, global::javax.net.ssl.SSLSessionContext_._getIds30064)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _setSessionTimeout30065;
		void javax.net.ssl.SSLSessionContext.setSessionTimeout(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionContext_._setSessionTimeout30065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionContext_.staticClass, global::javax.net.ssl.SSLSessionContext_._setSessionTimeout30065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSessionTimeout30066;
		int javax.net.ssl.SSLSessionContext.getSessionTimeout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionContext_._getSessionTimeout30066);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionContext_.staticClass, global::javax.net.ssl.SSLSessionContext_._getSessionTimeout30066);
		}
		internal static global::MonoJavaBridge.MethodId _setSessionCacheSize30067;
		void javax.net.ssl.SSLSessionContext.setSessionCacheSize(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionContext_._setSessionCacheSize30067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionContext_.staticClass, global::javax.net.ssl.SSLSessionContext_._setSessionCacheSize30067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSessionCacheSize30068;
		int javax.net.ssl.SSLSessionContext.getSessionCacheSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionContext_._getSessionCacheSize30068);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionContext_.staticClass, global::javax.net.ssl.SSLSessionContext_._getSessionCacheSize30068);
		}
		static SSLSessionContext_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLSessionContext_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLSessionContext"));
			global::javax.net.ssl.SSLSessionContext_._getSession30063 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSessionContext_.staticClass, "getSession", "([B)Ljavax/net/ssl/SSLSession;");
			global::javax.net.ssl.SSLSessionContext_._getIds30064 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSessionContext_.staticClass, "getIds", "()Ljava/util/Enumeration;");
			global::javax.net.ssl.SSLSessionContext_._setSessionTimeout30065 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSessionContext_.staticClass, "setSessionTimeout", "(I)V");
			global::javax.net.ssl.SSLSessionContext_._getSessionTimeout30066 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSessionContext_.staticClass, "getSessionTimeout", "()I");
			global::javax.net.ssl.SSLSessionContext_._setSessionCacheSize30067 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSessionContext_.staticClass, "setSessionCacheSize", "(I)V");
			global::javax.net.ssl.SSLSessionContext_._getSessionCacheSize30068 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSessionContext_.staticClass, "getSessionCacheSize", "()I");
		}
		internal static void InitJNI()
		{
		}
	}
}
