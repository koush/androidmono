namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InflaterInputStream : java.io.FilterInputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InflaterInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.InflaterInputStream.staticClass, "close", "()V", ref global::java.util.zip.InflaterInputStream._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void mark(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.InflaterInputStream.staticClass, "mark", "(I)V", ref global::java.util.zip.InflaterInputStream._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.InflaterInputStream.staticClass, "reset", "()V", ref global::java.util.zip.InflaterInputStream._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected virtual void fill()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.InflaterInputStream.staticClass, "fill", "()V", ref global::java.util.zip.InflaterInputStream._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.InflaterInputStream.staticClass, "read", "([BII)I", ref global::java.util.zip.InflaterInputStream._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.InflaterInputStream.staticClass, "read", "()I", ref global::java.util.zip.InflaterInputStream._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override long skip(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.zip.InflaterInputStream.staticClass, "skip", "(J)J", ref global::java.util.zip.InflaterInputStream._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override int available()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.InflaterInputStream.staticClass, "available", "()I", ref global::java.util.zip.InflaterInputStream._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override bool markSupported()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.zip.InflaterInputStream.staticClass, "markSupported", "()Z", ref global::java.util.zip.InflaterInputStream._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public InflaterInputStream(java.io.InputStream arg0, java.util.zip.Inflater arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.InflaterInputStream._m9.native == global::System.IntPtr.Zero)
				global::java.util.zip.InflaterInputStream._m9 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "<init>", "(Ljava/io/InputStream;Ljava/util/zip/Inflater;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public InflaterInputStream(java.io.InputStream arg0, java.util.zip.Inflater arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.InflaterInputStream._m10.native == global::System.IntPtr.Zero)
				global::java.util.zip.InflaterInputStream._m10 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "<init>", "(Ljava/io/InputStream;Ljava/util/zip/Inflater;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public InflaterInputStream(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.InflaterInputStream._m11.native == global::System.IntPtr.Zero)
				global::java.util.zip.InflaterInputStream._m11 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static InflaterInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.InflaterInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/InflaterInputStream"));
		}
	}
}
