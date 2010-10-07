namespace android.content.pm
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ActivityInfo : android.content.pm.ComponentInfo, android.os.Parcelable
	{
		internal new static global::java.lang.Class staticClass;
		static ActivityInfo()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.pm.ActivityInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.pm.ActivityInfo(@__env);
			}
		}
		protected ActivityInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString1742;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.pm.ActivityInfo._toString1742));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.pm.ActivityInfo.staticClass, global::android.content.pm.ActivityInfo._toString1742));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dump1743;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.pm.ActivityInfo._dump1743, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.pm.ActivityInfo.staticClass, global::android.content.pm.ActivityInfo._dump1743, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1744;
		public override void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.pm.ActivityInfo._writeToParcel1744, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.pm.ActivityInfo.staticClass, global::android.content.pm.ActivityInfo._writeToParcel1744, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1745;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.pm.ActivityInfo._describeContents1745);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.pm.ActivityInfo.staticClass, global::android.content.pm.ActivityInfo._describeContents1745);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getThemeResource1746;
		public virtual int getThemeResource() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.pm.ActivityInfo._getThemeResource1746);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.pm.ActivityInfo.staticClass, global::android.content.pm.ActivityInfo._getThemeResource1746);
		}
		internal static global::net.sf.jni4net.jni.MethodId _ActivityInfo1747;
		public ActivityInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.pm.ActivityInfo.staticClass, global::android.content.pm.ActivityInfo._ActivityInfo1747, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _ActivityInfo1748;
		public ActivityInfo(android.content.pm.ActivityInfo arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.pm.ActivityInfo.staticClass, global::android.content.pm.ActivityInfo._ActivityInfo1748, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.FieldId _theme1749;
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
		internal static global::net.sf.jni4net.jni.FieldId _launchMode1750;
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
		internal static global::net.sf.jni4net.jni.FieldId _permission1751;
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
		internal static global::net.sf.jni4net.jni.FieldId _taskAffinity1752;
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
		internal static global::net.sf.jni4net.jni.FieldId _targetActivity1753;
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
		internal static global::net.sf.jni4net.jni.FieldId _flags1754;
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
		internal static global::net.sf.jni4net.jni.FieldId _screenOrientation1755;
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
		internal static global::net.sf.jni4net.jni.FieldId _configChanges1756;
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
		internal static global::net.sf.jni4net.jni.FieldId _softInputMode1757;
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
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1758;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.pm.ActivityInfo.staticClass = @__class;
			global::android.content.pm.ActivityInfo._toString1742 = @__env.GetMethodID(global::android.content.pm.ActivityInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.pm.ActivityInfo._dump1743 = @__env.GetMethodID(global::android.content.pm.ActivityInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.content.pm.ActivityInfo._writeToParcel1744 = @__env.GetMethodID(global::android.content.pm.ActivityInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.ActivityInfo._describeContents1745 = @__env.GetMethodID(global::android.content.pm.ActivityInfo.staticClass, "describeContents", "()I");
			global::android.content.pm.ActivityInfo._getThemeResource1746 = @__env.GetMethodID(global::android.content.pm.ActivityInfo.staticClass, "getThemeResource", "()I");
			global::android.content.pm.ActivityInfo._ActivityInfo1747 = @__env.GetMethodID(global::android.content.pm.ActivityInfo.staticClass, "<init>", "()V");
			global::android.content.pm.ActivityInfo._ActivityInfo1748 = @__env.GetMethodID(global::android.content.pm.ActivityInfo.staticClass, "<init>", "(Landroid/content/pm/ActivityInfo;)V");
		}
	}
}
