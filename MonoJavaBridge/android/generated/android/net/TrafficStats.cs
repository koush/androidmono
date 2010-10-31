namespace android.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TrafficStats : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TrafficStats(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public static long MobileTxPackets
		{
			get
			{
				return getMobileTxPackets();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static long getMobileTxPackets()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.TrafficStats._m0.native == global::System.IntPtr.Zero)
				global::android.net.TrafficStats._m0 = @__env.GetStaticMethodIDNoThrow(global::android.net.TrafficStats.staticClass, "getMobileTxPackets", "()J");
			return @__env.CallStaticLongMethod(android.net.TrafficStats.staticClass, global::android.net.TrafficStats._m0);
		}
		public static long MobileRxPackets
		{
			get
			{
				return getMobileRxPackets();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static long getMobileRxPackets()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.TrafficStats._m1.native == global::System.IntPtr.Zero)
				global::android.net.TrafficStats._m1 = @__env.GetStaticMethodIDNoThrow(global::android.net.TrafficStats.staticClass, "getMobileRxPackets", "()J");
			return @__env.CallStaticLongMethod(android.net.TrafficStats.staticClass, global::android.net.TrafficStats._m1);
		}
		public static long MobileTxBytes
		{
			get
			{
				return getMobileTxBytes();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static long getMobileTxBytes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.TrafficStats._m2.native == global::System.IntPtr.Zero)
				global::android.net.TrafficStats._m2 = @__env.GetStaticMethodIDNoThrow(global::android.net.TrafficStats.staticClass, "getMobileTxBytes", "()J");
			return @__env.CallStaticLongMethod(android.net.TrafficStats.staticClass, global::android.net.TrafficStats._m2);
		}
		public static long MobileRxBytes
		{
			get
			{
				return getMobileRxBytes();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static long getMobileRxBytes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.TrafficStats._m3.native == global::System.IntPtr.Zero)
				global::android.net.TrafficStats._m3 = @__env.GetStaticMethodIDNoThrow(global::android.net.TrafficStats.staticClass, "getMobileRxBytes", "()J");
			return @__env.CallStaticLongMethod(android.net.TrafficStats.staticClass, global::android.net.TrafficStats._m3);
		}
		public static long TotalTxPackets
		{
			get
			{
				return getTotalTxPackets();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static long getTotalTxPackets()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.TrafficStats._m4.native == global::System.IntPtr.Zero)
				global::android.net.TrafficStats._m4 = @__env.GetStaticMethodIDNoThrow(global::android.net.TrafficStats.staticClass, "getTotalTxPackets", "()J");
			return @__env.CallStaticLongMethod(android.net.TrafficStats.staticClass, global::android.net.TrafficStats._m4);
		}
		public static long TotalRxPackets
		{
			get
			{
				return getTotalRxPackets();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static long getTotalRxPackets()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.TrafficStats._m5.native == global::System.IntPtr.Zero)
				global::android.net.TrafficStats._m5 = @__env.GetStaticMethodIDNoThrow(global::android.net.TrafficStats.staticClass, "getTotalRxPackets", "()J");
			return @__env.CallStaticLongMethod(android.net.TrafficStats.staticClass, global::android.net.TrafficStats._m5);
		}
		public static long TotalTxBytes
		{
			get
			{
				return getTotalTxBytes();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static long getTotalTxBytes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.TrafficStats._m6.native == global::System.IntPtr.Zero)
				global::android.net.TrafficStats._m6 = @__env.GetStaticMethodIDNoThrow(global::android.net.TrafficStats.staticClass, "getTotalTxBytes", "()J");
			return @__env.CallStaticLongMethod(android.net.TrafficStats.staticClass, global::android.net.TrafficStats._m6);
		}
		public static long TotalRxBytes
		{
			get
			{
				return getTotalRxBytes();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static long getTotalRxBytes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.TrafficStats._m7.native == global::System.IntPtr.Zero)
				global::android.net.TrafficStats._m7 = @__env.GetStaticMethodIDNoThrow(global::android.net.TrafficStats.staticClass, "getTotalRxBytes", "()J");
			return @__env.CallStaticLongMethod(android.net.TrafficStats.staticClass, global::android.net.TrafficStats._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static long getUidTxBytes(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.TrafficStats._m8.native == global::System.IntPtr.Zero)
				global::android.net.TrafficStats._m8 = @__env.GetStaticMethodIDNoThrow(global::android.net.TrafficStats.staticClass, "getUidTxBytes", "(I)J");
			return @__env.CallStaticLongMethod(android.net.TrafficStats.staticClass, global::android.net.TrafficStats._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static long getUidRxBytes(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.TrafficStats._m9.native == global::System.IntPtr.Zero)
				global::android.net.TrafficStats._m9 = @__env.GetStaticMethodIDNoThrow(global::android.net.TrafficStats.staticClass, "getUidRxBytes", "(I)J");
			return @__env.CallStaticLongMethod(android.net.TrafficStats.staticClass, global::android.net.TrafficStats._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public TrafficStats() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.TrafficStats._m10.native == global::System.IntPtr.Zero)
				global::android.net.TrafficStats._m10 = @__env.GetMethodIDNoThrow(global::android.net.TrafficStats.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.TrafficStats.staticClass, global::android.net.TrafficStats._m10);
			Init(@__env, handle);
		}
		public static int UNSUPPORTED
		{
			get
			{
				return -1;
			}
		}
		static TrafficStats()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.TrafficStats.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/TrafficStats"));
		}
	}
}
