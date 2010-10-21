namespace android
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Manifest : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Manifest()
		{
			InitJNI();
		}
		internal Manifest(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class permission : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static permission()
			{
				InitJNI();
			}
			internal permission(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _permission0;
			public permission()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.Manifest.permission.staticClass, global::android.Manifest.permission._permission0);
				Init(@__env, handle);
			}
			public static global::java.lang.String ACCESS_CHECKIN_PROPERTIES
			{
				get
				{
					return "android.permission.ACCESS_CHECKIN_PROPERTIES";
				}
			}
			public static global::java.lang.String ACCESS_COARSE_LOCATION
			{
				get
				{
					return "android.permission.ACCESS_COARSE_LOCATION";
				}
			}
			public static global::java.lang.String ACCESS_FINE_LOCATION
			{
				get
				{
					return "android.permission.ACCESS_FINE_LOCATION";
				}
			}
			public static global::java.lang.String ACCESS_LOCATION_EXTRA_COMMANDS
			{
				get
				{
					return "android.permission.ACCESS_LOCATION_EXTRA_COMMANDS";
				}
			}
			public static global::java.lang.String ACCESS_MOCK_LOCATION
			{
				get
				{
					return "android.permission.ACCESS_MOCK_LOCATION";
				}
			}
			public static global::java.lang.String ACCESS_NETWORK_STATE
			{
				get
				{
					return "android.permission.ACCESS_NETWORK_STATE";
				}
			}
			public static global::java.lang.String ACCESS_SURFACE_FLINGER
			{
				get
				{
					return "android.permission.ACCESS_SURFACE_FLINGER";
				}
			}
			public static global::java.lang.String ACCESS_WIFI_STATE
			{
				get
				{
					return "android.permission.ACCESS_WIFI_STATE";
				}
			}
			public static global::java.lang.String ACCOUNT_MANAGER
			{
				get
				{
					return "android.permission.ACCOUNT_MANAGER";
				}
			}
			public static global::java.lang.String AUTHENTICATE_ACCOUNTS
			{
				get
				{
					return "android.permission.AUTHENTICATE_ACCOUNTS";
				}
			}
			public static global::java.lang.String BATTERY_STATS
			{
				get
				{
					return "android.permission.BATTERY_STATS";
				}
			}
			public static global::java.lang.String BIND_APPWIDGET
			{
				get
				{
					return "android.permission.BIND_APPWIDGET";
				}
			}
			public static global::java.lang.String BIND_DEVICE_ADMIN
			{
				get
				{
					return "android.permission.BIND_DEVICE_ADMIN";
				}
			}
			public static global::java.lang.String BIND_INPUT_METHOD
			{
				get
				{
					return "android.permission.BIND_INPUT_METHOD";
				}
			}
			public static global::java.lang.String BIND_WALLPAPER
			{
				get
				{
					return "android.permission.BIND_WALLPAPER";
				}
			}
			public static global::java.lang.String BLUETOOTH
			{
				get
				{
					return "android.permission.BLUETOOTH";
				}
			}
			public static global::java.lang.String BLUETOOTH_ADMIN
			{
				get
				{
					return "android.permission.BLUETOOTH_ADMIN";
				}
			}
			public static global::java.lang.String BRICK
			{
				get
				{
					return "android.permission.BRICK";
				}
			}
			public static global::java.lang.String BROADCAST_PACKAGE_REMOVED
			{
				get
				{
					return "android.permission.BROADCAST_PACKAGE_REMOVED";
				}
			}
			public static global::java.lang.String BROADCAST_SMS
			{
				get
				{
					return "android.permission.BROADCAST_SMS";
				}
			}
			public static global::java.lang.String BROADCAST_STICKY
			{
				get
				{
					return "android.permission.BROADCAST_STICKY";
				}
			}
			public static global::java.lang.String BROADCAST_WAP_PUSH
			{
				get
				{
					return "android.permission.BROADCAST_WAP_PUSH";
				}
			}
			public static global::java.lang.String CALL_PHONE
			{
				get
				{
					return "android.permission.CALL_PHONE";
				}
			}
			public static global::java.lang.String CALL_PRIVILEGED
			{
				get
				{
					return "android.permission.CALL_PRIVILEGED";
				}
			}
			public static global::java.lang.String CAMERA
			{
				get
				{
					return "android.permission.CAMERA";
				}
			}
			public static global::java.lang.String CHANGE_COMPONENT_ENABLED_STATE
			{
				get
				{
					return "android.permission.CHANGE_COMPONENT_ENABLED_STATE";
				}
			}
			public static global::java.lang.String CHANGE_CONFIGURATION
			{
				get
				{
					return "android.permission.CHANGE_CONFIGURATION";
				}
			}
			public static global::java.lang.String CHANGE_NETWORK_STATE
			{
				get
				{
					return "android.permission.CHANGE_NETWORK_STATE";
				}
			}
			public static global::java.lang.String CHANGE_WIFI_MULTICAST_STATE
			{
				get
				{
					return "android.permission.CHANGE_WIFI_MULTICAST_STATE";
				}
			}
			public static global::java.lang.String CHANGE_WIFI_STATE
			{
				get
				{
					return "android.permission.CHANGE_WIFI_STATE";
				}
			}
			public static global::java.lang.String CLEAR_APP_CACHE
			{
				get
				{
					return "android.permission.CLEAR_APP_CACHE";
				}
			}
			public static global::java.lang.String CLEAR_APP_USER_DATA
			{
				get
				{
					return "android.permission.CLEAR_APP_USER_DATA";
				}
			}
			public static global::java.lang.String CONTROL_LOCATION_UPDATES
			{
				get
				{
					return "android.permission.CONTROL_LOCATION_UPDATES";
				}
			}
			public static global::java.lang.String DELETE_CACHE_FILES
			{
				get
				{
					return "android.permission.DELETE_CACHE_FILES";
				}
			}
			public static global::java.lang.String DELETE_PACKAGES
			{
				get
				{
					return "android.permission.DELETE_PACKAGES";
				}
			}
			public static global::java.lang.String DEVICE_POWER
			{
				get
				{
					return "android.permission.DEVICE_POWER";
				}
			}
			public static global::java.lang.String DIAGNOSTIC
			{
				get
				{
					return "android.permission.DIAGNOSTIC";
				}
			}
			public static global::java.lang.String DISABLE_KEYGUARD
			{
				get
				{
					return "android.permission.DISABLE_KEYGUARD";
				}
			}
			public static global::java.lang.String DUMP
			{
				get
				{
					return "android.permission.DUMP";
				}
			}
			public static global::java.lang.String EXPAND_STATUS_BAR
			{
				get
				{
					return "android.permission.EXPAND_STATUS_BAR";
				}
			}
			public static global::java.lang.String FACTORY_TEST
			{
				get
				{
					return "android.permission.FACTORY_TEST";
				}
			}
			public static global::java.lang.String FLASHLIGHT
			{
				get
				{
					return "android.permission.FLASHLIGHT";
				}
			}
			public static global::java.lang.String FORCE_BACK
			{
				get
				{
					return "android.permission.FORCE_BACK";
				}
			}
			public static global::java.lang.String GET_ACCOUNTS
			{
				get
				{
					return "android.permission.GET_ACCOUNTS";
				}
			}
			public static global::java.lang.String GET_PACKAGE_SIZE
			{
				get
				{
					return "android.permission.GET_PACKAGE_SIZE";
				}
			}
			public static global::java.lang.String GET_TASKS
			{
				get
				{
					return "android.permission.GET_TASKS";
				}
			}
			public static global::java.lang.String GLOBAL_SEARCH
			{
				get
				{
					return "android.permission.GLOBAL_SEARCH";
				}
			}
			public static global::java.lang.String HARDWARE_TEST
			{
				get
				{
					return "android.permission.HARDWARE_TEST";
				}
			}
			public static global::java.lang.String INJECT_EVENTS
			{
				get
				{
					return "android.permission.INJECT_EVENTS";
				}
			}
			public static global::java.lang.String INSTALL_LOCATION_PROVIDER
			{
				get
				{
					return "android.permission.INSTALL_LOCATION_PROVIDER";
				}
			}
			public static global::java.lang.String INSTALL_PACKAGES
			{
				get
				{
					return "android.permission.INSTALL_PACKAGES";
				}
			}
			public static global::java.lang.String INTERNAL_SYSTEM_WINDOW
			{
				get
				{
					return "android.permission.INTERNAL_SYSTEM_WINDOW";
				}
			}
			public static global::java.lang.String INTERNET
			{
				get
				{
					return "android.permission.INTERNET";
				}
			}
			public static global::java.lang.String KILL_BACKGROUND_PROCESSES
			{
				get
				{
					return "android.permission.KILL_BACKGROUND_PROCESSES";
				}
			}
			public static global::java.lang.String MANAGE_ACCOUNTS
			{
				get
				{
					return "android.permission.MANAGE_ACCOUNTS";
				}
			}
			public static global::java.lang.String MANAGE_APP_TOKENS
			{
				get
				{
					return "android.permission.MANAGE_APP_TOKENS";
				}
			}
			public static global::java.lang.String MASTER_CLEAR
			{
				get
				{
					return "android.permission.MASTER_CLEAR";
				}
			}
			public static global::java.lang.String MODIFY_AUDIO_SETTINGS
			{
				get
				{
					return "android.permission.MODIFY_AUDIO_SETTINGS";
				}
			}
			public static global::java.lang.String MODIFY_PHONE_STATE
			{
				get
				{
					return "android.permission.MODIFY_PHONE_STATE";
				}
			}
			public static global::java.lang.String MOUNT_FORMAT_FILESYSTEMS
			{
				get
				{
					return "android.permission.MOUNT_FORMAT_FILESYSTEMS";
				}
			}
			public static global::java.lang.String MOUNT_UNMOUNT_FILESYSTEMS
			{
				get
				{
					return "android.permission.MOUNT_UNMOUNT_FILESYSTEMS";
				}
			}
			public static global::java.lang.String PERSISTENT_ACTIVITY
			{
				get
				{
					return "android.permission.PERSISTENT_ACTIVITY";
				}
			}
			public static global::java.lang.String PROCESS_OUTGOING_CALLS
			{
				get
				{
					return "android.permission.PROCESS_OUTGOING_CALLS";
				}
			}
			public static global::java.lang.String READ_CALENDAR
			{
				get
				{
					return "android.permission.READ_CALENDAR";
				}
			}
			public static global::java.lang.String READ_CONTACTS
			{
				get
				{
					return "android.permission.READ_CONTACTS";
				}
			}
			public static global::java.lang.String READ_FRAME_BUFFER
			{
				get
				{
					return "android.permission.READ_FRAME_BUFFER";
				}
			}
			public static global::java.lang.String READ_HISTORY_BOOKMARKS
			{
				get
				{
					return "com.android.browser.permission.READ_HISTORY_BOOKMARKS";
				}
			}
			public static global::java.lang.String READ_INPUT_STATE
			{
				get
				{
					return "android.permission.READ_INPUT_STATE";
				}
			}
			public static global::java.lang.String READ_LOGS
			{
				get
				{
					return "android.permission.READ_LOGS";
				}
			}
			public static global::java.lang.String READ_OWNER_DATA
			{
				get
				{
					return "android.permission.READ_OWNER_DATA";
				}
			}
			public static global::java.lang.String READ_PHONE_STATE
			{
				get
				{
					return "android.permission.READ_PHONE_STATE";
				}
			}
			public static global::java.lang.String READ_SMS
			{
				get
				{
					return "android.permission.READ_SMS";
				}
			}
			public static global::java.lang.String READ_SYNC_SETTINGS
			{
				get
				{
					return "android.permission.READ_SYNC_SETTINGS";
				}
			}
			public static global::java.lang.String READ_SYNC_STATS
			{
				get
				{
					return "android.permission.READ_SYNC_STATS";
				}
			}
			public static global::java.lang.String REBOOT
			{
				get
				{
					return "android.permission.REBOOT";
				}
			}
			public static global::java.lang.String RECEIVE_BOOT_COMPLETED
			{
				get
				{
					return "android.permission.RECEIVE_BOOT_COMPLETED";
				}
			}
			public static global::java.lang.String RECEIVE_MMS
			{
				get
				{
					return "android.permission.RECEIVE_MMS";
				}
			}
			public static global::java.lang.String RECEIVE_SMS
			{
				get
				{
					return "android.permission.RECEIVE_SMS";
				}
			}
			public static global::java.lang.String RECEIVE_WAP_PUSH
			{
				get
				{
					return "android.permission.RECEIVE_WAP_PUSH";
				}
			}
			public static global::java.lang.String RECORD_AUDIO
			{
				get
				{
					return "android.permission.RECORD_AUDIO";
				}
			}
			public static global::java.lang.String REORDER_TASKS
			{
				get
				{
					return "android.permission.REORDER_TASKS";
				}
			}
			public static global::java.lang.String RESTART_PACKAGES
			{
				get
				{
					return "android.permission.RESTART_PACKAGES";
				}
			}
			public static global::java.lang.String SEND_SMS
			{
				get
				{
					return "android.permission.SEND_SMS";
				}
			}
			public static global::java.lang.String SET_ACTIVITY_WATCHER
			{
				get
				{
					return "android.permission.SET_ACTIVITY_WATCHER";
				}
			}
			public static global::java.lang.String SET_ALWAYS_FINISH
			{
				get
				{
					return "android.permission.SET_ALWAYS_FINISH";
				}
			}
			public static global::java.lang.String SET_ANIMATION_SCALE
			{
				get
				{
					return "android.permission.SET_ANIMATION_SCALE";
				}
			}
			public static global::java.lang.String SET_DEBUG_APP
			{
				get
				{
					return "android.permission.SET_DEBUG_APP";
				}
			}
			public static global::java.lang.String SET_ORIENTATION
			{
				get
				{
					return "android.permission.SET_ORIENTATION";
				}
			}
			public static global::java.lang.String SET_PREFERRED_APPLICATIONS
			{
				get
				{
					return "android.permission.SET_PREFERRED_APPLICATIONS";
				}
			}
			public static global::java.lang.String SET_PROCESS_LIMIT
			{
				get
				{
					return "android.permission.SET_PROCESS_LIMIT";
				}
			}
			public static global::java.lang.String SET_TIME
			{
				get
				{
					return "android.permission.SET_TIME";
				}
			}
			public static global::java.lang.String SET_TIME_ZONE
			{
				get
				{
					return "android.permission.SET_TIME_ZONE";
				}
			}
			public static global::java.lang.String SET_WALLPAPER
			{
				get
				{
					return "android.permission.SET_WALLPAPER";
				}
			}
			public static global::java.lang.String SET_WALLPAPER_HINTS
			{
				get
				{
					return "android.permission.SET_WALLPAPER_HINTS";
				}
			}
			public static global::java.lang.String SIGNAL_PERSISTENT_PROCESSES
			{
				get
				{
					return "android.permission.SIGNAL_PERSISTENT_PROCESSES";
				}
			}
			public static global::java.lang.String STATUS_BAR
			{
				get
				{
					return "android.permission.STATUS_BAR";
				}
			}
			public static global::java.lang.String SUBSCRIBED_FEEDS_READ
			{
				get
				{
					return "android.permission.SUBSCRIBED_FEEDS_READ";
				}
			}
			public static global::java.lang.String SUBSCRIBED_FEEDS_WRITE
			{
				get
				{
					return "android.permission.SUBSCRIBED_FEEDS_WRITE";
				}
			}
			public static global::java.lang.String SYSTEM_ALERT_WINDOW
			{
				get
				{
					return "android.permission.SYSTEM_ALERT_WINDOW";
				}
			}
			public static global::java.lang.String UPDATE_DEVICE_STATS
			{
				get
				{
					return "android.permission.UPDATE_DEVICE_STATS";
				}
			}
			public static global::java.lang.String USE_CREDENTIALS
			{
				get
				{
					return "android.permission.USE_CREDENTIALS";
				}
			}
			public static global::java.lang.String VIBRATE
			{
				get
				{
					return "android.permission.VIBRATE";
				}
			}
			public static global::java.lang.String WAKE_LOCK
			{
				get
				{
					return "android.permission.WAKE_LOCK";
				}
			}
			public static global::java.lang.String WRITE_APN_SETTINGS
			{
				get
				{
					return "android.permission.WRITE_APN_SETTINGS";
				}
			}
			public static global::java.lang.String WRITE_CALENDAR
			{
				get
				{
					return "android.permission.WRITE_CALENDAR";
				}
			}
			public static global::java.lang.String WRITE_CONTACTS
			{
				get
				{
					return "android.permission.WRITE_CONTACTS";
				}
			}
			public static global::java.lang.String WRITE_EXTERNAL_STORAGE
			{
				get
				{
					return "android.permission.WRITE_EXTERNAL_STORAGE";
				}
			}
			public static global::java.lang.String WRITE_GSERVICES
			{
				get
				{
					return "android.permission.WRITE_GSERVICES";
				}
			}
			public static global::java.lang.String WRITE_HISTORY_BOOKMARKS
			{
				get
				{
					return "com.android.browser.permission.WRITE_HISTORY_BOOKMARKS";
				}
			}
			public static global::java.lang.String WRITE_OWNER_DATA
			{
				get
				{
					return "android.permission.WRITE_OWNER_DATA";
				}
			}
			public static global::java.lang.String WRITE_SECURE_SETTINGS
			{
				get
				{
					return "android.permission.WRITE_SECURE_SETTINGS";
				}
			}
			public static global::java.lang.String WRITE_SETTINGS
			{
				get
				{
					return "android.permission.WRITE_SETTINGS";
				}
			}
			public static global::java.lang.String WRITE_SMS
			{
				get
				{
					return "android.permission.WRITE_SMS";
				}
			}
			public static global::java.lang.String WRITE_SYNC_SETTINGS
			{
				get
				{
					return "android.permission.WRITE_SYNC_SETTINGS";
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.Manifest.permission.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/Manifest$permission"));
				global::android.Manifest.permission._permission0 = @__env.GetMethodIDNoThrow(global::android.Manifest.permission.staticClass, "<init>", "()V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class permission_group : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static permission_group()
			{
				InitJNI();
			}
			internal permission_group(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _permission_group115;
			public permission_group()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.Manifest.permission_group.staticClass, global::android.Manifest.permission_group._permission_group115);
				Init(@__env, handle);
			}
			public static global::java.lang.String ACCOUNTS
			{
				get
				{
					return "android.permission-group.ACCOUNTS";
				}
			}
			public static global::java.lang.String COST_MONEY
			{
				get
				{
					return "android.permission-group.COST_MONEY";
				}
			}
			public static global::java.lang.String DEVELOPMENT_TOOLS
			{
				get
				{
					return "android.permission-group.DEVELOPMENT_TOOLS";
				}
			}
			public static global::java.lang.String HARDWARE_CONTROLS
			{
				get
				{
					return "android.permission-group.HARDWARE_CONTROLS";
				}
			}
			public static global::java.lang.String LOCATION
			{
				get
				{
					return "android.permission-group.LOCATION";
				}
			}
			public static global::java.lang.String MESSAGES
			{
				get
				{
					return "android.permission-group.MESSAGES";
				}
			}
			public static global::java.lang.String NETWORK
			{
				get
				{
					return "android.permission-group.NETWORK";
				}
			}
			public static global::java.lang.String PERSONAL_INFO
			{
				get
				{
					return "android.permission-group.PERSONAL_INFO";
				}
			}
			public static global::java.lang.String PHONE_CALLS
			{
				get
				{
					return "android.permission-group.PHONE_CALLS";
				}
			}
			public static global::java.lang.String STORAGE
			{
				get
				{
					return "android.permission-group.STORAGE";
				}
			}
			public static global::java.lang.String SYSTEM_TOOLS
			{
				get
				{
					return "android.permission-group.SYSTEM_TOOLS";
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.Manifest.permission_group.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/Manifest$permission_group"));
				global::android.Manifest.permission_group._permission_group115 = @__env.GetMethodIDNoThrow(global::android.Manifest.permission_group.staticClass, "<init>", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _Manifest127;
		public Manifest()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.Manifest.staticClass, global::android.Manifest._Manifest127);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.Manifest.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/Manifest"));
			global::android.Manifest._Manifest127 = @__env.GetMethodIDNoThrow(global::android.Manifest.staticClass, "<init>", "()V");
		}
	}
}
