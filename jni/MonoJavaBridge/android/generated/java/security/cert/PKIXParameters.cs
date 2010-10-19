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
		internal static global::MonoJavaBridge.MethodId _toString17930;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._toString17930)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._toString17930)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clone17931;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._clone17931)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._clone17931)) as java.lang.Object;
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
		internal static global::MonoJavaBridge.MethodId _getDate17932;
		public virtual global::java.util.Date getDate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._getDate17932)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._getDate17932)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _setDate17933;
		public virtual void setDate(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._setDate17933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._setDate17933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTargetCertConstraints17934;
		public virtual void setTargetCertConstraints(java.security.cert.CertSelector arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._setTargetCertConstraints17934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._setTargetCertConstraints17934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTrustAnchors17935;
		public virtual global::java.util.Set getTrustAnchors() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._getTrustAnchors17935)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._getTrustAnchors17935)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _setTrustAnchors17936;
		public virtual void setTrustAnchors(java.util.Set arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._setTrustAnchors17936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._setTrustAnchors17936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getInitialPolicies17937;
		public virtual global::java.util.Set getInitialPolicies() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._getInitialPolicies17937)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._getInitialPolicies17937)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _setInitialPolicies17938;
		public virtual void setInitialPolicies(java.util.Set arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._setInitialPolicies17938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._setInitialPolicies17938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCertStores17939;
		public virtual void setCertStores(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._setCertStores17939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._setCertStores17939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addCertStore17940;
		public virtual void addCertStore(java.security.cert.CertStore arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._addCertStore17940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._addCertStore17940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getCertStores17941;
		public virtual global::java.util.List getCertStores() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._getCertStores17941)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._getCertStores17941)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _setRevocationEnabled17942;
		public virtual void setRevocationEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._setRevocationEnabled17942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._setRevocationEnabled17942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isRevocationEnabled17943;
		public virtual bool isRevocationEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._isRevocationEnabled17943);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._isRevocationEnabled17943);
		}
		internal static global::MonoJavaBridge.MethodId _setExplicitPolicyRequired17944;
		public virtual void setExplicitPolicyRequired(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._setExplicitPolicyRequired17944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._setExplicitPolicyRequired17944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isExplicitPolicyRequired17945;
		public virtual bool isExplicitPolicyRequired() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._isExplicitPolicyRequired17945);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._isExplicitPolicyRequired17945);
		}
		internal static global::MonoJavaBridge.MethodId _setPolicyMappingInhibited17946;
		public virtual void setPolicyMappingInhibited(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._setPolicyMappingInhibited17946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._setPolicyMappingInhibited17946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isPolicyMappingInhibited17947;
		public virtual bool isPolicyMappingInhibited() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._isPolicyMappingInhibited17947);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._isPolicyMappingInhibited17947);
		}
		internal static global::MonoJavaBridge.MethodId _setAnyPolicyInhibited17948;
		public virtual void setAnyPolicyInhibited(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._setAnyPolicyInhibited17948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._setAnyPolicyInhibited17948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isAnyPolicyInhibited17949;
		public virtual bool isAnyPolicyInhibited() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._isAnyPolicyInhibited17949);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._isAnyPolicyInhibited17949);
		}
		internal static global::MonoJavaBridge.MethodId _setPolicyQualifiersRejected17950;
		public virtual void setPolicyQualifiersRejected(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._setPolicyQualifiersRejected17950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._setPolicyQualifiersRejected17950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getPolicyQualifiersRejected17951;
		public virtual bool getPolicyQualifiersRejected() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._getPolicyQualifiersRejected17951);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._getPolicyQualifiersRejected17951);
		}
		internal static global::MonoJavaBridge.MethodId _setCertPathCheckers17952;
		public virtual void setCertPathCheckers(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._setCertPathCheckers17952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._setCertPathCheckers17952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getCertPathCheckers17953;
		public virtual global::java.util.List getCertPathCheckers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._getCertPathCheckers17953)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._getCertPathCheckers17953)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _addCertPathChecker17954;
		public virtual void addCertPathChecker(java.security.cert.PKIXCertPathChecker arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._addCertPathChecker17954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._addCertPathChecker17954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSigProvider17955;
		public virtual global::java.lang.String getSigProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._getSigProvider17955)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._getSigProvider17955)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setSigProvider17956;
		public virtual void setSigProvider(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._setSigProvider17956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._setSigProvider17956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTargetCertConstraints17957;
		public virtual global::java.security.cert.CertSelector getTargetCertConstraints() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.cert.CertSelector>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.PKIXParameters._getTargetCertConstraints17957)) as java.security.cert.CertSelector;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.cert.CertSelector>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._getTargetCertConstraints17957)) as java.security.cert.CertSelector;
		}
		internal static global::MonoJavaBridge.MethodId _PKIXParameters17958;
		public PKIXParameters(java.util.Set arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._PKIXParameters17958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PKIXParameters17959;
		public PKIXParameters(java.security.KeyStore arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._PKIXParameters17959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.PKIXParameters.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/PKIXParameters"));
			global::java.security.cert.PKIXParameters._toString17930 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.PKIXParameters._clone17931 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.security.cert.PKIXParameters._getDate17932 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "getDate", "()Ljava/util/Date;");
			global::java.security.cert.PKIXParameters._setDate17933 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "setDate", "(Ljava/util/Date;)V");
			global::java.security.cert.PKIXParameters._setTargetCertConstraints17934 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "setTargetCertConstraints", "(Ljava/security/cert/CertSelector;)V");
			global::java.security.cert.PKIXParameters._getTrustAnchors17935 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "getTrustAnchors", "()Ljava/util/Set;");
			global::java.security.cert.PKIXParameters._setTrustAnchors17936 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "setTrustAnchors", "(Ljava/util/Set;)V");
			global::java.security.cert.PKIXParameters._getInitialPolicies17937 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "getInitialPolicies", "()Ljava/util/Set;");
			global::java.security.cert.PKIXParameters._setInitialPolicies17938 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "setInitialPolicies", "(Ljava/util/Set;)V");
			global::java.security.cert.PKIXParameters._setCertStores17939 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "setCertStores", "(Ljava/util/List;)V");
			global::java.security.cert.PKIXParameters._addCertStore17940 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "addCertStore", "(Ljava/security/cert/CertStore;)V");
			global::java.security.cert.PKIXParameters._getCertStores17941 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "getCertStores", "()Ljava/util/List;");
			global::java.security.cert.PKIXParameters._setRevocationEnabled17942 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "setRevocationEnabled", "(Z)V");
			global::java.security.cert.PKIXParameters._isRevocationEnabled17943 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "isRevocationEnabled", "()Z");
			global::java.security.cert.PKIXParameters._setExplicitPolicyRequired17944 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "setExplicitPolicyRequired", "(Z)V");
			global::java.security.cert.PKIXParameters._isExplicitPolicyRequired17945 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "isExplicitPolicyRequired", "()Z");
			global::java.security.cert.PKIXParameters._setPolicyMappingInhibited17946 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "setPolicyMappingInhibited", "(Z)V");
			global::java.security.cert.PKIXParameters._isPolicyMappingInhibited17947 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "isPolicyMappingInhibited", "()Z");
			global::java.security.cert.PKIXParameters._setAnyPolicyInhibited17948 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "setAnyPolicyInhibited", "(Z)V");
			global::java.security.cert.PKIXParameters._isAnyPolicyInhibited17949 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "isAnyPolicyInhibited", "()Z");
			global::java.security.cert.PKIXParameters._setPolicyQualifiersRejected17950 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "setPolicyQualifiersRejected", "(Z)V");
			global::java.security.cert.PKIXParameters._getPolicyQualifiersRejected17951 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "getPolicyQualifiersRejected", "()Z");
			global::java.security.cert.PKIXParameters._setCertPathCheckers17952 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "setCertPathCheckers", "(Ljava/util/List;)V");
			global::java.security.cert.PKIXParameters._getCertPathCheckers17953 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "getCertPathCheckers", "()Ljava/util/List;");
			global::java.security.cert.PKIXParameters._addCertPathChecker17954 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "addCertPathChecker", "(Ljava/security/cert/PKIXCertPathChecker;)V");
			global::java.security.cert.PKIXParameters._getSigProvider17955 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "getSigProvider", "()Ljava/lang/String;");
			global::java.security.cert.PKIXParameters._setSigProvider17956 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "setSigProvider", "(Ljava/lang/String;)V");
			global::java.security.cert.PKIXParameters._getTargetCertConstraints17957 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "getTargetCertConstraints", "()Ljava/security/cert/CertSelector;");
			global::java.security.cert.PKIXParameters._PKIXParameters17958 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "<init>", "(Ljava/util/Set;)V");
			global::java.security.cert.PKIXParameters._PKIXParameters17959 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "<init>", "(Ljava/security/KeyStore;)V");
		}
	}
}
