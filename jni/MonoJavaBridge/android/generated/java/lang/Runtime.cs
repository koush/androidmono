namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Runtime : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Runtime()
		{
			InitJNI();
		}
		protected Runtime(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _exit20429;
		public virtual void exit(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Runtime._exit20429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._exit20429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _runFinalizersOnExit20430;
		public static void runFinalizersOnExit(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.Runtime.staticClass, global::java.lang.Runtime._runFinalizersOnExit20430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _loadLibrary20431;
		public virtual void loadLibrary(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Runtime._loadLibrary20431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._loadLibrary20431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _load20432;
		public virtual void load(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Runtime._load20432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._load20432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _gc20433;
		public virtual void gc()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Runtime._gc20433);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._gc20433);
		}
		internal static global::MonoJavaBridge.MethodId _runFinalization20434;
		public virtual void runFinalization()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Runtime._runFinalization20434);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._runFinalization20434);
		}
		internal static global::MonoJavaBridge.MethodId _getRuntime20435;
		public static global::java.lang.Runtime getRuntime()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Runtime.staticClass, global::java.lang.Runtime._getRuntime20435)) as java.lang.Runtime;
		}
		internal static global::MonoJavaBridge.MethodId _freeMemory20436;
		public virtual long freeMemory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.lang.Runtime._freeMemory20436);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._freeMemory20436);
		}
		internal static global::MonoJavaBridge.MethodId _maxMemory20437;
		public virtual long maxMemory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.lang.Runtime._maxMemory20437);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._maxMemory20437);
		}
		internal static global::MonoJavaBridge.MethodId _addShutdownHook20438;
		public virtual void addShutdownHook(java.lang.Thread arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Runtime._addShutdownHook20438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._addShutdownHook20438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeShutdownHook20439;
		public virtual bool removeShutdownHook(java.lang.Thread arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Runtime._removeShutdownHook20439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._removeShutdownHook20439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _halt20440;
		public virtual void halt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Runtime._halt20440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._halt20440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _exec20441;
		public virtual global::java.lang.Process exec(java.lang.String arg0, java.lang.String[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Runtime._exec20441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Process;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._exec20441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Process;
		}
		internal static global::MonoJavaBridge.MethodId _exec20442;
		public virtual global::java.lang.Process exec(java.lang.String[] arg0, java.lang.String[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Runtime._exec20442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Process;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._exec20442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Process;
		}
		internal static global::MonoJavaBridge.MethodId _exec20443;
		public virtual global::java.lang.Process exec(java.lang.String[] arg0, java.lang.String[] arg1, java.io.File arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Runtime._exec20443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Process;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._exec20443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Process;
		}
		internal static global::MonoJavaBridge.MethodId _exec20444;
		public virtual global::java.lang.Process exec(java.lang.String arg0, java.lang.String[] arg1, java.io.File arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Runtime._exec20444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Process;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._exec20444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Process;
		}
		internal static global::MonoJavaBridge.MethodId _exec20445;
		public virtual global::java.lang.Process exec(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Runtime._exec20445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Process;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._exec20445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Process;
		}
		internal static global::MonoJavaBridge.MethodId _exec20446;
		public virtual global::java.lang.Process exec(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Runtime._exec20446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Process;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._exec20446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Process;
		}
		internal static global::MonoJavaBridge.MethodId _availableProcessors20447;
		public virtual int availableProcessors()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Runtime._availableProcessors20447);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._availableProcessors20447);
		}
		internal static global::MonoJavaBridge.MethodId _totalMemory20448;
		public virtual long totalMemory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.lang.Runtime._totalMemory20448);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._totalMemory20448);
		}
		internal static global::MonoJavaBridge.MethodId _traceInstructions20449;
		public virtual void traceInstructions(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Runtime._traceInstructions20449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._traceInstructions20449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _traceMethodCalls20450;
		public virtual void traceMethodCalls(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Runtime._traceMethodCalls20450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._traceMethodCalls20450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLocalizedInputStream20451;
		public virtual global::java.io.InputStream getLocalizedInputStream(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Runtime._getLocalizedInputStream20451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._getLocalizedInputStream20451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalizedOutputStream20452;
		public virtual global::java.io.OutputStream getLocalizedOutputStream(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Runtime._getLocalizedOutputStream20452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.OutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._getLocalizedOutputStream20452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.OutputStream;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Runtime.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Runtime"));
			global::java.lang.Runtime._exit20429 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "exit", "(I)V");
			global::java.lang.Runtime._runFinalizersOnExit20430 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Runtime.staticClass, "runFinalizersOnExit", "(Z)V");
			global::java.lang.Runtime._loadLibrary20431 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "loadLibrary", "(Ljava/lang/String;)V");
			global::java.lang.Runtime._load20432 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "load", "(Ljava/lang/String;)V");
			global::java.lang.Runtime._gc20433 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "gc", "()V");
			global::java.lang.Runtime._runFinalization20434 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "runFinalization", "()V");
			global::java.lang.Runtime._getRuntime20435 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Runtime.staticClass, "getRuntime", "()Ljava/lang/Runtime;");
			global::java.lang.Runtime._freeMemory20436 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "freeMemory", "()J");
			global::java.lang.Runtime._maxMemory20437 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "maxMemory", "()J");
			global::java.lang.Runtime._addShutdownHook20438 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "addShutdownHook", "(Ljava/lang/Thread;)V");
			global::java.lang.Runtime._removeShutdownHook20439 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "removeShutdownHook", "(Ljava/lang/Thread;)Z");
			global::java.lang.Runtime._halt20440 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "halt", "(I)V");
			global::java.lang.Runtime._exec20441 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "exec", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/Process;");
			global::java.lang.Runtime._exec20442 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "exec", "([Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/Process;");
			global::java.lang.Runtime._exec20443 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "exec", "([Ljava/lang/String;[Ljava/lang/String;Ljava/io/File;)Ljava/lang/Process;");
			global::java.lang.Runtime._exec20444 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "exec", "(Ljava/lang/String;[Ljava/lang/String;Ljava/io/File;)Ljava/lang/Process;");
			global::java.lang.Runtime._exec20445 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "exec", "([Ljava/lang/String;)Ljava/lang/Process;");
			global::java.lang.Runtime._exec20446 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "exec", "(Ljava/lang/String;)Ljava/lang/Process;");
			global::java.lang.Runtime._availableProcessors20447 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "availableProcessors", "()I");
			global::java.lang.Runtime._totalMemory20448 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "totalMemory", "()J");
			global::java.lang.Runtime._traceInstructions20449 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "traceInstructions", "(Z)V");
			global::java.lang.Runtime._traceMethodCalls20450 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "traceMethodCalls", "(Z)V");
			global::java.lang.Runtime._getLocalizedInputStream20451 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "getLocalizedInputStream", "(Ljava/io/InputStream;)Ljava/io/InputStream;");
			global::java.lang.Runtime._getLocalizedOutputStream20452 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "getLocalizedOutputStream", "(Ljava/io/OutputStream;)Ljava/io/OutputStream;");
		}
	}
}
