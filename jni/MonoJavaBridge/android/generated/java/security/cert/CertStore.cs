namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CertStore : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CertStore()
		{
			InitJNI();
		}
		protected CertStore(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23534;
		public static global::java.security.cert.CertStore getInstance(java.lang.String arg0, java.security.cert.CertStoreParameters arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.cert.CertStore.staticClass, global::java.security.cert.CertStore._getInstance23534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.security.cert.CertStore;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23535;
		public static global::java.security.cert.CertStore getInstance(java.lang.String arg0, java.security.cert.CertStoreParameters arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.cert.CertStore.staticClass, global::java.security.cert.CertStore._getInstance23535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.cert.CertStore;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23536;
		public static global::java.security.cert.CertStore getInstance(java.lang.String arg0, java.security.cert.CertStoreParameters arg1, java.security.Provider arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.cert.CertStore.staticClass, global::java.security.cert.CertStore._getInstance23536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.security.cert.CertStore;
		}
		internal static global::MonoJavaBridge.MethodId _getCertificates23537;
		public virtual global::java.util.Collection getCertificates(java.security.cert.CertSelector arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertStore._getCertificates23537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertStore.staticClass, global::java.security.cert.CertStore._getCertificates23537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
		}
		public new global::java.lang.String Type
		{
			get
			{
				return getType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getType23538;
		public virtual global::java.lang.String getType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertStore._getType23538)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertStore.staticClass, global::java.security.cert.CertStore._getType23538)) as java.lang.String;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProvider23539;
		public virtual global::java.security.Provider getProvider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertStore._getProvider23539)) as java.security.Provider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertStore.staticClass, global::java.security.cert.CertStore._getProvider23539)) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _getCRLs23540;
		public virtual global::java.util.Collection getCRLs(java.security.cert.CRLSelector arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertStore._getCRLs23540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertStore.staticClass, global::java.security.cert.CertStore._getCRLs23540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
		}
		public static global::java.lang.String DefaultType
		{
			get
			{
				return getDefaultType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultType23541;
		public static global::java.lang.String getDefaultType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.security.cert.CertStore.staticClass, global::java.security.cert.CertStore._getDefaultType23541)) as java.lang.String;
		}
		public new global::java.security.cert.CertStoreParameters CertStoreParameters
		{
			get
			{
				return getCertStoreParameters();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCertStoreParameters23542;
		public virtual global::java.security.cert.CertStoreParameters getCertStoreParameters()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.cert.CertStoreParameters>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertStore._getCertStoreParameters23542)) as java.security.cert.CertStoreParameters;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.cert.CertStoreParameters>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertStore.staticClass, global::java.security.cert.CertStore._getCertStoreParameters23542)) as java.security.cert.CertStoreParameters;
		}
		internal static global::MonoJavaBridge.MethodId _CertStore23543;
		protected CertStore(java.security.cert.CertStoreSpi arg0, java.security.Provider arg1, java.lang.String arg2, java.security.cert.CertStoreParameters arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertStore.staticClass, global::java.security.cert.CertStore._CertStore23543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertStore.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertStore"));
			global::java.security.cert.CertStore._getInstance23534 = @__env.GetStaticMethodIDNoThrow(global::java.security.cert.CertStore.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/cert/CertStoreParameters;Ljava/lang/String;)Ljava/security/cert/CertStore;");
			global::java.security.cert.CertStore._getInstance23535 = @__env.GetStaticMethodIDNoThrow(global::java.security.cert.CertStore.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/cert/CertStoreParameters;)Ljava/security/cert/CertStore;");
			global::java.security.cert.CertStore._getInstance23536 = @__env.GetStaticMethodIDNoThrow(global::java.security.cert.CertStore.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/cert/CertStoreParameters;Ljava/security/Provider;)Ljava/security/cert/CertStore;");
			global::java.security.cert.CertStore._getCertificates23537 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertStore.staticClass, "getCertificates", "(Ljava/security/cert/CertSelector;)Ljava/util/Collection;");
			global::java.security.cert.CertStore._getType23538 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertStore.staticClass, "getType", "()Ljava/lang/String;");
			global::java.security.cert.CertStore._getProvider23539 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertStore.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::java.security.cert.CertStore._getCRLs23540 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertStore.staticClass, "getCRLs", "(Ljava/security/cert/CRLSelector;)Ljava/util/Collection;");
			global::java.security.cert.CertStore._getDefaultType23541 = @__env.GetStaticMethodIDNoThrow(global::java.security.cert.CertStore.staticClass, "getDefaultType", "()Ljava/lang/String;");
			global::java.security.cert.CertStore._getCertStoreParameters23542 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertStore.staticClass, "getCertStoreParameters", "()Ljava/security/cert/CertStoreParameters;");
			global::java.security.cert.CertStore._CertStore23543 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertStore.staticClass, "<init>", "(Ljava/security/cert/CertStoreSpi;Ljava/security/Provider;Ljava/lang/String;Ljava/security/cert/CertStoreParameters;)V");
		}
	}
}
