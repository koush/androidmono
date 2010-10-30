namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CipherInputStream : java.io.FilterInputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CipherInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.CipherInputStream.staticClass, "close", "()V", ref global::javax.crypto.CipherInputStream._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.CipherInputStream.staticClass, "read", "()I", ref global::javax.crypto.CipherInputStream._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int read(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.CipherInputStream.staticClass, "read", "([B)I", ref global::javax.crypto.CipherInputStream._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.CipherInputStream.staticClass, "read", "([BII)I", ref global::javax.crypto.CipherInputStream._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override long skip(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::javax.crypto.CipherInputStream.staticClass, "skip", "(J)J", ref global::javax.crypto.CipherInputStream._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override int available()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.CipherInputStream.staticClass, "available", "()I", ref global::javax.crypto.CipherInputStream._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override bool markSupported()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.crypto.CipherInputStream.staticClass, "markSupported", "()Z", ref global::javax.crypto.CipherInputStream._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public CipherInputStream(java.io.InputStream arg0, javax.crypto.Cipher arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.CipherInputStream._m7.native == global::System.IntPtr.Zero)
				global::javax.crypto.CipherInputStream._m7 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherInputStream.staticClass, "<init>", "(Ljava/io/InputStream;Ljavax/crypto/Cipher;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.CipherInputStream.staticClass, global::javax.crypto.CipherInputStream._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected CipherInputStream(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.CipherInputStream._m8.native == global::System.IntPtr.Zero)
				global::javax.crypto.CipherInputStream._m8 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.CipherInputStream.staticClass, global::javax.crypto.CipherInputStream._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static CipherInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.CipherInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/CipherInputStream"));
		}
		internal static void InitJNI()
		{
		}
	}
}
