namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ProcessBuilder : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ProcessBuilder()
		{
			InitJNI();
		}
		internal ProcessBuilder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _start14784;
		public global::java.lang.Process start() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ProcessBuilder._start14784)) as java.lang.Process;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ProcessBuilder.staticClass, global::java.lang.ProcessBuilder._start14784)) as java.lang.Process;
		}
		internal static global::MonoJavaBridge.MethodId _environment14785;
		public global::java.util.Map environment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ProcessBuilder._environment14785)) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ProcessBuilder.staticClass, global::java.lang.ProcessBuilder._environment14785)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _directory14786;
		public global::java.lang.ProcessBuilder directory(java.io.File arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ProcessBuilder._directory14786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.ProcessBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ProcessBuilder.staticClass, global::java.lang.ProcessBuilder._directory14786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.ProcessBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _directory14787;
		public global::java.io.File directory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ProcessBuilder._directory14787)) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ProcessBuilder.staticClass, global::java.lang.ProcessBuilder._directory14787)) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _command14788;
		public global::java.lang.ProcessBuilder command(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ProcessBuilder._command14788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.ProcessBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ProcessBuilder.staticClass, global::java.lang.ProcessBuilder._command14788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.ProcessBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _command14789;
		public global::java.util.List command() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ProcessBuilder._command14789)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ProcessBuilder.staticClass, global::java.lang.ProcessBuilder._command14789)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _command14790;
		public global::java.lang.ProcessBuilder command(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ProcessBuilder._command14790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.ProcessBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ProcessBuilder.staticClass, global::java.lang.ProcessBuilder._command14790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.ProcessBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _redirectErrorStream14791;
		public bool redirectErrorStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.ProcessBuilder._redirectErrorStream14791);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.ProcessBuilder.staticClass, global::java.lang.ProcessBuilder._redirectErrorStream14791);
		}
		internal static global::MonoJavaBridge.MethodId _redirectErrorStream14792;
		public global::java.lang.ProcessBuilder redirectErrorStream(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ProcessBuilder._redirectErrorStream14792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.ProcessBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ProcessBuilder.staticClass, global::java.lang.ProcessBuilder._redirectErrorStream14792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.ProcessBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _ProcessBuilder14793;
		public ProcessBuilder(java.util.List arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ProcessBuilder.staticClass, global::java.lang.ProcessBuilder._ProcessBuilder14793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ProcessBuilder14794;
		public ProcessBuilder(java.lang.String[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ProcessBuilder.staticClass, global::java.lang.ProcessBuilder._ProcessBuilder14794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.ProcessBuilder.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ProcessBuilder"));
			global::java.lang.ProcessBuilder._start14784 = @__env.GetMethodIDNoThrow(global::java.lang.ProcessBuilder.staticClass, "start", "()Ljava/lang/Process;");
			global::java.lang.ProcessBuilder._environment14785 = @__env.GetMethodIDNoThrow(global::java.lang.ProcessBuilder.staticClass, "environment", "()Ljava/util/Map;");
			global::java.lang.ProcessBuilder._directory14786 = @__env.GetMethodIDNoThrow(global::java.lang.ProcessBuilder.staticClass, "directory", "(Ljava/io/File;)Ljava/lang/ProcessBuilder;");
			global::java.lang.ProcessBuilder._directory14787 = @__env.GetMethodIDNoThrow(global::java.lang.ProcessBuilder.staticClass, "directory", "()Ljava/io/File;");
			global::java.lang.ProcessBuilder._command14788 = @__env.GetMethodIDNoThrow(global::java.lang.ProcessBuilder.staticClass, "command", "(Ljava/util/List;)Ljava/lang/ProcessBuilder;");
			global::java.lang.ProcessBuilder._command14789 = @__env.GetMethodIDNoThrow(global::java.lang.ProcessBuilder.staticClass, "command", "()Ljava/util/List;");
			global::java.lang.ProcessBuilder._command14790 = @__env.GetMethodIDNoThrow(global::java.lang.ProcessBuilder.staticClass, "command", "([Ljava/lang/String;)Ljava/lang/ProcessBuilder;");
			global::java.lang.ProcessBuilder._redirectErrorStream14791 = @__env.GetMethodIDNoThrow(global::java.lang.ProcessBuilder.staticClass, "redirectErrorStream", "()Z");
			global::java.lang.ProcessBuilder._redirectErrorStream14792 = @__env.GetMethodIDNoThrow(global::java.lang.ProcessBuilder.staticClass, "redirectErrorStream", "(Z)Ljava/lang/ProcessBuilder;");
			global::java.lang.ProcessBuilder._ProcessBuilder14793 = @__env.GetMethodIDNoThrow(global::java.lang.ProcessBuilder.staticClass, "<init>", "(Ljava/util/List;)V");
			global::java.lang.ProcessBuilder._ProcessBuilder14794 = @__env.GetMethodIDNoThrow(global::java.lang.ProcessBuilder.staticClass, "<init>", "([Ljava/lang/String;)V");
		}
	}
}
