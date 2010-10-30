namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TrustManagerFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TrustManagerFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::javax.net.ssl.TrustManagerFactory getInstance(java.lang.String arg0, java.security.Provider arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.TrustManagerFactory._m0.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.TrustManagerFactory._m0 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactory.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/net/ssl/TrustManagerFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.TrustManagerFactory.staticClass, global::javax.net.ssl.TrustManagerFactory._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.TrustManagerFactory;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::javax.net.ssl.TrustManagerFactory getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.TrustManagerFactory._m1.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.TrustManagerFactory._m1 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactory.staticClass, "getInstance", "(Ljava/lang/String;)Ljavax/net/ssl/TrustManagerFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.TrustManagerFactory.staticClass, global::javax.net.ssl.TrustManagerFactory._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.net.ssl.TrustManagerFactory;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::javax.net.ssl.TrustManagerFactory getInstance(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.TrustManagerFactory._m2.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.TrustManagerFactory._m2 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactory.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/net/ssl/TrustManagerFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.TrustManagerFactory.staticClass, global::javax.net.ssl.TrustManagerFactory._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.TrustManagerFactory;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void init(java.security.KeyStore arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.TrustManagerFactory.staticClass, "init", "(Ljava/security/KeyStore;)V", ref global::javax.net.ssl.TrustManagerFactory._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void init(javax.net.ssl.ManagerFactoryParameters arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.TrustManagerFactory.staticClass, "init", "(Ljavax/net/ssl/ManagerFactoryParameters;)V", ref global::javax.net.ssl.TrustManagerFactory._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.String getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.net.ssl.TrustManagerFactory.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::javax.net.ssl.TrustManagerFactory._m5) as java.lang.String;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.security.Provider getProvider()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.TrustManagerFactory.staticClass, "getProvider", "()Ljava/security/Provider;", ref global::javax.net.ssl.TrustManagerFactory._m6) as java.security.Provider;
		}
		public static global::java.lang.String DefaultAlgorithm
		{
			get
			{
				return getDefaultAlgorithm();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static global::java.lang.String getDefaultAlgorithm()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.TrustManagerFactory._m7.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.TrustManagerFactory._m7 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactory.staticClass, "getDefaultAlgorithm", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(javax.net.ssl.TrustManagerFactory.staticClass, global::javax.net.ssl.TrustManagerFactory._m7)) as java.lang.String;
		}
		public new global::javax.net.ssl.TrustManager[] TrustManagers
		{
			get
			{
				return getTrustManagers();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::javax.net.ssl.TrustManager[] getTrustManagers()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<javax.net.ssl.TrustManager>(this, global::javax.net.ssl.TrustManagerFactory.staticClass, "getTrustManagers", "()[Ljavax/net/ssl/TrustManager;", ref global::javax.net.ssl.TrustManagerFactory._m8) as javax.net.ssl.TrustManager[];
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected TrustManagerFactory(javax.net.ssl.TrustManagerFactorySpi arg0, java.security.Provider arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.TrustManagerFactory._m9.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.TrustManagerFactory._m9 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactory.staticClass, "<init>", "(Ljavax/net/ssl/TrustManagerFactorySpi;Ljava/security/Provider;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.TrustManagerFactory.staticClass, global::javax.net.ssl.TrustManagerFactory._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static TrustManagerFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.TrustManagerFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/TrustManagerFactory"));
		}
		internal static void InitJNI()
		{
		}
	}
}
