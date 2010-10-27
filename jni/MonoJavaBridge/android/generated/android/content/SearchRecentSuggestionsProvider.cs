namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SearchRecentSuggestionsProvider : android.content.ContentProvider
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SearchRecentSuggestionsProvider()
		{
			InitJNI();
		}
		protected SearchRecentSuggestionsProvider(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getType3500;
		public override global::java.lang.String getType(android.net.Uri arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.SearchRecentSuggestionsProvider._getType3500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.SearchRecentSuggestionsProvider.staticClass, global::android.content.SearchRecentSuggestionsProvider._getType3500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _delete3501;
		public override int delete(android.net.Uri arg0, java.lang.String arg1, java.lang.String[] arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.SearchRecentSuggestionsProvider._delete3501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.SearchRecentSuggestionsProvider.staticClass, global::android.content.SearchRecentSuggestionsProvider._delete3501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _insert3502;
		public override global::android.net.Uri insert(android.net.Uri arg0, android.content.ContentValues arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.SearchRecentSuggestionsProvider._insert3502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.SearchRecentSuggestionsProvider.staticClass, global::android.content.SearchRecentSuggestionsProvider._insert3502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri;
		}
		internal static global::MonoJavaBridge.MethodId _query3503;
		public override global::android.database.Cursor query(android.net.Uri arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.SearchRecentSuggestionsProvider._query3503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.SearchRecentSuggestionsProvider.staticClass, global::android.content.SearchRecentSuggestionsProvider._query3503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _update3504;
		public override int update(android.net.Uri arg0, android.content.ContentValues arg1, java.lang.String arg2, java.lang.String[] arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.SearchRecentSuggestionsProvider._update3504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.SearchRecentSuggestionsProvider.staticClass, global::android.content.SearchRecentSuggestionsProvider._update3504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onCreate3505;
		public override bool onCreate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.SearchRecentSuggestionsProvider._onCreate3505);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.SearchRecentSuggestionsProvider.staticClass, global::android.content.SearchRecentSuggestionsProvider._onCreate3505);
		}
		internal static global::MonoJavaBridge.MethodId _setupSuggestions3506;
		protected virtual void setupSuggestions(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.SearchRecentSuggestionsProvider._setupSuggestions3506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.SearchRecentSuggestionsProvider.staticClass, global::android.content.SearchRecentSuggestionsProvider._setupSuggestions3506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _SearchRecentSuggestionsProvider3507;
		public SearchRecentSuggestionsProvider() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.SearchRecentSuggestionsProvider.staticClass, global::android.content.SearchRecentSuggestionsProvider._SearchRecentSuggestionsProvider3507);
			Init(@__env, handle);
		}
		public static int DATABASE_MODE_QUERIES
		{
			get
			{
				return 1;
			}
		}
		public static int DATABASE_MODE_2LINES
		{
			get
			{
				return 2;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.SearchRecentSuggestionsProvider.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/SearchRecentSuggestionsProvider"));
			global::android.content.SearchRecentSuggestionsProvider._getType3500 = @__env.GetMethodIDNoThrow(global::android.content.SearchRecentSuggestionsProvider.staticClass, "getType", "(Landroid/net/Uri;)Ljava/lang/String;");
			global::android.content.SearchRecentSuggestionsProvider._delete3501 = @__env.GetMethodIDNoThrow(global::android.content.SearchRecentSuggestionsProvider.staticClass, "delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I");
			global::android.content.SearchRecentSuggestionsProvider._insert3502 = @__env.GetMethodIDNoThrow(global::android.content.SearchRecentSuggestionsProvider.staticClass, "insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;");
			global::android.content.SearchRecentSuggestionsProvider._query3503 = @__env.GetMethodIDNoThrow(global::android.content.SearchRecentSuggestionsProvider.staticClass, "query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			global::android.content.SearchRecentSuggestionsProvider._update3504 = @__env.GetMethodIDNoThrow(global::android.content.SearchRecentSuggestionsProvider.staticClass, "update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I");
			global::android.content.SearchRecentSuggestionsProvider._onCreate3505 = @__env.GetMethodIDNoThrow(global::android.content.SearchRecentSuggestionsProvider.staticClass, "onCreate", "()Z");
			global::android.content.SearchRecentSuggestionsProvider._setupSuggestions3506 = @__env.GetMethodIDNoThrow(global::android.content.SearchRecentSuggestionsProvider.staticClass, "setupSuggestions", "(Ljava/lang/String;I)V");
			global::android.content.SearchRecentSuggestionsProvider._SearchRecentSuggestionsProvider3507 = @__env.GetMethodIDNoThrow(global::android.content.SearchRecentSuggestionsProvider.staticClass, "<init>", "()V");
		}
	}
}
