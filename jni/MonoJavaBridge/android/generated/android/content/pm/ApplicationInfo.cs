namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ApplicationInfo : android.content.pm.PackageItemInfo, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ApplicationInfo()
		{
			InitJNI();
		}
		protected ApplicationInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public new partial class DisplayNameComparator : java.lang.Object, java.util.Comparator
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static DisplayNameComparator()
			{
				InitJNI();
			}
			protected DisplayNameComparator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _compare3625;
			public virtual int compare(android.content.pm.ApplicationInfo arg0, android.content.pm.ApplicationInfo arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.ApplicationInfo.DisplayNameComparator._compare3625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.ApplicationInfo.DisplayNameComparator.staticClass, global::android.content.pm.ApplicationInfo.DisplayNameComparator._compare3625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _compare3626;
			public virtual int compare(java.lang.Object arg0, java.lang.Object arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.ApplicationInfo.DisplayNameComparator._compare3626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.ApplicationInfo.DisplayNameComparator.staticClass, global::android.content.pm.ApplicationInfo.DisplayNameComparator._compare3626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _DisplayNameComparator3627;
			public DisplayNameComparator(android.content.pm.PackageManager arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ApplicationInfo.DisplayNameComparator.staticClass, global::android.content.pm.ApplicationInfo.DisplayNameComparator._DisplayNameComparator3627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.pm.ApplicationInfo.DisplayNameComparator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/ApplicationInfo$DisplayNameComparator"));
				global::android.content.pm.ApplicationInfo.DisplayNameComparator._compare3625 = @__env.GetMethodIDNoThrow(global::android.content.pm.ApplicationInfo.DisplayNameComparator.staticClass, "compare", "(Landroid/content/pm/ApplicationInfo;Landroid/content/pm/ApplicationInfo;)I");
				global::android.content.pm.ApplicationInfo.DisplayNameComparator._compare3626 = @__env.GetMethodIDNoThrow(global::android.content.pm.ApplicationInfo.DisplayNameComparator.staticClass, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I");
				global::android.content.pm.ApplicationInfo.DisplayNameComparator._DisplayNameComparator3627 = @__env.GetMethodIDNoThrow(global::android.content.pm.ApplicationInfo.DisplayNameComparator.staticClass, "<init>", "(Landroid/content/pm/PackageManager;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString3628;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.ApplicationInfo._toString3628)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.ApplicationInfo.staticClass, global::android.content.pm.ApplicationInfo._toString3628)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _dump3629;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.ApplicationInfo._dump3629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.ApplicationInfo.staticClass, global::android.content.pm.ApplicationInfo._dump3629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel3630;
		public override void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.ApplicationInfo._writeToParcel3630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.ApplicationInfo.staticClass, global::android.content.pm.ApplicationInfo._writeToParcel3630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents3631;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.ApplicationInfo._describeContents3631);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.ApplicationInfo.staticClass, global::android.content.pm.ApplicationInfo._describeContents3631);
		}
		internal static global::MonoJavaBridge.MethodId _loadDescription3632;
		public virtual global::java.lang.CharSequence loadDescription(android.content.pm.PackageManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.ApplicationInfo._loadDescription3632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.ApplicationInfo.staticClass, global::android.content.pm.ApplicationInfo._loadDescription3632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _ApplicationInfo3633;
		public ApplicationInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ApplicationInfo.staticClass, global::android.content.pm.ApplicationInfo._ApplicationInfo3633);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ApplicationInfo3634;
		public ApplicationInfo(android.content.pm.ApplicationInfo arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ApplicationInfo.staticClass, global::android.content.pm.ApplicationInfo._ApplicationInfo3634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _taskAffinity3635;
		public global::java.lang.String taskAffinity
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _taskAffinity3635)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _permission3636;
		public global::java.lang.String permission
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _permission3636)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _processName3637;
		public global::java.lang.String processName
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _processName3637)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _className3638;
		public global::java.lang.String className
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _className3638)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _descriptionRes3639;
		public int descriptionRes
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _descriptionRes3639);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _theme3640;
		public int theme
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _theme3640);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _manageSpaceActivityName3641;
		public global::java.lang.String manageSpaceActivityName
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _manageSpaceActivityName3641)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _backupAgentName3642;
		public global::java.lang.String backupAgentName
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _backupAgentName3642)) as java.lang.String;
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
		internal static global::MonoJavaBridge.FieldId _flags3662;
		public int flags
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _flags3662);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _sourceDir3663;
		public global::java.lang.String sourceDir
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _sourceDir3663)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _publicSourceDir3664;
		public global::java.lang.String publicSourceDir
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _publicSourceDir3664)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _sharedLibraryFiles3665;
		public global::java.lang.String[] sharedLibraryFiles
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _sharedLibraryFiles3665)) as java.lang.String[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _dataDir3666;
		public global::java.lang.String dataDir
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _dataDir3666)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _uid3667;
		public int uid
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _uid3667);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _targetSdkVersion3668;
		public int targetSdkVersion
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _targetSdkVersion3668);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _enabled3669;
		public bool enabled
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _enabled3669);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR3670;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.ApplicationInfo.staticClass, _CREATOR3670)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.ApplicationInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/ApplicationInfo"));
			global::android.content.pm.ApplicationInfo._toString3628 = @__env.GetMethodIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.pm.ApplicationInfo._dump3629 = @__env.GetMethodIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.content.pm.ApplicationInfo._writeToParcel3630 = @__env.GetMethodIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.ApplicationInfo._describeContents3631 = @__env.GetMethodIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "describeContents", "()I");
			global::android.content.pm.ApplicationInfo._loadDescription3632 = @__env.GetMethodIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;");
			global::android.content.pm.ApplicationInfo._ApplicationInfo3633 = @__env.GetMethodIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "<init>", "()V");
			global::android.content.pm.ApplicationInfo._ApplicationInfo3634 = @__env.GetMethodIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "<init>", "(Landroid/content/pm/ApplicationInfo;)V");
			global::android.content.pm.ApplicationInfo._taskAffinity3635 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "taskAffinity", "Ljava/lang/String;");
			global::android.content.pm.ApplicationInfo._permission3636 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "permission", "Ljava/lang/String;");
			global::android.content.pm.ApplicationInfo._processName3637 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "processName", "Ljava/lang/String;");
			global::android.content.pm.ApplicationInfo._className3638 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "className", "Ljava/lang/String;");
			global::android.content.pm.ApplicationInfo._descriptionRes3639 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "descriptionRes", "I");
			global::android.content.pm.ApplicationInfo._theme3640 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "theme", "I");
			global::android.content.pm.ApplicationInfo._manageSpaceActivityName3641 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "manageSpaceActivityName", "Ljava/lang/String;");
			global::android.content.pm.ApplicationInfo._backupAgentName3642 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "backupAgentName", "Ljava/lang/String;");
			global::android.content.pm.ApplicationInfo._flags3662 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "flags", "I");
			global::android.content.pm.ApplicationInfo._sourceDir3663 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "sourceDir", "Ljava/lang/String;");
			global::android.content.pm.ApplicationInfo._publicSourceDir3664 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "publicSourceDir", "Ljava/lang/String;");
			global::android.content.pm.ApplicationInfo._sharedLibraryFiles3665 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "sharedLibraryFiles", "[Ljava/lang/String;");
			global::android.content.pm.ApplicationInfo._dataDir3666 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "dataDir", "Ljava/lang/String;");
			global::android.content.pm.ApplicationInfo._uid3667 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "uid", "I");
			global::android.content.pm.ApplicationInfo._targetSdkVersion3668 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "targetSdkVersion", "I");
			global::android.content.pm.ApplicationInfo._enabled3669 = @__env.GetFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "enabled", "Z");
			global::android.content.pm.ApplicationInfo._CREATOR3670 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.ApplicationInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
