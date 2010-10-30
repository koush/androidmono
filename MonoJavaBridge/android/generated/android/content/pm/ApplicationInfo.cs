namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ApplicationInfo : android.content.pm.PackageItemInfo, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ApplicationInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public new partial class DisplayNameComparator : java.lang.Object, java.util.Comparator
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected DisplayNameComparator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual int compare(android.content.pm.ApplicationInfo arg0, android.content.pm.ApplicationInfo arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.ApplicationInfo.DisplayNameComparator.staticClass, "compare", "(Landroid/content/pm/ApplicationInfo;Landroid/content/pm/ApplicationInfo;)I", ref global::android.content.pm.ApplicationInfo.DisplayNameComparator._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public virtual int compare(java.lang.Object arg0, java.lang.Object arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.ApplicationInfo.DisplayNameComparator.staticClass, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I", ref global::android.content.pm.ApplicationInfo.DisplayNameComparator._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public DisplayNameComparator(android.content.pm.PackageManager arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.pm.ApplicationInfo.DisplayNameComparator._m2.native == global::System.IntPtr.Zero)
					global::android.content.pm.ApplicationInfo.DisplayNameComparator._m2 = @__env.GetMethodIDNoThrow(global::android.content.pm.ApplicationInfo.DisplayNameComparator.staticClass, "<init>", "(Landroid/content/pm/PackageManager;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ApplicationInfo.DisplayNameComparator.staticClass, global::android.content.pm.ApplicationInfo.DisplayNameComparator._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static DisplayNameComparator()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.pm.ApplicationInfo.DisplayNameComparator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/ApplicationInfo$DisplayNameComparator"));
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.pm.ApplicationInfo.staticClass, "toString", "()Ljava/lang/String;", ref global::android.content.pm.ApplicationInfo._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.ApplicationInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V", ref global::android.content.pm.ApplicationInfo._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void dump(global::android.util.PrinterDelegate arg0, java.lang.String arg1)
		{
			dump((global::android.util.PrinterDelegateWrapper)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.ApplicationInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.pm.ApplicationInfo._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.ApplicationInfo.staticClass, "describeContents", "()I", ref global::android.content.pm.ApplicationInfo._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.CharSequence loadDescription(android.content.pm.PackageManager arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.content.pm.ApplicationInfo.staticClass, "loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", ref global::android.content.pm.ApplicationInfo._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public ApplicationInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.ApplicationInfo._m5.native == global::System.IntPtr.Zero)
				global::android.content.pm.ApplicationInfo._m5 = @__env.GetMethodIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ApplicationInfo.staticClass, global::android.content.pm.ApplicationInfo._m5);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public ApplicationInfo(android.content.pm.ApplicationInfo arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.ApplicationInfo._m6.native == global::System.IntPtr.Zero)
				global::android.content.pm.ApplicationInfo._m6 = @__env.GetMethodIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "<init>", "(Landroid/content/pm/ApplicationInfo;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ApplicationInfo.staticClass, global::android.content.pm.ApplicationInfo._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _taskAffinity1948;
		public global::java.lang.String taskAffinity
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _taskAffinity1948)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _permission1949;
		public global::java.lang.String permission
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _permission1949)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _processName1950;
		public global::java.lang.String processName
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _processName1950)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _className1951;
		public global::java.lang.String className
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _className1951)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _descriptionRes1952;
		public int descriptionRes
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _descriptionRes1952);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _theme1953;
		public int theme
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _theme1953);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _manageSpaceActivityName1954;
		public global::java.lang.String manageSpaceActivityName
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _manageSpaceActivityName1954)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _backupAgentName1955;
		public global::java.lang.String backupAgentName
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _backupAgentName1955)) as java.lang.String;
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
		public static int FLAG_VM_SAFE_MODE
		{
			get
			{
				return 16384;
			}
		}
		public static int FLAG_ALLOW_BACKUP
		{
			get
			{
				return 32768;
			}
		}
		public static int FLAG_KILL_AFTER_RESTORE
		{
			get
			{
				return 65536;
			}
		}
		public static int FLAG_RESTORE_ANY_VERSION
		{
			get
			{
				return 131072;
			}
		}
		public static int FLAG_EXTERNAL_STORAGE
		{
			get
			{
				return 262144;
			}
		}
		internal static global::MonoJavaBridge.FieldId _flags1975;
		public int flags
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _flags1975);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _sourceDir1976;
		public global::java.lang.String sourceDir
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _sourceDir1976)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _publicSourceDir1977;
		public global::java.lang.String publicSourceDir
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _publicSourceDir1977)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _sharedLibraryFiles1978;
		public global::java.lang.String[] sharedLibraryFiles
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _sharedLibraryFiles1978)) as java.lang.String[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _dataDir1979;
		public global::java.lang.String dataDir
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _dataDir1979)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _uid1980;
		public int uid
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _uid1980);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _targetSdkVersion1981;
		public int targetSdkVersion
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _targetSdkVersion1981);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _enabled1982;
		public bool enabled
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _enabled1982);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1983;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.ApplicationInfo.staticClass, _CREATOR1983)) as android.os.Parcelable_Creator;
			}
		}
		static ApplicationInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.ApplicationInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/ApplicationInfo"));
			global::android.content.pm.ApplicationInfo._taskAffinity1948 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "taskAffinity", "Ljava/lang/String;");
			global::android.content.pm.ApplicationInfo._permission1949 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "permission", "Ljava/lang/String;");
			global::android.content.pm.ApplicationInfo._processName1950 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "processName", "Ljava/lang/String;");
			global::android.content.pm.ApplicationInfo._className1951 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "className", "Ljava/lang/String;");
			global::android.content.pm.ApplicationInfo._descriptionRes1952 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "descriptionRes", "I");
			global::android.content.pm.ApplicationInfo._theme1953 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "theme", "I");
			global::android.content.pm.ApplicationInfo._manageSpaceActivityName1954 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "manageSpaceActivityName", "Ljava/lang/String;");
			global::android.content.pm.ApplicationInfo._backupAgentName1955 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "backupAgentName", "Ljava/lang/String;");
			global::android.content.pm.ApplicationInfo._flags1975 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "flags", "I");
			global::android.content.pm.ApplicationInfo._sourceDir1976 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "sourceDir", "Ljava/lang/String;");
			global::android.content.pm.ApplicationInfo._publicSourceDir1977 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "publicSourceDir", "Ljava/lang/String;");
			global::android.content.pm.ApplicationInfo._sharedLibraryFiles1978 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "sharedLibraryFiles", "[Ljava/lang/String;");
			global::android.content.pm.ApplicationInfo._dataDir1979 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "dataDir", "Ljava/lang/String;");
			global::android.content.pm.ApplicationInfo._uid1980 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "uid", "I");
			global::android.content.pm.ApplicationInfo._targetSdkVersion1981 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "targetSdkVersion", "I");
			global::android.content.pm.ApplicationInfo._enabled1982 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "enabled", "Z");
			global::android.content.pm.ApplicationInfo._CREATOR1983 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
