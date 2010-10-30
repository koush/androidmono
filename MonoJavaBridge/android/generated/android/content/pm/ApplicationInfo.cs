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
			internal static global::MonoJavaBridge.MethodId _compare3642;
			public virtual int compare(android.content.pm.ApplicationInfo arg0, android.content.pm.ApplicationInfo arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.pm.ApplicationInfo.DisplayNameComparator._compare3642.native == global::System.IntPtr.Zero)
					global::android.content.pm.ApplicationInfo.DisplayNameComparator._compare3642 = @__env.GetMethodIDNoThrow(global::android.content.pm.ApplicationInfo.DisplayNameComparator.staticClass, "compare", "(Landroid/content/pm/ApplicationInfo;Landroid/content/pm/ApplicationInfo;)I");
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.ApplicationInfo.DisplayNameComparator.staticClass, global::android.content.pm.ApplicationInfo.DisplayNameComparator._compare3642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _compare3643;
			public virtual int compare(java.lang.Object arg0, java.lang.Object arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.pm.ApplicationInfo.DisplayNameComparator._compare3643.native == global::System.IntPtr.Zero)
					global::android.content.pm.ApplicationInfo.DisplayNameComparator._compare3643 = @__env.GetMethodIDNoThrow(global::android.content.pm.ApplicationInfo.DisplayNameComparator.staticClass, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I");
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.ApplicationInfo.DisplayNameComparator.staticClass, global::android.content.pm.ApplicationInfo.DisplayNameComparator._compare3643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _DisplayNameComparator3644;
			public DisplayNameComparator(android.content.pm.PackageManager arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.pm.ApplicationInfo.DisplayNameComparator._DisplayNameComparator3644.native == global::System.IntPtr.Zero)
					global::android.content.pm.ApplicationInfo.DisplayNameComparator._DisplayNameComparator3644 = @__env.GetMethodIDNoThrow(global::android.content.pm.ApplicationInfo.DisplayNameComparator.staticClass, "<init>", "(Landroid/content/pm/PackageManager;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ApplicationInfo.DisplayNameComparator.staticClass, global::android.content.pm.ApplicationInfo.DisplayNameComparator._DisplayNameComparator3644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _toString3645;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.ApplicationInfo._toString3645.native == global::System.IntPtr.Zero)
				global::android.content.pm.ApplicationInfo._toString3645 = @__env.GetMethodIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.pm.ApplicationInfo.staticClass, global::android.content.pm.ApplicationInfo._toString3645) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _dump3646;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.ApplicationInfo._dump3646.native == global::System.IntPtr.Zero)
				global::android.content.pm.ApplicationInfo._dump3646 = @__env.GetMethodIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.ApplicationInfo.staticClass, global::android.content.pm.ApplicationInfo._dump3646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void dump(global::android.util.PrinterDelegate arg0, java.lang.String arg1)
		{
			dump((global::android.util.PrinterDelegateWrapper)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel3647;
		public override void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.ApplicationInfo._writeToParcel3647.native == global::System.IntPtr.Zero)
				global::android.content.pm.ApplicationInfo._writeToParcel3647 = @__env.GetMethodIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.ApplicationInfo.staticClass, global::android.content.pm.ApplicationInfo._writeToParcel3647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents3648;
		public virtual int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.ApplicationInfo._describeContents3648.native == global::System.IntPtr.Zero)
				global::android.content.pm.ApplicationInfo._describeContents3648 = @__env.GetMethodIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "describeContents", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.ApplicationInfo.staticClass, global::android.content.pm.ApplicationInfo._describeContents3648);
		}
		internal static global::MonoJavaBridge.MethodId _loadDescription3649;
		public virtual global::java.lang.CharSequence loadDescription(android.content.pm.PackageManager arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.ApplicationInfo._loadDescription3649.native == global::System.IntPtr.Zero)
				global::android.content.pm.ApplicationInfo._loadDescription3649 = @__env.GetMethodIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.content.pm.ApplicationInfo.staticClass, global::android.content.pm.ApplicationInfo._loadDescription3649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _ApplicationInfo3650;
		public ApplicationInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.ApplicationInfo._ApplicationInfo3650.native == global::System.IntPtr.Zero)
				global::android.content.pm.ApplicationInfo._ApplicationInfo3650 = @__env.GetMethodIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ApplicationInfo.staticClass, global::android.content.pm.ApplicationInfo._ApplicationInfo3650);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ApplicationInfo3651;
		public ApplicationInfo(android.content.pm.ApplicationInfo arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.ApplicationInfo._ApplicationInfo3651.native == global::System.IntPtr.Zero)
				global::android.content.pm.ApplicationInfo._ApplicationInfo3651 = @__env.GetMethodIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "<init>", "(Landroid/content/pm/ApplicationInfo;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ApplicationInfo.staticClass, global::android.content.pm.ApplicationInfo._ApplicationInfo3651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _taskAffinity3652;
		public global::java.lang.String taskAffinity
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _taskAffinity3652)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _permission3653;
		public global::java.lang.String permission
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _permission3653)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _processName3654;
		public global::java.lang.String processName
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _processName3654)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _className3655;
		public global::java.lang.String className
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _className3655)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _descriptionRes3656;
		public int descriptionRes
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _descriptionRes3656);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _theme3657;
		public int theme
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _theme3657);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _manageSpaceActivityName3658;
		public global::java.lang.String manageSpaceActivityName
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _manageSpaceActivityName3658)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _backupAgentName3659;
		public global::java.lang.String backupAgentName
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _backupAgentName3659)) as java.lang.String;
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
		internal static global::MonoJavaBridge.FieldId _flags3679;
		public int flags
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _flags3679);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _sourceDir3680;
		public global::java.lang.String sourceDir
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _sourceDir3680)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _publicSourceDir3681;
		public global::java.lang.String publicSourceDir
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _publicSourceDir3681)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _sharedLibraryFiles3682;
		public global::java.lang.String[] sharedLibraryFiles
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _sharedLibraryFiles3682)) as java.lang.String[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _dataDir3683;
		public global::java.lang.String dataDir
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _dataDir3683)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _uid3684;
		public int uid
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _uid3684);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _targetSdkVersion3685;
		public int targetSdkVersion
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _targetSdkVersion3685);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _enabled3686;
		public bool enabled
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _enabled3686);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR3687;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.ApplicationInfo.staticClass, _CREATOR3687)) as android.os.Parcelable_Creator;
			}
		}
		static ApplicationInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.ApplicationInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/ApplicationInfo"));
			global::android.content.pm.ApplicationInfo._taskAffinity3652 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "taskAffinity", "Ljava/lang/String;");
			global::android.content.pm.ApplicationInfo._permission3653 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "permission", "Ljava/lang/String;");
			global::android.content.pm.ApplicationInfo._processName3654 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "processName", "Ljava/lang/String;");
			global::android.content.pm.ApplicationInfo._className3655 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "className", "Ljava/lang/String;");
			global::android.content.pm.ApplicationInfo._descriptionRes3656 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "descriptionRes", "I");
			global::android.content.pm.ApplicationInfo._theme3657 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "theme", "I");
			global::android.content.pm.ApplicationInfo._manageSpaceActivityName3658 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "manageSpaceActivityName", "Ljava/lang/String;");
			global::android.content.pm.ApplicationInfo._backupAgentName3659 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "backupAgentName", "Ljava/lang/String;");
			global::android.content.pm.ApplicationInfo._flags3679 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "flags", "I");
			global::android.content.pm.ApplicationInfo._sourceDir3680 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "sourceDir", "Ljava/lang/String;");
			global::android.content.pm.ApplicationInfo._publicSourceDir3681 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "publicSourceDir", "Ljava/lang/String;");
			global::android.content.pm.ApplicationInfo._sharedLibraryFiles3682 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "sharedLibraryFiles", "[Ljava/lang/String;");
			global::android.content.pm.ApplicationInfo._dataDir3683 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "dataDir", "Ljava/lang/String;");
			global::android.content.pm.ApplicationInfo._uid3684 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "uid", "I");
			global::android.content.pm.ApplicationInfo._targetSdkVersion3685 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "targetSdkVersion", "I");
			global::android.content.pm.ApplicationInfo._enabled3686 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "enabled", "Z");
			global::android.content.pm.ApplicationInfo._CREATOR3687 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
