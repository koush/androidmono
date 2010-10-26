namespace android.test.mock
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MockContentProvider : android.content.ContentProvider
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MockContentProvider()
		{
			InitJNI();
		}
		protected MockContentProvider(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getType12383;
		public override global::java.lang.String getType(android.net.Uri arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockContentProvider._getType12383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockContentProvider.staticClass, global::android.test.mock.MockContentProvider._getType12383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _delete12384;
		public override int delete(android.net.Uri arg0, java.lang.String arg1, java.lang.String[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockContentProvider._delete12384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockContentProvider.staticClass, global::android.test.mock.MockContentProvider._delete12384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _insert12385;
		public override global::android.net.Uri insert(android.net.Uri arg0, android.content.ContentValues arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockContentProvider._insert12385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockContentProvider.staticClass, global::android.test.mock.MockContentProvider._insert12385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri;
		}
		internal static global::MonoJavaBridge.MethodId _query12386;
		public override global::android.database.Cursor query(android.net.Uri arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockContentProvider._query12386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockContentProvider.staticClass, global::android.test.mock.MockContentProvider._query12386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _update12387;
		public override int update(android.net.Uri arg0, android.content.ContentValues arg1, java.lang.String arg2, java.lang.String[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockContentProvider._update12387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockContentProvider.staticClass, global::android.test.mock.MockContentProvider._update12387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onCreate12388;
		public override bool onCreate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockContentProvider._onCreate12388);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockContentProvider.staticClass, global::android.test.mock.MockContentProvider._onCreate12388);
		}
		internal static global::MonoJavaBridge.MethodId _applyBatch12389;
		public override global::android.content.ContentProviderResult[] applyBatch(java.util.ArrayList arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.ContentProviderResult>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockContentProvider._applyBatch12389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderResult[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.ContentProviderResult>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockContentProvider.staticClass, global::android.test.mock.MockContentProvider._applyBatch12389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderResult[];
		}
		internal static global::MonoJavaBridge.MethodId _bulkInsert12390;
		public override int bulkInsert(android.net.Uri arg0, android.content.ContentValues[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockContentProvider._bulkInsert12390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockContentProvider.staticClass, global::android.test.mock.MockContentProvider._bulkInsert12390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _attachInfo12391;
		public override void attachInfo(android.content.Context arg0, android.content.pm.ProviderInfo arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockContentProvider._attachInfo12391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockContentProvider.staticClass, global::android.test.mock.MockContentProvider._attachInfo12391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _MockContentProvider12392;
		protected MockContentProvider()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.mock.MockContentProvider.staticClass, global::android.test.mock.MockContentProvider._MockContentProvider12392);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MockContentProvider12393;
		public MockContentProvider(android.content.Context arg0, java.lang.String arg1, java.lang.String arg2, android.content.pm.PathPermission[] arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.mock.MockContentProvider.staticClass, global::android.test.mock.MockContentProvider._MockContentProvider12393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MockContentProvider12394;
		public MockContentProvider(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.mock.MockContentProvider.staticClass, global::android.test.mock.MockContentProvider._MockContentProvider12394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.mock.MockContentProvider.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/mock/MockContentProvider"));
			global::android.test.mock.MockContentProvider._getType12383 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContentProvider.staticClass, "getType", "(Landroid/net/Uri;)Ljava/lang/String;");
			global::android.test.mock.MockContentProvider._delete12384 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContentProvider.staticClass, "delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I");
			global::android.test.mock.MockContentProvider._insert12385 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContentProvider.staticClass, "insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;");
			global::android.test.mock.MockContentProvider._query12386 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContentProvider.staticClass, "query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			global::android.test.mock.MockContentProvider._update12387 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContentProvider.staticClass, "update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I");
			global::android.test.mock.MockContentProvider._onCreate12388 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContentProvider.staticClass, "onCreate", "()Z");
			global::android.test.mock.MockContentProvider._applyBatch12389 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContentProvider.staticClass, "applyBatch", "(Ljava/util/ArrayList;)[Landroid/content/ContentProviderResult;");
			global::android.test.mock.MockContentProvider._bulkInsert12390 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContentProvider.staticClass, "bulkInsert", "(Landroid/net/Uri;[Landroid/content/ContentValues;)I");
			global::android.test.mock.MockContentProvider._attachInfo12391 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContentProvider.staticClass, "attachInfo", "(Landroid/content/Context;Landroid/content/pm/ProviderInfo;)V");
			global::android.test.mock.MockContentProvider._MockContentProvider12392 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContentProvider.staticClass, "<init>", "()V");
			global::android.test.mock.MockContentProvider._MockContentProvider12393 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContentProvider.staticClass, "<init>", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[Landroid/content/pm/PathPermission;)V");
			global::android.test.mock.MockContentProvider._MockContentProvider12394 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContentProvider.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
