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
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::java.security.KeyStore.Builder newInstance(java.security.KeyStore arg0, java.security.KeyStore.ProtectionParameter arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.security.KeyStore.Builder._m0.native == global::System.IntPtr.Zero)
					global::java.security.KeyStore.Builder._m0 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyStore.Builder.staticClass, "newInstance", "(Ljava/security/KeyStore;Ljava/security/KeyStore$ProtectionParameter;)Ljava/security/KeyStore$Builder;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyStore.Builder.staticClass, global::java.security.KeyStore.Builder._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.KeyStore.Builder;
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::java.security.KeyStore.Builder newInstance(java.lang.String arg0, java.security.Provider arg1, java.io.File arg2, java.security.KeyStore.ProtectionParameter arg3)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.security.KeyStore.Builder._m1.native == global::System.IntPtr.Zero)
					global::java.security.KeyStore.Builder._m1 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyStore.Builder.staticClass, "newInstance", "(Ljava/lang/String;Ljava/security/Provider;Ljava/io/File;Ljava/security/KeyStore$ProtectionParameter;)Ljava/security/KeyStore$Builder;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyStore.Builder.staticClass, global::java.security.KeyStore.Builder._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.security.KeyStore.Builder;
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public static global::java.security.KeyStore.Builder newInstance(java.lang.String arg0, java.security.Provider arg1, java.security.KeyStore.ProtectionParameter arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.security.KeyStore.Builder._m2.native == global::System.IntPtr.Zero)
					global::java.security.KeyStore.Builder._m2 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyStore.Builder.staticClass, "newInstance", "(Ljava/lang/String;Ljava/security/Provider;Ljava/security/KeyStore$ProtectionParameter;)Ljava/security/KeyStore$Builder;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyStore.Builder.staticClass, global::java.security.KeyStore.Builder._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.security.KeyStore.Builder;
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public abstract global::java.security.KeyStore getKeyStore();
			private static global::MonoJavaBridge.MethodId _m4;
			public abstract global::java.security.KeyStore.ProtectionParameter getProtectionParameter(java.lang.String arg0);
			private static global::MonoJavaBridge.MethodId _m5;
			protected Builder() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.security.KeyStore.Builder._m5.native == global::System.IntPtr.Zero)
					global::java.security.KeyStore.Builder._m5 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.Builder.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStore.Builder.staticClass, global::java.security.KeyStore.Builder._m5);
				Init(@__env, handle);
			}
			static Builder()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.KeyStore.Builder.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStore$Builder"));
			}
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.KeyStore.Builder))]
		internal sealed partial class Builder_ : java.security.KeyStore.Builder
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Builder_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public override global::java.security.KeyStore getKeyStore()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.KeyStore.Builder_.staticClass, "getKeyStore", "()Ljava/security/KeyStore;", ref global::java.security.KeyStore.Builder_._m0) as java.security.KeyStore;
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public override global::java.security.KeyStore.ProtectionParameter getProtectionParameter(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.KeyStore.ProtectionParameter>(this, global::java.security.KeyStore.Builder_.staticClass, "getProtectionParameter", "(Ljava/lang/String;)Ljava/security/KeyStore$ProtectionParameter;", ref global::java.security.KeyStore.Builder_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.KeyStore.ProtectionParameter;
			}
			static Builder_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.KeyStore.Builder_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStore$Builder"));
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
			private static global::MonoJavaBridge.MethodId _m0;
			global::java.security.KeyStore.ProtectionParameter java.security.KeyStore.LoadStoreParameter.getProtectionParameter()
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.KeyStore.ProtectionParameter>(this, global::java.security.KeyStore.LoadStoreParameter_.staticClass, "getProtectionParameter", "()Ljava/security/KeyStore$ProtectionParameter;", ref global::java.security.KeyStore.LoadStoreParameter_._m0) as java.security.KeyStore.ProtectionParameter;
			}
			static LoadStoreParameter_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.KeyStore.LoadStoreParameter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStore$LoadStoreParameter"));
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
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.KeyStore.staticClass, "size", "()I", ref global::java.security.KeyStore._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.security.Key getKey(java.lang.String arg0, char[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Key>(this, global::java.security.KeyStore.staticClass, "getKey", "(Ljava/lang/String;[C)Ljava/security/Key;", ref global::java.security.KeyStore._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.security.Key;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.security.KeyStore getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStore._m2.native == global::System.IntPtr.Zero)
				global::java.security.KeyStore._m2 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/security/KeyStore;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyStore.staticClass, global::java.security.KeyStore._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.KeyStore;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::java.security.KeyStore getInstance(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStore._m3.native == global::System.IntPtr.Zero)
				global::java.security.KeyStore._m3 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/KeyStore;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyStore.staticClass, global::java.security.KeyStore._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.KeyStore;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static global::java.security.KeyStore getInstance(java.lang.String arg0, java.security.Provider arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStore._m4.native == global::System.IntPtr.Zero)
				global::java.security.KeyStore._m4 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/KeyStore;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyStore.staticClass, global::java.security.KeyStore._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.KeyStore;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void load(java.io.InputStream arg0, char[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.KeyStore.staticClass, "load", "(Ljava/io/InputStream;[C)V", ref global::java.security.KeyStore._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void load(java.security.KeyStore.LoadStoreParameter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.KeyStore.staticClass, "load", "(Ljava/security/KeyStore$LoadStoreParameter;)V", ref global::java.security.KeyStore._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void store(java.io.OutputStream arg0, char[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.KeyStore.staticClass, "store", "(Ljava/io/OutputStream;[C)V", ref global::java.security.KeyStore._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void store(java.security.KeyStore.LoadStoreParameter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.KeyStore.staticClass, "store", "(Ljava/security/KeyStore$LoadStoreParameter;)V", ref global::java.security.KeyStore._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Type
		{
			get
			{
				return getType();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::java.lang.String getType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.KeyStore.staticClass, "getType", "()Ljava/lang/String;", ref global::java.security.KeyStore._m9) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::java.security.KeyStore.Entry getEntry(java.lang.String arg0, java.security.KeyStore.ProtectionParameter arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.KeyStore.Entry>(this, global::java.security.KeyStore.staticClass, "getEntry", "(Ljava/lang/String;Ljava/security/KeyStore$ProtectionParameter;)Ljava/security/KeyStore$Entry;", ref global::java.security.KeyStore._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.security.KeyStore.Entry;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::java.util.Enumeration aliases()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.security.KeyStore.staticClass, "aliases", "()Ljava/util/Enumeration;", ref global::java.security.KeyStore._m11) as java.util.Enumeration;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setEntry(java.lang.String arg0, java.security.KeyStore.Entry arg1, java.security.KeyStore.ProtectionParameter arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.KeyStore.staticClass, "setEntry", "(Ljava/lang/String;Ljava/security/KeyStore$Entry;Ljava/security/KeyStore$ProtectionParameter;)V", ref global::java.security.KeyStore._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::java.security.cert.Certificate[] getCertificateChain(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.security.cert.Certificate>(this, global::java.security.KeyStore.staticClass, "getCertificateChain", "(Ljava/lang/String;)[Ljava/security/cert/Certificate;", ref global::java.security.KeyStore._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.cert.Certificate[];
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::java.security.Provider getProvider()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.KeyStore.staticClass, "getProvider", "()Ljava/security/Provider;", ref global::java.security.KeyStore._m14) as java.security.Provider;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual global::java.security.cert.Certificate getCertificate(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.KeyStore.staticClass, "getCertificate", "(Ljava/lang/String;)Ljava/security/cert/Certificate;", ref global::java.security.KeyStore._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.cert.Certificate;
		}
		public static global::java.lang.String DefaultType
		{
			get
			{
				return getDefaultType();
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public static global::java.lang.String getDefaultType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStore._m16.native == global::System.IntPtr.Zero)
				global::java.security.KeyStore._m16 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyStore.staticClass, "getDefaultType", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.security.KeyStore.staticClass, global::java.security.KeyStore._m16)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual global::java.util.Date getCreationDate(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.KeyStore.staticClass, "getCreationDate", "(Ljava/lang/String;)Ljava/util/Date;", ref global::java.security.KeyStore._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Date;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void setKeyEntry(java.lang.String arg0, byte[] arg1, java.security.cert.Certificate[] arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.KeyStore.staticClass, "setKeyEntry", "(Ljava/lang/String;[B[Ljava/security/cert/Certificate;)V", ref global::java.security.KeyStore._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void setKeyEntry(java.lang.String arg0, java.security.Key arg1, char[] arg2, java.security.cert.Certificate[] arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.KeyStore.staticClass, "setKeyEntry", "(Ljava/lang/String;Ljava/security/Key;[C[Ljava/security/cert/Certificate;)V", ref global::java.security.KeyStore._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void setCertificateEntry(java.lang.String arg0, java.security.cert.Certificate arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.KeyStore.staticClass, "setCertificateEntry", "(Ljava/lang/String;Ljava/security/cert/Certificate;)V", ref global::java.security.KeyStore._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void deleteEntry(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.KeyStore.staticClass, "deleteEntry", "(Ljava/lang/String;)V", ref global::java.security.KeyStore._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual bool containsAlias(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.KeyStore.staticClass, "containsAlias", "(Ljava/lang/String;)Z", ref global::java.security.KeyStore._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual bool isKeyEntry(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.KeyStore.staticClass, "isKeyEntry", "(Ljava/lang/String;)Z", ref global::java.security.KeyStore._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual bool isCertificateEntry(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.KeyStore.staticClass, "isCertificateEntry", "(Ljava/lang/String;)Z", ref global::java.security.KeyStore._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual global::java.lang.String getCertificateAlias(java.security.cert.Certificate arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.KeyStore.staticClass, "getCertificateAlias", "(Ljava/security/cert/Certificate;)Ljava/lang/String;", ref global::java.security.KeyStore._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual bool entryInstanceOf(java.lang.String arg0, java.lang.Class arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.KeyStore.staticClass, "entryInstanceOf", "(Ljava/lang/String;Ljava/lang/Class;)Z", ref global::java.security.KeyStore._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		protected KeyStore(java.security.KeyStoreSpi arg0, java.security.Provider arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStore._m27.native == global::System.IntPtr.Zero)
				global::java.security.KeyStore._m27 = @__env.GetMethodIDNoThrow(global::java.security.KeyStore.staticClass, "<init>", "(Ljava/security/KeyStoreSpi;Ljava/security/Provider;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStore.staticClass, global::java.security.KeyStore._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static KeyStore()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyStore.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStore"));
		}
	}
}
