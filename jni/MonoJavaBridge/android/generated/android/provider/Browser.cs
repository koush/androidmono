namespace android.provider
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Browser : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Browser()
		{
			InitJNI();
		}
		protected Browser(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class BookmarkColumns : java.lang.Object, BaseColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static BookmarkColumns()
			{
				InitJNI();
			}
			protected BookmarkColumns(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _BookmarkColumns6983;
			public BookmarkColumns()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.Browser.BookmarkColumns.staticClass, global::android.provider.Browser.BookmarkColumns._BookmarkColumns6983);
				Init(@__env, handle);
			}
			public static global::java.lang.String URL
			{
				get
				{
					return "url";
				}
			}
			public static global::java.lang.String VISITS
			{
				get
				{
					return "visits";
				}
			}
			public static global::java.lang.String DATE
			{
				get
				{
					return "date";
				}
			}
			public static global::java.lang.String BOOKMARK
			{
				get
				{
					return "bookmark";
				}
			}
			public static global::java.lang.String TITLE
			{
				get
				{
					return "title";
				}
			}
			public static global::java.lang.String CREATED
			{
				get
				{
					return "created";
				}
			}
			public static global::java.lang.String FAVICON
			{
				get
				{
					return "favicon";
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.Browser.BookmarkColumns.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/Browser$BookmarkColumns"));
				global::android.provider.Browser.BookmarkColumns._BookmarkColumns6983 = @__env.GetMethodIDNoThrow(global::android.provider.Browser.BookmarkColumns.staticClass, "<init>", "()V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class SearchColumns : java.lang.Object, BaseColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static SearchColumns()
			{
				InitJNI();
			}
			protected SearchColumns(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _SearchColumns6984;
			public SearchColumns()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.Browser.SearchColumns.staticClass, global::android.provider.Browser.SearchColumns._SearchColumns6984);
				Init(@__env, handle);
			}
			public static global::java.lang.String URL
			{
				get
				{
					return "url";
				}
			}
			public static global::java.lang.String SEARCH
			{
				get
				{
					return "search";
				}
			}
			public static global::java.lang.String DATE
			{
				get
				{
					return "date";
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.Browser.SearchColumns.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/Browser$SearchColumns"));
				global::android.provider.Browser.SearchColumns._SearchColumns6984 = @__env.GetMethodIDNoThrow(global::android.provider.Browser.SearchColumns.staticClass, "<init>", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _saveBookmark6985;
		public static void saveBookmark(android.content.Context arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, global::android.provider.Browser._saveBookmark6985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _sendString6986;
		public static void sendString(android.content.Context arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, global::android.provider.Browser._sendString6986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAllBookmarks6987;
		public static global::android.database.Cursor getAllBookmarks(android.content.ContentResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallStaticObjectMethod(android.provider.Browser.staticClass, global::android.provider.Browser._getAllBookmarks6987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _getAllVisitedUrls6988;
		public static global::android.database.Cursor getAllVisitedUrls(android.content.ContentResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallStaticObjectMethod(android.provider.Browser.staticClass, global::android.provider.Browser._getAllVisitedUrls6988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _updateVisitedHistory6989;
		public static void updateVisitedHistory(android.content.ContentResolver arg0, java.lang.String arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, global::android.provider.Browser._updateVisitedHistory6989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _truncateHistory6990;
		public static void truncateHistory(android.content.ContentResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, global::android.provider.Browser._truncateHistory6990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _canClearHistory6991;
		public static bool canClearHistory(android.content.ContentResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.provider.Browser.staticClass, global::android.provider.Browser._canClearHistory6991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearHistory6992;
		public static void clearHistory(android.content.ContentResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, global::android.provider.Browser._clearHistory6992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deleteHistoryTimeFrame6993;
		public static void deleteHistoryTimeFrame(android.content.ContentResolver arg0, long arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, global::android.provider.Browser._deleteHistoryTimeFrame6993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _deleteFromHistory6994;
		public static void deleteFromHistory(android.content.ContentResolver arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, global::android.provider.Browser._deleteFromHistory6994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addSearchUrl6995;
		public static void addSearchUrl(android.content.ContentResolver arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, global::android.provider.Browser._addSearchUrl6995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clearSearches6996;
		public static void clearSearches(android.content.ContentResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, global::android.provider.Browser._clearSearches6996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestAllIcons6997;
		public static void requestAllIcons(android.content.ContentResolver arg0, java.lang.String arg1, android.webkit.WebIconDatabase.IconListener arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, global::android.provider.Browser._requestAllIcons6997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _Browser6998;
		public Browser()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.Browser.staticClass, global::android.provider.Browser._Browser6998);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _BOOKMARKS_URI6999;
		public static global::android.net.Uri BOOKMARKS_URI
		{
			get
			{
				return default(global::android.net.Uri);
			}
		}
		public static global::java.lang.String INITIAL_ZOOM_LEVEL
		{
			get
			{
				return "browser.initialZoomLevel";
			}
		}
		public static global::java.lang.String EXTRA_APPLICATION_ID
		{
			get
			{
				return "com.android.browser.application_id";
			}
		}
		public static global::java.lang.String EXTRA_HEADERS
		{
			get
			{
				return "com.android.browser.headers";
			}
		}
		internal static global::MonoJavaBridge.FieldId _HISTORY_PROJECTION7000;
		public static global::java.lang.String[] HISTORY_PROJECTION
		{
			get
			{
				return default(global::java.lang.String[]);
			}
		}
		public static int HISTORY_PROJECTION_ID_INDEX
		{
			get
			{
				return 0;
			}
		}
		public static int HISTORY_PROJECTION_URL_INDEX
		{
			get
			{
				return 1;
			}
		}
		public static int HISTORY_PROJECTION_VISITS_INDEX
		{
			get
			{
				return 2;
			}
		}
		public static int HISTORY_PROJECTION_DATE_INDEX
		{
			get
			{
				return 3;
			}
		}
		public static int HISTORY_PROJECTION_BOOKMARK_INDEX
		{
			get
			{
				return 4;
			}
		}
		public static int HISTORY_PROJECTION_TITLE_INDEX
		{
			get
			{
				return 5;
			}
		}
		public static int HISTORY_PROJECTION_FAVICON_INDEX
		{
			get
			{
				return 6;
			}
		}
		internal static global::MonoJavaBridge.FieldId _TRUNCATE_HISTORY_PROJECTION7001;
		public static global::java.lang.String[] TRUNCATE_HISTORY_PROJECTION
		{
			get
			{
				return default(global::java.lang.String[]);
			}
		}
		public static int TRUNCATE_HISTORY_PROJECTION_ID_INDEX
		{
			get
			{
				return 0;
			}
		}
		public static int TRUNCATE_N_OLDEST
		{
			get
			{
				return 5;
			}
		}
		internal static global::MonoJavaBridge.FieldId _SEARCHES_URI7002;
		public static global::android.net.Uri SEARCHES_URI
		{
			get
			{
				return default(global::android.net.Uri);
			}
		}
		internal static global::MonoJavaBridge.FieldId _SEARCHES_PROJECTION7003;
		public static global::java.lang.String[] SEARCHES_PROJECTION
		{
			get
			{
				return default(global::java.lang.String[]);
			}
		}
		public static int SEARCHES_PROJECTION_SEARCH_INDEX
		{
			get
			{
				return 1;
			}
		}
		public static int SEARCHES_PROJECTION_DATE_INDEX
		{
			get
			{
				return 2;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.provider.Browser.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/Browser"));
			global::android.provider.Browser._saveBookmark6985 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "saveBookmark", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.provider.Browser._sendString6986 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "sendString", "(Landroid/content/Context;Ljava/lang/String;)V");
			global::android.provider.Browser._getAllBookmarks6987 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "getAllBookmarks", "(Landroid/content/ContentResolver;)Landroid/database/Cursor;");
			global::android.provider.Browser._getAllVisitedUrls6988 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "getAllVisitedUrls", "(Landroid/content/ContentResolver;)Landroid/database/Cursor;");
			global::android.provider.Browser._updateVisitedHistory6989 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "updateVisitedHistory", "(Landroid/content/ContentResolver;Ljava/lang/String;Z)V");
			global::android.provider.Browser._truncateHistory6990 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "truncateHistory", "(Landroid/content/ContentResolver;)V");
			global::android.provider.Browser._canClearHistory6991 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "canClearHistory", "(Landroid/content/ContentResolver;)Z");
			global::android.provider.Browser._clearHistory6992 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "clearHistory", "(Landroid/content/ContentResolver;)V");
			global::android.provider.Browser._deleteHistoryTimeFrame6993 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "deleteHistoryTimeFrame", "(Landroid/content/ContentResolver;JJ)V");
			global::android.provider.Browser._deleteFromHistory6994 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "deleteFromHistory", "(Landroid/content/ContentResolver;Ljava/lang/String;)V");
			global::android.provider.Browser._addSearchUrl6995 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "addSearchUrl", "(Landroid/content/ContentResolver;Ljava/lang/String;)V");
			global::android.provider.Browser._clearSearches6996 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "clearSearches", "(Landroid/content/ContentResolver;)V");
			global::android.provider.Browser._requestAllIcons6997 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "requestAllIcons", "(Landroid/content/ContentResolver;Ljava/lang/String;Landroid/webkit/WebIconDatabase$IconListener;)V");
			global::android.provider.Browser._Browser6998 = @__env.GetMethodIDNoThrow(global::android.provider.Browser.staticClass, "<init>", "()V");
		}
	}
}
