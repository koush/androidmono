namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class KeyStore : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static KeyStore()
		{
			InitJNI();
		}
		protected KeyStore(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass(typeof(global::java.security.KeyStore.Builder_))]
		public abstract partial class Builder : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Builder()
			{
				InitJNI();
			}
			protected Builder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _newInstance22946;
			public static global::java.security.KeyStore.Builder newInstance(java.security.KeyStore arg0, java.security.KeyStore.ProtectionParameter arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyStore.Builder.staticClass, global::java.security.KeyStore.Builder._newInstance22946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.KeyStore.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _newInstance22947;
			public static global::java.security.KeyStore.Builder newInstance(java.lang.String arg0, java.security.Provider arg1, java.io.File arg2, java.security.KeyStore.ProtectionParameter arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyStore.Builder.staticClass, global::java.security.KeyStore.Builder._newInstance22947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.security.KeyStore.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _newInstance22948;
			public static global::java.security.KeyStore.Builder newInstance(java.lang.String arg0, java.security.Provider arg1, java.security.KeyStore.ProtectionParameter arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyStore.Builder.staticClass, global::java.security.KeyStore.Builder._newInstance22948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.security.KeyStore.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _getKeyStore22949;
			public abstract global::java.security.KeyStore getKeyStore();
			internal static global::MonoJavaBridge.MethodId _getProtectionParameter22950;
			public abstract global::java.security.KeyStore.ProtectionParameter getProtectionParameter(java.lang.String arg0);
			internal static global::MonoJavaBridge.MethodId _Builder22951;
			protected Builder()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStore.Builder.staticClass, global::java.security.KeyStore.Builder._Builder22951);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.KeyStore.Builder.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStore$Builder"));
				global::java.security.KeyStore.Builder._newInstance22946 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyStore.Builder.staticClass, "newInstance", "(Ljava/security/KeyStore;Ljava/security/KeyStore$ProtectionParameter;)Ljava/security/KeyStore$Builder;");
				global::java.security.KeyStore.Builder._newInstance22947 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyStore.Builder.staticClass, "newInstance", "(Ljava/lang/String;Ljava/security/Provider;Ljava/io/File;Ljava/security/KeyStore$ProtectionParameter;)Ljava/security/KeyStore$Builder;");
				global::java.security.KeyStore.Builder._newInstance22948 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyStore.Builder.staticClass, "newInstance", "(Ljava/lang/String;Ljava/security/Provider;Ljava/security/KeyStore$ProtectionParameter;)Ljava/security/KeyStore$Builder;");
				global::java.security.KeyStore.Builder._getKeyStore22949 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.Builder.staticClass, "getKeyStore", "()Ljava/security/KeyStore;");
				global::java.security.KeyStore.Builder._getProtectionParameter22950 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.Builder.staticClass, "getProtectionParameter", "(Ljava/lang/String;)Ljava/security/KeyStore$ProtectionParameter;");
				global::java.security.KeyStore.Builder._Builder22951 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.Builder.staticClass, "<init>", "()V");
			}
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.KeyStore.Builder))]
		public sealed partial class Builder_ : java.security.KeyStore.Builder
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Builder_()
			{
				InitJNI();
			}
			internal Builder_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _getKeyStore22952;
			public override global::java.security.KeyStore getKeyStore() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore.Builder_._getKeyStore22952)) as java.security.KeyStore;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.Builder_.staticClass, global::java.security.KeyStore.Builder_._getKeyStore22952)) as java.security.KeyStore;
			}
			internal static global::MonoJavaBridge.MethodId _getProtectionParameter22953;
			public override global::java.security.KeyStore.ProtectionParameter getProtectionParameter(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.KeyStore.ProtectionParameter>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore.Builder_._getProtectionParameter22953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.KeyStore.ProtectionParameter;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.KeyStore.ProtectionParameter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.Builder_.staticClass, global::java.security.KeyStore.Builder_._getProtectionParameter22953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.KeyStore.ProtectionParameter;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.KeyStore.Builder_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStore$Builder"));
				global::java.security.KeyStore.Builder_._getKeyStore22952 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.Builder_.staticClass, "getKeyStore", "()Ljava/security/KeyStore;");
				global::java.security.KeyStore.Builder_._getProtectionParameter22953 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.Builder_.staticClass, "getProtectionParameter", "(Ljava/lang/String;)Ljava/security/KeyStore$ProtectionParameter;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class CallbackHandlerProtection : java.lang.Object, ProtectionParameter
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static CallbackHandlerProtection()
			{
				InitJNI();
			}
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
			internal static global::MonoJavaBridge.MethodId _getCallbackHandler22954;
			public virtual global::javax.security.auth.callback.CallbackHandler getCallbackHandler() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.security.auth.callback.CallbackHandler>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore.CallbackHandlerProtection._getCallbackHandler22954)) as javax.security.auth.callback.CallbackHandler;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.security.auth.callback.CallbackHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.CallbackHandlerProtection.staticClass, global::java.security.KeyStore.CallbackHandlerProtection._getCallbackHandler22954)) as javax.security.auth.callback.CallbackHandler;
			}
			internal static global::MonoJavaBridge.MethodId _CallbackHandlerProtection22955;
			public CallbackHandlerProtection(javax.security.auth.callback.CallbackHandler arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStore.CallbackHandlerProtection.staticClass, global::java.security.KeyStore.CallbackHandlerProtection._CallbackHandlerProtection22955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.KeyStore.CallbackHandlerProtection.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStore$CallbackHandlerProtection"));
				global::java.security.KeyStore.CallbackHandlerProtection._getCallbackHandler22954 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.CallbackHandlerProtection.staticClass, "getCallbackHandler", "()Ljavax/security/auth/callback/CallbackHandler;");
				global::java.security.KeyStore.CallbackHandlerProtection._CallbackHandlerProtection22955 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.CallbackHandlerProtection.staticClass, "<init>", "(Ljavax/security/auth/callback/CallbackHandler;)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.KeyStore.Entry_))]
		public partial interface Entry  : global::MonoJavaBridge.IJavaObject 
		{
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.KeyStore.Entry))]
		public sealed partial class Entry_ : java.lang.Object, Entry
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Entry_()
			{
				InitJNI();
			}
			internal Entry_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.KeyStore.Entry_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStore$Entry"));
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.KeyStore.LoadStoreParameter_))]
		public partial interface LoadStoreParameter  : global::MonoJavaBridge.IJavaObject 
		{
			global::java.security.KeyStore.ProtectionParameter getProtectionParameter();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.KeyStore.LoadStoreParameter))]
		public sealed partial class LoadStoreParameter_ : java.lang.Object, LoadStoreParameter
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static LoadStoreParameter_()
			{
				InitJNI();
			}
			internal LoadStoreParameter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _getProtectionParameter22956;
			 global::java.security.KeyStore.ProtectionParameter java.security.KeyStore.LoadStoreParameter.getProtectionParameter() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.KeyStore.ProtectionParameter>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore.LoadStoreParameter_._getProtectionParameter22956)) as java.security.KeyStore.ProtectionParameter;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.KeyStore.ProtectionParameter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.LoadStoreParameter_.staticClass, global::java.security.KeyStore.LoadStoreParameter_._getProtectionParameter22956)) as java.security.KeyStore.ProtectionParameter;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.KeyStore.LoadStoreParameter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStore$LoadStoreParameter"));
				global::java.security.KeyStore.LoadStoreParameter_._getProtectionParameter22956 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.LoadStoreParameter_.staticClass, "getProtectionParameter", "()Ljava/security/KeyStore$ProtectionParameter;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class PasswordProtection : java.lang.Object, ProtectionParameter, javax.security.auth.Destroyable
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static PasswordProtection()
			{
				InitJNI();
			}
			protected PasswordProtection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _destroy22957;
			public virtual void destroy() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStore.PasswordProtection._destroy22957);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyStore.PasswordProtection.staticClass, global::java.security.KeyStore.PasswordProtection._destroy22957);
			}
			internal static global::MonoJavaBridge.MethodId _isDestroyed22958;
			public virtual bool isDestroyed() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.KeyStore.PasswordProtection._isDestroyed22958);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.KeyStore.PasswordProtection.staticClass, global::java.security.KeyStore.PasswordProtection._isDestroyed22958);
			}
			public new char[] Password
			{
				get
				{
					return getPassword();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getPassword22959;
			public virtual char[] getPassword() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore.PasswordProtection._getPassword22959)) as char[];
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.PasswordProtection.staticClass, global::java.security.KeyStore.PasswordProtection._getPassword22959)) as char[];
			}
			internal static global::MonoJavaBridge.MethodId _PasswordProtection22960;
			public PasswordProtection(char[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStore.PasswordProtection.staticClass, global::java.security.KeyStore.PasswordProtection._PasswordProtection22960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.KeyStore.PasswordProtection.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStore$PasswordProtection"));
				global::java.security.KeyStore.PasswordProtection._destroy22957 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.PasswordProtection.staticClass, "destroy", "()V");
				global::java.security.KeyStore.PasswordProtection._isDestroyed22958 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.PasswordProtection.staticClass, "isDestroyed", "()Z");
				global::java.security.KeyStore.PasswordProtection._getPassword22959 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.PasswordProtection.staticClass, "getPassword", "()[C");
				global::java.security.KeyStore.PasswordProtection._PasswordProtection22960 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.PasswordProtection.staticClass, "<init>", "([C)V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class PrivateKeyEntry : java.lang.Object, Entry
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static PrivateKeyEntry()
			{
				InitJNI();
			}
			internal PrivateKeyEntry(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _toString22961;
			public sealed override global::java.lang.String toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore.PrivateKeyEntry._toString22961)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.PrivateKeyEntry.staticClass, global::java.security.KeyStore.PrivateKeyEntry._toString22961)) as java.lang.String;
			}
			public new global::java.security.cert.Certificate[] CertificateChain
			{
				get
				{
					return getCertificateChain();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getCertificateChain22962;
			public global::java.security.cert.Certificate[] getCertificateChain() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore.PrivateKeyEntry._getCertificateChain22962)) as java.security.cert.Certificate[];
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.PrivateKeyEntry.staticClass, global::java.security.KeyStore.PrivateKeyEntry._getCertificateChain22962)) as java.security.cert.Certificate[];
			}
			public new global::java.security.cert.Certificate Certificate
			{
				get
				{
					return getCertificate();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getCertificate22963;
			public global::java.security.cert.Certificate getCertificate() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore.PrivateKeyEntry._getCertificate22963)) as java.security.cert.Certificate;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.PrivateKeyEntry.staticClass, global::java.security.KeyStore.PrivateKeyEntry._getCertificate22963)) as java.security.cert.Certificate;
			}
			public new global::java.security.PrivateKey PrivateKey
			{
				get
				{
					return getPrivateKey();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getPrivateKey22964;
			public global::java.security.PrivateKey getPrivateKey() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PrivateKey>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore.PrivateKeyEntry._getPrivateKey22964)) as java.security.PrivateKey;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PrivateKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.PrivateKeyEntry.staticClass, global::java.security.KeyStore.PrivateKeyEntry._getPrivateKey22964)) as java.security.PrivateKey;
			}
			internal static global::MonoJavaBridge.MethodId _PrivateKeyEntry22965;
			public PrivateKeyEntry(java.security.PrivateKey arg0, java.security.cert.Certificate[] arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStore.PrivateKeyEntry.staticClass, global::java.security.KeyStore.PrivateKeyEntry._PrivateKeyEntry22965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.KeyStore.PrivateKeyEntry.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStore$PrivateKeyEntry"));
				global::java.security.KeyStore.PrivateKeyEntry._toString22961 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.PrivateKeyEntry.staticClass, "toString", "()Ljava/lang/String;");
				global::java.security.KeyStore.PrivateKeyEntry._getCertificateChain22962 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.PrivateKeyEntry.staticClass, "getCertificateChain", "()[Ljava/security/cert/Certificate;");
				global::java.security.KeyStore.PrivateKeyEntry._getCertificate22963 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.PrivateKeyEntry.staticClass, "getCertificate", "()Ljava/security/cert/Certificate;");
				global::java.security.KeyStore.PrivateKeyEntry._getPrivateKey22964 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.PrivateKeyEntry.staticClass, "getPrivateKey", "()Ljava/security/PrivateKey;");
				global::java.security.KeyStore.PrivateKeyEntry._PrivateKeyEntry22965 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.PrivateKeyEntry.staticClass, "<init>", "(Ljava/security/PrivateKey;[Ljava/security/cert/Certificate;)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.KeyStore.ProtectionParameter_))]
		public partial interface ProtectionParameter  : global::MonoJavaBridge.IJavaObject 
		{
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.KeyStore.ProtectionParameter))]
		public sealed partial class ProtectionParameter_ : java.lang.Object, ProtectionParameter
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static ProtectionParameter_()
			{
				InitJNI();
			}
			internal ProtectionParameter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.KeyStore.ProtectionParameter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStore$ProtectionParameter"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class SecretKeyEntry : java.lang.Object, Entry
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static SecretKeyEntry()
			{
				InitJNI();
			}
			internal SecretKeyEntry(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _toString22966;
			public sealed override global::java.lang.String toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore.SecretKeyEntry._toString22966)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.SecretKeyEntry.staticClass, global::java.security.KeyStore.SecretKeyEntry._toString22966)) as java.lang.String;
			}
			public new global::javax.crypto.SecretKey SecretKey
			{
				get
				{
					return getSecretKey();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSecretKey22967;
			public global::javax.crypto.SecretKey getSecretKey() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.crypto.SecretKey>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore.SecretKeyEntry._getSecretKey22967)) as javax.crypto.SecretKey;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.crypto.SecretKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.SecretKeyEntry.staticClass, global::java.security.KeyStore.SecretKeyEntry._getSecretKey22967)) as javax.crypto.SecretKey;
			}
			internal static global::MonoJavaBridge.MethodId _SecretKeyEntry22968;
			public SecretKeyEntry(javax.crypto.SecretKey arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStore.SecretKeyEntry.staticClass, global::java.security.KeyStore.SecretKeyEntry._SecretKeyEntry22968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.KeyStore.SecretKeyEntry.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStore$SecretKeyEntry"));
				global::java.security.KeyStore.SecretKeyEntry._toString22966 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.SecretKeyEntry.staticClass, "toString", "()Ljava/lang/String;");
				global::java.security.KeyStore.SecretKeyEntry._getSecretKey22967 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.SecretKeyEntry.staticClass, "getSecretKey", "()Ljavax/crypto/SecretKey;");
				global::java.security.KeyStore.SecretKeyEntry._SecretKeyEntry22968 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.SecretKeyEntry.staticClass, "<init>", "(Ljavax/crypto/SecretKey;)V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class TrustedCertificateEntry : java.lang.Object, Entry
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static TrustedCertificateEntry()
			{
				InitJNI();
			}
			internal TrustedCertificateEntry(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _toString22969;
			public sealed override global::java.lang.String toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore.TrustedCertificateEntry._toString22969)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.TrustedCertificateEntry.staticClass, global::java.security.KeyStore.TrustedCertificateEntry._toString22969)) as java.lang.String;
			}
			public new global::java.security.cert.Certificate TrustedCertificate
			{
				get
				{
					return getTrustedCertificate();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getTrustedCertificate22970;
			public global::java.security.cert.Certificate getTrustedCertificate() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore.TrustedCertificateEntry._getTrustedCertificate22970)) as java.security.cert.Certificate;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.TrustedCertificateEntry.staticClass, global::java.security.KeyStore.TrustedCertificateEntry._getTrustedCertificate22970)) as java.security.cert.Certificate;
			}
			internal static global::MonoJavaBridge.MethodId _TrustedCertificateEntry22971;
			public TrustedCertificateEntry(java.security.cert.Certificate arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStore.TrustedCertificateEntry.staticClass, global::java.security.KeyStore.TrustedCertificateEntry._TrustedCertificateEntry22971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.KeyStore.TrustedCertificateEntry.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStore$TrustedCertificateEntry"));
				global::java.security.KeyStore.TrustedCertificateEntry._toString22969 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.TrustedCertificateEntry.staticClass, "toString", "()Ljava/lang/String;");
				global::java.security.KeyStore.TrustedCertificateEntry._getTrustedCertificate22970 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.TrustedCertificateEntry.staticClass, "getTrustedCertificate", "()Ljava/security/cert/Certificate;");
				global::java.security.KeyStore.TrustedCertificateEntry._TrustedCertificateEntry22971 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.TrustedCertificateEntry.staticClass, "<init>", "(Ljava/security/cert/Certificate;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _size22972;
		public virtual int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.KeyStore._size22972);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._size22972);
		}
		internal static global::MonoJavaBridge.MethodId _getKey22973;
		public virtual global::java.security.Key getKey(java.lang.String arg0, char[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Key>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore._getKey22973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.Key;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Key>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._getKey22973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.Key;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance22974;
		public static global::java.security.KeyStore getInstance(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyStore.staticClass, global::java.security.KeyStore._getInstance22974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.KeyStore;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance22975;
		public static global::java.security.KeyStore getInstance(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyStore.staticClass, global::java.security.KeyStore._getInstance22975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.KeyStore;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance22976;
		public static global::java.security.KeyStore getInstance(java.lang.String arg0, java.security.Provider arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyStore.staticClass, global::java.security.KeyStore._getInstance22976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.KeyStore;
		}
		internal static global::MonoJavaBridge.MethodId _load22977;
		public virtual void load(java.io.InputStream arg0, char[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStore._load22977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._load22977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _load22978;
		public virtual void load(java.security.KeyStore.LoadStoreParameter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStore._load22978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._load22978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _store22979;
		public virtual void store(java.io.OutputStream arg0, char[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStore._store22979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._store22979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _store22980;
		public virtual void store(java.security.KeyStore.LoadStoreParameter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStore._store22980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._store22980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Type
		{
			get
			{
				return getType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getType22981;
		public virtual global::java.lang.String getType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore._getType22981)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._getType22981)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEntry22982;
		public virtual global::java.security.KeyStore.Entry getEntry(java.lang.String arg0, java.security.KeyStore.ProtectionParameter arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.KeyStore.Entry>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore._getEntry22982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.KeyStore.Entry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.KeyStore.Entry>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._getEntry22982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.KeyStore.Entry;
		}
		internal static global::MonoJavaBridge.MethodId _aliases22983;
		public virtual global::java.util.Enumeration aliases() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore._aliases22983)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._aliases22983)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _setEntry22984;
		public virtual void setEntry(java.lang.String arg0, java.security.KeyStore.Entry arg1, java.security.KeyStore.ProtectionParameter arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStore._setEntry22984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._setEntry22984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getCertificateChain22985;
		public virtual global::java.security.cert.Certificate[] getCertificateChain(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore._getCertificateChain22985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.Certificate[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._getCertificateChain22985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.Certificate[];
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProvider22986;
		public virtual global::java.security.Provider getProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore._getProvider22986)) as java.security.Provider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._getProvider22986)) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _getCertificate22987;
		public virtual global::java.security.cert.Certificate getCertificate(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore._getCertificate22987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.Certificate;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._getCertificate22987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.Certificate;
		}
		public static global::java.lang.String DefaultType
		{
			get
			{
				return getDefaultType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultType22988;
		public static global::java.lang.String getDefaultType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.security.KeyStore.staticClass, global::java.security.KeyStore._getDefaultType22988)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getCreationDate22989;
		public virtual global::java.util.Date getCreationDate(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore._getCreationDate22989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._getCreationDate22989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _setKeyEntry22990;
		public virtual void setKeyEntry(java.lang.String arg0, byte[] arg1, java.security.cert.Certificate[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStore._setKeyEntry22990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._setKeyEntry22990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setKeyEntry22991;
		public virtual void setKeyEntry(java.lang.String arg0, java.security.Key arg1, char[] arg2, java.security.cert.Certificate[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStore._setKeyEntry22991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._setKeyEntry22991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setCertificateEntry22992;
		public virtual void setCertificateEntry(java.lang.String arg0, java.security.cert.Certificate arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStore._setCertificateEntry22992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._setCertificateEntry22992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _deleteEntry22993;
		public virtual void deleteEntry(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStore._deleteEntry22993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._deleteEntry22993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAlias22994;
		public virtual bool containsAlias(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.KeyStore._containsAlias22994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._containsAlias22994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isKeyEntry22995;
		public virtual bool isKeyEntry(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.KeyStore._isKeyEntry22995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._isKeyEntry22995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCertificateEntry22996;
		public virtual bool isCertificateEntry(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.KeyStore._isCertificateEntry22996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._isCertificateEntry22996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCertificateAlias22997;
		public virtual global::java.lang.String getCertificateAlias(java.security.cert.Certificate arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore._getCertificateAlias22997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._getCertificateAlias22997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _entryInstanceOf22998;
		public virtual bool entryInstanceOf(java.lang.String arg0, java.lang.Class arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.KeyStore._entryInstanceOf22998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._entryInstanceOf22998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _KeyStore22999;
		protected KeyStore(java.security.KeyStoreSpi arg0, java.security.Provider arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStore.staticClass, global::java.security.KeyStore._KeyStore22999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyStore.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStore"));
			global::java.security.KeyStore._size22972 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "size", "()I");
			global::java.security.KeyStore._getKey22973 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getKey", "(Ljava/lang/String;[C)Ljava/security/Key;");
			global::java.security.KeyStore._getInstance22974 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/security/KeyStore;");
			global::java.security.KeyStore._getInstance22975 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/KeyStore;");
			global::java.security.KeyStore._getInstance22976 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/KeyStore;");
			global::java.security.KeyStore._load22977 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "load", "(Ljava/io/InputStream;[C)V");
			global::java.security.KeyStore._load22978 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "load", "(Ljava/security/KeyStore$LoadStoreParameter;)V");
			global::java.security.KeyStore._store22979 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "store", "(Ljava/io/OutputStream;[C)V");
			global::java.security.KeyStore._store22980 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "store", "(Ljava/security/KeyStore$LoadStoreParameter;)V");
			global::java.security.KeyStore._getType22981 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getType", "()Ljava/lang/String;");
			global::java.security.KeyStore._getEntry22982 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getEntry", "(Ljava/lang/String;Ljava/security/KeyStore$ProtectionParameter;)Ljava/security/KeyStore$Entry;");
			global::java.security.KeyStore._aliases22983 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "aliases", "()Ljava/util/Enumeration;");
			global::java.security.KeyStore._setEntry22984 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "setEntry", "(Ljava/lang/String;Ljava/security/KeyStore$Entry;Ljava/security/KeyStore$ProtectionParameter;)V");
			global::java.security.KeyStore._getCertificateChain22985 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getCertificateChain", "(Ljava/lang/String;)[Ljava/security/cert/Certificate;");
			global::java.security.KeyStore._getProvider22986 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::java.security.KeyStore._getCertificate22987 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getCertificate", "(Ljava/lang/String;)Ljava/security/cert/Certificate;");
			global::java.security.KeyStore._getDefaultType22988 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getDefaultType", "()Ljava/lang/String;");
			global::java.security.KeyStore._getCreationDate22989 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getCreationDate", "(Ljava/lang/String;)Ljava/util/Date;");
			global::java.security.KeyStore._setKeyEntry22990 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "setKeyEntry", "(Ljava/lang/String;[B[Ljava/security/cert/Certificate;)V");
			global::java.security.KeyStore._setKeyEntry22991 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "setKeyEntry", "(Ljava/lang/String;Ljava/security/Key;[C[Ljava/security/cert/Certificate;)V");
			global::java.security.KeyStore._setCertificateEntry22992 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "setCertificateEntry", "(Ljava/lang/String;Ljava/security/cert/Certificate;)V");
			global::java.security.KeyStore._deleteEntry22993 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "deleteEntry", "(Ljava/lang/String;)V");
			global::java.security.KeyStore._containsAlias22994 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "containsAlias", "(Ljava/lang/String;)Z");
			global::java.security.KeyStore._isKeyEntry22995 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "isKeyEntry", "(Ljava/lang/String;)Z");
			global::java.security.KeyStore._isCertificateEntry22996 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "isCertificateEntry", "(Ljava/lang/String;)Z");
			global::java.security.KeyStore._getCertificateAlias22997 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getCertificateAlias", "(Ljava/security/cert/Certificate;)Ljava/lang/String;");
			global::java.security.KeyStore._entryInstanceOf22998 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "entryInstanceOf", "(Ljava/lang/String;Ljava/lang/Class;)Z");
			global::java.security.KeyStore._KeyStore22999 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "<init>", "(Ljava/security/KeyStoreSpi;Ljava/security/Provider;Ljava/lang/String;)V");
		}
	}
}
