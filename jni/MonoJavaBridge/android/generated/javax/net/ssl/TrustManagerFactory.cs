namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TrustManagerFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TrustManagerFactory()
		{
			InitJNI();
		}
		protected TrustManagerFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInstance30003;
		public static global::javax.net.ssl.TrustManagerFactory getInstance(java.lang.String arg0, java.security.Provider arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.TrustManagerFactory.staticClass, global::javax.net.ssl.TrustManagerFactory._getInstance30003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.TrustManagerFactory;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance30004;
		public static global::javax.net.ssl.TrustManagerFactory getInstance(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.TrustManagerFactory.staticClass, global::javax.net.ssl.TrustManagerFactory._getInstance30004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.net.ssl.TrustManagerFactory;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance30005;
		public static global::javax.net.ssl.TrustManagerFactory getInstance(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.TrustManagerFactory.staticClass, global::javax.net.ssl.TrustManagerFactory._getInstance30005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.TrustManagerFactory;
		}
		internal static global::MonoJavaBridge.MethodId _init30006;
		public virtual void init(java.security.KeyStore arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.TrustManagerFactory._init30006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.TrustManagerFactory.staticClass, global::javax.net.ssl.TrustManagerFactory._init30006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _init30007;
		public virtual void init(javax.net.ssl.ManagerFactoryParameters arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.TrustManagerFactory._init30007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.TrustManagerFactory.staticClass, global::javax.net.ssl.TrustManagerFactory._init30007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm30008;
		public virtual global::java.lang.String getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.TrustManagerFactory._getAlgorithm30008)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.TrustManagerFactory.staticClass, global::javax.net.ssl.TrustManagerFactory._getAlgorithm30008)) as java.lang.String;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProvider30009;
		public virtual global::java.security.Provider getProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.TrustManagerFactory._getProvider30009)) as java.security.Provider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.TrustManagerFactory.staticClass, global::javax.net.ssl.TrustManagerFactory._getProvider30009)) as java.security.Provider;
		}
		public static global::java.lang.String DefaultAlgorithm
		{
			get
			{
				return getDefaultAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultAlgorithm30010;
		public static global::java.lang.String getDefaultAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(javax.net.ssl.TrustManagerFactory.staticClass, global::javax.net.ssl.TrustManagerFactory._getDefaultAlgorithm30010)) as java.lang.String;
		}
		public new global::javax.net.ssl.TrustManager[] TrustManagers
		{
			get
			{
				return getTrustManagers();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTrustManagers30011;
		public virtual global::javax.net.ssl.TrustManager[] getTrustManagers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<javax.net.ssl.TrustManager>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.TrustManagerFactory._getTrustManagers30011)) as javax.net.ssl.TrustManager[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<javax.net.ssl.TrustManager>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.TrustManagerFactory.staticClass, global::javax.net.ssl.TrustManagerFactory._getTrustManagers30011)) as javax.net.ssl.TrustManager[];
		}
		internal static global::MonoJavaBridge.MethodId _TrustManagerFactory30012;
		protected TrustManagerFactory(javax.net.ssl.TrustManagerFactorySpi arg0, java.security.Provider arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.TrustManagerFactory.staticClass, global::javax.net.ssl.TrustManagerFactory._TrustManagerFactory30012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.TrustManagerFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/TrustManagerFactory"));
			global::javax.net.ssl.TrustManagerFactory._getInstance30003 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactory.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/net/ssl/TrustManagerFactory;");
			global::javax.net.ssl.TrustManagerFactory._getInstance30004 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactory.staticClass, "getInstance", "(Ljava/lang/String;)Ljavax/net/ssl/TrustManagerFactory;");
			global::javax.net.ssl.TrustManagerFactory._getInstance30005 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactory.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/net/ssl/TrustManagerFactory;");
			global::javax.net.ssl.TrustManagerFactory._init30006 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactory.staticClass, "init", "(Ljava/security/KeyStore;)V");
			global::javax.net.ssl.TrustManagerFactory._init30007 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactory.staticClass, "init", "(Ljavax/net/ssl/ManagerFactoryParameters;)V");
			global::javax.net.ssl.TrustManagerFactory._getAlgorithm30008 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactory.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::javax.net.ssl.TrustManagerFactory._getProvider30009 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactory.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::javax.net.ssl.TrustManagerFactory._getDefaultAlgorithm30010 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactory.staticClass, "getDefaultAlgorithm", "()Ljava/lang/String;");
			global::javax.net.ssl.TrustManagerFactory._getTrustManagers30011 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactory.staticClass, "getTrustManagers", "()[Ljavax/net/ssl/TrustManager;");
			global::javax.net.ssl.TrustManagerFactory._TrustManagerFactory30012 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactory.staticClass, "<init>", "(Ljavax/net/ssl/TrustManagerFactorySpi;Ljava/security/Provider;Ljava/lang/String;)V");
		}
	}
}
