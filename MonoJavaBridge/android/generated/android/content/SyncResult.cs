namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class SyncResult : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SyncResult(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.SyncResult.staticClass, "toString", "()Ljava/lang/String;", ref global::android.content.SyncResult._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.SyncResult.staticClass, "clear", "()V", ref global::android.content.SyncResult._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.SyncResult.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.SyncResult._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.SyncResult.staticClass, "describeContents", "()I", ref global::android.content.SyncResult._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public bool hasHardError()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.SyncResult.staticClass, "hasHardError", "()Z", ref global::android.content.SyncResult._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public bool hasSoftError()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.SyncResult.staticClass, "hasSoftError", "()Z", ref global::android.content.SyncResult._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public bool hasError()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.SyncResult.staticClass, "hasError", "()Z", ref global::android.content.SyncResult._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public bool madeSomeProgress()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.SyncResult.staticClass, "madeSomeProgress", "()Z", ref global::android.content.SyncResult._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public global::java.lang.String toDebugString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.SyncResult.staticClass, "toDebugString", "()Ljava/lang/String;", ref global::android.content.SyncResult._m8) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public SyncResult() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.SyncResult._m9.native == global::System.IntPtr.Zero)
				global::android.content.SyncResult._m9 = @__env.GetMethodIDNoThrow(global::android.content.SyncResult.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.SyncResult.staticClass, global::android.content.SyncResult._m9);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _syncAlreadyInProgress1885;
		public bool syncAlreadyInProgress
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _syncAlreadyInProgress1885);
			}
		}
		internal static global::MonoJavaBridge.FieldId _tooManyDeletions1886;
		public bool tooManyDeletions
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _tooManyDeletions1886);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _tooManyRetries1887;
		public bool tooManyRetries
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _tooManyRetries1887);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _databaseError1888;
		public bool databaseError
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _databaseError1888);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _fullSyncRequested1889;
		public bool fullSyncRequested
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _fullSyncRequested1889);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _partialSyncUnavailable1890;
		public bool partialSyncUnavailable
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _partialSyncUnavailable1890);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _moreRecordsToGet1891;
		public bool moreRecordsToGet
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _moreRecordsToGet1891);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _delayUntil1892;
		public long delayUntil
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _delayUntil1892);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _stats1893;
		public global::android.content.SyncStats stats
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _stats1893)) as android.content.SyncStats;
			}
		}
		internal static global::MonoJavaBridge.FieldId _ALREADY_IN_PROGRESS1894;
		public static global::android.content.SyncResult ALREADY_IN_PROGRESS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.SyncResult>(@__env.GetStaticObjectField(global::android.content.SyncResult.staticClass, _ALREADY_IN_PROGRESS1894)) as android.content.SyncResult;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1895;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.SyncResult.staticClass, _CREATOR1895)) as android.os.Parcelable_Creator;
			}
		}
		static SyncResult()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.SyncResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/SyncResult"));
			global::android.content.SyncResult._syncAlreadyInProgress1885 = @__env.GetFieldIDNoThrow(global::android.content.SyncResult.staticClass, "syncAlreadyInProgress", "Z");
			global::android.content.SyncResult._tooManyDeletions1886 = @__env.GetFieldIDNoThrow(global::android.content.SyncResult.staticClass, "tooManyDeletions", "Z");
			global::android.content.SyncResult._tooManyRetries1887 = @__env.GetFieldIDNoThrow(global::android.content.SyncResult.staticClass, "tooManyRetries", "Z");
			global::android.content.SyncResult._databaseError1888 = @__env.GetFieldIDNoThrow(global::android.content.SyncResult.staticClass, "databaseError", "Z");
			global::android.content.SyncResult._fullSyncRequested1889 = @__env.GetFieldIDNoThrow(global::android.content.SyncResult.staticClass, "fullSyncRequested", "Z");
			global::android.content.SyncResult._partialSyncUnavailable1890 = @__env.GetFieldIDNoThrow(global::android.content.SyncResult.staticClass, "partialSyncUnavailable", "Z");
			global::android.content.SyncResult._moreRecordsToGet1891 = @__env.GetFieldIDNoThrow(global::android.content.SyncResult.staticClass, "moreRecordsToGet", "Z");
			global::android.content.SyncResult._delayUntil1892 = @__env.GetFieldIDNoThrow(global::android.content.SyncResult.staticClass, "delayUntil", "J");
			global::android.content.SyncResult._stats1893 = @__env.GetFieldIDNoThrow(global::android.content.SyncResult.staticClass, "stats", "Landroid/content/SyncStats;");
			global::android.content.SyncResult._ALREADY_IN_PROGRESS1894 = @__env.GetStaticFieldIDNoThrow(global::android.content.SyncResult.staticClass, "ALREADY_IN_PROGRESS", "Landroid/content/SyncResult;");
			global::android.content.SyncResult._CREATOR1895 = @__env.GetStaticFieldIDNoThrow(global::android.content.SyncResult.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
