namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ContentProviderClient : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ContentProviderClient()
		{
			InitJNI();
		}
		protected ContentProviderClient(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getType2662;
		public virtual global::java.lang.String getType(android.net.Uri arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProviderClient._getType2662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProviderClient.staticClass, global::android.content.ContentProviderClient._getType2662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _delete2663;
		public virtual int delete(android.net.Uri arg0, java.lang.String arg1, java.lang.String[] arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContentProviderClient._delete2663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ContentProviderClient.staticClass, global::android.content.ContentProviderClient._delete2663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _insert2664;
		public virtual global::android.net.Uri insert(android.net.Uri arg0, android.content.ContentValues arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProviderClient._insert2664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProviderClient.staticClass, global::android.content.ContentProviderClient._insert2664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri;
		}
		internal static global::MonoJavaBridge.MethodId _release2665;
		public virtual bool release()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.ContentProviderClient._release2665);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.ContentProviderClient.staticClass, global::android.content.ContentProviderClient._release2665);
		}
		internal static global::MonoJavaBridge.MethodId _query2666;
		public virtual global::android.database.Cursor query(android.net.Uri arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProviderClient._query2666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProviderClient.staticClass, global::android.content.ContentProviderClient._query2666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _update2667;
		public virtual int update(android.net.Uri arg0, android.content.ContentValues arg1, java.lang.String arg2, java.lang.String[] arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContentProviderClient._update2667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ContentProviderClient.staticClass, global::android.content.ContentProviderClient._update2667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _applyBatch2668;
		public virtual global::android.content.ContentProviderResult[] applyBatch(java.util.ArrayList arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.ContentProviderResult>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProviderClient._applyBatch2668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderResult[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.ContentProviderResult>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProviderClient.staticClass, global::android.content.ContentProviderClient._applyBatch2668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderResult[];
		}
		internal static global::MonoJavaBridge.MethodId _bulkInsert2669;
		public virtual int bulkInsert(android.net.Uri arg0, android.content.ContentValues[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContentProviderClient._bulkInsert2669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ContentProviderClient.staticClass, global::android.content.ContentProviderClient._bulkInsert2669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _openFile2670;
		public virtual global::android.os.ParcelFileDescriptor openFile(android.net.Uri arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProviderClient._openFile2670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.os.ParcelFileDescriptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProviderClient.staticClass, global::android.content.ContentProviderClient._openFile2670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.os.ParcelFileDescriptor;
		}
		internal static global::MonoJavaBridge.MethodId _openAssetFile2671;
		public virtual global::android.content.res.AssetFileDescriptor openAssetFile(android.net.Uri arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProviderClient._openAssetFile2671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.res.AssetFileDescriptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProviderClient.staticClass, global::android.content.ContentProviderClient._openAssetFile2671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.res.AssetFileDescriptor;
		}
		public new global::android.content.ContentProvider LocalContentProvider
		{
			get
			{
				return getLocalContentProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalContentProvider2672;
		public virtual global::android.content.ContentProvider getLocalContentProvider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProviderClient._getLocalContentProvider2672)) as android.content.ContentProvider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProviderClient.staticClass, global::android.content.ContentProviderClient._getLocalContentProvider2672)) as android.content.ContentProvider;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ContentProviderClient.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ContentProviderClient"));
			global::android.content.ContentProviderClient._getType2662 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderClient.staticClass, "getType", "(Landroid/net/Uri;)Ljava/lang/String;");
			global::android.content.ContentProviderClient._delete2663 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderClient.staticClass, "delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I");
			global::android.content.ContentProviderClient._insert2664 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderClient.staticClass, "insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;");
			global::android.content.ContentProviderClient._release2665 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderClient.staticClass, "release", "()Z");
			global::android.content.ContentProviderClient._query2666 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderClient.staticClass, "query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			global::android.content.ContentProviderClient._update2667 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderClient.staticClass, "update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I");
			global::android.content.ContentProviderClient._applyBatch2668 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderClient.staticClass, "applyBatch", "(Ljava/util/ArrayList;)[Landroid/content/ContentProviderResult;");
			global::android.content.ContentProviderClient._bulkInsert2669 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderClient.staticClass, "bulkInsert", "(Landroid/net/Uri;[Landroid/content/ContentValues;)I");
			global::android.content.ContentProviderClient._openFile2670 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderClient.staticClass, "openFile", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/os/ParcelFileDescriptor;");
			global::android.content.ContentProviderClient._openAssetFile2671 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderClient.staticClass, "openAssetFile", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/content/res/AssetFileDescriptor;");
			global::android.content.ContentProviderClient._getLocalContentProvider2672 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderClient.staticClass, "getLocalContentProvider", "()Landroid/content/ContentProvider;");
		}
	}
}
