namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.cert.PKIXCertPathChecker_))]
	public abstract partial class PKIXCertPathChecker : java.lang.Object, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PKIXCertPathChecker(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.PKIXCertPathChecker.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.security.cert.PKIXCertPathChecker._m0) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract void init(bool arg0);
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract void check(java.security.cert.Certificate arg0, java.util.Collection arg1);
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract bool isForwardCheckingSupported();
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract global::java.util.Set getSupportedExtensions();
		private static global::MonoJavaBridge.MethodId _m5;
		protected PKIXCertPathChecker() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.PKIXCertPathChecker._m5.native == global::System.IntPtr.Zero)
				global::java.security.cert.PKIXCertPathChecker._m5 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXCertPathChecker.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.PKIXCertPathChecker.staticClass, global::java.security.cert.PKIXCertPathChecker._m5);
			Init(@__env, handle);
		}
		static PKIXCertPathChecker()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.PKIXCertPathChecker.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/PKIXCertPathChecker"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.PKIXCertPathChecker))]
	internal sealed partial class PKIXCertPathChecker_ : java.security.cert.PKIXCertPathChecker
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal PKIXCertPathChecker_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void init(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.PKIXCertPathChecker_.staticClass, "init", "(Z)V", ref global::java.security.cert.PKIXCertPathChecker_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void check(java.security.cert.Certificate arg0, java.util.Collection arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.PKIXCertPathChecker_.staticClass, "check", "(Ljava/security/cert/Certificate;Ljava/util/Collection;)V", ref global::java.security.cert.PKIXCertPathChecker_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool isForwardCheckingSupported()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.cert.PKIXCertPathChecker_.staticClass, "isForwardCheckingSupported", "()Z", ref global::java.security.cert.PKIXCertPathChecker_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.util.Set getSupportedExtensions()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.security.cert.PKIXCertPathChecker_.staticClass, "getSupportedExtensions", "()Ljava/util/Set;", ref global::java.security.cert.PKIXCertPathChecker_._m3) as java.util.Set;
		}
		static PKIXCertPathChecker_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.PKIXCertPathChecker_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/PKIXCertPathChecker"));
		}
	}
}
