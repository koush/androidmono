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
		internal static global::MonoJavaBridge.MethodId _start20298;
		public global::java.lang.Process start() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ProcessBuilder._start20298)) as java.lang.Process;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ProcessBuilder.staticClass, global::java.lang.ProcessBuilder._start20298)) as java.lang.Process;
		}
		internal static global::MonoJavaBridge.MethodId _environment20299;
		public global::java.util.Map environment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ProcessBuilder._environment20299)) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ProcessBuilder.staticClass, global::java.lang.ProcessBuilder._environment20299)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _directory20300;
		public global::java.lang.ProcessBuilder directory(java.io.File arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.ProcessBuilder>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ProcessBuilder._directory20300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.ProcessBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.ProcessBuilder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ProcessBuilder.staticClass, global::java.lang.ProcessBuilder._directory20300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.ProcessBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _directory20301;
		public global::java.io.File directory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ProcessBuilder._directory20301)) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ProcessBuilder.staticClass, global::java.lang.ProcessBuilder._directory20301)) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _command20302;
		public global::java.lang.ProcessBuilder command(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.ProcessBuilder>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ProcessBuilder._command20302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.ProcessBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.ProcessBuilder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ProcessBuilder.staticClass, global::java.lang.ProcessBuilder._command20302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.ProcessBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _command20303;
		public global::java.util.List command() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ProcessBuilder._command20303)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ProcessBuilder.staticClass, global::java.lang.ProcessBuilder._command20303)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _command20304;
		public global::java.lang.ProcessBuilder command(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.ProcessBuilder>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ProcessBuilder._command20304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.ProcessBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.ProcessBuilder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ProcessBuilder.staticClass, global::java.lang.ProcessBuilder._command20304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.ProcessBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _redirectErrorStream20305;
		public bool redirectErrorStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.ProcessBuilder._redirectErrorStream20305);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.ProcessBuilder.staticClass, global::java.lang.ProcessBuilder._redirectErrorStream20305);
		}
		internal static global::MonoJavaBridge.MethodId _redirectErrorStream20306;
		public global::java.lang.ProcessBuilder redirectErrorStream(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.ProcessBuilder>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ProcessBuilder._redirectErrorStream20306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.ProcessBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.ProcessBuilder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ProcessBuilder.staticClass, global::java.lang.ProcessBuilder._redirectErrorStream20306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.ProcessBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _ProcessBuilder20307;
		public ProcessBuilder(java.util.List arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ProcessBuilder.staticClass, global::java.lang.ProcessBuilder._ProcessBuilder20307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ProcessBuilder20308;
		public ProcessBuilder(java.lang.String[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ProcessBuilder.staticClass, global::java.lang.ProcessBuilder._ProcessBuilder20308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.ProcessBuilder.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ProcessBuilder"));
			global::java.lang.ProcessBuilder._start20298 = @__env.GetMethodIDNoThrow(global::java.lang.ProcessBuilder.staticClass, "start", "()Ljava/lang/Process;");
			global::java.lang.ProcessBuilder._environment20299 = @__env.GetMethodIDNoThrow(global::java.lang.ProcessBuilder.staticClass, "environment", "()Ljava/util/Map;");
			global::java.lang.ProcessBuilder._directory20300 = @__env.GetMethodIDNoThrow(global::java.lang.ProcessBuilder.staticClass, "directory", "(Ljava/io/File;)Ljava/lang/ProcessBuilder;");
			global::java.lang.ProcessBuilder._directory20301 = @__env.GetMethodIDNoThrow(global::java.lang.ProcessBuilder.staticClass, "directory", "()Ljava/io/File;");
			global::java.lang.ProcessBuilder._command20302 = @__env.GetMethodIDNoThrow(global::java.lang.ProcessBuilder.staticClass, "command", "(Ljava/util/List;)Ljava/lang/ProcessBuilder;");
			global::java.lang.ProcessBuilder._command20303 = @__env.GetMethodIDNoThrow(global::java.lang.ProcessBuilder.staticClass, "command", "()Ljava/util/List;");
			global::java.lang.ProcessBuilder._command20304 = @__env.GetMethodIDNoThrow(global::java.lang.ProcessBuilder.staticClass, "command", "([Ljava/lang/String;)Ljava/lang/ProcessBuilder;");
			global::java.lang.ProcessBuilder._redirectErrorStream20305 = @__env.GetMethodIDNoThrow(global::java.lang.ProcessBuilder.staticClass, "redirectErrorStream", "()Z");
			global::java.lang.ProcessBuilder._redirectErrorStream20306 = @__env.GetMethodIDNoThrow(global::java.lang.ProcessBuilder.staticClass, "redirectErrorStream", "(Z)Ljava/lang/ProcessBuilder;");
			global::java.lang.ProcessBuilder._ProcessBuilder20307 = @__env.GetMethodIDNoThrow(global::java.lang.ProcessBuilder.staticClass, "<init>", "(Ljava/util/List;)V");
			global::java.lang.ProcessBuilder._ProcessBuilder20308 = @__env.GetMethodIDNoThrow(global::java.lang.ProcessBuilder.staticClass, "<init>", "([Ljava/lang/String;)V");
		}
	}
}
