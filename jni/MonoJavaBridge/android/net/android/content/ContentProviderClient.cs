namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ContentProviderClient : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static ContentProviderClient() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.ContentProviderClient), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.content.ContentProviderClient(@__env); 
			} 
		} 
		protected ContentProviderClient(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getType987; 
		public virtual java.lang.String getType(android.net.Uri arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProviderClient)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getType987, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentProviderClient.staticClass, _getType987, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _delete988; 
		public virtual int delete(android.net.Uri arg0, java.lang.String arg1, java.lang.String[] arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProviderClient)) 
				return @__env.CallIntMethod(this, _delete988, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.ContentProviderClient.staticClass, _delete988, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _insert989; 
		public virtual android.net.Uri insert(android.net.Uri arg0, android.content.ContentValues arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProviderClient)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallObjectMethodPtr(this, _insert989, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentProviderClient.staticClass, _insert989, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _release990; 
		public virtual bool release() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProviderClient)) 
				return @__env.CallBooleanMethod(this, _release990); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.ContentProviderClient.staticClass, _release990); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _query991; 
		public virtual android.database.Cursor query(android.net.Uri arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProviderClient)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallObjectMethodPtr(this, _query991, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentProviderClient.staticClass, _query991, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _update992; 
		public virtual int update(android.net.Uri arg0, android.content.ContentValues arg1, java.lang.String arg2, java.lang.String[] arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProviderClient)) 
				return @__env.CallIntMethod(this, _update992, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.ContentProviderClient.staticClass, _update992, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _applyBatch993; 
		public virtual android.content.ContentProviderResult[] applyBatch(java.util.ArrayList arg0) 
		{ 
			if (GetType() == typeof(android.content.ContentProviderClient)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _applyBatch993, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentProviderClient.staticClass, _applyBatch993, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bulkInsert994; 
		public virtual int bulkInsert(android.net.Uri arg0, android.content.ContentValues[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProviderClient)) 
				return @__env.CallIntMethod(this, _bulkInsert994, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.ContentProviderClient.staticClass, _bulkInsert994, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _openFile995; 
		public virtual android.os.ParcelFileDescriptor openFile(android.net.Uri arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProviderClient)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.ParcelFileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, _openFile995, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.ParcelFileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentProviderClient.staticClass, _openFile995, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _openAssetFile996; 
		public virtual android.content.res.AssetFileDescriptor openAssetFile(android.net.Uri arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProviderClient)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetFileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, _openAssetFile996, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetFileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentProviderClient.staticClass, _openAssetFile996, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocalContentProvider997; 
		public virtual android.content.ContentProvider getLocalContentProvider() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProviderClient)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProvider>(@__env, @__env.CallObjectMethodPtr(this, _getLocalContentProvider997)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProvider>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentProviderClient.staticClass, _getLocalContentProvider997)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.ContentProviderClient.staticClass = @__class; 
			global::android.content.ContentProviderClient._getType987 = @__env.GetMethodID(global::android.content.ContentProviderClient.staticClass, "getType", "(Landroid/net/Uri;)Ljava/lang/String;"); 
			global::android.content.ContentProviderClient._delete988 = @__env.GetMethodID(global::android.content.ContentProviderClient.staticClass, "delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I"); 
			global::android.content.ContentProviderClient._insert989 = @__env.GetMethodID(global::android.content.ContentProviderClient.staticClass, "insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;"); 
			global::android.content.ContentProviderClient._release990 = @__env.GetMethodID(global::android.content.ContentProviderClient.staticClass, "release", "()Z"); 
			global::android.content.ContentProviderClient._query991 = @__env.GetMethodID(global::android.content.ContentProviderClient.staticClass, "query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;"); 
			global::android.content.ContentProviderClient._update992 = @__env.GetMethodID(global::android.content.ContentProviderClient.staticClass, "update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I"); 
			global::android.content.ContentProviderClient._applyBatch993 = @__env.GetMethodID(global::android.content.ContentProviderClient.staticClass, "applyBatch", "(Ljava/util/ArrayList;)[Landroid/content/ContentProviderResult;"); 
			global::android.content.ContentProviderClient._bulkInsert994 = @__env.GetMethodID(global::android.content.ContentProviderClient.staticClass, "bulkInsert", "(Landroid/net/Uri;[Landroid/content/ContentValues;)I"); 
			global::android.content.ContentProviderClient._openFile995 = @__env.GetMethodID(global::android.content.ContentProviderClient.staticClass, "openFile", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/os/ParcelFileDescriptor;"); 
			global::android.content.ContentProviderClient._openAssetFile996 = @__env.GetMethodID(global::android.content.ContentProviderClient.staticClass, "openAssetFile", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/content/res/AssetFileDescriptor;"); 
			global::android.content.ContentProviderClient._getLocalContentProvider997 = @__env.GetMethodID(global::android.content.ContentProviderClient.staticClass, "getLocalContentProvider", "()Landroid/content/ContentProvider;"); 
		} 
	} 
} 
