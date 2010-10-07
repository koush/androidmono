namespace java.security
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class KeyStoreSpi : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static KeyStoreSpi()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.security.KeyStoreSpi), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected KeyStoreSpi(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _engineGetKey13198;
		public abstract global::java.security.Key engineGetKey(java.lang.String arg0, char[] arg1);
		internal static global::net.sf.jni4net.jni.MethodId _engineGetCertificateChain13199;
		public abstract global::java.security.cert.Certificate[] engineGetCertificateChain(java.lang.String arg0);
		internal static global::net.sf.jni4net.jni.MethodId _engineGetCertificate13200;
		public abstract global::java.security.cert.Certificate engineGetCertificate(java.lang.String arg0);
		internal static global::net.sf.jni4net.jni.MethodId _engineGetCreationDate13201;
		public abstract global::java.util.Date engineGetCreationDate(java.lang.String arg0);
		internal static global::net.sf.jni4net.jni.MethodId _engineSetKeyEntry13202;
		public abstract void engineSetKeyEntry(java.lang.String arg0, java.security.Key arg1, char[] arg2, java.security.cert.Certificate[] arg3);
		internal static global::net.sf.jni4net.jni.MethodId _engineSetKeyEntry13203;
		public abstract void engineSetKeyEntry(java.lang.String arg0, byte[] arg1, java.security.cert.Certificate[] arg2);
		internal static global::net.sf.jni4net.jni.MethodId _engineSetCertificateEntry13204;
		public abstract void engineSetCertificateEntry(java.lang.String arg0, java.security.cert.Certificate arg1);
		internal static global::net.sf.jni4net.jni.MethodId _engineDeleteEntry13205;
		public abstract void engineDeleteEntry(java.lang.String arg0);
		internal static global::net.sf.jni4net.jni.MethodId _engineAliases13206;
		public abstract global::java.util.Enumeration engineAliases();
		internal static global::net.sf.jni4net.jni.MethodId _engineContainsAlias13207;
		public abstract bool engineContainsAlias(java.lang.String arg0);
		internal static global::net.sf.jni4net.jni.MethodId _engineSize13208;
		public abstract int engineSize();
		internal static global::net.sf.jni4net.jni.MethodId _engineIsKeyEntry13209;
		public abstract bool engineIsKeyEntry(java.lang.String arg0);
		internal static global::net.sf.jni4net.jni.MethodId _engineIsCertificateEntry13210;
		public abstract bool engineIsCertificateEntry(java.lang.String arg0);
		internal static global::net.sf.jni4net.jni.MethodId _engineGetCertificateAlias13211;
		public abstract global::java.lang.String engineGetCertificateAlias(java.security.cert.Certificate arg0);
		internal static global::net.sf.jni4net.jni.MethodId _engineStore13212;
		public abstract void engineStore(java.io.OutputStream arg0, char[] arg1);
		internal static global::net.sf.jni4net.jni.MethodId _engineStore13213;
		public virtual void engineStore(java.security.KeyStore.LoadStoreParameter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.security.KeyStoreSpi._engineStore13213, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.security.KeyStoreSpi.staticClass, global::java.security.KeyStoreSpi._engineStore13213, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _engineLoad13214;
		public abstract void engineLoad(java.io.InputStream arg0, char[] arg1);
		internal static global::net.sf.jni4net.jni.MethodId _engineLoad13215;
		public virtual void engineLoad(java.security.KeyStore.LoadStoreParameter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.security.KeyStoreSpi._engineLoad13215, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.security.KeyStoreSpi.staticClass, global::java.security.KeyStoreSpi._engineLoad13215, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _engineGetEntry13216;
		public virtual global::java.security.KeyStore.Entry engineGetEntry(java.lang.String arg0, java.security.KeyStore.ProtectionParameter arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.security.KeyStore.Entry>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.KeyStoreSpi._engineGetEntry13216, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.security.KeyStore.Entry>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.KeyStoreSpi.staticClass, global::java.security.KeyStoreSpi._engineGetEntry13216, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _engineSetEntry13217;
		public virtual void engineSetEntry(java.lang.String arg0, java.security.KeyStore.Entry arg1, java.security.KeyStore.ProtectionParameter arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.security.KeyStoreSpi._engineSetEntry13217, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.security.KeyStoreSpi.staticClass, global::java.security.KeyStoreSpi._engineSetEntry13217, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _engineEntryInstanceOf13218;
		public virtual bool engineEntryInstanceOf(java.lang.String arg0, java.lang.Class arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.security.KeyStoreSpi._engineEntryInstanceOf13218, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.security.KeyStoreSpi.staticClass, global::java.security.KeyStoreSpi._engineEntryInstanceOf13218, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _KeyStoreSpi13219;
		public KeyStoreSpi()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.security.KeyStoreSpi.staticClass, global::java.security.KeyStoreSpi._KeyStoreSpi13219, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.security.KeyStoreSpi.staticClass = @__class;
			global::java.security.KeyStoreSpi._engineGetKey13198 = @__env.GetMethodID(global::java.security.KeyStoreSpi.staticClass, "engineGetKey", "(Ljava/lang/String;[C)Ljava/security/Key;");
			global::java.security.KeyStoreSpi._engineGetCertificateChain13199 = @__env.GetMethodID(global::java.security.KeyStoreSpi.staticClass, "engineGetCertificateChain", "(Ljava/lang/String;)[Ljava/security/cert/Certificate;");
			global::java.security.KeyStoreSpi._engineGetCertificate13200 = @__env.GetMethodID(global::java.security.KeyStoreSpi.staticClass, "engineGetCertificate", "(Ljava/lang/String;)Ljava/security/cert/Certificate;");
			global::java.security.KeyStoreSpi._engineGetCreationDate13201 = @__env.GetMethodID(global::java.security.KeyStoreSpi.staticClass, "engineGetCreationDate", "(Ljava/lang/String;)Ljava/util/Date;");
			global::java.security.KeyStoreSpi._engineSetKeyEntry13202 = @__env.GetMethodID(global::java.security.KeyStoreSpi.staticClass, "engineSetKeyEntry", "(Ljava/lang/String;Ljava/security/Key;[C[Ljava/security/cert/Certificate;)V");
			global::java.security.KeyStoreSpi._engineSetKeyEntry13203 = @__env.GetMethodID(global::java.security.KeyStoreSpi.staticClass, "engineSetKeyEntry", "(Ljava/lang/String;[B[Ljava/security/cert/Certificate;)V");
			global::java.security.KeyStoreSpi._engineSetCertificateEntry13204 = @__env.GetMethodID(global::java.security.KeyStoreSpi.staticClass, "engineSetCertificateEntry", "(Ljava/lang/String;Ljava/security/cert/Certificate;)V");
			global::java.security.KeyStoreSpi._engineDeleteEntry13205 = @__env.GetMethodID(global::java.security.KeyStoreSpi.staticClass, "engineDeleteEntry", "(Ljava/lang/String;)V");
			global::java.security.KeyStoreSpi._engineAliases13206 = @__env.GetMethodID(global::java.security.KeyStoreSpi.staticClass, "engineAliases", "()Ljava/util/Enumeration;");
			global::java.security.KeyStoreSpi._engineContainsAlias13207 = @__env.GetMethodID(global::java.security.KeyStoreSpi.staticClass, "engineContainsAlias", "(Ljava/lang/String;)Z");
			global::java.security.KeyStoreSpi._engineSize13208 = @__env.GetMethodID(global::java.security.KeyStoreSpi.staticClass, "engineSize", "()I");
			global::java.security.KeyStoreSpi._engineIsKeyEntry13209 = @__env.GetMethodID(global::java.security.KeyStoreSpi.staticClass, "engineIsKeyEntry", "(Ljava/lang/String;)Z");
			global::java.security.KeyStoreSpi._engineIsCertificateEntry13210 = @__env.GetMethodID(global::java.security.KeyStoreSpi.staticClass, "engineIsCertificateEntry", "(Ljava/lang/String;)Z");
			global::java.security.KeyStoreSpi._engineGetCertificateAlias13211 = @__env.GetMethodID(global::java.security.KeyStoreSpi.staticClass, "engineGetCertificateAlias", "(Ljava/security/cert/Certificate;)Ljava/lang/String;");
			global::java.security.KeyStoreSpi._engineStore13212 = @__env.GetMethodID(global::java.security.KeyStoreSpi.staticClass, "engineStore", "(Ljava/io/OutputStream;[C)V");
			global::java.security.KeyStoreSpi._engineStore13213 = @__env.GetMethodID(global::java.security.KeyStoreSpi.staticClass, "engineStore", "(Ljava/security/KeyStore$LoadStoreParameter;)V");
			global::java.security.KeyStoreSpi._engineLoad13214 = @__env.GetMethodID(global::java.security.KeyStoreSpi.staticClass, "engineLoad", "(Ljava/io/InputStream;[C)V");
			global::java.security.KeyStoreSpi._engineLoad13215 = @__env.GetMethodID(global::java.security.KeyStoreSpi.staticClass, "engineLoad", "(Ljava/security/KeyStore$LoadStoreParameter;)V");
			global::java.security.KeyStoreSpi._engineGetEntry13216 = @__env.GetMethodID(global::java.security.KeyStoreSpi.staticClass, "engineGetEntry", "(Ljava/lang/String;Ljava/security/KeyStore$ProtectionParameter;)Ljava/security/KeyStore$Entry;");
			global::java.security.KeyStoreSpi._engineSetEntry13217 = @__env.GetMethodID(global::java.security.KeyStoreSpi.staticClass, "engineSetEntry", "(Ljava/lang/String;Ljava/security/KeyStore$Entry;Ljava/security/KeyStore$ProtectionParameter;)V");
			global::java.security.KeyStoreSpi._engineEntryInstanceOf13218 = @__env.GetMethodID(global::java.security.KeyStoreSpi.staticClass, "engineEntryInstanceOf", "(Ljava/lang/String;Ljava/lang/Class;)Z");
			global::java.security.KeyStoreSpi._KeyStoreSpi13219 = @__env.GetMethodID(global::java.security.KeyStoreSpi.staticClass, "<init>", "()V");
		}
	}
}
