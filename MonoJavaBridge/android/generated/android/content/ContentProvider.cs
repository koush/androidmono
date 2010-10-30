namespace android.content
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.content.ContentProvider_))]
	public abstract partial class ContentProvider : java.lang.Object, ComponentCallbacks
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ContentProvider(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getContext2633;
		public virtual global::android.content.Context getContext()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._getContext2633)) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _getType2634;
		public abstract global::java.lang.String getType(android.net.Uri arg0);
		internal static global::MonoJavaBridge.MethodId _delete2635;
		public abstract int delete(android.net.Uri arg0, java.lang.String arg1, java.lang.String[] arg2);
		internal static global::MonoJavaBridge.MethodId _insert2636;
		public abstract global::android.net.Uri insert(android.net.Uri arg0, android.content.ContentValues arg1);
		internal static global::MonoJavaBridge.MethodId _query2637;
		public abstract global::android.database.Cursor query(android.net.Uri arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4);
		internal static global::MonoJavaBridge.MethodId _update2638;
		public abstract int update(android.net.Uri arg0, android.content.ContentValues arg1, java.lang.String arg2, java.lang.String[] arg3);
		internal static global::MonoJavaBridge.MethodId _onCreate2639;
		public abstract bool onCreate();
		internal static global::MonoJavaBridge.MethodId _onConfigurationChanged2640;
		public virtual void onConfigurationChanged(android.content.res.Configuration arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._onConfigurationChanged2640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLowMemory2641;
		public virtual void onLowMemory()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._onLowMemory2641);
		}
		internal static global::MonoJavaBridge.MethodId _applyBatch2642;
		public virtual global::android.content.ContentProviderResult[] applyBatch(java.util.ArrayList arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.ContentProviderResult>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._applyBatch2642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderResult[];
		}
		internal static global::MonoJavaBridge.MethodId _bulkInsert2643;
		public virtual int bulkInsert(android.net.Uri arg0, android.content.ContentValues[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._bulkInsert2643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _openFile2644;
		public virtual global::android.os.ParcelFileDescriptor openFile(android.net.Uri arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._openFile2644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.os.ParcelFileDescriptor;
		}
		internal static global::MonoJavaBridge.MethodId _openAssetFile2645;
		public virtual global::android.content.res.AssetFileDescriptor openAssetFile(android.net.Uri arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._openAssetFile2645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.res.AssetFileDescriptor;
		}
		internal static global::MonoJavaBridge.MethodId _setReadPermission2646;
		protected virtual void setReadPermission(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._setReadPermission2646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getReadPermission2647;
		public virtual global::java.lang.String getReadPermission()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._getReadPermission2647)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setWritePermission2648;
		protected virtual void setWritePermission(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._setWritePermission2648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWritePermission2649;
		public virtual global::java.lang.String getWritePermission()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._getWritePermission2649)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setPathPermissions2650;
		protected virtual void setPathPermissions(android.content.pm.PathPermission[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._setPathPermissions2650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPathPermissions2651;
		public virtual global::android.content.pm.PathPermission[] getPathPermissions()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.PathPermission>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._getPathPermissions2651)) as android.content.pm.PathPermission[];
		}
		internal static global::MonoJavaBridge.MethodId _openFileHelper2652;
		protected virtual global::android.os.ParcelFileDescriptor openFileHelper(android.net.Uri arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._openFileHelper2652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.os.ParcelFileDescriptor;
		}
		internal static global::MonoJavaBridge.MethodId _isTemporary2653;
		protected virtual bool isTemporary()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._isTemporary2653);
		}
		internal static global::MonoJavaBridge.MethodId _attachInfo2654;
		public virtual void attachInfo(android.content.Context arg0, android.content.pm.ProviderInfo arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._attachInfo2654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ContentProvider2655;
		public ContentProvider() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ContentProvider.staticClass, global::android.content.ContentProvider._ContentProvider2655);
			Init(@__env, handle);
		}
		static ContentProvider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ContentProvider.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ContentProvider"));
			global::android.content.ContentProvider._getContext2633 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "getContext", "()Landroid/content/Context;");
			global::android.content.ContentProvider._getType2634 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "getType", "(Landroid/net/Uri;)Ljava/lang/String;");
			global::android.content.ContentProvider._delete2635 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I");
			global::android.content.ContentProvider._insert2636 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;");
			global::android.content.ContentProvider._query2637 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			global::android.content.ContentProvider._update2638 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I");
			global::android.content.ContentProvider._onCreate2639 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "onCreate", "()Z");
			global::android.content.ContentProvider._onConfigurationChanged2640 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			global::android.content.ContentProvider._onLowMemory2641 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "onLowMemory", "()V");
			global::android.content.ContentProvider._applyBatch2642 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "applyBatch", "(Ljava/util/ArrayList;)[Landroid/content/ContentProviderResult;");
			global::android.content.ContentProvider._bulkInsert2643 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "bulkInsert", "(Landroid/net/Uri;[Landroid/content/ContentValues;)I");
			global::android.content.ContentProvider._openFile2644 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "openFile", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/os/ParcelFileDescriptor;");
			global::android.content.ContentProvider._openAssetFile2645 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "openAssetFile", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/content/res/AssetFileDescriptor;");
			global::android.content.ContentProvider._setReadPermission2646 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "setReadPermission", "(Ljava/lang/String;)V");
			global::android.content.ContentProvider._getReadPermission2647 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "getReadPermission", "()Ljava/lang/String;");
			global::android.content.ContentProvider._setWritePermission2648 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "setWritePermission", "(Ljava/lang/String;)V");
			global::android.content.ContentProvider._getWritePermission2649 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "getWritePermission", "()Ljava/lang/String;");
			global::android.content.ContentProvider._setPathPermissions2650 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "setPathPermissions", "([Landroid/content/pm/PathPermission;)V");
			global::android.content.ContentProvider._getPathPermissions2651 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "getPathPermissions", "()[Landroid/content/pm/PathPermission;");
			global::android.content.ContentProvider._openFileHelper2652 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "openFileHelper", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/os/ParcelFileDescriptor;");
			global::android.content.ContentProvider._isTemporary2653 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "isTemporary", "()Z");
			global::android.content.ContentProvider._attachInfo2654 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "attachInfo", "(Landroid/content/Context;Landroid/content/pm/ProviderInfo;)V");
			global::android.content.ContentProvider._ContentProvider2655 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.ContentProvider))]
	internal sealed partial class ContentProvider_ : android.content.ContentProvider
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ContentProvider_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getType2656;
		public override global::java.lang.String getType(android.net.Uri arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProvider_._getType2656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _delete2657;
		public override int delete(android.net.Uri arg0, java.lang.String arg1, java.lang.String[] arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContentProvider_._delete2657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _insert2658;
		public override global::android.net.Uri insert(android.net.Uri arg0, android.content.ContentValues arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProvider_._insert2658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri;
		}
		internal static global::MonoJavaBridge.MethodId _query2659;
		public override global::android.database.Cursor query(android.net.Uri arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProvider_._query2659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _update2660;
		public override int update(android.net.Uri arg0, android.content.ContentValues arg1, java.lang.String arg2, java.lang.String[] arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContentProvider_._update2660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onCreate2661;
		public override bool onCreate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.ContentProvider_._onCreate2661);
		}
		static ContentProvider_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ContentProvider_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ContentProvider"));
			global::android.content.ContentProvider_._getType2656 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider_.staticClass, "getType", "(Landroid/net/Uri;)Ljava/lang/String;");
			global::android.content.ContentProvider_._delete2657 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider_.staticClass, "delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I");
			global::android.content.ContentProvider_._insert2658 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider_.staticClass, "insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;");
			global::android.content.ContentProvider_._query2659 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider_.staticClass, "query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			global::android.content.ContentProvider_._update2660 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider_.staticClass, "update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I");
			global::android.content.ContentProvider_._onCreate2661 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider_.staticClass, "onCreate", "()Z");
		}
		internal static void InitJNI()
		{
		}
	}
}
