namespace android.provider 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class Settings : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Settings() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.Settings), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.provider.Settings(@__env); 
			} 
		} 
		internal Settings(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class NameValueTable : java.lang.Object, BaseColumns
		{ 
			internal static global::java.lang.Class staticClass; 
			static NameValueTable() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.Settings.NameValueTable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.Settings.NameValueTable(@__env); 
				} 
			} 
			protected NameValueTable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _putString6039; 
			protected static bool putString(android.content.ContentResolver arg0, android.net.Uri arg1, java.lang.String arg2, java.lang.String arg3) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticBooleanMethod(android.provider.Settings.NameValueTable.staticClass, _putString6039, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getUriFor6040; 
			public static android.net.Uri getUriFor(android.net.Uri arg0, java.lang.String arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.Settings.NameValueTable.staticClass, _getUriFor6040, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _NameValueTable6041; 
			public NameValueTable()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.provider.Settings.NameValueTable.staticClass, _NameValueTable6041, this); 
			} 
			public static java.lang.String NAME
			{ 
				get 
				{ 
					return "name"; 
				} 
			} 
			public static java.lang.String VALUE
			{ 
				get 
				{ 
					return "value"; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.Settings.NameValueTable.staticClass = @__class; 
				global::android.provider.Settings.NameValueTable._putString6039 = @__env.GetStaticMethodID(global::android.provider.Settings.NameValueTable.staticClass, "putString", "(Landroid/content/ContentResolver;Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;)Z"); 
				global::android.provider.Settings.NameValueTable._getUriFor6040 = @__env.GetStaticMethodID(global::android.provider.Settings.NameValueTable.staticClass, "getUriFor", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/net/Uri;"); 
				global::android.provider.Settings.NameValueTable._NameValueTable6041 = @__env.GetMethodID(global::android.provider.Settings.NameValueTable.staticClass, "<init>", "()V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Secure : android.provider.Settings.NameValueTable
		{ 
			internal new static global::java.lang.Class staticClass; 
			static Secure() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.Settings.Secure), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.Settings.Secure(@__env); 
				} 
			} 
			internal Secure(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getInt6042; 
			public static int getInt(android.content.ContentResolver arg0, java.lang.String arg1, int arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticIntMethod(android.provider.Settings.Secure.staticClass, _getInt6042, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getInt6043; 
			public static int getInt(android.content.ContentResolver arg0, java.lang.String arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticIntMethod(android.provider.Settings.Secure.staticClass, _getInt6043, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _putInt6044; 
			public static bool putInt(android.content.ContentResolver arg0, java.lang.String arg1, int arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticBooleanMethod(android.provider.Settings.Secure.staticClass, _putInt6044, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getLong6045; 
			public static long getLong(android.content.ContentResolver arg0, java.lang.String arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticLongMethod(android.provider.Settings.Secure.staticClass, _getLong6045, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getLong6046; 
			public static long getLong(android.content.ContentResolver arg0, java.lang.String arg1, long arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticLongMethod(android.provider.Settings.Secure.staticClass, _getLong6046, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _putLong6047; 
			public static bool putLong(android.content.ContentResolver arg0, java.lang.String arg1, long arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticBooleanMethod(android.provider.Settings.Secure.staticClass, _putLong6047, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getFloat6048; 
			public static float getFloat(android.content.ContentResolver arg0, java.lang.String arg1, float arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticFloatMethod(android.provider.Settings.Secure.staticClass, _getFloat6048, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getFloat6049; 
			public static float getFloat(android.content.ContentResolver arg0, java.lang.String arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticFloatMethod(android.provider.Settings.Secure.staticClass, _getFloat6049, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _putFloat6050; 
			public static bool putFloat(android.content.ContentResolver arg0, java.lang.String arg1, float arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticBooleanMethod(android.provider.Settings.Secure.staticClass, _putFloat6050, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getString6051; 
			public static java.lang.String getString(android.content.ContentResolver arg0, java.lang.String arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.Settings.Secure.staticClass, _getString6051, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _putString6052; 
			public static bool putString(android.content.ContentResolver arg0, java.lang.String arg1, java.lang.String arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticBooleanMethod(android.provider.Settings.Secure.staticClass, _putString6052, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getUriFor6053; 
			public static android.net.Uri getUriFor(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.Settings.Secure.staticClass, _getUriFor6053, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _Secure6054; 
			public Secure()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.provider.Settings.Secure.staticClass, _Secure6054, this); 
			} 
			public static java.lang.String SYS_PROP_SETTING_VERSION
			{ 
				get 
				{ 
					return "sys.settings_secure_version"; 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONTENT_URI6055; 
			public static android.net.Uri CONTENT_URI
			{ 
				get 
				{ 
					return default(android.net.Uri); 
				} 
			} 
			public static java.lang.String ADB_ENABLED
			{ 
				get 
				{ 
					return "adb_enabled"; 
				} 
			} 
			public static java.lang.String ALLOW_MOCK_LOCATION
			{ 
				get 
				{ 
					return "mock_location"; 
				} 
			} 
			public static java.lang.String ANDROID_ID
			{ 
				get 
				{ 
					return "android_id"; 
				} 
			} 
			public static java.lang.String BLUETOOTH_ON
			{ 
				get 
				{ 
					return "bluetooth_on"; 
				} 
			} 
			public static java.lang.String DATA_ROAMING
			{ 
				get 
				{ 
					return "data_roaming"; 
				} 
			} 
			public static java.lang.String DEFAULT_INPUT_METHOD
			{ 
				get 
				{ 
					return "default_input_method"; 
				} 
			} 
			public static java.lang.String DEVICE_PROVISIONED
			{ 
				get 
				{ 
					return "device_provisioned"; 
				} 
			} 
			public static java.lang.String ENABLED_INPUT_METHODS
			{ 
				get 
				{ 
					return "enabled_input_methods"; 
				} 
			} 
			public static java.lang.String HTTP_PROXY
			{ 
				get 
				{ 
					return "http_proxy"; 
				} 
			} 
			public static java.lang.String INSTALL_NON_MARKET_APPS
			{ 
				get 
				{ 
					return "install_non_market_apps"; 
				} 
			} 
			public static java.lang.String LOCATION_PROVIDERS_ALLOWED
			{ 
				get 
				{ 
					return "location_providers_allowed"; 
				} 
			} 
			public static java.lang.String LOGGING_ID
			{ 
				get 
				{ 
					return "logging_id"; 
				} 
			} 
			public static java.lang.String NETWORK_PREFERENCE
			{ 
				get 
				{ 
					return "network_preference"; 
				} 
			} 
			public static java.lang.String PARENTAL_CONTROL_ENABLED
			{ 
				get 
				{ 
					return "parental_control_enabled"; 
				} 
			} 
			public static java.lang.String PARENTAL_CONTROL_LAST_UPDATE
			{ 
				get 
				{ 
					return "parental_control_last_update"; 
				} 
			} 
			public static java.lang.String PARENTAL_CONTROL_REDIRECT_URL
			{ 
				get 
				{ 
					return "parental_control_redirect_url"; 
				} 
			} 
			public static java.lang.String SETTINGS_CLASSNAME
			{ 
				get 
				{ 
					return "settings_classname"; 
				} 
			} 
			public static java.lang.String USB_MASS_STORAGE_ENABLED
			{ 
				get 
				{ 
					return "usb_mass_storage_enabled"; 
				} 
			} 
			public static java.lang.String USE_GOOGLE_MAIL
			{ 
				get 
				{ 
					return "use_google_mail"; 
				} 
			} 
			public static java.lang.String ACCESSIBILITY_ENABLED
			{ 
				get 
				{ 
					return "accessibility_enabled"; 
				} 
			} 
			public static java.lang.String ENABLED_ACCESSIBILITY_SERVICES
			{ 
				get 
				{ 
					return "enabled_accessibility_services"; 
				} 
			} 
			public static java.lang.String TTS_USE_DEFAULTS
			{ 
				get 
				{ 
					return "tts_use_defaults"; 
				} 
			} 
			public static java.lang.String TTS_DEFAULT_RATE
			{ 
				get 
				{ 
					return "tts_default_rate"; 
				} 
			} 
			public static java.lang.String TTS_DEFAULT_PITCH
			{ 
				get 
				{ 
					return "tts_default_pitch"; 
				} 
			} 
			public static java.lang.String TTS_DEFAULT_SYNTH
			{ 
				get 
				{ 
					return "tts_default_synth"; 
				} 
			} 
			public static java.lang.String TTS_DEFAULT_LANG
			{ 
				get 
				{ 
					return "tts_default_lang"; 
				} 
			} 
			public static java.lang.String TTS_DEFAULT_COUNTRY
			{ 
				get 
				{ 
					return "tts_default_country"; 
				} 
			} 
			public static java.lang.String TTS_DEFAULT_VARIANT
			{ 
				get 
				{ 
					return "tts_default_variant"; 
				} 
			} 
			public static java.lang.String WIFI_NETWORKS_AVAILABLE_NOTIFICATION_ON
			{ 
				get 
				{ 
					return "wifi_networks_available_notification_on"; 
				} 
			} 
			public static java.lang.String WIFI_NETWORKS_AVAILABLE_REPEAT_DELAY
			{ 
				get 
				{ 
					return "wifi_networks_available_repeat_delay"; 
				} 
			} 
			public static java.lang.String WIFI_NUM_OPEN_NETWORKS_KEPT
			{ 
				get 
				{ 
					return "wifi_num_open_networks_kept"; 
				} 
			} 
			public static java.lang.String WIFI_ON
			{ 
				get 
				{ 
					return "wifi_on"; 
				} 
			} 
			public static java.lang.String WIFI_WATCHDOG_ACCEPTABLE_PACKET_LOSS_PERCENTAGE
			{ 
				get 
				{ 
					return "wifi_watchdog_acceptable_packet_loss_percentage"; 
				} 
			} 
			public static java.lang.String WIFI_WATCHDOG_AP_COUNT
			{ 
				get 
				{ 
					return "wifi_watchdog_ap_count"; 
				} 
			} 
			public static java.lang.String WIFI_WATCHDOG_BACKGROUND_CHECK_DELAY_MS
			{ 
				get 
				{ 
					return "wifi_watchdog_background_check_delay_ms"; 
				} 
			} 
			public static java.lang.String WIFI_WATCHDOG_BACKGROUND_CHECK_ENABLED
			{ 
				get 
				{ 
					return "wifi_watchdog_background_check_enabled"; 
				} 
			} 
			public static java.lang.String WIFI_WATCHDOG_BACKGROUND_CHECK_TIMEOUT_MS
			{ 
				get 
				{ 
					return "wifi_watchdog_background_check_timeout_ms"; 
				} 
			} 
			public static java.lang.String WIFI_WATCHDOG_INITIAL_IGNORED_PING_COUNT
			{ 
				get 
				{ 
					return "wifi_watchdog_initial_ignored_ping_count"; 
				} 
			} 
			public static java.lang.String WIFI_WATCHDOG_MAX_AP_CHECKS
			{ 
				get 
				{ 
					return "wifi_watchdog_max_ap_checks"; 
				} 
			} 
			public static java.lang.String WIFI_WATCHDOG_ON
			{ 
				get 
				{ 
					return "wifi_watchdog_on"; 
				} 
			} 
			public static java.lang.String WIFI_WATCHDOG_WATCH_LIST
			{ 
				get 
				{ 
					return "wifi_watchdog_watch_list"; 
				} 
			} 
			public static java.lang.String WIFI_WATCHDOG_PING_COUNT
			{ 
				get 
				{ 
					return "wifi_watchdog_ping_count"; 
				} 
			} 
			public static java.lang.String WIFI_WATCHDOG_PING_DELAY_MS
			{ 
				get 
				{ 
					return "wifi_watchdog_ping_delay_ms"; 
				} 
			} 
			public static java.lang.String WIFI_WATCHDOG_PING_TIMEOUT_MS
			{ 
				get 
				{ 
					return "wifi_watchdog_ping_timeout_ms"; 
				} 
			} 
			public static java.lang.String WIFI_MAX_DHCP_RETRY_COUNT
			{ 
				get 
				{ 
					return "wifi_max_dhcp_retry_count"; 
				} 
			} 
			public static java.lang.String WIFI_MOBILE_DATA_TRANSITION_WAKELOCK_TIMEOUT_MS
			{ 
				get 
				{ 
					return "wifi_mobile_data_transition_wakelock_timeout_ms"; 
				} 
			} 
			public static java.lang.String BACKGROUND_DATA
			{ 
				get 
				{ 
					return "background_data"; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.Settings.Secure.staticClass = @__class; 
				global::android.provider.Settings.Secure._getInt6042 = @__env.GetStaticMethodID(global::android.provider.Settings.Secure.staticClass, "getInt", "(Landroid/content/ContentResolver;Ljava/lang/String;I)I"); 
				global::android.provider.Settings.Secure._getInt6043 = @__env.GetStaticMethodID(global::android.provider.Settings.Secure.staticClass, "getInt", "(Landroid/content/ContentResolver;Ljava/lang/String;)I"); 
				global::android.provider.Settings.Secure._putInt6044 = @__env.GetStaticMethodID(global::android.provider.Settings.Secure.staticClass, "putInt", "(Landroid/content/ContentResolver;Ljava/lang/String;I)Z"); 
				global::android.provider.Settings.Secure._getLong6045 = @__env.GetStaticMethodID(global::android.provider.Settings.Secure.staticClass, "getLong", "(Landroid/content/ContentResolver;Ljava/lang/String;)J"); 
				global::android.provider.Settings.Secure._getLong6046 = @__env.GetStaticMethodID(global::android.provider.Settings.Secure.staticClass, "getLong", "(Landroid/content/ContentResolver;Ljava/lang/String;J)J"); 
				global::android.provider.Settings.Secure._putLong6047 = @__env.GetStaticMethodID(global::android.provider.Settings.Secure.staticClass, "putLong", "(Landroid/content/ContentResolver;Ljava/lang/String;J)Z"); 
				global::android.provider.Settings.Secure._getFloat6048 = @__env.GetStaticMethodID(global::android.provider.Settings.Secure.staticClass, "getFloat", "(Landroid/content/ContentResolver;Ljava/lang/String;F)F"); 
				global::android.provider.Settings.Secure._getFloat6049 = @__env.GetStaticMethodID(global::android.provider.Settings.Secure.staticClass, "getFloat", "(Landroid/content/ContentResolver;Ljava/lang/String;)F"); 
				global::android.provider.Settings.Secure._putFloat6050 = @__env.GetStaticMethodID(global::android.provider.Settings.Secure.staticClass, "putFloat", "(Landroid/content/ContentResolver;Ljava/lang/String;F)Z"); 
				global::android.provider.Settings.Secure._getString6051 = @__env.GetStaticMethodID(global::android.provider.Settings.Secure.staticClass, "getString", "(Landroid/content/ContentResolver;Ljava/lang/String;)Ljava/lang/String;"); 
				global::android.provider.Settings.Secure._putString6052 = @__env.GetStaticMethodID(global::android.provider.Settings.Secure.staticClass, "putString", "(Landroid/content/ContentResolver;Ljava/lang/String;Ljava/lang/String;)Z"); 
				global::android.provider.Settings.Secure._getUriFor6053 = @__env.GetStaticMethodID(global::android.provider.Settings.Secure.staticClass, "getUriFor", "(Ljava/lang/String;)Landroid/net/Uri;"); 
				global::android.provider.Settings.Secure._Secure6054 = @__env.GetMethodID(global::android.provider.Settings.Secure.staticClass, "<init>", "()V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class SettingNotFoundException : android.util.AndroidException
		{ 
			internal new static global::java.lang.Class staticClass; 
			static SettingNotFoundException() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.Settings.SettingNotFoundException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.Settings.SettingNotFoundException(@__env); 
				} 
			} 
			protected SettingNotFoundException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _SettingNotFoundException6056; 
			public SettingNotFoundException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.provider.Settings.SettingNotFoundException.staticClass, _SettingNotFoundException6056, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.Settings.SettingNotFoundException.staticClass = @__class; 
				global::android.provider.Settings.SettingNotFoundException._SettingNotFoundException6056 = @__env.GetMethodID(global::android.provider.Settings.SettingNotFoundException.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class System : android.provider.Settings.NameValueTable
		{ 
			internal new static global::java.lang.Class staticClass; 
			static System() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.Settings.System), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.provider.Settings.System(@__env); 
				} 
			} 
			internal System(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getInt6057; 
			public static int getInt(android.content.ContentResolver arg0, java.lang.String arg1, int arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticIntMethod(android.provider.Settings.System.staticClass, _getInt6057, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getInt6058; 
			public static int getInt(android.content.ContentResolver arg0, java.lang.String arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticIntMethod(android.provider.Settings.System.staticClass, _getInt6058, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _putInt6059; 
			public static bool putInt(android.content.ContentResolver arg0, java.lang.String arg1, int arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticBooleanMethod(android.provider.Settings.System.staticClass, _putInt6059, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getLong6060; 
			public static long getLong(android.content.ContentResolver arg0, java.lang.String arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticLongMethod(android.provider.Settings.System.staticClass, _getLong6060, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getLong6061; 
			public static long getLong(android.content.ContentResolver arg0, java.lang.String arg1, long arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticLongMethod(android.provider.Settings.System.staticClass, _getLong6061, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _putLong6062; 
			public static bool putLong(android.content.ContentResolver arg0, java.lang.String arg1, long arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticBooleanMethod(android.provider.Settings.System.staticClass, _putLong6062, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getFloat6063; 
			public static float getFloat(android.content.ContentResolver arg0, java.lang.String arg1, float arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticFloatMethod(android.provider.Settings.System.staticClass, _getFloat6063, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getFloat6064; 
			public static float getFloat(android.content.ContentResolver arg0, java.lang.String arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticFloatMethod(android.provider.Settings.System.staticClass, _getFloat6064, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _putFloat6065; 
			public static bool putFloat(android.content.ContentResolver arg0, java.lang.String arg1, float arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticBooleanMethod(android.provider.Settings.System.staticClass, _putFloat6065, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getString6066; 
			public static java.lang.String getString(android.content.ContentResolver arg0, java.lang.String arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.Settings.System.staticClass, _getString6066, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getConfiguration6067; 
			public static void getConfiguration(android.content.ContentResolver arg0, android.content.res.Configuration arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.CallStaticVoidMethod(android.provider.Settings.System.staticClass, _getConfiguration6067, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _putString6068; 
			public static bool putString(android.content.ContentResolver arg0, java.lang.String arg1, java.lang.String arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticBooleanMethod(android.provider.Settings.System.staticClass, _putString6068, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getUriFor6069; 
			public static android.net.Uri getUriFor(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.Settings.System.staticClass, _getUriFor6069, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _putConfiguration6070; 
			public static bool putConfiguration(android.content.ContentResolver arg0, android.content.res.Configuration arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticBooleanMethod(android.provider.Settings.System.staticClass, _putConfiguration6070, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getShowGTalkServiceStatus6071; 
			public static bool getShowGTalkServiceStatus(android.content.ContentResolver arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticBooleanMethod(android.provider.Settings.System.staticClass, _getShowGTalkServiceStatus6071, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setShowGTalkServiceStatus6072; 
			public static void setShowGTalkServiceStatus(android.content.ContentResolver arg0, bool arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.CallStaticVoidMethod(android.provider.Settings.System.staticClass, _setShowGTalkServiceStatus6072, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _System6073; 
			public System()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.provider.Settings.System.staticClass, _System6073, this); 
			} 
			public static java.lang.String SYS_PROP_SETTING_VERSION
			{ 
				get 
				{ 
					return "sys.settings_system_version"; 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONTENT_URI6074; 
			public static android.net.Uri CONTENT_URI
			{ 
				get 
				{ 
					return default(android.net.Uri); 
				} 
			} 
			public static java.lang.String STAY_ON_WHILE_PLUGGED_IN
			{ 
				get 
				{ 
					return "stay_on_while_plugged_in"; 
				} 
			} 
			public static java.lang.String END_BUTTON_BEHAVIOR
			{ 
				get 
				{ 
					return "end_button_behavior"; 
				} 
			} 
			public static java.lang.String AIRPLANE_MODE_ON
			{ 
				get 
				{ 
					return "airplane_mode_on"; 
				} 
			} 
			public static java.lang.String RADIO_BLUETOOTH
			{ 
				get 
				{ 
					return "bluetooth"; 
				} 
			} 
			public static java.lang.String RADIO_WIFI
			{ 
				get 
				{ 
					return "wifi"; 
				} 
			} 
			public static java.lang.String RADIO_CELL
			{ 
				get 
				{ 
					return "cell"; 
				} 
			} 
			public static java.lang.String AIRPLANE_MODE_RADIOS
			{ 
				get 
				{ 
					return "airplane_mode_radios"; 
				} 
			} 
			public static java.lang.String WIFI_SLEEP_POLICY
			{ 
				get 
				{ 
					return "wifi_sleep_policy"; 
				} 
			} 
			public static int WIFI_SLEEP_POLICY_DEFAULT
			{ 
				get 
				{ 
					return 0; 
				} 
			} 
			public static int WIFI_SLEEP_POLICY_NEVER_WHILE_PLUGGED
			{ 
				get 
				{ 
					return 1; 
				} 
			} 
			public static int WIFI_SLEEP_POLICY_NEVER
			{ 
				get 
				{ 
					return 2; 
				} 
			} 
			public static java.lang.String WIFI_USE_STATIC_IP
			{ 
				get 
				{ 
					return "wifi_use_static_ip"; 
				} 
			} 
			public static java.lang.String WIFI_STATIC_IP
			{ 
				get 
				{ 
					return "wifi_static_ip"; 
				} 
			} 
			public static java.lang.String WIFI_STATIC_GATEWAY
			{ 
				get 
				{ 
					return "wifi_static_gateway"; 
				} 
			} 
			public static java.lang.String WIFI_STATIC_NETMASK
			{ 
				get 
				{ 
					return "wifi_static_netmask"; 
				} 
			} 
			public static java.lang.String WIFI_STATIC_DNS1
			{ 
				get 
				{ 
					return "wifi_static_dns1"; 
				} 
			} 
			public static java.lang.String WIFI_STATIC_DNS2
			{ 
				get 
				{ 
					return "wifi_static_dns2"; 
				} 
			} 
			public static java.lang.String BLUETOOTH_DISCOVERABILITY
			{ 
				get 
				{ 
					return "bluetooth_discoverability"; 
				} 
			} 
			public static java.lang.String BLUETOOTH_DISCOVERABILITY_TIMEOUT
			{ 
				get 
				{ 
					return "bluetooth_discoverability_timeout"; 
				} 
			} 
			public static java.lang.String LOCK_PATTERN_ENABLED
			{ 
				get 
				{ 
					return "lock_pattern_autolock"; 
				} 
			} 
			public static java.lang.String LOCK_PATTERN_VISIBLE
			{ 
				get 
				{ 
					return "lock_pattern_visible_pattern"; 
				} 
			} 
			public static java.lang.String LOCK_PATTERN_TACTILE_FEEDBACK_ENABLED
			{ 
				get 
				{ 
					return "lock_pattern_tactile_feedback_enabled"; 
				} 
			} 
			public static java.lang.String NEXT_ALARM_FORMATTED
			{ 
				get 
				{ 
					return "next_alarm_formatted"; 
				} 
			} 
			public static java.lang.String FONT_SCALE
			{ 
				get 
				{ 
					return "font_scale"; 
				} 
			} 
			public static java.lang.String DEBUG_APP
			{ 
				get 
				{ 
					return "debug_app"; 
				} 
			} 
			public static java.lang.String WAIT_FOR_DEBUGGER
			{ 
				get 
				{ 
					return "wait_for_debugger"; 
				} 
			} 
			public static java.lang.String DIM_SCREEN
			{ 
				get 
				{ 
					return "dim_screen"; 
				} 
			} 
			public static java.lang.String SCREEN_OFF_TIMEOUT
			{ 
				get 
				{ 
					return "screen_off_timeout"; 
				} 
			} 
			public static java.lang.String SCREEN_BRIGHTNESS
			{ 
				get 
				{ 
					return "screen_brightness"; 
				} 
			} 
			public static java.lang.String SHOW_PROCESSES
			{ 
				get 
				{ 
					return "show_processes"; 
				} 
			} 
			public static java.lang.String ALWAYS_FINISH_ACTIVITIES
			{ 
				get 
				{ 
					return "always_finish_activities"; 
				} 
			} 
			public static java.lang.String MODE_RINGER
			{ 
				get 
				{ 
					return "mode_ringer"; 
				} 
			} 
			public static java.lang.String MODE_RINGER_STREAMS_AFFECTED
			{ 
				get 
				{ 
					return "mode_ringer_streams_affected"; 
				} 
			} 
			public static java.lang.String MUTE_STREAMS_AFFECTED
			{ 
				get 
				{ 
					return "mute_streams_affected"; 
				} 
			} 
			public static java.lang.String VIBRATE_ON
			{ 
				get 
				{ 
					return "vibrate_on"; 
				} 
			} 
			public static java.lang.String VOLUME_RING
			{ 
				get 
				{ 
					return "volume_ring"; 
				} 
			} 
			public static java.lang.String VOLUME_SYSTEM
			{ 
				get 
				{ 
					return "volume_system"; 
				} 
			} 
			public static java.lang.String VOLUME_VOICE
			{ 
				get 
				{ 
					return "volume_voice"; 
				} 
			} 
			public static java.lang.String VOLUME_MUSIC
			{ 
				get 
				{ 
					return "volume_music"; 
				} 
			} 
			public static java.lang.String VOLUME_ALARM
			{ 
				get 
				{ 
					return "volume_alarm"; 
				} 
			} 
			public static java.lang.String VOLUME_NOTIFICATION
			{ 
				get 
				{ 
					return "volume_notification"; 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _VOLUME_SETTINGS6075; 
			public static java.lang.String[] VOLUME_SETTINGS
			{ 
				get 
				{ 
					return default(java.lang.String[]); 
				} 
			} 
			public static java.lang.String APPEND_FOR_LAST_AUDIBLE
			{ 
				get 
				{ 
					return "_last_audible"; 
				} 
			} 
			public static java.lang.String RINGTONE
			{ 
				get 
				{ 
					return "ringtone"; 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _DEFAULT_RINGTONE_URI6076; 
			public static android.net.Uri DEFAULT_RINGTONE_URI
			{ 
				get 
				{ 
					return default(android.net.Uri); 
				} 
			} 
			public static java.lang.String NOTIFICATION_SOUND
			{ 
				get 
				{ 
					return "notification_sound"; 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _DEFAULT_NOTIFICATION_URI6077; 
			public static android.net.Uri DEFAULT_NOTIFICATION_URI
			{ 
				get 
				{ 
					return default(android.net.Uri); 
				} 
			} 
			public static java.lang.String ALARM_ALERT
			{ 
				get 
				{ 
					return "alarm_alert"; 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _DEFAULT_ALARM_ALERT_URI6078; 
			public static android.net.Uri DEFAULT_ALARM_ALERT_URI
			{ 
				get 
				{ 
					return default(android.net.Uri); 
				} 
			} 
			public static java.lang.String TEXT_AUTO_REPLACE
			{ 
				get 
				{ 
					return "auto_replace"; 
				} 
			} 
			public static java.lang.String TEXT_AUTO_CAPS
			{ 
				get 
				{ 
					return "auto_caps"; 
				} 
			} 
			public static java.lang.String TEXT_AUTO_PUNCTUATE
			{ 
				get 
				{ 
					return "auto_punctuate"; 
				} 
			} 
			public static java.lang.String TEXT_SHOW_PASSWORD
			{ 
				get 
				{ 
					return "show_password"; 
				} 
			} 
			public static java.lang.String SHOW_GTALK_SERVICE_STATUS
			{ 
				get 
				{ 
					return "SHOW_GTALK_SERVICE_STATUS"; 
				} 
			} 
			public static java.lang.String WALLPAPER_ACTIVITY
			{ 
				get 
				{ 
					return "wallpaper_activity"; 
				} 
			} 
			public static java.lang.String AUTO_TIME
			{ 
				get 
				{ 
					return "auto_time"; 
				} 
			} 
			public static java.lang.String TIME_12_24
			{ 
				get 
				{ 
					return "time_12_24"; 
				} 
			} 
			public static java.lang.String DATE_FORMAT
			{ 
				get 
				{ 
					return "date_format"; 
				} 
			} 
			public static java.lang.String SETUP_WIZARD_HAS_RUN
			{ 
				get 
				{ 
					return "setup_wizard_has_run"; 
				} 
			} 
			public static java.lang.String WINDOW_ANIMATION_SCALE
			{ 
				get 
				{ 
					return "window_animation_scale"; 
				} 
			} 
			public static java.lang.String TRANSITION_ANIMATION_SCALE
			{ 
				get 
				{ 
					return "transition_animation_scale"; 
				} 
			} 
			public static java.lang.String ACCELEROMETER_ROTATION
			{ 
				get 
				{ 
					return "accelerometer_rotation"; 
				} 
			} 
			public static java.lang.String DTMF_TONE_WHEN_DIALING
			{ 
				get 
				{ 
					return "dtmf_tone"; 
				} 
			} 
			public static java.lang.String SOUND_EFFECTS_ENABLED
			{ 
				get 
				{ 
					return "sound_effects_enabled"; 
				} 
			} 
			public static java.lang.String HAPTIC_FEEDBACK_ENABLED
			{ 
				get 
				{ 
					return "haptic_feedback_enabled"; 
				} 
			} 
			public static java.lang.String SHOW_WEB_SUGGESTIONS
			{ 
				get 
				{ 
					return "show_web_suggestions"; 
				} 
			} 
			public static java.lang.String ADB_ENABLED
			{ 
				get 
				{ 
					return "adb_enabled"; 
				} 
			} 
			public static java.lang.String ANDROID_ID
			{ 
				get 
				{ 
					return "android_id"; 
				} 
			} 
			public static java.lang.String BLUETOOTH_ON
			{ 
				get 
				{ 
					return "bluetooth_on"; 
				} 
			} 
			public static java.lang.String DATA_ROAMING
			{ 
				get 
				{ 
					return "data_roaming"; 
				} 
			} 
			public static java.lang.String DEVICE_PROVISIONED
			{ 
				get 
				{ 
					return "device_provisioned"; 
				} 
			} 
			public static java.lang.String HTTP_PROXY
			{ 
				get 
				{ 
					return "http_proxy"; 
				} 
			} 
			public static java.lang.String INSTALL_NON_MARKET_APPS
			{ 
				get 
				{ 
					return "install_non_market_apps"; 
				} 
			} 
			public static java.lang.String LOCATION_PROVIDERS_ALLOWED
			{ 
				get 
				{ 
					return "location_providers_allowed"; 
				} 
			} 
			public static java.lang.String LOGGING_ID
			{ 
				get 
				{ 
					return "logging_id"; 
				} 
			} 
			public static java.lang.String NETWORK_PREFERENCE
			{ 
				get 
				{ 
					return "network_preference"; 
				} 
			} 
			public static java.lang.String PARENTAL_CONTROL_ENABLED
			{ 
				get 
				{ 
					return "parental_control_enabled"; 
				} 
			} 
			public static java.lang.String PARENTAL_CONTROL_LAST_UPDATE
			{ 
				get 
				{ 
					return "parental_control_last_update"; 
				} 
			} 
			public static java.lang.String PARENTAL_CONTROL_REDIRECT_URL
			{ 
				get 
				{ 
					return "parental_control_redirect_url"; 
				} 
			} 
			public static java.lang.String SETTINGS_CLASSNAME
			{ 
				get 
				{ 
					return "settings_classname"; 
				} 
			} 
			public static java.lang.String USB_MASS_STORAGE_ENABLED
			{ 
				get 
				{ 
					return "usb_mass_storage_enabled"; 
				} 
			} 
			public static java.lang.String USE_GOOGLE_MAIL
			{ 
				get 
				{ 
					return "use_google_mail"; 
				} 
			} 
			public static java.lang.String WIFI_MAX_DHCP_RETRY_COUNT
			{ 
				get 
				{ 
					return "wifi_max_dhcp_retry_count"; 
				} 
			} 
			public static java.lang.String WIFI_MOBILE_DATA_TRANSITION_WAKELOCK_TIMEOUT_MS
			{ 
				get 
				{ 
					return "wifi_mobile_data_transition_wakelock_timeout_ms"; 
				} 
			} 
			public static java.lang.String WIFI_NETWORKS_AVAILABLE_NOTIFICATION_ON
			{ 
				get 
				{ 
					return "wifi_networks_available_notification_on"; 
				} 
			} 
			public static java.lang.String WIFI_NETWORKS_AVAILABLE_REPEAT_DELAY
			{ 
				get 
				{ 
					return "wifi_networks_available_repeat_delay"; 
				} 
			} 
			public static java.lang.String WIFI_NUM_OPEN_NETWORKS_KEPT
			{ 
				get 
				{ 
					return "wifi_num_open_networks_kept"; 
				} 
			} 
			public static java.lang.String WIFI_ON
			{ 
				get 
				{ 
					return "wifi_on"; 
				} 
			} 
			public static java.lang.String WIFI_WATCHDOG_ACCEPTABLE_PACKET_LOSS_PERCENTAGE
			{ 
				get 
				{ 
					return "wifi_watchdog_acceptable_packet_loss_percentage"; 
				} 
			} 
			public static java.lang.String WIFI_WATCHDOG_AP_COUNT
			{ 
				get 
				{ 
					return "wifi_watchdog_ap_count"; 
				} 
			} 
			public static java.lang.String WIFI_WATCHDOG_BACKGROUND_CHECK_DELAY_MS
			{ 
				get 
				{ 
					return "wifi_watchdog_background_check_delay_ms"; 
				} 
			} 
			public static java.lang.String WIFI_WATCHDOG_BACKGROUND_CHECK_ENABLED
			{ 
				get 
				{ 
					return "wifi_watchdog_background_check_enabled"; 
				} 
			} 
			public static java.lang.String WIFI_WATCHDOG_BACKGROUND_CHECK_TIMEOUT_MS
			{ 
				get 
				{ 
					return "wifi_watchdog_background_check_timeout_ms"; 
				} 
			} 
			public static java.lang.String WIFI_WATCHDOG_INITIAL_IGNORED_PING_COUNT
			{ 
				get 
				{ 
					return "wifi_watchdog_initial_ignored_ping_count"; 
				} 
			} 
			public static java.lang.String WIFI_WATCHDOG_MAX_AP_CHECKS
			{ 
				get 
				{ 
					return "wifi_watchdog_max_ap_checks"; 
				} 
			} 
			public static java.lang.String WIFI_WATCHDOG_ON
			{ 
				get 
				{ 
					return "wifi_watchdog_on"; 
				} 
			} 
			public static java.lang.String WIFI_WATCHDOG_PING_COUNT
			{ 
				get 
				{ 
					return "wifi_watchdog_ping_count"; 
				} 
			} 
			public static java.lang.String WIFI_WATCHDOG_PING_DELAY_MS
			{ 
				get 
				{ 
					return "wifi_watchdog_ping_delay_ms"; 
				} 
			} 
			public static java.lang.String WIFI_WATCHDOG_PING_TIMEOUT_MS
			{ 
				get 
				{ 
					return "wifi_watchdog_ping_timeout_ms"; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.Settings.System.staticClass = @__class; 
				global::android.provider.Settings.System._getInt6057 = @__env.GetStaticMethodID(global::android.provider.Settings.System.staticClass, "getInt", "(Landroid/content/ContentResolver;Ljava/lang/String;I)I"); 
				global::android.provider.Settings.System._getInt6058 = @__env.GetStaticMethodID(global::android.provider.Settings.System.staticClass, "getInt", "(Landroid/content/ContentResolver;Ljava/lang/String;)I"); 
				global::android.provider.Settings.System._putInt6059 = @__env.GetStaticMethodID(global::android.provider.Settings.System.staticClass, "putInt", "(Landroid/content/ContentResolver;Ljava/lang/String;I)Z"); 
				global::android.provider.Settings.System._getLong6060 = @__env.GetStaticMethodID(global::android.provider.Settings.System.staticClass, "getLong", "(Landroid/content/ContentResolver;Ljava/lang/String;)J"); 
				global::android.provider.Settings.System._getLong6061 = @__env.GetStaticMethodID(global::android.provider.Settings.System.staticClass, "getLong", "(Landroid/content/ContentResolver;Ljava/lang/String;J)J"); 
				global::android.provider.Settings.System._putLong6062 = @__env.GetStaticMethodID(global::android.provider.Settings.System.staticClass, "putLong", "(Landroid/content/ContentResolver;Ljava/lang/String;J)Z"); 
				global::android.provider.Settings.System._getFloat6063 = @__env.GetStaticMethodID(global::android.provider.Settings.System.staticClass, "getFloat", "(Landroid/content/ContentResolver;Ljava/lang/String;F)F"); 
				global::android.provider.Settings.System._getFloat6064 = @__env.GetStaticMethodID(global::android.provider.Settings.System.staticClass, "getFloat", "(Landroid/content/ContentResolver;Ljava/lang/String;)F"); 
				global::android.provider.Settings.System._putFloat6065 = @__env.GetStaticMethodID(global::android.provider.Settings.System.staticClass, "putFloat", "(Landroid/content/ContentResolver;Ljava/lang/String;F)Z"); 
				global::android.provider.Settings.System._getString6066 = @__env.GetStaticMethodID(global::android.provider.Settings.System.staticClass, "getString", "(Landroid/content/ContentResolver;Ljava/lang/String;)Ljava/lang/String;"); 
				global::android.provider.Settings.System._getConfiguration6067 = @__env.GetStaticMethodID(global::android.provider.Settings.System.staticClass, "getConfiguration", "(Landroid/content/ContentResolver;Landroid/content/res/Configuration;)V"); 
				global::android.provider.Settings.System._putString6068 = @__env.GetStaticMethodID(global::android.provider.Settings.System.staticClass, "putString", "(Landroid/content/ContentResolver;Ljava/lang/String;Ljava/lang/String;)Z"); 
				global::android.provider.Settings.System._getUriFor6069 = @__env.GetStaticMethodID(global::android.provider.Settings.System.staticClass, "getUriFor", "(Ljava/lang/String;)Landroid/net/Uri;"); 
				global::android.provider.Settings.System._putConfiguration6070 = @__env.GetStaticMethodID(global::android.provider.Settings.System.staticClass, "putConfiguration", "(Landroid/content/ContentResolver;Landroid/content/res/Configuration;)Z"); 
				global::android.provider.Settings.System._getShowGTalkServiceStatus6071 = @__env.GetStaticMethodID(global::android.provider.Settings.System.staticClass, "getShowGTalkServiceStatus", "(Landroid/content/ContentResolver;)Z"); 
				global::android.provider.Settings.System._setShowGTalkServiceStatus6072 = @__env.GetStaticMethodID(global::android.provider.Settings.System.staticClass, "setShowGTalkServiceStatus", "(Landroid/content/ContentResolver;Z)V"); 
				global::android.provider.Settings.System._System6073 = @__env.GetMethodID(global::android.provider.Settings.System.staticClass, "<init>", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Settings6079; 
		public Settings()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.provider.Settings.staticClass, _Settings6079, this); 
		} 
		public static java.lang.String ACTION_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.SETTINGS"; 
			} 
		} 
		public static java.lang.String ACTION_APN_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.APN_SETTINGS"; 
			} 
		} 
		public static java.lang.String ACTION_LOCATION_SOURCE_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.LOCATION_SOURCE_SETTINGS"; 
			} 
		} 
		public static java.lang.String ACTION_WIRELESS_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.WIRELESS_SETTINGS"; 
			} 
		} 
		public static java.lang.String ACTION_AIRPLANE_MODE_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.AIRPLANE_MODE_SETTINGS"; 
			} 
		} 
		public static java.lang.String ACTION_ACCESSIBILITY_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.ACCESSIBILITY_SETTINGS"; 
			} 
		} 
		public static java.lang.String ACTION_SECURITY_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.SECURITY_SETTINGS"; 
			} 
		} 
		public static java.lang.String ACTION_PRIVACY_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.PRIVACY_SETTINGS"; 
			} 
		} 
		public static java.lang.String ACTION_WIFI_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.WIFI_SETTINGS"; 
			} 
		} 
		public static java.lang.String ACTION_WIFI_IP_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.WIFI_IP_SETTINGS"; 
			} 
		} 
		public static java.lang.String ACTION_BLUETOOTH_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.BLUETOOTH_SETTINGS"; 
			} 
		} 
		public static java.lang.String ACTION_DATE_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.DATE_SETTINGS"; 
			} 
		} 
		public static java.lang.String ACTION_SOUND_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.SOUND_SETTINGS"; 
			} 
		} 
		public static java.lang.String ACTION_DISPLAY_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.DISPLAY_SETTINGS"; 
			} 
		} 
		public static java.lang.String ACTION_LOCALE_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.LOCALE_SETTINGS"; 
			} 
		} 
		public static java.lang.String ACTION_INPUT_METHOD_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.INPUT_METHOD_SETTINGS"; 
			} 
		} 
		public static java.lang.String ACTION_USER_DICTIONARY_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.USER_DICTIONARY_SETTINGS"; 
			} 
		} 
		public static java.lang.String ACTION_APPLICATION_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.APPLICATION_SETTINGS"; 
			} 
		} 
		public static java.lang.String ACTION_APPLICATION_DEVELOPMENT_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.APPLICATION_DEVELOPMENT_SETTINGS"; 
			} 
		} 
		public static java.lang.String ACTION_QUICK_LAUNCH_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.QUICK_LAUNCH_SETTINGS"; 
			} 
		} 
		public static java.lang.String ACTION_MANAGE_APPLICATIONS_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.MANAGE_APPLICATIONS_SETTINGS"; 
			} 
		} 
		public static java.lang.String ACTION_SYNC_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.SYNC_SETTINGS"; 
			} 
		} 
		public static java.lang.String ACTION_NETWORK_OPERATOR_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.NETWORK_OPERATOR_SETTINGS"; 
			} 
		} 
		public static java.lang.String ACTION_DATA_ROAMING_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.DATA_ROAMING_SETTINGS"; 
			} 
		} 
		public static java.lang.String ACTION_INTERNAL_STORAGE_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.INTERNAL_STORAGE_SETTINGS"; 
			} 
		} 
		public static java.lang.String ACTION_MEMORY_CARD_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.MEMORY_CARD_SETTINGS"; 
			} 
		} 
		public static java.lang.String AUTHORITY
		{ 
			get 
			{ 
				return "settings"; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.provider.Settings.staticClass = @__class; 
			global::android.provider.Settings._Settings6079 = @__env.GetMethodID(global::android.provider.Settings.staticClass, "<init>", "()V"); 
		} 
	} 
} 
