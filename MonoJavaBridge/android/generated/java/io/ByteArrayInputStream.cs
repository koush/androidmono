namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ByteArrayInputStream : java.io.InputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ByteArrayInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ByteArrayInputStream.staticClass, "close", "()V", ref global::java.io.ByteArrayInputStream._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void mark(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ByteArrayInputStream.staticClass, "mark", "(I)V", ref global::java.io.ByteArrayInputStream._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ByteArrayInputStream.staticClass, "reset", "()V", ref global::java.io.ByteArrayInputStream._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ByteArrayInputStream.staticClass, "read", "()I", ref global::java.io.ByteArrayInputStream._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ByteArrayInputStream.staticClass, "read", "([BII)I", ref global::java.io.ByteArrayInputStream._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override long skip(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.ByteArrayInputStream.staticClass, "skip", "(J)J", ref global::java.io.ByteArrayInputStream._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override int available()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ByteArrayInputStream.staticClass, "available", "()I", ref global::java.io.ByteArrayInputStream._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override bool markSupported()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.ByteArrayInputStream.staticClass, "markSupported", "()Z", ref global::java.io.ByteArrayInputStream._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public ByteArrayInputStream(byte[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ByteArrayInputStream._m8.native == global::System.IntPtr.Zero)
				global::java.io.ByteArrayInputStream._m8 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayInputStream.staticClass, "<init>", "([B)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ByteArrayInputStream.staticClass, global::java.io.ByteArrayInputStream._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public ByteArrayInputStream(byte[] arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ByteArrayInputStream._m9.native == global::System.IntPtr.Zero)
				global::java.io.ByteArrayInputStream._m9 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayInputStream.staticClass, "<init>", "([BII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ByteArrayInputStream.staticClass, global::java.io.ByteArrayInputStream._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static ByteArrayInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ByteArrayInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ByteArrayInputStream"));
		}
	}
}
