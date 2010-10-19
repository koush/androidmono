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
		internal static global::MonoJavaBridge.MethodId _toString18046;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector._toString18046)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._toString18046)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clone18047;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector._clone18047)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._clone18047)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _match18048;
		public virtual bool match(java.security.cert.CRL arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector._match18048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._match18048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIssuers18049;
		public virtual void setIssuers(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector._setIssuers18049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._setIssuers18049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIssuerNames18050;
		public virtual void setIssuerNames(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector._setIssuerNames18050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._setIssuerNames18050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addIssuer18051;
		public virtual void addIssuer(javax.security.auth.x500.X500Principal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector._addIssuer18051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._addIssuer18051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addIssuerName18052;
		public virtual void addIssuerName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector._addIssuerName18052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._addIssuerName18052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addIssuerName18053;
		public virtual void addIssuerName(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector._addIssuerName18053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._addIssuerName18053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMinCRLNumber18054;
		public virtual void setMinCRLNumber(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector._setMinCRLNumber18054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._setMinCRLNumber18054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMaxCRLNumber18055;
		public virtual void setMaxCRLNumber(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector._setMaxCRLNumber18055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._setMaxCRLNumber18055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDateAndTime18056;
		public virtual void setDateAndTime(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector._setDateAndTime18056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._setDateAndTime18056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCertificateChecking18057;
		public virtual void setCertificateChecking(java.security.cert.X509Certificate arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector._setCertificateChecking18057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._setCertificateChecking18057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getIssuers18058;
		public virtual global::java.util.Collection getIssuers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector._getIssuers18058)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._getIssuers18058)) as java.util.Collection;
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
		internal static global::MonoJavaBridge.MethodId _getIssuerNames18059;
		public virtual global::java.util.Collection getIssuerNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector._getIssuerNames18059)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._getIssuerNames18059)) as java.util.Collection;
		}
		public new global::java.math.BigInteger MinCRL
		{
			get
			{
				return getMinCRL();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMinCRL18060;
		public virtual global::java.math.BigInteger getMinCRL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector._getMinCRL18060)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._getMinCRL18060)) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger MaxCRL
		{
			get
			{
				return getMaxCRL();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaxCRL18061;
		public virtual global::java.math.BigInteger getMaxCRL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector._getMaxCRL18061)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._getMaxCRL18061)) as java.math.BigInteger;
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
		internal static global::MonoJavaBridge.MethodId _getDateAndTime18062;
		public virtual global::java.util.Date getDateAndTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector._getDateAndTime18062)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._getDateAndTime18062)) as java.util.Date;
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
		internal static global::MonoJavaBridge.MethodId _getCertificateChecking18063;
		public virtual global::java.security.cert.X509Certificate getCertificateChecking() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector._getCertificateChecking18063)) as java.security.cert.X509Certificate;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._getCertificateChecking18063)) as java.security.cert.X509Certificate;
		}
		internal static global::MonoJavaBridge.MethodId _X509CRLSelector18064;
		public X509CRLSelector()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.X509CRLSelector.staticClass, global::java.security.cert.X509CRLSelector._X509CRLSelector18064);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509CRLSelector.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509CRLSelector"));
			global::java.security.cert.X509CRLSelector._toString18046 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.X509CRLSelector._clone18047 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.security.cert.X509CRLSelector._match18048 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "match", "(Ljava/security/cert/CRL;)Z");
			global::java.security.cert.X509CRLSelector._setIssuers18049 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "setIssuers", "(Ljava/util/Collection;)V");
			global::java.security.cert.X509CRLSelector._setIssuerNames18050 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "setIssuerNames", "(Ljava/util/Collection;)V");
			global::java.security.cert.X509CRLSelector._addIssuer18051 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "addIssuer", "(Ljavax/security/auth/x500/X500Principal;)V");
			global::java.security.cert.X509CRLSelector._addIssuerName18052 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "addIssuerName", "(Ljava/lang/String;)V");
			global::java.security.cert.X509CRLSelector._addIssuerName18053 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "addIssuerName", "([B)V");
			global::java.security.cert.X509CRLSelector._setMinCRLNumber18054 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "setMinCRLNumber", "(Ljava/math/BigInteger;)V");
			global::java.security.cert.X509CRLSelector._setMaxCRLNumber18055 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "setMaxCRLNumber", "(Ljava/math/BigInteger;)V");
			global::java.security.cert.X509CRLSelector._setDateAndTime18056 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "setDateAndTime", "(Ljava/util/Date;)V");
			global::java.security.cert.X509CRLSelector._setCertificateChecking18057 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "setCertificateChecking", "(Ljava/security/cert/X509Certificate;)V");
			global::java.security.cert.X509CRLSelector._getIssuers18058 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "getIssuers", "()Ljava/util/Collection;");
			global::java.security.cert.X509CRLSelector._getIssuerNames18059 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "getIssuerNames", "()Ljava/util/Collection;");
			global::java.security.cert.X509CRLSelector._getMinCRL18060 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "getMinCRL", "()Ljava/math/BigInteger;");
			global::java.security.cert.X509CRLSelector._getMaxCRL18061 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "getMaxCRL", "()Ljava/math/BigInteger;");
			global::java.security.cert.X509CRLSelector._getDateAndTime18062 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "getDateAndTime", "()Ljava/util/Date;");
			global::java.security.cert.X509CRLSelector._getCertificateChecking18063 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "getCertificateChecking", "()Ljava/security/cert/X509Certificate;");
			global::java.security.cert.X509CRLSelector._X509CRLSelector18064 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLSelector.staticClass, "<init>", "()V");
		}
	}
}
