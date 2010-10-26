namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class KeyPair : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static KeyPair()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getPublic23036;
		public global::java.security.PublicKey getPublic() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyPair._getPublic23036)) as java.security.PublicKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyPair.staticClass, global::java.security.KeyPair._getPublic23036)) as java.security.PublicKey;
		}
		public new global::java.security.PrivateKey Private
		{
			get
			{
				return getPrivate();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPrivate23037;
		public global::java.security.PrivateKey getPrivate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PrivateKey>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyPair._getPrivate23037)) as java.security.PrivateKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PrivateKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyPair.staticClass, global::java.security.KeyPair._getPrivate23037)) as java.security.PrivateKey;
		}
		internal static global::MonoJavaBridge.MethodId _KeyPair23038;
		public KeyPair(java.security.PublicKey arg0, java.security.PrivateKey arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyPair.staticClass, global::java.security.KeyPair._KeyPair23038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyPair.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyPair"));
			global::java.security.KeyPair._getPublic23036 = @__env.GetMethodIDNoThrow(global::java.security.KeyPair.staticClass, "getPublic", "()Ljava/security/PublicKey;");
			global::java.security.KeyPair._getPrivate23037 = @__env.GetMethodIDNoThrow(global::java.security.KeyPair.staticClass, "getPrivate", "()Ljava/security/PrivateKey;");
			global::java.security.KeyPair._KeyPair23038 = @__env.GetMethodIDNoThrow(global::java.security.KeyPair.staticClass, "<init>", "(Ljava/security/PublicKey;Ljava/security/PrivateKey;)V");
		}
	}
}
