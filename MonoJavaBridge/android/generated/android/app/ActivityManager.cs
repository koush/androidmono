namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ActivityManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ActivityManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class MemoryInfo : java.lang.Object, android.os.Parcelable
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected MemoryInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ActivityManager.MemoryInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.app.ActivityManager.MemoryInfo._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public virtual int describeContents()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.ActivityManager.MemoryInfo.staticClass, "describeContents", "()I", ref global::android.app.ActivityManager.MemoryInfo._m1);
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public virtual void readFromParcel(android.os.Parcel arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ActivityManager.MemoryInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V", ref global::android.app.ActivityManager.MemoryInfo._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public MemoryInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.app.ActivityManager.MemoryInfo._m3.native == global::System.IntPtr.Zero)
					global::android.app.ActivityManager.MemoryInfo._m3 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.MemoryInfo.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ActivityManager.MemoryInfo.staticClass, global::android.app.ActivityManager.MemoryInfo._m3);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _availMem1276;
			public long availMem
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetLongField(this.JvmHandle, _availMem1276);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _threshold1277;
			public long threshold
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetLongField(this.JvmHandle, _threshold1277);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _lowMemory1278;
			public bool lowMemory
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _lowMemory1278);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR1279;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.app.ActivityManager.MemoryInfo.staticClass, _CREATOR1279)) as android.os.Parcelable_Creator;
				}
			}
			static MemoryInfo()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.ActivityManager.MemoryInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/ActivityManager$MemoryInfo"));
				global::android.app.ActivityManager.MemoryInfo._availMem1276 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.MemoryInfo.staticClass, "availMem", "J");
				global::android.app.ActivityManager.MemoryInfo._threshold1277 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.MemoryInfo.staticClass, "threshold", "J");
				global::android.app.ActivityManager.MemoryInfo._lowMemory1278 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.MemoryInfo.staticClass, "lowMemory", "Z");
				global::android.app.ActivityManager.MemoryInfo._CREATOR1279 = @__env.GetStaticFieldIDNoThrow(global::android.app.ActivityManager.MemoryInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class ProcessErrorStateInfo : java.lang.Object, android.os.Parcelable
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected ProcessErrorStateInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.app.ActivityManager.ProcessErrorStateInfo._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public virtual int describeContents()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "describeContents", "()I", ref global::android.app.ActivityManager.ProcessErrorStateInfo._m1);
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public virtual void readFromParcel(android.os.Parcel arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V", ref global::android.app.ActivityManager.ProcessErrorStateInfo._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public ProcessErrorStateInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.app.ActivityManager.ProcessErrorStateInfo._m3.native == global::System.IntPtr.Zero)
					global::android.app.ActivityManager.ProcessErrorStateInfo._m3 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ActivityManager.ProcessErrorStateInfo.staticClass, global::android.app.ActivityManager.ProcessErrorStateInfo._m3);
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
			internal static global::MonoJavaBridge.FieldId _condition1283;
			public int condition
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _condition1283);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _processName1284;
			public global::java.lang.String processName
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _processName1284)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _pid1285;
			public int pid
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _pid1285);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _uid1286;
			public int uid
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _uid1286);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _tag1287;
			public global::java.lang.String tag
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _tag1287)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _shortMsg1288;
			public global::java.lang.String shortMsg
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _shortMsg1288)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _longMsg1289;
			public global::java.lang.String longMsg
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _longMsg1289)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _stackTrace1290;
			public global::java.lang.String stackTrace
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _stackTrace1290)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _crashData1291;
			public byte[] crashData
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.GetObjectField(this.JvmHandle, _crashData1291)) as byte[];
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR1292;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, _CREATOR1292)) as android.os.Parcelable_Creator;
				}
			}
			static ProcessErrorStateInfo()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/ActivityManager$ProcessErrorStateInfo"));
				global::android.app.ActivityManager.ProcessErrorStateInfo._condition1283 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "condition", "I");
				global::android.app.ActivityManager.ProcessErrorStateInfo._processName1284 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "processName", "Ljava/lang/String;");
				global::android.app.ActivityManager.ProcessErrorStateInfo._pid1285 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "pid", "I");
				global::android.app.ActivityManager.ProcessErrorStateInfo._uid1286 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "uid", "I");
				global::android.app.ActivityManager.ProcessErrorStateInfo._tag1287 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "tag", "Ljava/lang/String;");
				global::android.app.ActivityManager.ProcessErrorStateInfo._shortMsg1288 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "shortMsg", "Ljava/lang/String;");
				global::android.app.ActivityManager.ProcessErrorStateInfo._longMsg1289 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "longMsg", "Ljava/lang/String;");
				global::android.app.ActivityManager.ProcessErrorStateInfo._stackTrace1290 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "stackTrace", "Ljava/lang/String;");
				global::android.app.ActivityManager.ProcessErrorStateInfo._crashData1291 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "crashData", "[B");
				global::android.app.ActivityManager.ProcessErrorStateInfo._CREATOR1292 = @__env.GetStaticFieldIDNoThrow(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class RecentTaskInfo : java.lang.Object, android.os.Parcelable
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected RecentTaskInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ActivityManager.RecentTaskInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.app.ActivityManager.RecentTaskInfo._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public virtual int describeContents()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.ActivityManager.RecentTaskInfo.staticClass, "describeContents", "()I", ref global::android.app.ActivityManager.RecentTaskInfo._m1);
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public virtual void readFromParcel(android.os.Parcel arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ActivityManager.RecentTaskInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V", ref global::android.app.ActivityManager.RecentTaskInfo._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public RecentTaskInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.app.ActivityManager.RecentTaskInfo._m3.native == global::System.IntPtr.Zero)
					global::android.app.ActivityManager.RecentTaskInfo._m3 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RecentTaskInfo.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ActivityManager.RecentTaskInfo.staticClass, global::android.app.ActivityManager.RecentTaskInfo._m3);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _id1293;
			public int id
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _id1293);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _baseIntent1294;
			public global::android.content.Intent baseIntent
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _baseIntent1294)) as android.content.Intent;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _origActivity1295;
			public global::android.content.ComponentName origActivity
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ComponentName>(@__env.GetObjectField(this.JvmHandle, _origActivity1295)) as android.content.ComponentName;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR1296;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.app.ActivityManager.RecentTaskInfo.staticClass, _CREATOR1296)) as android.os.Parcelable_Creator;
				}
			}
			static RecentTaskInfo()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.ActivityManager.RecentTaskInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/ActivityManager$RecentTaskInfo"));
				global::android.app.ActivityManager.RecentTaskInfo._id1293 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RecentTaskInfo.staticClass, "id", "I");
				global::android.app.ActivityManager.RecentTaskInfo._baseIntent1294 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RecentTaskInfo.staticClass, "baseIntent", "Landroid/content/Intent;");
				global::android.app.ActivityManager.RecentTaskInfo._origActivity1295 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RecentTaskInfo.staticClass, "origActivity", "Landroid/content/ComponentName;");
				global::android.app.ActivityManager.RecentTaskInfo._CREATOR1296 = @__env.GetStaticFieldIDNoThrow(global::android.app.ActivityManager.RecentTaskInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class RunningAppProcessInfo : java.lang.Object, android.os.Parcelable
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected RunningAppProcessInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.app.ActivityManager.RunningAppProcessInfo._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public virtual int describeContents()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "describeContents", "()I", ref global::android.app.ActivityManager.RunningAppProcessInfo._m1);
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public virtual void readFromParcel(android.os.Parcel arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V", ref global::android.app.ActivityManager.RunningAppProcessInfo._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public RunningAppProcessInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.app.ActivityManager.RunningAppProcessInfo._m3.native == global::System.IntPtr.Zero)
					global::android.app.ActivityManager.RunningAppProcessInfo._m3 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ActivityManager.RunningAppProcessInfo.staticClass, global::android.app.ActivityManager.RunningAppProcessInfo._m3);
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public RunningAppProcessInfo(java.lang.String arg0, int arg1, java.lang.String[] arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.app.ActivityManager.RunningAppProcessInfo._m4.native == global::System.IntPtr.Zero)
					global::android.app.ActivityManager.RunningAppProcessInfo._m4 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "<init>", "(Ljava/lang/String;I[Ljava/lang/String;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ActivityManager.RunningAppProcessInfo.staticClass, global::android.app.ActivityManager.RunningAppProcessInfo._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _processName1297;
			public global::java.lang.String processName
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _processName1297)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _pid1298;
			public int pid
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _pid1298);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _uid1299;
			public int uid
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _uid1299);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _pkgList1300;
			public global::java.lang.String[] pkgList
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _pkgList1300)) as java.lang.String[];
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
			internal static global::MonoJavaBridge.FieldId _importance1306;
			public int importance
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _importance1306);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _lru1307;
			public int lru
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _lru1307);
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
			internal static global::MonoJavaBridge.FieldId _importanceReasonCode1311;
			public int importanceReasonCode
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _importanceReasonCode1311);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _importanceReasonPid1312;
			public int importanceReasonPid
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _importanceReasonPid1312);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _importanceReasonComponent1313;
			public global::android.content.ComponentName importanceReasonComponent
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ComponentName>(@__env.GetObjectField(this.JvmHandle, _importanceReasonComponent1313)) as android.content.ComponentName;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR1314;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, _CREATOR1314)) as android.os.Parcelable_Creator;
				}
			}
			static RunningAppProcessInfo()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.ActivityManager.RunningAppProcessInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/ActivityManager$RunningAppProcessInfo"));
				global::android.app.ActivityManager.RunningAppProcessInfo._processName1297 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "processName", "Ljava/lang/String;");
				global::android.app.ActivityManager.RunningAppProcessInfo._pid1298 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "pid", "I");
				global::android.app.ActivityManager.RunningAppProcessInfo._uid1299 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "uid", "I");
				global::android.app.ActivityManager.RunningAppProcessInfo._pkgList1300 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "pkgList", "[Ljava/lang/String;");
				global::android.app.ActivityManager.RunningAppProcessInfo._importance1306 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "importance", "I");
				global::android.app.ActivityManager.RunningAppProcessInfo._lru1307 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "lru", "I");
				global::android.app.ActivityManager.RunningAppProcessInfo._importanceReasonCode1311 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "importanceReasonCode", "I");
				global::android.app.ActivityManager.RunningAppProcessInfo._importanceReasonPid1312 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "importanceReasonPid", "I");
				global::android.app.ActivityManager.RunningAppProcessInfo._importanceReasonComponent1313 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "importanceReasonComponent", "Landroid/content/ComponentName;");
				global::android.app.ActivityManager.RunningAppProcessInfo._CREATOR1314 = @__env.GetStaticFieldIDNoThrow(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class RunningServiceInfo : java.lang.Object, android.os.Parcelable
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected RunningServiceInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ActivityManager.RunningServiceInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.app.ActivityManager.RunningServiceInfo._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public virtual int describeContents()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.ActivityManager.RunningServiceInfo.staticClass, "describeContents", "()I", ref global::android.app.ActivityManager.RunningServiceInfo._m1);
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public virtual void readFromParcel(android.os.Parcel arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ActivityManager.RunningServiceInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V", ref global::android.app.ActivityManager.RunningServiceInfo._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public RunningServiceInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.app.ActivityManager.RunningServiceInfo._m3.native == global::System.IntPtr.Zero)
					global::android.app.ActivityManager.RunningServiceInfo._m3 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ActivityManager.RunningServiceInfo.staticClass, global::android.app.ActivityManager.RunningServiceInfo._m3);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _service1315;
			public global::android.content.ComponentName service
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ComponentName>(@__env.GetObjectField(this.JvmHandle, _service1315)) as android.content.ComponentName;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _pid1316;
			public int pid
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _pid1316);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _uid1317;
			public int uid
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _uid1317);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _process1318;
			public global::java.lang.String process
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _process1318)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _foreground1319;
			public bool foreground
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _foreground1319);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _activeSince1320;
			public long activeSince
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetLongField(this.JvmHandle, _activeSince1320);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _started1321;
			public bool started
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _started1321);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _clientCount1322;
			public int clientCount
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _clientCount1322);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _crashCount1323;
			public int crashCount
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _crashCount1323);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _lastActivityTime1324;
			public long lastActivityTime
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetLongField(this.JvmHandle, _lastActivityTime1324);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _restarting1325;
			public long restarting
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetLongField(this.JvmHandle, _restarting1325);
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
			internal static global::MonoJavaBridge.FieldId _flags1330;
			public int flags
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _flags1330);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _clientPackage1331;
			public global::java.lang.String clientPackage
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _clientPackage1331)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _clientLabel1332;
			public int clientLabel
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _clientLabel1332);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR1333;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.app.ActivityManager.RunningServiceInfo.staticClass, _CREATOR1333)) as android.os.Parcelable_Creator;
				}
			}
			static RunningServiceInfo()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.ActivityManager.RunningServiceInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/ActivityManager$RunningServiceInfo"));
				global::android.app.ActivityManager.RunningServiceInfo._service1315 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "service", "Landroid/content/ComponentName;");
				global::android.app.ActivityManager.RunningServiceInfo._pid1316 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "pid", "I");
				global::android.app.ActivityManager.RunningServiceInfo._uid1317 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "uid", "I");
				global::android.app.ActivityManager.RunningServiceInfo._process1318 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "process", "Ljava/lang/String;");
				global::android.app.ActivityManager.RunningServiceInfo._foreground1319 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "foreground", "Z");
				global::android.app.ActivityManager.RunningServiceInfo._activeSince1320 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "activeSince", "J");
				global::android.app.ActivityManager.RunningServiceInfo._started1321 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "started", "Z");
				global::android.app.ActivityManager.RunningServiceInfo._clientCount1322 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "clientCount", "I");
				global::android.app.ActivityManager.RunningServiceInfo._crashCount1323 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "crashCount", "I");
				global::android.app.ActivityManager.RunningServiceInfo._lastActivityTime1324 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "lastActivityTime", "J");
				global::android.app.ActivityManager.RunningServiceInfo._restarting1325 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "restarting", "J");
				global::android.app.ActivityManager.RunningServiceInfo._flags1330 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "flags", "I");
				global::android.app.ActivityManager.RunningServiceInfo._clientPackage1331 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "clientPackage", "Ljava/lang/String;");
				global::android.app.ActivityManager.RunningServiceInfo._clientLabel1332 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "clientLabel", "I");
				global::android.app.ActivityManager.RunningServiceInfo._CREATOR1333 = @__env.GetStaticFieldIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class RunningTaskInfo : java.lang.Object, android.os.Parcelable
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected RunningTaskInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ActivityManager.RunningTaskInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.app.ActivityManager.RunningTaskInfo._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public virtual int describeContents()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.ActivityManager.RunningTaskInfo.staticClass, "describeContents", "()I", ref global::android.app.ActivityManager.RunningTaskInfo._m1);
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public virtual void readFromParcel(android.os.Parcel arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ActivityManager.RunningTaskInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V", ref global::android.app.ActivityManager.RunningTaskInfo._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public RunningTaskInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.app.ActivityManager.RunningTaskInfo._m3.native == global::System.IntPtr.Zero)
					global::android.app.ActivityManager.RunningTaskInfo._m3 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RunningTaskInfo.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ActivityManager.RunningTaskInfo.staticClass, global::android.app.ActivityManager.RunningTaskInfo._m3);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _id1334;
			public int id
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _id1334);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _baseActivity1335;
			public global::android.content.ComponentName baseActivity
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ComponentName>(@__env.GetObjectField(this.JvmHandle, _baseActivity1335)) as android.content.ComponentName;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _topActivity1336;
			public global::android.content.ComponentName topActivity
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ComponentName>(@__env.GetObjectField(this.JvmHandle, _topActivity1336)) as android.content.ComponentName;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _thumbnail1337;
			public global::android.graphics.Bitmap thumbnail
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.GetObjectField(this.JvmHandle, _thumbnail1337)) as android.graphics.Bitmap;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _description1338;
			public global::java.lang.CharSequence description
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _description1338)) as java.lang.CharSequence;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _numActivities1339;
			public int numActivities
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _numActivities1339);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _numRunning1340;
			public int numRunning
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _numRunning1340);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR1341;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.app.ActivityManager.RunningTaskInfo.staticClass, _CREATOR1341)) as android.os.Parcelable_Creator;
				}
			}
			static RunningTaskInfo()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.ActivityManager.RunningTaskInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/ActivityManager$RunningTaskInfo"));
				global::android.app.ActivityManager.RunningTaskInfo._id1334 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningTaskInfo.staticClass, "id", "I");
				global::android.app.ActivityManager.RunningTaskInfo._baseActivity1335 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningTaskInfo.staticClass, "baseActivity", "Landroid/content/ComponentName;");
				global::android.app.ActivityManager.RunningTaskInfo._topActivity1336 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningTaskInfo.staticClass, "topActivity", "Landroid/content/ComponentName;");
				global::android.app.ActivityManager.RunningTaskInfo._thumbnail1337 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningTaskInfo.staticClass, "thumbnail", "Landroid/graphics/Bitmap;");
				global::android.app.ActivityManager.RunningTaskInfo._description1338 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningTaskInfo.staticClass, "description", "Ljava/lang/CharSequence;");
				global::android.app.ActivityManager.RunningTaskInfo._numActivities1339 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningTaskInfo.staticClass, "numActivities", "I");
				global::android.app.ActivityManager.RunningTaskInfo._numRunning1340 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningTaskInfo.staticClass, "numRunning", "I");
				global::android.app.ActivityManager.RunningTaskInfo._CREATOR1341 = @__env.GetStaticFieldIDNoThrow(global::android.app.ActivityManager.RunningTaskInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
			}
		}
		public new int MemoryClass
		{
			get
			{
				return getMemoryClass();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual int getMemoryClass()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.ActivityManager.staticClass, "getMemoryClass", "()I", ref global::android.app.ActivityManager._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.util.List getRecentTasks(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.app.ActivityManager.staticClass, "getRecentTasks", "(II)Ljava/util/List;", ref global::android.app.ActivityManager._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.util.List getRunningTasks(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.app.ActivityManager.staticClass, "getRunningTasks", "(I)Ljava/util/List;", ref global::android.app.ActivityManager._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.util.List getRunningServices(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.app.ActivityManager.staticClass, "getRunningServices", "(I)Ljava/util/List;", ref global::android.app.ActivityManager._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::android.app.PendingIntent getRunningServiceControlPanel(android.content.ComponentName arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.app.PendingIntent>(this, global::android.app.ActivityManager.staticClass, "getRunningServiceControlPanel", "(Landroid/content/ComponentName;)Landroid/app/PendingIntent;", ref global::android.app.ActivityManager._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.app.PendingIntent;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void getMemoryInfo(android.app.ActivityManager.MemoryInfo arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ActivityManager.staticClass, "getMemoryInfo", "(Landroid/app/ActivityManager$MemoryInfo;)V", ref global::android.app.ActivityManager._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.List ProcessesInErrorState
		{
			get
			{
				return getProcessesInErrorState();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.util.List getProcessesInErrorState()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.app.ActivityManager.staticClass, "getProcessesInErrorState", "()Ljava/util/List;", ref global::android.app.ActivityManager._m6) as java.util.List;
		}
		public new global::java.util.List RunningAppProcesses
		{
			get
			{
				return getRunningAppProcesses();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.util.List getRunningAppProcesses()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.app.ActivityManager.staticClass, "getRunningAppProcesses", "()Ljava/util/List;", ref global::android.app.ActivityManager._m7) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::android.os.Debug.MemoryInfo[] getProcessMemoryInfo(int[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<android.os.Debug.MemoryInfo>(this, global::android.app.ActivityManager.staticClass, "getProcessMemoryInfo", "([I)[Landroid/os/Debug/MemoryInfo;", ref global::android.app.ActivityManager._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.Debug.MemoryInfo[];
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void restartPackage(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ActivityManager.staticClass, "restartPackage", "(Ljava/lang/String;)V", ref global::android.app.ActivityManager._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void killBackgroundProcesses(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ActivityManager.staticClass, "killBackgroundProcesses", "(Ljava/lang/String;)V", ref global::android.app.ActivityManager._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.content.pm.ConfigurationInfo DeviceConfigurationInfo
		{
			get
			{
				return getDeviceConfigurationInfo();
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::android.content.pm.ConfigurationInfo getDeviceConfigurationInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.ActivityManager.staticClass, "getDeviceConfigurationInfo", "()Landroid/content/pm/ConfigurationInfo;", ref global::android.app.ActivityManager._m11) as android.content.pm.ConfigurationInfo;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static bool isUserAMonkey()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.ActivityManager._m12.native == global::System.IntPtr.Zero)
				global::android.app.ActivityManager._m12 = @__env.GetStaticMethodIDNoThrow(global::android.app.ActivityManager.staticClass, "isUserAMonkey", "()Z");
			return @__env.CallStaticBooleanMethod(android.app.ActivityManager.staticClass, global::android.app.ActivityManager._m12);
		}
		public static int RECENT_WITH_EXCLUDED
		{
			get
			{
				return 1;
			}
		}
		static ActivityManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.ActivityManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/ActivityManager"));
		}
	}
}
