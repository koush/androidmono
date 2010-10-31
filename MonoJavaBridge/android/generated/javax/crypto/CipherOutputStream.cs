namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CipherOutputStream : java.io.FilterOutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CipherOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.CipherOutputStream.staticClass, "write", "(I)V", ref global::javax.crypto.CipherOutputStream._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void write(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.CipherOutputStream.staticClass, "write", "([B)V", ref global::javax.crypto.CipherOutputStream._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.CipherOutputStream.staticClass, "write", "([BII)V", ref global::javax.crypto.CipherOutputStream._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.CipherOutputStream.staticClass, "flush", "()V", ref global::javax.crypto.CipherOutputStream._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.CipherOutputStream.staticClass, "close", "()V", ref global::javax.crypto.CipherOutputStream._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public CipherOutputStream(java.io.OutputStream arg0, javax.crypto.Cipher arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.CipherOutputStream._m5.native == global::System.IntPtr.Zero)
				global::javax.crypto.CipherOutputStream._m5 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;Ljavax/crypto/Cipher;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.CipherOutputStream.staticClass, global::javax.crypto.CipherOutputStream._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected CipherOutputStream(java.io.OutputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.CipherOutputStream._m6.native == global::System.IntPtr.Zero)
				global::javax.crypto.CipherOutputStream._m6 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.CipherOutputStream.staticClass, global::javax.crypto.CipherOutputStream._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static CipherOutputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.CipherOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/CipherOutputStream"));
		}
	}
}
