namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class X509CRLSelector : java.lang.Object, CRLSelector
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static X509CRLSelector()
		{
			InitJNI();
		}
		protected X509CRLSelector(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString23765;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector._toString23765)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._toString23765)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clone23766;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector._clone23766)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._clone23766)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _match23767;
		public virtual bool match(java.security.cert.CRL arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector._match23767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._match23767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIssuers23768;
		public virtual void setIssuers(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector._setIssuers23768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._setIssuers23768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIssuerNames23769;
		public virtual void setIssuerNames(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector._setIssuerNames23769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._setIssuerNames23769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addIssuer23770;
		public virtual void addIssuer(javax.security.auth.x500.X500Principal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector._addIssuer23770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._addIssuer23770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addIssuerName23771;
		public virtual void addIssuerName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector._addIssuerName23771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._addIssuerName23771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addIssuerName23772;
		public virtual void addIssuerName(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector._addIssuerName23772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._addIssuerName23772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMinCRLNumber23773;
		public virtual void setMinCRLNumber(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector._setMinCRLNumber23773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._setMinCRLNumber23773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMaxCRLNumber23774;
		public virtual void setMaxCRLNumber(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector._setMaxCRLNumber23774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._setMaxCRLNumber23774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDateAndTime23775;
		public virtual void setDateAndTime(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector._setDateAndTime23775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._setDateAndTime23775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCertificateChecking23776;
		public virtual void setCertificateChecking(java.security.cert.X509Certificate arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector._setCertificateChecking23776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._setCertificateChecking23776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getIssuers23777;
		public virtual global::java.util.Collection getIssuers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector._getIssuers23777)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._getIssuers23777)) as java.util.Collection;
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
		internal static global::MonoJavaBridge.MethodId _getIssuerNames23778;
		public virtual global::java.util.Collection getIssuerNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector._getIssuerNames23778)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._getIssuerNames23778)) as java.util.Collection;
		}
		public new global::java.math.BigInteger MinCRL
		{
			get
			{
				return getMinCRL();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMinCRL23779;
		public virtual global::java.math.BigInteger getMinCRL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector._getMinCRL23779)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._getMinCRL23779)) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger MaxCRL
		{
			get
			{
				return getMaxCRL();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaxCRL23780;
		public virtual global::java.math.BigInteger getMaxCRL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector._getMaxCRL23780)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._getMaxCRL23780)) as java.math.BigInteger;
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
		internal static global::MonoJavaBridge.MethodId _getDateAndTime23781;
		public virtual global::java.util.Date getDateAndTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector._getDateAndTime23781)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._getDateAndTime23781)) as java.util.Date;
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
		internal static global::MonoJavaBridge.MethodId _getCertificateChecking23782;
		public virtual global::java.security.cert.X509Certificate getCertificateChecking() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector._getCertificateChecking23782)) as java.security.cert.X509Certificate;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._getCertificateChecking23782)) as java.security.cert.X509Certificate;
		}
		internal static global::MonoJavaBridge.MethodId _X509CRLSelector23783;
		public X509CRLSelector()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._X509CRLSelector23783);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509CRLSelector.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509CRLSelector"));
			global::java.security.cert.X509CRLSelector._toString23765 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.X509CRLSelector._clone23766 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.security.cert.X509CRLSelector._match23767 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "match", "(Ljava/security/cert/CRL;)Z");
			global::java.security.cert.X509CRLSelector._setIssuers23768 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "setIssuers", "(Ljava/util/Collection;)V");
			global::java.security.cert.X509CRLSelector._setIssuerNames23769 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "setIssuerNames", "(Ljava/util/Collection;)V");
			global::java.security.cert.X509CRLSelector._addIssuer23770 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "addIssuer", "(Ljavax/security/auth/x500/X500Principal;)V");
			global::java.security.cert.X509CRLSelector._addIssuerName23771 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "addIssuerName", "(Ljava/lang/String;)V");
			global::java.security.cert.X509CRLSelector._addIssuerName23772 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "addIssuerName", "([B)V");
			global::java.security.cert.X509CRLSelector._setMinCRLNumber23773 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "setMinCRLNumber", "(Ljava/math/BigInteger;)V");
			global::java.security.cert.X509CRLSelector._setMaxCRLNumber23774 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "setMaxCRLNumber", "(Ljava/math/BigInteger;)V");
			global::java.security.cert.X509CRLSelector._setDateAndTime23775 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "setDateAndTime", "(Ljava/util/Date;)V");
			global::java.security.cert.X509CRLSelector._setCertificateChecking23776 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "setCertificateChecking", "(Ljava/security/cert/X509Certificate;)V");
			global::java.security.cert.X509CRLSelector._getIssuers23777 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "getIssuers", "()Ljava/util/Collection;");
			global::java.security.cert.X509CRLSelector._getIssuerNames23778 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "getIssuerNames", "()Ljava/util/Collection;");
			global::java.security.cert.X509CRLSelector._getMinCRL23779 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "getMinCRL", "()Ljava/math/BigInteger;");
			global::java.security.cert.X509CRLSelector._getMaxCRL23780 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "getMaxCRL", "()Ljava/math/BigInteger;");
			global::java.security.cert.X509CRLSelector._getDateAndTime23781 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "getDateAndTime", "()Ljava/util/Date;");
			global::java.security.cert.X509CRLSelector._getCertificateChecking23782 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "getCertificateChecking", "()Ljava/security/cert/X509Certificate;");
			global::java.security.cert.X509CRLSelector._X509CRLSelector23783 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "<init>", "()V");
		}
	}
}
