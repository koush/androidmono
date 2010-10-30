namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FilterInputStream : java.io.InputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FilterInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FilterInputStream.staticClass, "close", "()V", ref global::java.io.FilterInputStream._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void mark(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FilterInputStream.staticClass, "mark", "(I)V", ref global::java.io.FilterInputStream._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FilterInputStream.staticClass, "reset", "()V", ref global::java.io.FilterInputStream._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.FilterInputStream.staticClass, "read", "([BII)I", ref global::java.io.FilterInputStream._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int read(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.FilterInputStream.staticClass, "read", "([B)I", ref global::java.io.FilterInputStream._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.FilterInputStream.staticClass, "read", "()I", ref global::java.io.FilterInputStream._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override long skip(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.FilterInputStream.staticClass, "skip", "(J)J", ref global::java.io.FilterInputStream._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override int available()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.FilterInputStream.staticClass, "available", "()I", ref global::java.io.FilterInputStream._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override bool markSupported()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.FilterInputStream.staticClass, "markSupported", "()Z", ref global::java.io.FilterInputStream._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected FilterInputStream(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FilterInputStream._m9.native == global::System.IntPtr.Zero)
				global::java.io.FilterInputStream._m9 = @__env.GetMethodIDNoThrow(global::java.io.FilterInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static FilterInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FilterInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FilterInputStream"));
		}
		internal static void InitJNI()
		{
		}
	}
}
