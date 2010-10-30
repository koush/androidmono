namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.cert.PKIXCertPathChecker_))]
	public abstract partial class PKIXCertPathChecker : java.lang.Object, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PKIXCertPathChecker(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone23634;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.PKIXCertPathChecker.staticClass, global::java.security.cert.PKIXCertPathChecker._clone23634)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _init23635;
		public abstract void init(bool arg0);
		internal static global::MonoJavaBridge.MethodId _check23636;
		public abstract void check(java.security.cert.Certificate arg0, java.util.Collection arg1);
		internal static global::MonoJavaBridge.MethodId _isForwardCheckingSupported23637;
		public abstract bool isForwardCheckingSupported();
		internal static global::MonoJavaBridge.MethodId _getSupportedExtensions23638;
		public abstract global::java.util.Set getSupportedExtensions();
		internal static global::MonoJavaBridge.MethodId _PKIXCertPathChecker23639;
		protected PKIXCertPathChecker() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.PKIXCertPathChecker.staticClass, global::java.security.cert.PKIXCertPathChecker._PKIXCertPathChecker23639);
			Init(@__env, handle);
		}
		static PKIXCertPathChecker()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.PKIXCertPathChecker.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/PKIXCertPathChecker"));
			global::java.security.cert.PKIXCertPathChecker._clone23634 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXCertPathChecker.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.security.cert.PKIXCertPathChecker._init23635 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXCertPathChecker.staticClass, "init", "(Z)V");
			global::java.security.cert.PKIXCertPathChecker._check23636 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXCertPathChecker.staticClass, "check", "(Ljava/security/cert/Certificate;Ljava/util/Collection;)V");
			global::java.security.cert.PKIXCertPathChecker._isForwardCheckingSupported23637 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXCertPathChecker.staticClass, "isForwardCheckingSupported", "()Z");
			global::java.security.cert.PKIXCertPathChecker._getSupportedExtensions23638 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXCertPathChecker.staticClass, "getSupportedExtensions", "()Ljava/util/Set;");
			global::java.security.cert.PKIXCertPathChecker._PKIXCertPathChecker23639 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXCertPathChecker.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.PKIXCertPathChecker))]
	internal sealed partial class PKIXCertPathChecker_ : java.security.cert.PKIXCertPathChecker
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal PKIXCertPathChecker_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _init23640;
		public override void init(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.PKIXCertPathChecker_._init23640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _check23641;
		public override void check(java.security.cert.Certificate arg0, java.util.Collection arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.PKIXCertPathChecker_._check23641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isForwardCheckingSupported23642;
		public override bool isForwardCheckingSupported()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.PKIXCertPathChecker_._isForwardCheckingSupported23642);
		}
		internal static global::MonoJavaBridge.MethodId _getSupportedExtensions23643;
		public override global::java.util.Set getSupportedExtensions()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.PKIXCertPathChecker_._getSupportedExtensions23643)) as java.util.Set;
		}
		static PKIXCertPathChecker_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.PKIXCertPathChecker_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/PKIXCertPathChecker"));
			global::java.security.cert.PKIXCertPathChecker_._init23640 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXCertPathChecker_.staticClass, "init", "(Z)V");
			global::java.security.cert.PKIXCertPathChecker_._check23641 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXCertPathChecker_.staticClass, "check", "(Ljava/security/cert/Certificate;Ljava/util/Collection;)V");
			global::java.security.cert.PKIXCertPathChecker_._isForwardCheckingSupported23642 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXCertPathChecker_.staticClass, "isForwardCheckingSupported", "()Z");
			global::java.security.cert.PKIXCertPathChecker_._getSupportedExtensions23643 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXCertPathChecker_.staticClass, "getSupportedExtensions", "()Ljava/util/Set;");
		}
		internal static void InitJNI()
		{
		}
	}
}
