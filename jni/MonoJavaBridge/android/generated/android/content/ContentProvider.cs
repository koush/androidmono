namespace android.content
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class ContentProvider : java.lang.Object, ComponentCallbacks
	{
		internal static global::java.lang.Class staticClass;
		static ContentProvider()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.ContentProvider), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected ContentProvider(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getContext1111;
		public virtual global::android.content.Context getContext() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentProvider._getContext1111));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._getContext1111));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getType1112;
		public abstract global::java.lang.String getType(android.net.Uri arg0);
		internal static global::net.sf.jni4net.jni.MethodId _delete1113;
		public abstract int delete(android.net.Uri arg0, java.lang.String arg1, java.lang.String[] arg2);
		internal static global::net.sf.jni4net.jni.MethodId _insert1114;
		public abstract global::android.net.Uri insert(android.net.Uri arg0, android.content.ContentValues arg1);
		internal static global::net.sf.jni4net.jni.MethodId _query1115;
		public abstract global::android.database.Cursor query(android.net.Uri arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4);
		internal static global::net.sf.jni4net.jni.MethodId _update1116;
		public abstract int update(android.net.Uri arg0, android.content.ContentValues arg1, java.lang.String arg2, java.lang.String[] arg3);
		internal static global::net.sf.jni4net.jni.MethodId _onCreate1117;
		public abstract bool onCreate();
		internal static global::net.sf.jni4net.jni.MethodId _onConfigurationChanged1118;
		public virtual void onConfigurationChanged(android.content.res.Configuration arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContentProvider._onConfigurationChanged1118, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._onConfigurationChanged1118, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onLowMemory1119;
		public virtual void onLowMemory() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContentProvider._onLowMemory1119);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._onLowMemory1119);
		}
		internal static global::net.sf.jni4net.jni.MethodId _applyBatch1120;
		public virtual global::android.content.ContentProviderResult[] applyBatch(java.util.ArrayList arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentProvider._applyBatch1120, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._applyBatch1120, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _bulkInsert1121;
		public virtual int bulkInsert(android.net.Uri arg0, android.content.ContentValues[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.ContentProvider._bulkInsert1121, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._bulkInsert1121, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _openFile1122;
		public virtual global::android.os.ParcelFileDescriptor openFile(android.net.Uri arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.ParcelFileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentProvider._openFile1122, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.ParcelFileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._openFile1122, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _openAssetFile1123;
		public virtual global::android.content.res.AssetFileDescriptor openAssetFile(android.net.Uri arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetFileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentProvider._openAssetFile1123, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetFileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._openAssetFile1123, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setReadPermission1124;
		protected virtual void setReadPermission(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContentProvider._setReadPermission1124, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._setReadPermission1124, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getReadPermission1125;
		public virtual global::java.lang.String getReadPermission() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentProvider._getReadPermission1125));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._getReadPermission1125));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setWritePermission1126;
		protected virtual void setWritePermission(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContentProvider._setWritePermission1126, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._setWritePermission1126, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWritePermission1127;
		public virtual global::java.lang.String getWritePermission() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentProvider._getWritePermission1127));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._getWritePermission1127));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPathPermissions1128;
		protected virtual void setPathPermissions(android.content.pm.PathPermission[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContentProvider._setPathPermissions1128, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._setPathPermissions1128, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPathPermissions1129;
		public virtual global::android.content.pm.PathPermission[] getPathPermissions() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentProvider._getPathPermissions1129));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._getPathPermissions1129));
		}
		internal static global::net.sf.jni4net.jni.MethodId _openFileHelper1130;
		protected virtual global::android.os.ParcelFileDescriptor openFileHelper(android.net.Uri arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.ParcelFileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentProvider._openFileHelper1130, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.ParcelFileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._openFileHelper1130, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isTemporary1131;
		protected virtual bool isTemporary() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.ContentProvider._isTemporary1131);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._isTemporary1131);
		}
		internal static global::net.sf.jni4net.jni.MethodId _attachInfo1132;
		public virtual void attachInfo(android.content.Context arg0, android.content.pm.ProviderInfo arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContentProvider._attachInfo1132, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._attachInfo1132, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ContentProvider1133;
		public ContentProvider()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.ContentProvider.staticClass, global::android.content.ContentProvider._ContentProvider1133, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.ContentProvider.staticClass = @__class;
			global::android.content.ContentProvider._getContext1111 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "getContext", "()Landroid/content/Context;");
			global::android.content.ContentProvider._getType1112 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "getType", "(Landroid/net/Uri;)Ljava/lang/String;");
			global::android.content.ContentProvider._delete1113 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I");
			global::android.content.ContentProvider._insert1114 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;");
			global::android.content.ContentProvider._query1115 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			global::android.content.ContentProvider._update1116 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I");
			global::android.content.ContentProvider._onCreate1117 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "onCreate", "()Z");
			global::android.content.ContentProvider._onConfigurationChanged1118 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			global::android.content.ContentProvider._onLowMemory1119 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "onLowMemory", "()V");
			global::android.content.ContentProvider._applyBatch1120 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "applyBatch", "(Ljava/util/ArrayList;)[Landroid/content/ContentProviderResult;");
			global::android.content.ContentProvider._bulkInsert1121 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "bulkInsert", "(Landroid/net/Uri;[Landroid/content/ContentValues;)I");
			global::android.content.ContentProvider._openFile1122 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "openFile", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/os/ParcelFileDescriptor;");
			global::android.content.ContentProvider._openAssetFile1123 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "openAssetFile", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/content/res/AssetFileDescriptor;");
			global::android.content.ContentProvider._setReadPermission1124 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "setReadPermission", "(Ljava/lang/String;)V");
			global::android.content.ContentProvider._getReadPermission1125 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "getReadPermission", "()Ljava/lang/String;");
			global::android.content.ContentProvider._setWritePermission1126 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "setWritePermission", "(Ljava/lang/String;)V");
			global::android.content.ContentProvider._getWritePermission1127 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "getWritePermission", "()Ljava/lang/String;");
			global::android.content.ContentProvider._setPathPermissions1128 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "setPathPermissions", "([Landroid/content/pm/PathPermission;)V");
			global::android.content.ContentProvider._getPathPermissions1129 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "getPathPermissions", "()[Landroid/content/pm/PathPermission;");
			global::android.content.ContentProvider._openFileHelper1130 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "openFileHelper", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/os/ParcelFileDescriptor;");
			global::android.content.ContentProvider._isTemporary1131 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "isTemporary", "()Z");
			global::android.content.ContentProvider._attachInfo1132 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "attachInfo", "(Landroid/content/Context;Landroid/content/pm/ProviderInfo;)V");
			global::android.content.ContentProvider._ContentProvider1133 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "<init>", "()V");
		}
	}
}
