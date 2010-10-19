namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class X509CertSelector : java.lang.Object, CertSelector
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static X509CertSelector()
		{
			InitJNI();
		}
		protected X509CertSelector(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString18065;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._toString18065)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._toString18065)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clone18066;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._clone18066)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._clone18066)) as java.lang.Object;
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
		internal static global::MonoJavaBridge.MethodId _getBasicConstraints18067;
		public virtual int getBasicConstraints() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getBasicConstraints18067);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getBasicConstraints18067);
		}
		internal static global::MonoJavaBridge.MethodId _match18068;
		public virtual bool match(java.security.cert.Certificate arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._match18068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._match18068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getCertificate18069;
		public virtual global::java.security.cert.X509Certificate getCertificate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getCertificate18069)) as java.security.cert.X509Certificate;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getCertificate18069)) as java.security.cert.X509Certificate;
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
		internal static global::MonoJavaBridge.MethodId _getSerialNumber18070;
		public virtual global::java.math.BigInteger getSerialNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getSerialNumber18070)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getSerialNumber18070)) as java.math.BigInteger;
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
		internal static global::MonoJavaBridge.MethodId _getKeyUsage18071;
		public virtual bool[] getKeyUsage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getKeyUsage18071)) as bool[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getKeyUsage18071)) as bool[];
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
		internal static global::MonoJavaBridge.MethodId _getExtendedKeyUsage18072;
		public virtual global::java.util.Set getExtendedKeyUsage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getExtendedKeyUsage18072)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getExtendedKeyUsage18072)) as java.util.Set;
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
		internal static global::MonoJavaBridge.MethodId _getSubjectAlternativeNames18073;
		public virtual global::java.util.Collection getSubjectAlternativeNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getSubjectAlternativeNames18073)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getSubjectAlternativeNames18073)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _setSerialNumber18074;
		public virtual void setSerialNumber(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setSerialNumber18074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setSerialNumber18074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIssuer18075;
		public virtual void setIssuer(javax.security.auth.x500.X500Principal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setIssuer18075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setIssuer18075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIssuer18076;
		public virtual void setIssuer(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setIssuer18076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setIssuer18076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIssuer18077;
		public virtual void setIssuer(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setIssuer18077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setIssuer18077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSubject18078;
		public virtual void setSubject(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setSubject18078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setSubject18078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSubject18079;
		public virtual void setSubject(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setSubject18079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setSubject18079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSubject18080;
		public virtual void setSubject(javax.security.auth.x500.X500Principal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setSubject18080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setSubject18080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getPolicy18081;
		public virtual global::java.util.Set getPolicy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getPolicy18081)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getPolicy18081)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _setPolicy18082;
		public virtual void setPolicy(java.util.Set arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setPolicy18082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setPolicy18082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSubject18083;
		public virtual global::javax.security.auth.x500.X500Principal getSubject() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getSubject18083)) as javax.security.auth.x500.X500Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getSubject18083)) as javax.security.auth.x500.X500Principal;
		}
		internal static global::MonoJavaBridge.MethodId _setCertificate18084;
		public virtual void setCertificate(java.security.cert.X509Certificate arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setCertificate18084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setCertificate18084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNameConstraints18085;
		public virtual void setNameConstraints(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setNameConstraints18085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setNameConstraints18085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getNameConstraints18086;
		public virtual byte[] getNameConstraints() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getNameConstraints18086)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getNameConstraints18086)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _setSubjectKeyIdentifier18087;
		public virtual void setSubjectKeyIdentifier(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setSubjectKeyIdentifier18087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setSubjectKeyIdentifier18087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAuthorityKeyIdentifier18088;
		public virtual void setAuthorityKeyIdentifier(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setAuthorityKeyIdentifier18088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setAuthorityKeyIdentifier18088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCertificateValid18089;
		public virtual void setCertificateValid(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setCertificateValid18089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setCertificateValid18089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPrivateKeyValid18090;
		public virtual void setPrivateKeyValid(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setPrivateKeyValid18090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setPrivateKeyValid18090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSubjectPublicKeyAlgID18091;
		public virtual void setSubjectPublicKeyAlgID(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setSubjectPublicKeyAlgID18091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setSubjectPublicKeyAlgID18091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSubjectPublicKey18092;
		public virtual void setSubjectPublicKey(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setSubjectPublicKey18092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setSubjectPublicKey18092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSubjectPublicKey18093;
		public virtual void setSubjectPublicKey(java.security.PublicKey arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setSubjectPublicKey18093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setSubjectPublicKey18093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setKeyUsage18094;
		public virtual void setKeyUsage(bool[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setKeyUsage18094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setKeyUsage18094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setExtendedKeyUsage18095;
		public virtual void setExtendedKeyUsage(java.util.Set arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setExtendedKeyUsage18095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setExtendedKeyUsage18095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMatchAllSubjectAltNames18096;
		public virtual void setMatchAllSubjectAltNames(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setMatchAllSubjectAltNames18096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setMatchAllSubjectAltNames18096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSubjectAlternativeNames18097;
		public virtual void setSubjectAlternativeNames(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setSubjectAlternativeNames18097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setSubjectAlternativeNames18097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addSubjectAlternativeName18098;
		public virtual void addSubjectAlternativeName(int arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._addSubjectAlternativeName18098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._addSubjectAlternativeName18098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addSubjectAlternativeName18099;
		public virtual void addSubjectAlternativeName(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._addSubjectAlternativeName18099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._addSubjectAlternativeName18099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBasicConstraints18100;
		public virtual void setBasicConstraints(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setBasicConstraints18100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setBasicConstraints18100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPathToNames18101;
		public virtual void setPathToNames(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setPathToNames18101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setPathToNames18101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addPathToName18102;
		public virtual void addPathToName(int arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._addPathToName18102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._addPathToName18102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addPathToName18103;
		public virtual void addPathToName(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._addPathToName18103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._addPathToName18103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		internal static global::MonoJavaBridge.MethodId _getIssuer18104;
		public virtual global::javax.security.auth.x500.X500Principal getIssuer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getIssuer18104)) as javax.security.auth.x500.X500Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getIssuer18104)) as javax.security.auth.x500.X500Principal;
		}
		public new global::java.lang.String IssuerAsString
		{
			get
			{
				return getIssuerAsString();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIssuerAsString18105;
		public virtual global::java.lang.String getIssuerAsString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getIssuerAsString18105)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getIssuerAsString18105)) as java.lang.String;
		}
		public new byte[] IssuerAsBytes
		{
			get
			{
				return getIssuerAsBytes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIssuerAsBytes18106;
		public virtual byte[] getIssuerAsBytes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getIssuerAsBytes18106)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getIssuerAsBytes18106)) as byte[];
		}
		public new global::java.lang.String SubjectAsString
		{
			get
			{
				return getSubjectAsString();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSubjectAsString18107;
		public virtual global::java.lang.String getSubjectAsString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getSubjectAsString18107)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getSubjectAsString18107)) as java.lang.String;
		}
		public new byte[] SubjectAsBytes
		{
			get
			{
				return getSubjectAsBytes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSubjectAsBytes18108;
		public virtual byte[] getSubjectAsBytes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getSubjectAsBytes18108)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getSubjectAsBytes18108)) as byte[];
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
		internal static global::MonoJavaBridge.MethodId _getSubjectKeyIdentifier18109;
		public virtual byte[] getSubjectKeyIdentifier() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getSubjectKeyIdentifier18109)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getSubjectKeyIdentifier18109)) as byte[];
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
		internal static global::MonoJavaBridge.MethodId _getAuthorityKeyIdentifier18110;
		public virtual byte[] getAuthorityKeyIdentifier() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getAuthorityKeyIdentifier18110)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getAuthorityKeyIdentifier18110)) as byte[];
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
		internal static global::MonoJavaBridge.MethodId _getCertificateValid18111;
		public virtual global::java.util.Date getCertificateValid() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getCertificateValid18111)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getCertificateValid18111)) as java.util.Date;
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
		internal static global::MonoJavaBridge.MethodId _getPrivateKeyValid18112;
		public virtual global::java.util.Date getPrivateKeyValid() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getPrivateKeyValid18112)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getPrivateKeyValid18112)) as java.util.Date;
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
		internal static global::MonoJavaBridge.MethodId _getSubjectPublicKeyAlgID18113;
		public virtual global::java.lang.String getSubjectPublicKeyAlgID() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getSubjectPublicKeyAlgID18113)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getSubjectPublicKeyAlgID18113)) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getSubjectPublicKey18114;
		public virtual global::java.security.PublicKey getSubjectPublicKey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getSubjectPublicKey18114)) as java.security.PublicKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getSubjectPublicKey18114)) as java.security.PublicKey;
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
		internal static global::MonoJavaBridge.MethodId _getMatchAllSubjectAltNames18115;
		public virtual bool getMatchAllSubjectAltNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getMatchAllSubjectAltNames18115);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getMatchAllSubjectAltNames18115);
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
		internal static global::MonoJavaBridge.MethodId _getPathToNames18116;
		public virtual global::java.util.Collection getPathToNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getPathToNames18116)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getPathToNames18116)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _X509CertSelector18117;
		public X509CertSelector()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._X509CertSelector18117);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509CertSelector.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509CertSelector"));
			global::java.security.cert.X509CertSelector._toString18065 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.X509CertSelector._clone18066 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.security.cert.X509CertSelector._getBasicConstraints18067 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getBasicConstraints", "()I");
			global::java.security.cert.X509CertSelector._match18068 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "match", "(Ljava/security/cert/Certificate;)Z");
			global::java.security.cert.X509CertSelector._getCertificate18069 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getCertificate", "()Ljava/security/cert/X509Certificate;");
			global::java.security.cert.X509CertSelector._getSerialNumber18070 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getSerialNumber", "()Ljava/math/BigInteger;");
			global::java.security.cert.X509CertSelector._getKeyUsage18071 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getKeyUsage", "()[Z");
			global::java.security.cert.X509CertSelector._getExtendedKeyUsage18072 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getExtendedKeyUsage", "()Ljava/util/Set;");
			global::java.security.cert.X509CertSelector._getSubjectAlternativeNames18073 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getSubjectAlternativeNames", "()Ljava/util/Collection;");
			global::java.security.cert.X509CertSelector._setSerialNumber18074 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setSerialNumber", "(Ljava/math/BigInteger;)V");
			global::java.security.cert.X509CertSelector._setIssuer18075 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setIssuer", "(Ljavax/security/auth/x500/X500Principal;)V");
			global::java.security.cert.X509CertSelector._setIssuer18076 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setIssuer", "([B)V");
			global::java.security.cert.X509CertSelector._setIssuer18077 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setIssuer", "(Ljava/lang/String;)V");
			global::java.security.cert.X509CertSelector._setSubject18078 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setSubject", "([B)V");
			global::java.security.cert.X509CertSelector._setSubject18079 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setSubject", "(Ljava/lang/String;)V");
			global::java.security.cert.X509CertSelector._setSubject18080 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setSubject", "(Ljavax/security/auth/x500/X500Principal;)V");
			global::java.security.cert.X509CertSelector._getPolicy18081 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getPolicy", "()Ljava/util/Set;");
			global::java.security.cert.X509CertSelector._setPolicy18082 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setPolicy", "(Ljava/util/Set;)V");
			global::java.security.cert.X509CertSelector._getSubject18083 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getSubject", "()Ljavax/security/auth/x500/X500Principal;");
			global::java.security.cert.X509CertSelector._setCertificate18084 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setCertificate", "(Ljava/security/cert/X509Certificate;)V");
			global::java.security.cert.X509CertSelector._setNameConstraints18085 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setNameConstraints", "([B)V");
			global::java.security.cert.X509CertSelector._getNameConstraints18086 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getNameConstraints", "()[B");
			global::java.security.cert.X509CertSelector._setSubjectKeyIdentifier18087 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setSubjectKeyIdentifier", "([B)V");
			global::java.security.cert.X509CertSelector._setAuthorityKeyIdentifier18088 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setAuthorityKeyIdentifier", "([B)V");
			global::java.security.cert.X509CertSelector._setCertificateValid18089 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setCertificateValid", "(Ljava/util/Date;)V");
			global::java.security.cert.X509CertSelector._setPrivateKeyValid18090 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setPrivateKeyValid", "(Ljava/util/Date;)V");
			global::java.security.cert.X509CertSelector._setSubjectPublicKeyAlgID18091 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setSubjectPublicKeyAlgID", "(Ljava/lang/String;)V");
			global::java.security.cert.X509CertSelector._setSubjectPublicKey18092 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setSubjectPublicKey", "([B)V");
			global::java.security.cert.X509CertSelector._setSubjectPublicKey18093 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setSubjectPublicKey", "(Ljava/security/PublicKey;)V");
			global::java.security.cert.X509CertSelector._setKeyUsage18094 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setKeyUsage", "([Z)V");
			global::java.security.cert.X509CertSelector._setExtendedKeyUsage18095 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setExtendedKeyUsage", "(Ljava/util/Set;)V");
			global::java.security.cert.X509CertSelector._setMatchAllSubjectAltNames18096 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setMatchAllSubjectAltNames", "(Z)V");
			global::java.security.cert.X509CertSelector._setSubjectAlternativeNames18097 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setSubjectAlternativeNames", "(Ljava/util/Collection;)V");
			global::java.security.cert.X509CertSelector._addSubjectAlternativeName18098 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "addSubjectAlternativeName", "(I[B)V");
			global::java.security.cert.X509CertSelector._addSubjectAlternativeName18099 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "addSubjectAlternativeName", "(ILjava/lang/String;)V");
			global::java.security.cert.X509CertSelector._setBasicConstraints18100 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setBasicConstraints", "(I)V");
			global::java.security.cert.X509CertSelector._setPathToNames18101 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setPathToNames", "(Ljava/util/Collection;)V");
			global::java.security.cert.X509CertSelector._addPathToName18102 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "addPathToName", "(I[B)V");
			global::java.security.cert.X509CertSelector._addPathToName18103 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "addPathToName", "(ILjava/lang/String;)V");
			global::java.security.cert.X509CertSelector._getIssuer18104 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getIssuer", "()Ljavax/security/auth/x500/X500Principal;");
			global::java.security.cert.X509CertSelector._getIssuerAsString18105 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getIssuerAsString", "()Ljava/lang/String;");
			global::java.security.cert.X509CertSelector._getIssuerAsBytes18106 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getIssuerAsBytes", "()[B");
			global::java.security.cert.X509CertSelector._getSubjectAsString18107 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getSubjectAsString", "()Ljava/lang/String;");
			global::java.security.cert.X509CertSelector._getSubjectAsBytes18108 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getSubjectAsBytes", "()[B");
			global::java.security.cert.X509CertSelector._getSubjectKeyIdentifier18109 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getSubjectKeyIdentifier", "()[B");
			global::java.security.cert.X509CertSelector._getAuthorityKeyIdentifier18110 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getAuthorityKeyIdentifier", "()[B");
			global::java.security.cert.X509CertSelector._getCertificateValid18111 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getCertificateValid", "()Ljava/util/Date;");
			global::java.security.cert.X509CertSelector._getPrivateKeyValid18112 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getPrivateKeyValid", "()Ljava/util/Date;");
			global::java.security.cert.X509CertSelector._getSubjectPublicKeyAlgID18113 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getSubjectPublicKeyAlgID", "()Ljava/lang/String;");
			global::java.security.cert.X509CertSelector._getSubjectPublicKey18114 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getSubjectPublicKey", "()Ljava/security/PublicKey;");
			global::java.security.cert.X509CertSelector._getMatchAllSubjectAltNames18115 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getMatchAllSubjectAltNames", "()Z");
			global::java.security.cert.X509CertSelector._getPathToNames18116 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getPathToNames", "()Ljava/util/Collection;");
			global::java.security.cert.X509CertSelector._X509CertSelector18117 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "<init>", "()V");
		}
	}
}
