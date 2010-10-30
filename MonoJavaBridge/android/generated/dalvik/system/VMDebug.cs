namespace dalvik.system
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class VMDebug : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal VMDebug(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static bool isDebuggerConnected()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._m0.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._m0 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "isDebuggerConnected", "()Z");
			return @__env.CallStaticBooleanMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static void startMethodTracing()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._m1.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._m1 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "startMethodTracing", "()V");
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static void startMethodTracing(java.lang.String arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._m2.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._m2 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "startMethodTracing", "(Ljava/lang/String;II)V");
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static void stopMethodTracing()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._m3.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._m3 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "stopMethodTracing", "()V");
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static long threadCpuTimeNanos()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._m4.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._m4 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "threadCpuTimeNanos", "()J");
			return @__env.CallStaticLongMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static void startAllocCounting()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._m5.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._m5 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "startAllocCounting", "()V");
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static void stopAllocCounting()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._m6.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._m6 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "stopAllocCounting", "()V");
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._m6);
		}
		public static int AllocationLimit
		{
			set
			{
				setAllocationLimit(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static int setAllocationLimit(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._m7.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._m7 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "setAllocationLimit", "(I)I");
			return @__env.CallStaticIntMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int GlobalAllocationLimit
		{
			set
			{
				setGlobalAllocationLimit(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static int setGlobalAllocationLimit(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._m8.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._m8 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "setGlobalAllocationLimit", "(I)I");
			return @__env.CallStaticIntMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static void printLoadedClasses(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._m9.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._m9 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "printLoadedClasses", "(I)V");
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int LoadedClassCount
		{
			get
			{
				return getLoadedClassCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static int getLoadedClassCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._m10.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._m10 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "getLoadedClassCount", "()I");
			return @__env.CallStaticIntMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static void dumpHprofData(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._m11.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._m11 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "dumpHprofData", "(Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static long lastDebuggerActivity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._m12.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._m12 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "lastDebuggerActivity", "()J");
			return @__env.CallStaticLongMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static bool isDebuggingEnabled()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._m13.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._m13 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "isDebuggingEnabled", "()Z");
			return @__env.CallStaticBooleanMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static void startEmulatorTracing()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._m14.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._m14 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "startEmulatorTracing", "()V");
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static void stopEmulatorTracing()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._m15.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._m15 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "stopEmulatorTracing", "()V");
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public static int getAllocCount(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._m16.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._m16 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "getAllocCount", "(I)I");
			return @__env.CallStaticIntMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public static void resetAllocCount(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._m17.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._m17 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "resetAllocCount", "(I)V");
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public static void startInstructionCounting()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._m18.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._m18 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "startInstructionCounting", "()V");
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._m18);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public static void stopInstructionCounting()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._m19.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._m19 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "stopInstructionCounting", "()V");
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public static void getInstructionCount(int[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._m20.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._m20 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "getInstructionCount", "([I)V");
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public static void resetInstructionCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.VMDebug._m21.native == global::System.IntPtr.Zero)
				global::dalvik.system.VMDebug._m21 = @__env.GetStaticMethodIDNoThrow(global::dalvik.system.VMDebug.staticClass, "resetInstructionCount", "()V");
			@__env.CallStaticVoidMethod(dalvik.system.VMDebug.staticClass, global::dalvik.system.VMDebug._m21);
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
