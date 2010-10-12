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
		internal static global::MonoJavaBridge.MethodId _getSession15993;
		 global::javax.net.ssl.SSLSession javax.net.ssl.SSLSessionContext.getSession(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionContext_._getSession15993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.net.ssl.SSLSession;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionContext_.staticClass, global::javax.net.ssl.SSLSessionContext_._getSession15993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.net.ssl.SSLSession;
		}
		internal static global::MonoJavaBridge.MethodId _getIds15994;
		 global::java.util.Enumeration javax.net.ssl.SSLSessionContext.getIds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionContext_._getIds15994)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionContext_.staticClass, global::javax.net.ssl.SSLSessionContext_._getIds15994)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _setSessionTimeout15995;
		 void javax.net.ssl.SSLSessionContext.setSessionTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionContext_._setSessionTimeout15995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionContext_.staticClass, global::javax.net.ssl.SSLSessionContext_._setSessionTimeout15995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSessionTimeout15996;
		 int javax.net.ssl.SSLSessionContext.getSessionTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionContext_._getSessionTimeout15996);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionContext_.staticClass, global::javax.net.ssl.SSLSessionContext_._getSessionTimeout15996);
		}
		internal static global::MonoJavaBridge.MethodId _setSessionCacheSize15997;
		 void javax.net.ssl.SSLSessionContext.setSessionCacheSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionContext_._setSessionCacheSize15997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionContext_.staticClass, global::javax.net.ssl.SSLSessionContext_._setSessionCacheSize15997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSessionCacheSize15998;
		 int javax.net.ssl.SSLSessionContext.getSessionCacheSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionContext_._getSessionCacheSize15998);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionContext_.staticClass, global::javax.net.ssl.SSLSessionContext_._getSessionCacheSize15998);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLSessionContext_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLSessionContext"));
			global::javax.net.ssl.SSLSessionContext_._getSession15993 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSessionContext_.staticClass, "getSession", "([B)Ljavax/net/ssl/SSLSession;");
			global::javax.net.ssl.SSLSessionContext_._getIds15994 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSessionContext_.staticClass, "getIds", "()Ljava/util/Enumeration;");
			global::javax.net.ssl.SSLSessionContext_._setSessionTimeout15995 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSessionContext_.staticClass, "setSessionTimeout", "(I)V");
			global::javax.net.ssl.SSLSessionContext_._getSessionTimeout15996 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSessionContext_.staticClass, "getSessionTimeout", "()I");
			global::javax.net.ssl.SSLSessionContext_._setSessionCacheSize15997 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSessionContext_.staticClass, "setSessionCacheSize", "(I)V");
			global::javax.net.ssl.SSLSessionContext_._getSessionCacheSize15998 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSessionContext_.staticClass, "getSessionCacheSize", "()I");
		}
	}
}
