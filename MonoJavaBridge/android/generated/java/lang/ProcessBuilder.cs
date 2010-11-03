namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ProcessBuilder : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ProcessBuilder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public global::java.lang.Process start()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.ProcessBuilder.staticClass, "start", "()Ljava/lang/Process;", ref global::java.lang.ProcessBuilder._m0) as java.lang.Process;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public global::java.util.Map environment()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map>(this, global::java.lang.ProcessBuilder.staticClass, "environment", "()Ljava/util/Map;", ref global::java.lang.ProcessBuilder._m1) as java.util.Map;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public global::java.lang.ProcessBuilder directory(java.io.File arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.ProcessBuilder>(this, global::java.lang.ProcessBuilder.staticClass, "directory", "(Ljava/io/File;)Ljava/lang/ProcessBuilder;", ref global::java.lang.ProcessBuilder._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.ProcessBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public global::java.io.File directory()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.ProcessBuilder.staticClass, "directory", "()Ljava/io/File;", ref global::java.lang.ProcessBuilder._m3) as java.io.File;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public global::java.lang.ProcessBuilder command(java.util.List arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.ProcessBuilder>(this, global::java.lang.ProcessBuilder.staticClass, "command", "(Ljava/util/List;)Ljava/lang/ProcessBuilder;", ref global::java.lang.ProcessBuilder._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.ProcessBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public global::java.util.List command()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::java.lang.ProcessBuilder.staticClass, "command", "()Ljava/util/List;", ref global::java.lang.ProcessBuilder._m5) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public global::java.lang.ProcessBuilder command(java.lang.String[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.ProcessBuilder>(this, global::java.lang.ProcessBuilder.staticClass, "command", "([Ljava/lang/String;)Ljava/lang/ProcessBuilder;", ref global::java.lang.ProcessBuilder._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.ProcessBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public bool redirectErrorStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.ProcessBuilder.staticClass, "redirectErrorStream", "()Z", ref global::java.lang.ProcessBuilder._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public global::java.lang.ProcessBuilder redirectErrorStream(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.ProcessBuilder>(this, global::java.lang.ProcessBuilder.staticClass, "redirectErrorStream", "(Z)Ljava/lang/ProcessBuilder;", ref global::java.lang.ProcessBuilder._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.ProcessBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public ProcessBuilder(java.util.List arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ProcessBuilder._m9.native == global::System.IntPtr.Zero)
				global::java.lang.ProcessBuilder._m9 = @__env.GetMethodIDNoThrow(global::java.lang.ProcessBuilder.staticClass, "<init>", "(Ljava/util/List;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ProcessBuilder.staticClass, global::java.lang.ProcessBuilder._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public ProcessBuilder(java.lang.String[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ProcessBuilder._m10.native == global::System.IntPtr.Zero)
				global::java.lang.ProcessBuilder._m10 = @__env.GetMethodIDNoThrow(global::java.lang.ProcessBuilder.staticClass, "<init>", "([Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ProcessBuilder.staticClass, global::java.lang.ProcessBuilder._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ProcessBuilder()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.ProcessBuilder.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ProcessBuilder"));
		}
	}
}
