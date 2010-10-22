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
		internal static global::MonoJavaBridge.MethodId _engineGetKey23004;
		public abstract global::java.security.Key engineGetKey(java.lang.String arg0, char[] arg1);
		internal static global::MonoJavaBridge.MethodId _engineGetCertificateChain23005;
		public abstract global::java.security.cert.Certificate[] engineGetCertificateChain(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _engineGetCertificate23006;
		public abstract global::java.security.cert.Certificate engineGetCertificate(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _engineGetCreationDate23007;
		public abstract global::java.util.Date engineGetCreationDate(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _engineSetKeyEntry23008;
		public abstract void engineSetKeyEntry(java.lang.String arg0, java.security.Key arg1, char[] arg2, java.security.cert.Certificate[] arg3);
		internal static global::MonoJavaBridge.MethodId _engineSetKeyEntry23009;
		public abstract void engineSetKeyEntry(java.lang.String arg0, byte[] arg1, java.security.cert.Certificate[] arg2);
		internal static global::MonoJavaBridge.MethodId _engineSetCertificateEntry23010;
		public abstract void engineSetCertificateEntry(java.lang.String arg0, java.security.cert.Certificate arg1);
		internal static global::MonoJavaBridge.MethodId _engineDeleteEntry23011;
		public abstract void engineDeleteEntry(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _engineAliases23012;
		public abstract global::java.util.Enumeration engineAliases();
		internal static global::MonoJavaBridge.MethodId _engineContainsAlias23013;
		public abstract bool engineContainsAlias(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _engineSize23014;
		public abstract int engineSize();
		internal static global::MonoJavaBridge.MethodId _engineIsKeyEntry23015;
		public abstract bool engineIsKeyEntry(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _engineIsCertificateEntry23016;
		public abstract bool engineIsCertificateEntry(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _engineGetCertificateAlias23017;
		public abstract global::java.lang.String engineGetCertificateAlias(java.security.cert.Certificate arg0);
		internal static global::MonoJavaBridge.MethodId _engineStore23018;
		public abstract void engineStore(java.io.OutputStream arg0, char[] arg1);
		internal static global::MonoJavaBridge.MethodId _engineStore23019;
		public virtual void engineStore(java.security.KeyStore.LoadStoreParameter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi._engineStore23019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi.staticClass, global::java.security.KeyStoreSpi._engineStore23019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineLoad23020;
		public abstract void engineLoad(java.io.InputStream arg0, char[] arg1);
		internal static global::MonoJavaBridge.MethodId _engineLoad23021;
		public virtual void engineLoad(java.security.KeyStore.LoadStoreParameter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi._engineLoad23021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi.staticClass, global::java.security.KeyStoreSpi._engineLoad23021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineGetEntry23022;
		public virtual global::java.security.KeyStore.Entry engineGetEntry(java.lang.String arg0, java.security.KeyStore.ProtectionParameter arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.KeyStore.Entry>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStoreSpi._engineGetEntry23022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.KeyStore.Entry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.KeyStore.Entry>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStoreSpi.staticClass, global::java.security.KeyStoreSpi._engineGetEntry23022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.KeyStore.Entry;
		}
		internal static global::MonoJavaBridge.MethodId _engineSetEntry23023;
		public virtual void engineSetEntry(java.lang.String arg0, java.security.KeyStore.Entry arg1, java.security.KeyStore.ProtectionParameter arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi._engineSetEntry23023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi.staticClass, global::java.security.KeyStoreSpi._engineSetEntry23023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _engineEntryInstanceOf23024;
		public virtual bool engineEntryInstanceOf(java.lang.String arg0, java.lang.Class arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.KeyStoreSpi._engineEntryInstanceOf23024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.KeyStoreSpi.staticClass, global::java.security.KeyStoreSpi._engineEntryInstanceOf23024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _KeyStoreSpi23025;
		public KeyStoreSpi()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStoreSpi.staticClass, global::java.security.KeyStoreSpi._KeyStoreSpi23025);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyStoreSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStoreSpi"));
			global::java.security.KeyStoreSpi._engineGetKey23004 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineGetKey", "(Ljava/lang/String;[C)Ljava/security/Key;");
			global::java.security.KeyStoreSpi._engineGetCertificateChain23005 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineGetCertificateChain", "(Ljava/lang/String;)[Ljava/security/cert/Certificate;");
			global::java.security.KeyStoreSpi._engineGetCertificate23006 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineGetCertificate", "(Ljava/lang/String;)Ljava/security/cert/Certificate;");
			global::java.security.KeyStoreSpi._engineGetCreationDate23007 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineGetCreationDate", "(Ljava/lang/String;)Ljava/util/Date;");
			global::java.security.KeyStoreSpi._engineSetKeyEntry23008 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineSetKeyEntry", "(Ljava/lang/String;Ljava/security/Key;[C[Ljava/security/cert/Certificate;)V");
			global::java.security.KeyStoreSpi._engineSetKeyEntry23009 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineSetKeyEntry", "(Ljava/lang/String;[B[Ljava/security/cert/Certificate;)V");
			global::java.security.KeyStoreSpi._engineSetCertificateEntry23010 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineSetCertificateEntry", "(Ljava/lang/String;Ljava/security/cert/Certificate;)V");
			global::java.security.KeyStoreSpi._engineDeleteEntry23011 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineDeleteEntry", "(Ljava/lang/String;)V");
			global::java.security.KeyStoreSpi._engineAliases23012 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineAliases", "()Ljava/util/Enumeration;");
			global::java.security.KeyStoreSpi._engineContainsAlias23013 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineContainsAlias", "(Ljava/lang/String;)Z");
			global::java.security.KeyStoreSpi._engineSize23014 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineSize", "()I");
			global::java.security.KeyStoreSpi._engineIsKeyEntry23015 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineIsKeyEntry", "(Ljava/lang/String;)Z");
			global::java.security.KeyStoreSpi._engineIsCertificateEntry23016 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineIsCertificateEntry", "(Ljava/lang/String;)Z");
			global::java.security.KeyStoreSpi._engineGetCertificateAlias23017 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineGetCertificateAlias", "(Ljava/security/cert/Certificate;)Ljava/lang/String;");
			global::java.security.KeyStoreSpi._engineStore23018 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineStore", "(Ljava/io/OutputStream;[C)V");
			global::java.security.KeyStoreSpi._engineStore23019 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineStore", "(Ljava/security/KeyStore$LoadStoreParameter;)V");
			global::java.security.KeyStoreSpi._engineLoad23020 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineLoad", "(Ljava/io/InputStream;[C)V");
			global::java.security.KeyStoreSpi._engineLoad23021 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineLoad", "(Ljava/security/KeyStore$LoadStoreParameter;)V");
			global::java.security.KeyStoreSpi._engineGetEntry23022 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineGetEntry", "(Ljava/lang/String;Ljava/security/KeyStore$ProtectionParameter;)Ljava/security/KeyStore$Entry;");
			global::java.security.KeyStoreSpi._engineSetEntry23023 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineSetEntry", "(Ljava/lang/String;Ljava/security/KeyStore$Entry;Ljava/security/KeyStore$ProtectionParameter;)V");
			global::java.security.KeyStoreSpi._engineEntryInstanceOf23024 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "engineEntryInstanceOf", "(Ljava/lang/String;Ljava/lang/Class;)Z");
			global::java.security.KeyStoreSpi._KeyStoreSpi23025 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _engineGetKey23026;
		public override global::java.security.Key engineGetKey(java.lang.String arg0, char[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Key>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineGetKey23026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.Key;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Key>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStoreSpi_.staticClass, global::java.security.KeyStoreSpi_._engineGetKey23026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.Key;
		}
		internal static global::MonoJavaBridge.MethodId _engineGetCertificateChain23027;
		public override global::java.security.cert.Certificate[] engineGetCertificateChain(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineGetCertificateChain23027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.Certificate[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStoreSpi_.staticClass, global::java.security.KeyStoreSpi_._engineGetCertificateChain23027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.Certificate[];
		}
		internal static global::MonoJavaBridge.MethodId _engineGetCertificate23028;
		public override global::java.security.cert.Certificate engineGetCertificate(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineGetCertificate23028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.Certificate;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStoreSpi_.staticClass, global::java.security.KeyStoreSpi_._engineGetCertificate23028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.Certificate;
		}
		internal static global::MonoJavaBridge.MethodId _engineGetCreationDate23029;
		public override global::java.util.Date engineGetCreationDate(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineGetCreationDate23029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStoreSpi_.staticClass, global::java.security.KeyStoreSpi_._engineGetCreationDate23029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _engineSetKeyEntry23030;
		public override void engineSetKeyEntry(java.lang.String arg0, java.security.Key arg1, char[] arg2, java.security.cert.Certificate[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineSetKeyEntry23030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi_.staticClass, global::java.security.KeyStoreSpi_._engineSetKeyEntry23030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _engineSetKeyEntry23031;
		public override void engineSetKeyEntry(java.lang.String arg0, byte[] arg1, java.security.cert.Certificate[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineSetKeyEntry23031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi_.staticClass, global::java.security.KeyStoreSpi_._engineSetKeyEntry23031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _engineSetCertificateEntry23032;
		public override void engineSetCertificateEntry(java.lang.String arg0, java.security.cert.Certificate arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineSetCertificateEntry23032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi_.staticClass, global::java.security.KeyStoreSpi_._engineSetCertificateEntry23032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineDeleteEntry23033;
		public override void engineDeleteEntry(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineDeleteEntry23033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi_.staticClass, global::java.security.KeyStoreSpi_._engineDeleteEntry23033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineAliases23034;
		public override global::java.util.Enumeration engineAliases() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineAliases23034)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStoreSpi_.staticClass, global::java.security.KeyStoreSpi_._engineAliases23034)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _engineContainsAlias23035;
		public override bool engineContainsAlias(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineContainsAlias23035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.KeyStoreSpi_.staticClass, global::java.security.KeyStoreSpi_._engineContainsAlias23035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineSize23036;
		public override int engineSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineSize23036);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.KeyStoreSpi_.staticClass, global::java.security.KeyStoreSpi_._engineSize23036);
		}
		internal static global::MonoJavaBridge.MethodId _engineIsKeyEntry23037;
		public override bool engineIsKeyEntry(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineIsKeyEntry23037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.KeyStoreSpi_.staticClass, global::java.security.KeyStoreSpi_._engineIsKeyEntry23037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineIsCertificateEntry23038;
		public override bool engineIsCertificateEntry(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineIsCertificateEntry23038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.KeyStoreSpi_.staticClass, global::java.security.KeyStoreSpi_._engineIsCertificateEntry23038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineGetCertificateAlias23039;
		public override global::java.lang.String engineGetCertificateAlias(java.security.cert.Certificate arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineGetCertificateAlias23039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStoreSpi_.staticClass, global::java.security.KeyStoreSpi_._engineGetCertificateAlias23039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _engineStore23040;
		public override void engineStore(java.io.OutputStream arg0, char[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineStore23040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi_.staticClass, global::java.security.KeyStoreSpi_._engineStore23040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineLoad23041;
		public override void engineLoad(java.io.InputStream arg0, char[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi_._engineLoad23041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyStoreSpi_.staticClass, global::java.security.KeyStoreSpi_._engineLoad23041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyStoreSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStoreSpi"));
			global::java.security.KeyStoreSpi_._engineGetKey23026 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineGetKey", "(Ljava/lang/String;[C)Ljava/security/Key;");
			global::java.security.KeyStoreSpi_._engineGetCertificateChain23027 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineGetCertificateChain", "(Ljava/lang/String;)[Ljava/security/cert/Certificate;");
			global::java.security.KeyStoreSpi_._engineGetCertificate23028 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineGetCertificate", "(Ljava/lang/String;)Ljava/security/cert/Certificate;");
			global::java.security.KeyStoreSpi_._engineGetCreationDate23029 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineGetCreationDate", "(Ljava/lang/String;)Ljava/util/Date;");
			global::java.security.KeyStoreSpi_._engineSetKeyEntry23030 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineSetKeyEntry", "(Ljava/lang/String;Ljava/security/Key;[C[Ljava/security/cert/Certificate;)V");
			global::java.security.KeyStoreSpi_._engineSetKeyEntry23031 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineSetKeyEntry", "(Ljava/lang/String;[B[Ljava/security/cert/Certificate;)V");
			global::java.security.KeyStoreSpi_._engineSetCertificateEntry23032 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineSetCertificateEntry", "(Ljava/lang/String;Ljava/security/cert/Certificate;)V");
			global::java.security.KeyStoreSpi_._engineDeleteEntry23033 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineDeleteEntry", "(Ljava/lang/String;)V");
			global::java.security.KeyStoreSpi_._engineAliases23034 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineAliases", "()Ljava/util/Enumeration;");
			global::java.security.KeyStoreSpi_._engineContainsAlias23035 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineContainsAlias", "(Ljava/lang/String;)Z");
			global::java.security.KeyStoreSpi_._engineSize23036 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineSize", "()I");
			global::java.security.KeyStoreSpi_._engineIsKeyEntry23037 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineIsKeyEntry", "(Ljava/lang/String;)Z");
			global::java.security.KeyStoreSpi_._engineIsCertificateEntry23038 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineIsCertificateEntry", "(Ljava/lang/String;)Z");
			global::java.security.KeyStoreSpi_._engineGetCertificateAlias23039 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineGetCertificateAlias", "(Ljava/security/cert/Certificate;)Ljava/lang/String;");
			global::java.security.KeyStoreSpi_._engineStore23040 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineStore", "(Ljava/io/OutputStream;[C)V");
			global::java.security.KeyStoreSpi_._engineLoad23041 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreSpi_.staticClass, "engineLoad", "(Ljava/io/InputStream;[C)V");
		}
	}
}
