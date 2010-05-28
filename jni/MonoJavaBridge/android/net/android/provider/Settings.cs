namespace android.provider 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class Settings : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Settings() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.provider.Settings), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.provider.Settings.NameValueTable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _putString6318; 
			protected static bool putString(android.content.ContentResolver arg0, android.net.Uri arg1, java.lang.String arg2, java.lang.String arg3) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticBooleanMethod(android.provider.Settings.NameValueTable.staticClass, global::android.provider.Settings.NameValueTable._putString6318, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getUriFor6319; 
			public static global::android.net.Uri getUriFor(android.net.Uri arg0, java.lang.String arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.Settings.NameValueTable.staticClass, global::android.provider.Settings.NameValueTable._getUriFor6319, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _NameValueTable6320; 
			public NameValueTable()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.provider.Settings.NameValueTable.staticClass, global::android.provider.Settings.NameValueTable._NameValueTable6320, this); 
			} 
			public static global::java.lang.String NAME
			{ 
				get 
				{ 
					return "name"; 
				} 
			} 
			public static global::java.lang.String VALUE
			{ 
				get 
				{ 
					return "value"; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.Settings.NameValueTable.staticClass = @__class; 
				global::android.provider.Settings.NameValueTable._putString6318 = @__env.GetStaticMethodID(global::android.provider.Settings.NameValueTable.staticClass, "putString", "(Landroid/content/ContentResolver;Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;)Z"); 
				global::android.provider.Settings.NameValueTable._getUriFor6319 = @__env.GetStaticMethodID(global::android.provider.Settings.NameValueTable.staticClass, "getUriFor", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/net/Uri;"); 
				global::android.provider.Settings.NameValueTable._NameValueTable6320 = @__env.GetMethodID(global::android.provider.Settings.NameValueTable.staticClass, "<init>", "()V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Secure : android.provider.Settings.NameValueTable
		{ 
			internal new static global::java.lang.Class staticClass; 
			static Secure() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.provider.Settings.Secure), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _getInt6321; 
			public static int getInt(android.content.ContentResolver arg0, java.lang.String arg1, int arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticIntMethod(android.provider.Settings.Secure.staticClass, global::android.provider.Settings.Secure._getInt6321, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getInt6322; 
			public static int getInt(android.content.ContentResolver arg0, java.lang.String arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticIntMethod(android.provider.Settings.Secure.staticClass, global::android.provider.Settings.Secure._getInt6322, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _putInt6323; 
			public static bool putInt(android.content.ContentResolver arg0, java.lang.String arg1, int arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticBooleanMethod(android.provider.Settings.Secure.staticClass, global::android.provider.Settings.Secure._putInt6323, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getLong6324; 
			public static long getLong(android.content.ContentResolver arg0, java.lang.String arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticLongMethod(android.provider.Settings.Secure.staticClass, global::android.provider.Settings.Secure._getLong6324, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getLong6325; 
			public static long getLong(android.content.ContentResolver arg0, java.lang.String arg1, long arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticLongMethod(android.provider.Settings.Secure.staticClass, global::android.provider.Settings.Secure._getLong6325, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _putLong6326; 
			public static bool putLong(android.content.ContentResolver arg0, java.lang.String arg1, long arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticBooleanMethod(android.provider.Settings.Secure.staticClass, global::android.provider.Settings.Secure._putLong6326, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getFloat6327; 
			public static float getFloat(android.content.ContentResolver arg0, java.lang.String arg1, float arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticFloatMethod(android.provider.Settings.Secure.staticClass, global::android.provider.Settings.Secure._getFloat6327, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getFloat6328; 
			public static float getFloat(android.content.ContentResolver arg0, java.lang.String arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticFloatMethod(android.provider.Settings.Secure.staticClass, global::android.provider.Settings.Secure._getFloat6328, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _putFloat6329; 
			public static bool putFloat(android.content.ContentResolver arg0, java.lang.String arg1, float arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticBooleanMethod(android.provider.Settings.Secure.staticClass, global::android.provider.Settings.Secure._putFloat6329, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getString6330; 
			public static global::java.lang.String getString(android.content.ContentResolver arg0, java.lang.String arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.Settings.Secure.staticClass, global::android.provider.Settings.Secure._getString6330, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _putString6331; 
			public static bool putString(android.content.ContentResolver arg0, java.lang.String arg1, java.lang.String arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticBooleanMethod(android.provider.Settings.Secure.staticClass, global::android.provider.Settings.Secure._putString6331, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getUriFor6332; 
			public static global::android.net.Uri getUriFor(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.Settings.Secure.staticClass, global::android.provider.Settings.Secure._getUriFor6332, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _Secure6333; 
			public Secure()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.provider.Settings.Secure.staticClass, global::android.provider.Settings.Secure._Secure6333, this); 
			} 
			public static global::java.lang.String SYS_PROP_SETTING_VERSION
			{ 
				get 
				{ 
					return "sys.settings_secure_version"; 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONTENT_URI6334; 
			public static global::android.net.Uri CONTENT_URI
			{ 
				get 
				{ 
					return default(global::android.net.Uri); 
				} 
			} 
			public static global::java.lang.String ADB_ENABLED
			{ 
				get 
				{ 
					return "adb_enabled"; 
				} 
			} 
			public static global::java.lang.String ALLOW_MOCK_LOCATION
			{ 
				get 
				{ 
					return "mock_location"; 
				} 
			} 
			public static global::java.lang.String ANDROID_ID
			{ 
				get 
				{ 
					return "android_id"; 
				} 
			} 
			public static global::java.lang.String BLUETOOTH_ON
			{ 
				get 
				{ 
					return "bluetooth_on"; 
				} 
			} 
			public static global::java.lang.String DATA_ROAMING
			{ 
				get 
				{ 
					return "data_roaming"; 
				} 
			} 
			public static global::java.lang.String DEFAULT_INPUT_METHOD
			{ 
				get 
				{ 
					return "default_input_method"; 
				} 
			} 
			public static global::java.lang.String DEVICE_PROVISIONED
			{ 
				get 
				{ 
					return "device_provisioned"; 
				} 
			} 
			public static global::java.lang.String ENABLED_INPUT_METHODS
			{ 
				get 
				{ 
					return "enabled_input_methods"; 
				} 
			} 
			public static global::java.lang.String HTTP_PROXY
			{ 
				get 
				{ 
					return "http_proxy"; 
				} 
			} 
			public static global::java.lang.String INSTALL_NON_MARKET_APPS
			{ 
				get 
				{ 
					return "install_non_market_apps"; 
				} 
			} 
			public static global::java.lang.String LOCATION_PROVIDERS_ALLOWED
			{ 
				get 
				{ 
					return "location_providers_allowed"; 
				} 
			} 
			public static global::java.lang.String LOGGING_ID
			{ 
				get 
				{ 
					return "logging_id"; 
				} 
			} 
			public static global::java.lang.String NETWORK_PREFERENCE
			{ 
				get 
				{ 
					return "network_preference"; 
				} 
			} 
			public static global::java.lang.String PARENTAL_CONTROL_ENABLED
			{ 
				get 
				{ 
					return "parental_control_enabled"; 
				} 
			} 
			public static global::java.lang.String PARENTAL_CONTROL_LAST_UPDATE
			{ 
				get 
				{ 
					return "parental_control_last_update"; 
				} 
			} 
			public static global::java.lang.String PARENTAL_CONTROL_REDIRECT_URL
			{ 
				get 
				{ 
					return "parental_control_redirect_url"; 
				} 
			} 
			public static global::java.lang.String SETTINGS_CLASSNAME
			{ 
				get 
				{ 
					return "settings_classname"; 
				} 
			} 
			public static global::java.lang.String USB_MASS_STORAGE_ENABLED
			{ 
				get 
				{ 
					return "usb_mass_storage_enabled"; 
				} 
			} 
			public static global::java.lang.String USE_GOOGLE_MAIL
			{ 
				get 
				{ 
					return "use_google_mail"; 
				} 
			} 
			public static global::java.lang.String ACCESSIBILITY_ENABLED
			{ 
				get 
				{ 
					return "accessibility_enabled"; 
				} 
			} 
			public static global::java.lang.String ENABLED_ACCESSIBILITY_SERVICES
			{ 
				get 
				{ 
					return "enabled_accessibility_services"; 
				} 
			} 
			public static global::java.lang.String TTS_USE_DEFAULTS
			{ 
				get 
				{ 
					return "tts_use_defaults"; 
				} 
			} 
			public static global::java.lang.String TTS_DEFAULT_RATE
			{ 
				get 
				{ 
					return "tts_default_rate"; 
				} 
			} 
			public static global::java.lang.String TTS_DEFAULT_PITCH
			{ 
				get 
				{ 
					return "tts_default_pitch"; 
				} 
			} 
			public static global::java.lang.String TTS_DEFAULT_SYNTH
			{ 
				get 
				{ 
					return "tts_default_synth"; 
				} 
			} 
			public static global::java.lang.String TTS_DEFAULT_LANG
			{ 
				get 
				{ 
					return "tts_default_lang"; 
				} 
			} 
			public static global::java.lang.String TTS_DEFAULT_COUNTRY
			{ 
				get 
				{ 
					return "tts_default_country"; 
				} 
			} 
			public static global::java.lang.String TTS_DEFAULT_VARIANT
			{ 
				get 
				{ 
					return "tts_default_variant"; 
				} 
			} 
			public static global::java.lang.String WIFI_NETWORKS_AVAILABLE_NOTIFICATION_ON
			{ 
				get 
				{ 
					return "wifi_networks_available_notification_on"; 
				} 
			} 
			public static global::java.lang.String WIFI_NETWORKS_AVAILABLE_REPEAT_DELAY
			{ 
				get 
				{ 
					return "wifi_networks_available_repeat_delay"; 
				} 
			} 
			public static global::java.lang.String WIFI_NUM_OPEN_NETWORKS_KEPT
			{ 
				get 
				{ 
					return "wifi_num_open_networks_kept"; 
				} 
			} 
			public static global::java.lang.String WIFI_ON
			{ 
				get 
				{ 
					return "wifi_on"; 
				} 
			} 
			public static global::java.lang.String WIFI_WATCHDOG_ACCEPTABLE_PACKET_LOSS_PERCENTAGE
			{ 
				get 
				{ 
					return "wifi_watchdog_acceptable_packet_loss_percentage"; 
				} 
			} 
			public static global::java.lang.String WIFI_WATCHDOG_AP_COUNT
			{ 
				get 
				{ 
					return "wifi_watchdog_ap_count"; 
				} 
			} 
			public static global::java.lang.String WIFI_WATCHDOG_BACKGROUND_CHECK_DELAY_MS
			{ 
				get 
				{ 
					return "wifi_watchdog_background_check_delay_ms"; 
				} 
			} 
			public static global::java.lang.String WIFI_WATCHDOG_BACKGROUND_CHECK_ENABLED
			{ 
				get 
				{ 
					return "wifi_watchdog_background_check_enabled"; 
				} 
			} 
			public static global::java.lang.String WIFI_WATCHDOG_BACKGROUND_CHECK_TIMEOUT_MS
			{ 
				get 
				{ 
					return "wifi_watchdog_background_check_timeout_ms"; 
				} 
			} 
			public static global::java.lang.String WIFI_WATCHDOG_INITIAL_IGNORED_PING_COUNT
			{ 
				get 
				{ 
					return "wifi_watchdog_initial_ignored_ping_count"; 
				} 
			} 
			public static global::java.lang.String WIFI_WATCHDOG_MAX_AP_CHECKS
			{ 
				get 
				{ 
					return "wifi_watchdog_max_ap_checks"; 
				} 
			} 
			public static global::java.lang.String WIFI_WATCHDOG_ON
			{ 
				get 
				{ 
					return "wifi_watchdog_on"; 
				} 
			} 
			public static global::java.lang.String WIFI_WATCHDOG_WATCH_LIST
			{ 
				get 
				{ 
					return "wifi_watchdog_watch_list"; 
				} 
			} 
			public static global::java.lang.String WIFI_WATCHDOG_PING_COUNT
			{ 
				get 
				{ 
					return "wifi_watchdog_ping_count"; 
				} 
			} 
			public static global::java.lang.String WIFI_WATCHDOG_PING_DELAY_MS
			{ 
				get 
				{ 
					return "wifi_watchdog_ping_delay_ms"; 
				} 
			} 
			public static global::java.lang.String WIFI_WATCHDOG_PING_TIMEOUT_MS
			{ 
				get 
				{ 
					return "wifi_watchdog_ping_timeout_ms"; 
				} 
			} 
			public static global::java.lang.String WIFI_MAX_DHCP_RETRY_COUNT
			{ 
				get 
				{ 
					return "wifi_max_dhcp_retry_count"; 
				} 
			} 
			public static global::java.lang.String WIFI_MOBILE_DATA_TRANSITION_WAKELOCK_TIMEOUT_MS
			{ 
				get 
				{ 
					return "wifi_mobile_data_transition_wakelock_timeout_ms"; 
				} 
			} 
			public static global::java.lang.String BACKGROUND_DATA
			{ 
				get 
				{ 
					return "background_data"; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.Settings.Secure.staticClass = @__class; 
				global::android.provider.Settings.Secure._getInt6321 = @__env.GetStaticMethodID(global::android.provider.Settings.Secure.staticClass, "getInt", "(Landroid/content/ContentResolver;Ljava/lang/String;I)I"); 
				global::android.provider.Settings.Secure._getInt6322 = @__env.GetStaticMethodID(global::android.provider.Settings.Secure.staticClass, "getInt", "(Landroid/content/ContentResolver;Ljava/lang/String;)I"); 
				global::android.provider.Settings.Secure._putInt6323 = @__env.GetStaticMethodID(global::android.provider.Settings.Secure.staticClass, "putInt", "(Landroid/content/ContentResolver;Ljava/lang/String;I)Z"); 
				global::android.provider.Settings.Secure._getLong6324 = @__env.GetStaticMethodID(global::android.provider.Settings.Secure.staticClass, "getLong", "(Landroid/content/ContentResolver;Ljava/lang/String;)J"); 
				global::android.provider.Settings.Secure._getLong6325 = @__env.GetStaticMethodID(global::android.provider.Settings.Secure.staticClass, "getLong", "(Landroid/content/ContentResolver;Ljava/lang/String;J)J"); 
				global::android.provider.Settings.Secure._putLong6326 = @__env.GetStaticMethodID(global::android.provider.Settings.Secure.staticClass, "putLong", "(Landroid/content/ContentResolver;Ljava/lang/String;J)Z"); 
				global::android.provider.Settings.Secure._getFloat6327 = @__env.GetStaticMethodID(global::android.provider.Settings.Secure.staticClass, "getFloat", "(Landroid/content/ContentResolver;Ljava/lang/String;F)F"); 
				global::android.provider.Settings.Secure._getFloat6328 = @__env.GetStaticMethodID(global::android.provider.Settings.Secure.staticClass, "getFloat", "(Landroid/content/ContentResolver;Ljava/lang/String;)F"); 
				global::android.provider.Settings.Secure._putFloat6329 = @__env.GetStaticMethodID(global::android.provider.Settings.Secure.staticClass, "putFloat", "(Landroid/content/ContentResolver;Ljava/lang/String;F)Z"); 
				global::android.provider.Settings.Secure._getString6330 = @__env.GetStaticMethodID(global::android.provider.Settings.Secure.staticClass, "getString", "(Landroid/content/ContentResolver;Ljava/lang/String;)Ljava/lang/String;"); 
				global::android.provider.Settings.Secure._putString6331 = @__env.GetStaticMethodID(global::android.provider.Settings.Secure.staticClass, "putString", "(Landroid/content/ContentResolver;Ljava/lang/String;Ljava/lang/String;)Z"); 
				global::android.provider.Settings.Secure._getUriFor6332 = @__env.GetStaticMethodID(global::android.provider.Settings.Secure.staticClass, "getUriFor", "(Ljava/lang/String;)Landroid/net/Uri;"); 
				global::android.provider.Settings.Secure._Secure6333 = @__env.GetMethodID(global::android.provider.Settings.Secure.staticClass, "<init>", "()V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class SettingNotFoundException : android.util.AndroidException
		{ 
			internal new static global::java.lang.Class staticClass; 
			static SettingNotFoundException() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.provider.Settings.SettingNotFoundException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _SettingNotFoundException6335; 
			public SettingNotFoundException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.provider.Settings.SettingNotFoundException.staticClass, global::android.provider.Settings.SettingNotFoundException._SettingNotFoundException6335, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.Settings.SettingNotFoundException.staticClass = @__class; 
				global::android.provider.Settings.SettingNotFoundException._SettingNotFoundException6335 = @__env.GetMethodID(global::android.provider.Settings.SettingNotFoundException.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class System : android.provider.Settings.NameValueTable
		{ 
			internal new static global::java.lang.Class staticClass; 
			static System() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.provider.Settings.System), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _getInt6336; 
			public static int getInt(android.content.ContentResolver arg0, java.lang.String arg1, int arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticIntMethod(android.provider.Settings.System.staticClass, global::android.provider.Settings.System._getInt6336, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getInt6337; 
			public static int getInt(android.content.ContentResolver arg0, java.lang.String arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticIntMethod(android.provider.Settings.System.staticClass, global::android.provider.Settings.System._getInt6337, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _putInt6338; 
			public static bool putInt(android.content.ContentResolver arg0, java.lang.String arg1, int arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticBooleanMethod(android.provider.Settings.System.staticClass, global::android.provider.Settings.System._putInt6338, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getLong6339; 
			public static long getLong(android.content.ContentResolver arg0, java.lang.String arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticLongMethod(android.provider.Settings.System.staticClass, global::android.provider.Settings.System._getLong6339, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getLong6340; 
			public static long getLong(android.content.ContentResolver arg0, java.lang.String arg1, long arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticLongMethod(android.provider.Settings.System.staticClass, global::android.provider.Settings.System._getLong6340, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _putLong6341; 
			public static bool putLong(android.content.ContentResolver arg0, java.lang.String arg1, long arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticBooleanMethod(android.provider.Settings.System.staticClass, global::android.provider.Settings.System._putLong6341, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getFloat6342; 
			public static float getFloat(android.content.ContentResolver arg0, java.lang.String arg1, float arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticFloatMethod(android.provider.Settings.System.staticClass, global::android.provider.Settings.System._getFloat6342, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getFloat6343; 
			public static float getFloat(android.content.ContentResolver arg0, java.lang.String arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticFloatMethod(android.provider.Settings.System.staticClass, global::android.provider.Settings.System._getFloat6343, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _putFloat6344; 
			public static bool putFloat(android.content.ContentResolver arg0, java.lang.String arg1, float arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticBooleanMethod(android.provider.Settings.System.staticClass, global::android.provider.Settings.System._putFloat6344, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getString6345; 
			public static global::java.lang.String getString(android.content.ContentResolver arg0, java.lang.String arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.Settings.System.staticClass, global::android.provider.Settings.System._getString6345, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getConfiguration6346; 
			public static void getConfiguration(android.content.ContentResolver arg0, android.content.res.Configuration arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.CallStaticVoidMethod(android.provider.Settings.System.staticClass, global::android.provider.Settings.System._getConfiguration6346, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _putString6347; 
			public static bool putString(android.content.ContentResolver arg0, java.lang.String arg1, java.lang.String arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticBooleanMethod(android.provider.Settings.System.staticClass, global::android.provider.Settings.System._putString6347, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getUriFor6348; 
			public static global::android.net.Uri getUriFor(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.Settings.System.staticClass, global::android.provider.Settings.System._getUriFor6348, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _putConfiguration6349; 
			public static bool putConfiguration(android.content.ContentResolver arg0, android.content.res.Configuration arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticBooleanMethod(android.provider.Settings.System.staticClass, global::android.provider.Settings.System._putConfiguration6349, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getShowGTalkServiceStatus6350; 
			public static bool getShowGTalkServiceStatus(android.content.ContentResolver arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return @__env.CallStaticBooleanMethod(android.provider.Settings.System.staticClass, global::android.provider.Settings.System._getShowGTalkServiceStatus6350, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setShowGTalkServiceStatus6351; 
			public static void setShowGTalkServiceStatus(android.content.ContentResolver arg0, bool arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.CallStaticVoidMethod(android.provider.Settings.System.staticClass, global::android.provider.Settings.System._setShowGTalkServiceStatus6351, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _System6352; 
			public System()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.provider.Settings.System.staticClass, global::android.provider.Settings.System._System6352, this); 
			} 
			public static global::java.lang.String SYS_PROP_SETTING_VERSION
			{ 
				get 
				{ 
					return "sys.settings_system_version"; 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONTENT_URI6353; 
			public static global::android.net.Uri CONTENT_URI
			{ 
				get 
				{ 
					return default(global::android.net.Uri); 
				} 
			} 
			public static global::java.lang.String STAY_ON_WHILE_PLUGGED_IN
			{ 
				get 
				{ 
					return "stay_on_while_plugged_in"; 
				} 
			} 
			public static global::java.lang.String END_BUTTON_BEHAVIOR
			{ 
				get 
				{ 
					return "end_button_behavior"; 
				} 
			} 
			public static global::java.lang.String AIRPLANE_MODE_ON
			{ 
				get 
				{ 
					return "airplane_mode_on"; 
				} 
			} 
			public static global::java.lang.String RADIO_BLUETOOTH
			{ 
				get 
				{ 
					return "bluetooth"; 
				} 
			} 
			public static global::java.lang.String RADIO_WIFI
			{ 
				get 
				{ 
					return "wifi"; 
				} 
			} 
			public static global::java.lang.String RADIO_CELL
			{ 
				get 
				{ 
					return "cell"; 
				} 
			} 
			public static global::java.lang.String AIRPLANE_MODE_RADIOS
			{ 
				get 
				{ 
					return "airplane_mode_radios"; 
				} 
			} 
			public static global::java.lang.String WIFI_SLEEP_POLICY
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
			public static global::java.lang.String WIFI_USE_STATIC_IP
			{ 
				get 
				{ 
					return "wifi_use_static_ip"; 
				} 
			} 
			public static global::java.lang.String WIFI_STATIC_IP
			{ 
				get 
				{ 
					return "wifi_static_ip"; 
				} 
			} 
			public static global::java.lang.String WIFI_STATIC_GATEWAY
			{ 
				get 
				{ 
					return "wifi_static_gateway"; 
				} 
			} 
			public static global::java.lang.String WIFI_STATIC_NETMASK
			{ 
				get 
				{ 
					return "wifi_static_netmask"; 
				} 
			} 
			public static global::java.lang.String WIFI_STATIC_DNS1
			{ 
				get 
				{ 
					return "wifi_static_dns1"; 
				} 
			} 
			public static global::java.lang.String WIFI_STATIC_DNS2
			{ 
				get 
				{ 
					return "wifi_static_dns2"; 
				} 
			} 
			public static global::java.lang.String BLUETOOTH_DISCOVERABILITY
			{ 
				get 
				{ 
					return "bluetooth_discoverability"; 
				} 
			} 
			public static global::java.lang.String BLUETOOTH_DISCOVERABILITY_TIMEOUT
			{ 
				get 
				{ 
					return "bluetooth_discoverability_timeout"; 
				} 
			} 
			public static global::java.lang.String LOCK_PATTERN_ENABLED
			{ 
				get 
				{ 
					return "lock_pattern_autolock"; 
				} 
			} 
			public static global::java.lang.String LOCK_PATTERN_VISIBLE
			{ 
				get 
				{ 
					return "lock_pattern_visible_pattern"; 
				} 
			} 
			public static global::java.lang.String LOCK_PATTERN_TACTILE_FEEDBACK_ENABLED
			{ 
				get 
				{ 
					return "lock_pattern_tactile_feedback_enabled"; 
				} 
			} 
			public static global::java.lang.String NEXT_ALARM_FORMATTED
			{ 
				get 
				{ 
					return "next_alarm_formatted"; 
				} 
			} 
			public static global::java.lang.String FONT_SCALE
			{ 
				get 
				{ 
					return "font_scale"; 
				} 
			} 
			public static global::java.lang.String DEBUG_APP
			{ 
				get 
				{ 
					return "debug_app"; 
				} 
			} 
			public static global::java.lang.String WAIT_FOR_DEBUGGER
			{ 
				get 
				{ 
					return "wait_for_debugger"; 
				} 
			} 
			public static global::java.lang.String DIM_SCREEN
			{ 
				get 
				{ 
					return "dim_screen"; 
				} 
			} 
			public static global::java.lang.String SCREEN_OFF_TIMEOUT
			{ 
				get 
				{ 
					return "screen_off_timeout"; 
				} 
			} 
			public static global::java.lang.String SCREEN_BRIGHTNESS
			{ 
				get 
				{ 
					return "screen_brightness"; 
				} 
			} 
			public static global::java.lang.String SHOW_PROCESSES
			{ 
				get 
				{ 
					return "show_processes"; 
				} 
			} 
			public static global::java.lang.String ALWAYS_FINISH_ACTIVITIES
			{ 
				get 
				{ 
					return "always_finish_activities"; 
				} 
			} 
			public static global::java.lang.String MODE_RINGER
			{ 
				get 
				{ 
					return "mode_ringer"; 
				} 
			} 
			public static global::java.lang.String MODE_RINGER_STREAMS_AFFECTED
			{ 
				get 
				{ 
					return "mode_ringer_streams_affected"; 
				} 
			} 
			public static global::java.lang.String MUTE_STREAMS_AFFECTED
			{ 
				get 
				{ 
					return "mute_streams_affected"; 
				} 
			} 
			public static global::java.lang.String VIBRATE_ON
			{ 
				get 
				{ 
					return "vibrate_on"; 
				} 
			} 
			public static global::java.lang.String VOLUME_RING
			{ 
				get 
				{ 
					return "volume_ring"; 
				} 
			} 
			public static global::java.lang.String VOLUME_SYSTEM
			{ 
				get 
				{ 
					return "volume_system"; 
				} 
			} 
			public static global::java.lang.String VOLUME_VOICE
			{ 
				get 
				{ 
					return "volume_voice"; 
				} 
			} 
			public static global::java.lang.String VOLUME_MUSIC
			{ 
				get 
				{ 
					return "volume_music"; 
				} 
			} 
			public static global::java.lang.String VOLUME_ALARM
			{ 
				get 
				{ 
					return "volume_alarm"; 
				} 
			} 
			public static global::java.lang.String VOLUME_NOTIFICATION
			{ 
				get 
				{ 
					return "volume_notification"; 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _VOLUME_SETTINGS6354; 
			public static global::java.lang.String[] VOLUME_SETTINGS
			{ 
				get 
				{ 
					return default(global::java.lang.String[]); 
				} 
			} 
			public static global::java.lang.String APPEND_FOR_LAST_AUDIBLE
			{ 
				get 
				{ 
					return "_last_audible"; 
				} 
			} 
			public static global::java.lang.String RINGTONE
			{ 
				get 
				{ 
					return "ringtone"; 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _DEFAULT_RINGTONE_URI6355; 
			public static global::android.net.Uri DEFAULT_RINGTONE_URI
			{ 
				get 
				{ 
					return default(global::android.net.Uri); 
				} 
			} 
			public static global::java.lang.String NOTIFICATION_SOUND
			{ 
				get 
				{ 
					return "notification_sound"; 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _DEFAULT_NOTIFICATION_URI6356; 
			public static global::android.net.Uri DEFAULT_NOTIFICATION_URI
			{ 
				get 
				{ 
					return default(global::android.net.Uri); 
				} 
			} 
			public static global::java.lang.String ALARM_ALERT
			{ 
				get 
				{ 
					return "alarm_alert"; 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _DEFAULT_ALARM_ALERT_URI6357; 
			public static global::android.net.Uri DEFAULT_ALARM_ALERT_URI
			{ 
				get 
				{ 
					return default(global::android.net.Uri); 
				} 
			} 
			public static global::java.lang.String TEXT_AUTO_REPLACE
			{ 
				get 
				{ 
					return "auto_replace"; 
				} 
			} 
			public static global::java.lang.String TEXT_AUTO_CAPS
			{ 
				get 
				{ 
					return "auto_caps"; 
				} 
			} 
			public static global::java.lang.String TEXT_AUTO_PUNCTUATE
			{ 
				get 
				{ 
					return "auto_punctuate"; 
				} 
			} 
			public static global::java.lang.String TEXT_SHOW_PASSWORD
			{ 
				get 
				{ 
					return "show_password"; 
				} 
			} 
			public static global::java.lang.String SHOW_GTALK_SERVICE_STATUS
			{ 
				get 
				{ 
					return "SHOW_GTALK_SERVICE_STATUS"; 
				} 
			} 
			public static global::java.lang.String WALLPAPER_ACTIVITY
			{ 
				get 
				{ 
					return "wallpaper_activity"; 
				} 
			} 
			public static global::java.lang.String AUTO_TIME
			{ 
				get 
				{ 
					return "auto_time"; 
				} 
			} 
			public static global::java.lang.String TIME_12_24
			{ 
				get 
				{ 
					return "time_12_24"; 
				} 
			} 
			public static global::java.lang.String DATE_FORMAT
			{ 
				get 
				{ 
					return "date_format"; 
				} 
			} 
			public static global::java.lang.String SETUP_WIZARD_HAS_RUN
			{ 
				get 
				{ 
					return "setup_wizard_has_run"; 
				} 
			} 
			public static global::java.lang.String WINDOW_ANIMATION_SCALE
			{ 
				get 
				{ 
					return "window_animation_scale"; 
				} 
			} 
			public static global::java.lang.String TRANSITION_ANIMATION_SCALE
			{ 
				get 
				{ 
					return "transition_animation_scale"; 
				} 
			} 
			public static global::java.lang.String ACCELEROMETER_ROTATION
			{ 
				get 
				{ 
					return "accelerometer_rotation"; 
				} 
			} 
			public static global::java.lang.String DTMF_TONE_WHEN_DIALING
			{ 
				get 
				{ 
					return "dtmf_tone"; 
				} 
			} 
			public static global::java.lang.String SOUND_EFFECTS_ENABLED
			{ 
				get 
				{ 
					return "sound_effects_enabled"; 
				} 
			} 
			public static global::java.lang.String HAPTIC_FEEDBACK_ENABLED
			{ 
				get 
				{ 
					return "haptic_feedback_enabled"; 
				} 
			} 
			public static global::java.lang.String SHOW_WEB_SUGGESTIONS
			{ 
				get 
				{ 
					return "show_web_suggestions"; 
				} 
			} 
			public static global::java.lang.String ADB_ENABLED
			{ 
				get 
				{ 
					return "adb_enabled"; 
				} 
			} 
			public static global::java.lang.String ANDROID_ID
			{ 
				get 
				{ 
					return "android_id"; 
				} 
			} 
			public static global::java.lang.String BLUETOOTH_ON
			{ 
				get 
				{ 
					return "bluetooth_on"; 
				} 
			} 
			public static global::java.lang.String DATA_ROAMING
			{ 
				get 
				{ 
					return "data_roaming"; 
				} 
			} 
			public static global::java.lang.String DEVICE_PROVISIONED
			{ 
				get 
				{ 
					return "device_provisioned"; 
				} 
			} 
			public static global::java.lang.String HTTP_PROXY
			{ 
				get 
				{ 
					return "http_proxy"; 
				} 
			} 
			public static global::java.lang.String INSTALL_NON_MARKET_APPS
			{ 
				get 
				{ 
					return "install_non_market_apps"; 
				} 
			} 
			public static global::java.lang.String LOCATION_PROVIDERS_ALLOWED
			{ 
				get 
				{ 
					return "location_providers_allowed"; 
				} 
			} 
			public static global::java.lang.String LOGGING_ID
			{ 
				get 
				{ 
					return "logging_id"; 
				} 
			} 
			public static global::java.lang.String NETWORK_PREFERENCE
			{ 
				get 
				{ 
					return "network_preference"; 
				} 
			} 
			public static global::java.lang.String PARENTAL_CONTROL_ENABLED
			{ 
				get 
				{ 
					return "parental_control_enabled"; 
				} 
			} 
			public static global::java.lang.String PARENTAL_CONTROL_LAST_UPDATE
			{ 
				get 
				{ 
					return "parental_control_last_update"; 
				} 
			} 
			public static global::java.lang.String PARENTAL_CONTROL_REDIRECT_URL
			{ 
				get 
				{ 
					return "parental_control_redirect_url"; 
				} 
			} 
			public static global::java.lang.String SETTINGS_CLASSNAME
			{ 
				get 
				{ 
					return "settings_classname"; 
				} 
			} 
			public static global::java.lang.String USB_MASS_STORAGE_ENABLED
			{ 
				get 
				{ 
					return "usb_mass_storage_enabled"; 
				} 
			} 
			public static global::java.lang.String USE_GOOGLE_MAIL
			{ 
				get 
				{ 
					return "use_google_mail"; 
				} 
			} 
			public static global::java.lang.String WIFI_MAX_DHCP_RETRY_COUNT
			{ 
				get 
				{ 
					return "wifi_max_dhcp_retry_count"; 
				} 
			} 
			public static global::java.lang.String WIFI_MOBILE_DATA_TRANSITION_WAKELOCK_TIMEOUT_MS
			{ 
				get 
				{ 
					return "wifi_mobile_data_transition_wakelock_timeout_ms"; 
				} 
			} 
			public static global::java.lang.String WIFI_NETWORKS_AVAILABLE_NOTIFICATION_ON
			{ 
				get 
				{ 
					return "wifi_networks_available_notification_on"; 
				} 
			} 
			public static global::java.lang.String WIFI_NETWORKS_AVAILABLE_REPEAT_DELAY
			{ 
				get 
				{ 
					return "wifi_networks_available_repeat_delay"; 
				} 
			} 
			public static global::java.lang.String WIFI_NUM_OPEN_NETWORKS_KEPT
			{ 
				get 
				{ 
					return "wifi_num_open_networks_kept"; 
				} 
			} 
			public static global::java.lang.String WIFI_ON
			{ 
				get 
				{ 
					return "wifi_on"; 
				} 
			} 
			public static global::java.lang.String WIFI_WATCHDOG_ACCEPTABLE_PACKET_LOSS_PERCENTAGE
			{ 
				get 
				{ 
					return "wifi_watchdog_acceptable_packet_loss_percentage"; 
				} 
			} 
			public static global::java.lang.String WIFI_WATCHDOG_AP_COUNT
			{ 
				get 
				{ 
					return "wifi_watchdog_ap_count"; 
				} 
			} 
			public static global::java.lang.String WIFI_WATCHDOG_BACKGROUND_CHECK_DELAY_MS
			{ 
				get 
				{ 
					return "wifi_watchdog_background_check_delay_ms"; 
				} 
			} 
			public static global::java.lang.String WIFI_WATCHDOG_BACKGROUND_CHECK_ENABLED
			{ 
				get 
				{ 
					return "wifi_watchdog_background_check_enabled"; 
				} 
			} 
			public static global::java.lang.String WIFI_WATCHDOG_BACKGROUND_CHECK_TIMEOUT_MS
			{ 
				get 
				{ 
					return "wifi_watchdog_background_check_timeout_ms"; 
				} 
			} 
			public static global::java.lang.String WIFI_WATCHDOG_INITIAL_IGNORED_PING_COUNT
			{ 
				get 
				{ 
					return "wifi_watchdog_initial_ignored_ping_count"; 
				} 
			} 
			public static global::java.lang.String WIFI_WATCHDOG_MAX_AP_CHECKS
			{ 
				get 
				{ 
					return "wifi_watchdog_max_ap_checks"; 
				} 
			} 
			public static global::java.lang.String WIFI_WATCHDOG_ON
			{ 
				get 
				{ 
					return "wifi_watchdog_on"; 
				} 
			} 
			public static global::java.lang.String WIFI_WATCHDOG_PING_COUNT
			{ 
				get 
				{ 
					return "wifi_watchdog_ping_count"; 
				} 
			} 
			public static global::java.lang.String WIFI_WATCHDOG_PING_DELAY_MS
			{ 
				get 
				{ 
					return "wifi_watchdog_ping_delay_ms"; 
				} 
			} 
			public static global::java.lang.String WIFI_WATCHDOG_PING_TIMEOUT_MS
			{ 
				get 
				{ 
					return "wifi_watchdog_ping_timeout_ms"; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.Settings.System.staticClass = @__class; 
				global::android.provider.Settings.System._getInt6336 = @__env.GetStaticMethodID(global::android.provider.Settings.System.staticClass, "getInt", "(Landroid/content/ContentResolver;Ljava/lang/String;I)I"); 
				global::android.provider.Settings.System._getInt6337 = @__env.GetStaticMethodID(global::android.provider.Settings.System.staticClass, "getInt", "(Landroid/content/ContentResolver;Ljava/lang/String;)I"); 
				global::android.provider.Settings.System._putInt6338 = @__env.GetStaticMethodID(global::android.provider.Settings.System.staticClass, "putInt", "(Landroid/content/ContentResolver;Ljava/lang/String;I)Z"); 
				global::android.provider.Settings.System._getLong6339 = @__env.GetStaticMethodID(global::android.provider.Settings.System.staticClass, "getLong", "(Landroid/content/ContentResolver;Ljava/lang/String;)J"); 
				global::android.provider.Settings.System._getLong6340 = @__env.GetStaticMethodID(global::android.provider.Settings.System.staticClass, "getLong", "(Landroid/content/ContentResolver;Ljava/lang/String;J)J"); 
				global::android.provider.Settings.System._putLong6341 = @__env.GetStaticMethodID(global::android.provider.Settings.System.staticClass, "putLong", "(Landroid/content/ContentResolver;Ljava/lang/String;J)Z"); 
				global::android.provider.Settings.System._getFloat6342 = @__env.GetStaticMethodID(global::android.provider.Settings.System.staticClass, "getFloat", "(Landroid/content/ContentResolver;Ljava/lang/String;F)F"); 
				global::android.provider.Settings.System._getFloat6343 = @__env.GetStaticMethodID(global::android.provider.Settings.System.staticClass, "getFloat", "(Landroid/content/ContentResolver;Ljava/lang/String;)F"); 
				global::android.provider.Settings.System._putFloat6344 = @__env.GetStaticMethodID(global::android.provider.Settings.System.staticClass, "putFloat", "(Landroid/content/ContentResolver;Ljava/lang/String;F)Z"); 
				global::android.provider.Settings.System._getString6345 = @__env.GetStaticMethodID(global::android.provider.Settings.System.staticClass, "getString", "(Landroid/content/ContentResolver;Ljava/lang/String;)Ljava/lang/String;"); 
				global::android.provider.Settings.System._getConfiguration6346 = @__env.GetStaticMethodID(global::android.provider.Settings.System.staticClass, "getConfiguration", "(Landroid/content/ContentResolver;Landroid/content/res/Configuration;)V"); 
				global::android.provider.Settings.System._putString6347 = @__env.GetStaticMethodID(global::android.provider.Settings.System.staticClass, "putString", "(Landroid/content/ContentResolver;Ljava/lang/String;Ljava/lang/String;)Z"); 
				global::android.provider.Settings.System._getUriFor6348 = @__env.GetStaticMethodID(global::android.provider.Settings.System.staticClass, "getUriFor", "(Ljava/lang/String;)Landroid/net/Uri;"); 
				global::android.provider.Settings.System._putConfiguration6349 = @__env.GetStaticMethodID(global::android.provider.Settings.System.staticClass, "putConfiguration", "(Landroid/content/ContentResolver;Landroid/content/res/Configuration;)Z"); 
				global::android.provider.Settings.System._getShowGTalkServiceStatus6350 = @__env.GetStaticMethodID(global::android.provider.Settings.System.staticClass, "getShowGTalkServiceStatus", "(Landroid/content/ContentResolver;)Z"); 
				global::android.provider.Settings.System._setShowGTalkServiceStatus6351 = @__env.GetStaticMethodID(global::android.provider.Settings.System.staticClass, "setShowGTalkServiceStatus", "(Landroid/content/ContentResolver;Z)V"); 
				global::android.provider.Settings.System._System6352 = @__env.GetMethodID(global::android.provider.Settings.System.staticClass, "<init>", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Settings6358; 
		public Settings()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.provider.Settings.staticClass, global::android.provider.Settings._Settings6358, this); 
		} 
		public static global::java.lang.String ACTION_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.SETTINGS"; 
			} 
		} 
		public static global::java.lang.String ACTION_APN_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.APN_SETTINGS"; 
			} 
		} 
		public static global::java.lang.String ACTION_LOCATION_SOURCE_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.LOCATION_SOURCE_SETTINGS"; 
			} 
		} 
		public static global::java.lang.String ACTION_WIRELESS_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.WIRELESS_SETTINGS"; 
			} 
		} 
		public static global::java.lang.String ACTION_AIRPLANE_MODE_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.AIRPLANE_MODE_SETTINGS"; 
			} 
		} 
		public static global::java.lang.String ACTION_ACCESSIBILITY_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.ACCESSIBILITY_SETTINGS"; 
			} 
		} 
		public static global::java.lang.String ACTION_SECURITY_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.SECURITY_SETTINGS"; 
			} 
		} 
		public static global::java.lang.String ACTION_PRIVACY_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.PRIVACY_SETTINGS"; 
			} 
		} 
		public static global::java.lang.String ACTION_WIFI_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.WIFI_SETTINGS"; 
			} 
		} 
		public static global::java.lang.String ACTION_WIFI_IP_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.WIFI_IP_SETTINGS"; 
			} 
		} 
		public static global::java.lang.String ACTION_BLUETOOTH_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.BLUETOOTH_SETTINGS"; 
			} 
		} 
		public static global::java.lang.String ACTION_DATE_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.DATE_SETTINGS"; 
			} 
		} 
		public static global::java.lang.String ACTION_SOUND_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.SOUND_SETTINGS"; 
			} 
		} 
		public static global::java.lang.String ACTION_DISPLAY_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.DISPLAY_SETTINGS"; 
			} 
		} 
		public static global::java.lang.String ACTION_LOCALE_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.LOCALE_SETTINGS"; 
			} 
		} 
		public static global::java.lang.String ACTION_INPUT_METHOD_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.INPUT_METHOD_SETTINGS"; 
			} 
		} 
		public static global::java.lang.String ACTION_USER_DICTIONARY_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.USER_DICTIONARY_SETTINGS"; 
			} 
		} 
		public static global::java.lang.String ACTION_APPLICATION_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.APPLICATION_SETTINGS"; 
			} 
		} 
		public static global::java.lang.String ACTION_APPLICATION_DEVELOPMENT_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.APPLICATION_DEVELOPMENT_SETTINGS"; 
			} 
		} 
		public static global::java.lang.String ACTION_QUICK_LAUNCH_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.QUICK_LAUNCH_SETTINGS"; 
			} 
		} 
		public static global::java.lang.String ACTION_MANAGE_APPLICATIONS_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.MANAGE_APPLICATIONS_SETTINGS"; 
			} 
		} 
		public static global::java.lang.String ACTION_SYNC_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.SYNC_SETTINGS"; 
			} 
		} 
		public static global::java.lang.String ACTION_NETWORK_OPERATOR_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.NETWORK_OPERATOR_SETTINGS"; 
			} 
		} 
		public static global::java.lang.String ACTION_DATA_ROAMING_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.DATA_ROAMING_SETTINGS"; 
			} 
		} 
		public static global::java.lang.String ACTION_INTERNAL_STORAGE_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.INTERNAL_STORAGE_SETTINGS"; 
			} 
		} 
		public static global::java.lang.String ACTION_MEMORY_CARD_SETTINGS
		{ 
			get 
			{ 
				return "android.settings.MEMORY_CARD_SETTINGS"; 
			} 
		} 
		public static global::java.lang.String AUTHORITY
		{ 
			get 
			{ 
				return "settings"; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.provider.Settings.staticClass = @__class; 
			global::android.provider.Settings._Settings6358 = @__env.GetMethodID(global::android.provider.Settings.staticClass, "<init>", "()V"); 
		} 
	} 
} 
