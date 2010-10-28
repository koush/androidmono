namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PipedInputStream : java.io.InputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PipedInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close19369;
		public override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PipedInputStream._close19369);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._close19369);
		}
		internal static global::MonoJavaBridge.MethodId _read19370;
		public override int read()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.PipedInputStream._read19370);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._read19370);
		}
		internal static global::MonoJavaBridge.MethodId _read19371;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.PipedInputStream._read19371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._read19371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _available19372;
		public override int available()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.PipedInputStream._available19372);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._available19372);
		}
		internal static global::MonoJavaBridge.MethodId _connect19373;
		public virtual void connect(java.io.PipedOutputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PipedInputStream._connect19373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._connect19373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _receive19374;
		protected virtual void receive(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PipedInputStream._receive19374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._receive19374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PipedInputStream19375;
		public PipedInputStream(java.io.PipedOutputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._PipedInputStream19375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PipedInputStream19376;
		public PipedInputStream(java.io.PipedOutputStream arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._PipedInputStream19376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PipedInputStream19377;
		public PipedInputStream() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._PipedInputStream19377);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PipedInputStream19378;
		public PipedInputStream(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._PipedInputStream19378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static PipedInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.PipedInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/PipedInputStream"));
			global::java.io.PipedInputStream._close19369 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "close", "()V");
			global::java.io.PipedInputStream._read19370 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "read", "()I");
			global::java.io.PipedInputStream._read19371 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "read", "([BII)I");
			global::java.io.PipedInputStream._available19372 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "available", "()I");
			global::java.io.PipedInputStream._connect19373 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "connect", "(Ljava/io/PipedOutputStream;)V");
			global::java.io.PipedInputStream._receive19374 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "receive", "(I)V");
			global::java.io.PipedInputStream._PipedInputStream19375 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "<init>", "(Ljava/io/PipedOutputStream;)V");
			global::java.io.PipedInputStream._PipedInputStream19376 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "<init>", "(Ljava/io/PipedOutputStream;I)V");
			global::java.io.PipedInputStream._PipedInputStream19377 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "<init>", "()V");
			global::java.io.PipedInputStream._PipedInputStream19378 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "<init>", "(I)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
