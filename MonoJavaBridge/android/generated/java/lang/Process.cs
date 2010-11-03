namespace java.lang
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.lang.Process_))]
	public abstract partial class Process : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Process(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract void destroy();
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract global::java.io.InputStream getInputStream();
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract global::java.io.OutputStream getOutputStream();
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract global::java.io.InputStream getErrorStream();
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract int waitFor();
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract int exitValue();
		private static global::MonoJavaBridge.MethodId _m6;
		public Process() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Process._m6.native == global::System.IntPtr.Zero)
				global::java.lang.Process._m6 = @__env.GetMethodIDNoThrow(global::java.lang.Process.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Process.staticClass, global::java.lang.Process._m6);
			Init(@__env, handle);
		}
		static Process()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Process.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Process"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.Process))]
	internal sealed partial class Process_ : java.lang.Process
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Process_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void destroy()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Process_.staticClass, "destroy", "()V", ref global::java.lang.Process_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.io.InputStream getInputStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Process_.staticClass, "getInputStream", "()Ljava/io/InputStream;", ref global::java.lang.Process_._m1) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.io.OutputStream getOutputStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Process_.staticClass, "getOutputStream", "()Ljava/io/OutputStream;", ref global::java.lang.Process_._m2) as java.io.OutputStream;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.io.InputStream getErrorStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Process_.staticClass, "getErrorStream", "()Ljava/io/InputStream;", ref global::java.lang.Process_._m3) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int waitFor()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Process_.staticClass, "waitFor", "()I", ref global::java.lang.Process_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override int exitValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Process_.staticClass, "exitValue", "()I", ref global::java.lang.Process_._m5);
		}
		static Process_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Process_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Process"));
		}
	}
}
