namespace android.content
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class ContentResolver : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static ContentResolver()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.ContentResolver), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected ContentResolver(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getType1184;
		public virtual global::java.lang.String getType(android.net.Uri arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentResolver._getType1184, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._getType1184, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _delete1185;
		public virtual int delete(android.net.Uri arg0, java.lang.String arg1, java.lang.String[] arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.ContentResolver._delete1185, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._delete1185, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _insert1186;
		public virtual global::android.net.Uri insert(android.net.Uri arg0, android.content.ContentValues arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentResolver._insert1186, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._insert1186, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _query1187;
		public virtual global::android.database.Cursor query(android.net.Uri arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentResolver._query1187, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._query1187, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _update1188;
		public virtual int update(android.net.Uri arg0, android.content.ContentValues arg1, java.lang.String arg2, java.lang.String[] arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.ContentResolver._update1188, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._update1188, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _openInputStream1189;
		public virtual global::java.io.InputStream openInputStream(android.net.Uri arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentResolver._openInputStream1189, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._openInputStream1189, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _openOutputStream1190;
		public virtual global::java.io.OutputStream openOutputStream(android.net.Uri arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.OutputStream>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentResolver._openOutputStream1190, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.OutputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._openOutputStream1190, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _openOutputStream1191;
		public virtual global::java.io.OutputStream openOutputStream(android.net.Uri arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.OutputStream>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentResolver._openOutputStream1191, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.OutputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._openOutputStream1191, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _openFileDescriptor1192;
		public virtual global::android.os.ParcelFileDescriptor openFileDescriptor(android.net.Uri arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.ParcelFileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentResolver._openFileDescriptor1192, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.ParcelFileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._openFileDescriptor1192, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _openAssetFileDescriptor1193;
		public virtual global::android.content.res.AssetFileDescriptor openAssetFileDescriptor(android.net.Uri arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetFileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentResolver._openAssetFileDescriptor1193, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetFileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._openAssetFileDescriptor1193, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _applyBatch1194;
		public virtual global::android.content.ContentProviderResult[] applyBatch(java.lang.String arg0, java.util.ArrayList arg1) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentResolver._applyBatch1194, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._applyBatch1194, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _bulkInsert1195;
		public virtual int bulkInsert(android.net.Uri arg0, android.content.ContentValues[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.ContentResolver._bulkInsert1195, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._bulkInsert1195, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _acquireContentProviderClient1196;
		public virtual global::android.content.ContentProviderClient acquireContentProviderClient(android.net.Uri arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderClient>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentResolver._acquireContentProviderClient1196, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderClient>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._acquireContentProviderClient1196, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _acquireContentProviderClient1197;
		public virtual global::android.content.ContentProviderClient acquireContentProviderClient(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderClient>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentResolver._acquireContentProviderClient1197, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderClient>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._acquireContentProviderClient1197, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _registerContentObserver1198;
		public virtual void registerContentObserver(android.net.Uri arg0, bool arg1, android.database.ContentObserver arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContentResolver._registerContentObserver1198, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._registerContentObserver1198, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unregisterContentObserver1199;
		public virtual void unregisterContentObserver(android.database.ContentObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContentResolver._unregisterContentObserver1199, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._unregisterContentObserver1199, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _notifyChange1200;
		public virtual void notifyChange(android.net.Uri arg0, android.database.ContentObserver arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContentResolver._notifyChange1200, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._notifyChange1200, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _notifyChange1201;
		public virtual void notifyChange(android.net.Uri arg0, android.database.ContentObserver arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContentResolver._notifyChange1201, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._notifyChange1201, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startSync1202;
		public virtual void startSync(android.net.Uri arg0, android.os.Bundle arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContentResolver._startSync1202, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._startSync1202, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestSync1203;
		public static void requestSync(android.accounts.Account arg0, java.lang.String arg1, android.os.Bundle arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._requestSync1203, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _validateSyncExtrasBundle1204;
		public static void validateSyncExtrasBundle(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._validateSyncExtrasBundle1204, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _cancelSync1205;
		public virtual void cancelSync(android.net.Uri arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContentResolver._cancelSync1205, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._cancelSync1205, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _cancelSync1206;
		public static void cancelSync(android.accounts.Account arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._cancelSync1206, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSyncAdapterTypes1207;
		public static global::android.content.SyncAdapterType[] getSyncAdapterTypes() 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._getSyncAdapterTypes1207));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSyncAutomatically1208;
		public static bool getSyncAutomatically(android.accounts.Account arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._getSyncAutomatically1208, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSyncAutomatically1209;
		public static void setSyncAutomatically(android.accounts.Account arg0, java.lang.String arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._setSyncAutomatically1209, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addPeriodicSync1210;
		public static void addPeriodicSync(android.accounts.Account arg0, java.lang.String arg1, android.os.Bundle arg2, long arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._addPeriodicSync1210, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removePeriodicSync1211;
		public static void removePeriodicSync(android.accounts.Account arg0, java.lang.String arg1, android.os.Bundle arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._removePeriodicSync1211, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPeriodicSyncs1212;
		public static global::java.util.List getPeriodicSyncs(android.accounts.Account arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallStaticObjectMethodPtr(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._getPeriodicSyncs1212, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIsSyncable1213;
		public static int getIsSyncable(android.accounts.Account arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._getIsSyncable1213, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIsSyncable1214;
		public static void setIsSyncable(android.accounts.Account arg0, java.lang.String arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._setIsSyncable1214, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMasterSyncAutomatically1215;
		public static bool getMasterSyncAutomatically() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._getMasterSyncAutomatically1215);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMasterSyncAutomatically1216;
		public static void setMasterSyncAutomatically(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._setMasterSyncAutomatically1216, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isSyncActive1217;
		public static bool isSyncActive(android.accounts.Account arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._isSyncActive1217, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentSync1218;
		public static global::android.content.SyncInfo getCurrentSync() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.SyncInfo>(@__env, @__env.CallStaticObjectMethodPtr(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._getCurrentSync1218));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isSyncPending1219;
		public static bool isSyncPending(android.accounts.Account arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._isSyncPending1219, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addStatusChangeListener1220;
		public static global::java.lang.Object addStatusChangeListener(int arg0, android.content.SyncStatusObserver arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallStaticObjectMethodPtr(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._addStatusChangeListener1220, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeStatusChangeListener1221;
		public static void removeStatusChangeListener(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._removeStatusChangeListener1221, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ContentResolver1222;
		public ContentResolver(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._ContentResolver1222, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		public static global::java.lang.String SYNC_EXTRAS_ACCOUNT
		{
			get
			{
				return "account";
			}
		}
		public static global::java.lang.String SYNC_EXTRAS_EXPEDITED
		{
			get
			{
				return "expedited";
			}
		}
		public static global::java.lang.String SYNC_EXTRAS_FORCE
		{
			get
			{
				return "force";
			}
		}
		public static global::java.lang.String SYNC_EXTRAS_IGNORE_SETTINGS
		{
			get
			{
				return "ignore_settings";
			}
		}
		public static global::java.lang.String SYNC_EXTRAS_IGNORE_BACKOFF
		{
			get
			{
				return "ignore_backoff";
			}
		}
		public static global::java.lang.String SYNC_EXTRAS_DO_NOT_RETRY
		{
			get
			{
				return "do_not_retry";
			}
		}
		public static global::java.lang.String SYNC_EXTRAS_MANUAL
		{
			get
			{
				return "force";
			}
		}
		public static global::java.lang.String SYNC_EXTRAS_UPLOAD
		{
			get
			{
				return "upload";
			}
		}
		public static global::java.lang.String SYNC_EXTRAS_OVERRIDE_TOO_MANY_DELETIONS
		{
			get
			{
				return "deletions_override";
			}
		}
		public static global::java.lang.String SYNC_EXTRAS_DISCARD_LOCAL_DELETIONS
		{
			get
			{
				return "discard_deletions";
			}
		}
		public static global::java.lang.String SYNC_EXTRAS_INITIALIZE
		{
			get
			{
				return "initialize";
			}
		}
		public static global::java.lang.String SCHEME_CONTENT
		{
			get
			{
				return "content";
			}
		}
		public static global::java.lang.String SCHEME_ANDROID_RESOURCE
		{
			get
			{
				return "android.resource";
			}
		}
		public static global::java.lang.String SCHEME_FILE
		{
			get
			{
				return "file";
			}
		}
		public static global::java.lang.String CURSOR_ITEM_BASE_TYPE
		{
			get
			{
				return "vnd.android.cursor.item";
			}
		}
		public static global::java.lang.String CURSOR_DIR_BASE_TYPE
		{
			get
			{
				return "vnd.android.cursor.dir";
			}
		}
		public static int SYNC_OBSERVER_TYPE_SETTINGS
		{
			get
			{
				return 1;
			}
		}
		public static int SYNC_OBSERVER_TYPE_PENDING
		{
			get
			{
				return 2;
			}
		}
		public static int SYNC_OBSERVER_TYPE_ACTIVE
		{
			get
			{
				return 4;
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.ContentResolver.staticClass = @__class;
			global::android.content.ContentResolver._getType1184 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "getType", "(Landroid/net/Uri;)Ljava/lang/String;");
			global::android.content.ContentResolver._delete1185 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I");
			global::android.content.ContentResolver._insert1186 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;");
			global::android.content.ContentResolver._query1187 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			global::android.content.ContentResolver._update1188 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I");
			global::android.content.ContentResolver._openInputStream1189 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "openInputStream", "(Landroid/net/Uri;)Ljava/io/InputStream;");
			global::android.content.ContentResolver._openOutputStream1190 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "openOutputStream", "(Landroid/net/Uri;)Ljava/io/OutputStream;");
			global::android.content.ContentResolver._openOutputStream1191 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "openOutputStream", "(Landroid/net/Uri;Ljava/lang/String;)Ljava/io/OutputStream;");
			global::android.content.ContentResolver._openFileDescriptor1192 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "openFileDescriptor", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/os/ParcelFileDescriptor;");
			global::android.content.ContentResolver._openAssetFileDescriptor1193 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "openAssetFileDescriptor", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/content/res/AssetFileDescriptor;");
			global::android.content.ContentResolver._applyBatch1194 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "applyBatch", "(Ljava/lang/String;Ljava/util/ArrayList;)[Landroid/content/ContentProviderResult;");
			global::android.content.ContentResolver._bulkInsert1195 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "bulkInsert", "(Landroid/net/Uri;[Landroid/content/ContentValues;)I");
			global::android.content.ContentResolver._acquireContentProviderClient1196 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "acquireContentProviderClient", "(Landroid/net/Uri;)Landroid/content/ContentProviderClient;");
			global::android.content.ContentResolver._acquireContentProviderClient1197 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "acquireContentProviderClient", "(Ljava/lang/String;)Landroid/content/ContentProviderClient;");
			global::android.content.ContentResolver._registerContentObserver1198 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "registerContentObserver", "(Landroid/net/Uri;ZLandroid/database/ContentObserver;)V");
			global::android.content.ContentResolver._unregisterContentObserver1199 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.content.ContentResolver._notifyChange1200 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "notifyChange", "(Landroid/net/Uri;Landroid/database/ContentObserver;)V");
			global::android.content.ContentResolver._notifyChange1201 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "notifyChange", "(Landroid/net/Uri;Landroid/database/ContentObserver;Z)V");
			global::android.content.ContentResolver._startSync1202 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "startSync", "(Landroid/net/Uri;Landroid/os/Bundle;)V");
			global::android.content.ContentResolver._requestSync1203 = @__env.GetStaticMethodID(global::android.content.ContentResolver.staticClass, "requestSync", "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;)V");
			global::android.content.ContentResolver._validateSyncExtrasBundle1204 = @__env.GetStaticMethodID(global::android.content.ContentResolver.staticClass, "validateSyncExtrasBundle", "(Landroid/os/Bundle;)V");
			global::android.content.ContentResolver._cancelSync1205 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "cancelSync", "(Landroid/net/Uri;)V");
			global::android.content.ContentResolver._cancelSync1206 = @__env.GetStaticMethodID(global::android.content.ContentResolver.staticClass, "cancelSync", "(Landroid/accounts/Account;Ljava/lang/String;)V");
			global::android.content.ContentResolver._getSyncAdapterTypes1207 = @__env.GetStaticMethodID(global::android.content.ContentResolver.staticClass, "getSyncAdapterTypes", "()[Landroid/content/SyncAdapterType;");
			global::android.content.ContentResolver._getSyncAutomatically1208 = @__env.GetStaticMethodID(global::android.content.ContentResolver.staticClass, "getSyncAutomatically", "(Landroid/accounts/Account;Ljava/lang/String;)Z");
			global::android.content.ContentResolver._setSyncAutomatically1209 = @__env.GetStaticMethodID(global::android.content.ContentResolver.staticClass, "setSyncAutomatically", "(Landroid/accounts/Account;Ljava/lang/String;Z)V");
			global::android.content.ContentResolver._addPeriodicSync1210 = @__env.GetStaticMethodID(global::android.content.ContentResolver.staticClass, "addPeriodicSync", "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;J)V");
			global::android.content.ContentResolver._removePeriodicSync1211 = @__env.GetStaticMethodID(global::android.content.ContentResolver.staticClass, "removePeriodicSync", "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;)V");
			global::android.content.ContentResolver._getPeriodicSyncs1212 = @__env.GetStaticMethodID(global::android.content.ContentResolver.staticClass, "getPeriodicSyncs", "(Landroid/accounts/Account;Ljava/lang/String;)Ljava/util/List;");
			global::android.content.ContentResolver._getIsSyncable1213 = @__env.GetStaticMethodID(global::android.content.ContentResolver.staticClass, "getIsSyncable", "(Landroid/accounts/Account;Ljava/lang/String;)I");
			global::android.content.ContentResolver._setIsSyncable1214 = @__env.GetStaticMethodID(global::android.content.ContentResolver.staticClass, "setIsSyncable", "(Landroid/accounts/Account;Ljava/lang/String;I)V");
			global::android.content.ContentResolver._getMasterSyncAutomatically1215 = @__env.GetStaticMethodID(global::android.content.ContentResolver.staticClass, "getMasterSyncAutomatically", "()Z");
			global::android.content.ContentResolver._setMasterSyncAutomatically1216 = @__env.GetStaticMethodID(global::android.content.ContentResolver.staticClass, "setMasterSyncAutomatically", "(Z)V");
			global::android.content.ContentResolver._isSyncActive1217 = @__env.GetStaticMethodID(global::android.content.ContentResolver.staticClass, "isSyncActive", "(Landroid/accounts/Account;Ljava/lang/String;)Z");
			global::android.content.ContentResolver._getCurrentSync1218 = @__env.GetStaticMethodID(global::android.content.ContentResolver.staticClass, "getCurrentSync", "()Landroid/content/SyncInfo;");
			global::android.content.ContentResolver._isSyncPending1219 = @__env.GetStaticMethodID(global::android.content.ContentResolver.staticClass, "isSyncPending", "(Landroid/accounts/Account;Ljava/lang/String;)Z");
			global::android.content.ContentResolver._addStatusChangeListener1220 = @__env.GetStaticMethodID(global::android.content.ContentResolver.staticClass, "addStatusChangeListener", "(ILandroid/content/SyncStatusObserver;)Ljava/lang/Object;");
			global::android.content.ContentResolver._removeStatusChangeListener1221 = @__env.GetStaticMethodID(global::android.content.ContentResolver.staticClass, "removeStatusChangeListener", "(Ljava/lang/Object;)V");
			global::android.content.ContentResolver._ContentResolver1222 = @__env.GetMethodID(global::android.content.ContentResolver.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
