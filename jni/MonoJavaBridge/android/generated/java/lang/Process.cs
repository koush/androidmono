namespace java.lang
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.lang.Process_))]
	public abstract partial class Process : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Process()
		{
			InitJNI();
		}
		protected Process(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _destroy14771;
		public abstract void destroy();
		internal static global::MonoJavaBridge.MethodId _getInputStream14772;
		public abstract global::java.io.InputStream getInputStream();
		internal static global::MonoJavaBridge.MethodId _getOutputStream14773;
		public abstract global::java.io.OutputStream getOutputStream();
		internal static global::MonoJavaBridge.MethodId _getErrorStream14774;
		public abstract global::java.io.InputStream getErrorStream();
		internal static global::MonoJavaBridge.MethodId _waitFor14775;
		public abstract int waitFor();
		internal static global::MonoJavaBridge.MethodId _exitValue14776;
		public abstract int exitValue();
		internal static global::MonoJavaBridge.MethodId _Process14777;
		public Process()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Process.staticClass, global::java.lang.Process._Process14777);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Process.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Process"));
			global::java.lang.Process._destroy14771 = @__env.GetMethodIDNoThrow(global::java.lang.Process.staticClass, "destroy", "()V");
			global::java.lang.Process._getInputStream14772 = @__env.GetMethodIDNoThrow(global::java.lang.Process.staticClass, "getInputStream", "()Ljava/io/InputStream;");
			global::java.lang.Process._getOutputStream14773 = @__env.GetMethodIDNoThrow(global::java.lang.Process.staticClass, "getOutputStream", "()Ljava/io/OutputStream;");
			global::java.lang.Process._getErrorStream14774 = @__env.GetMethodIDNoThrow(global::java.lang.Process.staticClass, "getErrorStream", "()Ljava/io/InputStream;");
			global::java.lang.Process._waitFor14775 = @__env.GetMethodIDNoThrow(global::java.lang.Process.staticClass, "waitFor", "()I");
			global::java.lang.Process._exitValue14776 = @__env.GetMethodIDNoThrow(global::java.lang.Process.staticClass, "exitValue", "()I");
			global::java.lang.Process._Process14777 = @__env.GetMethodIDNoThrow(global::java.lang.Process.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.Process))]
	public sealed partial class Process_ : java.lang.Process
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Process_()
		{
			InitJNI();
		}
		internal Process_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _destroy14778;
		public override void destroy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Process_._destroy14778);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Process_.staticClass, global::java.lang.Process_._destroy14778);
		}
		internal static global::MonoJavaBridge.MethodId _getInputStream14779;
		public override global::java.io.InputStream getInputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Process_._getInputStream14779)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Process_.staticClass, global::java.lang.Process_._getInputStream14779)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getOutputStream14780;
		public override global::java.io.OutputStream getOutputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Process_._getOutputStream14780)) as java.io.OutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Process_.staticClass, global::java.lang.Process_._getOutputStream14780)) as java.io.OutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getErrorStream14781;
		public override global::java.io.InputStream getErrorStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Process_._getErrorStream14781)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Process_.staticClass, global::java.lang.Process_._getErrorStream14781)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _waitFor14782;
		public override int waitFor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Process_._waitFor14782);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Process_.staticClass, global::java.lang.Process_._waitFor14782);
		}
		internal static global::MonoJavaBridge.MethodId _exitValue14783;
		public override int exitValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Process_._exitValue14783);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Process_.staticClass, global::java.lang.Process_._exitValue14783);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Process_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Process"));
			global::java.lang.Process_._destroy14778 = @__env.GetMethodIDNoThrow(global::java.lang.Process_.staticClass, "destroy", "()V");
			global::java.lang.Process_._getInputStream14779 = @__env.GetMethodIDNoThrow(global::java.lang.Process_.staticClass, "getInputStream", "()Ljava/io/InputStream;");
			global::java.lang.Process_._getOutputStream14780 = @__env.GetMethodIDNoThrow(global::java.lang.Process_.staticClass, "getOutputStream", "()Ljava/io/OutputStream;");
			global::java.lang.Process_._getErrorStream14781 = @__env.GetMethodIDNoThrow(global::java.lang.Process_.staticClass, "getErrorStream", "()Ljava/io/InputStream;");
			global::java.lang.Process_._waitFor14782 = @__env.GetMethodIDNoThrow(global::java.lang.Process_.staticClass, "waitFor", "()I");
			global::java.lang.Process_._exitValue14783 = @__env.GetMethodIDNoThrow(global::java.lang.Process_.staticClass, "exitValue", "()I");
		}
	}
}
