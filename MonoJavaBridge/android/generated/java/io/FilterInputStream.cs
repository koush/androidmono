namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FilterInputStream : java.io.InputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FilterInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close19058;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._close19058);
		}
		internal static global::MonoJavaBridge.MethodId _mark19059;
		public override void mark(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._mark19059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset19060;
		public override void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._reset19060);
		}
		internal static global::MonoJavaBridge.MethodId _read19061;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._read19061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read19062;
		public override int read(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._read19062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read19063;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._read19063);
		}
		internal static global::MonoJavaBridge.MethodId _skip19064;
		public override long skip(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._skip19064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available19065;
		public override int available()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._available19065);
		}
		internal static global::MonoJavaBridge.MethodId _markSupported19066;
		public override bool markSupported()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._markSupported19066);
		}
		internal static global::MonoJavaBridge.MethodId _FilterInputStream19067;
		protected FilterInputStream(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._FilterInputStream19067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static FilterInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FilterInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FilterInputStream"));
			global::java.io.FilterInputStream._close19058 = @__env.GetMethodIDNoThrow(global::java.io.FilterInputStream.staticClass, "close", "()V");
			global::java.io.FilterInputStream._mark19059 = @__env.GetMethodIDNoThrow(global::java.io.FilterInputStream.staticClass, "mark", "(I)V");
			global::java.io.FilterInputStream._reset19060 = @__env.GetMethodIDNoThrow(global::java.io.FilterInputStream.staticClass, "reset", "()V");
			global::java.io.FilterInputStream._read19061 = @__env.GetMethodIDNoThrow(global::java.io.FilterInputStream.staticClass, "read", "([BII)I");
			global::java.io.FilterInputStream._read19062 = @__env.GetMethodIDNoThrow(global::java.io.FilterInputStream.staticClass, "read", "([B)I");
			global::java.io.FilterInputStream._read19063 = @__env.GetMethodIDNoThrow(global::java.io.FilterInputStream.staticClass, "read", "()I");
			global::java.io.FilterInputStream._skip19064 = @__env.GetMethodIDNoThrow(global::java.io.FilterInputStream.staticClass, "skip", "(J)J");
			global::java.io.FilterInputStream._available19065 = @__env.GetMethodIDNoThrow(global::java.io.FilterInputStream.staticClass, "available", "()I");
			global::java.io.FilterInputStream._markSupported19066 = @__env.GetMethodIDNoThrow(global::java.io.FilterInputStream.staticClass, "markSupported", "()Z");
			global::java.io.FilterInputStream._FilterInputStream19067 = @__env.GetMethodIDNoThrow(global::java.io.FilterInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
