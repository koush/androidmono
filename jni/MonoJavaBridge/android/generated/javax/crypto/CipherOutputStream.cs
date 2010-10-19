namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CipherOutputStream : java.io.FilterOutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CipherOutputStream()
		{
			InitJNI();
		}
		protected CipherOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write22527;
		public override void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.CipherOutputStream._write22527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.CipherOutputStream.staticClass, global::javax.crypto.CipherOutputStream._write22527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write22528;
		public override void write(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.CipherOutputStream._write22528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.CipherOutputStream.staticClass, global::javax.crypto.CipherOutputStream._write22528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write22529;
		public override void write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.CipherOutputStream._write22529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.CipherOutputStream.staticClass, global::javax.crypto.CipherOutputStream._write22529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _flush22530;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.CipherOutputStream._flush22530);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.CipherOutputStream.staticClass, global::javax.crypto.CipherOutputStream._flush22530);
		}
		internal static global::MonoJavaBridge.MethodId _close22531;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.CipherOutputStream._close22531);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.CipherOutputStream.staticClass, global::javax.crypto.CipherOutputStream._close22531);
		}
		internal static global::MonoJavaBridge.MethodId _CipherOutputStream22532;
		public CipherOutputStream(java.io.OutputStream arg0, javax.crypto.Cipher arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.CipherOutputStream.staticClass, global::javax.crypto.CipherOutputStream._CipherOutputStream22532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CipherOutputStream22533;
		protected CipherOutputStream(java.io.OutputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.CipherOutputStream.staticClass, global::javax.crypto.CipherOutputStream._CipherOutputStream22533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.CipherOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/CipherOutputStream"));
			global::javax.crypto.CipherOutputStream._write22527 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherOutputStream.staticClass, "write", "(I)V");
			global::javax.crypto.CipherOutputStream._write22528 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherOutputStream.staticClass, "write", "([B)V");
			global::javax.crypto.CipherOutputStream._write22529 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherOutputStream.staticClass, "write", "([BII)V");
			global::javax.crypto.CipherOutputStream._flush22530 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherOutputStream.staticClass, "flush", "()V");
			global::javax.crypto.CipherOutputStream._close22531 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherOutputStream.staticClass, "close", "()V");
			global::javax.crypto.CipherOutputStream._CipherOutputStream22532 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;Ljavax/crypto/Cipher;)V");
			global::javax.crypto.CipherOutputStream._CipherOutputStream22533 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
		}
	}
}
