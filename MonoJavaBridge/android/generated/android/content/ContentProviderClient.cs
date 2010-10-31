namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ContentProviderClient : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ContentProviderClient(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.String getType(android.net.Uri arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.ContentProviderClient.staticClass, "getType", "(Landroid/net/Uri;)Ljava/lang/String;", ref global::android.content.ContentProviderClient._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int delete(android.net.Uri arg0, java.lang.String arg1, java.lang.String[] arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.ContentProviderClient.staticClass, "delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I", ref global::android.content.ContentProviderClient._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::android.net.Uri insert(android.net.Uri arg0, android.content.ContentValues arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContentProviderClient.staticClass, "insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;", ref global::android.content.ContentProviderClient._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.net.Uri;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual bool release()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.ContentProviderClient.staticClass, "release", "()Z", ref global::android.content.ContentProviderClient._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::android.database.Cursor query(android.net.Uri arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.database.Cursor>(this, global::android.content.ContentProviderClient.staticClass, "query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;", ref global::android.content.ContentProviderClient._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4)) as android.database.Cursor;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int update(android.net.Uri arg0, android.content.ContentValues arg1, java.lang.String arg2, java.lang.String[] arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.ContentProviderClient.staticClass, "update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I", ref global::android.content.ContentProviderClient._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::android.content.ContentProviderResult[] applyBatch(java.util.ArrayList arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<android.content.ContentProviderResult>(this, global::android.content.ContentProviderClient.staticClass, "applyBatch", "(Ljava/util/ArrayList;)[Landroid/content/ContentProviderResult;", ref global::android.content.ContentProviderClient._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.ContentProviderResult[];
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual int bulkInsert(android.net.Uri arg0, android.content.ContentValues[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.ContentProviderClient.staticClass, "bulkInsert", "(Landroid/net/Uri;[Landroid/content/ContentValues;)I", ref global::android.content.ContentProviderClient._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::android.os.ParcelFileDescriptor openFile(android.net.Uri arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContentProviderClient.staticClass, "openFile", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/os/ParcelFileDescriptor;", ref global::android.content.ContentProviderClient._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.os.ParcelFileDescriptor;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::android.content.res.AssetFileDescriptor openAssetFile(android.net.Uri arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContentProviderClient.staticClass, "openAssetFile", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/content/res/AssetFileDescriptor;", ref global::android.content.ContentProviderClient._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.res.AssetFileDescriptor;
		}
		public new global::android.content.ContentProvider LocalContentProvider
		{
			get
			{
				return getLocalContentProvider();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::android.content.ContentProvider getLocalContentProvider()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContentProviderClient.staticClass, "getLocalContentProvider", "()Landroid/content/ContentProvider;", ref global::android.content.ContentProviderClient._m10) as android.content.ContentProvider;
		}
		static ContentProviderClient()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ContentProviderClient.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ContentProviderClient"));
		}
	}
}
