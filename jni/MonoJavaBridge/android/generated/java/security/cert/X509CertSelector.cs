namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class X509CertSelector : java.lang.Object, CertSelector
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected X509CertSelector(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString23785;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._toString23785)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._toString23785)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clone23786;
		public virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._clone23786)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._clone23786)) as java.lang.Object;
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
		internal static global::MonoJavaBridge.MethodId _getBasicConstraints23787;
		public virtual int getBasicConstraints()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getBasicConstraints23787);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getBasicConstraints23787);
		}
		internal static global::MonoJavaBridge.MethodId _match23788;
		public virtual bool match(java.security.cert.Certificate arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._match23788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._match23788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getCertificate23789;
		public virtual global::java.security.cert.X509Certificate getCertificate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getCertificate23789)) as java.security.cert.X509Certificate;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getCertificate23789)) as java.security.cert.X509Certificate;
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
		internal static global::MonoJavaBridge.MethodId _getSerialNumber23790;
		public virtual global::java.math.BigInteger getSerialNumber()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getSerialNumber23790)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getSerialNumber23790)) as java.math.BigInteger;
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
		internal static global::MonoJavaBridge.MethodId _getKeyUsage23791;
		public virtual bool[] getKeyUsage()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getKeyUsage23791)) as bool[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getKeyUsage23791)) as bool[];
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
		internal static global::MonoJavaBridge.MethodId _getExtendedKeyUsage23792;
		public virtual global::java.util.Set getExtendedKeyUsage()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getExtendedKeyUsage23792)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getExtendedKeyUsage23792)) as java.util.Set;
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
		internal static global::MonoJavaBridge.MethodId _getSubjectAlternativeNames23793;
		public virtual global::java.util.Collection getSubjectAlternativeNames()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getSubjectAlternativeNames23793)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getSubjectAlternativeNames23793)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _setSerialNumber23794;
		public virtual void setSerialNumber(java.math.BigInteger arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setSerialNumber23794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setSerialNumber23794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIssuer23795;
		public virtual void setIssuer(javax.security.auth.x500.X500Principal arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setIssuer23795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setIssuer23795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIssuer23796;
		public virtual void setIssuer(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setIssuer23796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setIssuer23796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIssuer23797;
		public virtual void setIssuer(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setIssuer23797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setIssuer23797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSubject23798;
		public virtual void setSubject(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setSubject23798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setSubject23798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSubject23799;
		public virtual void setSubject(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setSubject23799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setSubject23799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSubject23800;
		public virtual void setSubject(javax.security.auth.x500.X500Principal arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setSubject23800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setSubject23800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getPolicy23801;
		public virtual global::java.util.Set getPolicy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getPolicy23801)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getPolicy23801)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _setPolicy23802;
		public virtual void setPolicy(java.util.Set arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setPolicy23802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setPolicy23802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSubject23803;
		public virtual global::javax.security.auth.x500.X500Principal getSubject()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.security.auth.x500.X500Principal>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getSubject23803)) as javax.security.auth.x500.X500Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.security.auth.x500.X500Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getSubject23803)) as javax.security.auth.x500.X500Principal;
		}
		internal static global::MonoJavaBridge.MethodId _setCertificate23804;
		public virtual void setCertificate(java.security.cert.X509Certificate arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setCertificate23804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setCertificate23804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNameConstraints23805;
		public virtual void setNameConstraints(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setNameConstraints23805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setNameConstraints23805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getNameConstraints23806;
		public virtual byte[] getNameConstraints()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getNameConstraints23806)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getNameConstraints23806)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _setSubjectKeyIdentifier23807;
		public virtual void setSubjectKeyIdentifier(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setSubjectKeyIdentifier23807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setSubjectKeyIdentifier23807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAuthorityKeyIdentifier23808;
		public virtual void setAuthorityKeyIdentifier(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setAuthorityKeyIdentifier23808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setAuthorityKeyIdentifier23808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCertificateValid23809;
		public virtual void setCertificateValid(java.util.Date arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setCertificateValid23809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setCertificateValid23809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPrivateKeyValid23810;
		public virtual void setPrivateKeyValid(java.util.Date arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setPrivateKeyValid23810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setPrivateKeyValid23810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSubjectPublicKeyAlgID23811;
		public virtual void setSubjectPublicKeyAlgID(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setSubjectPublicKeyAlgID23811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setSubjectPublicKeyAlgID23811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSubjectPublicKey23812;
		public virtual void setSubjectPublicKey(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setSubjectPublicKey23812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setSubjectPublicKey23812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSubjectPublicKey23813;
		public virtual void setSubjectPublicKey(java.security.PublicKey arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setSubjectPublicKey23813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setSubjectPublicKey23813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setKeyUsage23814;
		public virtual void setKeyUsage(bool[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setKeyUsage23814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setKeyUsage23814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setExtendedKeyUsage23815;
		public virtual void setExtendedKeyUsage(java.util.Set arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setExtendedKeyUsage23815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setExtendedKeyUsage23815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMatchAllSubjectAltNames23816;
		public virtual void setMatchAllSubjectAltNames(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setMatchAllSubjectAltNames23816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setMatchAllSubjectAltNames23816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSubjectAlternativeNames23817;
		public virtual void setSubjectAlternativeNames(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setSubjectAlternativeNames23817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setSubjectAlternativeNames23817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addSubjectAlternativeName23818;
		public virtual void addSubjectAlternativeName(int arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._addSubjectAlternativeName23818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._addSubjectAlternativeName23818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addSubjectAlternativeName23819;
		public virtual void addSubjectAlternativeName(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._addSubjectAlternativeName23819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._addSubjectAlternativeName23819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBasicConstraints23820;
		public virtual void setBasicConstraints(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setBasicConstraints23820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setBasicConstraints23820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPathToNames23821;
		public virtual void setPathToNames(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._setPathToNames23821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._setPathToNames23821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addPathToName23822;
		public virtual void addPathToName(int arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._addPathToName23822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._addPathToName23822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addPathToName23823;
		public virtual void addPathToName(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._addPathToName23823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._addPathToName23823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		internal static global::MonoJavaBridge.MethodId _getIssuer23824;
		public virtual global::javax.security.auth.x500.X500Principal getIssuer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.security.auth.x500.X500Principal>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getIssuer23824)) as javax.security.auth.x500.X500Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.security.auth.x500.X500Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getIssuer23824)) as javax.security.auth.x500.X500Principal;
		}
		public new global::java.lang.String IssuerAsString
		{
			get
			{
				return getIssuerAsString();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIssuerAsString23825;
		public virtual global::java.lang.String getIssuerAsString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getIssuerAsString23825)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getIssuerAsString23825)) as java.lang.String;
		}
		public new byte[] IssuerAsBytes
		{
			get
			{
				return getIssuerAsBytes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIssuerAsBytes23826;
		public virtual byte[] getIssuerAsBytes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getIssuerAsBytes23826)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getIssuerAsBytes23826)) as byte[];
		}
		public new global::java.lang.String SubjectAsString
		{
			get
			{
				return getSubjectAsString();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSubjectAsString23827;
		public virtual global::java.lang.String getSubjectAsString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getSubjectAsString23827)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getSubjectAsString23827)) as java.lang.String;
		}
		public new byte[] SubjectAsBytes
		{
			get
			{
				return getSubjectAsBytes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSubjectAsBytes23828;
		public virtual byte[] getSubjectAsBytes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getSubjectAsBytes23828)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getSubjectAsBytes23828)) as byte[];
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
		internal static global::MonoJavaBridge.MethodId _getSubjectKeyIdentifier23829;
		public virtual byte[] getSubjectKeyIdentifier()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getSubjectKeyIdentifier23829)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getSubjectKeyIdentifier23829)) as byte[];
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
		internal static global::MonoJavaBridge.MethodId _getAuthorityKeyIdentifier23830;
		public virtual byte[] getAuthorityKeyIdentifier()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getAuthorityKeyIdentifier23830)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getAuthorityKeyIdentifier23830)) as byte[];
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
		internal static global::MonoJavaBridge.MethodId _getCertificateValid23831;
		public virtual global::java.util.Date getCertificateValid()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getCertificateValid23831)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getCertificateValid23831)) as java.util.Date;
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
		internal static global::MonoJavaBridge.MethodId _getPrivateKeyValid23832;
		public virtual global::java.util.Date getPrivateKeyValid()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getPrivateKeyValid23832)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getPrivateKeyValid23832)) as java.util.Date;
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
		internal static global::MonoJavaBridge.MethodId _getSubjectPublicKeyAlgID23833;
		public virtual global::java.lang.String getSubjectPublicKeyAlgID()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getSubjectPublicKeyAlgID23833)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getSubjectPublicKeyAlgID23833)) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getSubjectPublicKey23834;
		public virtual global::java.security.PublicKey getSubjectPublicKey()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getSubjectPublicKey23834)) as java.security.PublicKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getSubjectPublicKey23834)) as java.security.PublicKey;
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
		internal static global::MonoJavaBridge.MethodId _getMatchAllSubjectAltNames23835;
		public virtual bool getMatchAllSubjectAltNames()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getMatchAllSubjectAltNames23835);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getMatchAllSubjectAltNames23835);
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
		internal static global::MonoJavaBridge.MethodId _getPathToNames23836;
		public virtual global::java.util.Collection getPathToNames()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector._getPathToNames23836)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._getPathToNames23836)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _X509CertSelector23837;
		public X509CertSelector() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.X509CertSelector.staticClass, global::java.security.cert.X509CertSelector._X509CertSelector23837);
			Init(@__env, handle);
		}
		static X509CertSelector()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509CertSelector.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509CertSelector"));
			global::java.security.cert.X509CertSelector._toString23785 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.X509CertSelector._clone23786 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.security.cert.X509CertSelector._getBasicConstraints23787 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getBasicConstraints", "()I");
			global::java.security.cert.X509CertSelector._match23788 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "match", "(Ljava/security/cert/Certificate;)Z");
			global::java.security.cert.X509CertSelector._getCertificate23789 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getCertificate", "()Ljava/security/cert/X509Certificate;");
			global::java.security.cert.X509CertSelector._getSerialNumber23790 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getSerialNumber", "()Ljava/math/BigInteger;");
			global::java.security.cert.X509CertSelector._getKeyUsage23791 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getKeyUsage", "()[Z");
			global::java.security.cert.X509CertSelector._getExtendedKeyUsage23792 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getExtendedKeyUsage", "()Ljava/util/Set;");
			global::java.security.cert.X509CertSelector._getSubjectAlternativeNames23793 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getSubjectAlternativeNames", "()Ljava/util/Collection;");
			global::java.security.cert.X509CertSelector._setSerialNumber23794 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setSerialNumber", "(Ljava/math/BigInteger;)V");
			global::java.security.cert.X509CertSelector._setIssuer23795 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setIssuer", "(Ljavax/security/auth/x500/X500Principal;)V");
			global::java.security.cert.X509CertSelector._setIssuer23796 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setIssuer", "([B)V");
			global::java.security.cert.X509CertSelector._setIssuer23797 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setIssuer", "(Ljava/lang/String;)V");
			global::java.security.cert.X509CertSelector._setSubject23798 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setSubject", "([B)V");
			global::java.security.cert.X509CertSelector._setSubject23799 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setSubject", "(Ljava/lang/String;)V");
			global::java.security.cert.X509CertSelector._setSubject23800 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setSubject", "(Ljavax/security/auth/x500/X500Principal;)V");
			global::java.security.cert.X509CertSelector._getPolicy23801 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getPolicy", "()Ljava/util/Set;");
			global::java.security.cert.X509CertSelector._setPolicy23802 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setPolicy", "(Ljava/util/Set;)V");
			global::java.security.cert.X509CertSelector._getSubject23803 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getSubject", "()Ljavax/security/auth/x500/X500Principal;");
			global::java.security.cert.X509CertSelector._setCertificate23804 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setCertificate", "(Ljava/security/cert/X509Certificate;)V");
			global::java.security.cert.X509CertSelector._setNameConstraints23805 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setNameConstraints", "([B)V");
			global::java.security.cert.X509CertSelector._getNameConstraints23806 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getNameConstraints", "()[B");
			global::java.security.cert.X509CertSelector._setSubjectKeyIdentifier23807 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setSubjectKeyIdentifier", "([B)V");
			global::java.security.cert.X509CertSelector._setAuthorityKeyIdentifier23808 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setAuthorityKeyIdentifier", "([B)V");
			global::java.security.cert.X509CertSelector._setCertificateValid23809 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setCertificateValid", "(Ljava/util/Date;)V");
			global::java.security.cert.X509CertSelector._setPrivateKeyValid23810 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setPrivateKeyValid", "(Ljava/util/Date;)V");
			global::java.security.cert.X509CertSelector._setSubjectPublicKeyAlgID23811 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setSubjectPublicKeyAlgID", "(Ljava/lang/String;)V");
			global::java.security.cert.X509CertSelector._setSubjectPublicKey23812 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setSubjectPublicKey", "([B)V");
			global::java.security.cert.X509CertSelector._setSubjectPublicKey23813 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setSubjectPublicKey", "(Ljava/security/PublicKey;)V");
			global::java.security.cert.X509CertSelector._setKeyUsage23814 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setKeyUsage", "([Z)V");
			global::java.security.cert.X509CertSelector._setExtendedKeyUsage23815 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setExtendedKeyUsage", "(Ljava/util/Set;)V");
			global::java.security.cert.X509CertSelector._setMatchAllSubjectAltNames23816 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setMatchAllSubjectAltNames", "(Z)V");
			global::java.security.cert.X509CertSelector._setSubjectAlternativeNames23817 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setSubjectAlternativeNames", "(Ljava/util/Collection;)V");
			global::java.security.cert.X509CertSelector._addSubjectAlternativeName23818 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "addSubjectAlternativeName", "(I[B)V");
			global::java.security.cert.X509CertSelector._addSubjectAlternativeName23819 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "addSubjectAlternativeName", "(ILjava/lang/String;)V");
			global::java.security.cert.X509CertSelector._setBasicConstraints23820 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setBasicConstraints", "(I)V");
			global::java.security.cert.X509CertSelector._setPathToNames23821 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "setPathToNames", "(Ljava/util/Collection;)V");
			global::java.security.cert.X509CertSelector._addPathToName23822 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "addPathToName", "(I[B)V");
			global::java.security.cert.X509CertSelector._addPathToName23823 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "addPathToName", "(ILjava/lang/String;)V");
			global::java.security.cert.X509CertSelector._getIssuer23824 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getIssuer", "()Ljavax/security/auth/x500/X500Principal;");
			global::java.security.cert.X509CertSelector._getIssuerAsString23825 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getIssuerAsString", "()Ljava/lang/String;");
			global::java.security.cert.X509CertSelector._getIssuerAsBytes23826 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getIssuerAsBytes", "()[B");
			global::java.security.cert.X509CertSelector._getSubjectAsString23827 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getSubjectAsString", "()Ljava/lang/String;");
			global::java.security.cert.X509CertSelector._getSubjectAsBytes23828 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getSubjectAsBytes", "()[B");
			global::java.security.cert.X509CertSelector._getSubjectKeyIdentifier23829 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getSubjectKeyIdentifier", "()[B");
			global::java.security.cert.X509CertSelector._getAuthorityKeyIdentifier23830 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getAuthorityKeyIdentifier", "()[B");
			global::java.security.cert.X509CertSelector._getCertificateValid23831 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getCertificateValid", "()Ljava/util/Date;");
			global::java.security.cert.X509CertSelector._getPrivateKeyValid23832 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getPrivateKeyValid", "()Ljava/util/Date;");
			global::java.security.cert.X509CertSelector._getSubjectPublicKeyAlgID23833 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getSubjectPublicKeyAlgID", "()Ljava/lang/String;");
			global::java.security.cert.X509CertSelector._getSubjectPublicKey23834 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getSubjectPublicKey", "()Ljava/security/PublicKey;");
			global::java.security.cert.X509CertSelector._getMatchAllSubjectAltNames23835 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getMatchAllSubjectAltNames", "()Z");
			global::java.security.cert.X509CertSelector._getPathToNames23836 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "getPathToNames", "()Ljava/util/Collection;");
			global::java.security.cert.X509CertSelector._X509CertSelector23837 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CertSelector.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
