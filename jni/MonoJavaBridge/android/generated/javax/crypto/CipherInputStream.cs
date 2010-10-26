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
		internal static global::MonoJavaBridge.MethodId _close28532;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.CipherInputStream._close28532);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.CipherInputStream.staticClass, global::javax.crypto.CipherInputStream._close28532);
		}
		internal static global::MonoJavaBridge.MethodId _read28533;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.CipherInputStream._read28533);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.CipherInputStream.staticClass, global::javax.crypto.CipherInputStream._read28533);
		}
		internal static global::MonoJavaBridge.MethodId _read28534;
		public override int read(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.CipherInputStream._read28534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.CipherInputStream.staticClass, global::javax.crypto.CipherInputStream._read28534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read28535;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.CipherInputStream._read28535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.CipherInputStream.staticClass, global::javax.crypto.CipherInputStream._read28535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _skip28536;
		public override long skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::javax.crypto.CipherInputStream._skip28536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::javax.crypto.CipherInputStream.staticClass, global::javax.crypto.CipherInputStream._skip28536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available28537;
		public override int available() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.CipherInputStream._available28537);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.CipherInputStream.staticClass, global::javax.crypto.CipherInputStream._available28537);
		}
		internal static global::MonoJavaBridge.MethodId _markSupported28538;
		public override bool markSupported() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.crypto.CipherInputStream._markSupported28538);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.crypto.CipherInputStream.staticClass, global::javax.crypto.CipherInputStream._markSupported28538);
		}
		internal static global::MonoJavaBridge.MethodId _CipherInputStream28539;
		public CipherInputStream(java.io.InputStream arg0, javax.crypto.Cipher arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.CipherInputStream.staticClass, global::javax.crypto.CipherInputStream._CipherInputStream28539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CipherInputStream28540;
		protected CipherInputStream(java.io.InputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.CipherInputStream.staticClass, global::javax.crypto.CipherInputStream._CipherInputStream28540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.CipherInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/CipherInputStream"));
			global::javax.crypto.CipherInputStream._close28532 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherInputStream.staticClass, "close", "()V");
			global::javax.crypto.CipherInputStream._read28533 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherInputStream.staticClass, "read", "()I");
			global::javax.crypto.CipherInputStream._read28534 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherInputStream.staticClass, "read", "([B)I");
			global::javax.crypto.CipherInputStream._read28535 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherInputStream.staticClass, "read", "([BII)I");
			global::javax.crypto.CipherInputStream._skip28536 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherInputStream.staticClass, "skip", "(J)J");
			global::javax.crypto.CipherInputStream._available28537 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherInputStream.staticClass, "available", "()I");
			global::javax.crypto.CipherInputStream._markSupported28538 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherInputStream.staticClass, "markSupported", "()Z");
			global::javax.crypto.CipherInputStream._CipherInputStream28539 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherInputStream.staticClass, "<init>", "(Ljava/io/InputStream;Ljavax/crypto/Cipher;)V");
			global::javax.crypto.CipherInputStream._CipherInputStream28540 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
		}
	}
}
