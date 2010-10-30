namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CipherOutputStream : java.io.FilterOutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CipherOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write28542;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.CipherOutputStream._write28542.native == global::System.IntPtr.Zero)
				global::javax.crypto.CipherOutputStream._write28542 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherOutputStream.staticClass, "write", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.CipherOutputStream.staticClass, global::javax.crypto.CipherOutputStream._write28542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write28543;
		public override void write(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.CipherOutputStream._write28543.native == global::System.IntPtr.Zero)
				global::javax.crypto.CipherOutputStream._write28543 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherOutputStream.staticClass, "write", "([B)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.CipherOutputStream.staticClass, global::javax.crypto.CipherOutputStream._write28543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write28544;
		public override void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.CipherOutputStream._write28544.native == global::System.IntPtr.Zero)
				global::javax.crypto.CipherOutputStream._write28544 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherOutputStream.staticClass, "write", "([BII)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.CipherOutputStream.staticClass, global::javax.crypto.CipherOutputStream._write28544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _flush28545;
		public override void flush()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.CipherOutputStream._flush28545.native == global::System.IntPtr.Zero)
				global::javax.crypto.CipherOutputStream._flush28545 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherOutputStream.staticClass, "flush", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.CipherOutputStream.staticClass, global::javax.crypto.CipherOutputStream._flush28545);
		}
		internal static global::MonoJavaBridge.MethodId _close28546;
		public override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.CipherOutputStream._close28546.native == global::System.IntPtr.Zero)
				global::javax.crypto.CipherOutputStream._close28546 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherOutputStream.staticClass, "close", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.CipherOutputStream.staticClass, global::javax.crypto.CipherOutputStream._close28546);
		}
		internal static global::MonoJavaBridge.MethodId _CipherOutputStream28547;
		public CipherOutputStream(java.io.OutputStream arg0, javax.crypto.Cipher arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.CipherOutputStream._CipherOutputStream28547.native == global::System.IntPtr.Zero)
				global::javax.crypto.CipherOutputStream._CipherOutputStream28547 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;Ljavax/crypto/Cipher;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.CipherOutputStream.staticClass, global::javax.crypto.CipherOutputStream._CipherOutputStream28547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CipherOutputStream28548;
		protected CipherOutputStream(java.io.OutputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.CipherOutputStream._CipherOutputStream28548.native == global::System.IntPtr.Zero)
				global::javax.crypto.CipherOutputStream._CipherOutputStream28548 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.CipherOutputStream.staticClass, global::javax.crypto.CipherOutputStream._CipherOutputStream28548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static CipherOutputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.CipherOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/CipherOutputStream"));
		}
		internal static void InitJNI()
		{
		}
	}
}
