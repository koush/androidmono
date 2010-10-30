namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class KeyStore : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected KeyStore(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass(typeof(global::java.security.KeyStore.Builder_))]
		public abstract partial class Builder : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected Builder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _newInstance23065;
			public static global::java.security.KeyStore.Builder newInstance(java.security.KeyStore arg0, java.security.KeyStore.ProtectionParameter arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.security.KeyStore.Builder._newInstance23065.native == global::System.IntPtr.Zero)
					global::java.security.KeyStore.Builder._newInstance23065 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyStore.Builder.staticClass, "newInstance", "(Ljava/security/KeyStore;Ljava/security/KeyStore$ProtectionParameter;)Ljava/security/KeyStore$Builder;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyStore.Builder.staticClass, global::java.security.KeyStore.Builder._newInstance23065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.KeyStore.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _newInstance23066;
			public static global::java.security.KeyStore.Builder newInstance(java.lang.String arg0, java.security.Provider arg1, java.io.File arg2, java.security.KeyStore.ProtectionParameter arg3)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.security.KeyStore.Builder._newInstance23066.native == global::System.IntPtr.Zero)
					global::java.security.KeyStore.Builder._newInstance23066 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyStore.Builder.staticClass, "newInstance", "(Ljava/lang/String;Ljava/security/Provider;Ljava/io/File;Ljava/security/KeyStore$ProtectionParameter;)Ljava/security/KeyStore$Builder;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyStore.Builder.staticClass, global::java.security.KeyStore.Builder._newInstance23066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.security.KeyStore.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _newInstance23067;
			public static global::java.security.KeyStore.Builder newInstance(java.lang.String arg0, java.security.Provider arg1, java.security.KeyStore.ProtectionParameter arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.security.KeyStore.Builder._newInstance23067.native == global::System.IntPtr.Zero)
					global::java.security.KeyStore.Builder._newInstance23067 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyStore.Builder.staticClass, "newInstance", "(Ljava/lang/String;Ljava/security/Provider;Ljava/security/KeyStore$ProtectionParameter;)Ljava/security/KeyStore$Builder;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyStore.Builder.staticClass, global::java.security.KeyStore.Builder._newInstance23067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.security.KeyStore.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _getKeyStore23068;
			public abstract global::java.security.KeyStore getKeyStore();
			internal static global::MonoJavaBridge.MethodId _getProtectionParameter23069;
			public abstract global::java.security.KeyStore.ProtectionParameter getProtectionParameter(java.lang.String arg0);
			internal static global::MonoJavaBridge.MethodId _Builder23070;
			protected Builder() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.security.KeyStore.Builder._Builder23070.native == global::System.IntPtr.Zero)
					global::java.security.KeyStore.Builder._Builder23070 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.Builder.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStore.Builder.staticClass, global::java.security.KeyStore.Builder._Builder23070);
				Init(@__env, handle);
			}
			static Builder()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.KeyStore.Builder.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStore$Builder"));
			}
			internal static void InitJNI()
			{
			}
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.KeyStore.Builder))]
		internal sealed partial class Builder_ : java.security.KeyStore.Builder
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Builder_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _getKeyStore23071;
			public override global::java.security.KeyStore getKeyStore()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.security.KeyStore.Builder_._getKeyStore23071.native == global::System.IntPtr.Zero)
					global::java.security.KeyStore.Builder_._getKeyStore23071 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.Builder_.staticClass, "getKeyStore", "()Ljava/security/KeyStore;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore.Builder_._getKeyStore23071)) as java.security.KeyStore;
			}
			internal static global::MonoJavaBridge.MethodId _getProtectionParameter23072;
			public override global::java.security.KeyStore.ProtectionParameter getProtectionParameter(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.security.KeyStore.Builder_._getProtectionParameter23072.native == global::System.IntPtr.Zero)
					global::java.security.KeyStore.Builder_._getProtectionParameter23072 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.Builder_.staticClass, "getProtectionParameter", "(Ljava/lang/String;)Ljava/security/KeyStore$ProtectionParameter;");
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.KeyStore.ProtectionParameter>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore.Builder_._getProtectionParameter23072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.KeyStore.ProtectionParameter;
			}
			static Builder_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.KeyStore.Builder_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStore$Builder"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class CallbackHandlerProtection : java.lang.Object, ProtectionParameter
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected CallbackHandlerProtection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			public new global::javax.security.auth.callback.CallbackHandler CallbackHandler
			{
				get
				{
					return getCallbackHandler();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getCallbackHandler23073;
			public virtual global::javax.security.auth.callback.CallbackHandler getCallbackHandler()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.security.KeyStore.CallbackHandlerProtection._getCallbackHandler23073.native == global::System.IntPtr.Zero)
					global::java.security.KeyStore.CallbackHandlerProtection._getCallbackHandler23073 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.CallbackHandlerProtection.staticClass, "getCallbackHandler", "()Ljavax/security/auth/callback/CallbackHandler;");
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.security.auth.callback.CallbackHandler>(this, global::java.security.KeyStore.CallbackHandlerProtection.staticClass, global::java.security.KeyStore.CallbackHandlerProtection._getCallbackHandler23073) as javax.security.auth.callback.CallbackHandler;
			}
			internal static global::MonoJavaBridge.MethodId _CallbackHandlerProtection23074;
			public CallbackHandlerProtection(javax.security.auth.callback.CallbackHandler arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.security.KeyStore.CallbackHandlerProtection._CallbackHandlerProtection23074.native == global::System.IntPtr.Zero)
					global::java.security.KeyStore.CallbackHandlerProtection._CallbackHandlerProtection23074 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.CallbackHandlerProtection.staticClass, "<init>", "(Ljavax/security/auth/callback/CallbackHandler;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStore.CallbackHandlerProtection.staticClass, global::java.security.KeyStore.CallbackHandlerProtection._CallbackHandlerProtection23074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static CallbackHandlerProtection()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.KeyStore.CallbackHandlerProtection.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStore$CallbackHandlerProtection"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.KeyStore.Entry_))]
		public partial interface Entry  : global::MonoJavaBridge.IJavaObject 
		{
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.KeyStore.Entry))]
		internal sealed partial class Entry_ : java.lang.Object, Entry
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Entry_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			static Entry_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.KeyStore.Entry_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStore$Entry"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.KeyStore.LoadStoreParameter_))]
		public partial interface LoadStoreParameter  : global::MonoJavaBridge.IJavaObject 
		{
			global::java.security.KeyStore.ProtectionParameter getProtectionParameter();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.KeyStore.LoadStoreParameter))]
		internal sealed partial class LoadStoreParameter_ : java.lang.Object, LoadStoreParameter
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal LoadStoreParameter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _getProtectionParameter23075;
			global::java.security.KeyStore.ProtectionParameter java.security.KeyStore.LoadStoreParameter.getProtectionParameter()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.security.KeyStore.LoadStoreParameter_._getProtectionParameter23075.native == global::System.IntPtr.Zero)
					global::java.security.KeyStore.LoadStoreParameter_._getProtectionParameter23075 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.LoadStoreParameter_.staticClass, "getProtectionParameter", "()Ljava/security/KeyStore$ProtectionParameter;");
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.KeyStore.ProtectionParameter>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore.LoadStoreParameter_._getProtectionParameter23075)) as java.security.KeyStore.ProtectionParameter;
			}
			static LoadStoreParameter_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.KeyStore.LoadStoreParameter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStore$LoadStoreParameter"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class PasswordProtection : java.lang.Object, ProtectionParameter, javax.security.auth.Destroyable
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected PasswordProtection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _destroy23076;
			public virtual void destroy()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.security.KeyStore.PasswordProtection._destroy23076.native == global::System.IntPtr.Zero)
					global::java.security.KeyStore.PasswordProtection._destroy23076 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.PasswordProtection.staticClass, "destroy", "()V");
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.KeyStore.PasswordProtection.staticClass, global::java.security.KeyStore.PasswordProtection._destroy23076);
			}
			internal static global::MonoJavaBridge.MethodId _isDestroyed23077;
			public virtual bool isDestroyed()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.security.KeyStore.PasswordProtection._isDestroyed23077.native == global::System.IntPtr.Zero)
					global::java.security.KeyStore.PasswordProtection._isDestroyed23077 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.PasswordProtection.staticClass, "isDestroyed", "()Z");
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.KeyStore.PasswordProtection.staticClass, global::java.security.KeyStore.PasswordProtection._isDestroyed23077);
			}
			public new char[] Password
			{
				get
				{
					return getPassword();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getPassword23078;
			public virtual char[] getPassword()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.security.KeyStore.PasswordProtection._getPassword23078.native == global::System.IntPtr.Zero)
					global::java.security.KeyStore.PasswordProtection._getPassword23078 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.PasswordProtection.staticClass, "getPassword", "()[C");
				return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<char>(this, global::java.security.KeyStore.PasswordProtection.staticClass, global::java.security.KeyStore.PasswordProtection._getPassword23078) as char[];
			}
			internal static global::MonoJavaBridge.MethodId _PasswordProtection23079;
			public PasswordProtection(char[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.security.KeyStore.PasswordProtection._PasswordProtection23079.native == global::System.IntPtr.Zero)
					global::java.security.KeyStore.PasswordProtection._PasswordProtection23079 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.PasswordProtection.staticClass, "<init>", "([C)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStore.PasswordProtection.staticClass, global::java.security.KeyStore.PasswordProtection._PasswordProtection23079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static PasswordProtection()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.KeyStore.PasswordProtection.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStore$PasswordProtection"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class PrivateKeyEntry : java.lang.Object, Entry
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal PrivateKeyEntry(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _toString23080;
			public sealed override global::java.lang.String toString()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.security.KeyStore.PrivateKeyEntry._toString23080.native == global::System.IntPtr.Zero)
					global::java.security.KeyStore.PrivateKeyEntry._toString23080 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.PrivateKeyEntry.staticClass, "toString", "()Ljava/lang/String;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.PrivateKeyEntry.staticClass, global::java.security.KeyStore.PrivateKeyEntry._toString23080)) as java.lang.String;
			}
			public new global::java.security.cert.Certificate[] CertificateChain
			{
				get
				{
					return getCertificateChain();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getCertificateChain23081;
			public global::java.security.cert.Certificate[] getCertificateChain()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.security.KeyStore.PrivateKeyEntry._getCertificateChain23081.native == global::System.IntPtr.Zero)
					global::java.security.KeyStore.PrivateKeyEntry._getCertificateChain23081 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.PrivateKeyEntry.staticClass, "getCertificateChain", "()[Ljava/security/cert/Certificate;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.PrivateKeyEntry.staticClass, global::java.security.KeyStore.PrivateKeyEntry._getCertificateChain23081)) as java.security.cert.Certificate[];
			}
			public new global::java.security.cert.Certificate Certificate
			{
				get
				{
					return getCertificate();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getCertificate23082;
			public global::java.security.cert.Certificate getCertificate()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.security.KeyStore.PrivateKeyEntry._getCertificate23082.native == global::System.IntPtr.Zero)
					global::java.security.KeyStore.PrivateKeyEntry._getCertificate23082 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.PrivateKeyEntry.staticClass, "getCertificate", "()Ljava/security/cert/Certificate;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.PrivateKeyEntry.staticClass, global::java.security.KeyStore.PrivateKeyEntry._getCertificate23082)) as java.security.cert.Certificate;
			}
			public new global::java.security.PrivateKey PrivateKey
			{
				get
				{
					return getPrivateKey();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getPrivateKey23083;
			public global::java.security.PrivateKey getPrivateKey()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.security.KeyStore.PrivateKeyEntry._getPrivateKey23083.native == global::System.IntPtr.Zero)
					global::java.security.KeyStore.PrivateKeyEntry._getPrivateKey23083 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.PrivateKeyEntry.staticClass, "getPrivateKey", "()Ljava/security/PrivateKey;");
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PrivateKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.PrivateKeyEntry.staticClass, global::java.security.KeyStore.PrivateKeyEntry._getPrivateKey23083)) as java.security.PrivateKey;
			}
			internal static global::MonoJavaBridge.MethodId _PrivateKeyEntry23084;
			public PrivateKeyEntry(java.security.PrivateKey arg0, java.security.cert.Certificate[] arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.security.KeyStore.PrivateKeyEntry._PrivateKeyEntry23084.native == global::System.IntPtr.Zero)
					global::java.security.KeyStore.PrivateKeyEntry._PrivateKeyEntry23084 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.PrivateKeyEntry.staticClass, "<init>", "(Ljava/security/PrivateKey;[Ljava/security/cert/Certificate;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStore.PrivateKeyEntry.staticClass, global::java.security.KeyStore.PrivateKeyEntry._PrivateKeyEntry23084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			static PrivateKeyEntry()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.KeyStore.PrivateKeyEntry.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStore$PrivateKeyEntry"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.KeyStore.ProtectionParameter_))]
		public partial interface ProtectionParameter  : global::MonoJavaBridge.IJavaObject 
		{
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.KeyStore.ProtectionParameter))]
		internal sealed partial class ProtectionParameter_ : java.lang.Object, ProtectionParameter
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal ProtectionParameter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			static ProtectionParameter_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.KeyStore.ProtectionParameter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStore$ProtectionParameter"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class SecretKeyEntry : java.lang.Object, Entry
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal SecretKeyEntry(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _toString23085;
			public sealed override global::java.lang.String toString()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.security.KeyStore.SecretKeyEntry._toString23085.native == global::System.IntPtr.Zero)
					global::java.security.KeyStore.SecretKeyEntry._toString23085 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.SecretKeyEntry.staticClass, "toString", "()Ljava/lang/String;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.SecretKeyEntry.staticClass, global::java.security.KeyStore.SecretKeyEntry._toString23085)) as java.lang.String;
			}
			public new global::javax.crypto.SecretKey SecretKey
			{
				get
				{
					return getSecretKey();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSecretKey23086;
			public global::javax.crypto.SecretKey getSecretKey()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.security.KeyStore.SecretKeyEntry._getSecretKey23086.native == global::System.IntPtr.Zero)
					global::java.security.KeyStore.SecretKeyEntry._getSecretKey23086 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.SecretKeyEntry.staticClass, "getSecretKey", "()Ljavax/crypto/SecretKey;");
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.crypto.SecretKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.SecretKeyEntry.staticClass, global::java.security.KeyStore.SecretKeyEntry._getSecretKey23086)) as javax.crypto.SecretKey;
			}
			internal static global::MonoJavaBridge.MethodId _SecretKeyEntry23087;
			public SecretKeyEntry(javax.crypto.SecretKey arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.security.KeyStore.SecretKeyEntry._SecretKeyEntry23087.native == global::System.IntPtr.Zero)
					global::java.security.KeyStore.SecretKeyEntry._SecretKeyEntry23087 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.SecretKeyEntry.staticClass, "<init>", "(Ljavax/crypto/SecretKey;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStore.SecretKeyEntry.staticClass, global::java.security.KeyStore.SecretKeyEntry._SecretKeyEntry23087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static SecretKeyEntry()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.KeyStore.SecretKeyEntry.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStore$SecretKeyEntry"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class TrustedCertificateEntry : java.lang.Object, Entry
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal TrustedCertificateEntry(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _toString23088;
			public sealed override global::java.lang.String toString()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.security.KeyStore.TrustedCertificateEntry._toString23088.native == global::System.IntPtr.Zero)
					global::java.security.KeyStore.TrustedCertificateEntry._toString23088 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.TrustedCertificateEntry.staticClass, "toString", "()Ljava/lang/String;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.TrustedCertificateEntry.staticClass, global::java.security.KeyStore.TrustedCertificateEntry._toString23088)) as java.lang.String;
			}
			public new global::java.security.cert.Certificate TrustedCertificate
			{
				get
				{
					return getTrustedCertificate();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getTrustedCertificate23089;
			public global::java.security.cert.Certificate getTrustedCertificate()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.security.KeyStore.TrustedCertificateEntry._getTrustedCertificate23089.native == global::System.IntPtr.Zero)
					global::java.security.KeyStore.TrustedCertificateEntry._getTrustedCertificate23089 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.TrustedCertificateEntry.staticClass, "getTrustedCertificate", "()Ljava/security/cert/Certificate;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.TrustedCertificateEntry.staticClass, global::java.security.KeyStore.TrustedCertificateEntry._getTrustedCertificate23089)) as java.security.cert.Certificate;
			}
			internal static global::MonoJavaBridge.MethodId _TrustedCertificateEntry23090;
			public TrustedCertificateEntry(java.security.cert.Certificate arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.security.KeyStore.TrustedCertificateEntry._TrustedCertificateEntry23090.native == global::System.IntPtr.Zero)
					global::java.security.KeyStore.TrustedCertificateEntry._TrustedCertificateEntry23090 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.TrustedCertificateEntry.staticClass, "<init>", "(Ljava/security/cert/Certificate;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStore.TrustedCertificateEntry.staticClass, global::java.security.KeyStore.TrustedCertificateEntry._TrustedCertificateEntry23090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static TrustedCertificateEntry()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.KeyStore.TrustedCertificateEntry.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStore$TrustedCertificateEntry"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _size23091;
		public virtual int size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStore._size23091.native == global::System.IntPtr.Zero)
				global::java.security.KeyStore._size23091 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "size", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._size23091);
		}
		internal static global::MonoJavaBridge.MethodId _getKey23092;
		public virtual global::java.security.Key getKey(java.lang.String arg0, char[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStore._getKey23092.native == global::System.IntPtr.Zero)
				global::java.security.KeyStore._getKey23092 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getKey", "(Ljava/lang/String;[C)Ljava/security/Key;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Key>(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._getKey23092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.security.Key;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23093;
		public static global::java.security.KeyStore getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStore._getInstance23093.native == global::System.IntPtr.Zero)
				global::java.security.KeyStore._getInstance23093 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/security/KeyStore;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyStore.staticClass, global::java.security.KeyStore._getInstance23093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.KeyStore;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23094;
		public static global::java.security.KeyStore getInstance(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStore._getInstance23094.native == global::System.IntPtr.Zero)
				global::java.security.KeyStore._getInstance23094 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/KeyStore;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyStore.staticClass, global::java.security.KeyStore._getInstance23094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.KeyStore;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23095;
		public static global::java.security.KeyStore getInstance(java.lang.String arg0, java.security.Provider arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStore._getInstance23095.native == global::System.IntPtr.Zero)
				global::java.security.KeyStore._getInstance23095 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/KeyStore;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyStore.staticClass, global::java.security.KeyStore._getInstance23095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.KeyStore;
		}
		internal static global::MonoJavaBridge.MethodId _load23096;
		public virtual void load(java.io.InputStream arg0, char[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStore._load23096.native == global::System.IntPtr.Zero)
				global::java.security.KeyStore._load23096 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "load", "(Ljava/io/InputStream;[C)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._load23096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _load23097;
		public virtual void load(java.security.KeyStore.LoadStoreParameter arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStore._load23097.native == global::System.IntPtr.Zero)
				global::java.security.KeyStore._load23097 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "load", "(Ljava/security/KeyStore$LoadStoreParameter;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._load23097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _store23098;
		public virtual void store(java.io.OutputStream arg0, char[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStore._store23098.native == global::System.IntPtr.Zero)
				global::java.security.KeyStore._store23098 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "store", "(Ljava/io/OutputStream;[C)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._store23098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _store23099;
		public virtual void store(java.security.KeyStore.LoadStoreParameter arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStore._store23099.native == global::System.IntPtr.Zero)
				global::java.security.KeyStore._store23099 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "store", "(Ljava/security/KeyStore$LoadStoreParameter;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._store23099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Type
		{
			get
			{
				return getType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getType23100;
		public virtual global::java.lang.String getType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStore._getType23100.native == global::System.IntPtr.Zero)
				global::java.security.KeyStore._getType23100 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getType", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._getType23100) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEntry23101;
		public virtual global::java.security.KeyStore.Entry getEntry(java.lang.String arg0, java.security.KeyStore.ProtectionParameter arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStore._getEntry23101.native == global::System.IntPtr.Zero)
				global::java.security.KeyStore._getEntry23101 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getEntry", "(Ljava/lang/String;Ljava/security/KeyStore$ProtectionParameter;)Ljava/security/KeyStore$Entry;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.KeyStore.Entry>(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._getEntry23101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.security.KeyStore.Entry;
		}
		internal static global::MonoJavaBridge.MethodId _aliases23102;
		public virtual global::java.util.Enumeration aliases()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStore._aliases23102.native == global::System.IntPtr.Zero)
				global::java.security.KeyStore._aliases23102 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "aliases", "()Ljava/util/Enumeration;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._aliases23102) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _setEntry23103;
		public virtual void setEntry(java.lang.String arg0, java.security.KeyStore.Entry arg1, java.security.KeyStore.ProtectionParameter arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStore._setEntry23103.native == global::System.IntPtr.Zero)
				global::java.security.KeyStore._setEntry23103 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "setEntry", "(Ljava/lang/String;Ljava/security/KeyStore$Entry;Ljava/security/KeyStore$ProtectionParameter;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._setEntry23103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getCertificateChain23104;
		public virtual global::java.security.cert.Certificate[] getCertificateChain(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStore._getCertificateChain23104.native == global::System.IntPtr.Zero)
				global::java.security.KeyStore._getCertificateChain23104 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getCertificateChain", "(Ljava/lang/String;)[Ljava/security/cert/Certificate;");
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.security.cert.Certificate>(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._getCertificateChain23104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.cert.Certificate[];
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProvider23105;
		public virtual global::java.security.Provider getProvider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStore._getProvider23105.native == global::System.IntPtr.Zero)
				global::java.security.KeyStore._getProvider23105 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getProvider", "()Ljava/security/Provider;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._getProvider23105) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _getCertificate23106;
		public virtual global::java.security.cert.Certificate getCertificate(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStore._getCertificate23106.native == global::System.IntPtr.Zero)
				global::java.security.KeyStore._getCertificate23106 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getCertificate", "(Ljava/lang/String;)Ljava/security/cert/Certificate;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._getCertificate23106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.cert.Certificate;
		}
		public static global::java.lang.String DefaultType
		{
			get
			{
				return getDefaultType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultType23107;
		public static global::java.lang.String getDefaultType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStore._getDefaultType23107.native == global::System.IntPtr.Zero)
				global::java.security.KeyStore._getDefaultType23107 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getDefaultType", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.security.KeyStore.staticClass, global::java.security.KeyStore._getDefaultType23107)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getCreationDate23108;
		public virtual global::java.util.Date getCreationDate(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStore._getCreationDate23108.native == global::System.IntPtr.Zero)
				global::java.security.KeyStore._getCreationDate23108 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getCreationDate", "(Ljava/lang/String;)Ljava/util/Date;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._getCreationDate23108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _setKeyEntry23109;
		public virtual void setKeyEntry(java.lang.String arg0, byte[] arg1, java.security.cert.Certificate[] arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStore._setKeyEntry23109.native == global::System.IntPtr.Zero)
				global::java.security.KeyStore._setKeyEntry23109 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "setKeyEntry", "(Ljava/lang/String;[B[Ljava/security/cert/Certificate;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._setKeyEntry23109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setKeyEntry23110;
		public virtual void setKeyEntry(java.lang.String arg0, java.security.Key arg1, char[] arg2, java.security.cert.Certificate[] arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStore._setKeyEntry23110.native == global::System.IntPtr.Zero)
				global::java.security.KeyStore._setKeyEntry23110 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "setKeyEntry", "(Ljava/lang/String;Ljava/security/Key;[C[Ljava/security/cert/Certificate;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._setKeyEntry23110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setCertificateEntry23111;
		public virtual void setCertificateEntry(java.lang.String arg0, java.security.cert.Certificate arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStore._setCertificateEntry23111.native == global::System.IntPtr.Zero)
				global::java.security.KeyStore._setCertificateEntry23111 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "setCertificateEntry", "(Ljava/lang/String;Ljava/security/cert/Certificate;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._setCertificateEntry23111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _deleteEntry23112;
		public virtual void deleteEntry(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStore._deleteEntry23112.native == global::System.IntPtr.Zero)
				global::java.security.KeyStore._deleteEntry23112 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "deleteEntry", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._deleteEntry23112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAlias23113;
		public virtual bool containsAlias(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStore._containsAlias23113.native == global::System.IntPtr.Zero)
				global::java.security.KeyStore._containsAlias23113 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "containsAlias", "(Ljava/lang/String;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._containsAlias23113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isKeyEntry23114;
		public virtual bool isKeyEntry(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStore._isKeyEntry23114.native == global::System.IntPtr.Zero)
				global::java.security.KeyStore._isKeyEntry23114 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "isKeyEntry", "(Ljava/lang/String;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._isKeyEntry23114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCertificateEntry23115;
		public virtual bool isCertificateEntry(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStore._isCertificateEntry23115.native == global::System.IntPtr.Zero)
				global::java.security.KeyStore._isCertificateEntry23115 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "isCertificateEntry", "(Ljava/lang/String;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._isCertificateEntry23115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCertificateAlias23116;
		public virtual global::java.lang.String getCertificateAlias(java.security.cert.Certificate arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStore._getCertificateAlias23116.native == global::System.IntPtr.Zero)
				global::java.security.KeyStore._getCertificateAlias23116 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getCertificateAlias", "(Ljava/security/cert/Certificate;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._getCertificateAlias23116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _entryInstanceOf23117;
		public virtual bool entryInstanceOf(java.lang.String arg0, java.lang.Class arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStore._entryInstanceOf23117.native == global::System.IntPtr.Zero)
				global::java.security.KeyStore._entryInstanceOf23117 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "entryInstanceOf", "(Ljava/lang/String;Ljava/lang/Class;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._entryInstanceOf23117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _KeyStore23118;
		protected KeyStore(java.security.KeyStoreSpi arg0, java.security.Provider arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStore._KeyStore23118.native == global::System.IntPtr.Zero)
				global::java.security.KeyStore._KeyStore23118 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "<init>", "(Ljava/security/KeyStoreSpi;Ljava/security/Provider;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStore.staticClass, global::java.security.KeyStore._KeyStore23118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static KeyStore()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyStore.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStore"));
		}
		internal static void InitJNI()
		{
		}
	}
}
