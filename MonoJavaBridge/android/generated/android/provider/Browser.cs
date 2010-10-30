namespace android.provider
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Browser : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Browser(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class BookmarkColumns : java.lang.Object, BaseColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected BookmarkColumns(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public BookmarkColumns() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Browser.BookmarkColumns._m0.native == global::System.IntPtr.Zero)
					global::android.provider.Browser.BookmarkColumns._m0 = @__env.GetMethodIDNoThrow(global::android.provider.Browser.BookmarkColumns.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.Browser.BookmarkColumns.staticClass, global::android.provider.Browser.BookmarkColumns._m0);
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
			static BookmarkColumns()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.Browser.BookmarkColumns.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/Browser$BookmarkColumns"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class SearchColumns : java.lang.Object, BaseColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected SearchColumns(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public SearchColumns() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Browser.SearchColumns._m0.native == global::System.IntPtr.Zero)
					global::android.provider.Browser.SearchColumns._m0 = @__env.GetMethodIDNoThrow(global::android.provider.Browser.SearchColumns.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.Browser.SearchColumns.staticClass, global::android.provider.Browser.SearchColumns._m0);
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
			static SearchColumns()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.Browser.SearchColumns.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/Browser$SearchColumns"));
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static void saveBookmark(android.content.Context arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.provider.Browser._m0.native == global::System.IntPtr.Zero)
				global::android.provider.Browser._m0 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "saveBookmark", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, global::android.provider.Browser._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static void sendString(android.content.Context arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.provider.Browser._m1.native == global::System.IntPtr.Zero)
				global::android.provider.Browser._m1 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "sendString", "(Landroid/content/Context;Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, global::android.provider.Browser._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::android.database.Cursor getAllBookmarks(android.content.ContentResolver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.provider.Browser._m2.native == global::System.IntPtr.Zero)
				global::android.provider.Browser._m2 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "getAllBookmarks", "(Landroid/content/ContentResolver;)Landroid/database/Cursor;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallStaticObjectMethod(android.provider.Browser.staticClass, global::android.provider.Browser._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.Cursor;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::android.database.Cursor getAllVisitedUrls(android.content.ContentResolver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.provider.Browser._m3.native == global::System.IntPtr.Zero)
				global::android.provider.Browser._m3 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "getAllVisitedUrls", "(Landroid/content/ContentResolver;)Landroid/database/Cursor;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallStaticObjectMethod(android.provider.Browser.staticClass, global::android.provider.Browser._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.Cursor;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static void updateVisitedHistory(android.content.ContentResolver arg0, java.lang.String arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.provider.Browser._m4.native == global::System.IntPtr.Zero)
				global::android.provider.Browser._m4 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "updateVisitedHistory", "(Landroid/content/ContentResolver;Ljava/lang/String;Z)V");
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, global::android.provider.Browser._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static void truncateHistory(android.content.ContentResolver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.provider.Browser._m5.native == global::System.IntPtr.Zero)
				global::android.provider.Browser._m5 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "truncateHistory", "(Landroid/content/ContentResolver;)V");
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, global::android.provider.Browser._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static bool canClearHistory(android.content.ContentResolver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.provider.Browser._m6.native == global::System.IntPtr.Zero)
				global::android.provider.Browser._m6 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "canClearHistory", "(Landroid/content/ContentResolver;)Z");
			return @__env.CallStaticBooleanMethod(android.provider.Browser.staticClass, global::android.provider.Browser._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static void clearHistory(android.content.ContentResolver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.provider.Browser._m7.native == global::System.IntPtr.Zero)
				global::android.provider.Browser._m7 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "clearHistory", "(Landroid/content/ContentResolver;)V");
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, global::android.provider.Browser._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static void deleteHistoryTimeFrame(android.content.ContentResolver arg0, long arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.provider.Browser._m8.native == global::System.IntPtr.Zero)
				global::android.provider.Browser._m8 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "deleteHistoryTimeFrame", "(Landroid/content/ContentResolver;JJ)V");
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, global::android.provider.Browser._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static void deleteFromHistory(android.content.ContentResolver arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.provider.Browser._m9.native == global::System.IntPtr.Zero)
				global::android.provider.Browser._m9 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "deleteFromHistory", "(Landroid/content/ContentResolver;Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, global::android.provider.Browser._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static void addSearchUrl(android.content.ContentResolver arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.provider.Browser._m10.native == global::System.IntPtr.Zero)
				global::android.provider.Browser._m10 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "addSearchUrl", "(Landroid/content/ContentResolver;Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, global::android.provider.Browser._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static void clearSearches(android.content.ContentResolver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.provider.Browser._m11.native == global::System.IntPtr.Zero)
				global::android.provider.Browser._m11 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "clearSearches", "(Landroid/content/ContentResolver;)V");
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, global::android.provider.Browser._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static void requestAllIcons(android.content.ContentResolver arg0, java.lang.String arg1, android.webkit.WebIconDatabase.IconListener arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.provider.Browser._m12.native == global::System.IntPtr.Zero)
				global::android.provider.Browser._m12 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Browser.staticClass, "requestAllIcons", "(Landroid/content/ContentResolver;Ljava/lang/String;Landroid/webkit/WebIconDatabase$IconListener;)V");
			@__env.CallStaticVoidMethod(android.provider.Browser.staticClass, global::android.provider.Browser._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public static void requestAllIcons(android.content.ContentResolver arg0, java.lang.String arg1, global::android.webkit.WebIconDatabase.IconListenerDelegate arg2)
		{
			requestAllIcons(arg0, arg1, (global::android.webkit.WebIconDatabase.IconListenerDelegateWrapper)arg2);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public Browser() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.provider.Browser._m13.native == global::System.IntPtr.Zero)
				global::android.provider.Browser._m13 = @__env.GetMethodIDNoThrow(global::android.provider.Browser.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.Browser.staticClass, global::android.provider.Browser._m13);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _BOOKMARKS_URI4068;
		public static global::android.net.Uri BOOKMARKS_URI
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.Browser.staticClass, _BOOKMARKS_URI4068)) as android.net.Uri;
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
		internal static global::MonoJavaBridge.FieldId _HISTORY_PROJECTION4072;
		public static global::java.lang.String[] HISTORY_PROJECTION
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetStaticObjectField(global::android.provider.Browser.staticClass, _HISTORY_PROJECTION4072)) as java.lang.String[];
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
		internal static global::MonoJavaBridge.FieldId _TRUNCATE_HISTORY_PROJECTION4080;
		public static global::java.lang.String[] TRUNCATE_HISTORY_PROJECTION
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetStaticObjectField(global::android.provider.Browser.staticClass, _TRUNCATE_HISTORY_PROJECTION4080)) as java.lang.String[];
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
		internal static global::MonoJavaBridge.FieldId _SEARCHES_URI4083;
		public static global::android.net.Uri SEARCHES_URI
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.Browser.staticClass, _SEARCHES_URI4083)) as android.net.Uri;
			}
		}
		internal static global::MonoJavaBridge.FieldId _SEARCHES_PROJECTION4084;
		public static global::java.lang.String[] SEARCHES_PROJECTION
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetStaticObjectField(global::android.provider.Browser.staticClass, _SEARCHES_PROJECTION4084)) as java.lang.String[];
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
		static Browser()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.provider.Browser.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/Browser"));
			global::android.provider.Browser._BOOKMARKS_URI4068 = @__env.GetStaticFieldIDNoThrow(global::android.provider.Browser.staticClass, "BOOKMARKS_URI", "Landroid/net/Uri;");
			global::android.provider.Browser._HISTORY_PROJECTION4072 = @__env.GetStaticFieldIDNoThrow(global::android.provider.Browser.staticClass, "HISTORY_PROJECTION", "[Ljava/lang/String;");
			global::android.provider.Browser._TRUNCATE_HISTORY_PROJECTION4080 = @__env.GetStaticFieldIDNoThrow(global::android.provider.Browser.staticClass, "TRUNCATE_HISTORY_PROJECTION", "[Ljava/lang/String;");
			global::android.provider.Browser._SEARCHES_URI4083 = @__env.GetStaticFieldIDNoThrow(global::android.provider.Browser.staticClass, "SEARCHES_URI", "Landroid/net/Uri;");
			global::android.provider.Browser._SEARCHES_PROJECTION4084 = @__env.GetStaticFieldIDNoThrow(global::android.provider.Browser.staticClass, "SEARCHES_PROJECTION", "[Ljava/lang/String;");
		}
		internal static void InitJNI()
		{
		}
	}
}
