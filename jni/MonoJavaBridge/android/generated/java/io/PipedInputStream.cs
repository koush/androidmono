namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PipedInputStream : java.io.InputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PipedInputStream()
		{
			InitJNI();
		}
		protected PipedInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close13749;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PipedInputStream._close13749);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._close13749);
		}
		internal static global::MonoJavaBridge.MethodId _read13750;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.PipedInputStream._read13750);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._read13750);
		}
		internal static global::MonoJavaBridge.MethodId _read13751;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.PipedInputStream._read13751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._read13751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _available13752;
		public override int available() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.PipedInputStream._available13752);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._available13752);
		}
		internal static global::MonoJavaBridge.MethodId _connect13753;
		public virtual void connect(java.io.PipedOutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PipedInputStream._connect13753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._connect13753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _receive13754;
		protected virtual void receive(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PipedInputStream._receive13754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._receive13754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PipedInputStream13755;
		public PipedInputStream(java.io.PipedOutputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._PipedInputStream13755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PipedInputStream13756;
		public PipedInputStream(java.io.PipedOutputStream arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._PipedInputStream13756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PipedInputStream13757;
		public PipedInputStream()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._PipedInputStream13757);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PipedInputStream13758;
		public PipedInputStream(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._PipedInputStream13758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.PipedInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/PipedInputStream"));
			global::java.io.PipedInputStream._close13749 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "close", "()V");
			global::java.io.PipedInputStream._read13750 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "read", "()I");
			global::java.io.PipedInputStream._read13751 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "read", "([BII)I");
			global::java.io.PipedInputStream._available13752 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "available", "()I");
			global::java.io.PipedInputStream._connect13753 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "connect", "(Ljava/io/PipedOutputStream;)V");
			global::java.io.PipedInputStream._receive13754 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "receive", "(I)V");
			global::java.io.PipedInputStream._PipedInputStream13755 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "<init>", "(Ljava/io/PipedOutputStream;)V");
			global::java.io.PipedInputStream._PipedInputStream13756 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "<init>", "(Ljava/io/PipedOutputStream;I)V");
			global::java.io.PipedInputStream._PipedInputStream13757 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "<init>", "()V");
			global::java.io.PipedInputStream._PipedInputStream13758 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "<init>", "(I)V");
		}
	}
}
