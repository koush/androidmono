namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SyncStats : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SyncStats(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString3572;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.SyncStats.staticClass, global::android.content.SyncStats._toString3572)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clear3573;
		public virtual void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.SyncStats.staticClass, global::android.content.SyncStats._clear3573);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel3574;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.SyncStats.staticClass, global::android.content.SyncStats._writeToParcel3574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents3575;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.SyncStats.staticClass, global::android.content.SyncStats._describeContents3575);
		}
		internal static global::MonoJavaBridge.MethodId _SyncStats3576;
		public SyncStats() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.SyncStats.staticClass, global::android.content.SyncStats._SyncStats3576);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SyncStats3577;
		public SyncStats(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.SyncStats.staticClass, global::android.content.SyncStats._SyncStats3577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _numAuthExceptions3578;
		public long numAuthExceptions
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _numAuthExceptions3578);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _numIoExceptions3579;
		public long numIoExceptions
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _numIoExceptions3579);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _numParseExceptions3580;
		public long numParseExceptions
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _numParseExceptions3580);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _numConflictDetectedExceptions3581;
		public long numConflictDetectedExceptions
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _numConflictDetectedExceptions3581);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _numInserts3582;
		public long numInserts
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _numInserts3582);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _numUpdates3583;
		public long numUpdates
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _numUpdates3583);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _numDeletes3584;
		public long numDeletes
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _numDeletes3584);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _numEntries3585;
		public long numEntries
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _numEntries3585);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _numSkippedEntries3586;
		public long numSkippedEntries
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _numSkippedEntries3586);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR3587;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.SyncStats.staticClass, _CREATOR3587)) as android.os.Parcelable_Creator;
			}
		}
		static SyncStats()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.SyncStats.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/SyncStats"));
			global::android.content.SyncStats._toString3572 = @__env.GetMethodIDNoThrow(global::android.content.SyncStats.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.SyncStats._clear3573 = @__env.GetMethodIDNoThrow(global::android.content.SyncStats.staticClass, "clear", "()V");
			global::android.content.SyncStats._writeToParcel3574 = @__env.GetMethodIDNoThrow(global::android.content.SyncStats.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.SyncStats._describeContents3575 = @__env.GetMethodIDNoThrow(global::android.content.SyncStats.staticClass, "describeContents", "()I");
			global::android.content.SyncStats._SyncStats3576 = @__env.GetMethodIDNoThrow(global::android.content.SyncStats.staticClass, "<init>", "()V");
			global::android.content.SyncStats._SyncStats3577 = @__env.GetMethodIDNoThrow(global::android.content.SyncStats.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::android.content.SyncStats._numAuthExceptions3578 = @__env.GetFieldIDNoThrow(global::android.content.SyncStats.staticClass, "numAuthExceptions", "J");
			global::android.content.SyncStats._numIoExceptions3579 = @__env.GetFieldIDNoThrow(global::android.content.SyncStats.staticClass, "numIoExceptions", "J");
			global::android.content.SyncStats._numParseExceptions3580 = @__env.GetFieldIDNoThrow(global::android.content.SyncStats.staticClass, "numParseExceptions", "J");
			global::android.content.SyncStats._numConflictDetectedExceptions3581 = @__env.GetFieldIDNoThrow(global::android.content.SyncStats.staticClass, "numConflictDetectedExceptions", "J");
			global::android.content.SyncStats._numInserts3582 = @__env.GetFieldIDNoThrow(global::android.content.SyncStats.staticClass, "numInserts", "J");
			global::android.content.SyncStats._numUpdates3583 = @__env.GetFieldIDNoThrow(global::android.content.SyncStats.staticClass, "numUpdates", "J");
			global::android.content.SyncStats._numDeletes3584 = @__env.GetFieldIDNoThrow(global::android.content.SyncStats.staticClass, "numDeletes", "J");
			global::android.content.SyncStats._numEntries3585 = @__env.GetFieldIDNoThrow(global::android.content.SyncStats.staticClass, "numEntries", "J");
			global::android.content.SyncStats._numSkippedEntries3586 = @__env.GetFieldIDNoThrow(global::android.content.SyncStats.staticClass, "numSkippedEntries", "J");
			global::android.content.SyncStats._CREATOR3587 = @__env.GetStaticFieldIDNoThrow(global::android.content.SyncStats.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
