namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SearchRecentSuggestionsProvider : android.content.ContentProvider
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SearchRecentSuggestionsProvider(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String getType(android.net.Uri arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.SearchRecentSuggestionsProvider.staticClass, "getType", "(Landroid/net/Uri;)Ljava/lang/String;", ref global::android.content.SearchRecentSuggestionsProvider._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int delete(android.net.Uri arg0, java.lang.String arg1, java.lang.String[] arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.SearchRecentSuggestionsProvider.staticClass, "delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I", ref global::android.content.SearchRecentSuggestionsProvider._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::android.net.Uri insert(android.net.Uri arg0, android.content.ContentValues arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.SearchRecentSuggestionsProvider.staticClass, "insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;", ref global::android.content.SearchRecentSuggestionsProvider._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.net.Uri;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::android.database.Cursor query(android.net.Uri arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.database.Cursor>(this, global::android.content.SearchRecentSuggestionsProvider.staticClass, "query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;", ref global::android.content.SearchRecentSuggestionsProvider._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4)) as android.database.Cursor;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int update(android.net.Uri arg0, android.content.ContentValues arg1, java.lang.String arg2, java.lang.String[] arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.SearchRecentSuggestionsProvider.staticClass, "update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I", ref global::android.content.SearchRecentSuggestionsProvider._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override bool onCreate()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.SearchRecentSuggestionsProvider.staticClass, "onCreate", "()Z", ref global::android.content.SearchRecentSuggestionsProvider._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected virtual void setupSuggestions(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.SearchRecentSuggestionsProvider.staticClass, "setupSuggestions", "(Ljava/lang/String;I)V", ref global::android.content.SearchRecentSuggestionsProvider._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public SearchRecentSuggestionsProvider() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.SearchRecentSuggestionsProvider._m7.native == global::System.IntPtr.Zero)
				global::android.content.SearchRecentSuggestionsProvider._m7 = @__env.GetMethodIDNoThrow(global::android.content.SearchRecentSuggestionsProvider.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.SearchRecentSuggestionsProvider.staticClass, global::android.content.SearchRecentSuggestionsProvider._m7);
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
		static SearchRecentSuggestionsProvider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.SearchRecentSuggestionsProvider.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/SearchRecentSuggestionsProvider"));
		}
	}
}
