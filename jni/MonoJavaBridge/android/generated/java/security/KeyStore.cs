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
			internal static global::MonoJavaBridge.MethodId _newInstance17347;
			public static global::java.security.KeyStore.Builder newInstance(java.security.KeyStore arg0, java.security.KeyStore.ProtectionParameter arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyStore.Builder.staticClass, global::java.security.KeyStore.Builder._newInstance17347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.KeyStore.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _newInstance17348;
			public static global::java.security.KeyStore.Builder newInstance(java.lang.String arg0, java.security.Provider arg1, java.io.File arg2, java.security.KeyStore.ProtectionParameter arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyStore.Builder.staticClass, global::java.security.KeyStore.Builder._newInstance17348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.security.KeyStore.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _newInstance17349;
			public static global::java.security.KeyStore.Builder newInstance(java.lang.String arg0, java.security.Provider arg1, java.security.KeyStore.ProtectionParameter arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyStore.Builder.staticClass, global::java.security.KeyStore.Builder._newInstance17349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.security.KeyStore.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _getKeyStore17350;
			public abstract global::java.security.KeyStore getKeyStore();
			internal static global::MonoJavaBridge.MethodId _getProtectionParameter17351;
			public abstract global::java.security.KeyStore.ProtectionParameter getProtectionParameter(java.lang.String arg0);
			internal static global::MonoJavaBridge.MethodId _Builder17352;
			protected Builder()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStore.Builder.staticClass, global::java.security.KeyStore.Builder._Builder17352);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.KeyStore.Builder.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStore$Builder"));
				global::java.security.KeyStore.Builder._newInstance17347 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyStore.Builder.staticClass, "newInstance", "(Ljava/security/KeyStore;Ljava/security/KeyStore$ProtectionParameter;)Ljava/security/KeyStore$Builder;");
				global::java.security.KeyStore.Builder._newInstance17348 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyStore.Builder.staticClass, "newInstance", "(Ljava/lang/String;Ljava/security/Provider;Ljava/io/File;Ljava/security/KeyStore$ProtectionParameter;)Ljava/security/KeyStore$Builder;");
				global::java.security.KeyStore.Builder._newInstance17349 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyStore.Builder.staticClass, "newInstance", "(Ljava/lang/String;Ljava/security/Provider;Ljava/security/KeyStore$ProtectionParameter;)Ljava/security/KeyStore$Builder;");
				global::java.security.KeyStore.Builder._getKeyStore17350 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.Builder.staticClass, "getKeyStore", "()Ljava/security/KeyStore;");
				global::java.security.KeyStore.Builder._getProtectionParameter17351 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.Builder.staticClass, "getProtectionParameter", "(Ljava/lang/String;)Ljava/security/KeyStore$ProtectionParameter;");
				global::java.security.KeyStore.Builder._Builder17352 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.Builder.staticClass, "<init>", "()V");
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
			internal static global::MonoJavaBridge.MethodId _getKeyStore17353;
			public override global::java.security.KeyStore getKeyStore() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore.Builder_._getKeyStore17353)) as java.security.KeyStore;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.Builder_.staticClass, global::java.security.KeyStore.Builder_._getKeyStore17353)) as java.security.KeyStore;
			}
			internal static global::MonoJavaBridge.MethodId _getProtectionParameter17354;
			public override global::java.security.KeyStore.ProtectionParameter getProtectionParameter(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.KeyStore.ProtectionParameter>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore.Builder_._getProtectionParameter17354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.KeyStore.ProtectionParameter;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.KeyStore.ProtectionParameter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.Builder_.staticClass, global::java.security.KeyStore.Builder_._getProtectionParameter17354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.KeyStore.ProtectionParameter;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.KeyStore.Builder_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStore$Builder"));
				global::java.security.KeyStore.Builder_._getKeyStore17353 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.Builder_.staticClass, "getKeyStore", "()Ljava/security/KeyStore;");
				global::java.security.KeyStore.Builder_._getProtectionParameter17354 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.Builder_.staticClass, "getProtectionParameter", "(Ljava/lang/String;)Ljava/security/KeyStore$ProtectionParameter;");
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
			internal static global::MonoJavaBridge.MethodId _getCallbackHandler17355;
			public virtual global::javax.security.auth.callback.CallbackHandler getCallbackHandler() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.security.auth.callback.CallbackHandler>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore.CallbackHandlerProtection._getCallbackHandler17355)) as javax.security.auth.callback.CallbackHandler;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.security.auth.callback.CallbackHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.CallbackHandlerProtection.staticClass, global::java.security.KeyStore.CallbackHandlerProtection._getCallbackHandler17355)) as javax.security.auth.callback.CallbackHandler;
			}
			internal static global::MonoJavaBridge.MethodId _CallbackHandlerProtection17356;
			public CallbackHandlerProtection(javax.security.auth.callback.CallbackHandler arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStore.CallbackHandlerProtection.staticClass, global::java.security.KeyStore.CallbackHandlerProtection._CallbackHandlerProtection17356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.KeyStore.CallbackHandlerProtection.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStore$CallbackHandlerProtection"));
				global::java.security.KeyStore.CallbackHandlerProtection._getCallbackHandler17355 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.CallbackHandlerProtection.staticClass, "getCallbackHandler", "()Ljavax/security/auth/callback/CallbackHandler;");
				global::java.security.KeyStore.CallbackHandlerProtection._CallbackHandlerProtection17356 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.CallbackHandlerProtection.staticClass, "<init>", "(Ljavax/security/auth/callback/CallbackHandler;)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.KeyStore.Entry_))]
		public interface Entry  : global::MonoJavaBridge.IJavaObject 
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
		public interface LoadStoreParameter  : global::MonoJavaBridge.IJavaObject 
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
			internal static global::MonoJavaBridge.MethodId _getProtectionParameter17357;
			 global::java.security.KeyStore.ProtectionParameter java.security.KeyStore.LoadStoreParameter.getProtectionParameter() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.KeyStore.ProtectionParameter>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore.LoadStoreParameter_._getProtectionParameter17357)) as java.security.KeyStore.ProtectionParameter;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.KeyStore.ProtectionParameter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.LoadStoreParameter_.staticClass, global::java.security.KeyStore.LoadStoreParameter_._getProtectionParameter17357)) as java.security.KeyStore.ProtectionParameter;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.KeyStore.LoadStoreParameter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStore$LoadStoreParameter"));
				global::java.security.KeyStore.LoadStoreParameter_._getProtectionParameter17357 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.LoadStoreParameter_.staticClass, "getProtectionParameter", "()Ljava/security/KeyStore$ProtectionParameter;");
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
			internal static global::MonoJavaBridge.MethodId _destroy17358;
			public virtual void destroy() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStore.PasswordProtection._destroy17358);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyStore.PasswordProtection.staticClass, global::java.security.KeyStore.PasswordProtection._destroy17358);
			}
			internal static global::MonoJavaBridge.MethodId _isDestroyed17359;
			public virtual bool isDestroyed() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.KeyStore.PasswordProtection._isDestroyed17359);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.KeyStore.PasswordProtection.staticClass, global::java.security.KeyStore.PasswordProtection._isDestroyed17359);
			}
			public new char[] Password
			{
				get
				{
					return getPassword();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getPassword17360;
			public virtual char[] getPassword() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore.PasswordProtection._getPassword17360)) as char[];
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.PasswordProtection.staticClass, global::java.security.KeyStore.PasswordProtection._getPassword17360)) as char[];
			}
			internal static global::MonoJavaBridge.MethodId _PasswordProtection17361;
			public PasswordProtection(char[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStore.PasswordProtection.staticClass, global::java.security.KeyStore.PasswordProtection._PasswordProtection17361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.KeyStore.PasswordProtection.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStore$PasswordProtection"));
				global::java.security.KeyStore.PasswordProtection._destroy17358 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.PasswordProtection.staticClass, "destroy", "()V");
				global::java.security.KeyStore.PasswordProtection._isDestroyed17359 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.PasswordProtection.staticClass, "isDestroyed", "()Z");
				global::java.security.KeyStore.PasswordProtection._getPassword17360 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.PasswordProtection.staticClass, "getPassword", "()[C");
				global::java.security.KeyStore.PasswordProtection._PasswordProtection17361 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.PasswordProtection.staticClass, "<init>", "([C)V");
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
			internal static global::MonoJavaBridge.MethodId _toString17362;
			public sealed override global::java.lang.String toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore.PrivateKeyEntry._toString17362)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.PrivateKeyEntry.staticClass, global::java.security.KeyStore.PrivateKeyEntry._toString17362)) as java.lang.String;
			}
			public new global::java.security.cert.Certificate[] CertificateChain
			{
				get
				{
					return getCertificateChain();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getCertificateChain17363;
			public global::java.security.cert.Certificate[] getCertificateChain() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore.PrivateKeyEntry._getCertificateChain17363)) as java.security.cert.Certificate[];
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.PrivateKeyEntry.staticClass, global::java.security.KeyStore.PrivateKeyEntry._getCertificateChain17363)) as java.security.cert.Certificate[];
			}
			public new global::java.security.cert.Certificate Certificate
			{
				get
				{
					return getCertificate();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getCertificate17364;
			public global::java.security.cert.Certificate getCertificate() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore.PrivateKeyEntry._getCertificate17364)) as java.security.cert.Certificate;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.PrivateKeyEntry.staticClass, global::java.security.KeyStore.PrivateKeyEntry._getCertificate17364)) as java.security.cert.Certificate;
			}
			public new global::java.security.PrivateKey PrivateKey
			{
				get
				{
					return getPrivateKey();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getPrivateKey17365;
			public global::java.security.PrivateKey getPrivateKey() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PrivateKey>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore.PrivateKeyEntry._getPrivateKey17365)) as java.security.PrivateKey;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PrivateKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.PrivateKeyEntry.staticClass, global::java.security.KeyStore.PrivateKeyEntry._getPrivateKey17365)) as java.security.PrivateKey;
			}
			internal static global::MonoJavaBridge.MethodId _PrivateKeyEntry17366;
			public PrivateKeyEntry(java.security.PrivateKey arg0, java.security.cert.Certificate[] arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStore.PrivateKeyEntry.staticClass, global::java.security.KeyStore.PrivateKeyEntry._PrivateKeyEntry17366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.KeyStore.PrivateKeyEntry.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStore$PrivateKeyEntry"));
				global::java.security.KeyStore.PrivateKeyEntry._toString17362 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.PrivateKeyEntry.staticClass, "toString", "()Ljava/lang/String;");
				global::java.security.KeyStore.PrivateKeyEntry._getCertificateChain17363 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.PrivateKeyEntry.staticClass, "getCertificateChain", "()[Ljava/security/cert/Certificate;");
				global::java.security.KeyStore.PrivateKeyEntry._getCertificate17364 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.PrivateKeyEntry.staticClass, "getCertificate", "()Ljava/security/cert/Certificate;");
				global::java.security.KeyStore.PrivateKeyEntry._getPrivateKey17365 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.PrivateKeyEntry.staticClass, "getPrivateKey", "()Ljava/security/PrivateKey;");
				global::java.security.KeyStore.PrivateKeyEntry._PrivateKeyEntry17366 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.PrivateKeyEntry.staticClass, "<init>", "(Ljava/security/PrivateKey;[Ljava/security/cert/Certificate;)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.KeyStore.ProtectionParameter_))]
		public interface ProtectionParameter  : global::MonoJavaBridge.IJavaObject 
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
			internal static global::MonoJavaBridge.MethodId _toString17367;
			public sealed override global::java.lang.String toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore.SecretKeyEntry._toString17367)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.SecretKeyEntry.staticClass, global::java.security.KeyStore.SecretKeyEntry._toString17367)) as java.lang.String;
			}
			public new global::javax.crypto.SecretKey SecretKey
			{
				get
				{
					return getSecretKey();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSecretKey17368;
			public global::javax.crypto.SecretKey getSecretKey() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.crypto.SecretKey>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore.SecretKeyEntry._getSecretKey17368)) as javax.crypto.SecretKey;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.crypto.SecretKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.SecretKeyEntry.staticClass, global::java.security.KeyStore.SecretKeyEntry._getSecretKey17368)) as javax.crypto.SecretKey;
			}
			internal static global::MonoJavaBridge.MethodId _SecretKeyEntry17369;
			public SecretKeyEntry(javax.crypto.SecretKey arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStore.SecretKeyEntry.staticClass, global::java.security.KeyStore.SecretKeyEntry._SecretKeyEntry17369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.KeyStore.SecretKeyEntry.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStore$SecretKeyEntry"));
				global::java.security.KeyStore.SecretKeyEntry._toString17367 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.SecretKeyEntry.staticClass, "toString", "()Ljava/lang/String;");
				global::java.security.KeyStore.SecretKeyEntry._getSecretKey17368 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.SecretKeyEntry.staticClass, "getSecretKey", "()Ljavax/crypto/SecretKey;");
				global::java.security.KeyStore.SecretKeyEntry._SecretKeyEntry17369 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.SecretKeyEntry.staticClass, "<init>", "(Ljavax/crypto/SecretKey;)V");
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
			internal static global::MonoJavaBridge.MethodId _toString17370;
			public sealed override global::java.lang.String toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore.TrustedCertificateEntry._toString17370)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.TrustedCertificateEntry.staticClass, global::java.security.KeyStore.TrustedCertificateEntry._toString17370)) as java.lang.String;
			}
			public new global::java.security.cert.Certificate TrustedCertificate
			{
				get
				{
					return getTrustedCertificate();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getTrustedCertificate17371;
			public global::java.security.cert.Certificate getTrustedCertificate() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore.TrustedCertificateEntry._getTrustedCertificate17371)) as java.security.cert.Certificate;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.TrustedCertificateEntry.staticClass, global::java.security.KeyStore.TrustedCertificateEntry._getTrustedCertificate17371)) as java.security.cert.Certificate;
			}
			internal static global::MonoJavaBridge.MethodId _TrustedCertificateEntry17372;
			public TrustedCertificateEntry(java.security.cert.Certificate arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStore.TrustedCertificateEntry.staticClass, global::java.security.KeyStore.TrustedCertificateEntry._TrustedCertificateEntry17372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.KeyStore.TrustedCertificateEntry.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStore$TrustedCertificateEntry"));
				global::java.security.KeyStore.TrustedCertificateEntry._toString17370 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.TrustedCertificateEntry.staticClass, "toString", "()Ljava/lang/String;");
				global::java.security.KeyStore.TrustedCertificateEntry._getTrustedCertificate17371 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.TrustedCertificateEntry.staticClass, "getTrustedCertificate", "()Ljava/security/cert/Certificate;");
				global::java.security.KeyStore.TrustedCertificateEntry._TrustedCertificateEntry17372 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.TrustedCertificateEntry.staticClass, "<init>", "(Ljava/security/cert/Certificate;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _size17373;
		public virtual int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.KeyStore._size17373);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._size17373);
		}
		internal static global::MonoJavaBridge.MethodId _getKey17374;
		public virtual global::java.security.Key getKey(java.lang.String arg0, char[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Key>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore._getKey17374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.Key;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Key>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._getKey17374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.Key;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance17375;
		public static global::java.security.KeyStore getInstance(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyStore.staticClass, global::java.security.KeyStore._getInstance17375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.KeyStore;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance17376;
		public static global::java.security.KeyStore getInstance(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyStore.staticClass, global::java.security.KeyStore._getInstance17376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.KeyStore;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance17377;
		public static global::java.security.KeyStore getInstance(java.lang.String arg0, java.security.Provider arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyStore.staticClass, global::java.security.KeyStore._getInstance17377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.KeyStore;
		}
		internal static global::MonoJavaBridge.MethodId _load17378;
		public virtual void load(java.io.InputStream arg0, char[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStore._load17378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._load17378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _load17379;
		public virtual void load(java.security.KeyStore.LoadStoreParameter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStore._load17379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._load17379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _store17380;
		public virtual void store(java.io.OutputStream arg0, char[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStore._store17380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._store17380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _store17381;
		public virtual void store(java.security.KeyStore.LoadStoreParameter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStore._store17381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._store17381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Type
		{
			get
			{
				return getType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getType17382;
		public virtual global::java.lang.String getType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore._getType17382)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._getType17382)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEntry17383;
		public virtual global::java.security.KeyStore.Entry getEntry(java.lang.String arg0, java.security.KeyStore.ProtectionParameter arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.KeyStore.Entry>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore._getEntry17383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.KeyStore.Entry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.KeyStore.Entry>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._getEntry17383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.KeyStore.Entry;
		}
		internal static global::MonoJavaBridge.MethodId _aliases17384;
		public virtual global::java.util.Enumeration aliases() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore._aliases17384)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._aliases17384)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _setEntry17385;
		public virtual void setEntry(java.lang.String arg0, java.security.KeyStore.Entry arg1, java.security.KeyStore.ProtectionParameter arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStore._setEntry17385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._setEntry17385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getCertificateChain17386;
		public virtual global::java.security.cert.Certificate[] getCertificateChain(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore._getCertificateChain17386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.Certificate[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._getCertificateChain17386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.Certificate[];
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProvider17387;
		public virtual global::java.security.Provider getProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore._getProvider17387)) as java.security.Provider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._getProvider17387)) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _getCertificate17388;
		public virtual global::java.security.cert.Certificate getCertificate(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore._getCertificate17388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.Certificate;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._getCertificate17388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.Certificate;
		}
		public static global::java.lang.String DefaultType
		{
			get
			{
				return getDefaultType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultType17389;
		public static global::java.lang.String getDefaultType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyStore.staticClass, global::java.security.KeyStore._getDefaultType17389)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getCreationDate17390;
		public virtual global::java.util.Date getCreationDate(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore._getCreationDate17390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._getCreationDate17390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _setKeyEntry17391;
		public virtual void setKeyEntry(java.lang.String arg0, byte[] arg1, java.security.cert.Certificate[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStore._setKeyEntry17391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._setKeyEntry17391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setKeyEntry17392;
		public virtual void setKeyEntry(java.lang.String arg0, java.security.Key arg1, char[] arg2, java.security.cert.Certificate[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStore._setKeyEntry17392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._setKeyEntry17392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setCertificateEntry17393;
		public virtual void setCertificateEntry(java.lang.String arg0, java.security.cert.Certificate arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStore._setCertificateEntry17393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._setCertificateEntry17393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _deleteEntry17394;
		public virtual void deleteEntry(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyStore._deleteEntry17394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._deleteEntry17394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAlias17395;
		public virtual bool containsAlias(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.KeyStore._containsAlias17395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._containsAlias17395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isKeyEntry17396;
		public virtual bool isKeyEntry(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.KeyStore._isKeyEntry17396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._isKeyEntry17396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCertificateEntry17397;
		public virtual bool isCertificateEntry(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.KeyStore._isCertificateEntry17397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._isCertificateEntry17397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCertificateAlias17398;
		public virtual global::java.lang.String getCertificateAlias(java.security.cert.Certificate arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyStore._getCertificateAlias17398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._getCertificateAlias17398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _entryInstanceOf17399;
		public virtual bool entryInstanceOf(java.lang.String arg0, java.lang.Class arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.KeyStore._entryInstanceOf17399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._entryInstanceOf17399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _KeyStore17400;
		protected KeyStore(java.security.KeyStoreSpi arg0, java.security.Provider arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStore.staticClass, global::java.security.KeyStore._KeyStore17400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyStore.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStore"));
			global::java.security.KeyStore._size17373 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "size", "()I");
			global::java.security.KeyStore._getKey17374 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getKey", "(Ljava/lang/String;[C)Ljava/security/Key;");
			global::java.security.KeyStore._getInstance17375 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/security/KeyStore;");
			global::java.security.KeyStore._getInstance17376 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/KeyStore;");
			global::java.security.KeyStore._getInstance17377 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/KeyStore;");
			global::java.security.KeyStore._load17378 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "load", "(Ljava/io/InputStream;[C)V");
			global::java.security.KeyStore._load17379 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "load", "(Ljava/security/KeyStore$LoadStoreParameter;)V");
			global::java.security.KeyStore._store17380 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "store", "(Ljava/io/OutputStream;[C)V");
			global::java.security.KeyStore._store17381 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "store", "(Ljava/security/KeyStore$LoadStoreParameter;)V");
			global::java.security.KeyStore._getType17382 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getType", "()Ljava/lang/String;");
			global::java.security.KeyStore._getEntry17383 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getEntry", "(Ljava/lang/String;Ljava/security/KeyStore$ProtectionParameter;)Ljava/security/KeyStore$Entry;");
			global::java.security.KeyStore._aliases17384 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "aliases", "()Ljava/util/Enumeration;");
			global::java.security.KeyStore._setEntry17385 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "setEntry", "(Ljava/lang/String;Ljava/security/KeyStore$Entry;Ljava/security/KeyStore$ProtectionParameter;)V");
			global::java.security.KeyStore._getCertificateChain17386 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getCertificateChain", "(Ljava/lang/String;)[Ljava/security/cert/Certificate;");
			global::java.security.KeyStore._getProvider17387 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::java.security.KeyStore._getCertificate17388 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getCertificate", "(Ljava/lang/String;)Ljava/security/cert/Certificate;");
			global::java.security.KeyStore._getDefaultType17389 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getDefaultType", "()Ljava/lang/String;");
			global::java.security.KeyStore._getCreationDate17390 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getCreationDate", "(Ljava/lang/String;)Ljava/util/Date;");
			global::java.security.KeyStore._setKeyEntry17391 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "setKeyEntry", "(Ljava/lang/String;[B[Ljava/security/cert/Certificate;)V");
			global::java.security.KeyStore._setKeyEntry17392 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "setKeyEntry", "(Ljava/lang/String;Ljava/security/Key;[C[Ljava/security/cert/Certificate;)V");
			global::java.security.KeyStore._setCertificateEntry17393 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "setCertificateEntry", "(Ljava/lang/String;Ljava/security/cert/Certificate;)V");
			global::java.security.KeyStore._deleteEntry17394 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "deleteEntry", "(Ljava/lang/String;)V");
			global::java.security.KeyStore._containsAlias17395 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "containsAlias", "(Ljava/lang/String;)Z");
			global::java.security.KeyStore._isKeyEntry17396 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "isKeyEntry", "(Ljava/lang/String;)Z");
			global::java.security.KeyStore._isCertificateEntry17397 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "isCertificateEntry", "(Ljava/lang/String;)Z");
			global::java.security.KeyStore._getCertificateAlias17398 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getCertificateAlias", "(Ljava/security/cert/Certificate;)Ljava/lang/String;");
			global::java.security.KeyStore._entryInstanceOf17399 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "entryInstanceOf", "(Ljava/lang/String;Ljava/lang/Class;)Z");
			global::java.security.KeyStore._KeyStore17400 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "<init>", "(Ljava/security/KeyStoreSpi;Ljava/security/Provider;Ljava/lang/String;)V");
		}
	}
}
