namespace java.io
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class FileOutputStream : java.io.OutputStream
	{
		internal static global::java.lang.Class staticClass;
		static FileOutputStream()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.io.FileOutputStream), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::java.io.FileOutputStream(@__env);
			}
		}
		protected FileOutputStream(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _write11395;
		public override void write(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.FileOutputStream._write11395, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._write11395, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _write11396;
		public override void write(byte[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.FileOutputStream._write11396, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._write11396, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _write11397;
		public override void write(byte[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.FileOutputStream._write11397, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._write11397, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _close11398;
		public override void close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.FileOutputStream._close11398);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._close11398);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFD11399;
		public virtual global::java.io.FileDescriptor getFD() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, global::java.io.FileOutputStream._getFD11399));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._getFD11399));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChannel11400;
		public virtual global::java.nio.channels.FileChannel getChannel() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.FileChannel>(@__env, @__env.CallObjectMethodPtr(this, global::java.io.FileOutputStream._getChannel11400));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.FileChannel>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._getChannel11400));
		}
		internal static global::net.sf.jni4net.jni.MethodId _FileOutputStream11401;
		public FileOutputStream(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._FileOutputStream11401, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _FileOutputStream11402;
		public FileOutputStream(java.lang.String arg0, bool arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._FileOutputStream11402, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _FileOutputStream11403;
		public FileOutputStream(java.io.File arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._FileOutputStream11403, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _FileOutputStream11404;
		public FileOutputStream(java.io.File arg0, bool arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._FileOutputStream11404, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _FileOutputStream11405;
		public FileOutputStream(java.io.FileDescriptor arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.io.FileOutputStream.staticClass, global::java.io.FileOutputStream._FileOutputStream11405, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.io.FileOutputStream.staticClass = @__class;
			global::java.io.FileOutputStream._write11395 = @__env.GetMethodID(global::java.io.FileOutputStream.staticClass, "write", "(I)V");
			global::java.io.FileOutputStream._write11396 = @__env.GetMethodID(global::java.io.FileOutputStream.staticClass, "write", "([B)V");
			global::java.io.FileOutputStream._write11397 = @__env.GetMethodID(global::java.io.FileOutputStream.staticClass, "write", "([BII)V");
			global::java.io.FileOutputStream._close11398 = @__env.GetMethodID(global::java.io.FileOutputStream.staticClass, "close", "()V");
			global::java.io.FileOutputStream._getFD11399 = @__env.GetMethodID(global::java.io.FileOutputStream.staticClass, "getFD", "()Ljava/io/FileDescriptor;");
			global::java.io.FileOutputStream._getChannel11400 = @__env.GetMethodID(global::java.io.FileOutputStream.staticClass, "getChannel", "()Ljava/nio/channels/FileChannel;");
			global::java.io.FileOutputStream._FileOutputStream11401 = @__env.GetMethodID(global::java.io.FileOutputStream.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.io.FileOutputStream._FileOutputStream11402 = @__env.GetMethodID(global::java.io.FileOutputStream.staticClass, "<init>", "(Ljava/lang/String;Z)V");
			global::java.io.FileOutputStream._FileOutputStream11403 = @__env.GetMethodID(global::java.io.FileOutputStream.staticClass, "<init>", "(Ljava/io/File;)V");
			global::java.io.FileOutputStream._FileOutputStream11404 = @__env.GetMethodID(global::java.io.FileOutputStream.staticClass, "<init>", "(Ljava/io/File;Z)V");
			global::java.io.FileOutputStream._FileOutputStream11405 = @__env.GetMethodID(global::java.io.FileOutputStream.staticClass, "<init>", "(Ljava/io/FileDescriptor;)V");
		}
	}
}
