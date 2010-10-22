namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SyncStats : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SyncStats()
		{
			InitJNI();
		}
		protected SyncStats(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString3556;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.SyncStats._toString3556)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.SyncStats.staticClass, global::android.content.SyncStats._toString3556)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clear3557;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.SyncStats._clear3557);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.SyncStats.staticClass, global::android.content.SyncStats._clear3557);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel3558;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.SyncStats._writeToParcel3558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.SyncStats.staticClass, global::android.content.SyncStats._writeToParcel3558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents3559;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.SyncStats._describeContents3559);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.SyncStats.staticClass, global::android.content.SyncStats._describeContents3559);
		}
		internal static global::MonoJavaBridge.MethodId _SyncStats3560;
		public SyncStats()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.SyncStats.staticClass, global::android.content.SyncStats._SyncStats3560);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SyncStats3561;
		public SyncStats(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.SyncStats.staticClass, global::android.content.SyncStats._SyncStats3561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _numAuthExceptions3562;
		public long numAuthExceptions
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _numAuthExceptions3562);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _numIoExceptions3563;
		public long numIoExceptions
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _numIoExceptions3563);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _numParseExceptions3564;
		public long numParseExceptions
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _numParseExceptions3564);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _numConflictDetectedExceptions3565;
		public long numConflictDetectedExceptions
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _numConflictDetectedExceptions3565);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _numInserts3566;
		public long numInserts
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _numInserts3566);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _numUpdates3567;
		public long numUpdates
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _numUpdates3567);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _numDeletes3568;
		public long numDeletes
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _numDeletes3568);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _numEntries3569;
		public long numEntries
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _numEntries3569);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _numSkippedEntries3570;
		public long numSkippedEntries
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _numSkippedEntries3570);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR3571;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.SyncStats.staticClass, _CREATOR3571)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.SyncStats.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/SyncStats"));
			global::android.content.SyncStats._toString3556 = @__env.GetMethodIDNoThrow(global::android.content.SyncStats.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.SyncStats._clear3557 = @__env.GetMethodIDNoThrow(global::android.content.SyncStats.staticClass, "clear", "()V");
			global::android.content.SyncStats._writeToParcel3558 = @__env.GetMethodIDNoThrow(global::android.content.SyncStats.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.SyncStats._describeContents3559 = @__env.GetMethodIDNoThrow(global::android.content.SyncStats.staticClass, "describeContents", "()I");
			global::android.content.SyncStats._SyncStats3560 = @__env.GetMethodIDNoThrow(global::android.content.SyncStats.staticClass, "<init>", "()V");
			global::android.content.SyncStats._SyncStats3561 = @__env.GetMethodIDNoThrow(global::android.content.SyncStats.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::android.content.SyncStats._numAuthExceptions3562 = @__env.GetFieldIDNoThrow(global::android.content.SyncStats.staticClass, "numAuthExceptions", "J");
			global::android.content.SyncStats._numIoExceptions3563 = @__env.GetFieldIDNoThrow(global::android.content.SyncStats.staticClass, "numIoExceptions", "J");
			global::android.content.SyncStats._numParseExceptions3564 = @__env.GetFieldIDNoThrow(global::android.content.SyncStats.staticClass, "numParseExceptions", "J");
			global::android.content.SyncStats._numConflictDetectedExceptions3565 = @__env.GetFieldIDNoThrow(global::android.content.SyncStats.staticClass, "numConflictDetectedExceptions", "J");
			global::android.content.SyncStats._numInserts3566 = @__env.GetFieldIDNoThrow(global::android.content.SyncStats.staticClass, "numInserts", "J");
			global::android.content.SyncStats._numUpdates3567 = @__env.GetFieldIDNoThrow(global::android.content.SyncStats.staticClass, "numUpdates", "J");
			global::android.content.SyncStats._numDeletes3568 = @__env.GetFieldIDNoThrow(global::android.content.SyncStats.staticClass, "numDeletes", "J");
			global::android.content.SyncStats._numEntries3569 = @__env.GetFieldIDNoThrow(global::android.content.SyncStats.staticClass, "numEntries", "J");
			global::android.content.SyncStats._numSkippedEntries3570 = @__env.GetFieldIDNoThrow(global::android.content.SyncStats.staticClass, "numSkippedEntries", "J");
			global::android.content.SyncStats._CREATOR3571 = @__env.GetStaticFieldIDNoThrow(global::android.content.SyncStats.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
