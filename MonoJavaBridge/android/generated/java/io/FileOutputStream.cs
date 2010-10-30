namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FileOutputStream : java.io.OutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FileOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize19031;
		protected override void finalize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FileOutputStream._finalize19031.native == global::System.IntPtr.Zero)
				global::java.io.FileOutputStream._finalize19031 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "finalize", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._finalize19031);
		}
		internal static global::MonoJavaBridge.MethodId _write19032;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FileOutputStream._write19032.native == global::System.IntPtr.Zero)
				global::java.io.FileOutputStream._write19032 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "write", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._write19032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write19033;
		public override void write(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FileOutputStream._write19033.native == global::System.IntPtr.Zero)
				global::java.io.FileOutputStream._write19033 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "write", "([B)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._write19033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write19034;
		public override void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FileOutputStream._write19034.native == global::System.IntPtr.Zero)
				global::java.io.FileOutputStream._write19034 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "write", "([BII)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._write19034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _close19035;
		public override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FileOutputStream._close19035.native == global::System.IntPtr.Zero)
				global::java.io.FileOutputStream._close19035 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "close", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._close19035);
		}
		public new global::java.io.FileDescriptor FD
		{
			get
			{
				return getFD();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFD19036;
		public virtual global::java.io.FileDescriptor getFD()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FileOutputStream._getFD19036.native == global::System.IntPtr.Zero)
				global::java.io.FileOutputStream._getFD19036 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "getFD", "()Ljava/io/FileDescriptor;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.io.FileDescriptor>(this, global::java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._getFD19036) as java.io.FileDescriptor;
		}
		public new global::java.nio.channels.FileChannel Channel
		{
			get
			{
				return getChannel();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChannel19037;
		public virtual global::java.nio.channels.FileChannel getChannel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FileOutputStream._getChannel19037.native == global::System.IntPtr.Zero)
				global::java.io.FileOutputStream._getChannel19037 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "getChannel", "()Ljava/nio/channels/FileChannel;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._getChannel19037) as java.nio.channels.FileChannel;
		}
		internal static global::MonoJavaBridge.MethodId _FileOutputStream19038;
		public FileOutputStream(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FileOutputStream._FileOutputStream19038.native == global::System.IntPtr.Zero)
				global::java.io.FileOutputStream._FileOutputStream19038 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._FileOutputStream19038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileOutputStream19039;
		public FileOutputStream(java.lang.String arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FileOutputStream._FileOutputStream19039.native == global::System.IntPtr.Zero)
				global::java.io.FileOutputStream._FileOutputStream19039 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "<init>", "(Ljava/lang/String;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._FileOutputStream19039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileOutputStream19040;
		public FileOutputStream(java.io.File arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FileOutputStream._FileOutputStream19040.native == global::System.IntPtr.Zero)
				global::java.io.FileOutputStream._FileOutputStream19040 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "<init>", "(Ljava/io/File;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._FileOutputStream19040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileOutputStream19041;
		public FileOutputStream(java.io.File arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FileOutputStream._FileOutputStream19041.native == global::System.IntPtr.Zero)
				global::java.io.FileOutputStream._FileOutputStream19041 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "<init>", "(Ljava/io/File;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._FileOutputStream19041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileOutputStream19042;
		public FileOutputStream(java.io.FileDescriptor arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FileOutputStream._FileOutputStream19042.native == global::System.IntPtr.Zero)
				global::java.io.FileOutputStream._FileOutputStream19042 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "<init>", "(Ljava/io/FileDescriptor;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._FileOutputStream19042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static FileOutputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FileOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FileOutputStream"));
		}
		internal static void InitJNI()
		{
		}
	}
}
