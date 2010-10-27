namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ByteArrayInputStream : java.io.InputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ByteArrayInputStream()
		{
			InitJNI();
		}
		protected ByteArrayInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close18834;
		public override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ByteArrayInputStream._close18834);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ByteArrayInputStream.staticClass, global::java.io.ByteArrayInputStream._close18834);
		}
		internal static global::MonoJavaBridge.MethodId _mark18835;
		public override void mark(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ByteArrayInputStream._mark18835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ByteArrayInputStream.staticClass, global::java.io.ByteArrayInputStream._mark18835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset18836;
		public override void reset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ByteArrayInputStream._reset18836);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ByteArrayInputStream.staticClass, global::java.io.ByteArrayInputStream._reset18836);
		}
		internal static global::MonoJavaBridge.MethodId _read18837;
		public override int read()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ByteArrayInputStream._read18837);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ByteArrayInputStream.staticClass, global::java.io.ByteArrayInputStream._read18837);
		}
		internal static global::MonoJavaBridge.MethodId _read18838;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ByteArrayInputStream._read18838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ByteArrayInputStream.staticClass, global::java.io.ByteArrayInputStream._read18838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _skip18839;
		public override long skip(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.ByteArrayInputStream._skip18839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.ByteArrayInputStream.staticClass, global::java.io.ByteArrayInputStream._skip18839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available18840;
		public override int available()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ByteArrayInputStream._available18840);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ByteArrayInputStream.staticClass, global::java.io.ByteArrayInputStream._available18840);
		}
		internal static global::MonoJavaBridge.MethodId _markSupported18841;
		public override bool markSupported()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.ByteArrayInputStream._markSupported18841);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.ByteArrayInputStream.staticClass, global::java.io.ByteArrayInputStream._markSupported18841);
		}
		internal static global::MonoJavaBridge.MethodId _ByteArrayInputStream18842;
		public ByteArrayInputStream(byte[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ByteArrayInputStream.staticClass, global::java.io.ByteArrayInputStream._ByteArrayInputStream18842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ByteArrayInputStream18843;
		public ByteArrayInputStream(byte[] arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ByteArrayInputStream.staticClass, global::java.io.ByteArrayInputStream._ByteArrayInputStream18843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ByteArrayInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ByteArrayInputStream"));
			global::java.io.ByteArrayInputStream._close18834 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayInputStream.staticClass, "close", "()V");
			global::java.io.ByteArrayInputStream._mark18835 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayInputStream.staticClass, "mark", "(I)V");
			global::java.io.ByteArrayInputStream._reset18836 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayInputStream.staticClass, "reset", "()V");
			global::java.io.ByteArrayInputStream._read18837 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayInputStream.staticClass, "read", "()I");
			global::java.io.ByteArrayInputStream._read18838 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayInputStream.staticClass, "read", "([BII)I");
			global::java.io.ByteArrayInputStream._skip18839 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayInputStream.staticClass, "skip", "(J)J");
			global::java.io.ByteArrayInputStream._available18840 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayInputStream.staticClass, "available", "()I");
			global::java.io.ByteArrayInputStream._markSupported18841 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayInputStream.staticClass, "markSupported", "()Z");
			global::java.io.ByteArrayInputStream._ByteArrayInputStream18842 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayInputStream.staticClass, "<init>", "([B)V");
			global::java.io.ByteArrayInputStream._ByteArrayInputStream18843 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayInputStream.staticClass, "<init>", "([BII)V");
		}
	}
}
