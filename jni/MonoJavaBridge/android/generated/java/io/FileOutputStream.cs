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
		internal static global::MonoJavaBridge.MethodId _finalize12568;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FileOutputStream._finalize12568);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._finalize12568);
		}
		internal static global::MonoJavaBridge.MethodId _write12569;
		public override void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FileOutputStream._write12569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._write12569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write12570;
		public override void write(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FileOutputStream._write12570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._write12570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write12571;
		public override void write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FileOutputStream._write12571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._write12571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _close12572;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FileOutputStream._close12572);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._close12572);
		}
		internal static global::MonoJavaBridge.MethodId _getFD12573;
		public virtual global::java.io.FileDescriptor getFD() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.FileOutputStream._getFD12573)) as java.io.FileDescriptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._getFD12573)) as java.io.FileDescriptor;
		}
		internal static global::MonoJavaBridge.MethodId _getChannel12574;
		public virtual global::java.nio.channels.FileChannel getChannel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.FileOutputStream._getChannel12574)) as java.nio.channels.FileChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._getChannel12574)) as java.nio.channels.FileChannel;
		}
		internal static global::MonoJavaBridge.MethodId _FileOutputStream12575;
		public FileOutputStream(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._FileOutputStream12575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileOutputStream12576;
		public FileOutputStream(java.lang.String arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._FileOutputStream12576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileOutputStream12577;
		public FileOutputStream(java.io.File arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._FileOutputStream12577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileOutputStream12578;
		public FileOutputStream(java.io.File arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._FileOutputStream12578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileOutputStream12579;
		public FileOutputStream(java.io.FileDescriptor arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._FileOutputStream12579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FileOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FileOutputStream"));
			global::java.io.FileOutputStream._finalize12568 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "finalize", "()V");
			global::java.io.FileOutputStream._write12569 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "write", "(I)V");
			global::java.io.FileOutputStream._write12570 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "write", "([B)V");
			global::java.io.FileOutputStream._write12571 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "write", "([BII)V");
			global::java.io.FileOutputStream._close12572 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "close", "()V");
			global::java.io.FileOutputStream._getFD12573 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "getFD", "()Ljava/io/FileDescriptor;");
			global::java.io.FileOutputStream._getChannel12574 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "getChannel", "()Ljava/nio/channels/FileChannel;");
			global::java.io.FileOutputStream._FileOutputStream12575 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.io.FileOutputStream._FileOutputStream12576 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "<init>", "(Ljava/lang/String;Z)V");
			global::java.io.FileOutputStream._FileOutputStream12577 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "<init>", "(Ljava/io/File;)V");
			global::java.io.FileOutputStream._FileOutputStream12578 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "<init>", "(Ljava/io/File;Z)V");
			global::java.io.FileOutputStream._FileOutputStream12579 = @__env.GetMethodIDNoThrow(global::java.io.FileOutputStream.staticClass, "<init>", "(Ljava/io/FileDescriptor;)V");
		}
	}
}
