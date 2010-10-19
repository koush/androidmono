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
		internal static global::MonoJavaBridge.MethodId _getElapsedCpuTime6685;
		public static long getElapsedCpuTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.os.Process.staticClass, global::android.os.Process._getElapsedCpuTime6685);
		}
		internal static global::MonoJavaBridge.MethodId _myPid6686;
		public static int myPid() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Process.staticClass, global::android.os.Process._myPid6686);
		}
		internal static global::MonoJavaBridge.MethodId _myTid6687;
		public static int myTid() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Process.staticClass, global::android.os.Process._myTid6687);
		}
		internal static global::MonoJavaBridge.MethodId _myUid6688;
		public static int myUid() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Process.staticClass, global::android.os.Process._myUid6688);
		}
		internal static global::MonoJavaBridge.MethodId _getUidForName6689;
		public static int getUidForName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Process.staticClass, global::android.os.Process._getUidForName6689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGidForName6690;
		public static int getGidForName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Process.staticClass, global::android.os.Process._getGidForName6690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setThreadPriority6691;
		public static void setThreadPriority(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Process.staticClass, global::android.os.Process._setThreadPriority6691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setThreadPriority6692;
		public static void setThreadPriority(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Process.staticClass, global::android.os.Process._setThreadPriority6692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getThreadPriority6693;
		public static int getThreadPriority(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Process.staticClass, global::android.os.Process._getThreadPriority6693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _supportsProcesses6694;
		public static bool supportsProcesses() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.os.Process.staticClass, global::android.os.Process._supportsProcesses6694);
		}
		internal static global::MonoJavaBridge.MethodId _killProcess6695;
		public static void killProcess(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Process.staticClass, global::android.os.Process._killProcess6695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendSignal6696;
		public static void sendSignal(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Process.staticClass, global::android.os.Process._sendSignal6696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _Process6697;
		public Process()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Process.staticClass, global::android.os.Process._Process6697);
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
			global::android.os.Process._getElapsedCpuTime6685 = @__env.GetStaticMethodIDNoThrow(global::android.os.Process.staticClass, "getElapsedCpuTime", "()J");
			global::android.os.Process._myPid6686 = @__env.GetStaticMethodIDNoThrow(global::android.os.Process.staticClass, "myPid", "()I");
			global::android.os.Process._myTid6687 = @__env.GetStaticMethodIDNoThrow(global::android.os.Process.staticClass, "myTid", "()I");
			global::android.os.Process._myUid6688 = @__env.GetStaticMethodIDNoThrow(global::android.os.Process.staticClass, "myUid", "()I");
			global::android.os.Process._getUidForName6689 = @__env.GetStaticMethodIDNoThrow(global::android.os.Process.staticClass, "getUidForName", "(Ljava/lang/String;)I");
			global::android.os.Process._getGidForName6690 = @__env.GetStaticMethodIDNoThrow(global::android.os.Process.staticClass, "getGidForName", "(Ljava/lang/String;)I");
			global::android.os.Process._setThreadPriority6691 = @__env.GetStaticMethodIDNoThrow(global::android.os.Process.staticClass, "setThreadPriority", "(II)V");
			global::android.os.Process._setThreadPriority6692 = @__env.GetStaticMethodIDNoThrow(global::android.os.Process.staticClass, "setThreadPriority", "(I)V");
			global::android.os.Process._getThreadPriority6693 = @__env.GetStaticMethodIDNoThrow(global::android.os.Process.staticClass, "getThreadPriority", "(I)I");
			global::android.os.Process._supportsProcesses6694 = @__env.GetStaticMethodIDNoThrow(global::android.os.Process.staticClass, "supportsProcesses", "()Z");
			global::android.os.Process._killProcess6695 = @__env.GetStaticMethodIDNoThrow(global::android.os.Process.staticClass, "killProcess", "(I)V");
			global::android.os.Process._sendSignal6696 = @__env.GetStaticMethodIDNoThrow(global::android.os.Process.staticClass, "sendSignal", "(II)V");
			global::android.os.Process._Process6697 = @__env.GetMethodIDNoThrow(global::android.os.Process.staticClass, "<init>", "()V");
		}
	}
}
