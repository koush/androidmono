namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PushbackInputStream : java.io.FilterInputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PushbackInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PushbackInputStream.staticClass, "close", "()V", ref global::java.io.PushbackInputStream._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void mark(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PushbackInputStream.staticClass, "mark", "(I)V", ref global::java.io.PushbackInputStream._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PushbackInputStream.staticClass, "reset", "()V", ref global::java.io.PushbackInputStream._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.PushbackInputStream.staticClass, "read", "()I", ref global::java.io.PushbackInputStream._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.PushbackInputStream.staticClass, "read", "([BII)I", ref global::java.io.PushbackInputStream._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override long skip(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.PushbackInputStream.staticClass, "skip", "(J)J", ref global::java.io.PushbackInputStream._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override int available()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.PushbackInputStream.staticClass, "available", "()I", ref global::java.io.PushbackInputStream._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override bool markSupported()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.PushbackInputStream.staticClass, "markSupported", "()Z", ref global::java.io.PushbackInputStream._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void unread(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PushbackInputStream.staticClass, "unread", "([B)V", ref global::java.io.PushbackInputStream._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void unread(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PushbackInputStream.staticClass, "unread", "([BII)V", ref global::java.io.PushbackInputStream._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void unread(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PushbackInputStream.staticClass, "unread", "(I)V", ref global::java.io.PushbackInputStream._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public PushbackInputStream(java.io.InputStream arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PushbackInputStream._m11.native == global::System.IntPtr.Zero)
				global::java.io.PushbackInputStream._m11 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "<init>", "(Ljava/io/InputStream;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public PushbackInputStream(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PushbackInputStream._m12.native == global::System.IntPtr.Zero)
				global::java.io.PushbackInputStream._m12 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static PushbackInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.PushbackInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/PushbackInputStream"));
		}
	}
}
