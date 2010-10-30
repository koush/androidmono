namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Runtime : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Runtime(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _exit20430;
		public virtual void exit(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Runtime.staticClass, "exit", "(I)V", ref global::java.lang.Runtime._exit20430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _runFinalizersOnExit20431;
		public static void runFinalizersOnExit(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Runtime._runFinalizersOnExit20431.native == global::System.IntPtr.Zero)
				global::java.lang.Runtime._runFinalizersOnExit20431 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Runtime.staticClass, "runFinalizersOnExit", "(Z)V");
			@__env.CallStaticVoidMethod(java.lang.Runtime.staticClass, global::java.lang.Runtime._runFinalizersOnExit20431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _loadLibrary20432;
		public virtual void loadLibrary(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Runtime.staticClass, "loadLibrary", "(Ljava/lang/String;)V", ref global::java.lang.Runtime._loadLibrary20432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _load20433;
		public virtual void load(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Runtime.staticClass, "load", "(Ljava/lang/String;)V", ref global::java.lang.Runtime._load20433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _gc20434;
		public virtual void gc()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Runtime.staticClass, "gc", "()V", ref global::java.lang.Runtime._gc20434);
		}
		internal static global::MonoJavaBridge.MethodId _runFinalization20435;
		public virtual void runFinalization()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Runtime.staticClass, "runFinalization", "()V", ref global::java.lang.Runtime._runFinalization20435);
		}
		internal static global::MonoJavaBridge.MethodId _getRuntime20436;
		public static global::java.lang.Runtime getRuntime()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Runtime._getRuntime20436.native == global::System.IntPtr.Zero)
				global::java.lang.Runtime._getRuntime20436 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Runtime.staticClass, "getRuntime", "()Ljava/lang/Runtime;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Runtime.staticClass, global::java.lang.Runtime._getRuntime20436)) as java.lang.Runtime;
		}
		internal static global::MonoJavaBridge.MethodId _freeMemory20437;
		public virtual long freeMemory()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.lang.Runtime.staticClass, "freeMemory", "()J", ref global::java.lang.Runtime._freeMemory20437);
		}
		internal static global::MonoJavaBridge.MethodId _maxMemory20438;
		public virtual long maxMemory()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.lang.Runtime.staticClass, "maxMemory", "()J", ref global::java.lang.Runtime._maxMemory20438);
		}
		internal static global::MonoJavaBridge.MethodId _addShutdownHook20439;
		public virtual void addShutdownHook(java.lang.Thread arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Runtime.staticClass, "addShutdownHook", "(Ljava/lang/Thread;)V", ref global::java.lang.Runtime._addShutdownHook20439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeShutdownHook20440;
		public virtual bool removeShutdownHook(java.lang.Thread arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Runtime.staticClass, "removeShutdownHook", "(Ljava/lang/Thread;)Z", ref global::java.lang.Runtime._removeShutdownHook20440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _halt20441;
		public virtual void halt(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Runtime.staticClass, "halt", "(I)V", ref global::java.lang.Runtime._halt20441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _exec20442;
		public virtual global::java.lang.Process exec(java.lang.String arg0, java.lang.String[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Runtime.staticClass, "exec", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/Process;", ref global::java.lang.Runtime._exec20442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Process;
		}
		internal static global::MonoJavaBridge.MethodId _exec20443;
		public virtual global::java.lang.Process exec(java.lang.String[] arg0, java.lang.String[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Runtime.staticClass, "exec", "([Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/Process;", ref global::java.lang.Runtime._exec20443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Process;
		}
		internal static global::MonoJavaBridge.MethodId _exec20444;
		public virtual global::java.lang.Process exec(java.lang.String[] arg0, java.lang.String[] arg1, java.io.File arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Runtime.staticClass, "exec", "([Ljava/lang/String;[Ljava/lang/String;Ljava/io/File;)Ljava/lang/Process;", ref global::java.lang.Runtime._exec20444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Process;
		}
		internal static global::MonoJavaBridge.MethodId _exec20445;
		public virtual global::java.lang.Process exec(java.lang.String arg0, java.lang.String[] arg1, java.io.File arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Runtime.staticClass, "exec", "(Ljava/lang/String;[Ljava/lang/String;Ljava/io/File;)Ljava/lang/Process;", ref global::java.lang.Runtime._exec20445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Process;
		}
		internal static global::MonoJavaBridge.MethodId _exec20446;
		public virtual global::java.lang.Process exec(java.lang.String[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Runtime.staticClass, "exec", "([Ljava/lang/String;)Ljava/lang/Process;", ref global::java.lang.Runtime._exec20446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Process;
		}
		internal static global::MonoJavaBridge.MethodId _exec20447;
		public virtual global::java.lang.Process exec(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Runtime.staticClass, "exec", "(Ljava/lang/String;)Ljava/lang/Process;", ref global::java.lang.Runtime._exec20447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Process;
		}
		internal static global::MonoJavaBridge.MethodId _availableProcessors20448;
		public virtual int availableProcessors()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Runtime.staticClass, "availableProcessors", "()I", ref global::java.lang.Runtime._availableProcessors20448);
		}
		internal static global::MonoJavaBridge.MethodId _totalMemory20449;
		public virtual long totalMemory()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.lang.Runtime.staticClass, "totalMemory", "()J", ref global::java.lang.Runtime._totalMemory20449);
		}
		internal static global::MonoJavaBridge.MethodId _traceInstructions20450;
		public virtual void traceInstructions(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Runtime.staticClass, "traceInstructions", "(Z)V", ref global::java.lang.Runtime._traceInstructions20450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _traceMethodCalls20451;
		public virtual void traceMethodCalls(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Runtime.staticClass, "traceMethodCalls", "(Z)V", ref global::java.lang.Runtime._traceMethodCalls20451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLocalizedInputStream20452;
		public virtual global::java.io.InputStream getLocalizedInputStream(java.io.InputStream arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Runtime.staticClass, "getLocalizedInputStream", "(Ljava/io/InputStream;)Ljava/io/InputStream;", ref global::java.lang.Runtime._getLocalizedInputStream20452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalizedOutputStream20453;
		public virtual global::java.io.OutputStream getLocalizedOutputStream(java.io.OutputStream arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Runtime.staticClass, "getLocalizedOutputStream", "(Ljava/io/OutputStream;)Ljava/io/OutputStream;", ref global::java.lang.Runtime._getLocalizedOutputStream20453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.OutputStream;
		}
		static Runtime()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Runtime.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Runtime"));
		}
		internal static void InitJNI()
		{
		}
	}
}
