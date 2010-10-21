namespace dalvik.system
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class VMDebug : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static VMDebug()
		{
			InitJNI();
		}
		internal VMDebug(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isDebuggerConnected18497;
		public static bool isDebuggerConnected() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._isDebuggerConnected18497);
		}
		internal static global::MonoJavaBridge.MethodId _startMethodTracing18498;
		public static void startMethodTracing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._startMethodTracing18498);
		}
		internal static global::MonoJavaBridge.MethodId _startMethodTracing18499;
		public static void startMethodTracing(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._startMethodTracing18499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _stopMethodTracing18500;
		public static void stopMethodTracing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._stopMethodTracing18500);
		}
		internal static global::MonoJavaBridge.MethodId _threadCpuTimeNanos18501;
		public static long threadCpuTimeNanos() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._threadCpuTimeNanos18501);
		}
		internal static global::MonoJavaBridge.MethodId _startAllocCounting18502;
		public static void startAllocCounting() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._startAllocCounting18502);
		}
		internal static global::MonoJavaBridge.MethodId _stopAllocCounting18503;
		public static void stopAllocCounting() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._stopAllocCounting18503);
		}
		internal static global::MonoJavaBridge.MethodId _setAllocationLimit18504;
		public static int setAllocationLimit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._setAllocationLimit18504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setGlobalAllocationLimit18505;
		public static int setGlobalAllocationLimit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._setGlobalAllocationLimit18505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _printLoadedClasses18506;
		public static void printLoadedClasses(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._printLoadedClasses18506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int LoadedClassCount
		{
			get
			{
				return getLoadedClassCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLoadedClassCount18507;
		public static int getLoadedClassCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._getLoadedClassCount18507);
		}
		internal static global::MonoJavaBridge.MethodId _dumpHprofData18508;
		public static void dumpHprofData(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._dumpHprofData18508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lastDebuggerActivity18509;
		public static long lastDebuggerActivity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._lastDebuggerActivity18509);
		}
		internal static global::MonoJavaBridge.MethodId _isDebuggingEnabled18510;
		public static bool isDebuggingEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._isDebuggingEnabled18510);
		}
		internal static global::MonoJavaBridge.MethodId _startEmulatorTracing18511;
		public static void startEmulatorTracing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._startEmulatorTracing18511);
		}
		internal static global::MonoJavaBridge.MethodId _stopEmulatorTracing18512;
		public static void stopEmulatorTracing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._stopEmulatorTracing18512);
		}
		internal static global::MonoJavaBridge.MethodId _getAllocCount18513;
		public static int getAllocCount(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._getAllocCount18513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _resetAllocCount18514;
		public static void resetAllocCount(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._resetAllocCount18514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startInstructionCounting18515;
		public static void startInstructionCounting() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._startInstructionCounting18515);
		}
		internal static global::MonoJavaBridge.MethodId _stopInstructionCounting18516;
		public static void stopInstructionCounting() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._stopInstructionCounting18516);
		}
		internal static global::MonoJavaBridge.MethodId _getInstructionCount18517;
		public static void getInstructionCount(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._getInstructionCount18517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _resetInstructionCount18518;
		public static void resetInstructionCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._resetInstructionCount18518);
		}
		public static global::java.lang.String DEFAULT_METHOD_TRACE_FILE_NAME
		{
			get
			{
				return "/sdcard/dmtrace.trace";
			}
		}
		public static int TRACE_COUNT_ALLOCS
		{
			get
			{
				return 1;
			}
		}
		public static int KIND_GLOBAL_ALLOCATED_OBJECTS
		{
			get
			{
				return 1;
			}
		}
		public static int KIND_GLOBAL_ALLOCATED_BYTES
		{
			get
			{
				return 2;
			}
		}
		public static int KIND_GLOBAL_FREED_OBJECTS
		{
			get
			{
				return 4;
			}
		}
		public static int KIND_GLOBAL_FREED_BYTES
		{
			get
			{
				return 8;
			}
		}
		public static int KIND_GLOBAL_GC_INVOCATIONS
		{
			get
			{
				return 16;
			}
		}
		public static int KIND_GLOBAL_CLASS_INIT_COUNT
		{
			get
			{
				return 32;
			}
		}
		public static int KIND_GLOBAL_CLASS_INIT_TIME
		{
			get
			{
				return 64;
			}
		}
		public static int KIND_GLOBAL_EXT_ALLOCATED_OBJECTS
		{
			get
			{
				return 4096;
			}
		}
		public static int KIND_GLOBAL_EXT_ALLOCATED_BYTES
		{
			get
			{
				return 8192;
			}
		}
		public static int KIND_GLOBAL_EXT_FREED_OBJECTS
		{
			get
			{
				return 16384;
			}
		}
		public static int KIND_GLOBAL_EXT_FREED_BYTES
		{
			get
			{
				return 32768;
			}
		}
		public static int KIND_THREAD_ALLOCATED_OBJECTS
		{
			get
			{
				return 65536;
			}
		}
		public static int KIND_THREAD_ALLOCATED_BYTES
		{
			get
			{
				return 131072;
			}
		}
		public static int KIND_THREAD_FREED_OBJECTS
		{
			get
			{
				return 262144;
			}
		}
		public static int KIND_THREAD_FREED_BYTES
		{
			get
			{
				return 524288;
			}
		}
		public static int KIND_THREAD_GC_INVOCATIONS
		{
			get
			{
				return 1048576;
			}
		}
		public static int KIND_THREAD_CLASS_INIT_COUNT
		{
			get
			{
				return 2097152;
			}
		}
		public static int KIND_THREAD_CLASS_INIT_TIME
		{
			get
			{
				return 4194304;
			}
		}
		public static int KIND_THREAD_EXT_ALLOCATED_OBJECTS
		{
			get
			{
				return 268435456;
			}
		}
		public static int KIND_THREAD_EXT_ALLOCATED_BYTES
		{
			get
			{
				return 536870912;
			}
		}
		public static int KIND_THREAD_EXT_FREED_OBJECTS
		{
			get
			{
				return 1073741824;
			}
		}
		public static int KIND_THREAD_EXT_FREED_BYTES
		{
			get
			{
				return -2147483648;
			}
		}
		public static int KIND_ALL_COUNTS
		{
			get
			{
				return -1;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::dalvik.system.VMDebug.staticClass = @__env.NewGlobalRef(@__env.FindClass("dalvik/system/VMDebug"));
			global::dalvik.system.VMDebug._isDebuggerConnected18497 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "isDebuggerConnected", "()Z");
			global::dalvik.system.VMDebug._startMethodTracing18498 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "startMethodTracing", "()V");
			global::dalvik.system.VMDebug._startMethodTracing18499 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "startMethodTracing", "(Ljava/lang/String;II)V");
			global::dalvik.system.VMDebug._stopMethodTracing18500 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "stopMethodTracing", "()V");
			global::dalvik.system.VMDebug._threadCpuTimeNanos18501 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "threadCpuTimeNanos", "()J");
			global::dalvik.system.VMDebug._startAllocCounting18502 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "startAllocCounting", "()V");
			global::dalvik.system.VMDebug._stopAllocCounting18503 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "stopAllocCounting", "()V");
			global::dalvik.system.VMDebug._setAllocationLimit18504 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "setAllocationLimit", "(I)I");
			global::dalvik.system.VMDebug._setGlobalAllocationLimit18505 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "setGlobalAllocationLimit", "(I)I");
			global::dalvik.system.VMDebug._printLoadedClasses18506 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "printLoadedClasses", "(I)V");
			global::dalvik.system.VMDebug._getLoadedClassCount18507 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "getLoadedClassCount", "()I");
			global::dalvik.system.VMDebug._dumpHprofData18508 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "dumpHprofData", "(Ljava/lang/String;)V");
			global::dalvik.system.VMDebug._lastDebuggerActivity18509 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "lastDebuggerActivity", "()J");
			global::dalvik.system.VMDebug._isDebuggingEnabled18510 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "isDebuggingEnabled", "()Z");
			global::dalvik.system.VMDebug._startEmulatorTracing18511 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "startEmulatorTracing", "()V");
			global::dalvik.system.VMDebug._stopEmulatorTracing18512 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "stopEmulatorTracing", "()V");
			global::dalvik.system.VMDebug._getAllocCount18513 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "getAllocCount", "(I)I");
			global::dalvik.system.VMDebug._resetAllocCount18514 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "resetAllocCount", "(I)V");
			global::dalvik.system.VMDebug._startInstructionCounting18515 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "startInstructionCounting", "()V");
			global::dalvik.system.VMDebug._stopInstructionCounting18516 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "stopInstructionCounting", "()V");
			global::dalvik.system.VMDebug._getInstructionCount18517 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "getInstructionCount", "([I)V");
			global::dalvik.system.VMDebug._resetInstructionCount18518 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "resetInstructionCount", "()V");
		}
	}
}
