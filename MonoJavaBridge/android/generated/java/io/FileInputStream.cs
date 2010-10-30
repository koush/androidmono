namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FileInputStream : java.io.InputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FileInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize19017;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FileInputStream.staticClass, global::java.io.FileInputStream._finalize19017);
		}
		internal static global::MonoJavaBridge.MethodId _close19018;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FileInputStream.staticClass, global::java.io.FileInputStream._close19018);
		}
		internal static global::MonoJavaBridge.MethodId _read19019;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.FileInputStream.staticClass, global::java.io.FileInputStream._read19019);
		}
		internal static global::MonoJavaBridge.MethodId _read19020;
		public override int read(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.FileInputStream.staticClass, global::java.io.FileInputStream._read19020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read19021;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.FileInputStream.staticClass, global::java.io.FileInputStream._read19021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _skip19022;
		public override long skip(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.FileInputStream.staticClass, global::java.io.FileInputStream._skip19022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available19023;
		public override int available()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.FileInputStream.staticClass, global::java.io.FileInputStream._available19023);
		}
		public new global::java.io.FileDescriptor FD
		{
			get
			{
				return getFD();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFD19024;
		public virtual global::java.io.FileDescriptor getFD()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.io.FileDescriptor>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.FileInputStream.staticClass, global::java.io.FileInputStream._getFD19024)) as java.io.FileDescriptor;
		}
		public new global::java.nio.channels.FileChannel Channel
		{
			get
			{
				return getChannel();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChannel19025;
		public virtual global::java.nio.channels.FileChannel getChannel()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.FileInputStream.staticClass, global::java.io.FileInputStream._getChannel19025)) as java.nio.channels.FileChannel;
		}
		internal static global::MonoJavaBridge.MethodId _FileInputStream19026;
		public FileInputStream(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileInputStream.staticClass, global::java.io.FileInputStream._FileInputStream19026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileInputStream19027;
		public FileInputStream(java.io.File arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileInputStream.staticClass, global::java.io.FileInputStream._FileInputStream19027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileInputStream19028;
		public FileInputStream(java.io.FileDescriptor arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileInputStream.staticClass, global::java.io.FileInputStream._FileInputStream19028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static FileInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FileInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FileInputStream"));
			global::java.io.FileInputStream._finalize19017 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "finalize", "()V");
			global::java.io.FileInputStream._close19018 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "close", "()V");
			global::java.io.FileInputStream._read19019 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "read", "()I");
			global::java.io.FileInputStream._read19020 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "read", "([B)I");
			global::java.io.FileInputStream._read19021 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "read", "([BII)I");
			global::java.io.FileInputStream._skip19022 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "skip", "(J)J");
			global::java.io.FileInputStream._available19023 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "available", "()I");
			global::java.io.FileInputStream._getFD19024 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "getFD", "()Ljava/io/FileDescriptor;");
			global::java.io.FileInputStream._getChannel19025 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "getChannel", "()Ljava/nio/channels/FileChannel;");
			global::java.io.FileInputStream._FileInputStream19026 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.io.FileInputStream._FileInputStream19027 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "<init>", "(Ljava/io/File;)V");
			global::java.io.FileInputStream._FileInputStream19028 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "<init>", "(Ljava/io/FileDescriptor;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
