namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class X509CRLSelector : java.lang.Object, CRLSelector
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected X509CRLSelector(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString23766;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._toString23766)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clone23767;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._clone23767)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _match23768;
		public virtual bool match(java.security.cert.CRL arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._match23768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIssuers23769;
		public virtual void setIssuers(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._setIssuers23769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIssuerNames23770;
		public virtual void setIssuerNames(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._setIssuerNames23770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addIssuer23771;
		public virtual void addIssuer(javax.security.auth.x500.X500Principal arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._addIssuer23771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addIssuerName23772;
		public virtual void addIssuerName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._addIssuerName23772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addIssuerName23773;
		public virtual void addIssuerName(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._addIssuerName23773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.math.BigInteger MinCRLNumber
		{
			set
			{
				setMinCRLNumber(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMinCRLNumber23774;
		public virtual void setMinCRLNumber(java.math.BigInteger arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._setMinCRLNumber23774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.math.BigInteger MaxCRLNumber
		{
			set
			{
				setMaxCRLNumber(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMaxCRLNumber23775;
		public virtual void setMaxCRLNumber(java.math.BigInteger arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._setMaxCRLNumber23775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDateAndTime23776;
		public virtual void setDateAndTime(java.util.Date arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._setDateAndTime23776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCertificateChecking23777;
		public virtual void setCertificateChecking(java.security.cert.X509Certificate arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._setCertificateChecking23777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getIssuers23778;
		public virtual global::java.util.Collection getIssuers()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._getIssuers23778)) as java.util.Collection;
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
		internal static global::MonoJavaBridge.MethodId _getIssuerNames23779;
		public virtual global::java.util.Collection getIssuerNames()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._getIssuerNames23779)) as java.util.Collection;
		}
		public new global::java.math.BigInteger MinCRL
		{
			get
			{
				return getMinCRL();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMinCRL23780;
		public virtual global::java.math.BigInteger getMinCRL()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._getMinCRL23780)) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger MaxCRL
		{
			get
			{
				return getMaxCRL();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaxCRL23781;
		public virtual global::java.math.BigInteger getMaxCRL()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._getMaxCRL23781)) as java.math.BigInteger;
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
		internal static global::MonoJavaBridge.MethodId _getDateAndTime23782;
		public virtual global::java.util.Date getDateAndTime()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._getDateAndTime23782)) as java.util.Date;
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
		internal static global::MonoJavaBridge.MethodId _getCertificateChecking23783;
		public virtual global::java.security.cert.X509Certificate getCertificateChecking()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._getCertificateChecking23783)) as java.security.cert.X509Certificate;
		}
		internal static global::MonoJavaBridge.MethodId _X509CRLSelector23784;
		public X509CRLSelector() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._X509CRLSelector23784);
			Init(@__env, handle);
		}
		static X509CRLSelector()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509CRLSelector.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509CRLSelector"));
			global::java.security.cert.X509CRLSelector._toString23766 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.X509CRLSelector._clone23767 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.security.cert.X509CRLSelector._match23768 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "match", "(Ljava/security/cert/CRL;)Z");
			global::java.security.cert.X509CRLSelector._setIssuers23769 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "setIssuers", "(Ljava/util/Collection;)V");
			global::java.security.cert.X509CRLSelector._setIssuerNames23770 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "setIssuerNames", "(Ljava/util/Collection;)V");
			global::java.security.cert.X509CRLSelector._addIssuer23771 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "addIssuer", "(Ljavax/security/auth/x500/X500Principal;)V");
			global::java.security.cert.X509CRLSelector._addIssuerName23772 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "addIssuerName", "(Ljava/lang/String;)V");
			global::java.security.cert.X509CRLSelector._addIssuerName23773 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "addIssuerName", "([B)V");
			global::java.security.cert.X509CRLSelector._setMinCRLNumber23774 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "setMinCRLNumber", "(Ljava/math/BigInteger;)V");
			global::java.security.cert.X509CRLSelector._setMaxCRLNumber23775 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "setMaxCRLNumber", "(Ljava/math/BigInteger;)V");
			global::java.security.cert.X509CRLSelector._setDateAndTime23776 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "setDateAndTime", "(Ljava/util/Date;)V");
			global::java.security.cert.X509CRLSelector._setCertificateChecking23777 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "setCertificateChecking", "(Ljava/security/cert/X509Certificate;)V");
			global::java.security.cert.X509CRLSelector._getIssuers23778 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "getIssuers", "()Ljava/util/Collection;");
			global::java.security.cert.X509CRLSelector._getIssuerNames23779 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "getIssuerNames", "()Ljava/util/Collection;");
			global::java.security.cert.X509CRLSelector._getMinCRL23780 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "getMinCRL", "()Ljava/math/BigInteger;");
			global::java.security.cert.X509CRLSelector._getMaxCRL23781 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "getMaxCRL", "()Ljava/math/BigInteger;");
			global::java.security.cert.X509CRLSelector._getDateAndTime23782 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "getDateAndTime", "()Ljava/util/Date;");
			global::java.security.cert.X509CRLSelector._getCertificateChecking23783 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "getCertificateChecking", "()Ljava/security/cert/X509Certificate;");
			global::java.security.cert.X509CRLSelector._X509CRLSelector23784 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
