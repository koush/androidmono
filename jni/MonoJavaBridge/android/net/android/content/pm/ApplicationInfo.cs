namespace android.content.pm 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ApplicationInfo : android.content.pm.PackageItemInfo, android.os.Parcelable
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ApplicationInfo() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.pm.ApplicationInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.pm.ApplicationInfo.DisplayNameComparator), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _compare1540; 
			public virtual int compare(android.content.pm.ApplicationInfo arg0, android.content.pm.ApplicationInfo arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.pm.ApplicationInfo.DisplayNameComparator)) 
					return @__env.CallIntMethod(this, _compare1540, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.content.pm.ApplicationInfo.DisplayNameComparator.staticClass, _compare1540, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _compare1541; 
			public virtual int compare(java.lang.Object arg0, java.lang.Object arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.pm.ApplicationInfo.DisplayNameComparator)) 
					return @__env.CallIntMethod(this, _compare1541, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.content.pm.ApplicationInfo.DisplayNameComparator.staticClass, _compare1541, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _DisplayNameComparator1542; 
			public DisplayNameComparator(android.content.pm.PackageManager arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.content.pm.ApplicationInfo.DisplayNameComparator.staticClass, _DisplayNameComparator1542, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.content.pm.ApplicationInfo.DisplayNameComparator.staticClass = @__class; 
				global::android.content.pm.ApplicationInfo.DisplayNameComparator._compare1540 = @__env.GetMethodID(global::android.content.pm.ApplicationInfo.DisplayNameComparator.staticClass, "compare", "(Landroid/content/pm/ApplicationInfo;Landroid/content/pm/ApplicationInfo;)I"); 
				global::android.content.pm.ApplicationInfo.DisplayNameComparator._compare1541 = @__env.GetMethodID(global::android.content.pm.ApplicationInfo.DisplayNameComparator.staticClass, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I"); 
				global::android.content.pm.ApplicationInfo.DisplayNameComparator._DisplayNameComparator1542 = @__env.GetMethodID(global::android.content.pm.ApplicationInfo.DisplayNameComparator.staticClass, "<init>", "(Landroid/content/pm/PackageManager;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString1543; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.ApplicationInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString1543)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.pm.ApplicationInfo.staticClass, _toString1543)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dump1544; 
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.ApplicationInfo)) 
				@__env.CallVoidMethod(this, _dump1544, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.pm.ApplicationInfo.staticClass, _dump1544, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1545; 
		public override void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.ApplicationInfo)) 
				@__env.CallVoidMethod(this, _writeToParcel1545, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.pm.ApplicationInfo.staticClass, _writeToParcel1545, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1546; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.ApplicationInfo)) 
				return @__env.CallIntMethod(this, _describeContents1546); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.pm.ApplicationInfo.staticClass, _describeContents1546); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _loadDescription1547; 
		public virtual java.lang.CharSequence loadDescription(android.content.pm.PackageManager arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.ApplicationInfo)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _loadDescription1547, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.pm.ApplicationInfo.staticClass, _loadDescription1547, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ApplicationInfo1548; 
		public ApplicationInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.pm.ApplicationInfo.staticClass, _ApplicationInfo1548, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ApplicationInfo1549; 
		public ApplicationInfo(android.content.pm.ApplicationInfo arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.pm.ApplicationInfo.staticClass, _ApplicationInfo1549, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _taskAffinity1550; 
		public java.lang.String taskAffinity
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _permission1551; 
		public java.lang.String permission
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _processName1552; 
		public java.lang.String processName
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _className1553; 
		public java.lang.String className
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _descriptionRes1554; 
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
		internal static global::net.sf.jni4net.jni.FieldId _theme1555; 
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
		internal static global::net.sf.jni4net.jni.FieldId _manageSpaceActivityName1556; 
		public java.lang.String manageSpaceActivityName
		{ 
			get 
			{ 
				return default(java.lang.String); 
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
		internal static global::net.sf.jni4net.jni.FieldId _flags1557; 
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
		internal static global::net.sf.jni4net.jni.FieldId _sourceDir1558; 
		public java.lang.String sourceDir
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _publicSourceDir1559; 
		public java.lang.String publicSourceDir
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _sharedLibraryFiles1560; 
		public java.lang.String[] sharedLibraryFiles
		{ 
			get 
			{ 
				return default(java.lang.String[]); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _dataDir1561; 
		public java.lang.String dataDir
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _uid1562; 
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
		internal static global::net.sf.jni4net.jni.FieldId _targetSdkVersion1563; 
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
		internal static global::net.sf.jni4net.jni.FieldId _enabled1564; 
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
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1565; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.pm.ApplicationInfo.staticClass = @__class; 
			global::android.content.pm.ApplicationInfo._toString1543 = @__env.GetMethodID(global::android.content.pm.ApplicationInfo.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.content.pm.ApplicationInfo._dump1544 = @__env.GetMethodID(global::android.content.pm.ApplicationInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V"); 
			global::android.content.pm.ApplicationInfo._writeToParcel1545 = @__env.GetMethodID(global::android.content.pm.ApplicationInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.content.pm.ApplicationInfo._describeContents1546 = @__env.GetMethodID(global::android.content.pm.ApplicationInfo.staticClass, "describeContents", "()I"); 
			global::android.content.pm.ApplicationInfo._loadDescription1547 = @__env.GetMethodID(global::android.content.pm.ApplicationInfo.staticClass, "loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;"); 
			global::android.content.pm.ApplicationInfo._ApplicationInfo1548 = @__env.GetMethodID(global::android.content.pm.ApplicationInfo.staticClass, "<init>", "()V"); 
			global::android.content.pm.ApplicationInfo._ApplicationInfo1549 = @__env.GetMethodID(global::android.content.pm.ApplicationInfo.staticClass, "<init>", "(Landroid/content/pm/ApplicationInfo;)V"); 
		} 
	} 
} 
