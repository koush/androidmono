namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SSLContext : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SSLContext()
		{
			InitJNI();
		}
		protected SSLContext(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public static global::javax.net.ssl.SSLContext Default
		{
			get
			{
				return getDefault();
			}
			set
			{
				setDefault(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefault29763;
		public static global::javax.net.ssl.SSLContext getDefault() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.SSLContext.staticClass, global::javax.net.ssl.SSLContext._getDefault29763)) as javax.net.ssl.SSLContext;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance29764;
		public static global::javax.net.ssl.SSLContext getInstance(java.lang.String arg0, java.security.Provider arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.SSLContext.staticClass, global::javax.net.ssl.SSLContext._getInstance29764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLContext;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance29765;
		public static global::javax.net.ssl.SSLContext getInstance(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.SSLContext.staticClass, global::javax.net.ssl.SSLContext._getInstance29765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.net.ssl.SSLContext;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance29766;
		public static global::javax.net.ssl.SSLContext getInstance(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.SSLContext.staticClass, global::javax.net.ssl.SSLContext._getInstance29766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLContext;
		}
		internal static global::MonoJavaBridge.MethodId _init29767;
		public virtual void init(javax.net.ssl.KeyManager[] arg0, javax.net.ssl.TrustManager[] arg1, java.security.SecureRandom arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLContext._init29767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLContext.staticClass, global::javax.net.ssl.SSLContext._init29767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::java.lang.String Protocol
		{
			get
			{
				return getProtocol();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProtocol29768;
		public virtual global::java.lang.String getProtocol() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContext._getProtocol29768)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContext.staticClass, global::javax.net.ssl.SSLContext._getProtocol29768)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setDefault29769;
		public static void setDefault(javax.net.ssl.SSLContext arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(javax.net.ssl.SSLContext.staticClass, global::javax.net.ssl.SSLContext._setDefault29769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProvider29770;
		public virtual global::java.security.Provider getProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContext._getProvider29770)) as java.security.Provider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContext.staticClass, global::javax.net.ssl.SSLContext._getProvider29770)) as java.security.Provider;
		}
		public new global::javax.net.ssl.SSLSocketFactory SocketFactory
		{
			get
			{
				return getSocketFactory();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSocketFactory29771;
		public virtual global::javax.net.ssl.SSLSocketFactory getSocketFactory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContext._getSocketFactory29771)) as javax.net.ssl.SSLSocketFactory;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContext.staticClass, global::javax.net.ssl.SSLContext._getSocketFactory29771)) as javax.net.ssl.SSLSocketFactory;
		}
		public new global::javax.net.ssl.SSLServerSocketFactory ServerSocketFactory
		{
			get
			{
				return getServerSocketFactory();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getServerSocketFactory29772;
		public virtual global::javax.net.ssl.SSLServerSocketFactory getServerSocketFactory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContext._getServerSocketFactory29772)) as javax.net.ssl.SSLServerSocketFactory;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContext.staticClass, global::javax.net.ssl.SSLContext._getServerSocketFactory29772)) as javax.net.ssl.SSLServerSocketFactory;
		}
		internal static global::MonoJavaBridge.MethodId _createSSLEngine29773;
		public virtual global::javax.net.ssl.SSLEngine createSSLEngine() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContext._createSSLEngine29773)) as javax.net.ssl.SSLEngine;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContext.staticClass, global::javax.net.ssl.SSLContext._createSSLEngine29773)) as javax.net.ssl.SSLEngine;
		}
		internal static global::MonoJavaBridge.MethodId _createSSLEngine29774;
		public virtual global::javax.net.ssl.SSLEngine createSSLEngine(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContext._createSSLEngine29774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLEngine;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContext.staticClass, global::javax.net.ssl.SSLContext._createSSLEngine29774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLEngine;
		}
		public new global::javax.net.ssl.SSLSessionContext ServerSessionContext
		{
			get
			{
				return getServerSessionContext();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getServerSessionContext29775;
		public virtual global::javax.net.ssl.SSLSessionContext getServerSessionContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSessionContext>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContext._getServerSessionContext29775)) as javax.net.ssl.SSLSessionContext;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSessionContext>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContext.staticClass, global::javax.net.ssl.SSLContext._getServerSessionContext29775)) as javax.net.ssl.SSLSessionContext;
		}
		public new global::javax.net.ssl.SSLSessionContext ClientSessionContext
		{
			get
			{
				return getClientSessionContext();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getClientSessionContext29776;
		public virtual global::javax.net.ssl.SSLSessionContext getClientSessionContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSessionContext>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContext._getClientSessionContext29776)) as javax.net.ssl.SSLSessionContext;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSessionContext>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContext.staticClass, global::javax.net.ssl.SSLContext._getClientSessionContext29776)) as javax.net.ssl.SSLSessionContext;
		}
		internal static global::MonoJavaBridge.MethodId _SSLContext29777;
		protected SSLContext(javax.net.ssl.SSLContextSpi arg0, java.security.Provider arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLContext.staticClass, global::javax.net.ssl.SSLContext._SSLContext29777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLContext.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLContext"));
			global::javax.net.ssl.SSLContext._getDefault29763 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.SSLContext.staticClass, "getDefault", "()Ljavax/net/ssl/SSLContext;");
			global::javax.net.ssl.SSLContext._getInstance29764 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.SSLContext.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/net/ssl/SSLContext;");
			global::javax.net.ssl.SSLContext._getInstance29765 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.SSLContext.staticClass, "getInstance", "(Ljava/lang/String;)Ljavax/net/ssl/SSLContext;");
			global::javax.net.ssl.SSLContext._getInstance29766 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.SSLContext.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/net/ssl/SSLContext;");
			global::javax.net.ssl.SSLContext._init29767 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContext.staticClass, "init", "([Ljavax/net/ssl/KeyManager;[Ljavax/net/ssl/TrustManager;Ljava/security/SecureRandom;)V");
			global::javax.net.ssl.SSLContext._getProtocol29768 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContext.staticClass, "getProtocol", "()Ljava/lang/String;");
			global::javax.net.ssl.SSLContext._setDefault29769 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.SSLContext.staticClass, "setDefault", "(Ljavax/net/ssl/SSLContext;)V");
			global::javax.net.ssl.SSLContext._getProvider29770 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContext.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::javax.net.ssl.SSLContext._getSocketFactory29771 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContext.staticClass, "getSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;");
			global::javax.net.ssl.SSLContext._getServerSocketFactory29772 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContext.staticClass, "getServerSocketFactory", "()Ljavax/net/ssl/SSLServerSocketFactory;");
			global::javax.net.ssl.SSLContext._createSSLEngine29773 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContext.staticClass, "createSSLEngine", "()Ljavax/net/ssl/SSLEngine;");
			global::javax.net.ssl.SSLContext._createSSLEngine29774 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContext.staticClass, "createSSLEngine", "(Ljava/lang/String;I)Ljavax/net/ssl/SSLEngine;");
			global::javax.net.ssl.SSLContext._getServerSessionContext29775 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContext.staticClass, "getServerSessionContext", "()Ljavax/net/ssl/SSLSessionContext;");
			global::javax.net.ssl.SSLContext._getClientSessionContext29776 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContext.staticClass, "getClientSessionContext", "()Ljavax/net/ssl/SSLSessionContext;");
			global::javax.net.ssl.SSLContext._SSLContext29777 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContext.staticClass, "<init>", "(Ljavax/net/ssl/SSLContextSpi;Ljava/security/Provider;Ljava/lang/String;)V");
		}
	}
}
