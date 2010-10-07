namespace android.os
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Environment : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Environment()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.Environment), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.os.Environment(@__env);
			}
		}
		protected Environment(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRootDirectory6129;
		public static global::java.io.File getRootDirectory() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallStaticObjectMethodPtr(android.os.Environment.staticClass, global::android.os.Environment._getRootDirectory6129));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDataDirectory6130;
		public static global::java.io.File getDataDirectory() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallStaticObjectMethodPtr(android.os.Environment.staticClass, global::android.os.Environment._getDataDirectory6130));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getExternalStorageDirectory6131;
		public static global::java.io.File getExternalStorageDirectory() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallStaticObjectMethodPtr(android.os.Environment.staticClass, global::android.os.Environment._getExternalStorageDirectory6131));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getExternalStoragePublicDirectory6132;
		public static global::java.io.File getExternalStoragePublicDirectory(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallStaticObjectMethodPtr(android.os.Environment.staticClass, global::android.os.Environment._getExternalStoragePublicDirectory6132, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDownloadCacheDirectory6133;
		public static global::java.io.File getDownloadCacheDirectory() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallStaticObjectMethodPtr(android.os.Environment.staticClass, global::android.os.Environment._getDownloadCacheDirectory6133));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getExternalStorageState6134;
		public static global::java.lang.String getExternalStorageState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.os.Environment.staticClass, global::android.os.Environment._getExternalStorageState6134));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Environment6135;
		public Environment()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.os.Environment.staticClass, global::android.os.Environment._Environment6135, this);
		}
		internal static global::net.sf.jni4net.jni.FieldId _DIRECTORY_MUSIC6136;
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
		internal static global::net.sf.jni4net.jni.FieldId _DIRECTORY_PODCASTS6137;
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
		internal static global::net.sf.jni4net.jni.FieldId _DIRECTORY_RINGTONES6138;
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
		internal static global::net.sf.jni4net.jni.FieldId _DIRECTORY_ALARMS6139;
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
		internal static global::net.sf.jni4net.jni.FieldId _DIRECTORY_NOTIFICATIONS6140;
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
		internal static global::net.sf.jni4net.jni.FieldId _DIRECTORY_PICTURES6141;
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
		internal static global::net.sf.jni4net.jni.FieldId _DIRECTORY_MOVIES6142;
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
		internal static global::net.sf.jni4net.jni.FieldId _DIRECTORY_DOWNLOADS6143;
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
		internal static global::net.sf.jni4net.jni.FieldId _DIRECTORY_DCIM6144;
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.os.Environment.staticClass = @__class;
			global::android.os.Environment._getRootDirectory6129 = @__env.GetStaticMethodID(global::android.os.Environment.staticClass, "getRootDirectory", "()Ljava/io/File;");
			global::android.os.Environment._getDataDirectory6130 = @__env.GetStaticMethodID(global::android.os.Environment.staticClass, "getDataDirectory", "()Ljava/io/File;");
			global::android.os.Environment._getExternalStorageDirectory6131 = @__env.GetStaticMethodID(global::android.os.Environment.staticClass, "getExternalStorageDirectory", "()Ljava/io/File;");
			global::android.os.Environment._getExternalStoragePublicDirectory6132 = @__env.GetStaticMethodID(global::android.os.Environment.staticClass, "getExternalStoragePublicDirectory", "(Ljava/lang/String;)Ljava/io/File;");
			global::android.os.Environment._getDownloadCacheDirectory6133 = @__env.GetStaticMethodID(global::android.os.Environment.staticClass, "getDownloadCacheDirectory", "()Ljava/io/File;");
			global::android.os.Environment._getExternalStorageState6134 = @__env.GetStaticMethodID(global::android.os.Environment.staticClass, "getExternalStorageState", "()Ljava/lang/String;");
			global::android.os.Environment._Environment6135 = @__env.GetMethodID(global::android.os.Environment.staticClass, "<init>", "()V");
		}
	}
}
