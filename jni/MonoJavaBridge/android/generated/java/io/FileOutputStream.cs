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
		internal static global::MonoJavaBridge.MethodId _finalize18913;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FileOutputStream._finalize18913);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._finalize18913);
		}
		internal static global::MonoJavaBridge.MethodId _write18914;
		public override void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FileOutputStream._write18914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._write18914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write18915;
		public override void write(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FileOutputStream._write18915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._write18915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write18916;
		public override void write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FileOutputStream._write18916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._write18916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _close18917;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FileOutputStream._close18917);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._close18917);
		}
		public new global::java.io.FileDescriptor FD
		{
			get
			{
				return getFD();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFD18918;
		public virtual global::java.io.FileDescriptor getFD() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.FileOutputStream._getFD18918)) as java.io.FileDescriptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._getFD18918)) as java.io.FileDescriptor;
		}
		public new global::java.nio.channels.FileChannel Channel
		{
			get
			{
				return getChannel();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChannel18919;
		public virtual global::java.nio.channels.FileChannel getChannel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.FileOutputStream._getChannel18919)) as java.nio.channels.FileChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._getChannel18919)) as java.nio.channels.FileChannel;
		}
		internal static global::MonoJavaBridge.MethodId _FileOutputStream18920;
		public FileOutputStream(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._FileOutputStream18920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileOutputStream18921;
		public FileOutputStream(java.lang.String arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._FileOutputStream18921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileOutputStream18922;
		public FileOutputStream(java.io.File arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._FileOutputStream18922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileOutputStream18923;
		public FileOutputStream(java.io.File arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._FileOutputStream18923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileOutputStream18924;
		public FileOutputStream(java.io.FileDescriptor arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._FileOutputStream18924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FileOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FileOutputStream"));
			global::java.io.FileOutputStream._finalize18913 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "finalize", "()V");
			global::java.io.FileOutputStream._write18914 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "write", "(I)V");
			global::java.io.FileOutputStream._write18915 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "write", "([B)V");
			global::java.io.FileOutputStream._write18916 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "write", "([BII)V");
			global::java.io.FileOutputStream._close18917 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "close", "()V");
			global::java.io.FileOutputStream._getFD18918 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "getFD", "()Ljava/io/FileDescriptor;");
			global::java.io.FileOutputStream._getChannel18919 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "getChannel", "()Ljava/nio/channels/FileChannel;");
			global::java.io.FileOutputStream._FileOutputStream18920 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.io.FileOutputStream._FileOutputStream18921 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "<init>", "(Ljava/lang/String;Z)V");
			global::java.io.FileOutputStream._FileOutputStream18922 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "<init>", "(Ljava/io/File;)V");
			global::java.io.FileOutputStream._FileOutputStream18923 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "<init>", "(Ljava/io/File;Z)V");
			global::java.io.FileOutputStream._FileOutputStream18924 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "<init>", "(Ljava/io/FileDescriptor;)V");
		}
	}
}
