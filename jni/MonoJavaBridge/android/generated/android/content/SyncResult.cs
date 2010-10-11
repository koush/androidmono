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
		internal static global::MonoJavaBridge.MethodId _toString1795;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.SyncResult._toString1795)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.SyncResult.staticClass, global::android.content.SyncResult._toString1795)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clear1796;
		public void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.SyncResult._clear1796);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.SyncResult.staticClass, global::android.content.SyncResult._clear1796);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel1797;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.SyncResult._writeToParcel1797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.SyncResult.staticClass, global::android.content.SyncResult._writeToParcel1797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents1798;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.SyncResult._describeContents1798);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.SyncResult.staticClass, global::android.content.SyncResult._describeContents1798);
		}
		internal static global::MonoJavaBridge.MethodId _hasHardError1799;
		public bool hasHardError() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.SyncResult._hasHardError1799);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.SyncResult.staticClass, global::android.content.SyncResult._hasHardError1799);
		}
		internal static global::MonoJavaBridge.MethodId _hasSoftError1800;
		public bool hasSoftError() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.SyncResult._hasSoftError1800);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.SyncResult.staticClass, global::android.content.SyncResult._hasSoftError1800);
		}
		internal static global::MonoJavaBridge.MethodId _hasError1801;
		public bool hasError() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.SyncResult._hasError1801);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.SyncResult.staticClass, global::android.content.SyncResult._hasError1801);
		}
		internal static global::MonoJavaBridge.MethodId _madeSomeProgress1802;
		public bool madeSomeProgress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.SyncResult._madeSomeProgress1802);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.SyncResult.staticClass, global::android.content.SyncResult._madeSomeProgress1802);
		}
		internal static global::MonoJavaBridge.MethodId _toDebugString1803;
		public global::java.lang.String toDebugString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.SyncResult._toDebugString1803)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.SyncResult.staticClass, global::android.content.SyncResult._toDebugString1803)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _SyncResult1804;
		public SyncResult()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.SyncResult.staticClass, global::android.content.SyncResult._SyncResult1804);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _syncAlreadyInProgress1805;
		public bool syncAlreadyInProgress
		{
			get
			{
				return default(bool);
			}
		}
		internal static global::MonoJavaBridge.FieldId _tooManyDeletions1806;
		public bool tooManyDeletions
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _tooManyRetries1807;
		public bool tooManyRetries
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _databaseError1808;
		public bool databaseError
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _fullSyncRequested1809;
		public bool fullSyncRequested
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _partialSyncUnavailable1810;
		public bool partialSyncUnavailable
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _moreRecordsToGet1811;
		public bool moreRecordsToGet
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _delayUntil1812;
		public long delayUntil
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _stats1813;
		public global::android.content.SyncStats stats
		{
			get
			{
				return default(global::android.content.SyncStats);
			}
		}
		internal static global::MonoJavaBridge.FieldId _ALREADY_IN_PROGRESS1814;
		public static global::android.content.SyncResult ALREADY_IN_PROGRESS
		{
			get
			{
				return default(global::android.content.SyncResult);
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1815;
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
			global::android.content.SyncResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/SyncResult"));
			global::android.content.SyncResult._toString1795 = @__env.GetMethodIDNoThrow(global::android.content.SyncResult.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.SyncResult._clear1796 = @__env.GetMethodIDNoThrow(global::android.content.SyncResult.staticClass, "clear", "()V");
			global::android.content.SyncResult._writeToParcel1797 = @__env.GetMethodIDNoThrow(global::android.content.SyncResult.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.SyncResult._describeContents1798 = @__env.GetMethodIDNoThrow(global::android.content.SyncResult.staticClass, "describeContents", "()I");
			global::android.content.SyncResult._hasHardError1799 = @__env.GetMethodIDNoThrow(global::android.content.SyncResult.staticClass, "hasHardError", "()Z");
			global::android.content.SyncResult._hasSoftError1800 = @__env.GetMethodIDNoThrow(global::android.content.SyncResult.staticClass, "hasSoftError", "()Z");
			global::android.content.SyncResult._hasError1801 = @__env.GetMethodIDNoThrow(global::android.content.SyncResult.staticClass, "hasError", "()Z");
			global::android.content.SyncResult._madeSomeProgress1802 = @__env.GetMethodIDNoThrow(global::android.content.SyncResult.staticClass, "madeSomeProgress", "()Z");
			global::android.content.SyncResult._toDebugString1803 = @__env.GetMethodIDNoThrow(global::android.content.SyncResult.staticClass, "toDebugString", "()Ljava/lang/String;");
			global::android.content.SyncResult._SyncResult1804 = @__env.GetMethodIDNoThrow(global::android.content.SyncResult.staticClass, "<init>", "()V");
		}
	}
}
