namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Environment : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Environment()
		{
			InitJNI();
		}
		protected Environment(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public static global::java.io.File RootDirectory
		{
			get
			{
				return getRootDirectory();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRootDirectory9808;
		public static global::java.io.File getRootDirectory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Environment.staticClass, global::android.os.Environment._getRootDirectory9808)) as java.io.File;
		}
		public static global::java.io.File DataDirectory
		{
			get
			{
				return getDataDirectory();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDataDirectory9809;
		public static global::java.io.File getDataDirectory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Environment.staticClass, global::android.os.Environment._getDataDirectory9809)) as java.io.File;
		}
		public static global::java.io.File ExternalStorageDirectory
		{
			get
			{
				return getExternalStorageDirectory();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExternalStorageDirectory9810;
		public static global::java.io.File getExternalStorageDirectory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Environment.staticClass, global::android.os.Environment._getExternalStorageDirectory9810)) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _getExternalStoragePublicDirectory9811;
		public static global::java.io.File getExternalStoragePublicDirectory(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Environment.staticClass, global::android.os.Environment._getExternalStoragePublicDirectory9811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File;
		}
		public static global::java.io.File DownloadCacheDirectory
		{
			get
			{
				return getDownloadCacheDirectory();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDownloadCacheDirectory9812;
		public static global::java.io.File getDownloadCacheDirectory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Environment.staticClass, global::android.os.Environment._getDownloadCacheDirectory9812)) as java.io.File;
		}
		public static global::java.lang.String ExternalStorageState
		{
			get
			{
				return getExternalStorageState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExternalStorageState9813;
		public static global::java.lang.String getExternalStorageState()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.os.Environment.staticClass, global::android.os.Environment._getExternalStorageState9813)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _Environment9814;
		public Environment() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Environment.staticClass, global::android.os.Environment._Environment9814);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _DIRECTORY_MUSIC9815;
		public static global::java.lang.String DIRECTORY_MUSIC
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Environment.staticClass, _DIRECTORY_MUSIC9815)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _DIRECTORY_PODCASTS9816;
		public static global::java.lang.String DIRECTORY_PODCASTS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Environment.staticClass, _DIRECTORY_PODCASTS9816)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _DIRECTORY_RINGTONES9817;
		public static global::java.lang.String DIRECTORY_RINGTONES
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Environment.staticClass, _DIRECTORY_RINGTONES9817)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _DIRECTORY_ALARMS9818;
		public static global::java.lang.String DIRECTORY_ALARMS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Environment.staticClass, _DIRECTORY_ALARMS9818)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _DIRECTORY_NOTIFICATIONS9819;
		public static global::java.lang.String DIRECTORY_NOTIFICATIONS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Environment.staticClass, _DIRECTORY_NOTIFICATIONS9819)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _DIRECTORY_PICTURES9820;
		public static global::java.lang.String DIRECTORY_PICTURES
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Environment.staticClass, _DIRECTORY_PICTURES9820)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _DIRECTORY_MOVIES9821;
		public static global::java.lang.String DIRECTORY_MOVIES
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Environment.staticClass, _DIRECTORY_MOVIES9821)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _DIRECTORY_DOWNLOADS9822;
		public static global::java.lang.String DIRECTORY_DOWNLOADS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Environment.staticClass, _DIRECTORY_DOWNLOADS9822)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _DIRECTORY_DCIM9823;
		public static global::java.lang.String DIRECTORY_DCIM
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Environment.staticClass, _DIRECTORY_DCIM9823)) as java.lang.String;
			}
			set
			{
			}
		}
		public static global::java.lang.String MEDIA_REMOVED
		{
			get
			{
				return "removed";
			}
		}
		public static global::java.lang.String MEDIA_UNMOUNTED
		{
			get
			{
				return "unmounted";
			}
		}
		public static global::java.lang.String MEDIA_CHECKING
		{
			get
			{
				return "checking";
			}
		}
		public static global::java.lang.String MEDIA_NOFS
		{
			get
			{
				return "nofs";
			}
		}
		public static global::java.lang.String MEDIA_MOUNTED
		{
			get
			{
				return "mounted";
			}
		}
		public static global::java.lang.String MEDIA_MOUNTED_READ_ONLY
		{
			get
			{
				return "mounted_ro";
			}
		}
		public static global::java.lang.String MEDIA_SHARED
		{
			get
			{
				return "shared";
			}
		}
		public static global::java.lang.String MEDIA_BAD_REMOVAL
		{
			get
			{
				return "bad_removal";
			}
		}
		public static global::java.lang.String MEDIA_UNMOUNTABLE
		{
			get
			{
				return "unmountable";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Environment.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Environment"));
			global::android.os.Environment._getRootDirectory9808 = @__env.GetStaticMethodIDNoThrow(global::android.os.Environment.staticClass, "getRootDirectory", "()Ljava/io/File;");
			global::android.os.Environment._getDataDirectory9809 = @__env.GetStaticMethodIDNoThrow(global::android.os.Environment.staticClass, "getDataDirectory", "()Ljava/io/File;");
			global::android.os.Environment._getExternalStorageDirectory9810 = @__env.GetStaticMethodIDNoThrow(global::android.os.Environment.staticClass, "getExternalStorageDirectory", "()Ljava/io/File;");
			global::android.os.Environment._getExternalStoragePublicDirectory9811 = @__env.GetStaticMethodIDNoThrow(global::android.os.Environment.staticClass, "getExternalStoragePublicDirectory", "(Ljava/lang/String;)Ljava/io/File;");
			global::android.os.Environment._getDownloadCacheDirectory9812 = @__env.GetStaticMethodIDNoThrow(global::android.os.Environment.staticClass, "getDownloadCacheDirectory", "()Ljava/io/File;");
			global::android.os.Environment._getExternalStorageState9813 = @__env.GetStaticMethodIDNoThrow(global::android.os.Environment.staticClass, "getExternalStorageState", "()Ljava/lang/String;");
			global::android.os.Environment._Environment9814 = @__env.GetMethodIDNoThrow(global::android.os.Environment.staticClass, "<init>", "()V");
			global::android.os.Environment._DIRECTORY_MUSIC9815 = @__env.GetStaticFieldIDNoThrow(global::android.os.Environment.staticClass, "DIRECTORY_MUSIC", "Ljava/lang/String;");
			global::android.os.Environment._DIRECTORY_PODCASTS9816 = @__env.GetStaticFieldIDNoThrow(global::android.os.Environment.staticClass, "DIRECTORY_PODCASTS", "Ljava/lang/String;");
			global::android.os.Environment._DIRECTORY_RINGTONES9817 = @__env.GetStaticFieldIDNoThrow(global::android.os.Environment.staticClass, "DIRECTORY_RINGTONES", "Ljava/lang/String;");
			global::android.os.Environment._DIRECTORY_ALARMS9818 = @__env.GetStaticFieldIDNoThrow(global::android.os.Environment.staticClass, "DIRECTORY_ALARMS", "Ljava/lang/String;");
			global::android.os.Environment._DIRECTORY_NOTIFICATIONS9819 = @__env.GetStaticFieldIDNoThrow(global::android.os.Environment.staticClass, "DIRECTORY_NOTIFICATIONS", "Ljava/lang/String;");
			global::android.os.Environment._DIRECTORY_PICTURES9820 = @__env.GetStaticFieldIDNoThrow(global::android.os.Environment.staticClass, "DIRECTORY_PICTURES", "Ljava/lang/String;");
			global::android.os.Environment._DIRECTORY_MOVIES9821 = @__env.GetStaticFieldIDNoThrow(global::android.os.Environment.staticClass, "DIRECTORY_MOVIES", "Ljava/lang/String;");
			global::android.os.Environment._DIRECTORY_DOWNLOADS9822 = @__env.GetStaticFieldIDNoThrow(global::android.os.Environment.staticClass, "DIRECTORY_DOWNLOADS", "Ljava/lang/String;");
			global::android.os.Environment._DIRECTORY_DCIM9823 = @__env.GetStaticFieldIDNoThrow(global::android.os.Environment.staticClass, "DIRECTORY_DCIM", "Ljava/lang/String;");
		}
	}
}
