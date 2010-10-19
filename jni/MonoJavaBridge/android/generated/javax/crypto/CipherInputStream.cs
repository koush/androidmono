namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CipherInputStream : java.io.FilterInputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CipherInputStream()
		{
			InitJNI();
		}
		protected CipherInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close22518;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.CipherInputStream._close22518);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.CipherInputStream.staticClass, global::javax.crypto.CipherInputStream._close22518);
		}
		internal static global::MonoJavaBridge.MethodId _read22519;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.CipherInputStream._read22519);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.CipherInputStream.staticClass, global::javax.crypto.CipherInputStream._read22519);
		}
		internal static global::MonoJavaBridge.MethodId _read22520;
		public override int read(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.CipherInputStream._read22520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.CipherInputStream.staticClass, global::javax.crypto.CipherInputStream._read22520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read22521;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.CipherInputStream._read22521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.CipherInputStream.staticClass, global::javax.crypto.CipherInputStream._read22521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _skip22522;
		public override long skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::javax.crypto.CipherInputStream._skip22522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::javax.crypto.CipherInputStream.staticClass, global::javax.crypto.CipherInputStream._skip22522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available22523;
		public override int available() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.CipherInputStream._available22523);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.CipherInputStream.staticClass, global::javax.crypto.CipherInputStream._available22523);
		}
		internal static global::MonoJavaBridge.MethodId _markSupported22524;
		public override bool markSupported() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.crypto.CipherInputStream._markSupported22524);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.crypto.CipherInputStream.staticClass, global::javax.crypto.CipherInputStream._markSupported22524);
		}
		internal static global::MonoJavaBridge.MethodId _CipherInputStream22525;
		public CipherInputStream(java.io.InputStream arg0, javax.crypto.Cipher arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.CipherInputStream.staticClass, global::javax.crypto.CipherInputStream._CipherInputStream22525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CipherInputStream22526;
		protected CipherInputStream(java.io.InputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.CipherInputStream.staticClass, global::javax.crypto.CipherInputStream._CipherInputStream22526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.CipherInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/CipherInputStream"));
			global::javax.crypto.CipherInputStream._close22518 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherInputStream.staticClass, "close", "()V");
			global::javax.crypto.CipherInputStream._read22519 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherInputStream.staticClass, "read", "()I");
			global::javax.crypto.CipherInputStream._read22520 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherInputStream.staticClass, "read", "([B)I");
			global::javax.crypto.CipherInputStream._read22521 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherInputStream.staticClass, "read", "([BII)I");
			global::javax.crypto.CipherInputStream._skip22522 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherInputStream.staticClass, "skip", "(J)J");
			global::javax.crypto.CipherInputStream._available22523 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherInputStream.staticClass, "available", "()I");
			global::javax.crypto.CipherInputStream._markSupported22524 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherInputStream.staticClass, "markSupported", "()Z");
			global::javax.crypto.CipherInputStream._CipherInputStream22525 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherInputStream.staticClass, "<init>", "(Ljava/io/InputStream;Ljavax/crypto/Cipher;)V");
			global::javax.crypto.CipherInputStream._CipherInputStream22526 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
		}
	}
}
