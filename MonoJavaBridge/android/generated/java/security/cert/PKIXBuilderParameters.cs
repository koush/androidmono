namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PKIXBuilderParameters : java.security.cert.PKIXParameters
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PKIXBuilderParameters(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.PKIXBuilderParameters.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.cert.PKIXBuilderParameters._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void setMaxPathLength(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.PKIXBuilderParameters.staticClass, "setMaxPathLength", "(I)V", ref global::java.security.cert.PKIXBuilderParameters._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MaxPathLength
		{
			get
			{
				return getMaxPathLength();
			}
			set
			{
				setMaxPathLength(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getMaxPathLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.cert.PKIXBuilderParameters.staticClass, "getMaxPathLength", "()I", ref global::java.security.cert.PKIXBuilderParameters._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public PKIXBuilderParameters(java.util.Set arg0, java.security.cert.CertSelector arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.PKIXBuilderParameters._m3.native == global::System.IntPtr.Zero)
				global::java.security.cert.PKIXBuilderParameters._m3 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXBuilderParameters.staticClass, "<init>", "(Ljava/util/Set;Ljava/security/cert/CertSelector;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.PKIXBuilderParameters.staticClass, global::java.security.cert.PKIXBuilderParameters._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public PKIXBuilderParameters(java.security.KeyStore arg0, java.security.cert.CertSelector arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.PKIXBuilderParameters._m4.native == global::System.IntPtr.Zero)
				global::java.security.cert.PKIXBuilderParameters._m4 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXBuilderParameters.staticClass, "<init>", "(Ljava/security/KeyStore;Ljava/security/cert/CertSelector;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.PKIXBuilderParameters.staticClass, global::java.security.cert.PKIXBuilderParameters._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static PKIXBuilderParameters()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.PKIXBuilderParameters.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/PKIXBuilderParameters"));
		}
	}
}
