namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TrustManagerFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TrustManagerFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInstance30122;
		public static global::javax.net.ssl.TrustManagerFactory getInstance(java.lang.String arg0, java.security.Provider arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.TrustManagerFactory.staticClass, global::javax.net.ssl.TrustManagerFactory._getInstance30122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.TrustManagerFactory;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance30123;
		public static global::javax.net.ssl.TrustManagerFactory getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.TrustManagerFactory.staticClass, global::javax.net.ssl.TrustManagerFactory._getInstance30123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.net.ssl.TrustManagerFactory;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance30124;
		public static global::javax.net.ssl.TrustManagerFactory getInstance(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.TrustManagerFactory.staticClass, global::javax.net.ssl.TrustManagerFactory._getInstance30124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.TrustManagerFactory;
		}
		internal static global::MonoJavaBridge.MethodId _init30125;
		public virtual void init(java.security.KeyStore arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.TrustManagerFactory._init30125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.TrustManagerFactory.staticClass, global::javax.net.ssl.TrustManagerFactory._init30125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _init30126;
		public virtual void init(javax.net.ssl.ManagerFactoryParameters arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.TrustManagerFactory._init30126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.TrustManagerFactory.staticClass, global::javax.net.ssl.TrustManagerFactory._init30126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm30127;
		public virtual global::java.lang.String getAlgorithm()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.TrustManagerFactory._getAlgorithm30127)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.TrustManagerFactory.staticClass, global::javax.net.ssl.TrustManagerFactory._getAlgorithm30127)) as java.lang.String;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProvider30128;
		public virtual global::java.security.Provider getProvider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.TrustManagerFactory._getProvider30128)) as java.security.Provider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.TrustManagerFactory.staticClass, global::javax.net.ssl.TrustManagerFactory._getProvider30128)) as java.security.Provider;
		}
		public static global::java.lang.String DefaultAlgorithm
		{
			get
			{
				return getDefaultAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultAlgorithm30129;
		public static global::java.lang.String getDefaultAlgorithm()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(javax.net.ssl.TrustManagerFactory.staticClass, global::javax.net.ssl.TrustManagerFactory._getDefaultAlgorithm30129)) as java.lang.String;
		}
		public new global::javax.net.ssl.TrustManager[] TrustManagers
		{
			get
			{
				return getTrustManagers();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTrustManagers30130;
		public virtual global::javax.net.ssl.TrustManager[] getTrustManagers()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<javax.net.ssl.TrustManager>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.TrustManagerFactory._getTrustManagers30130)) as javax.net.ssl.TrustManager[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<javax.net.ssl.TrustManager>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.TrustManagerFactory.staticClass, global::javax.net.ssl.TrustManagerFactory._getTrustManagers30130)) as javax.net.ssl.TrustManager[];
		}
		internal static global::MonoJavaBridge.MethodId _TrustManagerFactory30131;
		protected TrustManagerFactory(javax.net.ssl.TrustManagerFactorySpi arg0, java.security.Provider arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.TrustManagerFactory.staticClass, global::javax.net.ssl.TrustManagerFactory._TrustManagerFactory30131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static TrustManagerFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.TrustManagerFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/TrustManagerFactory"));
			global::javax.net.ssl.TrustManagerFactory._getInstance30122 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactory.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/net/ssl/TrustManagerFactory;");
			global::javax.net.ssl.TrustManagerFactory._getInstance30123 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactory.staticClass, "getInstance", "(Ljava/lang/String;)Ljavax/net/ssl/TrustManagerFactory;");
			global::javax.net.ssl.TrustManagerFactory._getInstance30124 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactory.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/net/ssl/TrustManagerFactory;");
			global::javax.net.ssl.TrustManagerFactory._init30125 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactory.staticClass, "init", "(Ljava/security/KeyStore;)V");
			global::javax.net.ssl.TrustManagerFactory._init30126 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactory.staticClass, "init", "(Ljavax/net/ssl/ManagerFactoryParameters;)V");
			global::javax.net.ssl.TrustManagerFactory._getAlgorithm30127 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactory.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::javax.net.ssl.TrustManagerFactory._getProvider30128 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactory.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::javax.net.ssl.TrustManagerFactory._getDefaultAlgorithm30129 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactory.staticClass, "getDefaultAlgorithm", "()Ljava/lang/String;");
			global::javax.net.ssl.TrustManagerFactory._getTrustManagers30130 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactory.staticClass, "getTrustManagers", "()[Ljavax/net/ssl/TrustManager;");
			global::javax.net.ssl.TrustManagerFactory._TrustManagerFactory30131 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactory.staticClass, "<init>", "(Ljavax/net/ssl/TrustManagerFactorySpi;Ljava/security/Provider;Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
