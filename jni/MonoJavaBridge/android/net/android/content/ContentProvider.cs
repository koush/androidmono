namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class ContentProvider : java.lang.Object, ComponentCallbacks
	{ 
		internal static global::java.lang.Class staticClass; 
		static ContentProvider() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.ContentProvider), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected ContentProvider(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContext964; 
		public virtual android.content.Context getContext() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProvider)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, _getContext964)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentProvider.staticClass, _getContext964)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getType965; 
		public abstract java.lang.String getType(android.net.Uri arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _delete966; 
		public abstract int delete(android.net.Uri arg0, java.lang.String arg1, java.lang.String[] arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _insert967; 
		public abstract android.net.Uri insert(android.net.Uri arg0, android.content.ContentValues arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _query968; 
		public abstract android.database.Cursor query(android.net.Uri arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4); 
		internal static global::net.sf.jni4net.jni.MethodId _update969; 
		public abstract int update(android.net.Uri arg0, android.content.ContentValues arg1, java.lang.String arg2, java.lang.String[] arg3); 
		internal static global::net.sf.jni4net.jni.MethodId _onCreate970; 
		public abstract bool onCreate(); 
		internal static global::net.sf.jni4net.jni.MethodId _onConfigurationChanged971; 
		public virtual void onConfigurationChanged(android.content.res.Configuration arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProvider)) 
				@__env.CallVoidMethod(this, _onConfigurationChanged971, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContentProvider.staticClass, _onConfigurationChanged971, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLowMemory972; 
		public virtual void onLowMemory() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProvider)) 
				@__env.CallVoidMethod(this, _onLowMemory972); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContentProvider.staticClass, _onLowMemory972); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _applyBatch973; 
		public virtual android.content.ContentProviderResult[] applyBatch(java.util.ArrayList arg0) 
		{ 
			if (GetType() == typeof(android.content.ContentProvider)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _applyBatch973, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentProvider.staticClass, _applyBatch973, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bulkInsert974; 
		public virtual int bulkInsert(android.net.Uri arg0, android.content.ContentValues[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProvider)) 
				return @__env.CallIntMethod(this, _bulkInsert974, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.ContentProvider.staticClass, _bulkInsert974, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _openFile975; 
		public virtual android.os.ParcelFileDescriptor openFile(android.net.Uri arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProvider)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.ParcelFileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, _openFile975, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.ParcelFileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentProvider.staticClass, _openFile975, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _openAssetFile976; 
		public virtual android.content.res.AssetFileDescriptor openAssetFile(android.net.Uri arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProvider)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetFileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, _openAssetFile976, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetFileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentProvider.staticClass, _openAssetFile976, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setReadPermission977; 
		protected virtual void setReadPermission(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProvider)) 
				@__env.CallVoidMethod(this, _setReadPermission977, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContentProvider.staticClass, _setReadPermission977, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getReadPermission978; 
		public virtual java.lang.String getReadPermission() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProvider)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getReadPermission978)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentProvider.staticClass, _getReadPermission978)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setWritePermission979; 
		protected virtual void setWritePermission(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProvider)) 
				@__env.CallVoidMethod(this, _setWritePermission979, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContentProvider.staticClass, _setWritePermission979, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWritePermission980; 
		public virtual java.lang.String getWritePermission() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProvider)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getWritePermission980)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentProvider.staticClass, _getWritePermission980)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPathPermissions981; 
		protected virtual void setPathPermissions(android.content.pm.PathPermission[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProvider)) 
				@__env.CallVoidMethod(this, _setPathPermissions981, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContentProvider.staticClass, _setPathPermissions981, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPathPermissions982; 
		public virtual android.content.pm.PathPermission[] getPathPermissions() 
		{ 
			if (GetType() == typeof(android.content.ContentProvider)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getPathPermissions982)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentProvider.staticClass, _getPathPermissions982)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _openFileHelper983; 
		protected virtual android.os.ParcelFileDescriptor openFileHelper(android.net.Uri arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProvider)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.ParcelFileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, _openFileHelper983, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.ParcelFileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentProvider.staticClass, _openFileHelper983, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isTemporary984; 
		protected virtual bool isTemporary() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProvider)) 
				return @__env.CallBooleanMethod(this, _isTemporary984); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.ContentProvider.staticClass, _isTemporary984); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _attachInfo985; 
		public virtual void attachInfo(android.content.Context arg0, android.content.pm.ProviderInfo arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProvider)) 
				@__env.CallVoidMethod(this, _attachInfo985, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContentProvider.staticClass, _attachInfo985, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ContentProvider986; 
		public ContentProvider()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.ContentProvider.staticClass, _ContentProvider986, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.ContentProvider.staticClass = @__class; 
			global::android.content.ContentProvider._getContext964 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "getContext", "()Landroid/content/Context;"); 
			global::android.content.ContentProvider._getType965 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "getType", "(Landroid/net/Uri;)Ljava/lang/String;"); 
			global::android.content.ContentProvider._delete966 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I"); 
			global::android.content.ContentProvider._insert967 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;"); 
			global::android.content.ContentProvider._query968 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;"); 
			global::android.content.ContentProvider._update969 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I"); 
			global::android.content.ContentProvider._onCreate970 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "onCreate", "()Z"); 
			global::android.content.ContentProvider._onConfigurationChanged971 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V"); 
			global::android.content.ContentProvider._onLowMemory972 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "onLowMemory", "()V"); 
			global::android.content.ContentProvider._applyBatch973 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "applyBatch", "(Ljava/util/ArrayList;)[Landroid/content/ContentProviderResult;"); 
			global::android.content.ContentProvider._bulkInsert974 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "bulkInsert", "(Landroid/net/Uri;[Landroid/content/ContentValues;)I"); 
			global::android.content.ContentProvider._openFile975 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "openFile", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/os/ParcelFileDescriptor;"); 
			global::android.content.ContentProvider._openAssetFile976 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "openAssetFile", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/content/res/AssetFileDescriptor;"); 
			global::android.content.ContentProvider._setReadPermission977 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "setReadPermission", "(Ljava/lang/String;)V"); 
			global::android.content.ContentProvider._getReadPermission978 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "getReadPermission", "()Ljava/lang/String;"); 
			global::android.content.ContentProvider._setWritePermission979 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "setWritePermission", "(Ljava/lang/String;)V"); 
			global::android.content.ContentProvider._getWritePermission980 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "getWritePermission", "()Ljava/lang/String;"); 
			global::android.content.ContentProvider._setPathPermissions981 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "setPathPermissions", "([Landroid/content/pm/PathPermission;)V"); 
			global::android.content.ContentProvider._getPathPermissions982 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "getPathPermissions", "()[Landroid/content/pm/PathPermission;"); 
			global::android.content.ContentProvider._openFileHelper983 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "openFileHelper", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/os/ParcelFileDescriptor;"); 
			global::android.content.ContentProvider._isTemporary984 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "isTemporary", "()Z"); 
			global::android.content.ContentProvider._attachInfo985 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "attachInfo", "(Landroid/content/Context;Landroid/content/pm/ProviderInfo;)V"); 
			global::android.content.ContentProvider._ContentProvider986 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "<init>", "()V"); 
		} 
	} 
} 
