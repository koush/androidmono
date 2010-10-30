namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SealedObject : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SealedObject(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getObject28708;
		public virtual global::java.lang.Object getObject(javax.crypto.Cipher arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.SealedObject.staticClass, "getObject", "(Ljavax/crypto/Cipher;)Ljava/lang/Object;", ref global::javax.crypto.SealedObject._getObject28708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getObject28709;
		public virtual global::java.lang.Object getObject(java.security.Key arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.SealedObject.staticClass, "getObject", "(Ljava/security/Key;)Ljava/lang/Object;", ref global::javax.crypto.SealedObject._getObject28709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getObject28710;
		public virtual global::java.lang.Object getObject(java.security.Key arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.SealedObject.staticClass, "getObject", "(Ljava/security/Key;Ljava/lang/String;)Ljava/lang/Object;", ref global::javax.crypto.SealedObject._getObject28710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm28711;
		public virtual global::java.lang.String getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.crypto.SealedObject.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::javax.crypto.SealedObject._getAlgorithm28711) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _SealedObject28712;
		public SealedObject(java.io.Serializable arg0, javax.crypto.Cipher arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.SealedObject._SealedObject28712.native == global::System.IntPtr.Zero)
				global::javax.crypto.SealedObject._SealedObject28712 = @__env.GetMethodIDNoThrow(global::javax.crypto.SealedObject.staticClass, "<init>", "(Ljava/io/Serializable;Ljavax/crypto/Cipher;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.SealedObject.staticClass, global::javax.crypto.SealedObject._SealedObject28712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SealedObject28713;
		protected SealedObject(javax.crypto.SealedObject arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.SealedObject._SealedObject28713.native == global::System.IntPtr.Zero)
				global::javax.crypto.SealedObject._SealedObject28713 = @__env.GetMethodIDNoThrow(global::javax.crypto.SealedObject.staticClass, "<init>", "(Ljavax/crypto/SealedObject;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.SealedObject.staticClass, global::javax.crypto.SealedObject._SealedObject28713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static SealedObject()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.SealedObject.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/SealedObject"));
		}
		internal static void InitJNI()
		{
		}
	}
}
