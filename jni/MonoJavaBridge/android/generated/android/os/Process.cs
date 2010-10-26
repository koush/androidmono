namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Process : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Process()
		{
			InitJNI();
		}
		protected Process(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public static long ElapsedCpuTime
		{
			get
			{
				return getElapsedCpuTime();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getElapsedCpuTime10147;
		public static long getElapsedCpuTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.os.Process.staticClass, global::android.os.Process._getElapsedCpuTime10147);
		}
		internal static global::MonoJavaBridge.MethodId _myPid10148;
		public static int myPid() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Process.staticClass, global::android.os.Process._myPid10148);
		}
		internal static global::MonoJavaBridge.MethodId _myTid10149;
		public static int myTid() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Process.staticClass, global::android.os.Process._myTid10149);
		}
		internal static global::MonoJavaBridge.MethodId _myUid10150;
		public static int myUid() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Process.staticClass, global::android.os.Process._myUid10150);
		}
		internal static global::MonoJavaBridge.MethodId _getUidForName10151;
		public static int getUidForName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Process.staticClass, global::android.os.Process._getUidForName10151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGidForName10152;
		public static int getGidForName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Process.staticClass, global::android.os.Process._getGidForName10152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setThreadPriority10153;
		public static void setThreadPriority(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Process.staticClass, global::android.os.Process._setThreadPriority10153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setThreadPriority10154;
		public static void setThreadPriority(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Process.staticClass, global::android.os.Process._setThreadPriority10154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getThreadPriority10155;
		public static int getThreadPriority(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Process.staticClass, global::android.os.Process._getThreadPriority10155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _supportsProcesses10156;
		public static bool supportsProcesses() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.os.Process.staticClass, global::android.os.Process._supportsProcesses10156);
		}
		internal static global::MonoJavaBridge.MethodId _killProcess10157;
		public static void killProcess(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Process.staticClass, global::android.os.Process._killProcess10157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendSignal10158;
		public static void sendSignal(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Process.staticClass, global::android.os.Process._sendSignal10158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _Process10159;
		public Process()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Process.staticClass, global::android.os.Process._Process10159);
			Init(@__env, handle);
		}
		public static int SYSTEM_UID
		{
			get
			{
				return 1000;
			}
		}
		public static int PHONE_UID
		{
			get
			{
				return 1001;
			}
		}
		public static int FIRST_APPLICATION_UID
		{
			get
			{
				return 10000;
			}
		}
		public static int LAST_APPLICATION_UID
		{
			get
			{
				return 99999;
			}
		}
		public static int BLUETOOTH_GID
		{
			get
			{
				return 2000;
			}
		}
		public static int THREAD_PRIORITY_DEFAULT
		{
			get
			{
				return 0;
			}
		}
		public static int THREAD_PRIORITY_LOWEST
		{
			get
			{
				return 19;
			}
		}
		public static int THREAD_PRIORITY_BACKGROUND
		{
			get
			{
				return 10;
			}
		}
		public static int THREAD_PRIORITY_FOREGROUND
		{
			get
			{
				return -2;
			}
		}
		public static int THREAD_PRIORITY_DISPLAY
		{
			get
			{
				return -4;
			}
		}
		public static int THREAD_PRIORITY_URGENT_DISPLAY
		{
			get
			{
				return -8;
			}
		}
		public static int THREAD_PRIORITY_AUDIO
		{
			get
			{
				return -16;
			}
		}
		public static int THREAD_PRIORITY_URGENT_AUDIO
		{
			get
			{
				return -19;
			}
		}
		public static int THREAD_PRIORITY_MORE_FAVORABLE
		{
			get
			{
				return -1;
			}
		}
		public static int THREAD_PRIORITY_LESS_FAVORABLE
		{
			get
			{
				return 1;
			}
		}
		public static int SIGNAL_QUIT
		{
			get
			{
				return 3;
			}
		}
		public static int SIGNAL_KILL
		{
			get
			{
				return 9;
			}
		}
		public static int SIGNAL_USR1
		{
			get
			{
				return 10;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Process.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Process"));
			global::android.os.Process._getElapsedCpuTime10147 = @__env.GetStaticMethodIDNoThrow(global::android.os.Process.staticClass, "getElapsedCpuTime", "()J");
			global::android.os.Process._myPid10148 = @__env.GetStaticMethodIDNoThrow(global::android.os.Process.staticClass, "myPid", "()I");
			global::android.os.Process._myTid10149 = @__env.GetStaticMethodIDNoThrow(global::android.os.Process.staticClass, "myTid", "()I");
			global::android.os.Process._myUid10150 = @__env.GetStaticMethodIDNoThrow(global::android.os.Process.staticClass, "myUid", "()I");
			global::android.os.Process._getUidForName10151 = @__env.GetStaticMethodIDNoThrow(global::android.os.Process.staticClass, "getUidForName", "(Ljava/lang/String;)I");
			global::android.os.Process._getGidForName10152 = @__env.GetStaticMethodIDNoThrow(global::android.os.Process.staticClass, "getGidForName", "(Ljava/lang/String;)I");
			global::android.os.Process._setThreadPriority10153 = @__env.GetStaticMethodIDNoThrow(global::android.os.Process.staticClass, "setThreadPriority", "(II)V");
			global::android.os.Process._setThreadPriority10154 = @__env.GetStaticMethodIDNoThrow(global::android.os.Process.staticClass, "setThreadPriority", "(I)V");
			global::android.os.Process._getThreadPriority10155 = @__env.GetStaticMethodIDNoThrow(global::android.os.Process.staticClass, "getThreadPriority", "(I)I");
			global::android.os.Process._supportsProcesses10156 = @__env.GetStaticMethodIDNoThrow(global::android.os.Process.staticClass, "supportsProcesses", "()Z");
			global::android.os.Process._killProcess10157 = @__env.GetStaticMethodIDNoThrow(global::android.os.Process.staticClass, "killProcess", "(I)V");
			global::android.os.Process._sendSignal10158 = @__env.GetStaticMethodIDNoThrow(global::android.os.Process.staticClass, "sendSignal", "(II)V");
			global::android.os.Process._Process10159 = @__env.GetMethodIDNoThrow(global::android.os.Process.staticClass, "<init>", "()V");
		}
	}
}
