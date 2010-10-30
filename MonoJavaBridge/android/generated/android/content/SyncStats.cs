namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SyncStats : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SyncStats(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.SyncStats.staticClass, "toString", "()Ljava/lang/String;", ref global::android.content.SyncStats._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.SyncStats.staticClass, "clear", "()V", ref global::android.content.SyncStats._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.SyncStats.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.SyncStats._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.SyncStats.staticClass, "describeContents", "()I", ref global::android.content.SyncStats._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public SyncStats() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.SyncStats._m4.native == global::System.IntPtr.Zero)
				global::android.content.SyncStats._m4 = @__env.GetMethodIDNoThrow(global::android.content.SyncStats.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.SyncStats.staticClass, global::android.content.SyncStats._m4);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public SyncStats(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.SyncStats._m5.native == global::System.IntPtr.Zero)
				global::android.content.SyncStats._m5 = @__env.GetMethodIDNoThrow(global::android.content.SyncStats.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.SyncStats.staticClass, global::android.content.SyncStats._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _numAuthExceptions1896;
		public long numAuthExceptions
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _numAuthExceptions1896);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _numIoExceptions1897;
		public long numIoExceptions
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _numIoExceptions1897);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _numParseExceptions1898;
		public long numParseExceptions
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _numParseExceptions1898);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _numConflictDetectedExceptions1899;
		public long numConflictDetectedExceptions
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _numConflictDetectedExceptions1899);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _numInserts1900;
		public long numInserts
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _numInserts1900);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _numUpdates1901;
		public long numUpdates
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _numUpdates1901);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _numDeletes1902;
		public long numDeletes
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _numDeletes1902);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _numEntries1903;
		public long numEntries
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _numEntries1903);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _numSkippedEntries1904;
		public long numSkippedEntries
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _numSkippedEntries1904);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1905;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.SyncStats.staticClass, _CREATOR1905)) as android.os.Parcelable_Creator;
			}
		}
		static SyncStats()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.SyncStats.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/SyncStats"));
			global::android.content.SyncStats._numAuthExceptions1896 = @__env.GetFieldIDNoThrow(global::android.content.SyncStats.staticClass, "numAuthExceptions", "J");
			global::android.content.SyncStats._numIoExceptions1897 = @__env.GetFieldIDNoThrow(global::android.content.SyncStats.staticClass, "numIoExceptions", "J");
			global::android.content.SyncStats._numParseExceptions1898 = @__env.GetFieldIDNoThrow(global::android.content.SyncStats.staticClass, "numParseExceptions", "J");
			global::android.content.SyncStats._numConflictDetectedExceptions1899 = @__env.GetFieldIDNoThrow(global::android.content.SyncStats.staticClass, "numConflictDetectedExceptions", "J");
			global::android.content.SyncStats._numInserts1900 = @__env.GetFieldIDNoThrow(global::android.content.SyncStats.staticClass, "numInserts", "J");
			global::android.content.SyncStats._numUpdates1901 = @__env.GetFieldIDNoThrow(global::android.content.SyncStats.staticClass, "numUpdates", "J");
			global::android.content.SyncStats._numDeletes1902 = @__env.GetFieldIDNoThrow(global::android.content.SyncStats.staticClass, "numDeletes", "J");
			global::android.content.SyncStats._numEntries1903 = @__env.GetFieldIDNoThrow(global::android.content.SyncStats.staticClass, "numEntries", "J");
			global::android.content.SyncStats._numSkippedEntries1904 = @__env.GetFieldIDNoThrow(global::android.content.SyncStats.staticClass, "numSkippedEntries", "J");
			global::android.content.SyncStats._CREATOR1905 = @__env.GetStaticFieldIDNoThrow(global::android.content.SyncStats.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
