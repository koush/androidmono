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
		internal static global::MonoJavaBridge.MethodId _close19251;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PipedInputStream._close19251);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._close19251);
		}
		internal static global::MonoJavaBridge.MethodId _read19252;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.PipedInputStream._read19252);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._read19252);
		}
		internal static global::MonoJavaBridge.MethodId _read19253;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.PipedInputStream._read19253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._read19253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _available19254;
		public override int available() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.PipedInputStream._available19254);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._available19254);
		}
		internal static global::MonoJavaBridge.MethodId _connect19255;
		public virtual void connect(java.io.PipedOutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PipedInputStream._connect19255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._connect19255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _receive19256;
		protected virtual void receive(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PipedInputStream._receive19256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._receive19256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PipedInputStream19257;
		public PipedInputStream(java.io.PipedOutputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._PipedInputStream19257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PipedInputStream19258;
		public PipedInputStream(java.io.PipedOutputStream arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._PipedInputStream19258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PipedInputStream19259;
		public PipedInputStream()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._PipedInputStream19259);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PipedInputStream19260;
		public PipedInputStream(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PipedInputStream.staticClass, global::java.io.PipedInputStream._PipedInputStream19260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.PipedInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/PipedInputStream"));
			global::java.io.PipedInputStream._close19251 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "close", "()V");
			global::java.io.PipedInputStream._read19252 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "read", "()I");
			global::java.io.PipedInputStream._read19253 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "read", "([BII)I");
			global::java.io.PipedInputStream._available19254 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "available", "()I");
			global::java.io.PipedInputStream._connect19255 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "connect", "(Ljava/io/PipedOutputStream;)V");
			global::java.io.PipedInputStream._receive19256 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "receive", "(I)V");
			global::java.io.PipedInputStream._PipedInputStream19257 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "<init>", "(Ljava/io/PipedOutputStream;)V");
			global::java.io.PipedInputStream._PipedInputStream19258 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "<init>", "(Ljava/io/PipedOutputStream;I)V");
			global::java.io.PipedInputStream._PipedInputStream19259 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "<init>", "()V");
			global::java.io.PipedInputStream._PipedInputStream19260 = @__env.GetMethodIDNoThrow(global::java.io.PipedInputStream.staticClass, "<init>", "(I)V");
		}
	}
}
