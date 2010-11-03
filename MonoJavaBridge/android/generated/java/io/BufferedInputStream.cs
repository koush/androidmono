namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BufferedInputStream : java.io.FilterInputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BufferedInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.BufferedInputStream.staticClass, "close", "()V", ref global::java.io.BufferedInputStream._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void mark(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.BufferedInputStream.staticClass, "mark", "(I)V", ref global::java.io.BufferedInputStream._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.BufferedInputStream.staticClass, "reset", "()V", ref global::java.io.BufferedInputStream._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.BufferedInputStream.staticClass, "read", "([BII)I", ref global::java.io.BufferedInputStream._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.BufferedInputStream.staticClass, "read", "()I", ref global::java.io.BufferedInputStream._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override long skip(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.BufferedInputStream.staticClass, "skip", "(J)J", ref global::java.io.BufferedInputStream._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override int available()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.BufferedInputStream.staticClass, "available", "()I", ref global::java.io.BufferedInputStream._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override bool markSupported()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.BufferedInputStream.staticClass, "markSupported", "()Z", ref global::java.io.BufferedInputStream._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public BufferedInputStream(java.io.InputStream arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.BufferedInputStream._m8.native == global::System.IntPtr.Zero)
				global::java.io.BufferedInputStream._m8 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "<init>", "(Ljava/io/InputStream;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public BufferedInputStream(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.BufferedInputStream._m9.native == global::System.IntPtr.Zero)
				global::java.io.BufferedInputStream._m9 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static BufferedInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.BufferedInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/BufferedInputStream"));
		}
	}
}
