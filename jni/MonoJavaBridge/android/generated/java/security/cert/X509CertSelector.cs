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
		internal static global::MonoJavaBridge.MethodId _toString23784;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._toString23784)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._toString23784)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clone23785;
		public virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._clone23785)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._clone23785)) as java.lang.Object;
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
		internal static global::MonoJavaBridge.MethodId _getBasicConstraints23786;
		public virtual int getBasicConstraints()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getBasicConstraints23786);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getBasicConstraints23786);
		}
		internal static global::MonoJavaBridge.MethodId _match23787;
		public virtual bool match(java.security.cert.Certificate arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._match23787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._match23787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getCertificate23788;
		public virtual global::java.security.cert.X509Certificate getCertificate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getCertificate23788)) as java.security.cert.X509Certificate;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getCertificate23788)) as java.security.cert.X509Certificate;
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
		internal static global::MonoJavaBridge.MethodId _getSerialNumber23789;
		public virtual global::java.math.BigInteger getSerialNumber()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getSerialNumber23789)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getSerialNumber23789)) as java.math.BigInteger;
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
		internal static global::MonoJavaBridge.MethodId _getKeyUsage23790;
		public virtual bool[] getKeyUsage()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getKeyUsage23790)) as bool[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getKeyUsage23790)) as bool[];
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
		internal static global::MonoJavaBridge.MethodId _getExtendedKeyUsage23791;
		public virtual global::java.util.Set getExtendedKeyUsage()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getExtendedKeyUsage23791)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getExtendedKeyUsage23791)) as java.util.Set;
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
		internal static global::MonoJavaBridge.MethodId _getSubjectAlternativeNames23792;
		public virtual global::java.util.Collection getSubjectAlternativeNames()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getSubjectAlternativeNames23792)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getSubjectAlternativeNames23792)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _setSerialNumber23793;
		public virtual void setSerialNumber(java.math.BigInteger arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setSerialNumber23793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setSerialNumber23793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIssuer23794;
		public virtual void setIssuer(javax.security.auth.x500.X500Principal arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setIssuer23794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setIssuer23794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIssuer23795;
		public virtual void setIssuer(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setIssuer23795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setIssuer23795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIssuer23796;
		public virtual void setIssuer(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setIssuer23796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setIssuer23796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSubject23797;
		public virtual void setSubject(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setSubject23797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setSubject23797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSubject23798;
		public virtual void setSubject(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setSubject23798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setSubject23798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSubject23799;
		public virtual void setSubject(javax.security.auth.x500.X500Principal arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setSubject23799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setSubject23799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getPolicy23800;
		public virtual global::java.util.Set getPolicy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getPolicy23800)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getPolicy23800)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _setPolicy23801;
		public virtual void setPolicy(java.util.Set arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setPolicy23801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setPolicy23801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSubject23802;
		public virtual global::javax.security.auth.x500.X500Principal getSubject()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.security.auth.x500.X500Principal>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getSubject23802)) as javax.security.auth.x500.X500Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.security.auth.x500.X500Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getSubject23802)) as javax.security.auth.x500.X500Principal;
		}
		internal static global::MonoJavaBridge.MethodId _setCertificate23803;
		public virtual void setCertificate(java.security.cert.X509Certificate arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setCertificate23803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setCertificate23803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNameConstraints23804;
		public virtual void setNameConstraints(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setNameConstraints23804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setNameConstraints23804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getNameConstraints23805;
		public virtual byte[] getNameConstraints()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getNameConstraints23805)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getNameConstraints23805)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _setSubjectKeyIdentifier23806;
		public virtual void setSubjectKeyIdentifier(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setSubjectKeyIdentifier23806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setSubjectKeyIdentifier23806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAuthorityKeyIdentifier23807;
		public virtual void setAuthorityKeyIdentifier(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setAuthorityKeyIdentifier23807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setAuthorityKeyIdentifier23807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCertificateValid23808;
		public virtual void setCertificateValid(java.util.Date arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setCertificateValid23808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setCertificateValid23808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPrivateKeyValid23809;
		public virtual void setPrivateKeyValid(java.util.Date arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setPrivateKeyValid23809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setPrivateKeyValid23809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSubjectPublicKeyAlgID23810;
		public virtual void setSubjectPublicKeyAlgID(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setSubjectPublicKeyAlgID23810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setSubjectPublicKeyAlgID23810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSubjectPublicKey23811;
		public virtual void setSubjectPublicKey(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setSubjectPublicKey23811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setSubjectPublicKey23811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSubjectPublicKey23812;
		public virtual void setSubjectPublicKey(java.security.PublicKey arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setSubjectPublicKey23812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setSubjectPublicKey23812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setKeyUsage23813;
		public virtual void setKeyUsage(bool[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setKeyUsage23813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setKeyUsage23813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setExtendedKeyUsage23814;
		public virtual void setExtendedKeyUsage(java.util.Set arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setExtendedKeyUsage23814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setExtendedKeyUsage23814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMatchAllSubjectAltNames23815;
		public virtual void setMatchAllSubjectAltNames(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setMatchAllSubjectAltNames23815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setMatchAllSubjectAltNames23815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSubjectAlternativeNames23816;
		public virtual void setSubjectAlternativeNames(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setSubjectAlternativeNames23816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setSubjectAlternativeNames23816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addSubjectAlternativeName23817;
		public virtual void addSubjectAlternativeName(int arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._addSubjectAlternativeName23817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._addSubjectAlternativeName23817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addSubjectAlternativeName23818;
		public virtual void addSubjectAlternativeName(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._addSubjectAlternativeName23818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._addSubjectAlternativeName23818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBasicConstraints23819;
		public virtual void setBasicConstraints(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setBasicConstraints23819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setBasicConstraints23819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPathToNames23820;
		public virtual void setPathToNames(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setPathToNames23820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setPathToNames23820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addPathToName23821;
		public virtual void addPathToName(int arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._addPathToName23821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._addPathToName23821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addPathToName23822;
		public virtual void addPathToName(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._addPathToName23822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._addPathToName23822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		internal static global::MonoJavaBridge.MethodId _getIssuer23823;
		public virtual global::javax.security.auth.x500.X500Principal getIssuer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.security.auth.x500.X500Principal>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getIssuer23823)) as javax.security.auth.x500.X500Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.security.auth.x500.X500Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getIssuer23823)) as javax.security.auth.x500.X500Principal;
		}
		public new global::java.lang.String IssuerAsString
		{
			get
			{
				return getIssuerAsString();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIssuerAsString23824;
		public virtual global::java.lang.String getIssuerAsString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getIssuerAsString23824)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getIssuerAsString23824)) as java.lang.String;
		}
		public new byte[] IssuerAsBytes
		{
			get
			{
				return getIssuerAsBytes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIssuerAsBytes23825;
		public virtual byte[] getIssuerAsBytes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getIssuerAsBytes23825)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getIssuerAsBytes23825)) as byte[];
		}
		public new global::java.lang.String SubjectAsString
		{
			get
			{
				return getSubjectAsString();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSubjectAsString23826;
		public virtual global::java.lang.String getSubjectAsString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getSubjectAsString23826)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getSubjectAsString23826)) as java.lang.String;
		}
		public new byte[] SubjectAsBytes
		{
			get
			{
				return getSubjectAsBytes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSubjectAsBytes23827;
		public virtual byte[] getSubjectAsBytes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getSubjectAsBytes23827)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getSubjectAsBytes23827)) as byte[];
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
		internal static global::MonoJavaBridge.MethodId _getSubjectKeyIdentifier23828;
		public virtual byte[] getSubjectKeyIdentifier()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getSubjectKeyIdentifier23828)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getSubjectKeyIdentifier23828)) as byte[];
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
		internal static global::MonoJavaBridge.MethodId _getAuthorityKeyIdentifier23829;
		public virtual byte[] getAuthorityKeyIdentifier()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getAuthorityKeyIdentifier23829)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getAuthorityKeyIdentifier23829)) as byte[];
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
		internal static global::MonoJavaBridge.MethodId _getCertificateValid23830;
		public virtual global::java.util.Date getCertificateValid()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getCertificateValid23830)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getCertificateValid23830)) as java.util.Date;
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
		internal static global::MonoJavaBridge.MethodId _getPrivateKeyValid23831;
		public virtual global::java.util.Date getPrivateKeyValid()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getPrivateKeyValid23831)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getPrivateKeyValid23831)) as java.util.Date;
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
		internal static global::MonoJavaBridge.MethodId _getSubjectPublicKeyAlgID23832;
		public virtual global::java.lang.String getSubjectPublicKeyAlgID()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getSubjectPublicKeyAlgID23832)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getSubjectPublicKeyAlgID23832)) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getSubjectPublicKey23833;
		public virtual global::java.security.PublicKey getSubjectPublicKey()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getSubjectPublicKey23833)) as java.security.PublicKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getSubjectPublicKey23833)) as java.security.PublicKey;
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
		internal static global::MonoJavaBridge.MethodId _getMatchAllSubjectAltNames23834;
		public virtual bool getMatchAllSubjectAltNames()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getMatchAllSubjectAltNames23834);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getMatchAllSubjectAltNames23834);
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
		internal static global::MonoJavaBridge.MethodId _getPathToNames23835;
		public virtual global::java.util.Collection getPathToNames()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getPathToNames23835)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getPathToNames23835)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _X509CertSelector23836;
		public X509CertSelector() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._X509CertSelector23836);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509CertSelector.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509CertSelector"));
			global::java.security.cert.X509CertSelector._toString23784 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.X509CertSelector._clone23785 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.security.cert.X509CertSelector._getBasicConstraints23786 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getBasicConstraints", "()I");
			global::java.security.cert.X509CertSelector._match23787 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "match", "(Ljava/security/cert/Certificate;)Z");
			global::java.security.cert.X509CertSelector._getCertificate23788 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getCertificate", "()Ljava/security/cert/X509Certificate;");
			global::java.security.cert.X509CertSelector._getSerialNumber23789 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getSerialNumber", "()Ljava/math/BigInteger;");
			global::java.security.cert.X509CertSelector._getKeyUsage23790 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getKeyUsage", "()[Z");
			global::java.security.cert.X509CertSelector._getExtendedKeyUsage23791 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getExtendedKeyUsage", "()Ljava/util/Set;");
			global::java.security.cert.X509CertSelector._getSubjectAlternativeNames23792 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getSubjectAlternativeNames", "()Ljava/util/Collection;");
			global::java.security.cert.X509CertSelector._setSerialNumber23793 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setSerialNumber", "(Ljava/math/BigInteger;)V");
			global::java.security.cert.X509CertSelector._setIssuer23794 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setIssuer", "(Ljavax/security/auth/x500/X500Principal;)V");
			global::java.security.cert.X509CertSelector._setIssuer23795 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setIssuer", "([B)V");
			global::java.security.cert.X509CertSelector._setIssuer23796 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setIssuer", "(Ljava/lang/String;)V");
			global::java.security.cert.X509CertSelector._setSubject23797 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setSubject", "([B)V");
			global::java.security.cert.X509CertSelector._setSubject23798 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setSubject", "(Ljava/lang/String;)V");
			global::java.security.cert.X509CertSelector._setSubject23799 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setSubject", "(Ljavax/security/auth/x500/X500Principal;)V");
			global::java.security.cert.X509CertSelector._getPolicy23800 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getPolicy", "()Ljava/util/Set;");
			global::java.security.cert.X509CertSelector._setPolicy23801 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setPolicy", "(Ljava/util/Set;)V");
			global::java.security.cert.X509CertSelector._getSubject23802 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getSubject", "()Ljavax/security/auth/x500/X500Principal;");
			global::java.security.cert.X509CertSelector._setCertificate23803 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setCertificate", "(Ljava/security/cert/X509Certificate;)V");
			global::java.security.cert.X509CertSelector._setNameConstraints23804 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setNameConstraints", "([B)V");
			global::java.security.cert.X509CertSelector._getNameConstraints23805 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getNameConstraints", "()[B");
			global::java.security.cert.X509CertSelector._setSubjectKeyIdentifier23806 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setSubjectKeyIdentifier", "([B)V");
			global::java.security.cert.X509CertSelector._setAuthorityKeyIdentifier23807 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setAuthorityKeyIdentifier", "([B)V");
			global::java.security.cert.X509CertSelector._setCertificateValid23808 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setCertificateValid", "(Ljava/util/Date;)V");
			global::java.security.cert.X509CertSelector._setPrivateKeyValid23809 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setPrivateKeyValid", "(Ljava/util/Date;)V");
			global::java.security.cert.X509CertSelector._setSubjectPublicKeyAlgID23810 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setSubjectPublicKeyAlgID", "(Ljava/lang/String;)V");
			global::java.security.cert.X509CertSelector._setSubjectPublicKey23811 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setSubjectPublicKey", "([B)V");
			global::java.security.cert.X509CertSelector._setSubjectPublicKey23812 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setSubjectPublicKey", "(Ljava/security/PublicKey;)V");
			global::java.security.cert.X509CertSelector._setKeyUsage23813 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setKeyUsage", "([Z)V");
			global::java.security.cert.X509CertSelector._setExtendedKeyUsage23814 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setExtendedKeyUsage", "(Ljava/util/Set;)V");
			global::java.security.cert.X509CertSelector._setMatchAllSubjectAltNames23815 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setMatchAllSubjectAltNames", "(Z)V");
			global::java.security.cert.X509CertSelector._setSubjectAlternativeNames23816 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setSubjectAlternativeNames", "(Ljava/util/Collection;)V");
			global::java.security.cert.X509CertSelector._addSubjectAlternativeName23817 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "addSubjectAlternativeName", "(I[B)V");
			global::java.security.cert.X509CertSelector._addSubjectAlternativeName23818 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "addSubjectAlternativeName", "(ILjava/lang/String;)V");
			global::java.security.cert.X509CertSelector._setBasicConstraints23819 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setBasicConstraints", "(I)V");
			global::java.security.cert.X509CertSelector._setPathToNames23820 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setPathToNames", "(Ljava/util/Collection;)V");
			global::java.security.cert.X509CertSelector._addPathToName23821 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "addPathToName", "(I[B)V");
			global::java.security.cert.X509CertSelector._addPathToName23822 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "addPathToName", "(ILjava/lang/String;)V");
			global::java.security.cert.X509CertSelector._getIssuer23823 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getIssuer", "()Ljavax/security/auth/x500/X500Principal;");
			global::java.security.cert.X509CertSelector._getIssuerAsString23824 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getIssuerAsString", "()Ljava/lang/String;");
			global::java.security.cert.X509CertSelector._getIssuerAsBytes23825 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getIssuerAsBytes", "()[B");
			global::java.security.cert.X509CertSelector._getSubjectAsString23826 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getSubjectAsString", "()Ljava/lang/String;");
			global::java.security.cert.X509CertSelector._getSubjectAsBytes23827 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getSubjectAsBytes", "()[B");
			global::java.security.cert.X509CertSelector._getSubjectKeyIdentifier23828 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getSubjectKeyIdentifier", "()[B");
			global::java.security.cert.X509CertSelector._getAuthorityKeyIdentifier23829 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getAuthorityKeyIdentifier", "()[B");
			global::java.security.cert.X509CertSelector._getCertificateValid23830 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getCertificateValid", "()Ljava/util/Date;");
			global::java.security.cert.X509CertSelector._getPrivateKeyValid23831 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getPrivateKeyValid", "()Ljava/util/Date;");
			global::java.security.cert.X509CertSelector._getSubjectPublicKeyAlgID23832 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getSubjectPublicKeyAlgID", "()Ljava/lang/String;");
			global::java.security.cert.X509CertSelector._getSubjectPublicKey23833 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getSubjectPublicKey", "()Ljava/security/PublicKey;");
			global::java.security.cert.X509CertSelector._getMatchAllSubjectAltNames23834 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getMatchAllSubjectAltNames", "()Z");
			global::java.security.cert.X509CertSelector._getPathToNames23835 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getPathToNames", "()Ljava/util/Collection;");
			global::java.security.cert.X509CertSelector._X509CertSelector23836 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "<init>", "()V");
		}
	}
}
