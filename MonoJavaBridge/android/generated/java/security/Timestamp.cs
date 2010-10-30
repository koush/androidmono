namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Timestamp : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Timestamp(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals23409;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.Timestamp.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.security.Timestamp._equals23409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString23410;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.Timestamp.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.Timestamp._toString23410) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode23411;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.Timestamp.staticClass, "hashCode", "()I", ref global::java.security.Timestamp._hashCode23411);
		}
		public new global::java.security.cert.CertPath SignerCertPath
		{
			get
			{
				return getSignerCertPath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSignerCertPath23412;
		public global::java.security.cert.CertPath getSignerCertPath()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.Timestamp.staticClass, "getSignerCertPath", "()Ljava/security/cert/CertPath;", ref global::java.security.Timestamp._getSignerCertPath23412) as java.security.cert.CertPath;
		}
		internal static global::MonoJavaBridge.MethodId _getTimestamp23413;
		public global::java.util.Date getTimestamp()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.Timestamp.staticClass, "getTimestamp", "()Ljava/util/Date;", ref global::java.security.Timestamp._getTimestamp23413) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _Timestamp23414;
		public Timestamp(java.util.Date arg0, java.security.cert.CertPath arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Timestamp._Timestamp23414.native == global::System.IntPtr.Zero)
				global::java.security.Timestamp._Timestamp23414 = @__env.GetMethodIDNoThrow(global::java.security.Timestamp.staticClass, "<init>", "(Ljava/util/Date;Ljava/security/cert/CertPath;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Timestamp.staticClass, global::java.security.Timestamp._Timestamp23414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static Timestamp()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Timestamp.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Timestamp"));
		}
		internal static void InitJNI()
		{
		}
	}
}
