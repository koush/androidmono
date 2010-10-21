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
			internal static global::MonoJavaBridge.MethodId _BookmarkColumns10422;
			public BookmarkColumns()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.Browser.BookmarkColumns.staticClass, global::android.provider.Browser.BookmarkColumns._BookmarkColumns10422);
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
				global::android.provider.Browser.BookmarkColumns._BookmarkColumns10422 = @__env.GetMethodIDNoThrow(global::android.provider.Browser.BookmarkColumns.staticClass, "<init>", "()V");
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
			internal static global::MonoJavaBridge.MethodId _SearchColumns10430;
			public SearchColumns()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.Browser.SearchColumns.staticClass, global::android.provider.Browser.SearchColumns._SearchColumns10430);
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
				global::android.provider.Browser.SearchColumns._SearchColumns10430 = @__env.GetMethodIDNoThrow(global::android.provider.Browser.SearchColumns.staticClass, "<init>", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _saveBookmark10434;
		public static void saveBookmark(android.content.Context arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, global::android.provider.Browser._saveBookmark10434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _sendString10435;
		public static void sendString(android.content.Context arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, global::android.provider.Browser._sendString10435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAllBookmarks10436;
		public static global::android.database.Cursor getAllBookmarks(android.content.ContentResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallStaticObjectMethod(android.provider.Browser.staticClass, global::android.provider.Browser._getAllBookmarks10436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _getAllVisitedUrls10437;
		public static global::android.database.Cursor getAllVisitedUrls(android.content.ContentResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallStaticObjectMethod(android.provider.Browser.staticClass, global::android.provider.Browser._getAllVisitedUrls10437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _updateVisitedHistory10438;
		public static void updateVisitedHistory(android.content.ContentResolver arg0, java.lang.String arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, global::android.provider.Browser._updateVisitedHistory10438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _truncateHistory10439;
		public static void truncateHistory(android.content.ContentResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, global::android.provider.Browser._truncateHistory10439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _canClearHistory10440;
		public static bool canClearHistory(android.content.ContentResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.provider.Browser.staticClass, global::android.provider.Browser._canClearHistory10440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearHistory10441;
		public static void clearHistory(android.content.ContentResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, global::android.provider.Browser._clearHistory10441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deleteHistoryTimeFrame10442;
		public static void deleteHistoryTimeFrame(android.content.ContentResolver arg0, long arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, global::android.provider.Browser._deleteHistoryTimeFrame10442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _deleteFromHistory10443;
		public static void deleteFromHistory(android.content.ContentResolver arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, global::android.provider.Browser._deleteFromHistory10443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addSearchUrl10444;
		public static void addSearchUrl(android.content.ContentResolver arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, global::android.provider.Browser._addSearchUrl10444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clearSearches10445;
		public static void clearSearches(android.content.ContentResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, global::android.provider.Browser._clearSearches10445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestAllIcons10446;
		public static void requestAllIcons(android.content.ContentResolver arg0, java.lang.String arg1, android.webkit.WebIconDatabase.IconListener arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, global::android.provider.Browser._requestAllIcons10446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _Browser10447;
		public Browser()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.Browser.staticClass, global::android.provider.Browser._Browser10447);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _BOOKMARKS_URI10448;
		public static global::android.net.Uri BOOKMARKS_URI
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.Browser.staticClass, _BOOKMARKS_URI10448)) as android.net.Uri;
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
		internal static global::MonoJavaBridge.FieldId _HISTORY_PROJECTION10452;
		public static global::java.lang.String[] HISTORY_PROJECTION
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetStaticObjectField(global::android.provider.Browser.staticClass, _HISTORY_PROJECTION10452)) as java.lang.String[];
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
		internal static global::MonoJavaBridge.FieldId _TRUNCATE_HISTORY_PROJECTION10460;
		public static global::java.lang.String[] TRUNCATE_HISTORY_PROJECTION
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetStaticObjectField(global::android.provider.Browser.staticClass, _TRUNCATE_HISTORY_PROJECTION10460)) as java.lang.String[];
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
		internal static global::MonoJavaBridge.FieldId _SEARCHES_URI10463;
		public static global::android.net.Uri SEARCHES_URI
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.Browser.staticClass, _SEARCHES_URI10463)) as android.net.Uri;
			}
		}
		internal static global::MonoJavaBridge.FieldId _SEARCHES_PROJECTION10464;
		public static global::java.lang.String[] SEARCHES_PROJECTION
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetStaticObjectField(global::android.provider.Browser.staticClass, _SEARCHES_PROJECTION10464)) as java.lang.String[];
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
			global::android.provider.Browser._saveBookmark10434 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "saveBookmark", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.provider.Browser._sendString10435 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "sendString", "(Landroid/content/Context;Ljava/lang/String;)V");
			global::android.provider.Browser._getAllBookmarks10436 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "getAllBookmarks", "(Landroid/content/ContentResolver;)Landroid/database/Cursor;");
			global::android.provider.Browser._getAllVisitedUrls10437 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "getAllVisitedUrls", "(Landroid/content/ContentResolver;)Landroid/database/Cursor;");
			global::android.provider.Browser._updateVisitedHistory10438 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "updateVisitedHistory", "(Landroid/content/ContentResolver;Ljava/lang/String;Z)V");
			global::android.provider.Browser._truncateHistory10439 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "truncateHistory", "(Landroid/content/ContentResolver;)V");
			global::android.provider.Browser._canClearHistory10440 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "canClearHistory", "(Landroid/content/ContentResolver;)Z");
			global::android.provider.Browser._clearHistory10441 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "clearHistory", "(Landroid/content/ContentResolver;)V");
			global::android.provider.Browser._deleteHistoryTimeFrame10442 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "deleteHistoryTimeFrame", "(Landroid/content/ContentResolver;JJ)V");
			global::android.provider.Browser._deleteFromHistory10443 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "deleteFromHistory", "(Landroid/content/ContentResolver;Ljava/lang/String;)V");
			global::android.provider.Browser._addSearchUrl10444 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "addSearchUrl", "(Landroid/content/ContentResolver;Ljava/lang/String;)V");
			global::android.provider.Browser._clearSearches10445 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "clearSearches", "(Landroid/content/ContentResolver;)V");
			global::android.provider.Browser._requestAllIcons10446 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "requestAllIcons", "(Landroid/content/ContentResolver;Ljava/lang/String;Landroid/webkit/WebIconDatabase$IconListener;)V");
			global::android.provider.Browser._Browser10447 = @__env.GetMethodIDNoThrow(global::android.provider.Browser.staticClass, "<init>", "()V");
			global::android.provider.Browser._BOOKMARKS_URI10448 = @__env.GetStaticFieldIDNoThrow(global::android.provider.Browser.staticClass, "BOOKMARKS_URI", "Landroid/net/Uri;");
			global::android.provider.Browser._HISTORY_PROJECTION10452 = @__env.GetStaticFieldIDNoThrow(global::android.provider.Browser.staticClass, "HISTORY_PROJECTION", "[Ljava/lang/String;");
			global::android.provider.Browser._TRUNCATE_HISTORY_PROJECTION10460 = @__env.GetStaticFieldIDNoThrow(global::android.provider.Browser.staticClass, "TRUNCATE_HISTORY_PROJECTION", "[Ljava/lang/String;");
			global::android.provider.Browser._SEARCHES_URI10463 = @__env.GetStaticFieldIDNoThrow(global::android.provider.Browser.staticClass, "SEARCHES_URI", "Landroid/net/Uri;");
			global::android.provider.Browser._SEARCHES_PROJECTION10464 = @__env.GetStaticFieldIDNoThrow(global::android.provider.Browser.staticClass, "SEARCHES_PROJECTION", "[Ljava/lang/String;");
		}
	}
}
