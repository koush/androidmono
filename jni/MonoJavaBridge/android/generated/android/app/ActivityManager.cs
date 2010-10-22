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
			internal static global::MonoJavaBridge.MethodId _writeToParcel1551;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityManager.MemoryInfo._writeToParcel1551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityManager.MemoryInfo.staticClass, global::android.app.ActivityManager.MemoryInfo._writeToParcel1551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _describeContents1552;
			public virtual int describeContents() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.app.ActivityManager.MemoryInfo._describeContents1552);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.ActivityManager.MemoryInfo.staticClass, global::android.app.ActivityManager.MemoryInfo._describeContents1552);
			}
			internal static global::MonoJavaBridge.MethodId _readFromParcel1553;
			public virtual void readFromParcel(android.os.Parcel arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityManager.MemoryInfo._readFromParcel1553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityManager.MemoryInfo.staticClass, global::android.app.ActivityManager.MemoryInfo._readFromParcel1553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _MemoryInfo1554;
			public MemoryInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ActivityManager.MemoryInfo.staticClass, global::android.app.ActivityManager.MemoryInfo._MemoryInfo1554);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _availMem1555;
			public long availMem
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetLongField(this.JvmHandle, _availMem1555);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _threshold1556;
			public long threshold
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetLongField(this.JvmHandle, _threshold1556);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _lowMemory1557;
			public bool lowMemory
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _lowMemory1557);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR1558;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.app.ActivityManager.MemoryInfo.staticClass, _CREATOR1558)) as android.os.Parcelable_Creator;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.ActivityManager.MemoryInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/ActivityManager$MemoryInfo"));
				global::android.app.ActivityManager.MemoryInfo._writeToParcel1551 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.MemoryInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
				global::android.app.ActivityManager.MemoryInfo._describeContents1552 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.MemoryInfo.staticClass, "describeContents", "()I");
				global::android.app.ActivityManager.MemoryInfo._readFromParcel1553 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.MemoryInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
				global::android.app.ActivityManager.MemoryInfo._MemoryInfo1554 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.MemoryInfo.staticClass, "<init>", "()V");
				global::android.app.ActivityManager.MemoryInfo._availMem1555 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.MemoryInfo.staticClass, "availMem", "J");
				global::android.app.ActivityManager.MemoryInfo._threshold1556 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.MemoryInfo.staticClass, "threshold", "J");
				global::android.app.ActivityManager.MemoryInfo._lowMemory1557 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.MemoryInfo.staticClass, "lowMemory", "Z");
				global::android.app.ActivityManager.MemoryInfo._CREATOR1558 = @__env.GetStaticFieldIDNoThrow(global::android.app.ActivityManager.MemoryInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
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
			internal static global::MonoJavaBridge.MethodId _writeToParcel1559;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityManager.ProcessErrorStateInfo._writeToParcel1559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, global::android.app.ActivityManager.ProcessErrorStateInfo._writeToParcel1559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _describeContents1560;
			public virtual int describeContents() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.app.ActivityManager.ProcessErrorStateInfo._describeContents1560);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, global::android.app.ActivityManager.ProcessErrorStateInfo._describeContents1560);
			}
			internal static global::MonoJavaBridge.MethodId _readFromParcel1561;
			public virtual void readFromParcel(android.os.Parcel arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityManager.ProcessErrorStateInfo._readFromParcel1561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, global::android.app.ActivityManager.ProcessErrorStateInfo._readFromParcel1561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _ProcessErrorStateInfo1562;
			public ProcessErrorStateInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ActivityManager.ProcessErrorStateInfo.staticClass, global::android.app.ActivityManager.ProcessErrorStateInfo._ProcessErrorStateInfo1562);
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
			internal static global::MonoJavaBridge.FieldId _condition1566;
			public int condition
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _condition1566);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _processName1567;
			public global::java.lang.String processName
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _processName1567)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _pid1568;
			public int pid
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _pid1568);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _uid1569;
			public int uid
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _uid1569);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _tag1570;
			public global::java.lang.String tag
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _tag1570)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _shortMsg1571;
			public global::java.lang.String shortMsg
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _shortMsg1571)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _longMsg1572;
			public global::java.lang.String longMsg
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _longMsg1572)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _stackTrace1573;
			public global::java.lang.String stackTrace
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _stackTrace1573)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _crashData1574;
			public byte[] crashData
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.GetObjectField(this.JvmHandle, _crashData1574)) as byte[];
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR1575;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, _CREATOR1575)) as android.os.Parcelable_Creator;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/ActivityManager$ProcessErrorStateInfo"));
				global::android.app.ActivityManager.ProcessErrorStateInfo._writeToParcel1559 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
				global::android.app.ActivityManager.ProcessErrorStateInfo._describeContents1560 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "describeContents", "()I");
				global::android.app.ActivityManager.ProcessErrorStateInfo._readFromParcel1561 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
				global::android.app.ActivityManager.ProcessErrorStateInfo._ProcessErrorStateInfo1562 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "<init>", "()V");
				global::android.app.ActivityManager.ProcessErrorStateInfo._condition1566 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "condition", "I");
				global::android.app.ActivityManager.ProcessErrorStateInfo._processName1567 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "processName", "Ljava/lang/String;");
				global::android.app.ActivityManager.ProcessErrorStateInfo._pid1568 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "pid", "I");
				global::android.app.ActivityManager.ProcessErrorStateInfo._uid1569 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "uid", "I");
				global::android.app.ActivityManager.ProcessErrorStateInfo._tag1570 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "tag", "Ljava/lang/String;");
				global::android.app.ActivityManager.ProcessErrorStateInfo._shortMsg1571 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "shortMsg", "Ljava/lang/String;");
				global::android.app.ActivityManager.ProcessErrorStateInfo._longMsg1572 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "longMsg", "Ljava/lang/String;");
				global::android.app.ActivityManager.ProcessErrorStateInfo._stackTrace1573 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "stackTrace", "Ljava/lang/String;");
				global::android.app.ActivityManager.ProcessErrorStateInfo._crashData1574 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "crashData", "[B");
				global::android.app.ActivityManager.ProcessErrorStateInfo._CREATOR1575 = @__env.GetStaticFieldIDNoThrow(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
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
			internal static global::MonoJavaBridge.MethodId _writeToParcel1576;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityManager.RecentTaskInfo._writeToParcel1576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityManager.RecentTaskInfo.staticClass, global::android.app.ActivityManager.RecentTaskInfo._writeToParcel1576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _describeContents1577;
			public virtual int describeContents() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.app.ActivityManager.RecentTaskInfo._describeContents1577);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.ActivityManager.RecentTaskInfo.staticClass, global::android.app.ActivityManager.RecentTaskInfo._describeContents1577);
			}
			internal static global::MonoJavaBridge.MethodId _readFromParcel1578;
			public virtual void readFromParcel(android.os.Parcel arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityManager.RecentTaskInfo._readFromParcel1578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityManager.RecentTaskInfo.staticClass, global::android.app.ActivityManager.RecentTaskInfo._readFromParcel1578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _RecentTaskInfo1579;
			public RecentTaskInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ActivityManager.RecentTaskInfo.staticClass, global::android.app.ActivityManager.RecentTaskInfo._RecentTaskInfo1579);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _id1580;
			public int id
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _id1580);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _baseIntent1581;
			public global::android.content.Intent baseIntent
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _baseIntent1581)) as android.content.Intent;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _origActivity1582;
			public global::android.content.ComponentName origActivity
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ComponentName>(@__env.GetObjectField(this.JvmHandle, _origActivity1582)) as android.content.ComponentName;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR1583;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.app.ActivityManager.RecentTaskInfo.staticClass, _CREATOR1583)) as android.os.Parcelable_Creator;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.ActivityManager.RecentTaskInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/ActivityManager$RecentTaskInfo"));
				global::android.app.ActivityManager.RecentTaskInfo._writeToParcel1576 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RecentTaskInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
				global::android.app.ActivityManager.RecentTaskInfo._describeContents1577 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RecentTaskInfo.staticClass, "describeContents", "()I");
				global::android.app.ActivityManager.RecentTaskInfo._readFromParcel1578 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RecentTaskInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
				global::android.app.ActivityManager.RecentTaskInfo._RecentTaskInfo1579 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RecentTaskInfo.staticClass, "<init>", "()V");
				global::android.app.ActivityManager.RecentTaskInfo._id1580 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RecentTaskInfo.staticClass, "id", "I");
				global::android.app.ActivityManager.RecentTaskInfo._baseIntent1581 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RecentTaskInfo.staticClass, "baseIntent", "Landroid/content/Intent;");
				global::android.app.ActivityManager.RecentTaskInfo._origActivity1582 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RecentTaskInfo.staticClass, "origActivity", "Landroid/content/ComponentName;");
				global::android.app.ActivityManager.RecentTaskInfo._CREATOR1583 = @__env.GetStaticFieldIDNoThrow(global::android.app.ActivityManager.RecentTaskInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
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
			internal static global::MonoJavaBridge.MethodId _writeToParcel1584;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityManager.RunningAppProcessInfo._writeToParcel1584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, global::android.app.ActivityManager.RunningAppProcessInfo._writeToParcel1584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _describeContents1585;
			public virtual int describeContents() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.app.ActivityManager.RunningAppProcessInfo._describeContents1585);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, global::android.app.ActivityManager.RunningAppProcessInfo._describeContents1585);
			}
			internal static global::MonoJavaBridge.MethodId _readFromParcel1586;
			public virtual void readFromParcel(android.os.Parcel arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityManager.RunningAppProcessInfo._readFromParcel1586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, global::android.app.ActivityManager.RunningAppProcessInfo._readFromParcel1586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _RunningAppProcessInfo1587;
			public RunningAppProcessInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ActivityManager.RunningAppProcessInfo.staticClass, global::android.app.ActivityManager.RunningAppProcessInfo._RunningAppProcessInfo1587);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _RunningAppProcessInfo1588;
			public RunningAppProcessInfo(java.lang.String arg0, int arg1, java.lang.String[] arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ActivityManager.RunningAppProcessInfo.staticClass, global::android.app.ActivityManager.RunningAppProcessInfo._RunningAppProcessInfo1588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _processName1589;
			public global::java.lang.String processName
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _processName1589)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _pid1590;
			public int pid
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _pid1590);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _uid1591;
			public int uid
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _uid1591);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _pkgList1592;
			public global::java.lang.String[] pkgList
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _pkgList1592)) as java.lang.String[];
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
			internal static global::MonoJavaBridge.FieldId _importance1598;
			public int importance
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _importance1598);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _lru1599;
			public int lru
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _lru1599);
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
			internal static global::MonoJavaBridge.FieldId _importanceReasonCode1603;
			public int importanceReasonCode
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _importanceReasonCode1603);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _importanceReasonPid1604;
			public int importanceReasonPid
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _importanceReasonPid1604);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _importanceReasonComponent1605;
			public global::android.content.ComponentName importanceReasonComponent
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ComponentName>(@__env.GetObjectField(this.JvmHandle, _importanceReasonComponent1605)) as android.content.ComponentName;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR1606;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, _CREATOR1606)) as android.os.Parcelable_Creator;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.ActivityManager.RunningAppProcessInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/ActivityManager$RunningAppProcessInfo"));
				global::android.app.ActivityManager.RunningAppProcessInfo._writeToParcel1584 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
				global::android.app.ActivityManager.RunningAppProcessInfo._describeContents1585 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "describeContents", "()I");
				global::android.app.ActivityManager.RunningAppProcessInfo._readFromParcel1586 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
				global::android.app.ActivityManager.RunningAppProcessInfo._RunningAppProcessInfo1587 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "<init>", "()V");
				global::android.app.ActivityManager.RunningAppProcessInfo._RunningAppProcessInfo1588 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "<init>", "(Ljava/lang/String;I[Ljava/lang/String;)V");
				global::android.app.ActivityManager.RunningAppProcessInfo._processName1589 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "processName", "Ljava/lang/String;");
				global::android.app.ActivityManager.RunningAppProcessInfo._pid1590 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "pid", "I");
				global::android.app.ActivityManager.RunningAppProcessInfo._uid1591 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "uid", "I");
				global::android.app.ActivityManager.RunningAppProcessInfo._pkgList1592 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "pkgList", "[Ljava/lang/String;");
				global::android.app.ActivityManager.RunningAppProcessInfo._importance1598 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "importance", "I");
				global::android.app.ActivityManager.RunningAppProcessInfo._lru1599 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "lru", "I");
				global::android.app.ActivityManager.RunningAppProcessInfo._importanceReasonCode1603 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "importanceReasonCode", "I");
				global::android.app.ActivityManager.RunningAppProcessInfo._importanceReasonPid1604 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "importanceReasonPid", "I");
				global::android.app.ActivityManager.RunningAppProcessInfo._importanceReasonComponent1605 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "importanceReasonComponent", "Landroid/content/ComponentName;");
				global::android.app.ActivityManager.RunningAppProcessInfo._CREATOR1606 = @__env.GetStaticFieldIDNoThrow(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
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
			internal static global::MonoJavaBridge.MethodId _writeToParcel1607;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityManager.RunningServiceInfo._writeToParcel1607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityManager.RunningServiceInfo.staticClass, global::android.app.ActivityManager.RunningServiceInfo._writeToParcel1607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _describeContents1608;
			public virtual int describeContents() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.app.ActivityManager.RunningServiceInfo._describeContents1608);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.ActivityManager.RunningServiceInfo.staticClass, global::android.app.ActivityManager.RunningServiceInfo._describeContents1608);
			}
			internal static global::MonoJavaBridge.MethodId _readFromParcel1609;
			public virtual void readFromParcel(android.os.Parcel arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityManager.RunningServiceInfo._readFromParcel1609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityManager.RunningServiceInfo.staticClass, global::android.app.ActivityManager.RunningServiceInfo._readFromParcel1609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _RunningServiceInfo1610;
			public RunningServiceInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ActivityManager.RunningServiceInfo.staticClass, global::android.app.ActivityManager.RunningServiceInfo._RunningServiceInfo1610);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _service1611;
			public global::android.content.ComponentName service
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ComponentName>(@__env.GetObjectField(this.JvmHandle, _service1611)) as android.content.ComponentName;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _pid1612;
			public int pid
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _pid1612);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _uid1613;
			public int uid
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _uid1613);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _process1614;
			public global::java.lang.String process
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _process1614)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _foreground1615;
			public bool foreground
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _foreground1615);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _activeSince1616;
			public long activeSince
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetLongField(this.JvmHandle, _activeSince1616);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _started1617;
			public bool started
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _started1617);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _clientCount1618;
			public int clientCount
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _clientCount1618);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _crashCount1619;
			public int crashCount
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _crashCount1619);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _lastActivityTime1620;
			public long lastActivityTime
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetLongField(this.JvmHandle, _lastActivityTime1620);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _restarting1621;
			public long restarting
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetLongField(this.JvmHandle, _restarting1621);
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
			internal static global::MonoJavaBridge.FieldId _flags1626;
			public int flags
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _flags1626);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _clientPackage1627;
			public global::java.lang.String clientPackage
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _clientPackage1627)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _clientLabel1628;
			public int clientLabel
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _clientLabel1628);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR1629;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.app.ActivityManager.RunningServiceInfo.staticClass, _CREATOR1629)) as android.os.Parcelable_Creator;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.ActivityManager.RunningServiceInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/ActivityManager$RunningServiceInfo"));
				global::android.app.ActivityManager.RunningServiceInfo._writeToParcel1607 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
				global::android.app.ActivityManager.RunningServiceInfo._describeContents1608 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "describeContents", "()I");
				global::android.app.ActivityManager.RunningServiceInfo._readFromParcel1609 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
				global::android.app.ActivityManager.RunningServiceInfo._RunningServiceInfo1610 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "<init>", "()V");
				global::android.app.ActivityManager.RunningServiceInfo._service1611 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "service", "Landroid/content/ComponentName;");
				global::android.app.ActivityManager.RunningServiceInfo._pid1612 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "pid", "I");
				global::android.app.ActivityManager.RunningServiceInfo._uid1613 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "uid", "I");
				global::android.app.ActivityManager.RunningServiceInfo._process1614 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "process", "Ljava/lang/String;");
				global::android.app.ActivityManager.RunningServiceInfo._foreground1615 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "foreground", "Z");
				global::android.app.ActivityManager.RunningServiceInfo._activeSince1616 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "activeSince", "J");
				global::android.app.ActivityManager.RunningServiceInfo._started1617 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "started", "Z");
				global::android.app.ActivityManager.RunningServiceInfo._clientCount1618 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "clientCount", "I");
				global::android.app.ActivityManager.RunningServiceInfo._crashCount1619 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "crashCount", "I");
				global::android.app.ActivityManager.RunningServiceInfo._lastActivityTime1620 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "lastActivityTime", "J");
				global::android.app.ActivityManager.RunningServiceInfo._restarting1621 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "restarting", "J");
				global::android.app.ActivityManager.RunningServiceInfo._flags1626 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "flags", "I");
				global::android.app.ActivityManager.RunningServiceInfo._clientPackage1627 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "clientPackage", "Ljava/lang/String;");
				global::android.app.ActivityManager.RunningServiceInfo._clientLabel1628 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "clientLabel", "I");
				global::android.app.ActivityManager.RunningServiceInfo._CREATOR1629 = @__env.GetStaticFieldIDNoThrow(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
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
			internal static global::MonoJavaBridge.MethodId _writeToParcel1630;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityManager.RunningTaskInfo._writeToParcel1630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityManager.RunningTaskInfo.staticClass, global::android.app.ActivityManager.RunningTaskInfo._writeToParcel1630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _describeContents1631;
			public virtual int describeContents() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.app.ActivityManager.RunningTaskInfo._describeContents1631);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.ActivityManager.RunningTaskInfo.staticClass, global::android.app.ActivityManager.RunningTaskInfo._describeContents1631);
			}
			internal static global::MonoJavaBridge.MethodId _readFromParcel1632;
			public virtual void readFromParcel(android.os.Parcel arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityManager.RunningTaskInfo._readFromParcel1632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityManager.RunningTaskInfo.staticClass, global::android.app.ActivityManager.RunningTaskInfo._readFromParcel1632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _RunningTaskInfo1633;
			public RunningTaskInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ActivityManager.RunningTaskInfo.staticClass, global::android.app.ActivityManager.RunningTaskInfo._RunningTaskInfo1633);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _id1634;
			public int id
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _id1634);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _baseActivity1635;
			public global::android.content.ComponentName baseActivity
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ComponentName>(@__env.GetObjectField(this.JvmHandle, _baseActivity1635)) as android.content.ComponentName;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _topActivity1636;
			public global::android.content.ComponentName topActivity
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ComponentName>(@__env.GetObjectField(this.JvmHandle, _topActivity1636)) as android.content.ComponentName;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _thumbnail1637;
			public global::android.graphics.Bitmap thumbnail
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.GetObjectField(this.JvmHandle, _thumbnail1637)) as android.graphics.Bitmap;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _description1638;
			public global::java.lang.CharSequence description
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _description1638)) as java.lang.CharSequence;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _numActivities1639;
			public int numActivities
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _numActivities1639);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _numRunning1640;
			public int numRunning
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _numRunning1640);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR1641;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.app.ActivityManager.RunningTaskInfo.staticClass, _CREATOR1641)) as android.os.Parcelable_Creator;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.ActivityManager.RunningTaskInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/ActivityManager$RunningTaskInfo"));
				global::android.app.ActivityManager.RunningTaskInfo._writeToParcel1630 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RunningTaskInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
				global::android.app.ActivityManager.RunningTaskInfo._describeContents1631 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RunningTaskInfo.staticClass, "describeContents", "()I");
				global::android.app.ActivityManager.RunningTaskInfo._readFromParcel1632 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RunningTaskInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
				global::android.app.ActivityManager.RunningTaskInfo._RunningTaskInfo1633 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.RunningTaskInfo.staticClass, "<init>", "()V");
				global::android.app.ActivityManager.RunningTaskInfo._id1634 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningTaskInfo.staticClass, "id", "I");
				global::android.app.ActivityManager.RunningTaskInfo._baseActivity1635 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningTaskInfo.staticClass, "baseActivity", "Landroid/content/ComponentName;");
				global::android.app.ActivityManager.RunningTaskInfo._topActivity1636 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningTaskInfo.staticClass, "topActivity", "Landroid/content/ComponentName;");
				global::android.app.ActivityManager.RunningTaskInfo._thumbnail1637 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningTaskInfo.staticClass, "thumbnail", "Landroid/graphics/Bitmap;");
				global::android.app.ActivityManager.RunningTaskInfo._description1638 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningTaskInfo.staticClass, "description", "Ljava/lang/CharSequence;");
				global::android.app.ActivityManager.RunningTaskInfo._numActivities1639 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningTaskInfo.staticClass, "numActivities", "I");
				global::android.app.ActivityManager.RunningTaskInfo._numRunning1640 = @__env.GetFieldIDNoThrow(global::android.app.ActivityManager.RunningTaskInfo.staticClass, "numRunning", "I");
				global::android.app.ActivityManager.RunningTaskInfo._CREATOR1641 = @__env.GetStaticFieldIDNoThrow(global::android.app.ActivityManager.RunningTaskInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
			}
		}
		public new int MemoryClass
		{
			get
			{
				return getMemoryClass();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMemoryClass1642;
		public virtual int getMemoryClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.ActivityManager._getMemoryClass1642);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getMemoryClass1642);
		}
		internal static global::MonoJavaBridge.MethodId _getRecentTasks1643;
		public virtual global::java.util.List getRecentTasks(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.ActivityManager._getRecentTasks1643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getRecentTasks1643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getRunningTasks1644;
		public virtual global::java.util.List getRunningTasks(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.ActivityManager._getRunningTasks1644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getRunningTasks1644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getRunningServices1645;
		public virtual global::java.util.List getRunningServices(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.ActivityManager._getRunningServices1645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getRunningServices1645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getRunningServiceControlPanel1646;
		public virtual global::android.app.PendingIntent getRunningServiceControlPanel(android.content.ComponentName arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.app.PendingIntent>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.ActivityManager._getRunningServiceControlPanel1646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.PendingIntent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.app.PendingIntent>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getRunningServiceControlPanel1646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.PendingIntent;
		}
		internal static global::MonoJavaBridge.MethodId _getMemoryInfo1647;
		public virtual void getMemoryInfo(android.app.ActivityManager.MemoryInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityManager._getMemoryInfo1647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getMemoryInfo1647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.List ProcessesInErrorState
		{
			get
			{
				return getProcessesInErrorState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProcessesInErrorState1648;
		public virtual global::java.util.List getProcessesInErrorState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.ActivityManager._getProcessesInErrorState1648)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getProcessesInErrorState1648)) as java.util.List;
		}
		public new global::java.util.List RunningAppProcesses
		{
			get
			{
				return getRunningAppProcesses();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRunningAppProcesses1649;
		public virtual global::java.util.List getRunningAppProcesses() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.ActivityManager._getRunningAppProcesses1649)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getRunningAppProcesses1649)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getProcessMemoryInfo1650;
		public virtual global::android.os.Debug.MemoryInfo[] getProcessMemoryInfo(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.os.Debug.MemoryInfo>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.ActivityManager._getProcessMemoryInfo1650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Debug.MemoryInfo[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.os.Debug.MemoryInfo>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getProcessMemoryInfo1650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Debug.MemoryInfo[];
		}
		internal static global::MonoJavaBridge.MethodId _restartPackage1651;
		public virtual void restartPackage(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityManager._restartPackage1651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._restartPackage1651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _killBackgroundProcesses1652;
		public virtual void killBackgroundProcesses(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ActivityManager._killBackgroundProcesses1652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._killBackgroundProcesses1652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.content.pm.ConfigurationInfo DeviceConfigurationInfo
		{
			get
			{
				return getDeviceConfigurationInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeviceConfigurationInfo1653;
		public virtual global::android.content.pm.ConfigurationInfo getDeviceConfigurationInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.ActivityManager._getDeviceConfigurationInfo1653)) as android.content.pm.ConfigurationInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getDeviceConfigurationInfo1653)) as android.content.pm.ConfigurationInfo;
		}
		internal static global::MonoJavaBridge.MethodId _isUserAMonkey1654;
		public static bool isUserAMonkey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.app.ActivityManager.staticClass, global::android.app.ActivityManager._isUserAMonkey1654);
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
			global::android.app.ActivityManager._getMemoryClass1642 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.staticClass, "getMemoryClass", "()I");
			global::android.app.ActivityManager._getRecentTasks1643 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.staticClass, "getRecentTasks", "(II)Ljava/util/List;");
			global::android.app.ActivityManager._getRunningTasks1644 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.staticClass, "getRunningTasks", "(I)Ljava/util/List;");
			global::android.app.ActivityManager._getRunningServices1645 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.staticClass, "getRunningServices", "(I)Ljava/util/List;");
			global::android.app.ActivityManager._getRunningServiceControlPanel1646 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.staticClass, "getRunningServiceControlPanel", "(Landroid/content/ComponentName;)Landroid/app/PendingIntent;");
			global::android.app.ActivityManager._getMemoryInfo1647 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.staticClass, "getMemoryInfo", "(Landroid/app/ActivityManager$MemoryInfo;)V");
			global::android.app.ActivityManager._getProcessesInErrorState1648 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.staticClass, "getProcessesInErrorState", "()Ljava/util/List;");
			global::android.app.ActivityManager._getRunningAppProcesses1649 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.staticClass, "getRunningAppProcesses", "()Ljava/util/List;");
			global::android.app.ActivityManager._getProcessMemoryInfo1650 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.staticClass, "getProcessMemoryInfo", "([I)[Landroid/os/Debug/MemoryInfo;");
			global::android.app.ActivityManager._restartPackage1651 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.staticClass, "restartPackage", "(Ljava/lang/String;)V");
			global::android.app.ActivityManager._killBackgroundProcesses1652 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.staticClass, "killBackgroundProcesses", "(Ljava/lang/String;)V");
			global::android.app.ActivityManager._getDeviceConfigurationInfo1653 = @__env.GetMethodIDNoThrow(global::android.app.ActivityManager.staticClass, "getDeviceConfigurationInfo", "()Landroid/content/pm/ConfigurationInfo;");
			global::android.app.ActivityManager._isUserAMonkey1654 = @__env.GetStaticMethodIDNoThrow(global::android.app.ActivityManager.staticClass, "isUserAMonkey", "()Z");
		}
	}
}
