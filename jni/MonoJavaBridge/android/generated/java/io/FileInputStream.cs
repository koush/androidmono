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
		internal static global::MonoJavaBridge.MethodId _finalize18899;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FileInputStream._finalize18899);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FileInputStream.staticClass, global::java.io.FileInputStream._finalize18899);
		}
		internal static global::MonoJavaBridge.MethodId _close18900;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FileInputStream._close18900);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FileInputStream.staticClass, global::java.io.FileInputStream._close18900);
		}
		internal static global::MonoJavaBridge.MethodId _read18901;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.FileInputStream._read18901);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.FileInputStream.staticClass, global::java.io.FileInputStream._read18901);
		}
		internal static global::MonoJavaBridge.MethodId _read18902;
		public override int read(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.FileInputStream._read18902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.FileInputStream.staticClass, global::java.io.FileInputStream._read18902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read18903;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.FileInputStream._read18903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.FileInputStream.staticClass, global::java.io.FileInputStream._read18903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _skip18904;
		public override long skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.FileInputStream._skip18904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.FileInputStream.staticClass, global::java.io.FileInputStream._skip18904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available18905;
		public override int available() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.FileInputStream._available18905);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.FileInputStream.staticClass, global::java.io.FileInputStream._available18905);
		}
		public new global::java.io.FileDescriptor FD
		{
			get
			{
				return getFD();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFD18906;
		public virtual global::java.io.FileDescriptor getFD() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.FileInputStream._getFD18906)) as java.io.FileDescriptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.FileInputStream.staticClass, global::java.io.FileInputStream._getFD18906)) as java.io.FileDescriptor;
		}
		public new global::java.nio.channels.FileChannel Channel
		{
			get
			{
				return getChannel();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChannel18907;
		public virtual global::java.nio.channels.FileChannel getChannel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.FileInputStream._getChannel18907)) as java.nio.channels.FileChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.FileInputStream.staticClass, global::java.io.FileInputStream._getChannel18907)) as java.nio.channels.FileChannel;
		}
		internal static global::MonoJavaBridge.MethodId _FileInputStream18908;
		public FileInputStream(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileInputStream.staticClass, global::java.io.FileInputStream._FileInputStream18908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileInputStream18909;
		public FileInputStream(java.io.File arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileInputStream.staticClass, global::java.io.FileInputStream._FileInputStream18909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileInputStream18910;
		public FileInputStream(java.io.FileDescriptor arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileInputStream.staticClass, global::java.io.FileInputStream._FileInputStream18910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FileInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FileInputStream"));
			global::java.io.FileInputStream._finalize18899 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "finalize", "()V");
			global::java.io.FileInputStream._close18900 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "close", "()V");
			global::java.io.FileInputStream._read18901 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "read", "()I");
			global::java.io.FileInputStream._read18902 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "read", "([B)I");
			global::java.io.FileInputStream._read18903 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "read", "([BII)I");
			global::java.io.FileInputStream._skip18904 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "skip", "(J)J");
			global::java.io.FileInputStream._available18905 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "available", "()I");
			global::java.io.FileInputStream._getFD18906 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "getFD", "()Ljava/io/FileDescriptor;");
			global::java.io.FileInputStream._getChannel18907 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "getChannel", "()Ljava/nio/channels/FileChannel;");
			global::java.io.FileInputStream._FileInputStream18908 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.io.FileInputStream._FileInputStream18909 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "<init>", "(Ljava/io/File;)V");
			global::java.io.FileInputStream._FileInputStream18910 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "<init>", "(Ljava/io/FileDescriptor;)V");
		}
	}
}
