namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CipherInputStream : java.io.FilterInputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CipherInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close28533;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.CipherInputStream.staticClass, global::javax.crypto.CipherInputStream._close28533);
		}
		internal static global::MonoJavaBridge.MethodId _read28534;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.CipherInputStream.staticClass, global::javax.crypto.CipherInputStream._read28534);
		}
		internal static global::MonoJavaBridge.MethodId _read28535;
		public override int read(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.CipherInputStream.staticClass, global::javax.crypto.CipherInputStream._read28535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read28536;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.CipherInputStream.staticClass, global::javax.crypto.CipherInputStream._read28536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _skip28537;
		public override long skip(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::javax.crypto.CipherInputStream.staticClass, global::javax.crypto.CipherInputStream._skip28537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available28538;
		public override int available()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.CipherInputStream.staticClass, global::javax.crypto.CipherInputStream._available28538);
		}
		internal static global::MonoJavaBridge.MethodId _markSupported28539;
		public override bool markSupported()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.crypto.CipherInputStream.staticClass, global::javax.crypto.CipherInputStream._markSupported28539);
		}
		internal static global::MonoJavaBridge.MethodId _CipherInputStream28540;
		public CipherInputStream(java.io.InputStream arg0, javax.crypto.Cipher arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.CipherInputStream.staticClass, global::javax.crypto.CipherInputStream._CipherInputStream28540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CipherInputStream28541;
		protected CipherInputStream(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.CipherInputStream.staticClass, global::javax.crypto.CipherInputStream._CipherInputStream28541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static CipherInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.CipherInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/CipherInputStream"));
			global::javax.crypto.CipherInputStream._close28533 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherInputStream.staticClass, "close", "()V");
			global::javax.crypto.CipherInputStream._read28534 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherInputStream.staticClass, "read", "()I");
			global::javax.crypto.CipherInputStream._read28535 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherInputStream.staticClass, "read", "([B)I");
			global::javax.crypto.CipherInputStream._read28536 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherInputStream.staticClass, "read", "([BII)I");
			global::javax.crypto.CipherInputStream._skip28537 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherInputStream.staticClass, "skip", "(J)J");
			global::javax.crypto.CipherInputStream._available28538 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherInputStream.staticClass, "available", "()I");
			global::javax.crypto.CipherInputStream._markSupported28539 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherInputStream.staticClass, "markSupported", "()Z");
			global::javax.crypto.CipherInputStream._CipherInputStream28540 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherInputStream.staticClass, "<init>", "(Ljava/io/InputStream;Ljavax/crypto/Cipher;)V");
			global::javax.crypto.CipherInputStream._CipherInputStream28541 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
