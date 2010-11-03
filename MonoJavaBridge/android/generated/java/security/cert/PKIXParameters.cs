namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PKIXParameters : java.lang.Object, CertPathParameters
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PKIXParameters(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.PKIXParameters.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.cert.PKIXParameters._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.PKIXParameters.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.security.cert.PKIXParameters._m1) as java.lang.Object;
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
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.util.Date getDate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.PKIXParameters.staticClass, "getDate", "()Ljava/util/Date;", ref global::java.security.cert.PKIXParameters._m2) as java.util.Date;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setDate(java.util.Date arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.PKIXParameters.staticClass, "setDate", "(Ljava/util/Date;)V", ref global::java.security.cert.PKIXParameters._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setTargetCertConstraints(java.security.cert.CertSelector arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.PKIXParameters.staticClass, "setTargetCertConstraints", "(Ljava/security/cert/CertSelector;)V", ref global::java.security.cert.PKIXParameters._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.util.Set getTrustAnchors()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.security.cert.PKIXParameters.staticClass, "getTrustAnchors", "()Ljava/util/Set;", ref global::java.security.cert.PKIXParameters._m5) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setTrustAnchors(java.util.Set arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.PKIXParameters.staticClass, "setTrustAnchors", "(Ljava/util/Set;)V", ref global::java.security.cert.PKIXParameters._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.util.Set getInitialPolicies()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.security.cert.PKIXParameters.staticClass, "getInitialPolicies", "()Ljava/util/Set;", ref global::java.security.cert.PKIXParameters._m7) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setInitialPolicies(java.util.Set arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.PKIXParameters.staticClass, "setInitialPolicies", "(Ljava/util/Set;)V", ref global::java.security.cert.PKIXParameters._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setCertStores(java.util.List arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.PKIXParameters.staticClass, "setCertStores", "(Ljava/util/List;)V", ref global::java.security.cert.PKIXParameters._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void addCertStore(java.security.cert.CertStore arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.PKIXParameters.staticClass, "addCertStore", "(Ljava/security/cert/CertStore;)V", ref global::java.security.cert.PKIXParameters._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::java.util.List getCertStores()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::java.security.cert.PKIXParameters.staticClass, "getCertStores", "()Ljava/util/List;", ref global::java.security.cert.PKIXParameters._m11) as java.util.List;
		}
		public new bool RevocationEnabled
		{
			set
			{
				setRevocationEnabled(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setRevocationEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.PKIXParameters.staticClass, "setRevocationEnabled", "(Z)V", ref global::java.security.cert.PKIXParameters._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual bool isRevocationEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.cert.PKIXParameters.staticClass, "isRevocationEnabled", "()Z", ref global::java.security.cert.PKIXParameters._m13);
		}
		public new bool ExplicitPolicyRequired
		{
			set
			{
				setExplicitPolicyRequired(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setExplicitPolicyRequired(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.PKIXParameters.staticClass, "setExplicitPolicyRequired", "(Z)V", ref global::java.security.cert.PKIXParameters._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual bool isExplicitPolicyRequired()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.cert.PKIXParameters.staticClass, "isExplicitPolicyRequired", "()Z", ref global::java.security.cert.PKIXParameters._m15);
		}
		public new bool PolicyMappingInhibited
		{
			set
			{
				setPolicyMappingInhibited(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void setPolicyMappingInhibited(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.PKIXParameters.staticClass, "setPolicyMappingInhibited", "(Z)V", ref global::java.security.cert.PKIXParameters._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual bool isPolicyMappingInhibited()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.cert.PKIXParameters.staticClass, "isPolicyMappingInhibited", "()Z", ref global::java.security.cert.PKIXParameters._m17);
		}
		public new bool AnyPolicyInhibited
		{
			set
			{
				setAnyPolicyInhibited(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void setAnyPolicyInhibited(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.PKIXParameters.staticClass, "setAnyPolicyInhibited", "(Z)V", ref global::java.security.cert.PKIXParameters._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual bool isAnyPolicyInhibited()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.cert.PKIXParameters.staticClass, "isAnyPolicyInhibited", "()Z", ref global::java.security.cert.PKIXParameters._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void setPolicyQualifiersRejected(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.PKIXParameters.staticClass, "setPolicyQualifiersRejected", "(Z)V", ref global::java.security.cert.PKIXParameters._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual bool getPolicyQualifiersRejected()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.cert.PKIXParameters.staticClass, "getPolicyQualifiersRejected", "()Z", ref global::java.security.cert.PKIXParameters._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void setCertPathCheckers(java.util.List arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.PKIXParameters.staticClass, "setCertPathCheckers", "(Ljava/util/List;)V", ref global::java.security.cert.PKIXParameters._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual global::java.util.List getCertPathCheckers()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::java.security.cert.PKIXParameters.staticClass, "getCertPathCheckers", "()Ljava/util/List;", ref global::java.security.cert.PKIXParameters._m23) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual void addCertPathChecker(java.security.cert.PKIXCertPathChecker arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.PKIXParameters.staticClass, "addCertPathChecker", "(Ljava/security/cert/PKIXCertPathChecker;)V", ref global::java.security.cert.PKIXParameters._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual global::java.lang.String getSigProvider()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.PKIXParameters.staticClass, "getSigProvider", "()Ljava/lang/String;", ref global::java.security.cert.PKIXParameters._m25) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual void setSigProvider(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.PKIXParameters.staticClass, "setSigProvider", "(Ljava/lang/String;)V", ref global::java.security.cert.PKIXParameters._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual global::java.security.cert.CertSelector getTargetCertConstraints()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.cert.CertSelector>(this, global::java.security.cert.PKIXParameters.staticClass, "getTargetCertConstraints", "()Ljava/security/cert/CertSelector;", ref global::java.security.cert.PKIXParameters._m27) as java.security.cert.CertSelector;
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public PKIXParameters(java.util.Set arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.PKIXParameters._m28.native == global::System.IntPtr.Zero)
				global::java.security.cert.PKIXParameters._m28 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "<init>", "(Ljava/util/Set;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public PKIXParameters(java.security.KeyStore arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.PKIXParameters._m29.native == global::System.IntPtr.Zero)
				global::java.security.cert.PKIXParameters._m29 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXParameters.staticClass, "<init>", "(Ljava/security/KeyStore;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.PKIXParameters.staticClass, global::java.security.cert.PKIXParameters._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static PKIXParameters()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.PKIXParameters.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/PKIXParameters"));
		}
	}
}
