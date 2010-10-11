namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ActivityManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ActivityManager()
		{
			InitJNI();
		}
		protected ActivityManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class MemoryInfo : java.lang.Object, android.os.Parcelable
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static MemoryInfo()
			{
				InitJNI();
			}
			protected MemoryInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _writeToParcel292;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityManager.MemoryInfo._writeToParcel292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityManager.MemoryInfo.staticClass, global::android.app.ActivityManager.MemoryInfo._writeToParcel292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _describeContents293;
			public virtual int describeContents() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.app.ActivityManager.MemoryInfo._describeContents293);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.ActivityManager.MemoryInfo.staticClass, global::android.app.ActivityManager.MemoryInfo._describeContents293);
			}
			internal static global::MonoJavaBridge.MethodId _readFromParcel294;
			public virtual void readFromParcel(android.os.Parcel arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityManager.MemoryInfo._readFromParcel294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityManager.MemoryInfo.staticClass, global::android.app.ActivityManager.MemoryInfo._readFromParcel294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _MemoryInfo295;
			public MemoryInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ActivityManager.MemoryInfo.staticClass, global::android.app.ActivityManager.MemoryInfo._MemoryInfo295);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _availMem296;
			public long availMem
			{
				get
				{
					return default(long);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _threshold297;
			public long threshold
			{
				get
				{
					return default(long);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _lowMemory298;
			public bool lowMemory
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR299;
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
				global::android.app.ActivityManager.MemoryInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/ActivityManager$MemoryInfo"));
				global::android.app.ActivityManager.MemoryInfo._writeToParcel292 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.MemoryInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
				global::android.app.ActivityManager.MemoryInfo._describeContents293 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.MemoryInfo.staticClass, "describeContents", "()I");
				global::android.app.ActivityManager.MemoryInfo._readFromParcel294 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.MemoryInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
				global::android.app.ActivityManager.MemoryInfo._MemoryInfo295 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.MemoryInfo.staticClass, "<init>", "()V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class ProcessErrorStateInfo : java.lang.Object, android.os.Parcelable
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static ProcessErrorStateInfo()
			{
				InitJNI();
			}
			protected ProcessErrorStateInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _writeToParcel300;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityManager.ProcessErrorStateInfo._writeToParcel300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, global::android.app.ActivityManager.ProcessErrorStateInfo._writeToParcel300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _describeContents301;
			public virtual int describeContents() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.app.ActivityManager.ProcessErrorStateInfo._describeContents301);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, global::android.app.ActivityManager.ProcessErrorStateInfo._describeContents301);
			}
			internal static global::MonoJavaBridge.MethodId _readFromParcel302;
			public virtual void readFromParcel(android.os.Parcel arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityManager.ProcessErrorStateInfo._readFromParcel302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, global::android.app.ActivityManager.ProcessErrorStateInfo._readFromParcel302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _ProcessErrorStateInfo303;
			public ProcessErrorStateInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ActivityManager.ProcessErrorStateInfo.staticClass, global::android.app.ActivityManager.ProcessErrorStateInfo._ProcessErrorStateInfo303);
				Init(@__env, handle);
			}
			public static int NO_ERROR
			{
				get
				{
					return 0;
				}
			}
			public static int CRASHED
			{
				get
				{
					return 1;
				}
			}
			public static int NOT_RESPONDING
			{
				get
				{
					return 2;
				}
			}
			internal static global::MonoJavaBridge.FieldId _condition304;
			public int condition
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _processName305;
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
			internal static global::MonoJavaBridge.FieldId _pid306;
			public int pid
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _uid307;
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
			internal static global::MonoJavaBridge.FieldId _tag308;
			public global::java.lang.String tag
			{
				get
				{
					return default(global::java.lang.String);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _shortMsg309;
			public global::java.lang.String shortMsg
			{
				get
				{
					return default(global::java.lang.String);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _longMsg310;
			public global::java.lang.String longMsg
			{
				get
				{
					return default(global::java.lang.String);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _stackTrace311;
			public global::java.lang.String stackTrace
			{
				get
				{
					return default(global::java.lang.String);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _crashData312;
			public byte[] crashData
			{
				get
				{
					return default(byte[]);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR313;
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
				global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/ActivityManager$ProcessErrorStateInfo"));
				global::android.app.ActivityManager.ProcessErrorStateInfo._writeToParcel300 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
				global::android.app.ActivityManager.ProcessErrorStateInfo._describeContents301 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "describeContents", "()I");
				global::android.app.ActivityManager.ProcessErrorStateInfo._readFromParcel302 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
				global::android.app.ActivityManager.ProcessErrorStateInfo._ProcessErrorStateInfo303 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "<init>", "()V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class RecentTaskInfo : java.lang.Object, android.os.Parcelable
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static RecentTaskInfo()
			{
				InitJNI();
			}
			protected RecentTaskInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _writeToParcel314;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityManager.RecentTaskInfo._writeToParcel314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityManager.RecentTaskInfo.staticClass, global::android.app.ActivityManager.RecentTaskInfo._writeToParcel314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _describeContents315;
			public virtual int describeContents() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.app.ActivityManager.RecentTaskInfo._describeContents315);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.ActivityManager.RecentTaskInfo.staticClass, global::android.app.ActivityManager.RecentTaskInfo._describeContents315);
			}
			internal static global::MonoJavaBridge.MethodId _readFromParcel316;
			public virtual void readFromParcel(android.os.Parcel arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityManager.RecentTaskInfo._readFromParcel316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityManager.RecentTaskInfo.staticClass, global::android.app.ActivityManager.RecentTaskInfo._readFromParcel316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _RecentTaskInfo317;
			public RecentTaskInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ActivityManager.RecentTaskInfo.staticClass, global::android.app.ActivityManager.RecentTaskInfo._RecentTaskInfo317);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _id318;
			public int id
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _baseIntent319;
			public global::android.content.Intent baseIntent
			{
				get
				{
					return default(global::android.content.Intent);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _origActivity320;
			public global::android.content.ComponentName origActivity
			{
				get
				{
					return default(global::android.content.ComponentName);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR321;
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
				global::android.app.ActivityManager.RecentTaskInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/ActivityManager$RecentTaskInfo"));
				global::android.app.ActivityManager.RecentTaskInfo._writeToParcel314 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RecentTaskInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
				global::android.app.ActivityManager.RecentTaskInfo._describeContents315 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RecentTaskInfo.staticClass, "describeContents", "()I");
				global::android.app.ActivityManager.RecentTaskInfo._readFromParcel316 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RecentTaskInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
				global::android.app.ActivityManager.RecentTaskInfo._RecentTaskInfo317 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RecentTaskInfo.staticClass, "<init>", "()V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class RunningAppProcessInfo : java.lang.Object, android.os.Parcelable
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static RunningAppProcessInfo()
			{
				InitJNI();
			}
			protected RunningAppProcessInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _writeToParcel322;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityManager.RunningAppProcessInfo._writeToParcel322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, global::android.app.ActivityManager.RunningAppProcessInfo._writeToParcel322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _describeContents323;
			public virtual int describeContents() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.app.ActivityManager.RunningAppProcessInfo._describeContents323);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, global::android.app.ActivityManager.RunningAppProcessInfo._describeContents323);
			}
			internal static global::MonoJavaBridge.MethodId _readFromParcel324;
			public virtual void readFromParcel(android.os.Parcel arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityManager.RunningAppProcessInfo._readFromParcel324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, global::android.app.ActivityManager.RunningAppProcessInfo._readFromParcel324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _RunningAppProcessInfo325;
			public RunningAppProcessInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ActivityManager.RunningAppProcessInfo.staticClass, global::android.app.ActivityManager.RunningAppProcessInfo._RunningAppProcessInfo325);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _RunningAppProcessInfo326;
			public RunningAppProcessInfo(java.lang.String arg0, int arg1, java.lang.String[] arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ActivityManager.RunningAppProcessInfo.staticClass, global::android.app.ActivityManager.RunningAppProcessInfo._RunningAppProcessInfo326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _processName327;
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
			internal static global::MonoJavaBridge.FieldId _pid328;
			public int pid
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _uid329;
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
			internal static global::MonoJavaBridge.FieldId _pkgList330;
			public global::java.lang.String[] pkgList
			{
				get
				{
					return default(global::java.lang.String[]);
				}
				set
				{
				}
			}
			public static int IMPORTANCE_FOREGROUND
			{
				get
				{
					return 100;
				}
			}
			public static int IMPORTANCE_VISIBLE
			{
				get
				{
					return 200;
				}
			}
			public static int IMPORTANCE_SERVICE
			{
				get
				{
					return 300;
				}
			}
			public static int IMPORTANCE_BACKGROUND
			{
				get
				{
					return 400;
				}
			}
			public static int IMPORTANCE_EMPTY
			{
				get
				{
					return 500;
				}
			}
			internal static global::MonoJavaBridge.FieldId _importance331;
			public int importance
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _lru332;
			public int lru
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			public static int REASON_UNKNOWN
			{
				get
				{
					return 0;
				}
			}
			public static int REASON_PROVIDER_IN_USE
			{
				get
				{
					return 1;
				}
			}
			public static int REASON_SERVICE_IN_USE
			{
				get
				{
					return 2;
				}
			}
			internal static global::MonoJavaBridge.FieldId _importanceReasonCode333;
			public int importanceReasonCode
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _importanceReasonPid334;
			public int importanceReasonPid
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _importanceReasonComponent335;
			public global::android.content.ComponentName importanceReasonComponent
			{
				get
				{
					return default(global::android.content.ComponentName);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR336;
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
				global::android.app.ActivityManager.RunningAppProcessInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/ActivityManager$RunningAppProcessInfo"));
				global::android.app.ActivityManager.RunningAppProcessInfo._writeToParcel322 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
				global::android.app.ActivityManager.RunningAppProcessInfo._describeContents323 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "describeContents", "()I");
				global::android.app.ActivityManager.RunningAppProcessInfo._readFromParcel324 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
				global::android.app.ActivityManager.RunningAppProcessInfo._RunningAppProcessInfo325 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "<init>", "()V");
				global::android.app.ActivityManager.RunningAppProcessInfo._RunningAppProcessInfo326 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "<init>", "(Ljava/lang/String;I[Ljava/lang/String;)V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class RunningServiceInfo : java.lang.Object, android.os.Parcelable
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static RunningServiceInfo()
			{
				InitJNI();
			}
			protected RunningServiceInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _writeToParcel337;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityManager.RunningServiceInfo._writeToParcel337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityManager.RunningServiceInfo.staticClass, global::android.app.ActivityManager.RunningServiceInfo._writeToParcel337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _describeContents338;
			public virtual int describeContents() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.app.ActivityManager.RunningServiceInfo._describeContents338);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.ActivityManager.RunningServiceInfo.staticClass, global::android.app.ActivityManager.RunningServiceInfo._describeContents338);
			}
			internal static global::MonoJavaBridge.MethodId _readFromParcel339;
			public virtual void readFromParcel(android.os.Parcel arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityManager.RunningServiceInfo._readFromParcel339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityManager.RunningServiceInfo.staticClass, global::android.app.ActivityManager.RunningServiceInfo._readFromParcel339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _RunningServiceInfo340;
			public RunningServiceInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ActivityManager.RunningServiceInfo.staticClass, global::android.app.ActivityManager.RunningServiceInfo._RunningServiceInfo340);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _service341;
			public global::android.content.ComponentName service
			{
				get
				{
					return default(global::android.content.ComponentName);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _pid342;
			public int pid
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _uid343;
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
			internal static global::MonoJavaBridge.FieldId _process344;
			public global::java.lang.String process
			{
				get
				{
					return default(global::java.lang.String);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _foreground345;
			public bool foreground
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _activeSince346;
			public long activeSince
			{
				get
				{
					return default(long);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _started347;
			public bool started
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _clientCount348;
			public int clientCount
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _crashCount349;
			public int crashCount
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _lastActivityTime350;
			public long lastActivityTime
			{
				get
				{
					return default(long);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _restarting351;
			public long restarting
			{
				get
				{
					return default(long);
				}
				set
				{
				}
			}
			public static int FLAG_STARTED
			{
				get
				{
					return 1;
				}
			}
			public static int FLAG_FOREGROUND
			{
				get
				{
					return 2;
				}
			}
			public static int FLAG_SYSTEM_PROCESS
			{
				get
				{
					return 4;
				}
			}
			public static int FLAG_PERSISTENT_PROCESS
			{
				get
				{
					return 8;
				}
			}
			internal static global::MonoJavaBridge.FieldId _flags352;
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
			internal static global::MonoJavaBridge.FieldId _clientPackage353;
			public global::java.lang.String clientPackage
			{
				get
				{
					return default(global::java.lang.String);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _clientLabel354;
			public int clientLabel
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR355;
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
				global::android.app.ActivityManager.RunningServiceInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/ActivityManager$RunningServiceInfo"));
				global::android.app.ActivityManager.RunningServiceInfo._writeToParcel337 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
				global::android.app.ActivityManager.RunningServiceInfo._describeContents338 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "describeContents", "()I");
				global::android.app.ActivityManager.RunningServiceInfo._readFromParcel339 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
				global::android.app.ActivityManager.RunningServiceInfo._RunningServiceInfo340 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "<init>", "()V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class RunningTaskInfo : java.lang.Object, android.os.Parcelable
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static RunningTaskInfo()
			{
				InitJNI();
			}
			protected RunningTaskInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _writeToParcel356;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityManager.RunningTaskInfo._writeToParcel356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityManager.RunningTaskInfo.staticClass, global::android.app.ActivityManager.RunningTaskInfo._writeToParcel356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _describeContents357;
			public virtual int describeContents() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.app.ActivityManager.RunningTaskInfo._describeContents357);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.ActivityManager.RunningTaskInfo.staticClass, global::android.app.ActivityManager.RunningTaskInfo._describeContents357);
			}
			internal static global::MonoJavaBridge.MethodId _readFromParcel358;
			public virtual void readFromParcel(android.os.Parcel arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityManager.RunningTaskInfo._readFromParcel358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityManager.RunningTaskInfo.staticClass, global::android.app.ActivityManager.RunningTaskInfo._readFromParcel358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _RunningTaskInfo359;
			public RunningTaskInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ActivityManager.RunningTaskInfo.staticClass, global::android.app.ActivityManager.RunningTaskInfo._RunningTaskInfo359);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _id360;
			public int id
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _baseActivity361;
			public global::android.content.ComponentName baseActivity
			{
				get
				{
					return default(global::android.content.ComponentName);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _topActivity362;
			public global::android.content.ComponentName topActivity
			{
				get
				{
					return default(global::android.content.ComponentName);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _thumbnail363;
			public global::android.graphics.Bitmap thumbnail
			{
				get
				{
					return default(global::android.graphics.Bitmap);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _description364;
			public global::java.lang.CharSequence description
			{
				get
				{
					return default(global::java.lang.CharSequence);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _numActivities365;
			public int numActivities
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _numRunning366;
			public int numRunning
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR367;
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
				global::android.app.ActivityManager.RunningTaskInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/ActivityManager$RunningTaskInfo"));
				global::android.app.ActivityManager.RunningTaskInfo._writeToParcel356 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RunningTaskInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
				global::android.app.ActivityManager.RunningTaskInfo._describeContents357 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RunningTaskInfo.staticClass, "describeContents", "()I");
				global::android.app.ActivityManager.RunningTaskInfo._readFromParcel358 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RunningTaskInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
				global::android.app.ActivityManager.RunningTaskInfo._RunningTaskInfo359 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RunningTaskInfo.staticClass, "<init>", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMemoryClass368;
		public virtual int getMemoryClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.ActivityManager._getMemoryClass368);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getMemoryClass368);
		}
		internal static global::MonoJavaBridge.MethodId _getRecentTasks369;
		public virtual global::java.util.List getRecentTasks(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.ActivityManager._getRecentTasks369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getRecentTasks369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getRunningTasks370;
		public virtual global::java.util.List getRunningTasks(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.ActivityManager._getRunningTasks370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getRunningTasks370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getRunningServices371;
		public virtual global::java.util.List getRunningServices(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.ActivityManager._getRunningServices371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getRunningServices371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getRunningServiceControlPanel372;
		public virtual global::android.app.PendingIntent getRunningServiceControlPanel(android.content.ComponentName arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.ActivityManager._getRunningServiceControlPanel372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.PendingIntent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getRunningServiceControlPanel372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.PendingIntent;
		}
		internal static global::MonoJavaBridge.MethodId _getMemoryInfo373;
		public virtual void getMemoryInfo(android.app.ActivityManager.MemoryInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityManager._getMemoryInfo373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getMemoryInfo373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getProcessesInErrorState374;
		public virtual global::java.util.List getProcessesInErrorState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.ActivityManager._getProcessesInErrorState374)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getProcessesInErrorState374)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getRunningAppProcesses375;
		public virtual global::java.util.List getRunningAppProcesses() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.ActivityManager._getRunningAppProcesses375)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getRunningAppProcesses375)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getProcessMemoryInfo376;
		public virtual global::android.os.Debug.MemoryInfo[] getProcessMemoryInfo(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.os.Debug.MemoryInfo>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.ActivityManager._getProcessMemoryInfo376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Debug.MemoryInfo[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.os.Debug.MemoryInfo>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getProcessMemoryInfo376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Debug.MemoryInfo[];
		}
		internal static global::MonoJavaBridge.MethodId _restartPackage377;
		public virtual void restartPackage(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityManager._restartPackage377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._restartPackage377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _killBackgroundProcesses378;
		public virtual void killBackgroundProcesses(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityManager._killBackgroundProcesses378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._killBackgroundProcesses378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDeviceConfigurationInfo379;
		public virtual global::android.content.pm.ConfigurationInfo getDeviceConfigurationInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.ActivityManager._getDeviceConfigurationInfo379)) as android.content.pm.ConfigurationInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getDeviceConfigurationInfo379)) as android.content.pm.ConfigurationInfo;
		}
		internal static global::MonoJavaBridge.MethodId _isUserAMonkey380;
		public static bool isUserAMonkey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.app.ActivityManager.staticClass, global::android.app.ActivityManager._isUserAMonkey380);
		}
		public static int RECENT_WITH_EXCLUDED
		{
			get
			{
				return 1;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.ActivityManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/ActivityManager"));
			global::android.app.ActivityManager._getMemoryClass368 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.staticClass, "getMemoryClass", "()I");
			global::android.app.ActivityManager._getRecentTasks369 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.staticClass, "getRecentTasks", "(II)Ljava/util/List;");
			global::android.app.ActivityManager._getRunningTasks370 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.staticClass, "getRunningTasks", "(I)Ljava/util/List;");
			global::android.app.ActivityManager._getRunningServices371 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.staticClass, "getRunningServices", "(I)Ljava/util/List;");
			global::android.app.ActivityManager._getRunningServiceControlPanel372 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.staticClass, "getRunningServiceControlPanel", "(Landroid/content/ComponentName;)Landroid/app/PendingIntent;");
			global::android.app.ActivityManager._getMemoryInfo373 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.staticClass, "getMemoryInfo", "(Landroid/app/ActivityManager$MemoryInfo;)V");
			global::android.app.ActivityManager._getProcessesInErrorState374 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.staticClass, "getProcessesInErrorState", "()Ljava/util/List;");
			global::android.app.ActivityManager._getRunningAppProcesses375 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.staticClass, "getRunningAppProcesses", "()Ljava/util/List;");
			global::android.app.ActivityManager._getProcessMemoryInfo376 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.staticClass, "getProcessMemoryInfo", "([I)[Landroid/os/Debug/MemoryInfo;");
			global::android.app.ActivityManager._restartPackage377 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.staticClass, "restartPackage", "(Ljava/lang/String;)V");
			global::android.app.ActivityManager._killBackgroundProcesses378 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.staticClass, "killBackgroundProcesses", "(Ljava/lang/String;)V");
			global::android.app.ActivityManager._getDeviceConfigurationInfo379 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.staticClass, "getDeviceConfigurationInfo", "()Landroid/content/pm/ConfigurationInfo;");
			global::android.app.ActivityManager._isUserAMonkey380 = @__env.GetStaticMethodIDNoThrow(global::android.app.ActivityManager.staticClass, "isUserAMonkey", "()Z");
		}
	}
}
