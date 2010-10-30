namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ActivityInfo : android.content.pm.ComponentInfo, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ActivityInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.pm.ActivityInfo.staticClass, "toString", "()Ljava/lang/String;", ref global::android.content.pm.ActivityInfo._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.ActivityInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V", ref global::android.content.pm.ActivityInfo._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void dump(global::android.util.PrinterDelegate arg0, java.lang.String arg1)
		{
			dump((global::android.util.PrinterDelegateWrapper)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.ActivityInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.pm.ActivityInfo._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.ActivityInfo.staticClass, "describeContents", "()I", ref global::android.content.pm.ActivityInfo._m3);
		}
		public new int ThemeResource
		{
			get
			{
				return getThemeResource();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int getThemeResource()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.ActivityInfo.staticClass, "getThemeResource", "()I", ref global::android.content.pm.ActivityInfo._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public ActivityInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.ActivityInfo._m5.native == global::System.IntPtr.Zero)
				global::android.content.pm.ActivityInfo._m5 = @__env.GetMethodIDNoThrow(global::android.content.pm.ActivityInfo.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ActivityInfo.staticClass, global::android.content.pm.ActivityInfo._m5);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public ActivityInfo(android.content.pm.ActivityInfo arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.ActivityInfo._m6.native == global::System.IntPtr.Zero)
				global::android.content.pm.ActivityInfo._m6 = @__env.GetMethodIDNoThrow(global::android.content.pm.ActivityInfo.staticClass, "<init>", "(Landroid/content/pm/ActivityInfo;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ActivityInfo.staticClass, global::android.content.pm.ActivityInfo._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _theme1907;
		public int theme
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _theme1907);
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
		internal static global::MonoJavaBridge.FieldId _launchMode1912;
		public int launchMode
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _launchMode1912);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _permission1913;
		public global::java.lang.String permission
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _permission1913)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _taskAffinity1914;
		public global::java.lang.String taskAffinity
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _taskAffinity1914)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _targetActivity1915;
		public global::java.lang.String targetActivity
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _targetActivity1915)) as java.lang.String;
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
		internal static global::MonoJavaBridge.FieldId _flags1925;
		public int flags
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _flags1925);
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
		internal static global::MonoJavaBridge.FieldId _screenOrientation1933;
		public int screenOrientation
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _screenOrientation1933);
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
		internal static global::MonoJavaBridge.FieldId _configChanges1945;
		public int configChanges
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _configChanges1945);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _softInputMode1946;
		public int softInputMode
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _softInputMode1946);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1947;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.ActivityInfo.staticClass, _CREATOR1947)) as android.os.Parcelable_Creator;
			}
		}
		static ActivityInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.ActivityInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/ActivityInfo"));
			global::android.content.pm.ActivityInfo._theme1907 = @__env.GetFieldIDNoThrow(global::android.content.pm.ActivityInfo.staticClass, "theme", "I");
			global::android.content.pm.ActivityInfo._launchMode1912 = @__env.GetFieldIDNoThrow(global::android.content.pm.ActivityInfo.staticClass, "launchMode", "I");
			global::android.content.pm.ActivityInfo._permission1913 = @__env.GetFieldIDNoThrow(global::android.content.pm.ActivityInfo.staticClass, "permission", "Ljava/lang/String;");
			global::android.content.pm.ActivityInfo._taskAffinity1914 = @__env.GetFieldIDNoThrow(global::android.content.pm.ActivityInfo.staticClass, "taskAffinity", "Ljava/lang/String;");
			global::android.content.pm.ActivityInfo._targetActivity1915 = @__env.GetFieldIDNoThrow(global::android.content.pm.ActivityInfo.staticClass, "targetActivity", "Ljava/lang/String;");
			global::android.content.pm.ActivityInfo._flags1925 = @__env.GetFieldIDNoThrow(global::android.content.pm.ActivityInfo.staticClass, "flags", "I");
			global::android.content.pm.ActivityInfo._screenOrientation1933 = @__env.GetFieldIDNoThrow(global::android.content.pm.ActivityInfo.staticClass, "screenOrientation", "I");
			global::android.content.pm.ActivityInfo._configChanges1945 = @__env.GetFieldIDNoThrow(global::android.content.pm.ActivityInfo.staticClass, "configChanges", "I");
			global::android.content.pm.ActivityInfo._softInputMode1946 = @__env.GetFieldIDNoThrow(global::android.content.pm.ActivityInfo.staticClass, "softInputMode", "I");
			global::android.content.pm.ActivityInfo._CREATOR1947 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.ActivityInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
