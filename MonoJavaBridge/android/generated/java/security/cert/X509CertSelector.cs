namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class X509CertSelector : java.lang.Object, CertSelector
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected X509CertSelector(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.X509CertSelector.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.cert.X509CertSelector._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.X509CertSelector.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.security.cert.X509CertSelector._m1) as java.lang.Object;
		}
		public new int BasicConstraints
		{
			get
			{
				return getBasicConstraints();
			}
			set
			{
				setBasicConstraints(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getBasicConstraints()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.cert.X509CertSelector.staticClass, "getBasicConstraints", "()I", ref global::java.security.cert.X509CertSelector._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual bool match(java.security.cert.Certificate arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.cert.X509CertSelector.staticClass, "match", "(Ljava/security/cert/Certificate;)Z", ref global::java.security.cert.X509CertSelector._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.security.cert.X509Certificate Certificate
		{
			get
			{
				return getCertificate();
			}
			set
			{
				setCertificate(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.security.cert.X509Certificate getCertificate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.X509CertSelector.staticClass, "getCertificate", "()Ljava/security/cert/X509Certificate;", ref global::java.security.cert.X509CertSelector._m4) as java.security.cert.X509Certificate;
		}
		public new global::java.math.BigInteger SerialNumber
		{
			get
			{
				return getSerialNumber();
			}
			set
			{
				setSerialNumber(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.math.BigInteger getSerialNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.X509CertSelector.staticClass, "getSerialNumber", "()Ljava/math/BigInteger;", ref global::java.security.cert.X509CertSelector._m5) as java.math.BigInteger;
		}
		public new bool[] KeyUsage
		{
			get
			{
				return getKeyUsage();
			}
			set
			{
				setKeyUsage(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual bool[] getKeyUsage()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<bool>(this, global::java.security.cert.X509CertSelector.staticClass, "getKeyUsage", "()[Z", ref global::java.security.cert.X509CertSelector._m6) as bool[];
		}
		public new global::java.util.Set ExtendedKeyUsage
		{
			get
			{
				return getExtendedKeyUsage();
			}
			set
			{
				setExtendedKeyUsage(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.util.Set getExtendedKeyUsage()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.security.cert.X509CertSelector.staticClass, "getExtendedKeyUsage", "()Ljava/util/Set;", ref global::java.security.cert.X509CertSelector._m7) as java.util.Set;
		}
		public new global::java.util.Collection SubjectAlternativeNames
		{
			get
			{
				return getSubjectAlternativeNames();
			}
			set
			{
				setSubjectAlternativeNames(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.util.Collection getSubjectAlternativeNames()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.security.cert.X509CertSelector.staticClass, "getSubjectAlternativeNames", "()Ljava/util/Collection;", ref global::java.security.cert.X509CertSelector._m8) as java.util.Collection;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setSerialNumber(java.math.BigInteger arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CertSelector.staticClass, "setSerialNumber", "(Ljava/math/BigInteger;)V", ref global::java.security.cert.X509CertSelector._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setIssuer(javax.security.auth.x500.X500Principal arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CertSelector.staticClass, "setIssuer", "(Ljavax/security/auth/x500/X500Principal;)V", ref global::java.security.cert.X509CertSelector._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setIssuer(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CertSelector.staticClass, "setIssuer", "([B)V", ref global::java.security.cert.X509CertSelector._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setIssuer(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CertSelector.staticClass, "setIssuer", "(Ljava/lang/String;)V", ref global::java.security.cert.X509CertSelector._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void setSubject(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CertSelector.staticClass, "setSubject", "([B)V", ref global::java.security.cert.X509CertSelector._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setSubject(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CertSelector.staticClass, "setSubject", "(Ljava/lang/String;)V", ref global::java.security.cert.X509CertSelector._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setSubject(javax.security.auth.x500.X500Principal arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CertSelector.staticClass, "setSubject", "(Ljavax/security/auth/x500/X500Principal;)V", ref global::java.security.cert.X509CertSelector._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.Set Policy
		{
			get
			{
				return getPolicy();
			}
			set
			{
				setPolicy(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual global::java.util.Set getPolicy()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.security.cert.X509CertSelector.staticClass, "getPolicy", "()Ljava/util/Set;", ref global::java.security.cert.X509CertSelector._m16) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setPolicy(java.util.Set arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CertSelector.staticClass, "setPolicy", "(Ljava/util/Set;)V", ref global::java.security.cert.X509CertSelector._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::javax.security.auth.x500.X500Principal Subject
		{
			get
			{
				return getSubject();
			}
			set
			{
				setSubject(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual global::javax.security.auth.x500.X500Principal getSubject()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<javax.security.auth.x500.X500Principal>(this, global::java.security.cert.X509CertSelector.staticClass, "getSubject", "()Ljavax/security/auth/x500/X500Principal;", ref global::java.security.cert.X509CertSelector._m18) as javax.security.auth.x500.X500Principal;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void setCertificate(java.security.cert.X509Certificate arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CertSelector.staticClass, "setCertificate", "(Ljava/security/cert/X509Certificate;)V", ref global::java.security.cert.X509CertSelector._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void setNameConstraints(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CertSelector.staticClass, "setNameConstraints", "([B)V", ref global::java.security.cert.X509CertSelector._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new byte[] NameConstraints
		{
			get
			{
				return getNameConstraints();
			}
			set
			{
				setNameConstraints(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual byte[] getNameConstraints()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.cert.X509CertSelector.staticClass, "getNameConstraints", "()[B", ref global::java.security.cert.X509CertSelector._m21) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void setSubjectKeyIdentifier(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CertSelector.staticClass, "setSubjectKeyIdentifier", "([B)V", ref global::java.security.cert.X509CertSelector._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual void setAuthorityKeyIdentifier(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CertSelector.staticClass, "setAuthorityKeyIdentifier", "([B)V", ref global::java.security.cert.X509CertSelector._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual void setCertificateValid(java.util.Date arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CertSelector.staticClass, "setCertificateValid", "(Ljava/util/Date;)V", ref global::java.security.cert.X509CertSelector._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual void setPrivateKeyValid(java.util.Date arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CertSelector.staticClass, "setPrivateKeyValid", "(Ljava/util/Date;)V", ref global::java.security.cert.X509CertSelector._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual void setSubjectPublicKeyAlgID(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CertSelector.staticClass, "setSubjectPublicKeyAlgID", "(Ljava/lang/String;)V", ref global::java.security.cert.X509CertSelector._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual void setSubjectPublicKey(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CertSelector.staticClass, "setSubjectPublicKey", "([B)V", ref global::java.security.cert.X509CertSelector._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual void setSubjectPublicKey(java.security.PublicKey arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CertSelector.staticClass, "setSubjectPublicKey", "(Ljava/security/PublicKey;)V", ref global::java.security.cert.X509CertSelector._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual void setKeyUsage(bool[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CertSelector.staticClass, "setKeyUsage", "([Z)V", ref global::java.security.cert.X509CertSelector._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual void setExtendedKeyUsage(java.util.Set arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CertSelector.staticClass, "setExtendedKeyUsage", "(Ljava/util/Set;)V", ref global::java.security.cert.X509CertSelector._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual void setMatchAllSubjectAltNames(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CertSelector.staticClass, "setMatchAllSubjectAltNames", "(Z)V", ref global::java.security.cert.X509CertSelector._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual void setSubjectAlternativeNames(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CertSelector.staticClass, "setSubjectAlternativeNames", "(Ljava/util/Collection;)V", ref global::java.security.cert.X509CertSelector._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual void addSubjectAlternativeName(int arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CertSelector.staticClass, "addSubjectAlternativeName", "(I[B)V", ref global::java.security.cert.X509CertSelector._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual void addSubjectAlternativeName(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CertSelector.staticClass, "addSubjectAlternativeName", "(ILjava/lang/String;)V", ref global::java.security.cert.X509CertSelector._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual void setBasicConstraints(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CertSelector.staticClass, "setBasicConstraints", "(I)V", ref global::java.security.cert.X509CertSelector._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual void setPathToNames(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CertSelector.staticClass, "setPathToNames", "(Ljava/util/Collection;)V", ref global::java.security.cert.X509CertSelector._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual void addPathToName(int arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CertSelector.staticClass, "addPathToName", "(I[B)V", ref global::java.security.cert.X509CertSelector._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public virtual void addPathToName(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CertSelector.staticClass, "addPathToName", "(ILjava/lang/String;)V", ref global::java.security.cert.X509CertSelector._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::javax.security.auth.x500.X500Principal Issuer
		{
			get
			{
				return getIssuer();
			}
			set
			{
				setIssuer(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public virtual global::javax.security.auth.x500.X500Principal getIssuer()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<javax.security.auth.x500.X500Principal>(this, global::java.security.cert.X509CertSelector.staticClass, "getIssuer", "()Ljavax/security/auth/x500/X500Principal;", ref global::java.security.cert.X509CertSelector._m39) as javax.security.auth.x500.X500Principal;
		}
		public new global::java.lang.String IssuerAsString
		{
			get
			{
				return getIssuerAsString();
			}
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public virtual global::java.lang.String getIssuerAsString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.X509CertSelector.staticClass, "getIssuerAsString", "()Ljava/lang/String;", ref global::java.security.cert.X509CertSelector._m40) as java.lang.String;
		}
		public new byte[] IssuerAsBytes
		{
			get
			{
				return getIssuerAsBytes();
			}
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public virtual byte[] getIssuerAsBytes()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.cert.X509CertSelector.staticClass, "getIssuerAsBytes", "()[B", ref global::java.security.cert.X509CertSelector._m41) as byte[];
		}
		public new global::java.lang.String SubjectAsString
		{
			get
			{
				return getSubjectAsString();
			}
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public virtual global::java.lang.String getSubjectAsString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.X509CertSelector.staticClass, "getSubjectAsString", "()Ljava/lang/String;", ref global::java.security.cert.X509CertSelector._m42) as java.lang.String;
		}
		public new byte[] SubjectAsBytes
		{
			get
			{
				return getSubjectAsBytes();
			}
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public virtual byte[] getSubjectAsBytes()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.cert.X509CertSelector.staticClass, "getSubjectAsBytes", "()[B", ref global::java.security.cert.X509CertSelector._m43) as byte[];
		}
		public new byte[] SubjectKeyIdentifier
		{
			get
			{
				return getSubjectKeyIdentifier();
			}
			set
			{
				setSubjectKeyIdentifier(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public virtual byte[] getSubjectKeyIdentifier()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.cert.X509CertSelector.staticClass, "getSubjectKeyIdentifier", "()[B", ref global::java.security.cert.X509CertSelector._m44) as byte[];
		}
		public new byte[] AuthorityKeyIdentifier
		{
			get
			{
				return getAuthorityKeyIdentifier();
			}
			set
			{
				setAuthorityKeyIdentifier(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public virtual byte[] getAuthorityKeyIdentifier()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.cert.X509CertSelector.staticClass, "getAuthorityKeyIdentifier", "()[B", ref global::java.security.cert.X509CertSelector._m45) as byte[];
		}
		public new global::java.util.Date CertificateValid
		{
			get
			{
				return getCertificateValid();
			}
			set
			{
				setCertificateValid(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public virtual global::java.util.Date getCertificateValid()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.X509CertSelector.staticClass, "getCertificateValid", "()Ljava/util/Date;", ref global::java.security.cert.X509CertSelector._m46) as java.util.Date;
		}
		public new global::java.util.Date PrivateKeyValid
		{
			get
			{
				return getPrivateKeyValid();
			}
			set
			{
				setPrivateKeyValid(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public virtual global::java.util.Date getPrivateKeyValid()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.X509CertSelector.staticClass, "getPrivateKeyValid", "()Ljava/util/Date;", ref global::java.security.cert.X509CertSelector._m47) as java.util.Date;
		}
		public new global::java.lang.String SubjectPublicKeyAlgID
		{
			get
			{
				return getSubjectPublicKeyAlgID();
			}
			set
			{
				setSubjectPublicKeyAlgID(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public virtual global::java.lang.String getSubjectPublicKeyAlgID()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.X509CertSelector.staticClass, "getSubjectPublicKeyAlgID", "()Ljava/lang/String;", ref global::java.security.cert.X509CertSelector._m48) as java.lang.String;
		}
		public new global::java.security.PublicKey SubjectPublicKey
		{
			get
			{
				return getSubjectPublicKey();
			}
			set
			{
				setSubjectPublicKey(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public virtual global::java.security.PublicKey getSubjectPublicKey()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.PublicKey>(this, global::java.security.cert.X509CertSelector.staticClass, "getSubjectPublicKey", "()Ljava/security/PublicKey;", ref global::java.security.cert.X509CertSelector._m49) as java.security.PublicKey;
		}
		public new bool MatchAllSubjectAltNames
		{
			get
			{
				return getMatchAllSubjectAltNames();
			}
			set
			{
				setMatchAllSubjectAltNames(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m50;
		public virtual bool getMatchAllSubjectAltNames()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.cert.X509CertSelector.staticClass, "getMatchAllSubjectAltNames", "()Z", ref global::java.security.cert.X509CertSelector._m50);
		}
		public new global::java.util.Collection PathToNames
		{
			get
			{
				return getPathToNames();
			}
			set
			{
				setPathToNames(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m51;
		public virtual global::java.util.Collection getPathToNames()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.security.cert.X509CertSelector.staticClass, "getPathToNames", "()Ljava/util/Collection;", ref global::java.security.cert.X509CertSelector._m51) as java.util.Collection;
		}
		private static global::MonoJavaBridge.MethodId _m52;
		public X509CertSelector() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.X509CertSelector._m52.native == global::System.IntPtr.Zero)
				global::java.security.cert.X509CertSelector._m52 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._m52);
			Init(@__env, handle);
		}
		static X509CertSelector()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509CertSelector.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509CertSelector"));
		}
	}
}
