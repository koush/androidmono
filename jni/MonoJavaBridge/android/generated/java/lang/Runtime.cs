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
		internal static global::MonoJavaBridge.MethodId _exit20311;
		public virtual void exit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Runtime._exit20311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._exit20311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _runFinalizersOnExit20312;
		public static void runFinalizersOnExit(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.Runtime.staticClass, global::java.lang.Runtime._runFinalizersOnExit20312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _loadLibrary20313;
		public virtual void loadLibrary(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Runtime._loadLibrary20313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._loadLibrary20313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _load20314;
		public virtual void load(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Runtime._load20314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._load20314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _gc20315;
		public virtual void gc() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Runtime._gc20315);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._gc20315);
		}
		internal static global::MonoJavaBridge.MethodId _runFinalization20316;
		public virtual void runFinalization() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Runtime._runFinalization20316);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._runFinalization20316);
		}
		internal static global::MonoJavaBridge.MethodId _getRuntime20317;
		public static global::java.lang.Runtime getRuntime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Runtime.staticClass, global::java.lang.Runtime._getRuntime20317)) as java.lang.Runtime;
		}
		internal static global::MonoJavaBridge.MethodId _freeMemory20318;
		public virtual long freeMemory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.lang.Runtime._freeMemory20318);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._freeMemory20318);
		}
		internal static global::MonoJavaBridge.MethodId _maxMemory20319;
		public virtual long maxMemory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.lang.Runtime._maxMemory20319);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._maxMemory20319);
		}
		internal static global::MonoJavaBridge.MethodId _addShutdownHook20320;
		public virtual void addShutdownHook(java.lang.Thread arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Runtime._addShutdownHook20320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._addShutdownHook20320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeShutdownHook20321;
		public virtual bool removeShutdownHook(java.lang.Thread arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Runtime._removeShutdownHook20321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._removeShutdownHook20321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _halt20322;
		public virtual void halt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Runtime._halt20322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._halt20322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _exec20323;
		public virtual global::java.lang.Process exec(java.lang.String arg0, java.lang.String[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Runtime._exec20323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Process;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._exec20323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Process;
		}
		internal static global::MonoJavaBridge.MethodId _exec20324;
		public virtual global::java.lang.Process exec(java.lang.String[] arg0, java.lang.String[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Runtime._exec20324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Process;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._exec20324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Process;
		}
		internal static global::MonoJavaBridge.MethodId _exec20325;
		public virtual global::java.lang.Process exec(java.lang.String[] arg0, java.lang.String[] arg1, java.io.File arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Runtime._exec20325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Process;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._exec20325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Process;
		}
		internal static global::MonoJavaBridge.MethodId _exec20326;
		public virtual global::java.lang.Process exec(java.lang.String arg0, java.lang.String[] arg1, java.io.File arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Runtime._exec20326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Process;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._exec20326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Process;
		}
		internal static global::MonoJavaBridge.MethodId _exec20327;
		public virtual global::java.lang.Process exec(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Runtime._exec20327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Process;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._exec20327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Process;
		}
		internal static global::MonoJavaBridge.MethodId _exec20328;
		public virtual global::java.lang.Process exec(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Runtime._exec20328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Process;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._exec20328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Process;
		}
		internal static global::MonoJavaBridge.MethodId _availableProcessors20329;
		public virtual int availableProcessors() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Runtime._availableProcessors20329);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._availableProcessors20329);
		}
		internal static global::MonoJavaBridge.MethodId _totalMemory20330;
		public virtual long totalMemory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.lang.Runtime._totalMemory20330);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._totalMemory20330);
		}
		internal static global::MonoJavaBridge.MethodId _traceInstructions20331;
		public virtual void traceInstructions(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Runtime._traceInstructions20331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._traceInstructions20331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _traceMethodCalls20332;
		public virtual void traceMethodCalls(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Runtime._traceMethodCalls20332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._traceMethodCalls20332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLocalizedInputStream20333;
		public virtual global::java.io.InputStream getLocalizedInputStream(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Runtime._getLocalizedInputStream20333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._getLocalizedInputStream20333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalizedOutputStream20334;
		public virtual global::java.io.OutputStream getLocalizedOutputStream(java.io.OutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Runtime._getLocalizedOutputStream20334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.OutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._getLocalizedOutputStream20334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.OutputStream;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Runtime.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Runtime"));
			global::java.lang.Runtime._exit20311 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "exit", "(I)V");
			global::java.lang.Runtime._runFinalizersOnExit20312 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Runtime.staticClass, "runFinalizersOnExit", "(Z)V");
			global::java.lang.Runtime._loadLibrary20313 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "loadLibrary", "(Ljava/lang/String;)V");
			global::java.lang.Runtime._load20314 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "load", "(Ljava/lang/String;)V");
			global::java.lang.Runtime._gc20315 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "gc", "()V");
			global::java.lang.Runtime._runFinalization20316 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "runFinalization", "()V");
			global::java.lang.Runtime._getRuntime20317 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Runtime.staticClass, "getRuntime", "()Ljava/lang/Runtime;");
			global::java.lang.Runtime._freeMemory20318 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "freeMemory", "()J");
			global::java.lang.Runtime._maxMemory20319 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "maxMemory", "()J");
			global::java.lang.Runtime._addShutdownHook20320 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "addShutdownHook", "(Ljava/lang/Thread;)V");
			global::java.lang.Runtime._removeShutdownHook20321 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "removeShutdownHook", "(Ljava/lang/Thread;)Z");
			global::java.lang.Runtime._halt20322 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "halt", "(I)V");
			global::java.lang.Runtime._exec20323 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "exec", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/Process;");
			global::java.lang.Runtime._exec20324 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "exec", "([Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/Process;");
			global::java.lang.Runtime._exec20325 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "exec", "([Ljava/lang/String;[Ljava/lang/String;Ljava/io/File;)Ljava/lang/Process;");
			global::java.lang.Runtime._exec20326 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "exec", "(Ljava/lang/String;[Ljava/lang/String;Ljava/io/File;)Ljava/lang/Process;");
			global::java.lang.Runtime._exec20327 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "exec", "([Ljava/lang/String;)Ljava/lang/Process;");
			global::java.lang.Runtime._exec20328 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "exec", "(Ljava/lang/String;)Ljava/lang/Process;");
			global::java.lang.Runtime._availableProcessors20329 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "availableProcessors", "()I");
			global::java.lang.Runtime._totalMemory20330 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "totalMemory", "()J");
			global::java.lang.Runtime._traceInstructions20331 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "traceInstructions", "(Z)V");
			global::java.lang.Runtime._traceMethodCalls20332 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "traceMethodCalls", "(Z)V");
			global::java.lang.Runtime._getLocalizedInputStream20333 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "getLocalizedInputStream", "(Ljava/io/InputStream;)Ljava/io/InputStream;");
			global::java.lang.Runtime._getLocalizedOutputStream20334 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "getLocalizedOutputStream", "(Ljava/io/OutputStream;)Ljava/io/OutputStream;");
		}
	}
}
