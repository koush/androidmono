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
		internal static global::MonoJavaBridge.MethodId _exit14797;
		public virtual void exit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Runtime._exit14797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._exit14797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _runFinalizersOnExit14798;
		public static void runFinalizersOnExit(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.Runtime.staticClass, global::java.lang.Runtime._runFinalizersOnExit14798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _loadLibrary14799;
		public virtual void loadLibrary(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Runtime._loadLibrary14799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._loadLibrary14799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _load14800;
		public virtual void load(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Runtime._load14800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._load14800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _gc14801;
		public virtual void gc() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Runtime._gc14801);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._gc14801);
		}
		internal static global::MonoJavaBridge.MethodId _runFinalization14802;
		public virtual void runFinalization() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Runtime._runFinalization14802);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._runFinalization14802);
		}
		internal static global::MonoJavaBridge.MethodId _getRuntime14803;
		public static global::java.lang.Runtime getRuntime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Runtime.staticClass, global::java.lang.Runtime._getRuntime14803)) as java.lang.Runtime;
		}
		internal static global::MonoJavaBridge.MethodId _freeMemory14804;
		public virtual long freeMemory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.lang.Runtime._freeMemory14804);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._freeMemory14804);
		}
		internal static global::MonoJavaBridge.MethodId _maxMemory14805;
		public virtual long maxMemory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.lang.Runtime._maxMemory14805);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._maxMemory14805);
		}
		internal static global::MonoJavaBridge.MethodId _addShutdownHook14806;
		public virtual void addShutdownHook(java.lang.Thread arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Runtime._addShutdownHook14806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._addShutdownHook14806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeShutdownHook14807;
		public virtual bool removeShutdownHook(java.lang.Thread arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Runtime._removeShutdownHook14807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._removeShutdownHook14807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _halt14808;
		public virtual void halt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Runtime._halt14808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._halt14808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _exec14809;
		public virtual global::java.lang.Process exec(java.lang.String arg0, java.lang.String[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Runtime._exec14809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Process;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._exec14809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Process;
		}
		internal static global::MonoJavaBridge.MethodId _exec14810;
		public virtual global::java.lang.Process exec(java.lang.String[] arg0, java.lang.String[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Runtime._exec14810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Process;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._exec14810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Process;
		}
		internal static global::MonoJavaBridge.MethodId _exec14811;
		public virtual global::java.lang.Process exec(java.lang.String[] arg0, java.lang.String[] arg1, java.io.File arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Runtime._exec14811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Process;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._exec14811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Process;
		}
		internal static global::MonoJavaBridge.MethodId _exec14812;
		public virtual global::java.lang.Process exec(java.lang.String arg0, java.lang.String[] arg1, java.io.File arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Runtime._exec14812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Process;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._exec14812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Process;
		}
		internal static global::MonoJavaBridge.MethodId _exec14813;
		public virtual global::java.lang.Process exec(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Runtime._exec14813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Process;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._exec14813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Process;
		}
		internal static global::MonoJavaBridge.MethodId _exec14814;
		public virtual global::java.lang.Process exec(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Runtime._exec14814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Process;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._exec14814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Process;
		}
		internal static global::MonoJavaBridge.MethodId _availableProcessors14815;
		public virtual int availableProcessors() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Runtime._availableProcessors14815);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._availableProcessors14815);
		}
		internal static global::MonoJavaBridge.MethodId _totalMemory14816;
		public virtual long totalMemory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.lang.Runtime._totalMemory14816);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._totalMemory14816);
		}
		internal static global::MonoJavaBridge.MethodId _traceInstructions14817;
		public virtual void traceInstructions(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Runtime._traceInstructions14817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._traceInstructions14817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _traceMethodCalls14818;
		public virtual void traceMethodCalls(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Runtime._traceMethodCalls14818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._traceMethodCalls14818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLocalizedInputStream14819;
		public virtual global::java.io.InputStream getLocalizedInputStream(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Runtime._getLocalizedInputStream14819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._getLocalizedInputStream14819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalizedOutputStream14820;
		public virtual global::java.io.OutputStream getLocalizedOutputStream(java.io.OutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Runtime._getLocalizedOutputStream14820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.OutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Runtime.staticClass, global::java.lang.Runtime._getLocalizedOutputStream14820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.OutputStream;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Runtime.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Runtime"));
			global::java.lang.Runtime._exit14797 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "exit", "(I)V");
			global::java.lang.Runtime._runFinalizersOnExit14798 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Runtime.staticClass, "runFinalizersOnExit", "(Z)V");
			global::java.lang.Runtime._loadLibrary14799 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "loadLibrary", "(Ljava/lang/String;)V");
			global::java.lang.Runtime._load14800 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "load", "(Ljava/lang/String;)V");
			global::java.lang.Runtime._gc14801 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "gc", "()V");
			global::java.lang.Runtime._runFinalization14802 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "runFinalization", "()V");
			global::java.lang.Runtime._getRuntime14803 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Runtime.staticClass, "getRuntime", "()Ljava/lang/Runtime;");
			global::java.lang.Runtime._freeMemory14804 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "freeMemory", "()J");
			global::java.lang.Runtime._maxMemory14805 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "maxMemory", "()J");
			global::java.lang.Runtime._addShutdownHook14806 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "addShutdownHook", "(Ljava/lang/Thread;)V");
			global::java.lang.Runtime._removeShutdownHook14807 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "removeShutdownHook", "(Ljava/lang/Thread;)Z");
			global::java.lang.Runtime._halt14808 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "halt", "(I)V");
			global::java.lang.Runtime._exec14809 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "exec", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/Process;");
			global::java.lang.Runtime._exec14810 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "exec", "([Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/Process;");
			global::java.lang.Runtime._exec14811 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "exec", "([Ljava/lang/String;[Ljava/lang/String;Ljava/io/File;)Ljava/lang/Process;");
			global::java.lang.Runtime._exec14812 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "exec", "(Ljava/lang/String;[Ljava/lang/String;Ljava/io/File;)Ljava/lang/Process;");
			global::java.lang.Runtime._exec14813 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "exec", "([Ljava/lang/String;)Ljava/lang/Process;");
			global::java.lang.Runtime._exec14814 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "exec", "(Ljava/lang/String;)Ljava/lang/Process;");
			global::java.lang.Runtime._availableProcessors14815 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "availableProcessors", "()I");
			global::java.lang.Runtime._totalMemory14816 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "totalMemory", "()J");
			global::java.lang.Runtime._traceInstructions14817 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "traceInstructions", "(Z)V");
			global::java.lang.Runtime._traceMethodCalls14818 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "traceMethodCalls", "(Z)V");
			global::java.lang.Runtime._getLocalizedInputStream14819 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "getLocalizedInputStream", "(Ljava/io/InputStream;)Ljava/io/InputStream;");
			global::java.lang.Runtime._getLocalizedOutputStream14820 = @__env.GetMethodIDNoThrow(global::java.lang.Runtime.staticClass, "getLocalizedOutputStream", "(Ljava/io/OutputStream;)Ljava/io/OutputStream;");
		}
	}
}
