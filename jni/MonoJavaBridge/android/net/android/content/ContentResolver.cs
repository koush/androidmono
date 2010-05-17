namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class ContentResolver : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static ContentResolver() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.ContentResolver), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected ContentResolver(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getType1036; 
		public virtual java.lang.String getType(android.net.Uri arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentResolver)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getType1036, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentResolver.staticClass, _getType1036, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _delete1037; 
		public virtual int delete(android.net.Uri arg0, java.lang.String arg1, java.lang.String[] arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentResolver)) 
				return @__env.CallIntMethod(this, _delete1037, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.ContentResolver.staticClass, _delete1037, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _insert1038; 
		public virtual android.net.Uri insert(android.net.Uri arg0, android.content.ContentValues arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentResolver)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallObjectMethodPtr(this, _insert1038, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentResolver.staticClass, _insert1038, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _query1039; 
		public virtual android.database.Cursor query(android.net.Uri arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentResolver)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallObjectMethodPtr(this, _query1039, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentResolver.staticClass, _query1039, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _update1040; 
		public virtual int update(android.net.Uri arg0, android.content.ContentValues arg1, java.lang.String arg2, java.lang.String[] arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentResolver)) 
				return @__env.CallIntMethod(this, _update1040, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.ContentResolver.staticClass, _update1040, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _openInputStream1041; 
		public virtual java.io.InputStream openInputStream(android.net.Uri arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentResolver)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallObjectMethodPtr(this, _openInputStream1041, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentResolver.staticClass, _openInputStream1041, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _openOutputStream1042; 
		public virtual java.io.OutputStream openOutputStream(android.net.Uri arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentResolver)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.OutputStream>(@__env, @__env.CallObjectMethodPtr(this, _openOutputStream1042, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.OutputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentResolver.staticClass, _openOutputStream1042, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _openOutputStream1043; 
		public virtual java.io.OutputStream openOutputStream(android.net.Uri arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentResolver)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.OutputStream>(@__env, @__env.CallObjectMethodPtr(this, _openOutputStream1043, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.OutputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentResolver.staticClass, _openOutputStream1043, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _openFileDescriptor1044; 
		public virtual android.os.ParcelFileDescriptor openFileDescriptor(android.net.Uri arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentResolver)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.ParcelFileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, _openFileDescriptor1044, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.ParcelFileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentResolver.staticClass, _openFileDescriptor1044, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _openAssetFileDescriptor1045; 
		public virtual android.content.res.AssetFileDescriptor openAssetFileDescriptor(android.net.Uri arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentResolver)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetFileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, _openAssetFileDescriptor1045, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetFileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentResolver.staticClass, _openAssetFileDescriptor1045, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _applyBatch1046; 
		public virtual android.content.ContentProviderResult[] applyBatch(java.lang.String arg0, java.util.ArrayList arg1) 
		{ 
			if (GetType() == typeof(android.content.ContentResolver)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _applyBatch1046, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentResolver.staticClass, _applyBatch1046, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bulkInsert1047; 
		public virtual int bulkInsert(android.net.Uri arg0, android.content.ContentValues[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentResolver)) 
				return @__env.CallIntMethod(this, _bulkInsert1047, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.ContentResolver.staticClass, _bulkInsert1047, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _acquireContentProviderClient1048; 
		public virtual android.content.ContentProviderClient acquireContentProviderClient(android.net.Uri arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentResolver)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderClient>(@__env, @__env.CallObjectMethodPtr(this, _acquireContentProviderClient1048, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderClient>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentResolver.staticClass, _acquireContentProviderClient1048, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _acquireContentProviderClient1049; 
		public virtual android.content.ContentProviderClient acquireContentProviderClient(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentResolver)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderClient>(@__env, @__env.CallObjectMethodPtr(this, _acquireContentProviderClient1049, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderClient>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentResolver.staticClass, _acquireContentProviderClient1049, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerContentObserver1050; 
		public virtual void registerContentObserver(android.net.Uri arg0, bool arg1, android.database.ContentObserver arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentResolver)) 
				@__env.CallVoidMethod(this, _registerContentObserver1050, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContentResolver.staticClass, _registerContentObserver1050, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unregisterContentObserver1051; 
		public virtual void unregisterContentObserver(android.database.ContentObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentResolver)) 
				@__env.CallVoidMethod(this, _unregisterContentObserver1051, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContentResolver.staticClass, _unregisterContentObserver1051, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _notifyChange1052; 
		public virtual void notifyChange(android.net.Uri arg0, android.database.ContentObserver arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentResolver)) 
				@__env.CallVoidMethod(this, _notifyChange1052, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContentResolver.staticClass, _notifyChange1052, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _notifyChange1053; 
		public virtual void notifyChange(android.net.Uri arg0, android.database.ContentObserver arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentResolver)) 
				@__env.CallVoidMethod(this, _notifyChange1053, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContentResolver.staticClass, _notifyChange1053, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startSync1054; 
		public virtual void startSync(android.net.Uri arg0, android.os.Bundle arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentResolver)) 
				@__env.CallVoidMethod(this, _startSync1054, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContentResolver.staticClass, _startSync1054, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestSync1055; 
		public static void requestSync(android.accounts.Account arg0, java.lang.String arg1, android.os.Bundle arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.content.ContentResolver.staticClass, _requestSync1055, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _validateSyncExtrasBundle1056; 
		public static void validateSyncExtrasBundle(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.content.ContentResolver.staticClass, _validateSyncExtrasBundle1056, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cancelSync1057; 
		public virtual void cancelSync(android.net.Uri arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentResolver)) 
				@__env.CallVoidMethod(this, _cancelSync1057, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContentResolver.staticClass, _cancelSync1057, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cancelSync1058; 
		public static void cancelSync(android.accounts.Account arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.content.ContentResolver.staticClass, _cancelSync1058, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSyncAdapterTypes1059; 
		public static android.content.SyncAdapterType[] getSyncAdapterTypes() 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.content.ContentResolver.staticClass, _getSyncAdapterTypes1059)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSyncAutomatically1060; 
		public static bool getSyncAutomatically(android.accounts.Account arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.content.ContentResolver.staticClass, _getSyncAutomatically1060, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSyncAutomatically1061; 
		public static void setSyncAutomatically(android.accounts.Account arg0, java.lang.String arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.content.ContentResolver.staticClass, _setSyncAutomatically1061, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIsSyncable1062; 
		public static int getIsSyncable(android.accounts.Account arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.content.ContentResolver.staticClass, _getIsSyncable1062, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIsSyncable1063; 
		public static void setIsSyncable(android.accounts.Account arg0, java.lang.String arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.content.ContentResolver.staticClass, _setIsSyncable1063, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMasterSyncAutomatically1064; 
		public static bool getMasterSyncAutomatically() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.content.ContentResolver.staticClass, _getMasterSyncAutomatically1064); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMasterSyncAutomatically1065; 
		public static void setMasterSyncAutomatically(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.content.ContentResolver.staticClass, _setMasterSyncAutomatically1065, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isSyncActive1066; 
		public static bool isSyncActive(android.accounts.Account arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.content.ContentResolver.staticClass, _isSyncActive1066, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isSyncPending1067; 
		public static bool isSyncPending(android.accounts.Account arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.content.ContentResolver.staticClass, _isSyncPending1067, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addStatusChangeListener1068; 
		public static java.lang.Object addStatusChangeListener(int arg0, android.content.SyncStatusObserver arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallStaticObjectMethodPtr(android.content.ContentResolver.staticClass, _addStatusChangeListener1068, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeStatusChangeListener1069; 
		public static void removeStatusChangeListener(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.content.ContentResolver.staticClass, _removeStatusChangeListener1069, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ContentResolver1070; 
		public ContentResolver(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.ContentResolver.staticClass, _ContentResolver1070, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		public static java.lang.String SYNC_EXTRAS_ACCOUNT
		{ 
			get 
			{ 
				return "account"; 
			} 
		} 
		public static java.lang.String SYNC_EXTRAS_EXPEDITED
		{ 
			get 
			{ 
				return "expedited"; 
			} 
		} 
		public static java.lang.String SYNC_EXTRAS_FORCE
		{ 
			get 
			{ 
				return "force"; 
			} 
		} 
		public static java.lang.String SYNC_EXTRAS_MANUAL
		{ 
			get 
			{ 
				return "force"; 
			} 
		} 
		public static java.lang.String SYNC_EXTRAS_UPLOAD
		{ 
			get 
			{ 
				return "upload"; 
			} 
		} 
		public static java.lang.String SYNC_EXTRAS_OVERRIDE_TOO_MANY_DELETIONS
		{ 
			get 
			{ 
				return "deletions_override"; 
			} 
		} 
		public static java.lang.String SYNC_EXTRAS_DISCARD_LOCAL_DELETIONS
		{ 
			get 
			{ 
				return "discard_deletions"; 
			} 
		} 
		public static java.lang.String SYNC_EXTRAS_INITIALIZE
		{ 
			get 
			{ 
				return "initialize"; 
			} 
		} 
		public static java.lang.String SCHEME_CONTENT
		{ 
			get 
			{ 
				return "content"; 
			} 
		} 
		public static java.lang.String SCHEME_ANDROID_RESOURCE
		{ 
			get 
			{ 
				return "android.resource"; 
			} 
		} 
		public static java.lang.String SCHEME_FILE
		{ 
			get 
			{ 
				return "file"; 
			} 
		} 
		public static java.lang.String CURSOR_ITEM_BASE_TYPE
		{ 
			get 
			{ 
				return "vnd.android.cursor.item"; 
			} 
		} 
		public static java.lang.String CURSOR_DIR_BASE_TYPE
		{ 
			get 
			{ 
				return "vnd.android.cursor.dir"; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.ContentResolver.staticClass = @__class; 
			global::android.content.ContentResolver._getType1036 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "getType", "(Landroid/net/Uri;)Ljava/lang/String;"); 
			global::android.content.ContentResolver._delete1037 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I"); 
			global::android.content.ContentResolver._insert1038 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;"); 
			global::android.content.ContentResolver._query1039 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;"); 
			global::android.content.ContentResolver._update1040 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I"); 
			global::android.content.ContentResolver._openInputStream1041 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "openInputStream", "(Landroid/net/Uri;)Ljava/io/InputStream;"); 
			global::android.content.ContentResolver._openOutputStream1042 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "openOutputStream", "(Landroid/net/Uri;Ljava/lang/String;)Ljava/io/OutputStream;"); 
			global::android.content.ContentResolver._openOutputStream1043 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "openOutputStream", "(Landroid/net/Uri;)Ljava/io/OutputStream;"); 
			global::android.content.ContentResolver._openFileDescriptor1044 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "openFileDescriptor", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/os/ParcelFileDescriptor;"); 
			global::android.content.ContentResolver._openAssetFileDescriptor1045 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "openAssetFileDescriptor", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/content/res/AssetFileDescriptor;"); 
			global::android.content.ContentResolver._applyBatch1046 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "applyBatch", "(Ljava/lang/String;Ljava/util/ArrayList;)[Landroid/content/ContentProviderResult;"); 
			global::android.content.ContentResolver._bulkInsert1047 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "bulkInsert", "(Landroid/net/Uri;[Landroid/content/ContentValues;)I"); 
			global::android.content.ContentResolver._acquireContentProviderClient1048 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "acquireContentProviderClient", "(Landroid/net/Uri;)Landroid/content/ContentProviderClient;"); 
			global::android.content.ContentResolver._acquireContentProviderClient1049 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "acquireContentProviderClient", "(Ljava/lang/String;)Landroid/content/ContentProviderClient;"); 
			global::android.content.ContentResolver._registerContentObserver1050 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "registerContentObserver", "(Landroid/net/Uri;ZLandroid/database/ContentObserver;)V"); 
			global::android.content.ContentResolver._unregisterContentObserver1051 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V"); 
			global::android.content.ContentResolver._notifyChange1052 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "notifyChange", "(Landroid/net/Uri;Landroid/database/ContentObserver;)V"); 
			global::android.content.ContentResolver._notifyChange1053 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "notifyChange", "(Landroid/net/Uri;Landroid/database/ContentObserver;Z)V"); 
			global::android.content.ContentResolver._startSync1054 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "startSync", "(Landroid/net/Uri;Landroid/os/Bundle;)V"); 
			global::android.content.ContentResolver._requestSync1055 = @__env.GetStaticMethodID(global::android.content.ContentResolver.staticClass, "requestSync", "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;)V"); 
			global::android.content.ContentResolver._validateSyncExtrasBundle1056 = @__env.GetStaticMethodID(global::android.content.ContentResolver.staticClass, "validateSyncExtrasBundle", "(Landroid/os/Bundle;)V"); 
			global::android.content.ContentResolver._cancelSync1057 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "cancelSync", "(Landroid/net/Uri;)V"); 
			global::android.content.ContentResolver._cancelSync1058 = @__env.GetStaticMethodID(global::android.content.ContentResolver.staticClass, "cancelSync", "(Landroid/accounts/Account;Ljava/lang/String;)V"); 
			global::android.content.ContentResolver._getSyncAdapterTypes1059 = @__env.GetStaticMethodID(global::android.content.ContentResolver.staticClass, "getSyncAdapterTypes", "()[Landroid/content/SyncAdapterType;"); 
			global::android.content.ContentResolver._getSyncAutomatically1060 = @__env.GetStaticMethodID(global::android.content.ContentResolver.staticClass, "getSyncAutomatically", "(Landroid/accounts/Account;Ljava/lang/String;)Z"); 
			global::android.content.ContentResolver._setSyncAutomatically1061 = @__env.GetStaticMethodID(global::android.content.ContentResolver.staticClass, "setSyncAutomatically", "(Landroid/accounts/Account;Ljava/lang/String;Z)V"); 
			global::android.content.ContentResolver._getIsSyncable1062 = @__env.GetStaticMethodID(global::android.content.ContentResolver.staticClass, "getIsSyncable", "(Landroid/accounts/Account;Ljava/lang/String;)I"); 
			global::android.content.ContentResolver._setIsSyncable1063 = @__env.GetStaticMethodID(global::android.content.ContentResolver.staticClass, "setIsSyncable", "(Landroid/accounts/Account;Ljava/lang/String;I)V"); 
			global::android.content.ContentResolver._getMasterSyncAutomatically1064 = @__env.GetStaticMethodID(global::android.content.ContentResolver.staticClass, "getMasterSyncAutomatically", "()Z"); 
			global::android.content.ContentResolver._setMasterSyncAutomatically1065 = @__env.GetStaticMethodID(global::android.content.ContentResolver.staticClass, "setMasterSyncAutomatically", "(Z)V"); 
			global::android.content.ContentResolver._isSyncActive1066 = @__env.GetStaticMethodID(global::android.content.ContentResolver.staticClass, "isSyncActive", "(Landroid/accounts/Account;Ljava/lang/String;)Z"); 
			global::android.content.ContentResolver._isSyncPending1067 = @__env.GetStaticMethodID(global::android.content.ContentResolver.staticClass, "isSyncPending", "(Landroid/accounts/Account;Ljava/lang/String;)Z"); 
			global::android.content.ContentResolver._addStatusChangeListener1068 = @__env.GetStaticMethodID(global::android.content.ContentResolver.staticClass, "addStatusChangeListener", "(ILandroid/content/SyncStatusObserver;)Ljava/lang/Object;"); 
			global::android.content.ContentResolver._removeStatusChangeListener1069 = @__env.GetStaticMethodID(global::android.content.ContentResolver.staticClass, "removeStatusChangeListener", "(Ljava/lang/Object;)V"); 
			global::android.content.ContentResolver._ContentResolver1070 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
