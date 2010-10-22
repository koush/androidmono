namespace android.content
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.content.ContentProvider_))]
	public abstract partial class ContentProvider : java.lang.Object, ComponentCallbacks
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ContentProvider()
		{
			InitJNI();
		}
		protected ContentProvider(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getContext2625;
		public virtual global::android.content.Context getContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProvider._getContext2625)) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._getContext2625)) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _getType2626;
		public abstract global::java.lang.String getType(android.net.Uri arg0);
		internal static global::MonoJavaBridge.MethodId _delete2627;
		public abstract int delete(android.net.Uri arg0, java.lang.String arg1, java.lang.String[] arg2);
		internal static global::MonoJavaBridge.MethodId _insert2628;
		public abstract global::android.net.Uri insert(android.net.Uri arg0, android.content.ContentValues arg1);
		internal static global::MonoJavaBridge.MethodId _query2629;
		public abstract global::android.database.Cursor query(android.net.Uri arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4);
		internal static global::MonoJavaBridge.MethodId _update2630;
		public abstract int update(android.net.Uri arg0, android.content.ContentValues arg1, java.lang.String arg2, java.lang.String[] arg3);
		internal static global::MonoJavaBridge.MethodId _onCreate2631;
		public abstract bool onCreate();
		internal static global::MonoJavaBridge.MethodId _onConfigurationChanged2632;
		public virtual void onConfigurationChanged(android.content.res.Configuration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentProvider._onConfigurationChanged2632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._onConfigurationChanged2632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLowMemory2633;
		public virtual void onLowMemory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentProvider._onLowMemory2633);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._onLowMemory2633);
		}
		internal static global::MonoJavaBridge.MethodId _applyBatch2634;
		public virtual global::android.content.ContentProviderResult[] applyBatch(java.util.ArrayList arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.ContentProviderResult>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProvider._applyBatch2634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderResult[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.ContentProviderResult>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._applyBatch2634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderResult[];
		}
		internal static global::MonoJavaBridge.MethodId _bulkInsert2635;
		public virtual int bulkInsert(android.net.Uri arg0, android.content.ContentValues[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContentProvider._bulkInsert2635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._bulkInsert2635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _openFile2636;
		public virtual global::android.os.ParcelFileDescriptor openFile(android.net.Uri arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProvider._openFile2636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.os.ParcelFileDescriptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._openFile2636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.os.ParcelFileDescriptor;
		}
		internal static global::MonoJavaBridge.MethodId _openAssetFile2637;
		public virtual global::android.content.res.AssetFileDescriptor openAssetFile(android.net.Uri arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProvider._openAssetFile2637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.res.AssetFileDescriptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._openAssetFile2637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.res.AssetFileDescriptor;
		}
		internal static global::MonoJavaBridge.MethodId _setReadPermission2638;
		protected virtual void setReadPermission(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentProvider._setReadPermission2638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._setReadPermission2638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getReadPermission2639;
		public virtual global::java.lang.String getReadPermission() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProvider._getReadPermission2639)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._getReadPermission2639)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setWritePermission2640;
		protected virtual void setWritePermission(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentProvider._setWritePermission2640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._setWritePermission2640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWritePermission2641;
		public virtual global::java.lang.String getWritePermission() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProvider._getWritePermission2641)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._getWritePermission2641)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setPathPermissions2642;
		protected virtual void setPathPermissions(android.content.pm.PathPermission[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentProvider._setPathPermissions2642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._setPathPermissions2642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPathPermissions2643;
		public virtual global::android.content.pm.PathPermission[] getPathPermissions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.PathPermission>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProvider._getPathPermissions2643)) as android.content.pm.PathPermission[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.PathPermission>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._getPathPermissions2643)) as android.content.pm.PathPermission[];
		}
		internal static global::MonoJavaBridge.MethodId _openFileHelper2644;
		protected virtual global::android.os.ParcelFileDescriptor openFileHelper(android.net.Uri arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProvider._openFileHelper2644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.os.ParcelFileDescriptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._openFileHelper2644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.os.ParcelFileDescriptor;
		}
		internal static global::MonoJavaBridge.MethodId _isTemporary2645;
		protected virtual bool isTemporary() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.ContentProvider._isTemporary2645);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._isTemporary2645);
		}
		internal static global::MonoJavaBridge.MethodId _attachInfo2646;
		public virtual void attachInfo(android.content.Context arg0, android.content.pm.ProviderInfo arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentProvider._attachInfo2646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentProvider.staticClass, global::android.content.ContentProvider._attachInfo2646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ContentProvider2647;
		public ContentProvider()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ContentProvider.staticClass, global::android.content.ContentProvider._ContentProvider2647);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ContentProvider.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ContentProvider"));
			global::android.content.ContentProvider._getContext2625 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "getContext", "()Landroid/content/Context;");
			global::android.content.ContentProvider._getType2626 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "getType", "(Landroid/net/Uri;)Ljava/lang/String;");
			global::android.content.ContentProvider._delete2627 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I");
			global::android.content.ContentProvider._insert2628 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;");
			global::android.content.ContentProvider._query2629 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			global::android.content.ContentProvider._update2630 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I");
			global::android.content.ContentProvider._onCreate2631 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "onCreate", "()Z");
			global::android.content.ContentProvider._onConfigurationChanged2632 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			global::android.content.ContentProvider._onLowMemory2633 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "onLowMemory", "()V");
			global::android.content.ContentProvider._applyBatch2634 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "applyBatch", "(Ljava/util/ArrayList;)[Landroid/content/ContentProviderResult;");
			global::android.content.ContentProvider._bulkInsert2635 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "bulkInsert", "(Landroid/net/Uri;[Landroid/content/ContentValues;)I");
			global::android.content.ContentProvider._openFile2636 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "openFile", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/os/ParcelFileDescriptor;");
			global::android.content.ContentProvider._openAssetFile2637 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "openAssetFile", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/content/res/AssetFileDescriptor;");
			global::android.content.ContentProvider._setReadPermission2638 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "setReadPermission", "(Ljava/lang/String;)V");
			global::android.content.ContentProvider._getReadPermission2639 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "getReadPermission", "()Ljava/lang/String;");
			global::android.content.ContentProvider._setWritePermission2640 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "setWritePermission", "(Ljava/lang/String;)V");
			global::android.content.ContentProvider._getWritePermission2641 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "getWritePermission", "()Ljava/lang/String;");
			global::android.content.ContentProvider._setPathPermissions2642 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "setPathPermissions", "([Landroid/content/pm/PathPermission;)V");
			global::android.content.ContentProvider._getPathPermissions2643 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "getPathPermissions", "()[Landroid/content/pm/PathPermission;");
			global::android.content.ContentProvider._openFileHelper2644 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "openFileHelper", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/os/ParcelFileDescriptor;");
			global::android.content.ContentProvider._isTemporary2645 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "isTemporary", "()Z");
			global::android.content.ContentProvider._attachInfo2646 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "attachInfo", "(Landroid/content/Context;Landroid/content/pm/ProviderInfo;)V");
			global::android.content.ContentProvider._ContentProvider2647 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.ContentProvider))]
	public sealed partial class ContentProvider_ : android.content.ContentProvider
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ContentProvider_()
		{
			InitJNI();
		}
		internal ContentProvider_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getType2648;
		public override global::java.lang.String getType(android.net.Uri arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProvider_._getType2648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProvider_.staticClass, global::android.content.ContentProvider_._getType2648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _delete2649;
		public override int delete(android.net.Uri arg0, java.lang.String arg1, java.lang.String[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContentProvider_._delete2649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ContentProvider_.staticClass, global::android.content.ContentProvider_._delete2649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _insert2650;
		public override global::android.net.Uri insert(android.net.Uri arg0, android.content.ContentValues arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProvider_._insert2650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProvider_.staticClass, global::android.content.ContentProvider_._insert2650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri;
		}
		internal static global::MonoJavaBridge.MethodId _query2651;
		public override global::android.database.Cursor query(android.net.Uri arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProvider_._query2651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProvider_.staticClass, global::android.content.ContentProvider_._query2651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _update2652;
		public override int update(android.net.Uri arg0, android.content.ContentValues arg1, java.lang.String arg2, java.lang.String[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContentProvider_._update2652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ContentProvider_.staticClass, global::android.content.ContentProvider_._update2652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onCreate2653;
		public override bool onCreate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.ContentProvider_._onCreate2653);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.ContentProvider_.staticClass, global::android.content.ContentProvider_._onCreate2653);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ContentProvider_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ContentProvider"));
			global::android.content.ContentProvider_._getType2648 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider_.staticClass, "getType", "(Landroid/net/Uri;)Ljava/lang/String;");
			global::android.content.ContentProvider_._delete2649 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider_.staticClass, "delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I");
			global::android.content.ContentProvider_._insert2650 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider_.staticClass, "insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;");
			global::android.content.ContentProvider_._query2651 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider_.staticClass, "query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			global::android.content.ContentProvider_._update2652 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider_.staticClass, "update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I");
			global::android.content.ContentProvider_._onCreate2653 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider_.staticClass, "onCreate", "()Z");
		}
	}
}
