namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class BatteryManager : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static BatteryManager() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.BatteryManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.os.BatteryManager(@__env); 
			} 
		} 
		protected BatteryManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _BatteryManager5351; 
		public BatteryManager()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.BatteryManager.staticClass, global::android.os.BatteryManager._BatteryManager5351, this); 
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.os.BatteryManager.staticClass = @__class; 
			global::android.os.BatteryManager._BatteryManager5351 = @__env.GetMethodID(global::android.os.BatteryManager.staticClass, "<init>", "()V"); 
		} 
	} 
} 
