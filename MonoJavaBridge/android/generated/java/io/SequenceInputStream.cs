namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SequenceInputStream : java.io.InputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SequenceInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.SequenceInputStream.staticClass, "close", "()V", ref global::java.io.SequenceInputStream._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.SequenceInputStream.staticClass, "read", "()I", ref global::java.io.SequenceInputStream._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.SequenceInputStream.staticClass, "read", "([BII)I", ref global::java.io.SequenceInputStream._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int available()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.SequenceInputStream.staticClass, "available", "()I", ref global::java.io.SequenceInputStream._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public SequenceInputStream(java.util.Enumeration arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.SequenceInputStream._m4.native == global::System.IntPtr.Zero)
				global::java.io.SequenceInputStream._m4 = @__env.GetMethodIDNoThrow(global::java.io.SequenceInputStream.staticClass, "<init>", "(Ljava/util/Enumeration;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.SequenceInputStream.staticClass, global::java.io.SequenceInputStream._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public SequenceInputStream(java.io.InputStream arg0, java.io.InputStream arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.SequenceInputStream._m5.native == global::System.IntPtr.Zero)
				global::java.io.SequenceInputStream._m5 = @__env.GetMethodIDNoThrow(global::java.io.SequenceInputStream.staticClass, "<init>", "(Ljava/io/InputStream;Ljava/io/InputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.SequenceInputStream.staticClass, global::java.io.SequenceInputStream._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static SequenceInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.SequenceInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/SequenceInputStream"));
		}
	}
}
