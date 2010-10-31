namespace android.content
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.content.ContentProvider_))]
	public abstract partial class ContentProvider : java.lang.Object, ComponentCallbacks
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ContentProvider(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::android.content.Context getContext()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContentProvider.staticClass, "getContext", "()Landroid/content/Context;", ref global::android.content.ContentProvider._m0) as android.content.Context;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract global::java.lang.String getType(android.net.Uri arg0);
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract int delete(android.net.Uri arg0, java.lang.String arg1, java.lang.String[] arg2);
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract global::android.net.Uri insert(android.net.Uri arg0, android.content.ContentValues arg1);
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract global::android.database.Cursor query(android.net.Uri arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4);
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract int update(android.net.Uri arg0, android.content.ContentValues arg1, java.lang.String arg2, java.lang.String[] arg3);
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract bool onCreate();
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void onConfigurationChanged(android.content.res.Configuration arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentProvider.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V", ref global::android.content.ContentProvider._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void onLowMemory()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentProvider.staticClass, "onLowMemory", "()V", ref global::android.content.ContentProvider._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::android.content.ContentProviderResult[] applyBatch(java.util.ArrayList arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<android.content.ContentProviderResult>(this, global::android.content.ContentProvider.staticClass, "applyBatch", "(Ljava/util/ArrayList;)[Landroid/content/ContentProviderResult;", ref global::android.content.ContentProvider._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.ContentProviderResult[];
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual int bulkInsert(android.net.Uri arg0, android.content.ContentValues[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.ContentProvider.staticClass, "bulkInsert", "(Landroid/net/Uri;[Landroid/content/ContentValues;)I", ref global::android.content.ContentProvider._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::android.os.ParcelFileDescriptor openFile(android.net.Uri arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContentProvider.staticClass, "openFile", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/os/ParcelFileDescriptor;", ref global::android.content.ContentProvider._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.os.ParcelFileDescriptor;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::android.content.res.AssetFileDescriptor openAssetFile(android.net.Uri arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContentProvider.staticClass, "openAssetFile", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/content/res/AssetFileDescriptor;", ref global::android.content.ContentProvider._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.res.AssetFileDescriptor;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		protected virtual void setReadPermission(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentProvider.staticClass, "setReadPermission", "(Ljava/lang/String;)V", ref global::android.content.ContentProvider._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::java.lang.String getReadPermission()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.ContentProvider.staticClass, "getReadPermission", "()Ljava/lang/String;", ref global::android.content.ContentProvider._m14) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		protected virtual void setWritePermission(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentProvider.staticClass, "setWritePermission", "(Ljava/lang/String;)V", ref global::android.content.ContentProvider._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual global::java.lang.String getWritePermission()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.ContentProvider.staticClass, "getWritePermission", "()Ljava/lang/String;", ref global::android.content.ContentProvider._m16) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		protected virtual void setPathPermissions(android.content.pm.PathPermission[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentProvider.staticClass, "setPathPermissions", "([Landroid/content/pm/PathPermission;)V", ref global::android.content.ContentProvider._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual global::android.content.pm.PathPermission[] getPathPermissions()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<android.content.pm.PathPermission>(this, global::android.content.ContentProvider.staticClass, "getPathPermissions", "()[Landroid/content/pm/PathPermission;", ref global::android.content.ContentProvider._m18) as android.content.pm.PathPermission[];
		}
		private static global::MonoJavaBridge.MethodId _m19;
		protected virtual global::android.os.ParcelFileDescriptor openFileHelper(android.net.Uri arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContentProvider.staticClass, "openFileHelper", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/os/ParcelFileDescriptor;", ref global::android.content.ContentProvider._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.os.ParcelFileDescriptor;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		protected virtual bool isTemporary()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.ContentProvider.staticClass, "isTemporary", "()Z", ref global::android.content.ContentProvider._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void attachInfo(android.content.Context arg0, android.content.pm.ProviderInfo arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentProvider.staticClass, "attachInfo", "(Landroid/content/Context;Landroid/content/pm/ProviderInfo;)V", ref global::android.content.ContentProvider._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public ContentProvider() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContentProvider._m22.native == global::System.IntPtr.Zero)
				global::android.content.ContentProvider._m22 = @__env.GetMethodIDNoThrow(global::android.content.ContentProvider.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ContentProvider.staticClass, global::android.content.ContentProvider._m22);
			Init(@__env, handle);
		}
		static ContentProvider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ContentProvider.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ContentProvider"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.ContentProvider))]
	internal sealed partial class ContentProvider_ : android.content.ContentProvider
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ContentProvider_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String getType(android.net.Uri arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.ContentProvider_.staticClass, "getType", "(Landroid/net/Uri;)Ljava/lang/String;", ref global::android.content.ContentProvider_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int delete(android.net.Uri arg0, java.lang.String arg1, java.lang.String[] arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.ContentProvider_.staticClass, "delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I", ref global::android.content.ContentProvider_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::android.net.Uri insert(android.net.Uri arg0, android.content.ContentValues arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContentProvider_.staticClass, "insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;", ref global::android.content.ContentProvider_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.net.Uri;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::android.database.Cursor query(android.net.Uri arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.database.Cursor>(this, global::android.content.ContentProvider_.staticClass, "query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;", ref global::android.content.ContentProvider_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4)) as android.database.Cursor;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int update(android.net.Uri arg0, android.content.ContentValues arg1, java.lang.String arg2, java.lang.String[] arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.ContentProvider_.staticClass, "update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I", ref global::android.content.ContentProvider_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override bool onCreate()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.ContentProvider_.staticClass, "onCreate", "()Z", ref global::android.content.ContentProvider_._m5);
		}
		static ContentProvider_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ContentProvider_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ContentProvider"));
		}
	}
}
