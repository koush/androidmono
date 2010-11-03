namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StringBufferInputStream : java.io.InputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected StringBufferInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StringBufferInputStream.staticClass, "reset", "()V", ref global::java.io.StringBufferInputStream._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.StringBufferInputStream.staticClass, "read", "()I", ref global::java.io.StringBufferInputStream._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.StringBufferInputStream.staticClass, "read", "([BII)I", ref global::java.io.StringBufferInputStream._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override long skip(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.StringBufferInputStream.staticClass, "skip", "(J)J", ref global::java.io.StringBufferInputStream._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int available()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.StringBufferInputStream.staticClass, "available", "()I", ref global::java.io.StringBufferInputStream._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public StringBufferInputStream(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.StringBufferInputStream._m5.native == global::System.IntPtr.Zero)
				global::java.io.StringBufferInputStream._m5 = @__env.GetMethodIDNoThrow(global::java.io.StringBufferInputStream.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.StringBufferInputStream.staticClass, global::java.io.StringBufferInputStream._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static StringBufferInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.StringBufferInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/StringBufferInputStream"));
		}
	}
}
