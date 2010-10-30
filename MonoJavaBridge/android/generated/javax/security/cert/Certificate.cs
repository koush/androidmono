namespace javax.security.cert
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.security.cert.Certificate_))]
	public abstract partial class Certificate : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Certificate(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals30224;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.security.cert.Certificate.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::javax.security.cert.Certificate._equals30224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString30225;
		public abstract global::java.lang.String toString();
		internal static global::MonoJavaBridge.MethodId _hashCode30226;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.security.cert.Certificate.staticClass, "hashCode", "()I", ref global::javax.security.cert.Certificate._hashCode30226);
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded30227;
		public abstract byte[] getEncoded();
		internal static global::MonoJavaBridge.MethodId _verify30228;
		public abstract void verify(java.security.PublicKey arg0);
		internal static global::MonoJavaBridge.MethodId _verify30229;
		public abstract void verify(java.security.PublicKey arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _getPublicKey30230;
		public abstract global::java.security.PublicKey getPublicKey();
		internal static global::MonoJavaBridge.MethodId _Certificate30231;
		public Certificate() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.cert.Certificate._Certificate30231.native == global::System.IntPtr.Zero)
				global::javax.security.cert.Certificate._Certificate30231 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.cert.Certificate.staticClass, global::javax.security.cert.Certificate._Certificate30231);
			Init(@__env, handle);
		}
		static Certificate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.cert.Certificate.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/cert/Certificate"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.security.cert.Certificate))]
	internal sealed partial class Certificate_ : javax.security.cert.Certificate
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Certificate_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString30232;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.security.cert.Certificate_.staticClass, "toString", "()Ljava/lang/String;", ref global::javax.security.cert.Certificate_._toString30232) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded30233;
		public override byte[] getEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.security.cert.Certificate_.staticClass, "getEncoded", "()[B", ref global::javax.security.cert.Certificate_._getEncoded30233) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _verify30234;
		public override void verify(java.security.PublicKey arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.security.cert.Certificate_.staticClass, "verify", "(Ljava/security/PublicKey;)V", ref global::javax.security.cert.Certificate_._verify30234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verify30235;
		public override void verify(java.security.PublicKey arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.security.cert.Certificate_.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V", ref global::javax.security.cert.Certificate_._verify30235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPublicKey30236;
		public override global::java.security.PublicKey getPublicKey()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.PublicKey>(this, global::javax.security.cert.Certificate_.staticClass, "getPublicKey", "()Ljava/security/PublicKey;", ref global::javax.security.cert.Certificate_._getPublicKey30236) as java.security.PublicKey;
		}
		static Certificate_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.cert.Certificate_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/cert/Certificate"));
		}
		internal static void InitJNI()
		{
		}
	}
}
