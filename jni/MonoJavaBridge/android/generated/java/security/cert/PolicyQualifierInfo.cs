namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PolicyQualifierInfo : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PolicyQualifierInfo()
		{
			InitJNI();
		}
		protected PolicyQualifierInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString17967;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.PolicyQualifierInfo._toString17967)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.PolicyQualifierInfo.staticClass, global::java.security.cert.PolicyQualifierInfo._toString17967)) as java.lang.String;
		}
		public new byte[] Encoded
		{
			get
			{
				return getEncoded();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded17968;
		public virtual byte[] getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.PolicyQualifierInfo._getEncoded17968)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.PolicyQualifierInfo.staticClass, global::java.security.cert.PolicyQualifierInfo._getEncoded17968)) as byte[];
		}
		public new global::java.lang.String PolicyQualifierId
		{
			get
			{
				return getPolicyQualifierId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPolicyQualifierId17969;
		public virtual global::java.lang.String getPolicyQualifierId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.PolicyQualifierInfo._getPolicyQualifierId17969)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.PolicyQualifierInfo.staticClass, global::java.security.cert.PolicyQualifierInfo._getPolicyQualifierId17969)) as java.lang.String;
		}
		public new byte[] PolicyQualifier
		{
			get
			{
				return getPolicyQualifier();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPolicyQualifier17970;
		public virtual byte[] getPolicyQualifier() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.PolicyQualifierInfo._getPolicyQualifier17970)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.PolicyQualifierInfo.staticClass, global::java.security.cert.PolicyQualifierInfo._getPolicyQualifier17970)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _PolicyQualifierInfo17971;
		public PolicyQualifierInfo(byte[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.PolicyQualifierInfo.staticClass, global::java.security.cert.PolicyQualifierInfo._PolicyQualifierInfo17971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.PolicyQualifierInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/PolicyQualifierInfo"));
			global::java.security.cert.PolicyQualifierInfo._toString17967 = @__env.GetMethodIDNoThrow(global::java.security.cert.PolicyQualifierInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.PolicyQualifierInfo._getEncoded17968 = @__env.GetMethodIDNoThrow(global::java.security.cert.PolicyQualifierInfo.staticClass, "getEncoded", "()[B");
			global::java.security.cert.PolicyQualifierInfo._getPolicyQualifierId17969 = @__env.GetMethodIDNoThrow(global::java.security.cert.PolicyQualifierInfo.staticClass, "getPolicyQualifierId", "()Ljava/lang/String;");
			global::java.security.cert.PolicyQualifierInfo._getPolicyQualifier17970 = @__env.GetMethodIDNoThrow(global::java.security.cert.PolicyQualifierInfo.staticClass, "getPolicyQualifier", "()[B");
			global::java.security.cert.PolicyQualifierInfo._PolicyQualifierInfo17971 = @__env.GetMethodIDNoThrow(global::java.security.cert.PolicyQualifierInfo.staticClass, "<init>", "([B)V");
		}
	}
}
