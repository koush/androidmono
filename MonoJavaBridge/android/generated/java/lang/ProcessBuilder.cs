namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ProcessBuilder : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ProcessBuilder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _start20416;
		public global::java.lang.Process start()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.ProcessBuilder.staticClass, "start", "()Ljava/lang/Process;", ref global::java.lang.ProcessBuilder._start20416) as java.lang.Process;
		}
		internal static global::MonoJavaBridge.MethodId _environment20417;
		public global::java.util.Map environment()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map>(this, global::java.lang.ProcessBuilder.staticClass, "environment", "()Ljava/util/Map;", ref global::java.lang.ProcessBuilder._environment20417) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _directory20418;
		public global::java.lang.ProcessBuilder directory(java.io.File arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.ProcessBuilder>(this, global::java.lang.ProcessBuilder.staticClass, "directory", "(Ljava/io/File;)Ljava/lang/ProcessBuilder;", ref global::java.lang.ProcessBuilder._directory20418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.ProcessBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _directory20419;
		public global::java.io.File directory()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.ProcessBuilder.staticClass, "directory", "()Ljava/io/File;", ref global::java.lang.ProcessBuilder._directory20419) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _command20420;
		public global::java.lang.ProcessBuilder command(java.util.List arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.ProcessBuilder>(this, global::java.lang.ProcessBuilder.staticClass, "command", "(Ljava/util/List;)Ljava/lang/ProcessBuilder;", ref global::java.lang.ProcessBuilder._command20420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.ProcessBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _command20421;
		public global::java.util.List command()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::java.lang.ProcessBuilder.staticClass, "command", "()Ljava/util/List;", ref global::java.lang.ProcessBuilder._command20421) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _command20422;
		public global::java.lang.ProcessBuilder command(java.lang.String[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.ProcessBuilder>(this, global::java.lang.ProcessBuilder.staticClass, "command", "([Ljava/lang/String;)Ljava/lang/ProcessBuilder;", ref global::java.lang.ProcessBuilder._command20422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.ProcessBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _redirectErrorStream20423;
		public bool redirectErrorStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.ProcessBuilder.staticClass, "redirectErrorStream", "()Z", ref global::java.lang.ProcessBuilder._redirectErrorStream20423);
		}
		internal static global::MonoJavaBridge.MethodId _redirectErrorStream20424;
		public global::java.lang.ProcessBuilder redirectErrorStream(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.ProcessBuilder>(this, global::java.lang.ProcessBuilder.staticClass, "redirectErrorStream", "(Z)Ljava/lang/ProcessBuilder;", ref global::java.lang.ProcessBuilder._redirectErrorStream20424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.ProcessBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _ProcessBuilder20425;
		public ProcessBuilder(java.util.List arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ProcessBuilder._ProcessBuilder20425.native == global::System.IntPtr.Zero)
				global::java.lang.ProcessBuilder._ProcessBuilder20425 = @__env.GetMethodIDNoThrow(global::java.lang.ProcessBuilder.staticClass, "<init>", "(Ljava/util/List;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ProcessBuilder.staticClass, global::java.lang.ProcessBuilder._ProcessBuilder20425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ProcessBuilder20426;
		public ProcessBuilder(java.lang.String[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ProcessBuilder._ProcessBuilder20426.native == global::System.IntPtr.Zero)
				global::java.lang.ProcessBuilder._ProcessBuilder20426 = @__env.GetMethodIDNoThrow(global::java.lang.ProcessBuilder.staticClass, "<init>", "([Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ProcessBuilder.staticClass, global::java.lang.ProcessBuilder._ProcessBuilder20426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ProcessBuilder()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.ProcessBuilder.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ProcessBuilder"));
		}
		internal static void InitJNI()
		{
		}
	}
}
