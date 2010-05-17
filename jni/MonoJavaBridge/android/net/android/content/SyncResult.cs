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
		internal static global::net.sf.jni4net.jni.MethodId _clear1484; 
		public void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.SyncResult)) 
				@__env.CallVoidMethod(this, _clear1484); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.SyncResult.staticClass, _clear1484); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString1485; 
		public sealed override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.SyncResult)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString1485)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.SyncResult.staticClass, _toString1485)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1486; 
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.SyncResult)) 
				@__env.CallVoidMethod(this, _writeToParcel1486, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.SyncResult.staticClass, _writeToParcel1486, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1487; 
		public int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.SyncResult)) 
				return @__env.CallIntMethod(this, _describeContents1487); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.SyncResult.staticClass, _describeContents1487); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasHardError1488; 
		public bool hasHardError() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.SyncResult)) 
				return @__env.CallBooleanMethod(this, _hasHardError1488); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.SyncResult.staticClass, _hasHardError1488); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasSoftError1489; 
		public bool hasSoftError() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.SyncResult)) 
				return @__env.CallBooleanMethod(this, _hasSoftError1489); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.SyncResult.staticClass, _hasSoftError1489); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasError1490; 
		public bool hasError() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.SyncResult)) 
				return @__env.CallBooleanMethod(this, _hasError1490); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.SyncResult.staticClass, _hasError1490); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _madeSomeProgress1491; 
		public bool madeSomeProgress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.SyncResult)) 
				return @__env.CallBooleanMethod(this, _madeSomeProgress1491); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.SyncResult.staticClass, _madeSomeProgress1491); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toDebugString1492; 
		public java.lang.String toDebugString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.SyncResult)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toDebugString1492)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.SyncResult.staticClass, _toDebugString1492)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SyncResult1493; 
		public SyncResult()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.SyncResult.staticClass, _SyncResult1493, this); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _syncAlreadyInProgress1494; 
		public bool syncAlreadyInProgress
		{ 
			get 
			{ 
				return default(bool); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _tooManyDeletions1495; 
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
		internal static global::net.sf.jni4net.jni.FieldId _tooManyRetries1496; 
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
		internal static global::net.sf.jni4net.jni.FieldId _databaseError1497; 
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
		internal static global::net.sf.jni4net.jni.FieldId _fullSyncRequested1498; 
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
		internal static global::net.sf.jni4net.jni.FieldId _partialSyncUnavailable1499; 
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
		internal static global::net.sf.jni4net.jni.FieldId _moreRecordsToGet1500; 
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
		internal static global::net.sf.jni4net.jni.FieldId _stats1501; 
		public android.content.SyncStats stats
		{ 
			get 
			{ 
				return default(android.content.SyncStats); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _ALREADY_IN_PROGRESS1502; 
		public static android.content.SyncResult ALREADY_IN_PROGRESS
		{ 
			get 
			{ 
				return default(android.content.SyncResult); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1503; 
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
			global::android.content.SyncResult._clear1484 = @__env.GetMethodID(global::android.content.SyncResult.staticClass, "clear", "()V"); 
			global::android.content.SyncResult._toString1485 = @__env.GetMethodID(global::android.content.SyncResult.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.content.SyncResult._writeToParcel1486 = @__env.GetMethodID(global::android.content.SyncResult.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.content.SyncResult._describeContents1487 = @__env.GetMethodID(global::android.content.SyncResult.staticClass, "describeContents", "()I"); 
			global::android.content.SyncResult._hasHardError1488 = @__env.GetMethodID(global::android.content.SyncResult.staticClass, "hasHardError", "()Z"); 
			global::android.content.SyncResult._hasSoftError1489 = @__env.GetMethodID(global::android.content.SyncResult.staticClass, "hasSoftError", "()Z"); 
			global::android.content.SyncResult._hasError1490 = @__env.GetMethodID(global::android.content.SyncResult.staticClass, "hasError", "()Z"); 
			global::android.content.SyncResult._madeSomeProgress1491 = @__env.GetMethodID(global::android.content.SyncResult.staticClass, "madeSomeProgress", "()Z"); 
			global::android.content.SyncResult._toDebugString1492 = @__env.GetMethodID(global::android.content.SyncResult.staticClass, "toDebugString", "()Ljava/lang/String;"); 
			global::android.content.SyncResult._SyncResult1493 = @__env.GetMethodID(global::android.content.SyncResult.staticClass, "<init>", "()V"); 
		} 
	} 
} 
