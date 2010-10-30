namespace dalvik.system
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class VMDebug : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal VMDebug(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isDebuggerConnected18615;
		public static bool isDebuggerConnected()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._isDebuggerConnected18615.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._isDebuggerConnected18615 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "isDebuggerConnected", "()Z");
			return @__env.CallStaticBooleanMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._isDebuggerConnected18615);
		}
		internal static global::MonoJavaBridge.MethodId _startMethodTracing18616;
		public static void startMethodTracing()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._startMethodTracing18616.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._startMethodTracing18616 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "startMethodTracing", "()V");
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._startMethodTracing18616);
		}
		internal static global::MonoJavaBridge.MethodId _startMethodTracing18617;
		public static void startMethodTracing(java.lang.String arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._startMethodTracing18617.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._startMethodTracing18617 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "startMethodTracing", "(Ljava/lang/String;II)V");
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._startMethodTracing18617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _stopMethodTracing18618;
		public static void stopMethodTracing()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._stopMethodTracing18618.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._stopMethodTracing18618 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "stopMethodTracing", "()V");
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._stopMethodTracing18618);
		}
		internal static global::MonoJavaBridge.MethodId _threadCpuTimeNanos18619;
		public static long threadCpuTimeNanos()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._threadCpuTimeNanos18619.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._threadCpuTimeNanos18619 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "threadCpuTimeNanos", "()J");
			return @__env.CallStaticLongMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._threadCpuTimeNanos18619);
		}
		internal static global::MonoJavaBridge.MethodId _startAllocCounting18620;
		public static void startAllocCounting()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._startAllocCounting18620.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._startAllocCounting18620 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "startAllocCounting", "()V");
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._startAllocCounting18620);
		}
		internal static global::MonoJavaBridge.MethodId _stopAllocCounting18621;
		public static void stopAllocCounting()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._stopAllocCounting18621.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._stopAllocCounting18621 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "stopAllocCounting", "()V");
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._stopAllocCounting18621);
		}
		public static int AllocationLimit
		{
			set
			{
				setAllocationLimit(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setAllocationLimit18622;
		public static int setAllocationLimit(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._setAllocationLimit18622.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._setAllocationLimit18622 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "setAllocationLimit", "(I)I");
			return @__env.CallStaticIntMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._setAllocationLimit18622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int GlobalAllocationLimit
		{
			set
			{
				setGlobalAllocationLimit(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setGlobalAllocationLimit18623;
		public static int setGlobalAllocationLimit(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._setGlobalAllocationLimit18623.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._setGlobalAllocationLimit18623 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "setGlobalAllocationLimit", "(I)I");
			return @__env.CallStaticIntMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._setGlobalAllocationLimit18623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _printLoadedClasses18624;
		public static void printLoadedClasses(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._printLoadedClasses18624.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._printLoadedClasses18624 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "printLoadedClasses", "(I)V");
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._printLoadedClasses18624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int LoadedClassCount
		{
			get
			{
				return getLoadedClassCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLoadedClassCount18625;
		public static int getLoadedClassCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._getLoadedClassCount18625.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._getLoadedClassCount18625 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "getLoadedClassCount", "()I");
			return @__env.CallStaticIntMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._getLoadedClassCount18625);
		}
		internal static global::MonoJavaBridge.MethodId _dumpHprofData18626;
		public static void dumpHprofData(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._dumpHprofData18626.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._dumpHprofData18626 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "dumpHprofData", "(Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._dumpHprofData18626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lastDebuggerActivity18627;
		public static long lastDebuggerActivity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._lastDebuggerActivity18627.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._lastDebuggerActivity18627 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "lastDebuggerActivity", "()J");
			return @__env.CallStaticLongMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._lastDebuggerActivity18627);
		}
		internal static global::MonoJavaBridge.MethodId _isDebuggingEnabled18628;
		public static bool isDebuggingEnabled()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._isDebuggingEnabled18628.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._isDebuggingEnabled18628 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "isDebuggingEnabled", "()Z");
			return @__env.CallStaticBooleanMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._isDebuggingEnabled18628);
		}
		internal static global::MonoJavaBridge.MethodId _startEmulatorTracing18629;
		public static void startEmulatorTracing()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._startEmulatorTracing18629.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._startEmulatorTracing18629 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "startEmulatorTracing", "()V");
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._startEmulatorTracing18629);
		}
		internal static global::MonoJavaBridge.MethodId _stopEmulatorTracing18630;
		public static void stopEmulatorTracing()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._stopEmulatorTracing18630.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._stopEmulatorTracing18630 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "stopEmulatorTracing", "()V");
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._stopEmulatorTracing18630);
		}
		internal static global::MonoJavaBridge.MethodId _getAllocCount18631;
		public static int getAllocCount(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._getAllocCount18631.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._getAllocCount18631 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "getAllocCount", "(I)I");
			return @__env.CallStaticIntMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._getAllocCount18631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _resetAllocCount18632;
		public static void resetAllocCount(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._resetAllocCount18632.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._resetAllocCount18632 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "resetAllocCount", "(I)V");
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._resetAllocCount18632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startInstructionCounting18633;
		public static void startInstructionCounting()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._startInstructionCounting18633.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._startInstructionCounting18633 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "startInstructionCounting", "()V");
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._startInstructionCounting18633);
		}
		internal static global::MonoJavaBridge.MethodId _stopInstructionCounting18634;
		public static void stopInstructionCounting()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._stopInstructionCounting18634.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._stopInstructionCounting18634 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "stopInstructionCounting", "()V");
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._stopInstructionCounting18634);
		}
		internal static global::MonoJavaBridge.MethodId _getInstructionCount18635;
		public static void getInstructionCount(int[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._getInstructionCount18635.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._getInstructionCount18635 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "getInstructionCount", "([I)V");
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._getInstructionCount18635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _resetInstructionCount18636;
		public static void resetInstructionCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._resetInstructionCount18636.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._resetInstructionCount18636 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "resetInstructionCount", "()V");
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._resetInstructionCount18636);
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
		static VMDebug()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::dalvik.system.VMDebug.staticClass = @__env.NewGlobalRef(@__env.FindClass("dalvik/system/VMDebug"));
		}
		internal static void InitJNI()
		{
		}
	}
}
