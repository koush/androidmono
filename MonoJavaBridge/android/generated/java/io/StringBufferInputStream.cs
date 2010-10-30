namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StringBufferInputStream : java.io.InputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected StringBufferInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _reset19602;
		public override void reset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.StringBufferInputStream._reset19602.native == global::System.IntPtr.Zero)
				global::java.io.StringBufferInputStream._reset19602 = @__env.GetMethodIDNoThrow(global::java.io.StringBufferInputStream.staticClass, "reset", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StringBufferInputStream.staticClass, global::java.io.StringBufferInputStream._reset19602);
		}
		internal static global::MonoJavaBridge.MethodId _read19603;
		public override int read()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.StringBufferInputStream._read19603.native == global::System.IntPtr.Zero)
				global::java.io.StringBufferInputStream._read19603 = @__env.GetMethodIDNoThrow(global::java.io.StringBufferInputStream.staticClass, "read", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.StringBufferInputStream.staticClass, global::java.io.StringBufferInputStream._read19603);
		}
		internal static global::MonoJavaBridge.MethodId _read19604;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.StringBufferInputStream._read19604.native == global::System.IntPtr.Zero)
				global::java.io.StringBufferInputStream._read19604 = @__env.GetMethodIDNoThrow(global::java.io.StringBufferInputStream.staticClass, "read", "([BII)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.StringBufferInputStream.staticClass, global::java.io.StringBufferInputStream._read19604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _skip19605;
		public override long skip(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.StringBufferInputStream._skip19605.native == global::System.IntPtr.Zero)
				global::java.io.StringBufferInputStream._skip19605 = @__env.GetMethodIDNoThrow(global::java.io.StringBufferInputStream.staticClass, "skip", "(J)J");
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.StringBufferInputStream.staticClass, global::java.io.StringBufferInputStream._skip19605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available19606;
		public override int available()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.StringBufferInputStream._available19606.native == global::System.IntPtr.Zero)
				global::java.io.StringBufferInputStream._available19606 = @__env.GetMethodIDNoThrow(global::java.io.StringBufferInputStream.staticClass, "available", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.StringBufferInputStream.staticClass, global::java.io.StringBufferInputStream._available19606);
		}
		internal static global::MonoJavaBridge.MethodId _StringBufferInputStream19607;
		public StringBufferInputStream(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.StringBufferInputStream._StringBufferInputStream19607.native == global::System.IntPtr.Zero)
				global::java.io.StringBufferInputStream._StringBufferInputStream19607 = @__env.GetMethodIDNoThrow(global::java.io.StringBufferInputStream.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.StringBufferInputStream.staticClass, global::java.io.StringBufferInputStream._StringBufferInputStream19607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static StringBufferInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.StringBufferInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/StringBufferInputStream"));
		}
		internal static void InitJNI()
		{
		}
	}
}
