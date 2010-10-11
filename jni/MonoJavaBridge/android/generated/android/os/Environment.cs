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
		internal static global::MonoJavaBridge.MethodId _getRootDirectory6397;
		public static global::java.io.File getRootDirectory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Environment.staticClass, global::android.os.Environment._getRootDirectory6397)) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _getDataDirectory6398;
		public static global::java.io.File getDataDirectory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Environment.staticClass, global::android.os.Environment._getDataDirectory6398)) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _getExternalStorageDirectory6399;
		public static global::java.io.File getExternalStorageDirectory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Environment.staticClass, global::android.os.Environment._getExternalStorageDirectory6399)) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _getExternalStoragePublicDirectory6400;
		public static global::java.io.File getExternalStoragePublicDirectory(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Environment.staticClass, global::android.os.Environment._getExternalStoragePublicDirectory6400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _getDownloadCacheDirectory6401;
		public static global::java.io.File getDownloadCacheDirectory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Environment.staticClass, global::android.os.Environment._getDownloadCacheDirectory6401)) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _getExternalStorageState6402;
		public static global::java.lang.String getExternalStorageState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Environment.staticClass, global::android.os.Environment._getExternalStorageState6402)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _Environment6403;
		public Environment()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Environment.staticClass, global::android.os.Environment._Environment6403);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _DIRECTORY_MUSIC6404;
		public static global::java.lang.String DIRECTORY_MUSIC
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _DIRECTORY_PODCASTS6405;
		public static global::java.lang.String DIRECTORY_PODCASTS
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _DIRECTORY_RINGTONES6406;
		public static global::java.lang.String DIRECTORY_RINGTONES
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _DIRECTORY_ALARMS6407;
		public static global::java.lang.String DIRECTORY_ALARMS
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _DIRECTORY_NOTIFICATIONS6408;
		public static global::java.lang.String DIRECTORY_NOTIFICATIONS
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _DIRECTORY_PICTURES6409;
		public static global::java.lang.String DIRECTORY_PICTURES
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _DIRECTORY_MOVIES6410;
		public static global::java.lang.String DIRECTORY_MOVIES
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _DIRECTORY_DOWNLOADS6411;
		public static global::java.lang.String DIRECTORY_DOWNLOADS
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _DIRECTORY_DCIM6412;
		public static global::java.lang.String DIRECTORY_DCIM
		{
			get
			{
				return default(global::java.lang.String);
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
			global::android.os.Environment._getRootDirectory6397 = @__env.GetStaticMethodIDNoThrow(global::android.os.Environment.staticClass, "getRootDirectory", "()Ljava/io/File;");
			global::android.os.Environment._getDataDirectory6398 = @__env.GetStaticMethodIDNoThrow(global::android.os.Environment.staticClass, "getDataDirectory", "()Ljava/io/File;");
			global::android.os.Environment._getExternalStorageDirectory6399 = @__env.GetStaticMethodIDNoThrow(global::android.os.Environment.staticClass, "getExternalStorageDirectory", "()Ljava/io/File;");
			global::android.os.Environment._getExternalStoragePublicDirectory6400 = @__env.GetStaticMethodIDNoThrow(global::android.os.Environment.staticClass, "getExternalStoragePublicDirectory", "(Ljava/lang/String;)Ljava/io/File;");
			global::android.os.Environment._getDownloadCacheDirectory6401 = @__env.GetStaticMethodIDNoThrow(global::android.os.Environment.staticClass, "getDownloadCacheDirectory", "()Ljava/io/File;");
			global::android.os.Environment._getExternalStorageState6402 = @__env.GetStaticMethodIDNoThrow(global::android.os.Environment.staticClass, "getExternalStorageState", "()Ljava/lang/String;");
			global::android.os.Environment._Environment6403 = @__env.GetMethodIDNoThrow(global::android.os.Environment.staticClass, "<init>", "()V");
		}
	}
}
