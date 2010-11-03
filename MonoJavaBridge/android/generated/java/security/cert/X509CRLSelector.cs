namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class X509CRLSelector : java.lang.Object, CRLSelector
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected X509CRLSelector(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.X509CRLSelector.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.cert.X509CRLSelector._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.X509CRLSelector.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.security.cert.X509CRLSelector._m1) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual bool match(java.security.cert.CRL arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.cert.X509CRLSelector.staticClass, "match", "(Ljava/security/cert/CRL;)Z", ref global::java.security.cert.X509CRLSelector._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setIssuers(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CRLSelector.staticClass, "setIssuers", "(Ljava/util/Collection;)V", ref global::java.security.cert.X509CRLSelector._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setIssuerNames(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CRLSelector.staticClass, "setIssuerNames", "(Ljava/util/Collection;)V", ref global::java.security.cert.X509CRLSelector._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void addIssuer(javax.security.auth.x500.X500Principal arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CRLSelector.staticClass, "addIssuer", "(Ljavax/security/auth/x500/X500Principal;)V", ref global::java.security.cert.X509CRLSelector._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void addIssuerName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CRLSelector.staticClass, "addIssuerName", "(Ljava/lang/String;)V", ref global::java.security.cert.X509CRLSelector._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void addIssuerName(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CRLSelector.staticClass, "addIssuerName", "([B)V", ref global::java.security.cert.X509CRLSelector._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.math.BigInteger MinCRLNumber
		{
			set
			{
				setMinCRLNumber(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setMinCRLNumber(java.math.BigInteger arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CRLSelector.staticClass, "setMinCRLNumber", "(Ljava/math/BigInteger;)V", ref global::java.security.cert.X509CRLSelector._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.math.BigInteger MaxCRLNumber
		{
			set
			{
				setMaxCRLNumber(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setMaxCRLNumber(java.math.BigInteger arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CRLSelector.staticClass, "setMaxCRLNumber", "(Ljava/math/BigInteger;)V", ref global::java.security.cert.X509CRLSelector._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setDateAndTime(java.util.Date arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CRLSelector.staticClass, "setDateAndTime", "(Ljava/util/Date;)V", ref global::java.security.cert.X509CRLSelector._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setCertificateChecking(java.security.cert.X509Certificate arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CRLSelector.staticClass, "setCertificateChecking", "(Ljava/security/cert/X509Certificate;)V", ref global::java.security.cert.X509CRLSelector._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.Collection Issuers
		{
			get
			{
				return getIssuers();
			}
			set
			{
				setIssuers(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::java.util.Collection getIssuers()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.security.cert.X509CRLSelector.staticClass, "getIssuers", "()Ljava/util/Collection;", ref global::java.security.cert.X509CRLSelector._m12) as java.util.Collection;
		}
		public new global::java.util.Collection IssuerNames
		{
			get
			{
				return getIssuerNames();
			}
			set
			{
				setIssuerNames(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::java.util.Collection getIssuerNames()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.security.cert.X509CRLSelector.staticClass, "getIssuerNames", "()Ljava/util/Collection;", ref global::java.security.cert.X509CRLSelector._m13) as java.util.Collection;
		}
		public new global::java.math.BigInteger MinCRL
		{
			get
			{
				return getMinCRL();
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::java.math.BigInteger getMinCRL()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.X509CRLSelector.staticClass, "getMinCRL", "()Ljava/math/BigInteger;", ref global::java.security.cert.X509CRLSelector._m14) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger MaxCRL
		{
			get
			{
				return getMaxCRL();
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual global::java.math.BigInteger getMaxCRL()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.X509CRLSelector.staticClass, "getMaxCRL", "()Ljava/math/BigInteger;", ref global::java.security.cert.X509CRLSelector._m15) as java.math.BigInteger;
		}
		public new global::java.util.Date DateAndTime
		{
			get
			{
				return getDateAndTime();
			}
			set
			{
				setDateAndTime(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual global::java.util.Date getDateAndTime()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.X509CRLSelector.staticClass, "getDateAndTime", "()Ljava/util/Date;", ref global::java.security.cert.X509CRLSelector._m16) as java.util.Date;
		}
		public new global::java.security.cert.X509Certificate CertificateChecking
		{
			get
			{
				return getCertificateChecking();
			}
			set
			{
				setCertificateChecking(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual global::java.security.cert.X509Certificate getCertificateChecking()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.X509CRLSelector.staticClass, "getCertificateChecking", "()Ljava/security/cert/X509Certificate;", ref global::java.security.cert.X509CRLSelector._m17) as java.security.cert.X509Certificate;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public X509CRLSelector() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.X509CRLSelector._m18.native == global::System.IntPtr.Zero)
				global::java.security.cert.X509CRLSelector._m18 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._m18);
			Init(@__env, handle);
		}
		static X509CRLSelector()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509CRLSelector.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509CRLSelector"));
		}
	}
}
