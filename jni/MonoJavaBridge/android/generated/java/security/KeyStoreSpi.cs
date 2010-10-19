namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.KeyStoreSpi_))]
	public abstract partial class KeyStoreSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static KeyStoreSpi()
		{
			InitJNI();
		}
		protected KeyStoreSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineGetKey17405;
		public abstract global::java.security.Key engineGetKey(java.lang.String arg0, char[] arg1);
		internal static global::MonoJavaBridge.MethodId _engineGetCertificateChain17406;
		public abstract global::java.security.cert.Certificate[] engineGetCertificateChain(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _engineGetCertificate17407;
		public abstract global::java.security.cert.Certificate engineGetCertificate(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _engineGetCreationDate17408;
		public abstract global::java.util.Date engineGetCreationDate(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _engineSetKeyEntry17409;
		public abstract void engineSetKeyEntry(java.lang.String arg0, java.security.Key arg1, char[] arg2, java.security.cert.Certificate[] arg3);
		internal static global::MonoJavaBridge.MethodId _engineSetKeyEntry17410;
		public abstract void engineSetKeyEntry(java.lang.String arg0, byte[] arg1, java.security.cert.Certificate[] arg2);
		internal static global::MonoJavaBridge.MethodId _engineSetCertificateEntry17411;
		public abstract void engineSetCertificateEntry(java.lang.String arg0, java.security.cert.Certificate arg1);
		internal static global::MonoJavaBridge.MethodId _engineDeleteEntry17412;
		public abstract void engineDeleteEntry(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _engineAliases17413;
		public abstract global::java.util.Enumeration engineAliases();
		internal static global::MonoJavaBridge.MethodId _engineContainsAlias17414;
		public abstract bool engineContainsAlias(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _engineSize17415;
		public abstract int engineSize();
		internal static global::MonoJavaBridge.MethodId _engineIsKeyEntry17416;
		public abstract bool engineIsKeyEntry(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _engineIsCertificateEntry17417;
		public abstract bool engineIsCertificateEntry(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _engineGetCertificateAlias17418;
		public abstract global::java.lang.String engineGetCertificateAlias(java.security.cert.Certificate arg0);
		internal static global::MonoJavaBridge.MethodId _engineStore17419;
		public abstract void engineStore(java.io.OutputStream arg0, char[] arg1);
		internal static global::MonoJavaBridge.MethodId _engineStore17420;
		public virtual void engineStore(java.security.KeyStore.LoadStoreParameter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi._engineStore17420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi.staticClass, global::java.security.KeyStoreSpi._engineStore17420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineLoad17421;
		public abstract void engineLoad(java.io.InputStream arg0, char[] arg1);
		internal static global::MonoJavaBridge.MethodId _engineLoad17422;
		public virtual void engineLoad(java.security.KeyStore.LoadStoreParameter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi._engineLoad17422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi.staticClass, global::java.security.KeyStoreSpi._engineLoad17422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineGetEntry17423;
		public virtual global::java.security.KeyStore.Entry engineGetEntry(java.lang.String arg0, java.security.KeyStore.ProtectionParameter arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.KeyStore.Entry>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStoreSpi._engineGetEntry17423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.KeyStore.Entry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.KeyStore.Entry>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStoreSpi.staticClass, global::java.security.KeyStoreSpi._engineGetEntry17423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.KeyStore.Entry;
		}
		internal static global::MonoJavaBridge.MethodId _engineSetEntry17424;
		public virtual void engineSetEntry(java.lang.String arg0, java.security.KeyStore.Entry arg1, java.security.KeyStore.ProtectionParameter arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi._engineSetEntry17424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi.staticClass, global::java.security.KeyStoreSpi._engineSetEntry17424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _engineEntryInstanceOf17425;
		public virtual bool engineEntryInstanceOf(java.lang.String arg0, java.lang.Class arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.KeyStoreSpi._engineEntryInstanceOf17425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.KeyStoreSpi.staticClass, global::java.security.KeyStoreSpi._engineEntryInstanceOf17425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _KeyStoreSpi17426;
		public KeyStoreSpi()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStoreSpi.staticClass, global::java.security.KeyStoreSpi._KeyStoreSpi17426);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyStoreSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStoreSpi"));
			global::java.security.KeyStoreSpi._engineGetKey17405 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineGetKey", "(Ljava/lang/String;[C)Ljava/security/Key;");
			global::java.security.KeyStoreSpi._engineGetCertificateChain17406 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineGetCertificateChain", "(Ljava/lang/String;)[Ljava/security/cert/Certificate;");
			global::java.security.KeyStoreSpi._engineGetCertificate17407 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineGetCertificate", "(Ljava/lang/String;)Ljava/security/cert/Certificate;");
			global::java.security.KeyStoreSpi._engineGetCreationDate17408 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineGetCreationDate", "(Ljava/lang/String;)Ljava/util/Date;");
			global::java.security.KeyStoreSpi._engineSetKeyEntry17409 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineSetKeyEntry", "(Ljava/lang/String;Ljava/security/Key;[C[Ljava/security/cert/Certificate;)V");
			global::java.security.KeyStoreSpi._engineSetKeyEntry17410 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineSetKeyEntry", "(Ljava/lang/String;[B[Ljava/security/cert/Certificate;)V");
			global::java.security.KeyStoreSpi._engineSetCertificateEntry17411 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineSetCertificateEntry", "(Ljava/lang/String;Ljava/security/cert/Certificate;)V");
			global::java.security.KeyStoreSpi._engineDeleteEntry17412 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineDeleteEntry", "(Ljava/lang/String;)V");
			global::java.security.KeyStoreSpi._engineAliases17413 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineAliases", "()Ljava/util/Enumeration;");
			global::java.security.KeyStoreSpi._engineContainsAlias17414 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineContainsAlias", "(Ljava/lang/String;)Z");
			global::java.security.KeyStoreSpi._engineSize17415 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineSize", "()I");
			global::java.security.KeyStoreSpi._engineIsKeyEntry17416 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineIsKeyEntry", "(Ljava/lang/String;)Z");
			global::java.security.KeyStoreSpi._engineIsCertificateEntry17417 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineIsCertificateEntry", "(Ljava/lang/String;)Z");
			global::java.security.KeyStoreSpi._engineGetCertificateAlias17418 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineGetCertificateAlias", "(Ljava/security/cert/Certificate;)Ljava/lang/String;");
			global::java.security.KeyStoreSpi._engineStore17419 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineStore", "(Ljava/io/OutputStream;[C)V");
			global::java.security.KeyStoreSpi._engineStore17420 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineStore", "(Ljava/security/KeyStore$LoadStoreParameter;)V");
			global::java.security.KeyStoreSpi._engineLoad17421 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineLoad", "(Ljava/io/InputStream;[C)V");
			global::java.security.KeyStoreSpi._engineLoad17422 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineLoad", "(Ljava/security/KeyStore$LoadStoreParameter;)V");
			global::java.security.KeyStoreSpi._engineGetEntry17423 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineGetEntry", "(Ljava/lang/String;Ljava/security/KeyStore$ProtectionParameter;)Ljava/security/KeyStore$Entry;");
			global::java.security.KeyStoreSpi._engineSetEntry17424 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineSetEntry", "(Ljava/lang/String;Ljava/security/KeyStore$Entry;Ljava/security/KeyStore$ProtectionParameter;)V");
			global::java.security.KeyStoreSpi._engineEntryInstanceOf17425 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineEntryInstanceOf", "(Ljava/lang/String;Ljava/lang/Class;)Z");
			global::java.security.KeyStoreSpi._KeyStoreSpi17426 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.KeyStoreSpi))]
	public sealed partial class KeyStoreSpi_ : java.security.KeyStoreSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static KeyStoreSpi_()
		{
			InitJNI();
		}
		internal KeyStoreSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineGetKey17427;
		public override global::java.security.Key engineGetKey(java.lang.String arg0, char[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Key>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineGetKey17427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.Key;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Key>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStoreSpi_.staticClass, global::java.security.KeyStoreSpi_._engineGetKey17427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.Key;
		}
		internal static global::MonoJavaBridge.MethodId _engineGetCertificateChain17428;
		public override global::java.security.cert.Certificate[] engineGetCertificateChain(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineGetCertificateChain17428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.Certificate[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStoreSpi_.staticClass, global::java.security.KeyStoreSpi_._engineGetCertificateChain17428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.Certificate[];
		}
		internal static global::MonoJavaBridge.MethodId _engineGetCertificate17429;
		public override global::java.security.cert.Certificate engineGetCertificate(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineGetCertificate17429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.Certificate;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStoreSpi_.staticClass, global::java.security.KeyStoreSpi_._engineGetCertificate17429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.Certificate;
		}
		internal static global::MonoJavaBridge.MethodId _engineGetCreationDate17430;
		public override global::java.util.Date engineGetCreationDate(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineGetCreationDate17430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStoreSpi_.staticClass, global::java.security.KeyStoreSpi_._engineGetCreationDate17430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _engineSetKeyEntry17431;
		public override void engineSetKeyEntry(java.lang.String arg0, java.security.Key arg1, char[] arg2, java.security.cert.Certificate[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineSetKeyEntry17431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi_.staticClass, global::java.security.KeyStoreSpi_._engineSetKeyEntry17431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _engineSetKeyEntry17432;
		public override void engineSetKeyEntry(java.lang.String arg0, byte[] arg1, java.security.cert.Certificate[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineSetKeyEntry17432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi_.staticClass, global::java.security.KeyStoreSpi_._engineSetKeyEntry17432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _engineSetCertificateEntry17433;
		public override void engineSetCertificateEntry(java.lang.String arg0, java.security.cert.Certificate arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineSetCertificateEntry17433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi_.staticClass, global::java.security.KeyStoreSpi_._engineSetCertificateEntry17433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineDeleteEntry17434;
		public override void engineDeleteEntry(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineDeleteEntry17434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi_.staticClass, global::java.security.KeyStoreSpi_._engineDeleteEntry17434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineAliases17435;
		public override global::java.util.Enumeration engineAliases() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineAliases17435)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStoreSpi_.staticClass, global::java.security.KeyStoreSpi_._engineAliases17435)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _engineContainsAlias17436;
		public override bool engineContainsAlias(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineContainsAlias17436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.KeyStoreSpi_.staticClass, global::java.security.KeyStoreSpi_._engineContainsAlias17436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineSize17437;
		public override int engineSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineSize17437);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.KeyStoreSpi_.staticClass, global::java.security.KeyStoreSpi_._engineSize17437);
		}
		internal static global::MonoJavaBridge.MethodId _engineIsKeyEntry17438;
		public override bool engineIsKeyEntry(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineIsKeyEntry17438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.KeyStoreSpi_.staticClass, global::java.security.KeyStoreSpi_._engineIsKeyEntry17438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineIsCertificateEntry17439;
		public override bool engineIsCertificateEntry(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineIsCertificateEntry17439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.KeyStoreSpi_.staticClass, global::java.security.KeyStoreSpi_._engineIsCertificateEntry17439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineGetCertificateAlias17440;
		public override global::java.lang.String engineGetCertificateAlias(java.security.cert.Certificate arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineGetCertificateAlias17440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStoreSpi_.staticClass, global::java.security.KeyStoreSpi_._engineGetCertificateAlias17440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _engineStore17441;
		public override void engineStore(java.io.OutputStream arg0, char[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineStore17441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi_.staticClass, global::java.security.KeyStoreSpi_._engineStore17441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineLoad17442;
		public override void engineLoad(java.io.InputStream arg0, char[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineLoad17442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi_.staticClass, global::java.security.KeyStoreSpi_._engineLoad17442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyStoreSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStoreSpi"));
			global::java.security.KeyStoreSpi_._engineGetKey17427 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineGetKey", "(Ljava/lang/String;[C)Ljava/security/Key;");
			global::java.security.KeyStoreSpi_._engineGetCertificateChain17428 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineGetCertificateChain", "(Ljava/lang/String;)[Ljava/security/cert/Certificate;");
			global::java.security.KeyStoreSpi_._engineGetCertificate17429 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineGetCertificate", "(Ljava/lang/String;)Ljava/security/cert/Certificate;");
			global::java.security.KeyStoreSpi_._engineGetCreationDate17430 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineGetCreationDate", "(Ljava/lang/String;)Ljava/util/Date;");
			global::java.security.KeyStoreSpi_._engineSetKeyEntry17431 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineSetKeyEntry", "(Ljava/lang/String;Ljava/security/Key;[C[Ljava/security/cert/Certificate;)V");
			global::java.security.KeyStoreSpi_._engineSetKeyEntry17432 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineSetKeyEntry", "(Ljava/lang/String;[B[Ljava/security/cert/Certificate;)V");
			global::java.security.KeyStoreSpi_._engineSetCertificateEntry17433 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineSetCertificateEntry", "(Ljava/lang/String;Ljava/security/cert/Certificate;)V");
			global::java.security.KeyStoreSpi_._engineDeleteEntry17434 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineDeleteEntry", "(Ljava/lang/String;)V");
			global::java.security.KeyStoreSpi_._engineAliases17435 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineAliases", "()Ljava/util/Enumeration;");
			global::java.security.KeyStoreSpi_._engineContainsAlias17436 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineContainsAlias", "(Ljava/lang/String;)Z");
			global::java.security.KeyStoreSpi_._engineSize17437 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineSize", "()I");
			global::java.security.KeyStoreSpi_._engineIsKeyEntry17438 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineIsKeyEntry", "(Ljava/lang/String;)Z");
			global::java.security.KeyStoreSpi_._engineIsCertificateEntry17439 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineIsCertificateEntry", "(Ljava/lang/String;)Z");
			global::java.security.KeyStoreSpi_._engineGetCertificateAlias17440 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineGetCertificateAlias", "(Ljava/security/cert/Certificate;)Ljava/lang/String;");
			global::java.security.KeyStoreSpi_._engineStore17441 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineStore", "(Ljava/io/OutputStream;[C)V");
			global::java.security.KeyStoreSpi_._engineLoad17442 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineLoad", "(Ljava/io/InputStream;[C)V");
		}
	}
}
