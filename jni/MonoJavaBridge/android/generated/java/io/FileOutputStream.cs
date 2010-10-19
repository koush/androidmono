namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FileOutputStream : java.io.OutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FileOutputStream()
		{
			InitJNI();
		}
		protected FileOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize13438;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FileOutputStream._finalize13438);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._finalize13438);
		}
		internal static global::MonoJavaBridge.MethodId _write13439;
		public override void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FileOutputStream._write13439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._write13439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write13440;
		public override void write(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FileOutputStream._write13440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._write13440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write13441;
		public override void write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FileOutputStream._write13441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._write13441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _close13442;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FileOutputStream._close13442);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._close13442);
		}
		public new global::java.io.FileDescriptor FD
		{
			get
			{
				return getFD();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFD13443;
		public virtual global::java.io.FileDescriptor getFD() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.FileOutputStream._getFD13443)) as java.io.FileDescriptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._getFD13443)) as java.io.FileDescriptor;
		}
		public new global::java.nio.channels.FileChannel Channel
		{
			get
			{
				return getChannel();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChannel13444;
		public virtual global::java.nio.channels.FileChannel getChannel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.FileOutputStream._getChannel13444)) as java.nio.channels.FileChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._getChannel13444)) as java.nio.channels.FileChannel;
		}
		internal static global::MonoJavaBridge.MethodId _FileOutputStream13445;
		public FileOutputStream(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._FileOutputStream13445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileOutputStream13446;
		public FileOutputStream(java.lang.String arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._FileOutputStream13446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileOutputStream13447;
		public FileOutputStream(java.io.File arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._FileOutputStream13447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileOutputStream13448;
		public FileOutputStream(java.io.File arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._FileOutputStream13448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileOutputStream13449;
		public FileOutputStream(java.io.FileDescriptor arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._FileOutputStream13449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FileOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FileOutputStream"));
			global::java.io.FileOutputStream._finalize13438 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "finalize", "()V");
			global::java.io.FileOutputStream._write13439 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "write", "(I)V");
			global::java.io.FileOutputStream._write13440 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "write", "([B)V");
			global::java.io.FileOutputStream._write13441 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "write", "([BII)V");
			global::java.io.FileOutputStream._close13442 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "close", "()V");
			global::java.io.FileOutputStream._getFD13443 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "getFD", "()Ljava/io/FileDescriptor;");
			global::java.io.FileOutputStream._getChannel13444 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "getChannel", "()Ljava/nio/channels/FileChannel;");
			global::java.io.FileOutputStream._FileOutputStream13445 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.io.FileOutputStream._FileOutputStream13446 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "<init>", "(Ljava/lang/String;Z)V");
			global::java.io.FileOutputStream._FileOutputStream13447 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "<init>", "(Ljava/io/File;)V");
			global::java.io.FileOutputStream._FileOutputStream13448 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "<init>", "(Ljava/io/File;Z)V");
			global::java.io.FileOutputStream._FileOutputStream13449 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "<init>", "(Ljava/io/FileDescriptor;)V");
		}
	}
}
