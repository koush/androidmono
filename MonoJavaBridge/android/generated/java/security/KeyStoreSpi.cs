namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.KeyStoreSpi_))]
	public abstract partial class KeyStoreSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected KeyStoreSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract global::java.security.Key engineGetKey(java.lang.String arg0, char[] arg1);
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract global::java.security.cert.Certificate[] engineGetCertificateChain(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract global::java.security.cert.Certificate engineGetCertificate(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract global::java.util.Date engineGetCreationDate(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract void engineSetKeyEntry(java.lang.String arg0, java.security.Key arg1, char[] arg2, java.security.cert.Certificate[] arg3);
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract void engineSetKeyEntry(java.lang.String arg0, byte[] arg1, java.security.cert.Certificate[] arg2);
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract void engineSetCertificateEntry(java.lang.String arg0, java.security.cert.Certificate arg1);
		private static global::MonoJavaBridge.MethodId _m7;
		public abstract void engineDeleteEntry(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m8;
		public abstract global::java.util.Enumeration engineAliases();
		private static global::MonoJavaBridge.MethodId _m9;
		public abstract bool engineContainsAlias(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m10;
		public abstract int engineSize();
		private static global::MonoJavaBridge.MethodId _m11;
		public abstract bool engineIsKeyEntry(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m12;
		public abstract bool engineIsCertificateEntry(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m13;
		public abstract global::java.lang.String engineGetCertificateAlias(java.security.cert.Certificate arg0);
		private static global::MonoJavaBridge.MethodId _m14;
		public abstract void engineStore(java.io.OutputStream arg0, char[] arg1);
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void engineStore(java.security.KeyStore.LoadStoreParameter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.KeyStoreSpi.staticClass, "engineStore", "(Ljava/security/KeyStore$LoadStoreParameter;)V", ref global::java.security.KeyStoreSpi._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public abstract void engineLoad(java.io.InputStream arg0, char[] arg1);
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void engineLoad(java.security.KeyStore.LoadStoreParameter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.KeyStoreSpi.staticClass, "engineLoad", "(Ljava/security/KeyStore$LoadStoreParameter;)V", ref global::java.security.KeyStoreSpi._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual global::java.security.KeyStore.Entry engineGetEntry(java.lang.String arg0, java.security.KeyStore.ProtectionParameter arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.KeyStore.Entry>(this, global::java.security.KeyStoreSpi.staticClass, "engineGetEntry", "(Ljava/lang/String;Ljava/security/KeyStore$ProtectionParameter;)Ljava/security/KeyStore$Entry;", ref global::java.security.KeyStoreSpi._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.security.KeyStore.Entry;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void engineSetEntry(java.lang.String arg0, java.security.KeyStore.Entry arg1, java.security.KeyStore.ProtectionParameter arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.KeyStoreSpi.staticClass, "engineSetEntry", "(Ljava/lang/String;Ljava/security/KeyStore$Entry;Ljava/security/KeyStore$ProtectionParameter;)V", ref global::java.security.KeyStoreSpi._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual bool engineEntryInstanceOf(java.lang.String arg0, java.lang.Class arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.KeyStoreSpi.staticClass, "engineEntryInstanceOf", "(Ljava/lang/String;Ljava/lang/Class;)Z", ref global::java.security.KeyStoreSpi._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public KeyStoreSpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStoreSpi._m21.native == global::System.IntPtr.Zero)
				global::java.security.KeyStoreSpi._m21 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStoreSpi.staticClass, global::java.security.KeyStoreSpi._m21);
			Init(@__env, handle);
		}
		static KeyStoreSpi()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyStoreSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStoreSpi"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.KeyStoreSpi))]
	internal sealed partial class KeyStoreSpi_ : java.security.KeyStoreSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal KeyStoreSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.security.Key engineGetKey(java.lang.String arg0, char[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Key>(this, global::java.security.KeyStoreSpi_.staticClass, "engineGetKey", "(Ljava/lang/String;[C)Ljava/security/Key;", ref global::java.security.KeyStoreSpi_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.security.Key;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.security.cert.Certificate[] engineGetCertificateChain(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.security.cert.Certificate>(this, global::java.security.KeyStoreSpi_.staticClass, "engineGetCertificateChain", "(Ljava/lang/String;)[Ljava/security/cert/Certificate;", ref global::java.security.KeyStoreSpi_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.cert.Certificate[];
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.security.cert.Certificate engineGetCertificate(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.KeyStoreSpi_.staticClass, "engineGetCertificate", "(Ljava/lang/String;)Ljava/security/cert/Certificate;", ref global::java.security.KeyStoreSpi_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.cert.Certificate;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.util.Date engineGetCreationDate(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.KeyStoreSpi_.staticClass, "engineGetCreationDate", "(Ljava/lang/String;)Ljava/util/Date;", ref global::java.security.KeyStoreSpi_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Date;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void engineSetKeyEntry(java.lang.String arg0, java.security.Key arg1, char[] arg2, java.security.cert.Certificate[] arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.KeyStoreSpi_.staticClass, "engineSetKeyEntry", "(Ljava/lang/String;Ljava/security/Key;[C[Ljava/security/cert/Certificate;)V", ref global::java.security.KeyStoreSpi_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override void engineSetKeyEntry(java.lang.String arg0, byte[] arg1, java.security.cert.Certificate[] arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.KeyStoreSpi_.staticClass, "engineSetKeyEntry", "(Ljava/lang/String;[B[Ljava/security/cert/Certificate;)V", ref global::java.security.KeyStoreSpi_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override void engineSetCertificateEntry(java.lang.String arg0, java.security.cert.Certificate arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.KeyStoreSpi_.staticClass, "engineSetCertificateEntry", "(Ljava/lang/String;Ljava/security/cert/Certificate;)V", ref global::java.security.KeyStoreSpi_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override void engineDeleteEntry(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.KeyStoreSpi_.staticClass, "engineDeleteEntry", "(Ljava/lang/String;)V", ref global::java.security.KeyStoreSpi_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override global::java.util.Enumeration engineAliases()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.security.KeyStoreSpi_.staticClass, "engineAliases", "()Ljava/util/Enumeration;", ref global::java.security.KeyStoreSpi_._m8) as java.util.Enumeration;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override bool engineContainsAlias(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.KeyStoreSpi_.staticClass, "engineContainsAlias", "(Ljava/lang/String;)Z", ref global::java.security.KeyStoreSpi_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override int engineSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.KeyStoreSpi_.staticClass, "engineSize", "()I", ref global::java.security.KeyStoreSpi_._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override bool engineIsKeyEntry(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.KeyStoreSpi_.staticClass, "engineIsKeyEntry", "(Ljava/lang/String;)Z", ref global::java.security.KeyStoreSpi_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override bool engineIsCertificateEntry(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.KeyStoreSpi_.staticClass, "engineIsCertificateEntry", "(Ljava/lang/String;)Z", ref global::java.security.KeyStoreSpi_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override global::java.lang.String engineGetCertificateAlias(java.security.cert.Certificate arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.KeyStoreSpi_.staticClass, "engineGetCertificateAlias", "(Ljava/security/cert/Certificate;)Ljava/lang/String;", ref global::java.security.KeyStoreSpi_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override void engineStore(java.io.OutputStream arg0, char[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.KeyStoreSpi_.staticClass, "engineStore", "(Ljava/io/OutputStream;[C)V", ref global::java.security.KeyStoreSpi_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public override void engineLoad(java.io.InputStream arg0, char[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.KeyStoreSpi_.staticClass, "engineLoad", "(Ljava/io/InputStream;[C)V", ref global::java.security.KeyStoreSpi_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static KeyStoreSpi_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyStoreSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStoreSpi"));
		}
		internal static void InitJNI()
		{
		}
	}
}
