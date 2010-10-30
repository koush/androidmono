namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class KeyManagerFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected KeyManagerFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInstance29862;
		public static global::javax.net.ssl.KeyManagerFactory getInstance(java.lang.String arg0, java.security.Provider arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.KeyManagerFactory._getInstance29862.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.KeyManagerFactory._getInstance29862 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.KeyManagerFactory.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/net/ssl/KeyManagerFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.KeyManagerFactory.staticClass, global::javax.net.ssl.KeyManagerFactory._getInstance29862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.KeyManagerFactory;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance29863;
		public static global::javax.net.ssl.KeyManagerFactory getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.KeyManagerFactory._getInstance29863.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.KeyManagerFactory._getInstance29863 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.KeyManagerFactory.staticClass, "getInstance", "(Ljava/lang/String;)Ljavax/net/ssl/KeyManagerFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.KeyManagerFactory.staticClass, global::javax.net.ssl.KeyManagerFactory._getInstance29863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.net.ssl.KeyManagerFactory;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance29864;
		public static global::javax.net.ssl.KeyManagerFactory getInstance(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.KeyManagerFactory._getInstance29864.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.KeyManagerFactory._getInstance29864 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.KeyManagerFactory.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/net/ssl/KeyManagerFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.KeyManagerFactory.staticClass, global::javax.net.ssl.KeyManagerFactory._getInstance29864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.KeyManagerFactory;
		}
		internal static global::MonoJavaBridge.MethodId _init29865;
		public virtual void init(java.security.KeyStore arg0, char[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.KeyManagerFactory._init29865.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.KeyManagerFactory._init29865 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.KeyManagerFactory.staticClass, "init", "(Ljava/security/KeyStore;[C)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.KeyManagerFactory.staticClass, global::javax.net.ssl.KeyManagerFactory._init29865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _init29866;
		public virtual void init(javax.net.ssl.ManagerFactoryParameters arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.KeyManagerFactory._init29866.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.KeyManagerFactory._init29866 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.KeyManagerFactory.staticClass, "init", "(Ljavax/net/ssl/ManagerFactoryParameters;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.KeyManagerFactory.staticClass, global::javax.net.ssl.KeyManagerFactory._init29866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm29867;
		public virtual global::java.lang.String getAlgorithm()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.KeyManagerFactory._getAlgorithm29867.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.KeyManagerFactory._getAlgorithm29867 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.KeyManagerFactory.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.net.ssl.KeyManagerFactory.staticClass, global::javax.net.ssl.KeyManagerFactory._getAlgorithm29867) as java.lang.String;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProvider29868;
		public virtual global::java.security.Provider getProvider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.KeyManagerFactory._getProvider29868.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.KeyManagerFactory._getProvider29868 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.KeyManagerFactory.staticClass, "getProvider", "()Ljava/security/Provider;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.KeyManagerFactory.staticClass, global::javax.net.ssl.KeyManagerFactory._getProvider29868) as java.security.Provider;
		}
		public static global::java.lang.String DefaultAlgorithm
		{
			get
			{
				return getDefaultAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultAlgorithm29869;
		public static global::java.lang.String getDefaultAlgorithm()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.KeyManagerFactory._getDefaultAlgorithm29869.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.KeyManagerFactory._getDefaultAlgorithm29869 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.KeyManagerFactory.staticClass, "getDefaultAlgorithm", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(javax.net.ssl.KeyManagerFactory.staticClass, global::javax.net.ssl.KeyManagerFactory._getDefaultAlgorithm29869)) as java.lang.String;
		}
		public new global::javax.net.ssl.KeyManager[] KeyManagers
		{
			get
			{
				return getKeyManagers();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getKeyManagers29870;
		public virtual global::javax.net.ssl.KeyManager[] getKeyManagers()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.KeyManagerFactory._getKeyManagers29870.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.KeyManagerFactory._getKeyManagers29870 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.KeyManagerFactory.staticClass, "getKeyManagers", "()[Ljavax/net/ssl/KeyManager;");
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<javax.net.ssl.KeyManager>(this, global::javax.net.ssl.KeyManagerFactory.staticClass, global::javax.net.ssl.KeyManagerFactory._getKeyManagers29870) as javax.net.ssl.KeyManager[];
		}
		internal static global::MonoJavaBridge.MethodId _KeyManagerFactory29871;
		protected KeyManagerFactory(javax.net.ssl.KeyManagerFactorySpi arg0, java.security.Provider arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.KeyManagerFactory._KeyManagerFactory29871.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.KeyManagerFactory._KeyManagerFactory29871 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.KeyManagerFactory.staticClass, "<init>", "(Ljavax/net/ssl/KeyManagerFactorySpi;Ljava/security/Provider;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.KeyManagerFactory.staticClass, global::javax.net.ssl.KeyManagerFactory._KeyManagerFactory29871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static KeyManagerFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.KeyManagerFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/KeyManagerFactory"));
		}
		internal static void InitJNI()
		{
		}
	}
}
