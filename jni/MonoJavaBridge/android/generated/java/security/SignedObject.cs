namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class SignedObject : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SignedObject()
		{
			InitJNI();
		}
		internal SignedObject(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.Object Object
		{
			get
			{
				return getObject();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getObject23279;
		public global::java.lang.Object getObject() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.SignedObject._getObject23279)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.SignedObject.staticClass, global::java.security.SignedObject._getObject23279)) as java.lang.Object;
		}
		public new byte[] Signature
		{
			get
			{
				return getSignature();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSignature23280;
		public byte[] getSignature() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.SignedObject._getSignature23280)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.SignedObject.staticClass, global::java.security.SignedObject._getSignature23280)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _verify23281;
		public bool verify(java.security.PublicKey arg0, java.security.Signature arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.SignedObject._verify23281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.SignedObject.staticClass, global::java.security.SignedObject._verify23281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm23282;
		public global::java.lang.String getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.SignedObject._getAlgorithm23282)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.SignedObject.staticClass, global::java.security.SignedObject._getAlgorithm23282)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _SignedObject23283;
		public SignedObject(java.io.Serializable arg0, java.security.PrivateKey arg1, java.security.Signature arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.SignedObject.staticClass, global::java.security.SignedObject._SignedObject23283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.SignedObject.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/SignedObject"));
			global::java.security.SignedObject._getObject23279 = @__env.GetMethodIDNoThrow(global::java.security.SignedObject.staticClass, "getObject", "()Ljava/lang/Object;");
			global::java.security.SignedObject._getSignature23280 = @__env.GetMethodIDNoThrow(global::java.security.SignedObject.staticClass, "getSignature", "()[B");
			global::java.security.SignedObject._verify23281 = @__env.GetMethodIDNoThrow(global::java.security.SignedObject.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/security/Signature;)Z");
			global::java.security.SignedObject._getAlgorithm23282 = @__env.GetMethodIDNoThrow(global::java.security.SignedObject.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::java.security.SignedObject._SignedObject23283 = @__env.GetMethodIDNoThrow(global::java.security.SignedObject.staticClass, "<init>", "(Ljava/io/Serializable;Ljava/security/PrivateKey;Ljava/security/Signature;)V");
		}
	}
}
