namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class SignedObject : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
		internal static global::MonoJavaBridge.MethodId _getObject23398;
		public global::java.lang.Object getObject()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.SignedObject.staticClass, "getObject", "()Ljava/lang/Object;", ref global::java.security.SignedObject._getObject23398) as java.lang.Object;
		}
		public new byte[] Signature
		{
			get
			{
				return getSignature();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSignature23399;
		public byte[] getSignature()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.SignedObject.staticClass, "getSignature", "()[B", ref global::java.security.SignedObject._getSignature23399) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _verify23400;
		public bool verify(java.security.PublicKey arg0, java.security.Signature arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.SignedObject.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/security/Signature;)Z", ref global::java.security.SignedObject._verify23400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm23401;
		public global::java.lang.String getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.SignedObject.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::java.security.SignedObject._getAlgorithm23401) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _SignedObject23402;
		public SignedObject(java.io.Serializable arg0, java.security.PrivateKey arg1, java.security.Signature arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.SignedObject._SignedObject23402.native == global::System.IntPtr.Zero)
				global::java.security.SignedObject._SignedObject23402 = @__env.GetMethodIDNoThrow(global::java.security.SignedObject.staticClass, "<init>", "(Ljava/io/Serializable;Ljava/security/PrivateKey;Ljava/security/Signature;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.SignedObject.staticClass, global::java.security.SignedObject._SignedObject23402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static SignedObject()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.SignedObject.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/SignedObject"));
		}
		internal static void InitJNI()
		{
		}
	}
}
