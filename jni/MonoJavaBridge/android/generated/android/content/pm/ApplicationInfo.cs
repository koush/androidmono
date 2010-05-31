namespace android.content.pm
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ApplicationInfo : android.content.pm.PackageItemInfo, android.os.Parcelable
	{
		internal new static global::java.lang.Class staticClass;
		static ApplicationInfo()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.pm.ApplicationInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.pm.ApplicationInfo(@__env);
			}
		}
		protected ApplicationInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public new class DisplayNameComparator : java.lang.Object, java.util.Comparator
		{
			internal static global::java.lang.Class staticClass;
			static DisplayNameComparator()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.pm.ApplicationInfo.DisplayNameComparator), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.content.pm.ApplicationInfo.DisplayNameComparator(@__env);
				}
			}
			protected DisplayNameComparator(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _compare1585;
			public virtual int compare(android.content.pm.ApplicationInfo arg0, android.content.pm.ApplicationInfo arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.content.pm.ApplicationInfo.DisplayNameComparator._compare1585, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.content.pm.ApplicationInfo.DisplayNameComparator.staticClass, global::android.content.pm.ApplicationInfo.DisplayNameComparator._compare1585, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _compare1586;
			public virtual int compare(java.lang.Object arg0, java.lang.Object arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.content.pm.ApplicationInfo.DisplayNameComparator._compare1586, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.content.pm.ApplicationInfo.DisplayNameComparator.staticClass, global::android.content.pm.ApplicationInfo.DisplayNameComparator._compare1586, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _DisplayNameComparator1587;
			public DisplayNameComparator(android.content.pm.PackageManager arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.content.pm.ApplicationInfo.DisplayNameComparator.staticClass, global::android.content.pm.ApplicationInfo.DisplayNameComparator._DisplayNameComparator1587, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.content.pm.ApplicationInfo.DisplayNameComparator.staticClass = @__class;
				global::android.content.pm.ApplicationInfo.DisplayNameComparator._compare1585 = @__env.GetMethodID(global::android.content.pm.ApplicationInfo.DisplayNameComparator.staticClass, "compare", "(Landroid/content/pm/ApplicationInfo;Landroid/content/pm/ApplicationInfo;)I");
				global::android.content.pm.ApplicationInfo.DisplayNameComparator._compare1586 = @__env.GetMethodID(global::android.content.pm.ApplicationInfo.DisplayNameComparator.staticClass, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I");
				global::android.content.pm.ApplicationInfo.DisplayNameComparator._DisplayNameComparator1587 = @__env.GetMethodID(global::android.content.pm.ApplicationInfo.DisplayNameComparator.staticClass, "<init>", "(Landroid/content/pm/PackageManager;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString1588;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.pm.ApplicationInfo._toString1588));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.pm.ApplicationInfo.staticClass, global::android.content.pm.ApplicationInfo._toString1588));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dump1589;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.pm.ApplicationInfo._dump1589, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.pm.ApplicationInfo.staticClass, global::android.content.pm.ApplicationInfo._dump1589, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1590;
		public override void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.pm.ApplicationInfo._writeToParcel1590, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.pm.ApplicationInfo.staticClass, global::android.content.pm.ApplicationInfo._writeToParcel1590, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1591;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.pm.ApplicationInfo._describeContents1591);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.pm.ApplicationInfo.staticClass, global::android.content.pm.ApplicationInfo._describeContents1591);
		}
		internal static global::net.sf.jni4net.jni.MethodId _loadDescription1592;
		public virtual global::java.lang.CharSequence loadDescription(android.content.pm.PackageManager arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.pm.ApplicationInfo._loadDescription1592, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.pm.ApplicationInfo.staticClass, global::android.content.pm.ApplicationInfo._loadDescription1592, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ApplicationInfo1593;
		public ApplicationInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.pm.ApplicationInfo.staticClass, global::android.content.pm.ApplicationInfo._ApplicationInfo1593, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _ApplicationInfo1594;
		public ApplicationInfo(android.content.pm.ApplicationInfo arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.pm.ApplicationInfo.staticClass, global::android.content.pm.ApplicationInfo._ApplicationInfo1594, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.FieldId _taskAffinity1595;
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
		internal static global::net.sf.jni4net.jni.FieldId _permission1596;
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
		internal static global::net.sf.jni4net.jni.FieldId _processName1597;
		public global::java.lang.String processName
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _className1598;
		public global::java.lang.String className
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _descriptionRes1599;
		public int descriptionRes
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _theme1600;
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
		internal static global::net.sf.jni4net.jni.FieldId _manageSpaceActivityName1601;
		public global::java.lang.String manageSpaceActivityName
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		public static int FLAG_SYSTEM
		{
			get
			{
				return 1;
			}
		}
		public static int FLAG_DEBUGGABLE
		{
			get
			{
				return 2;
			}
		}
		public static int FLAG_HAS_CODE
		{
			get
			{
				return 4;
			}
		}
		public static int FLAG_PERSISTENT
		{
			get
			{
				return 8;
			}
		}
		public static int FLAG_FACTORY_TEST
		{
			get
			{
				return 16;
			}
		}
		public static int FLAG_ALLOW_TASK_REPARENTING
		{
			get
			{
				return 32;
			}
		}
		public static int FLAG_ALLOW_CLEAR_USER_DATA
		{
			get
			{
				return 64;
			}
		}
		public static int FLAG_UPDATED_SYSTEM_APP
		{
			get
			{
				return 128;
			}
		}
		public static int FLAG_TEST_ONLY
		{
			get
			{
				return 256;
			}
		}
		public static int FLAG_SUPPORTS_SMALL_SCREENS
		{
			get
			{
				return 512;
			}
		}
		public static int FLAG_SUPPORTS_NORMAL_SCREENS
		{
			get
			{
				return 1024;
			}
		}
		public static int FLAG_SUPPORTS_LARGE_SCREENS
		{
			get
			{
				return 2048;
			}
		}
		public static int FLAG_RESIZEABLE_FOR_SCREENS
		{
			get
			{
				return 4096;
			}
		}
		public static int FLAG_SUPPORTS_SCREEN_DENSITIES
		{
			get
			{
				return 8192;
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _flags1602;
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
		internal static global::net.sf.jni4net.jni.FieldId _sourceDir1603;
		public global::java.lang.String sourceDir
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _publicSourceDir1604;
		public global::java.lang.String publicSourceDir
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _sharedLibraryFiles1605;
		public global::java.lang.String[] sharedLibraryFiles
		{
			get
			{
				return default(global::java.lang.String[]);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _dataDir1606;
		public global::java.lang.String dataDir
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _uid1607;
		public int uid
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _targetSdkVersion1608;
		public int targetSdkVersion
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _enabled1609;
		public bool enabled
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1610;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.pm.ApplicationInfo.staticClass = @__class;
			global::android.content.pm.ApplicationInfo._toString1588 = @__env.GetMethodID(global::android.content.pm.ApplicationInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.pm.ApplicationInfo._dump1589 = @__env.GetMethodID(global::android.content.pm.ApplicationInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.content.pm.ApplicationInfo._writeToParcel1590 = @__env.GetMethodID(global::android.content.pm.ApplicationInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.ApplicationInfo._describeContents1591 = @__env.GetMethodID(global::android.content.pm.ApplicationInfo.staticClass, "describeContents", "()I");
			global::android.content.pm.ApplicationInfo._loadDescription1592 = @__env.GetMethodID(global::android.content.pm.ApplicationInfo.staticClass, "loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;");
			global::android.content.pm.ApplicationInfo._ApplicationInfo1593 = @__env.GetMethodID(global::android.content.pm.ApplicationInfo.staticClass, "<init>", "()V");
			global::android.content.pm.ApplicationInfo._ApplicationInfo1594 = @__env.GetMethodID(global::android.content.pm.ApplicationInfo.staticClass, "<init>", "(Landroid/content/pm/ApplicationInfo;)V");
		}
	}
}
