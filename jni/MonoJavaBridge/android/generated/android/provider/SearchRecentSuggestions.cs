namespace android.provider
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SearchRecentSuggestions : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SearchRecentSuggestions()
		{
			InitJNI();
		}
		protected SearchRecentSuggestions(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _truncateHistory7175;
		protected virtual void truncateHistory(android.content.ContentResolver arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.provider.SearchRecentSuggestions._truncateHistory7175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.provider.SearchRecentSuggestions.staticClass, global::android.provider.SearchRecentSuggestions._truncateHistory7175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clearHistory7176;
		public virtual void clearHistory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.provider.SearchRecentSuggestions._clearHistory7176);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.provider.SearchRecentSuggestions.staticClass, global::android.provider.SearchRecentSuggestions._clearHistory7176);
		}
		internal static global::MonoJavaBridge.MethodId _saveRecentQuery7177;
		public virtual void saveRecentQuery(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.provider.SearchRecentSuggestions._saveRecentQuery7177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.provider.SearchRecentSuggestions.staticClass, global::android.provider.SearchRecentSuggestions._saveRecentQuery7177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _SearchRecentSuggestions7178;
		public SearchRecentSuggestions(android.content.Context arg0, java.lang.String arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.SearchRecentSuggestions.staticClass, global::android.provider.SearchRecentSuggestions._SearchRecentSuggestions7178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _QUERIES_PROJECTION_1LINE7179;
		public static global::java.lang.String[] QUERIES_PROJECTION_1LINE
		{
			get
			{
				return default(global::java.lang.String[]);
			}
		}
		internal static global::MonoJavaBridge.FieldId _QUERIES_PROJECTION_2LINE7180;
		public static global::java.lang.String[] QUERIES_PROJECTION_2LINE
		{
			get
			{
				return default(global::java.lang.String[]);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.provider.SearchRecentSuggestions.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/SearchRecentSuggestions"));
			global::android.provider.SearchRecentSuggestions._truncateHistory7175 = @__env.GetMethodIDNoThrow(global::android.provider.SearchRecentSuggestions.staticClass, "truncateHistory", "(Landroid/content/ContentResolver;I)V");
			global::android.provider.SearchRecentSuggestions._clearHistory7176 = @__env.GetMethodIDNoThrow(global::android.provider.SearchRecentSuggestions.staticClass, "clearHistory", "()V");
			global::android.provider.SearchRecentSuggestions._saveRecentQuery7177 = @__env.GetMethodIDNoThrow(global::android.provider.SearchRecentSuggestions.staticClass, "saveRecentQuery", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.provider.SearchRecentSuggestions._SearchRecentSuggestions7178 = @__env.GetMethodIDNoThrow(global::android.provider.SearchRecentSuggestions.staticClass, "<init>", "(Landroid/content/Context;Ljava/lang/String;I)V");
		}
	}
}
