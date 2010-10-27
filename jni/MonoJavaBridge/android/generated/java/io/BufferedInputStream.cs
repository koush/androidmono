namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BufferedInputStream : java.io.FilterInputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BufferedInputStream()
		{
			InitJNI();
		}
		protected BufferedInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close18800;
		public override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.BufferedInputStream._close18800);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._close18800);
		}
		internal static global::MonoJavaBridge.MethodId _mark18801;
		public override void mark(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.BufferedInputStream._mark18801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._mark18801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset18802;
		public override void reset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.BufferedInputStream._reset18802);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._reset18802);
		}
		internal static global::MonoJavaBridge.MethodId _read18803;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.BufferedInputStream._read18803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._read18803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read18804;
		public override int read()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.BufferedInputStream._read18804);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._read18804);
		}
		internal static global::MonoJavaBridge.MethodId _skip18805;
		public override long skip(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.BufferedInputStream._skip18805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._skip18805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available18806;
		public override int available()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.BufferedInputStream._available18806);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._available18806);
		}
		internal static global::MonoJavaBridge.MethodId _markSupported18807;
		public override bool markSupported()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.BufferedInputStream._markSupported18807);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._markSupported18807);
		}
		internal static global::MonoJavaBridge.MethodId _BufferedInputStream18808;
		public BufferedInputStream(java.io.InputStream arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._BufferedInputStream18808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BufferedInputStream18809;
		public BufferedInputStream(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._BufferedInputStream18809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.BufferedInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/BufferedInputStream"));
			global::java.io.BufferedInputStream._close18800 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "close", "()V");
			global::java.io.BufferedInputStream._mark18801 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "mark", "(I)V");
			global::java.io.BufferedInputStream._reset18802 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "reset", "()V");
			global::java.io.BufferedInputStream._read18803 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "read", "([BII)I");
			global::java.io.BufferedInputStream._read18804 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "read", "()I");
			global::java.io.BufferedInputStream._skip18805 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "skip", "(J)J");
			global::java.io.BufferedInputStream._available18806 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "available", "()I");
			global::java.io.BufferedInputStream._markSupported18807 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "markSupported", "()Z");
			global::java.io.BufferedInputStream._BufferedInputStream18808 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "<init>", "(Ljava/io/InputStream;I)V");
			global::java.io.BufferedInputStream._BufferedInputStream18809 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
		}
	}
}
