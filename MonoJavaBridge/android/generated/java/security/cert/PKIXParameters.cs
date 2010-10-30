namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PKIXParameters : java.lang.Object, CertPathParameters
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PKIXParameters(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString23650;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.PKIXParameters.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.cert.PKIXParameters._toString23650) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clone23651;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.PKIXParameters.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.security.cert.PKIXParameters._clone23651) as java.lang.Object;
		}
		public new global::java.util.Date Date
		{
			get
			{
				return getDate();
			}
			set
			{
				setDate(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDate23652;
		public virtual global::java.util.Date getDate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.PKIXParameters.staticClass, "getDate", "()Ljava/util/Date;", ref global::java.security.cert.PKIXParameters._getDate23652) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _setDate23653;
		public virtual void setDate(java.util.Date arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.PKIXParameters.staticClass, "setDate", "(Ljava/util/Date;)V", ref global::java.security.cert.PKIXParameters._setDate23653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTargetCertConstraints23654;
		public virtual void setTargetCertConstraints(java.security.cert.CertSelector arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.PKIXParameters.staticClass, "setTargetCertConstraints", "(Ljava/security/cert/CertSelector;)V", ref global::java.security.cert.PKIXParameters._setTargetCertConstraints23654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.Set TrustAnchors
		{
			get
			{
				return getTrustAnchors();
			}
			set
			{
				setTrustAnchors(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTrustAnchors23655;
		public virtual global::java.util.Set getTrustAnchors()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.security.cert.PKIXParameters.staticClass, "getTrustAnchors", "()Ljava/util/Set;", ref global::java.security.cert.PKIXParameters._getTrustAnchors23655) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _setTrustAnchors23656;
		public virtual void setTrustAnchors(java.util.Set arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.PKIXParameters.staticClass, "setTrustAnchors", "(Ljava/util/Set;)V", ref global::java.security.cert.PKIXParameters._setTrustAnchors23656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.Set InitialPolicies
		{
			get
			{
				return getInitialPolicies();
			}
			set
			{
				setInitialPolicies(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInitialPolicies23657;
		public virtual global::java.util.Set getInitialPolicies()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.security.cert.PKIXParameters.staticClass, "getInitialPolicies", "()Ljava/util/Set;", ref global::java.security.cert.PKIXParameters._getInitialPolicies23657) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _setInitialPolicies23658;
		public virtual void setInitialPolicies(java.util.Set arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.PKIXParameters.staticClass, "setInitialPolicies", "(Ljava/util/Set;)V", ref global::java.security.cert.PKIXParameters._setInitialPolicies23658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCertStores23659;
		public virtual void setCertStores(java.util.List arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.PKIXParameters.staticClass, "setCertStores", "(Ljava/util/List;)V", ref global::java.security.cert.PKIXParameters._setCertStores23659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addCertStore23660;
		public virtual void addCertStore(java.security.cert.CertStore arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.PKIXParameters.staticClass, "addCertStore", "(Ljava/security/cert/CertStore;)V", ref global::java.security.cert.PKIXParameters._addCertStore23660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.List CertStores
		{
			get
			{
				return getCertStores();
			}
			set
			{
				setCertStores(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCertStores23661;
		public virtual global::java.util.List getCertStores()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::java.security.cert.PKIXParameters.staticClass, "getCertStores", "()Ljava/util/List;", ref global::java.security.cert.PKIXParameters._getCertStores23661) as java.util.List;
		}
		public new bool RevocationEnabled
		{
			set
			{
				setRevocationEnabled(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setRevocationEnabled23662;
		public virtual void setRevocationEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.PKIXParameters.staticClass, "setRevocationEnabled", "(Z)V", ref global::java.security.cert.PKIXParameters._setRevocationEnabled23662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isRevocationEnabled23663;
		public virtual bool isRevocationEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.cert.PKIXParameters.staticClass, "isRevocationEnabled", "()Z", ref global::java.security.cert.PKIXParameters._isRevocationEnabled23663);
		}
		public new bool ExplicitPolicyRequired
		{
			set
			{
				setExplicitPolicyRequired(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setExplicitPolicyRequired23664;
		public virtual void setExplicitPolicyRequired(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.PKIXParameters.staticClass, "setExplicitPolicyRequired", "(Z)V", ref global::java.security.cert.PKIXParameters._setExplicitPolicyRequired23664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isExplicitPolicyRequired23665;
		public virtual bool isExplicitPolicyRequired()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.cert.PKIXParameters.staticClass, "isExplicitPolicyRequired", "()Z", ref global::java.security.cert.PKIXParameters._isExplicitPolicyRequired23665);
		}
		public new bool PolicyMappingInhibited
		{
			set
			{
				setPolicyMappingInhibited(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setPolicyMappingInhibited23666;
		public virtual void setPolicyMappingInhibited(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.PKIXParameters.staticClass, "setPolicyMappingInhibited", "(Z)V", ref global::java.security.cert.PKIXParameters._setPolicyMappingInhibited23666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isPolicyMappingInhibited23667;
		public virtual bool isPolicyMappingInhibited()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.cert.PKIXParameters.staticClass, "isPolicyMappingInhibited", "()Z", ref global::java.security.cert.PKIXParameters._isPolicyMappingInhibited23667);
		}
		public new bool AnyPolicyInhibited
		{
			set
			{
				setAnyPolicyInhibited(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setAnyPolicyInhibited23668;
		public virtual void setAnyPolicyInhibited(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.PKIXParameters.staticClass, "setAnyPolicyInhibited", "(Z)V", ref global::java.security.cert.PKIXParameters._setAnyPolicyInhibited23668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isAnyPolicyInhibited23669;
		public virtual bool isAnyPolicyInhibited()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.cert.PKIXParameters.staticClass, "isAnyPolicyInhibited", "()Z", ref global::java.security.cert.PKIXParameters._isAnyPolicyInhibited23669);
		}
		internal static global::MonoJavaBridge.MethodId _setPolicyQualifiersRejected23670;
		public virtual void setPolicyQualifiersRejected(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.PKIXParameters.staticClass, "setPolicyQualifiersRejected", "(Z)V", ref global::java.security.cert.PKIXParameters._setPolicyQualifiersRejected23670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool PolicyQualifiersRejected
		{
			get
			{
				return getPolicyQualifiersRejected();
			}
			set
			{
				setPolicyQualifiersRejected(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPolicyQualifiersRejected23671;
		public virtual bool getPolicyQualifiersRejected()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.cert.PKIXParameters.staticClass, "getPolicyQualifiersRejected", "()Z", ref global::java.security.cert.PKIXParameters._getPolicyQualifiersRejected23671);
		}
		internal static global::MonoJavaBridge.MethodId _setCertPathCheckers23672;
		public virtual void setCertPathCheckers(java.util.List arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.PKIXParameters.staticClass, "setCertPathCheckers", "(Ljava/util/List;)V", ref global::java.security.cert.PKIXParameters._setCertPathCheckers23672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.List CertPathCheckers
		{
			get
			{
				return getCertPathCheckers();
			}
			set
			{
				setCertPathCheckers(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCertPathCheckers23673;
		public virtual global::java.util.List getCertPathCheckers()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::java.security.cert.PKIXParameters.staticClass, "getCertPathCheckers", "()Ljava/util/List;", ref global::java.security.cert.PKIXParameters._getCertPathCheckers23673) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _addCertPathChecker23674;
		public virtual void addCertPathChecker(java.security.cert.PKIXCertPathChecker arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.PKIXParameters.staticClass, "addCertPathChecker", "(Ljava/security/cert/PKIXCertPathChecker;)V", ref global::java.security.cert.PKIXParameters._addCertPathChecker23674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String SigProvider
		{
			get
			{
				return getSigProvider();
			}
			set
			{
				setSigProvider(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSigProvider23675;
		public virtual global::java.lang.String getSigProvider()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.PKIXParameters.staticClass, "getSigProvider", "()Ljava/lang/String;", ref global::java.security.cert.PKIXParameters._getSigProvider23675) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setSigProvider23676;
		public virtual void setSigProvider(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.PKIXParameters.staticClass, "setSigProvider", "(Ljava/lang/String;)V", ref global::java.security.cert.PKIXParameters._setSigProvider23676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.security.cert.CertSelector TargetCertConstraints
		{
			get
			{
				return getTargetCertConstraints();
			}
			set
			{
				setTargetCertConstraints(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTargetCertConstraints23677;
		public virtual global::java.security.cert.CertSelector getTargetCertConstraints()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.cert.CertSelector>(this, global::java.security.cert.PKIXParameters.staticClass, "getTargetCertConstraints", "()Ljava/security/cert/CertSelector;", ref global::java.security.cert.PKIXParameters._getTargetCertConstraints23677) as java.security.cert.CertSelector;
		}
		internal static global::MonoJavaBridge.MethodId _PKIXParameters23678;
		public PKIXParameters(java.util.Set arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.PKIXParameters._PKIXParameters23678.native == global::System.IntPtr.Zero)
				global::java.security.cert.PKIXParameters._PKIXParameters23678 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "<init>", "(Ljava/util/Set;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._PKIXParameters23678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PKIXParameters23679;
		public PKIXParameters(java.security.KeyStore arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.PKIXParameters._PKIXParameters23679.native == global::System.IntPtr.Zero)
				global::java.security.cert.PKIXParameters._PKIXParameters23679 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "<init>", "(Ljava/security/KeyStore;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._PKIXParameters23679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static PKIXParameters()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.PKIXParameters.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/PKIXParameters"));
		}
		internal static void InitJNI()
		{
		}
	}
}
