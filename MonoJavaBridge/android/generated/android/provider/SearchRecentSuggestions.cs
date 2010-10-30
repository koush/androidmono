namespace android.provider
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SearchRecentSuggestions : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SearchRecentSuggestions(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _truncateHistory11329;
		protected virtual void truncateHistory(android.content.ContentResolver arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.provider.SearchRecentSuggestions.staticClass, "truncateHistory", "(Landroid/content/ContentResolver;I)V", ref global::android.provider.SearchRecentSuggestions._truncateHistory11329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clearHistory11330;
		public virtual void clearHistory()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.provider.SearchRecentSuggestions.staticClass, "clearHistory", "()V", ref global::android.provider.SearchRecentSuggestions._clearHistory11330);
		}
		internal static global::MonoJavaBridge.MethodId _saveRecentQuery11331;
		public virtual void saveRecentQuery(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.provider.SearchRecentSuggestions.staticClass, "saveRecentQuery", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::android.provider.SearchRecentSuggestions._saveRecentQuery11331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _SearchRecentSuggestions11332;
		public SearchRecentSuggestions(android.content.Context arg0, java.lang.String arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.provider.SearchRecentSuggestions._SearchRecentSuggestions11332.native == global::System.IntPtr.Zero)
				global::android.provider.SearchRecentSuggestions._SearchRecentSuggestions11332 = @__env.GetMethodIDNoThrow(global::android.provider.SearchRecentSuggestions.staticClass, "<init>", "(Landroid/content/Context;Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.SearchRecentSuggestions.staticClass, global::android.provider.SearchRecentSuggestions._SearchRecentSuggestions11332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _QUERIES_PROJECTION_1LINE11333;
		public static global::java.lang.String[] QUERIES_PROJECTION_1LINE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetStaticObjectField(global::android.provider.SearchRecentSuggestions.staticClass, _QUERIES_PROJECTION_1LINE11333)) as java.lang.String[];
			}
		}
		internal static global::MonoJavaBridge.FieldId _QUERIES_PROJECTION_2LINE11334;
		public static global::java.lang.String[] QUERIES_PROJECTION_2LINE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetStaticObjectField(global::android.provider.SearchRecentSuggestions.staticClass, _QUERIES_PROJECTION_2LINE11334)) as java.lang.String[];
			}
		}
		public static int QUERIES_PROJECTION_DATE_INDEX
		{
			get
			{
				return 1;
			}
		}
		public static int QUERIES_PROJECTION_QUERY_INDEX
		{
			get
			{
				return 2;
			}
		}
		public static int QUERIES_PROJECTION_DISPLAY1_INDEX
		{
			get
			{
				return 3;
			}
		}
		public static int QUERIES_PROJECTION_DISPLAY2_INDEX
		{
			get
			{
				return 4;
			}
		}
		static SearchRecentSuggestions()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.provider.SearchRecentSuggestions.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/SearchRecentSuggestions"));
			global::android.provider.SearchRecentSuggestions._QUERIES_PROJECTION_1LINE11333 = @__env.GetStaticFieldIDNoThrow(global::android.provider.SearchRecentSuggestions.staticClass, "QUERIES_PROJECTION_1LINE", "[Ljava/lang/String;");
			global::android.provider.SearchRecentSuggestions._QUERIES_PROJECTION_2LINE11334 = @__env.GetStaticFieldIDNoThrow(global::android.provider.SearchRecentSuggestions.staticClass, "QUERIES_PROJECTION_2LINE", "[Ljava/lang/String;");
		}
		internal static void InitJNI()
		{
		}
	}
}
