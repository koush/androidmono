namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.net.ssl.SSLSessionContext_))]
	public interface SSLSessionContext  : global::MonoJavaBridge.IJavaObject 
	{
		global::javax.net.ssl.SSLSession getSession(byte[] arg0);
		global::java.util.Enumeration getIds();
		void setSessionTimeout(int arg0);
		int getSessionTimeout();
		void setSessionCacheSize(int arg0);
		int getSessionCacheSize();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.SSLSessionContext))]
	public sealed partial class SSLSessionContext_ : java.lang.Object, SSLSessionContext
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SSLSessionContext_()
		{
			InitJNI();
		}
		internal SSLSessionContext_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getSession29944;
		 global::javax.net.ssl.SSLSession javax.net.ssl.SSLSessionContext.getSession(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionContext_._getSession29944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.net.ssl.SSLSession;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionContext_.staticClass, global::javax.net.ssl.SSLSessionContext_._getSession29944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.net.ssl.SSLSession;
		}
		internal static global::MonoJavaBridge.MethodId _getIds29945;
		 global::java.util.Enumeration javax.net.ssl.SSLSessionContext.getIds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionContext_._getIds29945)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionContext_.staticClass, global::javax.net.ssl.SSLSessionContext_._getIds29945)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _setSessionTimeout29946;
		 void javax.net.ssl.SSLSessionContext.setSessionTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionContext_._setSessionTimeout29946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionContext_.staticClass, global::javax.net.ssl.SSLSessionContext_._setSessionTimeout29946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSessionTimeout29947;
		 int javax.net.ssl.SSLSessionContext.getSessionTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionContext_._getSessionTimeout29947);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionContext_.staticClass, global::javax.net.ssl.SSLSessionContext_._getSessionTimeout29947);
		}
		internal static global::MonoJavaBridge.MethodId _setSessionCacheSize29948;
		 void javax.net.ssl.SSLSessionContext.setSessionCacheSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionContext_._setSessionCacheSize29948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionContext_.staticClass, global::javax.net.ssl.SSLSessionContext_._setSessionCacheSize29948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSessionCacheSize29949;
		 int javax.net.ssl.SSLSessionContext.getSessionCacheSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionContext_._getSessionCacheSize29949);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionContext_.staticClass, global::javax.net.ssl.SSLSessionContext_._getSessionCacheSize29949);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLSessionContext_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLSessionContext"));
			global::javax.net.ssl.SSLSessionContext_._getSession29944 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSessionContext_.staticClass, "getSession", "([B)Ljavax/net/ssl/SSLSession;");
			global::javax.net.ssl.SSLSessionContext_._getIds29945 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSessionContext_.staticClass, "getIds", "()Ljava/util/Enumeration;");
			global::javax.net.ssl.SSLSessionContext_._setSessionTimeout29946 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSessionContext_.staticClass, "setSessionTimeout", "(I)V");
			global::javax.net.ssl.SSLSessionContext_._getSessionTimeout29947 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSessionContext_.staticClass, "getSessionTimeout", "()I");
			global::javax.net.ssl.SSLSessionContext_._setSessionCacheSize29948 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSessionContext_.staticClass, "setSessionCacheSize", "(I)V");
			global::javax.net.ssl.SSLSessionContext_._getSessionCacheSize29949 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSessionContext_.staticClass, "getSessionCacheSize", "()I");
		}
	}
}
