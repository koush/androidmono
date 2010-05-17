namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Process : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Process() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.os.Process), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.os.Process(@__env); 
			} 
		} 
		protected Process(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getElapsedCpuTime5564; 
		public static long getElapsedCpuTime() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticLongMethod(android.os.Process.staticClass, _getElapsedCpuTime5564); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _myPid5565; 
		public static int myPid() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Process.staticClass, _myPid5565); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _myTid5566; 
		public static int myTid() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Process.staticClass, _myTid5566); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _myUid5567; 
		public static int myUid() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Process.staticClass, _myUid5567); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUidForName5568; 
		public static int getUidForName(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Process.staticClass, _getUidForName5568, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGidForName5569; 
		public static int getGidForName(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Process.staticClass, _getGidForName5569, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setThreadPriority5570; 
		public static void setThreadPriority(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Process.staticClass, _setThreadPriority5570, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setThreadPriority5571; 
		public static void setThreadPriority(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Process.staticClass, _setThreadPriority5571, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getThreadPriority5572; 
		public static int getThreadPriority(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Process.staticClass, _getThreadPriority5572, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _supportsProcesses5573; 
		public static bool supportsProcesses() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.os.Process.staticClass, _supportsProcesses5573); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _killProcess5574; 
		public static void killProcess(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Process.staticClass, _killProcess5574, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendSignal5575; 
		public static void sendSignal(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Process.staticClass, _sendSignal5575, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Process5576; 
		public Process()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.Process.staticClass, _Process5576, this); 
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.os.Process.staticClass = @__class; 
			global::android.os.Process._getElapsedCpuTime5564 = @__env.GetStaticMethodID(global::android.os.Process.staticClass, "getElapsedCpuTime", "()J"); 
			global::android.os.Process._myPid5565 = @__env.GetStaticMethodID(global::android.os.Process.staticClass, "myPid", "()I"); 
			global::android.os.Process._myTid5566 = @__env.GetStaticMethodID(global::android.os.Process.staticClass, "myTid", "()I"); 
			global::android.os.Process._myUid5567 = @__env.GetStaticMethodID(global::android.os.Process.staticClass, "myUid", "()I"); 
			global::android.os.Process._getUidForName5568 = @__env.GetStaticMethodID(global::android.os.Process.staticClass, "getUidForName", "(Ljava/lang/String;)I"); 
			global::android.os.Process._getGidForName5569 = @__env.GetStaticMethodID(global::android.os.Process.staticClass, "getGidForName", "(Ljava/lang/String;)I"); 
			global::android.os.Process._setThreadPriority5570 = @__env.GetStaticMethodID(global::android.os.Process.staticClass, "setThreadPriority", "(II)V"); 
			global::android.os.Process._setThreadPriority5571 = @__env.GetStaticMethodID(global::android.os.Process.staticClass, "setThreadPriority", "(I)V"); 
			global::android.os.Process._getThreadPriority5572 = @__env.GetStaticMethodID(global::android.os.Process.staticClass, "getThreadPriority", "(I)I"); 
			global::android.os.Process._supportsProcesses5573 = @__env.GetStaticMethodID(global::android.os.Process.staticClass, "supportsProcesses", "()Z"); 
			global::android.os.Process._killProcess5574 = @__env.GetStaticMethodID(global::android.os.Process.staticClass, "killProcess", "(I)V"); 
			global::android.os.Process._sendSignal5575 = @__env.GetStaticMethodID(global::android.os.Process.staticClass, "sendSignal", "(II)V"); 
			global::android.os.Process._Process5576 = @__env.GetMethodID(global::android.os.Process.staticClass, "<init>", "()V"); 
		} 
	} 
} 
