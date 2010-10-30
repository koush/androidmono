namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.KeyStoreSpi_))]
	public abstract partial class KeyStoreSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected KeyStoreSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineGetKey23123;
		public abstract global::java.security.Key engineGetKey(java.lang.String arg0, char[] arg1);
		internal static global::MonoJavaBridge.MethodId _engineGetCertificateChain23124;
		public abstract global::java.security.cert.Certificate[] engineGetCertificateChain(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _engineGetCertificate23125;
		public abstract global::java.security.cert.Certificate engineGetCertificate(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _engineGetCreationDate23126;
		public abstract global::java.util.Date engineGetCreationDate(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _engineSetKeyEntry23127;
		public abstract void engineSetKeyEntry(java.lang.String arg0, java.security.Key arg1, char[] arg2, java.security.cert.Certificate[] arg3);
		internal static global::MonoJavaBridge.MethodId _engineSetKeyEntry23128;
		public abstract void engineSetKeyEntry(java.lang.String arg0, byte[] arg1, java.security.cert.Certificate[] arg2);
		internal static global::MonoJavaBridge.MethodId _engineSetCertificateEntry23129;
		public abstract void engineSetCertificateEntry(java.lang.String arg0, java.security.cert.Certificate arg1);
		internal static global::MonoJavaBridge.MethodId _engineDeleteEntry23130;
		public abstract void engineDeleteEntry(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _engineAliases23131;
		public abstract global::java.util.Enumeration engineAliases();
		internal static global::MonoJavaBridge.MethodId _engineContainsAlias23132;
		public abstract bool engineContainsAlias(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _engineSize23133;
		public abstract int engineSize();
		internal static global::MonoJavaBridge.MethodId _engineIsKeyEntry23134;
		public abstract bool engineIsKeyEntry(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _engineIsCertificateEntry23135;
		public abstract bool engineIsCertificateEntry(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _engineGetCertificateAlias23136;
		public abstract global::java.lang.String engineGetCertificateAlias(java.security.cert.Certificate arg0);
		internal static global::MonoJavaBridge.MethodId _engineStore23137;
		public abstract void engineStore(java.io.OutputStream arg0, char[] arg1);
		internal static global::MonoJavaBridge.MethodId _engineStore23138;
		public virtual void engineStore(java.security.KeyStore.LoadStoreParameter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.KeyStoreSpi.staticClass, global::java.security.KeyStoreSpi._engineStore23138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineLoad23139;
		public abstract void engineLoad(java.io.InputStream arg0, char[] arg1);
		internal static global::MonoJavaBridge.MethodId _engineLoad23140;
		public virtual void engineLoad(java.security.KeyStore.LoadStoreParameter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.KeyStoreSpi.staticClass, global::java.security.KeyStoreSpi._engineLoad23140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineGetEntry23141;
		public virtual global::java.security.KeyStore.Entry engineGetEntry(java.lang.String arg0, java.security.KeyStore.ProtectionParameter arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.KeyStore.Entry>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.KeyStoreSpi.staticClass, global::java.security.KeyStoreSpi._engineGetEntry23141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.KeyStore.Entry;
		}
		internal static global::MonoJavaBridge.MethodId _engineSetEntry23142;
		public virtual void engineSetEntry(java.lang.String arg0, java.security.KeyStore.Entry arg1, java.security.KeyStore.ProtectionParameter arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.KeyStoreSpi.staticClass, global::java.security.KeyStoreSpi._engineSetEntry23142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _engineEntryInstanceOf23143;
		public virtual bool engineEntryInstanceOf(java.lang.String arg0, java.lang.Class arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.KeyStoreSpi.staticClass, global::java.security.KeyStoreSpi._engineEntryInstanceOf23143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _KeyStoreSpi23144;
		public KeyStoreSpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStoreSpi.staticClass, global::java.security.KeyStoreSpi._KeyStoreSpi23144);
			Init(@__env, handle);
		}
		static KeyStoreSpi()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyStoreSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStoreSpi"));
			global::java.security.KeyStoreSpi._engineGetKey23123 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineGetKey", "(Ljava/lang/String;[C)Ljava/security/Key;");
			global::java.security.KeyStoreSpi._engineGetCertificateChain23124 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineGetCertificateChain", "(Ljava/lang/String;)[Ljava/security/cert/Certificate;");
			global::java.security.KeyStoreSpi._engineGetCertificate23125 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineGetCertificate", "(Ljava/lang/String;)Ljava/security/cert/Certificate;");
			global::java.security.KeyStoreSpi._engineGetCreationDate23126 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineGetCreationDate", "(Ljava/lang/String;)Ljava/util/Date;");
			global::java.security.KeyStoreSpi._engineSetKeyEntry23127 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineSetKeyEntry", "(Ljava/lang/String;Ljava/security/Key;[C[Ljava/security/cert/Certificate;)V");
			global::java.security.KeyStoreSpi._engineSetKeyEntry23128 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineSetKeyEntry", "(Ljava/lang/String;[B[Ljava/security/cert/Certificate;)V");
			global::java.security.KeyStoreSpi._engineSetCertificateEntry23129 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineSetCertificateEntry", "(Ljava/lang/String;Ljava/security/cert/Certificate;)V");
			global::java.security.KeyStoreSpi._engineDeleteEntry23130 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineDeleteEntry", "(Ljava/lang/String;)V");
			global::java.security.KeyStoreSpi._engineAliases23131 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineAliases", "()Ljava/util/Enumeration;");
			global::java.security.KeyStoreSpi._engineContainsAlias23132 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineContainsAlias", "(Ljava/lang/String;)Z");
			global::java.security.KeyStoreSpi._engineSize23133 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineSize", "()I");
			global::java.security.KeyStoreSpi._engineIsKeyEntry23134 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineIsKeyEntry", "(Ljava/lang/String;)Z");
			global::java.security.KeyStoreSpi._engineIsCertificateEntry23135 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineIsCertificateEntry", "(Ljava/lang/String;)Z");
			global::java.security.KeyStoreSpi._engineGetCertificateAlias23136 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineGetCertificateAlias", "(Ljava/security/cert/Certificate;)Ljava/lang/String;");
			global::java.security.KeyStoreSpi._engineStore23137 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineStore", "(Ljava/io/OutputStream;[C)V");
			global::java.security.KeyStoreSpi._engineStore23138 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineStore", "(Ljava/security/KeyStore$LoadStoreParameter;)V");
			global::java.security.KeyStoreSpi._engineLoad23139 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineLoad", "(Ljava/io/InputStream;[C)V");
			global::java.security.KeyStoreSpi._engineLoad23140 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineLoad", "(Ljava/security/KeyStore$LoadStoreParameter;)V");
			global::java.security.KeyStoreSpi._engineGetEntry23141 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineGetEntry", "(Ljava/lang/String;Ljava/security/KeyStore$ProtectionParameter;)Ljava/security/KeyStore$Entry;");
			global::java.security.KeyStoreSpi._engineSetEntry23142 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineSetEntry", "(Ljava/lang/String;Ljava/security/KeyStore$Entry;Ljava/security/KeyStore$ProtectionParameter;)V");
			global::java.security.KeyStoreSpi._engineEntryInstanceOf23143 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineEntryInstanceOf", "(Ljava/lang/String;Ljava/lang/Class;)Z");
			global::java.security.KeyStoreSpi._KeyStoreSpi23144 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _engineGetKey23145;
		public override global::java.security.Key engineGetKey(java.lang.String arg0, char[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Key>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineGetKey23145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.Key;
		}
		internal static global::MonoJavaBridge.MethodId _engineGetCertificateChain23146;
		public override global::java.security.cert.Certificate[] engineGetCertificateChain(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineGetCertificateChain23146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.Certificate[];
		}
		internal static global::MonoJavaBridge.MethodId _engineGetCertificate23147;
		public override global::java.security.cert.Certificate engineGetCertificate(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineGetCertificate23147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.Certificate;
		}
		internal static global::MonoJavaBridge.MethodId _engineGetCreationDate23148;
		public override global::java.util.Date engineGetCreationDate(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineGetCreationDate23148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _engineSetKeyEntry23149;
		public override void engineSetKeyEntry(java.lang.String arg0, java.security.Key arg1, char[] arg2, java.security.cert.Certificate[] arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineSetKeyEntry23149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _engineSetKeyEntry23150;
		public override void engineSetKeyEntry(java.lang.String arg0, byte[] arg1, java.security.cert.Certificate[] arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineSetKeyEntry23150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _engineSetCertificateEntry23151;
		public override void engineSetCertificateEntry(java.lang.String arg0, java.security.cert.Certificate arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineSetCertificateEntry23151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineDeleteEntry23152;
		public override void engineDeleteEntry(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineDeleteEntry23152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineAliases23153;
		public override global::java.util.Enumeration engineAliases()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineAliases23153)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _engineContainsAlias23154;
		public override bool engineContainsAlias(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineContainsAlias23154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineSize23155;
		public override int engineSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineSize23155);
		}
		internal static global::MonoJavaBridge.MethodId _engineIsKeyEntry23156;
		public override bool engineIsKeyEntry(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineIsKeyEntry23156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineIsCertificateEntry23157;
		public override bool engineIsCertificateEntry(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineIsCertificateEntry23157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineGetCertificateAlias23158;
		public override global::java.lang.String engineGetCertificateAlias(java.security.cert.Certificate arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineGetCertificateAlias23158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _engineStore23159;
		public override void engineStore(java.io.OutputStream arg0, char[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineStore23159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineLoad23160;
		public override void engineLoad(java.io.InputStream arg0, char[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineLoad23160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static KeyStoreSpi_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyStoreSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStoreSpi"));
			global::java.security.KeyStoreSpi_._engineGetKey23145 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineGetKey", "(Ljava/lang/String;[C)Ljava/security/Key;");
			global::java.security.KeyStoreSpi_._engineGetCertificateChain23146 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineGetCertificateChain", "(Ljava/lang/String;)[Ljava/security/cert/Certificate;");
			global::java.security.KeyStoreSpi_._engineGetCertificate23147 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineGetCertificate", "(Ljava/lang/String;)Ljava/security/cert/Certificate;");
			global::java.security.KeyStoreSpi_._engineGetCreationDate23148 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineGetCreationDate", "(Ljava/lang/String;)Ljava/util/Date;");
			global::java.security.KeyStoreSpi_._engineSetKeyEntry23149 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineSetKeyEntry", "(Ljava/lang/String;Ljava/security/Key;[C[Ljava/security/cert/Certificate;)V");
			global::java.security.KeyStoreSpi_._engineSetKeyEntry23150 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineSetKeyEntry", "(Ljava/lang/String;[B[Ljava/security/cert/Certificate;)V");
			global::java.security.KeyStoreSpi_._engineSetCertificateEntry23151 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineSetCertificateEntry", "(Ljava/lang/String;Ljava/security/cert/Certificate;)V");
			global::java.security.KeyStoreSpi_._engineDeleteEntry23152 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineDeleteEntry", "(Ljava/lang/String;)V");
			global::java.security.KeyStoreSpi_._engineAliases23153 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineAliases", "()Ljava/util/Enumeration;");
			global::java.security.KeyStoreSpi_._engineContainsAlias23154 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineContainsAlias", "(Ljava/lang/String;)Z");
			global::java.security.KeyStoreSpi_._engineSize23155 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineSize", "()I");
			global::java.security.KeyStoreSpi_._engineIsKeyEntry23156 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineIsKeyEntry", "(Ljava/lang/String;)Z");
			global::java.security.KeyStoreSpi_._engineIsCertificateEntry23157 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineIsCertificateEntry", "(Ljava/lang/String;)Z");
			global::java.security.KeyStoreSpi_._engineGetCertificateAlias23158 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineGetCertificateAlias", "(Ljava/security/cert/Certificate;)Ljava/lang/String;");
			global::java.security.KeyStoreSpi_._engineStore23159 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineStore", "(Ljava/io/OutputStream;[C)V");
			global::java.security.KeyStoreSpi_._engineLoad23160 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineLoad", "(Ljava/io/InputStream;[C)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
