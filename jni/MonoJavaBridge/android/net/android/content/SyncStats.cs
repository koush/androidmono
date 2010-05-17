namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SyncStats : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static SyncStats() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.SyncStats), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.content.SyncStats(@__env); 
			} 
		} 
		protected SyncStats(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear1504; 
		public virtual void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.SyncStats)) 
				@__env.CallVoidMethod(this, _clear1504); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.SyncStats.staticClass, _clear1504); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString1505; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.SyncStats)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString1505)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.SyncStats.staticClass, _toString1505)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1506; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.SyncStats)) 
				@__env.CallVoidMethod(this, _writeToParcel1506, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.SyncStats.staticClass, _writeToParcel1506, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1507; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.SyncStats)) 
				return @__env.CallIntMethod(this, _describeContents1507); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.SyncStats.staticClass, _describeContents1507); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SyncStats1508; 
		public SyncStats()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.SyncStats.staticClass, _SyncStats1508, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SyncStats1509; 
		public SyncStats(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.SyncStats.staticClass, _SyncStats1509, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _numAuthExceptions1510; 
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
		internal static global::net.sf.jni4net.jni.FieldId _numIoExceptions1511; 
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
		internal static global::net.sf.jni4net.jni.FieldId _numParseExceptions1512; 
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
		internal static global::net.sf.jni4net.jni.FieldId _numConflictDetectedExceptions1513; 
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
		internal static global::net.sf.jni4net.jni.FieldId _numInserts1514; 
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
		internal static global::net.sf.jni4net.jni.FieldId _numUpdates1515; 
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
		internal static global::net.sf.jni4net.jni.FieldId _numDeletes1516; 
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
		internal static global::net.sf.jni4net.jni.FieldId _numEntries1517; 
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
		internal static global::net.sf.jni4net.jni.FieldId _numSkippedEntries1518; 
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
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1519; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.SyncStats.staticClass = @__class; 
			global::android.content.SyncStats._clear1504 = @__env.GetMethodID(global::android.content.SyncStats.staticClass, "clear", "()V"); 
			global::android.content.SyncStats._toString1505 = @__env.GetMethodID(global::android.content.SyncStats.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.content.SyncStats._writeToParcel1506 = @__env.GetMethodID(global::android.content.SyncStats.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.content.SyncStats._describeContents1507 = @__env.GetMethodID(global::android.content.SyncStats.staticClass, "describeContents", "()I"); 
			global::android.content.SyncStats._SyncStats1508 = @__env.GetMethodID(global::android.content.SyncStats.staticClass, "<init>", "()V"); 
			global::android.content.SyncStats._SyncStats1509 = @__env.GetMethodID(global::android.content.SyncStats.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
		} 
	} 
} 
