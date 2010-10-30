namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Environment : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.io.File getRootDirectory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Environment._m0.native == global::System.IntPtr.Zero)
				global::android.os.Environment._m0 = @__env.GetStaticMethodIDNoThrow(global::android.os.Environment.staticClass, "getRootDirectory", "()Ljava/io/File;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Environment.staticClass, global::android.os.Environment._m0)) as java.io.File;
		}
		public static global::java.io.File DataDirectory
		{
			get
			{
				return getDataDirectory();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.io.File getDataDirectory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Environment._m1.native == global::System.IntPtr.Zero)
				global::android.os.Environment._m1 = @__env.GetStaticMethodIDNoThrow(global::android.os.Environment.staticClass, "getDataDirectory", "()Ljava/io/File;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Environment.staticClass, global::android.os.Environment._m1)) as java.io.File;
		}
		public static global::java.io.File ExternalStorageDirectory
		{
			get
			{
				return getExternalStorageDirectory();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.io.File getExternalStorageDirectory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Environment._m2.native == global::System.IntPtr.Zero)
				global::android.os.Environment._m2 = @__env.GetStaticMethodIDNoThrow(global::android.os.Environment.staticClass, "getExternalStorageDirectory", "()Ljava/io/File;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Environment.staticClass, global::android.os.Environment._m2)) as java.io.File;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::java.io.File getExternalStoragePublicDirectory(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Environment._m3.native == global::System.IntPtr.Zero)
				global::android.os.Environment._m3 = @__env.GetStaticMethodIDNoThrow(global::android.os.Environment.staticClass, "getExternalStoragePublicDirectory", "(Ljava/lang/String;)Ljava/io/File;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Environment.staticClass, global::android.os.Environment._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File;
		}
		public static global::java.io.File DownloadCacheDirectory
		{
			get
			{
				return getDownloadCacheDirectory();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static global::java.io.File getDownloadCacheDirectory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Environment._m4.native == global::System.IntPtr.Zero)
				global::android.os.Environment._m4 = @__env.GetStaticMethodIDNoThrow(global::android.os.Environment.staticClass, "getDownloadCacheDirectory", "()Ljava/io/File;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Environment.staticClass, global::android.os.Environment._m4)) as java.io.File;
		}
		public static global::java.lang.String ExternalStorageState
		{
			get
			{
				return getExternalStorageState();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::java.lang.String getExternalStorageState()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Environment._m5.native == global::System.IntPtr.Zero)
				global::android.os.Environment._m5 = @__env.GetStaticMethodIDNoThrow(global::android.os.Environment.staticClass, "getExternalStorageState", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.os.Environment.staticClass, global::android.os.Environment._m5)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public Environment() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Environment._m6.native == global::System.IntPtr.Zero)
				global::android.os.Environment._m6 = @__env.GetMethodIDNoThrow(global::android.os.Environment.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Environment.staticClass, global::android.os.Environment._m6);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _DIRECTORY_MUSIC3966;
		public static global::java.lang.String DIRECTORY_MUSIC
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Environment.staticClass, _DIRECTORY_MUSIC3966)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _DIRECTORY_PODCASTS3967;
		public static global::java.lang.String DIRECTORY_PODCASTS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Environment.staticClass, _DIRECTORY_PODCASTS3967)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _DIRECTORY_RINGTONES3968;
		public static global::java.lang.String DIRECTORY_RINGTONES
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Environment.staticClass, _DIRECTORY_RINGTONES3968)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _DIRECTORY_ALARMS3969;
		public static global::java.lang.String DIRECTORY_ALARMS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Environment.staticClass, _DIRECTORY_ALARMS3969)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _DIRECTORY_NOTIFICATIONS3970;
		public static global::java.lang.String DIRECTORY_NOTIFICATIONS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Environment.staticClass, _DIRECTORY_NOTIFICATIONS3970)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _DIRECTORY_PICTURES3971;
		public static global::java.lang.String DIRECTORY_PICTURES
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Environment.staticClass, _DIRECTORY_PICTURES3971)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _DIRECTORY_MOVIES3972;
		public static global::java.lang.String DIRECTORY_MOVIES
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Environment.staticClass, _DIRECTORY_MOVIES3972)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _DIRECTORY_DOWNLOADS3973;
		public static global::java.lang.String DIRECTORY_DOWNLOADS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Environment.staticClass, _DIRECTORY_DOWNLOADS3973)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _DIRECTORY_DCIM3974;
		public static global::java.lang.String DIRECTORY_DCIM
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Environment.staticClass, _DIRECTORY_DCIM3974)) as java.lang.String;
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
		static Environment()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Environment.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Environment"));
			global::android.os.Environment._DIRECTORY_MUSIC3966 = @__env.GetStaticFieldIDNoThrow(global::android.os.Environment.staticClass, "DIRECTORY_MUSIC", "Ljava/lang/String;");
			global::android.os.Environment._DIRECTORY_PODCASTS3967 = @__env.GetStaticFieldIDNoThrow(global::android.os.Environment.staticClass, "DIRECTORY_PODCASTS", "Ljava/lang/String;");
			global::android.os.Environment._DIRECTORY_RINGTONES3968 = @__env.GetStaticFieldIDNoThrow(global::android.os.Environment.staticClass, "DIRECTORY_RINGTONES", "Ljava/lang/String;");
			global::android.os.Environment._DIRECTORY_ALARMS3969 = @__env.GetStaticFieldIDNoThrow(global::android.os.Environment.staticClass, "DIRECTORY_ALARMS", "Ljava/lang/String;");
			global::android.os.Environment._DIRECTORY_NOTIFICATIONS3970 = @__env.GetStaticFieldIDNoThrow(global::android.os.Environment.staticClass, "DIRECTORY_NOTIFICATIONS", "Ljava/lang/String;");
			global::android.os.Environment._DIRECTORY_PICTURES3971 = @__env.GetStaticFieldIDNoThrow(global::android.os.Environment.staticClass, "DIRECTORY_PICTURES", "Ljava/lang/String;");
			global::android.os.Environment._DIRECTORY_MOVIES3972 = @__env.GetStaticFieldIDNoThrow(global::android.os.Environment.staticClass, "DIRECTORY_MOVIES", "Ljava/lang/String;");
			global::android.os.Environment._DIRECTORY_DOWNLOADS3973 = @__env.GetStaticFieldIDNoThrow(global::android.os.Environment.staticClass, "DIRECTORY_DOWNLOADS", "Ljava/lang/String;");
			global::android.os.Environment._DIRECTORY_DCIM3974 = @__env.GetStaticFieldIDNoThrow(global::android.os.Environment.staticClass, "DIRECTORY_DCIM", "Ljava/lang/String;");
		}
		internal static void InitJNI()
		{
		}
	}
}
