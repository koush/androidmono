namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Process : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
		private static global::MonoJavaBridge.MethodId _m0;
		public static long getElapsedCpuTime()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Process._m0.native == global::System.IntPtr.Zero)
				global::android.os.Process._m0 = @__env.GetStaticMethodIDNoThrow(global::android.os.Process.staticClass, "getElapsedCpuTime", "()J");
			return @__env.CallStaticLongMethod(android.os.Process.staticClass, global::android.os.Process._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static int myPid()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Process._m1.native == global::System.IntPtr.Zero)
				global::android.os.Process._m1 = @__env.GetStaticMethodIDNoThrow(global::android.os.Process.staticClass, "myPid", "()I");
			return @__env.CallStaticIntMethod(android.os.Process.staticClass, global::android.os.Process._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static int myTid()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Process._m2.native == global::System.IntPtr.Zero)
				global::android.os.Process._m2 = @__env.GetStaticMethodIDNoThrow(global::android.os.Process.staticClass, "myTid", "()I");
			return @__env.CallStaticIntMethod(android.os.Process.staticClass, global::android.os.Process._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static int myUid()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Process._m3.native == global::System.IntPtr.Zero)
				global::android.os.Process._m3 = @__env.GetStaticMethodIDNoThrow(global::android.os.Process.staticClass, "myUid", "()I");
			return @__env.CallStaticIntMethod(android.os.Process.staticClass, global::android.os.Process._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static int getUidForName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Process._m4.native == global::System.IntPtr.Zero)
				global::android.os.Process._m4 = @__env.GetStaticMethodIDNoThrow(global::android.os.Process.staticClass, "getUidForName", "(Ljava/lang/String;)I");
			return @__env.CallStaticIntMethod(android.os.Process.staticClass, global::android.os.Process._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static int getGidForName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Process._m5.native == global::System.IntPtr.Zero)
				global::android.os.Process._m5 = @__env.GetStaticMethodIDNoThrow(global::android.os.Process.staticClass, "getGidForName", "(Ljava/lang/String;)I");
			return @__env.CallStaticIntMethod(android.os.Process.staticClass, global::android.os.Process._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static void setThreadPriority(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Process._m6.native == global::System.IntPtr.Zero)
				global::android.os.Process._m6 = @__env.GetStaticMethodIDNoThrow(global::android.os.Process.staticClass, "setThreadPriority", "(II)V");
			@__env.CallStaticVoidMethod(android.os.Process.staticClass, global::android.os.Process._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public static int ThreadPriority
		{
			set
			{
				setThreadPriority(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static void setThreadPriority(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Process._m7.native == global::System.IntPtr.Zero)
				global::android.os.Process._m7 = @__env.GetStaticMethodIDNoThrow(global::android.os.Process.staticClass, "setThreadPriority", "(I)V");
			@__env.CallStaticVoidMethod(android.os.Process.staticClass, global::android.os.Process._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static int getThreadPriority(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Process._m8.native == global::System.IntPtr.Zero)
				global::android.os.Process._m8 = @__env.GetStaticMethodIDNoThrow(global::android.os.Process.staticClass, "getThreadPriority", "(I)I");
			return @__env.CallStaticIntMethod(android.os.Process.staticClass, global::android.os.Process._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static bool supportsProcesses()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Process._m9.native == global::System.IntPtr.Zero)
				global::android.os.Process._m9 = @__env.GetStaticMethodIDNoThrow(global::android.os.Process.staticClass, "supportsProcesses", "()Z");
			return @__env.CallStaticBooleanMethod(android.os.Process.staticClass, global::android.os.Process._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static void killProcess(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Process._m10.native == global::System.IntPtr.Zero)
				global::android.os.Process._m10 = @__env.GetStaticMethodIDNoThrow(global::android.os.Process.staticClass, "killProcess", "(I)V");
			@__env.CallStaticVoidMethod(android.os.Process.staticClass, global::android.os.Process._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static void sendSignal(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Process._m11.native == global::System.IntPtr.Zero)
				global::android.os.Process._m11 = @__env.GetStaticMethodIDNoThrow(global::android.os.Process.staticClass, "sendSignal", "(II)V");
			@__env.CallStaticVoidMethod(android.os.Process.staticClass, global::android.os.Process._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public Process() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Process._m12.native == global::System.IntPtr.Zero)
				global::android.os.Process._m12 = @__env.GetMethodIDNoThrow(global::android.os.Process.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Process.staticClass, global::android.os.Process._m12);
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
		static Process()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Process.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Process"));
		}
	}
}
