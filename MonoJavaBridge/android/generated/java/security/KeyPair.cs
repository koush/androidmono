namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class KeyPair : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal KeyPair(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.security.PublicKey Public
		{
			get
			{
				return getPublic();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public global::java.security.PublicKey getPublic()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.PublicKey>(this, global::java.security.KeyPair.staticClass, "getPublic", "()Ljava/security/PublicKey;", ref global::java.security.KeyPair._m0) as java.security.PublicKey;
		}
		public new global::java.security.PrivateKey Private
		{
			get
			{
				return getPrivate();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public global::java.security.PrivateKey getPrivate()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.PrivateKey>(this, global::java.security.KeyPair.staticClass, "getPrivate", "()Ljava/security/PrivateKey;", ref global::java.security.KeyPair._m1) as java.security.PrivateKey;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public KeyPair(java.security.PublicKey arg0, java.security.PrivateKey arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyPair._m2.native == global::System.IntPtr.Zero)
				global::java.security.KeyPair._m2 = @__env.GetMethodIDNoThrow(global::java.security.KeyPair.staticClass, "<init>", "(Ljava/security/PublicKey;Ljava/security/PrivateKey;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyPair.staticClass, global::java.security.KeyPair._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static KeyPair()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyPair.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyPair"));
		}
	}
}
