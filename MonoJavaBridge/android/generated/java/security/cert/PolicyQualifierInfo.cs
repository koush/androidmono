namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PolicyQualifierInfo : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PolicyQualifierInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.PolicyQualifierInfo.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.cert.PolicyQualifierInfo._m0) as java.lang.String;
		}
		public new byte[] Encoded
		{
			get
			{
				return getEncoded();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual byte[] getEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.cert.PolicyQualifierInfo.staticClass, "getEncoded", "()[B", ref global::java.security.cert.PolicyQualifierInfo._m1) as byte[];
		}
		public new global::java.lang.String PolicyQualifierId
		{
			get
			{
				return getPolicyQualifierId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.String getPolicyQualifierId()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.PolicyQualifierInfo.staticClass, "getPolicyQualifierId", "()Ljava/lang/String;", ref global::java.security.cert.PolicyQualifierInfo._m2) as java.lang.String;
		}
		public new byte[] PolicyQualifier
		{
			get
			{
				return getPolicyQualifier();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual byte[] getPolicyQualifier()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.cert.PolicyQualifierInfo.staticClass, "getPolicyQualifier", "()[B", ref global::java.security.cert.PolicyQualifierInfo._m3) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public PolicyQualifierInfo(byte[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.PolicyQualifierInfo._m4.native == global::System.IntPtr.Zero)
				global::java.security.cert.PolicyQualifierInfo._m4 = @__env.GetMethodIDNoThrow(global::java.security.cert.PolicyQualifierInfo.staticClass, "<init>", "([B)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.PolicyQualifierInfo.staticClass, global::java.security.cert.PolicyQualifierInfo._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static PolicyQualifierInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.PolicyQualifierInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/PolicyQualifierInfo"));
		}
	}
}
