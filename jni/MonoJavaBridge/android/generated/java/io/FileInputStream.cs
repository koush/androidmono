namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FileInputStream : java.io.InputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FileInputStream()
		{
			InitJNI();
		}
		protected FileInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize13424;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FileInputStream._finalize13424);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FileInputStream.staticClass, global::java.io.FileInputStream._finalize13424);
		}
		internal static global::MonoJavaBridge.MethodId _close13425;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FileInputStream._close13425);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FileInputStream.staticClass, global::java.io.FileInputStream._close13425);
		}
		internal static global::MonoJavaBridge.MethodId _read13426;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.FileInputStream._read13426);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.FileInputStream.staticClass, global::java.io.FileInputStream._read13426);
		}
		internal static global::MonoJavaBridge.MethodId _read13427;
		public override int read(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.FileInputStream._read13427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.FileInputStream.staticClass, global::java.io.FileInputStream._read13427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read13428;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.FileInputStream._read13428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.FileInputStream.staticClass, global::java.io.FileInputStream._read13428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _skip13429;
		public override long skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.FileInputStream._skip13429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.FileInputStream.staticClass, global::java.io.FileInputStream._skip13429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available13430;
		public override int available() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.FileInputStream._available13430);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.FileInputStream.staticClass, global::java.io.FileInputStream._available13430);
		}
		public new global::java.io.FileDescriptor FD
		{
			get
			{
				return getFD();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFD13431;
		public virtual global::java.io.FileDescriptor getFD() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.FileInputStream._getFD13431)) as java.io.FileDescriptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.FileInputStream.staticClass, global::java.io.FileInputStream._getFD13431)) as java.io.FileDescriptor;
		}
		public new global::java.nio.channels.FileChannel Channel
		{
			get
			{
				return getChannel();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChannel13432;
		public virtual global::java.nio.channels.FileChannel getChannel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.FileInputStream._getChannel13432)) as java.nio.channels.FileChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.FileInputStream.staticClass, global::java.io.FileInputStream._getChannel13432)) as java.nio.channels.FileChannel;
		}
		internal static global::MonoJavaBridge.MethodId _FileInputStream13433;
		public FileInputStream(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileInputStream.staticClass, global::java.io.FileInputStream._FileInputStream13433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileInputStream13434;
		public FileInputStream(java.io.File arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileInputStream.staticClass, global::java.io.FileInputStream._FileInputStream13434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileInputStream13435;
		public FileInputStream(java.io.FileDescriptor arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileInputStream.staticClass, global::java.io.FileInputStream._FileInputStream13435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FileInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FileInputStream"));
			global::java.io.FileInputStream._finalize13424 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "finalize", "()V");
			global::java.io.FileInputStream._close13425 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "close", "()V");
			global::java.io.FileInputStream._read13426 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "read", "()I");
			global::java.io.FileInputStream._read13427 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "read", "([B)I");
			global::java.io.FileInputStream._read13428 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "read", "([BII)I");
			global::java.io.FileInputStream._skip13429 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "skip", "(J)J");
			global::java.io.FileInputStream._available13430 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "available", "()I");
			global::java.io.FileInputStream._getFD13431 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "getFD", "()Ljava/io/FileDescriptor;");
			global::java.io.FileInputStream._getChannel13432 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "getChannel", "()Ljava/nio/channels/FileChannel;");
			global::java.io.FileInputStream._FileInputStream13433 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.io.FileInputStream._FileInputStream13434 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "<init>", "(Ljava/io/File;)V");
			global::java.io.FileInputStream._FileInputStream13435 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "<init>", "(Ljava/io/FileDescriptor;)V");
		}
	}
}
