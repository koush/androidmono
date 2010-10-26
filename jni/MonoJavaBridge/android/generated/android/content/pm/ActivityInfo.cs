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
		internal static global::MonoJavaBridge.MethodId _toString3594;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.ActivityInfo._toString3594)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.ActivityInfo.staticClass, global::android.content.pm.ActivityInfo._toString3594)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _dump3595;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.ActivityInfo._dump3595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.ActivityInfo.staticClass, global::android.content.pm.ActivityInfo._dump3595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void dump(global::android.util.PrinterDelegate arg0, java.lang.String arg1)
		{
			dump((global::android.util.PrinterDelegateWrapper)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel3596;
		public override void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.ActivityInfo._writeToParcel3596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.ActivityInfo.staticClass, global::android.content.pm.ActivityInfo._writeToParcel3596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents3597;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.ActivityInfo._describeContents3597);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.ActivityInfo.staticClass, global::android.content.pm.ActivityInfo._describeContents3597);
		}
		public new int ThemeResource
		{
			get
			{
				return getThemeResource();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getThemeResource3598;
		public virtual int getThemeResource() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.ActivityInfo._getThemeResource3598);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.ActivityInfo.staticClass, global::android.content.pm.ActivityInfo._getThemeResource3598);
		}
		internal static global::MonoJavaBridge.MethodId _ActivityInfo3599;
		public ActivityInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ActivityInfo.staticClass, global::android.content.pm.ActivityInfo._ActivityInfo3599);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ActivityInfo3600;
		public ActivityInfo(android.content.pm.ActivityInfo arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ActivityInfo.staticClass, global::android.content.pm.ActivityInfo._ActivityInfo3600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _theme3601;
		public int theme
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _theme3601);
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
		internal static global::MonoJavaBridge.FieldId _launchMode3606;
		public int launchMode
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _launchMode3606);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _permission3607;
		public global::java.lang.String permission
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _permission3607)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _taskAffinity3608;
		public global::java.lang.String taskAffinity
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _taskAffinity3608)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _targetActivity3609;
		public global::java.lang.String targetActivity
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _targetActivity3609)) as java.lang.String;
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
		internal static global::MonoJavaBridge.FieldId _flags3619;
		public int flags
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _flags3619);
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
		internal static global::MonoJavaBridge.FieldId _screenOrientation3627;
		public int screenOrientation
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _screenOrientation3627);
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
		internal static global::MonoJavaBridge.FieldId _configChanges3639;
		public int configChanges
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _configChanges3639);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _softInputMode3640;
		public int softInputMode
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _softInputMode3640);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR3641;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.ActivityInfo.staticClass, _CREATOR3641)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.ActivityInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/ActivityInfo"));
			global::android.content.pm.ActivityInfo._toString3594 = @__env.GetMethodIDNoThrow(global::android.content.pm.ActivityInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.pm.ActivityInfo._dump3595 = @__env.GetMethodIDNoThrow(global::android.content.pm.ActivityInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.content.pm.ActivityInfo._writeToParcel3596 = @__env.GetMethodIDNoThrow(global::android.content.pm.ActivityInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.ActivityInfo._describeContents3597 = @__env.GetMethodIDNoThrow(global::android.content.pm.ActivityInfo.staticClass, "describeContents", "()I");
			global::android.content.pm.ActivityInfo._getThemeResource3598 = @__env.GetMethodIDNoThrow(global::android.content.pm.ActivityInfo.staticClass, "getThemeResource", "()I");
			global::android.content.pm.ActivityInfo._ActivityInfo3599 = @__env.GetMethodIDNoThrow(global::android.content.pm.ActivityInfo.staticClass, "<init>", "()V");
			global::android.content.pm.ActivityInfo._ActivityInfo3600 = @__env.GetMethodIDNoThrow(global::android.content.pm.ActivityInfo.staticClass, "<init>", "(Landroid/content/pm/ActivityInfo;)V");
			global::android.content.pm.ActivityInfo._theme3601 = @__env.GetFieldIDNoThrow(global::android.content.pm.ActivityInfo.staticClass, "theme", "I");
			global::android.content.pm.ActivityInfo._launchMode3606 = @__env.GetFieldIDNoThrow(global::android.content.pm.ActivityInfo.staticClass, "launchMode", "I");
			global::android.content.pm.ActivityInfo._permission3607 = @__env.GetFieldIDNoThrow(global::android.content.pm.ActivityInfo.staticClass, "permission", "Ljava/lang/String;");
			global::android.content.pm.ActivityInfo._taskAffinity3608 = @__env.GetFieldIDNoThrow(global::android.content.pm.ActivityInfo.staticClass, "taskAffinity", "Ljava/lang/String;");
			global::android.content.pm.ActivityInfo._targetActivity3609 = @__env.GetFieldIDNoThrow(global::android.content.pm.ActivityInfo.staticClass, "targetActivity", "Ljava/lang/String;");
			global::android.content.pm.ActivityInfo._flags3619 = @__env.GetFieldIDNoThrow(global::android.content.pm.ActivityInfo.staticClass, "flags", "I");
			global::android.content.pm.ActivityInfo._screenOrientation3627 = @__env.GetFieldIDNoThrow(global::android.content.pm.ActivityInfo.staticClass, "screenOrientation", "I");
			global::android.content.pm.ActivityInfo._configChanges3639 = @__env.GetFieldIDNoThrow(global::android.content.pm.ActivityInfo.staticClass, "configChanges", "I");
			global::android.content.pm.ActivityInfo._softInputMode3640 = @__env.GetFieldIDNoThrow(global::android.content.pm.ActivityInfo.staticClass, "softInputMode", "I");
			global::android.content.pm.ActivityInfo._CREATOR3641 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.ActivityInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
