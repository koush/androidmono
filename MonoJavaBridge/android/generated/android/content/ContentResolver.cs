namespace android.content
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.content.ContentResolver_))]
	public abstract partial class ContentResolver : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ContentResolver(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.String getType(android.net.Uri arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.ContentResolver.staticClass, "getType", "(Landroid/net/Uri;)Ljava/lang/String;", ref global::android.content.ContentResolver._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int delete(android.net.Uri arg0, java.lang.String arg1, java.lang.String[] arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.ContentResolver.staticClass, "delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I", ref global::android.content.ContentResolver._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::android.net.Uri insert(android.net.Uri arg0, android.content.ContentValues arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContentResolver.staticClass, "insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;", ref global::android.content.ContentResolver._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.net.Uri;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::android.database.Cursor query(android.net.Uri arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.database.Cursor>(this, global::android.content.ContentResolver.staticClass, "query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;", ref global::android.content.ContentResolver._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4)) as android.database.Cursor;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int update(android.net.Uri arg0, android.content.ContentValues arg1, java.lang.String arg2, java.lang.String[] arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.ContentResolver.staticClass, "update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I", ref global::android.content.ContentResolver._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.io.InputStream openInputStream(android.net.Uri arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContentResolver.staticClass, "openInputStream", "(Landroid/net/Uri;)Ljava/io/InputStream;", ref global::android.content.ContentResolver._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.io.OutputStream openOutputStream(android.net.Uri arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContentResolver.staticClass, "openOutputStream", "(Landroid/net/Uri;)Ljava/io/OutputStream;", ref global::android.content.ContentResolver._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.OutputStream;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.io.OutputStream openOutputStream(android.net.Uri arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContentResolver.staticClass, "openOutputStream", "(Landroid/net/Uri;Ljava/lang/String;)Ljava/io/OutputStream;", ref global::android.content.ContentResolver._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.io.OutputStream;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::android.os.ParcelFileDescriptor openFileDescriptor(android.net.Uri arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContentResolver.staticClass, "openFileDescriptor", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/os/ParcelFileDescriptor;", ref global::android.content.ContentResolver._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.os.ParcelFileDescriptor;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::android.content.res.AssetFileDescriptor openAssetFileDescriptor(android.net.Uri arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContentResolver.staticClass, "openAssetFileDescriptor", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/content/res/AssetFileDescriptor;", ref global::android.content.ContentResolver._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.res.AssetFileDescriptor;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::android.content.ContentProviderResult[] applyBatch(java.lang.String arg0, java.util.ArrayList arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<android.content.ContentProviderResult>(this, global::android.content.ContentResolver.staticClass, "applyBatch", "(Ljava/lang/String;Ljava/util/ArrayList;)[Landroid/content/ContentProviderResult;", ref global::android.content.ContentResolver._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.ContentProviderResult[];
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual int bulkInsert(android.net.Uri arg0, android.content.ContentValues[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.ContentResolver.staticClass, "bulkInsert", "(Landroid/net/Uri;[Landroid/content/ContentValues;)I", ref global::android.content.ContentResolver._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::android.content.ContentProviderClient acquireContentProviderClient(android.net.Uri arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContentResolver.staticClass, "acquireContentProviderClient", "(Landroid/net/Uri;)Landroid/content/ContentProviderClient;", ref global::android.content.ContentResolver._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.ContentProviderClient;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::android.content.ContentProviderClient acquireContentProviderClient(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContentResolver.staticClass, "acquireContentProviderClient", "(Ljava/lang/String;)Landroid/content/ContentProviderClient;", ref global::android.content.ContentResolver._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.ContentProviderClient;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void registerContentObserver(android.net.Uri arg0, bool arg1, android.database.ContentObserver arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentResolver.staticClass, "registerContentObserver", "(Landroid/net/Uri;ZLandroid/database/ContentObserver;)V", ref global::android.content.ContentResolver._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void unregisterContentObserver(android.database.ContentObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentResolver.staticClass, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V", ref global::android.content.ContentResolver._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void notifyChange(android.net.Uri arg0, android.database.ContentObserver arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentResolver.staticClass, "notifyChange", "(Landroid/net/Uri;Landroid/database/ContentObserver;)V", ref global::android.content.ContentResolver._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void notifyChange(android.net.Uri arg0, android.database.ContentObserver arg1, bool arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentResolver.staticClass, "notifyChange", "(Landroid/net/Uri;Landroid/database/ContentObserver;Z)V", ref global::android.content.ContentResolver._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void startSync(android.net.Uri arg0, android.os.Bundle arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentResolver.staticClass, "startSync", "(Landroid/net/Uri;Landroid/os/Bundle;)V", ref global::android.content.ContentResolver._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public static void requestSync(android.accounts.Account arg0, java.lang.String arg1, android.os.Bundle arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContentResolver._m19.native == global::System.IntPtr.Zero)
				global::android.content.ContentResolver._m19 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "requestSync", "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;)V");
			@__env.CallStaticVoidMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public static void validateSyncExtrasBundle(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContentResolver._m20.native == global::System.IntPtr.Zero)
				global::android.content.ContentResolver._m20 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "validateSyncExtrasBundle", "(Landroid/os/Bundle;)V");
			@__env.CallStaticVoidMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void cancelSync(android.net.Uri arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentResolver.staticClass, "cancelSync", "(Landroid/net/Uri;)V", ref global::android.content.ContentResolver._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public static void cancelSync(android.accounts.Account arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContentResolver._m22.native == global::System.IntPtr.Zero)
				global::android.content.ContentResolver._m22 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "cancelSync", "(Landroid/accounts/Account;Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public static global::android.content.SyncAdapterType[] getSyncAdapterTypes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContentResolver._m23.native == global::System.IntPtr.Zero)
				global::android.content.ContentResolver._m23 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "getSyncAdapterTypes", "()[Landroid/content/SyncAdapterType;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.SyncAdapterType>(@__env.CallStaticObjectMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._m23)) as android.content.SyncAdapterType[];
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public static bool getSyncAutomatically(android.accounts.Account arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContentResolver._m24.native == global::System.IntPtr.Zero)
				global::android.content.ContentResolver._m24 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "getSyncAutomatically", "(Landroid/accounts/Account;Ljava/lang/String;)Z");
			return @__env.CallStaticBooleanMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public static void setSyncAutomatically(android.accounts.Account arg0, java.lang.String arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContentResolver._m25.native == global::System.IntPtr.Zero)
				global::android.content.ContentResolver._m25 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "setSyncAutomatically", "(Landroid/accounts/Account;Ljava/lang/String;Z)V");
			@__env.CallStaticVoidMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public static void addPeriodicSync(android.accounts.Account arg0, java.lang.String arg1, android.os.Bundle arg2, long arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContentResolver._m26.native == global::System.IntPtr.Zero)
				global::android.content.ContentResolver._m26 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "addPeriodicSync", "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;J)V");
			@__env.CallStaticVoidMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public static void removePeriodicSync(android.accounts.Account arg0, java.lang.String arg1, android.os.Bundle arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContentResolver._m27.native == global::System.IntPtr.Zero)
				global::android.content.ContentResolver._m27 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "removePeriodicSync", "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;)V");
			@__env.CallStaticVoidMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public static global::java.util.List getPeriodicSyncs(android.accounts.Account arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContentResolver._m28.native == global::System.IntPtr.Zero)
				global::android.content.ContentResolver._m28 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "getPeriodicSyncs", "(Landroid/accounts/Account;Ljava/lang/String;)Ljava/util/List;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallStaticObjectMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public static int getIsSyncable(android.accounts.Account arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContentResolver._m29.native == global::System.IntPtr.Zero)
				global::android.content.ContentResolver._m29 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "getIsSyncable", "(Landroid/accounts/Account;Ljava/lang/String;)I");
			return @__env.CallStaticIntMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public static void setIsSyncable(android.accounts.Account arg0, java.lang.String arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContentResolver._m30.native == global::System.IntPtr.Zero)
				global::android.content.ContentResolver._m30 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "setIsSyncable", "(Landroid/accounts/Account;Ljava/lang/String;I)V");
			@__env.CallStaticVoidMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public static bool getMasterSyncAutomatically()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContentResolver._m31.native == global::System.IntPtr.Zero)
				global::android.content.ContentResolver._m31 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "getMasterSyncAutomatically", "()Z");
			return @__env.CallStaticBooleanMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._m31);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public static void setMasterSyncAutomatically(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContentResolver._m32.native == global::System.IntPtr.Zero)
				global::android.content.ContentResolver._m32 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "setMasterSyncAutomatically", "(Z)V");
			@__env.CallStaticVoidMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public static bool isSyncActive(android.accounts.Account arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContentResolver._m33.native == global::System.IntPtr.Zero)
				global::android.content.ContentResolver._m33 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "isSyncActive", "(Landroid/accounts/Account;Ljava/lang/String;)Z");
			return @__env.CallStaticBooleanMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public static global::android.content.SyncInfo getCurrentSync()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContentResolver._m34.native == global::System.IntPtr.Zero)
				global::android.content.ContentResolver._m34 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "getCurrentSync", "()Landroid/content/SyncInfo;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._m34)) as android.content.SyncInfo;
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public static bool isSyncPending(android.accounts.Account arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContentResolver._m35.native == global::System.IntPtr.Zero)
				global::android.content.ContentResolver._m35 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "isSyncPending", "(Landroid/accounts/Account;Ljava/lang/String;)Z");
			return @__env.CallStaticBooleanMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public static global::java.lang.Object addStatusChangeListener(int arg0, android.content.SyncStatusObserver arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContentResolver._m36.native == global::System.IntPtr.Zero)
				global::android.content.ContentResolver._m36 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "addStatusChangeListener", "(ILandroid/content/SyncStatusObserver;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		public static java.lang.Object addStatusChangeListener(int arg0, global::android.content.SyncStatusObserverDelegate arg1)
		{
			return addStatusChangeListener(arg0, (global::android.content.SyncStatusObserverDelegateWrapper)arg1);
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public static void removeStatusChangeListener(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContentResolver._m37.native == global::System.IntPtr.Zero)
				global::android.content.ContentResolver._m37 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "removeStatusChangeListener", "(Ljava/lang/Object;)V");
			@__env.CallStaticVoidMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public ContentResolver(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContentResolver._m38.native == global::System.IntPtr.Zero)
				global::android.content.ContentResolver._m38 = @__env.GetMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
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
		static ContentResolver()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ContentResolver.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ContentResolver"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.ContentResolver))]
	internal sealed partial class ContentResolver_ : android.content.ContentResolver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ContentResolver_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static ContentResolver_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ContentResolver_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ContentResolver"));
		}
	}
}
