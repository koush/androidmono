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
		internal static global::net.sf.jni4net.jni.MethodId _getContext979; 
		public virtual android.content.Context getContext() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProvider)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, _getContext979)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentProvider.staticClass, _getContext979)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getType980; 
		public abstract java.lang.String getType(android.net.Uri arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _delete981; 
		public abstract int delete(android.net.Uri arg0, java.lang.String arg1, java.lang.String[] arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _insert982; 
		public abstract android.net.Uri insert(android.net.Uri arg0, android.content.ContentValues arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _query983; 
		public abstract android.database.Cursor query(android.net.Uri arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4); 
		internal static global::net.sf.jni4net.jni.MethodId _update984; 
		public abstract int update(android.net.Uri arg0, android.content.ContentValues arg1, java.lang.String arg2, java.lang.String[] arg3); 
		internal static global::net.sf.jni4net.jni.MethodId _onCreate985; 
		public abstract bool onCreate(); 
		internal static global::net.sf.jni4net.jni.MethodId _onConfigurationChanged986; 
		public virtual void onConfigurationChanged(android.content.res.Configuration arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProvider)) 
				@__env.CallVoidMethod(this, _onConfigurationChanged986, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContentProvider.staticClass, _onConfigurationChanged986, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLowMemory987; 
		public virtual void onLowMemory() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProvider)) 
				@__env.CallVoidMethod(this, _onLowMemory987); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContentProvider.staticClass, _onLowMemory987); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _applyBatch988; 
		public virtual android.content.ContentProviderResult[] applyBatch(java.util.ArrayList arg0) 
		{ 
			if (GetType() == typeof(android.content.ContentProvider)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _applyBatch988, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentProvider.staticClass, _applyBatch988, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bulkInsert989; 
		public virtual int bulkInsert(android.net.Uri arg0, android.content.ContentValues[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProvider)) 
				return @__env.CallIntMethod(this, _bulkInsert989, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.ContentProvider.staticClass, _bulkInsert989, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _openFile990; 
		public virtual android.os.ParcelFileDescriptor openFile(android.net.Uri arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProvider)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.ParcelFileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, _openFile990, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.ParcelFileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentProvider.staticClass, _openFile990, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _openAssetFile991; 
		public virtual android.content.res.AssetFileDescriptor openAssetFile(android.net.Uri arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProvider)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetFileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, _openAssetFile991, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetFileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentProvider.staticClass, _openAssetFile991, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setReadPermission992; 
		protected virtual void setReadPermission(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProvider)) 
				@__env.CallVoidMethod(this, _setReadPermission992, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContentProvider.staticClass, _setReadPermission992, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getReadPermission993; 
		public virtual java.lang.String getReadPermission() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProvider)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getReadPermission993)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentProvider.staticClass, _getReadPermission993)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setWritePermission994; 
		protected virtual void setWritePermission(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProvider)) 
				@__env.CallVoidMethod(this, _setWritePermission994, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContentProvider.staticClass, _setWritePermission994, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWritePermission995; 
		public virtual java.lang.String getWritePermission() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProvider)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getWritePermission995)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentProvider.staticClass, _getWritePermission995)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPathPermissions996; 
		protected virtual void setPathPermissions(android.content.pm.PathPermission[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProvider)) 
				@__env.CallVoidMethod(this, _setPathPermissions996, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContentProvider.staticClass, _setPathPermissions996, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPathPermissions997; 
		public virtual android.content.pm.PathPermission[] getPathPermissions() 
		{ 
			if (GetType() == typeof(android.content.ContentProvider)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getPathPermissions997)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentProvider.staticClass, _getPathPermissions997)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _openFileHelper998; 
		protected virtual android.os.ParcelFileDescriptor openFileHelper(android.net.Uri arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProvider)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.ParcelFileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, _openFileHelper998, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.ParcelFileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentProvider.staticClass, _openFileHelper998, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isTemporary999; 
		protected virtual bool isTemporary() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProvider)) 
				return @__env.CallBooleanMethod(this, _isTemporary999); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.ContentProvider.staticClass, _isTemporary999); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _attachInfo1000; 
		public virtual void attachInfo(android.content.Context arg0, android.content.pm.ProviderInfo arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProvider)) 
				@__env.CallVoidMethod(this, _attachInfo1000, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContentProvider.staticClass, _attachInfo1000, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ContentProvider1001; 
		public ContentProvider()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.ContentProvider.staticClass, _ContentProvider1001, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.ContentProvider.staticClass = @__class; 
			global::android.content.ContentProvider._getContext979 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "getContext", "()Landroid/content/Context;"); 
			global::android.content.ContentProvider._getType980 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "getType", "(Landroid/net/Uri;)Ljava/lang/String;"); 
			global::android.content.ContentProvider._delete981 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I"); 
			global::android.content.ContentProvider._insert982 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;"); 
			global::android.content.ContentProvider._query983 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;"); 
			global::android.content.ContentProvider._update984 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I"); 
			global::android.content.ContentProvider._onCreate985 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "onCreate", "()Z"); 
			global::android.content.ContentProvider._onConfigurationChanged986 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V"); 
			global::android.content.ContentProvider._onLowMemory987 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "onLowMemory", "()V"); 
			global::android.content.ContentProvider._applyBatch988 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "applyBatch", "(Ljava/util/ArrayList;)[Landroid/content/ContentProviderResult;"); 
			global::android.content.ContentProvider._bulkInsert989 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "bulkInsert", "(Landroid/net/Uri;[Landroid/content/ContentValues;)I"); 
			global::android.content.ContentProvider._openFile990 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "openFile", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/os/ParcelFileDescriptor;"); 
			global::android.content.ContentProvider._openAssetFile991 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "openAssetFile", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/content/res/AssetFileDescriptor;"); 
			global::android.content.ContentProvider._setReadPermission992 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "setReadPermission", "(Ljava/lang/String;)V"); 
			global::android.content.ContentProvider._getReadPermission993 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "getReadPermission", "()Ljava/lang/String;"); 
			global::android.content.ContentProvider._setWritePermission994 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "setWritePermission", "(Ljava/lang/String;)V"); 
			global::android.content.ContentProvider._getWritePermission995 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "getWritePermission", "()Ljava/lang/String;"); 
			global::android.content.ContentProvider._setPathPermissions996 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "setPathPermissions", "([Landroid/content/pm/PathPermission;)V"); 
			global::android.content.ContentProvider._getPathPermissions997 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "getPathPermissions", "()[Landroid/content/pm/PathPermission;"); 
			global::android.content.ContentProvider._openFileHelper998 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "openFileHelper", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/os/ParcelFileDescriptor;"); 
			global::android.content.ContentProvider._isTemporary999 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "isTemporary", "()Z"); 
			global::android.content.ContentProvider._attachInfo1000 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "attachInfo", "(Landroid/content/Context;Landroid/content/pm/ProviderInfo;)V"); 
			global::android.content.ContentProvider._ContentProvider1001 = @__env.GetMethodID(global::android.content.ContentProvider.staticClass, "<init>", "()V"); 
		} 
	} 
} 
