namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.cert.CRL_))]
	public abstract partial class CRL : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CRL(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract global::java.lang.String toString();
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.String getType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.CRL.staticClass, "getType", "()Ljava/lang/String;", ref global::java.security.cert.CRL._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract bool isRevoked(java.security.cert.Certificate arg0);
		private static global::MonoJavaBridge.MethodId _m3;
		protected CRL(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CRL._m3.native == global::System.IntPtr.Zero)
				global::java.security.cert.CRL._m3 = @__env.GetMethodIDNoThrow(global::java.security.cert.CRL.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CRL.staticClass, global::java.security.cert.CRL._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static CRL()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CRL.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CRL"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.CRL))]
	internal sealed partial class CRL_ : java.security.cert.CRL
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CRL_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.CRL_.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.cert.CRL_._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override bool isRevoked(java.security.cert.Certificate arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.cert.CRL_.staticClass, "isRevoked", "(Ljava/security/cert/Certificate;)Z", ref global::java.security.cert.CRL_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static CRL_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CRL_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CRL"));
		}
	}
}
