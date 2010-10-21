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
		internal static global::MonoJavaBridge.MethodId _close18682;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.BufferedInputStream._close18682);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._close18682);
		}
		internal static global::MonoJavaBridge.MethodId _mark18683;
		public override void mark(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.BufferedInputStream._mark18683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._mark18683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset18684;
		public override void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.BufferedInputStream._reset18684);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._reset18684);
		}
		internal static global::MonoJavaBridge.MethodId _read18685;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.BufferedInputStream._read18685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._read18685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read18686;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.BufferedInputStream._read18686);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._read18686);
		}
		internal static global::MonoJavaBridge.MethodId _skip18687;
		public override long skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.BufferedInputStream._skip18687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._skip18687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available18688;
		public override int available() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.BufferedInputStream._available18688);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._available18688);
		}
		internal static global::MonoJavaBridge.MethodId _markSupported18689;
		public override bool markSupported() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.BufferedInputStream._markSupported18689);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._markSupported18689);
		}
		internal static global::MonoJavaBridge.MethodId _BufferedInputStream18690;
		public BufferedInputStream(java.io.InputStream arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._BufferedInputStream18690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BufferedInputStream18691;
		public BufferedInputStream(java.io.InputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._BufferedInputStream18691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.BufferedInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/BufferedInputStream"));
			global::java.io.BufferedInputStream._close18682 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "close", "()V");
			global::java.io.BufferedInputStream._mark18683 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "mark", "(I)V");
			global::java.io.BufferedInputStream._reset18684 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "reset", "()V");
			global::java.io.BufferedInputStream._read18685 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "read", "([BII)I");
			global::java.io.BufferedInputStream._read18686 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "read", "()I");
			global::java.io.BufferedInputStream._skip18687 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "skip", "(J)J");
			global::java.io.BufferedInputStream._available18688 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "available", "()I");
			global::java.io.BufferedInputStream._markSupported18689 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "markSupported", "()Z");
			global::java.io.BufferedInputStream._BufferedInputStream18690 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "<init>", "(Ljava/io/InputStream;I)V");
			global::java.io.BufferedInputStream._BufferedInputStream18691 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
		}
	}
}
