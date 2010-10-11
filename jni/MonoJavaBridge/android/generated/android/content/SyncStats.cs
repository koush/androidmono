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
		internal static global::MonoJavaBridge.MethodId _toString1816;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.SyncStats._toString1816)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.SyncStats.staticClass, global::android.content.SyncStats._toString1816)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clear1817;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.SyncStats._clear1817);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.SyncStats.staticClass, global::android.content.SyncStats._clear1817);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel1818;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.SyncStats._writeToParcel1818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.SyncStats.staticClass, global::android.content.SyncStats._writeToParcel1818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents1819;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.SyncStats._describeContents1819);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.SyncStats.staticClass, global::android.content.SyncStats._describeContents1819);
		}
		internal static global::MonoJavaBridge.MethodId _SyncStats1820;
		public SyncStats()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.SyncStats.staticClass, global::android.content.SyncStats._SyncStats1820);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SyncStats1821;
		public SyncStats(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.SyncStats.staticClass, global::android.content.SyncStats._SyncStats1821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _numAuthExceptions1822;
		public long numAuthExceptions
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _numIoExceptions1823;
		public long numIoExceptions
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _numParseExceptions1824;
		public long numParseExceptions
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _numConflictDetectedExceptions1825;
		public long numConflictDetectedExceptions
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _numInserts1826;
		public long numInserts
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _numUpdates1827;
		public long numUpdates
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _numDeletes1828;
		public long numDeletes
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _numEntries1829;
		public long numEntries
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _numSkippedEntries1830;
		public long numSkippedEntries
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1831;
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
			global::android.content.SyncStats.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/SyncStats"));
			global::android.content.SyncStats._toString1816 = @__env.GetMethodIDNoThrow(global::android.content.SyncStats.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.SyncStats._clear1817 = @__env.GetMethodIDNoThrow(global::android.content.SyncStats.staticClass, "clear", "()V");
			global::android.content.SyncStats._writeToParcel1818 = @__env.GetMethodIDNoThrow(global::android.content.SyncStats.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.SyncStats._describeContents1819 = @__env.GetMethodIDNoThrow(global::android.content.SyncStats.staticClass, "describeContents", "()I");
			global::android.content.SyncStats._SyncStats1820 = @__env.GetMethodIDNoThrow(global::android.content.SyncStats.staticClass, "<init>", "()V");
			global::android.content.SyncStats._SyncStats1821 = @__env.GetMethodIDNoThrow(global::android.content.SyncStats.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
