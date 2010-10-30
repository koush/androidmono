namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PolicyQualifierInfo : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PolicyQualifierInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString23687;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.PolicyQualifierInfo.staticClass, global::java.security.cert.PolicyQualifierInfo._toString23687)) as java.lang.String;
		}
		public new byte[] Encoded
		{
			get
			{
				return getEncoded();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23688;
		public virtual byte[] getEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.PolicyQualifierInfo.staticClass, global::java.security.cert.PolicyQualifierInfo._getEncoded23688)) as byte[];
		}
		public new global::java.lang.String PolicyQualifierId
		{
			get
			{
				return getPolicyQualifierId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPolicyQualifierId23689;
		public virtual global::java.lang.String getPolicyQualifierId()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.PolicyQualifierInfo.staticClass, global::java.security.cert.PolicyQualifierInfo._getPolicyQualifierId23689)) as java.lang.String;
		}
		public new byte[] PolicyQualifier
		{
			get
			{
				return getPolicyQualifier();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPolicyQualifier23690;
		public virtual byte[] getPolicyQualifier()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.PolicyQualifierInfo.staticClass, global::java.security.cert.PolicyQualifierInfo._getPolicyQualifier23690)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _PolicyQualifierInfo23691;
		public PolicyQualifierInfo(byte[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.PolicyQualifierInfo.staticClass, global::java.security.cert.PolicyQualifierInfo._PolicyQualifierInfo23691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static PolicyQualifierInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.PolicyQualifierInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/PolicyQualifierInfo"));
			global::java.security.cert.PolicyQualifierInfo._toString23687 = @__env.GetMethodIDNoThrow(global::java.security.cert.PolicyQualifierInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.PolicyQualifierInfo._getEncoded23688 = @__env.GetMethodIDNoThrow(global::java.security.cert.PolicyQualifierInfo.staticClass, "getEncoded", "()[B");
			global::java.security.cert.PolicyQualifierInfo._getPolicyQualifierId23689 = @__env.GetMethodIDNoThrow(global::java.security.cert.PolicyQualifierInfo.staticClass, "getPolicyQualifierId", "()Ljava/lang/String;");
			global::java.security.cert.PolicyQualifierInfo._getPolicyQualifier23690 = @__env.GetMethodIDNoThrow(global::java.security.cert.PolicyQualifierInfo.staticClass, "getPolicyQualifier", "()[B");
			global::java.security.cert.PolicyQualifierInfo._PolicyQualifierInfo23691 = @__env.GetMethodIDNoThrow(global::java.security.cert.PolicyQualifierInfo.staticClass, "<init>", "([B)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
