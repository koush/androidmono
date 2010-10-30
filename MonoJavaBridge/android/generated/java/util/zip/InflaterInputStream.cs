namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InflaterInputStream : java.io.FilterInputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InflaterInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close28421;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.InflaterInputStream.staticClass, "close", "()V", ref global::java.util.zip.InflaterInputStream._close28421);
		}
		internal static global::MonoJavaBridge.MethodId _mark28422;
		public override void mark(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.InflaterInputStream.staticClass, "mark", "(I)V", ref global::java.util.zip.InflaterInputStream._mark28422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset28423;
		public override void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.InflaterInputStream.staticClass, "reset", "()V", ref global::java.util.zip.InflaterInputStream._reset28423);
		}
		internal static global::MonoJavaBridge.MethodId _fill28424;
		protected virtual void fill()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.InflaterInputStream.staticClass, "fill", "()V", ref global::java.util.zip.InflaterInputStream._fill28424);
		}
		internal static global::MonoJavaBridge.MethodId _read28425;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.InflaterInputStream.staticClass, "read", "([BII)I", ref global::java.util.zip.InflaterInputStream._read28425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read28426;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.InflaterInputStream.staticClass, "read", "()I", ref global::java.util.zip.InflaterInputStream._read28426);
		}
		internal static global::MonoJavaBridge.MethodId _skip28427;
		public override long skip(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.zip.InflaterInputStream.staticClass, "skip", "(J)J", ref global::java.util.zip.InflaterInputStream._skip28427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available28428;
		public override int available()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.InflaterInputStream.staticClass, "available", "()I", ref global::java.util.zip.InflaterInputStream._available28428);
		}
		internal static global::MonoJavaBridge.MethodId _markSupported28429;
		public override bool markSupported()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.zip.InflaterInputStream.staticClass, "markSupported", "()Z", ref global::java.util.zip.InflaterInputStream._markSupported28429);
		}
		internal static global::MonoJavaBridge.MethodId _InflaterInputStream28430;
		public InflaterInputStream(java.io.InputStream arg0, java.util.zip.Inflater arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.InflaterInputStream._InflaterInputStream28430.native == global::System.IntPtr.Zero)
				global::java.util.zip.InflaterInputStream._InflaterInputStream28430 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "<init>", "(Ljava/io/InputStream;Ljava/util/zip/Inflater;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._InflaterInputStream28430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InflaterInputStream28431;
		public InflaterInputStream(java.io.InputStream arg0, java.util.zip.Inflater arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.InflaterInputStream._InflaterInputStream28431.native == global::System.IntPtr.Zero)
				global::java.util.zip.InflaterInputStream._InflaterInputStream28431 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "<init>", "(Ljava/io/InputStream;Ljava/util/zip/Inflater;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._InflaterInputStream28431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InflaterInputStream28432;
		public InflaterInputStream(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.InflaterInputStream._InflaterInputStream28432.native == global::System.IntPtr.Zero)
				global::java.util.zip.InflaterInputStream._InflaterInputStream28432 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._InflaterInputStream28432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static InflaterInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.InflaterInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/InflaterInputStream"));
		}
		internal static void InitJNI()
		{
		}
	}
}
