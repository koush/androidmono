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
		internal static global::MonoJavaBridge.MethodId _destroy20285;
		public abstract void destroy();
		internal static global::MonoJavaBridge.MethodId _getInputStream20286;
		public abstract global::java.io.InputStream getInputStream();
		internal static global::MonoJavaBridge.MethodId _getOutputStream20287;
		public abstract global::java.io.OutputStream getOutputStream();
		internal static global::MonoJavaBridge.MethodId _getErrorStream20288;
		public abstract global::java.io.InputStream getErrorStream();
		internal static global::MonoJavaBridge.MethodId _waitFor20289;
		public abstract int waitFor();
		internal static global::MonoJavaBridge.MethodId _exitValue20290;
		public abstract int exitValue();
		internal static global::MonoJavaBridge.MethodId _Process20291;
		public Process()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Process.staticClass, global::java.lang.Process._Process20291);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Process.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Process"));
			global::java.lang.Process._destroy20285 = @__env.GetMethodIDNoThrow(global::java.lang.Process.staticClass, "destroy", "()V");
			global::java.lang.Process._getInputStream20286 = @__env.GetMethodIDNoThrow(global::java.lang.Process.staticClass, "getInputStream", "()Ljava/io/InputStream;");
			global::java.lang.Process._getOutputStream20287 = @__env.GetMethodIDNoThrow(global::java.lang.Process.staticClass, "getOutputStream", "()Ljava/io/OutputStream;");
			global::java.lang.Process._getErrorStream20288 = @__env.GetMethodIDNoThrow(global::java.lang.Process.staticClass, "getErrorStream", "()Ljava/io/InputStream;");
			global::java.lang.Process._waitFor20289 = @__env.GetMethodIDNoThrow(global::java.lang.Process.staticClass, "waitFor", "()I");
			global::java.lang.Process._exitValue20290 = @__env.GetMethodIDNoThrow(global::java.lang.Process.staticClass, "exitValue", "()I");
			global::java.lang.Process._Process20291 = @__env.GetMethodIDNoThrow(global::java.lang.Process.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _destroy20292;
		public override void destroy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Process_._destroy20292);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Process_.staticClass, global::java.lang.Process_._destroy20292);
		}
		internal static global::MonoJavaBridge.MethodId _getInputStream20293;
		public override global::java.io.InputStream getInputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Process_._getInputStream20293)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Process_.staticClass, global::java.lang.Process_._getInputStream20293)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getOutputStream20294;
		public override global::java.io.OutputStream getOutputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Process_._getOutputStream20294)) as java.io.OutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Process_.staticClass, global::java.lang.Process_._getOutputStream20294)) as java.io.OutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getErrorStream20295;
		public override global::java.io.InputStream getErrorStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Process_._getErrorStream20295)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Process_.staticClass, global::java.lang.Process_._getErrorStream20295)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _waitFor20296;
		public override int waitFor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Process_._waitFor20296);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Process_.staticClass, global::java.lang.Process_._waitFor20296);
		}
		internal static global::MonoJavaBridge.MethodId _exitValue20297;
		public override int exitValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Process_._exitValue20297);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Process_.staticClass, global::java.lang.Process_._exitValue20297);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Process_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Process"));
			global::java.lang.Process_._destroy20292 = @__env.GetMethodIDNoThrow(global::java.lang.Process_.staticClass, "destroy", "()V");
			global::java.lang.Process_._getInputStream20293 = @__env.GetMethodIDNoThrow(global::java.lang.Process_.staticClass, "getInputStream", "()Ljava/io/InputStream;");
			global::java.lang.Process_._getOutputStream20294 = @__env.GetMethodIDNoThrow(global::java.lang.Process_.staticClass, "getOutputStream", "()Ljava/io/OutputStream;");
			global::java.lang.Process_._getErrorStream20295 = @__env.GetMethodIDNoThrow(global::java.lang.Process_.staticClass, "getErrorStream", "()Ljava/io/InputStream;");
			global::java.lang.Process_._waitFor20296 = @__env.GetMethodIDNoThrow(global::java.lang.Process_.staticClass, "waitFor", "()I");
			global::java.lang.Process_._exitValue20297 = @__env.GetMethodIDNoThrow(global::java.lang.Process_.staticClass, "exitValue", "()I");
		}
	}
}
