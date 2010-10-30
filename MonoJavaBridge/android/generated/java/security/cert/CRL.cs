namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.cert.CRL_))]
	public abstract partial class CRL : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CRL(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString23467;
		public abstract global::java.lang.String toString();
		internal static global::MonoJavaBridge.MethodId _getType23468;
		public virtual global::java.lang.String getType()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.CRL.staticClass, global::java.security.cert.CRL._getType23468)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isRevoked23469;
		public abstract bool isRevoked(java.security.cert.Certificate arg0);
		internal static global::MonoJavaBridge.MethodId _CRL23470;
		protected CRL(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CRL.staticClass, global::java.security.cert.CRL._CRL23470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static CRL()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CRL.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CRL"));
			global::java.security.cert.CRL._toString23467 = @__env.GetMethodIDNoThrow(global::java.security.cert.CRL.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.CRL._getType23468 = @__env.GetMethodIDNoThrow(global::java.security.cert.CRL.staticClass, "getType", "()Ljava/lang/String;");
			global::java.security.cert.CRL._isRevoked23469 = @__env.GetMethodIDNoThrow(global::java.security.cert.CRL.staticClass, "isRevoked", "(Ljava/security/cert/Certificate;)Z");
			global::java.security.cert.CRL._CRL23470 = @__env.GetMethodIDNoThrow(global::java.security.cert.CRL.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.CRL))]
	internal sealed partial class CRL_ : java.security.cert.CRL
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CRL_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString23471;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CRL_._toString23471)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isRevoked23472;
		public override bool isRevoked(java.security.cert.Certificate arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.CRL_._isRevoked23472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static CRL_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CRL_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CRL"));
			global::java.security.cert.CRL_._toString23471 = @__env.GetMethodIDNoThrow(global::java.security.cert.CRL_.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.CRL_._isRevoked23472 = @__env.GetMethodIDNoThrow(global::java.security.cert.CRL_.staticClass, "isRevoked", "(Ljava/security/cert/Certificate;)Z");
		}
		internal static void InitJNI()
		{
		}
	}
}
