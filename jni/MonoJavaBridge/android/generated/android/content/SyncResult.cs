namespace android.content
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class SyncResult : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static SyncResult()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.SyncResult), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.SyncResult(@__env);
			}
		}
		internal SyncResult(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString1701;
		public sealed override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.SyncResult._toString1701));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.SyncResult.staticClass, global::android.content.SyncResult._toString1701));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clear1702;
		public void clear() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.SyncResult._clear1702);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.SyncResult.staticClass, global::android.content.SyncResult._clear1702);
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1703;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.SyncResult._writeToParcel1703, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.SyncResult.staticClass, global::android.content.SyncResult._writeToParcel1703, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1704;
		public int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.SyncResult._describeContents1704);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.SyncResult.staticClass, global::android.content.SyncResult._describeContents1704);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasHardError1705;
		public bool hasHardError() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.SyncResult._hasHardError1705);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.SyncResult.staticClass, global::android.content.SyncResult._hasHardError1705);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasSoftError1706;
		public bool hasSoftError() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.SyncResult._hasSoftError1706);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.SyncResult.staticClass, global::android.content.SyncResult._hasSoftError1706);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasError1707;
		public bool hasError() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.SyncResult._hasError1707);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.SyncResult.staticClass, global::android.content.SyncResult._hasError1707);
		}
		internal static global::net.sf.jni4net.jni.MethodId _madeSomeProgress1708;
		public bool madeSomeProgress() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.SyncResult._madeSomeProgress1708);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.SyncResult.staticClass, global::android.content.SyncResult._madeSomeProgress1708);
		}
		internal static global::net.sf.jni4net.jni.MethodId _toDebugString1709;
		public global::java.lang.String toDebugString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.SyncResult._toDebugString1709));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.SyncResult.staticClass, global::android.content.SyncResult._toDebugString1709));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SyncResult1710;
		public SyncResult()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.SyncResult.staticClass, global::android.content.SyncResult._SyncResult1710, this);
		}
		internal static global::net.sf.jni4net.jni.FieldId _syncAlreadyInProgress1711;
		public bool syncAlreadyInProgress
		{
			get
			{
				return default(bool);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _tooManyDeletions1712;
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
		internal static global::net.sf.jni4net.jni.FieldId _tooManyRetries1713;
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
		internal static global::net.sf.jni4net.jni.FieldId _databaseError1714;
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
		internal static global::net.sf.jni4net.jni.FieldId _fullSyncRequested1715;
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
		internal static global::net.sf.jni4net.jni.FieldId _partialSyncUnavailable1716;
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
		internal static global::net.sf.jni4net.jni.FieldId _moreRecordsToGet1717;
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
		internal static global::net.sf.jni4net.jni.FieldId _delayUntil1718;
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
		internal static global::net.sf.jni4net.jni.FieldId _stats1719;
		public global::android.content.SyncStats stats
		{
			get
			{
				return default(global::android.content.SyncStats);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _ALREADY_IN_PROGRESS1720;
		public static global::android.content.SyncResult ALREADY_IN_PROGRESS
		{
			get
			{
				return default(global::android.content.SyncResult);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1721;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.SyncResult.staticClass = @__class;
			global::android.content.SyncResult._toString1701 = @__env.GetMethodID(global::android.content.SyncResult.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.SyncResult._clear1702 = @__env.GetMethodID(global::android.content.SyncResult.staticClass, "clear", "()V");
			global::android.content.SyncResult._writeToParcel1703 = @__env.GetMethodID(global::android.content.SyncResult.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.SyncResult._describeContents1704 = @__env.GetMethodID(global::android.content.SyncResult.staticClass, "describeContents", "()I");
			global::android.content.SyncResult._hasHardError1705 = @__env.GetMethodID(global::android.content.SyncResult.staticClass, "hasHardError", "()Z");
			global::android.content.SyncResult._hasSoftError1706 = @__env.GetMethodID(global::android.content.SyncResult.staticClass, "hasSoftError", "()Z");
			global::android.content.SyncResult._hasError1707 = @__env.GetMethodID(global::android.content.SyncResult.staticClass, "hasError", "()Z");
			global::android.content.SyncResult._madeSomeProgress1708 = @__env.GetMethodID(global::android.content.SyncResult.staticClass, "madeSomeProgress", "()Z");
			global::android.content.SyncResult._toDebugString1709 = @__env.GetMethodID(global::android.content.SyncResult.staticClass, "toDebugString", "()Ljava/lang/String;");
			global::android.content.SyncResult._SyncResult1710 = @__env.GetMethodID(global::android.content.SyncResult.staticClass, "<init>", "()V");
		}
	}
}
