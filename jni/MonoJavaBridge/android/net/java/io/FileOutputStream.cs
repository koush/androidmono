namespace java.io 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class FileOutputStream : java.io.OutputStream
	{ 
		internal static global::java.lang.Class staticClass; 
		static FileOutputStream() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.io.FileOutputStream), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _write10573; 
		public override void write(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.FileOutputStream)) 
				@__env.CallVoidMethod(this, _write10573, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.FileOutputStream.staticClass, _write10573, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _write10574; 
		public override void write(byte[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.FileOutputStream)) 
				@__env.CallVoidMethod(this, _write10574, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.FileOutputStream.staticClass, _write10574, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _write10575; 
		public override void write(byte[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.FileOutputStream)) 
				@__env.CallVoidMethod(this, _write10575, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.FileOutputStream.staticClass, _write10575, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close10576; 
		public override void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.FileOutputStream)) 
				@__env.CallVoidMethod(this, _close10576); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.FileOutputStream.staticClass, _close10576); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFD10577; 
		public virtual java.io.FileDescriptor getFD() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.FileOutputStream)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, _getFD10577)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.io.FileOutputStream.staticClass, _getFD10577)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChannel10578; 
		public virtual java.nio.channels.FileChannel getChannel() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.FileOutputStream)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.FileChannel>(@__env, @__env.CallObjectMethodPtr(this, _getChannel10578)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.FileChannel>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.io.FileOutputStream.staticClass, _getChannel10578)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _FileOutputStream10579; 
		public FileOutputStream(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.io.FileOutputStream.staticClass, _FileOutputStream10579, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _FileOutputStream10580; 
		public FileOutputStream(java.lang.String arg0, bool arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.io.FileOutputStream.staticClass, _FileOutputStream10580, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _FileOutputStream10581; 
		public FileOutputStream(java.io.File arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.io.FileOutputStream.staticClass, _FileOutputStream10581, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _FileOutputStream10582; 
		public FileOutputStream(java.io.File arg0, bool arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.io.FileOutputStream.staticClass, _FileOutputStream10582, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _FileOutputStream10583; 
		public FileOutputStream(java.io.FileDescriptor arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.io.FileOutputStream.staticClass, _FileOutputStream10583, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.io.FileOutputStream.staticClass = @__class; 
			global::java.io.FileOutputStream._write10573 = @__env.GetMethodID(global::java.io.FileOutputStream.staticClass, "write", "(I)V"); 
			global::java.io.FileOutputStream._write10574 = @__env.GetMethodID(global::java.io.FileOutputStream.staticClass, "write", "([B)V"); 
			global::java.io.FileOutputStream._write10575 = @__env.GetMethodID(global::java.io.FileOutputStream.staticClass, "write", "([BII)V"); 
			global::java.io.FileOutputStream._close10576 = @__env.GetMethodID(global::java.io.FileOutputStream.staticClass, "close", "()V"); 
			global::java.io.FileOutputStream._getFD10577 = @__env.GetMethodID(global::java.io.FileOutputStream.staticClass, "getFD", "()Ljava/io/FileDescriptor;"); 
			global::java.io.FileOutputStream._getChannel10578 = @__env.GetMethodID(global::java.io.FileOutputStream.staticClass, "getChannel", "()Ljava/nio/channels/FileChannel;"); 
			global::java.io.FileOutputStream._FileOutputStream10579 = @__env.GetMethodID(global::java.io.FileOutputStream.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			global::java.io.FileOutputStream._FileOutputStream10580 = @__env.GetMethodID(global::java.io.FileOutputStream.staticClass, "<init>", "(Ljava/lang/String;Z)V"); 
			global::java.io.FileOutputStream._FileOutputStream10581 = @__env.GetMethodID(global::java.io.FileOutputStream.staticClass, "<init>", "(Ljava/io/File;)V"); 
			global::java.io.FileOutputStream._FileOutputStream10582 = @__env.GetMethodID(global::java.io.FileOutputStream.staticClass, "<init>", "(Ljava/io/File;Z)V"); 
			global::java.io.FileOutputStream._FileOutputStream10583 = @__env.GetMethodID(global::java.io.FileOutputStream.staticClass, "<init>", "(Ljava/io/FileDescriptor;)V"); 
		} 
	} 
} 
