namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FileOutputStream : java.io.OutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FileOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FileOutputStream.staticClass, "finalize", "()V", ref global::java.io.FileOutputStream._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FileOutputStream.staticClass, "write", "(I)V", ref global::java.io.FileOutputStream._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void write(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FileOutputStream.staticClass, "write", "([B)V", ref global::java.io.FileOutputStream._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FileOutputStream.staticClass, "write", "([BII)V", ref global::java.io.FileOutputStream._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FileOutputStream.staticClass, "close", "()V", ref global::java.io.FileOutputStream._m4);
		}
		public new global::java.io.FileDescriptor FD
		{
			get
			{
				return getFD();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.io.FileDescriptor getFD()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.io.FileDescriptor>(this, global::java.io.FileOutputStream.staticClass, "getFD", "()Ljava/io/FileDescriptor;", ref global::java.io.FileOutputStream._m5) as java.io.FileDescriptor;
		}
		public new global::java.nio.channels.FileChannel Channel
		{
			get
			{
				return getChannel();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.nio.channels.FileChannel getChannel()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.FileOutputStream.staticClass, "getChannel", "()Ljava/nio/channels/FileChannel;", ref global::java.io.FileOutputStream._m6) as java.nio.channels.FileChannel;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public FileOutputStream(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FileOutputStream._m7.native == global::System.IntPtr.Zero)
				global::java.io.FileOutputStream._m7 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public FileOutputStream(java.lang.String arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FileOutputStream._m8.native == global::System.IntPtr.Zero)
				global::java.io.FileOutputStream._m8 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "<init>", "(Ljava/lang/String;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public FileOutputStream(java.io.File arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FileOutputStream._m9.native == global::System.IntPtr.Zero)
				global::java.io.FileOutputStream._m9 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "<init>", "(Ljava/io/File;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public FileOutputStream(java.io.File arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FileOutputStream._m10.native == global::System.IntPtr.Zero)
				global::java.io.FileOutputStream._m10 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "<init>", "(Ljava/io/File;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public FileOutputStream(java.io.FileDescriptor arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FileOutputStream._m11.native == global::System.IntPtr.Zero)
				global::java.io.FileOutputStream._m11 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "<init>", "(Ljava/io/FileDescriptor;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
