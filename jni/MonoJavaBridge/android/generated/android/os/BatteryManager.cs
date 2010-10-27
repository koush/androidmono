namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BatteryManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BatteryManager()
		{
			InitJNI();
		}
		protected BatteryManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _BatteryManager9515;
		public BatteryManager() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.BatteryManager.staticClass, global::android.os.BatteryManager._BatteryManager9515);
			Init(@__env, handle);
		}
		public static global::java.lang.String EXTRA_STATUS
		{
			get
			{
				return "status";
			}
		}
		public static global::java.lang.String EXTRA_HEALTH
		{
			get
			{
				return "health";
			}
		}
		public static global::java.lang.String EXTRA_PRESENT
		{
			get
			{
				return "present";
			}
		}
		public static global::java.lang.String EXTRA_LEVEL
		{
			get
			{
				return "level";
			}
		}
		public static global::java.lang.String EXTRA_SCALE
		{
			get
			{
				return "scale";
			}
		}
		public static global::java.lang.String EXTRA_ICON_SMALL
		{
			get
			{
				return "icon-small";
			}
		}
		public static global::java.lang.String EXTRA_PLUGGED
		{
			get
			{
				return "plugged";
			}
		}
		public static global::java.lang.String EXTRA_VOLTAGE
		{
			get
			{
				return "voltage";
			}
		}
		public static global::java.lang.String EXTRA_TEMPERATURE
		{
			get
			{
				return "temperature";
			}
		}
		public static global::java.lang.String EXTRA_TECHNOLOGY
		{
			get
			{
				return "technology";
			}
		}
		public static int BATTERY_STATUS_UNKNOWN
		{
			get
			{
				return 1;
			}
		}
		public static int BATTERY_STATUS_CHARGING
		{
			get
			{
				return 2;
			}
		}
		public static int BATTERY_STATUS_DISCHARGING
		{
			get
			{
				return 3;
			}
		}
		public static int BATTERY_STATUS_NOT_CHARGING
		{
			get
			{
				return 4;
			}
		}
		public static int BATTERY_STATUS_FULL
		{
			get
			{
				return 5;
			}
		}
		public static int BATTERY_HEALTH_UNKNOWN
		{
			get
			{
				return 1;
			}
		}
		public static int BATTERY_HEALTH_GOOD
		{
			get
			{
				return 2;
			}
		}
		public static int BATTERY_HEALTH_OVERHEAT
		{
			get
			{
				return 3;
			}
		}
		public static int BATTERY_HEALTH_DEAD
		{
			get
			{
				return 4;
			}
		}
		public static int BATTERY_HEALTH_OVER_VOLTAGE
		{
			get
			{
				return 5;
			}
		}
		public static int BATTERY_HEALTH_UNSPECIFIED_FAILURE
		{
			get
			{
				return 6;
			}
		}
		public static int BATTERY_PLUGGED_AC
		{
			get
			{
				return 1;
			}
		}
		public static int BATTERY_PLUGGED_USB
		{
			get
			{
				return 2;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.BatteryManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/BatteryManager"));
			global::android.os.BatteryManager._BatteryManager9515 = @__env.GetMethodIDNoThrow(global::android.os.BatteryManager.staticClass, "<init>", "()V");
		}
	}
}
