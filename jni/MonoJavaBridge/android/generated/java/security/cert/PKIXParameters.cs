namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PKIXParameters : java.lang.Object, CertPathParameters
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PKIXParameters()
		{
			InitJNI();
		}
		protected PKIXParameters(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString23649;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._toString23649)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._toString23649)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clone23650;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._clone23650)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._clone23650)) as java.lang.Object;
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
		internal static global::MonoJavaBridge.MethodId _getDate23651;
		public virtual global::java.util.Date getDate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._getDate23651)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._getDate23651)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _setDate23652;
		public virtual void setDate(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._setDate23652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._setDate23652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTargetCertConstraints23653;
		public virtual void setTargetCertConstraints(java.security.cert.CertSelector arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._setTargetCertConstraints23653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._setTargetCertConstraints23653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTrustAnchors23654;
		public virtual global::java.util.Set getTrustAnchors() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._getTrustAnchors23654)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._getTrustAnchors23654)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _setTrustAnchors23655;
		public virtual void setTrustAnchors(java.util.Set arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._setTrustAnchors23655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._setTrustAnchors23655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getInitialPolicies23656;
		public virtual global::java.util.Set getInitialPolicies() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._getInitialPolicies23656)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._getInitialPolicies23656)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _setInitialPolicies23657;
		public virtual void setInitialPolicies(java.util.Set arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._setInitialPolicies23657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._setInitialPolicies23657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCertStores23658;
		public virtual void setCertStores(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._setCertStores23658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._setCertStores23658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addCertStore23659;
		public virtual void addCertStore(java.security.cert.CertStore arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._addCertStore23659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._addCertStore23659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getCertStores23660;
		public virtual global::java.util.List getCertStores() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._getCertStores23660)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._getCertStores23660)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _setRevocationEnabled23661;
		public virtual void setRevocationEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._setRevocationEnabled23661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._setRevocationEnabled23661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isRevocationEnabled23662;
		public virtual bool isRevocationEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._isRevocationEnabled23662);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._isRevocationEnabled23662);
		}
		internal static global::MonoJavaBridge.MethodId _setExplicitPolicyRequired23663;
		public virtual void setExplicitPolicyRequired(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._setExplicitPolicyRequired23663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._setExplicitPolicyRequired23663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isExplicitPolicyRequired23664;
		public virtual bool isExplicitPolicyRequired() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._isExplicitPolicyRequired23664);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._isExplicitPolicyRequired23664);
		}
		internal static global::MonoJavaBridge.MethodId _setPolicyMappingInhibited23665;
		public virtual void setPolicyMappingInhibited(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._setPolicyMappingInhibited23665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._setPolicyMappingInhibited23665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isPolicyMappingInhibited23666;
		public virtual bool isPolicyMappingInhibited() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._isPolicyMappingInhibited23666);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._isPolicyMappingInhibited23666);
		}
		internal static global::MonoJavaBridge.MethodId _setAnyPolicyInhibited23667;
		public virtual void setAnyPolicyInhibited(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._setAnyPolicyInhibited23667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._setAnyPolicyInhibited23667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isAnyPolicyInhibited23668;
		public virtual bool isAnyPolicyInhibited() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._isAnyPolicyInhibited23668);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._isAnyPolicyInhibited23668);
		}
		internal static global::MonoJavaBridge.MethodId _setPolicyQualifiersRejected23669;
		public virtual void setPolicyQualifiersRejected(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._setPolicyQualifiersRejected23669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._setPolicyQualifiersRejected23669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getPolicyQualifiersRejected23670;
		public virtual bool getPolicyQualifiersRejected() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._getPolicyQualifiersRejected23670);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._getPolicyQualifiersRejected23670);
		}
		internal static global::MonoJavaBridge.MethodId _setCertPathCheckers23671;
		public virtual void setCertPathCheckers(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._setCertPathCheckers23671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._setCertPathCheckers23671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getCertPathCheckers23672;
		public virtual global::java.util.List getCertPathCheckers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._getCertPathCheckers23672)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._getCertPathCheckers23672)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _addCertPathChecker23673;
		public virtual void addCertPathChecker(java.security.cert.PKIXCertPathChecker arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._addCertPathChecker23673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._addCertPathChecker23673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSigProvider23674;
		public virtual global::java.lang.String getSigProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._getSigProvider23674)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._getSigProvider23674)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setSigProvider23675;
		public virtual void setSigProvider(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._setSigProvider23675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._setSigProvider23675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTargetCertConstraints23676;
		public virtual global::java.security.cert.CertSelector getTargetCertConstraints() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.cert.CertSelector>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._getTargetCertConstraints23676)) as java.security.cert.CertSelector;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.cert.CertSelector>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._getTargetCertConstraints23676)) as java.security.cert.CertSelector;
		}
		internal static global::MonoJavaBridge.MethodId _PKIXParameters23677;
		public PKIXParameters(java.util.Set arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._PKIXParameters23677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PKIXParameters23678;
		public PKIXParameters(java.security.KeyStore arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._PKIXParameters23678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.PKIXParameters.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/PKIXParameters"));
			global::java.security.cert.PKIXParameters._toString23649 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.PKIXParameters._clone23650 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.security.cert.PKIXParameters._getDate23651 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "getDate", "()Ljava/util/Date;");
			global::java.security.cert.PKIXParameters._setDate23652 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "setDate", "(Ljava/util/Date;)V");
			global::java.security.cert.PKIXParameters._setTargetCertConstraints23653 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "setTargetCertConstraints", "(Ljava/security/cert/CertSelector;)V");
			global::java.security.cert.PKIXParameters._getTrustAnchors23654 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "getTrustAnchors", "()Ljava/util/Set;");
			global::java.security.cert.PKIXParameters._setTrustAnchors23655 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "setTrustAnchors", "(Ljava/util/Set;)V");
			global::java.security.cert.PKIXParameters._getInitialPolicies23656 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "getInitialPolicies", "()Ljava/util/Set;");
			global::java.security.cert.PKIXParameters._setInitialPolicies23657 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "setInitialPolicies", "(Ljava/util/Set;)V");
			global::java.security.cert.PKIXParameters._setCertStores23658 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "setCertStores", "(Ljava/util/List;)V");
			global::java.security.cert.PKIXParameters._addCertStore23659 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "addCertStore", "(Ljava/security/cert/CertStore;)V");
			global::java.security.cert.PKIXParameters._getCertStores23660 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "getCertStores", "()Ljava/util/List;");
			global::java.security.cert.PKIXParameters._setRevocationEnabled23661 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "setRevocationEnabled", "(Z)V");
			global::java.security.cert.PKIXParameters._isRevocationEnabled23662 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "isRevocationEnabled", "()Z");
			global::java.security.cert.PKIXParameters._setExplicitPolicyRequired23663 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "setExplicitPolicyRequired", "(Z)V");
			global::java.security.cert.PKIXParameters._isExplicitPolicyRequired23664 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "isExplicitPolicyRequired", "()Z");
			global::java.security.cert.PKIXParameters._setPolicyMappingInhibited23665 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "setPolicyMappingInhibited", "(Z)V");
			global::java.security.cert.PKIXParameters._isPolicyMappingInhibited23666 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "isPolicyMappingInhibited", "()Z");
			global::java.security.cert.PKIXParameters._setAnyPolicyInhibited23667 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "setAnyPolicyInhibited", "(Z)V");
			global::java.security.cert.PKIXParameters._isAnyPolicyInhibited23668 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "isAnyPolicyInhibited", "()Z");
			global::java.security.cert.PKIXParameters._setPolicyQualifiersRejected23669 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "setPolicyQualifiersRejected", "(Z)V");
			global::java.security.cert.PKIXParameters._getPolicyQualifiersRejected23670 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "getPolicyQualifiersRejected", "()Z");
			global::java.security.cert.PKIXParameters._setCertPathCheckers23671 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "setCertPathCheckers", "(Ljava/util/List;)V");
			global::java.security.cert.PKIXParameters._getCertPathCheckers23672 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "getCertPathCheckers", "()Ljava/util/List;");
			global::java.security.cert.PKIXParameters._addCertPathChecker23673 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "addCertPathChecker", "(Ljava/security/cert/PKIXCertPathChecker;)V");
			global::java.security.cert.PKIXParameters._getSigProvider23674 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "getSigProvider", "()Ljava/lang/String;");
			global::java.security.cert.PKIXParameters._setSigProvider23675 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "setSigProvider", "(Ljava/lang/String;)V");
			global::java.security.cert.PKIXParameters._getTargetCertConstraints23676 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "getTargetCertConstraints", "()Ljava/security/cert/CertSelector;");
			global::java.security.cert.PKIXParameters._PKIXParameters23677 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "<init>", "(Ljava/util/Set;)V");
			global::java.security.cert.PKIXParameters._PKIXParameters23678 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "<init>", "(Ljava/security/KeyStore;)V");
		}
	}
}
