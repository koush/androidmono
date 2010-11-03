namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CertStore : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CertStore(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.security.cert.CertStore getInstance(java.lang.String arg0, java.security.cert.CertStoreParameters arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertStore._m0.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertStore._m0 = @__env.GetStaticMethodIDNoThrow(global::java.security.cert.CertStore.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/cert/CertStoreParameters;Ljava/lang/String;)Ljava/security/cert/CertStore;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.cert.CertStore.staticClass, global::java.security.cert.CertStore._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.security.cert.CertStore;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.security.cert.CertStore getInstance(java.lang.String arg0, java.security.cert.CertStoreParameters arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertStore._m1.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertStore._m1 = @__env.GetStaticMethodIDNoThrow(global::java.security.cert.CertStore.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/cert/CertStoreParameters;)Ljava/security/cert/CertStore;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.cert.CertStore.staticClass, global::java.security.cert.CertStore._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.cert.CertStore;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.security.cert.CertStore getInstance(java.lang.String arg0, java.security.cert.CertStoreParameters arg1, java.security.Provider arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertStore._m2.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertStore._m2 = @__env.GetStaticMethodIDNoThrow(global::java.security.cert.CertStore.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/cert/CertStoreParameters;Ljava/security/Provider;)Ljava/security/cert/CertStore;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.cert.CertStore.staticClass, global::java.security.cert.CertStore._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.security.cert.CertStore;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.util.Collection getCertificates(java.security.cert.CertSelector arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.security.cert.CertStore.staticClass, "getCertificates", "(Ljava/security/cert/CertSelector;)Ljava/util/Collection;", ref global::java.security.cert.CertStore._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Collection;
		}
		public new global::java.lang.String Type
		{
			get
			{
				return getType();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.String getType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.CertStore.staticClass, "getType", "()Ljava/lang/String;", ref global::java.security.cert.CertStore._m4) as java.lang.String;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.security.Provider getProvider()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.CertStore.staticClass, "getProvider", "()Ljava/security/Provider;", ref global::java.security.cert.CertStore._m5) as java.security.Provider;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.util.Collection getCRLs(java.security.cert.CRLSelector arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.security.cert.CertStore.staticClass, "getCRLs", "(Ljava/security/cert/CRLSelector;)Ljava/util/Collection;", ref global::java.security.cert.CertStore._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Collection;
		}
		public static global::java.lang.String DefaultType
		{
			get
			{
				return getDefaultType();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static global::java.lang.String getDefaultType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertStore._m7.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertStore._m7 = @__env.GetStaticMethodIDNoThrow(global::java.security.cert.CertStore.staticClass, "getDefaultType", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.security.cert.CertStore.staticClass, global::java.security.cert.CertStore._m7)) as java.lang.String;
		}
		public new global::java.security.cert.CertStoreParameters CertStoreParameters
		{
			get
			{
				return getCertStoreParameters();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.security.cert.CertStoreParameters getCertStoreParameters()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.cert.CertStoreParameters>(this, global::java.security.cert.CertStore.staticClass, "getCertStoreParameters", "()Ljava/security/cert/CertStoreParameters;", ref global::java.security.cert.CertStore._m8) as java.security.cert.CertStoreParameters;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected CertStore(java.security.cert.CertStoreSpi arg0, java.security.Provider arg1, java.lang.String arg2, java.security.cert.CertStoreParameters arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertStore._m9.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertStore._m9 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertStore.staticClass, "<init>", "(Ljava/security/cert/CertStoreSpi;Ljava/security/Provider;Ljava/lang/String;Ljava/security/cert/CertStoreParameters;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertStore.staticClass, global::java.security.cert.CertStore._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static CertStore()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertStore.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertStore"));
		}
	}
}
