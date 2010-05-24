namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class SyncResult : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static SyncResult() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.SyncResult), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _clear1528; 
		public void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.SyncResult)) 
				@__env.CallVoidMethod(this, _clear1528); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.SyncResult.staticClass, _clear1528); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString1529; 
		public sealed override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.SyncResult)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString1529)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.SyncResult.staticClass, _toString1529)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1530; 
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.SyncResult)) 
				@__env.CallVoidMethod(this, _writeToParcel1530, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.SyncResult.staticClass, _writeToParcel1530, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1531; 
		public int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.SyncResult)) 
				return @__env.CallIntMethod(this, _describeContents1531); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.SyncResult.staticClass, _describeContents1531); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasHardError1532; 
		public bool hasHardError() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.SyncResult)) 
				return @__env.CallBooleanMethod(this, _hasHardError1532); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.SyncResult.staticClass, _hasHardError1532); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasSoftError1533; 
		public bool hasSoftError() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.SyncResult)) 
				return @__env.CallBooleanMethod(this, _hasSoftError1533); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.SyncResult.staticClass, _hasSoftError1533); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasError1534; 
		public bool hasError() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.SyncResult)) 
				return @__env.CallBooleanMethod(this, _hasError1534); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.SyncResult.staticClass, _hasError1534); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _madeSomeProgress1535; 
		public bool madeSomeProgress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.SyncResult)) 
				return @__env.CallBooleanMethod(this, _madeSomeProgress1535); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.SyncResult.staticClass, _madeSomeProgress1535); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toDebugString1536; 
		public java.lang.String toDebugString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.SyncResult)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toDebugString1536)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.SyncResult.staticClass, _toDebugString1536)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SyncResult1537; 
		public SyncResult()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.SyncResult.staticClass, _SyncResult1537, this); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _syncAlreadyInProgress1538; 
		public bool syncAlreadyInProgress
		{ 
			get 
			{ 
				return default(bool); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _tooManyDeletions1539; 
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
		internal static global::net.sf.jni4net.jni.FieldId _tooManyRetries1540; 
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
		internal static global::net.sf.jni4net.jni.FieldId _databaseError1541; 
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
		internal static global::net.sf.jni4net.jni.FieldId _fullSyncRequested1542; 
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
		internal static global::net.sf.jni4net.jni.FieldId _partialSyncUnavailable1543; 
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
		internal static global::net.sf.jni4net.jni.FieldId _moreRecordsToGet1544; 
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
		internal static global::net.sf.jni4net.jni.FieldId _stats1545; 
		public android.content.SyncStats stats
		{ 
			get 
			{ 
				return default(android.content.SyncStats); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _ALREADY_IN_PROGRESS1546; 
		public static android.content.SyncResult ALREADY_IN_PROGRESS
		{ 
			get 
			{ 
				return default(android.content.SyncResult); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1547; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.SyncResult.staticClass = @__class; 
			global::android.content.SyncResult._clear1528 = @__env.GetMethodID(global::android.content.SyncResult.staticClass, "clear", "()V"); 
			global::android.content.SyncResult._toString1529 = @__env.GetMethodID(global::android.content.SyncResult.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.content.SyncResult._writeToParcel1530 = @__env.GetMethodID(global::android.content.SyncResult.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.content.SyncResult._describeContents1531 = @__env.GetMethodID(global::android.content.SyncResult.staticClass, "describeContents", "()I"); 
			global::android.content.SyncResult._hasHardError1532 = @__env.GetMethodID(global::android.content.SyncResult.staticClass, "hasHardError", "()Z"); 
			global::android.content.SyncResult._hasSoftError1533 = @__env.GetMethodID(global::android.content.SyncResult.staticClass, "hasSoftError", "()Z"); 
			global::android.content.SyncResult._hasError1534 = @__env.GetMethodID(global::android.content.SyncResult.staticClass, "hasError", "()Z"); 
			global::android.content.SyncResult._madeSomeProgress1535 = @__env.GetMethodID(global::android.content.SyncResult.staticClass, "madeSomeProgress", "()Z"); 
			global::android.content.SyncResult._toDebugString1536 = @__env.GetMethodID(global::android.content.SyncResult.staticClass, "toDebugString", "()Ljava/lang/String;"); 
			global::android.content.SyncResult._SyncResult1537 = @__env.GetMethodID(global::android.content.SyncResult.staticClass, "<init>", "()V"); 
		} 
	} 
} 
