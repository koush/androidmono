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
		internal static global::MonoJavaBridge.MethodId _getInstance23572;
		public static global::javax.net.ssl.TrustManagerFactory getInstance(java.lang.String arg0, java.security.Provider arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.TrustManagerFactory.staticClass, global::javax.net.ssl.TrustManagerFactory._getInstance23572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.TrustManagerFactory;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23573;
		public static global::javax.net.ssl.TrustManagerFactory getInstance(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.TrustManagerFactory.staticClass, global::javax.net.ssl.TrustManagerFactory._getInstance23573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.net.ssl.TrustManagerFactory;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23574;
		public static global::javax.net.ssl.TrustManagerFactory getInstance(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.TrustManagerFactory.staticClass, global::javax.net.ssl.TrustManagerFactory._getInstance23574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.TrustManagerFactory;
		}
		internal static global::MonoJavaBridge.MethodId _init23575;
		public virtual void init(java.security.KeyStore arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.TrustManagerFactory._init23575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.TrustManagerFactory.staticClass, global::javax.net.ssl.TrustManagerFactory._init23575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _init23576;
		public virtual void init(javax.net.ssl.ManagerFactoryParameters arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.TrustManagerFactory._init23576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.TrustManagerFactory.staticClass, global::javax.net.ssl.TrustManagerFactory._init23576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm23577;
		public virtual global::java.lang.String getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.TrustManagerFactory._getAlgorithm23577)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.TrustManagerFactory.staticClass, global::javax.net.ssl.TrustManagerFactory._getAlgorithm23577)) as java.lang.String;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProvider23578;
		public virtual global::java.security.Provider getProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.TrustManagerFactory._getProvider23578)) as java.security.Provider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.TrustManagerFactory.staticClass, global::javax.net.ssl.TrustManagerFactory._getProvider23578)) as java.security.Provider;
		}
		public static global::java.lang.String DefaultAlgorithm
		{
			get
			{
				return getDefaultAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultAlgorithm23579;
		public static global::java.lang.String getDefaultAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.TrustManagerFactory.staticClass, global::javax.net.ssl.TrustManagerFactory._getDefaultAlgorithm23579)) as java.lang.String;
		}
		public new global::javax.net.ssl.TrustManager[] TrustManagers
		{
			get
			{
				return getTrustManagers();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTrustManagers23580;
		public virtual global::javax.net.ssl.TrustManager[] getTrustManagers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<javax.net.ssl.TrustManager>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.TrustManagerFactory._getTrustManagers23580)) as javax.net.ssl.TrustManager[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<javax.net.ssl.TrustManager>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.TrustManagerFactory.staticClass, global::javax.net.ssl.TrustManagerFactory._getTrustManagers23580)) as javax.net.ssl.TrustManager[];
		}
		internal static global::MonoJavaBridge.MethodId _TrustManagerFactory23581;
		protected TrustManagerFactory(javax.net.ssl.TrustManagerFactorySpi arg0, java.security.Provider arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.TrustManagerFactory.staticClass, global::javax.net.ssl.TrustManagerFactory._TrustManagerFactory23581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.TrustManagerFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/TrustManagerFactory"));
			global::javax.net.ssl.TrustManagerFactory._getInstance23572 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactory.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/net/ssl/TrustManagerFactory;");
			global::javax.net.ssl.TrustManagerFactory._getInstance23573 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactory.staticClass, "getInstance", "(Ljava/lang/String;)Ljavax/net/ssl/TrustManagerFactory;");
			global::javax.net.ssl.TrustManagerFactory._getInstance23574 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactory.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/net/ssl/TrustManagerFactory;");
			global::javax.net.ssl.TrustManagerFactory._init23575 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactory.staticClass, "init", "(Ljava/security/KeyStore;)V");
			global::javax.net.ssl.TrustManagerFactory._init23576 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactory.staticClass, "init", "(Ljavax/net/ssl/ManagerFactoryParameters;)V");
			global::javax.net.ssl.TrustManagerFactory._getAlgorithm23577 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactory.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::javax.net.ssl.TrustManagerFactory._getProvider23578 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactory.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::javax.net.ssl.TrustManagerFactory._getDefaultAlgorithm23579 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactory.staticClass, "getDefaultAlgorithm", "()Ljava/lang/String;");
			global::javax.net.ssl.TrustManagerFactory._getTrustManagers23580 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactory.staticClass, "getTrustManagers", "()[Ljavax/net/ssl/TrustManager;");
			global::javax.net.ssl.TrustManagerFactory._TrustManagerFactory23581 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactory.staticClass, "<init>", "(Ljavax/net/ssl/TrustManagerFactorySpi;Ljava/security/Provider;Ljava/lang/String;)V");
		}
	}
}
