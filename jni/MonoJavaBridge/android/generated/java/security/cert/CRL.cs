namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.cert.CRL_))]
	public abstract partial class CRL : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CRL()
		{
			InitJNI();
		}
		protected CRL(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString23466;
		public abstract global::java.lang.String toString();
		internal static global::MonoJavaBridge.MethodId _getType23467;
		public virtual global::java.lang.String getType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CRL._getType23467)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CRL.staticClass, global::java.security.cert.CRL._getType23467)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isRevoked23468;
		public abstract bool isRevoked(java.security.cert.Certificate arg0);
		internal static global::MonoJavaBridge.MethodId _CRL23469;
		protected CRL(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CRL.staticClass, global::java.security.cert.CRL._CRL23469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CRL.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CRL"));
			global::java.security.cert.CRL._toString23466 = @__env.GetMethodIDNoThrow(global::java.security.cert.CRL.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.CRL._getType23467 = @__env.GetMethodIDNoThrow(global::java.security.cert.CRL.staticClass, "getType", "()Ljava/lang/String;");
			global::java.security.cert.CRL._isRevoked23468 = @__env.GetMethodIDNoThrow(global::java.security.cert.CRL.staticClass, "isRevoked", "(Ljava/security/cert/Certificate;)Z");
			global::java.security.cert.CRL._CRL23469 = @__env.GetMethodIDNoThrow(global::java.security.cert.CRL.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.CRL))]
	internal sealed partial class CRL_ : java.security.cert.CRL
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CRL_()
		{
			InitJNI();
		}
		internal CRL_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString23470;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CRL_._toString23470)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CRL_.staticClass, global::java.security.cert.CRL_._toString23470)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isRevoked23471;
		public override bool isRevoked(java.security.cert.Certificate arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.CRL_._isRevoked23471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.CRL_.staticClass, global::java.security.cert.CRL_._isRevoked23471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CRL_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CRL"));
			global::java.security.cert.CRL_._toString23470 = @__env.GetMethodIDNoThrow(global::java.security.cert.CRL_.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.CRL_._isRevoked23471 = @__env.GetMethodIDNoThrow(global::java.security.cert.CRL_.staticClass, "isRevoked", "(Ljava/security/cert/Certificate;)Z");
		}
	}
}
