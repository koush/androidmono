namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ActivityInfo : android.content.pm.ComponentInfo, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ActivityInfo()
		{
			InitJNI();
		}
		protected ActivityInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString1836;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.ActivityInfo._toString1836)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.ActivityInfo.staticClass, global::android.content.pm.ActivityInfo._toString1836)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _dump1837;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.ActivityInfo._dump1837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.ActivityInfo.staticClass, global::android.content.pm.ActivityInfo._dump1837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel1838;
		public override void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.ActivityInfo._writeToParcel1838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.ActivityInfo.staticClass, global::android.content.pm.ActivityInfo._writeToParcel1838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents1839;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.ActivityInfo._describeContents1839);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.ActivityInfo.staticClass, global::android.content.pm.ActivityInfo._describeContents1839);
		}
		internal static global::MonoJavaBridge.MethodId _getThemeResource1840;
		public virtual int getThemeResource() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.ActivityInfo._getThemeResource1840);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.ActivityInfo.staticClass, global::android.content.pm.ActivityInfo._getThemeResource1840);
		}
		internal static global::MonoJavaBridge.MethodId _ActivityInfo1841;
		public ActivityInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ActivityInfo.staticClass, global::android.content.pm.ActivityInfo._ActivityInfo1841);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ActivityInfo1842;
		public ActivityInfo(android.content.pm.ActivityInfo arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ActivityInfo.staticClass, global::android.content.pm.ActivityInfo._ActivityInfo1842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _theme1843;
		public int theme
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		public static int LAUNCH_MULTIPLE
		{
			get
			{
				return 0;
			}
		}
		public static int LAUNCH_SINGLE_TOP
		{
			get
			{
				return 1;
			}
		}
		public static int LAUNCH_SINGLE_TASK
		{
			get
			{
				return 2;
			}
		}
		public static int LAUNCH_SINGLE_INSTANCE
		{
			get
			{
				return 3;
			}
		}
		internal static global::MonoJavaBridge.FieldId _launchMode1844;
		public int launchMode
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _permission1845;
		public global::java.lang.String permission
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _taskAffinity1846;
		public global::java.lang.String taskAffinity
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _targetActivity1847;
		public global::java.lang.String targetActivity
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		public static int FLAG_MULTIPROCESS
		{
			get
			{
				return 1;
			}
		}
		public static int FLAG_FINISH_ON_TASK_LAUNCH
		{
			get
			{
				return 2;
			}
		}
		public static int FLAG_CLEAR_TASK_ON_LAUNCH
		{
			get
			{
				return 4;
			}
		}
		public static int FLAG_ALWAYS_RETAIN_TASK_STATE
		{
			get
			{
				return 8;
			}
		}
		public static int FLAG_STATE_NOT_NEEDED
		{
			get
			{
				return 16;
			}
		}
		public static int FLAG_EXCLUDE_FROM_RECENTS
		{
			get
			{
				return 32;
			}
		}
		public static int FLAG_ALLOW_TASK_REPARENTING
		{
			get
			{
				return 64;
			}
		}
		public static int FLAG_NO_HISTORY
		{
			get
			{
				return 128;
			}
		}
		public static int FLAG_FINISH_ON_CLOSE_SYSTEM_DIALOGS
		{
			get
			{
				return 256;
			}
		}
		internal static global::MonoJavaBridge.FieldId _flags1848;
		public int flags
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		public static int SCREEN_ORIENTATION_UNSPECIFIED
		{
			get
			{
				return -1;
			}
		}
		public static int SCREEN_ORIENTATION_LANDSCAPE
		{
			get
			{
				return 0;
			}
		}
		public static int SCREEN_ORIENTATION_PORTRAIT
		{
			get
			{
				return 1;
			}
		}
		public static int SCREEN_ORIENTATION_USER
		{
			get
			{
				return 2;
			}
		}
		public static int SCREEN_ORIENTATION_BEHIND
		{
			get
			{
				return 3;
			}
		}
		public static int SCREEN_ORIENTATION_SENSOR
		{
			get
			{
				return 4;
			}
		}
		public static int SCREEN_ORIENTATION_NOSENSOR
		{
			get
			{
				return 5;
			}
		}
		internal static global::MonoJavaBridge.FieldId _screenOrientation1849;
		public int screenOrientation
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		public static int CONFIG_MCC
		{
			get
			{
				return 1;
			}
		}
		public static int CONFIG_MNC
		{
			get
			{
				return 2;
			}
		}
		public static int CONFIG_LOCALE
		{
			get
			{
				return 4;
			}
		}
		public static int CONFIG_TOUCHSCREEN
		{
			get
			{
				return 8;
			}
		}
		public static int CONFIG_KEYBOARD
		{
			get
			{
				return 16;
			}
		}
		public static int CONFIG_KEYBOARD_HIDDEN
		{
			get
			{
				return 32;
			}
		}
		public static int CONFIG_NAVIGATION
		{
			get
			{
				return 64;
			}
		}
		public static int CONFIG_ORIENTATION
		{
			get
			{
				return 128;
			}
		}
		public static int CONFIG_SCREEN_LAYOUT
		{
			get
			{
				return 256;
			}
		}
		public static int CONFIG_UI_MODE
		{
			get
			{
				return 512;
			}
		}
		public static int CONFIG_FONT_SCALE
		{
			get
			{
				return 1073741824;
			}
		}
		internal static global::MonoJavaBridge.FieldId _configChanges1850;
		public int configChanges
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _softInputMode1851;
		public int softInputMode
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1852;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.ActivityInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/ActivityInfo"));
			global::android.content.pm.ActivityInfo._toString1836 = @__env.GetMethodIDNoThrow(global::android.content.pm.ActivityInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.pm.ActivityInfo._dump1837 = @__env.GetMethodIDNoThrow(global::android.content.pm.ActivityInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.content.pm.ActivityInfo._writeToParcel1838 = @__env.GetMethodIDNoThrow(global::android.content.pm.ActivityInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.ActivityInfo._describeContents1839 = @__env.GetMethodIDNoThrow(global::android.content.pm.ActivityInfo.staticClass, "describeContents", "()I");
			global::android.content.pm.ActivityInfo._getThemeResource1840 = @__env.GetMethodIDNoThrow(global::android.content.pm.ActivityInfo.staticClass, "getThemeResource", "()I");
			global::android.content.pm.ActivityInfo._ActivityInfo1841 = @__env.GetMethodIDNoThrow(global::android.content.pm.ActivityInfo.staticClass, "<init>", "()V");
			global::android.content.pm.ActivityInfo._ActivityInfo1842 = @__env.GetMethodIDNoThrow(global::android.content.pm.ActivityInfo.staticClass, "<init>", "(Landroid/content/pm/ActivityInfo;)V");
		}
	}
}
