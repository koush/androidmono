namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FileInputStream : java.io.InputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FileInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FileInputStream.staticClass, "finalize", "()V", ref global::java.io.FileInputStream._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FileInputStream.staticClass, "close", "()V", ref global::java.io.FileInputStream._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.FileInputStream.staticClass, "read", "()I", ref global::java.io.FileInputStream._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int read(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.FileInputStream.staticClass, "read", "([B)I", ref global::java.io.FileInputStream._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.FileInputStream.staticClass, "read", "([BII)I", ref global::java.io.FileInputStream._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override long skip(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.FileInputStream.staticClass, "skip", "(J)J", ref global::java.io.FileInputStream._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override int available()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.FileInputStream.staticClass, "available", "()I", ref global::java.io.FileInputStream._m6);
		}
		public new global::java.io.FileDescriptor FD
		{
			get
			{
				return getFD();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.io.FileDescriptor getFD()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.io.FileDescriptor>(this, global::java.io.FileInputStream.staticClass, "getFD", "()Ljava/io/FileDescriptor;", ref global::java.io.FileInputStream._m7) as java.io.FileDescriptor;
		}
		public new global::java.nio.channels.FileChannel Channel
		{
			get
			{
				return getChannel();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.nio.channels.FileChannel getChannel()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.FileInputStream.staticClass, "getChannel", "()Ljava/nio/channels/FileChannel;", ref global::java.io.FileInputStream._m8) as java.nio.channels.FileChannel;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public FileInputStream(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FileInputStream._m9.native == global::System.IntPtr.Zero)
				global::java.io.FileInputStream._m9 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileInputStream.staticClass, global::java.io.FileInputStream._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public FileInputStream(java.io.File arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FileInputStream._m10.native == global::System.IntPtr.Zero)
				global::java.io.FileInputStream._m10 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "<init>", "(Ljava/io/File;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileInputStream.staticClass, global::java.io.FileInputStream._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public FileInputStream(java.io.FileDescriptor arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FileInputStream._m11.native == global::System.IntPtr.Zero)
				global::java.io.FileInputStream._m11 = @__env.GetMethodIDNoThrow(global::java.io.FileInputStream.staticClass, "<init>", "(Ljava/io/FileDescriptor;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileInputStream.staticClass, global::java.io.FileInputStream._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static FileInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FileInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FileInputStream"));
		}
		internal static void InitJNI()
		{
		}
	}
}
