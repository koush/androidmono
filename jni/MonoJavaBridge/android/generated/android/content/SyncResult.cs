namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class SyncResult : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SyncResult()
		{
			InitJNI();
		}
		internal SyncResult(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString3535;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.SyncResult._toString3535)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.SyncResult.staticClass, global::android.content.SyncResult._toString3535)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clear3536;
		public void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.SyncResult._clear3536);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.SyncResult.staticClass, global::android.content.SyncResult._clear3536);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel3537;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.SyncResult._writeToParcel3537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.SyncResult.staticClass, global::android.content.SyncResult._writeToParcel3537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents3538;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.SyncResult._describeContents3538);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.SyncResult.staticClass, global::android.content.SyncResult._describeContents3538);
		}
		internal static global::MonoJavaBridge.MethodId _hasHardError3539;
		public bool hasHardError() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.SyncResult._hasHardError3539);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.SyncResult.staticClass, global::android.content.SyncResult._hasHardError3539);
		}
		internal static global::MonoJavaBridge.MethodId _hasSoftError3540;
		public bool hasSoftError() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.SyncResult._hasSoftError3540);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.SyncResult.staticClass, global::android.content.SyncResult._hasSoftError3540);
		}
		internal static global::MonoJavaBridge.MethodId _hasError3541;
		public bool hasError() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.SyncResult._hasError3541);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.SyncResult.staticClass, global::android.content.SyncResult._hasError3541);
		}
		internal static global::MonoJavaBridge.MethodId _madeSomeProgress3542;
		public bool madeSomeProgress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.SyncResult._madeSomeProgress3542);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.SyncResult.staticClass, global::android.content.SyncResult._madeSomeProgress3542);
		}
		internal static global::MonoJavaBridge.MethodId _toDebugString3543;
		public global::java.lang.String toDebugString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.SyncResult._toDebugString3543)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.SyncResult.staticClass, global::android.content.SyncResult._toDebugString3543)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _SyncResult3544;
		public SyncResult()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.SyncResult.staticClass, global::android.content.SyncResult._SyncResult3544);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _syncAlreadyInProgress3545;
		public bool syncAlreadyInProgress
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _syncAlreadyInProgress3545);
			}
		}
		internal static global::MonoJavaBridge.FieldId _tooManyDeletions3546;
		public bool tooManyDeletions
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _tooManyDeletions3546);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _tooManyRetries3547;
		public bool tooManyRetries
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _tooManyRetries3547);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _databaseError3548;
		public bool databaseError
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _databaseError3548);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _fullSyncRequested3549;
		public bool fullSyncRequested
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _fullSyncRequested3549);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _partialSyncUnavailable3550;
		public bool partialSyncUnavailable
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _partialSyncUnavailable3550);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _moreRecordsToGet3551;
		public bool moreRecordsToGet
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _moreRecordsToGet3551);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _delayUntil3552;
		public long delayUntil
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _delayUntil3552);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _stats3553;
		public global::android.content.SyncStats stats
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _stats3553)) as android.content.SyncStats;
			}
		}
		internal static global::MonoJavaBridge.FieldId _ALREADY_IN_PROGRESS3554;
		public static global::android.content.SyncResult ALREADY_IN_PROGRESS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.SyncResult>(@__env.GetStaticObjectField(global::android.content.SyncResult.staticClass, _ALREADY_IN_PROGRESS3554)) as android.content.SyncResult;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR3555;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.SyncResult.staticClass, _CREATOR3555)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.SyncResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/SyncResult"));
			global::android.content.SyncResult._toString3535 = @__env.GetMethodIDNoThrow(global::android.content.SyncResult.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.SyncResult._clear3536 = @__env.GetMethodIDNoThrow(global::android.content.SyncResult.staticClass, "clear", "()V");
			global::android.content.SyncResult._writeToParcel3537 = @__env.GetMethodIDNoThrow(global::android.content.SyncResult.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.SyncResult._describeContents3538 = @__env.GetMethodIDNoThrow(global::android.content.SyncResult.staticClass, "describeContents", "()I");
			global::android.content.SyncResult._hasHardError3539 = @__env.GetMethodIDNoThrow(global::android.content.SyncResult.staticClass, "hasHardError", "()Z");
			global::android.content.SyncResult._hasSoftError3540 = @__env.GetMethodIDNoThrow(global::android.content.SyncResult.staticClass, "hasSoftError", "()Z");
			global::android.content.SyncResult._hasError3541 = @__env.GetMethodIDNoThrow(global::android.content.SyncResult.staticClass, "hasError", "()Z");
			global::android.content.SyncResult._madeSomeProgress3542 = @__env.GetMethodIDNoThrow(global::android.content.SyncResult.staticClass, "madeSomeProgress", "()Z");
			global::android.content.SyncResult._toDebugString3543 = @__env.GetMethodIDNoThrow(global::android.content.SyncResult.staticClass, "toDebugString", "()Ljava/lang/String;");
			global::android.content.SyncResult._SyncResult3544 = @__env.GetMethodIDNoThrow(global::android.content.SyncResult.staticClass, "<init>", "()V");
			global::android.content.SyncResult._syncAlreadyInProgress3545 = @__env.GetFieldIDNoThrow(global::android.content.SyncResult.staticClass, "syncAlreadyInProgress", "Z");
			global::android.content.SyncResult._tooManyDeletions3546 = @__env.GetFieldIDNoThrow(global::android.content.SyncResult.staticClass, "tooManyDeletions", "Z");
			global::android.content.SyncResult._tooManyRetries3547 = @__env.GetFieldIDNoThrow(global::android.content.SyncResult.staticClass, "tooManyRetries", "Z");
			global::android.content.SyncResult._databaseError3548 = @__env.GetFieldIDNoThrow(global::android.content.SyncResult.staticClass, "databaseError", "Z");
			global::android.content.SyncResult._fullSyncRequested3549 = @__env.GetFieldIDNoThrow(global::android.content.SyncResult.staticClass, "fullSyncRequested", "Z");
			global::android.content.SyncResult._partialSyncUnavailable3550 = @__env.GetFieldIDNoThrow(global::android.content.SyncResult.staticClass, "partialSyncUnavailable", "Z");
			global::android.content.SyncResult._moreRecordsToGet3551 = @__env.GetFieldIDNoThrow(global::android.content.SyncResult.staticClass, "moreRecordsToGet", "Z");
			global::android.content.SyncResult._delayUntil3552 = @__env.GetFieldIDNoThrow(global::android.content.SyncResult.staticClass, "delayUntil", "J");
			global::android.content.SyncResult._stats3553 = @__env.GetFieldIDNoThrow(global::android.content.SyncResult.staticClass, "stats", "Landroid/content/SyncStats;");
			global::android.content.SyncResult._ALREADY_IN_PROGRESS3554 = @__env.GetStaticFieldIDNoThrow(global::android.content.SyncResult.staticClass, "ALREADY_IN_PROGRESS", "Landroid/content/SyncResult;");
			global::android.content.SyncResult._CREATOR3555 = @__env.GetStaticFieldIDNoThrow(global::android.content.SyncResult.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
