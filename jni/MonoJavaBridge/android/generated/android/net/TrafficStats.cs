namespace android.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TrafficStats : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TrafficStats()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getMobileTxPackets5255;
		public static long getMobileTxPackets() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.net.TrafficStats.staticClass, global::android.net.TrafficStats._getMobileTxPackets5255);
		}
		public static long MobileRxPackets
		{
			get
			{
				return getMobileRxPackets();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMobileRxPackets5256;
		public static long getMobileRxPackets() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.net.TrafficStats.staticClass, global::android.net.TrafficStats._getMobileRxPackets5256);
		}
		public static long MobileTxBytes
		{
			get
			{
				return getMobileTxBytes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMobileTxBytes5257;
		public static long getMobileTxBytes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.net.TrafficStats.staticClass, global::android.net.TrafficStats._getMobileTxBytes5257);
		}
		public static long MobileRxBytes
		{
			get
			{
				return getMobileRxBytes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMobileRxBytes5258;
		public static long getMobileRxBytes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.net.TrafficStats.staticClass, global::android.net.TrafficStats._getMobileRxBytes5258);
		}
		public static long TotalTxPackets
		{
			get
			{
				return getTotalTxPackets();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalTxPackets5259;
		public static long getTotalTxPackets() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.net.TrafficStats.staticClass, global::android.net.TrafficStats._getTotalTxPackets5259);
		}
		public static long TotalRxPackets
		{
			get
			{
				return getTotalRxPackets();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalRxPackets5260;
		public static long getTotalRxPackets() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.net.TrafficStats.staticClass, global::android.net.TrafficStats._getTotalRxPackets5260);
		}
		public static long TotalTxBytes
		{
			get
			{
				return getTotalTxBytes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalTxBytes5261;
		public static long getTotalTxBytes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.net.TrafficStats.staticClass, global::android.net.TrafficStats._getTotalTxBytes5261);
		}
		public static long TotalRxBytes
		{
			get
			{
				return getTotalRxBytes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalRxBytes5262;
		public static long getTotalRxBytes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.net.TrafficStats.staticClass, global::android.net.TrafficStats._getTotalRxBytes5262);
		}
		internal static global::MonoJavaBridge.MethodId _getUidTxBytes5263;
		public static long getUidTxBytes(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.net.TrafficStats.staticClass, global::android.net.TrafficStats._getUidTxBytes5263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUidRxBytes5264;
		public static long getUidRxBytes(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.net.TrafficStats.staticClass, global::android.net.TrafficStats._getUidRxBytes5264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _TrafficStats5265;
		public TrafficStats()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.TrafficStats.staticClass, global::android.net.TrafficStats._TrafficStats5265);
			Init(@__env, handle);
		}
		public static int UNSUPPORTED
		{
			get
			{
				return -1;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.TrafficStats.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/TrafficStats"));
			global::android.net.TrafficStats._getMobileTxPackets5255 = @__env.GetStaticMethodIDNoThrow(global::android.net.TrafficStats.staticClass, "getMobileTxPackets", "()J");
			global::android.net.TrafficStats._getMobileRxPackets5256 = @__env.GetStaticMethodIDNoThrow(global::android.net.TrafficStats.staticClass, "getMobileRxPackets", "()J");
			global::android.net.TrafficStats._getMobileTxBytes5257 = @__env.GetStaticMethodIDNoThrow(global::android.net.TrafficStats.staticClass, "getMobileTxBytes", "()J");
			global::android.net.TrafficStats._getMobileRxBytes5258 = @__env.GetStaticMethodIDNoThrow(global::android.net.TrafficStats.staticClass, "getMobileRxBytes", "()J");
			global::android.net.TrafficStats._getTotalTxPackets5259 = @__env.GetStaticMethodIDNoThrow(global::android.net.TrafficStats.staticClass, "getTotalTxPackets", "()J");
			global::android.net.TrafficStats._getTotalRxPackets5260 = @__env.GetStaticMethodIDNoThrow(global::android.net.TrafficStats.staticClass, "getTotalRxPackets", "()J");
			global::android.net.TrafficStats._getTotalTxBytes5261 = @__env.GetStaticMethodIDNoThrow(global::android.net.TrafficStats.staticClass, "getTotalTxBytes", "()J");
			global::android.net.TrafficStats._getTotalRxBytes5262 = @__env.GetStaticMethodIDNoThrow(global::android.net.TrafficStats.staticClass, "getTotalRxBytes", "()J");
			global::android.net.TrafficStats._getUidTxBytes5263 = @__env.GetStaticMethodIDNoThrow(global::android.net.TrafficStats.staticClass, "getUidTxBytes", "(I)J");
			global::android.net.TrafficStats._getUidRxBytes5264 = @__env.GetStaticMethodIDNoThrow(global::android.net.TrafficStats.staticClass, "getUidRxBytes", "(I)J");
			global::android.net.TrafficStats._TrafficStats5265 = @__env.GetMethodIDNoThrow(global::android.net.TrafficStats.staticClass, "<init>", "()V");
		}
	}
}
